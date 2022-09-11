/* file "JSONStreamWriter.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */

using System.IO;


public class JSONStreamWriter : JSONWriter
  {
    private TextWriter stream;

    public JSONStreamWriter(TextWriter init_stream, whitespace_style style) :
            base(style)
      {
        stream = init_stream;
      }
    public JSONStreamWriter(TextWriter init_stream) :
            base(whitespace_style.WHITESPACE_VERBOSE_4)
      {
        stream = init_stream;
      }

    protected override void send_raw_text(string text)
      {
        stream.Write(text);
      }
  }
