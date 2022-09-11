/* file "CurrentConditionsShortPhraseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CurrentConditionsShortPhraseJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_drizzle,
        Value_rain,
        Value_snow,
        Value_rain_x20_and_x20_snow,
        Value_snow_x20_grains,
        Value_ice_x20_crystals,
        Value_ice_x20_pellets,
        Value_hail,
        Value_mist,
        Value_fog,
        Value_fog_x20_patches,
        Value_light_x20_snow_x2f_fog,
        Value_light_x20_snow_x20_and_x20_fog,
        Value_snow_x2f_fog,
        Value_snow_x20_and_x20_fog,
        Value_heavy_x20_snow_x2f_fog,
        Value_heavy_x20_snow_x20_and_x20_fog,
        Value_smoke,
        Value_volcanic_x20_ash,
        Value_widespread_x20_dust,
        Value_sand,
        Value_haze,
        Value_spray,
        Value_dust_x20_whirls,
        Value_sandstorm,
        Value_low_x20_drifting_x20_snow,
        Value_low_x20_drifting_x20_widespread_x20_dust,
        Value_low_x20_drifting_x20_sand,
        Value_blowing_x20_snow,
        Value_blowing_x20_widespread_x20_dust,
        Value_blowing_x20_sand,
        Value_a_x20_shower,
        Value_shower,
        Value_rain_x20_mist,
        Value_rain_x20_showers,
        Value_heavy_x20_rain_x20_shower,
        Value_light_x20_rain_x20_shower,
        Value_snow_x20_showers,
        Value_snow_x20_blowing,
        Value_snow_x20_mist,
        Value_snow_x20_blowing_x20_snow_x20_mist,
        Value_ice_x20_pellet_x20_showers,
        Value_hail_x20_showers,
        Value_small_x20_hail_x20_showers,
        Value_thunderstorm,
        Value_thunderstorms_x20_and_x20_rain,
        Value_thunderstorms_x20_and_x20_snow,
        Value_thunderstorms_x20_and_x20_ice_x20_pellets,
        Value_thunderstorms_x20_and_x20_hail,
        Value_thunderstorms_x20_and_x20_small_x20_hail,
        Value_freezing_x20_drizzle,
        Value_freezing_x20_rain,
        Value_freezing_x20_fog,
        Value_heavy_x20_drizzle,
        Value_heavy_x20_rain,
        Value_heavy_x20_snow,
        Value_heavy_x20_snow_x20_grains,
        Value_heavy_x20_ice_x20_crystals,
        Value_heavy_x20_ice_x20_pellets,
        Value_heavy_x20_hail,
        Value_heavy_x20_mist,
        Value_heavy_x20_fog,
        Value_heavy_x20_fog_x20_patches,
        Value_heavy_x20_smoke,
        Value_heavy_x20_volcanic_x20_ash,
        Value_heavy_x20_widespread_x20_dust,
        Value_heavy_x20_sand,
        Value_heavy_x20_haze,
        Value_heavy_x20_spray,
        Value_heavy_x20_dust_x20_whirls,
        Value_heavy_x20_sandstorm,
        Value_heavy_x20_low_x20_drifting_x20_snow,
        Value_heavy_x20_low_x20_drifting_x20_widespread_x20_dust,
        Value_heavy_x20_low_x20_drifting_x20_sand,
        Value_heavy_x20_blowing_x20_snow,
        Value_heavy_x20_blowing_x20_widespread_x20_dust,
        Value_heavy_x20_blowing_x20_sand,
        Value_heavy_x20_rain_x20_mist,
        Value_heavy_x20_rain_x20_showers,
        Value_heavy_x20_snow_x20_showers,
        Value_heavy_x20_snow_x20_blowing,
        Value_heavy_x20_snow_x20_mist,
        Value_heavy_x20_snow_x20_blowing_x20_snow_x20_mist,
        Value_heavy_x20_ice_x20_pellet_x20_showers,
        Value_heavy_x20_hail_x20_showers,
        Value_heavy_x20_small_x20_hail_x20_showers,
        Value_heavy_x20_thunderstorm,
        Value_heavy_x20_thunderstorms_x20_and_x20_rain,
        Value_heavy_x20_thunderstorms_x20_and_x20_snow,
        Value_heavy_x20_thunderstorms_x20_and_x20_ice_x20_pellets,
        Value_heavy_x20_thunderstorms_x20_and_x20_hail,
        Value_heavy_x20_thunderstorms_x20_and_x20_small_x20_hail,
        Value_heavy_x20_freezing_x20_drizzle,
        Value_heavy_x20_freezing_x20_rain,
        Value_heavy_x20_freezing_x20_fog,
        Value_light_x20_drizzle,
        Value_light_x20_rain,
        Value_light_x20_snow,
        Value_light_x20_snow_x20_grains,
        Value_light_x20_ice_x20_crystals,
        Value_light_x20_ice_x20_pellets,
        Value_light_x20_hail,
        Value_light_x20_mist,
        Value_light_x20_fog,
        Value_light_x20_fog_x20_patches,
        Value_light_x20_smoke,
        Value_light_x20_volcanic_x20_ash,
        Value_light_x20_widespread_x20_dust,
        Value_light_x20_sand,
        Value_light_x20_haze,
        Value_light_x20_spray,
        Value_light_x20_dust_x20_whirls,
        Value_light_x20_sandstorm,
        Value_light_x20_low_x20_drifting_x20_snow,
        Value_light_x20_low_x20_drifting_x20_widespread_x20_dust,
        Value_light_x20_low_x20_drifting_x20_sand,
        Value_light_x20_blowing_x20_snow,
        Value_light_x20_blowing_x20_widespread_x20_dust,
        Value_light_x20_blowing_x20_sand,
        Value_light_x20_rain_x20_mist,
        Value_light_x20_rain_x20_showers,
        Value_light_x20_snow_x20_showers,
        Value_light_x20_snow_x20_blowing,
        Value_light_x20_snow_x20_mist,
        Value_light_x20_snow_x20_blowing_x20_snow_x20_mist,
        Value_light_x20_ice_x20_pellet_x20_showers,
        Value_light_x20_hail_x20_showers,
        Value_light_x20_small_x20_hail_x20_showers,
        Value_light_x20_thunderstorm,
        Value_light_x20_thunderstorms_x20_and_x20_rain,
        Value_light_x20_thunderstorms_x20_and_x20_snow,
        Value_light_x20_thunderstorms_x20_and_x20_ice_x20_pellets,
        Value_light_x20_thunderstorms_x20_and_x20_hail,
        Value_light_x20_thunderstorms_x20_and_x20_small_x20_hail,
        Value_light_x20_freezing_x20_drizzle,
        Value_light_x20_freezing_x20_rain,
        Value_light_x20_freezing_x20_fog,
        Value_patches_x20_of_x20_fog,
        Value_shallow_x20_fog,
        Value_dense_x20_fog,
        Value_partial_x20_fog,
        Value_overcast,
        Value_clouds_x20_and_x20_sun,
        Value_clear,
        Value_mostly_x20_clear,
        Value_sunny,
        Value_partly_x20_sunny,
        Value_mostly_x20_sunny,
        Value_cloudy,
        Value_some_x20_clouds,
        Value_partly_x20_cloudy,
        Value_mostly_x20_cloudy,
        Value_intermittent_x20_clouds,
        Value_scattered_x20_clouds,
        Value_small_x20_hail,
        Value_squals,
        Value_funnel_x20_cloud,
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
        Value_unknown_x20_precipitation,
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
            case 'b':
                if (String.Compare(chars, 1, "lowing ", 0, 7, false) == 0)
                  {
                    switch (chars[8])
                      {
                        case 's':
                            switch (chars[9])
                              {
                                case 'a':
                                    if ((String.Compare(chars, 10, "nd", 0, 2, false) == 0) && (chars.Length == 12))
                                        return TypeValueKnownValues.Value_blowing_x20_sand;
                                    break;
                                case 'n':
                                    if ((String.Compare(chars, 10, "ow", 0, 2, false) == 0) && (chars.Length == 12))
                                        return TypeValueKnownValues.Value_blowing_x20_snow;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'w':
                            if ((String.Compare(chars, 9, "idespread dust", 0, 14, false) == 0) && (chars.Length == 23))
                                return TypeValueKnownValues.Value_blowing_x20_widespread_x20_dust;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'c':
                if (String.Compare(chars, 1, "l", 0, 1, false) == 0)
                  {
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
                  }
                break;
            case 'd':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "nse fog", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeValueKnownValues.Value_dense_x20_fog;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "izzle", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeValueKnownValues.Value_drizzle;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "st whirls", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypeValueKnownValues.Value_dust_x20_whirls;
                        break;
                    default:
                        break;
                  }
                break;
            case 'f':
                switch (chars[1])
                  {
                    case 'o':
                        if (String.Compare(chars, 2, "g", 0, 1, false) == 0)
                          {
                            if (chars.Length == 3)
                              {
                                return TypeValueKnownValues.Value_fog;
                              }
                            switch (chars[3])
                              {
                                case ' ':
                                    if ((String.Compare(chars, 4, "patches", 0, 7, false) == 0) && (chars.Length == 11))
                                        return TypeValueKnownValues.Value_fog_x20_patches;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(chars, 2, "eezing ", 0, 7, false) == 0)
                          {
                            switch (chars[9])
                              {
                                case 'd':
                                    if ((String.Compare(chars, 10, "rizzle", 0, 6, false) == 0) && (chars.Length == 16))
                                        return TypeValueKnownValues.Value_freezing_x20_drizzle;
                                    break;
                                case 'f':
                                    if ((String.Compare(chars, 10, "og", 0, 2, false) == 0) && (chars.Length == 12))
                                        return TypeValueKnownValues.Value_freezing_x20_fog;
                                    break;
                                case 'r':
                                    if ((String.Compare(chars, 10, "ain", 0, 3, false) == 0) && (chars.Length == 13))
                                        return TypeValueKnownValues.Value_freezing_x20_rain;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "nnel cloud", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeValueKnownValues.Value_funnel_x20_cloud;
                        break;
                    default:
                        break;
                  }
                break;
            case 'h':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'i':
                                if (String.Compare(chars, 3, "l", 0, 1, false) == 0)
                                  {
                                    if (chars.Length == 4)
                                      {
                                        return TypeValueKnownValues.Value_hail;
                                      }
                                    switch (chars[4])
                                      {
                                        case ' ':
                                            if ((String.Compare(chars, 5, "showers", 0, 7, false) == 0) && (chars.Length == 12))
                                                return TypeValueKnownValues.Value_hail_x20_showers;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'z':
                                if ((String.Compare(chars, 3, "e", 0, 1, false) == 0) && (chars.Length == 4))
                                    return TypeValueKnownValues.Value_haze;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if (String.Compare(chars, 2, "avy ", 0, 4, false) == 0)
                          {
                            switch (chars[6])
                              {
                                case 'b':
                                    if (String.Compare(chars, 7, "lowing ", 0, 7, false) == 0)
                                      {
                                        switch (chars[14])
                                          {
                                            case 's':
                                                switch (chars[15])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(chars, 16, "nd", 0, 2, false) == 0) && (chars.Length == 18))
                                                            return TypeValueKnownValues.Value_heavy_x20_blowing_x20_sand;
                                                        break;
                                                    case 'n':
                                                        if ((String.Compare(chars, 16, "ow", 0, 2, false) == 0) && (chars.Length == 18))
                                                            return TypeValueKnownValues.Value_heavy_x20_blowing_x20_snow;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'w':
                                                if ((String.Compare(chars, 15, "idespread dust", 0, 14, false) == 0) && (chars.Length == 29))
                                                    return TypeValueKnownValues.Value_heavy_x20_blowing_x20_widespread_x20_dust;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'd':
                                    switch (chars[7])
                                      {
                                        case 'r':
                                            if ((String.Compare(chars, 8, "izzle", 0, 5, false) == 0) && (chars.Length == 13))
                                                return TypeValueKnownValues.Value_heavy_x20_drizzle;
                                            break;
                                        case 'u':
                                            if ((String.Compare(chars, 8, "st whirls", 0, 9, false) == 0) && (chars.Length == 17))
                                                return TypeValueKnownValues.Value_heavy_x20_dust_x20_whirls;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'f':
                                    switch (chars[7])
                                      {
                                        case 'o':
                                            if (String.Compare(chars, 8, "g", 0, 1, false) == 0)
                                              {
                                                if (chars.Length == 9)
                                                  {
                                                    return TypeValueKnownValues.Value_heavy_x20_fog;
                                                  }
                                                switch (chars[9])
                                                  {
                                                    case ' ':
                                                        if ((String.Compare(chars, 10, "patches", 0, 7, false) == 0) && (chars.Length == 17))
                                                            return TypeValueKnownValues.Value_heavy_x20_fog_x20_patches;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'r':
                                            if (String.Compare(chars, 8, "eezing ", 0, 7, false) == 0)
                                              {
                                                switch (chars[15])
                                                  {
                                                    case 'd':
                                                        if ((String.Compare(chars, 16, "rizzle", 0, 6, false) == 0) && (chars.Length == 22))
                                                            return TypeValueKnownValues.Value_heavy_x20_freezing_x20_drizzle;
                                                        break;
                                                    case 'f':
                                                        if ((String.Compare(chars, 16, "og", 0, 2, false) == 0) && (chars.Length == 18))
                                                            return TypeValueKnownValues.Value_heavy_x20_freezing_x20_fog;
                                                        break;
                                                    case 'r':
                                                        if ((String.Compare(chars, 16, "ain", 0, 3, false) == 0) && (chars.Length == 19))
                                                            return TypeValueKnownValues.Value_heavy_x20_freezing_x20_rain;
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
                                case 'h':
                                    if (String.Compare(chars, 7, "a", 0, 1, false) == 0)
                                      {
                                        switch (chars[8])
                                          {
                                            case 'i':
                                                if (String.Compare(chars, 9, "l", 0, 1, false) == 0)
                                                  {
                                                    if (chars.Length == 10)
                                                      {
                                                        return TypeValueKnownValues.Value_heavy_x20_hail;
                                                      }
                                                    switch (chars[10])
                                                      {
                                                        case ' ':
                                                            if ((String.Compare(chars, 11, "showers", 0, 7, false) == 0) && (chars.Length == 18))
                                                                return TypeValueKnownValues.Value_heavy_x20_hail_x20_showers;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'z':
                                                if ((String.Compare(chars, 9, "e", 0, 1, false) == 0) && (chars.Length == 10))
                                                    return TypeValueKnownValues.Value_heavy_x20_haze;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'i':
                                    if (String.Compare(chars, 7, "ce ", 0, 3, false) == 0)
                                      {
                                        switch (chars[10])
                                          {
                                            case 'c':
                                                if ((String.Compare(chars, 11, "rystals", 0, 7, false) == 0) && (chars.Length == 18))
                                                    return TypeValueKnownValues.Value_heavy_x20_ice_x20_crystals;
                                                break;
                                            case 'p':
                                                if (String.Compare(chars, 11, "ellet", 0, 5, false) == 0)
                                                  {
                                                    switch (chars[16])
                                                      {
                                                        case ' ':
                                                            if ((String.Compare(chars, 17, "showers", 0, 7, false) == 0) && (chars.Length == 24))
                                                                return TypeValueKnownValues.Value_heavy_x20_ice_x20_pellet_x20_showers;
                                                            break;
                                                        case 's':
                                                            if (chars.Length == 17)
                                                                return TypeValueKnownValues.Value_heavy_x20_ice_x20_pellets;
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
                                    if (String.Compare(chars, 7, "ow drifting ", 0, 12, false) == 0)
                                      {
                                        switch (chars[19])
                                          {
                                            case 's':
                                                switch (chars[20])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(chars, 21, "nd", 0, 2, false) == 0) && (chars.Length == 23))
                                                            return TypeValueKnownValues.Value_heavy_x20_low_x20_drifting_x20_sand;
                                                        break;
                                                    case 'n':
                                                        if ((String.Compare(chars, 21, "ow", 0, 2, false) == 0) && (chars.Length == 23))
                                                            return TypeValueKnownValues.Value_heavy_x20_low_x20_drifting_x20_snow;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'w':
                                                if ((String.Compare(chars, 20, "idespread dust", 0, 14, false) == 0) && (chars.Length == 34))
                                                    return TypeValueKnownValues.Value_heavy_x20_low_x20_drifting_x20_widespread_x20_dust;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'm':
                                    if ((String.Compare(chars, 7, "ist", 0, 3, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_heavy_x20_mist;
                                    break;
                                case 'r':
                                    if (String.Compare(chars, 7, "ain", 0, 3, false) == 0)
                                      {
                                        if (chars.Length == 10)
                                          {
                                            return TypeValueKnownValues.Value_heavy_x20_rain;
                                          }
                                        switch (chars[10])
                                          {
                                            case ' ':
                                                switch (chars[11])
                                                  {
                                                    case 'm':
                                                        if ((String.Compare(chars, 12, "ist", 0, 3, false) == 0) && (chars.Length == 15))
                                                            return TypeValueKnownValues.Value_heavy_x20_rain_x20_mist;
                                                        break;
                                                    case 's':
                                                        if (String.Compare(chars, 12, "hower", 0, 5, false) == 0)
                                                          {
                                                            if (chars.Length == 17)
                                                              {
                                                                return TypeValueKnownValues.Value_heavy_x20_rain_x20_shower;
                                                              }
                                                            switch (chars[17])
                                                              {
                                                                case 's':
                                                                    if (chars.Length == 18)
                                                                        return TypeValueKnownValues.Value_heavy_x20_rain_x20_showers;
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
                                      }
                                    break;
                                case 's':
                                    switch (chars[7])
                                      {
                                        case 'a':
                                            if (String.Compare(chars, 8, "nd", 0, 2, false) == 0)
                                              {
                                                if (chars.Length == 10)
                                                  {
                                                    return TypeValueKnownValues.Value_heavy_x20_sand;
                                                  }
                                                switch (chars[10])
                                                  {
                                                    case 's':
                                                        if ((String.Compare(chars, 11, "torm", 0, 4, false) == 0) && (chars.Length == 15))
                                                            return TypeValueKnownValues.Value_heavy_x20_sandstorm;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'm':
                                            switch (chars[8])
                                              {
                                                case 'a':
                                                    if ((String.Compare(chars, 9, "ll hail showers", 0, 15, false) == 0) && (chars.Length == 24))
                                                        return TypeValueKnownValues.Value_heavy_x20_small_x20_hail_x20_showers;
                                                    break;
                                                case 'o':
                                                    if ((String.Compare(chars, 9, "ke", 0, 2, false) == 0) && (chars.Length == 11))
                                                        return TypeValueKnownValues.Value_heavy_x20_smoke;
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'n':
                                            if (String.Compare(chars, 8, "ow", 0, 2, false) == 0)
                                              {
                                                if (chars.Length == 10)
                                                  {
                                                    return TypeValueKnownValues.Value_heavy_x20_snow;
                                                  }
                                                switch (chars[10])
                                                  {
                                                    case ' ':
                                                        switch (chars[11])
                                                          {
                                                            case 'a':
                                                                if ((String.Compare(chars, 12, "nd fog", 0, 6, false) == 0) && (chars.Length == 18))
                                                                    return TypeValueKnownValues.Value_heavy_x20_snow_x20_and_x20_fog;
                                                                break;
                                                            case 'b':
                                                                if (String.Compare(chars, 12, "lowing", 0, 6, false) == 0)
                                                                  {
                                                                    if (chars.Length == 18)
                                                                      {
                                                                        return TypeValueKnownValues.Value_heavy_x20_snow_x20_blowing;
                                                                      }
                                                                    switch (chars[18])
                                                                      {
                                                                        case ' ':
                                                                            if ((String.Compare(chars, 19, "snow mist", 0, 9, false) == 0) && (chars.Length == 28))
                                                                                return TypeValueKnownValues.Value_heavy_x20_snow_x20_blowing_x20_snow_x20_mist;
                                                                            break;
                                                                        default:
                                                                            break;
                                                                      }
                                                                  }
                                                                break;
                                                            case 'g':
                                                                if ((String.Compare(chars, 12, "rains", 0, 5, false) == 0) && (chars.Length == 17))
                                                                    return TypeValueKnownValues.Value_heavy_x20_snow_x20_grains;
                                                                break;
                                                            case 'm':
                                                                if ((String.Compare(chars, 12, "ist", 0, 3, false) == 0) && (chars.Length == 15))
                                                                    return TypeValueKnownValues.Value_heavy_x20_snow_x20_mist;
                                                                break;
                                                            case 's':
                                                                if ((String.Compare(chars, 12, "howers", 0, 6, false) == 0) && (chars.Length == 18))
                                                                    return TypeValueKnownValues.Value_heavy_x20_snow_x20_showers;
                                                                break;
                                                            default:
                                                                break;
                                                          }
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
                                        case 'p':
                                            if ((String.Compare(chars, 8, "ray", 0, 3, false) == 0) && (chars.Length == 11))
                                                return TypeValueKnownValues.Value_heavy_x20_spray;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 't':
                                    if (String.Compare(chars, 7, "hunderstorm", 0, 11, false) == 0)
                                      {
                                        if (chars.Length == 18)
                                          {
                                            return TypeValueKnownValues.Value_heavy_x20_thunderstorm;
                                          }
                                        switch (chars[18])
                                          {
                                            case 's':
                                                if (String.Compare(chars, 19, " and ", 0, 5, false) == 0)
                                                  {
                                                    switch (chars[24])
                                                      {
                                                        case 'h':
                                                            if ((String.Compare(chars, 25, "ail", 0, 3, false) == 0) && (chars.Length == 28))
                                                                return TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_hail;
                                                            break;
                                                        case 'i':
                                                            if ((String.Compare(chars, 25, "ce pellets", 0, 10, false) == 0) && (chars.Length == 35))
                                                                return TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_ice_x20_pellets;
                                                            break;
                                                        case 'r':
                                                            if ((String.Compare(chars, 25, "ain", 0, 3, false) == 0) && (chars.Length == 28))
                                                                return TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_rain;
                                                            break;
                                                        case 's':
                                                            switch (chars[25])
                                                              {
                                                                case 'm':
                                                                    if ((String.Compare(chars, 26, "all hail", 0, 8, false) == 0) && (chars.Length == 34))
                                                                        return TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_small_x20_hail;
                                                                    break;
                                                                case 'n':
                                                                    if ((String.Compare(chars, 26, "ow", 0, 2, false) == 0) && (chars.Length == 28))
                                                                        return TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_snow;
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
                                      }
                                    break;
                                case 'v':
                                    if ((String.Compare(chars, 7, "olcanic ash", 0, 11, false) == 0) && (chars.Length == 18))
                                        return TypeValueKnownValues.Value_heavy_x20_volcanic_x20_ash;
                                    break;
                                case 'w':
                                    if ((String.Compare(chars, 7, "idespread dust", 0, 14, false) == 0) && (chars.Length == 21))
                                        return TypeValueKnownValues.Value_heavy_x20_widespread_x20_dust;
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
                switch (chars[1])
                  {
                    case 'c':
                        if (String.Compare(chars, 2, "e ", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'c':
                                    if ((String.Compare(chars, 5, "rystals", 0, 7, false) == 0) && (chars.Length == 12))
                                        return TypeValueKnownValues.Value_ice_x20_crystals;
                                    break;
                                case 'p':
                                    if (String.Compare(chars, 5, "ellet", 0, 5, false) == 0)
                                      {
                                        switch (chars[10])
                                          {
                                            case ' ':
                                                if ((String.Compare(chars, 11, "showers", 0, 7, false) == 0) && (chars.Length == 18))
                                                    return TypeValueKnownValues.Value_ice_x20_pellet_x20_showers;
                                                break;
                                            case 's':
                                                if (chars.Length == 11)
                                                    return TypeValueKnownValues.Value_ice_x20_pellets;
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
                    case 'n':
                        if ((String.Compare(chars, 2, "termittent clouds", 0, 17, false) == 0) && (chars.Length == 19))
                            return TypeValueKnownValues.Value_intermittent_x20_clouds;
                        break;
                    default:
                        break;
                  }
                break;
            case 'l':
                switch (chars[1])
                  {
                    case 'i':
                        if (String.Compare(chars, 2, "ght ", 0, 4, false) == 0)
                          {
                            switch (chars[6])
                              {
                                case 'b':
                                    if (String.Compare(chars, 7, "lowing ", 0, 7, false) == 0)
                                      {
                                        switch (chars[14])
                                          {
                                            case 's':
                                                switch (chars[15])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(chars, 16, "nd", 0, 2, false) == 0) && (chars.Length == 18))
                                                            return TypeValueKnownValues.Value_light_x20_blowing_x20_sand;
                                                        break;
                                                    case 'n':
                                                        if ((String.Compare(chars, 16, "ow", 0, 2, false) == 0) && (chars.Length == 18))
                                                            return TypeValueKnownValues.Value_light_x20_blowing_x20_snow;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'w':
                                                if ((String.Compare(chars, 15, "idespread dust", 0, 14, false) == 0) && (chars.Length == 29))
                                                    return TypeValueKnownValues.Value_light_x20_blowing_x20_widespread_x20_dust;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'd':
                                    switch (chars[7])
                                      {
                                        case 'r':
                                            if ((String.Compare(chars, 8, "izzle", 0, 5, false) == 0) && (chars.Length == 13))
                                                return TypeValueKnownValues.Value_light_x20_drizzle;
                                            break;
                                        case 'u':
                                            if ((String.Compare(chars, 8, "st whirls", 0, 9, false) == 0) && (chars.Length == 17))
                                                return TypeValueKnownValues.Value_light_x20_dust_x20_whirls;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'f':
                                    switch (chars[7])
                                      {
                                        case 'o':
                                            if (String.Compare(chars, 8, "g", 0, 1, false) == 0)
                                              {
                                                if (chars.Length == 9)
                                                  {
                                                    return TypeValueKnownValues.Value_light_x20_fog;
                                                  }
                                                switch (chars[9])
                                                  {
                                                    case ' ':
                                                        if ((String.Compare(chars, 10, "patches", 0, 7, false) == 0) && (chars.Length == 17))
                                                            return TypeValueKnownValues.Value_light_x20_fog_x20_patches;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'r':
                                            if (String.Compare(chars, 8, "eezing ", 0, 7, false) == 0)
                                              {
                                                switch (chars[15])
                                                  {
                                                    case 'd':
                                                        if ((String.Compare(chars, 16, "rizzle", 0, 6, false) == 0) && (chars.Length == 22))
                                                            return TypeValueKnownValues.Value_light_x20_freezing_x20_drizzle;
                                                        break;
                                                    case 'f':
                                                        if ((String.Compare(chars, 16, "og", 0, 2, false) == 0) && (chars.Length == 18))
                                                            return TypeValueKnownValues.Value_light_x20_freezing_x20_fog;
                                                        break;
                                                    case 'r':
                                                        if ((String.Compare(chars, 16, "ain", 0, 3, false) == 0) && (chars.Length == 19))
                                                            return TypeValueKnownValues.Value_light_x20_freezing_x20_rain;
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
                                case 'h':
                                    if (String.Compare(chars, 7, "a", 0, 1, false) == 0)
                                      {
                                        switch (chars[8])
                                          {
                                            case 'i':
                                                if (String.Compare(chars, 9, "l", 0, 1, false) == 0)
                                                  {
                                                    if (chars.Length == 10)
                                                      {
                                                        return TypeValueKnownValues.Value_light_x20_hail;
                                                      }
                                                    switch (chars[10])
                                                      {
                                                        case ' ':
                                                            if ((String.Compare(chars, 11, "showers", 0, 7, false) == 0) && (chars.Length == 18))
                                                                return TypeValueKnownValues.Value_light_x20_hail_x20_showers;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'z':
                                                if ((String.Compare(chars, 9, "e", 0, 1, false) == 0) && (chars.Length == 10))
                                                    return TypeValueKnownValues.Value_light_x20_haze;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'i':
                                    if (String.Compare(chars, 7, "ce ", 0, 3, false) == 0)
                                      {
                                        switch (chars[10])
                                          {
                                            case 'c':
                                                if ((String.Compare(chars, 11, "rystals", 0, 7, false) == 0) && (chars.Length == 18))
                                                    return TypeValueKnownValues.Value_light_x20_ice_x20_crystals;
                                                break;
                                            case 'p':
                                                if (String.Compare(chars, 11, "ellet", 0, 5, false) == 0)
                                                  {
                                                    switch (chars[16])
                                                      {
                                                        case ' ':
                                                            if ((String.Compare(chars, 17, "showers", 0, 7, false) == 0) && (chars.Length == 24))
                                                                return TypeValueKnownValues.Value_light_x20_ice_x20_pellet_x20_showers;
                                                            break;
                                                        case 's':
                                                            if (chars.Length == 17)
                                                                return TypeValueKnownValues.Value_light_x20_ice_x20_pellets;
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
                                    if (String.Compare(chars, 7, "ow drifting ", 0, 12, false) == 0)
                                      {
                                        switch (chars[19])
                                          {
                                            case 's':
                                                switch (chars[20])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(chars, 21, "nd", 0, 2, false) == 0) && (chars.Length == 23))
                                                            return TypeValueKnownValues.Value_light_x20_low_x20_drifting_x20_sand;
                                                        break;
                                                    case 'n':
                                                        if ((String.Compare(chars, 21, "ow", 0, 2, false) == 0) && (chars.Length == 23))
                                                            return TypeValueKnownValues.Value_light_x20_low_x20_drifting_x20_snow;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'w':
                                                if ((String.Compare(chars, 20, "idespread dust", 0, 14, false) == 0) && (chars.Length == 34))
                                                    return TypeValueKnownValues.Value_light_x20_low_x20_drifting_x20_widespread_x20_dust;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'm':
                                    if ((String.Compare(chars, 7, "ist", 0, 3, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_light_x20_mist;
                                    break;
                                case 'r':
                                    if (String.Compare(chars, 7, "ain", 0, 3, false) == 0)
                                      {
                                        if (chars.Length == 10)
                                          {
                                            return TypeValueKnownValues.Value_light_x20_rain;
                                          }
                                        switch (chars[10])
                                          {
                                            case ' ':
                                                switch (chars[11])
                                                  {
                                                    case 'm':
                                                        if ((String.Compare(chars, 12, "ist", 0, 3, false) == 0) && (chars.Length == 15))
                                                            return TypeValueKnownValues.Value_light_x20_rain_x20_mist;
                                                        break;
                                                    case 's':
                                                        if (String.Compare(chars, 12, "hower", 0, 5, false) == 0)
                                                          {
                                                            if (chars.Length == 17)
                                                              {
                                                                return TypeValueKnownValues.Value_light_x20_rain_x20_shower;
                                                              }
                                                            switch (chars[17])
                                                              {
                                                                case 's':
                                                                    if (chars.Length == 18)
                                                                        return TypeValueKnownValues.Value_light_x20_rain_x20_showers;
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
                                      }
                                    break;
                                case 's':
                                    switch (chars[7])
                                      {
                                        case 'a':
                                            if (String.Compare(chars, 8, "nd", 0, 2, false) == 0)
                                              {
                                                if (chars.Length == 10)
                                                  {
                                                    return TypeValueKnownValues.Value_light_x20_sand;
                                                  }
                                                switch (chars[10])
                                                  {
                                                    case 's':
                                                        if ((String.Compare(chars, 11, "torm", 0, 4, false) == 0) && (chars.Length == 15))
                                                            return TypeValueKnownValues.Value_light_x20_sandstorm;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'm':
                                            switch (chars[8])
                                              {
                                                case 'a':
                                                    if ((String.Compare(chars, 9, "ll hail showers", 0, 15, false) == 0) && (chars.Length == 24))
                                                        return TypeValueKnownValues.Value_light_x20_small_x20_hail_x20_showers;
                                                    break;
                                                case 'o':
                                                    if ((String.Compare(chars, 9, "ke", 0, 2, false) == 0) && (chars.Length == 11))
                                                        return TypeValueKnownValues.Value_light_x20_smoke;
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'n':
                                            if (String.Compare(chars, 8, "ow", 0, 2, false) == 0)
                                              {
                                                if (chars.Length == 10)
                                                  {
                                                    return TypeValueKnownValues.Value_light_x20_snow;
                                                  }
                                                switch (chars[10])
                                                  {
                                                    case ' ':
                                                        switch (chars[11])
                                                          {
                                                            case 'a':
                                                                if ((String.Compare(chars, 12, "nd fog", 0, 6, false) == 0) && (chars.Length == 18))
                                                                    return TypeValueKnownValues.Value_light_x20_snow_x20_and_x20_fog;
                                                                break;
                                                            case 'b':
                                                                if (String.Compare(chars, 12, "lowing", 0, 6, false) == 0)
                                                                  {
                                                                    if (chars.Length == 18)
                                                                      {
                                                                        return TypeValueKnownValues.Value_light_x20_snow_x20_blowing;
                                                                      }
                                                                    switch (chars[18])
                                                                      {
                                                                        case ' ':
                                                                            if ((String.Compare(chars, 19, "snow mist", 0, 9, false) == 0) && (chars.Length == 28))
                                                                                return TypeValueKnownValues.Value_light_x20_snow_x20_blowing_x20_snow_x20_mist;
                                                                            break;
                                                                        default:
                                                                            break;
                                                                      }
                                                                  }
                                                                break;
                                                            case 'g':
                                                                if ((String.Compare(chars, 12, "rains", 0, 5, false) == 0) && (chars.Length == 17))
                                                                    return TypeValueKnownValues.Value_light_x20_snow_x20_grains;
                                                                break;
                                                            case 'm':
                                                                if ((String.Compare(chars, 12, "ist", 0, 3, false) == 0) && (chars.Length == 15))
                                                                    return TypeValueKnownValues.Value_light_x20_snow_x20_mist;
                                                                break;
                                                            case 's':
                                                                if ((String.Compare(chars, 12, "howers", 0, 6, false) == 0) && (chars.Length == 18))
                                                                    return TypeValueKnownValues.Value_light_x20_snow_x20_showers;
                                                                break;
                                                            default:
                                                                break;
                                                          }
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
                                        case 'p':
                                            if ((String.Compare(chars, 8, "ray", 0, 3, false) == 0) && (chars.Length == 11))
                                                return TypeValueKnownValues.Value_light_x20_spray;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 't':
                                    if (String.Compare(chars, 7, "hunderstorm", 0, 11, false) == 0)
                                      {
                                        if (chars.Length == 18)
                                          {
                                            return TypeValueKnownValues.Value_light_x20_thunderstorm;
                                          }
                                        switch (chars[18])
                                          {
                                            case 's':
                                                if (String.Compare(chars, 19, " and ", 0, 5, false) == 0)
                                                  {
                                                    switch (chars[24])
                                                      {
                                                        case 'h':
                                                            if ((String.Compare(chars, 25, "ail", 0, 3, false) == 0) && (chars.Length == 28))
                                                                return TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_hail;
                                                            break;
                                                        case 'i':
                                                            if ((String.Compare(chars, 25, "ce pellets", 0, 10, false) == 0) && (chars.Length == 35))
                                                                return TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_ice_x20_pellets;
                                                            break;
                                                        case 'r':
                                                            if ((String.Compare(chars, 25, "ain", 0, 3, false) == 0) && (chars.Length == 28))
                                                                return TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_rain;
                                                            break;
                                                        case 's':
                                                            switch (chars[25])
                                                              {
                                                                case 'm':
                                                                    if ((String.Compare(chars, 26, "all hail", 0, 8, false) == 0) && (chars.Length == 34))
                                                                        return TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_small_x20_hail;
                                                                    break;
                                                                case 'n':
                                                                    if ((String.Compare(chars, 26, "ow", 0, 2, false) == 0) && (chars.Length == 28))
                                                                        return TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_snow;
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
                                      }
                                    break;
                                case 'v':
                                    if ((String.Compare(chars, 7, "olcanic ash", 0, 11, false) == 0) && (chars.Length == 18))
                                        return TypeValueKnownValues.Value_light_x20_volcanic_x20_ash;
                                    break;
                                case 'w':
                                    if ((String.Compare(chars, 7, "idespread dust", 0, 14, false) == 0) && (chars.Length == 21))
                                        return TypeValueKnownValues.Value_light_x20_widespread_x20_dust;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if (String.Compare(chars, 2, "w drifting ", 0, 11, false) == 0)
                          {
                            switch (chars[13])
                              {
                                case 's':
                                    switch (chars[14])
                                      {
                                        case 'a':
                                            if ((String.Compare(chars, 15, "nd", 0, 2, false) == 0) && (chars.Length == 17))
                                                return TypeValueKnownValues.Value_low_x20_drifting_x20_sand;
                                            break;
                                        case 'n':
                                            if ((String.Compare(chars, 15, "ow", 0, 2, false) == 0) && (chars.Length == 17))
                                                return TypeValueKnownValues.Value_low_x20_drifting_x20_snow;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'w':
                                    if ((String.Compare(chars, 14, "idespread dust", 0, 14, false) == 0) && (chars.Length == 28))
                                        return TypeValueKnownValues.Value_low_x20_drifting_x20_widespread_x20_dust;
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
            case 'm':
                switch (chars[1])
                  {
                    case 'i':
                        if ((String.Compare(chars, 2, "st", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_mist;
                        break;
                    case 'o':
                        if (String.Compare(chars, 2, "stly ", 0, 5, false) == 0)
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
                                                if ((String.Compare(chars, 10, "udy", 0, 3, false) == 0) && (chars.Length == 13))
                                                    return TypeValueKnownValues.Value_mostly_x20_cloudy;
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
                    default:
                        break;
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
                if (String.Compare(chars, 1, "a", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'r':
                            if (String.Compare(chars, 3, "t", 0, 1, false) == 0)
                              {
                                switch (chars[4])
                                  {
                                    case 'i':
                                        if ((String.Compare(chars, 5, "al fog", 0, 6, false) == 0) && (chars.Length == 11))
                                            return TypeValueKnownValues.Value_partial_x20_fog;
                                        break;
                                    case 'l':
                                        if (String.Compare(chars, 5, "y ", 0, 2, false) == 0)
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
                                                                if (String.Compare(chars, 14, "with ", 0, 5, false) == 0)
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
                                                    if ((String.Compare(chars, 8, "unny", 0, 4, false) == 0) && (chars.Length == 12))
                                                        return TypeValueKnownValues.Value_partly_x20_sunny;
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
                        case 't':
                            if ((String.Compare(chars, 3, "ches of fog", 0, 11, false) == 0) && (chars.Length == 14))
                                return TypeValueKnownValues.Value_patches_x20_of_x20_fog;
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
                            switch (chars[5])
                              {
                                case 'a':
                                    if ((String.Compare(chars, 6, "nd snow", 0, 7, false) == 0) && (chars.Length == 13))
                                        return TypeValueKnownValues.Value_rain_x20_and_x20_snow;
                                    break;
                                case 'm':
                                    if ((String.Compare(chars, 6, "ist", 0, 3, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_rain_x20_mist;
                                    break;
                                case 's':
                                    if ((String.Compare(chars, 6, "howers", 0, 6, false) == 0) && (chars.Length == 12))
                                        return TypeValueKnownValues.Value_rain_x20_showers;
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
            case 's':
                switch (chars[1])
                  {
                    case 'a':
                        if (String.Compare(chars, 2, "nd", 0, 2, false) == 0)
                          {
                            if (chars.Length == 4)
                              {
                                return TypeValueKnownValues.Value_sand;
                              }
                            switch (chars[4])
                              {
                                case 's':
                                    if ((String.Compare(chars, 5, "torm", 0, 4, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_sandstorm;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'c':
                        if ((String.Compare(chars, 2, "attered clouds", 0, 14, false) == 0) && (chars.Length == 16))
                            return TypeValueKnownValues.Value_scattered_x20_clouds;
                        break;
                    case 'h':
                        switch (chars[2])
                          {
                            case 'a':
                                if ((String.Compare(chars, 3, "llow fog", 0, 8, false) == 0) && (chars.Length == 11))
                                    return TypeValueKnownValues.Value_shallow_x20_fog;
                                break;
                            case 'o':
                                if ((String.Compare(chars, 3, "wer", 0, 3, false) == 0) && (chars.Length == 6))
                                    return TypeValueKnownValues.Value_shower;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'm':
                        switch (chars[2])
                          {
                            case 'a':
                                if (String.Compare(chars, 3, "ll hail", 0, 7, false) == 0)
                                  {
                                    if (chars.Length == 10)
                                      {
                                        return TypeValueKnownValues.Value_small_x20_hail;
                                      }
                                    switch (chars[10])
                                      {
                                        case ' ':
                                            if ((String.Compare(chars, 11, "showers", 0, 7, false) == 0) && (chars.Length == 18))
                                                return TypeValueKnownValues.Value_small_x20_hail_x20_showers;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'o':
                                if ((String.Compare(chars, 3, "ke", 0, 2, false) == 0) && (chars.Length == 5))
                                    return TypeValueKnownValues.Value_smoke;
                                break;
                            default:
                                break;
                          }
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
                                    switch (chars[5])
                                      {
                                        case 'a':
                                            if ((String.Compare(chars, 6, "nd fog", 0, 6, false) == 0) && (chars.Length == 12))
                                                return TypeValueKnownValues.Value_snow_x20_and_x20_fog;
                                            break;
                                        case 'b':
                                            if (String.Compare(chars, 6, "lowing", 0, 6, false) == 0)
                                              {
                                                if (chars.Length == 12)
                                                  {
                                                    return TypeValueKnownValues.Value_snow_x20_blowing;
                                                  }
                                                switch (chars[12])
                                                  {
                                                    case ' ':
                                                        if ((String.Compare(chars, 13, "snow mist", 0, 9, false) == 0) && (chars.Length == 22))
                                                            return TypeValueKnownValues.Value_snow_x20_blowing_x20_snow_x20_mist;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'g':
                                            if ((String.Compare(chars, 6, "rains", 0, 5, false) == 0) && (chars.Length == 11))
                                                return TypeValueKnownValues.Value_snow_x20_grains;
                                            break;
                                        case 'm':
                                            if ((String.Compare(chars, 6, "ist", 0, 3, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_snow_x20_mist;
                                            break;
                                        case 's':
                                            if ((String.Compare(chars, 6, "howers", 0, 6, false) == 0) && (chars.Length == 12))
                                                return TypeValueKnownValues.Value_snow_x20_showers;
                                            break;
                                        default:
                                            break;
                                      }
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
                    case 'p':
                        if ((String.Compare(chars, 2, "ray", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValueKnownValues.Value_spray;
                        break;
                    case 'q':
                        if ((String.Compare(chars, 2, "uals", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_squals;
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
                                        if (String.Compare(chars, 13, " and ", 0, 5, false) == 0)
                                          {
                                            switch (chars[18])
                                              {
                                                case 'h':
                                                    if ((String.Compare(chars, 19, "ail", 0, 3, false) == 0) && (chars.Length == 22))
                                                        return TypeValueKnownValues.Value_thunderstorms_x20_and_x20_hail;
                                                    break;
                                                case 'i':
                                                    if ((String.Compare(chars, 19, "ce pellets", 0, 10, false) == 0) && (chars.Length == 29))
                                                        return TypeValueKnownValues.Value_thunderstorms_x20_and_x20_ice_x20_pellets;
                                                    break;
                                                case 'r':
                                                    if ((String.Compare(chars, 19, "ain", 0, 3, false) == 0) && (chars.Length == 22))
                                                        return TypeValueKnownValues.Value_thunderstorms_x20_and_x20_rain;
                                                    break;
                                                case 's':
                                                    switch (chars[19])
                                                      {
                                                        case 'm':
                                                            if ((String.Compare(chars, 20, "all hail", 0, 8, false) == 0) && (chars.Length == 28))
                                                                return TypeValueKnownValues.Value_thunderstorms_x20_and_x20_small_x20_hail;
                                                            break;
                                                        case 'n':
                                                            if ((String.Compare(chars, 20, "ow", 0, 2, false) == 0) && (chars.Length == 22))
                                                                return TypeValueKnownValues.Value_thunderstorms_x20_and_x20_snow;
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
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'u':
                if (String.Compare(chars, 1, "nknown", 0, 6, false) == 0)
                  {
                    if (chars.Length == 7)
                      {
                        return TypeValueKnownValues.Value_unknown;
                      }
                    switch (chars[7])
                      {
                        case ' ':
                            if ((String.Compare(chars, 8, "precipitation", 0, 13, false) == 0) && (chars.Length == 21))
                                return TypeValueKnownValues.Value_unknown_x20_precipitation;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'v':
                if ((String.Compare(chars, 1, "olcanic ash", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeValueKnownValues.Value_volcanic_x20_ash;
                break;
            case 'w':
                if ((String.Compare(chars, 1, "idespread dust", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypeValueKnownValues.Value_widespread_x20_dust;
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
            case TypeValueKnownValues.Value_drizzle:
                return "drizzle";
            case TypeValueKnownValues.Value_rain:
                return "rain";
            case TypeValueKnownValues.Value_snow:
                return "snow";
            case TypeValueKnownValues.Value_rain_x20_and_x20_snow:
                return "rain and snow";
            case TypeValueKnownValues.Value_snow_x20_grains:
                return "snow grains";
            case TypeValueKnownValues.Value_ice_x20_crystals:
                return "ice crystals";
            case TypeValueKnownValues.Value_ice_x20_pellets:
                return "ice pellets";
            case TypeValueKnownValues.Value_hail:
                return "hail";
            case TypeValueKnownValues.Value_mist:
                return "mist";
            case TypeValueKnownValues.Value_fog:
                return "fog";
            case TypeValueKnownValues.Value_fog_x20_patches:
                return "fog patches";
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
            case TypeValueKnownValues.Value_smoke:
                return "smoke";
            case TypeValueKnownValues.Value_volcanic_x20_ash:
                return "volcanic ash";
            case TypeValueKnownValues.Value_widespread_x20_dust:
                return "widespread dust";
            case TypeValueKnownValues.Value_sand:
                return "sand";
            case TypeValueKnownValues.Value_haze:
                return "haze";
            case TypeValueKnownValues.Value_spray:
                return "spray";
            case TypeValueKnownValues.Value_dust_x20_whirls:
                return "dust whirls";
            case TypeValueKnownValues.Value_sandstorm:
                return "sandstorm";
            case TypeValueKnownValues.Value_low_x20_drifting_x20_snow:
                return "low drifting snow";
            case TypeValueKnownValues.Value_low_x20_drifting_x20_widespread_x20_dust:
                return "low drifting widespread dust";
            case TypeValueKnownValues.Value_low_x20_drifting_x20_sand:
                return "low drifting sand";
            case TypeValueKnownValues.Value_blowing_x20_snow:
                return "blowing snow";
            case TypeValueKnownValues.Value_blowing_x20_widespread_x20_dust:
                return "blowing widespread dust";
            case TypeValueKnownValues.Value_blowing_x20_sand:
                return "blowing sand";
            case TypeValueKnownValues.Value_a_x20_shower:
                return "a shower";
            case TypeValueKnownValues.Value_shower:
                return "shower";
            case TypeValueKnownValues.Value_rain_x20_mist:
                return "rain mist";
            case TypeValueKnownValues.Value_rain_x20_showers:
                return "rain showers";
            case TypeValueKnownValues.Value_heavy_x20_rain_x20_shower:
                return "heavy rain shower";
            case TypeValueKnownValues.Value_light_x20_rain_x20_shower:
                return "light rain shower";
            case TypeValueKnownValues.Value_snow_x20_showers:
                return "snow showers";
            case TypeValueKnownValues.Value_snow_x20_blowing:
                return "snow blowing";
            case TypeValueKnownValues.Value_snow_x20_mist:
                return "snow mist";
            case TypeValueKnownValues.Value_snow_x20_blowing_x20_snow_x20_mist:
                return "snow blowing snow mist";
            case TypeValueKnownValues.Value_ice_x20_pellet_x20_showers:
                return "ice pellet showers";
            case TypeValueKnownValues.Value_hail_x20_showers:
                return "hail showers";
            case TypeValueKnownValues.Value_small_x20_hail_x20_showers:
                return "small hail showers";
            case TypeValueKnownValues.Value_thunderstorm:
                return "thunderstorm";
            case TypeValueKnownValues.Value_thunderstorms_x20_and_x20_rain:
                return "thunderstorms and rain";
            case TypeValueKnownValues.Value_thunderstorms_x20_and_x20_snow:
                return "thunderstorms and snow";
            case TypeValueKnownValues.Value_thunderstorms_x20_and_x20_ice_x20_pellets:
                return "thunderstorms and ice pellets";
            case TypeValueKnownValues.Value_thunderstorms_x20_and_x20_hail:
                return "thunderstorms and hail";
            case TypeValueKnownValues.Value_thunderstorms_x20_and_x20_small_x20_hail:
                return "thunderstorms and small hail";
            case TypeValueKnownValues.Value_freezing_x20_drizzle:
                return "freezing drizzle";
            case TypeValueKnownValues.Value_freezing_x20_rain:
                return "freezing rain";
            case TypeValueKnownValues.Value_freezing_x20_fog:
                return "freezing fog";
            case TypeValueKnownValues.Value_heavy_x20_drizzle:
                return "heavy drizzle";
            case TypeValueKnownValues.Value_heavy_x20_rain:
                return "heavy rain";
            case TypeValueKnownValues.Value_heavy_x20_snow:
                return "heavy snow";
            case TypeValueKnownValues.Value_heavy_x20_snow_x20_grains:
                return "heavy snow grains";
            case TypeValueKnownValues.Value_heavy_x20_ice_x20_crystals:
                return "heavy ice crystals";
            case TypeValueKnownValues.Value_heavy_x20_ice_x20_pellets:
                return "heavy ice pellets";
            case TypeValueKnownValues.Value_heavy_x20_hail:
                return "heavy hail";
            case TypeValueKnownValues.Value_heavy_x20_mist:
                return "heavy mist";
            case TypeValueKnownValues.Value_heavy_x20_fog:
                return "heavy fog";
            case TypeValueKnownValues.Value_heavy_x20_fog_x20_patches:
                return "heavy fog patches";
            case TypeValueKnownValues.Value_heavy_x20_smoke:
                return "heavy smoke";
            case TypeValueKnownValues.Value_heavy_x20_volcanic_x20_ash:
                return "heavy volcanic ash";
            case TypeValueKnownValues.Value_heavy_x20_widespread_x20_dust:
                return "heavy widespread dust";
            case TypeValueKnownValues.Value_heavy_x20_sand:
                return "heavy sand";
            case TypeValueKnownValues.Value_heavy_x20_haze:
                return "heavy haze";
            case TypeValueKnownValues.Value_heavy_x20_spray:
                return "heavy spray";
            case TypeValueKnownValues.Value_heavy_x20_dust_x20_whirls:
                return "heavy dust whirls";
            case TypeValueKnownValues.Value_heavy_x20_sandstorm:
                return "heavy sandstorm";
            case TypeValueKnownValues.Value_heavy_x20_low_x20_drifting_x20_snow:
                return "heavy low drifting snow";
            case TypeValueKnownValues.Value_heavy_x20_low_x20_drifting_x20_widespread_x20_dust:
                return "heavy low drifting widespread dust";
            case TypeValueKnownValues.Value_heavy_x20_low_x20_drifting_x20_sand:
                return "heavy low drifting sand";
            case TypeValueKnownValues.Value_heavy_x20_blowing_x20_snow:
                return "heavy blowing snow";
            case TypeValueKnownValues.Value_heavy_x20_blowing_x20_widespread_x20_dust:
                return "heavy blowing widespread dust";
            case TypeValueKnownValues.Value_heavy_x20_blowing_x20_sand:
                return "heavy blowing sand";
            case TypeValueKnownValues.Value_heavy_x20_rain_x20_mist:
                return "heavy rain mist";
            case TypeValueKnownValues.Value_heavy_x20_rain_x20_showers:
                return "heavy rain showers";
            case TypeValueKnownValues.Value_heavy_x20_snow_x20_showers:
                return "heavy snow showers";
            case TypeValueKnownValues.Value_heavy_x20_snow_x20_blowing:
                return "heavy snow blowing";
            case TypeValueKnownValues.Value_heavy_x20_snow_x20_mist:
                return "heavy snow mist";
            case TypeValueKnownValues.Value_heavy_x20_snow_x20_blowing_x20_snow_x20_mist:
                return "heavy snow blowing snow mist";
            case TypeValueKnownValues.Value_heavy_x20_ice_x20_pellet_x20_showers:
                return "heavy ice pellet showers";
            case TypeValueKnownValues.Value_heavy_x20_hail_x20_showers:
                return "heavy hail showers";
            case TypeValueKnownValues.Value_heavy_x20_small_x20_hail_x20_showers:
                return "heavy small hail showers";
            case TypeValueKnownValues.Value_heavy_x20_thunderstorm:
                return "heavy thunderstorm";
            case TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_rain:
                return "heavy thunderstorms and rain";
            case TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_snow:
                return "heavy thunderstorms and snow";
            case TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_ice_x20_pellets:
                return "heavy thunderstorms and ice pellets";
            case TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_hail:
                return "heavy thunderstorms and hail";
            case TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_small_x20_hail:
                return "heavy thunderstorms and small hail";
            case TypeValueKnownValues.Value_heavy_x20_freezing_x20_drizzle:
                return "heavy freezing drizzle";
            case TypeValueKnownValues.Value_heavy_x20_freezing_x20_rain:
                return "heavy freezing rain";
            case TypeValueKnownValues.Value_heavy_x20_freezing_x20_fog:
                return "heavy freezing fog";
            case TypeValueKnownValues.Value_light_x20_drizzle:
                return "light drizzle";
            case TypeValueKnownValues.Value_light_x20_rain:
                return "light rain";
            case TypeValueKnownValues.Value_light_x20_snow:
                return "light snow";
            case TypeValueKnownValues.Value_light_x20_snow_x20_grains:
                return "light snow grains";
            case TypeValueKnownValues.Value_light_x20_ice_x20_crystals:
                return "light ice crystals";
            case TypeValueKnownValues.Value_light_x20_ice_x20_pellets:
                return "light ice pellets";
            case TypeValueKnownValues.Value_light_x20_hail:
                return "light hail";
            case TypeValueKnownValues.Value_light_x20_mist:
                return "light mist";
            case TypeValueKnownValues.Value_light_x20_fog:
                return "light fog";
            case TypeValueKnownValues.Value_light_x20_fog_x20_patches:
                return "light fog patches";
            case TypeValueKnownValues.Value_light_x20_smoke:
                return "light smoke";
            case TypeValueKnownValues.Value_light_x20_volcanic_x20_ash:
                return "light volcanic ash";
            case TypeValueKnownValues.Value_light_x20_widespread_x20_dust:
                return "light widespread dust";
            case TypeValueKnownValues.Value_light_x20_sand:
                return "light sand";
            case TypeValueKnownValues.Value_light_x20_haze:
                return "light haze";
            case TypeValueKnownValues.Value_light_x20_spray:
                return "light spray";
            case TypeValueKnownValues.Value_light_x20_dust_x20_whirls:
                return "light dust whirls";
            case TypeValueKnownValues.Value_light_x20_sandstorm:
                return "light sandstorm";
            case TypeValueKnownValues.Value_light_x20_low_x20_drifting_x20_snow:
                return "light low drifting snow";
            case TypeValueKnownValues.Value_light_x20_low_x20_drifting_x20_widespread_x20_dust:
                return "light low drifting widespread dust";
            case TypeValueKnownValues.Value_light_x20_low_x20_drifting_x20_sand:
                return "light low drifting sand";
            case TypeValueKnownValues.Value_light_x20_blowing_x20_snow:
                return "light blowing snow";
            case TypeValueKnownValues.Value_light_x20_blowing_x20_widespread_x20_dust:
                return "light blowing widespread dust";
            case TypeValueKnownValues.Value_light_x20_blowing_x20_sand:
                return "light blowing sand";
            case TypeValueKnownValues.Value_light_x20_rain_x20_mist:
                return "light rain mist";
            case TypeValueKnownValues.Value_light_x20_rain_x20_showers:
                return "light rain showers";
            case TypeValueKnownValues.Value_light_x20_snow_x20_showers:
                return "light snow showers";
            case TypeValueKnownValues.Value_light_x20_snow_x20_blowing:
                return "light snow blowing";
            case TypeValueKnownValues.Value_light_x20_snow_x20_mist:
                return "light snow mist";
            case TypeValueKnownValues.Value_light_x20_snow_x20_blowing_x20_snow_x20_mist:
                return "light snow blowing snow mist";
            case TypeValueKnownValues.Value_light_x20_ice_x20_pellet_x20_showers:
                return "light ice pellet showers";
            case TypeValueKnownValues.Value_light_x20_hail_x20_showers:
                return "light hail showers";
            case TypeValueKnownValues.Value_light_x20_small_x20_hail_x20_showers:
                return "light small hail showers";
            case TypeValueKnownValues.Value_light_x20_thunderstorm:
                return "light thunderstorm";
            case TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_rain:
                return "light thunderstorms and rain";
            case TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_snow:
                return "light thunderstorms and snow";
            case TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_ice_x20_pellets:
                return "light thunderstorms and ice pellets";
            case TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_hail:
                return "light thunderstorms and hail";
            case TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_small_x20_hail:
                return "light thunderstorms and small hail";
            case TypeValueKnownValues.Value_light_x20_freezing_x20_drizzle:
                return "light freezing drizzle";
            case TypeValueKnownValues.Value_light_x20_freezing_x20_rain:
                return "light freezing rain";
            case TypeValueKnownValues.Value_light_x20_freezing_x20_fog:
                return "light freezing fog";
            case TypeValueKnownValues.Value_patches_x20_of_x20_fog:
                return "patches of fog";
            case TypeValueKnownValues.Value_shallow_x20_fog:
                return "shallow fog";
            case TypeValueKnownValues.Value_dense_x20_fog:
                return "dense fog";
            case TypeValueKnownValues.Value_partial_x20_fog:
                return "partial fog";
            case TypeValueKnownValues.Value_overcast:
                return "overcast";
            case TypeValueKnownValues.Value_clouds_x20_and_x20_sun:
                return "clouds and sun";
            case TypeValueKnownValues.Value_clear:
                return "clear";
            case TypeValueKnownValues.Value_mostly_x20_clear:
                return "mostly clear";
            case TypeValueKnownValues.Value_sunny:
                return "sunny";
            case TypeValueKnownValues.Value_partly_x20_sunny:
                return "partly sunny";
            case TypeValueKnownValues.Value_mostly_x20_sunny:
                return "mostly sunny";
            case TypeValueKnownValues.Value_cloudy:
                return "cloudy";
            case TypeValueKnownValues.Value_some_x20_clouds:
                return "some clouds";
            case TypeValueKnownValues.Value_partly_x20_cloudy:
                return "partly cloudy";
            case TypeValueKnownValues.Value_mostly_x20_cloudy:
                return "mostly cloudy";
            case TypeValueKnownValues.Value_intermittent_x20_clouds:
                return "intermittent clouds";
            case TypeValueKnownValues.Value_scattered_x20_clouds:
                return "scattered clouds";
            case TypeValueKnownValues.Value_small_x20_hail:
                return "small hail";
            case TypeValueKnownValues.Value_squals:
                return "squals";
            case TypeValueKnownValues.Value_funnel_x20_cloud:
                return "funnel cloud";
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
            case TypeValueKnownValues.Value_unknown_x20_precipitation:
                return "unknown precipitation";
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
            throw new Exception("The value for field Value of CurrentConditionsShortPhraseJSON is not a string.");
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
            case 'b':
                if (String.Compare(json_string.getData(), 1, "lowing ", 0, 7, false) == 0)
                  {
                    switch (json_string.getData()[8])
                      {
                        case 's':
                            switch (json_string.getData()[9])
                              {
                                case 'a':
                                    if ((String.Compare(json_string.getData(), 10, "nd", 0, 2, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_blowing_x20_sand;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'n':
                                    if ((String.Compare(json_string.getData(), 10, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_blowing_x20_snow;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'w':
                            if ((String.Compare(json_string.getData(), 9, "idespread dust", 0, 14, false) == 0) && (json_string.getData().Length == 23))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_blowing_x20_widespread_x20_dust;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'c':
                if (String.Compare(json_string.getData(), 1, "l", 0, 1, false) == 0)
                  {
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
                  }
                break;
            case 'd':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "nse fog", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_dense_x20_fog;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "izzle", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_drizzle;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "st whirls", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_dust_x20_whirls;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'f':
                switch (json_string.getData()[1])
                  {
                    case 'o':
                        if (String.Compare(json_string.getData(), 2, "g", 0, 1, false) == 0)
                          {
                            if (json_string.getData().Length == 3)
                              {
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_fog;
                                    goto open_enum_is_done;
                                  }
                              }
                            switch (json_string.getData()[3])
                              {
                                case ' ':
                                    if ((String.Compare(json_string.getData(), 4, "patches", 0, 7, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_fog_x20_patches;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(json_string.getData(), 2, "eezing ", 0, 7, false) == 0)
                          {
                            switch (json_string.getData()[9])
                              {
                                case 'd':
                                    if ((String.Compare(json_string.getData(), 10, "rizzle", 0, 6, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_freezing_x20_drizzle;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'f':
                                    if ((String.Compare(json_string.getData(), 10, "og", 0, 2, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_freezing_x20_fog;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'r':
                                    if ((String.Compare(json_string.getData(), 10, "ain", 0, 3, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_freezing_x20_rain;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "nnel cloud", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_funnel_x20_cloud;
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
                        switch (json_string.getData()[2])
                          {
                            case 'i':
                                if (String.Compare(json_string.getData(), 3, "l", 0, 1, false) == 0)
                                  {
                                    if (json_string.getData().Length == 4)
                                      {
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_hail;
                                            goto open_enum_is_done;
                                          }
                                      }
                                    switch (json_string.getData()[4])
                                      {
                                        case ' ':
                                            if ((String.Compare(json_string.getData(), 5, "showers", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_hail_x20_showers;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'z':
                                if ((String.Compare(json_string.getData(), 3, "e", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_haze;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "avy ", 0, 4, false) == 0)
                          {
                            switch (json_string.getData()[6])
                              {
                                case 'b':
                                    if (String.Compare(json_string.getData(), 7, "lowing ", 0, 7, false) == 0)
                                      {
                                        switch (json_string.getData()[14])
                                          {
                                            case 's':
                                                switch (json_string.getData()[15])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(json_string.getData(), 16, "nd", 0, 2, false) == 0) && (json_string.getData().Length == 18))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_blowing_x20_sand;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'n':
                                                        if ((String.Compare(json_string.getData(), 16, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 18))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_blowing_x20_snow;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'w':
                                                if ((String.Compare(json_string.getData(), 15, "idespread dust", 0, 14, false) == 0) && (json_string.getData().Length == 29))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_blowing_x20_widespread_x20_dust;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'd':
                                    switch (json_string.getData()[7])
                                      {
                                        case 'r':
                                            if ((String.Compare(json_string.getData(), 8, "izzle", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_drizzle;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'u':
                                            if ((String.Compare(json_string.getData(), 8, "st whirls", 0, 9, false) == 0) && (json_string.getData().Length == 17))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_dust_x20_whirls;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'f':
                                    switch (json_string.getData()[7])
                                      {
                                        case 'o':
                                            if (String.Compare(json_string.getData(), 8, "g", 0, 1, false) == 0)
                                              {
                                                if (json_string.getData().Length == 9)
                                                  {
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_fog;
                                                        goto open_enum_is_done;
                                                      }
                                                  }
                                                switch (json_string.getData()[9])
                                                  {
                                                    case ' ':
                                                        if ((String.Compare(json_string.getData(), 10, "patches", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_fog_x20_patches;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'r':
                                            if (String.Compare(json_string.getData(), 8, "eezing ", 0, 7, false) == 0)
                                              {
                                                switch (json_string.getData()[15])
                                                  {
                                                    case 'd':
                                                        if ((String.Compare(json_string.getData(), 16, "rizzle", 0, 6, false) == 0) && (json_string.getData().Length == 22))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_freezing_x20_drizzle;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'f':
                                                        if ((String.Compare(json_string.getData(), 16, "og", 0, 2, false) == 0) && (json_string.getData().Length == 18))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_freezing_x20_fog;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'r':
                                                        if ((String.Compare(json_string.getData(), 16, "ain", 0, 3, false) == 0) && (json_string.getData().Length == 19))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_freezing_x20_rain;
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
                                case 'h':
                                    if (String.Compare(json_string.getData(), 7, "a", 0, 1, false) == 0)
                                      {
                                        switch (json_string.getData()[8])
                                          {
                                            case 'i':
                                                if (String.Compare(json_string.getData(), 9, "l", 0, 1, false) == 0)
                                                  {
                                                    if (json_string.getData().Length == 10)
                                                      {
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_hail;
                                                            goto open_enum_is_done;
                                                          }
                                                      }
                                                    switch (json_string.getData()[10])
                                                      {
                                                        case ' ':
                                                            if ((String.Compare(json_string.getData(), 11, "showers", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_hail_x20_showers;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'z':
                                                if ((String.Compare(json_string.getData(), 9, "e", 0, 1, false) == 0) && (json_string.getData().Length == 10))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_haze;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'i':
                                    if (String.Compare(json_string.getData(), 7, "ce ", 0, 3, false) == 0)
                                      {
                                        switch (json_string.getData()[10])
                                          {
                                            case 'c':
                                                if ((String.Compare(json_string.getData(), 11, "rystals", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_ice_x20_crystals;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'p':
                                                if (String.Compare(json_string.getData(), 11, "ellet", 0, 5, false) == 0)
                                                  {
                                                    switch (json_string.getData()[16])
                                                      {
                                                        case ' ':
                                                            if ((String.Compare(json_string.getData(), 17, "showers", 0, 7, false) == 0) && (json_string.getData().Length == 24))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_ice_x20_pellet_x20_showers;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 's':
                                                            if (json_string.getData().Length == 17)
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_ice_x20_pellets;
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
                                    if (String.Compare(json_string.getData(), 7, "ow drifting ", 0, 12, false) == 0)
                                      {
                                        switch (json_string.getData()[19])
                                          {
                                            case 's':
                                                switch (json_string.getData()[20])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(json_string.getData(), 21, "nd", 0, 2, false) == 0) && (json_string.getData().Length == 23))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_low_x20_drifting_x20_sand;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'n':
                                                        if ((String.Compare(json_string.getData(), 21, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 23))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_low_x20_drifting_x20_snow;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'w':
                                                if ((String.Compare(json_string.getData(), 20, "idespread dust", 0, 14, false) == 0) && (json_string.getData().Length == 34))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_low_x20_drifting_x20_widespread_x20_dust;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'm':
                                    if ((String.Compare(json_string.getData(), 7, "ist", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_mist;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'r':
                                    if (String.Compare(json_string.getData(), 7, "ain", 0, 3, false) == 0)
                                      {
                                        if (json_string.getData().Length == 10)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_rain;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[10])
                                          {
                                            case ' ':
                                                switch (json_string.getData()[11])
                                                  {
                                                    case 'm':
                                                        if ((String.Compare(json_string.getData(), 12, "ist", 0, 3, false) == 0) && (json_string.getData().Length == 15))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_rain_x20_mist;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 's':
                                                        if (String.Compare(json_string.getData(), 12, "hower", 0, 5, false) == 0)
                                                          {
                                                            if (json_string.getData().Length == 17)
                                                              {
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_rain_x20_shower;
                                                                    goto open_enum_is_done;
                                                                  }
                                                              }
                                                            switch (json_string.getData()[17])
                                                              {
                                                                case 's':
                                                                    if (json_string.getData().Length == 18)
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_rain_x20_showers;
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
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 's':
                                    switch (json_string.getData()[7])
                                      {
                                        case 'a':
                                            if (String.Compare(json_string.getData(), 8, "nd", 0, 2, false) == 0)
                                              {
                                                if (json_string.getData().Length == 10)
                                                  {
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_sand;
                                                        goto open_enum_is_done;
                                                      }
                                                  }
                                                switch (json_string.getData()[10])
                                                  {
                                                    case 's':
                                                        if ((String.Compare(json_string.getData(), 11, "torm", 0, 4, false) == 0) && (json_string.getData().Length == 15))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_sandstorm;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'm':
                                            switch (json_string.getData()[8])
                                              {
                                                case 'a':
                                                    if ((String.Compare(json_string.getData(), 9, "ll hail showers", 0, 15, false) == 0) && (json_string.getData().Length == 24))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_small_x20_hail_x20_showers;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'o':
                                                    if ((String.Compare(json_string.getData(), 9, "ke", 0, 2, false) == 0) && (json_string.getData().Length == 11))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_smoke;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'n':
                                            if (String.Compare(json_string.getData(), 8, "ow", 0, 2, false) == 0)
                                              {
                                                if (json_string.getData().Length == 10)
                                                  {
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_snow;
                                                        goto open_enum_is_done;
                                                      }
                                                  }
                                                switch (json_string.getData()[10])
                                                  {
                                                    case ' ':
                                                        switch (json_string.getData()[11])
                                                          {
                                                            case 'a':
                                                                if ((String.Compare(json_string.getData(), 12, "nd fog", 0, 6, false) == 0) && (json_string.getData().Length == 18))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_snow_x20_and_x20_fog;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'b':
                                                                if (String.Compare(json_string.getData(), 12, "lowing", 0, 6, false) == 0)
                                                                  {
                                                                    if (json_string.getData().Length == 18)
                                                                      {
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_snow_x20_blowing;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                      }
                                                                    switch (json_string.getData()[18])
                                                                      {
                                                                        case ' ':
                                                                            if ((String.Compare(json_string.getData(), 19, "snow mist", 0, 9, false) == 0) && (json_string.getData().Length == 28))
                                                                                  {
                                                                                    the_open_enum.in_known_list = true;
                                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_snow_x20_blowing_x20_snow_x20_mist;
                                                                                    goto open_enum_is_done;
                                                                                  }
                                                                            break;
                                                                        default:
                                                                            break;
                                                                      }
                                                                  }
                                                                break;
                                                            case 'g':
                                                                if ((String.Compare(json_string.getData(), 12, "rains", 0, 5, false) == 0) && (json_string.getData().Length == 17))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_snow_x20_grains;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'm':
                                                                if ((String.Compare(json_string.getData(), 12, "ist", 0, 3, false) == 0) && (json_string.getData().Length == 15))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_snow_x20_mist;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 's':
                                                                if ((String.Compare(json_string.getData(), 12, "howers", 0, 6, false) == 0) && (json_string.getData().Length == 18))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_snow_x20_showers;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
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
                                        case 'p':
                                            if ((String.Compare(json_string.getData(), 8, "ray", 0, 3, false) == 0) && (json_string.getData().Length == 11))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_spray;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 't':
                                    if (String.Compare(json_string.getData(), 7, "hunderstorm", 0, 11, false) == 0)
                                      {
                                        if (json_string.getData().Length == 18)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_thunderstorm;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[18])
                                          {
                                            case 's':
                                                if (String.Compare(json_string.getData(), 19, " and ", 0, 5, false) == 0)
                                                  {
                                                    switch (json_string.getData()[24])
                                                      {
                                                        case 'h':
                                                            if ((String.Compare(json_string.getData(), 25, "ail", 0, 3, false) == 0) && (json_string.getData().Length == 28))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_hail;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'i':
                                                            if ((String.Compare(json_string.getData(), 25, "ce pellets", 0, 10, false) == 0) && (json_string.getData().Length == 35))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_ice_x20_pellets;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'r':
                                                            if ((String.Compare(json_string.getData(), 25, "ain", 0, 3, false) == 0) && (json_string.getData().Length == 28))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_rain;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 's':
                                                            switch (json_string.getData()[25])
                                                              {
                                                                case 'm':
                                                                    if ((String.Compare(json_string.getData(), 26, "all hail", 0, 8, false) == 0) && (json_string.getData().Length == 34))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_small_x20_hail;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'n':
                                                                    if ((String.Compare(json_string.getData(), 26, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 28))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_snow;
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
                                      }
                                    break;
                                case 'v':
                                    if ((String.Compare(json_string.getData(), 7, "olcanic ash", 0, 11, false) == 0) && (json_string.getData().Length == 18))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_volcanic_x20_ash;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'w':
                                    if ((String.Compare(json_string.getData(), 7, "idespread dust", 0, 14, false) == 0) && (json_string.getData().Length == 21))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_heavy_x20_widespread_x20_dust;
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
            case 'i':
                switch (json_string.getData()[1])
                  {
                    case 'c':
                        if (String.Compare(json_string.getData(), 2, "e ", 0, 2, false) == 0)
                          {
                            switch (json_string.getData()[4])
                              {
                                case 'c':
                                    if ((String.Compare(json_string.getData(), 5, "rystals", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_ice_x20_crystals;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'p':
                                    if (String.Compare(json_string.getData(), 5, "ellet", 0, 5, false) == 0)
                                      {
                                        switch (json_string.getData()[10])
                                          {
                                            case ' ':
                                                if ((String.Compare(json_string.getData(), 11, "showers", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_ice_x20_pellet_x20_showers;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 's':
                                                if (json_string.getData().Length == 11)
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_ice_x20_pellets;
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
                    case 'n':
                        if ((String.Compare(json_string.getData(), 2, "termittent clouds", 0, 17, false) == 0) && (json_string.getData().Length == 19))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_intermittent_x20_clouds;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'l':
                switch (json_string.getData()[1])
                  {
                    case 'i':
                        if (String.Compare(json_string.getData(), 2, "ght ", 0, 4, false) == 0)
                          {
                            switch (json_string.getData()[6])
                              {
                                case 'b':
                                    if (String.Compare(json_string.getData(), 7, "lowing ", 0, 7, false) == 0)
                                      {
                                        switch (json_string.getData()[14])
                                          {
                                            case 's':
                                                switch (json_string.getData()[15])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(json_string.getData(), 16, "nd", 0, 2, false) == 0) && (json_string.getData().Length == 18))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_blowing_x20_sand;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'n':
                                                        if ((String.Compare(json_string.getData(), 16, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 18))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_blowing_x20_snow;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'w':
                                                if ((String.Compare(json_string.getData(), 15, "idespread dust", 0, 14, false) == 0) && (json_string.getData().Length == 29))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_blowing_x20_widespread_x20_dust;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'd':
                                    switch (json_string.getData()[7])
                                      {
                                        case 'r':
                                            if ((String.Compare(json_string.getData(), 8, "izzle", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_drizzle;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'u':
                                            if ((String.Compare(json_string.getData(), 8, "st whirls", 0, 9, false) == 0) && (json_string.getData().Length == 17))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_dust_x20_whirls;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'f':
                                    switch (json_string.getData()[7])
                                      {
                                        case 'o':
                                            if (String.Compare(json_string.getData(), 8, "g", 0, 1, false) == 0)
                                              {
                                                if (json_string.getData().Length == 9)
                                                  {
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_fog;
                                                        goto open_enum_is_done;
                                                      }
                                                  }
                                                switch (json_string.getData()[9])
                                                  {
                                                    case ' ':
                                                        if ((String.Compare(json_string.getData(), 10, "patches", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_fog_x20_patches;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'r':
                                            if (String.Compare(json_string.getData(), 8, "eezing ", 0, 7, false) == 0)
                                              {
                                                switch (json_string.getData()[15])
                                                  {
                                                    case 'd':
                                                        if ((String.Compare(json_string.getData(), 16, "rizzle", 0, 6, false) == 0) && (json_string.getData().Length == 22))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_freezing_x20_drizzle;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'f':
                                                        if ((String.Compare(json_string.getData(), 16, "og", 0, 2, false) == 0) && (json_string.getData().Length == 18))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_freezing_x20_fog;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'r':
                                                        if ((String.Compare(json_string.getData(), 16, "ain", 0, 3, false) == 0) && (json_string.getData().Length == 19))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_freezing_x20_rain;
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
                                case 'h':
                                    if (String.Compare(json_string.getData(), 7, "a", 0, 1, false) == 0)
                                      {
                                        switch (json_string.getData()[8])
                                          {
                                            case 'i':
                                                if (String.Compare(json_string.getData(), 9, "l", 0, 1, false) == 0)
                                                  {
                                                    if (json_string.getData().Length == 10)
                                                      {
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_hail;
                                                            goto open_enum_is_done;
                                                          }
                                                      }
                                                    switch (json_string.getData()[10])
                                                      {
                                                        case ' ':
                                                            if ((String.Compare(json_string.getData(), 11, "showers", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_hail_x20_showers;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'z':
                                                if ((String.Compare(json_string.getData(), 9, "e", 0, 1, false) == 0) && (json_string.getData().Length == 10))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_haze;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'i':
                                    if (String.Compare(json_string.getData(), 7, "ce ", 0, 3, false) == 0)
                                      {
                                        switch (json_string.getData()[10])
                                          {
                                            case 'c':
                                                if ((String.Compare(json_string.getData(), 11, "rystals", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_ice_x20_crystals;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'p':
                                                if (String.Compare(json_string.getData(), 11, "ellet", 0, 5, false) == 0)
                                                  {
                                                    switch (json_string.getData()[16])
                                                      {
                                                        case ' ':
                                                            if ((String.Compare(json_string.getData(), 17, "showers", 0, 7, false) == 0) && (json_string.getData().Length == 24))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_ice_x20_pellet_x20_showers;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 's':
                                                            if (json_string.getData().Length == 17)
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_ice_x20_pellets;
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
                                    if (String.Compare(json_string.getData(), 7, "ow drifting ", 0, 12, false) == 0)
                                      {
                                        switch (json_string.getData()[19])
                                          {
                                            case 's':
                                                switch (json_string.getData()[20])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(json_string.getData(), 21, "nd", 0, 2, false) == 0) && (json_string.getData().Length == 23))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_low_x20_drifting_x20_sand;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'n':
                                                        if ((String.Compare(json_string.getData(), 21, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 23))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_low_x20_drifting_x20_snow;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'w':
                                                if ((String.Compare(json_string.getData(), 20, "idespread dust", 0, 14, false) == 0) && (json_string.getData().Length == 34))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_low_x20_drifting_x20_widespread_x20_dust;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'm':
                                    if ((String.Compare(json_string.getData(), 7, "ist", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_mist;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'r':
                                    if (String.Compare(json_string.getData(), 7, "ain", 0, 3, false) == 0)
                                      {
                                        if (json_string.getData().Length == 10)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_rain;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[10])
                                          {
                                            case ' ':
                                                switch (json_string.getData()[11])
                                                  {
                                                    case 'm':
                                                        if ((String.Compare(json_string.getData(), 12, "ist", 0, 3, false) == 0) && (json_string.getData().Length == 15))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_rain_x20_mist;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 's':
                                                        if (String.Compare(json_string.getData(), 12, "hower", 0, 5, false) == 0)
                                                          {
                                                            if (json_string.getData().Length == 17)
                                                              {
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_rain_x20_shower;
                                                                    goto open_enum_is_done;
                                                                  }
                                                              }
                                                            switch (json_string.getData()[17])
                                                              {
                                                                case 's':
                                                                    if (json_string.getData().Length == 18)
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_rain_x20_showers;
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
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 's':
                                    switch (json_string.getData()[7])
                                      {
                                        case 'a':
                                            if (String.Compare(json_string.getData(), 8, "nd", 0, 2, false) == 0)
                                              {
                                                if (json_string.getData().Length == 10)
                                                  {
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_sand;
                                                        goto open_enum_is_done;
                                                      }
                                                  }
                                                switch (json_string.getData()[10])
                                                  {
                                                    case 's':
                                                        if ((String.Compare(json_string.getData(), 11, "torm", 0, 4, false) == 0) && (json_string.getData().Length == 15))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_sandstorm;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'm':
                                            switch (json_string.getData()[8])
                                              {
                                                case 'a':
                                                    if ((String.Compare(json_string.getData(), 9, "ll hail showers", 0, 15, false) == 0) && (json_string.getData().Length == 24))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_small_x20_hail_x20_showers;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'o':
                                                    if ((String.Compare(json_string.getData(), 9, "ke", 0, 2, false) == 0) && (json_string.getData().Length == 11))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_smoke;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'n':
                                            if (String.Compare(json_string.getData(), 8, "ow", 0, 2, false) == 0)
                                              {
                                                if (json_string.getData().Length == 10)
                                                  {
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_snow;
                                                        goto open_enum_is_done;
                                                      }
                                                  }
                                                switch (json_string.getData()[10])
                                                  {
                                                    case ' ':
                                                        switch (json_string.getData()[11])
                                                          {
                                                            case 'a':
                                                                if ((String.Compare(json_string.getData(), 12, "nd fog", 0, 6, false) == 0) && (json_string.getData().Length == 18))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_snow_x20_and_x20_fog;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'b':
                                                                if (String.Compare(json_string.getData(), 12, "lowing", 0, 6, false) == 0)
                                                                  {
                                                                    if (json_string.getData().Length == 18)
                                                                      {
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_snow_x20_blowing;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                      }
                                                                    switch (json_string.getData()[18])
                                                                      {
                                                                        case ' ':
                                                                            if ((String.Compare(json_string.getData(), 19, "snow mist", 0, 9, false) == 0) && (json_string.getData().Length == 28))
                                                                                  {
                                                                                    the_open_enum.in_known_list = true;
                                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_snow_x20_blowing_x20_snow_x20_mist;
                                                                                    goto open_enum_is_done;
                                                                                  }
                                                                            break;
                                                                        default:
                                                                            break;
                                                                      }
                                                                  }
                                                                break;
                                                            case 'g':
                                                                if ((String.Compare(json_string.getData(), 12, "rains", 0, 5, false) == 0) && (json_string.getData().Length == 17))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_snow_x20_grains;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'm':
                                                                if ((String.Compare(json_string.getData(), 12, "ist", 0, 3, false) == 0) && (json_string.getData().Length == 15))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_snow_x20_mist;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 's':
                                                                if ((String.Compare(json_string.getData(), 12, "howers", 0, 6, false) == 0) && (json_string.getData().Length == 18))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_snow_x20_showers;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
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
                                        case 'p':
                                            if ((String.Compare(json_string.getData(), 8, "ray", 0, 3, false) == 0) && (json_string.getData().Length == 11))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_spray;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 't':
                                    if (String.Compare(json_string.getData(), 7, "hunderstorm", 0, 11, false) == 0)
                                      {
                                        if (json_string.getData().Length == 18)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_thunderstorm;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[18])
                                          {
                                            case 's':
                                                if (String.Compare(json_string.getData(), 19, " and ", 0, 5, false) == 0)
                                                  {
                                                    switch (json_string.getData()[24])
                                                      {
                                                        case 'h':
                                                            if ((String.Compare(json_string.getData(), 25, "ail", 0, 3, false) == 0) && (json_string.getData().Length == 28))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_hail;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'i':
                                                            if ((String.Compare(json_string.getData(), 25, "ce pellets", 0, 10, false) == 0) && (json_string.getData().Length == 35))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_ice_x20_pellets;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'r':
                                                            if ((String.Compare(json_string.getData(), 25, "ain", 0, 3, false) == 0) && (json_string.getData().Length == 28))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_rain;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 's':
                                                            switch (json_string.getData()[25])
                                                              {
                                                                case 'm':
                                                                    if ((String.Compare(json_string.getData(), 26, "all hail", 0, 8, false) == 0) && (json_string.getData().Length == 34))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_small_x20_hail;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'n':
                                                                    if ((String.Compare(json_string.getData(), 26, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 28))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_snow;
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
                                      }
                                    break;
                                case 'v':
                                    if ((String.Compare(json_string.getData(), 7, "olcanic ash", 0, 11, false) == 0) && (json_string.getData().Length == 18))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_volcanic_x20_ash;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'w':
                                    if ((String.Compare(json_string.getData(), 7, "idespread dust", 0, 14, false) == 0) && (json_string.getData().Length == 21))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_light_x20_widespread_x20_dust;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if (String.Compare(json_string.getData(), 2, "w drifting ", 0, 11, false) == 0)
                          {
                            switch (json_string.getData()[13])
                              {
                                case 's':
                                    switch (json_string.getData()[14])
                                      {
                                        case 'a':
                                            if ((String.Compare(json_string.getData(), 15, "nd", 0, 2, false) == 0) && (json_string.getData().Length == 17))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_low_x20_drifting_x20_sand;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'n':
                                            if ((String.Compare(json_string.getData(), 15, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 17))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_low_x20_drifting_x20_snow;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'w':
                                    if ((String.Compare(json_string.getData(), 14, "idespread dust", 0, 14, false) == 0) && (json_string.getData().Length == 28))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_low_x20_drifting_x20_widespread_x20_dust;
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
            case 'm':
                switch (json_string.getData()[1])
                  {
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "st", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_mist;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if (String.Compare(json_string.getData(), 2, "stly ", 0, 5, false) == 0)
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
                                                if ((String.Compare(json_string.getData(), 10, "udy", 0, 3, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_mostly_x20_cloudy;
                                                        goto open_enum_is_done;
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
                    default:
                        break;
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
                if (String.Compare(json_string.getData(), 1, "a", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'r':
                            if (String.Compare(json_string.getData(), 3, "t", 0, 1, false) == 0)
                              {
                                switch (json_string.getData()[4])
                                  {
                                    case 'i':
                                        if ((String.Compare(json_string.getData(), 5, "al fog", 0, 6, false) == 0) && (json_string.getData().Length == 11))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_partial_x20_fog;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'l':
                                        if (String.Compare(json_string.getData(), 5, "y ", 0, 2, false) == 0)
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
                                                                if (String.Compare(json_string.getData(), 14, "with ", 0, 5, false) == 0)
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
                                                    if ((String.Compare(json_string.getData(), 8, "unny", 0, 4, false) == 0) && (json_string.getData().Length == 12))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_partly_x20_sunny;
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
                        case 't':
                            if ((String.Compare(json_string.getData(), 3, "ches of fog", 0, 11, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_patches_x20_of_x20_fog;
                                    goto open_enum_is_done;
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
                            switch (json_string.getData()[5])
                              {
                                case 'a':
                                    if ((String.Compare(json_string.getData(), 6, "nd snow", 0, 7, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_rain_x20_and_x20_snow;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'm':
                                    if ((String.Compare(json_string.getData(), 6, "ist", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_rain_x20_mist;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 's':
                                    if ((String.Compare(json_string.getData(), 6, "howers", 0, 6, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_rain_x20_showers;
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
            case 's':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if (String.Compare(json_string.getData(), 2, "nd", 0, 2, false) == 0)
                          {
                            if (json_string.getData().Length == 4)
                              {
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_sand;
                                    goto open_enum_is_done;
                                  }
                              }
                            switch (json_string.getData()[4])
                              {
                                case 's':
                                    if ((String.Compare(json_string.getData(), 5, "torm", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_sandstorm;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'c':
                        if ((String.Compare(json_string.getData(), 2, "attered clouds", 0, 14, false) == 0) && (json_string.getData().Length == 16))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_scattered_x20_clouds;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'h':
                        switch (json_string.getData()[2])
                          {
                            case 'a':
                                if ((String.Compare(json_string.getData(), 3, "llow fog", 0, 8, false) == 0) && (json_string.getData().Length == 11))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_shallow_x20_fog;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'o':
                                if ((String.Compare(json_string.getData(), 3, "wer", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_shower;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'm':
                        switch (json_string.getData()[2])
                          {
                            case 'a':
                                if (String.Compare(json_string.getData(), 3, "ll hail", 0, 7, false) == 0)
                                  {
                                    if (json_string.getData().Length == 10)
                                      {
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_small_x20_hail;
                                            goto open_enum_is_done;
                                          }
                                      }
                                    switch (json_string.getData()[10])
                                      {
                                        case ' ':
                                            if ((String.Compare(json_string.getData(), 11, "showers", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_small_x20_hail_x20_showers;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'o':
                                if ((String.Compare(json_string.getData(), 3, "ke", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_smoke;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
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
                                    switch (json_string.getData()[5])
                                      {
                                        case 'a':
                                            if ((String.Compare(json_string.getData(), 6, "nd fog", 0, 6, false) == 0) && (json_string.getData().Length == 12))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_snow_x20_and_x20_fog;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'b':
                                            if (String.Compare(json_string.getData(), 6, "lowing", 0, 6, false) == 0)
                                              {
                                                if (json_string.getData().Length == 12)
                                                  {
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_snow_x20_blowing;
                                                        goto open_enum_is_done;
                                                      }
                                                  }
                                                switch (json_string.getData()[12])
                                                  {
                                                    case ' ':
                                                        if ((String.Compare(json_string.getData(), 13, "snow mist", 0, 9, false) == 0) && (json_string.getData().Length == 22))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_snow_x20_blowing_x20_snow_x20_mist;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'g':
                                            if ((String.Compare(json_string.getData(), 6, "rains", 0, 5, false) == 0) && (json_string.getData().Length == 11))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_snow_x20_grains;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'm':
                                            if ((String.Compare(json_string.getData(), 6, "ist", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_snow_x20_mist;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 's':
                                            if ((String.Compare(json_string.getData(), 6, "howers", 0, 6, false) == 0) && (json_string.getData().Length == 12))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_snow_x20_showers;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
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
                    case 'p':
                        if ((String.Compare(json_string.getData(), 2, "ray", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_spray;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'q':
                        if ((String.Compare(json_string.getData(), 2, "uals", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_squals;
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
                                        if (String.Compare(json_string.getData(), 13, " and ", 0, 5, false) == 0)
                                          {
                                            switch (json_string.getData()[18])
                                              {
                                                case 'h':
                                                    if ((String.Compare(json_string.getData(), 19, "ail", 0, 3, false) == 0) && (json_string.getData().Length == 22))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_thunderstorms_x20_and_x20_hail;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'i':
                                                    if ((String.Compare(json_string.getData(), 19, "ce pellets", 0, 10, false) == 0) && (json_string.getData().Length == 29))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_thunderstorms_x20_and_x20_ice_x20_pellets;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'r':
                                                    if ((String.Compare(json_string.getData(), 19, "ain", 0, 3, false) == 0) && (json_string.getData().Length == 22))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_thunderstorms_x20_and_x20_rain;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 's':
                                                    switch (json_string.getData()[19])
                                                      {
                                                        case 'm':
                                                            if ((String.Compare(json_string.getData(), 20, "all hail", 0, 8, false) == 0) && (json_string.getData().Length == 28))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_thunderstorms_x20_and_x20_small_x20_hail;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'n':
                                                            if ((String.Compare(json_string.getData(), 20, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 22))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_thunderstorms_x20_and_x20_snow;
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
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'u':
                if (String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0)
                  {
                    if (json_string.getData().Length == 7)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeValueKnownValues.Value_unknown;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[7])
                      {
                        case ' ':
                            if ((String.Compare(json_string.getData(), 8, "precipitation", 0, 13, false) == 0) && (json_string.getData().Length == 21))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_unknown_x20_precipitation;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'v':
                if ((String.Compare(json_string.getData(), 1, "olcanic ash", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_volcanic_x20_ash;
                        goto open_enum_is_done;
                      }
                break;
            case 'w':
                if ((String.Compare(json_string.getData(), 1, "idespread dust", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_widespread_x20_dust;
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


    public CurrentConditionsShortPhraseJSON()
      {
        flagHasValue = false;
      }

    public CurrentConditionsShortPhraseJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public CurrentConditionsShortPhraseJSON(string init_value)
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

    public CurrentConditionsShortPhraseJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_drizzle:
                    handler.string_value("drizzle");
                    break;
                case TypeValueKnownValues.Value_rain:
                    handler.string_value("rain");
                    break;
                case TypeValueKnownValues.Value_snow:
                    handler.string_value("snow");
                    break;
                case TypeValueKnownValues.Value_rain_x20_and_x20_snow:
                    handler.string_value("rain and snow");
                    break;
                case TypeValueKnownValues.Value_snow_x20_grains:
                    handler.string_value("snow grains");
                    break;
                case TypeValueKnownValues.Value_ice_x20_crystals:
                    handler.string_value("ice crystals");
                    break;
                case TypeValueKnownValues.Value_ice_x20_pellets:
                    handler.string_value("ice pellets");
                    break;
                case TypeValueKnownValues.Value_hail:
                    handler.string_value("hail");
                    break;
                case TypeValueKnownValues.Value_mist:
                    handler.string_value("mist");
                    break;
                case TypeValueKnownValues.Value_fog:
                    handler.string_value("fog");
                    break;
                case TypeValueKnownValues.Value_fog_x20_patches:
                    handler.string_value("fog patches");
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
                case TypeValueKnownValues.Value_smoke:
                    handler.string_value("smoke");
                    break;
                case TypeValueKnownValues.Value_volcanic_x20_ash:
                    handler.string_value("volcanic ash");
                    break;
                case TypeValueKnownValues.Value_widespread_x20_dust:
                    handler.string_value("widespread dust");
                    break;
                case TypeValueKnownValues.Value_sand:
                    handler.string_value("sand");
                    break;
                case TypeValueKnownValues.Value_haze:
                    handler.string_value("haze");
                    break;
                case TypeValueKnownValues.Value_spray:
                    handler.string_value("spray");
                    break;
                case TypeValueKnownValues.Value_dust_x20_whirls:
                    handler.string_value("dust whirls");
                    break;
                case TypeValueKnownValues.Value_sandstorm:
                    handler.string_value("sandstorm");
                    break;
                case TypeValueKnownValues.Value_low_x20_drifting_x20_snow:
                    handler.string_value("low drifting snow");
                    break;
                case TypeValueKnownValues.Value_low_x20_drifting_x20_widespread_x20_dust:
                    handler.string_value("low drifting widespread dust");
                    break;
                case TypeValueKnownValues.Value_low_x20_drifting_x20_sand:
                    handler.string_value("low drifting sand");
                    break;
                case TypeValueKnownValues.Value_blowing_x20_snow:
                    handler.string_value("blowing snow");
                    break;
                case TypeValueKnownValues.Value_blowing_x20_widespread_x20_dust:
                    handler.string_value("blowing widespread dust");
                    break;
                case TypeValueKnownValues.Value_blowing_x20_sand:
                    handler.string_value("blowing sand");
                    break;
                case TypeValueKnownValues.Value_a_x20_shower:
                    handler.string_value("a shower");
                    break;
                case TypeValueKnownValues.Value_shower:
                    handler.string_value("shower");
                    break;
                case TypeValueKnownValues.Value_rain_x20_mist:
                    handler.string_value("rain mist");
                    break;
                case TypeValueKnownValues.Value_rain_x20_showers:
                    handler.string_value("rain showers");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_rain_x20_shower:
                    handler.string_value("heavy rain shower");
                    break;
                case TypeValueKnownValues.Value_light_x20_rain_x20_shower:
                    handler.string_value("light rain shower");
                    break;
                case TypeValueKnownValues.Value_snow_x20_showers:
                    handler.string_value("snow showers");
                    break;
                case TypeValueKnownValues.Value_snow_x20_blowing:
                    handler.string_value("snow blowing");
                    break;
                case TypeValueKnownValues.Value_snow_x20_mist:
                    handler.string_value("snow mist");
                    break;
                case TypeValueKnownValues.Value_snow_x20_blowing_x20_snow_x20_mist:
                    handler.string_value("snow blowing snow mist");
                    break;
                case TypeValueKnownValues.Value_ice_x20_pellet_x20_showers:
                    handler.string_value("ice pellet showers");
                    break;
                case TypeValueKnownValues.Value_hail_x20_showers:
                    handler.string_value("hail showers");
                    break;
                case TypeValueKnownValues.Value_small_x20_hail_x20_showers:
                    handler.string_value("small hail showers");
                    break;
                case TypeValueKnownValues.Value_thunderstorm:
                    handler.string_value("thunderstorm");
                    break;
                case TypeValueKnownValues.Value_thunderstorms_x20_and_x20_rain:
                    handler.string_value("thunderstorms and rain");
                    break;
                case TypeValueKnownValues.Value_thunderstorms_x20_and_x20_snow:
                    handler.string_value("thunderstorms and snow");
                    break;
                case TypeValueKnownValues.Value_thunderstorms_x20_and_x20_ice_x20_pellets:
                    handler.string_value("thunderstorms and ice pellets");
                    break;
                case TypeValueKnownValues.Value_thunderstorms_x20_and_x20_hail:
                    handler.string_value("thunderstorms and hail");
                    break;
                case TypeValueKnownValues.Value_thunderstorms_x20_and_x20_small_x20_hail:
                    handler.string_value("thunderstorms and small hail");
                    break;
                case TypeValueKnownValues.Value_freezing_x20_drizzle:
                    handler.string_value("freezing drizzle");
                    break;
                case TypeValueKnownValues.Value_freezing_x20_rain:
                    handler.string_value("freezing rain");
                    break;
                case TypeValueKnownValues.Value_freezing_x20_fog:
                    handler.string_value("freezing fog");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_drizzle:
                    handler.string_value("heavy drizzle");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_rain:
                    handler.string_value("heavy rain");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_snow:
                    handler.string_value("heavy snow");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_snow_x20_grains:
                    handler.string_value("heavy snow grains");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_ice_x20_crystals:
                    handler.string_value("heavy ice crystals");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_ice_x20_pellets:
                    handler.string_value("heavy ice pellets");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_hail:
                    handler.string_value("heavy hail");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_mist:
                    handler.string_value("heavy mist");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_fog:
                    handler.string_value("heavy fog");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_fog_x20_patches:
                    handler.string_value("heavy fog patches");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_smoke:
                    handler.string_value("heavy smoke");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_volcanic_x20_ash:
                    handler.string_value("heavy volcanic ash");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_widespread_x20_dust:
                    handler.string_value("heavy widespread dust");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_sand:
                    handler.string_value("heavy sand");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_haze:
                    handler.string_value("heavy haze");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_spray:
                    handler.string_value("heavy spray");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_dust_x20_whirls:
                    handler.string_value("heavy dust whirls");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_sandstorm:
                    handler.string_value("heavy sandstorm");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_low_x20_drifting_x20_snow:
                    handler.string_value("heavy low drifting snow");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_low_x20_drifting_x20_widespread_x20_dust:
                    handler.string_value("heavy low drifting widespread dust");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_low_x20_drifting_x20_sand:
                    handler.string_value("heavy low drifting sand");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_blowing_x20_snow:
                    handler.string_value("heavy blowing snow");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_blowing_x20_widespread_x20_dust:
                    handler.string_value("heavy blowing widespread dust");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_blowing_x20_sand:
                    handler.string_value("heavy blowing sand");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_rain_x20_mist:
                    handler.string_value("heavy rain mist");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_rain_x20_showers:
                    handler.string_value("heavy rain showers");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_snow_x20_showers:
                    handler.string_value("heavy snow showers");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_snow_x20_blowing:
                    handler.string_value("heavy snow blowing");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_snow_x20_mist:
                    handler.string_value("heavy snow mist");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_snow_x20_blowing_x20_snow_x20_mist:
                    handler.string_value("heavy snow blowing snow mist");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_ice_x20_pellet_x20_showers:
                    handler.string_value("heavy ice pellet showers");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_hail_x20_showers:
                    handler.string_value("heavy hail showers");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_small_x20_hail_x20_showers:
                    handler.string_value("heavy small hail showers");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_thunderstorm:
                    handler.string_value("heavy thunderstorm");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_rain:
                    handler.string_value("heavy thunderstorms and rain");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_snow:
                    handler.string_value("heavy thunderstorms and snow");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_ice_x20_pellets:
                    handler.string_value("heavy thunderstorms and ice pellets");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_hail:
                    handler.string_value("heavy thunderstorms and hail");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_small_x20_hail:
                    handler.string_value("heavy thunderstorms and small hail");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_freezing_x20_drizzle:
                    handler.string_value("heavy freezing drizzle");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_freezing_x20_rain:
                    handler.string_value("heavy freezing rain");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_freezing_x20_fog:
                    handler.string_value("heavy freezing fog");
                    break;
                case TypeValueKnownValues.Value_light_x20_drizzle:
                    handler.string_value("light drizzle");
                    break;
                case TypeValueKnownValues.Value_light_x20_rain:
                    handler.string_value("light rain");
                    break;
                case TypeValueKnownValues.Value_light_x20_snow:
                    handler.string_value("light snow");
                    break;
                case TypeValueKnownValues.Value_light_x20_snow_x20_grains:
                    handler.string_value("light snow grains");
                    break;
                case TypeValueKnownValues.Value_light_x20_ice_x20_crystals:
                    handler.string_value("light ice crystals");
                    break;
                case TypeValueKnownValues.Value_light_x20_ice_x20_pellets:
                    handler.string_value("light ice pellets");
                    break;
                case TypeValueKnownValues.Value_light_x20_hail:
                    handler.string_value("light hail");
                    break;
                case TypeValueKnownValues.Value_light_x20_mist:
                    handler.string_value("light mist");
                    break;
                case TypeValueKnownValues.Value_light_x20_fog:
                    handler.string_value("light fog");
                    break;
                case TypeValueKnownValues.Value_light_x20_fog_x20_patches:
                    handler.string_value("light fog patches");
                    break;
                case TypeValueKnownValues.Value_light_x20_smoke:
                    handler.string_value("light smoke");
                    break;
                case TypeValueKnownValues.Value_light_x20_volcanic_x20_ash:
                    handler.string_value("light volcanic ash");
                    break;
                case TypeValueKnownValues.Value_light_x20_widespread_x20_dust:
                    handler.string_value("light widespread dust");
                    break;
                case TypeValueKnownValues.Value_light_x20_sand:
                    handler.string_value("light sand");
                    break;
                case TypeValueKnownValues.Value_light_x20_haze:
                    handler.string_value("light haze");
                    break;
                case TypeValueKnownValues.Value_light_x20_spray:
                    handler.string_value("light spray");
                    break;
                case TypeValueKnownValues.Value_light_x20_dust_x20_whirls:
                    handler.string_value("light dust whirls");
                    break;
                case TypeValueKnownValues.Value_light_x20_sandstorm:
                    handler.string_value("light sandstorm");
                    break;
                case TypeValueKnownValues.Value_light_x20_low_x20_drifting_x20_snow:
                    handler.string_value("light low drifting snow");
                    break;
                case TypeValueKnownValues.Value_light_x20_low_x20_drifting_x20_widespread_x20_dust:
                    handler.string_value("light low drifting widespread dust");
                    break;
                case TypeValueKnownValues.Value_light_x20_low_x20_drifting_x20_sand:
                    handler.string_value("light low drifting sand");
                    break;
                case TypeValueKnownValues.Value_light_x20_blowing_x20_snow:
                    handler.string_value("light blowing snow");
                    break;
                case TypeValueKnownValues.Value_light_x20_blowing_x20_widespread_x20_dust:
                    handler.string_value("light blowing widespread dust");
                    break;
                case TypeValueKnownValues.Value_light_x20_blowing_x20_sand:
                    handler.string_value("light blowing sand");
                    break;
                case TypeValueKnownValues.Value_light_x20_rain_x20_mist:
                    handler.string_value("light rain mist");
                    break;
                case TypeValueKnownValues.Value_light_x20_rain_x20_showers:
                    handler.string_value("light rain showers");
                    break;
                case TypeValueKnownValues.Value_light_x20_snow_x20_showers:
                    handler.string_value("light snow showers");
                    break;
                case TypeValueKnownValues.Value_light_x20_snow_x20_blowing:
                    handler.string_value("light snow blowing");
                    break;
                case TypeValueKnownValues.Value_light_x20_snow_x20_mist:
                    handler.string_value("light snow mist");
                    break;
                case TypeValueKnownValues.Value_light_x20_snow_x20_blowing_x20_snow_x20_mist:
                    handler.string_value("light snow blowing snow mist");
                    break;
                case TypeValueKnownValues.Value_light_x20_ice_x20_pellet_x20_showers:
                    handler.string_value("light ice pellet showers");
                    break;
                case TypeValueKnownValues.Value_light_x20_hail_x20_showers:
                    handler.string_value("light hail showers");
                    break;
                case TypeValueKnownValues.Value_light_x20_small_x20_hail_x20_showers:
                    handler.string_value("light small hail showers");
                    break;
                case TypeValueKnownValues.Value_light_x20_thunderstorm:
                    handler.string_value("light thunderstorm");
                    break;
                case TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_rain:
                    handler.string_value("light thunderstorms and rain");
                    break;
                case TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_snow:
                    handler.string_value("light thunderstorms and snow");
                    break;
                case TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_ice_x20_pellets:
                    handler.string_value("light thunderstorms and ice pellets");
                    break;
                case TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_hail:
                    handler.string_value("light thunderstorms and hail");
                    break;
                case TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_small_x20_hail:
                    handler.string_value("light thunderstorms and small hail");
                    break;
                case TypeValueKnownValues.Value_light_x20_freezing_x20_drizzle:
                    handler.string_value("light freezing drizzle");
                    break;
                case TypeValueKnownValues.Value_light_x20_freezing_x20_rain:
                    handler.string_value("light freezing rain");
                    break;
                case TypeValueKnownValues.Value_light_x20_freezing_x20_fog:
                    handler.string_value("light freezing fog");
                    break;
                case TypeValueKnownValues.Value_patches_x20_of_x20_fog:
                    handler.string_value("patches of fog");
                    break;
                case TypeValueKnownValues.Value_shallow_x20_fog:
                    handler.string_value("shallow fog");
                    break;
                case TypeValueKnownValues.Value_dense_x20_fog:
                    handler.string_value("dense fog");
                    break;
                case TypeValueKnownValues.Value_partial_x20_fog:
                    handler.string_value("partial fog");
                    break;
                case TypeValueKnownValues.Value_overcast:
                    handler.string_value("overcast");
                    break;
                case TypeValueKnownValues.Value_clouds_x20_and_x20_sun:
                    handler.string_value("clouds and sun");
                    break;
                case TypeValueKnownValues.Value_clear:
                    handler.string_value("clear");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_clear:
                    handler.string_value("mostly clear");
                    break;
                case TypeValueKnownValues.Value_sunny:
                    handler.string_value("sunny");
                    break;
                case TypeValueKnownValues.Value_partly_x20_sunny:
                    handler.string_value("partly sunny");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_sunny:
                    handler.string_value("mostly sunny");
                    break;
                case TypeValueKnownValues.Value_cloudy:
                    handler.string_value("cloudy");
                    break;
                case TypeValueKnownValues.Value_some_x20_clouds:
                    handler.string_value("some clouds");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy:
                    handler.string_value("partly cloudy");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_cloudy:
                    handler.string_value("mostly cloudy");
                    break;
                case TypeValueKnownValues.Value_intermittent_x20_clouds:
                    handler.string_value("intermittent clouds");
                    break;
                case TypeValueKnownValues.Value_scattered_x20_clouds:
                    handler.string_value("scattered clouds");
                    break;
                case TypeValueKnownValues.Value_small_x20_hail:
                    handler.string_value("small hail");
                    break;
                case TypeValueKnownValues.Value_squals:
                    handler.string_value("squals");
                    break;
                case TypeValueKnownValues.Value_funnel_x20_cloud:
                    handler.string_value("funnel cloud");
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
                case TypeValueKnownValues.Value_unknown_x20_precipitation:
                    handler.string_value("unknown precipitation");
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
                case TypeValueKnownValues.Value_drizzle:
                    handler.string_value("drizzle");
                    break;
                case TypeValueKnownValues.Value_rain:
                    handler.string_value("rain");
                    break;
                case TypeValueKnownValues.Value_snow:
                    handler.string_value("snow");
                    break;
                case TypeValueKnownValues.Value_rain_x20_and_x20_snow:
                    handler.string_value("rain and snow");
                    break;
                case TypeValueKnownValues.Value_snow_x20_grains:
                    handler.string_value("snow grains");
                    break;
                case TypeValueKnownValues.Value_ice_x20_crystals:
                    handler.string_value("ice crystals");
                    break;
                case TypeValueKnownValues.Value_ice_x20_pellets:
                    handler.string_value("ice pellets");
                    break;
                case TypeValueKnownValues.Value_hail:
                    handler.string_value("hail");
                    break;
                case TypeValueKnownValues.Value_mist:
                    handler.string_value("mist");
                    break;
                case TypeValueKnownValues.Value_fog:
                    handler.string_value("fog");
                    break;
                case TypeValueKnownValues.Value_fog_x20_patches:
                    handler.string_value("fog patches");
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
                case TypeValueKnownValues.Value_smoke:
                    handler.string_value("smoke");
                    break;
                case TypeValueKnownValues.Value_volcanic_x20_ash:
                    handler.string_value("volcanic ash");
                    break;
                case TypeValueKnownValues.Value_widespread_x20_dust:
                    handler.string_value("widespread dust");
                    break;
                case TypeValueKnownValues.Value_sand:
                    handler.string_value("sand");
                    break;
                case TypeValueKnownValues.Value_haze:
                    handler.string_value("haze");
                    break;
                case TypeValueKnownValues.Value_spray:
                    handler.string_value("spray");
                    break;
                case TypeValueKnownValues.Value_dust_x20_whirls:
                    handler.string_value("dust whirls");
                    break;
                case TypeValueKnownValues.Value_sandstorm:
                    handler.string_value("sandstorm");
                    break;
                case TypeValueKnownValues.Value_low_x20_drifting_x20_snow:
                    handler.string_value("low drifting snow");
                    break;
                case TypeValueKnownValues.Value_low_x20_drifting_x20_widespread_x20_dust:
                    handler.string_value("low drifting widespread dust");
                    break;
                case TypeValueKnownValues.Value_low_x20_drifting_x20_sand:
                    handler.string_value("low drifting sand");
                    break;
                case TypeValueKnownValues.Value_blowing_x20_snow:
                    handler.string_value("blowing snow");
                    break;
                case TypeValueKnownValues.Value_blowing_x20_widespread_x20_dust:
                    handler.string_value("blowing widespread dust");
                    break;
                case TypeValueKnownValues.Value_blowing_x20_sand:
                    handler.string_value("blowing sand");
                    break;
                case TypeValueKnownValues.Value_a_x20_shower:
                    handler.string_value("a shower");
                    break;
                case TypeValueKnownValues.Value_shower:
                    handler.string_value("shower");
                    break;
                case TypeValueKnownValues.Value_rain_x20_mist:
                    handler.string_value("rain mist");
                    break;
                case TypeValueKnownValues.Value_rain_x20_showers:
                    handler.string_value("rain showers");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_rain_x20_shower:
                    handler.string_value("heavy rain shower");
                    break;
                case TypeValueKnownValues.Value_light_x20_rain_x20_shower:
                    handler.string_value("light rain shower");
                    break;
                case TypeValueKnownValues.Value_snow_x20_showers:
                    handler.string_value("snow showers");
                    break;
                case TypeValueKnownValues.Value_snow_x20_blowing:
                    handler.string_value("snow blowing");
                    break;
                case TypeValueKnownValues.Value_snow_x20_mist:
                    handler.string_value("snow mist");
                    break;
                case TypeValueKnownValues.Value_snow_x20_blowing_x20_snow_x20_mist:
                    handler.string_value("snow blowing snow mist");
                    break;
                case TypeValueKnownValues.Value_ice_x20_pellet_x20_showers:
                    handler.string_value("ice pellet showers");
                    break;
                case TypeValueKnownValues.Value_hail_x20_showers:
                    handler.string_value("hail showers");
                    break;
                case TypeValueKnownValues.Value_small_x20_hail_x20_showers:
                    handler.string_value("small hail showers");
                    break;
                case TypeValueKnownValues.Value_thunderstorm:
                    handler.string_value("thunderstorm");
                    break;
                case TypeValueKnownValues.Value_thunderstorms_x20_and_x20_rain:
                    handler.string_value("thunderstorms and rain");
                    break;
                case TypeValueKnownValues.Value_thunderstorms_x20_and_x20_snow:
                    handler.string_value("thunderstorms and snow");
                    break;
                case TypeValueKnownValues.Value_thunderstorms_x20_and_x20_ice_x20_pellets:
                    handler.string_value("thunderstorms and ice pellets");
                    break;
                case TypeValueKnownValues.Value_thunderstorms_x20_and_x20_hail:
                    handler.string_value("thunderstorms and hail");
                    break;
                case TypeValueKnownValues.Value_thunderstorms_x20_and_x20_small_x20_hail:
                    handler.string_value("thunderstorms and small hail");
                    break;
                case TypeValueKnownValues.Value_freezing_x20_drizzle:
                    handler.string_value("freezing drizzle");
                    break;
                case TypeValueKnownValues.Value_freezing_x20_rain:
                    handler.string_value("freezing rain");
                    break;
                case TypeValueKnownValues.Value_freezing_x20_fog:
                    handler.string_value("freezing fog");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_drizzle:
                    handler.string_value("heavy drizzle");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_rain:
                    handler.string_value("heavy rain");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_snow:
                    handler.string_value("heavy snow");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_snow_x20_grains:
                    handler.string_value("heavy snow grains");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_ice_x20_crystals:
                    handler.string_value("heavy ice crystals");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_ice_x20_pellets:
                    handler.string_value("heavy ice pellets");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_hail:
                    handler.string_value("heavy hail");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_mist:
                    handler.string_value("heavy mist");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_fog:
                    handler.string_value("heavy fog");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_fog_x20_patches:
                    handler.string_value("heavy fog patches");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_smoke:
                    handler.string_value("heavy smoke");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_volcanic_x20_ash:
                    handler.string_value("heavy volcanic ash");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_widespread_x20_dust:
                    handler.string_value("heavy widespread dust");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_sand:
                    handler.string_value("heavy sand");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_haze:
                    handler.string_value("heavy haze");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_spray:
                    handler.string_value("heavy spray");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_dust_x20_whirls:
                    handler.string_value("heavy dust whirls");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_sandstorm:
                    handler.string_value("heavy sandstorm");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_low_x20_drifting_x20_snow:
                    handler.string_value("heavy low drifting snow");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_low_x20_drifting_x20_widespread_x20_dust:
                    handler.string_value("heavy low drifting widespread dust");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_low_x20_drifting_x20_sand:
                    handler.string_value("heavy low drifting sand");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_blowing_x20_snow:
                    handler.string_value("heavy blowing snow");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_blowing_x20_widespread_x20_dust:
                    handler.string_value("heavy blowing widespread dust");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_blowing_x20_sand:
                    handler.string_value("heavy blowing sand");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_rain_x20_mist:
                    handler.string_value("heavy rain mist");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_rain_x20_showers:
                    handler.string_value("heavy rain showers");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_snow_x20_showers:
                    handler.string_value("heavy snow showers");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_snow_x20_blowing:
                    handler.string_value("heavy snow blowing");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_snow_x20_mist:
                    handler.string_value("heavy snow mist");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_snow_x20_blowing_x20_snow_x20_mist:
                    handler.string_value("heavy snow blowing snow mist");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_ice_x20_pellet_x20_showers:
                    handler.string_value("heavy ice pellet showers");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_hail_x20_showers:
                    handler.string_value("heavy hail showers");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_small_x20_hail_x20_showers:
                    handler.string_value("heavy small hail showers");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_thunderstorm:
                    handler.string_value("heavy thunderstorm");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_rain:
                    handler.string_value("heavy thunderstorms and rain");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_snow:
                    handler.string_value("heavy thunderstorms and snow");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_ice_x20_pellets:
                    handler.string_value("heavy thunderstorms and ice pellets");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_hail:
                    handler.string_value("heavy thunderstorms and hail");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_thunderstorms_x20_and_x20_small_x20_hail:
                    handler.string_value("heavy thunderstorms and small hail");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_freezing_x20_drizzle:
                    handler.string_value("heavy freezing drizzle");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_freezing_x20_rain:
                    handler.string_value("heavy freezing rain");
                    break;
                case TypeValueKnownValues.Value_heavy_x20_freezing_x20_fog:
                    handler.string_value("heavy freezing fog");
                    break;
                case TypeValueKnownValues.Value_light_x20_drizzle:
                    handler.string_value("light drizzle");
                    break;
                case TypeValueKnownValues.Value_light_x20_rain:
                    handler.string_value("light rain");
                    break;
                case TypeValueKnownValues.Value_light_x20_snow:
                    handler.string_value("light snow");
                    break;
                case TypeValueKnownValues.Value_light_x20_snow_x20_grains:
                    handler.string_value("light snow grains");
                    break;
                case TypeValueKnownValues.Value_light_x20_ice_x20_crystals:
                    handler.string_value("light ice crystals");
                    break;
                case TypeValueKnownValues.Value_light_x20_ice_x20_pellets:
                    handler.string_value("light ice pellets");
                    break;
                case TypeValueKnownValues.Value_light_x20_hail:
                    handler.string_value("light hail");
                    break;
                case TypeValueKnownValues.Value_light_x20_mist:
                    handler.string_value("light mist");
                    break;
                case TypeValueKnownValues.Value_light_x20_fog:
                    handler.string_value("light fog");
                    break;
                case TypeValueKnownValues.Value_light_x20_fog_x20_patches:
                    handler.string_value("light fog patches");
                    break;
                case TypeValueKnownValues.Value_light_x20_smoke:
                    handler.string_value("light smoke");
                    break;
                case TypeValueKnownValues.Value_light_x20_volcanic_x20_ash:
                    handler.string_value("light volcanic ash");
                    break;
                case TypeValueKnownValues.Value_light_x20_widespread_x20_dust:
                    handler.string_value("light widespread dust");
                    break;
                case TypeValueKnownValues.Value_light_x20_sand:
                    handler.string_value("light sand");
                    break;
                case TypeValueKnownValues.Value_light_x20_haze:
                    handler.string_value("light haze");
                    break;
                case TypeValueKnownValues.Value_light_x20_spray:
                    handler.string_value("light spray");
                    break;
                case TypeValueKnownValues.Value_light_x20_dust_x20_whirls:
                    handler.string_value("light dust whirls");
                    break;
                case TypeValueKnownValues.Value_light_x20_sandstorm:
                    handler.string_value("light sandstorm");
                    break;
                case TypeValueKnownValues.Value_light_x20_low_x20_drifting_x20_snow:
                    handler.string_value("light low drifting snow");
                    break;
                case TypeValueKnownValues.Value_light_x20_low_x20_drifting_x20_widespread_x20_dust:
                    handler.string_value("light low drifting widespread dust");
                    break;
                case TypeValueKnownValues.Value_light_x20_low_x20_drifting_x20_sand:
                    handler.string_value("light low drifting sand");
                    break;
                case TypeValueKnownValues.Value_light_x20_blowing_x20_snow:
                    handler.string_value("light blowing snow");
                    break;
                case TypeValueKnownValues.Value_light_x20_blowing_x20_widespread_x20_dust:
                    handler.string_value("light blowing widespread dust");
                    break;
                case TypeValueKnownValues.Value_light_x20_blowing_x20_sand:
                    handler.string_value("light blowing sand");
                    break;
                case TypeValueKnownValues.Value_light_x20_rain_x20_mist:
                    handler.string_value("light rain mist");
                    break;
                case TypeValueKnownValues.Value_light_x20_rain_x20_showers:
                    handler.string_value("light rain showers");
                    break;
                case TypeValueKnownValues.Value_light_x20_snow_x20_showers:
                    handler.string_value("light snow showers");
                    break;
                case TypeValueKnownValues.Value_light_x20_snow_x20_blowing:
                    handler.string_value("light snow blowing");
                    break;
                case TypeValueKnownValues.Value_light_x20_snow_x20_mist:
                    handler.string_value("light snow mist");
                    break;
                case TypeValueKnownValues.Value_light_x20_snow_x20_blowing_x20_snow_x20_mist:
                    handler.string_value("light snow blowing snow mist");
                    break;
                case TypeValueKnownValues.Value_light_x20_ice_x20_pellet_x20_showers:
                    handler.string_value("light ice pellet showers");
                    break;
                case TypeValueKnownValues.Value_light_x20_hail_x20_showers:
                    handler.string_value("light hail showers");
                    break;
                case TypeValueKnownValues.Value_light_x20_small_x20_hail_x20_showers:
                    handler.string_value("light small hail showers");
                    break;
                case TypeValueKnownValues.Value_light_x20_thunderstorm:
                    handler.string_value("light thunderstorm");
                    break;
                case TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_rain:
                    handler.string_value("light thunderstorms and rain");
                    break;
                case TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_snow:
                    handler.string_value("light thunderstorms and snow");
                    break;
                case TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_ice_x20_pellets:
                    handler.string_value("light thunderstorms and ice pellets");
                    break;
                case TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_hail:
                    handler.string_value("light thunderstorms and hail");
                    break;
                case TypeValueKnownValues.Value_light_x20_thunderstorms_x20_and_x20_small_x20_hail:
                    handler.string_value("light thunderstorms and small hail");
                    break;
                case TypeValueKnownValues.Value_light_x20_freezing_x20_drizzle:
                    handler.string_value("light freezing drizzle");
                    break;
                case TypeValueKnownValues.Value_light_x20_freezing_x20_rain:
                    handler.string_value("light freezing rain");
                    break;
                case TypeValueKnownValues.Value_light_x20_freezing_x20_fog:
                    handler.string_value("light freezing fog");
                    break;
                case TypeValueKnownValues.Value_patches_x20_of_x20_fog:
                    handler.string_value("patches of fog");
                    break;
                case TypeValueKnownValues.Value_shallow_x20_fog:
                    handler.string_value("shallow fog");
                    break;
                case TypeValueKnownValues.Value_dense_x20_fog:
                    handler.string_value("dense fog");
                    break;
                case TypeValueKnownValues.Value_partial_x20_fog:
                    handler.string_value("partial fog");
                    break;
                case TypeValueKnownValues.Value_overcast:
                    handler.string_value("overcast");
                    break;
                case TypeValueKnownValues.Value_clouds_x20_and_x20_sun:
                    handler.string_value("clouds and sun");
                    break;
                case TypeValueKnownValues.Value_clear:
                    handler.string_value("clear");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_clear:
                    handler.string_value("mostly clear");
                    break;
                case TypeValueKnownValues.Value_sunny:
                    handler.string_value("sunny");
                    break;
                case TypeValueKnownValues.Value_partly_x20_sunny:
                    handler.string_value("partly sunny");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_sunny:
                    handler.string_value("mostly sunny");
                    break;
                case TypeValueKnownValues.Value_cloudy:
                    handler.string_value("cloudy");
                    break;
                case TypeValueKnownValues.Value_some_x20_clouds:
                    handler.string_value("some clouds");
                    break;
                case TypeValueKnownValues.Value_partly_x20_cloudy:
                    handler.string_value("partly cloudy");
                    break;
                case TypeValueKnownValues.Value_mostly_x20_cloudy:
                    handler.string_value("mostly cloudy");
                    break;
                case TypeValueKnownValues.Value_intermittent_x20_clouds:
                    handler.string_value("intermittent clouds");
                    break;
                case TypeValueKnownValues.Value_scattered_x20_clouds:
                    handler.string_value("scattered clouds");
                    break;
                case TypeValueKnownValues.Value_small_x20_hail:
                    handler.string_value("small hail");
                    break;
                case TypeValueKnownValues.Value_squals:
                    handler.string_value("squals");
                    break;
                case TypeValueKnownValues.Value_funnel_x20_cloud:
                    handler.string_value("funnel cloud");
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
                case TypeValueKnownValues.Value_unknown_x20_precipitation:
                    handler.string_value("unknown precipitation");
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

    public static CurrentConditionsShortPhraseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CurrentConditionsShortPhraseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrentConditionsShortPhrase", ignore_extras);
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
    public static CurrentConditionsShortPhraseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CurrentConditionsShortPhraseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CurrentConditionsShortPhraseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrentConditionsShortPhrase", ignore_extras);
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
    public static CurrentConditionsShortPhraseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CurrentConditionsShortPhraseJSON from_text(string text, bool ignore_extras)
      {
        CurrentConditionsShortPhraseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrentConditionsShortPhrase", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CurrentConditionsShortPhraseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CurrentConditionsShortPhraseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CurrentConditionsShortPhraseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrentConditionsShortPhrase", ignore_extras);
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
            CurrentConditionsShortPhraseJSON result = new CurrentConditionsShortPhraseJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(CurrentConditionsShortPhraseJSON new_result);
        public Generator(bool ignore_extras) : base("Type CurrentConditionsShortPhrase")
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
        protected override void handle_result(CurrentConditionsShortPhraseJSON  result)
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
        public CurrentConditionsShortPhraseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CurrentConditionsShortPhraseJSON  result)
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
    protected virtual void handle_result(List<CurrentConditionsShortPhraseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CurrentConditionsShortPhraseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CurrentConditionsShortPhraseJSON>();
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
    public List<CurrentConditionsShortPhraseJSON> value;
  };
  };
