/* file "JSONObjectValue.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */

using System.Collections.Generic;
using System.Diagnostics;


public class JSONObjectValue : JSONValue
  {
    private List<string> keys;
    private List<JSONValue> values;
    private Dictionary<string, JSONValue> index;

    public JSONObjectValue()
      {
        keys = new List<string>();
        values = new List<JSONValue>();
        index = new Dictionary<string, JSONValue>();
      }

    public override Kind kind()  { return Kind.JVK_OBJECT; }
    public int componentCount()  { return values.Count; }
    public string componentKey(int component_num)
      {
        Debug.Assert(keys.Count == values.Count);
        Debug.Assert(component_num < values.Count);
        return keys[component_num];
      }
    public JSONValue componentValue(int component_num)
      {
        Debug.Assert(keys.Count == values.Count);
        Debug.Assert(component_num < values.Count);
        return values[component_num];
      }
    public JSONValue lookup(string field_name)
      {
        return (index.ContainsKey(field_name) ? index[field_name] : null);
      }

    public override void write(JSONHandler handler)
      {
        handler.start_object();
        int count = keys.Count;
        Debug.Assert(count == values.Count);
        for (int num = 0; num < count; ++num)
          {
            handler.start_pair(keys[num]);
            values[num].write(handler);
          }
        handler.finish_object();
      }
    public override JSONObjectValue object_value()  { return this; }

    public void appendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(keys.Count == values.Count);
        keys.Add(key);
        values.Add(new_component);
        index.Add(key, new_component);
      }
    public void setField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = lookup(key);
        if (old_field == null)
          {
            appendPair(key, new_component);
          }
        else
          {
            int count = keys.Count;
            Debug.Assert(count == values.Count);
            for (int num = 0; num < count; ++num)
              {
                if (keys[num].Equals(key))
                  {
                    values[num] = new_component;
                    break;
                  }
              }
            index.Add(key, new_component);
          }
      }
  }
