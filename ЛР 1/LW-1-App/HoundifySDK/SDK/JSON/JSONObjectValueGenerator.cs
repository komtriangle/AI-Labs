/* file "JSONObjectValueGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Diagnostics;


public abstract class JSONObjectValueGenerator : JSONObjectGenerator
  {
    private JSONObjectValue value;
    private JSONValueHandler local_field_handler;

    protected JSONObjectValueGenerator()
      {
        local_field_handler = new JSONValueHandler();
      }

    protected override void start()
      {
        Debug.Assert(value == null);
        value = new JSONObjectValue();
      }
    protected override JSONHandler start_field(string field_name)
      {
        Debug.Assert(value != null);
        local_field_handler.result = null;
        return local_field_handler;
      }
    protected override void finish_field(string field_name,
                                         JSONHandler field_handler)
      {
        Debug.Assert(value != null);
        Debug.Assert(field_handler == local_field_handler);
        Debug.Assert(local_field_handler.result != null);
        value.appendPair(field_name, local_field_handler.result);
      }
    protected override void finish()
      {
        Debug.Assert(value != null);
        handle_result(value);
        value = null;
      }
    protected abstract void handle_result(JSONObjectValue result);
  };
