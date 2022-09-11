/* file "JSONTextSource.cs" */

/* Copyright 2012-2018 SoundHound, Incorporated.  All rights reserved. */


public abstract class JSONTextSource
  {
    protected JSONTextSource()  { }

    public abstract char getchar();
    public abstract void ungetchar(char to_unget);
    public abstract string file_name();
  }
