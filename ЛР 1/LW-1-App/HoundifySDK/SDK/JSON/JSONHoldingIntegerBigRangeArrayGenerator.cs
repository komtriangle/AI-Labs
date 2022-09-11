/* file "JSONHoldingIntegerBigRangeArrayGenerator.cs" */

/* Copyright 2015-2018 SoundHound, Incorporated.  All rights reserved. */

using System.Numerics;
using System.Diagnostics;
using System.Collections.Generic;


public class JSONHoldingIntegerBigRangeArrayGenerator : JSONArrayGenerator
  {
    private class ElementHandler : JSONIntegerBigRangeGenerator
      {
        private JSONHoldingIntegerBigRangeArrayGenerator top;

        protected override void handle_result(BigInteger result)
          {
            top.value.Add(result);
          }

        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(JSONHoldingIntegerBigRangeArrayGenerator init_top,
                BigInteger lower_bound, BigInteger upper_bound) :
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

    protected void handle_result(List<BigInteger> result)
      {
      }

    public JSONHoldingIntegerBigRangeArrayGenerator(string what,
            BigInteger lower_bound, BigInteger upper_bound)
      {
        element_handler = new ElementHandler(this, lower_bound, upper_bound);
        have_value = false;
        value = new List<BigInteger>();
        base.set_what(what);
      }

    public JSONHoldingIntegerBigRangeArrayGenerator(BigInteger lower_bound,
                                                    BigInteger upper_bound)
      {
        element_handler = new ElementHandler(this, lower_bound, upper_bound);
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
