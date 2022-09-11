/* file "JSONIntegerValue.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */

using System.Numerics;


public class JSONIntegerValue : JSONValue
  {
    private BigInteger data;

    public JSONIntegerValue(BigInteger init_data)
      {
        data = init_data;
      }
    public JSONIntegerValue(byte init_data)
      {
        data = init_data;
      }
    public JSONIntegerValue(short init_data)
      {
        data = init_data;
      }
    public JSONIntegerValue(int init_data)
      {
        data = init_data;
      }
    public JSONIntegerValue(long init_data)
      {
        data = init_data;
      }

    public override Kind kind()  { return Kind.JVK_INTEGER; }
    public BigInteger getData()  { return data; }
    public string getText()
      {
        return data.ToString();
      }

    public int getInt()
      {
        return (int)data;
      }
    public long getLongInt()
      {
        return (long)data;
      }
    public override void write(JSONHandler handler)
      {
        handler.number_value(data.ToString());
      }
    public override JSONIntegerValue integer_value()  { return this; }
  }
