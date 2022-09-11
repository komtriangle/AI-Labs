/* file "JSONNumberTextGenerator.cs" */

/* Copyright 2015-2018 SoundHound, Incorporated.  All rights reserved. */

using System.Numerics;
using System.Diagnostics;


public abstract class JSONNumberTextGenerator : JSONNumberGenerator
  {
    protected JSONNumberTextGenerator()
      {
      }

    protected JSONNumberTextGenerator(string what)
      {
        set_what(what);
      }

    public override void number_value(int to_write)
      {
        handle_result(to_write.ToString());
      }

    public override void number_value(long to_write)
      {
        handle_result(to_write.ToString());
      }

    public override void number_value(BigInteger to_write)
      {
        handle_result(to_write.ToString());
      }

    public override void number_value(double to_write, int precision)
      {
        handle_result(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                string.Format(System.Globalization.CultureInfo.InvariantCulture,
                    "{{0:e{0}}}", precision), to_write));
      }

    public override void number_value(BigInteger mantissa_whole_part,
            BigInteger mantissa_fraction_numerator,
            int mantissa_fraction_digit_count, BigInteger exponent)
      {
        string number_string = "";
        if (mantissa_whole_part == 0)
          {
            if (mantissa_fraction_numerator < 0)
                number_string += '-';
            number_string += '0';
          }
        else
          {
            number_string += mantissa_whole_part.ToString();
          }
        if (mantissa_fraction_digit_count > 0)
          {
            number_string += '.';
            string fraction_string = mantissa_fraction_numerator.ToString();
            if ((fraction_string[0] == '+') || (fraction_string[0] == '-'))
                fraction_string = fraction_string.Substring(1);
            int non_zero_digit_count = fraction_string.Length;
            Debug.Assert(mantissa_fraction_digit_count >= non_zero_digit_count);
            int zero_digit_count =
                    mantissa_fraction_digit_count - non_zero_digit_count;
            while (zero_digit_count > 0)
              {
                number_string += '0';
                --zero_digit_count;
              }
            number_string += fraction_string;
          }
        if (exponent != 0)
          {
            number_string += 'e';
            number_string += exponent.ToString();
          }
        number_value(number_string);
      }

    public override void number_value(string number_text)
      {
        handle_result(number_text);
      }

    protected abstract void handle_result(string result);
  };
