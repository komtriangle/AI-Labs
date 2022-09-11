/* file "JSONHoldingNumberTextGenerator.java" */

/* Copyright 2015-2018 SoundHound, Incorporated.  All rights reserved. */

using System.Diagnostics;


public class JSONHoldingNumberTextGenerator : JSONNumberTextGenerator
  {
    protected override void handle_result(string result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public JSONHoldingNumberTextGenerator(string what)
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
    public string value;
  };
