/* file "JSONParallelGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System;
using System.Diagnostics;
using System.Numerics;


public abstract class JSONParallelGenerator : JSONCheckingHandler
  {
    private int depth;
    private JSONHandler[] parallel_handlers;
    private bool[] parallel_active;
    private string[] parallel_errors;

    private void pre_value()
      {
        if (depth > 0)
            return;
        Debug.Assert(parallel_handlers == null);
        Debug.Assert(parallel_active == null);
        Debug.Assert(parallel_errors == null);
        parallel_handlers = start();
        Debug.Assert(parallel_handlers != null);
        parallel_active = new bool[parallel_handlers.Length];
        parallel_errors = new string[parallel_handlers.Length];
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            parallel_active[parallel_num] = true;
            parallel_errors[parallel_num] = null;
          }
      }

    private void post_value()
      {
        if (depth > 0)
            return;
        int winning_index = 0;
        while (true)
          {
            if (winning_index >= parallel_handlers.Length)
              {
                string message = "None of the options for %what% matched.";
                for (int other_index = 0;
                     other_index < parallel_handlers.Length; ++other_index)
                  {
                    Debug.Assert(!(parallel_active[other_index]));
                    Debug.Assert(parallel_errors[other_index] != null);
                    message += "  Option " + other_index +
                               " doesn't match because `" +
                               parallel_errors[other_index] + "'.\n";
                  }
                parallel_handlers = null;
                parallel_active = null;
                parallel_errors = null;
                error(message);
              }
            if (parallel_active[winning_index])
                break;
            ++winning_index;
          }
        for (int other_index = 0; other_index < winning_index; ++other_index)
          {
            Debug.Assert(!(parallel_active[other_index]));
            Debug.Assert(parallel_errors[other_index] != null);
          }
        finish(winning_index);
        while (winning_index < parallel_handlers.Length)
          {
            if (parallel_active[winning_index])
              {
                Debug.Assert(parallel_errors[winning_index] == null);
                parallel_handlers[winning_index].reset();
              }
            else
              {
                Debug.Assert(parallel_errors[winning_index] != null);
              }
            ++winning_index;
          }
        parallel_handlers = null;
        parallel_active = null;
        parallel_errors = null;
      }

    protected JSONParallelGenerator()
      {
        depth = 0;
        parallel_handlers = null;
        parallel_active = null;
        parallel_errors = null;
      }

    protected abstract JSONHandler[] start();
    protected abstract void finish(int winning_index);

    public override void true_value()
      {
        pre_value();
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].true_value();
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
        post_value();
      }

    public override void false_value()
      {
        pre_value();
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].false_value();
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
        post_value();
      }

    public override void boolean_value(bool to_write)
      {
        pre_value();
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].boolean_value(to_write);
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
        post_value();
      }

    public override void null_value()
      {
        pre_value();
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].null_value();
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
        post_value();
      }

    public override void string_value(string to_write)
      {
        pre_value();
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].string_value(to_write);
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
        post_value();
      }

    public override void number_value(int to_write)
      {
        pre_value();
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].number_value(to_write);
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
        post_value();
      }

    public override void number_value(long to_write)
      {
        pre_value();
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].number_value(to_write);
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
        post_value();
      }

    public override void number_value(BigInteger to_write)
      {
        pre_value();
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].number_value(to_write);
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
        post_value();
      }

    public override void number_value(double to_write, int precision)
      {
        pre_value();
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].number_value(to_write,
                                                                 precision);
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
        post_value();
      }

    public override void number_value(BigInteger mantissa_whole_part,
            BigInteger mantissa_fraction_numerator,
            int mantissa_fraction_digit_count, BigInteger exponent)
      {
        pre_value();
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].number_value(
                            mantissa_whole_part, mantissa_fraction_numerator,
                            mantissa_fraction_digit_count, exponent);
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
        post_value();
      }

    public override void number_value(string number_text)
      {
        pre_value();
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].number_value(number_text);
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
        post_value();
      }

    public override void start_object()
      {
        pre_value();
        ++depth;
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].start_object();
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
      }

    public override void start_pair(string name)
      {
        Debug.Assert(depth > 0);
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].start_pair(name);
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
      }

    public override void pair(string name, string new_string_value)
      {
        Debug.Assert(depth > 0);
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].pair(name,
                                                         new_string_value);
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
      }

    public override void pair(string name, bool value)
      {
        Debug.Assert(depth > 0);
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].pair(name, value);
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
      }

    public override void pair(string name, int value)
      {
        Debug.Assert(depth > 0);
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].pair(name, value);
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
      }

    public override void pair(string name, long value)
      {
        Debug.Assert(depth > 0);
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].pair(name, value);
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
      }

    public override void pair(string name, double value, int precision)
      {
        Debug.Assert(depth > 0);
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].pair(name, value,
                                                         precision);
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
      }

    public override void finish_object()
      {
        Debug.Assert(depth > 0);
        --depth;
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].finish_object();
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
        post_value();
      }

    public override void start_array()
      {
        pre_value();
        ++depth;
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].start_array();
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
      }

    public override void finish_array()
      {
        Debug.Assert(depth > 0);
        --depth;
        for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
             ++parallel_num)
          {
            if (parallel_active[parallel_num])
              {
                Debug.Assert(parallel_errors[parallel_num] == null);
                try
                  {
                    parallel_handlers[parallel_num].finish_array();
                  }
                catch (Exception e1)
                  {
                    parallel_active[parallel_num] = false;
                    parallel_errors[parallel_num] = e1.Message;
                    parallel_handlers[parallel_num].reset();
                  }
              }
          }
        post_value();
      }

    public override void reset()
      {
        depth = 0;
        if (parallel_handlers != null)
          {
            for (int parallel_num = 0; parallel_num < parallel_handlers.Length;
                 ++parallel_num)
              {
                if (parallel_active[parallel_num])
                  {
                    Debug.Assert(parallel_errors[parallel_num] == null);
                    parallel_handlers[parallel_num].reset();
                  }
                else
                  {
                    Debug.Assert(parallel_errors[parallel_num] != null);
                  }
              }
          }
        parallel_handlers = null;
        parallel_active = null;
        parallel_errors = null;
      }
  };
