/* file "JSONIntegerRangeBaseGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Numerics;


public abstract class JSONIntegerRangeBaseGenerator : JSONCoreIntegerGenerator
  {
    protected BigInteger lower_bound;
    protected BigInteger upper_bound;

    protected JSONIntegerRangeBaseGenerator(BigInteger init_lower_bound,
                                            BigInteger init_upper_bound)
      {
        lower_bound = init_lower_bound;
        upper_bound = init_upper_bound;
      }

    public override void number_value(BigInteger to_write)
      {
        if (to_write < lower_bound)
          {
            error("Expected an integer greater than or equal to {0} for " +
                  "%what%, found {1}.", lower_bound, to_write);
          }
        if (upper_bound < to_write)
          {
            error("Expected an integer less than or equal to {0} for %what%, " +
                  "found {1}.", upper_bound, to_write);
          }
        handle_result(to_write);
      }
  };
