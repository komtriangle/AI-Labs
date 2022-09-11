/* file "JSONParse.cs" */

/* Copyright 2012-2018 SoundHound, Incorporated.  All rights reserved. */

using System;
using System.IO;
using System.Diagnostics;
using System.Numerics;
using System.Text;


public class JSONParse
  {
    public class JSONTextReaderTextSource : JSONTextSource
      {
        private TextReader input;
        private string source_file_name;
        private bool have_one_waiting;
        private char waiting;

        public JSONTextReaderTextSource(TextReader init_input, string file_name)
          {
            input = init_input;
            source_file_name = file_name;
            have_one_waiting = false;
          }

        public override char getchar()
          {
            if (have_one_waiting)
              {
                have_one_waiting = false;
                return waiting;
              }
            else
              {
                int result = input.Read();
                if (result == -1)
                    return (char)0;
                return (char)result;
              }
          }
        public override void ungetchar(char to_unget)
          {
            Debug.Assert(!have_one_waiting);
            waiting = to_unget;
            have_one_waiting = true;
          }
        public override string file_name()  { return source_file_name; }
      }

    public class JSONStringTextSource : JSONTextSource
      {
        private char[] text;
        private int current;
        private string source_file_name;

        public JSONStringTextSource(string init_text, string file_name)
          {
            Debug.Assert(init_text != null);
            text = init_text.ToCharArray();
            current = 0;
            source_file_name = file_name;
          }

        public override char getchar()
          {
            if (current >= text.Length)
                return (char)0;
            char result = text[current];
            ++current;
            return result;
          }
        public override void ungetchar(char to_unget)
          {
            Debug.Assert(to_unget != 0);
            Debug.Assert(0 < current);
            --current;
            Debug.Assert(current < text.Length);
            Debug.Assert(text[current] == to_unget);
          }
        public override string file_name()  { return source_file_name; }
      }

    private class JSONParser
      {
        private JSONTextSource source;
        private long line_num;
        private long column_num;
        private long last_line_num;
        private long last_column_num;
        private long last_line_column_num;

        private void skip_whitespace()
          {
            while (true)
              {
                char inchar = getchar();
                if (inchar == 0)
                    return;
                switch (inchar)
                  {
                    case ' ':
                    case '\t':
                    case '\n':
                    case '\f':
                    case '\r':
                        break;
                    default:
                        ungetchar(inchar);
                        return;
                  }
              }
          }

        private void do_exponent(BigInteger mantissa_whole_part,
                BigInteger mantissa_fraction_numerator,
                long mantissa_fraction_digit_count, JSONHandler handler)
          {
            char inchar = getchar();
            bool negate = false;
            if (inchar == '-')
              {
                negate = true;
              }
            else if (inchar == '+')
              {
                /* Do nothing. */
              }
            else if (inchar != 0)
              {
                ungetchar(inchar);
              }

            char first_digit = getchar();
            if ((first_digit < '0') || (first_digit > '9'))
              {
                error("In a JSON number, there was no digit in the exponent " +
                      "part though there was an `e'.\n");
                return;
              }
            if (first_digit != 0)
                ungetchar(first_digit);

            BigInteger exponent = parse_decimal_digits().value;

            if (negate)
                exponent = -exponent;

            handler.number_value(mantissa_whole_part,
                    mantissa_fraction_numerator,
                    (int)mantissa_fraction_digit_count, exponent);
          }

        private class ValueAndDigitCount
          {
            public ValueAndDigitCount(BigInteger init_value,
                                      long init_digit_count)
              {
                value = init_value;
                digit_count = init_digit_count;
              }

            public BigInteger value;
            public long digit_count;
          }

        private ValueAndDigitCount parse_decimal_digits()
          {
            char inchar = getchar();
            Debug.Assert((inchar >= '0') && (inchar <= '9'));

            BigInteger result = (inchar - '0');
            long digit_count = 1;
            while (true)
              {
                char digit = getchar();
                if ((digit < '0') || (digit > '9'))
                  {
                    if (digit != 0)
                        ungetchar(digit);
                    return new ValueAndDigitCount(result, digit_count);
                  }

                ++digit_count;

                BigInteger product = result * 10;
                result = product + (digit - '0');
              }
          }

        private char getchar()
          {
            char result = source.getchar();
            last_line_num = line_num;
            last_column_num = column_num;
            if (result == '\n')
              {
                ++line_num;
                last_line_column_num = column_num;
                column_num = 1;
              }
            else
              {
                ++column_num;
              }
            return result;
          }
        private void ungetchar(char to_unget)
          {
            if (to_unget == '\n')
              {
                Debug.Assert(line_num > 1);
                --line_num;
                Debug.Assert(column_num == 1);
                column_num = last_line_column_num;
              }
            else
              {
                Debug.Assert(column_num > 1);
                --column_num;
              }
            source.ungetchar(to_unget);
          }
        private void error(string format, params Object[] arguments)
          {
            string file_name = source.file_name();
            StringBuilder builder = new StringBuilder(120);
            builder.AppendFormat("Error: [{0}:{1}:{2}]: ", file_name,
                                 last_line_num, last_column_num);
            builder.AppendFormat(format, arguments);
            throw new FormatException(builder.ToString());
          }

        public JSONParser(JSONTextSource init_source)
          {
            source = init_source;
            line_num = 1;
            column_num = 1;
          }

        private class JSONLabelHandler : JSONHandler
          {
            public string label;
            public override void string_value(string to_write)
              { label = to_write; }
          }

        public void parse_value(JSONHandler handler)
          {
            skip_whitespace();

            char inchar = getchar();
            if (inchar == 0)
              {
                error("Expected a value, found end-of-input.\n");
                return;
              }

            switch (inchar)
              {
                case '\"':
                  {
                    StringBuilder buffer = new StringBuilder();
                    while (true)
                      {
                        char inchar2 = getchar();
                        if (inchar2 == 0)
                          {
                            error("End-of-input was encountered in a string " +
                                  "value.\n");
                            return;
                          }

                        switch (inchar2)
                          {
                            case '\"':
                              {
                                handler.string_value(buffer.ToString());
                                return;
                              }
                            case '\\':
                              {
                                char nextchar = getchar();
                                switch (nextchar)
                                  {
                                    case '\"':
                                      {
                                        buffer.Append('\"');
                                        break;
                                      }
                                    case '\\':
                                      {
                                        buffer.Append('\\');
                                        break;
                                      }
                                    case '/':
                                      {
                                        buffer.Append('/');
                                        break;
                                      }
                                    case 'b':
                                      {
                                        buffer.Append('\b');
                                        break;
                                      }
                                    case 'f':
                                      {
                                        buffer.Append('\f');
                                        break;
                                      }
                                    case 'n':
                                      {
                                        buffer.Append('\n');
                                        break;
                                      }
                                    case 'r':
                                      {
                                        buffer.Append('\r');
                                        break;
                                      }
                                    case 't':
                                      {
                                        buffer.Append('\t');
                                        break;
                                      }
                                    case 'u':
                                      {
                                        int code_point = 0;
                                        for (int digit_num = 0; digit_num < 4;
                                             ++digit_num)
                                          {
                                            char digitchar = getchar();
                                            if ((digitchar >= '0') &&
                                                (digitchar <= '9'))
                                              {
                                                digitchar -= '0';
                                              }
                                            else if ((digitchar >= 'a') &&
                                                     (digitchar <= 'f'))
                                              {
                                                digitchar -= (char)('a' - 0xa);
                                              }
                                            else if ((digitchar >= 'A') &&
                                                     (digitchar <= 'F'))
                                              {
                                                digitchar -= (char)('A' - 0xa);
                                              }
                                            else
                                              {
                                                error("{0} was encountered in" +
                                                      " a hex escape sequence" +
                                                      " of a string value.\n",
                                                      ((digitchar == 0) ?
                                                       "End-of-input" :
                                                       "A non-hex digit"));
                                                return;
                                              }
                                            code_point *= 16;
                                            code_point += digitchar;
                                          }
                                        Debug.Assert(code_point >= 0);
                                        Debug.Assert(code_point <= 0xffff);
                                        if (code_point == 0)
                                          {
                                            buffer.Append('\0');
                                            break;
                                          }
                                        if ((code_point >= 0xd800) &&
                                            (code_point < 0xe000))
                                          {
                                            if (code_point >= 0xdc00)
                                              {
                                                error("A starting hex escape " +
                                                      "sequence specified a " +
                                                      "value (0x{0:x4}) that " +
                                                      "is not a legal " +
                                                      "starting UTF-16 code " +
                                                      "unit.\n", code_point);
                                                return;
                                              }

                                            char check = getchar();
                                            if (check != '\\')
                                              {
                                                error("A lead surrogate hex " +
                                                      "escape sequence " +
                                                      "(\\u{0:x4}) was not " +
                                                      "followed by an escape " +
                                                      "sequence.\n",
                                                      code_point);
                                                return;
                                              }

                                            check = getchar();
                                            if (check != 'u')
                                              {
                                                error("A lead surrogate hex " +
                                                      "escape sequence " +
                                                      "(\\u{0:x4}) was not " +
                                                      "followed by a hex " +
                                                      "escape sequence.\n",
                                                      code_point);
                                                return;
                                              }

                                            int second_code_unit = 0;
                                            for (int digit_num = 0;
                                                 digit_num < 4; ++digit_num)
                                              {
                                                char digitchar = getchar();
                                                if ((digitchar >= '0') &&
                                                    (digitchar <= '9'))
                                                  {
                                                    digitchar -= '0';
                                                  }
                                                else if ((digitchar >= 'a') &&
                                                         (digitchar <= 'f'))
                                                  {
                                                    digitchar -=
                                                            (char)('a' - 0xa);
                                                  }
                                                else if ((digitchar >= 'A') &&
                                                         (digitchar <= 'F'))
                                                  {
                                                    digitchar -=
                                                            (char)('A' - 0xa);
                                                  }
                                                else
                                                  {
                                                    error("{0} was " +
                                                          "encountered in a " +
                                                          "hex escape " +
                                                          "sequence of a " +
                                                          "string value.\n",
                                                          ((digitchar == 0) ?
                                                           "End-of-input" :
                                                           "A non-hex digit"));
                                                    return;
                                                  }
                                                second_code_unit *= 16;
                                                second_code_unit += digitchar;
                                              }
                                            Debug.Assert(second_code_unit >= 0);
                                            Debug.Assert(
                                                    second_code_unit <= 0xffff);

                                            if ((second_code_unit < 0xdc00) ||
                                                (second_code_unit >= 0xe000))
                                              {
                                                error("A lead surrogate hex " +
                                                      "escape sequence " +
                                                      "(\\u{0:x4}) was not " +
                                                      "followed by a trail " +
                                                      "surrogate hex escape " +
                                                      "sequence.\n",
                                                      code_point);
                                                return;
                                              }

                                            code_point =
                                                    (((code_point - 0xd800) <<
                                                      10) |
                                                     (second_code_unit -
                                                      0xdc00)) + 0x10000;
                                          }
                                        buffer.Append(char.ConvertFromUtf32(
                                                code_point));
                                        break;
                                      }
                                    case (char)0:
                                    default:
                                      {
                                        error("{0} was encountered in an " +
                                              "escape sequence of a string " +
                                              "value.\n",
                                              ((nextchar == 0) ? "End-of-input"
                                               : "An invalid character"));
                                        return;
                                      }
                                  }
                                break;
                              }
                            default:
                              {
                                buffer.Append(inchar2);
                                break;
                              }
                          }
                      }
                  }
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '-':
                  {
                    bool negate = false;
                    if (inchar == '-')
                      {
                        negate = true;
                        inchar = getchar();
                        switch (inchar)
                          {
                            case '0':
                            case '1':
                            case '2':
                            case '3':
                            case '4':
                            case '5':
                            case '6':
                            case '7':
                            case '8':
                            case '9':
                                break;
                            default:
                                error("A non-digit was encountered following " +
                                      "a minus sign in an integer value.\n");
                                return;
                          }
                      }

                    Debug.Assert((inchar >= '0') && (inchar <= '9'));

                    BigInteger the_bi;
                    if (inchar == '0')
                      {
                        the_bi = 0;
                      }
                    else
                      {
                        ungetchar(inchar);
                        the_bi = parse_decimal_digits().value;
                      }

                    if (negate)
                        the_bi = -the_bi;

                    char next = getchar();
                    switch (next)
                      {
                        case '.':
                          {
                            char first_digit = getchar();
                            if ((first_digit < '0') || (first_digit > '9'))
                              {
                                error("In a JSON number, there was no digit " +
                                      "after the decimal point.\n");
                                return;
                              }
                            if (first_digit != 0)
                                ungetchar(first_digit);
                            ValueAndDigitCount fraction =
                                    parse_decimal_digits();

                            if (negate && the_bi == 0)
                              {
                                fraction.value = -fraction.value;
                              }

                            char trailer = getchar();
                            if ((trailer == 'e') || (trailer == 'E'))
                              {
                                do_exponent(the_bi, fraction.value,
                                            fraction.digit_count, handler);
                                return;
                              }
                            if (trailer != 0)
                                ungetchar(trailer);
                            handler.number_value(the_bi, fraction.value,
                                    (int)fraction.digit_count, 0);
                            return;
                          }
                        case 'e':
                        case 'E':
                          {
                            do_exponent(the_bi, 0, 0, handler);
                            return;
                          }
                        default:
                          {
                            ungetchar(next);
                            handler.number_value(the_bi);
                            return;
                          }
                        case (char)0:
                          {
                            handler.number_value(the_bi);
                            return;
                          }
                      }
                  }
                case 't':
                  {
                    inchar = getchar();
                    if (inchar != 'r')
                      {
                        error("A partial true value was encountered as a JSON" +
                              " value.\n");
                        return;
                      }
                    inchar = getchar();
                    if (inchar != 'u')
                      {
                        error("A partial true value was encountered as a JSON" +
                              " value.\n");
                        return;
                      }
                    inchar = getchar();
                    if (inchar != 'e')
                      {
                        error("A partial true value was encountered as a JSON" +
                              " value.\n");
                        return;
                      }
                    handler.true_value();
                    return;
                  }
                case 'f':
                  {
                    inchar = getchar();
                    if (inchar != 'a')
                      {
                        error("A partial false value was encountered as a " +
                              "JSON value.\n");
                        return;
                      }
                    inchar = getchar();
                    if (inchar != 'l')
                      {
                        error("A partial false value was encountered as a " +
                              "JSON value.\n");
                        return;
                      }
                    inchar = getchar();
                    if (inchar != 's')
                      {
                        error("A partial false value was encountered as a " +
                              "JSON value.\n");
                        return;
                      }
                    inchar = getchar();
                    if (inchar != 'e')
                      {
                        error("A partial false value was encountered as a " +
                              "JSON value.\n");
                        return;
                      }
                    handler.false_value();
                    return;
                  }
                case 'n':
                  {
                    inchar = getchar();
                    if (inchar != 'u')
                      {
                        error("A partial null value was encountered as a JSON" +
                              " value.\n");
                        return;
                      }
                    inchar = getchar();
                    if (inchar != 'l')
                      {
                        error("A partial null value was encountered as a JSON" +
                              " value.\n");
                        return;
                      }
                    inchar = getchar();
                    if (inchar != 'l')
                      {
                        error("A partial null value was encountered as a JSON" +
                              " value.\n");
                        return;
                      }
                    handler.null_value();
                    return;
                  }
                case '{':
                  {
                    handler.start_object();

                    skip_whitespace();
                    char next = getchar();
                    if (next == '}')
                      {
                        handler.finish_object();
                        return;
                      }
                    if (next != 0)
                        ungetchar(next);

                    while (true)
                      {
                        char quote = getchar();
                        if (quote != '\"')
                          {
                            error("A non-string was found where the label for" +
                                  " an object item was expected.\n");
                            return;
                          }
                        ungetchar(quote);

                        JSONLabelHandler label_handler = new JSONLabelHandler();
                        parse_value(label_handler);
                        handler.start_pair(label_handler.label);

                        skip_whitespace();
                        char colon = getchar();
                        if (colon != ':')
                          {
                            error("Expected a colon but didn't find it.\n");
                            return;
                          }

                        parse_value(handler);

                        skip_whitespace();
                        char comma = getchar();
                        if (comma == '}')
                          {
                            handler.finish_object();
                            return;
                          }
                        if (comma != ',')
                          {
                            error("Expected a comma or right curly brace but " +
                                  "didn't find it.\n");
                            return;
                          }

                        skip_whitespace();
                      }
                  }
                case '[':
                  {
                    skip_whitespace();

                    handler.start_array();
                    char next = getchar();
                    if (next == ']')
                      {
                        handler.finish_array();
                        return;
                      }
                    if (next != 0)
                        ungetchar(next);

                    while (true)
                      {
                        parse_value(handler);

                        skip_whitespace();
                        char comma = getchar();
                        if (comma == ']')
                          {
                            handler.finish_array();
                            return;
                          }
                        if (comma != ',')
                          {
                            error("Expected a comma or right square brace but" +
                                  " didn't find it.\n");
                            return;
                          }
                      }
                  }
                default:
                  {
                    error("Expected a JSON value, found `{0}'.\n", inchar);
                    return;
                  }
              }
          }
      }

    public static void parse_json_value(JSONTextSource source,
                                        JSONHandler handler)
      {
        (new JSONParser(source)).parse_value(handler);
      }

    public static void parse_json_value(TextReader input, string file_name,
                                        JSONHandler handler)
      {
        parse_json_value(new JSONTextReaderTextSource(input, file_name),
                         handler);
      }

    public static void parse_json_value(string text, string file_name,
                                        JSONHandler handler)
      {
        parse_json_value(new JSONStringTextSource(text, file_name), handler);
      }
  }
