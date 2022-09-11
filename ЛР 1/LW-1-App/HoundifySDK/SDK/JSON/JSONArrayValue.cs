/* file "JSONArrayValue.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */

using System.Collections.Generic;
using System.Diagnostics;


public class JSONArrayValue : JSONValue
  {
    private List<JSONValue> values;

    public JSONArrayValue()
      {
        values = new List<JSONValue>();
      }

    public override Kind kind()  { return Kind.JVK_ARRAY; }
    public int componentCount()  { return values.Count; }
    public JSONValue component(int component_num)
      {
        Debug.Assert(component_num < values.Count);
        return values[component_num];
      }

    public override void write(JSONHandler handler)
      {
        handler.start_array();
        int count = values.Count;
        for (int num = 0; num < count; ++num)
            values[num].write(handler);
        handler.finish_array();
      }
    public override JSONArrayValue array_value()  { return this; }

    public void appendComponent(JSONValue new_component)
      {
        Debug.Assert(new_component != null);
        values.Add(new_component);
      }
  }
