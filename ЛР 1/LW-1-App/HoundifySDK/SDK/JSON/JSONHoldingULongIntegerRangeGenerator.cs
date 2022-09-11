/* file "JSONHoldingULongIntegerRangeGenerator.cs" */

/* Copyright 2015-2018 SoundHound, Incorporated.  All rights reserved. */

using System.Diagnostics;


public class JSONHoldingULongIntegerRangeGenerator :
        JSONULongIntegerRangeGenerator
  {
    protected override void handle_result(ulong result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public JSONHoldingULongIntegerRangeGenerator(string what, ulong lower_bound,
            ulong upper_bound) : base(lower_bound, upper_bound)
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
    public ulong value;
  };
