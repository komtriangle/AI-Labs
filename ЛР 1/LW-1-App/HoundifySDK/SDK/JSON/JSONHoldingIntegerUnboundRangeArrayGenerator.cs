/* file "JSONHoldingIntegerUnboundRangeArrayGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Numerics;
using System.Diagnostics;
using System.Collections.Generic;


public class JSONHoldingIntegerUnboundRangeArrayGenerator : JSONArrayGenerator
  {
    private class ElementHandler : JSONIntegerUnboundRangeGenerator
      {
        private JSONHoldingIntegerUnboundRangeArrayGenerator top;

        protected override void handle_result(BigInteger result)
          {
            top.value.Add(result);
          }

        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(
                JSONHoldingIntegerUnboundRangeArrayGenerator init_top)
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

    protected void handle_result(List<BigInteger> result)
      {
      }

    public JSONHoldingIntegerUnboundRangeArrayGenerator(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<BigInteger>();
        base.set_what(what);
      }

    public JSONHoldingIntegerUnboundRangeArrayGenerator()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<BigInteger>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<BigInteger> value;
  };
