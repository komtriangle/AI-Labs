/* file "HTTPRawReader.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */


public interface HTTPRawReader
  {
    string readLine();
    int read_bytes(byte[] buffer, int byte_count);
    void check_for_errors();
    void close();
  };
