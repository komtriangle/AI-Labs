/* file "JSONHoldingULongIntegerRangeArrayGenerator.cs" */

/* Copyright 2015-2018 SoundHound, Incorporated.  All rights reserved. */

using System.Diagnostics;
using System.Collections.Generic;


public class JSONHoldingULongIntegerRangeArrayGenerator : JSONArrayGenerator
  {
    private class ElementHandler : JSONULongIntegerRangeGenerator
      {
        private JSONHoldingULongIntegerRangeArrayGenerator top;

        protected override void handle_result(ulong result)
          {
            top.value.Add(result);
          }

        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(
                JSONHoldingULongIntegerRangeArrayGenerator init_top,
                ulong lower_bound, ulong upper_bound) :
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

    protected void handle_result(List<ulong> result)
      {
      }

    public JSONHoldingULongIntegerRangeArrayGenerator(string what,
            ulong lower_bound, ulong upper_bound)
      {
        element_handler = new ElementHandler(this, lower_bound, upper_bound);
        have_value = false;
        value = new List<ulong>();
        base.set_what(what);
      }

    public JSONHoldingULongIntegerRangeArrayGenerator(ulong lower_bound,
                                                      ulong upper_bound)
      {
        element_handler = new ElementHandler(this, lower_bound, upper_bound);
        have_value = false;
        value = new List<ulong>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<ulong> value;
  };
