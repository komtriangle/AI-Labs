/* file "HTTPStreamReader.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */

using System;
using System.Text;
using System.IO;
using System.Diagnostics;


public class HTTPStreamReader : HTTPRawReader
  {
    private Stream stream;
    private int max_read;
    private byte[] saved_bytes;
    private int saved_start;
    private int saved_end;

    public HTTPStreamReader(Stream init_stream)
      {
        stream = init_stream;
        max_read = 1024;
        saved_bytes = new byte[1024];
        saved_start = 0;
        saved_end = 0;
      }

    public HTTPStreamReader(Stream init_stream, int init_max_read)
      {
        stream = init_stream;
        max_read = init_max_read;
        saved_bytes = new byte[1024];
        saved_start = 0;
        saved_end = 0;
      }

    public string readLine()
      {
        while (true)
          {
            int position = saved_start;
            while (position < saved_end)
              {
                if (saved_bytes[position] == '\n')
                  {
                    int end = position;
                    if ((end > saved_start) && (saved_bytes[end - 1] == '\r'))
                        --end;
                    string result = Encoding.UTF8.GetString(saved_bytes,
                            saved_start, end - saved_start);
                    saved_start = position + 1;
                    Debug.Assert(saved_start <= saved_end);
                    return result;
                  }
                ++position;
              }
            if (saved_start > 0)
              {
                for (int num = 0; num < (saved_end - saved_start); ++num)
                    saved_bytes[num] = saved_bytes[num + saved_start];
                saved_end -= saved_start;
                saved_start = 0;
              }
            Debug.Assert(saved_start == 0);
            if (saved_end == saved_bytes.Length)
              {
                byte[] new_buffer = new byte[saved_end * 2];
                for (int num = 0; num < saved_end; ++num)
                    new_buffer[num] = saved_bytes[num];
                saved_bytes = new_buffer;
              }
            Debug.Assert(saved_end < saved_bytes.Length);
            int max_count = saved_bytes.Length - saved_end;
            if (max_count > max_read)
                max_count = max_read;
            int new_count = stream.Read(saved_bytes, saved_end, max_count);
            if (new_count < 0)
                return null;
            saved_end += new_count;
          }
      }
    public int read_bytes(byte[] buffer, int byte_count)
      {
        if (saved_end > saved_start)
          {
            if ((saved_end - saved_start) > byte_count)
              {
                Array.Copy(saved_bytes, saved_start, buffer, 0, byte_count);
                saved_start += byte_count;
                return byte_count;
              }
            int result = saved_end - saved_start;
            Array.Copy(saved_bytes, saved_start, buffer, 0, result);
            saved_start = 0;
            saved_end = 0;
            return result;
          }
        return stream.Read(buffer, 0, byte_count);
      }
    public virtual void check_for_errors()
      {
      }
    public void close()
      {
        stream.Close();
      }
  };
