/* file "JSONHoldingIntegerBigRangeGenerator.cs" */

/* Copyright 2015-2018 SoundHound, Incorporated.  All rights reserved. */

using System.Numerics;
using System.Diagnostics;


public class JSONHoldingIntegerBigRangeGenerator : JSONIntegerBigRangeGenerator
  {
    protected override void handle_result(BigInteger result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public JSONHoldingIntegerBigRangeGenerator(string what,
            BigInteger lower_bound, BigInteger upper_bound) :
                    base(lower_bound, upper_bound)
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
    public BigInteger value;
  };
