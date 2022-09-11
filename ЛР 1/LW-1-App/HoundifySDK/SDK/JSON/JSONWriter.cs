/* file "JSONWriter.cs" */

/* Copyright 2012-2018 SoundHound, Incorporated.  All rights reserved. */

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Diagnostics;


public abstract class JSONWriter : JSONHandler
  {
    public enum whitespace_style { WHITESPACE_NONE, WHITESPACE_VERBOSE_4 };

    private enum which_compound { OBJECT, ARRAY };
    private List<which_compound> compound_stack;
    private bool first;
    private bool in_pair;
    private whitespace_style style;
    private bool ascii_only;

    private void start_value(string separator)
      {
        if (compound_stack.Count > 0)
          {
            switch (compound_stack[compound_stack.Count - 1])
              {
                case which_compound.OBJECT:
                    Debug.Assert(in_pair);
                    in_pair = false;
                    switch (style)
                      {
                        case whitespace_style.WHITESPACE_NONE:
                            break;
                        case whitespace_style.WHITESPACE_VERBOSE_4:
                            send_raw_text(separator);
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                    break;
                case which_compound.ARRAY:
                    if (!first)
                        send_raw_text(",");
                    else
                        first = false;
                    switch (style)
                      {
                        case whitespace_style.WHITESPACE_NONE:
                            break;
                        case whitespace_style.WHITESPACE_VERBOSE_4:
                            send_raw_text("\n");
                            for (int item_num = 0;
                                 item_num < compound_stack.Count; ++item_num)
                              {
                                send_raw_text("    ");
                              }
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
      }

    private void start_value()
      {
        start_value(" ");
      }

    private void send_quoted_string(string data)
      {
        send_raw_text("\"");
        char[] data_chars = data.ToCharArray();
        int follow = 0;
        while (follow < data_chars.Length)
          {
            switch (data_chars[follow])
              {
                case '\"':
                  {
                    send_raw_text("\\\"");
                    ++follow;
                    break;
                  }
                case '\\':
                  {
                    send_raw_text("\\\\");
                    ++follow;
                    break;
                  }
                case '\b':
                  {
                    send_raw_text("\\b");
                    ++follow;
                    break;
                  }
                case '\f':
                  {
                    send_raw_text("\\f");
                    ++follow;
                    break;
                  }
                case '\n':
                  {
                    send_raw_text("\\n");
                    ++follow;
                    break;
                  }
                case '\r':
                  {
                    send_raw_text("\\r");
                    ++follow;
                    break;
                  }
                case '\t':
                  {
                    send_raw_text("\\t");
                    ++follow;
                    break;
                  }
                default:
                  {
                    if ((data_chars[follow] >= ' ') &&
                        ((!ascii_only) || (data_chars[follow] <= '~')))
                      {
                        if (data_chars[follow] <= '~')
                          {
                            send_raw_text(data.Substring(follow, 1));
                            ++follow;
                          }
                        else
                          {
                            int code_point;
                            int length;
                            if ((data_chars[follow] >= 0xd800) &&
                                (data_chars[follow] <= 0xdbff) &&
                                (follow + 1 < data_chars.Length))
                              {
                                code_point =
                                        (((((int)(data_chars[follow])) -
                                           0xd800) << 10) |
                                         (data_chars[follow + 1] - 0xdc00)) +
                                        0x10000;
                                length = 2;
                              }
                            else
                              {
                                code_point = data_chars[follow];
                                length = 1;
                              }
                            switch (code_point)
                              {
                                case 0x00a0:
                                case 0x1680:
                                case 0x2000:
                                case 0x2001:
                                case 0x2002:
                                case 0x2003:
                                case 0x2004:
                                case 0x2005:
                                case 0x2006:
                                case 0x2007:
                                case 0x2008:
                                case 0x2009:
                                case 0x200a:
                                case 0x202f:
                                case 0x205f:
                                case 0x3000:
                                    /* These are various sorts of spaces.  Since
                                     * it's hard to distinguish them visually as
                                     * displayed by most systems, we escape them
                                     * for readability. */
                                    code_point = (int)data_chars[follow];
                                    send_raw_text(
                                            string.Format("\\u{0:x4}",
                                                          code_point));
                                    ++follow;
                                    break;
                                default:
                                    send_raw_text(
                                            data.Substring(follow, length));
                                    follow += length;
                                    break;
                              }
                          }
                      }
                    else
                      {
                        send_raw_text(
                                string.Format("\\u{0:x4}",
                                              (int)data_chars[follow]));
                        ++follow;
                      }
                    break;
                  }
              }
          }
        send_raw_text("\"");
      }

    public override void true_value()
      {
        start_value();
        send_raw_text("true");
      }

    public override void false_value()
      {
        start_value();
        send_raw_text("false");
      }

    public override void boolean_value(bool to_write)
      {
        if (to_write)
            true_value();
        else
            false_value();
      }

    public override void null_value()
      {
        start_value();
        send_raw_text("null");
      }

    public override void string_value(string to_write)
      {
        if (to_write == null)
          {
            null_value();
          }
        else
          {
            start_value();
            send_quoted_string(to_write);
          }
      }

    public override void number_value(int to_write)
      {
        start_value();
        send_raw_text(to_write.ToString());
      }

    public override void number_value(long to_write)
      {
        start_value();
        send_raw_text(to_write.ToString());
      }

    public override void number_value(BigInteger to_write)
      {
        start_value();
        send_raw_text(to_write.ToString());
      }

    public override void number_value(double to_write, int precision)
      {
        start_value();
        string output =
                string.Format(System.Globalization.CultureInfo.InvariantCulture,
                    string.Format(System.Globalization.CultureInfo.InvariantCulture,
                        "{{0:e{0}}}", precision), to_write);
        if (output.EndsWith("e+00"))
            output = output.Substring(0, output.Length - 4);
        send_raw_text(output);
      }

    public override void number_value(BigInteger mantissa_whole_part,
            BigInteger mantissa_fraction_numerator,
            int mantissa_fraction_digit_count, BigInteger exponent)
      {
        start_value();

        if (mantissa_fraction_numerator < 0)
          {
            mantissa_fraction_numerator = -mantissa_fraction_numerator;
            if (mantissa_whole_part == 0)
              {
                send_raw_text("-");
              }
          }
        Debug.Assert(mantissa_fraction_numerator >= 0);

        send_raw_text(mantissa_whole_part.ToString());
        if (mantissa_fraction_digit_count > 0)
          {
            send_raw_text(".");
            string non_zero_fraction = mantissa_fraction_numerator.ToString();
            int non_zero_count = non_zero_fraction.Length;
            Debug.Assert(non_zero_count <= mantissa_fraction_digit_count);
            for (long pad = non_zero_count; pad < mantissa_fraction_digit_count;
                 ++pad)
              {
                send_raw_text("0");
              }
            send_raw_text(non_zero_fraction);
          }
        if (exponent != 0)
          {
            send_raw_text("e");
            if (exponent < 0)
              {
                send_raw_text("-");
                exponent = -exponent;
              }
            else
              {
                send_raw_text("+");
              }
            string exponent_digits = exponent.ToString();
            int exponent_space = exponent_digits.Length;
            Debug.Assert(exponent_space > 0);
            if (exponent_space < 2)
                send_raw_text("0");
            send_raw_text(exponent_digits);
          }
      }

    public override void number_value(string number_text)
      {
        start_value();

        if (!(is_valid_number_format(number_text)))
            throw new Exception("JSONWriter: illegal number format");

        send_raw_text(number_text);
      }

    public override void start_object()
      {
        switch (style)
          {
            case whitespace_style.WHITESPACE_NONE:
              {
                start_value("");
                break;
              }
            case whitespace_style.WHITESPACE_VERBOSE_4:
              {
                string separator = "\n";
                for (int item_num = 0; item_num < compound_stack.Count;
                     ++item_num)
                  {
                    separator += "    ";
                  }
                start_value(separator);
                send_raw_text("  ");
                break;
              }
            default:
              {
                Debug.Assert(false);
                break;
              }
          }

        send_raw_text("{");
        first = true;
        in_pair = false;
        compound_stack.Add(which_compound.OBJECT);
      }

    public override void start_pair(string name)
      {
        Debug.Assert(compound_stack.Count > 0);
        Debug.Assert(compound_stack[compound_stack.Count - 1] ==
                     which_compound.OBJECT);
        Debug.Assert(!in_pair);

        if (!first)
            send_raw_text(",");
        else
            first = false;

        switch (style)
          {
            case whitespace_style.WHITESPACE_NONE:
                break;
            case whitespace_style.WHITESPACE_VERBOSE_4:
                send_raw_text("\n");
                for (int item_num = 0; item_num < compound_stack.Count;
                     ++item_num)
                  {
                    send_raw_text("    ");
                  }
                break;
            default:
                Debug.Assert(false);
                break;
          }

        send_quoted_string(name);

        send_raw_text(":");

        in_pair = true;
      }

    public override void pair(string name, string new_value)
      {
        start_pair(name);
        string_value(new_value);
      }

    public override void pair(string name, bool value)
      {
        start_pair(name);
        boolean_value(value);
      }

    public override void pair(string name, int value)
      {
        start_pair(name);
        number_value(value);
      }

    public override void pair(string name, long value)
      {
        start_pair(name);
        number_value(value);
      }

    public override void pair(string name, double value, int precision)
      {
        start_pair(name);
        number_value(value, precision);
      }

    public override void finish_object()
      {
        Debug.Assert(compound_stack.Count > 0);
        Debug.Assert(compound_stack[compound_stack.Count - 1] ==
                     which_compound.OBJECT);
        Debug.Assert(!in_pair);

        compound_stack.RemoveAt(compound_stack.Count - 1);

        switch (style)
          {
            case whitespace_style.WHITESPACE_NONE:
                break;
            case whitespace_style.WHITESPACE_VERBOSE_4:
                send_raw_text("\n");
                for (int item_num = 0; item_num < compound_stack.Count;
                     ++item_num)
                  {
                    send_raw_text("    ");
                  }
                send_raw_text("  ");
                break;
            default:
                Debug.Assert(false);
                break;
          }

        send_raw_text("}");

        first = false;
        in_pair = false;
      }

    public override void start_array()
      {
        switch (style)
          {
            case whitespace_style.WHITESPACE_NONE:
              {
                start_value("");
                break;
              }
            case whitespace_style.WHITESPACE_VERBOSE_4:
              {
                string separator = "\n";
                for (int item_num = 0; item_num < compound_stack.Count;
                     ++item_num)
                  {
                    separator += "    ";
                  }
                start_value(separator);
                send_raw_text("  ");
                break;
              }
            default:
              {
                Debug.Assert(false);
                break;
              }
          }

        send_raw_text("[");
        first = true;
        compound_stack.Add(which_compound.ARRAY);
      }

    public override void finish_array()
      {
        Debug.Assert(compound_stack.Count > 0);
        Debug.Assert(compound_stack[compound_stack.Count - 1] ==
                     which_compound.ARRAY);

        compound_stack.RemoveAt(compound_stack.Count - 1);

        switch (style)
          {
            case whitespace_style.WHITESPACE_NONE:
                break;
            case whitespace_style.WHITESPACE_VERBOSE_4:
                send_raw_text("\n");
                for (int item_num = 0; item_num < compound_stack.Count;
                     ++item_num)
                  {
                    send_raw_text("    ");
                  }
                send_raw_text("  ");
                break;
            default:
                Debug.Assert(false);
                break;
          }

        send_raw_text("]");

        first = false;
        in_pair = false;
      }

    public void set_ascii_only(bool new_value)  { ascii_only = new_value; }

    public static bool is_valid_number_format(string number_text)
      {
        char[] chars = number_text.ToCharArray();
        int follow = 0;

        if (follow >= chars.Length)
            return false;

        if (chars[follow] == '-')
            ++follow;

        if (follow >= chars.Length)
            return false;

        if (chars[follow] == '0')
          {
            ++follow;
          }
        else if ((chars[follow] >= '1') && (chars[follow] <= '9'))
          {
            ++follow;
            while ((follow < chars.Length) && (chars[follow] >= '0') &&
                   (chars[follow] <= '9'))
              {
                ++follow;
              }
          }
        else
          {
            return false;
          }

        if ((follow < chars.Length) && (chars[follow] == '.'))
          {
            ++follow;
            if ((follow >= chars.Length) || (chars[follow] < '0') ||
                (chars[follow] > '9'))
              {
                return false;
              }
            ++follow;
            while ((follow < chars.Length) && (chars[follow] >= '0') &&
                   (chars[follow] <= '9'))
              {
                ++follow;
              }
          }

        if ((follow < chars.Length) &&
            ((chars[follow] == 'e') || (chars[follow] == 'E')))
          {
            ++follow;
            if ((follow < chars.Length) &&
                ((chars[follow] == '+') || (chars[follow] == '-')))
              {
                ++follow;
              }
            if ((follow >= chars.Length) || (chars[follow] < '0') ||
                (chars[follow] > '9'))
              {
                return false;
              }
            ++follow;
            while ((follow < chars.Length) && (chars[follow] >= '0') &&
                   (chars[follow] <= '9'))
              {
                ++follow;
              }
          }

        if (follow < chars.Length)
            return false;

        return true;
      }

    public static int compare_number_text_to_repeating_fraction(
            string left_number_text, bool right_mantissa_is_negative,
            string right_start_mantissa_digits,
            string right_repeat_mantissa_digits,
            bool right_exponent_is_negative, string right_exponent_digits)
      {
        Debug.Assert(left_number_text != null);
        Debug.Assert(right_start_mantissa_digits != null);
        Debug.Assert(right_repeat_mantissa_digits != null);
        Debug.Assert(right_exponent_digits != null);

        char[] left_chars = left_number_text.ToCharArray();
        char[] right_start_chars = right_start_mantissa_digits.ToCharArray();
        char[] right_repeat_chars = right_repeat_mantissa_digits.ToCharArray();
        char[] right_exponent_chars = right_exponent_digits.ToCharArray();

        bool left_is_zero = true;
        bool left_mantissa_is_negative = false;
        int left_exponent;
        int left_decimal_point = -1;
        int first_left_non_zero_mantissa_digit = -1;
          {
            int follow_left = 0;
            if (left_chars[follow_left] == '-')
              {
                left_mantissa_is_negative = true;
                ++follow_left;
              }
            while ((follow_left < left_chars.Length) &&
                   (left_chars[follow_left] != 'E') &&
                   (left_chars[follow_left] != 'e'))
              {
                Debug.Assert(((left_chars[follow_left] >= '0') &&
                              (left_chars[follow_left] <= '9')) ||
                             (left_chars[follow_left] == '.'));
                if ((left_chars[follow_left] >= '1') &&
                    (left_chars[follow_left] <= '9'))
                  {
                    left_is_zero = false;
                    if (first_left_non_zero_mantissa_digit == -1)
                        first_left_non_zero_mantissa_digit = follow_left;
                  }
                if (left_chars[follow_left] == '.')
                  {
                    Debug.Assert(left_decimal_point == -1);
                    left_decimal_point = follow_left;
                  }
                ++follow_left;
              }
            left_exponent = follow_left;
          }
        bool right_is_zero = true;
          {
            int follow_right = 0;
            while (follow_right < right_start_chars.Length)
              {
                Debug.Assert((right_start_chars[follow_right] >= '0') &&
                             (right_start_chars[follow_right] <= '9'));
                if ((right_start_chars[follow_right] >= '1') &&
                    (right_start_chars[follow_right] <= '9'))
                  {
                    right_is_zero = false;
                  }
                ++follow_right;
              }
          }
          {
            int follow_right = 0;
            while (follow_right < right_repeat_chars.Length)
              {
                Debug.Assert((right_repeat_chars[follow_right] >= '0') &&
                             (right_repeat_chars[follow_right] <= '9'));
                if ((right_repeat_chars[follow_right] >= '1') &&
                    (right_repeat_chars[follow_right] <= '9'))
                  {
                    right_is_zero = false;
                  }
                ++follow_right;
              }
          }

        int left_greater_result = 1;
        int right_greater_result = -1;

        if (left_is_zero)
          {
            if (right_is_zero)
                return 0;
            if (right_mantissa_is_negative)
                return left_greater_result;
            return right_greater_result;
          }
        if (right_is_zero)
          {
            return (left_mantissa_is_negative ? right_greater_result :
                                                left_greater_result);
          }

        if (left_mantissa_is_negative != right_mantissa_is_negative)
          {
            return (left_mantissa_is_negative ? right_greater_result :
                                                left_greater_result);
          }

        int left_magnitude_greater_result =
                (left_mantissa_is_negative ? right_greater_result :
                 left_greater_result);
        int right_magnitude_greater_result =
                (left_mantissa_is_negative ? left_greater_result :
                 right_greater_result);

        Debug.Assert(first_left_non_zero_mantissa_digit != -1);
        Debug.Assert((right_start_chars.Length == 0) ||
                     ((right_start_chars[0] >= '1') &&
                      (right_start_chars[0] <= '9')));
        Debug.Assert((right_start_chars.Length > 0) ||
                     ((right_repeat_chars[0] >= '1') &&
                      (right_repeat_chars[0] <= '9')));

        long left_minus_right_exponent =
                ((left_decimal_point == -1) ?
                 ((long)(left_exponent - first_left_non_zero_mantissa_digit)) :
                 ((left_decimal_point > first_left_non_zero_mantissa_digit) ?
                  ((long)(left_decimal_point -
                          first_left_non_zero_mantissa_digit)) :
                  (-(long)((first_left_non_zero_mantissa_digit -
                            left_decimal_point) + 1))));

          {
            int left_start_exponent_digits = left_exponent;
            bool left_exponent_is_negative = false;
            if (left_start_exponent_digits < left_chars.Length)
              {
                Debug.Assert((left_chars[left_start_exponent_digits] == 'e') ||
                             (left_chars[left_start_exponent_digits] == 'E'));
                ++left_start_exponent_digits;
                if (left_chars[left_start_exponent_digits] == '-')
                  {
                    left_exponent_is_negative = true;
                    ++left_start_exponent_digits;
                  }
                else if (left_chars[left_start_exponent_digits] == '+')
                  {
                    ++left_start_exponent_digits;
                  }
                while ((left_start_exponent_digits < left_chars.Length) &&
                       (left_chars[left_start_exponent_digits] == '0'))
                  {
                    ++left_start_exponent_digits;
                  }
              }
            int left_end_exponent_digits = left_start_exponent_digits;
            while (left_end_exponent_digits < left_chars.Length)
              {
                Debug.Assert((left_chars[left_end_exponent_digits] >= '0') &&
                             (left_chars[left_end_exponent_digits] <= '9'));
                ++left_end_exponent_digits;
              }
            int right_start_exponent_digits = 0;
            while ((right_start_exponent_digits <
                    right_exponent_chars.Length) &&
                   (right_exponent_chars[right_start_exponent_digits] == '0'))
              {
                ++right_start_exponent_digits;
              }
            int right_end_exponent_digits = right_start_exponent_digits;
            while (right_end_exponent_digits < right_exponent_chars.Length)
              {
                Debug.Assert((right_exponent_chars[right_end_exponent_digits] >=
                              '0') &&
                             (right_exponent_chars[right_end_exponent_digits] <=
                              '9'));
                ++right_end_exponent_digits;
              }
            int left_exponent_digit_count =
                    (left_end_exponent_digits - left_start_exponent_digits);
            int right_exponent_digit_count =
                    (right_end_exponent_digits - right_start_exponent_digits);
            int total_exponent_digit_count =
                    ((left_exponent_digit_count > right_exponent_digit_count) ?
                     left_exponent_digit_count : right_exponent_digit_count);
            long sum = 0;
            for (int digit_num = total_exponent_digit_count; digit_num > 0;
                 --digit_num)
              {
                long left_digit =
                        ((digit_num <= left_exponent_digit_count) ?
                         left_chars[left_end_exponent_digits - digit_num] -
                         '0' : 0);
                if (left_exponent_is_negative)
                    left_digit = -left_digit;
                long right_digit =
                        ((digit_num <= right_exponent_digit_count) ?
                         right_exponent_chars[
                                 right_end_exponent_digits - digit_num] - '0' :
                         0);
                if (right_exponent_is_negative)
                    right_digit = -right_digit;
                sum *= 10;
                sum += (left_digit - right_digit);
                if ((sum > 0) && ((left_minus_right_exponent + sum) > 0))
                    return left_magnitude_greater_result;
                if ((sum < 0) && ((left_minus_right_exponent + sum) < 0))
                    return right_magnitude_greater_result;
              }
            left_minus_right_exponent += sum;
            if (left_minus_right_exponent != 0)
              {
                return ((left_minus_right_exponent > 0) ?
                        left_magnitude_greater_result :
                        right_magnitude_greater_result);
              }
          }

        int follow_left_mantissa = first_left_non_zero_mantissa_digit;
        char[] follow_right_array = right_start_chars;
        int follow_right_position = 0;
        while (follow_left_mantissa < left_exponent)
          {
            if (follow_left_mantissa == left_decimal_point)
              {
                ++follow_left_mantissa;
                continue;
              }
            if (follow_right_position >= follow_right_array.Length)
              {
                follow_right_array = right_repeat_chars;
                follow_right_position = 0;
              }
            char right_digit =
                    ((follow_right_position >= follow_right_array.Length) ?
                     '0' : follow_right_array[follow_right_position]);
            char left_digit = left_chars[follow_left_mantissa];
            if (right_digit != left_digit)
              {
                return ((left_digit > right_digit) ?
                        left_magnitude_greater_result :
                        right_magnitude_greater_result);
              }
            ++follow_left_mantissa;
            ++follow_right_position;
          }
        if ((follow_right_position >= follow_right_array.Length) &&
            (right_repeat_chars.Length == 0))
          {
            return 0;
          }
        return right_magnitude_greater_result;
      }

    protected JSONWriter(
            whitespace_style init_style = whitespace_style.WHITESPACE_VERBOSE_4)
      {
        compound_stack = new List<which_compound>();
        style = init_style;
        ascii_only = false;
      }

    protected abstract void send_raw_text(string text);
  }
