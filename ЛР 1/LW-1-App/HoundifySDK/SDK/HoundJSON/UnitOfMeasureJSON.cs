/* file "UnitOfMeasureJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UnitOfMeasureJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_Unknown,
        Value_Fathom,
        Value_League,
        Value_LightYear,
        Value_AstronomicalUnit,
        Value_Parsec,
        Value_Angstrom,
        Value_Rope,
        Value_Perch,
        Value_Cubit,
        Value_Pole,
        Value_Ell,
        Value_Furlong,
        Value_Chain,
        Value_Rod,
        Value_Inch,
        Value_Foot,
        Value_Yard,
        Value_Mile,
        Value_NauticalMile,
        Value_Yoctometer,
        Value_Zeptometer,
        Value_Attometer,
        Value_Femtometer,
        Value_Picometer,
        Value_Nanometer,
        Value_Micrometer,
        Value_Millimeter,
        Value_Centimeter,
        Value_Decimeter,
        Value_Meter,
        Value_Decameter,
        Value_Hectometer,
        Value_Kilometer,
        Value_Megameter,
        Value_Gigameter,
        Value_Terameter,
        Value_Petameter,
        Value_Exameter,
        Value_Zettameter,
        Value_Yottameter,
        Value_Marathon,
        Value_HalfMarathon,
        Value_TenKRun,
        Value_FiveKRun,
        Value_OlympicPoolLap,
        Value_DegreeFahrenheit,
        Value_DegreeCelsius,
        Value_Kelvin,
        Value_Pascal,
        Value_Kilopascal,
        Value_Hectopascal,
        Value_Bar,
        Value_Millibar,
        Value_PoundPerSquareInch,
        Value_InchOfMercury,
        Value_Atmosphere,
        Value_Torr,
        Value_Bit,
        Value_Byte,
        Value_Kilobit,
        Value_Kilobyte,
        Value_Megabit,
        Value_Megabyte,
        Value_Gigabit,
        Value_Gigabyte,
        Value_Terabit,
        Value_Terabyte,
        Value_Petabit,
        Value_Petabyte,
        Value_Nanosecond,
        Value_Millisecond,
        Value_Microsecond,
        Value_Second,
        Value_Minute,
        Value_Hour,
        Value_Day,
        Value_Week,
        Value_Fortnight,
        Value_Month,
        Value_Year,
        Value_Decade,
        Value_Century,
        Value_Millenium,
        Value_SquareInch,
        Value_SquareFoot,
        Value_SquareYard,
        Value_SquareMile,
        Value_SquareMillimeter,
        Value_SquareCentimeter,
        Value_SquareMeter,
        Value_SquareKilometer,
        Value_Hectare,
        Value_Acre,
        Value_Yoctogram,
        Value_Zeptogram,
        Value_Attogram,
        Value_Femtogram,
        Value_Picogram,
        Value_Nanogram,
        Value_Microgram,
        Value_Milligram,
        Value_Centigram,
        Value_Decigram,
        Value_Gram,
        Value_Decagram,
        Value_Hectogram,
        Value_Kilogram,
        Value_Megagram,
        Value_Gigagram,
        Value_Teragram,
        Value_Petagram,
        Value_Exagram,
        Value_Zettagram,
        Value_Yottagram,
        Value_MetricTon,
        Value_OunceWeight,
        Value_Pound,
        Value_Grain,
        Value_Carat,
        Value_TroyPound,
        Value_TroyOunce,
        Value_PennyWeight,
        Value_Quarter,
        Value_Stone,
        Value_Ton,
        Value_LongTon,
        Value_CubicInch,
        Value_CubicFoot,
        Value_CubicMeter,
        Value_USTeaspoon,
        Value_UKTeaspoon,
        Value_USTablespoon,
        Value_UKTablespoon,
        Value_USOunceVolume,
        Value_UKOunceVolume,
        Value_Cup,
        Value_Shot,
        Value_USPint,
        Value_USLiquidQuart,
        Value_USDryQuart,
        Value_USGallon,
        Value_UKPint,
        Value_UKQuart,
        Value_UKGallon,
        Value_Milliliter,
        Value_CubicCentimeter,
        Value_Liter,
        Value_Yoctoliter,
        Value_Zeptoliter,
        Value_Attoliter,
        Value_Femtoliter,
        Value_Picoliter,
        Value_Nanoliter,
        Value_Microliter,
        Value_Centiliter,
        Value_Deciliter,
        Value_Decaliter,
        Value_Hectoliter,
        Value_Kiloliter,
        Value_Megaliter,
        Value_Gigaliter,
        Value_Teraliter,
        Value_Petaliter,
        Value_Exaliter,
        Value_Zettaliter,
        Value_Yottaliter,
        Value_USBushel,
        Value_UKBushel,
        Value_USPeck,
        Value_UKPeck,
        Value_USHogshead,
        Value_USBarrel,
        Value_USTierce,
        Value_Newton,
        Value_Kilonewton,
        Value_Dyne,
        Value_Poundal,
        Value_Pond,
        Value_Kilopond,
        Value_OunceForce,
        Value_PoundForce,
        Value_Joule,
        Value_Kilojoule,
        Value_Calorie,
        Value_Kilocalorie,
        Value_KilowattHour,
        Value_Btu,
        Value_Watt,
        Value_Kilowatt,
        Value_Horsepower,
        Value_MetricHorsepower,
        Value_FootPoundPerMinute,
        Value_ErgPerSecond,
        Value_CaloriesPerSecond,
        Value_MeterPerSecondSquared,
        Value_InchPerSecondSquared,
        Value_FootPerSecondSquared,
        Value_Galileo,
        Value_G,
        Value_KilometerPerHour,
        Value_MilePerHour,
        Value_FootPerSecond,
        Value_MeterPerSecond,
        Value_Knot,
        Value_Mach,
        Value_Yoctohertz,
        Value_Zeptohertz,
        Value_Attohertz,
        Value_Femtohertz,
        Value_Picohertz,
        Value_Nanohertz,
        Value_Microhertz,
        Value_Millihertz,
        Value_Centihertz,
        Value_Decihertz,
        Value_Hertz,
        Value_Decahertz,
        Value_Hectohertz,
        Value_Kilohertz,
        Value_Megahertz,
        Value_Gigahertz,
        Value_Terahertz,
        Value_Petahertz,
        Value_Exahertz,
        Value_Zettahertz,
        Value_Yottahertz,
        Value_Radian,
        Value_Degree,
        Value_Turn,
        Value_Quadrant,
        Value_Sextant,
        Value_MinuteOfArc,
        Value_SecondOfArc,
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
                    case 'c':
                        if ((String.Compare(chars, 2, "re", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Acre;
                        break;
                    case 'n':
                        if ((String.Compare(chars, 2, "gstrom", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeValueKnownValues.Value_Angstrom;
                        break;
                    case 's':
                        if ((String.Compare(chars, 2, "tronomicalUnit", 0, 14, false) == 0) && (chars.Length == 16))
                            return TypeValueKnownValues.Value_AstronomicalUnit;
                        break;
                    case 't':
                        switch (chars[2])
                          {
                            case 'm':
                                if ((String.Compare(chars, 3, "osphere", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeValueKnownValues.Value_Atmosphere;
                                break;
                            case 't':
                                if (String.Compare(chars, 3, "o", 0, 1, false) == 0)
                                  {
                                    switch (chars[4])
                                      {
                                        case 'g':
                                            if ((String.Compare(chars, 5, "ram", 0, 3, false) == 0) && (chars.Length == 8))
                                                return TypeValueKnownValues.Value_Attogram;
                                            break;
                                        case 'h':
                                            if ((String.Compare(chars, 5, "ertz", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Attohertz;
                                            break;
                                        case 'l':
                                            if ((String.Compare(chars, 5, "iter", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Attoliter;
                                            break;
                                        case 'm':
                                            if ((String.Compare(chars, 5, "eter", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Attometer;
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
            case 'B':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "r", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeValueKnownValues.Value_Bar;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "t", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeValueKnownValues.Value_Bit;
                        break;
                    case 't':
                        if ((String.Compare(chars, 2, "u", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeValueKnownValues.Value_Btu;
                        break;
                    case 'y':
                        if ((String.Compare(chars, 2, "te", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Byte;
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'l':
                                if (String.Compare(chars, 3, "orie", 0, 4, false) == 0)
                                  {
                                    if (chars.Length == 7)
                                      {
                                        return TypeValueKnownValues.Value_Calorie;
                                      }
                                    switch (chars[7])
                                      {
                                        case 's':
                                            if ((String.Compare(chars, 8, "PerSecond", 0, 9, false) == 0) && (chars.Length == 17))
                                                return TypeValueKnownValues.Value_CaloriesPerSecond;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'r':
                                if ((String.Compare(chars, 3, "at", 0, 2, false) == 0) && (chars.Length == 5))
                                    return TypeValueKnownValues.Value_Carat;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if (String.Compare(chars, 2, "nt", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'i':
                                    switch (chars[5])
                                      {
                                        case 'g':
                                            if ((String.Compare(chars, 6, "ram", 0, 3, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Centigram;
                                            break;
                                        case 'h':
                                            if ((String.Compare(chars, 6, "ertz", 0, 4, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_Centihertz;
                                            break;
                                        case 'l':
                                            if ((String.Compare(chars, 6, "iter", 0, 4, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_Centiliter;
                                            break;
                                        case 'm':
                                            if ((String.Compare(chars, 6, "eter", 0, 4, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_Centimeter;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'u':
                                    if ((String.Compare(chars, 5, "ry", 0, 2, false) == 0) && (chars.Length == 7))
                                        return TypeValueKnownValues.Value_Century;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'h':
                        if ((String.Compare(chars, 2, "ain", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValueKnownValues.Value_Chain;
                        break;
                    case 'u':
                        switch (chars[2])
                          {
                            case 'b':
                                if (String.Compare(chars, 3, "i", 0, 1, false) == 0)
                                  {
                                    switch (chars[4])
                                      {
                                        case 'c':
                                            switch (chars[5])
                                              {
                                                case 'C':
                                                    if ((String.Compare(chars, 6, "entimeter", 0, 9, false) == 0) && (chars.Length == 15))
                                                        return TypeValueKnownValues.Value_CubicCentimeter;
                                                    break;
                                                case 'F':
                                                    if ((String.Compare(chars, 6, "oot", 0, 3, false) == 0) && (chars.Length == 9))
                                                        return TypeValueKnownValues.Value_CubicFoot;
                                                    break;
                                                case 'I':
                                                    if ((String.Compare(chars, 6, "nch", 0, 3, false) == 0) && (chars.Length == 9))
                                                        return TypeValueKnownValues.Value_CubicInch;
                                                    break;
                                                case 'M':
                                                    if ((String.Compare(chars, 6, "eter", 0, 4, false) == 0) && (chars.Length == 10))
                                                        return TypeValueKnownValues.Value_CubicMeter;
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 't':
                                            if (chars.Length == 5)
                                                return TypeValueKnownValues.Value_Cubit;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'p':
                                if (chars.Length == 3)
                                    return TypeValueKnownValues.Value_Cup;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "y", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeValueKnownValues.Value_Day;
                        break;
                    case 'e':
                        switch (chars[2])
                          {
                            case 'c':
                                switch (chars[3])
                                  {
                                    case 'a':
                                        switch (chars[4])
                                          {
                                            case 'd':
                                                if ((String.Compare(chars, 5, "e", 0, 1, false) == 0) && (chars.Length == 6))
                                                    return TypeValueKnownValues.Value_Decade;
                                                break;
                                            case 'g':
                                                if ((String.Compare(chars, 5, "ram", 0, 3, false) == 0) && (chars.Length == 8))
                                                    return TypeValueKnownValues.Value_Decagram;
                                                break;
                                            case 'h':
                                                if ((String.Compare(chars, 5, "ertz", 0, 4, false) == 0) && (chars.Length == 9))
                                                    return TypeValueKnownValues.Value_Decahertz;
                                                break;
                                            case 'l':
                                                if ((String.Compare(chars, 5, "iter", 0, 4, false) == 0) && (chars.Length == 9))
                                                    return TypeValueKnownValues.Value_Decaliter;
                                                break;
                                            case 'm':
                                                if ((String.Compare(chars, 5, "eter", 0, 4, false) == 0) && (chars.Length == 9))
                                                    return TypeValueKnownValues.Value_Decameter;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'i':
                                        switch (chars[4])
                                          {
                                            case 'g':
                                                if ((String.Compare(chars, 5, "ram", 0, 3, false) == 0) && (chars.Length == 8))
                                                    return TypeValueKnownValues.Value_Decigram;
                                                break;
                                            case 'h':
                                                if ((String.Compare(chars, 5, "ertz", 0, 4, false) == 0) && (chars.Length == 9))
                                                    return TypeValueKnownValues.Value_Decihertz;
                                                break;
                                            case 'l':
                                                if ((String.Compare(chars, 5, "iter", 0, 4, false) == 0) && (chars.Length == 9))
                                                    return TypeValueKnownValues.Value_Deciliter;
                                                break;
                                            case 'm':
                                                if ((String.Compare(chars, 5, "eter", 0, 4, false) == 0) && (chars.Length == 9))
                                                    return TypeValueKnownValues.Value_Decimeter;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'g':
                                if (String.Compare(chars, 3, "ree", 0, 3, false) == 0)
                                  {
                                    if (chars.Length == 6)
                                      {
                                        return TypeValueKnownValues.Value_Degree;
                                      }
                                    switch (chars[6])
                                      {
                                        case 'C':
                                            if ((String.Compare(chars, 7, "elsius", 0, 6, false) == 0) && (chars.Length == 13))
                                                return TypeValueKnownValues.Value_DegreeCelsius;
                                            break;
                                        case 'F':
                                            if ((String.Compare(chars, 7, "ahrenheit", 0, 9, false) == 0) && (chars.Length == 16))
                                                return TypeValueKnownValues.Value_DegreeFahrenheit;
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
                    case 'y':
                        if ((String.Compare(chars, 2, "ne", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Dyne;
                        break;
                    default:
                        break;
                  }
                break;
            case 'E':
                switch (chars[1])
                  {
                    case 'l':
                        if ((String.Compare(chars, 2, "l", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeValueKnownValues.Value_Ell;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "gPerSecond", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeValueKnownValues.Value_ErgPerSecond;
                        break;
                    case 'x':
                        if (String.Compare(chars, 2, "a", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'g':
                                    if ((String.Compare(chars, 4, "ram", 0, 3, false) == 0) && (chars.Length == 7))
                                        return TypeValueKnownValues.Value_Exagram;
                                    break;
                                case 'h':
                                    if ((String.Compare(chars, 4, "ertz", 0, 4, false) == 0) && (chars.Length == 8))
                                        return TypeValueKnownValues.Value_Exahertz;
                                    break;
                                case 'l':
                                    if ((String.Compare(chars, 4, "iter", 0, 4, false) == 0) && (chars.Length == 8))
                                        return TypeValueKnownValues.Value_Exaliter;
                                    break;
                                case 'm':
                                    if ((String.Compare(chars, 4, "eter", 0, 4, false) == 0) && (chars.Length == 8))
                                        return TypeValueKnownValues.Value_Exameter;
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
            case 'F':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "thom", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_Fathom;
                        break;
                    case 'e':
                        if (String.Compare(chars, 2, "mto", 0, 3, false) == 0)
                          {
                            switch (chars[5])
                              {
                                case 'g':
                                    if ((String.Compare(chars, 6, "ram", 0, 3, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_Femtogram;
                                    break;
                                case 'h':
                                    if ((String.Compare(chars, 6, "ertz", 0, 4, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_Femtohertz;
                                    break;
                                case 'l':
                                    if ((String.Compare(chars, 6, "iter", 0, 4, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_Femtoliter;
                                    break;
                                case 'm':
                                    if ((String.Compare(chars, 6, "eter", 0, 4, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_Femtometer;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "veKRun", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeValueKnownValues.Value_FiveKRun;
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'o':
                                if (String.Compare(chars, 3, "t", 0, 1, false) == 0)
                                  {
                                    if (chars.Length == 4)
                                      {
                                        return TypeValueKnownValues.Value_Foot;
                                      }
                                    switch (chars[4])
                                      {
                                        case 'P':
                                            switch (chars[5])
                                              {
                                                case 'e':
                                                    if (String.Compare(chars, 6, "rSecond", 0, 7, false) == 0)
                                                      {
                                                        if (chars.Length == 13)
                                                          {
                                                            return TypeValueKnownValues.Value_FootPerSecond;
                                                          }
                                                        switch (chars[13])
                                                          {
                                                            case 'S':
                                                                if ((String.Compare(chars, 14, "quared", 0, 6, false) == 0) && (chars.Length == 20))
                                                                    return TypeValueKnownValues.Value_FootPerSecondSquared;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'o':
                                                    if ((String.Compare(chars, 6, "undPerMinute", 0, 12, false) == 0) && (chars.Length == 18))
                                                        return TypeValueKnownValues.Value_FootPoundPerMinute;
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
                            case 'r':
                                if ((String.Compare(chars, 3, "tnight", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeValueKnownValues.Value_Fortnight;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "rlong", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeValueKnownValues.Value_Furlong;
                        break;
                    default:
                        break;
                  }
                break;
            case 'G':
                if (chars.Length == 1)
                  {
                    return TypeValueKnownValues.Value_G;
                  }
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "lileo", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeValueKnownValues.Value_Galileo;
                        break;
                    case 'i':
                        if (String.Compare(chars, 2, "ga", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'b':
                                    switch (chars[5])
                                      {
                                        case 'i':
                                            if ((String.Compare(chars, 6, "t", 0, 1, false) == 0) && (chars.Length == 7))
                                                return TypeValueKnownValues.Value_Gigabit;
                                            break;
                                        case 'y':
                                            if ((String.Compare(chars, 6, "te", 0, 2, false) == 0) && (chars.Length == 8))
                                                return TypeValueKnownValues.Value_Gigabyte;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'g':
                                    if ((String.Compare(chars, 5, "ram", 0, 3, false) == 0) && (chars.Length == 8))
                                        return TypeValueKnownValues.Value_Gigagram;
                                    break;
                                case 'h':
                                    if ((String.Compare(chars, 5, "ertz", 0, 4, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_Gigahertz;
                                    break;
                                case 'l':
                                    if ((String.Compare(chars, 5, "iter", 0, 4, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_Gigaliter;
                                    break;
                                case 'm':
                                    if ((String.Compare(chars, 5, "eter", 0, 4, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_Gigameter;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(chars, 2, "a", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'i':
                                    if ((String.Compare(chars, 4, "n", 0, 1, false) == 0) && (chars.Length == 5))
                                        return TypeValueKnownValues.Value_Grain;
                                    break;
                                case 'm':
                                    if (chars.Length == 4)
                                        return TypeValueKnownValues.Value_Gram;
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
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "lfMarathon", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeValueKnownValues.Value_HalfMarathon;
                        break;
                    case 'e':
                        switch (chars[2])
                          {
                            case 'c':
                                if (String.Compare(chars, 3, "t", 0, 1, false) == 0)
                                  {
                                    switch (chars[4])
                                      {
                                        case 'a':
                                            if ((String.Compare(chars, 5, "re", 0, 2, false) == 0) && (chars.Length == 7))
                                                return TypeValueKnownValues.Value_Hectare;
                                            break;
                                        case 'o':
                                            switch (chars[5])
                                              {
                                                case 'g':
                                                    if ((String.Compare(chars, 6, "ram", 0, 3, false) == 0) && (chars.Length == 9))
                                                        return TypeValueKnownValues.Value_Hectogram;
                                                    break;
                                                case 'h':
                                                    if ((String.Compare(chars, 6, "ertz", 0, 4, false) == 0) && (chars.Length == 10))
                                                        return TypeValueKnownValues.Value_Hectohertz;
                                                    break;
                                                case 'l':
                                                    if ((String.Compare(chars, 6, "iter", 0, 4, false) == 0) && (chars.Length == 10))
                                                        return TypeValueKnownValues.Value_Hectoliter;
                                                    break;
                                                case 'm':
                                                    if ((String.Compare(chars, 6, "eter", 0, 4, false) == 0) && (chars.Length == 10))
                                                        return TypeValueKnownValues.Value_Hectometer;
                                                    break;
                                                case 'p':
                                                    if ((String.Compare(chars, 6, "ascal", 0, 5, false) == 0) && (chars.Length == 11))
                                                        return TypeValueKnownValues.Value_Hectopascal;
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
                            case 'r':
                                if ((String.Compare(chars, 3, "tz", 0, 2, false) == 0) && (chars.Length == 5))
                                    return TypeValueKnownValues.Value_Hertz;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'r':
                                if ((String.Compare(chars, 3, "sepower", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeValueKnownValues.Value_Horsepower;
                                break;
                            case 'u':
                                if ((String.Compare(chars, 3, "r", 0, 1, false) == 0) && (chars.Length == 4))
                                    return TypeValueKnownValues.Value_Hour;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'I':
                if (String.Compare(chars, 1, "nch", 0, 3, false) == 0)
                  {
                    if (chars.Length == 4)
                      {
                        return TypeValueKnownValues.Value_Inch;
                      }
                    switch (chars[4])
                      {
                        case 'O':
                            if ((String.Compare(chars, 5, "fMercury", 0, 8, false) == 0) && (chars.Length == 13))
                                return TypeValueKnownValues.Value_InchOfMercury;
                            break;
                        case 'P':
                            if ((String.Compare(chars, 5, "erSecondSquared", 0, 15, false) == 0) && (chars.Length == 20))
                                return TypeValueKnownValues.Value_InchPerSecondSquared;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'J':
                if ((String.Compare(chars, 1, "oule", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeValueKnownValues.Value_Joule;
                break;
            case 'K':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "lvin", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_Kelvin;
                        break;
                    case 'i':
                        if (String.Compare(chars, 2, "lo", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'b':
                                    switch (chars[5])
                                      {
                                        case 'i':
                                            if ((String.Compare(chars, 6, "t", 0, 1, false) == 0) && (chars.Length == 7))
                                                return TypeValueKnownValues.Value_Kilobit;
                                            break;
                                        case 'y':
                                            if ((String.Compare(chars, 6, "te", 0, 2, false) == 0) && (chars.Length == 8))
                                                return TypeValueKnownValues.Value_Kilobyte;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'c':
                                    if ((String.Compare(chars, 5, "alorie", 0, 6, false) == 0) && (chars.Length == 11))
                                        return TypeValueKnownValues.Value_Kilocalorie;
                                    break;
                                case 'g':
                                    if ((String.Compare(chars, 5, "ram", 0, 3, false) == 0) && (chars.Length == 8))
                                        return TypeValueKnownValues.Value_Kilogram;
                                    break;
                                case 'h':
                                    if ((String.Compare(chars, 5, "ertz", 0, 4, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_Kilohertz;
                                    break;
                                case 'j':
                                    if ((String.Compare(chars, 5, "oule", 0, 4, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_Kilojoule;
                                    break;
                                case 'l':
                                    if ((String.Compare(chars, 5, "iter", 0, 4, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_Kiloliter;
                                    break;
                                case 'm':
                                    if (String.Compare(chars, 5, "eter", 0, 4, false) == 0)
                                      {
                                        if (chars.Length == 9)
                                          {
                                            return TypeValueKnownValues.Value_Kilometer;
                                          }
                                        switch (chars[9])
                                          {
                                            case 'P':
                                                if ((String.Compare(chars, 10, "erHour", 0, 6, false) == 0) && (chars.Length == 16))
                                                    return TypeValueKnownValues.Value_KilometerPerHour;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'n':
                                    if ((String.Compare(chars, 5, "ewton", 0, 5, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_Kilonewton;
                                    break;
                                case 'p':
                                    switch (chars[5])
                                      {
                                        case 'a':
                                            if ((String.Compare(chars, 6, "scal", 0, 4, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_Kilopascal;
                                            break;
                                        case 'o':
                                            if ((String.Compare(chars, 6, "nd", 0, 2, false) == 0) && (chars.Length == 8))
                                                return TypeValueKnownValues.Value_Kilopond;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'w':
                                    if (String.Compare(chars, 5, "att", 0, 3, false) == 0)
                                      {
                                        if (chars.Length == 8)
                                          {
                                            return TypeValueKnownValues.Value_Kilowatt;
                                          }
                                        switch (chars[8])
                                          {
                                            case 'H':
                                                if ((String.Compare(chars, 9, "our", 0, 3, false) == 0) && (chars.Length == 12))
                                                    return TypeValueKnownValues.Value_KilowattHour;
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
                        if ((String.Compare(chars, 2, "ot", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Knot;
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "ague", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_League;
                        break;
                    case 'i':
                        switch (chars[2])
                          {
                            case 'g':
                                if ((String.Compare(chars, 3, "htYear", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeValueKnownValues.Value_LightYear;
                                break;
                            case 't':
                                if ((String.Compare(chars, 3, "er", 0, 2, false) == 0) && (chars.Length == 5))
                                    return TypeValueKnownValues.Value_Liter;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "ngTon", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeValueKnownValues.Value_LongTon;
                        break;
                    default:
                        break;
                  }
                break;
            case 'M':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'c':
                                if ((String.Compare(chars, 3, "h", 0, 1, false) == 0) && (chars.Length == 4))
                                    return TypeValueKnownValues.Value_Mach;
                                break;
                            case 'r':
                                if ((String.Compare(chars, 3, "athon", 0, 5, false) == 0) && (chars.Length == 8))
                                    return TypeValueKnownValues.Value_Marathon;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        switch (chars[2])
                          {
                            case 'g':
                                if (String.Compare(chars, 3, "a", 0, 1, false) == 0)
                                  {
                                    switch (chars[4])
                                      {
                                        case 'b':
                                            switch (chars[5])
                                              {
                                                case 'i':
                                                    if ((String.Compare(chars, 6, "t", 0, 1, false) == 0) && (chars.Length == 7))
                                                        return TypeValueKnownValues.Value_Megabit;
                                                    break;
                                                case 'y':
                                                    if ((String.Compare(chars, 6, "te", 0, 2, false) == 0) && (chars.Length == 8))
                                                        return TypeValueKnownValues.Value_Megabyte;
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'g':
                                            if ((String.Compare(chars, 5, "ram", 0, 3, false) == 0) && (chars.Length == 8))
                                                return TypeValueKnownValues.Value_Megagram;
                                            break;
                                        case 'h':
                                            if ((String.Compare(chars, 5, "ertz", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Megahertz;
                                            break;
                                        case 'l':
                                            if ((String.Compare(chars, 5, "iter", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Megaliter;
                                            break;
                                        case 'm':
                                            if ((String.Compare(chars, 5, "eter", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Megameter;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 't':
                                switch (chars[3])
                                  {
                                    case 'e':
                                        if (String.Compare(chars, 4, "r", 0, 1, false) == 0)
                                          {
                                            if (chars.Length == 5)
                                              {
                                                return TypeValueKnownValues.Value_Meter;
                                              }
                                            switch (chars[5])
                                              {
                                                case 'P':
                                                    if (String.Compare(chars, 6, "erSecond", 0, 8, false) == 0)
                                                      {
                                                        if (chars.Length == 14)
                                                          {
                                                            return TypeValueKnownValues.Value_MeterPerSecond;
                                                          }
                                                        switch (chars[14])
                                                          {
                                                            case 'S':
                                                                if ((String.Compare(chars, 15, "quared", 0, 6, false) == 0) && (chars.Length == 21))
                                                                    return TypeValueKnownValues.Value_MeterPerSecondSquared;
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
                                        if (String.Compare(chars, 4, "ic", 0, 2, false) == 0)
                                          {
                                            switch (chars[6])
                                              {
                                                case 'H':
                                                    if ((String.Compare(chars, 7, "orsepower", 0, 9, false) == 0) && (chars.Length == 16))
                                                        return TypeValueKnownValues.Value_MetricHorsepower;
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(chars, 7, "on", 0, 2, false) == 0) && (chars.Length == 9))
                                                        return TypeValueKnownValues.Value_MetricTon;
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
                    case 'i':
                        switch (chars[2])
                          {
                            case 'c':
                                if (String.Compare(chars, 3, "ro", 0, 2, false) == 0)
                                  {
                                    switch (chars[5])
                                      {
                                        case 'g':
                                            if ((String.Compare(chars, 6, "ram", 0, 3, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Microgram;
                                            break;
                                        case 'h':
                                            if ((String.Compare(chars, 6, "ertz", 0, 4, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_Microhertz;
                                            break;
                                        case 'l':
                                            if ((String.Compare(chars, 6, "iter", 0, 4, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_Microliter;
                                            break;
                                        case 'm':
                                            if ((String.Compare(chars, 6, "eter", 0, 4, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_Micrometer;
                                            break;
                                        case 's':
                                            if ((String.Compare(chars, 6, "econd", 0, 5, false) == 0) && (chars.Length == 11))
                                                return TypeValueKnownValues.Value_Microsecond;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'l':
                                switch (chars[3])
                                  {
                                    case 'e':
                                        if (chars.Length == 4)
                                          {
                                            return TypeValueKnownValues.Value_Mile;
                                          }
                                        switch (chars[4])
                                          {
                                            case 'P':
                                                if ((String.Compare(chars, 5, "erHour", 0, 6, false) == 0) && (chars.Length == 11))
                                                    return TypeValueKnownValues.Value_MilePerHour;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'l':
                                        switch (chars[4])
                                          {
                                            case 'e':
                                                if ((String.Compare(chars, 5, "nium", 0, 4, false) == 0) && (chars.Length == 9))
                                                    return TypeValueKnownValues.Value_Millenium;
                                                break;
                                            case 'i':
                                                switch (chars[5])
                                                  {
                                                    case 'b':
                                                        if ((String.Compare(chars, 6, "ar", 0, 2, false) == 0) && (chars.Length == 8))
                                                            return TypeValueKnownValues.Value_Millibar;
                                                        break;
                                                    case 'g':
                                                        if ((String.Compare(chars, 6, "ram", 0, 3, false) == 0) && (chars.Length == 9))
                                                            return TypeValueKnownValues.Value_Milligram;
                                                        break;
                                                    case 'h':
                                                        if ((String.Compare(chars, 6, "ertz", 0, 4, false) == 0) && (chars.Length == 10))
                                                            return TypeValueKnownValues.Value_Millihertz;
                                                        break;
                                                    case 'l':
                                                        if ((String.Compare(chars, 6, "iter", 0, 4, false) == 0) && (chars.Length == 10))
                                                            return TypeValueKnownValues.Value_Milliliter;
                                                        break;
                                                    case 'm':
                                                        if ((String.Compare(chars, 6, "eter", 0, 4, false) == 0) && (chars.Length == 10))
                                                            return TypeValueKnownValues.Value_Millimeter;
                                                        break;
                                                    case 's':
                                                        if ((String.Compare(chars, 6, "econd", 0, 5, false) == 0) && (chars.Length == 11))
                                                            return TypeValueKnownValues.Value_Millisecond;
                                                        break;
                                                    default:
                                                        break;
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
                            case 'n':
                                if (String.Compare(chars, 3, "ute", 0, 3, false) == 0)
                                  {
                                    if (chars.Length == 6)
                                      {
                                        return TypeValueKnownValues.Value_Minute;
                                      }
                                    switch (chars[6])
                                      {
                                        case 'O':
                                            if ((String.Compare(chars, 7, "fArc", 0, 4, false) == 0) && (chars.Length == 11))
                                                return TypeValueKnownValues.Value_MinuteOfArc;
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
                        if ((String.Compare(chars, 2, "nth", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValueKnownValues.Value_Month;
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'n':
                                if (String.Compare(chars, 3, "o", 0, 1, false) == 0)
                                  {
                                    switch (chars[4])
                                      {
                                        case 'g':
                                            if ((String.Compare(chars, 5, "ram", 0, 3, false) == 0) && (chars.Length == 8))
                                                return TypeValueKnownValues.Value_Nanogram;
                                            break;
                                        case 'h':
                                            if ((String.Compare(chars, 5, "ertz", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Nanohertz;
                                            break;
                                        case 'l':
                                            if ((String.Compare(chars, 5, "iter", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Nanoliter;
                                            break;
                                        case 'm':
                                            if ((String.Compare(chars, 5, "eter", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Nanometer;
                                            break;
                                        case 's':
                                            if ((String.Compare(chars, 5, "econd", 0, 5, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_Nanosecond;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'u':
                                if ((String.Compare(chars, 3, "ticalMile", 0, 9, false) == 0) && (chars.Length == 12))
                                    return TypeValueKnownValues.Value_NauticalMile;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "wton", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_Newton;
                        break;
                    default:
                        break;
                  }
                break;
            case 'O':
                switch (chars[1])
                  {
                    case 'l':
                        if ((String.Compare(chars, 2, "ympicPoolLap", 0, 12, false) == 0) && (chars.Length == 14))
                            return TypeValueKnownValues.Value_OlympicPoolLap;
                        break;
                    case 'u':
                        if (String.Compare(chars, 2, "nce", 0, 3, false) == 0)
                          {
                            switch (chars[5])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 6, "orce", 0, 4, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_OunceForce;
                                    break;
                                case 'W':
                                    if ((String.Compare(chars, 6, "eight", 0, 5, false) == 0) && (chars.Length == 11))
                                        return TypeValueKnownValues.Value_OunceWeight;
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
            case 'P':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'r':
                                if ((String.Compare(chars, 3, "sec", 0, 3, false) == 0) && (chars.Length == 6))
                                    return TypeValueKnownValues.Value_Parsec;
                                break;
                            case 's':
                                if ((String.Compare(chars, 3, "cal", 0, 3, false) == 0) && (chars.Length == 6))
                                    return TypeValueKnownValues.Value_Pascal;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        switch (chars[2])
                          {
                            case 'n':
                                if ((String.Compare(chars, 3, "nyWeight", 0, 8, false) == 0) && (chars.Length == 11))
                                    return TypeValueKnownValues.Value_PennyWeight;
                                break;
                            case 'r':
                                if ((String.Compare(chars, 3, "ch", 0, 2, false) == 0) && (chars.Length == 5))
                                    return TypeValueKnownValues.Value_Perch;
                                break;
                            case 't':
                                if (String.Compare(chars, 3, "a", 0, 1, false) == 0)
                                  {
                                    switch (chars[4])
                                      {
                                        case 'b':
                                            switch (chars[5])
                                              {
                                                case 'i':
                                                    if ((String.Compare(chars, 6, "t", 0, 1, false) == 0) && (chars.Length == 7))
                                                        return TypeValueKnownValues.Value_Petabit;
                                                    break;
                                                case 'y':
                                                    if ((String.Compare(chars, 6, "te", 0, 2, false) == 0) && (chars.Length == 8))
                                                        return TypeValueKnownValues.Value_Petabyte;
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'g':
                                            if ((String.Compare(chars, 5, "ram", 0, 3, false) == 0) && (chars.Length == 8))
                                                return TypeValueKnownValues.Value_Petagram;
                                            break;
                                        case 'h':
                                            if ((String.Compare(chars, 5, "ertz", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Petahertz;
                                            break;
                                        case 'l':
                                            if ((String.Compare(chars, 5, "iter", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Petaliter;
                                            break;
                                        case 'm':
                                            if ((String.Compare(chars, 5, "eter", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Petameter;
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
                        if (String.Compare(chars, 2, "co", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'g':
                                    if ((String.Compare(chars, 5, "ram", 0, 3, false) == 0) && (chars.Length == 8))
                                        return TypeValueKnownValues.Value_Picogram;
                                    break;
                                case 'h':
                                    if ((String.Compare(chars, 5, "ertz", 0, 4, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_Picohertz;
                                    break;
                                case 'l':
                                    if ((String.Compare(chars, 5, "iter", 0, 4, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_Picoliter;
                                    break;
                                case 'm':
                                    if ((String.Compare(chars, 5, "eter", 0, 4, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_Picometer;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'l':
                                if ((String.Compare(chars, 3, "e", 0, 1, false) == 0) && (chars.Length == 4))
                                    return TypeValueKnownValues.Value_Pole;
                                break;
                            case 'n':
                                if ((String.Compare(chars, 3, "d", 0, 1, false) == 0) && (chars.Length == 4))
                                    return TypeValueKnownValues.Value_Pond;
                                break;
                            case 'u':
                                if (String.Compare(chars, 3, "nd", 0, 2, false) == 0)
                                  {
                                    if (chars.Length == 5)
                                      {
                                        return TypeValueKnownValues.Value_Pound;
                                      }
                                    switch (chars[5])
                                      {
                                        case 'F':
                                            if ((String.Compare(chars, 6, "orce", 0, 4, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_PoundForce;
                                            break;
                                        case 'P':
                                            if ((String.Compare(chars, 6, "erSquareInch", 0, 12, false) == 0) && (chars.Length == 18))
                                                return TypeValueKnownValues.Value_PoundPerSquareInch;
                                            break;
                                        case 'a':
                                            if ((String.Compare(chars, 6, "l", 0, 1, false) == 0) && (chars.Length == 7))
                                                return TypeValueKnownValues.Value_Poundal;
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
            case 'Q':
                if (String.Compare(chars, 1, "ua", 0, 2, false) == 0)
                  {
                    switch (chars[3])
                      {
                        case 'd':
                            if ((String.Compare(chars, 4, "rant", 0, 4, false) == 0) && (chars.Length == 8))
                                return TypeValueKnownValues.Value_Quadrant;
                            break;
                        case 'r':
                            if ((String.Compare(chars, 4, "ter", 0, 3, false) == 0) && (chars.Length == 7))
                                return TypeValueKnownValues.Value_Quarter;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "dian", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_Radian;
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'd':
                                if (chars.Length == 3)
                                    return TypeValueKnownValues.Value_Rod;
                                break;
                            case 'p':
                                if ((String.Compare(chars, 3, "e", 0, 1, false) == 0) && (chars.Length == 4))
                                    return TypeValueKnownValues.Value_Rope;
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
                switch (chars[1])
                  {
                    case 'e':
                        switch (chars[2])
                          {
                            case 'c':
                                if (String.Compare(chars, 3, "ond", 0, 3, false) == 0)
                                  {
                                    if (chars.Length == 6)
                                      {
                                        return TypeValueKnownValues.Value_Second;
                                      }
                                    switch (chars[6])
                                      {
                                        case 'O':
                                            if ((String.Compare(chars, 7, "fArc", 0, 4, false) == 0) && (chars.Length == 11))
                                                return TypeValueKnownValues.Value_SecondOfArc;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'x':
                                if ((String.Compare(chars, 3, "tant", 0, 4, false) == 0) && (chars.Length == 7))
                                    return TypeValueKnownValues.Value_Sextant;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'h':
                        if ((String.Compare(chars, 2, "ot", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Shot;
                        break;
                    case 'q':
                        if (String.Compare(chars, 2, "uare", 0, 4, false) == 0)
                          {
                            switch (chars[6])
                              {
                                case 'C':
                                    if ((String.Compare(chars, 7, "entimeter", 0, 9, false) == 0) && (chars.Length == 16))
                                        return TypeValueKnownValues.Value_SquareCentimeter;
                                    break;
                                case 'F':
                                    if ((String.Compare(chars, 7, "oot", 0, 3, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_SquareFoot;
                                    break;
                                case 'I':
                                    if ((String.Compare(chars, 7, "nch", 0, 3, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_SquareInch;
                                    break;
                                case 'K':
                                    if ((String.Compare(chars, 7, "ilometer", 0, 8, false) == 0) && (chars.Length == 15))
                                        return TypeValueKnownValues.Value_SquareKilometer;
                                    break;
                                case 'M':
                                    switch (chars[7])
                                      {
                                        case 'e':
                                            if ((String.Compare(chars, 8, "ter", 0, 3, false) == 0) && (chars.Length == 11))
                                                return TypeValueKnownValues.Value_SquareMeter;
                                            break;
                                        case 'i':
                                            if (String.Compare(chars, 8, "l", 0, 1, false) == 0)
                                              {
                                                switch (chars[9])
                                                  {
                                                    case 'e':
                                                        if (chars.Length == 10)
                                                            return TypeValueKnownValues.Value_SquareMile;
                                                        break;
                                                    case 'l':
                                                        if ((String.Compare(chars, 10, "imeter", 0, 6, false) == 0) && (chars.Length == 16))
                                                            return TypeValueKnownValues.Value_SquareMillimeter;
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
                                case 'Y':
                                    if ((String.Compare(chars, 7, "ard", 0, 3, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_SquareYard;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 't':
                        if ((String.Compare(chars, 2, "one", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValueKnownValues.Value_Stone;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                switch (chars[1])
                  {
                    case 'e':
                        switch (chars[2])
                          {
                            case 'n':
                                if ((String.Compare(chars, 3, "KRun", 0, 4, false) == 0) && (chars.Length == 7))
                                    return TypeValueKnownValues.Value_TenKRun;
                                break;
                            case 'r':
                                if (String.Compare(chars, 3, "a", 0, 1, false) == 0)
                                  {
                                    switch (chars[4])
                                      {
                                        case 'b':
                                            switch (chars[5])
                                              {
                                                case 'i':
                                                    if ((String.Compare(chars, 6, "t", 0, 1, false) == 0) && (chars.Length == 7))
                                                        return TypeValueKnownValues.Value_Terabit;
                                                    break;
                                                case 'y':
                                                    if ((String.Compare(chars, 6, "te", 0, 2, false) == 0) && (chars.Length == 8))
                                                        return TypeValueKnownValues.Value_Terabyte;
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'g':
                                            if ((String.Compare(chars, 5, "ram", 0, 3, false) == 0) && (chars.Length == 8))
                                                return TypeValueKnownValues.Value_Teragram;
                                            break;
                                        case 'h':
                                            if ((String.Compare(chars, 5, "ertz", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Terahertz;
                                            break;
                                        case 'l':
                                            if ((String.Compare(chars, 5, "iter", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Teraliter;
                                            break;
                                        case 'm':
                                            if ((String.Compare(chars, 5, "eter", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Terameter;
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
                        switch (chars[2])
                          {
                            case 'n':
                                if (chars.Length == 3)
                                    return TypeValueKnownValues.Value_Ton;
                                break;
                            case 'r':
                                if ((String.Compare(chars, 3, "r", 0, 1, false) == 0) && (chars.Length == 4))
                                    return TypeValueKnownValues.Value_Torr;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'r':
                        if (String.Compare(chars, 2, "oy", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'O':
                                    if ((String.Compare(chars, 5, "unce", 0, 4, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_TroyOunce;
                                    break;
                                case 'P':
                                    if ((String.Compare(chars, 5, "ound", 0, 4, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_TroyPound;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "rn", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Turn;
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                switch (chars[1])
                  {
                    case 'K':
                        switch (chars[2])
                          {
                            case 'B':
                                if ((String.Compare(chars, 3, "ushel", 0, 5, false) == 0) && (chars.Length == 8))
                                    return TypeValueKnownValues.Value_UKBushel;
                                break;
                            case 'G':
                                if ((String.Compare(chars, 3, "allon", 0, 5, false) == 0) && (chars.Length == 8))
                                    return TypeValueKnownValues.Value_UKGallon;
                                break;
                            case 'O':
                                if ((String.Compare(chars, 3, "unceVolume", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeValueKnownValues.Value_UKOunceVolume;
                                break;
                            case 'P':
                                switch (chars[3])
                                  {
                                    case 'e':
                                        if ((String.Compare(chars, 4, "ck", 0, 2, false) == 0) && (chars.Length == 6))
                                            return TypeValueKnownValues.Value_UKPeck;
                                        break;
                                    case 'i':
                                        if ((String.Compare(chars, 4, "nt", 0, 2, false) == 0) && (chars.Length == 6))
                                            return TypeValueKnownValues.Value_UKPint;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'Q':
                                if ((String.Compare(chars, 3, "uart", 0, 4, false) == 0) && (chars.Length == 7))
                                    return TypeValueKnownValues.Value_UKQuart;
                                break;
                            case 'T':
                                switch (chars[3])
                                  {
                                    case 'a':
                                        if ((String.Compare(chars, 4, "blespoon", 0, 8, false) == 0) && (chars.Length == 12))
                                            return TypeValueKnownValues.Value_UKTablespoon;
                                        break;
                                    case 'e':
                                        if ((String.Compare(chars, 4, "aspoon", 0, 6, false) == 0) && (chars.Length == 10))
                                            return TypeValueKnownValues.Value_UKTeaspoon;
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
                        switch (chars[2])
                          {
                            case 'B':
                                switch (chars[3])
                                  {
                                    case 'a':
                                        if ((String.Compare(chars, 4, "rrel", 0, 4, false) == 0) && (chars.Length == 8))
                                            return TypeValueKnownValues.Value_USBarrel;
                                        break;
                                    case 'u':
                                        if ((String.Compare(chars, 4, "shel", 0, 4, false) == 0) && (chars.Length == 8))
                                            return TypeValueKnownValues.Value_USBushel;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'D':
                                if ((String.Compare(chars, 3, "ryQuart", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeValueKnownValues.Value_USDryQuart;
                                break;
                            case 'G':
                                if ((String.Compare(chars, 3, "allon", 0, 5, false) == 0) && (chars.Length == 8))
                                    return TypeValueKnownValues.Value_USGallon;
                                break;
                            case 'H':
                                if ((String.Compare(chars, 3, "ogshead", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeValueKnownValues.Value_USHogshead;
                                break;
                            case 'L':
                                if ((String.Compare(chars, 3, "iquidQuart", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeValueKnownValues.Value_USLiquidQuart;
                                break;
                            case 'O':
                                if ((String.Compare(chars, 3, "unceVolume", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeValueKnownValues.Value_USOunceVolume;
                                break;
                            case 'P':
                                switch (chars[3])
                                  {
                                    case 'e':
                                        if ((String.Compare(chars, 4, "ck", 0, 2, false) == 0) && (chars.Length == 6))
                                            return TypeValueKnownValues.Value_USPeck;
                                        break;
                                    case 'i':
                                        if ((String.Compare(chars, 4, "nt", 0, 2, false) == 0) && (chars.Length == 6))
                                            return TypeValueKnownValues.Value_USPint;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'T':
                                switch (chars[3])
                                  {
                                    case 'a':
                                        if ((String.Compare(chars, 4, "blespoon", 0, 8, false) == 0) && (chars.Length == 12))
                                            return TypeValueKnownValues.Value_USTablespoon;
                                        break;
                                    case 'e':
                                        if ((String.Compare(chars, 4, "aspoon", 0, 6, false) == 0) && (chars.Length == 10))
                                            return TypeValueKnownValues.Value_USTeaspoon;
                                        break;
                                    case 'i':
                                        if ((String.Compare(chars, 4, "erce", 0, 4, false) == 0) && (chars.Length == 8))
                                            return TypeValueKnownValues.Value_USTierce;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'n':
                        if ((String.Compare(chars, 2, "known", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeValueKnownValues.Value_Unknown;
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "tt", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Watt;
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "ek", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Week;
                        break;
                    default:
                        break;
                  }
                break;
            case 'Y':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "rd", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Yard;
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "ar", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Year;
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'c':
                                if (String.Compare(chars, 3, "to", 0, 2, false) == 0)
                                  {
                                    switch (chars[5])
                                      {
                                        case 'g':
                                            if ((String.Compare(chars, 6, "ram", 0, 3, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Yoctogram;
                                            break;
                                        case 'h':
                                            if ((String.Compare(chars, 6, "ertz", 0, 4, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_Yoctohertz;
                                            break;
                                        case 'l':
                                            if ((String.Compare(chars, 6, "iter", 0, 4, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_Yoctoliter;
                                            break;
                                        case 'm':
                                            if ((String.Compare(chars, 6, "eter", 0, 4, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_Yoctometer;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 't':
                                if (String.Compare(chars, 3, "ta", 0, 2, false) == 0)
                                  {
                                    switch (chars[5])
                                      {
                                        case 'g':
                                            if ((String.Compare(chars, 6, "ram", 0, 3, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_Yottagram;
                                            break;
                                        case 'h':
                                            if ((String.Compare(chars, 6, "ertz", 0, 4, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_Yottahertz;
                                            break;
                                        case 'l':
                                            if ((String.Compare(chars, 6, "iter", 0, 4, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_Yottaliter;
                                            break;
                                        case 'm':
                                            if ((String.Compare(chars, 6, "eter", 0, 4, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_Yottameter;
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
            case 'Z':
                if (String.Compare(chars, 1, "e", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'p':
                            if (String.Compare(chars, 3, "to", 0, 2, false) == 0)
                              {
                                switch (chars[5])
                                  {
                                    case 'g':
                                        if ((String.Compare(chars, 6, "ram", 0, 3, false) == 0) && (chars.Length == 9))
                                            return TypeValueKnownValues.Value_Zeptogram;
                                        break;
                                    case 'h':
                                        if ((String.Compare(chars, 6, "ertz", 0, 4, false) == 0) && (chars.Length == 10))
                                            return TypeValueKnownValues.Value_Zeptohertz;
                                        break;
                                    case 'l':
                                        if ((String.Compare(chars, 6, "iter", 0, 4, false) == 0) && (chars.Length == 10))
                                            return TypeValueKnownValues.Value_Zeptoliter;
                                        break;
                                    case 'm':
                                        if ((String.Compare(chars, 6, "eter", 0, 4, false) == 0) && (chars.Length == 10))
                                            return TypeValueKnownValues.Value_Zeptometer;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 't':
                            if (String.Compare(chars, 3, "ta", 0, 2, false) == 0)
                              {
                                switch (chars[5])
                                  {
                                    case 'g':
                                        if ((String.Compare(chars, 6, "ram", 0, 3, false) == 0) && (chars.Length == 9))
                                            return TypeValueKnownValues.Value_Zettagram;
                                        break;
                                    case 'h':
                                        if ((String.Compare(chars, 6, "ertz", 0, 4, false) == 0) && (chars.Length == 10))
                                            return TypeValueKnownValues.Value_Zettahertz;
                                        break;
                                    case 'l':
                                        if ((String.Compare(chars, 6, "iter", 0, 4, false) == 0) && (chars.Length == 10))
                                            return TypeValueKnownValues.Value_Zettaliter;
                                        break;
                                    case 'm':
                                        if ((String.Compare(chars, 6, "eter", 0, 4, false) == 0) && (chars.Length == 10))
                                            return TypeValueKnownValues.Value_Zettameter;
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
        return TypeValueKnownValues.Value__none;
      }

    public static string  stringFromValue(TypeValueKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeValueKnownValues.Value_Unknown:
                return "Unknown";
            case TypeValueKnownValues.Value_Fathom:
                return "Fathom";
            case TypeValueKnownValues.Value_League:
                return "League";
            case TypeValueKnownValues.Value_LightYear:
                return "LightYear";
            case TypeValueKnownValues.Value_AstronomicalUnit:
                return "AstronomicalUnit";
            case TypeValueKnownValues.Value_Parsec:
                return "Parsec";
            case TypeValueKnownValues.Value_Angstrom:
                return "Angstrom";
            case TypeValueKnownValues.Value_Rope:
                return "Rope";
            case TypeValueKnownValues.Value_Perch:
                return "Perch";
            case TypeValueKnownValues.Value_Cubit:
                return "Cubit";
            case TypeValueKnownValues.Value_Pole:
                return "Pole";
            case TypeValueKnownValues.Value_Ell:
                return "Ell";
            case TypeValueKnownValues.Value_Furlong:
                return "Furlong";
            case TypeValueKnownValues.Value_Chain:
                return "Chain";
            case TypeValueKnownValues.Value_Rod:
                return "Rod";
            case TypeValueKnownValues.Value_Inch:
                return "Inch";
            case TypeValueKnownValues.Value_Foot:
                return "Foot";
            case TypeValueKnownValues.Value_Yard:
                return "Yard";
            case TypeValueKnownValues.Value_Mile:
                return "Mile";
            case TypeValueKnownValues.Value_NauticalMile:
                return "NauticalMile";
            case TypeValueKnownValues.Value_Yoctometer:
                return "Yoctometer";
            case TypeValueKnownValues.Value_Zeptometer:
                return "Zeptometer";
            case TypeValueKnownValues.Value_Attometer:
                return "Attometer";
            case TypeValueKnownValues.Value_Femtometer:
                return "Femtometer";
            case TypeValueKnownValues.Value_Picometer:
                return "Picometer";
            case TypeValueKnownValues.Value_Nanometer:
                return "Nanometer";
            case TypeValueKnownValues.Value_Micrometer:
                return "Micrometer";
            case TypeValueKnownValues.Value_Millimeter:
                return "Millimeter";
            case TypeValueKnownValues.Value_Centimeter:
                return "Centimeter";
            case TypeValueKnownValues.Value_Decimeter:
                return "Decimeter";
            case TypeValueKnownValues.Value_Meter:
                return "Meter";
            case TypeValueKnownValues.Value_Decameter:
                return "Decameter";
            case TypeValueKnownValues.Value_Hectometer:
                return "Hectometer";
            case TypeValueKnownValues.Value_Kilometer:
                return "Kilometer";
            case TypeValueKnownValues.Value_Megameter:
                return "Megameter";
            case TypeValueKnownValues.Value_Gigameter:
                return "Gigameter";
            case TypeValueKnownValues.Value_Terameter:
                return "Terameter";
            case TypeValueKnownValues.Value_Petameter:
                return "Petameter";
            case TypeValueKnownValues.Value_Exameter:
                return "Exameter";
            case TypeValueKnownValues.Value_Zettameter:
                return "Zettameter";
            case TypeValueKnownValues.Value_Yottameter:
                return "Yottameter";
            case TypeValueKnownValues.Value_Marathon:
                return "Marathon";
            case TypeValueKnownValues.Value_HalfMarathon:
                return "HalfMarathon";
            case TypeValueKnownValues.Value_TenKRun:
                return "TenKRun";
            case TypeValueKnownValues.Value_FiveKRun:
                return "FiveKRun";
            case TypeValueKnownValues.Value_OlympicPoolLap:
                return "OlympicPoolLap";
            case TypeValueKnownValues.Value_DegreeFahrenheit:
                return "DegreeFahrenheit";
            case TypeValueKnownValues.Value_DegreeCelsius:
                return "DegreeCelsius";
            case TypeValueKnownValues.Value_Kelvin:
                return "Kelvin";
            case TypeValueKnownValues.Value_Pascal:
                return "Pascal";
            case TypeValueKnownValues.Value_Kilopascal:
                return "Kilopascal";
            case TypeValueKnownValues.Value_Hectopascal:
                return "Hectopascal";
            case TypeValueKnownValues.Value_Bar:
                return "Bar";
            case TypeValueKnownValues.Value_Millibar:
                return "Millibar";
            case TypeValueKnownValues.Value_PoundPerSquareInch:
                return "PoundPerSquareInch";
            case TypeValueKnownValues.Value_InchOfMercury:
                return "InchOfMercury";
            case TypeValueKnownValues.Value_Atmosphere:
                return "Atmosphere";
            case TypeValueKnownValues.Value_Torr:
                return "Torr";
            case TypeValueKnownValues.Value_Bit:
                return "Bit";
            case TypeValueKnownValues.Value_Byte:
                return "Byte";
            case TypeValueKnownValues.Value_Kilobit:
                return "Kilobit";
            case TypeValueKnownValues.Value_Kilobyte:
                return "Kilobyte";
            case TypeValueKnownValues.Value_Megabit:
                return "Megabit";
            case TypeValueKnownValues.Value_Megabyte:
                return "Megabyte";
            case TypeValueKnownValues.Value_Gigabit:
                return "Gigabit";
            case TypeValueKnownValues.Value_Gigabyte:
                return "Gigabyte";
            case TypeValueKnownValues.Value_Terabit:
                return "Terabit";
            case TypeValueKnownValues.Value_Terabyte:
                return "Terabyte";
            case TypeValueKnownValues.Value_Petabit:
                return "Petabit";
            case TypeValueKnownValues.Value_Petabyte:
                return "Petabyte";
            case TypeValueKnownValues.Value_Nanosecond:
                return "Nanosecond";
            case TypeValueKnownValues.Value_Millisecond:
                return "Millisecond";
            case TypeValueKnownValues.Value_Microsecond:
                return "Microsecond";
            case TypeValueKnownValues.Value_Second:
                return "Second";
            case TypeValueKnownValues.Value_Minute:
                return "Minute";
            case TypeValueKnownValues.Value_Hour:
                return "Hour";
            case TypeValueKnownValues.Value_Day:
                return "Day";
            case TypeValueKnownValues.Value_Week:
                return "Week";
            case TypeValueKnownValues.Value_Fortnight:
                return "Fortnight";
            case TypeValueKnownValues.Value_Month:
                return "Month";
            case TypeValueKnownValues.Value_Year:
                return "Year";
            case TypeValueKnownValues.Value_Decade:
                return "Decade";
            case TypeValueKnownValues.Value_Century:
                return "Century";
            case TypeValueKnownValues.Value_Millenium:
                return "Millenium";
            case TypeValueKnownValues.Value_SquareInch:
                return "SquareInch";
            case TypeValueKnownValues.Value_SquareFoot:
                return "SquareFoot";
            case TypeValueKnownValues.Value_SquareYard:
                return "SquareYard";
            case TypeValueKnownValues.Value_SquareMile:
                return "SquareMile";
            case TypeValueKnownValues.Value_SquareMillimeter:
                return "SquareMillimeter";
            case TypeValueKnownValues.Value_SquareCentimeter:
                return "SquareCentimeter";
            case TypeValueKnownValues.Value_SquareMeter:
                return "SquareMeter";
            case TypeValueKnownValues.Value_SquareKilometer:
                return "SquareKilometer";
            case TypeValueKnownValues.Value_Hectare:
                return "Hectare";
            case TypeValueKnownValues.Value_Acre:
                return "Acre";
            case TypeValueKnownValues.Value_Yoctogram:
                return "Yoctogram";
            case TypeValueKnownValues.Value_Zeptogram:
                return "Zeptogram";
            case TypeValueKnownValues.Value_Attogram:
                return "Attogram";
            case TypeValueKnownValues.Value_Femtogram:
                return "Femtogram";
            case TypeValueKnownValues.Value_Picogram:
                return "Picogram";
            case TypeValueKnownValues.Value_Nanogram:
                return "Nanogram";
            case TypeValueKnownValues.Value_Microgram:
                return "Microgram";
            case TypeValueKnownValues.Value_Milligram:
                return "Milligram";
            case TypeValueKnownValues.Value_Centigram:
                return "Centigram";
            case TypeValueKnownValues.Value_Decigram:
                return "Decigram";
            case TypeValueKnownValues.Value_Gram:
                return "Gram";
            case TypeValueKnownValues.Value_Decagram:
                return "Decagram";
            case TypeValueKnownValues.Value_Hectogram:
                return "Hectogram";
            case TypeValueKnownValues.Value_Kilogram:
                return "Kilogram";
            case TypeValueKnownValues.Value_Megagram:
                return "Megagram";
            case TypeValueKnownValues.Value_Gigagram:
                return "Gigagram";
            case TypeValueKnownValues.Value_Teragram:
                return "Teragram";
            case TypeValueKnownValues.Value_Petagram:
                return "Petagram";
            case TypeValueKnownValues.Value_Exagram:
                return "Exagram";
            case TypeValueKnownValues.Value_Zettagram:
                return "Zettagram";
            case TypeValueKnownValues.Value_Yottagram:
                return "Yottagram";
            case TypeValueKnownValues.Value_MetricTon:
                return "MetricTon";
            case TypeValueKnownValues.Value_OunceWeight:
                return "OunceWeight";
            case TypeValueKnownValues.Value_Pound:
                return "Pound";
            case TypeValueKnownValues.Value_Grain:
                return "Grain";
            case TypeValueKnownValues.Value_Carat:
                return "Carat";
            case TypeValueKnownValues.Value_TroyPound:
                return "TroyPound";
            case TypeValueKnownValues.Value_TroyOunce:
                return "TroyOunce";
            case TypeValueKnownValues.Value_PennyWeight:
                return "PennyWeight";
            case TypeValueKnownValues.Value_Quarter:
                return "Quarter";
            case TypeValueKnownValues.Value_Stone:
                return "Stone";
            case TypeValueKnownValues.Value_Ton:
                return "Ton";
            case TypeValueKnownValues.Value_LongTon:
                return "LongTon";
            case TypeValueKnownValues.Value_CubicInch:
                return "CubicInch";
            case TypeValueKnownValues.Value_CubicFoot:
                return "CubicFoot";
            case TypeValueKnownValues.Value_CubicMeter:
                return "CubicMeter";
            case TypeValueKnownValues.Value_USTeaspoon:
                return "USTeaspoon";
            case TypeValueKnownValues.Value_UKTeaspoon:
                return "UKTeaspoon";
            case TypeValueKnownValues.Value_USTablespoon:
                return "USTablespoon";
            case TypeValueKnownValues.Value_UKTablespoon:
                return "UKTablespoon";
            case TypeValueKnownValues.Value_USOunceVolume:
                return "USOunceVolume";
            case TypeValueKnownValues.Value_UKOunceVolume:
                return "UKOunceVolume";
            case TypeValueKnownValues.Value_Cup:
                return "Cup";
            case TypeValueKnownValues.Value_Shot:
                return "Shot";
            case TypeValueKnownValues.Value_USPint:
                return "USPint";
            case TypeValueKnownValues.Value_USLiquidQuart:
                return "USLiquidQuart";
            case TypeValueKnownValues.Value_USDryQuart:
                return "USDryQuart";
            case TypeValueKnownValues.Value_USGallon:
                return "USGallon";
            case TypeValueKnownValues.Value_UKPint:
                return "UKPint";
            case TypeValueKnownValues.Value_UKQuart:
                return "UKQuart";
            case TypeValueKnownValues.Value_UKGallon:
                return "UKGallon";
            case TypeValueKnownValues.Value_Milliliter:
                return "Milliliter";
            case TypeValueKnownValues.Value_CubicCentimeter:
                return "CubicCentimeter";
            case TypeValueKnownValues.Value_Liter:
                return "Liter";
            case TypeValueKnownValues.Value_Yoctoliter:
                return "Yoctoliter";
            case TypeValueKnownValues.Value_Zeptoliter:
                return "Zeptoliter";
            case TypeValueKnownValues.Value_Attoliter:
                return "Attoliter";
            case TypeValueKnownValues.Value_Femtoliter:
                return "Femtoliter";
            case TypeValueKnownValues.Value_Picoliter:
                return "Picoliter";
            case TypeValueKnownValues.Value_Nanoliter:
                return "Nanoliter";
            case TypeValueKnownValues.Value_Microliter:
                return "Microliter";
            case TypeValueKnownValues.Value_Centiliter:
                return "Centiliter";
            case TypeValueKnownValues.Value_Deciliter:
                return "Deciliter";
            case TypeValueKnownValues.Value_Decaliter:
                return "Decaliter";
            case TypeValueKnownValues.Value_Hectoliter:
                return "Hectoliter";
            case TypeValueKnownValues.Value_Kiloliter:
                return "Kiloliter";
            case TypeValueKnownValues.Value_Megaliter:
                return "Megaliter";
            case TypeValueKnownValues.Value_Gigaliter:
                return "Gigaliter";
            case TypeValueKnownValues.Value_Teraliter:
                return "Teraliter";
            case TypeValueKnownValues.Value_Petaliter:
                return "Petaliter";
            case TypeValueKnownValues.Value_Exaliter:
                return "Exaliter";
            case TypeValueKnownValues.Value_Zettaliter:
                return "Zettaliter";
            case TypeValueKnownValues.Value_Yottaliter:
                return "Yottaliter";
            case TypeValueKnownValues.Value_USBushel:
                return "USBushel";
            case TypeValueKnownValues.Value_UKBushel:
                return "UKBushel";
            case TypeValueKnownValues.Value_USPeck:
                return "USPeck";
            case TypeValueKnownValues.Value_UKPeck:
                return "UKPeck";
            case TypeValueKnownValues.Value_USHogshead:
                return "USHogshead";
            case TypeValueKnownValues.Value_USBarrel:
                return "USBarrel";
            case TypeValueKnownValues.Value_USTierce:
                return "USTierce";
            case TypeValueKnownValues.Value_Newton:
                return "Newton";
            case TypeValueKnownValues.Value_Kilonewton:
                return "Kilonewton";
            case TypeValueKnownValues.Value_Dyne:
                return "Dyne";
            case TypeValueKnownValues.Value_Poundal:
                return "Poundal";
            case TypeValueKnownValues.Value_Pond:
                return "Pond";
            case TypeValueKnownValues.Value_Kilopond:
                return "Kilopond";
            case TypeValueKnownValues.Value_OunceForce:
                return "OunceForce";
            case TypeValueKnownValues.Value_PoundForce:
                return "PoundForce";
            case TypeValueKnownValues.Value_Joule:
                return "Joule";
            case TypeValueKnownValues.Value_Kilojoule:
                return "Kilojoule";
            case TypeValueKnownValues.Value_Calorie:
                return "Calorie";
            case TypeValueKnownValues.Value_Kilocalorie:
                return "Kilocalorie";
            case TypeValueKnownValues.Value_KilowattHour:
                return "KilowattHour";
            case TypeValueKnownValues.Value_Btu:
                return "Btu";
            case TypeValueKnownValues.Value_Watt:
                return "Watt";
            case TypeValueKnownValues.Value_Kilowatt:
                return "Kilowatt";
            case TypeValueKnownValues.Value_Horsepower:
                return "Horsepower";
            case TypeValueKnownValues.Value_MetricHorsepower:
                return "MetricHorsepower";
            case TypeValueKnownValues.Value_FootPoundPerMinute:
                return "FootPoundPerMinute";
            case TypeValueKnownValues.Value_ErgPerSecond:
                return "ErgPerSecond";
            case TypeValueKnownValues.Value_CaloriesPerSecond:
                return "CaloriesPerSecond";
            case TypeValueKnownValues.Value_MeterPerSecondSquared:
                return "MeterPerSecondSquared";
            case TypeValueKnownValues.Value_InchPerSecondSquared:
                return "InchPerSecondSquared";
            case TypeValueKnownValues.Value_FootPerSecondSquared:
                return "FootPerSecondSquared";
            case TypeValueKnownValues.Value_Galileo:
                return "Galileo";
            case TypeValueKnownValues.Value_G:
                return "G";
            case TypeValueKnownValues.Value_KilometerPerHour:
                return "KilometerPerHour";
            case TypeValueKnownValues.Value_MilePerHour:
                return "MilePerHour";
            case TypeValueKnownValues.Value_FootPerSecond:
                return "FootPerSecond";
            case TypeValueKnownValues.Value_MeterPerSecond:
                return "MeterPerSecond";
            case TypeValueKnownValues.Value_Knot:
                return "Knot";
            case TypeValueKnownValues.Value_Mach:
                return "Mach";
            case TypeValueKnownValues.Value_Yoctohertz:
                return "Yoctohertz";
            case TypeValueKnownValues.Value_Zeptohertz:
                return "Zeptohertz";
            case TypeValueKnownValues.Value_Attohertz:
                return "Attohertz";
            case TypeValueKnownValues.Value_Femtohertz:
                return "Femtohertz";
            case TypeValueKnownValues.Value_Picohertz:
                return "Picohertz";
            case TypeValueKnownValues.Value_Nanohertz:
                return "Nanohertz";
            case TypeValueKnownValues.Value_Microhertz:
                return "Microhertz";
            case TypeValueKnownValues.Value_Millihertz:
                return "Millihertz";
            case TypeValueKnownValues.Value_Centihertz:
                return "Centihertz";
            case TypeValueKnownValues.Value_Decihertz:
                return "Decihertz";
            case TypeValueKnownValues.Value_Hertz:
                return "Hertz";
            case TypeValueKnownValues.Value_Decahertz:
                return "Decahertz";
            case TypeValueKnownValues.Value_Hectohertz:
                return "Hectohertz";
            case TypeValueKnownValues.Value_Kilohertz:
                return "Kilohertz";
            case TypeValueKnownValues.Value_Megahertz:
                return "Megahertz";
            case TypeValueKnownValues.Value_Gigahertz:
                return "Gigahertz";
            case TypeValueKnownValues.Value_Terahertz:
                return "Terahertz";
            case TypeValueKnownValues.Value_Petahertz:
                return "Petahertz";
            case TypeValueKnownValues.Value_Exahertz:
                return "Exahertz";
            case TypeValueKnownValues.Value_Zettahertz:
                return "Zettahertz";
            case TypeValueKnownValues.Value_Yottahertz:
                return "Yottahertz";
            case TypeValueKnownValues.Value_Radian:
                return "Radian";
            case TypeValueKnownValues.Value_Degree:
                return "Degree";
            case TypeValueKnownValues.Value_Turn:
                return "Turn";
            case TypeValueKnownValues.Value_Quadrant:
                return "Quadrant";
            case TypeValueKnownValues.Value_Sextant:
                return "Sextant";
            case TypeValueKnownValues.Value_MinuteOfArc:
                return "MinuteOfArc";
            case TypeValueKnownValues.Value_SecondOfArc:
                return "SecondOfArc";
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
            throw new Exception("The value for field Value of UnitOfMeasureJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'c':
                        if ((String.Compare(json_string.getData(), 2, "re", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Acre;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'n':
                        if ((String.Compare(json_string.getData(), 2, "gstrom", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Angstrom;
                                goto open_enum_is_done;
                              }
                        break;
                    case 's':
                        if ((String.Compare(json_string.getData(), 2, "tronomicalUnit", 0, 14, false) == 0) && (json_string.getData().Length == 16))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_AstronomicalUnit;
                                goto open_enum_is_done;
                              }
                        break;
                    case 't':
                        switch (json_string.getData()[2])
                          {
                            case 'm':
                                if ((String.Compare(json_string.getData(), 3, "osphere", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Atmosphere;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 't':
                                if (String.Compare(json_string.getData(), 3, "o", 0, 1, false) == 0)
                                  {
                                    switch (json_string.getData()[4])
                                      {
                                        case 'g':
                                            if ((String.Compare(json_string.getData(), 5, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Attogram;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'h':
                                            if ((String.Compare(json_string.getData(), 5, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Attohertz;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'l':
                                            if ((String.Compare(json_string.getData(), 5, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Attoliter;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'm':
                                            if ((String.Compare(json_string.getData(), 5, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Attometer;
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
                break;
            case 'B':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "r", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Bar;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "t", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Bit;
                                goto open_enum_is_done;
                              }
                        break;
                    case 't':
                        if ((String.Compare(json_string.getData(), 2, "u", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Btu;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'y':
                        if ((String.Compare(json_string.getData(), 2, "te", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Byte;
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
                        switch (json_string.getData()[2])
                          {
                            case 'l':
                                if (String.Compare(json_string.getData(), 3, "orie", 0, 4, false) == 0)
                                  {
                                    if (json_string.getData().Length == 7)
                                      {
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Calorie;
                                            goto open_enum_is_done;
                                          }
                                      }
                                    switch (json_string.getData()[7])
                                      {
                                        case 's':
                                            if ((String.Compare(json_string.getData(), 8, "PerSecond", 0, 9, false) == 0) && (json_string.getData().Length == 17))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_CaloriesPerSecond;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "at", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Carat;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "nt", 0, 2, false) == 0)
                          {
                            switch (json_string.getData()[4])
                              {
                                case 'i':
                                    switch (json_string.getData()[5])
                                      {
                                        case 'g':
                                            if ((String.Compare(json_string.getData(), 6, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Centigram;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'h':
                                            if ((String.Compare(json_string.getData(), 6, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Centihertz;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'l':
                                            if ((String.Compare(json_string.getData(), 6, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Centiliter;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'm':
                                            if ((String.Compare(json_string.getData(), 6, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Centimeter;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'u':
                                    if ((String.Compare(json_string.getData(), 5, "ry", 0, 2, false) == 0) && (json_string.getData().Length == 7))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Century;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'h':
                        if ((String.Compare(json_string.getData(), 2, "ain", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Chain;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        switch (json_string.getData()[2])
                          {
                            case 'b':
                                if (String.Compare(json_string.getData(), 3, "i", 0, 1, false) == 0)
                                  {
                                    switch (json_string.getData()[4])
                                      {
                                        case 'c':
                                            switch (json_string.getData()[5])
                                              {
                                                case 'C':
                                                    if ((String.Compare(json_string.getData(), 6, "entimeter", 0, 9, false) == 0) && (json_string.getData().Length == 15))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_CubicCentimeter;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'F':
                                                    if ((String.Compare(json_string.getData(), 6, "oot", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_CubicFoot;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'I':
                                                    if ((String.Compare(json_string.getData(), 6, "nch", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_CubicInch;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'M':
                                                    if ((String.Compare(json_string.getData(), 6, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_CubicMeter;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 't':
                                            if (json_string.getData().Length == 5)
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Cubit;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'p':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Cup;
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
            case 'D':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "y", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Day;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'e':
                        switch (json_string.getData()[2])
                          {
                            case 'c':
                                switch (json_string.getData()[3])
                                  {
                                    case 'a':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'd':
                                                if ((String.Compare(json_string.getData(), 5, "e", 0, 1, false) == 0) && (json_string.getData().Length == 6))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_Decade;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'g':
                                                if ((String.Compare(json_string.getData(), 5, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_Decagram;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'h':
                                                if ((String.Compare(json_string.getData(), 5, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_Decahertz;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'l':
                                                if ((String.Compare(json_string.getData(), 5, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_Decaliter;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'm':
                                                if ((String.Compare(json_string.getData(), 5, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_Decameter;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'i':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'g':
                                                if ((String.Compare(json_string.getData(), 5, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_Decigram;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'h':
                                                if ((String.Compare(json_string.getData(), 5, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_Decihertz;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'l':
                                                if ((String.Compare(json_string.getData(), 5, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_Deciliter;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'm':
                                                if ((String.Compare(json_string.getData(), 5, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_Decimeter;
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
                            case 'g':
                                if (String.Compare(json_string.getData(), 3, "ree", 0, 3, false) == 0)
                                  {
                                    if (json_string.getData().Length == 6)
                                      {
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Degree;
                                            goto open_enum_is_done;
                                          }
                                      }
                                    switch (json_string.getData()[6])
                                      {
                                        case 'C':
                                            if ((String.Compare(json_string.getData(), 7, "elsius", 0, 6, false) == 0) && (json_string.getData().Length == 13))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_DegreeCelsius;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 7, "ahrenheit", 0, 9, false) == 0) && (json_string.getData().Length == 16))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_DegreeFahrenheit;
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
                    case 'y':
                        if ((String.Compare(json_string.getData(), 2, "ne", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Dyne;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'E':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "l", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Ell;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "gPerSecond", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_ErgPerSecond;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'x':
                        if (String.Compare(json_string.getData(), 2, "a", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'g':
                                    if ((String.Compare(json_string.getData(), 4, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 7))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Exagram;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'h':
                                    if ((String.Compare(json_string.getData(), 4, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Exahertz;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'l':
                                    if ((String.Compare(json_string.getData(), 4, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Exaliter;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'm':
                                    if ((String.Compare(json_string.getData(), 4, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Exameter;
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
            case 'F':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "thom", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Fathom;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "mto", 0, 3, false) == 0)
                          {
                            switch (json_string.getData()[5])
                              {
                                case 'g':
                                    if ((String.Compare(json_string.getData(), 6, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Femtogram;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'h':
                                    if ((String.Compare(json_string.getData(), 6, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Femtohertz;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'l':
                                    if ((String.Compare(json_string.getData(), 6, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Femtoliter;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'm':
                                    if ((String.Compare(json_string.getData(), 6, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Femtometer;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "veKRun", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_FiveKRun;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 'o':
                                if (String.Compare(json_string.getData(), 3, "t", 0, 1, false) == 0)
                                  {
                                    if (json_string.getData().Length == 4)
                                      {
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Foot;
                                            goto open_enum_is_done;
                                          }
                                      }
                                    switch (json_string.getData()[4])
                                      {
                                        case 'P':
                                            switch (json_string.getData()[5])
                                              {
                                                case 'e':
                                                    if (String.Compare(json_string.getData(), 6, "rSecond", 0, 7, false) == 0)
                                                      {
                                                        if (json_string.getData().Length == 13)
                                                          {
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_FootPerSecond;
                                                                goto open_enum_is_done;
                                                              }
                                                          }
                                                        switch (json_string.getData()[13])
                                                          {
                                                            case 'S':
                                                                if ((String.Compare(json_string.getData(), 14, "quared", 0, 6, false) == 0) && (json_string.getData().Length == 20))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_FootPerSecondSquared;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'o':
                                                    if ((String.Compare(json_string.getData(), 6, "undPerMinute", 0, 12, false) == 0) && (json_string.getData().Length == 18))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_FootPoundPerMinute;
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
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "tnight", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Fortnight;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "rlong", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Furlong;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'G':
                if (json_string.getData().Length == 1)
                  {
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_G;
                        goto open_enum_is_done;
                      }
                  }
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "lileo", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Galileo;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if (String.Compare(json_string.getData(), 2, "ga", 0, 2, false) == 0)
                          {
                            switch (json_string.getData()[4])
                              {
                                case 'b':
                                    switch (json_string.getData()[5])
                                      {
                                        case 'i':
                                            if ((String.Compare(json_string.getData(), 6, "t", 0, 1, false) == 0) && (json_string.getData().Length == 7))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Gigabit;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'y':
                                            if ((String.Compare(json_string.getData(), 6, "te", 0, 2, false) == 0) && (json_string.getData().Length == 8))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Gigabyte;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'g':
                                    if ((String.Compare(json_string.getData(), 5, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Gigagram;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'h':
                                    if ((String.Compare(json_string.getData(), 5, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Gigahertz;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'l':
                                    if ((String.Compare(json_string.getData(), 5, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Gigaliter;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'm':
                                    if ((String.Compare(json_string.getData(), 5, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Gigameter;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(json_string.getData(), 2, "a", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'i':
                                    if ((String.Compare(json_string.getData(), 4, "n", 0, 1, false) == 0) && (json_string.getData().Length == 5))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Grain;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'm':
                                    if (json_string.getData().Length == 4)
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Gram;
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
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "lfMarathon", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_HalfMarathon;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'e':
                        switch (json_string.getData()[2])
                          {
                            case 'c':
                                if (String.Compare(json_string.getData(), 3, "t", 0, 1, false) == 0)
                                  {
                                    switch (json_string.getData()[4])
                                      {
                                        case 'a':
                                            if ((String.Compare(json_string.getData(), 5, "re", 0, 2, false) == 0) && (json_string.getData().Length == 7))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Hectare;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'o':
                                            switch (json_string.getData()[5])
                                              {
                                                case 'g':
                                                    if ((String.Compare(json_string.getData(), 6, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_Hectogram;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'h':
                                                    if ((String.Compare(json_string.getData(), 6, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_Hectohertz;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'l':
                                                    if ((String.Compare(json_string.getData(), 6, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_Hectoliter;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'm':
                                                    if ((String.Compare(json_string.getData(), 6, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_Hectometer;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'p':
                                                    if ((String.Compare(json_string.getData(), 6, "ascal", 0, 5, false) == 0) && (json_string.getData().Length == 11))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_Hectopascal;
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
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "tz", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Hertz;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "sepower", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Horsepower;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'u':
                                if ((String.Compare(json_string.getData(), 3, "r", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Hour;
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
            case 'I':
                if (String.Compare(json_string.getData(), 1, "nch", 0, 3, false) == 0)
                  {
                    if (json_string.getData().Length == 4)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeValueKnownValues.Value_Inch;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[4])
                      {
                        case 'O':
                            if ((String.Compare(json_string.getData(), 5, "fMercury", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_InchOfMercury;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'P':
                            if ((String.Compare(json_string.getData(), 5, "erSecondSquared", 0, 15, false) == 0) && (json_string.getData().Length == 20))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_InchPerSecondSquared;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'J':
                if ((String.Compare(json_string.getData(), 1, "oule", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Joule;
                        goto open_enum_is_done;
                      }
                break;
            case 'K':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "lvin", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Kelvin;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if (String.Compare(json_string.getData(), 2, "lo", 0, 2, false) == 0)
                          {
                            switch (json_string.getData()[4])
                              {
                                case 'b':
                                    switch (json_string.getData()[5])
                                      {
                                        case 'i':
                                            if ((String.Compare(json_string.getData(), 6, "t", 0, 1, false) == 0) && (json_string.getData().Length == 7))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Kilobit;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'y':
                                            if ((String.Compare(json_string.getData(), 6, "te", 0, 2, false) == 0) && (json_string.getData().Length == 8))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Kilobyte;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'c':
                                    if ((String.Compare(json_string.getData(), 5, "alorie", 0, 6, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Kilocalorie;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'g':
                                    if ((String.Compare(json_string.getData(), 5, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Kilogram;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'h':
                                    if ((String.Compare(json_string.getData(), 5, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Kilohertz;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'j':
                                    if ((String.Compare(json_string.getData(), 5, "oule", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Kilojoule;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'l':
                                    if ((String.Compare(json_string.getData(), 5, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Kiloliter;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'm':
                                    if (String.Compare(json_string.getData(), 5, "eter", 0, 4, false) == 0)
                                      {
                                        if (json_string.getData().Length == 9)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_Kilometer;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[9])
                                          {
                                            case 'P':
                                                if ((String.Compare(json_string.getData(), 10, "erHour", 0, 6, false) == 0) && (json_string.getData().Length == 16))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_KilometerPerHour;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'n':
                                    if ((String.Compare(json_string.getData(), 5, "ewton", 0, 5, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Kilonewton;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'p':
                                    switch (json_string.getData()[5])
                                      {
                                        case 'a':
                                            if ((String.Compare(json_string.getData(), 6, "scal", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Kilopascal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'o':
                                            if ((String.Compare(json_string.getData(), 6, "nd", 0, 2, false) == 0) && (json_string.getData().Length == 8))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Kilopond;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'w':
                                    if (String.Compare(json_string.getData(), 5, "att", 0, 3, false) == 0)
                                      {
                                        if (json_string.getData().Length == 8)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_Kilowatt;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[8])
                                          {
                                            case 'H':
                                                if ((String.Compare(json_string.getData(), 9, "our", 0, 3, false) == 0) && (json_string.getData().Length == 12))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_KilowattHour;
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
                        if ((String.Compare(json_string.getData(), 2, "ot", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Knot;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "ague", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_League;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        switch (json_string.getData()[2])
                          {
                            case 'g':
                                if ((String.Compare(json_string.getData(), 3, "htYear", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_LightYear;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 't':
                                if ((String.Compare(json_string.getData(), 3, "er", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Liter;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "ngTon", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_LongTon;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'M':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'c':
                                if ((String.Compare(json_string.getData(), 3, "h", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Mach;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "athon", 0, 5, false) == 0) && (json_string.getData().Length == 8))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Marathon;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        switch (json_string.getData()[2])
                          {
                            case 'g':
                                if (String.Compare(json_string.getData(), 3, "a", 0, 1, false) == 0)
                                  {
                                    switch (json_string.getData()[4])
                                      {
                                        case 'b':
                                            switch (json_string.getData()[5])
                                              {
                                                case 'i':
                                                    if ((String.Compare(json_string.getData(), 6, "t", 0, 1, false) == 0) && (json_string.getData().Length == 7))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_Megabit;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'y':
                                                    if ((String.Compare(json_string.getData(), 6, "te", 0, 2, false) == 0) && (json_string.getData().Length == 8))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_Megabyte;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'g':
                                            if ((String.Compare(json_string.getData(), 5, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Megagram;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'h':
                                            if ((String.Compare(json_string.getData(), 5, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Megahertz;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'l':
                                            if ((String.Compare(json_string.getData(), 5, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Megaliter;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'm':
                                            if ((String.Compare(json_string.getData(), 5, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Megameter;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 't':
                                switch (json_string.getData()[3])
                                  {
                                    case 'e':
                                        if (String.Compare(json_string.getData(), 4, "r", 0, 1, false) == 0)
                                          {
                                            if (json_string.getData().Length == 5)
                                              {
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Meter;
                                                    goto open_enum_is_done;
                                                  }
                                              }
                                            switch (json_string.getData()[5])
                                              {
                                                case 'P':
                                                    if (String.Compare(json_string.getData(), 6, "erSecond", 0, 8, false) == 0)
                                                      {
                                                        if (json_string.getData().Length == 14)
                                                          {
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_MeterPerSecond;
                                                                goto open_enum_is_done;
                                                              }
                                                          }
                                                        switch (json_string.getData()[14])
                                                          {
                                                            case 'S':
                                                                if ((String.Compare(json_string.getData(), 15, "quared", 0, 6, false) == 0) && (json_string.getData().Length == 21))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_MeterPerSecondSquared;
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
                                    case 'r':
                                        if (String.Compare(json_string.getData(), 4, "ic", 0, 2, false) == 0)
                                          {
                                            switch (json_string.getData()[6])
                                              {
                                                case 'H':
                                                    if ((String.Compare(json_string.getData(), 7, "orsepower", 0, 9, false) == 0) && (json_string.getData().Length == 16))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_MetricHorsepower;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(json_string.getData(), 7, "on", 0, 2, false) == 0) && (json_string.getData().Length == 9))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_MetricTon;
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
                        break;
                    case 'i':
                        switch (json_string.getData()[2])
                          {
                            case 'c':
                                if (String.Compare(json_string.getData(), 3, "ro", 0, 2, false) == 0)
                                  {
                                    switch (json_string.getData()[5])
                                      {
                                        case 'g':
                                            if ((String.Compare(json_string.getData(), 6, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Microgram;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'h':
                                            if ((String.Compare(json_string.getData(), 6, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Microhertz;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'l':
                                            if ((String.Compare(json_string.getData(), 6, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Microliter;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'm':
                                            if ((String.Compare(json_string.getData(), 6, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Micrometer;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 's':
                                            if ((String.Compare(json_string.getData(), 6, "econd", 0, 5, false) == 0) && (json_string.getData().Length == 11))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Microsecond;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'l':
                                switch (json_string.getData()[3])
                                  {
                                    case 'e':
                                        if (json_string.getData().Length == 4)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_Mile;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[4])
                                          {
                                            case 'P':
                                                if ((String.Compare(json_string.getData(), 5, "erHour", 0, 6, false) == 0) && (json_string.getData().Length == 11))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_MilePerHour;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'l':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'e':
                                                if ((String.Compare(json_string.getData(), 5, "nium", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_Millenium;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'i':
                                                switch (json_string.getData()[5])
                                                  {
                                                    case 'b':
                                                        if ((String.Compare(json_string.getData(), 6, "ar", 0, 2, false) == 0) && (json_string.getData().Length == 8))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_Millibar;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'g':
                                                        if ((String.Compare(json_string.getData(), 6, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_Milligram;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'h':
                                                        if ((String.Compare(json_string.getData(), 6, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_Millihertz;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'l':
                                                        if ((String.Compare(json_string.getData(), 6, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_Milliliter;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'm':
                                                        if ((String.Compare(json_string.getData(), 6, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_Millimeter;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 's':
                                                        if ((String.Compare(json_string.getData(), 6, "econd", 0, 5, false) == 0) && (json_string.getData().Length == 11))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_Millisecond;
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
                                    default:
                                        break;
                                  }
                                break;
                            case 'n':
                                if (String.Compare(json_string.getData(), 3, "ute", 0, 3, false) == 0)
                                  {
                                    if (json_string.getData().Length == 6)
                                      {
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Minute;
                                            goto open_enum_is_done;
                                          }
                                      }
                                    switch (json_string.getData()[6])
                                      {
                                        case 'O':
                                            if ((String.Compare(json_string.getData(), 7, "fArc", 0, 4, false) == 0) && (json_string.getData().Length == 11))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_MinuteOfArc;
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
                        if ((String.Compare(json_string.getData(), 2, "nth", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Month;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'n':
                                if (String.Compare(json_string.getData(), 3, "o", 0, 1, false) == 0)
                                  {
                                    switch (json_string.getData()[4])
                                      {
                                        case 'g':
                                            if ((String.Compare(json_string.getData(), 5, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Nanogram;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'h':
                                            if ((String.Compare(json_string.getData(), 5, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Nanohertz;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'l':
                                            if ((String.Compare(json_string.getData(), 5, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Nanoliter;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'm':
                                            if ((String.Compare(json_string.getData(), 5, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Nanometer;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 's':
                                            if ((String.Compare(json_string.getData(), 5, "econd", 0, 5, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Nanosecond;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'u':
                                if ((String.Compare(json_string.getData(), 3, "ticalMile", 0, 9, false) == 0) && (json_string.getData().Length == 12))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_NauticalMile;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "wton", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Newton;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'O':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "ympicPoolLap", 0, 12, false) == 0) && (json_string.getData().Length == 14))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_OlympicPoolLap;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if (String.Compare(json_string.getData(), 2, "nce", 0, 3, false) == 0)
                          {
                            switch (json_string.getData()[5])
                              {
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 6, "orce", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_OunceForce;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'W':
                                    if ((String.Compare(json_string.getData(), 6, "eight", 0, 5, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_OunceWeight;
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
            case 'P':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "sec", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Parsec;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 's':
                                if ((String.Compare(json_string.getData(), 3, "cal", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Pascal;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        switch (json_string.getData()[2])
                          {
                            case 'n':
                                if ((String.Compare(json_string.getData(), 3, "nyWeight", 0, 8, false) == 0) && (json_string.getData().Length == 11))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_PennyWeight;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "ch", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Perch;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 't':
                                if (String.Compare(json_string.getData(), 3, "a", 0, 1, false) == 0)
                                  {
                                    switch (json_string.getData()[4])
                                      {
                                        case 'b':
                                            switch (json_string.getData()[5])
                                              {
                                                case 'i':
                                                    if ((String.Compare(json_string.getData(), 6, "t", 0, 1, false) == 0) && (json_string.getData().Length == 7))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_Petabit;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'y':
                                                    if ((String.Compare(json_string.getData(), 6, "te", 0, 2, false) == 0) && (json_string.getData().Length == 8))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_Petabyte;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'g':
                                            if ((String.Compare(json_string.getData(), 5, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Petagram;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'h':
                                            if ((String.Compare(json_string.getData(), 5, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Petahertz;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'l':
                                            if ((String.Compare(json_string.getData(), 5, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Petaliter;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'm':
                                            if ((String.Compare(json_string.getData(), 5, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Petameter;
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
                        if (String.Compare(json_string.getData(), 2, "co", 0, 2, false) == 0)
                          {
                            switch (json_string.getData()[4])
                              {
                                case 'g':
                                    if ((String.Compare(json_string.getData(), 5, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Picogram;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'h':
                                    if ((String.Compare(json_string.getData(), 5, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Picohertz;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'l':
                                    if ((String.Compare(json_string.getData(), 5, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Picoliter;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'm':
                                    if ((String.Compare(json_string.getData(), 5, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Picometer;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 'l':
                                if ((String.Compare(json_string.getData(), 3, "e", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Pole;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'n':
                                if ((String.Compare(json_string.getData(), 3, "d", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Pond;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'u':
                                if (String.Compare(json_string.getData(), 3, "nd", 0, 2, false) == 0)
                                  {
                                    if (json_string.getData().Length == 5)
                                      {
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Pound;
                                            goto open_enum_is_done;
                                          }
                                      }
                                    switch (json_string.getData()[5])
                                      {
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 6, "orce", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_PoundForce;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'P':
                                            if ((String.Compare(json_string.getData(), 6, "erSquareInch", 0, 12, false) == 0) && (json_string.getData().Length == 18))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_PoundPerSquareInch;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'a':
                                            if ((String.Compare(json_string.getData(), 6, "l", 0, 1, false) == 0) && (json_string.getData().Length == 7))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Poundal;
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
                break;
            case 'Q':
                if (String.Compare(json_string.getData(), 1, "ua", 0, 2, false) == 0)
                  {
                    switch (json_string.getData()[3])
                      {
                        case 'd':
                            if ((String.Compare(json_string.getData(), 4, "rant", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_Quadrant;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'r':
                            if ((String.Compare(json_string.getData(), 4, "ter", 0, 3, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_Quarter;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "dian", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Radian;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 'd':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Rod;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'p':
                                if ((String.Compare(json_string.getData(), 3, "e", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Rope;
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
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        switch (json_string.getData()[2])
                          {
                            case 'c':
                                if (String.Compare(json_string.getData(), 3, "ond", 0, 3, false) == 0)
                                  {
                                    if (json_string.getData().Length == 6)
                                      {
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Second;
                                            goto open_enum_is_done;
                                          }
                                      }
                                    switch (json_string.getData()[6])
                                      {
                                        case 'O':
                                            if ((String.Compare(json_string.getData(), 7, "fArc", 0, 4, false) == 0) && (json_string.getData().Length == 11))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_SecondOfArc;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'x':
                                if ((String.Compare(json_string.getData(), 3, "tant", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Sextant;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'h':
                        if ((String.Compare(json_string.getData(), 2, "ot", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Shot;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'q':
                        if (String.Compare(json_string.getData(), 2, "uare", 0, 4, false) == 0)
                          {
                            switch (json_string.getData()[6])
                              {
                                case 'C':
                                    if ((String.Compare(json_string.getData(), 7, "entimeter", 0, 9, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_SquareCentimeter;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 7, "oot", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_SquareFoot;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'I':
                                    if ((String.Compare(json_string.getData(), 7, "nch", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_SquareInch;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'K':
                                    if ((String.Compare(json_string.getData(), 7, "ilometer", 0, 8, false) == 0) && (json_string.getData().Length == 15))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_SquareKilometer;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'M':
                                    switch (json_string.getData()[7])
                                      {
                                        case 'e':
                                            if ((String.Compare(json_string.getData(), 8, "ter", 0, 3, false) == 0) && (json_string.getData().Length == 11))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_SquareMeter;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'i':
                                            if (String.Compare(json_string.getData(), 8, "l", 0, 1, false) == 0)
                                              {
                                                switch (json_string.getData()[9])
                                                  {
                                                    case 'e':
                                                        if (json_string.getData().Length == 10)
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_SquareMile;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'l':
                                                        if ((String.Compare(json_string.getData(), 10, "imeter", 0, 6, false) == 0) && (json_string.getData().Length == 16))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_SquareMillimeter;
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
                                case 'Y':
                                    if ((String.Compare(json_string.getData(), 7, "ard", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_SquareYard;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 't':
                        if ((String.Compare(json_string.getData(), 2, "one", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Stone;
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
                    case 'e':
                        switch (json_string.getData()[2])
                          {
                            case 'n':
                                if ((String.Compare(json_string.getData(), 3, "KRun", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_TenKRun;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'r':
                                if (String.Compare(json_string.getData(), 3, "a", 0, 1, false) == 0)
                                  {
                                    switch (json_string.getData()[4])
                                      {
                                        case 'b':
                                            switch (json_string.getData()[5])
                                              {
                                                case 'i':
                                                    if ((String.Compare(json_string.getData(), 6, "t", 0, 1, false) == 0) && (json_string.getData().Length == 7))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_Terabit;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'y':
                                                    if ((String.Compare(json_string.getData(), 6, "te", 0, 2, false) == 0) && (json_string.getData().Length == 8))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_Terabyte;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'g':
                                            if ((String.Compare(json_string.getData(), 5, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Teragram;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'h':
                                            if ((String.Compare(json_string.getData(), 5, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Terahertz;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'l':
                                            if ((String.Compare(json_string.getData(), 5, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Teraliter;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'm':
                                            if ((String.Compare(json_string.getData(), 5, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Terameter;
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
                        switch (json_string.getData()[2])
                          {
                            case 'n':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Ton;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "r", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Torr;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'r':
                        if (String.Compare(json_string.getData(), 2, "oy", 0, 2, false) == 0)
                          {
                            switch (json_string.getData()[4])
                              {
                                case 'O':
                                    if ((String.Compare(json_string.getData(), 5, "unce", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_TroyOunce;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'P':
                                    if ((String.Compare(json_string.getData(), 5, "ound", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_TroyPound;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "rn", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Turn;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                switch (json_string.getData()[1])
                  {
                    case 'K':
                        switch (json_string.getData()[2])
                          {
                            case 'B':
                                if ((String.Compare(json_string.getData(), 3, "ushel", 0, 5, false) == 0) && (json_string.getData().Length == 8))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_UKBushel;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'G':
                                if ((String.Compare(json_string.getData(), 3, "allon", 0, 5, false) == 0) && (json_string.getData().Length == 8))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_UKGallon;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'O':
                                if ((String.Compare(json_string.getData(), 3, "unceVolume", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_UKOunceVolume;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'P':
                                switch (json_string.getData()[3])
                                  {
                                    case 'e':
                                        if ((String.Compare(json_string.getData(), 4, "ck", 0, 2, false) == 0) && (json_string.getData().Length == 6))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_UKPeck;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'i':
                                        if ((String.Compare(json_string.getData(), 4, "nt", 0, 2, false) == 0) && (json_string.getData().Length == 6))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_UKPint;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'Q':
                                if ((String.Compare(json_string.getData(), 3, "uart", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_UKQuart;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'T':
                                switch (json_string.getData()[3])
                                  {
                                    case 'a':
                                        if ((String.Compare(json_string.getData(), 4, "blespoon", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_UKTablespoon;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'e':
                                        if ((String.Compare(json_string.getData(), 4, "aspoon", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_UKTeaspoon;
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
                        switch (json_string.getData()[2])
                          {
                            case 'B':
                                switch (json_string.getData()[3])
                                  {
                                    case 'a':
                                        if ((String.Compare(json_string.getData(), 4, "rrel", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_USBarrel;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'u':
                                        if ((String.Compare(json_string.getData(), 4, "shel", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_USBushel;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'D':
                                if ((String.Compare(json_string.getData(), 3, "ryQuart", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_USDryQuart;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'G':
                                if ((String.Compare(json_string.getData(), 3, "allon", 0, 5, false) == 0) && (json_string.getData().Length == 8))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_USGallon;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'H':
                                if ((String.Compare(json_string.getData(), 3, "ogshead", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_USHogshead;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'L':
                                if ((String.Compare(json_string.getData(), 3, "iquidQuart", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_USLiquidQuart;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'O':
                                if ((String.Compare(json_string.getData(), 3, "unceVolume", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_USOunceVolume;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'P':
                                switch (json_string.getData()[3])
                                  {
                                    case 'e':
                                        if ((String.Compare(json_string.getData(), 4, "ck", 0, 2, false) == 0) && (json_string.getData().Length == 6))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_USPeck;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'i':
                                        if ((String.Compare(json_string.getData(), 4, "nt", 0, 2, false) == 0) && (json_string.getData().Length == 6))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_USPint;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'T':
                                switch (json_string.getData()[3])
                                  {
                                    case 'a':
                                        if ((String.Compare(json_string.getData(), 4, "blespoon", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_USTablespoon;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'e':
                                        if ((String.Compare(json_string.getData(), 4, "aspoon", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_USTeaspoon;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'i':
                                        if ((String.Compare(json_string.getData(), 4, "erce", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_USTierce;
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
                    case 'n':
                        if ((String.Compare(json_string.getData(), 2, "known", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Unknown;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "tt", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Watt;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "ek", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Week;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'Y':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "rd", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Yard;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "ar", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Year;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 'c':
                                if (String.Compare(json_string.getData(), 3, "to", 0, 2, false) == 0)
                                  {
                                    switch (json_string.getData()[5])
                                      {
                                        case 'g':
                                            if ((String.Compare(json_string.getData(), 6, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Yoctogram;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'h':
                                            if ((String.Compare(json_string.getData(), 6, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Yoctohertz;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'l':
                                            if ((String.Compare(json_string.getData(), 6, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Yoctoliter;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'm':
                                            if ((String.Compare(json_string.getData(), 6, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Yoctometer;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 't':
                                if (String.Compare(json_string.getData(), 3, "ta", 0, 2, false) == 0)
                                  {
                                    switch (json_string.getData()[5])
                                      {
                                        case 'g':
                                            if ((String.Compare(json_string.getData(), 6, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Yottagram;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'h':
                                            if ((String.Compare(json_string.getData(), 6, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Yottahertz;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'l':
                                            if ((String.Compare(json_string.getData(), 6, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Yottaliter;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'm':
                                            if ((String.Compare(json_string.getData(), 6, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_Yottameter;
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
                break;
            case 'Z':
                if (String.Compare(json_string.getData(), 1, "e", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'p':
                            if (String.Compare(json_string.getData(), 3, "to", 0, 2, false) == 0)
                              {
                                switch (json_string.getData()[5])
                                  {
                                    case 'g':
                                        if ((String.Compare(json_string.getData(), 6, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_Zeptogram;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'h':
                                        if ((String.Compare(json_string.getData(), 6, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_Zeptohertz;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'l':
                                        if ((String.Compare(json_string.getData(), 6, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_Zeptoliter;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'm':
                                        if ((String.Compare(json_string.getData(), 6, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_Zeptometer;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 't':
                            if (String.Compare(json_string.getData(), 3, "ta", 0, 2, false) == 0)
                              {
                                switch (json_string.getData()[5])
                                  {
                                    case 'g':
                                        if ((String.Compare(json_string.getData(), 6, "ram", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_Zettagram;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'h':
                                        if ((String.Compare(json_string.getData(), 6, "ertz", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_Zettahertz;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'l':
                                        if ((String.Compare(json_string.getData(), 6, "iter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_Zettaliter;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'm':
                                        if ((String.Compare(json_string.getData(), 6, "eter", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_Zettameter;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setValue(the_open_enum);
      }


    public UnitOfMeasureJSON()
      {
        flagHasValue = false;
      }

    public UnitOfMeasureJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public UnitOfMeasureJSON(string init_value)
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

    public UnitOfMeasureJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_Unknown:
                    handler.string_value("Unknown");
                    break;
                case TypeValueKnownValues.Value_Fathom:
                    handler.string_value("Fathom");
                    break;
                case TypeValueKnownValues.Value_League:
                    handler.string_value("League");
                    break;
                case TypeValueKnownValues.Value_LightYear:
                    handler.string_value("LightYear");
                    break;
                case TypeValueKnownValues.Value_AstronomicalUnit:
                    handler.string_value("AstronomicalUnit");
                    break;
                case TypeValueKnownValues.Value_Parsec:
                    handler.string_value("Parsec");
                    break;
                case TypeValueKnownValues.Value_Angstrom:
                    handler.string_value("Angstrom");
                    break;
                case TypeValueKnownValues.Value_Rope:
                    handler.string_value("Rope");
                    break;
                case TypeValueKnownValues.Value_Perch:
                    handler.string_value("Perch");
                    break;
                case TypeValueKnownValues.Value_Cubit:
                    handler.string_value("Cubit");
                    break;
                case TypeValueKnownValues.Value_Pole:
                    handler.string_value("Pole");
                    break;
                case TypeValueKnownValues.Value_Ell:
                    handler.string_value("Ell");
                    break;
                case TypeValueKnownValues.Value_Furlong:
                    handler.string_value("Furlong");
                    break;
                case TypeValueKnownValues.Value_Chain:
                    handler.string_value("Chain");
                    break;
                case TypeValueKnownValues.Value_Rod:
                    handler.string_value("Rod");
                    break;
                case TypeValueKnownValues.Value_Inch:
                    handler.string_value("Inch");
                    break;
                case TypeValueKnownValues.Value_Foot:
                    handler.string_value("Foot");
                    break;
                case TypeValueKnownValues.Value_Yard:
                    handler.string_value("Yard");
                    break;
                case TypeValueKnownValues.Value_Mile:
                    handler.string_value("Mile");
                    break;
                case TypeValueKnownValues.Value_NauticalMile:
                    handler.string_value("NauticalMile");
                    break;
                case TypeValueKnownValues.Value_Yoctometer:
                    handler.string_value("Yoctometer");
                    break;
                case TypeValueKnownValues.Value_Zeptometer:
                    handler.string_value("Zeptometer");
                    break;
                case TypeValueKnownValues.Value_Attometer:
                    handler.string_value("Attometer");
                    break;
                case TypeValueKnownValues.Value_Femtometer:
                    handler.string_value("Femtometer");
                    break;
                case TypeValueKnownValues.Value_Picometer:
                    handler.string_value("Picometer");
                    break;
                case TypeValueKnownValues.Value_Nanometer:
                    handler.string_value("Nanometer");
                    break;
                case TypeValueKnownValues.Value_Micrometer:
                    handler.string_value("Micrometer");
                    break;
                case TypeValueKnownValues.Value_Millimeter:
                    handler.string_value("Millimeter");
                    break;
                case TypeValueKnownValues.Value_Centimeter:
                    handler.string_value("Centimeter");
                    break;
                case TypeValueKnownValues.Value_Decimeter:
                    handler.string_value("Decimeter");
                    break;
                case TypeValueKnownValues.Value_Meter:
                    handler.string_value("Meter");
                    break;
                case TypeValueKnownValues.Value_Decameter:
                    handler.string_value("Decameter");
                    break;
                case TypeValueKnownValues.Value_Hectometer:
                    handler.string_value("Hectometer");
                    break;
                case TypeValueKnownValues.Value_Kilometer:
                    handler.string_value("Kilometer");
                    break;
                case TypeValueKnownValues.Value_Megameter:
                    handler.string_value("Megameter");
                    break;
                case TypeValueKnownValues.Value_Gigameter:
                    handler.string_value("Gigameter");
                    break;
                case TypeValueKnownValues.Value_Terameter:
                    handler.string_value("Terameter");
                    break;
                case TypeValueKnownValues.Value_Petameter:
                    handler.string_value("Petameter");
                    break;
                case TypeValueKnownValues.Value_Exameter:
                    handler.string_value("Exameter");
                    break;
                case TypeValueKnownValues.Value_Zettameter:
                    handler.string_value("Zettameter");
                    break;
                case TypeValueKnownValues.Value_Yottameter:
                    handler.string_value("Yottameter");
                    break;
                case TypeValueKnownValues.Value_Marathon:
                    handler.string_value("Marathon");
                    break;
                case TypeValueKnownValues.Value_HalfMarathon:
                    handler.string_value("HalfMarathon");
                    break;
                case TypeValueKnownValues.Value_TenKRun:
                    handler.string_value("TenKRun");
                    break;
                case TypeValueKnownValues.Value_FiveKRun:
                    handler.string_value("FiveKRun");
                    break;
                case TypeValueKnownValues.Value_OlympicPoolLap:
                    handler.string_value("OlympicPoolLap");
                    break;
                case TypeValueKnownValues.Value_DegreeFahrenheit:
                    handler.string_value("DegreeFahrenheit");
                    break;
                case TypeValueKnownValues.Value_DegreeCelsius:
                    handler.string_value("DegreeCelsius");
                    break;
                case TypeValueKnownValues.Value_Kelvin:
                    handler.string_value("Kelvin");
                    break;
                case TypeValueKnownValues.Value_Pascal:
                    handler.string_value("Pascal");
                    break;
                case TypeValueKnownValues.Value_Kilopascal:
                    handler.string_value("Kilopascal");
                    break;
                case TypeValueKnownValues.Value_Hectopascal:
                    handler.string_value("Hectopascal");
                    break;
                case TypeValueKnownValues.Value_Bar:
                    handler.string_value("Bar");
                    break;
                case TypeValueKnownValues.Value_Millibar:
                    handler.string_value("Millibar");
                    break;
                case TypeValueKnownValues.Value_PoundPerSquareInch:
                    handler.string_value("PoundPerSquareInch");
                    break;
                case TypeValueKnownValues.Value_InchOfMercury:
                    handler.string_value("InchOfMercury");
                    break;
                case TypeValueKnownValues.Value_Atmosphere:
                    handler.string_value("Atmosphere");
                    break;
                case TypeValueKnownValues.Value_Torr:
                    handler.string_value("Torr");
                    break;
                case TypeValueKnownValues.Value_Bit:
                    handler.string_value("Bit");
                    break;
                case TypeValueKnownValues.Value_Byte:
                    handler.string_value("Byte");
                    break;
                case TypeValueKnownValues.Value_Kilobit:
                    handler.string_value("Kilobit");
                    break;
                case TypeValueKnownValues.Value_Kilobyte:
                    handler.string_value("Kilobyte");
                    break;
                case TypeValueKnownValues.Value_Megabit:
                    handler.string_value("Megabit");
                    break;
                case TypeValueKnownValues.Value_Megabyte:
                    handler.string_value("Megabyte");
                    break;
                case TypeValueKnownValues.Value_Gigabit:
                    handler.string_value("Gigabit");
                    break;
                case TypeValueKnownValues.Value_Gigabyte:
                    handler.string_value("Gigabyte");
                    break;
                case TypeValueKnownValues.Value_Terabit:
                    handler.string_value("Terabit");
                    break;
                case TypeValueKnownValues.Value_Terabyte:
                    handler.string_value("Terabyte");
                    break;
                case TypeValueKnownValues.Value_Petabit:
                    handler.string_value("Petabit");
                    break;
                case TypeValueKnownValues.Value_Petabyte:
                    handler.string_value("Petabyte");
                    break;
                case TypeValueKnownValues.Value_Nanosecond:
                    handler.string_value("Nanosecond");
                    break;
                case TypeValueKnownValues.Value_Millisecond:
                    handler.string_value("Millisecond");
                    break;
                case TypeValueKnownValues.Value_Microsecond:
                    handler.string_value("Microsecond");
                    break;
                case TypeValueKnownValues.Value_Second:
                    handler.string_value("Second");
                    break;
                case TypeValueKnownValues.Value_Minute:
                    handler.string_value("Minute");
                    break;
                case TypeValueKnownValues.Value_Hour:
                    handler.string_value("Hour");
                    break;
                case TypeValueKnownValues.Value_Day:
                    handler.string_value("Day");
                    break;
                case TypeValueKnownValues.Value_Week:
                    handler.string_value("Week");
                    break;
                case TypeValueKnownValues.Value_Fortnight:
                    handler.string_value("Fortnight");
                    break;
                case TypeValueKnownValues.Value_Month:
                    handler.string_value("Month");
                    break;
                case TypeValueKnownValues.Value_Year:
                    handler.string_value("Year");
                    break;
                case TypeValueKnownValues.Value_Decade:
                    handler.string_value("Decade");
                    break;
                case TypeValueKnownValues.Value_Century:
                    handler.string_value("Century");
                    break;
                case TypeValueKnownValues.Value_Millenium:
                    handler.string_value("Millenium");
                    break;
                case TypeValueKnownValues.Value_SquareInch:
                    handler.string_value("SquareInch");
                    break;
                case TypeValueKnownValues.Value_SquareFoot:
                    handler.string_value("SquareFoot");
                    break;
                case TypeValueKnownValues.Value_SquareYard:
                    handler.string_value("SquareYard");
                    break;
                case TypeValueKnownValues.Value_SquareMile:
                    handler.string_value("SquareMile");
                    break;
                case TypeValueKnownValues.Value_SquareMillimeter:
                    handler.string_value("SquareMillimeter");
                    break;
                case TypeValueKnownValues.Value_SquareCentimeter:
                    handler.string_value("SquareCentimeter");
                    break;
                case TypeValueKnownValues.Value_SquareMeter:
                    handler.string_value("SquareMeter");
                    break;
                case TypeValueKnownValues.Value_SquareKilometer:
                    handler.string_value("SquareKilometer");
                    break;
                case TypeValueKnownValues.Value_Hectare:
                    handler.string_value("Hectare");
                    break;
                case TypeValueKnownValues.Value_Acre:
                    handler.string_value("Acre");
                    break;
                case TypeValueKnownValues.Value_Yoctogram:
                    handler.string_value("Yoctogram");
                    break;
                case TypeValueKnownValues.Value_Zeptogram:
                    handler.string_value("Zeptogram");
                    break;
                case TypeValueKnownValues.Value_Attogram:
                    handler.string_value("Attogram");
                    break;
                case TypeValueKnownValues.Value_Femtogram:
                    handler.string_value("Femtogram");
                    break;
                case TypeValueKnownValues.Value_Picogram:
                    handler.string_value("Picogram");
                    break;
                case TypeValueKnownValues.Value_Nanogram:
                    handler.string_value("Nanogram");
                    break;
                case TypeValueKnownValues.Value_Microgram:
                    handler.string_value("Microgram");
                    break;
                case TypeValueKnownValues.Value_Milligram:
                    handler.string_value("Milligram");
                    break;
                case TypeValueKnownValues.Value_Centigram:
                    handler.string_value("Centigram");
                    break;
                case TypeValueKnownValues.Value_Decigram:
                    handler.string_value("Decigram");
                    break;
                case TypeValueKnownValues.Value_Gram:
                    handler.string_value("Gram");
                    break;
                case TypeValueKnownValues.Value_Decagram:
                    handler.string_value("Decagram");
                    break;
                case TypeValueKnownValues.Value_Hectogram:
                    handler.string_value("Hectogram");
                    break;
                case TypeValueKnownValues.Value_Kilogram:
                    handler.string_value("Kilogram");
                    break;
                case TypeValueKnownValues.Value_Megagram:
                    handler.string_value("Megagram");
                    break;
                case TypeValueKnownValues.Value_Gigagram:
                    handler.string_value("Gigagram");
                    break;
                case TypeValueKnownValues.Value_Teragram:
                    handler.string_value("Teragram");
                    break;
                case TypeValueKnownValues.Value_Petagram:
                    handler.string_value("Petagram");
                    break;
                case TypeValueKnownValues.Value_Exagram:
                    handler.string_value("Exagram");
                    break;
                case TypeValueKnownValues.Value_Zettagram:
                    handler.string_value("Zettagram");
                    break;
                case TypeValueKnownValues.Value_Yottagram:
                    handler.string_value("Yottagram");
                    break;
                case TypeValueKnownValues.Value_MetricTon:
                    handler.string_value("MetricTon");
                    break;
                case TypeValueKnownValues.Value_OunceWeight:
                    handler.string_value("OunceWeight");
                    break;
                case TypeValueKnownValues.Value_Pound:
                    handler.string_value("Pound");
                    break;
                case TypeValueKnownValues.Value_Grain:
                    handler.string_value("Grain");
                    break;
                case TypeValueKnownValues.Value_Carat:
                    handler.string_value("Carat");
                    break;
                case TypeValueKnownValues.Value_TroyPound:
                    handler.string_value("TroyPound");
                    break;
                case TypeValueKnownValues.Value_TroyOunce:
                    handler.string_value("TroyOunce");
                    break;
                case TypeValueKnownValues.Value_PennyWeight:
                    handler.string_value("PennyWeight");
                    break;
                case TypeValueKnownValues.Value_Quarter:
                    handler.string_value("Quarter");
                    break;
                case TypeValueKnownValues.Value_Stone:
                    handler.string_value("Stone");
                    break;
                case TypeValueKnownValues.Value_Ton:
                    handler.string_value("Ton");
                    break;
                case TypeValueKnownValues.Value_LongTon:
                    handler.string_value("LongTon");
                    break;
                case TypeValueKnownValues.Value_CubicInch:
                    handler.string_value("CubicInch");
                    break;
                case TypeValueKnownValues.Value_CubicFoot:
                    handler.string_value("CubicFoot");
                    break;
                case TypeValueKnownValues.Value_CubicMeter:
                    handler.string_value("CubicMeter");
                    break;
                case TypeValueKnownValues.Value_USTeaspoon:
                    handler.string_value("USTeaspoon");
                    break;
                case TypeValueKnownValues.Value_UKTeaspoon:
                    handler.string_value("UKTeaspoon");
                    break;
                case TypeValueKnownValues.Value_USTablespoon:
                    handler.string_value("USTablespoon");
                    break;
                case TypeValueKnownValues.Value_UKTablespoon:
                    handler.string_value("UKTablespoon");
                    break;
                case TypeValueKnownValues.Value_USOunceVolume:
                    handler.string_value("USOunceVolume");
                    break;
                case TypeValueKnownValues.Value_UKOunceVolume:
                    handler.string_value("UKOunceVolume");
                    break;
                case TypeValueKnownValues.Value_Cup:
                    handler.string_value("Cup");
                    break;
                case TypeValueKnownValues.Value_Shot:
                    handler.string_value("Shot");
                    break;
                case TypeValueKnownValues.Value_USPint:
                    handler.string_value("USPint");
                    break;
                case TypeValueKnownValues.Value_USLiquidQuart:
                    handler.string_value("USLiquidQuart");
                    break;
                case TypeValueKnownValues.Value_USDryQuart:
                    handler.string_value("USDryQuart");
                    break;
                case TypeValueKnownValues.Value_USGallon:
                    handler.string_value("USGallon");
                    break;
                case TypeValueKnownValues.Value_UKPint:
                    handler.string_value("UKPint");
                    break;
                case TypeValueKnownValues.Value_UKQuart:
                    handler.string_value("UKQuart");
                    break;
                case TypeValueKnownValues.Value_UKGallon:
                    handler.string_value("UKGallon");
                    break;
                case TypeValueKnownValues.Value_Milliliter:
                    handler.string_value("Milliliter");
                    break;
                case TypeValueKnownValues.Value_CubicCentimeter:
                    handler.string_value("CubicCentimeter");
                    break;
                case TypeValueKnownValues.Value_Liter:
                    handler.string_value("Liter");
                    break;
                case TypeValueKnownValues.Value_Yoctoliter:
                    handler.string_value("Yoctoliter");
                    break;
                case TypeValueKnownValues.Value_Zeptoliter:
                    handler.string_value("Zeptoliter");
                    break;
                case TypeValueKnownValues.Value_Attoliter:
                    handler.string_value("Attoliter");
                    break;
                case TypeValueKnownValues.Value_Femtoliter:
                    handler.string_value("Femtoliter");
                    break;
                case TypeValueKnownValues.Value_Picoliter:
                    handler.string_value("Picoliter");
                    break;
                case TypeValueKnownValues.Value_Nanoliter:
                    handler.string_value("Nanoliter");
                    break;
                case TypeValueKnownValues.Value_Microliter:
                    handler.string_value("Microliter");
                    break;
                case TypeValueKnownValues.Value_Centiliter:
                    handler.string_value("Centiliter");
                    break;
                case TypeValueKnownValues.Value_Deciliter:
                    handler.string_value("Deciliter");
                    break;
                case TypeValueKnownValues.Value_Decaliter:
                    handler.string_value("Decaliter");
                    break;
                case TypeValueKnownValues.Value_Hectoliter:
                    handler.string_value("Hectoliter");
                    break;
                case TypeValueKnownValues.Value_Kiloliter:
                    handler.string_value("Kiloliter");
                    break;
                case TypeValueKnownValues.Value_Megaliter:
                    handler.string_value("Megaliter");
                    break;
                case TypeValueKnownValues.Value_Gigaliter:
                    handler.string_value("Gigaliter");
                    break;
                case TypeValueKnownValues.Value_Teraliter:
                    handler.string_value("Teraliter");
                    break;
                case TypeValueKnownValues.Value_Petaliter:
                    handler.string_value("Petaliter");
                    break;
                case TypeValueKnownValues.Value_Exaliter:
                    handler.string_value("Exaliter");
                    break;
                case TypeValueKnownValues.Value_Zettaliter:
                    handler.string_value("Zettaliter");
                    break;
                case TypeValueKnownValues.Value_Yottaliter:
                    handler.string_value("Yottaliter");
                    break;
                case TypeValueKnownValues.Value_USBushel:
                    handler.string_value("USBushel");
                    break;
                case TypeValueKnownValues.Value_UKBushel:
                    handler.string_value("UKBushel");
                    break;
                case TypeValueKnownValues.Value_USPeck:
                    handler.string_value("USPeck");
                    break;
                case TypeValueKnownValues.Value_UKPeck:
                    handler.string_value("UKPeck");
                    break;
                case TypeValueKnownValues.Value_USHogshead:
                    handler.string_value("USHogshead");
                    break;
                case TypeValueKnownValues.Value_USBarrel:
                    handler.string_value("USBarrel");
                    break;
                case TypeValueKnownValues.Value_USTierce:
                    handler.string_value("USTierce");
                    break;
                case TypeValueKnownValues.Value_Newton:
                    handler.string_value("Newton");
                    break;
                case TypeValueKnownValues.Value_Kilonewton:
                    handler.string_value("Kilonewton");
                    break;
                case TypeValueKnownValues.Value_Dyne:
                    handler.string_value("Dyne");
                    break;
                case TypeValueKnownValues.Value_Poundal:
                    handler.string_value("Poundal");
                    break;
                case TypeValueKnownValues.Value_Pond:
                    handler.string_value("Pond");
                    break;
                case TypeValueKnownValues.Value_Kilopond:
                    handler.string_value("Kilopond");
                    break;
                case TypeValueKnownValues.Value_OunceForce:
                    handler.string_value("OunceForce");
                    break;
                case TypeValueKnownValues.Value_PoundForce:
                    handler.string_value("PoundForce");
                    break;
                case TypeValueKnownValues.Value_Joule:
                    handler.string_value("Joule");
                    break;
                case TypeValueKnownValues.Value_Kilojoule:
                    handler.string_value("Kilojoule");
                    break;
                case TypeValueKnownValues.Value_Calorie:
                    handler.string_value("Calorie");
                    break;
                case TypeValueKnownValues.Value_Kilocalorie:
                    handler.string_value("Kilocalorie");
                    break;
                case TypeValueKnownValues.Value_KilowattHour:
                    handler.string_value("KilowattHour");
                    break;
                case TypeValueKnownValues.Value_Btu:
                    handler.string_value("Btu");
                    break;
                case TypeValueKnownValues.Value_Watt:
                    handler.string_value("Watt");
                    break;
                case TypeValueKnownValues.Value_Kilowatt:
                    handler.string_value("Kilowatt");
                    break;
                case TypeValueKnownValues.Value_Horsepower:
                    handler.string_value("Horsepower");
                    break;
                case TypeValueKnownValues.Value_MetricHorsepower:
                    handler.string_value("MetricHorsepower");
                    break;
                case TypeValueKnownValues.Value_FootPoundPerMinute:
                    handler.string_value("FootPoundPerMinute");
                    break;
                case TypeValueKnownValues.Value_ErgPerSecond:
                    handler.string_value("ErgPerSecond");
                    break;
                case TypeValueKnownValues.Value_CaloriesPerSecond:
                    handler.string_value("CaloriesPerSecond");
                    break;
                case TypeValueKnownValues.Value_MeterPerSecondSquared:
                    handler.string_value("MeterPerSecondSquared");
                    break;
                case TypeValueKnownValues.Value_InchPerSecondSquared:
                    handler.string_value("InchPerSecondSquared");
                    break;
                case TypeValueKnownValues.Value_FootPerSecondSquared:
                    handler.string_value("FootPerSecondSquared");
                    break;
                case TypeValueKnownValues.Value_Galileo:
                    handler.string_value("Galileo");
                    break;
                case TypeValueKnownValues.Value_G:
                    handler.string_value("G");
                    break;
                case TypeValueKnownValues.Value_KilometerPerHour:
                    handler.string_value("KilometerPerHour");
                    break;
                case TypeValueKnownValues.Value_MilePerHour:
                    handler.string_value("MilePerHour");
                    break;
                case TypeValueKnownValues.Value_FootPerSecond:
                    handler.string_value("FootPerSecond");
                    break;
                case TypeValueKnownValues.Value_MeterPerSecond:
                    handler.string_value("MeterPerSecond");
                    break;
                case TypeValueKnownValues.Value_Knot:
                    handler.string_value("Knot");
                    break;
                case TypeValueKnownValues.Value_Mach:
                    handler.string_value("Mach");
                    break;
                case TypeValueKnownValues.Value_Yoctohertz:
                    handler.string_value("Yoctohertz");
                    break;
                case TypeValueKnownValues.Value_Zeptohertz:
                    handler.string_value("Zeptohertz");
                    break;
                case TypeValueKnownValues.Value_Attohertz:
                    handler.string_value("Attohertz");
                    break;
                case TypeValueKnownValues.Value_Femtohertz:
                    handler.string_value("Femtohertz");
                    break;
                case TypeValueKnownValues.Value_Picohertz:
                    handler.string_value("Picohertz");
                    break;
                case TypeValueKnownValues.Value_Nanohertz:
                    handler.string_value("Nanohertz");
                    break;
                case TypeValueKnownValues.Value_Microhertz:
                    handler.string_value("Microhertz");
                    break;
                case TypeValueKnownValues.Value_Millihertz:
                    handler.string_value("Millihertz");
                    break;
                case TypeValueKnownValues.Value_Centihertz:
                    handler.string_value("Centihertz");
                    break;
                case TypeValueKnownValues.Value_Decihertz:
                    handler.string_value("Decihertz");
                    break;
                case TypeValueKnownValues.Value_Hertz:
                    handler.string_value("Hertz");
                    break;
                case TypeValueKnownValues.Value_Decahertz:
                    handler.string_value("Decahertz");
                    break;
                case TypeValueKnownValues.Value_Hectohertz:
                    handler.string_value("Hectohertz");
                    break;
                case TypeValueKnownValues.Value_Kilohertz:
                    handler.string_value("Kilohertz");
                    break;
                case TypeValueKnownValues.Value_Megahertz:
                    handler.string_value("Megahertz");
                    break;
                case TypeValueKnownValues.Value_Gigahertz:
                    handler.string_value("Gigahertz");
                    break;
                case TypeValueKnownValues.Value_Terahertz:
                    handler.string_value("Terahertz");
                    break;
                case TypeValueKnownValues.Value_Petahertz:
                    handler.string_value("Petahertz");
                    break;
                case TypeValueKnownValues.Value_Exahertz:
                    handler.string_value("Exahertz");
                    break;
                case TypeValueKnownValues.Value_Zettahertz:
                    handler.string_value("Zettahertz");
                    break;
                case TypeValueKnownValues.Value_Yottahertz:
                    handler.string_value("Yottahertz");
                    break;
                case TypeValueKnownValues.Value_Radian:
                    handler.string_value("Radian");
                    break;
                case TypeValueKnownValues.Value_Degree:
                    handler.string_value("Degree");
                    break;
                case TypeValueKnownValues.Value_Turn:
                    handler.string_value("Turn");
                    break;
                case TypeValueKnownValues.Value_Quadrant:
                    handler.string_value("Quadrant");
                    break;
                case TypeValueKnownValues.Value_Sextant:
                    handler.string_value("Sextant");
                    break;
                case TypeValueKnownValues.Value_MinuteOfArc:
                    handler.string_value("MinuteOfArc");
                    break;
                case TypeValueKnownValues.Value_SecondOfArc:
                    handler.string_value("SecondOfArc");
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
                case TypeValueKnownValues.Value_Unknown:
                    handler.string_value("Unknown");
                    break;
                case TypeValueKnownValues.Value_Fathom:
                    handler.string_value("Fathom");
                    break;
                case TypeValueKnownValues.Value_League:
                    handler.string_value("League");
                    break;
                case TypeValueKnownValues.Value_LightYear:
                    handler.string_value("LightYear");
                    break;
                case TypeValueKnownValues.Value_AstronomicalUnit:
                    handler.string_value("AstronomicalUnit");
                    break;
                case TypeValueKnownValues.Value_Parsec:
                    handler.string_value("Parsec");
                    break;
                case TypeValueKnownValues.Value_Angstrom:
                    handler.string_value("Angstrom");
                    break;
                case TypeValueKnownValues.Value_Rope:
                    handler.string_value("Rope");
                    break;
                case TypeValueKnownValues.Value_Perch:
                    handler.string_value("Perch");
                    break;
                case TypeValueKnownValues.Value_Cubit:
                    handler.string_value("Cubit");
                    break;
                case TypeValueKnownValues.Value_Pole:
                    handler.string_value("Pole");
                    break;
                case TypeValueKnownValues.Value_Ell:
                    handler.string_value("Ell");
                    break;
                case TypeValueKnownValues.Value_Furlong:
                    handler.string_value("Furlong");
                    break;
                case TypeValueKnownValues.Value_Chain:
                    handler.string_value("Chain");
                    break;
                case TypeValueKnownValues.Value_Rod:
                    handler.string_value("Rod");
                    break;
                case TypeValueKnownValues.Value_Inch:
                    handler.string_value("Inch");
                    break;
                case TypeValueKnownValues.Value_Foot:
                    handler.string_value("Foot");
                    break;
                case TypeValueKnownValues.Value_Yard:
                    handler.string_value("Yard");
                    break;
                case TypeValueKnownValues.Value_Mile:
                    handler.string_value("Mile");
                    break;
                case TypeValueKnownValues.Value_NauticalMile:
                    handler.string_value("NauticalMile");
                    break;
                case TypeValueKnownValues.Value_Yoctometer:
                    handler.string_value("Yoctometer");
                    break;
                case TypeValueKnownValues.Value_Zeptometer:
                    handler.string_value("Zeptometer");
                    break;
                case TypeValueKnownValues.Value_Attometer:
                    handler.string_value("Attometer");
                    break;
                case TypeValueKnownValues.Value_Femtometer:
                    handler.string_value("Femtometer");
                    break;
                case TypeValueKnownValues.Value_Picometer:
                    handler.string_value("Picometer");
                    break;
                case TypeValueKnownValues.Value_Nanometer:
                    handler.string_value("Nanometer");
                    break;
                case TypeValueKnownValues.Value_Micrometer:
                    handler.string_value("Micrometer");
                    break;
                case TypeValueKnownValues.Value_Millimeter:
                    handler.string_value("Millimeter");
                    break;
                case TypeValueKnownValues.Value_Centimeter:
                    handler.string_value("Centimeter");
                    break;
                case TypeValueKnownValues.Value_Decimeter:
                    handler.string_value("Decimeter");
                    break;
                case TypeValueKnownValues.Value_Meter:
                    handler.string_value("Meter");
                    break;
                case TypeValueKnownValues.Value_Decameter:
                    handler.string_value("Decameter");
                    break;
                case TypeValueKnownValues.Value_Hectometer:
                    handler.string_value("Hectometer");
                    break;
                case TypeValueKnownValues.Value_Kilometer:
                    handler.string_value("Kilometer");
                    break;
                case TypeValueKnownValues.Value_Megameter:
                    handler.string_value("Megameter");
                    break;
                case TypeValueKnownValues.Value_Gigameter:
                    handler.string_value("Gigameter");
                    break;
                case TypeValueKnownValues.Value_Terameter:
                    handler.string_value("Terameter");
                    break;
                case TypeValueKnownValues.Value_Petameter:
                    handler.string_value("Petameter");
                    break;
                case TypeValueKnownValues.Value_Exameter:
                    handler.string_value("Exameter");
                    break;
                case TypeValueKnownValues.Value_Zettameter:
                    handler.string_value("Zettameter");
                    break;
                case TypeValueKnownValues.Value_Yottameter:
                    handler.string_value("Yottameter");
                    break;
                case TypeValueKnownValues.Value_Marathon:
                    handler.string_value("Marathon");
                    break;
                case TypeValueKnownValues.Value_HalfMarathon:
                    handler.string_value("HalfMarathon");
                    break;
                case TypeValueKnownValues.Value_TenKRun:
                    handler.string_value("TenKRun");
                    break;
                case TypeValueKnownValues.Value_FiveKRun:
                    handler.string_value("FiveKRun");
                    break;
                case TypeValueKnownValues.Value_OlympicPoolLap:
                    handler.string_value("OlympicPoolLap");
                    break;
                case TypeValueKnownValues.Value_DegreeFahrenheit:
                    handler.string_value("DegreeFahrenheit");
                    break;
                case TypeValueKnownValues.Value_DegreeCelsius:
                    handler.string_value("DegreeCelsius");
                    break;
                case TypeValueKnownValues.Value_Kelvin:
                    handler.string_value("Kelvin");
                    break;
                case TypeValueKnownValues.Value_Pascal:
                    handler.string_value("Pascal");
                    break;
                case TypeValueKnownValues.Value_Kilopascal:
                    handler.string_value("Kilopascal");
                    break;
                case TypeValueKnownValues.Value_Hectopascal:
                    handler.string_value("Hectopascal");
                    break;
                case TypeValueKnownValues.Value_Bar:
                    handler.string_value("Bar");
                    break;
                case TypeValueKnownValues.Value_Millibar:
                    handler.string_value("Millibar");
                    break;
                case TypeValueKnownValues.Value_PoundPerSquareInch:
                    handler.string_value("PoundPerSquareInch");
                    break;
                case TypeValueKnownValues.Value_InchOfMercury:
                    handler.string_value("InchOfMercury");
                    break;
                case TypeValueKnownValues.Value_Atmosphere:
                    handler.string_value("Atmosphere");
                    break;
                case TypeValueKnownValues.Value_Torr:
                    handler.string_value("Torr");
                    break;
                case TypeValueKnownValues.Value_Bit:
                    handler.string_value("Bit");
                    break;
                case TypeValueKnownValues.Value_Byte:
                    handler.string_value("Byte");
                    break;
                case TypeValueKnownValues.Value_Kilobit:
                    handler.string_value("Kilobit");
                    break;
                case TypeValueKnownValues.Value_Kilobyte:
                    handler.string_value("Kilobyte");
                    break;
                case TypeValueKnownValues.Value_Megabit:
                    handler.string_value("Megabit");
                    break;
                case TypeValueKnownValues.Value_Megabyte:
                    handler.string_value("Megabyte");
                    break;
                case TypeValueKnownValues.Value_Gigabit:
                    handler.string_value("Gigabit");
                    break;
                case TypeValueKnownValues.Value_Gigabyte:
                    handler.string_value("Gigabyte");
                    break;
                case TypeValueKnownValues.Value_Terabit:
                    handler.string_value("Terabit");
                    break;
                case TypeValueKnownValues.Value_Terabyte:
                    handler.string_value("Terabyte");
                    break;
                case TypeValueKnownValues.Value_Petabit:
                    handler.string_value("Petabit");
                    break;
                case TypeValueKnownValues.Value_Petabyte:
                    handler.string_value("Petabyte");
                    break;
                case TypeValueKnownValues.Value_Nanosecond:
                    handler.string_value("Nanosecond");
                    break;
                case TypeValueKnownValues.Value_Millisecond:
                    handler.string_value("Millisecond");
                    break;
                case TypeValueKnownValues.Value_Microsecond:
                    handler.string_value("Microsecond");
                    break;
                case TypeValueKnownValues.Value_Second:
                    handler.string_value("Second");
                    break;
                case TypeValueKnownValues.Value_Minute:
                    handler.string_value("Minute");
                    break;
                case TypeValueKnownValues.Value_Hour:
                    handler.string_value("Hour");
                    break;
                case TypeValueKnownValues.Value_Day:
                    handler.string_value("Day");
                    break;
                case TypeValueKnownValues.Value_Week:
                    handler.string_value("Week");
                    break;
                case TypeValueKnownValues.Value_Fortnight:
                    handler.string_value("Fortnight");
                    break;
                case TypeValueKnownValues.Value_Month:
                    handler.string_value("Month");
                    break;
                case TypeValueKnownValues.Value_Year:
                    handler.string_value("Year");
                    break;
                case TypeValueKnownValues.Value_Decade:
                    handler.string_value("Decade");
                    break;
                case TypeValueKnownValues.Value_Century:
                    handler.string_value("Century");
                    break;
                case TypeValueKnownValues.Value_Millenium:
                    handler.string_value("Millenium");
                    break;
                case TypeValueKnownValues.Value_SquareInch:
                    handler.string_value("SquareInch");
                    break;
                case TypeValueKnownValues.Value_SquareFoot:
                    handler.string_value("SquareFoot");
                    break;
                case TypeValueKnownValues.Value_SquareYard:
                    handler.string_value("SquareYard");
                    break;
                case TypeValueKnownValues.Value_SquareMile:
                    handler.string_value("SquareMile");
                    break;
                case TypeValueKnownValues.Value_SquareMillimeter:
                    handler.string_value("SquareMillimeter");
                    break;
                case TypeValueKnownValues.Value_SquareCentimeter:
                    handler.string_value("SquareCentimeter");
                    break;
                case TypeValueKnownValues.Value_SquareMeter:
                    handler.string_value("SquareMeter");
                    break;
                case TypeValueKnownValues.Value_SquareKilometer:
                    handler.string_value("SquareKilometer");
                    break;
                case TypeValueKnownValues.Value_Hectare:
                    handler.string_value("Hectare");
                    break;
                case TypeValueKnownValues.Value_Acre:
                    handler.string_value("Acre");
                    break;
                case TypeValueKnownValues.Value_Yoctogram:
                    handler.string_value("Yoctogram");
                    break;
                case TypeValueKnownValues.Value_Zeptogram:
                    handler.string_value("Zeptogram");
                    break;
                case TypeValueKnownValues.Value_Attogram:
                    handler.string_value("Attogram");
                    break;
                case TypeValueKnownValues.Value_Femtogram:
                    handler.string_value("Femtogram");
                    break;
                case TypeValueKnownValues.Value_Picogram:
                    handler.string_value("Picogram");
                    break;
                case TypeValueKnownValues.Value_Nanogram:
                    handler.string_value("Nanogram");
                    break;
                case TypeValueKnownValues.Value_Microgram:
                    handler.string_value("Microgram");
                    break;
                case TypeValueKnownValues.Value_Milligram:
                    handler.string_value("Milligram");
                    break;
                case TypeValueKnownValues.Value_Centigram:
                    handler.string_value("Centigram");
                    break;
                case TypeValueKnownValues.Value_Decigram:
                    handler.string_value("Decigram");
                    break;
                case TypeValueKnownValues.Value_Gram:
                    handler.string_value("Gram");
                    break;
                case TypeValueKnownValues.Value_Decagram:
                    handler.string_value("Decagram");
                    break;
                case TypeValueKnownValues.Value_Hectogram:
                    handler.string_value("Hectogram");
                    break;
                case TypeValueKnownValues.Value_Kilogram:
                    handler.string_value("Kilogram");
                    break;
                case TypeValueKnownValues.Value_Megagram:
                    handler.string_value("Megagram");
                    break;
                case TypeValueKnownValues.Value_Gigagram:
                    handler.string_value("Gigagram");
                    break;
                case TypeValueKnownValues.Value_Teragram:
                    handler.string_value("Teragram");
                    break;
                case TypeValueKnownValues.Value_Petagram:
                    handler.string_value("Petagram");
                    break;
                case TypeValueKnownValues.Value_Exagram:
                    handler.string_value("Exagram");
                    break;
                case TypeValueKnownValues.Value_Zettagram:
                    handler.string_value("Zettagram");
                    break;
                case TypeValueKnownValues.Value_Yottagram:
                    handler.string_value("Yottagram");
                    break;
                case TypeValueKnownValues.Value_MetricTon:
                    handler.string_value("MetricTon");
                    break;
                case TypeValueKnownValues.Value_OunceWeight:
                    handler.string_value("OunceWeight");
                    break;
                case TypeValueKnownValues.Value_Pound:
                    handler.string_value("Pound");
                    break;
                case TypeValueKnownValues.Value_Grain:
                    handler.string_value("Grain");
                    break;
                case TypeValueKnownValues.Value_Carat:
                    handler.string_value("Carat");
                    break;
                case TypeValueKnownValues.Value_TroyPound:
                    handler.string_value("TroyPound");
                    break;
                case TypeValueKnownValues.Value_TroyOunce:
                    handler.string_value("TroyOunce");
                    break;
                case TypeValueKnownValues.Value_PennyWeight:
                    handler.string_value("PennyWeight");
                    break;
                case TypeValueKnownValues.Value_Quarter:
                    handler.string_value("Quarter");
                    break;
                case TypeValueKnownValues.Value_Stone:
                    handler.string_value("Stone");
                    break;
                case TypeValueKnownValues.Value_Ton:
                    handler.string_value("Ton");
                    break;
                case TypeValueKnownValues.Value_LongTon:
                    handler.string_value("LongTon");
                    break;
                case TypeValueKnownValues.Value_CubicInch:
                    handler.string_value("CubicInch");
                    break;
                case TypeValueKnownValues.Value_CubicFoot:
                    handler.string_value("CubicFoot");
                    break;
                case TypeValueKnownValues.Value_CubicMeter:
                    handler.string_value("CubicMeter");
                    break;
                case TypeValueKnownValues.Value_USTeaspoon:
                    handler.string_value("USTeaspoon");
                    break;
                case TypeValueKnownValues.Value_UKTeaspoon:
                    handler.string_value("UKTeaspoon");
                    break;
                case TypeValueKnownValues.Value_USTablespoon:
                    handler.string_value("USTablespoon");
                    break;
                case TypeValueKnownValues.Value_UKTablespoon:
                    handler.string_value("UKTablespoon");
                    break;
                case TypeValueKnownValues.Value_USOunceVolume:
                    handler.string_value("USOunceVolume");
                    break;
                case TypeValueKnownValues.Value_UKOunceVolume:
                    handler.string_value("UKOunceVolume");
                    break;
                case TypeValueKnownValues.Value_Cup:
                    handler.string_value("Cup");
                    break;
                case TypeValueKnownValues.Value_Shot:
                    handler.string_value("Shot");
                    break;
                case TypeValueKnownValues.Value_USPint:
                    handler.string_value("USPint");
                    break;
                case TypeValueKnownValues.Value_USLiquidQuart:
                    handler.string_value("USLiquidQuart");
                    break;
                case TypeValueKnownValues.Value_USDryQuart:
                    handler.string_value("USDryQuart");
                    break;
                case TypeValueKnownValues.Value_USGallon:
                    handler.string_value("USGallon");
                    break;
                case TypeValueKnownValues.Value_UKPint:
                    handler.string_value("UKPint");
                    break;
                case TypeValueKnownValues.Value_UKQuart:
                    handler.string_value("UKQuart");
                    break;
                case TypeValueKnownValues.Value_UKGallon:
                    handler.string_value("UKGallon");
                    break;
                case TypeValueKnownValues.Value_Milliliter:
                    handler.string_value("Milliliter");
                    break;
                case TypeValueKnownValues.Value_CubicCentimeter:
                    handler.string_value("CubicCentimeter");
                    break;
                case TypeValueKnownValues.Value_Liter:
                    handler.string_value("Liter");
                    break;
                case TypeValueKnownValues.Value_Yoctoliter:
                    handler.string_value("Yoctoliter");
                    break;
                case TypeValueKnownValues.Value_Zeptoliter:
                    handler.string_value("Zeptoliter");
                    break;
                case TypeValueKnownValues.Value_Attoliter:
                    handler.string_value("Attoliter");
                    break;
                case TypeValueKnownValues.Value_Femtoliter:
                    handler.string_value("Femtoliter");
                    break;
                case TypeValueKnownValues.Value_Picoliter:
                    handler.string_value("Picoliter");
                    break;
                case TypeValueKnownValues.Value_Nanoliter:
                    handler.string_value("Nanoliter");
                    break;
                case TypeValueKnownValues.Value_Microliter:
                    handler.string_value("Microliter");
                    break;
                case TypeValueKnownValues.Value_Centiliter:
                    handler.string_value("Centiliter");
                    break;
                case TypeValueKnownValues.Value_Deciliter:
                    handler.string_value("Deciliter");
                    break;
                case TypeValueKnownValues.Value_Decaliter:
                    handler.string_value("Decaliter");
                    break;
                case TypeValueKnownValues.Value_Hectoliter:
                    handler.string_value("Hectoliter");
                    break;
                case TypeValueKnownValues.Value_Kiloliter:
                    handler.string_value("Kiloliter");
                    break;
                case TypeValueKnownValues.Value_Megaliter:
                    handler.string_value("Megaliter");
                    break;
                case TypeValueKnownValues.Value_Gigaliter:
                    handler.string_value("Gigaliter");
                    break;
                case TypeValueKnownValues.Value_Teraliter:
                    handler.string_value("Teraliter");
                    break;
                case TypeValueKnownValues.Value_Petaliter:
                    handler.string_value("Petaliter");
                    break;
                case TypeValueKnownValues.Value_Exaliter:
                    handler.string_value("Exaliter");
                    break;
                case TypeValueKnownValues.Value_Zettaliter:
                    handler.string_value("Zettaliter");
                    break;
                case TypeValueKnownValues.Value_Yottaliter:
                    handler.string_value("Yottaliter");
                    break;
                case TypeValueKnownValues.Value_USBushel:
                    handler.string_value("USBushel");
                    break;
                case TypeValueKnownValues.Value_UKBushel:
                    handler.string_value("UKBushel");
                    break;
                case TypeValueKnownValues.Value_USPeck:
                    handler.string_value("USPeck");
                    break;
                case TypeValueKnownValues.Value_UKPeck:
                    handler.string_value("UKPeck");
                    break;
                case TypeValueKnownValues.Value_USHogshead:
                    handler.string_value("USHogshead");
                    break;
                case TypeValueKnownValues.Value_USBarrel:
                    handler.string_value("USBarrel");
                    break;
                case TypeValueKnownValues.Value_USTierce:
                    handler.string_value("USTierce");
                    break;
                case TypeValueKnownValues.Value_Newton:
                    handler.string_value("Newton");
                    break;
                case TypeValueKnownValues.Value_Kilonewton:
                    handler.string_value("Kilonewton");
                    break;
                case TypeValueKnownValues.Value_Dyne:
                    handler.string_value("Dyne");
                    break;
                case TypeValueKnownValues.Value_Poundal:
                    handler.string_value("Poundal");
                    break;
                case TypeValueKnownValues.Value_Pond:
                    handler.string_value("Pond");
                    break;
                case TypeValueKnownValues.Value_Kilopond:
                    handler.string_value("Kilopond");
                    break;
                case TypeValueKnownValues.Value_OunceForce:
                    handler.string_value("OunceForce");
                    break;
                case TypeValueKnownValues.Value_PoundForce:
                    handler.string_value("PoundForce");
                    break;
                case TypeValueKnownValues.Value_Joule:
                    handler.string_value("Joule");
                    break;
                case TypeValueKnownValues.Value_Kilojoule:
                    handler.string_value("Kilojoule");
                    break;
                case TypeValueKnownValues.Value_Calorie:
                    handler.string_value("Calorie");
                    break;
                case TypeValueKnownValues.Value_Kilocalorie:
                    handler.string_value("Kilocalorie");
                    break;
                case TypeValueKnownValues.Value_KilowattHour:
                    handler.string_value("KilowattHour");
                    break;
                case TypeValueKnownValues.Value_Btu:
                    handler.string_value("Btu");
                    break;
                case TypeValueKnownValues.Value_Watt:
                    handler.string_value("Watt");
                    break;
                case TypeValueKnownValues.Value_Kilowatt:
                    handler.string_value("Kilowatt");
                    break;
                case TypeValueKnownValues.Value_Horsepower:
                    handler.string_value("Horsepower");
                    break;
                case TypeValueKnownValues.Value_MetricHorsepower:
                    handler.string_value("MetricHorsepower");
                    break;
                case TypeValueKnownValues.Value_FootPoundPerMinute:
                    handler.string_value("FootPoundPerMinute");
                    break;
                case TypeValueKnownValues.Value_ErgPerSecond:
                    handler.string_value("ErgPerSecond");
                    break;
                case TypeValueKnownValues.Value_CaloriesPerSecond:
                    handler.string_value("CaloriesPerSecond");
                    break;
                case TypeValueKnownValues.Value_MeterPerSecondSquared:
                    handler.string_value("MeterPerSecondSquared");
                    break;
                case TypeValueKnownValues.Value_InchPerSecondSquared:
                    handler.string_value("InchPerSecondSquared");
                    break;
                case TypeValueKnownValues.Value_FootPerSecondSquared:
                    handler.string_value("FootPerSecondSquared");
                    break;
                case TypeValueKnownValues.Value_Galileo:
                    handler.string_value("Galileo");
                    break;
                case TypeValueKnownValues.Value_G:
                    handler.string_value("G");
                    break;
                case TypeValueKnownValues.Value_KilometerPerHour:
                    handler.string_value("KilometerPerHour");
                    break;
                case TypeValueKnownValues.Value_MilePerHour:
                    handler.string_value("MilePerHour");
                    break;
                case TypeValueKnownValues.Value_FootPerSecond:
                    handler.string_value("FootPerSecond");
                    break;
                case TypeValueKnownValues.Value_MeterPerSecond:
                    handler.string_value("MeterPerSecond");
                    break;
                case TypeValueKnownValues.Value_Knot:
                    handler.string_value("Knot");
                    break;
                case TypeValueKnownValues.Value_Mach:
                    handler.string_value("Mach");
                    break;
                case TypeValueKnownValues.Value_Yoctohertz:
                    handler.string_value("Yoctohertz");
                    break;
                case TypeValueKnownValues.Value_Zeptohertz:
                    handler.string_value("Zeptohertz");
                    break;
                case TypeValueKnownValues.Value_Attohertz:
                    handler.string_value("Attohertz");
                    break;
                case TypeValueKnownValues.Value_Femtohertz:
                    handler.string_value("Femtohertz");
                    break;
                case TypeValueKnownValues.Value_Picohertz:
                    handler.string_value("Picohertz");
                    break;
                case TypeValueKnownValues.Value_Nanohertz:
                    handler.string_value("Nanohertz");
                    break;
                case TypeValueKnownValues.Value_Microhertz:
                    handler.string_value("Microhertz");
                    break;
                case TypeValueKnownValues.Value_Millihertz:
                    handler.string_value("Millihertz");
                    break;
                case TypeValueKnownValues.Value_Centihertz:
                    handler.string_value("Centihertz");
                    break;
                case TypeValueKnownValues.Value_Decihertz:
                    handler.string_value("Decihertz");
                    break;
                case TypeValueKnownValues.Value_Hertz:
                    handler.string_value("Hertz");
                    break;
                case TypeValueKnownValues.Value_Decahertz:
                    handler.string_value("Decahertz");
                    break;
                case TypeValueKnownValues.Value_Hectohertz:
                    handler.string_value("Hectohertz");
                    break;
                case TypeValueKnownValues.Value_Kilohertz:
                    handler.string_value("Kilohertz");
                    break;
                case TypeValueKnownValues.Value_Megahertz:
                    handler.string_value("Megahertz");
                    break;
                case TypeValueKnownValues.Value_Gigahertz:
                    handler.string_value("Gigahertz");
                    break;
                case TypeValueKnownValues.Value_Terahertz:
                    handler.string_value("Terahertz");
                    break;
                case TypeValueKnownValues.Value_Petahertz:
                    handler.string_value("Petahertz");
                    break;
                case TypeValueKnownValues.Value_Exahertz:
                    handler.string_value("Exahertz");
                    break;
                case TypeValueKnownValues.Value_Zettahertz:
                    handler.string_value("Zettahertz");
                    break;
                case TypeValueKnownValues.Value_Yottahertz:
                    handler.string_value("Yottahertz");
                    break;
                case TypeValueKnownValues.Value_Radian:
                    handler.string_value("Radian");
                    break;
                case TypeValueKnownValues.Value_Degree:
                    handler.string_value("Degree");
                    break;
                case TypeValueKnownValues.Value_Turn:
                    handler.string_value("Turn");
                    break;
                case TypeValueKnownValues.Value_Quadrant:
                    handler.string_value("Quadrant");
                    break;
                case TypeValueKnownValues.Value_Sextant:
                    handler.string_value("Sextant");
                    break;
                case TypeValueKnownValues.Value_MinuteOfArc:
                    handler.string_value("MinuteOfArc");
                    break;
                case TypeValueKnownValues.Value_SecondOfArc:
                    handler.string_value("SecondOfArc");
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

    public static UnitOfMeasureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnitOfMeasureJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitOfMeasure", ignore_extras);
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
    public static UnitOfMeasureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UnitOfMeasureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnitOfMeasureJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitOfMeasure", ignore_extras);
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
    public static UnitOfMeasureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UnitOfMeasureJSON from_text(string text, bool ignore_extras)
      {
        UnitOfMeasureJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitOfMeasure", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UnitOfMeasureJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UnitOfMeasureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UnitOfMeasureJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitOfMeasure", ignore_extras);
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
            UnitOfMeasureJSON result = new UnitOfMeasureJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(UnitOfMeasureJSON new_result);
        public Generator(bool ignore_extras) : base("Type UnitOfMeasure")
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
        protected override void handle_result(UnitOfMeasureJSON  result)
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
        public UnitOfMeasureJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UnitOfMeasureJSON  result)
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
    protected virtual void handle_result(List<UnitOfMeasureJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UnitOfMeasureJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UnitOfMeasureJSON>();
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
    public List<UnitOfMeasureJSON> value;
  };
  };
