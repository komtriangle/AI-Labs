/* file "JSONHoldingValueArrayGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Collections.Generic;
using System.Diagnostics;


public class JSONHoldingValueArrayGenerator : JSONArrayGenerator
  {
    private class ElementHandler : JSONValueHandler
      {
        private JSONHoldingValueArrayGenerator top;

        protected override void handle_result(JSONValue result)
          {
            top.value.Add(result);
          }

        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(JSONHoldingValueArrayGenerator init_top)
          {
            top = init_top;
          }
      };

    private ElementHandler element_handler;

    protected override JSONHandler start()
      {
        have_value = true;
        value.Clear();
        return element_handler;
      }

    protected override void finish()
      {
        Debug.Assert(have_value);
        handle_result(value);
        element_handler.reset();
      }

    protected virtual void handle_result(List<JSONValue> result)
      {
      }

    public JSONHoldingValueArrayGenerator(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<JSONValue>();
        base.set_what(what);
      }

    public JSONHoldingValueArrayGenerator()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<JSONValue>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<JSONValue> value;
  };
