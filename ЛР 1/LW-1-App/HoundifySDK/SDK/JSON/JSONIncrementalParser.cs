/* file "JSONIncrementalParser.cs" */

/* Copyright 2015-2018 SoundHound, Incorporated.  All rights reserved. */


using System;
using System.Text;
using System.Numerics;
using System.Collections.Generic;
using System.Diagnostics;


public class JSONIncrementalParser
  {
    private enum StackState
      {
        SS_ARRAY,
        SS_OBJECT_LABEL,
        SS_OBJECT
      };

    private enum ParseState
      {
        PS_START,
        PS_TRUE_T,
        PS_TRUE_TR,
        PS_TRUE_TRU,
        PS_FALSE_F,
        PS_FALSE_FA,
        PS_FALSE_FAL,
        PS_FALSE_FALS,
        PS_NULL_N,
        PS_NULL_NU,
        PS_NULL_NUL,
        PS_STRING_BASE,
        PS_STRING_BACKSLASH,
        PS_STRING_HEX_0,
        PS_STRING_HEX_1,
        PS_STRING_HEX_2,
        PS_STRING_HEX_3,
        PS_STRING_HEX_4_START,
        PS_STRING_HEX_4_BACKSLASH,
        PS_STRING_HEX_4,
        PS_STRING_HEX_5,
        PS_STRING_HEX_6,
        PS_STRING_HEX_7,
        PS_NUMBER_MINUS,
        PS_NUMBER_ZERO,
        PS_NUMBER_DIGITS,
        PS_NUMBER_DOT,
        PS_NUMBER_DOT_DIGIT,
        PS_NUMBER_E,
        PS_NUMBER_E_SIGN,
        PS_NUMBER_E_SIGN_DIGIT,
        PS_ARRAY_BASE,
        PS_ARRAY_VALUE,
        PS_OBJECT_BASE,
        PS_OBJECT_LABEL,
        PS_OBJECT_VALUE,
        PS_OBJECT_COMMA
      };

    private JSONHandler handler;
    private BigInteger line_number;
    private BigInteger column_number;
    private List<StackState> state_stack;
    private ParseState current_state;
    private StringBuilder current_string;
    private bool number_is_negative;
    private BigInteger mantissa_whole_part;
    private BigInteger mantissa_fraction_numerator;
    private int mantissa_fraction_digit_count;
    private bool exponent_is_negative;
    private BigInteger exponent;
    private char[] hex_buffer;
    private int next_characters;
    private int bytes_left;
    private int bytes_after_column;
    private char[] current_new_characters;

    private static String describe_character(char the_character)
      {
        switch (the_character)
          {
            case '\b':
                return "\\b";
            case '\f':
                return "\\f";
            case '\n':
                return "\\n";
            case '\r':
                return "\\r";
            case '\t':
                return "\\t";
            default:
                break;
          }
        if (the_character >= ' ')
          {
            return String.Format("`{0}'", the_character);
          }
        else
          {
            return String.Format("0x{0:02x}", (int)the_character);
          }
      }

    private static int hex_digit_character_to_value(char the_character)
      {
        if ((the_character >= '0') && (the_character <= '9'))
            return the_character - '0';
        if ((the_character >= 'a') && (the_character <= 'f'))
            return (the_character - 'a') + 0xa;
        Debug.Assert((the_character >= 'A') && (the_character <= 'F'));
        return (the_character - 'A') + 0xa;
      }

    private ParseState value_done_state()
      {
        int stack_size = state_stack.Count;
        if (stack_size < 1)
            return ParseState.PS_START;
        switch (state_stack[stack_size - 1])
          {
            case StackState.SS_ARRAY:
                return ParseState.PS_ARRAY_VALUE;
            case StackState.SS_OBJECT_LABEL:
                Debug.Assert(false);
                return ParseState.PS_OBJECT_VALUE;
            case StackState.SS_OBJECT:
                return ParseState.PS_OBJECT_VALUE;
            default:
                Debug.Assert(false);
                return ParseState.PS_START;
          }
      }

    private void unexpected(String expected)
      {
        if (current_new_characters == null)
          {
            throw new Exception(String.Format(
                    "{0}:{1}: Expected {2}, found end of input.",
                    line_number.ToString(), column_number.ToString(),
                    expected));
          }
        column_number += bytes_after_column - bytes_left;
        throw new Exception(String.Format("{0}:{1}: Expected {2}, found {3}.",
                line_number.ToString(), column_number.ToString(), expected,
                describe_character(current_new_characters[next_characters])));
      }

    private void do_default()
      {
        switch (current_state)
          {
            case ParseState.PS_START:
                unexpected("a value");
                return;
            case ParseState.PS_ARRAY_BASE:
                unexpected("a value or `]'");
                return;
            default:
                Debug.Assert(false);
                return;
          }
      }

    public JSONIncrementalParser(JSONHandler init_handler)
      {
        Debug.Assert(init_handler != null);
        handler = init_handler;
        line_number = 1;
        column_number = 1;
        state_stack = new List<StackState>();
        current_state = ParseState.PS_START;
        hex_buffer = new char[7];
      }

    public void add_characters(char[] new_characters, int character_count)
      {
        Debug.Assert(new_characters != null);

        current_new_characters = new_characters;

        next_characters = 0;
        bytes_left = character_count;
        bytes_after_column = character_count;

        while (bytes_left > 0)
          {
            switch (current_state)
              {
                case ParseState.PS_START:
                    goto case ParseState.PS_ARRAY_BASE;
                case ParseState.PS_ARRAY_BASE:
                    switch (new_characters[next_characters])
                      {
                        case 't':
                          {
                            current_state = ParseState.PS_TRUE_T;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case 'f':
                          {
                            current_state = ParseState.PS_FALSE_F;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case 'n':
                          {
                            current_state = ParseState.PS_NULL_N;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '\"':
                          {
                            current_state = ParseState.PS_STRING_BASE;
                            current_string = new StringBuilder();
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '-':
                          {
                            current_state = ParseState.PS_NUMBER_MINUS;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '0':
                          {
                            current_state = ParseState.PS_NUMBER_ZERO;
                            number_is_negative = false;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '1':
                          {
                            goto case '9';
                          }
                        case '2':
                          {
                            goto case '9';
                          }
                        case '3':
                          {
                            goto case '9';
                          }
                        case '4':
                          {
                            goto case '9';
                          }
                        case '5':
                          {
                            goto case '9';
                          }
                        case '6':
                          {
                            goto case '9';
                          }
                        case '7':
                          {
                            goto case '9';
                          }
                        case '8':
                          {
                            goto case '9';
                          }
                        case '9':
                          {
                            mantissa_whole_part =
                                    new_characters[next_characters] - '0';
                            current_state = ParseState.PS_NUMBER_DIGITS;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '[':
                          {
                            state_stack.Add(StackState.SS_ARRAY);
                            current_state = ParseState.PS_ARRAY_BASE;
                            handler.start_array();
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case ']':
                          {
                            int stack_size = state_stack.Count;
                            if (current_state != ParseState.PS_ARRAY_BASE)
                                do_default();
                            Debug.Assert(state_stack[stack_size - 1] ==
                                         StackState.SS_ARRAY);
                            handler.finish_array();
                            state_stack.RemoveAt(state_stack.Count - 1);
                            current_state = value_done_state();
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '{':
                          {
                            state_stack.Add(StackState.SS_OBJECT_LABEL);
                            current_state = ParseState.PS_OBJECT_BASE;
                            handler.start_object();
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '\n':
                          {
                            ++line_number;
                            column_number = 1;
                            bytes_after_column = bytes_left - 1;

                            goto case '\f';
                          }
                        case ' ':
                          {
                            goto case '\f';
                          }
                        case '\r':
                          {
                            goto case '\f';
                          }
                        case '\t':
                          {
                            goto case '\f';
                          }
                        case '\f':
                          {
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        default:
                          {
                            do_default();
                            break;
                          }
                      }
                    break;
                case ParseState.PS_TRUE_T:
                    if (new_characters[next_characters] == 'r')
                      {
                        current_state = ParseState.PS_TRUE_TR;
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("`r'");
                        break;
                      }
                case ParseState.PS_TRUE_TR:
                    if (new_characters[next_characters] == 'u')
                      {
                        current_state = ParseState.PS_TRUE_TRU;
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("`u'");
                        break;
                      }
                case ParseState.PS_TRUE_TRU:
                    if (new_characters[next_characters] == 'e')
                      {
                        handler.true_value();
                        current_state = value_done_state();
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("`e'");
                        break;
                      }
                case ParseState.PS_FALSE_F:
                    if (new_characters[next_characters] == 'a')
                      {
                        current_state = ParseState.PS_FALSE_FA;
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("`a'");
                        break;
                      }
                case ParseState.PS_FALSE_FA:
                    if (new_characters[next_characters] == 'l')
                      {
                        current_state = ParseState.PS_FALSE_FAL;
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("`l'");
                        break;
                      }
                case ParseState.PS_FALSE_FAL:
                    if (new_characters[next_characters] == 's')
                      {
                        current_state = ParseState.PS_FALSE_FALS;
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("`s'");
                        break;
                      }
                case ParseState.PS_FALSE_FALS:
                    if (new_characters[next_characters] == 'e')
                      {
                        handler.false_value();
                        current_state = value_done_state();
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("`e'");
                        break;
                      }
                case ParseState.PS_NULL_N:
                    if (new_characters[next_characters] == 'u')
                      {
                        current_state = ParseState.PS_NULL_NU;
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("`u'");
                        break;
                      }
                case ParseState.PS_NULL_NU:
                    if (new_characters[next_characters] == 'l')
                      {
                        current_state = ParseState.PS_NULL_NUL;
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("`l'");
                        break;
                      }
                case ParseState.PS_NULL_NUL:
                    if (new_characters[next_characters] == 'l')
                      {
                        handler.null_value();
                        current_state = value_done_state();
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("`l'");
                        break;
                      }
                case ParseState.PS_STRING_BASE:
                    switch (new_characters[next_characters])
                      {
                        case '\\':
                          {
                            current_state = ParseState.PS_STRING_BACKSLASH;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '\"':
                          {
                            int stack_size = state_stack.Count;
                            if ((stack_size < 1) ||
                                (state_stack[stack_size - 1] !=
                                 StackState.SS_OBJECT_LABEL))
                              {
                                handler.string_value(current_string.ToString());
                                current_state = value_done_state();
                              }
                            else
                              {
                                handler.start_pair(current_string.ToString());
                                current_state = ParseState.PS_OBJECT_LABEL;
                                state_stack[stack_size - 1] =
                                        StackState.SS_OBJECT;
                              }
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        default:
                          {
                            if (new_characters[next_characters] < ' ')
                              {
                                unexpected(
                                        "string character or close double " +
                                        "quote");
                                break;
                              }
                            current_string.Append(
                                    new_characters[next_characters]);
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                      }
                    continue;
                case ParseState.PS_STRING_BACKSLASH:
                    switch (new_characters[next_characters])
                      {
                        case '\"':
                            goto case '/';
                        case '\\':
                            goto case '/';
                        case '/':
                            current_string.Append(
                                    new_characters[next_characters]);
                            current_state = ParseState.PS_STRING_BASE;
                            ++next_characters;
                            --bytes_left;
                            continue;
                        case 'b':
                            current_string.Append('\b');
                            current_state = ParseState.PS_STRING_BASE;
                            ++next_characters;
                            --bytes_left;
                            continue;
                        case 'f':
                            current_string.Append('\f');
                            current_state = ParseState.PS_STRING_BASE;
                            ++next_characters;
                            --bytes_left;
                            continue;
                        case 'n':
                            current_string.Append('\n');
                            current_state = ParseState.PS_STRING_BASE;
                            ++next_characters;
                            --bytes_left;
                            continue;
                        case 'r':
                            current_string.Append('\r');
                            current_state = ParseState.PS_STRING_BASE;
                            ++next_characters;
                            --bytes_left;
                            continue;
                        case 't':
                            current_string.Append('\t');
                            current_state = ParseState.PS_STRING_BASE;
                            ++next_characters;
                            --bytes_left;
                            continue;
                        case 'u':
                            current_state = ParseState.PS_STRING_HEX_0;
                            ++next_characters;
                            --bytes_left;
                            continue;
                        default:
                            unexpected("escape sequence");
                            break;
                      }
                    break;
                case ParseState.PS_STRING_HEX_0:
                    if (((new_characters[next_characters] >= '0') &&
                         (new_characters[next_characters] <= '9')) ||
                        ((new_characters[next_characters] >= 'a') &&
                         (new_characters[next_characters] <= 'f')) ||
                        ((new_characters[next_characters] >= 'A') &&
                         (new_characters[next_characters] <= 'F')))
                      {
                        hex_buffer[0] = new_characters[next_characters];
                        current_state = ParseState.PS_STRING_HEX_1;
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("four hex digits");
                        break;
                      }
                case ParseState.PS_STRING_HEX_1:
                    if (((new_characters[next_characters] >= '0') &&
                         (new_characters[next_characters] <= '9')) ||
                        ((new_characters[next_characters] >= 'a') &&
                         (new_characters[next_characters] <= 'f')) ||
                        ((new_characters[next_characters] >= 'A') &&
                         (new_characters[next_characters] <= 'F')))
                      {
                        hex_buffer[1] = new_characters[next_characters];
                        current_state = ParseState.PS_STRING_HEX_2;
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("three more hex digits");
                        break;
                      }
                case ParseState.PS_STRING_HEX_2:
                    if (((new_characters[next_characters] >= '0') &&
                         (new_characters[next_characters] <= '9')) ||
                        ((new_characters[next_characters] >= 'a') &&
                         (new_characters[next_characters] <= 'f')) ||
                        ((new_characters[next_characters] >= 'A') &&
                         (new_characters[next_characters] <= 'F')))
                      {
                        hex_buffer[2] = new_characters[next_characters];
                        current_state = ParseState.PS_STRING_HEX_3;
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("two more hex digits");
                        break;
                      }
                case ParseState.PS_STRING_HEX_3:
                    if (((new_characters[next_characters] >= '0') &&
                         (new_characters[next_characters] <= '9')) ||
                        ((new_characters[next_characters] >= 'a') &&
                         (new_characters[next_characters] <= 'f')) ||
                        ((new_characters[next_characters] >= 'A') &&
                         (new_characters[next_characters] <= 'F')))
                      {
                        int sequence_value =
                                (hex_digit_character_to_value(hex_buffer[0]) <<
                                 12) |
                                (hex_digit_character_to_value(hex_buffer[1]) <<
                                 8) |
                                (hex_digit_character_to_value(hex_buffer[2]) <<
                                 4) |
                                hex_digit_character_to_value(
                                        new_characters[next_characters]);
                        Debug.Assert(sequence_value >= 0);
                        Debug.Assert(sequence_value <= 0xffff);
                        if ((sequence_value <= 0xd7ff) ||
                            (sequence_value >= 0xe000))
                          {
                            current_string.Append((char)sequence_value);
                            current_state = ParseState.PS_STRING_BASE;
                          }
                        else
                          {
                            if (sequence_value >= 0xdc00)
                              {
                                BigInteger new_column_number =
                                        column_number +
                                        (bytes_after_column - bytes_left) - 5;

                                throw new Exception(String.Format(
                                        "{0}:{1}: The value for a \\u sequence " +
                                        "is not a valid first unit for a " +
                                        "UTF-16 character.", line_number,
                                        new_column_number));
                              }
                            hex_buffer[3] = new_characters[next_characters];
                            current_state = ParseState.PS_STRING_HEX_4_START;
                          }
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("one more hex digit");
                        break;
                      }
                case ParseState.PS_STRING_HEX_4_START:
                    if (new_characters[next_characters] == '\\')
                      {
                        current_state = ParseState.PS_STRING_HEX_4_BACKSLASH;
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("backslash");
                        break;
                      }
                case ParseState.PS_STRING_HEX_4_BACKSLASH:
                    if (new_characters[next_characters] == 'u')
                      {
                        current_state = ParseState.PS_STRING_HEX_4;
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("`u'");
                        break;
                      }
                case ParseState.PS_STRING_HEX_4:
                    if (((new_characters[next_characters] >= '0') &&
                         (new_characters[next_characters] <= '9')) ||
                        ((new_characters[next_characters] >= 'a') &&
                         (new_characters[next_characters] <= 'f')) ||
                        ((new_characters[next_characters] >= 'A') &&
                         (new_characters[next_characters] <= 'F')))
                      {
                        hex_buffer[4] = new_characters[next_characters];
                        current_state = ParseState.PS_STRING_HEX_5;
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("four hex digits");
                        break;
                      }
                case ParseState.PS_STRING_HEX_5:
                    if (((new_characters[next_characters] >= '0') &&
                         (new_characters[next_characters] <= '9')) ||
                        ((new_characters[next_characters] >= 'a') &&
                         (new_characters[next_characters] <= 'f')) ||
                        ((new_characters[next_characters] >= 'A') &&
                         (new_characters[next_characters] <= 'F')))
                      {
                        hex_buffer[5] = new_characters[next_characters];
                        current_state = ParseState.PS_STRING_HEX_6;
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("three more hex digits");
                        break;
                      }
                case ParseState.PS_STRING_HEX_6:
                    if (((new_characters[next_characters] >= '0') &&
                         (new_characters[next_characters] <= '9')) ||
                        ((new_characters[next_characters] >= 'a') &&
                         (new_characters[next_characters] <= 'f')) ||
                        ((new_characters[next_characters] >= 'A') &&
                         (new_characters[next_characters] <= 'F')))
                      {
                        hex_buffer[6] = new_characters[next_characters];
                        current_state = ParseState.PS_STRING_HEX_7;
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("two more hex digits");
                        break;
                      }
                case ParseState.PS_STRING_HEX_7:
                    if (((new_characters[next_characters] >= '0') &&
                         (new_characters[next_characters] <= '9')) ||
                        ((new_characters[next_characters] >= 'a') &&
                         (new_characters[next_characters] <= 'f')) ||
                        ((new_characters[next_characters] >= 'A') &&
                         (new_characters[next_characters] <= 'F')))
                      {
                        int sequence_value0 =
                                (hex_digit_character_to_value(hex_buffer[0]) <<
                                 12) |
                                (hex_digit_character_to_value(hex_buffer[1]) <<
                                 8) |
                                (hex_digit_character_to_value(hex_buffer[2]) <<
                                 4) |
                                hex_digit_character_to_value(hex_buffer[3]);
                        int sequence_value1 =
                                (hex_digit_character_to_value(hex_buffer[4]) <<
                                 12) |
                                (hex_digit_character_to_value(hex_buffer[5]) <<
                                 8) |
                                (hex_digit_character_to_value(hex_buffer[6]) <<
                                 4) |
                                hex_digit_character_to_value(
                                        new_characters[next_characters]);
                        Debug.Assert(sequence_value0 >= 0);
                        Debug.Assert(sequence_value0 <= 0xffff);
                        Debug.Assert(sequence_value1 >= 0);
                        Debug.Assert(sequence_value1 <= 0xffff);
                        Debug.Assert((sequence_value0 > 0xd7ff) &&
                                     (sequence_value0 < 0xdc00));
                        if ((sequence_value1 < 0xdc00) ||
                            (sequence_value1 > 0xdfff))
                          {
                            BigInteger new_column_number =
                                    column_number +
                                    (bytes_after_column - bytes_left) - 5;

                            throw new Exception(String.Format(
                                    "{0}:{1}: The second value for a two-unit " +
                                    "\\u sequence is not a valid second unit " +
                                    "for a UTF-16 character.",
                                    line_number.ToString(),
                                    new_column_number.ToString()));
                          }
                        int code_point =
                                (((sequence_value0 & 0x3ff) << 10) |
                                 (sequence_value1 & 0x3ff)) + 0x10000;
                        current_string.Append(
                                Char.ConvertFromUtf32(code_point));
                        current_state = ParseState.PS_STRING_BASE;
                        ++next_characters;
                        --bytes_left;
                        continue;
                      }
                    else
                      {
                        unexpected("one more hex digit");
                        break;
                      }
                case ParseState.PS_NUMBER_MINUS:
                    switch (new_characters[next_characters])
                      {
                        case '0':
                            current_state = ParseState.PS_NUMBER_ZERO;
                            number_is_negative = true;
                            ++next_characters;
                            --bytes_left;
                            continue;
                        case '1':
                            goto case '9';
                        case '2':
                            goto case '9';
                        case '3':
                            goto case '9';
                        case '4':
                            goto case '9';
                        case '5':
                            goto case '9';
                        case '6':
                            goto case '9';
                        case '7':
                            goto case '9';
                        case '8':
                            goto case '9';
                        case '9':
                            mantissa_whole_part =
                                    -(new_characters[next_characters] - '0');
                            current_state = ParseState.PS_NUMBER_DIGITS;
                            ++next_characters;
                            --bytes_left;
                            continue;
                        default:
                            unexpected("a digit");
                            break;
                      }
                    break;
                case ParseState.PS_NUMBER_ZERO:
                    switch (new_characters[next_characters])
                      {
                        case '.':
                            mantissa_whole_part = 0;
                            current_state = ParseState.PS_NUMBER_DOT;
                            ++next_characters;
                            --bytes_left;
                            continue;
                        case 'e':
                            goto case 'E';
                        case 'E':
                            mantissa_whole_part = 0;
                            mantissa_fraction_digit_count = 0;
                            current_state = ParseState.PS_NUMBER_E;
                            ++next_characters;
                            --bytes_left;
                            continue;
                        default:
                            handler.number_value(0);
                            current_state = value_done_state();
                            continue;
                      }
                case ParseState.PS_NUMBER_DIGITS:
                    switch (new_characters[next_characters])
                      {
                        case '0':
                          {
                            goto case '9';
                          }
                        case '1':
                          {
                            goto case '9';
                          }
                        case '2':
                          {
                            goto case '9';
                          }
                        case '3':
                          {
                            goto case '9';
                          }
                        case '4':
                          {
                            goto case '9';
                          }
                        case '5':
                          {
                            goto case '9';
                          }
                        case '6':
                          {
                            goto case '9';
                          }
                        case '7':
                          {
                            goto case '9';
                          }
                        case '8':
                          {
                            goto case '9';
                          }
                        case '9':
                          {
                            BigInteger product = mantissa_whole_part * 10;
                            long new_digit_long =
                                    new_characters[next_characters] - '0';
                            if (product < 0)
                                new_digit_long = -new_digit_long;
                            mantissa_whole_part = product + new_digit_long;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '.':
                          {
                            number_is_negative = (mantissa_whole_part < 0);
                            current_state = ParseState.PS_NUMBER_DOT;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case 'e':
                        case 'E':
                          {
                            mantissa_fraction_digit_count = 0;
                            current_state = ParseState.PS_NUMBER_E;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        default:
                          {
                            handler.number_value(mantissa_whole_part);
                            current_state = value_done_state();
                            continue;
                          }
                      }
                case ParseState.PS_NUMBER_DOT:
                    switch (new_characters[next_characters])
                      {
                        case '0':
                          {
                            goto case '9';
                          }
                        case '1':
                          {
                            goto case '9';
                          }
                        case '2':
                          {
                            goto case '9';
                          }
                        case '3':
                          {
                            goto case '9';
                          }
                        case '4':
                          {
                            goto case '9';
                          }
                        case '5':
                          {
                            goto case '9';
                          }
                        case '6':
                          {
                            goto case '9';
                          }
                        case '7':
                          {
                            goto case '9';
                          }
                        case '8':
                          {
                            goto case '9';
                          }
                        case '9':
                          {
                            long new_digit_long =
                                    new_characters[next_characters] - '0';
                            if (number_is_negative)
                                new_digit_long = -new_digit_long;
                            mantissa_fraction_numerator = new_digit_long;
                            mantissa_fraction_digit_count = 1;
                            current_state = ParseState.PS_NUMBER_DOT_DIGIT;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        default:
                          {
                            unexpected("a digit");
                            break;
                          }
                      }
                    break;
                case ParseState.PS_NUMBER_DOT_DIGIT:
                    switch (new_characters[next_characters])
                      {
                        case '0':
                          {
                            goto case '9';
                          }
                        case '1':
                          {
                            goto case '9';
                          }
                        case '2':
                          {
                            goto case '9';
                          }
                        case '3':
                          {
                            goto case '9';
                          }
                        case '4':
                          {
                            goto case '9';
                          }
                        case '5':
                          {
                            goto case '9';
                          }
                        case '6':
                          {
                            goto case '9';
                          }
                        case '7':
                          {
                            goto case '9';
                          }
                        case '8':
                          {
                            goto case '9';
                          }
                        case '9':
                          {
                            long new_digit_long =
                                    new_characters[next_characters] - '0';
                            if (number_is_negative)
                                new_digit_long = -new_digit_long;
                            mantissa_fraction_numerator =
                                    (mantissa_fraction_numerator * 10) +
                                    new_digit_long;
                            ++mantissa_fraction_digit_count;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case 'e':
                        case 'E':
                          {
                            Debug.Assert(mantissa_fraction_digit_count > 0);
                            current_state = ParseState.PS_NUMBER_E;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        default:
                          {
                            if (mantissa_fraction_digit_count == 0)
                                mantissa_fraction_numerator = 0;
                            handler.number_value(mantissa_whole_part,
                                    mantissa_fraction_numerator,
                                    mantissa_fraction_digit_count, 0);
                            current_state = value_done_state();
                            continue;
                          }
                      }
                case ParseState.PS_NUMBER_E:
                    switch (new_characters[next_characters])
                      {
                        case '0':
                          {
                            goto case '9';
                          }
                        case '1':
                          {
                            goto case '9';
                          }
                        case '2':
                          {
                            goto case '9';
                          }
                        case '3':
                          {
                            goto case '9';
                          }
                        case '4':
                          {
                            goto case '9';
                          }
                        case '5':
                          {
                            goto case '9';
                          }
                        case '6':
                          {
                            goto case '9';
                          }
                        case '7':
                          {
                            goto case '9';
                          }
                        case '8':
                          {
                            goto case '9';
                          }
                        case '9':
                          {
                            exponent_is_negative = false;
                            exponent = new_characters[next_characters] - '0';
                            current_state = ParseState.PS_NUMBER_E_SIGN_DIGIT;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '+':
                          {
                            exponent_is_negative = false;
                            current_state = ParseState.PS_NUMBER_E_SIGN;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '-':
                          {
                            exponent_is_negative = true;
                            current_state = ParseState.PS_NUMBER_E_SIGN;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        default:
                          {
                            unexpected("a plus or minus sign or a digit");
                            break;
                          }
                      }
                    break;
                case ParseState.PS_NUMBER_E_SIGN:
                    switch (new_characters[next_characters])
                      {
                        case '0':
                          {
                            goto case '9';
                          }
                        case '1':
                          {
                            goto case '9';
                          }
                        case '2':
                          {
                            goto case '9';
                          }
                        case '3':
                          {
                            goto case '9';
                          }
                        case '4':
                          {
                            goto case '9';
                          }
                        case '5':
                          {
                            goto case '9';
                          }
                        case '6':
                          {
                            goto case '9';
                          }
                        case '7':
                          {
                            goto case '9';
                          }
                        case '8':
                          {
                            goto case '9';
                          }
                        case '9':
                          {
                            long new_digit_long =
                                    new_characters[next_characters] - '0';
                            if (exponent_is_negative)
                                new_digit_long = -new_digit_long;
                            exponent = new_digit_long;
                            current_state = ParseState.PS_NUMBER_E_SIGN_DIGIT;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        default:
                          {
                            unexpected("a digit");
                            break;
                          }
                      }
                    break;
                case ParseState.PS_NUMBER_E_SIGN_DIGIT:
                    switch (new_characters[next_characters])
                      {
                        case '0':
                          {
                            goto case '9';
                          }
                        case '1':
                          {
                            goto case '9';
                          }
                        case '2':
                          {
                            goto case '9';
                          }
                        case '3':
                          {
                            goto case '9';
                          }
                        case '4':
                          {
                            goto case '9';
                          }
                        case '5':
                          {
                            goto case '9';
                          }
                        case '6':
                          {
                            goto case '9';
                          }
                        case '7':
                          {
                            goto case '9';
                          }
                        case '8':
                          {
                            goto case '9';
                          }
                        case '9':
                          {
                            long new_digit_long =
                                    new_characters[next_characters] - '0';
                            if (exponent_is_negative)
                                new_digit_long = -new_digit_long;
                            exponent = (exponent * 10) + new_digit_long;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        default:
                          {
                            if (mantissa_fraction_digit_count == 0)
                                mantissa_fraction_numerator = 0;
                            handler.number_value(mantissa_whole_part,
                                    mantissa_fraction_numerator,
                                    mantissa_fraction_digit_count, exponent);
                            current_state = value_done_state();
                            continue;
                          }
                      }
                case ParseState.PS_ARRAY_VALUE:
                    switch (new_characters[next_characters])
                      {
                        case ']':
                          {
                            int stack_size = state_stack.Count;
                            Debug.Assert(stack_size > 0);
                            Debug.Assert(state_stack[stack_size - 1] ==
                                         StackState.SS_ARRAY);
                            handler.finish_array();
                            state_stack.RemoveAt(state_stack.Count - 1);
                            current_state = value_done_state();
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case ',':
                          {
                            current_state = ParseState.PS_START;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '\n':
                          {
                            ++line_number;
                            column_number = 1;

                            bytes_after_column = bytes_left - 1;

                            goto case '\f';
                          }
                        case ' ':
                          {
                            goto case '\f';
                          }
                        case '\r':
                          {
                            goto case '\f';
                          }
                        case '\t':
                          {
                            goto case '\f';
                          }
                        case '\f':
                          {
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        default:
                          {
                            unexpected("a `]' or `,'");
                            break;
                          }
                      }
                    break;
                case ParseState.PS_OBJECT_BASE:
                    switch (new_characters[next_characters])
                      {
                        case '\"':
                          {
                            current_state = ParseState.PS_STRING_BASE;
                            current_string = new StringBuilder();
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '}':
                          {
                            int stack_size = state_stack.Count;
                            Debug.Assert(state_stack[stack_size - 1] ==
                                         StackState.SS_OBJECT_LABEL);
                            handler.finish_object();
                            state_stack.RemoveAt(state_stack.Count - 1);
                            current_state = value_done_state();
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '\n':
                          {
                            ++line_number;
                            column_number = 1;

                            bytes_after_column = bytes_left - 1;

                            goto case '\f';
                          }
                        case ' ':
                          {
                            goto case '\f';
                          }
                        case '\r':
                          {
                            goto case '\f';
                          }
                        case '\t':
                          {
                            goto case '\f';
                          }
                        case '\f':
                          {
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        default:
                          {
                            unexpected("a string or `}'");
                            break;
                          }
                      }
                    break;
                case ParseState.PS_OBJECT_LABEL:
                    switch (new_characters[next_characters])
                      {
                        case ':':
                          {
                            current_state = ParseState.PS_START;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '\n':
                          {
                            ++line_number;
                            column_number = 1;

                            bytes_after_column = bytes_left - 1;

                            goto case '\f';
                          }
                        case ' ':
                          {
                            goto case '\f';
                          }
                        case '\r':
                          {
                            goto case '\f';
                          }
                        case '\t':
                          {
                            goto case '\f';
                          }
                        case '\f':
                          {
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        default:
                          {
                            unexpected("a colon");
                            break;
                          }
                      }
                    break;
                case ParseState.PS_OBJECT_VALUE:
                    switch (new_characters[next_characters])
                      {
                        case '}':
                          {
                            int stack_size = state_stack.Count;
                            Debug.Assert(stack_size > 0);
                            Debug.Assert(state_stack[stack_size - 1] ==
                                         StackState.SS_OBJECT);
                            handler.finish_object();
                            state_stack.RemoveAt(state_stack.Count - 1);
                            current_state = value_done_state();
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case ',':
                          {
                            current_state = ParseState.PS_OBJECT_COMMA;
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '\n':
                          {
                            ++line_number;
                            column_number = 1;

                            bytes_after_column = bytes_left - 1;

                            goto case '\f';
                          }
                        case ' ':
                          {
                            goto case '\f';
                          }
                        case '\r':
                          {
                            goto case '\f';
                          }
                        case '\t':
                          {
                            goto case '\f';
                          }
                        case '\f':
                          {
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        default:
                          {
                            unexpected("a `}' or `,'");
                            break;
                          }
                      }
                    break;
                case ParseState.PS_OBJECT_COMMA:
                    switch (new_characters[next_characters])
                      {
                        case '\"':
                          {
                            current_state = ParseState.PS_STRING_BASE;
                            int stack_size = state_stack.Count;
                            Debug.Assert(stack_size > 0);
                            Debug.Assert(state_stack[stack_size - 1] ==
                                         StackState.SS_OBJECT);
                            state_stack[stack_size - 1] =
                                    StackState.SS_OBJECT_LABEL;
                            current_string = new StringBuilder();
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        case '\n':
                          {
                            ++line_number;
                            column_number = 1;

                            bytes_after_column = bytes_left - 1;

                            goto case '\f';
                          }
                        case ' ':
                          {
                            goto case '\f';
                          }
                        case '\r':
                          {
                            goto case '\f';
                          }
                        case '\t':
                          {
                            goto case '\f';
                          }
                        case '\f':
                          {
                            ++next_characters;
                            --bytes_left;
                            continue;
                          }
                        default:
                          {
                            unexpected("a string");
                            break;
                          }
                      }
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }

        column_number += bytes_after_column;
      }

    public void end_of_input()
      {
        current_new_characters = null;

        while (true)
          {
            switch (current_state)
              {
                case ParseState.PS_START:
                  {
                    int stack_size = state_stack.Count;
                    if (stack_size > 0)
                        unexpected("a value");
                    return;
                  }
                case ParseState.PS_TRUE_T:
                  {
                    unexpected("`r'");
                    return;
                  }
                case ParseState.PS_TRUE_TR:
                  {
                    unexpected("`u'");
                    return;
                  }
                case ParseState.PS_TRUE_TRU:
                  {
                    unexpected("`e'");
                    return;
                  }
                case ParseState.PS_FALSE_F:
                  {
                    unexpected("`a'");
                    return;
                  }
                case ParseState.PS_FALSE_FA:
                  {
                    unexpected("`l'");
                    return;
                  }
                case ParseState.PS_FALSE_FAL:
                  {
                    unexpected("`s'");
                    return;
                  }
                case ParseState.PS_FALSE_FALS:
                  {
                    unexpected("`e'");
                    return;
                  }
                case ParseState.PS_NULL_N:
                  {
                    unexpected("`u'");
                    return;
                  }
                case ParseState.PS_NULL_NU:
                case ParseState.PS_NULL_NUL:
                  {
                    unexpected("`l'");
                    return;
                  }
                case ParseState.PS_STRING_BASE:
                  {
                    unexpected("string character or close double quote");
                    return;
                  }
                case ParseState.PS_STRING_BACKSLASH:
                  {
                    unexpected("escape sequence");
                    return;
                  }
                case ParseState.PS_STRING_HEX_0:
                  {
                    unexpected("four hex digits");
                    return;
                  }
                case ParseState.PS_STRING_HEX_1:
                  {
                    unexpected("three more hex digits");
                    return;
                  }
                case ParseState.PS_STRING_HEX_2:
                  {
                    unexpected("two more hex digits");
                    return;
                  }
                case ParseState.PS_STRING_HEX_3:
                  {
                    unexpected("one more hex digit");
                    return;
                  }
                case ParseState.PS_STRING_HEX_4_START:
                  {
                    unexpected("backslash");
                    return;
                  }
                case ParseState.PS_STRING_HEX_4_BACKSLASH:
                  {
                    unexpected("`u'");
                    return;
                  }
                case ParseState.PS_STRING_HEX_4:
                  {
                    unexpected("four hex digits");
                    return;
                  }
                case ParseState.PS_STRING_HEX_5:
                  {
                    unexpected("three more hex digits");
                    return;
                  }
                case ParseState.PS_STRING_HEX_6:
                  {
                    unexpected("two more hex digits");
                    return;
                  }
                case ParseState.PS_STRING_HEX_7:
                  {
                    unexpected("one more hex digit");
                    return;
                  }
                case ParseState.PS_NUMBER_MINUS:
                  {
                    unexpected("a digit");
                    return;
                  }
                case ParseState.PS_NUMBER_ZERO:
                  {
                    handler.number_value(0);
                    current_state = value_done_state();
                    continue;
                  }
                case ParseState.PS_NUMBER_DIGITS:
                  {
                    handler.number_value(mantissa_whole_part);
                    current_state = value_done_state();
                    continue;
                  }
                case ParseState.PS_NUMBER_DOT:
                  {
                    unexpected("a digit");
                    return;
                  }
                case ParseState.PS_NUMBER_DOT_DIGIT:
                  {
                    Debug.Assert(mantissa_fraction_digit_count > 0);
                    handler.number_value(mantissa_whole_part,
                            mantissa_fraction_numerator,
                            mantissa_fraction_digit_count, 0);
                    current_state = value_done_state();
                    continue;
                  }
                case ParseState.PS_NUMBER_E:
                  {
                    unexpected("a plus or minus sign or a digit");
                    return;
                  }
                case ParseState.PS_NUMBER_E_SIGN:
                  {
                    unexpected("a digit");
                    return;
                  }
                case ParseState.PS_NUMBER_E_SIGN_DIGIT:
                  {
                    if (mantissa_fraction_digit_count == 0)
                        mantissa_fraction_numerator = 0;
                    handler.number_value(mantissa_whole_part,
                            mantissa_fraction_numerator,
                            mantissa_fraction_digit_count, exponent);
                    current_state = value_done_state();
                    continue;
                  }
                case ParseState.PS_ARRAY_BASE:
                  {
                    unexpected("a value or `]'");
                    return;
                  }
                case ParseState.PS_ARRAY_VALUE:
                  {
                    unexpected("a `]' or `,'");
                    return;
                  }
                case ParseState.PS_OBJECT_BASE:
                  {
                    unexpected("a string or `}'");
                    return;
                  }
                case ParseState.PS_OBJECT_LABEL:
                  {
                    unexpected("a colon");
                    return;
                  }
                case ParseState.PS_OBJECT_VALUE:
                  {
                    unexpected("a `}' or `,'");
                    return;
                  }
                case ParseState.PS_OBJECT_COMMA:
                  {
                    unexpected("a string");
                    return;
                  }
                default:
                  {
                    Debug.Assert(false);
                    return;
                  }
              }
          }
      }
  };
