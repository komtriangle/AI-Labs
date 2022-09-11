/* file "JSONBase.cs" */

/* Copyright 2018, 2019 SoundHound, Incorporated.  All rights reserved. */


public abstract class JSONBase
  {
    public abstract void write_as_json(JSONHandler handler);
    public abstract void write_partial_as_json(JSONHandler handler);
  }
