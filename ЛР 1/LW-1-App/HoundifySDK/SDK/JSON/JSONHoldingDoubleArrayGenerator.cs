/* file "JSONHoldingDoubleArrayGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Collections.Generic;
using System.Diagnostics;


public class JSONHoldingDoubleArrayGenerator : JSONArrayGenerator
  {
    private class ElementHandler : JSONDoubleGenerator
      {
        private JSONHoldingDoubleArrayGenerator top;

        protected override void handle_result(double result)
          {
            top.value.Add(result);
          }

        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(JSONHoldingDoubleArrayGenerator init_top)
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

    protected virtual void handle_result(List<double> result)
      {
      }

    public JSONHoldingDoubleArrayGenerator(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<double>();
        base.set_what(what);
      }

    public JSONHoldingDoubleArrayGenerator()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<double>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<double> value;
  };
