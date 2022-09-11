/* file "HTTPHandler.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */


public class HTTPHandler
  {
    public virtual void handleHTTPVersion(string version)  { }
    public virtual void handleParameter(string key, string value)  { }
    public virtual void handleContentByteCount(int byteCount)  { }
    public virtual void handleHeaderDone()  { }
    public virtual void handleContent(int byteCount, byte[] bytes)  { }
    public virtual void handleContentEnd()  { }
  };
