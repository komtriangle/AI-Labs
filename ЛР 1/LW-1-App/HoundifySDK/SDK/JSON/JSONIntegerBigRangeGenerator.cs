/* file "JSONIntegerBigRangeGenerator.cs" */

/* Copyright 2015-2018 SoundHound, Incorporated.  All rights reserved. */

using System.Numerics;
using System.Diagnostics;


public abstract class JSONIntegerBigRangeGenerator :
        JSONIntegerRangeBaseGenerator
  {
    protected JSONIntegerBigRangeGenerator(BigInteger lower_bound,
            BigInteger upper_bound) : base(lower_bound, upper_bound)
      {
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
