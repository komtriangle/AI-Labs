/* file "HTTPRawWriter.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */


public abstract class HTTPRawWriter
  {
    public abstract void write(string to_write);
    public abstract void write(byte[] to_write, int byte_count);
    public abstract int read(byte[] buffer, int byte_count);
    public abstract void close();
    public virtual void set_timeout_seconds(double seconds)  { }
  };
