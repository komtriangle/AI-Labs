/* file "JSONHoldingIntegerRangeGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Diagnostics;


public class JSONHoldingIntegerRangeGenerator : JSONIntegerRangeGenerator
  {
    protected override void handle_result(long result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public JSONHoldingIntegerRangeGenerator(string what, long lower_bound,
            long upper_bound) : base(lower_bound, upper_bound)
      {
        have_value = false;
        set_what(what);
      }

    public override void reset()
      {
        have_value = false;
        base.reset();
      }

    public bool have_value;
    public long value;
  };
