/* file "JSONBooleanGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Diagnostics;
using System.Numerics;


public abstract class JSONBooleanGenerator : JSONCheckingHandler
  {
    protected JSONBooleanGenerator()
      {
      }

    protected JSONBooleanGenerator(string what)
      {
        set_what(what);
      }

    protected abstract void handle_result(bool result);
    protected virtual void validate(bool result)  { }

    public override void true_value()
      {
        boolean_value(true);
      }

    public override void false_value()
      {
        boolean_value(false);
      }

    public override void boolean_value(bool to_write)
      {
        validate(to_write);
        handle_result(to_write);
      }

    public override void null_value()
      {
        error("Expected a boolean value for %what%, found null.");
      }

    public override void string_value(string to_write)
      {
        error("Expected a boolean value for %what%, found the string \"{0}\".",
              to_write);
      }

    public override void number_value(int to_write)
      {
        error("Expected a boolean value for %what%, found the integer {0}.",
              to_write);
      }

    public override void number_value(long to_write)
      {
        error("Expected a boolean value for %what%, found the integer {0}.",
              to_write);
      }

    public override void number_value(BigInteger to_write)
      {
        bad_integer(to_write, "a boolean value");
      }

    public override void number_value(double to_write, int precision)
      {
        error("Expected a boolean value for %what%, found the rational {0:f}.",
              precision, to_write);
      }

    public override void number_value(BigInteger mantissa_whole_part,
            BigInteger mantissa_fraction_numerator,
            int mantissa_fraction_digit_count, BigInteger exponent)
      {
        bad_number(mantissa_whole_part, mantissa_fraction_numerator,
                   mantissa_fraction_digit_count, exponent, "a boolean value");
      }

    public override void number_value(string number_text)
      {
        error("Expected a boolean value for %what%, found the number {0}.",
              number_text);
      }

    public override void start_object()
      {
        error("Expected a boolean value for %what%, found an object.");
      }

    public override void start_pair(string name)
      {
        Debug.Assert(false);
      }

    public override void pair(string name, string new_string_value)
      {
        Debug.Assert(false);
      }

    public override void pair(string name, bool value)
      {
        Debug.Assert(false);
      }

    public override void pair(string name, int value)
      {
        Debug.Assert(false);
      }

    public override void pair(string name, long value)
      {
        Debug.Assert(false);
      }

    public override void pair(string name, double value, int precision)
      {
        Debug.Assert(false);
      }

    public override void finish_object()
      {
        Debug.Assert(false);
      }

    public override void start_array()
      {
        error("Expected a boolean value for %what%, found an array.");
      }

    public override void finish_array()
      {
        Debug.Assert(false);
      }
  };
