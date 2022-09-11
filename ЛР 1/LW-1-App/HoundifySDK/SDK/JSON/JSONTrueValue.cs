/* file "JSONTrueValue.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */


public class JSONTrueValue : JSONValue
  {
    public JSONTrueValue()  { }

    public override Kind kind()  { return Kind.JVK_TRUE; }
    public override void write(JSONHandler handler)  { handler.true_value(); }
    public override JSONTrueValue true_value()  { return this; }
  }
