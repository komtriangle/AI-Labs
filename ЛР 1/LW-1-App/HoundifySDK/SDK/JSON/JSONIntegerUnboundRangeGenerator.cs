/* file "JSONIntegerUnboundRangeGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Numerics;


public abstract class JSONIntegerUnboundRangeGenerator :
        JSONCoreIntegerGenerator
  {
    protected JSONIntegerUnboundRangeGenerator()  { }

    public override void number_value(BigInteger to_write)
      {
        handle_result(to_write);
      }
    public override void number_value(int to_write)
      {
        number_value((BigInteger)to_write);
      }
    public override void number_value(long to_write)
      {
        number_value((BigInteger)to_write);
      }
  };
