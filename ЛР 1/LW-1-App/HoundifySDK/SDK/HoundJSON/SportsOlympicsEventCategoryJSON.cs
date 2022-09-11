/* file "SportsOlympicsEventCategoryJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsEventCategoryJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_AlpineSkiing,
        Value_Biathlon,
        Value_Bobsleigh,
        Value_CrossCountrySkiing,
        Value_Curling,
        Value_FigureSkating,
        Value_FreestyleSkiing,
        Value_IceHockey,
        Value_Luge,
        Value_NordicCombined,
        Value_ShortTrackSpeedSkating,
        Value_Skeleton,
        Value_SkiJumping,
        Value_Snowboarding,
        Value_SpeedSkating,
        Value_Archery,
        Value_ArtisticSwimming,
        Value_Athletics,
        Value_Badminton,
        Value_Baseball,
        Value_Basketball,
        Value_Boxing,
        Value_Canoeing,
        Value_Cycling,
        Value_Diving,
        Value_Equestrian,
        Value_Fencing,
        Value_FieldHockey,
        Value_Football,
        Value_Golf,
        Value_Gymnastics,
        Value_Handball,
        Value_Judo,
        Value_Karate,
        Value_ModernPentathlon,
        Value_Rowing,
        Value_Rugby,
        Value_Sailing,
        Value_Shooting,
        Value_Skateboarding,
        Value_Softball,
        Value_SportClimbing,
        Value_Surfing,
        Value_Swimming,
        Value_TableTennis,
        Value_Taekwondo,
        Value_Tennis,
        Value_Triathlon,
        Value_Volleyball,
        Value_WaterPolo,
        Value_Weightlifting,
        Value_Wrestling,
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
                        if ((String.Compare(chars, 2, "pineSkiing", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeValueKnownValues.Value_AlpineSkiing;
                        break;
                    case 'r':
                        switch (chars[2])
                          {
                            case 'c':
                                if ((String.Compare(chars, 3, "hery", 0, 4, false) == 0) && (chars.Length == 7))
                                    return TypeValueKnownValues.Value_Archery;
                                break;
                            case 't':
                                if ((String.Compare(chars, 3, "isticSwimming", 0, 13, false) == 0) && (chars.Length == 16))
                                    return TypeValueKnownValues.Value_ArtisticSwimming;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 't':
                        if ((String.Compare(chars, 2, "hletics", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeValueKnownValues.Value_Athletics;
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'd':
                                if ((String.Compare(chars, 3, "minton", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeValueKnownValues.Value_Badminton;
                                break;
                            case 's':
                                switch (chars[3])
                                  {
                                    case 'e':
                                        if ((String.Compare(chars, 4, "ball", 0, 4, false) == 0) && (chars.Length == 8))
                                            return TypeValueKnownValues.Value_Baseball;
                                        break;
                                    case 'k':
                                        if ((String.Compare(chars, 4, "etball", 0, 6, false) == 0) && (chars.Length == 10))
                                            return TypeValueKnownValues.Value_Basketball;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "athlon", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeValueKnownValues.Value_Biathlon;
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'b':
                                if ((String.Compare(chars, 3, "sleigh", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeValueKnownValues.Value_Bobsleigh;
                                break;
                            case 'x':
                                if ((String.Compare(chars, 3, "ing", 0, 3, false) == 0) && (chars.Length == 6))
                                    return TypeValueKnownValues.Value_Boxing;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "noeing", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeValueKnownValues.Value_Canoeing;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "ossCountrySkiing", 0, 16, false) == 0) && (chars.Length == 18))
                            return TypeValueKnownValues.Value_CrossCountrySkiing;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "rling", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeValueKnownValues.Value_Curling;
                        break;
                    case 'y':
                        if ((String.Compare(chars, 2, "cling", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeValueKnownValues.Value_Cycling;
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if ((String.Compare(chars, 1, "iving", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeValueKnownValues.Value_Diving;
                break;
            case 'E':
                if ((String.Compare(chars, 1, "questrian", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeValueKnownValues.Value_Equestrian;
                break;
            case 'F':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "ncing", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeValueKnownValues.Value_Fencing;
                        break;
                    case 'i':
                        switch (chars[2])
                          {
                            case 'e':
                                if ((String.Compare(chars, 3, "ldHockey", 0, 8, false) == 0) && (chars.Length == 11))
                                    return TypeValueKnownValues.Value_FieldHockey;
                                break;
                            case 'g':
                                if ((String.Compare(chars, 3, "ureSkating", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeValueKnownValues.Value_FigureSkating;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "otball", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeValueKnownValues.Value_Football;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "eestyleSkiing", 0, 13, false) == 0) && (chars.Length == 15))
                            return TypeValueKnownValues.Value_FreestyleSkiing;
                        break;
                    default:
                        break;
                  }
                break;
            case 'G':
                switch (chars[1])
                  {
                    case 'o':
                        if ((String.Compare(chars, 2, "lf", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Golf;
                        break;
                    case 'y':
                        if ((String.Compare(chars, 2, "mnastics", 0, 8, false) == 0) && (chars.Length == 10))
                            return TypeValueKnownValues.Value_Gymnastics;
                        break;
                    default:
                        break;
                  }
                break;
            case 'H':
                if ((String.Compare(chars, 1, "andball", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeValueKnownValues.Value_Handball;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "ceHockey", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeValueKnownValues.Value_IceHockey;
                break;
            case 'J':
                if ((String.Compare(chars, 1, "udo", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeValueKnownValues.Value_Judo;
                break;
            case 'K':
                if ((String.Compare(chars, 1, "arate", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeValueKnownValues.Value_Karate;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "uge", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeValueKnownValues.Value_Luge;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "odernPentathlon", 0, 15, false) == 0) && (chars.Length == 16))
                    return TypeValueKnownValues.Value_ModernPentathlon;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "ordicCombined", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeValueKnownValues.Value_NordicCombined;
                break;
            case 'R':
                switch (chars[1])
                  {
                    case 'o':
                        if ((String.Compare(chars, 2, "wing", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_Rowing;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "gby", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValueKnownValues.Value_Rugby;
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "iling", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeValueKnownValues.Value_Sailing;
                        break;
                    case 'h':
                        if (String.Compare(chars, 2, "o", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'o':
                                    if ((String.Compare(chars, 4, "ting", 0, 4, false) == 0) && (chars.Length == 8))
                                        return TypeValueKnownValues.Value_Shooting;
                                    break;
                                case 'r':
                                    if ((String.Compare(chars, 4, "tTrackSpeedSkating", 0, 18, false) == 0) && (chars.Length == 22))
                                        return TypeValueKnownValues.Value_ShortTrackSpeedSkating;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'k':
                        switch (chars[2])
                          {
                            case 'a':
                                if ((String.Compare(chars, 3, "teboarding", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeValueKnownValues.Value_Skateboarding;
                                break;
                            case 'e':
                                if ((String.Compare(chars, 3, "leton", 0, 5, false) == 0) && (chars.Length == 8))
                                    return TypeValueKnownValues.Value_Skeleton;
                                break;
                            case 'i':
                                if ((String.Compare(chars, 3, "Jumping", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeValueKnownValues.Value_SkiJumping;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'n':
                        if ((String.Compare(chars, 2, "owboarding", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeValueKnownValues.Value_Snowboarding;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "ftball", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeValueKnownValues.Value_Softball;
                        break;
                    case 'p':
                        switch (chars[2])
                          {
                            case 'e':
                                if ((String.Compare(chars, 3, "edSkating", 0, 9, false) == 0) && (chars.Length == 12))
                                    return TypeValueKnownValues.Value_SpeedSkating;
                                break;
                            case 'o':
                                if ((String.Compare(chars, 3, "rtClimbing", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeValueKnownValues.Value_SportClimbing;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "rfing", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeValueKnownValues.Value_Surfing;
                        break;
                    case 'w':
                        if ((String.Compare(chars, 2, "imming", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeValueKnownValues.Value_Swimming;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'b':
                                if ((String.Compare(chars, 3, "leTennis", 0, 8, false) == 0) && (chars.Length == 11))
                                    return TypeValueKnownValues.Value_TableTennis;
                                break;
                            case 'e':
                                if ((String.Compare(chars, 3, "kwondo", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeValueKnownValues.Value_Taekwondo;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "nnis", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_Tennis;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "iathlon", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeValueKnownValues.Value_Triathlon;
                        break;
                    default:
                        break;
                  }
                break;
            case 'V':
                if ((String.Compare(chars, 1, "olleyball", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeValueKnownValues.Value_Volleyball;
                break;
            case 'W':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "terPolo", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeValueKnownValues.Value_WaterPolo;
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "ightlifting", 0, 11, false) == 0) && (chars.Length == 13))
                            return TypeValueKnownValues.Value_Weightlifting;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "estling", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeValueKnownValues.Value_Wrestling;
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
            case TypeValueKnownValues.Value_AlpineSkiing:
                return "AlpineSkiing";
            case TypeValueKnownValues.Value_Biathlon:
                return "Biathlon";
            case TypeValueKnownValues.Value_Bobsleigh:
                return "Bobsleigh";
            case TypeValueKnownValues.Value_CrossCountrySkiing:
                return "CrossCountrySkiing";
            case TypeValueKnownValues.Value_Curling:
                return "Curling";
            case TypeValueKnownValues.Value_FigureSkating:
                return "FigureSkating";
            case TypeValueKnownValues.Value_FreestyleSkiing:
                return "FreestyleSkiing";
            case TypeValueKnownValues.Value_IceHockey:
                return "IceHockey";
            case TypeValueKnownValues.Value_Luge:
                return "Luge";
            case TypeValueKnownValues.Value_NordicCombined:
                return "NordicCombined";
            case TypeValueKnownValues.Value_ShortTrackSpeedSkating:
                return "ShortTrackSpeedSkating";
            case TypeValueKnownValues.Value_Skeleton:
                return "Skeleton";
            case TypeValueKnownValues.Value_SkiJumping:
                return "SkiJumping";
            case TypeValueKnownValues.Value_Snowboarding:
                return "Snowboarding";
            case TypeValueKnownValues.Value_SpeedSkating:
                return "SpeedSkating";
            case TypeValueKnownValues.Value_Archery:
                return "Archery";
            case TypeValueKnownValues.Value_ArtisticSwimming:
                return "ArtisticSwimming";
            case TypeValueKnownValues.Value_Athletics:
                return "Athletics";
            case TypeValueKnownValues.Value_Badminton:
                return "Badminton";
            case TypeValueKnownValues.Value_Baseball:
                return "Baseball";
            case TypeValueKnownValues.Value_Basketball:
                return "Basketball";
            case TypeValueKnownValues.Value_Boxing:
                return "Boxing";
            case TypeValueKnownValues.Value_Canoeing:
                return "Canoeing";
            case TypeValueKnownValues.Value_Cycling:
                return "Cycling";
            case TypeValueKnownValues.Value_Diving:
                return "Diving";
            case TypeValueKnownValues.Value_Equestrian:
                return "Equestrian";
            case TypeValueKnownValues.Value_Fencing:
                return "Fencing";
            case TypeValueKnownValues.Value_FieldHockey:
                return "FieldHockey";
            case TypeValueKnownValues.Value_Football:
                return "Football";
            case TypeValueKnownValues.Value_Golf:
                return "Golf";
            case TypeValueKnownValues.Value_Gymnastics:
                return "Gymnastics";
            case TypeValueKnownValues.Value_Handball:
                return "Handball";
            case TypeValueKnownValues.Value_Judo:
                return "Judo";
            case TypeValueKnownValues.Value_Karate:
                return "Karate";
            case TypeValueKnownValues.Value_ModernPentathlon:
                return "ModernPentathlon";
            case TypeValueKnownValues.Value_Rowing:
                return "Rowing";
            case TypeValueKnownValues.Value_Rugby:
                return "Rugby";
            case TypeValueKnownValues.Value_Sailing:
                return "Sailing";
            case TypeValueKnownValues.Value_Shooting:
                return "Shooting";
            case TypeValueKnownValues.Value_Skateboarding:
                return "Skateboarding";
            case TypeValueKnownValues.Value_Softball:
                return "Softball";
            case TypeValueKnownValues.Value_SportClimbing:
                return "SportClimbing";
            case TypeValueKnownValues.Value_Surfing:
                return "Surfing";
            case TypeValueKnownValues.Value_Swimming:
                return "Swimming";
            case TypeValueKnownValues.Value_TableTennis:
                return "TableTennis";
            case TypeValueKnownValues.Value_Taekwondo:
                return "Taekwondo";
            case TypeValueKnownValues.Value_Tennis:
                return "Tennis";
            case TypeValueKnownValues.Value_Triathlon:
                return "Triathlon";
            case TypeValueKnownValues.Value_Volleyball:
                return "Volleyball";
            case TypeValueKnownValues.Value_WaterPolo:
                return "WaterPolo";
            case TypeValueKnownValues.Value_Weightlifting:
                return "Weightlifting";
            case TypeValueKnownValues.Value_Wrestling:
                return "Wrestling";
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
            throw new Exception("The value for field Value of SportsOlympicsEventCategoryJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "pineSkiing", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_AlpineSkiing;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        switch (json_string.getData()[2])
                          {
                            case 'c':
                                if ((String.Compare(json_string.getData(), 3, "hery", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Archery;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 't':
                                if ((String.Compare(json_string.getData(), 3, "isticSwimming", 0, 13, false) == 0) && (json_string.getData().Length == 16))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_ArtisticSwimming;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 't':
                        if ((String.Compare(json_string.getData(), 2, "hletics", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Athletics;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'd':
                                if ((String.Compare(json_string.getData(), 3, "minton", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Badminton;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 's':
                                switch (json_string.getData()[3])
                                  {
                                    case 'e':
                                        if ((String.Compare(json_string.getData(), 4, "ball", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_Baseball;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'k':
                                        if ((String.Compare(json_string.getData(), 4, "etball", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_Basketball;
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
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "athlon", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Biathlon;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 'b':
                                if ((String.Compare(json_string.getData(), 3, "sleigh", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Bobsleigh;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'x':
                                if ((String.Compare(json_string.getData(), 3, "ing", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Boxing;
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
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "noeing", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Canoeing;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "ossCountrySkiing", 0, 16, false) == 0) && (json_string.getData().Length == 18))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_CrossCountrySkiing;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "rling", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Curling;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'y':
                        if ((String.Compare(json_string.getData(), 2, "cling", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Cycling;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "iving", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Diving;
                        goto open_enum_is_done;
                      }
                break;
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "questrian", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Equestrian;
                        goto open_enum_is_done;
                      }
                break;
            case 'F':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "ncing", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Fencing;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        switch (json_string.getData()[2])
                          {
                            case 'e':
                                if ((String.Compare(json_string.getData(), 3, "ldHockey", 0, 8, false) == 0) && (json_string.getData().Length == 11))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_FieldHockey;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'g':
                                if ((String.Compare(json_string.getData(), 3, "ureSkating", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_FigureSkating;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "otball", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Football;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "eestyleSkiing", 0, 13, false) == 0) && (json_string.getData().Length == 15))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_FreestyleSkiing;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'G':
                switch (json_string.getData()[1])
                  {
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "lf", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Golf;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'y':
                        if ((String.Compare(json_string.getData(), 2, "mnastics", 0, 8, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Gymnastics;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "andball", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Handball;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "ceHockey", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_IceHockey;
                        goto open_enum_is_done;
                      }
                break;
            case 'J':
                if ((String.Compare(json_string.getData(), 1, "udo", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Judo;
                        goto open_enum_is_done;
                      }
                break;
            case 'K':
                if ((String.Compare(json_string.getData(), 1, "arate", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Karate;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "uge", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Luge;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "odernPentathlon", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_ModernPentathlon;
                        goto open_enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "ordicCombined", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_NordicCombined;
                        goto open_enum_is_done;
                      }
                break;
            case 'R':
                switch (json_string.getData()[1])
                  {
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "wing", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Rowing;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "gby", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Rugby;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "iling", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Sailing;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'h':
                        if (String.Compare(json_string.getData(), 2, "o", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'o':
                                    if ((String.Compare(json_string.getData(), 4, "ting", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Shooting;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'r':
                                    if ((String.Compare(json_string.getData(), 4, "tTrackSpeedSkating", 0, 18, false) == 0) && (json_string.getData().Length == 22))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_ShortTrackSpeedSkating;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'k':
                        switch (json_string.getData()[2])
                          {
                            case 'a':
                                if ((String.Compare(json_string.getData(), 3, "teboarding", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Skateboarding;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'e':
                                if ((String.Compare(json_string.getData(), 3, "leton", 0, 5, false) == 0) && (json_string.getData().Length == 8))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Skeleton;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'i':
                                if ((String.Compare(json_string.getData(), 3, "Jumping", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_SkiJumping;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'n':
                        if ((String.Compare(json_string.getData(), 2, "owboarding", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Snowboarding;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "ftball", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Softball;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'p':
                        switch (json_string.getData()[2])
                          {
                            case 'e':
                                if ((String.Compare(json_string.getData(), 3, "edSkating", 0, 9, false) == 0) && (json_string.getData().Length == 12))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_SpeedSkating;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'o':
                                if ((String.Compare(json_string.getData(), 3, "rtClimbing", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_SportClimbing;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "rfing", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Surfing;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'w':
                        if ((String.Compare(json_string.getData(), 2, "imming", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Swimming;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'b':
                                if ((String.Compare(json_string.getData(), 3, "leTennis", 0, 8, false) == 0) && (json_string.getData().Length == 11))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_TableTennis;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'e':
                                if ((String.Compare(json_string.getData(), 3, "kwondo", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Taekwondo;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "nnis", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Tennis;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "iathlon", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Triathlon;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'V':
                if ((String.Compare(json_string.getData(), 1, "olleyball", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Volleyball;
                        goto open_enum_is_done;
                      }
                break;
            case 'W':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "terPolo", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_WaterPolo;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "ightlifting", 0, 11, false) == 0) && (json_string.getData().Length == 13))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Weightlifting;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "estling", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Wrestling;
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


    public SportsOlympicsEventCategoryJSON()
      {
        flagHasValue = false;
      }

    public SportsOlympicsEventCategoryJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public SportsOlympicsEventCategoryJSON(string init_value)
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

    public SportsOlympicsEventCategoryJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_AlpineSkiing:
                    handler.string_value("AlpineSkiing");
                    break;
                case TypeValueKnownValues.Value_Biathlon:
                    handler.string_value("Biathlon");
                    break;
                case TypeValueKnownValues.Value_Bobsleigh:
                    handler.string_value("Bobsleigh");
                    break;
                case TypeValueKnownValues.Value_CrossCountrySkiing:
                    handler.string_value("CrossCountrySkiing");
                    break;
                case TypeValueKnownValues.Value_Curling:
                    handler.string_value("Curling");
                    break;
                case TypeValueKnownValues.Value_FigureSkating:
                    handler.string_value("FigureSkating");
                    break;
                case TypeValueKnownValues.Value_FreestyleSkiing:
                    handler.string_value("FreestyleSkiing");
                    break;
                case TypeValueKnownValues.Value_IceHockey:
                    handler.string_value("IceHockey");
                    break;
                case TypeValueKnownValues.Value_Luge:
                    handler.string_value("Luge");
                    break;
                case TypeValueKnownValues.Value_NordicCombined:
                    handler.string_value("NordicCombined");
                    break;
                case TypeValueKnownValues.Value_ShortTrackSpeedSkating:
                    handler.string_value("ShortTrackSpeedSkating");
                    break;
                case TypeValueKnownValues.Value_Skeleton:
                    handler.string_value("Skeleton");
                    break;
                case TypeValueKnownValues.Value_SkiJumping:
                    handler.string_value("SkiJumping");
                    break;
                case TypeValueKnownValues.Value_Snowboarding:
                    handler.string_value("Snowboarding");
                    break;
                case TypeValueKnownValues.Value_SpeedSkating:
                    handler.string_value("SpeedSkating");
                    break;
                case TypeValueKnownValues.Value_Archery:
                    handler.string_value("Archery");
                    break;
                case TypeValueKnownValues.Value_ArtisticSwimming:
                    handler.string_value("ArtisticSwimming");
                    break;
                case TypeValueKnownValues.Value_Athletics:
                    handler.string_value("Athletics");
                    break;
                case TypeValueKnownValues.Value_Badminton:
                    handler.string_value("Badminton");
                    break;
                case TypeValueKnownValues.Value_Baseball:
                    handler.string_value("Baseball");
                    break;
                case TypeValueKnownValues.Value_Basketball:
                    handler.string_value("Basketball");
                    break;
                case TypeValueKnownValues.Value_Boxing:
                    handler.string_value("Boxing");
                    break;
                case TypeValueKnownValues.Value_Canoeing:
                    handler.string_value("Canoeing");
                    break;
                case TypeValueKnownValues.Value_Cycling:
                    handler.string_value("Cycling");
                    break;
                case TypeValueKnownValues.Value_Diving:
                    handler.string_value("Diving");
                    break;
                case TypeValueKnownValues.Value_Equestrian:
                    handler.string_value("Equestrian");
                    break;
                case TypeValueKnownValues.Value_Fencing:
                    handler.string_value("Fencing");
                    break;
                case TypeValueKnownValues.Value_FieldHockey:
                    handler.string_value("FieldHockey");
                    break;
                case TypeValueKnownValues.Value_Football:
                    handler.string_value("Football");
                    break;
                case TypeValueKnownValues.Value_Golf:
                    handler.string_value("Golf");
                    break;
                case TypeValueKnownValues.Value_Gymnastics:
                    handler.string_value("Gymnastics");
                    break;
                case TypeValueKnownValues.Value_Handball:
                    handler.string_value("Handball");
                    break;
                case TypeValueKnownValues.Value_Judo:
                    handler.string_value("Judo");
                    break;
                case TypeValueKnownValues.Value_Karate:
                    handler.string_value("Karate");
                    break;
                case TypeValueKnownValues.Value_ModernPentathlon:
                    handler.string_value("ModernPentathlon");
                    break;
                case TypeValueKnownValues.Value_Rowing:
                    handler.string_value("Rowing");
                    break;
                case TypeValueKnownValues.Value_Rugby:
                    handler.string_value("Rugby");
                    break;
                case TypeValueKnownValues.Value_Sailing:
                    handler.string_value("Sailing");
                    break;
                case TypeValueKnownValues.Value_Shooting:
                    handler.string_value("Shooting");
                    break;
                case TypeValueKnownValues.Value_Skateboarding:
                    handler.string_value("Skateboarding");
                    break;
                case TypeValueKnownValues.Value_Softball:
                    handler.string_value("Softball");
                    break;
                case TypeValueKnownValues.Value_SportClimbing:
                    handler.string_value("SportClimbing");
                    break;
                case TypeValueKnownValues.Value_Surfing:
                    handler.string_value("Surfing");
                    break;
                case TypeValueKnownValues.Value_Swimming:
                    handler.string_value("Swimming");
                    break;
                case TypeValueKnownValues.Value_TableTennis:
                    handler.string_value("TableTennis");
                    break;
                case TypeValueKnownValues.Value_Taekwondo:
                    handler.string_value("Taekwondo");
                    break;
                case TypeValueKnownValues.Value_Tennis:
                    handler.string_value("Tennis");
                    break;
                case TypeValueKnownValues.Value_Triathlon:
                    handler.string_value("Triathlon");
                    break;
                case TypeValueKnownValues.Value_Volleyball:
                    handler.string_value("Volleyball");
                    break;
                case TypeValueKnownValues.Value_WaterPolo:
                    handler.string_value("WaterPolo");
                    break;
                case TypeValueKnownValues.Value_Weightlifting:
                    handler.string_value("Weightlifting");
                    break;
                case TypeValueKnownValues.Value_Wrestling:
                    handler.string_value("Wrestling");
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
                case TypeValueKnownValues.Value_AlpineSkiing:
                    handler.string_value("AlpineSkiing");
                    break;
                case TypeValueKnownValues.Value_Biathlon:
                    handler.string_value("Biathlon");
                    break;
                case TypeValueKnownValues.Value_Bobsleigh:
                    handler.string_value("Bobsleigh");
                    break;
                case TypeValueKnownValues.Value_CrossCountrySkiing:
                    handler.string_value("CrossCountrySkiing");
                    break;
                case TypeValueKnownValues.Value_Curling:
                    handler.string_value("Curling");
                    break;
                case TypeValueKnownValues.Value_FigureSkating:
                    handler.string_value("FigureSkating");
                    break;
                case TypeValueKnownValues.Value_FreestyleSkiing:
                    handler.string_value("FreestyleSkiing");
                    break;
                case TypeValueKnownValues.Value_IceHockey:
                    handler.string_value("IceHockey");
                    break;
                case TypeValueKnownValues.Value_Luge:
                    handler.string_value("Luge");
                    break;
                case TypeValueKnownValues.Value_NordicCombined:
                    handler.string_value("NordicCombined");
                    break;
                case TypeValueKnownValues.Value_ShortTrackSpeedSkating:
                    handler.string_value("ShortTrackSpeedSkating");
                    break;
                case TypeValueKnownValues.Value_Skeleton:
                    handler.string_value("Skeleton");
                    break;
                case TypeValueKnownValues.Value_SkiJumping:
                    handler.string_value("SkiJumping");
                    break;
                case TypeValueKnownValues.Value_Snowboarding:
                    handler.string_value("Snowboarding");
                    break;
                case TypeValueKnownValues.Value_SpeedSkating:
                    handler.string_value("SpeedSkating");
                    break;
                case TypeValueKnownValues.Value_Archery:
                    handler.string_value("Archery");
                    break;
                case TypeValueKnownValues.Value_ArtisticSwimming:
                    handler.string_value("ArtisticSwimming");
                    break;
                case TypeValueKnownValues.Value_Athletics:
                    handler.string_value("Athletics");
                    break;
                case TypeValueKnownValues.Value_Badminton:
                    handler.string_value("Badminton");
                    break;
                case TypeValueKnownValues.Value_Baseball:
                    handler.string_value("Baseball");
                    break;
                case TypeValueKnownValues.Value_Basketball:
                    handler.string_value("Basketball");
                    break;
                case TypeValueKnownValues.Value_Boxing:
                    handler.string_value("Boxing");
                    break;
                case TypeValueKnownValues.Value_Canoeing:
                    handler.string_value("Canoeing");
                    break;
                case TypeValueKnownValues.Value_Cycling:
                    handler.string_value("Cycling");
                    break;
                case TypeValueKnownValues.Value_Diving:
                    handler.string_value("Diving");
                    break;
                case TypeValueKnownValues.Value_Equestrian:
                    handler.string_value("Equestrian");
                    break;
                case TypeValueKnownValues.Value_Fencing:
                    handler.string_value("Fencing");
                    break;
                case TypeValueKnownValues.Value_FieldHockey:
                    handler.string_value("FieldHockey");
                    break;
                case TypeValueKnownValues.Value_Football:
                    handler.string_value("Football");
                    break;
                case TypeValueKnownValues.Value_Golf:
                    handler.string_value("Golf");
                    break;
                case TypeValueKnownValues.Value_Gymnastics:
                    handler.string_value("Gymnastics");
                    break;
                case TypeValueKnownValues.Value_Handball:
                    handler.string_value("Handball");
                    break;
                case TypeValueKnownValues.Value_Judo:
                    handler.string_value("Judo");
                    break;
                case TypeValueKnownValues.Value_Karate:
                    handler.string_value("Karate");
                    break;
                case TypeValueKnownValues.Value_ModernPentathlon:
                    handler.string_value("ModernPentathlon");
                    break;
                case TypeValueKnownValues.Value_Rowing:
                    handler.string_value("Rowing");
                    break;
                case TypeValueKnownValues.Value_Rugby:
                    handler.string_value("Rugby");
                    break;
                case TypeValueKnownValues.Value_Sailing:
                    handler.string_value("Sailing");
                    break;
                case TypeValueKnownValues.Value_Shooting:
                    handler.string_value("Shooting");
                    break;
                case TypeValueKnownValues.Value_Skateboarding:
                    handler.string_value("Skateboarding");
                    break;
                case TypeValueKnownValues.Value_Softball:
                    handler.string_value("Softball");
                    break;
                case TypeValueKnownValues.Value_SportClimbing:
                    handler.string_value("SportClimbing");
                    break;
                case TypeValueKnownValues.Value_Surfing:
                    handler.string_value("Surfing");
                    break;
                case TypeValueKnownValues.Value_Swimming:
                    handler.string_value("Swimming");
                    break;
                case TypeValueKnownValues.Value_TableTennis:
                    handler.string_value("TableTennis");
                    break;
                case TypeValueKnownValues.Value_Taekwondo:
                    handler.string_value("Taekwondo");
                    break;
                case TypeValueKnownValues.Value_Tennis:
                    handler.string_value("Tennis");
                    break;
                case TypeValueKnownValues.Value_Triathlon:
                    handler.string_value("Triathlon");
                    break;
                case TypeValueKnownValues.Value_Volleyball:
                    handler.string_value("Volleyball");
                    break;
                case TypeValueKnownValues.Value_WaterPolo:
                    handler.string_value("WaterPolo");
                    break;
                case TypeValueKnownValues.Value_Weightlifting:
                    handler.string_value("Weightlifting");
                    break;
                case TypeValueKnownValues.Value_Wrestling:
                    handler.string_value("Wrestling");
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

    public static SportsOlympicsEventCategoryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventCategoryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventCategory", ignore_extras);
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
    public static SportsOlympicsEventCategoryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsEventCategoryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventCategoryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventCategory", ignore_extras);
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
    public static SportsOlympicsEventCategoryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsEventCategoryJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsEventCategoryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventCategory", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsEventCategoryJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsEventCategoryJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsEventCategoryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventCategory", ignore_extras);
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
            SportsOlympicsEventCategoryJSON result = new SportsOlympicsEventCategoryJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(SportsOlympicsEventCategoryJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsOlympicsEventCategory")
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
        protected override void handle_result(SportsOlympicsEventCategoryJSON  result)
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
        public SportsOlympicsEventCategoryJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsEventCategoryJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsEventCategoryJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsEventCategoryJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsEventCategoryJSON>();
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
    public List<SportsOlympicsEventCategoryJSON> value;
  };
  };
