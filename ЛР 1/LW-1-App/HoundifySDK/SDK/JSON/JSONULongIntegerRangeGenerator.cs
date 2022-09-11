/* file "JSONULongIntegerRangeGenerator.cs" */

/* Copyright 2015-2018 SoundHound, Incorporated.  All rights reserved. */

using System.Numerics;
using System.Diagnostics;


public abstract class JSONULongIntegerRangeGenerator :
        JSONIntegerRangeBaseGenerator
  {
    private ulong ulong_lower_bound;
    private ulong ulong_upper_bound;

    private void too_big(string number_text)
      {
        error("Expected an integer less than or equal to {0} for %what%, " +
              "found {1}.", ulong_upper_bound, number_text);
      }
    private void too_small(string number_text)
      {
        error("Expected an integer greater than or equal to {0} for %what%, " +
              "found {1}.", ulong_lower_bound, number_text);
      }

    protected JSONULongIntegerRangeGenerator(ulong lower_bound,
            ulong upper_bound) : base(lower_bound, upper_bound)
      {
        ulong_lower_bound = lower_bound;
        ulong_upper_bound = upper_bound;
      }

    protected override void handle_result(BigInteger result)
      {
        handle_result((ulong)result);
      }
    protected abstract void handle_result(ulong result);

    public override void number_value(int to_write)
      {
        if ((to_write < 0) || (((ulong)to_write) < ulong_lower_bound))
          {
            error("Expected an integer greater than or equal to {0} for " +
                  "%what%, found {1}.", ulong_lower_bound, to_write);
          }
        if (((ulong)to_write) > ulong_upper_bound)
          {
            error("Expected an integer less than or equal to {0} for %what%, " +
                  "found {1}.", ulong_upper_bound, to_write);
          }
        handle_result(to_write);
      }
    public override void number_value(long to_write)
      {
        if ((to_write < 0) || (((ulong)to_write) < ulong_lower_bound))
          {
            error("Expected an integer greater than or equal to {0} for " +
                  "%what%, found {1}.", ulong_lower_bound, to_write);
          }
        if (((ulong)to_write) > ulong_upper_bound)
          {
            error("Expected an integer less than or equal to {0} for %what%, " +
                  "found {1}.", ulong_upper_bound, to_write);
          }
        handle_result(to_write);
      }

    public override void number_value(string number_text)
      {
        Debug.Assert(number_text != null);

        int digits = 0;
        if (number_text[digits] == '-')
          {
            too_small(number_text);
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
        ulong result = 0;
        while (number_text.Length > digits)
          {
            Debug.Assert((number_text[digits] >= '0') &&
                         (number_text[digits] <= '9'));
            ulong addition = (ulong)(number_text[digits] - '0');
            if (result > (ulong_upper_bound - addition) / 10)
                too_big(number_text);
            result *= 10;
            result += addition;
            ++digits;
          }
        if (result < ulong_lower_bound)
            too_small(number_text);
        if (result > ulong_upper_bound)
            too_big(number_text);
        handle_result(result);
      }
  };
