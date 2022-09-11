/* file "JSONRationalValue.cs" */

/* Copyright 2012-2018 SoundHound, Incorporated.  All rights reserved. */

using System;
using System.Numerics;
using System.Diagnostics;
using System.IO;


public class JSONRationalValue : JSONValue
  {
    private BigInteger mantissa_whole_part;
    private BigInteger mantissa_fraction_numerator;
    private int mantissa_fraction_digit_count;
    private BigInteger exponent;
    private bool show_exponent;
    private bool exponent_plus;
    private int exponent_prefix_zero_count;

    public JSONRationalValue(BigInteger init_mantissa_whole_part,
            BigInteger init_mantissa_fraction_numerator,
            int init_mantissa_fraction_digit_count, BigInteger init_exponent,
            bool init_show_exponent, bool init_exponent_plus,
            int init_exponent_prefix_zero_count)
      {
        mantissa_whole_part = init_mantissa_whole_part;
        mantissa_fraction_numerator = init_mantissa_fraction_numerator;
        mantissa_fraction_digit_count = init_mantissa_fraction_digit_count;
        exponent = init_exponent;
        show_exponent = init_show_exponent;
        exponent_plus = init_exponent_plus;
        exponent_prefix_zero_count = init_exponent_prefix_zero_count;
      }
    public JSONRationalValue(BigInteger init_mantissa_whole_part,
            BigInteger init_mantissa_fraction_numerator,
            int init_mantissa_fraction_digit_count, BigInteger init_exponent,
            bool init_show_exponent, bool init_exponent_plus)
      {
        mantissa_whole_part = init_mantissa_whole_part;
        mantissa_fraction_numerator = init_mantissa_fraction_numerator;
        mantissa_fraction_digit_count = init_mantissa_fraction_digit_count;
        exponent = init_exponent;
        show_exponent = init_show_exponent;
        exponent_plus = init_exponent_plus;
        exponent_prefix_zero_count = 0;
      }
    public JSONRationalValue(BigInteger init_mantissa_whole_part,
            BigInteger init_mantissa_fraction_numerator,
            int init_mantissa_fraction_digit_count, BigInteger init_exponent,
            bool init_show_exponent)
      {
        mantissa_whole_part = init_mantissa_whole_part;
        mantissa_fraction_numerator = init_mantissa_fraction_numerator;
        mantissa_fraction_digit_count = init_mantissa_fraction_digit_count;
        exponent = init_exponent;
        show_exponent = init_show_exponent;
        exponent_plus = true;
        exponent_prefix_zero_count = 0;
      }
    public JSONRationalValue(BigInteger init_mantissa_whole_part,
            BigInteger init_mantissa_fraction_numerator,
            int init_mantissa_fraction_digit_count, BigInteger init_exponent)
      {
        mantissa_whole_part = init_mantissa_whole_part;
        mantissa_fraction_numerator = init_mantissa_fraction_numerator;
        mantissa_fraction_digit_count = init_mantissa_fraction_digit_count;
        exponent = init_exponent;
        show_exponent = true;
        exponent_plus = true;
        exponent_prefix_zero_count = 0;
      }
    public JSONRationalValue(double init_double, int precision)
      {
        string buffer_string = string.Format(System.Globalization.CultureInfo.InvariantCulture,
                string.Format(System.Globalization.CultureInfo.InvariantCulture,
                    "{{0:e{0}}}", precision), init_double);
        char[] buffer = buffer_string.ToCharArray();

        int start_mantissa_whole = 0;
        if (buffer[start_mantissa_whole] == '-')
            ++start_mantissa_whole;
        int decimal_point = start_mantissa_whole;
        do
          {
            Debug.Assert((buffer[decimal_point] >= '0') &&
                         (buffer[decimal_point] <= '9'));
            ++decimal_point;
          } while (buffer[decimal_point] != '.');
        mantissa_whole_part = BigInteger.Parse(buffer_string.Substring(
                start_mantissa_whole, (decimal_point - start_mantissa_whole)));

        int exponent_marker = decimal_point + 1;
        while (buffer[exponent_marker] != 'e')
          {
            Debug.Assert((buffer[exponent_marker] >= '0') &&
                         (buffer[exponent_marker] <= '9'));
            ++exponent_marker;
          }
        mantissa_fraction_numerator = BigInteger.Parse(buffer_string.Substring(
                (decimal_point + 1), (exponent_marker - (decimal_point + 1))));
        mantissa_fraction_digit_count = exponent_marker - (decimal_point + 1);

        if (buffer[0] == '-')
          {
            if (mantissa_whole_part != 0)
                mantissa_whole_part = -mantissa_whole_part;
            else
                mantissa_fraction_numerator = -mantissa_fraction_numerator;
          }

        int exponent_start = exponent_marker + 1;
        Debug.Assert((buffer[exponent_start] == '-') ||
                     (buffer[exponent_start] == '+'));
        ++exponent_start;
        exponent = BigInteger.Parse(buffer_string.Substring(exponent_start));
        if (buffer[exponent_marker + 1] == '-')
            exponent = -exponent;
        show_exponent = (exponent != 0);
        exponent_plus = true;
        exponent_prefix_zero_count = 0;
        while (buffer[exponent_start] == '0')
          {
            ++exponent_prefix_zero_count;
            ++exponent_start;
          }
      }

    public override Kind kind()  { return Kind.JVK_RATIONAL; }
    public BigInteger getMantissaWholePart()  { return mantissa_whole_part; }
    public BigInteger getMantissaFractionNumerator()
      { return mantissa_fraction_numerator; }
    public int getMantissaFractionDigitCount()
      { return mantissa_fraction_digit_count; }
    public BigInteger getExponent()  { return exponent; }
    public string getText()
      {
        StringWriter stream = new StringWriter();
        try
          {
            write(new JSONStreamWriter(stream));
          }
        catch (Exception)
          {
            Debug.Assert(false);
          }
        return stream.ToString();
      }

    public double getDouble()
      {
        StringWriter stream = new StringWriter();
        try
          {
            write(new JSONStreamWriter(stream));
          }
        catch (Exception)
          {
            Debug.Assert(false);
          }
        return Double.Parse(stream.ToString());
      }
    public float getFloat()
      {
        return (float)(getDouble());
      }
    public bool isInteger()
      {
        int non_zero_mantissa_fraction_digit_count =
                mantissa_fraction_digit_count;
        BigInteger remainder = mantissa_fraction_numerator;
        while (non_zero_mantissa_fraction_digit_count > 0)
          {
            if (remainder == 0)
              {
                non_zero_mantissa_fraction_digit_count = 0;
                break;
              }
            BigInteger this_digit = remainder % 10;
            remainder = remainder / 10;
            bool is_non_zero = !(this_digit == 0);
            if (is_non_zero)
                break;
            --non_zero_mantissa_fraction_digit_count;
          }
        BigInteger mantissa_fraction_digit_count_oi =
                non_zero_mantissa_fraction_digit_count;
        BigInteger digits_after_decimal_point =
                mantissa_fraction_digit_count_oi - exponent;
        bool result = (digits_after_decimal_point >= 0);
        return result;
      }
    public BigInteger getInteger()
      {
        BigInteger result = mantissa_whole_part;
        int digits_left = mantissa_fraction_digit_count;
        while (digits_left > 0)
          {
            result = result * 10;
            --digits_left;
          }

        result = result + mantissa_fraction_numerator;

        BigInteger digits_oi = mantissa_fraction_digit_count;
        BigInteger remaining_exponent = exponent - digits_oi;

        while (remaining_exponent > 0)
          {
            result = result * 10;
            remaining_exponent = remaining_exponent - 1;
          }

        while (remaining_exponent < 0)
          {
            BigInteger this_digit = result % 10;
            Debug.Assert(this_digit == 0);
            result = result / 10;
            remaining_exponent = remaining_exponent + 1;
          }

        return result;
      }
    public int getInt()
      {
        return (int)(getInteger());
      }
    public long getLongInt()
      {
        return (long)(getInteger());
      }
    public ulong getUnsignedLongInt()
      {
        return (ulong)(getInteger());
      }

    public override void write(JSONHandler handler)
      {
        handler.number_value(mantissa_whole_part, mantissa_fraction_numerator,
                             mantissa_fraction_digit_count, exponent);
      }
    public override JSONRationalValue rational_value()  { return this; }

    public static double getDouble(BigInteger mantissa_whole_part,
            BigInteger mantissa_fraction_numerator,
            int mantissa_fraction_digit_count, BigInteger exponent)
      {
        StringWriter stream = new StringWriter();
        try
          {
            JSONStreamWriter writer = new JSONStreamWriter(stream);
            writer.number_value(mantissa_whole_part,
                    mantissa_fraction_numerator, mantissa_fraction_digit_count,
                    exponent);
          }
        catch (Exception)
          {
            Debug.Assert(false);
          }
        return Double.Parse(stream.ToString());
      }
  }
