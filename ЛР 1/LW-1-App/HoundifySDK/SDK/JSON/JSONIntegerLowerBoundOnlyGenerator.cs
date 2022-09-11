/* file "JSONIntegerLowerBoundOnlyGenerator.cs" */

/* Copyright 2015, 2016 SoundHound, Incorporated.  All rights reserved. */

using System.Numerics;


public abstract class JSONIntegerLowerBoundOnlyGenerator :
        JSONCoreIntegerGenerator
  {
    protected BigInteger lower_bound;

    protected JSONIntegerLowerBoundOnlyGenerator(BigInteger init_lower_bound)
      {
        lower_bound = init_lower_bound;
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
        if (to_write < lower_bound)
          {
            error("Expected an integer greater than or equal to {0} for " +
                  "%what%, found {1}.", lower_bound.ToString(),
                  to_write.ToString());
          }
        handle_result(to_write);
      }
  };
