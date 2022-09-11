/* file "ForecastShortPhraseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ForecastShortPhraseJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_dreary,
        Value_a_x20_shower,
        Value_shower,
        Value_showers,
        Value_heavy_x20_rain_x20_shower,
        Value_light_x20_rain_x20_shower,
        Value_chance_x20_of_x20_flurries,
        Value_chance_x20_of_x20_rain,
        Value_chance_x20_rain,
        Value_chance_x20_of_x20_freezing_x20_rain,
        Value_chance_x20_of_x20_sleet,
        Value_chance_x20_of_x20_snow,
        Value_chance_x20_of_x20_thunderstorms,
        Value_chance_x20_of_x20_a_x20_thunderstorm,
        Value_clear,
        Value_cloudy,
        Value_some_x20_clouds,
        Value_flurries,
        Value_light_x20_fog,
        Value_fog,
        Value_heavy_x20_fog,
        Value_haze,
        Value_light_x20_snow_x2f_fog,
        Value_light_x20_snow_x20_and_x20_fog,
        Value_snow_x2f_fog,
        Value_snow_x20_and_x20_fog,
        Value_heavy_x20_snow_x2f_fog,
        Value_heavy_x20_snow_x20_and_x20_fog,
        Value_mostly_x20_cloudy,
        Value_mostly_x20_sunny,
        Value_mostly_x20_clear,
        Value_partly_x20_cloudy,
        Value_partly_x20_sunny,
        Value_partly_x20_sunny_x20_w_x2f__x20_showers,
        Value_mostly_x20_cloudy_x20_w_x2f__x20_showers,
        Value_partly_x20_cloudy_x20_w_x2f__x20_showers,
        Value_partly_x20_sunny_x20_w_x2f__x20_t_storms,
        Value_mostly_x20_cloudy_x20_w_x2f__x20_t_storms,
        Value_partly_x20_cloudy_x20_w_x2f__x20_t_storms,
        Value_partly_x20_sunny_x20_w_x2f__x20_flurries,
        Value_mostly_x20_cloudy_x20_w_x2f__x20_flurries,
        Value_partly_x20_cloudy_x20_w_x2f__x20_flurries,
        Value_partly_x20_sunny_x20_w_x2f__x20_snow,
        Value_mostly_x20_cloudy_x20_w_x2f__x20_snow,
        Value_partly_x20_cloudy_x20_w_x2f__x20_snow,
        Value_intermittent_x20_clouds,
        Value_freezing_x20_rain,
        Value_rain,
        Value_rain_x20_and_x20_snow,
        Value_sleet,
        Value_snow,
        Value_sunny,
        Value_clouds_x20_and_x20_sun,
        Value_thunderstorms,
        Value_thunderstorm,
        Value_overcast,
        Value_scattered_x20_clouds,
        Value_thin_x20_high_x20_clouds,
        Value_partly_x20_cloudy_x20_with_x20_light_x20_rain,
        Value_cloudy_x20_with_x20_light_x20_rain,
        Value_overcast_x20_with_x20_light_x20_rain,
        Value_partly_x20_cloudy_x20_with_x20_showers,
        Value_cloudy_x20_with_x20_showers,
        Value_overcast_x20_with_x20_showers,
        Value_overcast_x20_with_x20_rain,
        Value_partly_x20_cloudy_x2c__x20_possible_x20_thunderstorms_x20_with_x20_rain,
        Value_cloudy_x2c__x20_thunderstorms_x20_with_x20_rain,
        Value_overcast_x2c__x20_thunderstorms_x20_with_x20_rain,
        Value_partly_x20_cloudy_x20_with_x20_light_x20_wet_x20_snow,
        Value_cloudy_x20_with_x20_light_x20_wet_x20_snow,
        Value_overcast_x20_with_x20_light_x20_wet_x20_snow,
        Value_partly_x20_cloudy_x20_with_x20_wet_x20_snow_x20_showers,
        Value_cloudy_x20_with_x20_wet_x20_snow_x20_showers,
        Value_overcast_x20_with_x20_wet_x20_snow_x20_showers,
        Value_overcast_x20_with_x20_wet_x20_snow,
        Value_partly_x20_cloudy_x20_with_x20_light_x20_snow,
        Value_cloudy_x20_with_x20_light_x20_snow,
        Value_overcast_x20_with_x20_light_x20_snow,
        Value_partly_x20_cloudy_x20_with_x20_snow_x20_showers,
        Value_cloudy_x20_with_x20_snow_x20_showers,
        Value_overcast_x20_with_x20_snow_x20_showers,
        Value_overcast_x20_with_x20_snow,
        Value_unknown,
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
            case 'a':
                if ((String.Compare(chars, 1, " shower", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeValueKnownValues.Value_a_x20_shower;
                break;
            case 'c':
                switch (chars[1])
                  {
                    case 'h':
                        if (String.Compare(chars, 2, "ance ", 0, 5, false) == 0)
                          {
                            switch (chars[7])
                              {
                                case 'o':
                                    if (String.Compare(chars, 8, "f ", 0, 2, false) == 0)
                                      {
                                        switch (chars[10])
                                          {
                                            case 'a':
                                                if ((String.Compare(chars, 11, " thunderstorm", 0, 13, false) == 0) && (chars.Length == 24))
                                                    return TypeValueKnownValues.Value_chance_x20_of_x20_a_x20_thunderstorm;
                                                break;
                                            case 'f':
                                                switch (chars[11])
                                                  {
                                                    case 'l':
                                                        if ((String.Compare(chars, 12, "urries", 0, 6, false) == 0) && (chars.Length == 18))
                                                            return TypeValueKnownValues.Value_chance_x20_of_x20_flurries;
                                                        break;
                                                    case 'r':
                                                        if ((String.Compare(chars, 12, "eezing rain", 0, 11, false) == 0) && (chars.Length == 23))
                                                            return TypeValueKnownValues.Value_chance_x20_of_x20_freezing_x20_rain;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'r':
                                                if ((String.Compare(chars, 11, "ain", 0, 3, false) == 0) && (chars.Length == 14))
                                                    return TypeValueKnownValues.Value_chance_x20_of_x20_rain;
                                                break;
                                            case 's':
                                                switch (chars[11])
                                                  {
                                                    case 'l':
                                                        if ((String.Compare(chars, 12, "eet", 0, 3, false) == 0) && (chars.Length == 15))
                                                            return TypeValueKnownValues.Value_chance_x20_of_x20_sleet;
                                                        break;
                                                    case 'n':
                                                        if ((String.Compare(chars, 12, "ow", 0, 2, false) == 0) && (chars.Length == 14))
                                                            return TypeValueKnownValues.Value_chance_x20_of_x20_snow;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 't':
                                                if ((String.Compare(chars, 11, "hunderstorms", 0, 12, false) == 0) && (chars.Length == 23))
                                                    return TypeValueKnownValues.Value_chance_x20_of_x20_thunderstorms;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'r':
                                    if ((String.Compare(chars, 8, "ain", 0, 3, false) == 0) && (chars.Length == 11))
                                        return TypeValueKnownValues.Value_chance_x20_rain;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'l':
                        switch (chars[2])
                          {
                            case 'e':
                                if ((String.Compare(chars, 3, "ar", 0, 2, false) == 0) && (chars.Length == 5))
                                    return TypeValueKnownValues.Value_clear;
                                break;
                            case 'o':
                                if (String.Compare(chars, 3, "ud", 0, 2, false) == 0)
                                  {
                                    switch (chars[5])
                                      {
                                        case 's':
                                            if ((String.Compare(chars, 6, " and sun", 0, 8, false) == 0) && (chars.Length == 14))
                                                return TypeValueKnownValues.Value_clouds_x20_and_x20_sun;
                                            break;
                                        case 'y':
                                            if (chars.Length == 6)
                                              {
                                                return TypeValueKnownValues.Value_cloudy;
                                              }
                                            switch (chars[6])
                                              {
                                                case ' ':
                                                    if (String.Compare(chars, 7, "with ", 0, 5, false) == 0)
                                                      {
                                                        switch (chars[12])
                                                          {
                                                            case 'l':
                                                                if (String.Compare(chars, 13, "ight ", 0, 5, false) == 0)
                                                                  {
                                                                    switch (chars[18])
                                                                      {
                                                                        case 'r':
                                                                            if ((String.Compare(chars, 19, "ain", 0, 3, false) == 0) && (chars.Length == 22))
                                                                                return TypeValueKnownValues.Value_cloudy_x20_with_x20_light_x20_rain;
                                                                            break;
                                                                        case 's':
                                                                            if ((String.Compare(chars, 19, "now", 0, 3, false) == 0) && (chars.Length == 22))
                                                                                return TypeValueKnownValues.Value_cloudy_x20_with_x20_light_x20_snow;
                                                                            break;
                                                                        case 'w':
                                                                            if ((String.Compare(chars, 19, "et snow", 0, 7, false) == 0) && (chars.Length == 26))
                                                                                return TypeValueKnownValues.Value_cloudy_x20_with_x20_light_x20_wet_x20_snow;
                                                                            break;
                                                                        default:
                                                                            break;
                                                                      }
                                                                  }
                                                                break;
                                                            case 's':
                                                                switch (chars[13])
                                                                  {
                                                                    case 'h':
                                                                        if ((String.Compare(chars, 14, "owers", 0, 5, false) == 0) && (chars.Length == 19))
                                                                            return TypeValueKnownValues.Value_cloudy_x20_with_x20_showers;
                                                                        break;
                                                                    case 'n':
                                                                        if ((String.Compare(chars, 14, "ow showers", 0, 10, false) == 0) && (chars.Length == 24))
                                                                            return TypeValueKnownValues.Value_cloudy_x20_with_x20_snow_x20_showers;
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                                break;
                                                            case 'w':
                                                                if ((String.Compare(chars, 13, "et snow showers", 0, 15, false) == 0) && (chars.Length == 28))
                                                                    return TypeValueKnownValues.Value_cloudy_x20_with_x20_wet_x20_snow_x20_showers;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case ',':
                                                    if ((String.Compare(chars, 7, " thunderstorms with rain", 0, 24, false) == 0) && (chars.Length == 31))
                                                        return TypeValueKnownValues.Value_cloudy_x2c__x20_thunderstorms_x20_with_x20_rain;
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
                        break;
                    default:
                        break;
                  }
                break;
            case 'd':
                if ((String.Compare(chars, 1, "reary", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeValueKnownValues.Value_dreary;
                break;
            case 'f':
                switch (chars[1])
                  {
                    case 'l':
                        if ((String.Compare(chars, 2, "urries", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeValueKnownValues.Value_flurries;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "g", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeValueKnownValues.Value_fog;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "eezing rain", 0, 11, false) == 0) && (chars.Length == 13))
                            return TypeValueKnownValues.Value_freezing_x20_rain;
                        break;
                    default:
                        break;
                  }
                break;
            case 'h':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "ze", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_haze;
                        break;
                    case 'e':
                        if (String.Compare(chars, 2, "avy ", 0, 4, false) == 0)
                          {
                            switch (chars[6])
                              {
                                case 'f':
                                    if ((String.Compare(chars, 7, "og", 0, 2, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_heavy_x20_fog;
                                    break;
                                case 'r':
                                    if ((String.Compare(chars, 7, "ain shower", 0, 10, false) == 0) && (chars.Length == 17))
                                        return TypeValueKnownValues.Value_heavy_x20_rain_x20_shower;
                                    break;
                                case 's':
                                    if (String.Compare(chars, 7, "now", 0, 3, false) == 0)
                                      {
                                        switch (chars[10])
                                          {
                                            case ' ':
                                                if ((String.Compare(chars, 11, "and fog", 0, 7, false) == 0) && (chars.Length == 18))
                                                    return TypeValueKnownValues.Value_heavy_x20_snow_x20_and_x20_fog;
                                                break;
                                            case '/':
                                                if ((String.Compare(chars, 11, "fog", 0, 3, false) == 0) && (chars.Length == 14))
                                                    return TypeValueKnownValues.Value_heavy_x20_snow_x2f_fog;
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
                break;
            case 'i':
                if ((String.Compare(chars, 1, "ntermittent clouds", 0, 18, false) == 0) && (chars.Length == 19))
                    return TypeValueKnownValues.Value_intermittent_x20_clouds;
                break;
            case 'l':
                if (String.Compare(chars, 1, "ight ", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'f':
                            if ((String.Compare(chars, 7, "og", 0, 2, false) == 0) && (chars.Length == 9))
                                return TypeValueKnownValues.Value_light_x20_fog;
                            break;
                        case 'r':
                            if ((String.Compare(chars, 7, "ain shower", 0, 10, false) == 0) && (chars.Length == 17))
                                return TypeValueKnownValues.Value_light_x20_rain_x20_shower;
                            break;
                        case 's':
                            if (String.Compare(chars, 7, "now", 0, 3, false) == 0)
                              {
                                switch (chars[10])
                                  {
                                    case ' ':
                                        if ((String.Compare(chars, 11, "and fog", 0, 7, false) == 0) && (chars.Length == 18))
                                            return TypeValueKnownValues.Value_light_x20_snow_x20_and_x20_fog;
                                        break;
                                    case '/':
                                        if ((String.Compare(chars, 11, "fog", 0, 3, false) == 0) && (chars.Length == 14))
                                            return TypeValueKnownValues.Value_light_x20_snow_x2f_fog;
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
            case 'm':
                if (String.Compare(chars, 1, "ostly ", 0, 6, false) == 0)
                  {
                    switch (chars[7])
                      {
                        case 'c':
                            if (String.Compare(chars, 8, "l", 0, 1, false) == 0)
                              {
                                switch (chars[9])
                                  {
                                    case 'e':
                                        if ((String.Compare(chars, 10, "ar", 0, 2, false) == 0) && (chars.Length == 12))
                                            return TypeValueKnownValues.Value_mostly_x20_clear;
                                        break;
                                    case 'o':
                                        if (String.Compare(chars, 10, "udy", 0, 3, false) == 0)
                                          {
                                            if (chars.Length == 13)
                                              {
                                                return TypeValueKnownValues.Value_mostly_x20_cloudy;
                                              }
                                            switch (chars[13])
                                              {
                                                case ' ':
                                                    if (String.Compare(chars, 14, "w/ ", 0, 3, false) == 0)
                                                      {
                                                        switch (chars[17])
                                                          {
                                                            case 'f':
                                                                if ((String.Compare(chars, 18, "lurries", 0, 7, false) == 0) && (chars.Length == 25))
                                                                    return TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_flurries;
                                                                break;
                                                            case 's':
                                                                switch (chars[18])
                                                                  {
                                                                    case 'h':
                                                                        if ((String.Compare(chars, 19, "owers", 0, 5, false) == 0) && (chars.Length == 24))
                                                                            return TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_showers;
                                                                        break;
                                                                    case 'n':
                                                                        if ((String.Compare(chars, 19, "ow", 0, 2, false) == 0) && (chars.Length == 21))
                                                                            return TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_snow;
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                                break;
                                                            case 't':
                                                                if ((String.Compare(chars, 18, "-storms", 0, 7, false) == 0) && (chars.Length == 25))
                                                                    return TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_t_storms;
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
                              }
                            break;
                        case 's':
                            if ((String.Compare(chars, 8, "unny", 0, 4, false) == 0) && (chars.Length == 12))
                                return TypeValueKnownValues.Value_mostly_x20_sunny;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'o':
                if (String.Compare(chars, 1, "vercast", 0, 7, false) == 0)
                  {
                    if (chars.Length == 8)
                      {
                        return TypeValueKnownValues.Value_overcast;
                      }
                    switch (chars[8])
                      {
                        case ' ':
                            if (String.Compare(chars, 9, "with ", 0, 5, false) == 0)
                              {
                                switch (chars[14])
                                  {
                                    case 'l':
                                        if (String.Compare(chars, 15, "ight ", 0, 5, false) == 0)
                                          {
                                            switch (chars[20])
                                              {
                                                case 'r':
                                                    if ((String.Compare(chars, 21, "ain", 0, 3, false) == 0) && (chars.Length == 24))
                                                        return TypeValueKnownValues.Value_overcast_x20_with_x20_light_x20_rain;
                                                    break;
                                                case 's':
                                                    if ((String.Compare(chars, 21, "now", 0, 3, false) == 0) && (chars.Length == 24))
                                                        return TypeValueKnownValues.Value_overcast_x20_with_x20_light_x20_snow;
                                                    break;
                                                case 'w':
                                                    if ((String.Compare(chars, 21, "et snow", 0, 7, false) == 0) && (chars.Length == 28))
                                                        return TypeValueKnownValues.Value_overcast_x20_with_x20_light_x20_wet_x20_snow;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'r':
                                        if ((String.Compare(chars, 15, "ain", 0, 3, false) == 0) && (chars.Length == 18))
                                            return TypeValueKnownValues.Value_overcast_x20_with_x20_rain;
                                        break;
                                    case 's':
                                        switch (chars[15])
                                          {
                                            case 'h':
                                                if ((String.Compare(chars, 16, "owers", 0, 5, false) == 0) && (chars.Length == 21))
                                                    return TypeValueKnownValues.Value_overcast_x20_with_x20_showers;
                                                break;
                                            case 'n':
                                                if (String.Compare(chars, 16, "ow", 0, 2, false) == 0)
                                                  {
                                                    if (chars.Length == 18)
                                                      {
                                                        return TypeValueKnownValues.Value_overcast_x20_with_x20_snow;
                                                      }
                                                    switch (chars[18])
                                                      {
                                                        case ' ':
                                                            if ((String.Compare(chars, 19, "showers", 0, 7, false) == 0) && (chars.Length == 26))
                                                                return TypeValueKnownValues.Value_overcast_x20_with_x20_snow_x20_showers;
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
                                    case 'w':
                                        if (String.Compare(chars, 15, "et snow", 0, 7, false) == 0)
                                          {
                                            if (chars.Length == 22)
                                              {
                                                return TypeValueKnownValues.Value_overcast_x20_with_x20_wet_x20_snow;
                                              }
                                            switch (chars[22])
                                              {
                                                case ' ':
                                                    if ((String.Compare(chars, 23, "showers", 0, 7, false) == 0) && (chars.Length == 30))
                                                        return TypeValueKnownValues.Value_overcast_x20_with_x20_wet_x20_snow_x20_showers;
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
                        case ',':
                            if ((String.Compare(chars, 9, " thunderstorms with rain", 0, 24, false) == 0) && (chars.Length == 33))
                                return TypeValueKnownValues.Value_overcast_x2c__x20_thunderstorms_x20_with_x20_rain;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'p':
                if (String.Compare(chars, 1, "artly ", 0, 6, false) == 0)
                  {
                    switch (chars[7])
                      {
                        case 'c':
                            if (String.Compare(chars, 8, "loudy", 0, 5, false) == 0)
                              {
                                if (chars.Length == 13)
                                  {
                                    return TypeValueKnownValues.Value_partly_x20_cloudy;
                                  }
                                switch (chars[13])
                                  {
                                    case ' ':
                                        if (String.Compare(chars, 14, "w", 0, 1, false) == 0)
                                          {
                                            switch (chars[15])
                                              {
                                                case '/':
                                                    if (String.Compare(chars, 16, " ", 0, 1, false) == 0)
                                                      {
                                                        switch (chars[17])
                                                          {
                                                            case 'f':
                                                                if ((String.Compare(chars, 18, "lurries", 0, 7, false) == 0) && (chars.Length == 25))
                                                                    return TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_flurries;
                                                                break;
                                                            case 's':
                                                                switch (chars[18])
                                                                  {
                                                                    case 'h':
                                                                        if ((String.Compare(chars, 19, "owers", 0, 5, false) == 0) && (chars.Length == 24))
                                                                            return TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_showers;
                                                                        break;
                                                                    case 'n':
                                                                        if ((String.Compare(chars, 19, "ow", 0, 2, false) == 0) && (chars.Length == 21))
                                                                            return TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_snow;
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                                break;
                                                            case 't':
                                                                if ((String.Compare(chars, 18, "-storms", 0, 7, false) == 0) && (chars.Length == 25))
                                                                    return TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_t_storms;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'i':
                                                    if (String.Compare(chars, 16, "th ", 0, 3, false) == 0)
                                                      {
                                                        switch (chars[19])
                                                          {
                                                            case 'l':
                                                                if (String.Compare(chars, 20, "ight ", 0, 5, false) == 0)
                                                                  {
                                                                    switch (chars[25])
                                                                      {
                                                                        case 'r':
                                                                            if ((String.Compare(chars, 26, "ain", 0, 3, false) == 0) && (chars.Length == 29))
                                                                                return TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_light_x20_rain;
                                                                            break;
                                                                        case 's':
                                                                            if ((String.Compare(chars, 26, "now", 0, 3, false) == 0) && (chars.Length == 29))
                                                                                return TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_light_x20_snow;
                                                                            break;
                                                                        case 'w':
                                                                            if ((String.Compare(chars, 26, "et snow", 0, 7, false) == 0) && (chars.Length == 33))
                                                                                return TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_light_x20_wet_x20_snow;
                                                                            break;
                                                                        default:
                                                                            break;
                                                                      }
                                                                  }
                                                                break;
                                                            case 's':
                                                                switch (chars[20])
                                                                  {
                                                                    case 'h':
                                                                        if ((String.Compare(chars, 21, "owers", 0, 5, false) == 0) && (chars.Length == 26))
                                                                            return TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_showers;
                                                                        break;
                                                                    case 'n':
                                                                        if ((String.Compare(chars, 21, "ow showers", 0, 10, false) == 0) && (chars.Length == 31))
                                                                            return TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_snow_x20_showers;
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                                break;
                                                            case 'w':
                                                                if ((String.Compare(chars, 20, "et snow showers", 0, 15, false) == 0) && (chars.Length == 35))
                                                                    return TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_wet_x20_snow_x20_showers;
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
                                    case ',':
                                        if ((String.Compare(chars, 14, " possible thunderstorms with rain", 0, 33, false) == 0) && (chars.Length == 47))
                                            return TypeValueKnownValues.Value_partly_x20_cloudy_x2c__x20_possible_x20_thunderstorms_x20_with_x20_rain;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            if (String.Compare(chars, 8, "unny", 0, 4, false) == 0)
                              {
                                if (chars.Length == 12)
                                  {
                                    return TypeValueKnownValues.Value_partly_x20_sunny;
                                  }
                                switch (chars[12])
                                  {
                                    case ' ':
                                        if (String.Compare(chars, 13, "w/ ", 0, 3, false) == 0)
                                          {
                                            switch (chars[16])
                                              {
                                                case 'f':
                                                    if ((String.Compare(chars, 17, "lurries", 0, 7, false) == 0) && (chars.Length == 24))
                                                        return TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_flurries;
                                                    break;
                                                case 's':
                                                    switch (chars[17])
                                                      {
                                                        case 'h':
                                                            if ((String.Compare(chars, 18, "owers", 0, 5, false) == 0) && (chars.Length == 23))
                                                                return TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_showers;
                                                            break;
                                                        case 'n':
                                                            if ((String.Compare(chars, 18, "ow", 0, 2, false) == 0) && (chars.Length == 20))
                                                                return TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_snow;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                    break;
                                                case 't':
                                                    if ((String.Compare(chars, 17, "-storms", 0, 7, false) == 0) && (chars.Length == 24))
                                                        return TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_t_storms;
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
                  }
                break;
            case 'r':
                if (String.Compare(chars, 1, "ain", 0, 3, false) == 0)
                  {
                    if (chars.Length == 4)
                      {
                        return TypeValueKnownValues.Value_rain;
                      }
                    switch (chars[4])
                      {
                        case ' ':
                            if ((String.Compare(chars, 5, "and snow", 0, 8, false) == 0) && (chars.Length == 13))
                                return TypeValueKnownValues.Value_rain_x20_and_x20_snow;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 's':
                switch (chars[1])
                  {
                    case 'c':
                        if ((String.Compare(chars, 2, "attered clouds", 0, 14, false) == 0) && (chars.Length == 16))
                            return TypeValueKnownValues.Value_scattered_x20_clouds;
                        break;
                    case 'h':
                        if (String.Compare(chars, 2, "ower", 0, 4, false) == 0)
                          {
                            if (chars.Length == 6)
                              {
                                return TypeValueKnownValues.Value_shower;
                              }
                            switch (chars[6])
                              {
                                case 's':
                                    if (chars.Length == 7)
                                        return TypeValueKnownValues.Value_showers;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'l':
                        if ((String.Compare(chars, 2, "eet", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValueKnownValues.Value_sleet;
                        break;
                    case 'n':
                        if (String.Compare(chars, 2, "ow", 0, 2, false) == 0)
                          {
                            if (chars.Length == 4)
                              {
                                return TypeValueKnownValues.Value_snow;
                              }
                            switch (chars[4])
                              {
                                case ' ':
                                    if ((String.Compare(chars, 5, "and fog", 0, 7, false) == 0) && (chars.Length == 12))
                                        return TypeValueKnownValues.Value_snow_x20_and_x20_fog;
                                    break;
                                case '/':
                                    if ((String.Compare(chars, 5, "fog", 0, 3, false) == 0) && (chars.Length == 8))
                                        return TypeValueKnownValues.Value_snow_x2f_fog;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "me clouds", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypeValueKnownValues.Value_some_x20_clouds;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "nny", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValueKnownValues.Value_sunny;
                        break;
                    default:
                        break;
                  }
                break;
            case 't':
                if (String.Compare(chars, 1, "h", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'i':
                            if ((String.Compare(chars, 3, "n high clouds", 0, 13, false) == 0) && (chars.Length == 16))
                                return TypeValueKnownValues.Value_thin_x20_high_x20_clouds;
                            break;
                        case 'u':
                            if (String.Compare(chars, 3, "nderstorm", 0, 9, false) == 0)
                              {
                                if (chars.Length == 12)
                                  {
                                    return TypeValueKnownValues.Value_thunderstorm;
                                  }
                                switch (chars[12])
                                  {
                                    case 's':
                                        if (chars.Length == 13)
                                            return TypeValueKnownValues.Value_thunderstorms;
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
            case 'u':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeValueKnownValues.Value_unknown;
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
            case TypeValueKnownValues.Value_dreary:
                return "dreary";
            case TypeValueKnownValues.Value_a_x20_shower:
                return "a shower";
            case TypeValueKnownValues.Value_shower:
                return "shower";
            case TypeValueKnownValues.Value_showers:
                return "showers";
            case TypeValueKnownValues.Value_heavy_x20_rain_x20_shower:
                return "heavy rain shower";
            case TypeValueKnownValues.Value_light_x20_rain_x20_shower:
                return "light rain shower";
            case TypeValueKnownValues.Value_chance_x20_of_x20_flurries:
                return "chance of flurries";
            case TypeValueKnownValues.Value_chance_x20_of_x20_rain:
                return "chance of rain";
            case TypeValueKnownValues.Value_chance_x20_rain:
                return "chance rain";
            case TypeValueKnownValues.Value_chance_x20_of_x20_freezing_x20_rain:
                return "chance of freezing rain";
            case TypeValueKnownValues.Value_chance_x20_of_x20_sleet:
                return "chance of sleet";
            case TypeValueKnownValues.Value_chance_x20_of_x20_snow:
                return "chance of snow";
            case TypeValueKnownValues.Value_chance_x20_of_x20_thunderstorms:
                return "chance of thunderstorms";
            case TypeValueKnownValues.Value_chance_x20_of_x20_a_x20_thunderstorm:
                return "chance of a thunderstorm";
            case TypeValueKnownValues.Value_clear:
                return "clear";
            case TypeValueKnownValues.Value_cloudy:
                return "cloudy";
            case TypeValueKnownValues.Value_some_x20_clouds:
                return "some clouds";
            case TypeValueKnownValues.Value_flurries:
                return "flurries";
            case TypeValueKnownValues.Value_light_x20_fog:
                return "light fog";
            case TypeValueKnownValues.Value_fog:
                return "fog";
            case TypeValueKnownValues.Value_heavy_x20_fog:
                return "heavy fog";
            case TypeValueKnownValues.Value_haze:
                return "haze";
            case TypeValueKnownValues.Value_light_x20_snow_x2f_fog:
                return "light snow/fog";
            case TypeValueKnownValues.Value_light_x20_snow_x20_and_x20_fog:
                return "light snow and fog";
            case TypeValueKnownValues.Value_snow_x2f_fog:
                return "snow/fog";
            case TypeValueKnownValues.Value_snow_x20_and_x20_fog:
                return "snow and fog";
            case TypeValueKnownValues.Value_heavy_x20_snow_x2f_fog:
                return "heavy snow/fog";
            case TypeValueKnownValues.Value_heavy_x20_snow_x20_and_x20_fog:
                return "heavy snow and fog";
            case TypeValueKnownValues.Value_mostly_x20_cloudy:
                return "mostly cloudy";
            case TypeValueKnownValues.Value_mostly_x20_sunny:
                return "mostly sunny";
            case TypeValueKnownValues.Value_mostly_x20_clear:
                return "mostly clear";
            case TypeValueKnownValues.Value_partly_x20_cloudy:
                return "partly cloudy";
            case TypeValueKnownValues.Value_partly_x20_sunny:
                return "partly sunny";
            case TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_showers:
                return "partly sunny w/ showers";
            case TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_showers:
                return "mostly cloudy w/ showers";
            case TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_showers:
                return "partly cloudy w/ showers";
            case TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_t_storms:
                return "partly sunny w/ t-storms";
            case TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_t_storms:
                return "mostly cloudy w/ t-storms";
            case TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_t_storms:
                return "partly cloudy w/ t-storms";
            case TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_flurries:
                return "partly sunny w/ flurries";
            case TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_flurries:
                return "mostly cloudy w/ flurries";
            case TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_flurries:
                return "partly cloudy w/ flurries";
            case TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_snow:
                return "partly sunny w/ snow";
            case TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_snow:
                return "mostly cloudy w/ snow";
            case TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_snow:
                return "partly cloudy w/ snow";
            case TypeValueKnownValues.Value_intermittent_x20_clouds:
                return "intermittent clouds";
            case TypeValueKnownValues.Value_freezing_x20_rain:
                return "freezing rain";
            case TypeValueKnownValues.Value_rain:
                return "rain";
            case TypeValueKnownValues.Value_rain_x20_and_x20_snow:
                return "rain and snow";
            case TypeValueKnownValues.Value_sleet:
                return "sleet";
            case TypeValueKnownValues.Value_snow:
                return "snow";
            case TypeValueKnownValues.Value_sunny:
                return "sunny";
            case TypeValueKnownValues.Value_clouds_x20_and_x20_sun:
                return "clouds and sun";
            case TypeValueKnownValues.Value_thunderstorms:
                return "thunderstorms";
            case TypeValueKnownValues.Value_thunderstorm:
                return "thunderstorm";
            case TypeValueKnownValues.Value_overcast:
                return "overcast";
            case TypeValueKnownValues.Value_scattered_x20_clouds:
                return "scattered clouds";
            case TypeValueKnownValues.Value_thin_x20_high_x20_clouds:
                return "thin high clouds";
            case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_light_x20_rain:
                return "partly cloudy with light rain";
            case TypeValueKnownValues.Value_cloudy_x20_with_x20_light_x20_rain:
                return "cloudy with light rain";
            case TypeValueKnownValues.Value_overcast_x20_with_x20_light_x20_rain:
                return "overcast with light rain";
            case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_showers:
                return "partly cloudy with showers";
            case TypeValueKnownValues.Value_cloudy_x20_with_x20_showers:
                return "cloudy with showers";
            case TypeValueKnownValues.Value_overcast_x20_with_x20_showers:
                return "overcast with showers";
            case TypeValueKnownValues.Value_overcast_x20_with_x20_rain:
                return "overcast with rain";
            case TypeValueKnownValues.Value_partly_x20_cloudy_x2c__x20_possible_x20_thunderstorms_x20_with_x20_rain:
                return "partly cloudy, possible thunderstorms with rain";
            case TypeValueKnownValues.Value_cloudy_x2c__x20_thunderstorms_x20_with_x20_rain:
                return "cloudy, thunderstorms with rain";
            case TypeValueKnownValues.Value_overcast_x2c__x20_thunderstorms_x20_with_x20_rain:
                return "overcast, thunderstorms with rain";
            case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_light_x20_wet_x20_snow:
                return "partly cloudy with light wet snow";
            case TypeValueKnownValues.Value_cloudy_x20_with_x20_light_x20_wet_x20_snow:
                return "cloudy with light wet snow";
            case TypeValueKnownValues.Value_overcast_x20_with_x20_light_x20_wet_x20_snow:
                return "overcast with light wet snow";
            case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_wet_x20_snow_x20_showers:
                return "partly cloudy with wet snow showers";
            case TypeValueKnownValues.Value_cloudy_x20_with_x20_wet_x20_snow_x20_showers:
                return "cloudy with wet snow showers";
            case TypeValueKnownValues.Value_overcast_x20_with_x20_wet_x20_snow_x20_showers:
                return "overcast with wet snow showers";
            case TypeValueKnownValues.Value_overcast_x20_with_x20_wet_x20_snow:
                return "overcast with wet snow";
            case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_light_x20_snow:
                return "partly cloudy with light snow";
            case TypeValueKnownValues.Value_cloudy_x20_with_x20_light_x20_snow:
                return "cloudy with light snow";
            case TypeValueKnownValues.Value_overcast_x20_with_x20_light_x20_snow:
                return "overcast with light snow";
            case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_snow_x20_showers:
                return "partly cloudy with snow showers";
            case TypeValueKnownValues.Value_cloudy_x20_with_x20_snow_x20_showers:
                return "cloudy with snow showers";
            case TypeValueKnownValues.Value_overcast_x20_with_x20_snow_x20_showers:
                return "overcast with snow showers";
            case TypeValueKnownValues.Value_overcast_x20_with_x20_snow:
                return "overcast with snow";
            case TypeValueKnownValues.Value_unknown:
                return "unknown";
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
            throw new Exception("The value for field Value of ForecastShortPhraseJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'a':
                if ((String.Compare(json_string.getData(), 1, " shower", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_a_x20_shower;
                        goto open_enum_is_done;
                      }
                break;
            case 'c':
                switch (json_string.getData()[1])
                  {
                    case 'h':
                        if (String.Compare(json_string.getData(), 2, "ance ", 0, 5, false) == 0)
                          {
                            switch (json_string.getData()[7])
                              {
                                case 'o':
                                    if (String.Compare(json_string.getData(), 8, "f ", 0, 2, false) == 0)
                                      {
                                        switch (json_string.getData()[10])
                                          {
                                            case 'a':
                                                if ((String.Compare(json_string.getData(), 11, " thunderstorm", 0, 13, false) == 0) && (json_string.getData().Length == 24))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_chance_x20_of_x20_a_x20_thunderstorm;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'f':
                                                switch (json_string.getData()[11])
                                                  {
                                                    case 'l':
                                                        if ((String.Compare(json_string.getData(), 12, "urries", 0, 6, false) == 0) && (json_string.getData().Length == 18))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_chance_x20_of_x20_flurries;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'r':
                                                        if ((String.Compare(json_string.getData(), 12, "eezing rain", 0, 11, false) == 0) && (json_string.getData().Length == 23))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_chance_x20_of_x20_freezing_x20_rain;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'r':
                                                if ((String.Compare(json_string.getData(), 11, "ain", 0, 3, false) == 0) && (json_string.getData().Length == 14))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_chance_x20_of_x20_rain;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 's':
                                                switch (json_string.getData()[11])
                                                  {
                                                    case 'l':
                                                        if ((String.Compare(json_string.getData(), 12, "eet", 0, 3, false) == 0) && (json_string.getData().Length == 15))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_chance_x20_of_x20_sleet;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'n':
                                                        if ((String.Compare(json_string.getData(), 12, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 14))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_chance_x20_of_x20_snow;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 't':
                                                if ((String.Compare(json_string.getData(), 11, "hunderstorms", 0, 12, false) == 0) && (json_string.getData().Length == 23))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_chance_x20_of_x20_thunderstorms;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'r':
                                    if ((String.Compare(json_string.getData(), 8, "ain", 0, 3, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_chance_x20_rain;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'l':
                        switch (json_string.getData()[2])
                          {
                            case 'e':
                                if ((String.Compare(json_string.getData(), 3, "ar", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_clear;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'o':
                                if (String.Compare(json_string.getData(), 3, "ud", 0, 2, false) == 0)
                                  {
                                    switch (json_string.getData()[5])
                                      {
                                        case 's':
                                            if ((String.Compare(json_string.getData(), 6, " and sun", 0, 8, false) == 0) && (json_string.getData().Length == 14))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_clouds_x20_and_x20_sun;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'y':
                                            if (json_string.getData().Length == 6)
                                              {
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_cloudy;
                                                    goto open_enum_is_done;
                                                  }
                                              }
                                            switch (json_string.getData()[6])
                                              {
                                                case ' ':
                                                    if (String.Compare(json_string.getData(), 7, "with ", 0, 5, false) == 0)
                                                      {
                                                        switch (json_string.getData()[12])
                                                          {
                                                            case 'l':
                                                                if (String.Compare(json_string.getData(), 13, "ight ", 0, 5, false) == 0)
                                                                  {
                                                                    switch (json_string.getData()[18])
                                                                      {
                                                                        case 'r':
                                                                            if ((String.Compare(json_string.getData(), 19, "ain", 0, 3, false) == 0) && (json_string.getData().Length == 22))
                                                                                  {
                                                                                    the_open_enum.in_known_list = true;
                                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_cloudy_x20_with_x20_light_x20_rain;
                                                                                    goto open_enum_is_done;
                                                                                  }
                                                                            break;
                                                                        case 's':
                                                                            if ((String.Compare(json_string.getData(), 19, "now", 0, 3, false) == 0) && (json_string.getData().Length == 22))
                                                                                  {
                                                                                    the_open_enum.in_known_list = true;
                                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_cloudy_x20_with_x20_light_x20_snow;
                                                                                    goto open_enum_is_done;
                                                                                  }
                                                                            break;
                                                                        case 'w':
                                                                            if ((String.Compare(json_string.getData(), 19, "et snow", 0, 7, false) == 0) && (json_string.getData().Length == 26))
                                                                                  {
                                                                                    the_open_enum.in_known_list = true;
                                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_cloudy_x20_with_x20_light_x20_wet_x20_snow;
                                                                                    goto open_enum_is_done;
                                                                                  }
                                                                            break;
                                                                        default:
                                                                            break;
                                                                      }
                                                                  }
                                                                break;
                                                            case 's':
                                                                switch (json_string.getData()[13])
                                                                  {
                                                                    case 'h':
                                                                        if ((String.Compare(json_string.getData(), 14, "owers", 0, 5, false) == 0) && (json_string.getData().Length == 19))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_cloudy_x20_with_x20_showers;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    case 'n':
                                                                        if ((String.Compare(json_string.getData(), 14, "ow showers", 0, 10, false) == 0) && (json_string.getData().Length == 24))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_cloudy_x20_with_x20_snow_x20_showers;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                                break;
                                                            case 'w':
                                                                if ((String.Compare(json_string.getData(), 13, "et snow showers", 0, 15, false) == 0) && (json_string.getData().Length == 28))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_cloudy_x20_with_x20_wet_x20_snow_x20_showers;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case ',':
                                                    if ((String.Compare(json_string.getData(), 7, " thunderstorms with rain", 0, 24, false) == 0) && (json_string.getData().Length == 31))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_cloudy_x2c__x20_thunderstorms_x20_with_x20_rain;
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
                        break;
                    default:
                        break;
                  }
                break;
            case 'd':
                if ((String.Compare(json_string.getData(), 1, "reary", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_dreary;
                        goto open_enum_is_done;
                      }
                break;
            case 'f':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "urries", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_flurries;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "g", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_fog;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "eezing rain", 0, 11, false) == 0) && (json_string.getData().Length == 13))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_freezing_x20_rain;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'h':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "ze", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_haze;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "avy ", 0, 4, false) == 0)
                          {
                            switch (json_string.getData()[6])
                              {
                                case 'f':
                                    if ((String.Compare(json_string.getData(), 7, "og", 0, 2, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_fog;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'r':
                                    if ((String.Compare(json_string.getData(), 7, "ain shower", 0, 10, false) == 0) && (json_string.getData().Length == 17))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_rain_x20_shower;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 's':
                                    if (String.Compare(json_string.getData(), 7, "now", 0, 3, false) == 0)
                                      {
                                        switch (json_string.getData()[10])
                                          {
                                            case ' ':
                                                if ((String.Compare(json_string.getData(), 11, "and fog", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_snow_x20_and_x20_fog;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case '/':
                                                if ((String.Compare(json_string.getData(), 11, "fog", 0, 3, false) == 0) && (json_string.getData().Length == 14))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_snow_x2f_fog;
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
                    default:
                        break;
                  }
                break;
            case 'i':
                if ((String.Compare(json_string.getData(), 1, "ntermittent clouds", 0, 18, false) == 0) && (json_string.getData().Length == 19))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_intermittent_x20_clouds;
                        goto open_enum_is_done;
                      }
                break;
            case 'l':
                if (String.Compare(json_string.getData(), 1, "ight ", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'f':
                            if ((String.Compare(json_string.getData(), 7, "og", 0, 2, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_fog;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'r':
                            if ((String.Compare(json_string.getData(), 7, "ain shower", 0, 10, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_rain_x20_shower;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 's':
                            if (String.Compare(json_string.getData(), 7, "now", 0, 3, false) == 0)
                              {
                                switch (json_string.getData()[10])
                                  {
                                    case ' ':
                                        if ((String.Compare(json_string.getData(), 11, "and fog", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_snow_x20_and_x20_fog;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case '/':
                                        if ((String.Compare(json_string.getData(), 11, "fog", 0, 3, false) == 0) && (json_string.getData().Length == 14))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_snow_x2f_fog;
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
            case 'm':
                if (String.Compare(json_string.getData(), 1, "ostly ", 0, 6, false) == 0)
                  {
                    switch (json_string.getData()[7])
                      {
                        case 'c':
                            if (String.Compare(json_string.getData(), 8, "l", 0, 1, false) == 0)
                              {
                                switch (json_string.getData()[9])
                                  {
                                    case 'e':
                                        if ((String.Compare(json_string.getData(), 10, "ar", 0, 2, false) == 0) && (json_string.getData().Length == 12))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_mostly_x20_clear;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'o':
                                        if (String.Compare(json_string.getData(), 10, "udy", 0, 3, false) == 0)
                                          {
                                            if (json_string.getData().Length == 13)
                                              {
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_mostly_x20_cloudy;
                                                    goto open_enum_is_done;
                                                  }
                                              }
                                            switch (json_string.getData()[13])
                                              {
                                                case ' ':
                                                    if (String.Compare(json_string.getData(), 14, "w/ ", 0, 3, false) == 0)
                                                      {
                                                        switch (json_string.getData()[17])
                                                          {
                                                            case 'f':
                                                                if ((String.Compare(json_string.getData(), 18, "lurries", 0, 7, false) == 0) && (json_string.getData().Length == 25))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_flurries;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 's':
                                                                switch (json_string.getData()[18])
                                                                  {
                                                                    case 'h':
                                                                        if ((String.Compare(json_string.getData(), 19, "owers", 0, 5, false) == 0) && (json_string.getData().Length == 24))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_showers;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    case 'n':
                                                                        if ((String.Compare(json_string.getData(), 19, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 21))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_snow;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                                break;
                                                            case 't':
                                                                if ((String.Compare(json_string.getData(), 18, "-storms", 0, 7, false) == 0) && (json_string.getData().Length == 25))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_t_storms;
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
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            if ((String.Compare(json_string.getData(), 8, "unny", 0, 4, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_mostly_x20_sunny;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'o':
                if (String.Compare(json_string.getData(), 1, "vercast", 0, 7, false) == 0)
                  {
                    if (json_string.getData().Length == 8)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeValueKnownValues.Value_overcast;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[8])
                      {
                        case ' ':
                            if (String.Compare(json_string.getData(), 9, "with ", 0, 5, false) == 0)
                              {
                                switch (json_string.getData()[14])
                                  {
                                    case 'l':
                                        if (String.Compare(json_string.getData(), 15, "ight ", 0, 5, false) == 0)
                                          {
                                            switch (json_string.getData()[20])
                                              {
                                                case 'r':
                                                    if ((String.Compare(json_string.getData(), 21, "ain", 0, 3, false) == 0) && (json_string.getData().Length == 24))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_overcast_x20_with_x20_light_x20_rain;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 's':
                                                    if ((String.Compare(json_string.getData(), 21, "now", 0, 3, false) == 0) && (json_string.getData().Length == 24))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_overcast_x20_with_x20_light_x20_snow;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'w':
                                                    if ((String.Compare(json_string.getData(), 21, "et snow", 0, 7, false) == 0) && (json_string.getData().Length == 28))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_overcast_x20_with_x20_light_x20_wet_x20_snow;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'r':
                                        if ((String.Compare(json_string.getData(), 15, "ain", 0, 3, false) == 0) && (json_string.getData().Length == 18))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_overcast_x20_with_x20_rain;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 's':
                                        switch (json_string.getData()[15])
                                          {
                                            case 'h':
                                                if ((String.Compare(json_string.getData(), 16, "owers", 0, 5, false) == 0) && (json_string.getData().Length == 21))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_overcast_x20_with_x20_showers;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'n':
                                                if (String.Compare(json_string.getData(), 16, "ow", 0, 2, false) == 0)
                                                  {
                                                    if (json_string.getData().Length == 18)
                                                      {
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_overcast_x20_with_x20_snow;
                                                            goto open_enum_is_done;
                                                          }
                                                      }
                                                    switch (json_string.getData()[18])
                                                      {
                                                        case ' ':
                                                            if ((String.Compare(json_string.getData(), 19, "showers", 0, 7, false) == 0) && (json_string.getData().Length == 26))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_overcast_x20_with_x20_snow_x20_showers;
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
                                    case 'w':
                                        if (String.Compare(json_string.getData(), 15, "et snow", 0, 7, false) == 0)
                                          {
                                            if (json_string.getData().Length == 22)
                                              {
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_overcast_x20_with_x20_wet_x20_snow;
                                                    goto open_enum_is_done;
                                                  }
                                              }
                                            switch (json_string.getData()[22])
                                              {
                                                case ' ':
                                                    if ((String.Compare(json_string.getData(), 23, "showers", 0, 7, false) == 0) && (json_string.getData().Length == 30))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_overcast_x20_with_x20_wet_x20_snow_x20_showers;
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
                        case ',':
                            if ((String.Compare(json_string.getData(), 9, " thunderstorms with rain", 0, 24, false) == 0) && (json_string.getData().Length == 33))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_overcast_x2c__x20_thunderstorms_x20_with_x20_rain;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'p':
                if (String.Compare(json_string.getData(), 1, "artly ", 0, 6, false) == 0)
                  {
                    switch (json_string.getData()[7])
                      {
                        case 'c':
                            if (String.Compare(json_string.getData(), 8, "loudy", 0, 5, false) == 0)
                              {
                                if (json_string.getData().Length == 13)
                                  {
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_cloudy;
                                        goto open_enum_is_done;
                                      }
                                  }
                                switch (json_string.getData()[13])
                                  {
                                    case ' ':
                                        if (String.Compare(json_string.getData(), 14, "w", 0, 1, false) == 0)
                                          {
                                            switch (json_string.getData()[15])
                                              {
                                                case '/':
                                                    if (String.Compare(json_string.getData(), 16, " ", 0, 1, false) == 0)
                                                      {
                                                        switch (json_string.getData()[17])
                                                          {
                                                            case 'f':
                                                                if ((String.Compare(json_string.getData(), 18, "lurries", 0, 7, false) == 0) && (json_string.getData().Length == 25))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_flurries;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 's':
                                                                switch (json_string.getData()[18])
                                                                  {
                                                                    case 'h':
                                                                        if ((String.Compare(json_string.getData(), 19, "owers", 0, 5, false) == 0) && (json_string.getData().Length == 24))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_showers;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    case 'n':
                                                                        if ((String.Compare(json_string.getData(), 19, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 21))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_snow;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                                break;
                                                            case 't':
                                                                if ((String.Compare(json_string.getData(), 18, "-storms", 0, 7, false) == 0) && (json_string.getData().Length == 25))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_t_storms;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'i':
                                                    if (String.Compare(json_string.getData(), 16, "th ", 0, 3, false) == 0)
                                                      {
                                                        switch (json_string.getData()[19])
                                                          {
                                                            case 'l':
                                                                if (String.Compare(json_string.getData(), 20, "ight ", 0, 5, false) == 0)
                                                                  {
                                                                    switch (json_string.getData()[25])
                                                                      {
                                                                        case 'r':
                                                                            if ((String.Compare(json_string.getData(), 26, "ain", 0, 3, false) == 0) && (json_string.getData().Length == 29))
                                                                                  {
                                                                                    the_open_enum.in_known_list = true;
                                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_light_x20_rain;
                                                                                    goto open_enum_is_done;
                                                                                  }
                                                                            break;
                                                                        case 's':
                                                                            if ((String.Compare(json_string.getData(), 26, "now", 0, 3, false) == 0) && (json_string.getData().Length == 29))
                                                                                  {
                                                                                    the_open_enum.in_known_list = true;
                                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_light_x20_snow;
                                                                                    goto open_enum_is_done;
                                                                                  }
                                                                            break;
                                                                        case 'w':
                                                                            if ((String.Compare(json_string.getData(), 26, "et snow", 0, 7, false) == 0) && (json_string.getData().Length == 33))
                                                                                  {
                                                                                    the_open_enum.in_known_list = true;
                                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_light_x20_wet_x20_snow;
                                                                                    goto open_enum_is_done;
                                                                                  }
                                                                            break;
                                                                        default:
                                                                            break;
                                                                      }
                                                                  }
                                                                break;
                                                            case 's':
                                                                switch (json_string.getData()[20])
                                                                  {
                                                                    case 'h':
                                                                        if ((String.Compare(json_string.getData(), 21, "owers", 0, 5, false) == 0) && (json_string.getData().Length == 26))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_showers;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    case 'n':
                                                                        if ((String.Compare(json_string.getData(), 21, "ow showers", 0, 10, false) == 0) && (json_string.getData().Length == 31))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_snow_x20_showers;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                                break;
                                                            case 'w':
                                                                if ((String.Compare(json_string.getData(), 20, "et snow showers", 0, 15, false) == 0) && (json_string.getData().Length == 35))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_wet_x20_snow_x20_showers;
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
                                    case ',':
                                        if ((String.Compare(json_string.getData(), 14, " possible thunderstorms with rain", 0, 33, false) == 0) && (json_string.getData().Length == 47))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_cloudy_x2c__x20_possible_x20_thunderstorms_x20_with_x20_rain;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            if (String.Compare(json_string.getData(), 8, "unny", 0, 4, false) == 0)
                              {
                                if (json_string.getData().Length == 12)
                                  {
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_sunny;
                                        goto open_enum_is_done;
                                      }
                                  }
                                switch (json_string.getData()[12])
                                  {
                                    case ' ':
                                        if (String.Compare(json_string.getData(), 13, "w/ ", 0, 3, false) == 0)
                                          {
                                            switch (json_string.getData()[16])
                                              {
                                                case 'f':
                                                    if ((String.Compare(json_string.getData(), 17, "lurries", 0, 7, false) == 0) && (json_string.getData().Length == 24))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_flurries;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 's':
                                                    switch (json_string.getData()[17])
                                                      {
                                                        case 'h':
                                                            if ((String.Compare(json_string.getData(), 18, "owers", 0, 5, false) == 0) && (json_string.getData().Length == 23))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_showers;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'n':
                                                            if ((String.Compare(json_string.getData(), 18, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 20))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_snow;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                    break;
                                                case 't':
                                                    if ((String.Compare(json_string.getData(), 17, "-storms", 0, 7, false) == 0) && (json_string.getData().Length == 24))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_t_storms;
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
                        default:
                            break;
                      }
                  }
                break;
            case 'r':
                if (String.Compare(json_string.getData(), 1, "ain", 0, 3, false) == 0)
                  {
                    if (json_string.getData().Length == 4)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeValueKnownValues.Value_rain;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[4])
                      {
                        case ' ':
                            if ((String.Compare(json_string.getData(), 5, "and snow", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_rain_x20_and_x20_snow;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 's':
                switch (json_string.getData()[1])
                  {
                    case 'c':
                        if ((String.Compare(json_string.getData(), 2, "attered clouds", 0, 14, false) == 0) && (json_string.getData().Length == 16))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_scattered_x20_clouds;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'h':
                        if (String.Compare(json_string.getData(), 2, "ower", 0, 4, false) == 0)
                          {
                            if (json_string.getData().Length == 6)
                              {
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_shower;
                                    goto open_enum_is_done;
                                  }
                              }
                            switch (json_string.getData()[6])
                              {
                                case 's':
                                    if (json_string.getData().Length == 7)
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_showers;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "eet", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_sleet;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'n':
                        if (String.Compare(json_string.getData(), 2, "ow", 0, 2, false) == 0)
                          {
                            if (json_string.getData().Length == 4)
                              {
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_snow;
                                    goto open_enum_is_done;
                                  }
                              }
                            switch (json_string.getData()[4])
                              {
                                case ' ':
                                    if ((String.Compare(json_string.getData(), 5, "and fog", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_snow_x20_and_x20_fog;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case '/':
                                    if ((String.Compare(json_string.getData(), 5, "fog", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_snow_x2f_fog;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "me clouds", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_some_x20_clouds;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "nny", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_sunny;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 't':
                if (String.Compare(json_string.getData(), 1, "h", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'i':
                            if ((String.Compare(json_string.getData(), 3, "n high clouds", 0, 13, false) == 0) && (json_string.getData().Length == 16))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_thin_x20_high_x20_clouds;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'u':
                            if (String.Compare(json_string.getData(), 3, "nderstorm", 0, 9, false) == 0)
                              {
                                if (json_string.getData().Length == 12)
                                  {
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_thunderstorm;
                                        goto open_enum_is_done;
                                      }
                                  }
                                switch (json_string.getData()[12])
                                  {
                                    case 's':
                                        if (json_string.getData().Length == 13)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_thunderstorms;
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
            case 'u':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_unknown;
                        goto open_enum_is_done;
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


    public ForecastShortPhraseJSON()
      {
        flagHasValue = false;
      }

    public ForecastShortPhraseJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public ForecastShortPhraseJSON(string init_value)
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

    public ForecastShortPhraseJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_dreary:
                    handler.string_value("dreary");
                    break;
                case TypeValueKnownValues.Value_a_x20_shower:
                    handler.string_value("a shower");
                    break;
                case TypeValueKnownValues.Value_shower:
                    handler.string_value("shower");
                    break;
                case TypeValueKnownValues.Value_showers:
                    handler.string_value("showers");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_rain_x20_shower:
                    handler.string_value("heavy rain shower");
                    break;
                case TypeValueKnownValues.Value_light_x20_rain_x20_shower:
                    handler.string_value("light rain shower");
                    break;
                case TypeValueKnownValues.Value_chance_x20_of_x20_flurries:
                    handler.string_value("chance of flurries");
                    break;
                case TypeValueKnownValues.Value_chance_x20_of_x20_rain:
                    handler.string_value("chance of rain");
                    break;
                case TypeValueKnownValues.Value_chance_x20_rain:
                    handler.string_value("chance rain");
                    break;
                case TypeValueKnownValues.Value_chance_x20_of_x20_freezing_x20_rain:
                    handler.string_value("chance of freezing rain");
                    break;
                case TypeValueKnownValues.Value_chance_x20_of_x20_sleet:
                    handler.string_value("chance of sleet");
                    break;
                case TypeValueKnownValues.Value_chance_x20_of_x20_snow:
                    handler.string_value("chance of snow");
                    break;
                case TypeValueKnownValues.Value_chance_x20_of_x20_thunderstorms:
                    handler.string_value("chance of thunderstorms");
                    break;
                case TypeValueKnownValues.Value_chance_x20_of_x20_a_x20_thunderstorm:
                    handler.string_value("chance of a thunderstorm");
                    break;
                case TypeValueKnownValues.Value_clear:
                    handler.string_value("clear");
                    break;
                case TypeValueKnownValues.Value_cloudy:
                    handler.string_value("cloudy");
                    break;
                case TypeValueKnownValues.Value_some_x20_clouds:
                    handler.string_value("some clouds");
                    break;
                case TypeValueKnownValues.Value_flurries:
                    handler.string_value("flurries");
                    break;
                case TypeValueKnownValues.Value_light_x20_fog:
                    handler.string_value("light fog");
                    break;
                case TypeValueKnownValues.Value_fog:
                    handler.string_value("fog");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_fog:
                    handler.string_value("heavy fog");
                    break;
                case TypeValueKnownValues.Value_haze:
                    handler.string_value("haze");
                    break;
                case TypeValueKnownValues.Value_light_x20_snow_x2f_fog:
                    handler.string_value("light snow/fog");
                    break;
                case TypeValueKnownValues.Value_light_x20_snow_x20_and_x20_fog:
                    handler.string_value("light snow and fog");
                    break;
                case TypeValueKnownValues.Value_snow_x2f_fog:
                    handler.string_value("snow/fog");
                    break;
                case TypeValueKnownValues.Value_snow_x20_and_x20_fog:
                    handler.string_value("snow and fog");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_snow_x2f_fog:
                    handler.string_value("heavy snow/fog");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_snow_x20_and_x20_fog:
                    handler.string_value("heavy snow and fog");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_cloudy:
                    handler.string_value("mostly cloudy");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_sunny:
                    handler.string_value("mostly sunny");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_clear:
                    handler.string_value("mostly clear");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy:
                    handler.string_value("partly cloudy");
                    break;
                case TypeValueKnownValues.Value_partly_x20_sunny:
                    handler.string_value("partly sunny");
                    break;
                case TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_showers:
                    handler.string_value("partly sunny w/ showers");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_showers:
                    handler.string_value("mostly cloudy w/ showers");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_showers:
                    handler.string_value("partly cloudy w/ showers");
                    break;
                case TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_t_storms:
                    handler.string_value("partly sunny w/ t-storms");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_t_storms:
                    handler.string_value("mostly cloudy w/ t-storms");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_t_storms:
                    handler.string_value("partly cloudy w/ t-storms");
                    break;
                case TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_flurries:
                    handler.string_value("partly sunny w/ flurries");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_flurries:
                    handler.string_value("mostly cloudy w/ flurries");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_flurries:
                    handler.string_value("partly cloudy w/ flurries");
                    break;
                case TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_snow:
                    handler.string_value("partly sunny w/ snow");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_snow:
                    handler.string_value("mostly cloudy w/ snow");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_snow:
                    handler.string_value("partly cloudy w/ snow");
                    break;
                case TypeValueKnownValues.Value_intermittent_x20_clouds:
                    handler.string_value("intermittent clouds");
                    break;
                case TypeValueKnownValues.Value_freezing_x20_rain:
                    handler.string_value("freezing rain");
                    break;
                case TypeValueKnownValues.Value_rain:
                    handler.string_value("rain");
                    break;
                case TypeValueKnownValues.Value_rain_x20_and_x20_snow:
                    handler.string_value("rain and snow");
                    break;
                case TypeValueKnownValues.Value_sleet:
                    handler.string_value("sleet");
                    break;
                case TypeValueKnownValues.Value_snow:
                    handler.string_value("snow");
                    break;
                case TypeValueKnownValues.Value_sunny:
                    handler.string_value("sunny");
                    break;
                case TypeValueKnownValues.Value_clouds_x20_and_x20_sun:
                    handler.string_value("clouds and sun");
                    break;
                case TypeValueKnownValues.Value_thunderstorms:
                    handler.string_value("thunderstorms");
                    break;
                case TypeValueKnownValues.Value_thunderstorm:
                    handler.string_value("thunderstorm");
                    break;
                case TypeValueKnownValues.Value_overcast:
                    handler.string_value("overcast");
                    break;
                case TypeValueKnownValues.Value_scattered_x20_clouds:
                    handler.string_value("scattered clouds");
                    break;
                case TypeValueKnownValues.Value_thin_x20_high_x20_clouds:
                    handler.string_value("thin high clouds");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_light_x20_rain:
                    handler.string_value("partly cloudy with light rain");
                    break;
                case TypeValueKnownValues.Value_cloudy_x20_with_x20_light_x20_rain:
                    handler.string_value("cloudy with light rain");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_light_x20_rain:
                    handler.string_value("overcast with light rain");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_showers:
                    handler.string_value("partly cloudy with showers");
                    break;
                case TypeValueKnownValues.Value_cloudy_x20_with_x20_showers:
                    handler.string_value("cloudy with showers");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_showers:
                    handler.string_value("overcast with showers");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_rain:
                    handler.string_value("overcast with rain");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x2c__x20_possible_x20_thunderstorms_x20_with_x20_rain:
                    handler.string_value("partly cloudy, possible thunderstorms with rain");
                    break;
                case TypeValueKnownValues.Value_cloudy_x2c__x20_thunderstorms_x20_with_x20_rain:
                    handler.string_value("cloudy, thunderstorms with rain");
                    break;
                case TypeValueKnownValues.Value_overcast_x2c__x20_thunderstorms_x20_with_x20_rain:
                    handler.string_value("overcast, thunderstorms with rain");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_light_x20_wet_x20_snow:
                    handler.string_value("partly cloudy with light wet snow");
                    break;
                case TypeValueKnownValues.Value_cloudy_x20_with_x20_light_x20_wet_x20_snow:
                    handler.string_value("cloudy with light wet snow");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_light_x20_wet_x20_snow:
                    handler.string_value("overcast with light wet snow");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_wet_x20_snow_x20_showers:
                    handler.string_value("partly cloudy with wet snow showers");
                    break;
                case TypeValueKnownValues.Value_cloudy_x20_with_x20_wet_x20_snow_x20_showers:
                    handler.string_value("cloudy with wet snow showers");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_wet_x20_snow_x20_showers:
                    handler.string_value("overcast with wet snow showers");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_wet_x20_snow:
                    handler.string_value("overcast with wet snow");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_light_x20_snow:
                    handler.string_value("partly cloudy with light snow");
                    break;
                case TypeValueKnownValues.Value_cloudy_x20_with_x20_light_x20_snow:
                    handler.string_value("cloudy with light snow");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_light_x20_snow:
                    handler.string_value("overcast with light snow");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_snow_x20_showers:
                    handler.string_value("partly cloudy with snow showers");
                    break;
                case TypeValueKnownValues.Value_cloudy_x20_with_x20_snow_x20_showers:
                    handler.string_value("cloudy with snow showers");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_snow_x20_showers:
                    handler.string_value("overcast with snow showers");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_snow:
                    handler.string_value("overcast with snow");
                    break;
                case TypeValueKnownValues.Value_unknown:
                    handler.string_value("unknown");
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
                case TypeValueKnownValues.Value_dreary:
                    handler.string_value("dreary");
                    break;
                case TypeValueKnownValues.Value_a_x20_shower:
                    handler.string_value("a shower");
                    break;
                case TypeValueKnownValues.Value_shower:
                    handler.string_value("shower");
                    break;
                case TypeValueKnownValues.Value_showers:
                    handler.string_value("showers");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_rain_x20_shower:
                    handler.string_value("heavy rain shower");
                    break;
                case TypeValueKnownValues.Value_light_x20_rain_x20_shower:
                    handler.string_value("light rain shower");
                    break;
                case TypeValueKnownValues.Value_chance_x20_of_x20_flurries:
                    handler.string_value("chance of flurries");
                    break;
                case TypeValueKnownValues.Value_chance_x20_of_x20_rain:
                    handler.string_value("chance of rain");
                    break;
                case TypeValueKnownValues.Value_chance_x20_rain:
                    handler.string_value("chance rain");
                    break;
                case TypeValueKnownValues.Value_chance_x20_of_x20_freezing_x20_rain:
                    handler.string_value("chance of freezing rain");
                    break;
                case TypeValueKnownValues.Value_chance_x20_of_x20_sleet:
                    handler.string_value("chance of sleet");
                    break;
                case TypeValueKnownValues.Value_chance_x20_of_x20_snow:
                    handler.string_value("chance of snow");
                    break;
                case TypeValueKnownValues.Value_chance_x20_of_x20_thunderstorms:
                    handler.string_value("chance of thunderstorms");
                    break;
                case TypeValueKnownValues.Value_chance_x20_of_x20_a_x20_thunderstorm:
                    handler.string_value("chance of a thunderstorm");
                    break;
                case TypeValueKnownValues.Value_clear:
                    handler.string_value("clear");
                    break;
                case TypeValueKnownValues.Value_cloudy:
                    handler.string_value("cloudy");
                    break;
                case TypeValueKnownValues.Value_some_x20_clouds:
                    handler.string_value("some clouds");
                    break;
                case TypeValueKnownValues.Value_flurries:
                    handler.string_value("flurries");
                    break;
                case TypeValueKnownValues.Value_light_x20_fog:
                    handler.string_value("light fog");
                    break;
                case TypeValueKnownValues.Value_fog:
                    handler.string_value("fog");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_fog:
                    handler.string_value("heavy fog");
                    break;
                case TypeValueKnownValues.Value_haze:
                    handler.string_value("haze");
                    break;
                case TypeValueKnownValues.Value_light_x20_snow_x2f_fog:
                    handler.string_value("light snow/fog");
                    break;
                case TypeValueKnownValues.Value_light_x20_snow_x20_and_x20_fog:
                    handler.string_value("light snow and fog");
                    break;
                case TypeValueKnownValues.Value_snow_x2f_fog:
                    handler.string_value("snow/fog");
                    break;
                case TypeValueKnownValues.Value_snow_x20_and_x20_fog:
                    handler.string_value("snow and fog");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_snow_x2f_fog:
                    handler.string_value("heavy snow/fog");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_snow_x20_and_x20_fog:
                    handler.string_value("heavy snow and fog");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_cloudy:
                    handler.string_value("mostly cloudy");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_sunny:
                    handler.string_value("mostly sunny");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_clear:
                    handler.string_value("mostly clear");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy:
                    handler.string_value("partly cloudy");
                    break;
                case TypeValueKnownValues.Value_partly_x20_sunny:
                    handler.string_value("partly sunny");
                    break;
                case TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_showers:
                    handler.string_value("partly sunny w/ showers");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_showers:
                    handler.string_value("mostly cloudy w/ showers");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_showers:
                    handler.string_value("partly cloudy w/ showers");
                    break;
                case TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_t_storms:
                    handler.string_value("partly sunny w/ t-storms");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_t_storms:
                    handler.string_value("mostly cloudy w/ t-storms");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_t_storms:
                    handler.string_value("partly cloudy w/ t-storms");
                    break;
                case TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_flurries:
                    handler.string_value("partly sunny w/ flurries");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_flurries:
                    handler.string_value("mostly cloudy w/ flurries");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_flurries:
                    handler.string_value("partly cloudy w/ flurries");
                    break;
                case TypeValueKnownValues.Value_partly_x20_sunny_x20_w_x2f__x20_snow:
                    handler.string_value("partly sunny w/ snow");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_cloudy_x20_w_x2f__x20_snow:
                    handler.string_value("mostly cloudy w/ snow");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_w_x2f__x20_snow:
                    handler.string_value("partly cloudy w/ snow");
                    break;
                case TypeValueKnownValues.Value_intermittent_x20_clouds:
                    handler.string_value("intermittent clouds");
                    break;
                case TypeValueKnownValues.Value_freezing_x20_rain:
                    handler.string_value("freezing rain");
                    break;
                case TypeValueKnownValues.Value_rain:
                    handler.string_value("rain");
                    break;
                case TypeValueKnownValues.Value_rain_x20_and_x20_snow:
                    handler.string_value("rain and snow");
                    break;
                case TypeValueKnownValues.Value_sleet:
                    handler.string_value("sleet");
                    break;
                case TypeValueKnownValues.Value_snow:
                    handler.string_value("snow");
                    break;
                case TypeValueKnownValues.Value_sunny:
                    handler.string_value("sunny");
                    break;
                case TypeValueKnownValues.Value_clouds_x20_and_x20_sun:
                    handler.string_value("clouds and sun");
                    break;
                case TypeValueKnownValues.Value_thunderstorms:
                    handler.string_value("thunderstorms");
                    break;
                case TypeValueKnownValues.Value_thunderstorm:
                    handler.string_value("thunderstorm");
                    break;
                case TypeValueKnownValues.Value_overcast:
                    handler.string_value("overcast");
                    break;
                case TypeValueKnownValues.Value_scattered_x20_clouds:
                    handler.string_value("scattered clouds");
                    break;
                case TypeValueKnownValues.Value_thin_x20_high_x20_clouds:
                    handler.string_value("thin high clouds");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_light_x20_rain:
                    handler.string_value("partly cloudy with light rain");
                    break;
                case TypeValueKnownValues.Value_cloudy_x20_with_x20_light_x20_rain:
                    handler.string_value("cloudy with light rain");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_light_x20_rain:
                    handler.string_value("overcast with light rain");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_showers:
                    handler.string_value("partly cloudy with showers");
                    break;
                case TypeValueKnownValues.Value_cloudy_x20_with_x20_showers:
                    handler.string_value("cloudy with showers");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_showers:
                    handler.string_value("overcast with showers");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_rain:
                    handler.string_value("overcast with rain");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x2c__x20_possible_x20_thunderstorms_x20_with_x20_rain:
                    handler.string_value("partly cloudy, possible thunderstorms with rain");
                    break;
                case TypeValueKnownValues.Value_cloudy_x2c__x20_thunderstorms_x20_with_x20_rain:
                    handler.string_value("cloudy, thunderstorms with rain");
                    break;
                case TypeValueKnownValues.Value_overcast_x2c__x20_thunderstorms_x20_with_x20_rain:
                    handler.string_value("overcast, thunderstorms with rain");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_light_x20_wet_x20_snow:
                    handler.string_value("partly cloudy with light wet snow");
                    break;
                case TypeValueKnownValues.Value_cloudy_x20_with_x20_light_x20_wet_x20_snow:
                    handler.string_value("cloudy with light wet snow");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_light_x20_wet_x20_snow:
                    handler.string_value("overcast with light wet snow");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_wet_x20_snow_x20_showers:
                    handler.string_value("partly cloudy with wet snow showers");
                    break;
                case TypeValueKnownValues.Value_cloudy_x20_with_x20_wet_x20_snow_x20_showers:
                    handler.string_value("cloudy with wet snow showers");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_wet_x20_snow_x20_showers:
                    handler.string_value("overcast with wet snow showers");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_wet_x20_snow:
                    handler.string_value("overcast with wet snow");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_light_x20_snow:
                    handler.string_value("partly cloudy with light snow");
                    break;
                case TypeValueKnownValues.Value_cloudy_x20_with_x20_light_x20_snow:
                    handler.string_value("cloudy with light snow");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_light_x20_snow:
                    handler.string_value("overcast with light snow");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy_x20_with_x20_snow_x20_showers:
                    handler.string_value("partly cloudy with snow showers");
                    break;
                case TypeValueKnownValues.Value_cloudy_x20_with_x20_snow_x20_showers:
                    handler.string_value("cloudy with snow showers");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_snow_x20_showers:
                    handler.string_value("overcast with snow showers");
                    break;
                case TypeValueKnownValues.Value_overcast_x20_with_x20_snow:
                    handler.string_value("overcast with snow");
                    break;
                case TypeValueKnownValues.Value_unknown:
                    handler.string_value("unknown");
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

    public static ForecastShortPhraseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ForecastShortPhraseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ForecastShortPhrase", ignore_extras);
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
    public static ForecastShortPhraseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ForecastShortPhraseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ForecastShortPhraseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ForecastShortPhrase", ignore_extras);
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
    public static ForecastShortPhraseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ForecastShortPhraseJSON from_text(string text, bool ignore_extras)
      {
        ForecastShortPhraseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ForecastShortPhrase", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ForecastShortPhraseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ForecastShortPhraseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ForecastShortPhraseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ForecastShortPhrase", ignore_extras);
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
            ForecastShortPhraseJSON result = new ForecastShortPhraseJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(ForecastShortPhraseJSON new_result);
        public Generator(bool ignore_extras) : base("Type ForecastShortPhrase")
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
        protected override void handle_result(ForecastShortPhraseJSON  result)
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
        public ForecastShortPhraseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ForecastShortPhraseJSON  result)
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
    protected virtual void handle_result(List<ForecastShortPhraseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ForecastShortPhraseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ForecastShortPhraseJSON>();
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
    public List<ForecastShortPhraseJSON> value;
  };
  };
