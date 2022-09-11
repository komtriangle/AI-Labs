/* file "JSONValueHandler.cs" */

/* Copyright 2012-2018 SoundHound, Incorporated.  All rights reserved. */

using System.Collections.Generic;
using System.Numerics;
using System.Diagnostics;


public class JSONValueHandler : JSONHandler
  {
    private void handle_value(JSONValue item)
      {
        if (stack.Count == 0)
          {
            result = item;
            new_value(result);
            handle_result(result);
          }
        else
          {
            JSONValue top = stack[stack.Count - 1];
            if (top.kind() == JSONValue.Kind.JVK_ARRAY)
              {
                ((JSONArrayValue)top).appendComponent(item);
              }
            else
              {
                Debug.Assert(top.kind() == JSONValue.Kind.JVK_OBJECT);
                ((JSONObjectValue)top).appendPair(label, item);
              }
          }
      }

    protected virtual void set_what(string what)  { }
    protected virtual string get_what()
      {
        Debug.Assert(false);
        return null;
      }

    public JSONValueHandler()
      {
        result = null;
        stack = new List<JSONValue>();
        label_stack = new List<string>();
      }

    public JSONValueHandler(string what)
      {
        result = null;
        stack = new List<JSONValue>();
        label_stack = new List<string>();
      }

    public JSONValue result;
    private List<JSONValue> stack;
    private List<string> label_stack;
    private string label;

    protected virtual void new_value(JSONValue item)  { }
    protected virtual void handle_result(JSONValue item)  { }

    public override void true_value()
      {
        handle_value(new JSONTrueValue());
      }
    public override void false_value()
      {
        handle_value(new JSONFalseValue());
      }
    public override void boolean_value(bool to_write)
      {
        if (to_write)
            true_value();
        else
            false_value();
      }
    public override void null_value()
      {
        handle_value(new JSONNullValue());
      }
    public override void string_value(string to_write)
      {
        handle_value(new JSONStringValue(to_write));
      }
    public override void number_value(int to_write)
      {
        number_value((BigInteger)to_write);
      }
    public override void number_value(long to_write)
      {
        number_value((BigInteger)to_write);
      }
    public override void number_value(BigInteger to_write)
      {
        handle_value(new JSONIntegerValue(to_write));
      }
    public override void number_value(double to_write, int precision)
      {
        handle_value(new JSONRationalValue(to_write, precision));
      }
    public override void number_value(BigInteger mantissa_whole_part,
            BigInteger mantissa_fraction_numerator,
            int mantissa_fraction_digit_count, BigInteger exponent)
      {
        handle_value(new JSONRationalValue(mantissa_whole_part,
                mantissa_fraction_numerator, mantissa_fraction_digit_count,
                exponent, (exponent != 0)));
      }
    public override void number_value(string number_text)
      {
        int follow = 0;
        bool mantissa_is_negative = false;
        if ((follow < number_text.Length) && (number_text[follow] == '-'))
          {
            mantissa_is_negative = true;
            ++follow;
          }
        int mantissa_start = follow;
        while ((follow < number_text.Length) && (number_text[follow] >= '0') &&
               (number_text[follow] <= '9'))
          {
            ++follow;
          }
        BigInteger mantissa_whole_part =
                BigInteger.Parse(number_text.Substring(mantissa_start, follow - mantissa_start));
        if (mantissa_is_negative)
            mantissa_whole_part = -mantissa_whole_part;
        if (follow == number_text.Length)
          {
            number_value(mantissa_whole_part);
            return;
          }
        BigInteger mantissa_fraction_numerator;
        int mantissa_fraction_digit_count;
        if (number_text[follow] == '.')
          {
            ++follow;
            int start_fraction = follow;
            while ((follow < number_text.Length) &&
                   (number_text[follow] >= '0') && (number_text[follow] <= '9'))
              {
                ++follow;
              }
            mantissa_fraction_digit_count = follow - start_fraction;
            mantissa_fraction_numerator = BigInteger.Parse(
                    number_text.Substring(start_fraction, follow));
            if (mantissa_is_negative && (mantissa_whole_part == 0))
                mantissa_fraction_numerator = -mantissa_fraction_numerator;
          }
        else
          {
            mantissa_fraction_numerator = 0;
            mantissa_fraction_digit_count = 0;
          }
        BigInteger exponent;
        bool show_exponent = false;
        bool exponent_plus = false;
        int exponent_prefix_zero_count = 0;
        if ((follow < number_text.Length) &&
            ((number_text[follow] == 'e') || (number_text[follow] == 'E')))
          {
            show_exponent = true;
            ++follow;
            bool exponent_is_negative = false;
            if ((follow < number_text.Length) && (number_text[follow] == '-'))
              {
                exponent_is_negative = true;
                ++follow;
              }
            else if ((follow < number_text.Length) &&
                     (number_text[follow] == '+'))
              {
                exponent_plus = true;
                ++follow;
              }
            int start_exponent = follow;
            while ((follow < number_text.Length) &&
                   (number_text[follow] == '0'))
              {
                ++follow;
              }
            exponent_prefix_zero_count = follow - start_exponent;
            while ((follow < number_text.Length) &&
                   (number_text[follow] >= '0') && (number_text[follow] <= '9'))
              {
                ++follow;
              }
            exponent = BigInteger.Parse(
                    number_text.Substring(start_exponent, follow));
            if (exponent_is_negative)
                exponent = -exponent;
          }
        else
          {
            exponent = 0;
          }
        Debug.Assert(follow == number_text.Length);
        handle_value(new JSONRationalValue(mantissa_whole_part,
                mantissa_fraction_numerator, mantissa_fraction_digit_count,
                exponent, show_exponent, exponent_plus,
                exponent_prefix_zero_count));
      }
    public override void start_object()
      {
        stack.Add(new JSONObjectValue());
        label_stack.Add(label);
      }
    public override void start_pair(string name)
      {
        label = name;
      }
    public override void pair(string name, string value)
      {
        start_pair(name);
        string_value(value);
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
        Debug.Assert(stack.Count > 0);
        Debug.Assert(label_stack.Count == stack.Count);
        JSONValue item = stack[stack.Count - 1];
        Debug.Assert(item.kind() == JSONValue.Kind.JVK_OBJECT);
        label = label_stack[label_stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        label_stack.RemoveAt(label_stack.Count - 1);
        handle_value(item);
      }
    public override void start_array()
      {
        stack.Add(new JSONArrayValue());
        label_stack.Add(label);
      }
    public override void finish_array()
      {
        Debug.Assert(stack.Count > 0);
        Debug.Assert(label_stack.Count == stack.Count);
        JSONValue item = stack[stack.Count - 1];
        Debug.Assert(item.kind() == JSONValue.Kind.JVK_ARRAY);
        label = label_stack[label_stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        label_stack.RemoveAt(label_stack.Count - 1);
        handle_value(item);
      }

    public JSONValue getResult()
      {
        return result;
      }
  }
