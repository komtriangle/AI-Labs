/* file "GoldenRetriever.csGoldenRetriever.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */

using System;
using System.Diagnostics;


class GoldenRetriever
  {
    public bool have_content_length;
    public long content_length;
    public bool chunked;

    public GoldenRetriever()
      {
        have_content_length = false;
        content_length = 0;
        chunked = false;
      }

    public void handle_header_line(string this_line, HTTPHandler handler)
      {
        int follow = 0;
        while (this_line[follow] != ':')
            ++follow;
        string field_name = this_line.Substring(0, follow);
        ++follow;
        while ((follow < this_line.Length) && (this_line[follow] == ' '))
            ++follow;
        string content_length_string = this_line.Substring(follow);
        handler.handleParameter(field_name, content_length_string);

        if (field_name.ToLower().Equals("Content-Length".ToLower()))
          {
            content_length = 0;
            while (follow < this_line.Length)
              {
                if ((this_line[follow] < '0') || (this_line[follow] > '9'))
                  {
                    throw new Exception(
                            "Bad Content-Length field: `" +
                            content_length_string + "'.");
                  }
                if (content_length >
                    ((Int64.MaxValue - (this_line[follow] - '0')) / 10))
                  {
                    throw new Exception("Overflow in Content-Length field.");
                  }
                content_length =
                        ((content_length * 10) + (this_line[follow] - '0'));
                ++follow;
              }
            have_content_length = true;
          }
        else if (field_name.ToLower().Equals("Transfer-Encoding".ToLower()))
          {
            if (!(this_line.Substring(follow).ToLower().Equals("chunked")))
                throw new Exception("Unsupported Transfer-Encoding field.");
            chunked = true;
          }
      }

    public void handleParametersAndBody(HTTPHandler handler,
                                        HTTPRawReader reader)
      {
        while (true)
          {
            string this_line = reader.readLine();
            if ((this_line == null) || (this_line.Length == 0))
                break;
            handle_header_line(this_line, handler);
          }

        handler.handleHeaderDone();

        byte[] buffer = new byte[256];

        if (chunked)
          {
            while (true)
              {
                long chunk_byte_count = 0;
                while (true)
                  {
                    int num = reader.read_bytes(buffer, 1);
                    if (num < 1)
                        throw new Exception("Unexpected end of chunk header.");
                    if (buffer[0] == '\r')
                        break;
                    if (buffer[0] == ' ')
                        continue;
                    long digit;
                    if ((buffer[0] >= '0') && (buffer[0] <= '9'))
                        digit = buffer[0] - '0';
                    else if ((buffer[0] >= 'a') && (buffer[0] <= 'f'))
                        digit = (buffer[0] - 'a') + 0xa;
                    else if ((buffer[0] >= 'A') && (buffer[0] <= 'F'))
                        digit = (buffer[0] - 'A') + 0xa;
                    else
                        throw new Exception("Bad digit in chunk header.");
                    if (chunk_byte_count >= (Int64.MaxValue - digit) / 16)
                        throw new Exception("Overflow in chunk header.");
                    chunk_byte_count = (chunk_byte_count * 16) + digit;
                  }

                if (chunk_byte_count == 0)
                    break;

                  {
                    int num = reader.read_bytes(buffer, 1);
                    if (num < 1)
                        throw new Exception("Unexpected end of chunk header.");
                    if (buffer[0] != '\n')
                        throw new Exception("Bad end-of-line in chunk header.");
                  }

                while (chunk_byte_count > 0)
                  {
                    int num = reader.read_bytes(buffer,
                            ((chunk_byte_count > 256) ? 256 :
                             (int)chunk_byte_count));
                    if (num < 1)
                        break;
                    handler.handleContent(num, buffer);
                    chunk_byte_count -= num;
                  }

                  {
                    int num = reader.read_bytes(buffer, 1);
                    if (num < 1)
                        throw new Exception("Unexpected end of chunk.");
                    if (buffer[0] != '\r')
                        throw new Exception("Bad end-of-line in chunk.");
                  }

                  {
                    int num = reader.read_bytes(buffer, 1);
                    if (num < 1)
                        throw new Exception("Unexpected end of chunk.");
                    if (buffer[0] != '\n')
                        throw new Exception("Bad end-of-line in chunk.");
                  }
              }

            /* @@@ */
            /* @@@ -- Read the trailer. */
            /* @@@ */
          }
        else if (have_content_length)
          {
            while (content_length > 0)
              {
                int num = reader.read_bytes(buffer,
                        ((content_length > 256) ? 256 : (int)content_length));
                if (num < 1)
                    break;
                Debug.Assert(num <= content_length);
                handler.handleContent(num, buffer);
                content_length -= num;
              }
          }
        else
          {
            while (true)
              {
                int num = reader.read_bytes(buffer, 256);
                if (num < 1)
                    break;
                handler.handleContent(num, buffer);
              }
          }
        handler.handleContentEnd();
      }

    public static void error(string format, params object[] arguments)
      {
        Console.Error.Write(format, arguments);
        Console.Error.Write("\n");
        throw new Exception(string.Format(format, arguments));
      }
  };
