/* file "JSONStringValue.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */


public class JSONStringValue : JSONValue
  {
    private string data;

    public JSONStringValue(string init_data)
      {
        data = init_data;
      }

    public override Kind kind()  { return Kind.JVK_STRING; }
    public string getData()  { return data; }
    public override void write(JSONHandler handler)
      { handler.string_value(data); }
    public override JSONStringValue string_value()  { return this; }
  }
