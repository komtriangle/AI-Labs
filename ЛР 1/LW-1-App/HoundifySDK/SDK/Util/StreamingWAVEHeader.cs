/* file "StreamingWAVEHeader.cs" */

/* Copyright 2017 SoundHound, Incorporated.  All rights reserved. */


class StreamingWAVEHeader
  {
    public static int header_byte_count = 44;

    private static byte[] header_template = new byte[]
      {
        (byte)'R',
        (byte)'I',
        (byte)'F',
        (byte)'F',
        0,
        0,
        0,
        0,
        (byte)'W',
        (byte)'A',
        (byte)'V',
        (byte)'E',
        (byte)'f',
        (byte)'m',
        (byte)'t',
        (byte)' ',
        16,
        0,
        0,
        0,
        1,
        0,
        1,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        (byte)'d',
        (byte)'a',
        (byte)'t',
        (byte)'a',
        0,
        0,
        0,
        0
      };

    private byte[] header;

    public StreamingWAVEHeader(int channel_count, int samples_per_second,
                               int bits_per_sample)
      {
        header = header_template;
        header[22] = (byte)(channel_count & 0xff);
        header[23] = (byte)((channel_count >> 8) & 0xff);
        header[24] = (byte)(samples_per_second & 0xff);
        header[25] = (byte)((samples_per_second >> 8) & 0xff);
        header[26] = (byte)((samples_per_second >> 16) & 0xff);
        header[27] = (byte)((samples_per_second >> 24) & 0xff);
        int bytes_per_second =
                samples_per_second * channel_count * (bits_per_sample / 8);
        header[28] = (byte)(bytes_per_second & 0xff);
        header[29] = (byte)((bytes_per_second >> 8) & 0xff);
        header[30] = (byte)((bytes_per_second >> 16) & 0xff);
        header[31] = (byte)((bytes_per_second >> 24) & 0xff);
        int bytes_per_sample = channel_count * (bits_per_sample / 8);
        header[32] = (byte)(bytes_per_sample & 0xff);
        header[33] = (byte)((bytes_per_sample >> 8) & 0xff);
        header[34] = (byte)(bits_per_sample & 0xff);
        header[35] = (byte)((bits_per_sample >> 8) & 0xff);
      }

    byte[] get_header_bytes()
      {
        return header;
      }
  };
