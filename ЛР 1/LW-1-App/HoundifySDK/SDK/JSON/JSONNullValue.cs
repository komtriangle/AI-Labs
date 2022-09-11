/* file "JSONNullValue.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */


public class JSONNullValue : JSONValue
  {
    public JSONNullValue()  { }

    public override Kind kind()  { return Kind.JVK_NULL; }
    public override void write(JSONHandler handler)  { handler.null_value(); }
    public override JSONNullValue null_value()  { return this; }
  }
