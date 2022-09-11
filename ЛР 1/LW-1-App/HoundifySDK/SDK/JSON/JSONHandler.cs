/* file "JSONHandler.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */

using System.Numerics;
using System.Diagnostics;


public abstract class JSONHandler
  {
    protected JSONHandler()  { }

    public virtual void true_value()  { }
    public virtual void false_value()  { }
    public virtual void boolean_value(bool to_write)  { }
    public virtual void null_value()  { }
    public virtual void string_value(string to_write)  { }
    public virtual void number_value(int to_write)  { }
    public virtual void number_value(long to_write)  { }
    public virtual void number_value(BigInteger to_write)  { }
    public virtual void number_value(double to_write, int precision)  { }
    public virtual void number_value(double to_write)
      { number_value(to_write, 15); }
    public virtual void number_value(BigInteger mantissa_whole_part,
            BigInteger mantissa_fraction_numerator,
            int mantissa_fraction_digit_count, BigInteger exponent)  { }
    public virtual void number_value(string number_text)  { }
    public virtual void start_object()  { }
    public virtual void start_pair(string name)  { }
    public virtual void pair(string name, string string_value)  { }
    public virtual void pair(string name, bool value)  { }
    public virtual void pair(string name, int value)  { }
    public virtual void pair(string name, long value)  { }
    public virtual void pair(string name, double value, int precision)  { }
    public virtual void pair(string name, double value)
      { pair(name, value, 15); }
    public virtual void finish_object()  { }
    public virtual void start_array()  { }
    public virtual void finish_array()  { }

    public virtual void reset()  { }

    public virtual void pair(string name, char value)
      {
        Debug.Assert(false);
      }
    public virtual void string_pair(string name, int code_point)
      {
        pair(name, char.ConvertFromUtf32(code_point));
      }
  }
