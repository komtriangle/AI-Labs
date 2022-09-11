/* file "JSONHoldingIntegerLowerBoundOnlyArrayGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Numerics;
using System.Diagnostics;
using System.Collections.Generic;


public class JSONHoldingIntegerLowerBoundOnlyArrayGenerator : JSONArrayGenerator
  {
    private class ElementHandler : JSONIntegerLowerBoundOnlyGenerator
      {
        private JSONHoldingIntegerLowerBoundOnlyArrayGenerator top;

        protected override void handle_result(BigInteger result)
          {
            top.value.Add(result);
          }

        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(
                JSONHoldingIntegerLowerBoundOnlyArrayGenerator init_top,
                BigInteger init_lower_bound) : base(init_lower_bound)
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

    public JSONHoldingIntegerLowerBoundOnlyArrayGenerator(string what,
            BigInteger init_lower_bound)
      {
        element_handler = new ElementHandler(this, init_lower_bound);
        have_value = false;
        value = new List<BigInteger>();
        base.set_what(what);
      }

    public JSONHoldingIntegerLowerBoundOnlyArrayGenerator(
            BigInteger init_lower_bound)
      {
        element_handler = new ElementHandler(this, init_lower_bound);
        have_value = false;
        value = new List<BigInteger>();
      }

    public JSONHoldingIntegerLowerBoundOnlyArrayGenerator(long init_lower_bound)
      {
        element_handler = new ElementHandler(this, init_lower_bound);
        have_value = false;
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
