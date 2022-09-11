/* file "JSONHoldingIntegerLowerBoundOnlyGenerator.cs" */

/* Copyright 2015-2018 SoundHound, Incorporated.  All rights reserved. */

using System.Numerics;
using System.Diagnostics;


public class JSONHoldingIntegerLowerBoundOnlyGenerator :
        JSONIntegerLowerBoundOnlyGenerator
  {
    protected override void handle_result(BigInteger result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public JSONHoldingIntegerLowerBoundOnlyGenerator(string what,
            BigInteger init_lower_bound) : base(init_lower_bound)
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
