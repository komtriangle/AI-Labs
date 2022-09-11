/* file "JSONCoreIntegerGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Numerics;
using System.Diagnostics;


public abstract class JSONCoreIntegerGenerator : JSONIntegerGenerator
  {
    protected JSONCoreIntegerGenerator()
      {
      }

    protected abstract void handle_result(BigInteger result);

    public override void number_value(double to_write, int precision)
      {
        number_value(string.Format("%*e", precision, to_write));
      }

    public override void number_value(BigInteger mantissa_whole_part,
            BigInteger mantissa_fraction_numerator,
            int mantissa_fraction_digit_count, BigInteger exponent)
      {
        string all_digits = "";
        if (mantissa_whole_part == 0 && mantissa_fraction_numerator < 0)
          {
            all_digits += "-";
          }
        all_digits += mantissa_whole_part.ToString();
        BigInteger new_exponent = exponent;
        if (mantissa_fraction_digit_count > 0)
          {
            string fraction_string = mantissa_fraction_numerator.ToString();
            string fraction_digits_string =
                    ((mantissa_fraction_numerator < 0) ?
                     fraction_string.Substring(1) : fraction_string);
            int non_zero_count = fraction_digits_string.Length;
            while (non_zero_count < mantissa_fraction_digit_count)
              {
                all_digits += '0';
                ++non_zero_count;
              }
            all_digits += fraction_digits_string.ToString();
            new_exponent = new_exponent - mantissa_fraction_digit_count;
          }
        BigInteger result;
        if (new_exponent < 0)
          {
            int count = all_digits.Length;
            while (new_exponent != 0)
              {
                if (count == 0)
                  {
                    number_value((BigInteger)0);
                    return;
                  }
                --count;
                if (all_digits[count] != '0')
                  {
                    error("Expected an integer value for %what%, found a " +
                          "non-integer number.");
                  }
                new_exponent = new_exponent + 1;
              }
            result = BigInteger.Parse(all_digits);
          }
        else
          {
            while (new_exponent != 0)
              {
                all_digits += "0";
                new_exponent = new_exponent - 1;
              }
            result = BigInteger.Parse(all_digits);
          }
        number_value(result);
      }

    public override void number_value(string number_text)
      {
        Debug.Assert(number_text != null);

        bool is_negative = false;
        int follow = 0;
        if (number_text.Length > follow)
          {
            if (number_text[follow] == '-')
              {
                is_negative = true;
                ++follow;
              }
            else if (number_text[follow] == '+')
              {
                ++follow;
              }
          }
        while ((number_text.Length > follow) && (number_text[follow] >= '0') &&
               (number_text[follow] <= '9'))
          {
            ++follow;
          }
        BigInteger mantissa_whole_part =
                BigInteger.Parse(number_text.Substring(0, follow));
        if (number_text.Length == follow)
          {
            number_value(mantissa_whole_part);
            return;
          }
        BigInteger mantissa_fraction_numerator;
        int fraction_digit_count;
        if (number_text[follow] != '.')
          {
            mantissa_fraction_numerator = 0;
            fraction_digit_count = 0;
          }
        else
          {
            ++follow;
            int start = follow;
            while ((number_text.Length > follow) &&
                   (number_text[follow] >= '0') && (number_text[follow] <= '9'))
              {
                ++follow;
              }
            fraction_digit_count = follow - start;
            if (fraction_digit_count == 0)
              {
                mantissa_fraction_numerator = 0;
              }
            else
              {
                mantissa_fraction_numerator = BigInteger.Parse(
                        number_text.Substring(start, follow - start));
                if (is_negative)
                    mantissa_fraction_numerator = -mantissa_fraction_numerator;
              }
          }
        BigInteger exponent;
        if ((number_text.Length > follow) && (number_text[follow] != 'e') &&
            (number_text[follow] != 'E'))
          {
            exponent = 0;
          }
        else
          {
            ++follow;
            int start = follow;
            if (number_text.Length > follow)
              {
                if ((number_text[follow] == '-') ||
                    (number_text[follow] == '+'))
                  {
                    ++follow;
                  }
              }
            while ((number_text.Length > follow) &&
                   (number_text[follow] >= '0') && (number_text[follow] <= '9'))
              {
                ++follow;
              }
            exponent = BigInteger.Parse(
                    number_text.Substring(start, follow - start));
          }
        Debug.Assert(number_text.Length == follow);
        number_value(mantissa_whole_part, mantissa_fraction_numerator,
                     fraction_digit_count, exponent);
      }
  };
