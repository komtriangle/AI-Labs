/* file "FetchResult.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */


public interface FetchResult
  {
    int statusCode();
    string reasonPhrase();
    string httpVersion();
    int parameterCount();
    string parameterKey(int paramNum);
    string parameterValue(int paramNum);
    string parameterLookup(string key);
    byte[] contentBytes();
    int readContent(byte[] buffer, int minBytes, int maxBytes);
    bool contentDone();
  };
