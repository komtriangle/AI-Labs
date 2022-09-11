/* file "JSONHoldingValueGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Diagnostics;


public class JSONHoldingValueGenerator : JSONValueHandler
  {
    protected override void handle_result(JSONValue result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public JSONHoldingValueGenerator(string what) : base()
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
    public JSONValue value;
  };
