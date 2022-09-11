/* file "JSONHoldingIntegerUnboundRangeGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Diagnostics;
using System.Numerics;


public class JSONHoldingIntegerUnboundRangeGenerator :
        JSONIntegerUnboundRangeGenerator
  {
    protected override void handle_result(BigInteger result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public JSONHoldingIntegerUnboundRangeGenerator(string what)
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
