/* file "JSONHoldingDoubleGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Diagnostics;


public class JSONHoldingDoubleGenerator : JSONDoubleGenerator
  {
    protected override void handle_result(double result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public JSONHoldingDoubleGenerator(string what)
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
    public double value;
  };
