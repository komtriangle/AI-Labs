/* file "JSONFalseValue.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */


public class JSONFalseValue : JSONValue
  {
    public JSONFalseValue()  { }

    public override Kind kind()  { return Kind.JVK_FALSE; }
    public override void write(JSONHandler handler)  { handler.false_value(); }
    public override JSONFalseValue false_value()  { return this; }
  }
