/* file "FetchHandler.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */


public class FetchHandler : HTTPHandler
  {
    public virtual void handleStatusCode(int code)  { }
    public virtual void handleReasonPhrase(string message)  { }
  };
