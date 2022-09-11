/* file "MusicPlayerCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class MusicPlayerCommandJSON : CommandResultJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        public enum TypeCommandTypeKnownValues
          {
            CommandType_MUSIC_PLAYER_RESPONSE_SEARCH,
            CommandType_MUSIC_PLAYER_RESPONSE_PLAY_NUMBERED_TRACK,
            CommandType_MUSIC_PLAYER_RESPONSE_PLAY_LAST_SONG,
            CommandType_MUSIC_PLAYER_RESPONSE_PLAY_CURRENT_SONG,
            CommandType_MUSIC_PLAYER_RESPONSE_PAUSE,
            CommandType_MUSIC_PLAYER_RESPONSE_SKIP,
            CommandType_MUSIC_PLAYER_RESPONSE_THUMBS_UP,
            CommandType_MUSIC_PLAYER_RESPONSE_THUMBS_DOWN,
            CommandType_MUSIC_PLAYER_RESPONSE_RAISE_VOLUME,
            CommandType_MUSIC_PLAYER_RESPONSE_LOWER_VOLUME,
            CommandType_MUSIC_PLAYER_RESPONSE_MUTE,
            CommandType_MUSIC_PLAYER_RESPONSE_UNMUTE,
            CommandType_MUSIC_PLAYER_RESPONSE_STOP,
            CommandType_MUSIC_PLAYER_RESPONSE_REPLAY,
            CommandType_MUSIC_PLAYER_RESPONSE_REWIND,
            CommandType_MUSIC_PLAYER_RESPONSE_FAST_FORWARD,
            CommandType_MUSIC_PLAYER_RESPONSE_PLAY_LAST_IDENTIFIED_SONG,
            CommandType_MUSIC_PLAYER_RESPONSE_SHUFFLE,
            CommandType_MUSIC_PLAYER_RESPONSE_SEEK,
            CommandType_MUSIC_PLAYER_RESPONSE_SHUFFLE_ON,
            CommandType_MUSIC_PLAYER_RESPONSE_SHUFFLE_OFF,
            CommandType_MUSIC_PLAYER_RESPONSE_REPEAT_ON,
            CommandType_MUSIC_PLAYER_RESPONSE_REPEAT_OFF,
            CommandType_MUSIC_PLAYER_RESPONSE_REPEAT_SINGLE,
            CommandType_MUSIC_PLAYER_RESPONSE_SET_PROVIDER,
            CommandType_MUSIC_PLAYER_RESPONSE_SET_PLAYBACK_MODE,
            CommandType_MUSIC_PLAYER_RESPONSE_SKIP_ALBUM,
            CommandType_MUSIC_PLAYER_RESPONSE_ADD_TO_FAVORITES,
            CommandType_MUSIC_PLAYER_RESPONSE_REMOVE_FROM_FAVORITES,
            CommandType_MUSIC_PLAYER_RESPONSE_PLAY_FAVORITES,
            CommandType__none
          };
        public struct TypeCommandType
          {
            public bool in_known_list;
            public string string_value;
            public TypeCommandTypeKnownValues list_value;
          };

        public static TypeCommandTypeKnownValues  stringToCommandType(string chars)
          {
            if (String.Compare(chars, 0, "MUSIC_PLAYER_RESPONSE_", 0, 22, false) == 0)
              {
                switch (chars[22])
                  {
                    case 'A':
                        if ((String.Compare(chars, 23, "DD_TO_FAVORITES", 0, 15, false) == 0) && (chars.Length == 38))
                            return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_ADD_TO_FAVORITES;
                        break;
                    case 'F':
                        if ((String.Compare(chars, 23, "AST_FORWARD", 0, 11, false) == 0) && (chars.Length == 34))
                            return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_FAST_FORWARD;
                        break;
                    case 'L':
                        if ((String.Compare(chars, 23, "OWER_VOLUME", 0, 11, false) == 0) && (chars.Length == 34))
                            return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_LOWER_VOLUME;
                        break;
                    case 'M':
                        if ((String.Compare(chars, 23, "UTE", 0, 3, false) == 0) && (chars.Length == 26))
                            return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_MUTE;
                        break;
                    case 'P':
                        switch (chars[23])
                          {
                            case 'A':
                                if ((String.Compare(chars, 24, "USE", 0, 3, false) == 0) && (chars.Length == 27))
                                    return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PAUSE;
                                break;
                            case 'L':
                                if (String.Compare(chars, 24, "AY_", 0, 3, false) == 0)
                                  {
                                    switch (chars[27])
                                      {
                                        case 'C':
                                            if ((String.Compare(chars, 28, "URRENT_SONG", 0, 11, false) == 0) && (chars.Length == 39))
                                                return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_CURRENT_SONG;
                                            break;
                                        case 'F':
                                            if ((String.Compare(chars, 28, "AVORITES", 0, 8, false) == 0) && (chars.Length == 36))
                                                return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_FAVORITES;
                                            break;
                                        case 'L':
                                            if (String.Compare(chars, 28, "AST_", 0, 4, false) == 0)
                                              {
                                                switch (chars[32])
                                                  {
                                                    case 'I':
                                                        if ((String.Compare(chars, 33, "DENTIFIED_SONG", 0, 14, false) == 0) && (chars.Length == 47))
                                                            return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_LAST_IDENTIFIED_SONG;
                                                        break;
                                                    case 'S':
                                                        if ((String.Compare(chars, 33, "ONG", 0, 3, false) == 0) && (chars.Length == 36))
                                                            return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_LAST_SONG;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'N':
                                            if ((String.Compare(chars, 28, "UMBERED_TRACK", 0, 13, false) == 0) && (chars.Length == 41))
                                                return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_NUMBERED_TRACK;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'R':
                        switch (chars[23])
                          {
                            case 'A':
                                if ((String.Compare(chars, 24, "ISE_VOLUME", 0, 10, false) == 0) && (chars.Length == 34))
                                    return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_RAISE_VOLUME;
                                break;
                            case 'E':
                                switch (chars[24])
                                  {
                                    case 'M':
                                        if ((String.Compare(chars, 25, "OVE_FROM_FAVORITES", 0, 18, false) == 0) && (chars.Length == 43))
                                            return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REMOVE_FROM_FAVORITES;
                                        break;
                                    case 'P':
                                        switch (chars[25])
                                          {
                                            case 'E':
                                                if (String.Compare(chars, 26, "AT_", 0, 3, false) == 0)
                                                  {
                                                    switch (chars[29])
                                                      {
                                                        case 'O':
                                                            switch (chars[30])
                                                              {
                                                                case 'F':
                                                                    if ((String.Compare(chars, 31, "F", 0, 1, false) == 0) && (chars.Length == 32))
                                                                        return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REPEAT_OFF;
                                                                    break;
                                                                case 'N':
                                                                    if (chars.Length == 31)
                                                                        return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REPEAT_ON;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'S':
                                                            if ((String.Compare(chars, 30, "INGLE", 0, 5, false) == 0) && (chars.Length == 35))
                                                                return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REPEAT_SINGLE;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'L':
                                                if ((String.Compare(chars, 26, "AY", 0, 2, false) == 0) && (chars.Length == 28))
                                                    return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REPLAY;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'W':
                                        if ((String.Compare(chars, 25, "IND", 0, 3, false) == 0) && (chars.Length == 28))
                                            return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REWIND;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'S':
                        switch (chars[23])
                          {
                            case 'E':
                                switch (chars[24])
                                  {
                                    case 'A':
                                        if ((String.Compare(chars, 25, "RCH", 0, 3, false) == 0) && (chars.Length == 28))
                                            return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SEARCH;
                                        break;
                                    case 'E':
                                        if ((String.Compare(chars, 25, "K", 0, 1, false) == 0) && (chars.Length == 26))
                                            return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SEEK;
                                        break;
                                    case 'T':
                                        if (String.Compare(chars, 25, "_P", 0, 2, false) == 0)
                                          {
                                            switch (chars[27])
                                              {
                                                case 'L':
                                                    if ((String.Compare(chars, 28, "AYBACK_MODE", 0, 11, false) == 0) && (chars.Length == 39))
                                                        return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SET_PLAYBACK_MODE;
                                                    break;
                                                case 'R':
                                                    if ((String.Compare(chars, 28, "OVIDER", 0, 6, false) == 0) && (chars.Length == 34))
                                                        return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SET_PROVIDER;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'H':
                                if (String.Compare(chars, 24, "UFFLE", 0, 5, false) == 0)
                                  {
                                    if (chars.Length == 29)
                                      {
                                        return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SHUFFLE;
                                      }
                                    switch (chars[29])
                                      {
                                        case '_':
                                            if (String.Compare(chars, 30, "O", 0, 1, false) == 0)
                                              {
                                                switch (chars[31])
                                                  {
                                                    case 'F':
                                                        if ((String.Compare(chars, 32, "F", 0, 1, false) == 0) && (chars.Length == 33))
                                                            return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SHUFFLE_OFF;
                                                        break;
                                                    case 'N':
                                                        if (chars.Length == 32)
                                                            return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SHUFFLE_ON;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'K':
                                if (String.Compare(chars, 24, "IP", 0, 2, false) == 0)
                                  {
                                    if (chars.Length == 26)
                                      {
                                        return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SKIP;
                                      }
                                    switch (chars[26])
                                      {
                                        case '_':
                                            if ((String.Compare(chars, 27, "ALBUM", 0, 5, false) == 0) && (chars.Length == 32))
                                                return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SKIP_ALBUM;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'T':
                                if ((String.Compare(chars, 24, "OP", 0, 2, false) == 0) && (chars.Length == 26))
                                    return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_STOP;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'T':
                        if (String.Compare(chars, 23, "HUMBS_", 0, 6, false) == 0)
                          {
                            switch (chars[29])
                              {
                                case 'D':
                                    if ((String.Compare(chars, 30, "OWN", 0, 3, false) == 0) && (chars.Length == 33))
                                        return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_THUMBS_DOWN;
                                    break;
                                case 'U':
                                    if ((String.Compare(chars, 30, "P", 0, 1, false) == 0) && (chars.Length == 31))
                                        return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_THUMBS_UP;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'U':
                        if ((String.Compare(chars, 23, "NMUTE", 0, 5, false) == 0) && (chars.Length == 28))
                            return TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_UNMUTE;
                        break;
                    default:
                        break;
                  }
              }
            return TypeCommandTypeKnownValues.CommandType__none;
          }

        public static string  stringFromCommandType(TypeCommandTypeKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SEARCH:
                    return "MUSIC_PLAYER_RESPONSE_SEARCH";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_NUMBERED_TRACK:
                    return "MUSIC_PLAYER_RESPONSE_PLAY_NUMBERED_TRACK";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_LAST_SONG:
                    return "MUSIC_PLAYER_RESPONSE_PLAY_LAST_SONG";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_CURRENT_SONG:
                    return "MUSIC_PLAYER_RESPONSE_PLAY_CURRENT_SONG";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PAUSE:
                    return "MUSIC_PLAYER_RESPONSE_PAUSE";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SKIP:
                    return "MUSIC_PLAYER_RESPONSE_SKIP";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_THUMBS_UP:
                    return "MUSIC_PLAYER_RESPONSE_THUMBS_UP";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_THUMBS_DOWN:
                    return "MUSIC_PLAYER_RESPONSE_THUMBS_DOWN";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_RAISE_VOLUME:
                    return "MUSIC_PLAYER_RESPONSE_RAISE_VOLUME";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_LOWER_VOLUME:
                    return "MUSIC_PLAYER_RESPONSE_LOWER_VOLUME";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_MUTE:
                    return "MUSIC_PLAYER_RESPONSE_MUTE";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_UNMUTE:
                    return "MUSIC_PLAYER_RESPONSE_UNMUTE";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_STOP:
                    return "MUSIC_PLAYER_RESPONSE_STOP";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REPLAY:
                    return "MUSIC_PLAYER_RESPONSE_REPLAY";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REWIND:
                    return "MUSIC_PLAYER_RESPONSE_REWIND";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_FAST_FORWARD:
                    return "MUSIC_PLAYER_RESPONSE_FAST_FORWARD";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_LAST_IDENTIFIED_SONG:
                    return "MUSIC_PLAYER_RESPONSE_PLAY_LAST_IDENTIFIED_SONG";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SHUFFLE:
                    return "MUSIC_PLAYER_RESPONSE_SHUFFLE";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SEEK:
                    return "MUSIC_PLAYER_RESPONSE_SEEK";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SHUFFLE_ON:
                    return "MUSIC_PLAYER_RESPONSE_SHUFFLE_ON";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SHUFFLE_OFF:
                    return "MUSIC_PLAYER_RESPONSE_SHUFFLE_OFF";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REPEAT_ON:
                    return "MUSIC_PLAYER_RESPONSE_REPEAT_ON";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REPEAT_OFF:
                    return "MUSIC_PLAYER_RESPONSE_REPEAT_OFF";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REPEAT_SINGLE:
                    return "MUSIC_PLAYER_RESPONSE_REPEAT_SINGLE";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SET_PROVIDER:
                    return "MUSIC_PLAYER_RESPONSE_SET_PROVIDER";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SET_PLAYBACK_MODE:
                    return "MUSIC_PLAYER_RESPONSE_SET_PLAYBACK_MODE";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SKIP_ALBUM:
                    return "MUSIC_PLAYER_RESPONSE_SKIP_ALBUM";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_ADD_TO_FAVORITES:
                    return "MUSIC_PLAYER_RESPONSE_ADD_TO_FAVORITES";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REMOVE_FROM_FAVORITES:
                    return "MUSIC_PLAYER_RESPONSE_REMOVE_FROM_FAVORITES";
                case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_FAVORITES:
                    return "MUSIC_PLAYER_RESPONSE_PLAY_FAVORITES";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        public enum TypeMusicAudioInputSourceKnownValues
          {
            MusicAudioInputSource_Bluetooth,
            MusicAudioInputSource_Auxiliary,
            MusicAudioInputSource_HDMI1,
            MusicAudioInputSource_Optical,
            MusicAudioInputSource_CD,
            MusicAudioInputSource_USB,
            MusicAudioInputSource_USB_1,
            MusicAudioInputSource_USB_2,
            MusicAudioInputSource_USB_3,
            MusicAudioInputSource_USB_4,
            MusicAudioInputSource_USB_A,
            MusicAudioInputSource_USB_B,
            MusicAudioInputSource_USB_C,
            MusicAudioInputSource_USB_D,
            MusicAudioInputSource__none
          };
        public struct TypeMusicAudioInputSource
          {
            public bool in_known_list;
            public string string_value;
            public TypeMusicAudioInputSourceKnownValues list_value;
          };

        public static TypeMusicAudioInputSourceKnownValues  stringToMusicAudioInputSource(string chars)
          {
            switch (chars[0])
              {
                case 'A':
                    if ((String.Compare(chars, 1, "uxiliary", 0, 8, false) == 0) && (chars.Length == 9))
                        return TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_Auxiliary;
                    break;
                case 'B':
                    if ((String.Compare(chars, 1, "luetooth", 0, 8, false) == 0) && (chars.Length == 9))
                        return TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_Bluetooth;
                    break;
                case 'C':
                    if ((String.Compare(chars, 1, "D", 0, 1, false) == 0) && (chars.Length == 2))
                        return TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_CD;
                    break;
                case 'H':
                    if ((String.Compare(chars, 1, "DMI1", 0, 4, false) == 0) && (chars.Length == 5))
                        return TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_HDMI1;
                    break;
                case 'O':
                    if ((String.Compare(chars, 1, "ptical", 0, 6, false) == 0) && (chars.Length == 7))
                        return TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_Optical;
                    break;
                case 'U':
                    if (String.Compare(chars, 1, "SB", 0, 2, false) == 0)
                      {
                        if (chars.Length == 3)
                          {
                            return TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB;
                          }
                        switch (chars[3])
                          {
                            case '_':
                                switch (chars[4])
                                  {
                                    case '1':
                                        if (chars.Length == 5)
                                            return TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_1;
                                        break;
                                    case '2':
                                        if (chars.Length == 5)
                                            return TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_2;
                                        break;
                                    case '3':
                                        if (chars.Length == 5)
                                            return TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_3;
                                        break;
                                    case '4':
                                        if (chars.Length == 5)
                                            return TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_4;
                                        break;
                                    case 'A':
                                        if (chars.Length == 5)
                                            return TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_A;
                                        break;
                                    case 'B':
                                        if (chars.Length == 5)
                                            return TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_B;
                                        break;
                                    case 'C':
                                        if (chars.Length == 5)
                                            return TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_C;
                                        break;
                                    case 'D':
                                        if (chars.Length == 5)
                                            return TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_D;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource__none;
          }

        public static string  stringFromMusicAudioInputSource(TypeMusicAudioInputSourceKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_Bluetooth:
                    return "Bluetooth";
                case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_Auxiliary:
                    return "Auxiliary";
                case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_HDMI1:
                    return "HDMI1";
                case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_Optical:
                    return "Optical";
                case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_CD:
                    return "CD";
                case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB:
                    return "USB";
                case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_1:
                    return "USB_1";
                case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_2:
                    return "USB_2";
                case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_3:
                    return "USB_3";
                case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_4:
                    return "USB_4";
                case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_A:
                    return "USB_A";
                case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_B:
                    return "USB_B";
                case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_C:
                    return "USB_C";
                case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_D:
                    return "USB_D";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        public enum TypeMusicSourceDeviceKnownValues
          {
            MusicSourceDevice_iPhone,
            MusicSourceDevice_iPod,
            MusicSourceDevice_CDPlayer,
            MusicSourceDevice_Laptop,
            MusicSourceDevice_Computer,
            MusicSourceDevice__none
          };
        public struct TypeMusicSourceDevice
          {
            public bool in_known_list;
            public string string_value;
            public TypeMusicSourceDeviceKnownValues list_value;
          };

        public static TypeMusicSourceDeviceKnownValues  stringToMusicSourceDevice(string chars)
          {
            switch (chars[0])
              {
                case 'C':
                    switch (chars[1])
                      {
                        case 'D':
                            if ((String.Compare(chars, 2, "Player", 0, 6, false) == 0) && (chars.Length == 8))
                                return TypeMusicSourceDeviceKnownValues.MusicSourceDevice_CDPlayer;
                            break;
                        case 'o':
                            if ((String.Compare(chars, 2, "mputer", 0, 6, false) == 0) && (chars.Length == 8))
                                return TypeMusicSourceDeviceKnownValues.MusicSourceDevice_Computer;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if ((String.Compare(chars, 1, "aptop", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeMusicSourceDeviceKnownValues.MusicSourceDevice_Laptop;
                    break;
                case 'i':
                    if (String.Compare(chars, 1, "P", 0, 1, false) == 0)
                      {
                        switch (chars[2])
                          {
                            case 'h':
                                if ((String.Compare(chars, 3, "one", 0, 3, false) == 0) && (chars.Length == 6))
                                    return TypeMusicSourceDeviceKnownValues.MusicSourceDevice_iPhone;
                                break;
                            case 'o':
                                if ((String.Compare(chars, 3, "d", 0, 1, false) == 0) && (chars.Length == 4))
                                    return TypeMusicSourceDeviceKnownValues.MusicSourceDevice_iPod;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return TypeMusicSourceDeviceKnownValues.MusicSourceDevice__none;
          }

        public static string  stringFromMusicSourceDevice(TypeMusicSourceDeviceKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeMusicSourceDeviceKnownValues.MusicSourceDevice_iPhone:
                    return "iPhone";
                case TypeMusicSourceDeviceKnownValues.MusicSourceDevice_iPod:
                    return "iPod";
                case TypeMusicSourceDeviceKnownValues.MusicSourceDevice_CDPlayer:
                    return "CDPlayer";
                case TypeMusicSourceDeviceKnownValues.MusicSourceDevice_Laptop:
                    return "Laptop";
                case TypeMusicSourceDeviceKnownValues.MusicSourceDevice_Computer:
                    return "Computer";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasCommandType;
        private TypeCommandType storeCommandType;
        private bool flagHasPlayNumberedTrackTrackNumber;
        private BigInteger storePlayNumberedTrackTrackNumber;
        private bool flagHasRewindFastForwardAmountInSeconds;
        private double storeRewindFastForwardAmountInSeconds;
        private string textStoreRewindFastForwardAmountInSeconds;
        private bool flagHasSeekOffsetInSeconds;
        private double storeSeekOffsetInSeconds;
        private string textStoreSeekOffsetInSeconds;
        private bool flagHasSeekOffsetPercentage;
        private double storeSeekOffsetPercentage;
        private string textStoreSeekOffsetPercentage;
        private bool flagHasSkipAmount;
        private BigInteger storeSkipAmount;
        private bool flagHasMusicThirdParty;
        private MusicThirdPartyJSON  storeMusicThirdParty;
        private bool flagHasMusicThirdPartyDetails;
        private MusicThirdPartyDetailsJSON  storeMusicThirdPartyDetails;
        private bool flagHasUserRequestedVideos;
        private bool storeUserRequestedVideos;
        private bool flagHasUserRequestedPreview;
        private bool storeUserRequestedPreview;
        private bool flagHasUserRequestedFullPlayback;
        private bool storeUserRequestedFullPlayback;
        private bool flagHasUserRequestedSkip;
        private bool storeUserRequestedSkip;
        private bool flagHasUserRequestedAirplay;
        private bool storeUserRequestedAirplay;
        private bool flagHasUserRequestedResume;
        private bool storeUserRequestedResume;
        private bool flagHasUserRequestedAll;
        private bool storeUserRequestedAll;
        private bool flagHasUserSpecifiedPlaylist;
        private bool storeUserSpecifiedPlaylist;
        private bool flagHasUserSpecifiedCurrentPage;
        private bool storeUserSpecifiedCurrentPage;
        private bool flagHasTargetTrackName;
        private string storeTargetTrackName;
        private bool flagHasTargetTrackArtistName;
        private string storeTargetTrackArtistName;
        private bool flagHasTargetTrackSoundHoundId;
        private SoundHoundTrackIDJSON  storeTargetTrackSoundHoundId;
        private bool flagHasMusicAudioInputSource;
        private TypeMusicAudioInputSource storeMusicAudioInputSource;
        private bool flagHasMusicSourceDevice;
        private TypeMusicSourceDevice storeMusicSourceDevice;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONCommandType(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field CommandType of TypeNativeDataJSON is not a string.");
            TypeCommandType the_open_enum = new TypeCommandType();
            if (String.Compare(json_string.getData(), 0, "MUSIC_PLAYER_RESPONSE_", 0, 22, false) == 0)
              {
                switch (json_string.getData()[22])
                  {
                    case 'A':
                        if ((String.Compare(json_string.getData(), 23, "DD_TO_FAVORITES", 0, 15, false) == 0) && (json_string.getData().Length == 38))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_ADD_TO_FAVORITES;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'F':
                        if ((String.Compare(json_string.getData(), 23, "AST_FORWARD", 0, 11, false) == 0) && (json_string.getData().Length == 34))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_FAST_FORWARD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'L':
                        if ((String.Compare(json_string.getData(), 23, "OWER_VOLUME", 0, 11, false) == 0) && (json_string.getData().Length == 34))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_LOWER_VOLUME;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'M':
                        if ((String.Compare(json_string.getData(), 23, "UTE", 0, 3, false) == 0) && (json_string.getData().Length == 26))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_MUTE;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'P':
                        switch (json_string.getData()[23])
                          {
                            case 'A':
                                if ((String.Compare(json_string.getData(), 24, "USE", 0, 3, false) == 0) && (json_string.getData().Length == 27))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PAUSE;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'L':
                                if (String.Compare(json_string.getData(), 24, "AY_", 0, 3, false) == 0)
                                  {
                                    switch (json_string.getData()[27])
                                      {
                                        case 'C':
                                            if ((String.Compare(json_string.getData(), 28, "URRENT_SONG", 0, 11, false) == 0) && (json_string.getData().Length == 39))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_CURRENT_SONG;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 28, "AVORITES", 0, 8, false) == 0) && (json_string.getData().Length == 36))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_FAVORITES;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'L':
                                            if (String.Compare(json_string.getData(), 28, "AST_", 0, 4, false) == 0)
                                              {
                                                switch (json_string.getData()[32])
                                                  {
                                                    case 'I':
                                                        if ((String.Compare(json_string.getData(), 33, "DENTIFIED_SONG", 0, 14, false) == 0) && (json_string.getData().Length == 47))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_LAST_IDENTIFIED_SONG;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'S':
                                                        if ((String.Compare(json_string.getData(), 33, "ONG", 0, 3, false) == 0) && (json_string.getData().Length == 36))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_LAST_SONG;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'N':
                                            if ((String.Compare(json_string.getData(), 28, "UMBERED_TRACK", 0, 13, false) == 0) && (json_string.getData().Length == 41))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_NUMBERED_TRACK;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'R':
                        switch (json_string.getData()[23])
                          {
                            case 'A':
                                if ((String.Compare(json_string.getData(), 24, "ISE_VOLUME", 0, 10, false) == 0) && (json_string.getData().Length == 34))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_RAISE_VOLUME;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'E':
                                switch (json_string.getData()[24])
                                  {
                                    case 'M':
                                        if ((String.Compare(json_string.getData(), 25, "OVE_FROM_FAVORITES", 0, 18, false) == 0) && (json_string.getData().Length == 43))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REMOVE_FROM_FAVORITES;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'P':
                                        switch (json_string.getData()[25])
                                          {
                                            case 'E':
                                                if (String.Compare(json_string.getData(), 26, "AT_", 0, 3, false) == 0)
                                                  {
                                                    switch (json_string.getData()[29])
                                                      {
                                                        case 'O':
                                                            switch (json_string.getData()[30])
                                                              {
                                                                case 'F':
                                                                    if ((String.Compare(json_string.getData(), 31, "F", 0, 1, false) == 0) && (json_string.getData().Length == 32))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REPEAT_OFF;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'N':
                                                                    if (json_string.getData().Length == 31)
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REPEAT_ON;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'S':
                                                            if ((String.Compare(json_string.getData(), 30, "INGLE", 0, 5, false) == 0) && (json_string.getData().Length == 35))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REPEAT_SINGLE;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'L':
                                                if ((String.Compare(json_string.getData(), 26, "AY", 0, 2, false) == 0) && (json_string.getData().Length == 28))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REPLAY;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'W':
                                        if ((String.Compare(json_string.getData(), 25, "IND", 0, 3, false) == 0) && (json_string.getData().Length == 28))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REWIND;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'S':
                        switch (json_string.getData()[23])
                          {
                            case 'E':
                                switch (json_string.getData()[24])
                                  {
                                    case 'A':
                                        if ((String.Compare(json_string.getData(), 25, "RCH", 0, 3, false) == 0) && (json_string.getData().Length == 28))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SEARCH;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'E':
                                        if ((String.Compare(json_string.getData(), 25, "K", 0, 1, false) == 0) && (json_string.getData().Length == 26))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SEEK;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'T':
                                        if (String.Compare(json_string.getData(), 25, "_P", 0, 2, false) == 0)
                                          {
                                            switch (json_string.getData()[27])
                                              {
                                                case 'L':
                                                    if ((String.Compare(json_string.getData(), 28, "AYBACK_MODE", 0, 11, false) == 0) && (json_string.getData().Length == 39))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SET_PLAYBACK_MODE;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'R':
                                                    if ((String.Compare(json_string.getData(), 28, "OVIDER", 0, 6, false) == 0) && (json_string.getData().Length == 34))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SET_PROVIDER;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'H':
                                if (String.Compare(json_string.getData(), 24, "UFFLE", 0, 5, false) == 0)
                                  {
                                    if (json_string.getData().Length == 29)
                                      {
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SHUFFLE;
                                            goto open_enum_is_done;
                                          }
                                      }
                                    switch (json_string.getData()[29])
                                      {
                                        case '_':
                                            if (String.Compare(json_string.getData(), 30, "O", 0, 1, false) == 0)
                                              {
                                                switch (json_string.getData()[31])
                                                  {
                                                    case 'F':
                                                        if ((String.Compare(json_string.getData(), 32, "F", 0, 1, false) == 0) && (json_string.getData().Length == 33))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SHUFFLE_OFF;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'N':
                                                        if (json_string.getData().Length == 32)
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SHUFFLE_ON;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'K':
                                if (String.Compare(json_string.getData(), 24, "IP", 0, 2, false) == 0)
                                  {
                                    if (json_string.getData().Length == 26)
                                      {
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SKIP;
                                            goto open_enum_is_done;
                                          }
                                      }
                                    switch (json_string.getData()[26])
                                      {
                                        case '_':
                                            if ((String.Compare(json_string.getData(), 27, "ALBUM", 0, 5, false) == 0) && (json_string.getData().Length == 32))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SKIP_ALBUM;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'T':
                                if ((String.Compare(json_string.getData(), 24, "OP", 0, 2, false) == 0) && (json_string.getData().Length == 26))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_STOP;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'T':
                        if (String.Compare(json_string.getData(), 23, "HUMBS_", 0, 6, false) == 0)
                          {
                            switch (json_string.getData()[29])
                              {
                                case 'D':
                                    if ((String.Compare(json_string.getData(), 30, "OWN", 0, 3, false) == 0) && (json_string.getData().Length == 33))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_THUMBS_DOWN;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'U':
                                    if ((String.Compare(json_string.getData(), 30, "P", 0, 1, false) == 0) && (json_string.getData().Length == 31))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_THUMBS_UP;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'U':
                        if ((String.Compare(json_string.getData(), 23, "NMUTE", 0, 5, false) == 0) && (json_string.getData().Length == 28))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_UNMUTE;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setCommandType(the_open_enum);
          }


        private void  fromJSONPlayNumberedTrackTrackNumber(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field PlayNumberedTrackTrackNumber of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field PlayNumberedTrackTrackNumber of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setPlayNumberedTrackTrackNumber(extracted_integer);
          }


        private void  fromJSONRewindFastForwardAmountInSeconds(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONRationalValue json_rational = json_value.rational_value();
            string the_rational_text;
            if (json_rational != null)
              {
                the_rational_text = json_rational.getText();
              }
            else
              {
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer != null)
                  {
                    the_rational_text = json_integer.getText();
                  }
                else
                  {
                    throw new Exception("The value for field RewindFastForwardAmountInSeconds of TypeNativeDataJSON is not a number.");
                  }
              }
            setRewindFastForwardAmountInSecondsText(the_rational_text);
          }


        private void  fromJSONSeekOffsetInSeconds(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONRationalValue json_rational = json_value.rational_value();
            string the_rational_text;
            if (json_rational != null)
              {
                the_rational_text = json_rational.getText();
              }
            else
              {
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer != null)
                  {
                    the_rational_text = json_integer.getText();
                  }
                else
                  {
                    throw new Exception("The value for field SeekOffsetInSeconds of TypeNativeDataJSON is not a number.");
                  }
              }
            setSeekOffsetInSecondsText(the_rational_text);
          }


        private void  fromJSONSeekOffsetPercentage(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONRationalValue json_rational = json_value.rational_value();
            string the_rational_text;
            if (json_rational != null)
              {
                the_rational_text = json_rational.getText();
              }
            else
              {
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer != null)
                  {
                    the_rational_text = json_integer.getText();
                  }
                else
                  {
                    throw new Exception("The value for field SeekOffsetPercentage of TypeNativeDataJSON is not a number.");
                  }
              }
            setSeekOffsetPercentageText(the_rational_text);
          }


        private void  fromJSONSkipAmount(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field SkipAmount of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field SkipAmount of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setSkipAmount(extracted_integer);
          }


        private void  fromJSONMusicThirdParty(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MusicThirdPartyJSON convert_classy = MusicThirdPartyJSON.from_json(json_value, ignore_extras, true);
            setMusicThirdParty(convert_classy);
          }


        private void  fromJSONMusicThirdPartyDetails(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MusicThirdPartyDetailsJSON convert_classy = MusicThirdPartyDetailsJSON.from_json(json_value, ignore_extras, true);
            setMusicThirdPartyDetails(convert_classy);
          }


        private void  fromJSONUserRequestedVideos(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONTrueValue json_true = json_value.true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_value.false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for field UserRequestedVideos of TypeNativeDataJSON is not true for false.");
                  }
              }
            setUserRequestedVideos(the_bool);
          }


        private void  fromJSONUserRequestedPreview(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONTrueValue json_true = json_value.true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_value.false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for field UserRequestedPreview of TypeNativeDataJSON is not true for false.");
                  }
              }
            setUserRequestedPreview(the_bool);
          }


        private void  fromJSONUserRequestedFullPlayback(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONTrueValue json_true = json_value.true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_value.false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for field UserRequestedFullPlayback of TypeNativeDataJSON is not true for false.");
                  }
              }
            setUserRequestedFullPlayback(the_bool);
          }


        private void  fromJSONUserRequestedSkip(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONTrueValue json_true = json_value.true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_value.false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for field UserRequestedSkip of TypeNativeDataJSON is not true for false.");
                  }
              }
            setUserRequestedSkip(the_bool);
          }


        private void  fromJSONUserRequestedAirplay(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONTrueValue json_true = json_value.true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_value.false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for field UserRequestedAirplay of TypeNativeDataJSON is not true for false.");
                  }
              }
            setUserRequestedAirplay(the_bool);
          }


        private void  fromJSONUserRequestedResume(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONTrueValue json_true = json_value.true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_value.false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for field UserRequestedResume of TypeNativeDataJSON is not true for false.");
                  }
              }
            setUserRequestedResume(the_bool);
          }


        private void  fromJSONUserRequestedAll(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONTrueValue json_true = json_value.true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_value.false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for field UserRequestedAll of TypeNativeDataJSON is not true for false.");
                  }
              }
            setUserRequestedAll(the_bool);
          }


        private void  fromJSONUserSpecifiedPlaylist(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONTrueValue json_true = json_value.true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_value.false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for field UserSpecifiedPlaylist of TypeNativeDataJSON is not true for false.");
                  }
              }
            setUserSpecifiedPlaylist(the_bool);
          }


        private void  fromJSONUserSpecifiedCurrentPage(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONTrueValue json_true = json_value.true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_value.false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for field UserSpecifiedCurrentPage of TypeNativeDataJSON is not true for false.");
                  }
              }
            setUserSpecifiedCurrentPage(the_bool);
          }


        private void  fromJSONTargetTrackName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field TargetTrackName of TypeNativeDataJSON is not a string.");
            setTargetTrackName(json_string.getData());
          }


        private void  fromJSONTargetTrackArtistName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field TargetTrackArtistName of TypeNativeDataJSON is not a string.");
            setTargetTrackArtistName(json_string.getData());
          }


        private void  fromJSONTargetTrackSoundHoundId(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SoundHoundTrackIDJSON convert_classy = SoundHoundTrackIDJSON.from_json(json_value, ignore_extras, true);
            setTargetTrackSoundHoundId(convert_classy);
          }


        private void  fromJSONMusicAudioInputSource(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field MusicAudioInputSource of TypeNativeDataJSON is not a string.");
            TypeMusicAudioInputSource the_open_enum = new TypeMusicAudioInputSource();
            switch (json_string.getData()[0])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 1, "uxiliary", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_Auxiliary;
                            goto open_enum_is_done;
                          }
                    break;
                case 'B':
                    if ((String.Compare(json_string.getData(), 1, "luetooth", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_Bluetooth;
                            goto open_enum_is_done;
                          }
                    break;
                case 'C':
                    if ((String.Compare(json_string.getData(), 1, "D", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_CD;
                            goto open_enum_is_done;
                          }
                    break;
                case 'H':
                    if ((String.Compare(json_string.getData(), 1, "DMI1", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_HDMI1;
                            goto open_enum_is_done;
                          }
                    break;
                case 'O':
                    if ((String.Compare(json_string.getData(), 1, "ptical", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_Optical;
                            goto open_enum_is_done;
                          }
                    break;
                case 'U':
                    if (String.Compare(json_string.getData(), 1, "SB", 0, 2, false) == 0)
                      {
                        if (json_string.getData().Length == 3)
                          {
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB;
                                goto open_enum_is_done;
                              }
                          }
                        switch (json_string.getData()[3])
                          {
                            case '_':
                                switch (json_string.getData()[4])
                                  {
                                    case '1':
                                        if (json_string.getData().Length == 5)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_1;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case '2':
                                        if (json_string.getData().Length == 5)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_2;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case '3':
                                        if (json_string.getData().Length == 5)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_3;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case '4':
                                        if (json_string.getData().Length == 5)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_4;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'A':
                                        if (json_string.getData().Length == 5)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_A;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'B':
                                        if (json_string.getData().Length == 5)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_B;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'C':
                                        if (json_string.getData().Length == 5)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_C;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'D':
                                        if (json_string.getData().Length == 5)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_D;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setMusicAudioInputSource(the_open_enum);
          }


        private void  fromJSONMusicSourceDevice(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field MusicSourceDevice of TypeNativeDataJSON is not a string.");
            TypeMusicSourceDevice the_open_enum = new TypeMusicSourceDevice();
            switch (json_string.getData()[0])
              {
                case 'C':
                    switch (json_string.getData()[1])
                      {
                        case 'D':
                            if ((String.Compare(json_string.getData(), 2, "Player", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeMusicSourceDeviceKnownValues.MusicSourceDevice_CDPlayer;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'o':
                            if ((String.Compare(json_string.getData(), 2, "mputer", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeMusicSourceDeviceKnownValues.MusicSourceDevice_Computer;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if ((String.Compare(json_string.getData(), 1, "aptop", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeMusicSourceDeviceKnownValues.MusicSourceDevice_Laptop;
                            goto open_enum_is_done;
                          }
                    break;
                case 'i':
                    if (String.Compare(json_string.getData(), 1, "P", 0, 1, false) == 0)
                      {
                        switch (json_string.getData()[2])
                          {
                            case 'h':
                                if ((String.Compare(json_string.getData(), 3, "one", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeMusicSourceDeviceKnownValues.MusicSourceDevice_iPhone;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'o':
                                if ((String.Compare(json_string.getData(), 3, "d", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeMusicSourceDeviceKnownValues.MusicSourceDevice_iPod;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setMusicSourceDevice(the_open_enum);
          }


        public TypeNativeDataJSON()
          {
            flagHasCommandType = false;
            flagHasPlayNumberedTrackTrackNumber = false;
            flagHasRewindFastForwardAmountInSeconds = false;
            flagHasSeekOffsetInSeconds = false;
            flagHasSeekOffsetPercentage = false;
            flagHasSkipAmount = false;
            flagHasMusicThirdParty = false;
            flagHasMusicThirdPartyDetails = false;
            flagHasUserRequestedVideos = false;
            flagHasUserRequestedPreview = false;
            flagHasUserRequestedFullPlayback = false;
            flagHasUserRequestedSkip = false;
            flagHasUserRequestedAirplay = false;
            flagHasUserRequestedResume = false;
            flagHasUserRequestedAll = false;
            flagHasUserSpecifiedPlaylist = false;
            flagHasUserSpecifiedCurrentPage = false;
            flagHasTargetTrackName = false;
            flagHasTargetTrackArtistName = false;
            flagHasTargetTrackSoundHoundId = false;
            flagHasMusicAudioInputSource = false;
            flagHasMusicSourceDevice = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasCommandType()
          {
            return flagHasCommandType;
          }

        public TypeCommandType  getCommandType()
          {
            Debug.Assert(flagHasCommandType);
            return storeCommandType;
          }

        public string  getCommandTypeAsString()
          {
            TypeCommandType result = getCommandType();
            if (result.in_known_list)
                return stringFromCommandType(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasPlayNumberedTrackTrackNumber()
          {
            return flagHasPlayNumberedTrackTrackNumber;
          }

        public BigInteger  getPlayNumberedTrackTrackNumber()
          {
            Debug.Assert(flagHasPlayNumberedTrackTrackNumber);
            return storePlayNumberedTrackTrackNumber;
          }

        public bool  hasRewindFastForwardAmountInSeconds()
          {
            return flagHasRewindFastForwardAmountInSeconds;
          }

        public double  getRewindFastForwardAmountInSeconds()
          {
            Debug.Assert(flagHasRewindFastForwardAmountInSeconds);
            if (textStoreRewindFastForwardAmountInSeconds != "")
              {
                return Double.Parse(textStoreRewindFastForwardAmountInSeconds);
              }
            return storeRewindFastForwardAmountInSeconds;
          }

        public string  getRewindFastForwardAmountInSecondsAsText()
          {
            Debug.Assert(flagHasRewindFastForwardAmountInSeconds);
            if (textStoreRewindFastForwardAmountInSeconds == "")
              {
                return Convert.ToString(storeRewindFastForwardAmountInSeconds);
              }
            else
              {
                return (textStoreRewindFastForwardAmountInSeconds);
              }
          }

        public bool  hasSeekOffsetInSeconds()
          {
            return flagHasSeekOffsetInSeconds;
          }

        public double  getSeekOffsetInSeconds()
          {
            Debug.Assert(flagHasSeekOffsetInSeconds);
            if (textStoreSeekOffsetInSeconds != "")
              {
                return Double.Parse(textStoreSeekOffsetInSeconds);
              }
            return storeSeekOffsetInSeconds;
          }

        public string  getSeekOffsetInSecondsAsText()
          {
            Debug.Assert(flagHasSeekOffsetInSeconds);
            if (textStoreSeekOffsetInSeconds == "")
              {
                return Convert.ToString(storeSeekOffsetInSeconds);
              }
            else
              {
                return (textStoreSeekOffsetInSeconds);
              }
          }

        public bool  hasSeekOffsetPercentage()
          {
            return flagHasSeekOffsetPercentage;
          }

        public double  getSeekOffsetPercentage()
          {
            Debug.Assert(flagHasSeekOffsetPercentage);
            if (textStoreSeekOffsetPercentage != "")
              {
                return Double.Parse(textStoreSeekOffsetPercentage);
              }
            return storeSeekOffsetPercentage;
          }

        public string  getSeekOffsetPercentageAsText()
          {
            Debug.Assert(flagHasSeekOffsetPercentage);
            if (textStoreSeekOffsetPercentage == "")
              {
                return Convert.ToString(storeSeekOffsetPercentage);
              }
            else
              {
                return (textStoreSeekOffsetPercentage);
              }
          }

        public bool  hasSkipAmount()
          {
            return flagHasSkipAmount;
          }

        public BigInteger  getSkipAmount()
          {
            Debug.Assert(flagHasSkipAmount);
            return storeSkipAmount;
          }

        public bool  hasMusicThirdParty()
          {
            return flagHasMusicThirdParty;
          }

        public MusicThirdPartyJSON   getMusicThirdParty()
          {
            Debug.Assert(flagHasMusicThirdParty);
            return storeMusicThirdParty;
          }

        public bool  hasMusicThirdPartyDetails()
          {
            return flagHasMusicThirdPartyDetails;
          }

        public MusicThirdPartyDetailsJSON   getMusicThirdPartyDetails()
          {
            Debug.Assert(flagHasMusicThirdPartyDetails);
            return storeMusicThirdPartyDetails;
          }

        public bool  hasUserRequestedVideos()
          {
            return flagHasUserRequestedVideos;
          }

        public bool  getUserRequestedVideos()
          {
            Debug.Assert(flagHasUserRequestedVideos);
            return storeUserRequestedVideos;
          }

        public bool  hasUserRequestedPreview()
          {
            return flagHasUserRequestedPreview;
          }

        public bool  getUserRequestedPreview()
          {
            Debug.Assert(flagHasUserRequestedPreview);
            return storeUserRequestedPreview;
          }

        public bool  hasUserRequestedFullPlayback()
          {
            return flagHasUserRequestedFullPlayback;
          }

        public bool  getUserRequestedFullPlayback()
          {
            Debug.Assert(flagHasUserRequestedFullPlayback);
            return storeUserRequestedFullPlayback;
          }

        public bool  hasUserRequestedSkip()
          {
            return flagHasUserRequestedSkip;
          }

        public bool  getUserRequestedSkip()
          {
            Debug.Assert(flagHasUserRequestedSkip);
            return storeUserRequestedSkip;
          }

        public bool  hasUserRequestedAirplay()
          {
            return flagHasUserRequestedAirplay;
          }

        public bool  getUserRequestedAirplay()
          {
            Debug.Assert(flagHasUserRequestedAirplay);
            return storeUserRequestedAirplay;
          }

        public bool  hasUserRequestedResume()
          {
            return flagHasUserRequestedResume;
          }

        public bool  getUserRequestedResume()
          {
            Debug.Assert(flagHasUserRequestedResume);
            return storeUserRequestedResume;
          }

        public bool  hasUserRequestedAll()
          {
            return flagHasUserRequestedAll;
          }

        public bool  getUserRequestedAll()
          {
            Debug.Assert(flagHasUserRequestedAll);
            return storeUserRequestedAll;
          }

        public bool  hasUserSpecifiedPlaylist()
          {
            return flagHasUserSpecifiedPlaylist;
          }

        public bool  getUserSpecifiedPlaylist()
          {
            Debug.Assert(flagHasUserSpecifiedPlaylist);
            return storeUserSpecifiedPlaylist;
          }

        public bool  hasUserSpecifiedCurrentPage()
          {
            return flagHasUserSpecifiedCurrentPage;
          }

        public bool  getUserSpecifiedCurrentPage()
          {
            Debug.Assert(flagHasUserSpecifiedCurrentPage);
            return storeUserSpecifiedCurrentPage;
          }

        public bool  hasTargetTrackName()
          {
            return flagHasTargetTrackName;
          }

        public string  getTargetTrackName()
          {
            Debug.Assert(flagHasTargetTrackName);
            return storeTargetTrackName;
          }

        public bool  hasTargetTrackArtistName()
          {
            return flagHasTargetTrackArtistName;
          }

        public string  getTargetTrackArtistName()
          {
            Debug.Assert(flagHasTargetTrackArtistName);
            return storeTargetTrackArtistName;
          }

        public bool  hasTargetTrackSoundHoundId()
          {
            return flagHasTargetTrackSoundHoundId;
          }

        public SoundHoundTrackIDJSON   getTargetTrackSoundHoundId()
          {
            Debug.Assert(flagHasTargetTrackSoundHoundId);
            return storeTargetTrackSoundHoundId;
          }

        public long  getTargetTrackSoundHoundIdValue()
          {
            return getTargetTrackSoundHoundId().getValue();
          }

        public bool  hasMusicAudioInputSource()
          {
            return flagHasMusicAudioInputSource;
          }

        public TypeMusicAudioInputSource  getMusicAudioInputSource()
          {
            Debug.Assert(flagHasMusicAudioInputSource);
            return storeMusicAudioInputSource;
          }

        public string  getMusicAudioInputSourceAsString()
          {
            TypeMusicAudioInputSource result = getMusicAudioInputSource();
            if (result.in_known_list)
                return stringFromMusicAudioInputSource(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasMusicSourceDevice()
          {
            return flagHasMusicSourceDevice;
          }

        public TypeMusicSourceDevice  getMusicSourceDevice()
          {
            Debug.Assert(flagHasMusicSourceDevice);
            return storeMusicSourceDevice;
          }

        public string  getMusicSourceDeviceAsString()
          {
            TypeMusicSourceDevice result = getMusicSourceDevice();
            if (result.in_known_list)
                return stringFromMusicSourceDevice(result.list_value);
            else
                return result.string_value;
          }


        public virtual int extraTypeNativeDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNativeDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNativeDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNativeDataLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setCommandType(TypeCommandType new_value)
          {
            flagHasCommandType = true;
            storeCommandType = new_value;
          }
        public void setCommandType(string chars)
          {
            TypeCommandTypeKnownValues known = stringToCommandType(chars);
            TypeCommandType new_value = new TypeCommandType();
            if (known == TypeCommandTypeKnownValues.CommandType__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setCommandType(new_value);
          }
        public void setCommandType(TypeCommandTypeKnownValues new_value)
          {
            TypeCommandType new_full_value = new TypeCommandType();
            Debug.Assert(new_value != TypeCommandTypeKnownValues.CommandType__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setCommandType(new_full_value);
          }
        public void unsetCommandType()
          {
            flagHasCommandType = false;
          }
        public void setPlayNumberedTrackTrackNumber(BigInteger new_value)
          {
            flagHasPlayNumberedTrackTrackNumber = true;
            storePlayNumberedTrackTrackNumber = new_value;
          }
        public void unsetPlayNumberedTrackTrackNumber()
          {
            flagHasPlayNumberedTrackTrackNumber = false;
          }
        public void setRewindFastForwardAmountInSeconds(double new_value)
          {
            flagHasRewindFastForwardAmountInSeconds = true;
            storeRewindFastForwardAmountInSeconds = new_value;
            textStoreRewindFastForwardAmountInSeconds = "";
          }
        public void setRewindFastForwardAmountInSecondsText(string new_value)
          {
            flagHasRewindFastForwardAmountInSeconds = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field RewindFastForwardAmountInSeconds of TypeNativeDataJSON is not a valid number.");
            textStoreRewindFastForwardAmountInSeconds = new_value;
          }
        public void unsetRewindFastForwardAmountInSeconds()
          {
            flagHasRewindFastForwardAmountInSeconds = false;
          }
        public void setSeekOffsetInSeconds(double new_value)
          {
            flagHasSeekOffsetInSeconds = true;
            storeSeekOffsetInSeconds = new_value;
            textStoreSeekOffsetInSeconds = "";
          }
        public void setSeekOffsetInSecondsText(string new_value)
          {
            flagHasSeekOffsetInSeconds = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field SeekOffsetInSeconds of TypeNativeDataJSON is not a valid number.");
            textStoreSeekOffsetInSeconds = new_value;
          }
        public void unsetSeekOffsetInSeconds()
          {
            flagHasSeekOffsetInSeconds = false;
          }
        public void setSeekOffsetPercentage(double new_value)
          {
            flagHasSeekOffsetPercentage = true;
            storeSeekOffsetPercentage = new_value;
            textStoreSeekOffsetPercentage = "";
          }
        public void setSeekOffsetPercentageText(string new_value)
          {
            flagHasSeekOffsetPercentage = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field SeekOffsetPercentage of TypeNativeDataJSON is not a valid number.");
            textStoreSeekOffsetPercentage = new_value;
          }
        public void unsetSeekOffsetPercentage()
          {
            flagHasSeekOffsetPercentage = false;
          }
        public void setSkipAmount(BigInteger new_value)
          {
            flagHasSkipAmount = true;
            storeSkipAmount = new_value;
          }
        public void unsetSkipAmount()
          {
            flagHasSkipAmount = false;
          }
        public void setMusicThirdParty(MusicThirdPartyJSON  new_value)
          {
            if (flagHasMusicThirdParty)
              {
              }
            flagHasMusicThirdParty = true;
            storeMusicThirdParty = new_value;
          }
        public void unsetMusicThirdParty()
          {
            if (flagHasMusicThirdParty)
              {
              }
            flagHasMusicThirdParty = false;
          }
        public void setMusicThirdPartyDetails(MusicThirdPartyDetailsJSON  new_value)
          {
            if (flagHasMusicThirdPartyDetails)
              {
              }
            flagHasMusicThirdPartyDetails = true;
            storeMusicThirdPartyDetails = new_value;
          }
        public void unsetMusicThirdPartyDetails()
          {
            if (flagHasMusicThirdPartyDetails)
              {
              }
            flagHasMusicThirdPartyDetails = false;
          }
        public void setUserRequestedVideos(bool new_value)
          {
            flagHasUserRequestedVideos = true;
            storeUserRequestedVideos = new_value;
          }
        public void unsetUserRequestedVideos()
          {
            flagHasUserRequestedVideos = false;
          }
        public void setUserRequestedPreview(bool new_value)
          {
            flagHasUserRequestedPreview = true;
            storeUserRequestedPreview = new_value;
          }
        public void unsetUserRequestedPreview()
          {
            flagHasUserRequestedPreview = false;
          }
        public void setUserRequestedFullPlayback(bool new_value)
          {
            flagHasUserRequestedFullPlayback = true;
            storeUserRequestedFullPlayback = new_value;
          }
        public void unsetUserRequestedFullPlayback()
          {
            flagHasUserRequestedFullPlayback = false;
          }
        public void setUserRequestedSkip(bool new_value)
          {
            flagHasUserRequestedSkip = true;
            storeUserRequestedSkip = new_value;
          }
        public void unsetUserRequestedSkip()
          {
            flagHasUserRequestedSkip = false;
          }
        public void setUserRequestedAirplay(bool new_value)
          {
            flagHasUserRequestedAirplay = true;
            storeUserRequestedAirplay = new_value;
          }
        public void unsetUserRequestedAirplay()
          {
            flagHasUserRequestedAirplay = false;
          }
        public void setUserRequestedResume(bool new_value)
          {
            flagHasUserRequestedResume = true;
            storeUserRequestedResume = new_value;
          }
        public void unsetUserRequestedResume()
          {
            flagHasUserRequestedResume = false;
          }
        public void setUserRequestedAll(bool new_value)
          {
            flagHasUserRequestedAll = true;
            storeUserRequestedAll = new_value;
          }
        public void unsetUserRequestedAll()
          {
            flagHasUserRequestedAll = false;
          }
        public void setUserSpecifiedPlaylist(bool new_value)
          {
            flagHasUserSpecifiedPlaylist = true;
            storeUserSpecifiedPlaylist = new_value;
          }
        public void unsetUserSpecifiedPlaylist()
          {
            flagHasUserSpecifiedPlaylist = false;
          }
        public void setUserSpecifiedCurrentPage(bool new_value)
          {
            flagHasUserSpecifiedCurrentPage = true;
            storeUserSpecifiedCurrentPage = new_value;
          }
        public void unsetUserSpecifiedCurrentPage()
          {
            flagHasUserSpecifiedCurrentPage = false;
          }
        public void setTargetTrackName(string new_value)
          {
            flagHasTargetTrackName = true;
            storeTargetTrackName = new_value;
          }
        public void unsetTargetTrackName()
          {
            flagHasTargetTrackName = false;
          }
        public void setTargetTrackArtistName(string new_value)
          {
            flagHasTargetTrackArtistName = true;
            storeTargetTrackArtistName = new_value;
          }
        public void unsetTargetTrackArtistName()
          {
            flagHasTargetTrackArtistName = false;
          }
        public void setTargetTrackSoundHoundId(SoundHoundTrackIDJSON  new_value)
          {
            if (flagHasTargetTrackSoundHoundId)
              {
              }
            flagHasTargetTrackSoundHoundId = true;
            storeTargetTrackSoundHoundId = new_value;
          }
        public void setTargetTrackSoundHoundId(long new_value)
          {
            setTargetTrackSoundHoundId(new SoundHoundTrackIDJSON(new_value));
          }
        public void unsetTargetTrackSoundHoundId()
          {
            if (flagHasTargetTrackSoundHoundId)
              {
              }
            flagHasTargetTrackSoundHoundId = false;
          }
        public void setMusicAudioInputSource(TypeMusicAudioInputSource new_value)
          {
            flagHasMusicAudioInputSource = true;
            storeMusicAudioInputSource = new_value;
          }
        public void setMusicAudioInputSource(string chars)
          {
            TypeMusicAudioInputSourceKnownValues known = stringToMusicAudioInputSource(chars);
            TypeMusicAudioInputSource new_value = new TypeMusicAudioInputSource();
            if (known == TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setMusicAudioInputSource(new_value);
          }
        public void setMusicAudioInputSource(TypeMusicAudioInputSourceKnownValues new_value)
          {
            TypeMusicAudioInputSource new_full_value = new TypeMusicAudioInputSource();
            Debug.Assert(new_value != TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setMusicAudioInputSource(new_full_value);
          }
        public void unsetMusicAudioInputSource()
          {
            flagHasMusicAudioInputSource = false;
          }
        public void setMusicSourceDevice(TypeMusicSourceDevice new_value)
          {
            flagHasMusicSourceDevice = true;
            storeMusicSourceDevice = new_value;
          }
        public void setMusicSourceDevice(string chars)
          {
            TypeMusicSourceDeviceKnownValues known = stringToMusicSourceDevice(chars);
            TypeMusicSourceDevice new_value = new TypeMusicSourceDevice();
            if (known == TypeMusicSourceDeviceKnownValues.MusicSourceDevice__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setMusicSourceDevice(new_value);
          }
        public void setMusicSourceDevice(TypeMusicSourceDeviceKnownValues new_value)
          {
            TypeMusicSourceDevice new_full_value = new TypeMusicSourceDevice();
            Debug.Assert(new_value != TypeMusicSourceDeviceKnownValues.MusicSourceDevice__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setMusicSourceDevice(new_full_value);
          }
        public void unsetMusicSourceDevice()
          {
            flagHasMusicSourceDevice = false;
          }

        public virtual void extraTypeNativeDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNativeDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNativeDataLookup(key);
            if (old_field == null)
              {
                extraTypeNativeDataAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals( key))
                      {
                        extraValues[num] = new_component;
                        break;
                      }
                  }
                extraIndex.Add(key, new_component);
              }
          }

        public override void write_as_json(JSONHandler handler)
          {
            handler.start_object();
            write_fields_as_json(handler);
            int extra_count = extraKeys.Count;
            Debug.Assert(extra_count == extraValues.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                handler.start_pair(extraKeys[extra_num]);
                extraValues[extra_num].write(handler);
              }
            handler.finish_object();
          }

        public virtual void write_fields_as_json(JSONHandler handler)
          {
            write_fields_as_json(handler, false);
          }

        public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
          {
            Debug.Assert(partial_allowed || flagHasCommandType);
            if (flagHasCommandType)
              {
                handler.start_pair("CommandType");
                if (storeCommandType.in_known_list)
                  {
                    switch (storeCommandType.list_value)
                      {
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SEARCH:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_SEARCH");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_NUMBERED_TRACK:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_PLAY_NUMBERED_TRACK");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_LAST_SONG:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_PLAY_LAST_SONG");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_CURRENT_SONG:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_PLAY_CURRENT_SONG");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PAUSE:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_PAUSE");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SKIP:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_SKIP");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_THUMBS_UP:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_THUMBS_UP");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_THUMBS_DOWN:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_THUMBS_DOWN");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_RAISE_VOLUME:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_RAISE_VOLUME");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_LOWER_VOLUME:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_LOWER_VOLUME");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_MUTE:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_MUTE");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_UNMUTE:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_UNMUTE");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_STOP:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_STOP");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REPLAY:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_REPLAY");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REWIND:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_REWIND");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_FAST_FORWARD:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_FAST_FORWARD");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_LAST_IDENTIFIED_SONG:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_PLAY_LAST_IDENTIFIED_SONG");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SHUFFLE:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_SHUFFLE");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SEEK:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_SEEK");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SHUFFLE_ON:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_SHUFFLE_ON");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SHUFFLE_OFF:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_SHUFFLE_OFF");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REPEAT_ON:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_REPEAT_ON");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REPEAT_OFF:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_REPEAT_OFF");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REPEAT_SINGLE:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_REPEAT_SINGLE");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SET_PROVIDER:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_SET_PROVIDER");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SET_PLAYBACK_MODE:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_SET_PLAYBACK_MODE");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_SKIP_ALBUM:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_SKIP_ALBUM");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_ADD_TO_FAVORITES:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_ADD_TO_FAVORITES");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_REMOVE_FROM_FAVORITES:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_REMOVE_FROM_FAVORITES");
                            break;
                        case TypeCommandTypeKnownValues.CommandType_MUSIC_PLAYER_RESPONSE_PLAY_FAVORITES:
                            handler.string_value("MUSIC_PLAYER_RESPONSE_PLAY_FAVORITES");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeCommandType.string_value);
                  }
              }
            if (flagHasPlayNumberedTrackTrackNumber)
              {
                handler.start_pair("PlayNumberedTrackTrackNumber");
                handler.number_value(storePlayNumberedTrackTrackNumber);
              }
            if (flagHasRewindFastForwardAmountInSeconds)
              {
                handler.start_pair("RewindFastForwardAmountInSeconds");
                if (textStoreRewindFastForwardAmountInSeconds != "")
                    handler.number_value(textStoreRewindFastForwardAmountInSeconds);
                else if (((double)(long)storeRewindFastForwardAmountInSeconds) == storeRewindFastForwardAmountInSeconds)
                    handler.number_value((long)storeRewindFastForwardAmountInSeconds);
                else
                    handler.number_value(storeRewindFastForwardAmountInSeconds);
              }
            if (flagHasSeekOffsetInSeconds)
              {
                handler.start_pair("SeekOffsetInSeconds");
                if (textStoreSeekOffsetInSeconds != "")
                    handler.number_value(textStoreSeekOffsetInSeconds);
                else if (((double)(long)storeSeekOffsetInSeconds) == storeSeekOffsetInSeconds)
                    handler.number_value((long)storeSeekOffsetInSeconds);
                else
                    handler.number_value(storeSeekOffsetInSeconds);
              }
            if (flagHasSeekOffsetPercentage)
              {
                handler.start_pair("SeekOffsetPercentage");
                if (textStoreSeekOffsetPercentage != "")
                    handler.number_value(textStoreSeekOffsetPercentage);
                else if (((double)(long)storeSeekOffsetPercentage) == storeSeekOffsetPercentage)
                    handler.number_value((long)storeSeekOffsetPercentage);
                else
                    handler.number_value(storeSeekOffsetPercentage);
              }
            if (flagHasSkipAmount)
              {
                handler.start_pair("SkipAmount");
                handler.number_value(storeSkipAmount);
              }
            if (flagHasMusicThirdParty)
              {
                handler.start_pair("MusicThirdParty");
                if (partial_allowed)
                    storeMusicThirdParty.write_partial_as_json(handler);
                else
                    storeMusicThirdParty.write_as_json(handler);
              }
            if (flagHasMusicThirdPartyDetails)
              {
                handler.start_pair("MusicThirdPartyDetails");
                if (partial_allowed)
                    storeMusicThirdPartyDetails.write_partial_as_json(handler);
                else
                    storeMusicThirdPartyDetails.write_as_json(handler);
              }
            if (flagHasUserRequestedVideos)
              {
                handler.start_pair("UserRequestedVideos");
                handler.boolean_value(storeUserRequestedVideos);
              }
            if (flagHasUserRequestedPreview)
              {
                handler.start_pair("UserRequestedPreview");
                handler.boolean_value(storeUserRequestedPreview);
              }
            if (flagHasUserRequestedFullPlayback)
              {
                handler.start_pair("UserRequestedFullPlayback");
                handler.boolean_value(storeUserRequestedFullPlayback);
              }
            if (flagHasUserRequestedSkip)
              {
                handler.start_pair("UserRequestedSkip");
                handler.boolean_value(storeUserRequestedSkip);
              }
            if (flagHasUserRequestedAirplay)
              {
                handler.start_pair("UserRequestedAirplay");
                handler.boolean_value(storeUserRequestedAirplay);
              }
            if (flagHasUserRequestedResume)
              {
                handler.start_pair("UserRequestedResume");
                handler.boolean_value(storeUserRequestedResume);
              }
            if (flagHasUserRequestedAll)
              {
                handler.start_pair("UserRequestedAll");
                handler.boolean_value(storeUserRequestedAll);
              }
            if (flagHasUserSpecifiedPlaylist)
              {
                handler.start_pair("UserSpecifiedPlaylist");
                handler.boolean_value(storeUserSpecifiedPlaylist);
              }
            if (flagHasUserSpecifiedCurrentPage)
              {
                handler.start_pair("UserSpecifiedCurrentPage");
                handler.boolean_value(storeUserSpecifiedCurrentPage);
              }
            if (flagHasTargetTrackName)
              {
                handler.start_pair("TargetTrackName");
                handler.string_value(storeTargetTrackName);
              }
            if (flagHasTargetTrackArtistName)
              {
                handler.start_pair("TargetTrackArtistName");
                handler.string_value(storeTargetTrackArtistName);
              }
            if (flagHasTargetTrackSoundHoundId)
              {
                handler.start_pair("TargetTrackSoundHoundId");
                if (partial_allowed)
                    storeTargetTrackSoundHoundId.write_partial_as_json(handler);
                else
                    storeTargetTrackSoundHoundId.write_as_json(handler);
              }
            if (flagHasMusicAudioInputSource)
              {
                handler.start_pair("MusicAudioInputSource");
                if (storeMusicAudioInputSource.in_known_list)
                  {
                    switch (storeMusicAudioInputSource.list_value)
                      {
                        case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_Bluetooth:
                            handler.string_value("Bluetooth");
                            break;
                        case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_Auxiliary:
                            handler.string_value("Auxiliary");
                            break;
                        case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_HDMI1:
                            handler.string_value("HDMI1");
                            break;
                        case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_Optical:
                            handler.string_value("Optical");
                            break;
                        case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_CD:
                            handler.string_value("CD");
                            break;
                        case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB:
                            handler.string_value("USB");
                            break;
                        case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_1:
                            handler.string_value("USB_1");
                            break;
                        case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_2:
                            handler.string_value("USB_2");
                            break;
                        case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_3:
                            handler.string_value("USB_3");
                            break;
                        case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_4:
                            handler.string_value("USB_4");
                            break;
                        case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_A:
                            handler.string_value("USB_A");
                            break;
                        case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_B:
                            handler.string_value("USB_B");
                            break;
                        case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_C:
                            handler.string_value("USB_C");
                            break;
                        case TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource_USB_D:
                            handler.string_value("USB_D");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeMusicAudioInputSource.string_value);
                  }
              }
            if (flagHasMusicSourceDevice)
              {
                handler.start_pair("MusicSourceDevice");
                if (storeMusicSourceDevice.in_known_list)
                  {
                    switch (storeMusicSourceDevice.list_value)
                      {
                        case TypeMusicSourceDeviceKnownValues.MusicSourceDevice_iPhone:
                            handler.string_value("iPhone");
                            break;
                        case TypeMusicSourceDeviceKnownValues.MusicSourceDevice_iPod:
                            handler.string_value("iPod");
                            break;
                        case TypeMusicSourceDeviceKnownValues.MusicSourceDevice_CDPlayer:
                            handler.string_value("CDPlayer");
                            break;
                        case TypeMusicSourceDeviceKnownValues.MusicSourceDevice_Laptop:
                            handler.string_value("Laptop");
                            break;
                        case TypeMusicSourceDeviceKnownValues.MusicSourceDevice_Computer:
                            handler.string_value("Computer");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeMusicSourceDevice.string_value);
                  }
              }
          }
        public override void write_partial_as_json(JSONHandler handler)
          {
            handler.start_object();
            write_fields_as_json(handler, true);
            int extra_count = extraKeys.Count;
            Debug.Assert(extra_count == extraValues.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                handler.start_pair(extraKeys[extra_num]);
                extraValues[extra_num].write(handler);
              }
            handler.finish_object();
          }
        public virtual string missing_field_error(bool allow_unpolished)
          {
            if (!(hasCommandType()))
              {
                return "When parsing the object for %what%, the \"CommandType\" field was missing.";
              }
            return null;
          }

        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                generator.set_allow_incomplete(allow_incomplete);
                generator.set_allow_unpolished(allow_unpolished);
                if (allow_incomplete || allow_unpolished)
                    json_value.write(generator);
                else
                    json_value.write(generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                generator.set_allow_incomplete(allow_incomplete);
                generator.set_allow_unpolished(allow_unpolished);
                if (allow_incomplete || allow_unpolished)
                    json_value.write_partial_as_json(generator);
                else
                    json_value.write_as_json(generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_text(string text, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNativeDataJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private abstract class FieldGeneratorCommandType : JSONStringGenerator
              {
                protected FieldGeneratorCommandType(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorCommandType()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeCommandTypeKnownValues known = stringToCommandType(result);
                    TypeCommandType new_value = new TypeCommandType();
                    if (known == TypeCommandTypeKnownValues.CommandType__none)
                      {
                        new_value.in_known_list = false;
                        new_value.string_value = result;
                      }
                    else
                      {
                        new_value.in_known_list = true;
                        new_value.list_value = known;
                      }
                    handle_result(new_value);
                  }
                protected abstract void handle_result(TypeCommandType result);
              };
        private class FieldHoldingGeneratorCommandType : FieldGeneratorCommandType
      {
        protected override void handle_result(TypeCommandType result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorCommandType(String what)
          {
            have_value = false;
            base.set_what(what);
          }

        public override void reset()
          {
            have_value = false;
            base.reset();
          }

        public bool have_value;
        public TypeCommandType value;
      };
        private class FieldHoldingArrayGeneratorCommandType : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorCommandType
          {
            private FieldHoldingArrayGeneratorCommandType top;

            protected override void handle_result(TypeCommandType result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorCommandType init_top)
              {
                top = init_top;
              }
          };

        private ElementHandler element_handler;

        protected override JSONHandler start()
          {
            have_value = true;
            value.Clear();
            return element_handler;
          }
        protected override void finish()
          {
            Debug.Assert(have_value);
            handle_result(value);
            element_handler.reset();
          }
        protected virtual void handle_result(List<TypeCommandType> result)
          {
          }

        public FieldHoldingArrayGeneratorCommandType(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeCommandType>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorCommandType()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeCommandType>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeCommandType> value;
      };
            private FieldHoldingGeneratorCommandType fieldGeneratorCommandType;
        private class FieldHoldingGeneratorPlayNumberedTrackTrackNumber : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorPlayNumberedTrackTrackNumber(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorPlayNumberedTrackTrackNumber : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorPlayNumberedTrackTrackNumber(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorPlayNumberedTrackTrackNumber fieldGeneratorPlayNumberedTrackTrackNumber;
            private JSONHoldingNumberTextGenerator fieldGeneratorRewindFastForwardAmountInSeconds;
            private JSONHoldingNumberTextGenerator fieldGeneratorSeekOffsetInSeconds;
            private JSONHoldingNumberTextGenerator fieldGeneratorSeekOffsetPercentage;
        private class FieldHoldingGeneratorSkipAmount : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorSkipAmount(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorSkipAmount : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorSkipAmount(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorSkipAmount fieldGeneratorSkipAmount;
            private MusicThirdPartyJSON.HoldingGenerator fieldGeneratorMusicThirdParty;
            private MusicThirdPartyDetailsJSON.HoldingGenerator fieldGeneratorMusicThirdPartyDetails;
            private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedVideos;
            private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedPreview;
            private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedFullPlayback;
            private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedSkip;
            private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedAirplay;
            private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedResume;
            private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedAll;
            private JSONHoldingBooleanGenerator fieldGeneratorUserSpecifiedPlaylist;
            private JSONHoldingBooleanGenerator fieldGeneratorUserSpecifiedCurrentPage;
            private JSONHoldingStringGenerator fieldGeneratorTargetTrackName;
            private JSONHoldingStringGenerator fieldGeneratorTargetTrackArtistName;
            private SoundHoundTrackIDJSON.HoldingGenerator fieldGeneratorTargetTrackSoundHoundId;
        private abstract class FieldGeneratorMusicAudioInputSource : JSONStringGenerator
              {
                protected FieldGeneratorMusicAudioInputSource(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorMusicAudioInputSource()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeMusicAudioInputSourceKnownValues known = stringToMusicAudioInputSource(result);
                    TypeMusicAudioInputSource new_value = new TypeMusicAudioInputSource();
                    if (known == TypeMusicAudioInputSourceKnownValues.MusicAudioInputSource__none)
                      {
                        new_value.in_known_list = false;
                        new_value.string_value = result;
                      }
                    else
                      {
                        new_value.in_known_list = true;
                        new_value.list_value = known;
                      }
                    handle_result(new_value);
                  }
                protected abstract void handle_result(TypeMusicAudioInputSource result);
              };
        private class FieldHoldingGeneratorMusicAudioInputSource : FieldGeneratorMusicAudioInputSource
      {
        protected override void handle_result(TypeMusicAudioInputSource result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorMusicAudioInputSource(String what)
          {
            have_value = false;
            base.set_what(what);
          }

        public override void reset()
          {
            have_value = false;
            base.reset();
          }

        public bool have_value;
        public TypeMusicAudioInputSource value;
      };
        private class FieldHoldingArrayGeneratorMusicAudioInputSource : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorMusicAudioInputSource
          {
            private FieldHoldingArrayGeneratorMusicAudioInputSource top;

            protected override void handle_result(TypeMusicAudioInputSource result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorMusicAudioInputSource init_top)
              {
                top = init_top;
              }
          };

        private ElementHandler element_handler;

        protected override JSONHandler start()
          {
            have_value = true;
            value.Clear();
            return element_handler;
          }
        protected override void finish()
          {
            Debug.Assert(have_value);
            handle_result(value);
            element_handler.reset();
          }
        protected virtual void handle_result(List<TypeMusicAudioInputSource> result)
          {
          }

        public FieldHoldingArrayGeneratorMusicAudioInputSource(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeMusicAudioInputSource>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorMusicAudioInputSource()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeMusicAudioInputSource>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeMusicAudioInputSource> value;
      };
            private FieldHoldingGeneratorMusicAudioInputSource fieldGeneratorMusicAudioInputSource;
        private abstract class FieldGeneratorMusicSourceDevice : JSONStringGenerator
              {
                protected FieldGeneratorMusicSourceDevice(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorMusicSourceDevice()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeMusicSourceDeviceKnownValues known = stringToMusicSourceDevice(result);
                    TypeMusicSourceDevice new_value = new TypeMusicSourceDevice();
                    if (known == TypeMusicSourceDeviceKnownValues.MusicSourceDevice__none)
                      {
                        new_value.in_known_list = false;
                        new_value.string_value = result;
                      }
                    else
                      {
                        new_value.in_known_list = true;
                        new_value.list_value = known;
                      }
                    handle_result(new_value);
                  }
                protected abstract void handle_result(TypeMusicSourceDevice result);
              };
        private class FieldHoldingGeneratorMusicSourceDevice : FieldGeneratorMusicSourceDevice
      {
        protected override void handle_result(TypeMusicSourceDevice result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorMusicSourceDevice(String what)
          {
            have_value = false;
            base.set_what(what);
          }

        public override void reset()
          {
            have_value = false;
            base.reset();
          }

        public bool have_value;
        public TypeMusicSourceDevice value;
      };
        private class FieldHoldingArrayGeneratorMusicSourceDevice : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorMusicSourceDevice
          {
            private FieldHoldingArrayGeneratorMusicSourceDevice top;

            protected override void handle_result(TypeMusicSourceDevice result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorMusicSourceDevice init_top)
              {
                top = init_top;
              }
          };

        private ElementHandler element_handler;

        protected override JSONHandler start()
          {
            have_value = true;
            value.Clear();
            return element_handler;
          }
        protected override void finish()
          {
            Debug.Assert(have_value);
            handle_result(value);
            element_handler.reset();
          }
        protected virtual void handle_result(List<TypeMusicSourceDevice> result)
          {
          }

        public FieldHoldingArrayGeneratorMusicSourceDevice(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeMusicSourceDevice>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorMusicSourceDevice()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeMusicSourceDevice>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeMusicSourceDevice> value;
      };
            private FieldHoldingGeneratorMusicSourceDevice fieldGeneratorMusicSourceDevice;
            private class UnknownFieldGenerator : JSONValueHandler
              {
                public bool ignore;
                public List<string> field_names;
                public List<JSONValue > field_values;
                public Dictionary<string, JSONValue > index;
                public UnknownFieldGenerator(bool init_ignore)
                  {
                    ignore = init_ignore;
                    field_names = new List<string>();
                    field_values = new List<JSONValue >();
                index = new Dictionary<string, JSONValue >();
                  }

                protected override void new_value(JSONValue item)
                  {
                    if (ignore)
                        return;
                    Debug.Assert(field_names.Count == (field_values.Count + 1));
                    index.Add(field_names[field_values.Count], item);
                    field_values.Add(item);
                  }
                public override void reset()
                  {
                    field_names.Clear();
                    field_values.Clear();
                index = new Dictionary<string, JSONValue >();
                  }
              };
            private UnknownFieldGenerator unknownFieldGenerator;

            protected bool allow_incomplete;

            protected bool allow_unpolished;

            protected override void start()
              {
              }
            protected override JSONHandler start_field(string field_name)
              {
                JSONHandler result = start_known_field(field_name);
                if (result != null)
                    return result;
                Debug.Assert(unknownFieldGenerator.field_names.Count ==
                       unknownFieldGenerator.field_values.Count);
                if (unknownFieldGenerator.ignore)
                  {
                    Debug.Assert(unknownFieldGenerator.field_names.Count == 0);
                  }
                else
                  {
                    unknownFieldGenerator.field_names.Add(field_name);
                  }
                return unknownFieldGenerator;
              }
            protected override void finish_field(string field_name, JSONHandler field_handler)
              {
              }
            protected override void finish()
              {
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
              {
                if (fieldGeneratorCommandType.have_value)
                  {
                    result.setCommandType(fieldGeneratorCommandType.value);
                    fieldGeneratorCommandType.have_value = false;
                  }
                else if ((!(result.hasCommandType())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"CommandType\" field was missing.");
                  }
                if (fieldGeneratorPlayNumberedTrackTrackNumber.have_value)
                  {
                    result.setPlayNumberedTrackTrackNumber(fieldGeneratorPlayNumberedTrackTrackNumber.value);
                    fieldGeneratorPlayNumberedTrackTrackNumber.have_value = false;
                  }
                if (fieldGeneratorRewindFastForwardAmountInSeconds.have_value)
                  {
                    result.setRewindFastForwardAmountInSecondsText(fieldGeneratorRewindFastForwardAmountInSeconds.value);
                    fieldGeneratorRewindFastForwardAmountInSeconds.have_value = false;
                  }
                if (fieldGeneratorSeekOffsetInSeconds.have_value)
                  {
                    result.setSeekOffsetInSecondsText(fieldGeneratorSeekOffsetInSeconds.value);
                    fieldGeneratorSeekOffsetInSeconds.have_value = false;
                  }
                if (fieldGeneratorSeekOffsetPercentage.have_value)
                  {
                    result.setSeekOffsetPercentageText(fieldGeneratorSeekOffsetPercentage.value);
                    fieldGeneratorSeekOffsetPercentage.have_value = false;
                  }
                if (fieldGeneratorSkipAmount.have_value)
                  {
                    result.setSkipAmount(fieldGeneratorSkipAmount.value);
                    fieldGeneratorSkipAmount.have_value = false;
                  }
                if (fieldGeneratorMusicThirdParty.have_value)
                  {
                    result.setMusicThirdParty(fieldGeneratorMusicThirdParty.value);
                    fieldGeneratorMusicThirdParty.have_value = false;
                  }
                if (fieldGeneratorMusicThirdPartyDetails.have_value)
                  {
                    result.setMusicThirdPartyDetails(fieldGeneratorMusicThirdPartyDetails.value);
                    fieldGeneratorMusicThirdPartyDetails.have_value = false;
                  }
                if (fieldGeneratorUserRequestedVideos.have_value)
                  {
                    result.setUserRequestedVideos(fieldGeneratorUserRequestedVideos.value);
                    fieldGeneratorUserRequestedVideos.have_value = false;
                  }
                if (fieldGeneratorUserRequestedPreview.have_value)
                  {
                    result.setUserRequestedPreview(fieldGeneratorUserRequestedPreview.value);
                    fieldGeneratorUserRequestedPreview.have_value = false;
                  }
                if (fieldGeneratorUserRequestedFullPlayback.have_value)
                  {
                    result.setUserRequestedFullPlayback(fieldGeneratorUserRequestedFullPlayback.value);
                    fieldGeneratorUserRequestedFullPlayback.have_value = false;
                  }
                if (fieldGeneratorUserRequestedSkip.have_value)
                  {
                    result.setUserRequestedSkip(fieldGeneratorUserRequestedSkip.value);
                    fieldGeneratorUserRequestedSkip.have_value = false;
                  }
                if (fieldGeneratorUserRequestedAirplay.have_value)
                  {
                    result.setUserRequestedAirplay(fieldGeneratorUserRequestedAirplay.value);
                    fieldGeneratorUserRequestedAirplay.have_value = false;
                  }
                if (fieldGeneratorUserRequestedResume.have_value)
                  {
                    result.setUserRequestedResume(fieldGeneratorUserRequestedResume.value);
                    fieldGeneratorUserRequestedResume.have_value = false;
                  }
                if (fieldGeneratorUserRequestedAll.have_value)
                  {
                    result.setUserRequestedAll(fieldGeneratorUserRequestedAll.value);
                    fieldGeneratorUserRequestedAll.have_value = false;
                  }
                if (fieldGeneratorUserSpecifiedPlaylist.have_value)
                  {
                    result.setUserSpecifiedPlaylist(fieldGeneratorUserSpecifiedPlaylist.value);
                    fieldGeneratorUserSpecifiedPlaylist.have_value = false;
                  }
                if (fieldGeneratorUserSpecifiedCurrentPage.have_value)
                  {
                    result.setUserSpecifiedCurrentPage(fieldGeneratorUserSpecifiedCurrentPage.value);
                    fieldGeneratorUserSpecifiedCurrentPage.have_value = false;
                  }
                if (fieldGeneratorTargetTrackName.have_value)
                  {
                    result.setTargetTrackName(fieldGeneratorTargetTrackName.value);
                    fieldGeneratorTargetTrackName.have_value = false;
                  }
                if (fieldGeneratorTargetTrackArtistName.have_value)
                  {
                    result.setTargetTrackArtistName(fieldGeneratorTargetTrackArtistName.value);
                    fieldGeneratorTargetTrackArtistName.have_value = false;
                  }
                if (fieldGeneratorTargetTrackSoundHoundId.have_value)
                  {
                    result.setTargetTrackSoundHoundId(fieldGeneratorTargetTrackSoundHoundId.value);
                    fieldGeneratorTargetTrackSoundHoundId.have_value = false;
                  }
                if (fieldGeneratorMusicAudioInputSource.have_value)
                  {
                    result.setMusicAudioInputSource(fieldGeneratorMusicAudioInputSource.value);
                    fieldGeneratorMusicAudioInputSource.have_value = false;
                  }
                if (fieldGeneratorMusicSourceDevice.have_value)
                  {
                    result.setMusicSourceDevice(fieldGeneratorMusicSourceDevice.value);
                    fieldGeneratorMusicSourceDevice.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorCommandType;
                        break;
                    case 'M':
                        if (String.Compare(field_name, 1, "usic", 0, 4, false) == 0)
                          {
                            switch (field_name[5])
                              {
                                case 'A':
                                    if ((String.Compare(field_name, 6, "udioInputSource", 0, 15, false) == 0) && (field_name.Length == 21))
                                        return fieldGeneratorMusicAudioInputSource;
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 6, "ourceDevice", 0, 11, false) == 0) && (field_name.Length == 17))
                                        return fieldGeneratorMusicSourceDevice;
                                    break;
                                case 'T':
                                    if (String.Compare(field_name, 6, "hirdParty", 0, 9, false) == 0)
                                      {
                                        if (field_name.Length == 15)
                                          {
                                            return fieldGeneratorMusicThirdParty;
                                          }
                                        switch (field_name[15])
                                          {
                                            case 'D':
                                                if ((String.Compare(field_name, 16, "etails", 0, 6, false) == 0) && (field_name.Length == 22))
                                                    return fieldGeneratorMusicThirdPartyDetails;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "layNumberedTrackTrackNumber", 0, 27, false) == 0) && (field_name.Length == 28))
                            return fieldGeneratorPlayNumberedTrackTrackNumber;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "ewindFastForwardAmountInSeconds", 0, 31, false) == 0) && (field_name.Length == 32))
                            return fieldGeneratorRewindFastForwardAmountInSeconds;
                        break;
                    case 'S':
                        switch (field_name[1])
                          {
                            case 'e':
                                if (String.Compare(field_name, 2, "ekOffset", 0, 8, false) == 0)
                                  {
                                    switch (field_name[10])
                                      {
                                        case 'I':
                                            if ((String.Compare(field_name, 11, "nSeconds", 0, 8, false) == 0) && (field_name.Length == 19))
                                                return fieldGeneratorSeekOffsetInSeconds;
                                            break;
                                        case 'P':
                                            if ((String.Compare(field_name, 11, "ercentage", 0, 9, false) == 0) && (field_name.Length == 20))
                                                return fieldGeneratorSeekOffsetPercentage;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'k':
                                if ((String.Compare(field_name, 2, "ipAmount", 0, 8, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorSkipAmount;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'T':
                        if (String.Compare(field_name, 1, "argetTrack", 0, 10, false) == 0)
                          {
                            switch (field_name[11])
                              {
                                case 'A':
                                    if ((String.Compare(field_name, 12, "rtistName", 0, 9, false) == 0) && (field_name.Length == 21))
                                        return fieldGeneratorTargetTrackArtistName;
                                    break;
                                case 'N':
                                    if ((String.Compare(field_name, 12, "ame", 0, 3, false) == 0) && (field_name.Length == 15))
                                        return fieldGeneratorTargetTrackName;
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 12, "oundHoundId", 0, 11, false) == 0) && (field_name.Length == 23))
                                        return fieldGeneratorTargetTrackSoundHoundId;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'U':
                        if (String.Compare(field_name, 1, "ser", 0, 3, false) == 0)
                          {
                            switch (field_name[4])
                              {
                                case 'R':
                                    if (String.Compare(field_name, 5, "equested", 0, 8, false) == 0)
                                      {
                                        switch (field_name[13])
                                          {
                                            case 'A':
                                                switch (field_name[14])
                                                  {
                                                    case 'i':
                                                        if ((String.Compare(field_name, 15, "rplay", 0, 5, false) == 0) && (field_name.Length == 20))
                                                            return fieldGeneratorUserRequestedAirplay;
                                                        break;
                                                    case 'l':
                                                        if ((String.Compare(field_name, 15, "l", 0, 1, false) == 0) && (field_name.Length == 16))
                                                            return fieldGeneratorUserRequestedAll;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'F':
                                                if ((String.Compare(field_name, 14, "ullPlayback", 0, 11, false) == 0) && (field_name.Length == 25))
                                                    return fieldGeneratorUserRequestedFullPlayback;
                                                break;
                                            case 'P':
                                                if ((String.Compare(field_name, 14, "review", 0, 6, false) == 0) && (field_name.Length == 20))
                                                    return fieldGeneratorUserRequestedPreview;
                                                break;
                                            case 'R':
                                                if ((String.Compare(field_name, 14, "esume", 0, 5, false) == 0) && (field_name.Length == 19))
                                                    return fieldGeneratorUserRequestedResume;
                                                break;
                                            case 'S':
                                                if ((String.Compare(field_name, 14, "kip", 0, 3, false) == 0) && (field_name.Length == 17))
                                                    return fieldGeneratorUserRequestedSkip;
                                                break;
                                            case 'V':
                                                if ((String.Compare(field_name, 14, "ideos", 0, 5, false) == 0) && (field_name.Length == 19))
                                                    return fieldGeneratorUserRequestedVideos;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'S':
                                    if (String.Compare(field_name, 5, "pecified", 0, 8, false) == 0)
                                      {
                                        switch (field_name[13])
                                          {
                                            case 'C':
                                                if ((String.Compare(field_name, 14, "urrentPage", 0, 10, false) == 0) && (field_name.Length == 24))
                                                    return fieldGeneratorUserSpecifiedCurrentPage;
                                                break;
                                            case 'P':
                                                if ((String.Compare(field_name, 14, "laylist", 0, 7, false) == 0) && (field_name.Length == 21))
                                                    return fieldGeneratorUserSpecifiedPlaylist;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the TypeNativeData class");
                fieldGeneratorPlayNumberedTrackTrackNumber = new FieldHoldingGeneratorPlayNumberedTrackTrackNumber("field \"PlayNumberedTrackTrackNumber\" of the TypeNativeData class");
                fieldGeneratorRewindFastForwardAmountInSeconds = new JSONHoldingNumberTextGenerator("field \"RewindFastForwardAmountInSeconds\" of the TypeNativeData class");
                fieldGeneratorSeekOffsetInSeconds = new JSONHoldingNumberTextGenerator("field \"SeekOffsetInSeconds\" of the TypeNativeData class");
                fieldGeneratorSeekOffsetPercentage = new JSONHoldingNumberTextGenerator("field \"SeekOffsetPercentage\" of the TypeNativeData class");
                fieldGeneratorSkipAmount = new FieldHoldingGeneratorSkipAmount("field \"SkipAmount\" of the TypeNativeData class");
                fieldGeneratorMusicThirdParty = new MusicThirdPartyJSON.HoldingGenerator("field \"MusicThirdParty\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorMusicThirdPartyDetails = new MusicThirdPartyDetailsJSON.HoldingGenerator("field \"MusicThirdPartyDetails\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorUserRequestedVideos = new JSONHoldingBooleanGenerator("field \"UserRequestedVideos\" of the TypeNativeData class");
                fieldGeneratorUserRequestedPreview = new JSONHoldingBooleanGenerator("field \"UserRequestedPreview\" of the TypeNativeData class");
                fieldGeneratorUserRequestedFullPlayback = new JSONHoldingBooleanGenerator("field \"UserRequestedFullPlayback\" of the TypeNativeData class");
                fieldGeneratorUserRequestedSkip = new JSONHoldingBooleanGenerator("field \"UserRequestedSkip\" of the TypeNativeData class");
                fieldGeneratorUserRequestedAirplay = new JSONHoldingBooleanGenerator("field \"UserRequestedAirplay\" of the TypeNativeData class");
                fieldGeneratorUserRequestedResume = new JSONHoldingBooleanGenerator("field \"UserRequestedResume\" of the TypeNativeData class");
                fieldGeneratorUserRequestedAll = new JSONHoldingBooleanGenerator("field \"UserRequestedAll\" of the TypeNativeData class");
                fieldGeneratorUserSpecifiedPlaylist = new JSONHoldingBooleanGenerator("field \"UserSpecifiedPlaylist\" of the TypeNativeData class");
                fieldGeneratorUserSpecifiedCurrentPage = new JSONHoldingBooleanGenerator("field \"UserSpecifiedCurrentPage\" of the TypeNativeData class");
                fieldGeneratorTargetTrackName = new JSONHoldingStringGenerator("field \"TargetTrackName\" of the TypeNativeData class");
                fieldGeneratorTargetTrackArtistName = new JSONHoldingStringGenerator("field \"TargetTrackArtistName\" of the TypeNativeData class");
                fieldGeneratorTargetTrackSoundHoundId = new SoundHoundTrackIDJSON.HoldingGenerator("field \"TargetTrackSoundHoundId\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorMusicAudioInputSource = new FieldHoldingGeneratorMusicAudioInputSource("field \"MusicAudioInputSource\" of the TypeNativeData class");
                fieldGeneratorMusicSourceDevice = new FieldHoldingGeneratorMusicSourceDevice("field \"MusicSourceDevice\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the TypeNativeData class");
                fieldGeneratorPlayNumberedTrackTrackNumber = new FieldHoldingGeneratorPlayNumberedTrackTrackNumber("field \"PlayNumberedTrackTrackNumber\" of the TypeNativeData class");
                fieldGeneratorRewindFastForwardAmountInSeconds = new JSONHoldingNumberTextGenerator("field \"RewindFastForwardAmountInSeconds\" of the TypeNativeData class");
                fieldGeneratorSeekOffsetInSeconds = new JSONHoldingNumberTextGenerator("field \"SeekOffsetInSeconds\" of the TypeNativeData class");
                fieldGeneratorSeekOffsetPercentage = new JSONHoldingNumberTextGenerator("field \"SeekOffsetPercentage\" of the TypeNativeData class");
                fieldGeneratorSkipAmount = new FieldHoldingGeneratorSkipAmount("field \"SkipAmount\" of the TypeNativeData class");
                fieldGeneratorMusicThirdParty = new MusicThirdPartyJSON.HoldingGenerator("field \"MusicThirdParty\" of the TypeNativeData class", false);
                fieldGeneratorMusicThirdPartyDetails = new MusicThirdPartyDetailsJSON.HoldingGenerator("field \"MusicThirdPartyDetails\" of the TypeNativeData class", false);
                fieldGeneratorUserRequestedVideos = new JSONHoldingBooleanGenerator("field \"UserRequestedVideos\" of the TypeNativeData class");
                fieldGeneratorUserRequestedPreview = new JSONHoldingBooleanGenerator("field \"UserRequestedPreview\" of the TypeNativeData class");
                fieldGeneratorUserRequestedFullPlayback = new JSONHoldingBooleanGenerator("field \"UserRequestedFullPlayback\" of the TypeNativeData class");
                fieldGeneratorUserRequestedSkip = new JSONHoldingBooleanGenerator("field \"UserRequestedSkip\" of the TypeNativeData class");
                fieldGeneratorUserRequestedAirplay = new JSONHoldingBooleanGenerator("field \"UserRequestedAirplay\" of the TypeNativeData class");
                fieldGeneratorUserRequestedResume = new JSONHoldingBooleanGenerator("field \"UserRequestedResume\" of the TypeNativeData class");
                fieldGeneratorUserRequestedAll = new JSONHoldingBooleanGenerator("field \"UserRequestedAll\" of the TypeNativeData class");
                fieldGeneratorUserSpecifiedPlaylist = new JSONHoldingBooleanGenerator("field \"UserSpecifiedPlaylist\" of the TypeNativeData class");
                fieldGeneratorUserSpecifiedCurrentPage = new JSONHoldingBooleanGenerator("field \"UserSpecifiedCurrentPage\" of the TypeNativeData class");
                fieldGeneratorTargetTrackName = new JSONHoldingStringGenerator("field \"TargetTrackName\" of the TypeNativeData class");
                fieldGeneratorTargetTrackArtistName = new JSONHoldingStringGenerator("field \"TargetTrackArtistName\" of the TypeNativeData class");
                fieldGeneratorTargetTrackSoundHoundId = new SoundHoundTrackIDJSON.HoldingGenerator("field \"TargetTrackSoundHoundId\" of the TypeNativeData class", false);
                fieldGeneratorMusicAudioInputSource = new FieldHoldingGeneratorMusicAudioInputSource("field \"MusicAudioInputSource\" of the TypeNativeData class");
                fieldGeneratorMusicSourceDevice = new FieldHoldingGeneratorMusicSourceDevice("field \"MusicSourceDevice\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorCommandType.reset();
                fieldGeneratorPlayNumberedTrackTrackNumber.reset();
                fieldGeneratorRewindFastForwardAmountInSeconds.reset();
                fieldGeneratorSeekOffsetInSeconds.reset();
                fieldGeneratorSeekOffsetPercentage.reset();
                fieldGeneratorSkipAmount.reset();
                fieldGeneratorMusicThirdParty.reset();
                fieldGeneratorMusicThirdPartyDetails.reset();
                fieldGeneratorUserRequestedVideos.reset();
                fieldGeneratorUserRequestedPreview.reset();
                fieldGeneratorUserRequestedFullPlayback.reset();
                fieldGeneratorUserRequestedSkip.reset();
                fieldGeneratorUserRequestedAirplay.reset();
                fieldGeneratorUserRequestedResume.reset();
                fieldGeneratorUserRequestedAll.reset();
                fieldGeneratorUserSpecifiedPlaylist.reset();
                fieldGeneratorUserSpecifiedCurrentPage.reset();
                fieldGeneratorTargetTrackName.reset();
                fieldGeneratorTargetTrackArtistName.reset();
                fieldGeneratorTargetTrackSoundHoundId.reset();
                fieldGeneratorMusicAudioInputSource.reset();
                fieldGeneratorMusicSourceDevice.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorMusicThirdParty.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorMusicThirdPartyDetails.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorTargetTrackSoundHoundId.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorMusicThirdParty.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorMusicThirdPartyDetails.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorTargetTrackSoundHoundId.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeNativeDataJSON  result)
              {
    //@@@            Debug.Assert(!have_value);
                have_value = true;
                value = result;
              }

            public HoldingGenerator(String what, bool ignore_extras) : base(ignore_extras)
              {
                have_value = false;
                base.set_what(what);
              }

            public HoldingGenerator(String what) : base(false)
              {
                have_value = false;
                base.set_what(what);
              }

            public override void reset()
              {
                have_value = false;
                base.reset();
              }

            public bool have_value;
            public TypeNativeDataJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNativeDataJSON  result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(HoldingArrayGenerator init_top, bool ignore_extras) : base(ignore_extras)
              {
                top = init_top;
              }
          };

        private ElementHandler element_handler;

        protected override JSONHandler start()
          {
            have_value = true;
            value.Clear();
            return element_handler;
          }
        protected override void finish()
          {
            Debug.Assert(have_value);
            handle_result(value);
            element_handler.reset();
          }
        protected virtual void handle_result(List<TypeNativeDataJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNativeDataJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNativeDataJSON>();
            have_value = false;
          }

        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            element_handler.set_allow_incomplete(new_allow_incomplete);
          }

        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            element_handler.set_allow_unpolished(new_allow_unpolished);
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeNativeDataJSON> value;
      };
      };
    private bool flagHasSuccessfulPlayerCommand;
    private DynamicResponseJSON  storeSuccessfulPlayerCommand;
    private bool flagHasSuccessfulPlayerCommandWithTrackName;
    private DynamicResponseJSON  storeSuccessfulPlayerCommandWithTrackName;
    private bool flagHasNoControllableTrack;
    private DynamicResponseJSON  storeNoControllableTrack;
    private bool flagHasMusicProviderUnavailable;
    private DynamicResponseJSON  storeMusicProviderUnavailable;
    private bool flagHasNativeData;
    private TypeNativeDataJSON  storeNativeData;


    private JSONValue  extraSuccessfulPlayerCommandToJSON()
      {
        JSONValueHandler handler_SuccessfulPlayerCommand = new JSONValueHandler();
        storeSuccessfulPlayerCommand.write_as_json(handler_SuccessfulPlayerCommand);
        return handler_SuccessfulPlayerCommand.result;
      }

    private JSONValue  extraSuccessfulPlayerCommandWithTrackNameToJSON()
      {
        JSONValueHandler handler_SuccessfulPlayerCommandWithTrackName = new JSONValueHandler();
        storeSuccessfulPlayerCommandWithTrackName.write_as_json(handler_SuccessfulPlayerCommandWithTrackName);
        return handler_SuccessfulPlayerCommandWithTrackName.result;
      }

    private JSONValue  extraNoControllableTrackToJSON()
      {
        JSONValueHandler handler_NoControllableTrack = new JSONValueHandler();
        storeNoControllableTrack.write_as_json(handler_NoControllableTrack);
        return handler_NoControllableTrack.result;
      }

    private JSONValue  extraMusicProviderUnavailableToJSON()
      {
        JSONValueHandler handler_MusicProviderUnavailable = new JSONValueHandler();
        storeMusicProviderUnavailable.write_as_json(handler_MusicProviderUnavailable);
        return handler_MusicProviderUnavailable.result;
      }

    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }


    private void  fromJSONSuccessfulPlayerCommand(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setSuccessfulPlayerCommand(convert_classy);
      }


    private void  fromJSONSuccessfulPlayerCommandWithTrackName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setSuccessfulPlayerCommandWithTrackName(convert_classy);
      }


    private void  fromJSONNoControllableTrack(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setNoControllableTrack(convert_classy);
      }


    private void  fromJSONMusicProviderUnavailable(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setMusicProviderUnavailable(convert_classy);
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    public MusicPlayerCommandJSON()
      {
        flagHasSuccessfulPlayerCommand = false;
        flagHasSuccessfulPlayerCommandWithTrackName = false;
        flagHasNoControllableTrack = false;
        flagHasMusicProviderUnavailable = false;
        flagHasNativeData = false;
      }

    public override string  getCommandKind()
      {
        return "MusicPlayerCommand";
      }

    public bool  hasSuccessfulPlayerCommand()
      {
        return flagHasSuccessfulPlayerCommand;
      }

    public DynamicResponseJSON   getSuccessfulPlayerCommand()
      {
        Debug.Assert(flagHasSuccessfulPlayerCommand);
        return storeSuccessfulPlayerCommand;
      }

    public bool  hasSuccessfulPlayerCommandWithTrackName()
      {
        return flagHasSuccessfulPlayerCommandWithTrackName;
      }

    public DynamicResponseJSON   getSuccessfulPlayerCommandWithTrackName()
      {
        Debug.Assert(flagHasSuccessfulPlayerCommandWithTrackName);
        return storeSuccessfulPlayerCommandWithTrackName;
      }

    public bool  hasNoControllableTrack()
      {
        return flagHasNoControllableTrack;
      }

    public DynamicResponseJSON   getNoControllableTrack()
      {
        Debug.Assert(flagHasNoControllableTrack);
        return storeNoControllableTrack;
      }

    public bool  hasMusicProviderUnavailable()
      {
        return flagHasMusicProviderUnavailable;
      }

    public DynamicResponseJSON   getMusicProviderUnavailable()
      {
        Debug.Assert(flagHasMusicProviderUnavailable);
        return storeMusicProviderUnavailable;
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public TypeNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }


    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasSuccessfulPlayerCommand)
            ++result;
        if (flagHasSuccessfulPlayerCommandWithTrackName)
            ++result;
        if (flagHasNoControllableTrack)
            ++result;
        if (flagHasMusicProviderUnavailable)
            ++result;
        if (flagHasNativeData)
            ++result;
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSuccessfulPlayerCommand)
          {
            if (remainder == 0)
                return "SuccessfulPlayerCommand";
            --remainder;
          }
        if (flagHasSuccessfulPlayerCommandWithTrackName)
          {
            if (remainder == 0)
                return "SuccessfulPlayerCommandWithTrackName";
            --remainder;
          }
        if (flagHasNoControllableTrack)
          {
            if (remainder == 0)
                return "NoControllableTrack";
            --remainder;
          }
        if (flagHasMusicProviderUnavailable)
          {
            if (remainder == 0)
                return "MusicProviderUnavailable";
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSuccessfulPlayerCommand)
          {
            if (remainder == 0)
                return extraSuccessfulPlayerCommandToJSON();
            --remainder;
          }
        if (flagHasSuccessfulPlayerCommandWithTrackName)
          {
            if (remainder == 0)
                return extraSuccessfulPlayerCommandWithTrackNameToJSON();
            --remainder;
          }
        if (flagHasNoControllableTrack)
          {
            if (remainder == 0)
                return extraNoControllableTrackToJSON();
            --remainder;
          }
        if (flagHasMusicProviderUnavailable)
          {
            if (remainder == 0)
                return extraMusicProviderUnavailableToJSON();
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'M':
                if ((String.Compare(field_name, 1, "usicProviderUnavailable", 0, 23, false) == 0) && (field_name.Length == 24))
                    return (flagHasMusicProviderUnavailable ? extraMusicProviderUnavailableToJSON() : null);
                break;
            case 'N':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "tiveData", 0, 8, false) == 0) && (field_name.Length == 10))
                            return (flagHasNativeData ? extraNativeDataToJSON() : null);
                        break;
                    case 'o':
                        if ((String.Compare(field_name, 2, "ControllableTrack", 0, 17, false) == 0) && (field_name.Length == 19))
                            return (flagHasNoControllableTrack ? extraNoControllableTrackToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if (String.Compare(field_name, 1, "uccessfulPlayerCommand", 0, 22, false) == 0)
                  {
                    if (field_name.Length == 23)
                      {
                        return (flagHasSuccessfulPlayerCommand ? extraSuccessfulPlayerCommandToJSON() : null);
                      }
                    switch (field_name[23])
                      {
                        case 'W':
                            if ((String.Compare(field_name, 24, "ithTrackName", 0, 12, false) == 0) && (field_name.Length == 36))
                                return (flagHasSuccessfulPlayerCommandWithTrackName ? extraSuccessfulPlayerCommandWithTrackNameToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return null;
      }

    public void setSuccessfulPlayerCommand(DynamicResponseJSON  new_value)
      {
        if (flagHasSuccessfulPlayerCommand)
          {
          }
        flagHasSuccessfulPlayerCommand = true;
        storeSuccessfulPlayerCommand = new_value;
      }
    public void unsetSuccessfulPlayerCommand()
      {
        if (flagHasSuccessfulPlayerCommand)
          {
          }
        flagHasSuccessfulPlayerCommand = false;
      }
    public void setSuccessfulPlayerCommandWithTrackName(DynamicResponseJSON  new_value)
      {
        if (flagHasSuccessfulPlayerCommandWithTrackName)
          {
          }
        flagHasSuccessfulPlayerCommandWithTrackName = true;
        storeSuccessfulPlayerCommandWithTrackName = new_value;
      }
    public void unsetSuccessfulPlayerCommandWithTrackName()
      {
        if (flagHasSuccessfulPlayerCommandWithTrackName)
          {
          }
        flagHasSuccessfulPlayerCommandWithTrackName = false;
      }
    public void setNoControllableTrack(DynamicResponseJSON  new_value)
      {
        if (flagHasNoControllableTrack)
          {
          }
        flagHasNoControllableTrack = true;
        storeNoControllableTrack = new_value;
      }
    public void unsetNoControllableTrack()
      {
        if (flagHasNoControllableTrack)
          {
          }
        flagHasNoControllableTrack = false;
      }
    public void setMusicProviderUnavailable(DynamicResponseJSON  new_value)
      {
        if (flagHasMusicProviderUnavailable)
          {
          }
        flagHasMusicProviderUnavailable = true;
        storeMusicProviderUnavailable = new_value;
      }
    public void unsetMusicProviderUnavailable()
      {
        if (flagHasMusicProviderUnavailable)
          {
          }
        flagHasMusicProviderUnavailable = false;
      }
    public void setNativeData(TypeNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
      }

    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'M':
                if ((String.Compare(key, 1, "usicProviderUnavailable", 0, 23, false) == 0) && (key.Length == 24))
                    {
                    fromJSONMusicProviderUnavailable(new_component, false);
                    return;
                    }
                break;
            case 'N':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "tiveData", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONNativeData(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "ControllableTrack", 0, 17, false) == 0) && (key.Length == 19))
                            {
                            fromJSONNoControllableTrack(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if (String.Compare(key, 1, "uccessfulPlayerCommand", 0, 22, false) == 0)
                  {
                    if (key.Length == 23)
                      {
                        {
                        fromJSONSuccessfulPlayerCommand(new_component, false);
                        return;
                        }
                      }
                    switch (key[23])
                      {
                        case 'W':
                            if ((String.Compare(key, 24, "ithTrackName", 0, 12, false) == 0) && (key.Length == 36))
                                {
                                fromJSONSuccessfulPlayerCommandWithTrackName(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'M':
                if ((String.Compare(key, 1, "usicProviderUnavailable", 0, 23, false) == 0) && (key.Length == 24))
                    {
                    fromJSONMusicProviderUnavailable(new_component, false);
                    return;
                    }
                break;
            case 'N':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "tiveData", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONNativeData(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "ControllableTrack", 0, 17, false) == 0) && (key.Length == 19))
                            {
                            fromJSONNoControllableTrack(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if (String.Compare(key, 1, "uccessfulPlayerCommand", 0, 22, false) == 0)
                  {
                    if (key.Length == 23)
                      {
                        {
                        fromJSONSuccessfulPlayerCommand(new_component, false);
                        return;
                        }
                      }
                    switch (key[23])
                      {
                        case 'W':
                            if ((String.Compare(key, 24, "ithTrackName", 0, 12, false) == 0) && (key.Length == 36))
                                {
                                fromJSONSuccessfulPlayerCommandWithTrackName(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        if (flagHasSuccessfulPlayerCommand)
          {
            handler.start_pair("SuccessfulPlayerCommand");
            if (partial_allowed)
                storeSuccessfulPlayerCommand.write_partial_as_json(handler);
            else
                storeSuccessfulPlayerCommand.write_as_json(handler);
          }
        if (flagHasSuccessfulPlayerCommandWithTrackName)
          {
            handler.start_pair("SuccessfulPlayerCommandWithTrackName");
            if (partial_allowed)
                storeSuccessfulPlayerCommandWithTrackName.write_partial_as_json(handler);
            else
                storeSuccessfulPlayerCommandWithTrackName.write_as_json(handler);
          }
        if (flagHasNoControllableTrack)
          {
            handler.start_pair("NoControllableTrack");
            if (partial_allowed)
                storeNoControllableTrack.write_partial_as_json(handler);
            else
                storeNoControllableTrack.write_as_json(handler);
          }
        if (flagHasMusicProviderUnavailable)
          {
            handler.start_pair("MusicProviderUnavailable");
            if (partial_allowed)
                storeMusicProviderUnavailable.write_partial_as_json(handler);
            else
                storeMusicProviderUnavailable.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasNativeData);
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasNativeData()))
          {
            return "When parsing the object for %what%, the \"NativeData\" field was missing.";
          }
        return null;
      }

    public static new MusicPlayerCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicPlayerCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicPlayerCommand", ignore_extras);
            generator.set_allow_incomplete(allow_incomplete);
            generator.set_allow_unpolished(allow_unpolished);
            if (allow_incomplete || allow_unpolished)
                json_value.write(generator);
            else
                json_value.write(generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MusicPlayerCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicPlayerCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicPlayerCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicPlayerCommand", ignore_extras);
            generator.set_allow_incomplete(allow_incomplete);
            generator.set_allow_unpolished(allow_unpolished);
            if (allow_incomplete || allow_unpolished)
                json_value.write_partial_as_json(generator);
            else
                json_value.write_as_json(generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MusicPlayerCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicPlayerCommandJSON from_text(string text, bool ignore_extras)
      {
        MusicPlayerCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicPlayerCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicPlayerCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MusicPlayerCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicPlayerCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicPlayerCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorSuccessfulPlayerCommand;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorSuccessfulPlayerCommandWithTrackName;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorNoControllableTrack;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorMusicProviderUnavailable;
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;

        protected override void start()
          {
          }
        protected override JSONHandler start_field(string field_name)
          {
            JSONHandler result = start_known_field(field_name);
            if (result != null)
                return result;
            string message = "";
            message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
            throw new Exception(message);
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            if (!(getCommandResultJSONKey().Equals("MusicPlayerCommand")))
                throw new Exception("The key field has a value other than `MusicPlayerCommand'.");
            MusicPlayerCommandJSON result = new MusicPlayerCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((MusicPlayerCommandJSON )new_result);
          }
        protected void finish(MusicPlayerCommandJSON result)
          {
            if (fieldGeneratorSuccessfulPlayerCommand.have_value)
              {
                result.setSuccessfulPlayerCommand(fieldGeneratorSuccessfulPlayerCommand.value);
                fieldGeneratorSuccessfulPlayerCommand.have_value = false;
              }
            if (fieldGeneratorSuccessfulPlayerCommandWithTrackName.have_value)
              {
                result.setSuccessfulPlayerCommandWithTrackName(fieldGeneratorSuccessfulPlayerCommandWithTrackName.value);
                fieldGeneratorSuccessfulPlayerCommandWithTrackName.have_value = false;
              }
            if (fieldGeneratorNoControllableTrack.have_value)
              {
                result.setNoControllableTrack(fieldGeneratorNoControllableTrack.value);
                fieldGeneratorNoControllableTrack.have_value = false;
              }
            if (fieldGeneratorMusicProviderUnavailable.have_value)
              {
                result.setMusicProviderUnavailable(fieldGeneratorMusicProviderUnavailable.value);
                fieldGeneratorMusicProviderUnavailable.have_value = false;
              }
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            else if ((!(result.hasNativeData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NativeData\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(MusicPlayerCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'M':
                    if ((String.Compare(field_name, 1, "usicProviderUnavailable", 0, 23, false) == 0) && (field_name.Length == 24))
                        return fieldGeneratorMusicProviderUnavailable;
                    break;
                case 'N':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "tiveData", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorNativeData;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "ControllableTrack", 0, 17, false) == 0) && (field_name.Length == 19))
                                return fieldGeneratorNoControllableTrack;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "uccessfulPlayerCommand", 0, 22, false) == 0)
                      {
                        if (field_name.Length == 23)
                          {
                            return fieldGeneratorSuccessfulPlayerCommand;
                          }
                        switch (field_name[23])
                          {
                            case 'W':
                                if ((String.Compare(field_name, 24, "ithTrackName", 0, 12, false) == 0) && (field_name.Length == 36))
                                    return fieldGeneratorSuccessfulPlayerCommandWithTrackName;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSuccessfulPlayerCommand = new DynamicResponseJSON.HoldingGenerator("field \"SuccessfulPlayerCommand\" of the MusicPlayerCommand class", ignore_extras);
            fieldGeneratorSuccessfulPlayerCommandWithTrackName = new DynamicResponseJSON.HoldingGenerator("field \"SuccessfulPlayerCommandWithTrackName\" of the MusicPlayerCommand class", ignore_extras);
            fieldGeneratorNoControllableTrack = new DynamicResponseJSON.HoldingGenerator("field \"NoControllableTrack\" of the MusicPlayerCommand class", ignore_extras);
            fieldGeneratorMusicProviderUnavailable = new DynamicResponseJSON.HoldingGenerator("field \"MusicProviderUnavailable\" of the MusicPlayerCommand class", ignore_extras);
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the MusicPlayerCommand class", ignore_extras);
            set_what("the MusicPlayerCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSuccessfulPlayerCommand = new DynamicResponseJSON.HoldingGenerator("field \"SuccessfulPlayerCommand\" of the MusicPlayerCommand class", false);
            fieldGeneratorSuccessfulPlayerCommandWithTrackName = new DynamicResponseJSON.HoldingGenerator("field \"SuccessfulPlayerCommandWithTrackName\" of the MusicPlayerCommand class", false);
            fieldGeneratorNoControllableTrack = new DynamicResponseJSON.HoldingGenerator("field \"NoControllableTrack\" of the MusicPlayerCommand class", false);
            fieldGeneratorMusicProviderUnavailable = new DynamicResponseJSON.HoldingGenerator("field \"MusicProviderUnavailable\" of the MusicPlayerCommand class", false);
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the MusicPlayerCommand class", false);
            set_what("the MusicPlayerCommand class");
          }

        public override void reset()
          {
            fieldGeneratorSuccessfulPlayerCommand.reset();
            fieldGeneratorSuccessfulPlayerCommandWithTrackName.reset();
            fieldGeneratorNoControllableTrack.reset();
            fieldGeneratorMusicProviderUnavailable.reset();
            fieldGeneratorNativeData.reset();
            base.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicPlayerCommandJSON  result)
          {
//@@@            Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public HoldingGenerator(String what, bool ignore_extras) : base(ignore_extras)
          {
            have_value = false;
            base.set_what(what);
          }

        public HoldingGenerator(String what) : base(false)
          {
            have_value = false;
            base.set_what(what);
          }

        public override void reset()
          {
            have_value = false;
            base.reset();
          }

        public bool have_value;
        public MusicPlayerCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicPlayerCommandJSON  result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(HoldingArrayGenerator init_top, bool ignore_extras) : base(ignore_extras)
          {
            top = init_top;
          }
      };

    private ElementHandler element_handler;

    protected override JSONHandler start()
      {
        have_value = true;
        value.Clear();
        return element_handler;
      }
    protected override void finish()
      {
        Debug.Assert(have_value);
        handle_result(value);
        element_handler.reset();
      }
    protected virtual void handle_result(List<MusicPlayerCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicPlayerCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicPlayerCommandJSON>();
        have_value = false;
      }

    public void set_allow_incomplete(bool new_allow_incomplete)
      {
        element_handler.set_allow_incomplete(new_allow_incomplete);
      }

    public void set_allow_unpolished(bool new_allow_unpolished)
      {
        element_handler.set_allow_unpolished(new_allow_unpolished);
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<MusicPlayerCommandJSON> value;
  };
  };
