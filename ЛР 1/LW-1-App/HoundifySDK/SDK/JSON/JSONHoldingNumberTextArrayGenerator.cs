/* file "JSONHoldingNumberTextArrayGenerator.cs" */

/* Copyright 2015-2018 SoundHound, Incorporated.  All rights reserved. */

using System.Collections.Generic;
using System.Diagnostics;


public class JSONHoldingNumberTextArrayGenerator : JSONArrayGenerator
  {
    private class ElementHandler : JSONNumberTextGenerator
      {
        private JSONHoldingNumberTextArrayGenerator top;

        protected override void handle_result(string result)
          {
            top.value.Add(result);
          }

        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(JSONHoldingNumberTextArrayGenerator init_top)
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

    protected virtual void handle_result(List<string> result)
      {
      }

    public JSONHoldingNumberTextArrayGenerator(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
        base.set_what(what);
      }

    public JSONHoldingNumberTextArrayGenerator()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
      }

    public void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<string> value;
  };
