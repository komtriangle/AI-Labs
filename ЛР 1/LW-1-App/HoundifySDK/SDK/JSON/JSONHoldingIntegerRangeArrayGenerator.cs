/* file "JSONHoldingIntegerRangeArrayGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Diagnostics;
using System.Collections.Generic;


public class JSONHoldingIntegerRangeArrayGenerator : JSONArrayGenerator
  {
    private class ElementHandler : JSONIntegerRangeGenerator
      {
        private JSONHoldingIntegerRangeArrayGenerator top;

        protected override void handle_result(long result)
          {
            top.value.Add(result);
          }

        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(JSONHoldingIntegerRangeArrayGenerator init_top,
                long lower_bound, long upper_bound) :
                        base(lower_bound, upper_bound)
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

    protected void handle_result(List<long> result)
      {
      }

    public JSONHoldingIntegerRangeArrayGenerator(string what, long lower_bound,
                                                 long upper_bound)
      {
        element_handler = new ElementHandler(this, lower_bound, upper_bound);
        have_value = false;
        value = new List<long>();
        base.set_what(what);
      }

    public JSONHoldingIntegerRangeArrayGenerator(long lower_bound,
                                                 long upper_bound)
      {
        element_handler = new ElementHandler(this, lower_bound, upper_bound);
        have_value = false;
        value = new List<long>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<long> value;
  };
