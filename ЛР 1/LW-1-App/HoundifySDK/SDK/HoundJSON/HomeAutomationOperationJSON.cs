/* file "HomeAutomationOperationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationOperationJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_Auto,
        Value_Sleep,
        Value_Wake,
        Value_TurnOn,
        Value_TurnOff,
        Value_SetBrightness,
        Value_SetBrightnessDelta,
        Value_SetColor,
        Value_SetColorDelta,
        Value_Heat,
        Value_Cool,
        Value_Dry,
        Value_Wind,
        Value_SetTemperature,
        Value_SetTemperatureDelta,
        Value_SetWindSpeed,
        Value_SetWindSpeedDelta,
        Value_StartCleaning,
        Value_StopCleaning,
        Value_TurboControl,
        Value_Ready,
        Value_Pause,
        Value_Cancel,
        Value_Lock,
        Value_Unlock,
        Value_Open,
        Value_Close,
        Value_Alarm,
        Value_SetVolume,
        Value_SetVolumeDelta,
        Value_Mute,
        Value_Unmute,
        Value_Record,
        Value_PlayMusic,
        Value_PlayVideo,
        Value_ChangeChannel,
        Value_ChangeChannelDelta,
        Value__none
      };
    public struct TypeValue
      {
        public bool in_known_list;
        public string string_value;
        public TypeValueKnownValues list_value;
      };

    public static TypeValueKnownValues  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'l':
                        if ((String.Compare(chars, 2, "arm", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValueKnownValues.Value_Alarm;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "to", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Auto;
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "ncel", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_Cancel;
                        break;
                    case 'h':
                        if (String.Compare(chars, 2, "angeChannel", 0, 11, false) == 0)
                          {
                            if (chars.Length == 13)
                              {
                                return TypeValueKnownValues.Value_ChangeChannel;
                              }
                            switch (chars[13])
                              {
                                case 'D':
                                    if ((String.Compare(chars, 14, "elta", 0, 4, false) == 0) && (chars.Length == 18))
                                        return TypeValueKnownValues.Value_ChangeChannelDelta;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'l':
                        if ((String.Compare(chars, 2, "ose", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValueKnownValues.Value_Close;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "ol", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Cool;
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if ((String.Compare(chars, 1, "ry", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeValueKnownValues.Value_Dry;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "eat", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeValueKnownValues.Value_Heat;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "ock", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeValueKnownValues.Value_Lock;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "ute", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeValueKnownValues.Value_Mute;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "pen", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeValueKnownValues.Value_Open;
                break;
            case 'P':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "use", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValueKnownValues.Value_Pause;
                        break;
                    case 'l':
                        if (String.Compare(chars, 2, "ay", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'M':
                                    if ((String.Compare(chars, 5, "usic", 0, 4, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_PlayMusic;
                                    break;
                                case 'V':
                                    if ((String.Compare(chars, 5, "ideo", 0, 4, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_PlayVideo;
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
                if (String.Compare(chars, 1, "e", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'a':
                            if ((String.Compare(chars, 3, "dy", 0, 2, false) == 0) && (chars.Length == 5))
                                return TypeValueKnownValues.Value_Ready;
                            break;
                        case 'c':
                            if ((String.Compare(chars, 3, "ord", 0, 3, false) == 0) && (chars.Length == 6))
                                return TypeValueKnownValues.Value_Record;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'e':
                        if (String.Compare(chars, 2, "t", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'B':
                                    if (String.Compare(chars, 4, "rightness", 0, 9, false) == 0)
                                      {
                                        if (chars.Length == 13)
                                          {
                                            return TypeValueKnownValues.Value_SetBrightness;
                                          }
                                        switch (chars[13])
                                          {
                                            case 'D':
                                                if ((String.Compare(chars, 14, "elta", 0, 4, false) == 0) && (chars.Length == 18))
                                                    return TypeValueKnownValues.Value_SetBrightnessDelta;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'C':
                                    if (String.Compare(chars, 4, "olor", 0, 4, false) == 0)
                                      {
                                        if (chars.Length == 8)
                                          {
                                            return TypeValueKnownValues.Value_SetColor;
                                          }
                                        switch (chars[8])
                                          {
                                            case 'D':
                                                if ((String.Compare(chars, 9, "elta", 0, 4, false) == 0) && (chars.Length == 13))
                                                    return TypeValueKnownValues.Value_SetColorDelta;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'T':
                                    if (String.Compare(chars, 4, "emperature", 0, 10, false) == 0)
                                      {
                                        if (chars.Length == 14)
                                          {
                                            return TypeValueKnownValues.Value_SetTemperature;
                                          }
                                        switch (chars[14])
                                          {
                                            case 'D':
                                                if ((String.Compare(chars, 15, "elta", 0, 4, false) == 0) && (chars.Length == 19))
                                                    return TypeValueKnownValues.Value_SetTemperatureDelta;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'V':
                                    if (String.Compare(chars, 4, "olume", 0, 5, false) == 0)
                                      {
                                        if (chars.Length == 9)
                                          {
                                            return TypeValueKnownValues.Value_SetVolume;
                                          }
                                        switch (chars[9])
                                          {
                                            case 'D':
                                                if ((String.Compare(chars, 10, "elta", 0, 4, false) == 0) && (chars.Length == 14))
                                                    return TypeValueKnownValues.Value_SetVolumeDelta;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'W':
                                    if (String.Compare(chars, 4, "indSpeed", 0, 8, false) == 0)
                                      {
                                        if (chars.Length == 12)
                                          {
                                            return TypeValueKnownValues.Value_SetWindSpeed;
                                          }
                                        switch (chars[12])
                                          {
                                            case 'D':
                                                if ((String.Compare(chars, 13, "elta", 0, 4, false) == 0) && (chars.Length == 17))
                                                    return TypeValueKnownValues.Value_SetWindSpeedDelta;
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
                    case 'l':
                        if ((String.Compare(chars, 2, "eep", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValueKnownValues.Value_Sleep;
                        break;
                    case 't':
                        switch (chars[2])
                          {
                            case 'a':
                                if ((String.Compare(chars, 3, "rtCleaning", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeValueKnownValues.Value_StartCleaning;
                                break;
                            case 'o':
                                if ((String.Compare(chars, 3, "pCleaning", 0, 9, false) == 0) && (chars.Length == 12))
                                    return TypeValueKnownValues.Value_StopCleaning;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if (String.Compare(chars, 1, "ur", 0, 2, false) == 0)
                  {
                    switch (chars[3])
                      {
                        case 'b':
                            if ((String.Compare(chars, 4, "oControl", 0, 8, false) == 0) && (chars.Length == 12))
                                return TypeValueKnownValues.Value_TurboControl;
                            break;
                        case 'n':
                            if (String.Compare(chars, 4, "O", 0, 1, false) == 0)
                              {
                                switch (chars[5])
                                  {
                                    case 'f':
                                        if ((String.Compare(chars, 6, "f", 0, 1, false) == 0) && (chars.Length == 7))
                                            return TypeValueKnownValues.Value_TurnOff;
                                        break;
                                    case 'n':
                                        if (chars.Length == 6)
                                            return TypeValueKnownValues.Value_TurnOn;
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
            case 'U':
                if (String.Compare(chars, 1, "n", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'l':
                            if ((String.Compare(chars, 3, "ock", 0, 3, false) == 0) && (chars.Length == 6))
                                return TypeValueKnownValues.Value_Unlock;
                            break;
                        case 'm':
                            if ((String.Compare(chars, 3, "ute", 0, 3, false) == 0) && (chars.Length == 6))
                                return TypeValueKnownValues.Value_Unmute;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "ke", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Wake;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "nd", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Wind;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return TypeValueKnownValues.Value__none;
      }

    public static string  stringFromValue(TypeValueKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeValueKnownValues.Value_Auto:
                return "Auto";
            case TypeValueKnownValues.Value_Sleep:
                return "Sleep";
            case TypeValueKnownValues.Value_Wake:
                return "Wake";
            case TypeValueKnownValues.Value_TurnOn:
                return "TurnOn";
            case TypeValueKnownValues.Value_TurnOff:
                return "TurnOff";
            case TypeValueKnownValues.Value_SetBrightness:
                return "SetBrightness";
            case TypeValueKnownValues.Value_SetBrightnessDelta:
                return "SetBrightnessDelta";
            case TypeValueKnownValues.Value_SetColor:
                return "SetColor";
            case TypeValueKnownValues.Value_SetColorDelta:
                return "SetColorDelta";
            case TypeValueKnownValues.Value_Heat:
                return "Heat";
            case TypeValueKnownValues.Value_Cool:
                return "Cool";
            case TypeValueKnownValues.Value_Dry:
                return "Dry";
            case TypeValueKnownValues.Value_Wind:
                return "Wind";
            case TypeValueKnownValues.Value_SetTemperature:
                return "SetTemperature";
            case TypeValueKnownValues.Value_SetTemperatureDelta:
                return "SetTemperatureDelta";
            case TypeValueKnownValues.Value_SetWindSpeed:
                return "SetWindSpeed";
            case TypeValueKnownValues.Value_SetWindSpeedDelta:
                return "SetWindSpeedDelta";
            case TypeValueKnownValues.Value_StartCleaning:
                return "StartCleaning";
            case TypeValueKnownValues.Value_StopCleaning:
                return "StopCleaning";
            case TypeValueKnownValues.Value_TurboControl:
                return "TurboControl";
            case TypeValueKnownValues.Value_Ready:
                return "Ready";
            case TypeValueKnownValues.Value_Pause:
                return "Pause";
            case TypeValueKnownValues.Value_Cancel:
                return "Cancel";
            case TypeValueKnownValues.Value_Lock:
                return "Lock";
            case TypeValueKnownValues.Value_Unlock:
                return "Unlock";
            case TypeValueKnownValues.Value_Open:
                return "Open";
            case TypeValueKnownValues.Value_Close:
                return "Close";
            case TypeValueKnownValues.Value_Alarm:
                return "Alarm";
            case TypeValueKnownValues.Value_SetVolume:
                return "SetVolume";
            case TypeValueKnownValues.Value_SetVolumeDelta:
                return "SetVolumeDelta";
            case TypeValueKnownValues.Value_Mute:
                return "Mute";
            case TypeValueKnownValues.Value_Unmute:
                return "Unmute";
            case TypeValueKnownValues.Value_Record:
                return "Record";
            case TypeValueKnownValues.Value_PlayMusic:
                return "PlayMusic";
            case TypeValueKnownValues.Value_PlayVideo:
                return "PlayVideo";
            case TypeValueKnownValues.Value_ChangeChannel:
                return "ChangeChannel";
            case TypeValueKnownValues.Value_ChangeChannelDelta:
                return "ChangeChannelDelta";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasValue;
    private TypeValue storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Value of HomeAutomationOperationJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "arm", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Alarm;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "to", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Auto;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "ncel", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Cancel;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'h':
                        if (String.Compare(json_string.getData(), 2, "angeChannel", 0, 11, false) == 0)
                          {
                            if (json_string.getData().Length == 13)
                              {
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_ChangeChannel;
                                    goto open_enum_is_done;
                                  }
                              }
                            switch (json_string.getData()[13])
                              {
                                case 'D':
                                    if ((String.Compare(json_string.getData(), 14, "elta", 0, 4, false) == 0) && (json_string.getData().Length == 18))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_ChangeChannelDelta;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "ose", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Close;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "ol", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Cool;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ry", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Dry;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "eat", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Heat;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ock", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Lock;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "ute", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Mute;
                        goto open_enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "pen", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Open;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "use", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Pause;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'l':
                        if (String.Compare(json_string.getData(), 2, "ay", 0, 2, false) == 0)
                          {
                            switch (json_string.getData()[4])
                              {
                                case 'M':
                                    if ((String.Compare(json_string.getData(), 5, "usic", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_PlayMusic;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'V':
                                    if ((String.Compare(json_string.getData(), 5, "ideo", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_PlayVideo;
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
                if (String.Compare(json_string.getData(), 1, "e", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'a':
                            if ((String.Compare(json_string.getData(), 3, "dy", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_Ready;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'c':
                            if ((String.Compare(json_string.getData(), 3, "ord", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_Record;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "t", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'B':
                                    if (String.Compare(json_string.getData(), 4, "rightness", 0, 9, false) == 0)
                                      {
                                        if (json_string.getData().Length == 13)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SetBrightness;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[13])
                                          {
                                            case 'D':
                                                if ((String.Compare(json_string.getData(), 14, "elta", 0, 4, false) == 0) && (json_string.getData().Length == 18))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_SetBrightnessDelta;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'C':
                                    if (String.Compare(json_string.getData(), 4, "olor", 0, 4, false) == 0)
                                      {
                                        if (json_string.getData().Length == 8)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SetColor;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[8])
                                          {
                                            case 'D':
                                                if ((String.Compare(json_string.getData(), 9, "elta", 0, 4, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_SetColorDelta;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'T':
                                    if (String.Compare(json_string.getData(), 4, "emperature", 0, 10, false) == 0)
                                      {
                                        if (json_string.getData().Length == 14)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SetTemperature;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[14])
                                          {
                                            case 'D':
                                                if ((String.Compare(json_string.getData(), 15, "elta", 0, 4, false) == 0) && (json_string.getData().Length == 19))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_SetTemperatureDelta;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'V':
                                    if (String.Compare(json_string.getData(), 4, "olume", 0, 5, false) == 0)
                                      {
                                        if (json_string.getData().Length == 9)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SetVolume;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[9])
                                          {
                                            case 'D':
                                                if ((String.Compare(json_string.getData(), 10, "elta", 0, 4, false) == 0) && (json_string.getData().Length == 14))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_SetVolumeDelta;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'W':
                                    if (String.Compare(json_string.getData(), 4, "indSpeed", 0, 8, false) == 0)
                                      {
                                        if (json_string.getData().Length == 12)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SetWindSpeed;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[12])
                                          {
                                            case 'D':
                                                if ((String.Compare(json_string.getData(), 13, "elta", 0, 4, false) == 0) && (json_string.getData().Length == 17))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_SetWindSpeedDelta;
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
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "eep", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Sleep;
                                goto open_enum_is_done;
                              }
                        break;
                    case 't':
                        switch (json_string.getData()[2])
                          {
                            case 'a':
                                if ((String.Compare(json_string.getData(), 3, "rtCleaning", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_StartCleaning;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'o':
                                if ((String.Compare(json_string.getData(), 3, "pCleaning", 0, 9, false) == 0) && (json_string.getData().Length == 12))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_StopCleaning;
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
            case 'T':
                if (String.Compare(json_string.getData(), 1, "ur", 0, 2, false) == 0)
                  {
                    switch (json_string.getData()[3])
                      {
                        case 'b':
                            if ((String.Compare(json_string.getData(), 4, "oControl", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_TurboControl;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'n':
                            if (String.Compare(json_string.getData(), 4, "O", 0, 1, false) == 0)
                              {
                                switch (json_string.getData()[5])
                                  {
                                    case 'f':
                                        if ((String.Compare(json_string.getData(), 6, "f", 0, 1, false) == 0) && (json_string.getData().Length == 7))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_TurnOff;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'n':
                                        if (json_string.getData().Length == 6)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_TurnOn;
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
            case 'U':
                if (String.Compare(json_string.getData(), 1, "n", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'l':
                            if ((String.Compare(json_string.getData(), 3, "ock", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_Unlock;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'm':
                            if ((String.Compare(json_string.getData(), 3, "ute", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_Unmute;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "ke", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Wake;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "nd", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Wind;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setValue(the_open_enum);
      }


    public HomeAutomationOperationJSON()
      {
        flagHasValue = false;
      }

    public HomeAutomationOperationJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public HomeAutomationOperationJSON(string init_value)
      {
        flagHasValue = true;
        TypeValueKnownValues known = stringToValue(init_value);
        if (known == TypeValueKnownValues.Value__none)
          {
            storeValue.in_known_list = false;
            storeValue.string_value = init_value;
          }
        else
          {
            storeValue.in_known_list = true;
            storeValue.list_value = known;
          }
      }

    public HomeAutomationOperationJSON(TypeValueKnownValues init_value)
      {
        flagHasValue = true;
        Debug.Assert(init_value != TypeValueKnownValues.Value__none);
        storeValue.in_known_list = true;
        storeValue.list_value = init_value;
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public TypeValue  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }

    public string  getValueAsString()
      {
        TypeValue result = getValue();
        if (result.in_known_list)
            return stringFromValue(result.list_value);
        else
            return result.string_value;
      }



    public void setValue(TypeValue new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void setValue(string chars)
      {
        TypeValueKnownValues known = stringToValue(chars);
        TypeValue new_value = new TypeValue();
        if (known == TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setValue(new_value);
      }
    public void setValue(TypeValueKnownValues new_value)
      {
        TypeValue new_full_value = new TypeValue();
        Debug.Assert(new_value != TypeValueKnownValues.Value__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setValue(new_full_value);
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        if (storeValue.in_known_list)
          {
            switch (storeValue.list_value)
              {
                case TypeValueKnownValues.Value_Auto:
                    handler.string_value("Auto");
                    break;
                case TypeValueKnownValues.Value_Sleep:
                    handler.string_value("Sleep");
                    break;
                case TypeValueKnownValues.Value_Wake:
                    handler.string_value("Wake");
                    break;
                case TypeValueKnownValues.Value_TurnOn:
                    handler.string_value("TurnOn");
                    break;
                case TypeValueKnownValues.Value_TurnOff:
                    handler.string_value("TurnOff");
                    break;
                case TypeValueKnownValues.Value_SetBrightness:
                    handler.string_value("SetBrightness");
                    break;
                case TypeValueKnownValues.Value_SetBrightnessDelta:
                    handler.string_value("SetBrightnessDelta");
                    break;
                case TypeValueKnownValues.Value_SetColor:
                    handler.string_value("SetColor");
                    break;
                case TypeValueKnownValues.Value_SetColorDelta:
                    handler.string_value("SetColorDelta");
                    break;
                case TypeValueKnownValues.Value_Heat:
                    handler.string_value("Heat");
                    break;
                case TypeValueKnownValues.Value_Cool:
                    handler.string_value("Cool");
                    break;
                case TypeValueKnownValues.Value_Dry:
                    handler.string_value("Dry");
                    break;
                case TypeValueKnownValues.Value_Wind:
                    handler.string_value("Wind");
                    break;
                case TypeValueKnownValues.Value_SetTemperature:
                    handler.string_value("SetTemperature");
                    break;
                case TypeValueKnownValues.Value_SetTemperatureDelta:
                    handler.string_value("SetTemperatureDelta");
                    break;
                case TypeValueKnownValues.Value_SetWindSpeed:
                    handler.string_value("SetWindSpeed");
                    break;
                case TypeValueKnownValues.Value_SetWindSpeedDelta:
                    handler.string_value("SetWindSpeedDelta");
                    break;
                case TypeValueKnownValues.Value_StartCleaning:
                    handler.string_value("StartCleaning");
                    break;
                case TypeValueKnownValues.Value_StopCleaning:
                    handler.string_value("StopCleaning");
                    break;
                case TypeValueKnownValues.Value_TurboControl:
                    handler.string_value("TurboControl");
                    break;
                case TypeValueKnownValues.Value_Ready:
                    handler.string_value("Ready");
                    break;
                case TypeValueKnownValues.Value_Pause:
                    handler.string_value("Pause");
                    break;
                case TypeValueKnownValues.Value_Cancel:
                    handler.string_value("Cancel");
                    break;
                case TypeValueKnownValues.Value_Lock:
                    handler.string_value("Lock");
                    break;
                case TypeValueKnownValues.Value_Unlock:
                    handler.string_value("Unlock");
                    break;
                case TypeValueKnownValues.Value_Open:
                    handler.string_value("Open");
                    break;
                case TypeValueKnownValues.Value_Close:
                    handler.string_value("Close");
                    break;
                case TypeValueKnownValues.Value_Alarm:
                    handler.string_value("Alarm");
                    break;
                case TypeValueKnownValues.Value_SetVolume:
                    handler.string_value("SetVolume");
                    break;
                case TypeValueKnownValues.Value_SetVolumeDelta:
                    handler.string_value("SetVolumeDelta");
                    break;
                case TypeValueKnownValues.Value_Mute:
                    handler.string_value("Mute");
                    break;
                case TypeValueKnownValues.Value_Unmute:
                    handler.string_value("Unmute");
                    break;
                case TypeValueKnownValues.Value_Record:
                    handler.string_value("Record");
                    break;
                case TypeValueKnownValues.Value_PlayMusic:
                    handler.string_value("PlayMusic");
                    break;
                case TypeValueKnownValues.Value_PlayVideo:
                    handler.string_value("PlayVideo");
                    break;
                case TypeValueKnownValues.Value_ChangeChannel:
                    handler.string_value("ChangeChannel");
                    break;
                case TypeValueKnownValues.Value_ChangeChannelDelta:
                    handler.string_value("ChangeChannelDelta");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        else
          {
                    handler.string_value(storeValue.string_value);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        if (storeValue.in_known_list)
          {
            switch (storeValue.list_value)
              {
                case TypeValueKnownValues.Value_Auto:
                    handler.string_value("Auto");
                    break;
                case TypeValueKnownValues.Value_Sleep:
                    handler.string_value("Sleep");
                    break;
                case TypeValueKnownValues.Value_Wake:
                    handler.string_value("Wake");
                    break;
                case TypeValueKnownValues.Value_TurnOn:
                    handler.string_value("TurnOn");
                    break;
                case TypeValueKnownValues.Value_TurnOff:
                    handler.string_value("TurnOff");
                    break;
                case TypeValueKnownValues.Value_SetBrightness:
                    handler.string_value("SetBrightness");
                    break;
                case TypeValueKnownValues.Value_SetBrightnessDelta:
                    handler.string_value("SetBrightnessDelta");
                    break;
                case TypeValueKnownValues.Value_SetColor:
                    handler.string_value("SetColor");
                    break;
                case TypeValueKnownValues.Value_SetColorDelta:
                    handler.string_value("SetColorDelta");
                    break;
                case TypeValueKnownValues.Value_Heat:
                    handler.string_value("Heat");
                    break;
                case TypeValueKnownValues.Value_Cool:
                    handler.string_value("Cool");
                    break;
                case TypeValueKnownValues.Value_Dry:
                    handler.string_value("Dry");
                    break;
                case TypeValueKnownValues.Value_Wind:
                    handler.string_value("Wind");
                    break;
                case TypeValueKnownValues.Value_SetTemperature:
                    handler.string_value("SetTemperature");
                    break;
                case TypeValueKnownValues.Value_SetTemperatureDelta:
                    handler.string_value("SetTemperatureDelta");
                    break;
                case TypeValueKnownValues.Value_SetWindSpeed:
                    handler.string_value("SetWindSpeed");
                    break;
                case TypeValueKnownValues.Value_SetWindSpeedDelta:
                    handler.string_value("SetWindSpeedDelta");
                    break;
                case TypeValueKnownValues.Value_StartCleaning:
                    handler.string_value("StartCleaning");
                    break;
                case TypeValueKnownValues.Value_StopCleaning:
                    handler.string_value("StopCleaning");
                    break;
                case TypeValueKnownValues.Value_TurboControl:
                    handler.string_value("TurboControl");
                    break;
                case TypeValueKnownValues.Value_Ready:
                    handler.string_value("Ready");
                    break;
                case TypeValueKnownValues.Value_Pause:
                    handler.string_value("Pause");
                    break;
                case TypeValueKnownValues.Value_Cancel:
                    handler.string_value("Cancel");
                    break;
                case TypeValueKnownValues.Value_Lock:
                    handler.string_value("Lock");
                    break;
                case TypeValueKnownValues.Value_Unlock:
                    handler.string_value("Unlock");
                    break;
                case TypeValueKnownValues.Value_Open:
                    handler.string_value("Open");
                    break;
                case TypeValueKnownValues.Value_Close:
                    handler.string_value("Close");
                    break;
                case TypeValueKnownValues.Value_Alarm:
                    handler.string_value("Alarm");
                    break;
                case TypeValueKnownValues.Value_SetVolume:
                    handler.string_value("SetVolume");
                    break;
                case TypeValueKnownValues.Value_SetVolumeDelta:
                    handler.string_value("SetVolumeDelta");
                    break;
                case TypeValueKnownValues.Value_Mute:
                    handler.string_value("Mute");
                    break;
                case TypeValueKnownValues.Value_Unmute:
                    handler.string_value("Unmute");
                    break;
                case TypeValueKnownValues.Value_Record:
                    handler.string_value("Record");
                    break;
                case TypeValueKnownValues.Value_PlayMusic:
                    handler.string_value("PlayMusic");
                    break;
                case TypeValueKnownValues.Value_PlayVideo:
                    handler.string_value("PlayVideo");
                    break;
                case TypeValueKnownValues.Value_ChangeChannel:
                    handler.string_value("ChangeChannel");
                    break;
                case TypeValueKnownValues.Value_ChangeChannelDelta:
                    handler.string_value("ChangeChannelDelta");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        else
          {
                    handler.string_value(storeValue.string_value);
          }
      }

    public static HomeAutomationOperationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationOperationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationOperation", ignore_extras);
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
    public static HomeAutomationOperationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationOperationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationOperationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationOperation", ignore_extras);
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
    public static HomeAutomationOperationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationOperationJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationOperationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationOperation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationOperationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HomeAutomationOperationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationOperationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationOperation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class FieldGeneratorValue : JSONStringGenerator
      {
        protected FieldGeneratorValue(string what)
          {
            set_what(what);
          }
        protected FieldGeneratorValue()
          {
          }
        protected override void handle_result(string result)
          {
            TypeValueKnownValues known = stringToValue(result);
            TypeValue new_value = new TypeValue();
            if (known == TypeValueKnownValues.Value__none)
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
        protected abstract void handle_result(TypeValue result);
      };
    public class FieldHoldingGeneratorValue : FieldGeneratorValue
  {
    protected override void handle_result(TypeValue result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorValue(String what)
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
    public TypeValue value;
  };
    public class FieldHoldingArrayGeneratorValue : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorValue
      {
        private FieldHoldingArrayGeneratorValue top;

        protected override void handle_result(TypeValue result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorValue init_top)
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
    protected virtual void handle_result(List<TypeValue> result)
      {
      }

    public FieldHoldingArrayGeneratorValue(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorValue()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeValue> value;
  };
    public abstract class Generator : FieldGeneratorValue
      {
        protected override void handle_result(TypeValue new_value)
          {
            HomeAutomationOperationJSON result = new HomeAutomationOperationJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(HomeAutomationOperationJSON new_result);
        public Generator(bool ignore_extras) : base("Type HomeAutomationOperation")
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationOperationJSON  result)
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
        public HomeAutomationOperationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationOperationJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationOperationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationOperationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationOperationJSON>();
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
    public List<HomeAutomationOperationJSON> value;
  };
  };
