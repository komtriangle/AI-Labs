/* file "JSONArrayGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Numerics;
using System.Diagnostics;


public abstract class JSONArrayGenerator : JSONCheckingHandler
  {
    private int depth;
    private JSONHandler element_handler;

    protected JSONArrayGenerator()
      {
        depth = 0;
        element_handler = null;
      }

    protected abstract JSONHandler start();
    protected abstract void finish();

    public override void true_value()
      {
        if (depth == 0)
            error("Expected an array value for %what%, found true.");
        Debug.Assert(element_handler != null);
        element_handler.true_value();
      }

    public override void false_value()
      {
        if (depth == 0)
            error("Expected an array value for %what%, found false.");
        Debug.Assert(element_handler != null);
        element_handler.false_value();
      }

    public override void boolean_value(bool to_write)
      {
        if (depth == 0)
          {
            error("Expected an array value for %what%, found {0}.",
                  (to_write ? "true" : "false"));
          }
        Debug.Assert(element_handler != null);
        element_handler.boolean_value(to_write);
      }

    public override void null_value()
      {
        if (depth == 0)
            error("Expected an array value for %what%, found null.");
        Debug.Assert(element_handler != null);
        element_handler.null_value();
      }

    public override void string_value(string to_write)
      {
        if (depth == 0)
          {
            error("Expected an array value for %what%, found the string " +
                  "\"{0}\".", to_write);
          }
        Debug.Assert(element_handler != null);
        element_handler.string_value(to_write);
      }

    public override void number_value(int to_write)
      {
        if (depth == 0)
          {
            error("Expected an array value for %what%, found the integer {0}.",
                  to_write);
          }
        Debug.Assert(element_handler != null);
        element_handler.number_value(to_write);
      }

    public override void number_value(long to_write)
      {
        if (depth == 0)
          {
            error("Expected an array value for %what%, found the integer {0}.",
                  to_write);
          }
        Debug.Assert(element_handler != null);
        element_handler.number_value(to_write);
      }

    public override void number_value(BigInteger to_write)
      {
        if (depth == 0)
            bad_integer(to_write, "an array value");
        Debug.Assert(element_handler != null);
        element_handler.number_value(to_write);
      }

    public override void number_value(double to_write, int precision)
      {
        if (depth == 0)
          {
            error("Expected an array value for %what%, found the rational " +
                  string.Format("{{0:f{0}}}.", precision), to_write);
          }
        Debug.Assert(element_handler != null);
        element_handler.number_value(to_write, precision);
      }

    public override void number_value(BigInteger mantissa_whole_part,
            BigInteger mantissa_fraction_numerator,
            int mantissa_fraction_digit_count, BigInteger exponent)
      {
        if (depth == 0)
          {
            bad_number(mantissa_whole_part, mantissa_fraction_numerator,
                    mantissa_fraction_digit_count, exponent, "an array value");
          }
        Debug.Assert(element_handler != null);
        element_handler.number_value(mantissa_whole_part,
                mantissa_fraction_numerator, mantissa_fraction_digit_count,
                exponent);
      }

    public override void number_value(string number_text)
      {
        if (depth == 0)
          {
            error("Expected an array value for %what%, found the number {0}.",
                  number_text);
          }
        Debug.Assert(element_handler != null);
        element_handler.number_value(number_text);
      }

    public override void start_object()
      {
        if (depth == 0)
            error("Expected an array value for %what%, found an object.");
        ++depth;
        Debug.Assert(element_handler != null);
        element_handler.start_object();
      }

    public override void start_pair(string name)
      {
        Debug.Assert(name != null);

        Debug.Assert(depth > 1);
        Debug.Assert(element_handler != null);
        element_handler.start_pair(name);
      }

    public override void pair(string name, string new_string_value)
      {
        start_pair(name);
        string_value(new_string_value);
      }

    public override void pair(string name, bool value)
      {
        start_pair(name);
        boolean_value(value);
      }

    public override void pair(string name, int value)
      {
        start_pair(name);
        number_value(value);
      }

    public override void pair(string name, long value)
      {
        start_pair(name);
        number_value(value);
      }

    public override void pair(string name, double value, int precision)
      {
        start_pair(name);
        number_value(value, precision);
      }

    public override void finish_object()
      {
        Debug.Assert(depth > 1);
        --depth;
        Debug.Assert(element_handler != null);
        element_handler.finish_object();
      }

    public override void start_array()
      {
        if (depth == 0)
          {
            Debug.Assert(element_handler == null);
            element_handler = start();
          }
        else
          {
            Debug.Assert(element_handler != null);
            element_handler.start_array();
          }
        ++depth;
      }

    public override void finish_array()
      {
        Debug.Assert(depth > 0);
        --depth;
        Debug.Assert(element_handler != null);
        if (depth == 0)
          {
            element_handler = null;
            finish();
          }
        else
          {
            element_handler.finish_array();
          }
      }

    public override void reset()
      {
        depth = 0;
        element_handler = null;
      }
  };
