/* file "JSONCheckingHandler.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System;
using System.Numerics;
using System.Diagnostics;


public class JSONCheckingHandler : JSONHandler
  {
    private string what;

    protected JSONCheckingHandler()
      {
        what = null;
      }

    protected virtual string get_what()
      {
        Debug.Assert(what != null);
        return what;
      }

    protected void set_what(string new_what)
      {
        Debug.Assert(new_what != null);
        what = new_what;
      }

    protected void error(string message, params Object[] arguments)
      {
        Debug.Assert(message != null);
        throw new Exception(string.Format(
                message.Replace("%what%", get_what()), arguments));
      }

    protected void bad_integer(BigInteger the_integer, string expected,
                               params Object[] arguments)
      {
        error("Expected {0} for %what%, found the integer {1}.",
              string.Format(expected, arguments), the_integer.ToString());
      }

    protected void bad_integer(long the_integer, string expected,
                               params Object[] arguments)
      {
        error("Expected {0} for %what%, found the integer {1}.",
              string.Format(expected, arguments), the_integer);
      }

    protected void bad_number(BigInteger mantissa_whole_part,
            BigInteger mantissa_fraction_numerator,
            int mantissa_fraction_digit_count, BigInteger exponent,
            string expected, params Object[] arguments)
      {
        string number_string = mantissa_whole_part.ToString();

        if (mantissa_fraction_numerator != 0)
          {
            number_string += ".";
            string fraction_digits = mantissa_fraction_numerator.ToString();
            int digit_count = fraction_digits.Length;
            Debug.Assert(digit_count <= mantissa_fraction_digit_count);
            while (digit_count < mantissa_fraction_digit_count)
              {
                number_string += "0";
                ++digit_count;
              }
            number_string += fraction_digits;
          }

        if (exponent != 0)
          {
            number_string += "e";
            number_string += exponent.ToString();
          }

        error("Expected {0} for %what%, found the rational {1}.",
              string.Format(expected, arguments), number_string);
      }
  };
