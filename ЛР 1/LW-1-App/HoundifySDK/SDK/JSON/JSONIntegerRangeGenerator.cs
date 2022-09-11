/* file "JSONIntegerRangeGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Numerics;
using System.Diagnostics;


public abstract class JSONIntegerRangeGenerator : JSONIntegerRangeBaseGenerator
  {
    private long long_lower_bound;
    private long long_upper_bound;

    private void too_big(string number_text)
      {
        error("Expected an integer less than or equal to {0} for %what%, " +
              "found {1}.", long_upper_bound, number_text);
      }
    private void too_small(string number_text)
      {
        error("Expected an integer greater than or equal to {0} for %what%, " +
              "found {1}.", long_lower_bound, number_text);
      }

    protected JSONIntegerRangeGenerator(long lower_bound, long upper_bound) :
            base(lower_bound, upper_bound)
      {
        long_lower_bound = lower_bound;
        long_upper_bound = upper_bound;
      }

    protected override void handle_result(BigInteger result)
      {
        handle_result((long)result);
      }
    protected abstract void handle_result(long result);

    public override void number_value(int to_write)
      {
        if (to_write < long_lower_bound)
          {
            error("Expected an integer greater than or equal to {0} for " +
                  "%what%, found {1}.", long_lower_bound, to_write);
          }
        if (to_write > long_upper_bound)
          {
            error("Expected an integer less than or equal to {0} for %what%, " +
                  "found {1}.", long_upper_bound, to_write);
          }
        handle_result(to_write);
      }
    public override void number_value(long to_write)
      {
        if (to_write < long_lower_bound)
          {
            error("Expected an integer greater than or equal to {0} for " +
                  "%what%, found {1}.", long_lower_bound, to_write);
          }
        if (to_write > long_upper_bound)
          {
            error("Expected an integer less than or equal to {0} for %what%, " +
                  "found {1}.", long_upper_bound, to_write);
          }
        handle_result(to_write);
      }

    public override void number_value(string number_text)
      {
        Debug.Assert(number_text != null);

        bool is_negative = false;
        int digits = 0;
        if (number_text[digits] == '-')
          {
            is_negative = true;
            ++digits;
          }
        else if (number_text[digits] == '+')
          {
            ++digits;
          }
          {
            int follow = digits;
            while (number_text.Length > follow)
              {
                if ((number_text[digits] < '0') ||
                    (number_text[digits] > '9'))
                  {
                    base.number_value(number_text);
                    return;
                  }
                ++follow;
              }
          }
        if ((long_upper_bound < 0) && !is_negative)
          {
            too_big(number_text);
          }
        if ((long_lower_bound > 0) && is_negative)
          {
            too_small(number_text);
          }
        long result = 0;
        while (number_text.Length > digits)
          {
            Debug.Assert((number_text[digits] >= '0') &&
                         (number_text[digits] <= '9'));
            long addition = number_text[digits] - '0';
            if (is_negative)
                addition = -addition;
            if (long_upper_bound < 0)
              {
                if (result < -(((-long_upper_bound) + addition) / 10))
                    too_small(number_text);
              }
            else
              {
                if (result > (long_upper_bound - addition) / 10)
                    too_big(number_text);
              }
            result *= 10;
            result += addition;
            ++digits;
          }
        if (result < long_lower_bound)
            too_small(number_text);
        if (result > long_upper_bound)
            too_big(number_text);
        handle_result(result);
      }
  };
