/* file "Base64.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */

using System.Diagnostics;


public class Base64
  {
    public static char[] base64_encode(byte[] encoded)
      {
        char[] output = new char[4 * ((encoded.Length + 2) / 3)];
        for (int num = 0; num < encoded.Length / 3; ++num)
          {
            char[] chunk_chars = base64_encode_three(encoded, num * 3);
            output[(num * 4) + 0] = chunk_chars[0];
            output[(num * 4) + 1] = chunk_chars[1];
            output[(num * 4) + 2] = chunk_chars[2];
            output[(num * 4) + 3] = chunk_chars[3];
          }
        if ((encoded.Length % 3) == 2)
          {
            char[] chunk_chars =
                    base64_encode_last_two(encoded, encoded.Length - 2);
            output[((encoded.Length / 3) * 4) + 0] = chunk_chars[0];
            output[((encoded.Length / 3) * 4) + 1] = chunk_chars[1];
            output[((encoded.Length / 3) * 4) + 2] = chunk_chars[2];
            output[((encoded.Length / 3) * 4) + 3] = chunk_chars[3];
          }
        else if ((encoded.Length % 3) == 1)
          {
            char[] chunk_chars =
                    base64_encode_last_one(encoded, encoded.Length - 1);
            output[((encoded.Length / 3) * 4) + 0] = chunk_chars[0];
            output[((encoded.Length / 3) * 4) + 1] = chunk_chars[1];
            output[((encoded.Length / 3) * 4) + 2] = chunk_chars[2];
            output[((encoded.Length / 3) * 4) + 3] = chunk_chars[3];
          }
        return output;
      }

    public static char[] base64_encode_three(byte[] input, int start)
      {
        int bits0 = ((char)(input[0])) & 0xff;
        int bits1 = ((char)(input[1])) & 0xff;
        int bits2 = ((char)(input[2])) & 0xff;
        char[] output = new char[4];
        output[0] = base64_encode_six_bits(bits0 >> 2);
        output[1] = base64_encode_six_bits(((bits0 & 0x3) << 4) | (bits1 >> 4));
        output[2] = base64_encode_six_bits(((bits1 & 0xf) << 2) | (bits2 >> 6));
        output[3] = base64_encode_six_bits(bits2 & 0x3f);
        return output;
      }

    public static char[] base64_encode_last_two(byte[] input, int start)
      {
        int bits0 = ((char)(input[start + 0])) & 0xff;
        int bits1 = ((char)(input[start + 1])) & 0xff;
        char[] output = new char[4];
        output[0] = base64_encode_six_bits(bits0 >> 2);
        output[1] = base64_encode_six_bits(((bits0 & 0x3) << 4) | (bits1 >> 4));
        output[2] = base64_encode_six_bits((bits1 & 0xf) << 2);
        output[3] = '=';
        return output;
      }

    public static char[] base64_encode_last_one(byte[] input, int start)
      {
        int bits0 = ((char)(input[start + 0])) & 0xff;
        char[] output = new char[4];
        output[0] = base64_encode_six_bits(bits0 >> 2);
        output[1] = base64_encode_six_bits((bits0 & 0x3) << 4);
        output[2] = '=';
        output[3] = '=';
        return output;
      }

    public static byte[] base64_decode(string encoded)
      {
        Debug.Assert(encoded != null);
        Debug.Assert((encoded.Length % 4) == 0);

        int chunk_count = (encoded.Length / 4);
        if (chunk_count == 0)
            return new byte[0];
        int output_count =
                (chunk_count * 3) +
                ((encoded[(chunk_count * 4) - 2] == '=') ? -2 :
                 ((encoded[(chunk_count * 4) - 1] == '=') ? -1 : 0));
        byte[] decoded = new byte[output_count];
        int follow_encoded = 0;
        int follow_decoded = 0;
        for (int num = 0; num < chunk_count - 1; ++num)
          {
            int bits0 = base64_decode_six_bits(encoded[follow_encoded + 0]);
            int bits1 = base64_decode_six_bits(encoded[follow_encoded + 1]);
            int bits2 = base64_decode_six_bits(encoded[follow_encoded + 2]);
            int bits3 = base64_decode_six_bits(encoded[follow_encoded + 3]);
            follow_encoded += 4;
            decoded[follow_decoded] = (byte)((bits0 << 2) | (bits1 >> 4));
            ++follow_decoded;
            decoded[follow_decoded] =
                    (byte)(((bits1 & 0xf) << 4) | (bits2 >> 2));
            ++follow_decoded;
            decoded[follow_decoded] = (byte)(((bits2 & 0x3) << 6) | bits3);
            ++follow_decoded;
          }
        if (encoded[follow_encoded + 2] == '=')
          {
            Debug.Assert(encoded[follow_encoded + 3] == '=');
            int bits0 = base64_decode_six_bits(encoded[follow_encoded + 0]);
            int bits1 = base64_decode_six_bits(encoded[follow_encoded + 1]);
            decoded[follow_decoded] = (byte)((bits0 << 2) | (bits1 >> 4));
            ++follow_decoded;
            Debug.Assert((bits1 & 0xf) == 0);
          }
        else if (encoded[follow_encoded + 3] == '=')
          {
            int bits0 = base64_decode_six_bits(encoded[follow_encoded + 0]);
            int bits1 = base64_decode_six_bits(encoded[follow_encoded + 1]);
            int bits2 = base64_decode_six_bits(encoded[follow_encoded + 2]);
            follow_encoded += 4;
            decoded[follow_decoded] = (byte)((bits0 << 2) | (bits1 >> 4));
            ++follow_decoded;
            decoded[follow_decoded] =
                    (byte)(((bits1 & 0xf) << 4) | (bits2 >> 2));
            ++follow_decoded;
            Debug.Assert((bits2 & 0x3) == 0);
          }
        else
          {
            int bits0 = base64_decode_six_bits(encoded[follow_encoded + 0]);
            int bits1 = base64_decode_six_bits(encoded[follow_encoded + 1]);
            int bits2 = base64_decode_six_bits(encoded[follow_encoded + 2]);
            int bits3 = base64_decode_six_bits(encoded[follow_encoded + 3]);
            decoded[follow_decoded] = (byte)((bits0 << 2) | (bits1 >> 4));
            ++follow_decoded;
            decoded[follow_decoded] =
                    (byte)(((bits1 & 0xf) << 4) | (bits2 >> 2));
            ++follow_decoded;
            decoded[follow_decoded] = (byte)(((bits2 & 0x3) << 6) | bits3);
            ++follow_decoded;
          }
        return decoded;
      }

    public static char[] base64url_encode(byte[] encoded)
      {
        char[] output = new char[4 * ((encoded.Length + 2) / 3)];
        for (int num = 0; num < encoded.Length / 3; ++num)
          {
            char[] chunk_chars = base64url_encode_three(encoded, num * 3);
            output[(num * 4) + 0] = chunk_chars[0];
            output[(num * 4) + 1] = chunk_chars[1];
            output[(num * 4) + 2] = chunk_chars[2];
            output[(num * 4) + 3] = chunk_chars[3];
          }
        if ((encoded.Length % 3) == 2)
          {
            char[] chunk_chars =
                    base64url_encode_last_two(encoded, encoded.Length - 2);
            output[((encoded.Length / 3) * 4) + 0] = chunk_chars[0];
            output[((encoded.Length / 3) * 4) + 1] = chunk_chars[1];
            output[((encoded.Length / 3) * 4) + 2] = chunk_chars[2];
            output[((encoded.Length / 3) * 4) + 3] = chunk_chars[3];
          }
        else if ((encoded.Length % 3) == 1)
          {
            char[] chunk_chars =
                    base64url_encode_last_one(encoded, encoded.Length - 1);
            output[((encoded.Length / 3) * 4) + 0] = chunk_chars[0];
            output[((encoded.Length / 3) * 4) + 1] = chunk_chars[1];
            output[((encoded.Length / 3) * 4) + 2] = chunk_chars[2];
            output[((encoded.Length / 3) * 4) + 3] = chunk_chars[3];
          }
        return output;
      }

    public static char[] base64url_encode_three(byte[] input, int start)
      {
        int bits0 = ((int)(input[start + 0])) & 0xff;
        int bits1 = ((int)(input[start + 1])) & 0xff;
        int bits2 = ((int)(input[start + 2])) & 0xff;
        char[] output = new char[4];
        output[0] = base64url_encode_six_bits(bits0 >> 2);
        output[1] =
                base64url_encode_six_bits(((bits0 & 0x3) << 4) | (bits1 >> 4));
        output[2] =
                base64url_encode_six_bits(((bits1 & 0xf) << 2) | (bits2 >> 6));
        output[3] = base64url_encode_six_bits(bits2 & 0x3f);
        return output;
      }

    public static char[] base64url_encode_last_two(byte[] input, int start)
      {
        int bits0 = ((int)(input[start + 0])) & 0xff;
        int bits1 = ((int)(input[start + 1])) & 0xff;
        char[] output = new char[4];
        output[0] = base64url_encode_six_bits(bits0 >> 2);
        output[1] =
                base64url_encode_six_bits(((bits0 & 0x3) << 4) | (bits1 >> 4));
        output[2] = base64url_encode_six_bits((bits1 & 0xf) << 2);
        output[3] = '=';
        return output;
      }

    public static char[] base64url_encode_last_one(byte[] input, int start)
      {
        int bits0 = ((int)(input[start + 0])) & 0xff;
        char[] output = new char[4];
        output[0] = base64url_encode_six_bits(bits0 >> 2);
        output[1] = base64url_encode_six_bits((bits0 & 0x3) << 4);
        output[2] = '=';
        output[3] = '=';
        return output;
      }

    public static byte[] base64url_decode(string encoded)
      {
        Debug.Assert(encoded != null);
        Debug.Assert((encoded.Length % 4) == 0);

        int chunk_count = (encoded.Length / 4);
        if (chunk_count == 0)
            return new byte[0];
        int output_count =
                (chunk_count * 3) +
                ((encoded[(chunk_count * 4) - 2] == '=') ? -2 :
                 ((encoded[(chunk_count * 4) - 1] == '=') ? -1 : 0));
        byte[] decoded = new byte[output_count];
        int follow_encoded = 0;
        int follow_decoded = 0;
        for (int num = 0; num < chunk_count - 1; ++num)
          {
            int bits0 = base64url_decode_six_bits(encoded[follow_encoded + 0]);
            int bits1 = base64url_decode_six_bits(encoded[follow_encoded + 1]);
            int bits2 = base64url_decode_six_bits(encoded[follow_encoded + 2]);
            int bits3 = base64url_decode_six_bits(encoded[follow_encoded + 3]);
            follow_encoded += 4;
            decoded[follow_decoded] = (byte)((bits0 << 2) | (bits1 >> 4));
            ++follow_decoded;
            decoded[follow_decoded] =
                    (byte)(((bits1 & 0xf) << 4) | (bits2 >> 2));
            ++follow_decoded;
            decoded[follow_decoded] = (byte)(((bits2 & 0x3) << 6) | bits3);
            ++follow_decoded;
          }
        if (encoded[follow_encoded + 2] == '=')
          {
            Debug.Assert(encoded[follow_encoded + 3] == '=');
            int bits0 = base64url_decode_six_bits(encoded[follow_encoded + 0]);
            int bits1 = base64url_decode_six_bits(encoded[follow_encoded + 1]);
            decoded[follow_decoded] = (byte)((bits0 << 2) | (bits1 >> 4));
            ++follow_decoded;
            Debug.Assert((bits1 & 0xf) == 0);
          }
        else if (encoded[follow_encoded + 3] == '=')
          {
            int bits0 = base64url_decode_six_bits(encoded[follow_encoded + 0]);
            int bits1 = base64url_decode_six_bits(encoded[follow_encoded + 1]);
            int bits2 = base64url_decode_six_bits(encoded[follow_encoded + 2]);
            follow_encoded += 4;
            decoded[follow_decoded] = (byte)((bits0 << 2) | (bits1 >> 4));
            ++follow_decoded;
            decoded[follow_decoded] =
                    (byte)(((bits1 & 0xf) << 4) | (bits2 >> 2));
            ++follow_decoded;
            Debug.Assert((bits2 & 0x3) == 0);
          }
        else
          {
            int bits0 = base64url_decode_six_bits(encoded[follow_encoded + 0]);
            int bits1 = base64url_decode_six_bits(encoded[follow_encoded + 1]);
            int bits2 = base64url_decode_six_bits(encoded[follow_encoded + 2]);
            int bits3 = base64url_decode_six_bits(encoded[follow_encoded + 3]);
            decoded[follow_decoded] = (byte)((bits0 << 2) | (bits1 >> 4));
            ++follow_decoded;
            decoded[follow_decoded] =
                    (byte)(((bits1 & 0xf) << 4) | (bits2 >> 2));
            ++follow_decoded;
            decoded[follow_decoded] = (byte)(((bits2 & 0x3) << 6) | bits3);
            ++follow_decoded;
          }
        return decoded;
      }

    private static char base64_encode_six_bits(int input)
      {
        input &= 0x3f;
        Debug.Assert(input >= 0);
        Debug.Assert(input < 64);
        if (input < 26)
            return (char)(input + 'A');
        if (input < 52)
            return (char)((input - 26) + 'a');
        if (input < 62)
            return (char)((input - 52) + '0');
        if (input == 62)
            return '+';
        Debug.Assert(input == 63);
        return '/';
      }

    private static int base64_decode_six_bits(char input)
      {
        if ((input >= 'A') && (input <= 'Z'))
            return input - 'A';
        if ((input >= 'a') && (input <= 'z'))
            return (input - 'a') + 26;
        if ((input >= '0') && (input <= '9'))
            return (input - '0') + 52;
        if (input == '+')
            return 62;
        Debug.Assert(input == '/');
        return 63;
      }

    private static char base64url_encode_six_bits(int input)
      {
        input &= 0x3f;
        Debug.Assert(input >= 0);
        Debug.Assert(input < 64);
        if (input < 26)
            return (char)(input + 'A');
        if (input < 52)
            return (char)((input - 26) + 'a');
        if (input < 62)
            return (char)((input - 52) + '0');
        if (input == 62)
            return '-';
        Debug.Assert(input == 63);
        return '_';
      }

    private static int base64url_decode_six_bits(char input)
      {
        if ((input >= 'A') && (input <= 'Z'))
            return ((int)(input - 'A')) & 0x3f;
        if ((input >= 'a') && (input <= 'z'))
            return ((int)((input - 'a') + 26));
        if ((input >= '0') && (input <= '9'))
            return ((int)((input - '0') + 52));
        if (input == '-')
            return 62;
        Debug.Assert(input == '_');
        return 63;
      }
  };
