/* file "SportsOlympicsGamesCodeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsGamesCodeJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_1896Athens,
        Value_1900Paris,
        Value_1904StLouis,
        Value_1908London,
        Value_1912Stockholm,
        Value_1920Antwerp,
        Value_1924Chamonix,
        Value_1924Paris,
        Value_1928StMoritz,
        Value_1928Amsterdam,
        Value_1932LakePlacid,
        Value_1932LosAngeles,
        Value_1936GarmischPartenkirchen,
        Value_1936Berlin,
        Value_1948StMoritz,
        Value_1948London,
        Value_1952Oslo,
        Value_1952Helsinki,
        Value_1956CortinaDAmpezzo,
        Value_1956Melbourne,
        Value_1960SquawValley,
        Value_1960Rome,
        Value_1964Innsbruck,
        Value_1964Tokyo,
        Value_1968Grenoble,
        Value_1968MexicoCity,
        Value_1972Sapporo,
        Value_1972Munich,
        Value_1976Innsbruck,
        Value_1976Montreal,
        Value_1980LakePlacid,
        Value_1980Moscow,
        Value_1984Sarajevo,
        Value_1984LosAngeles,
        Value_1988Calgary,
        Value_1988Seoul,
        Value_1992Albertville,
        Value_1992Barcelona,
        Value_1994Lillehammer,
        Value_1996Atlanta,
        Value_1998Nagano,
        Value_2000Sydney,
        Value_2002SaltLakeCity,
        Value_2004Athens,
        Value_2006Turin,
        Value_2008Beijing,
        Value_2010Vancouver,
        Value_2012London,
        Value_2014Sochi,
        Value_2016RioDeJaneiro,
        Value_2018Pyeongchang,
        Value_2020Tokyo,
        Value_2022Beijing,
        Value_2024Paris,
        Value_2026MilanCortina,
        Value_2028LosAngeles,
        Value_2032Brisbane,
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
            case '1':
                switch (chars[1])
                  {
                    case '8':
                        if ((String.Compare(chars, 2, "96Athens", 0, 8, false) == 0) && (chars.Length == 10))
                            return TypeValueKnownValues.Value_1896Athens;
                        break;
                    case '9':
                        switch (chars[2])
                          {
                            case '0':
                                switch (chars[3])
                                  {
                                    case '0':
                                        if ((String.Compare(chars, 4, "Paris", 0, 5, false) == 0) && (chars.Length == 9))
                                            return TypeValueKnownValues.Value_1900Paris;
                                        break;
                                    case '4':
                                        if ((String.Compare(chars, 4, "StLouis", 0, 7, false) == 0) && (chars.Length == 11))
                                            return TypeValueKnownValues.Value_1904StLouis;
                                        break;
                                    case '8':
                                        if ((String.Compare(chars, 4, "London", 0, 6, false) == 0) && (chars.Length == 10))
                                            return TypeValueKnownValues.Value_1908London;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case '1':
                                if ((String.Compare(chars, 3, "2Stockholm", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeValueKnownValues.Value_1912Stockholm;
                                break;
                            case '2':
                                switch (chars[3])
                                  {
                                    case '0':
                                        if ((String.Compare(chars, 4, "Antwerp", 0, 7, false) == 0) && (chars.Length == 11))
                                            return TypeValueKnownValues.Value_1920Antwerp;
                                        break;
                                    case '4':
                                        switch (chars[4])
                                          {
                                            case 'C':
                                                if ((String.Compare(chars, 5, "hamonix", 0, 7, false) == 0) && (chars.Length == 12))
                                                    return TypeValueKnownValues.Value_1924Chamonix;
                                                break;
                                            case 'P':
                                                if ((String.Compare(chars, 5, "aris", 0, 4, false) == 0) && (chars.Length == 9))
                                                    return TypeValueKnownValues.Value_1924Paris;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '8':
                                        switch (chars[4])
                                          {
                                            case 'A':
                                                if ((String.Compare(chars, 5, "msterdam", 0, 8, false) == 0) && (chars.Length == 13))
                                                    return TypeValueKnownValues.Value_1928Amsterdam;
                                                break;
                                            case 'S':
                                                if ((String.Compare(chars, 5, "tMoritz", 0, 7, false) == 0) && (chars.Length == 12))
                                                    return TypeValueKnownValues.Value_1928StMoritz;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case '3':
                                switch (chars[3])
                                  {
                                    case '2':
                                        if (String.Compare(chars, 4, "L", 0, 1, false) == 0)
                                          {
                                            switch (chars[5])
                                              {
                                                case 'a':
                                                    if ((String.Compare(chars, 6, "kePlacid", 0, 8, false) == 0) && (chars.Length == 14))
                                                        return TypeValueKnownValues.Value_1932LakePlacid;
                                                    break;
                                                case 'o':
                                                    if ((String.Compare(chars, 6, "sAngeles", 0, 8, false) == 0) && (chars.Length == 14))
                                                        return TypeValueKnownValues.Value_1932LosAngeles;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case '6':
                                        switch (chars[4])
                                          {
                                            case 'B':
                                                if ((String.Compare(chars, 5, "erlin", 0, 5, false) == 0) && (chars.Length == 10))
                                                    return TypeValueKnownValues.Value_1936Berlin;
                                                break;
                                            case 'G':
                                                if ((String.Compare(chars, 5, "armischPartenkirchen", 0, 20, false) == 0) && (chars.Length == 25))
                                                    return TypeValueKnownValues.Value_1936GarmischPartenkirchen;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case '4':
                                if (String.Compare(chars, 3, "8", 0, 1, false) == 0)
                                  {
                                    switch (chars[4])
                                      {
                                        case 'L':
                                            if ((String.Compare(chars, 5, "ondon", 0, 5, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_1948London;
                                            break;
                                        case 'S':
                                            if ((String.Compare(chars, 5, "tMoritz", 0, 7, false) == 0) && (chars.Length == 12))
                                                return TypeValueKnownValues.Value_1948StMoritz;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case '5':
                                switch (chars[3])
                                  {
                                    case '2':
                                        switch (chars[4])
                                          {
                                            case 'H':
                                                if ((String.Compare(chars, 5, "elsinki", 0, 7, false) == 0) && (chars.Length == 12))
                                                    return TypeValueKnownValues.Value_1952Helsinki;
                                                break;
                                            case 'O':
                                                if ((String.Compare(chars, 5, "slo", 0, 3, false) == 0) && (chars.Length == 8))
                                                    return TypeValueKnownValues.Value_1952Oslo;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '6':
                                        switch (chars[4])
                                          {
                                            case 'C':
                                                if ((String.Compare(chars, 5, "ortinaDAmpezzo", 0, 14, false) == 0) && (chars.Length == 19))
                                                    return TypeValueKnownValues.Value_1956CortinaDAmpezzo;
                                                break;
                                            case 'M':
                                                if ((String.Compare(chars, 5, "elbourne", 0, 8, false) == 0) && (chars.Length == 13))
                                                    return TypeValueKnownValues.Value_1956Melbourne;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case '6':
                                switch (chars[3])
                                  {
                                    case '0':
                                        switch (chars[4])
                                          {
                                            case 'R':
                                                if ((String.Compare(chars, 5, "ome", 0, 3, false) == 0) && (chars.Length == 8))
                                                    return TypeValueKnownValues.Value_1960Rome;
                                                break;
                                            case 'S':
                                                if ((String.Compare(chars, 5, "quawValley", 0, 10, false) == 0) && (chars.Length == 15))
                                                    return TypeValueKnownValues.Value_1960SquawValley;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '4':
                                        switch (chars[4])
                                          {
                                            case 'I':
                                                if ((String.Compare(chars, 5, "nnsbruck", 0, 8, false) == 0) && (chars.Length == 13))
                                                    return TypeValueKnownValues.Value_1964Innsbruck;
                                                break;
                                            case 'T':
                                                if ((String.Compare(chars, 5, "okyo", 0, 4, false) == 0) && (chars.Length == 9))
                                                    return TypeValueKnownValues.Value_1964Tokyo;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '8':
                                        switch (chars[4])
                                          {
                                            case 'G':
                                                if ((String.Compare(chars, 5, "renoble", 0, 7, false) == 0) && (chars.Length == 12))
                                                    return TypeValueKnownValues.Value_1968Grenoble;
                                                break;
                                            case 'M':
                                                if ((String.Compare(chars, 5, "exicoCity", 0, 9, false) == 0) && (chars.Length == 14))
                                                    return TypeValueKnownValues.Value_1968MexicoCity;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case '7':
                                switch (chars[3])
                                  {
                                    case '2':
                                        switch (chars[4])
                                          {
                                            case 'M':
                                                if ((String.Compare(chars, 5, "unich", 0, 5, false) == 0) && (chars.Length == 10))
                                                    return TypeValueKnownValues.Value_1972Munich;
                                                break;
                                            case 'S':
                                                if ((String.Compare(chars, 5, "apporo", 0, 6, false) == 0) && (chars.Length == 11))
                                                    return TypeValueKnownValues.Value_1972Sapporo;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '6':
                                        switch (chars[4])
                                          {
                                            case 'I':
                                                if ((String.Compare(chars, 5, "nnsbruck", 0, 8, false) == 0) && (chars.Length == 13))
                                                    return TypeValueKnownValues.Value_1976Innsbruck;
                                                break;
                                            case 'M':
                                                if ((String.Compare(chars, 5, "ontreal", 0, 7, false) == 0) && (chars.Length == 12))
                                                    return TypeValueKnownValues.Value_1976Montreal;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case '8':
                                switch (chars[3])
                                  {
                                    case '0':
                                        switch (chars[4])
                                          {
                                            case 'L':
                                                if ((String.Compare(chars, 5, "akePlacid", 0, 9, false) == 0) && (chars.Length == 14))
                                                    return TypeValueKnownValues.Value_1980LakePlacid;
                                                break;
                                            case 'M':
                                                if ((String.Compare(chars, 5, "oscow", 0, 5, false) == 0) && (chars.Length == 10))
                                                    return TypeValueKnownValues.Value_1980Moscow;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '4':
                                        switch (chars[4])
                                          {
                                            case 'L':
                                                if ((String.Compare(chars, 5, "osAngeles", 0, 9, false) == 0) && (chars.Length == 14))
                                                    return TypeValueKnownValues.Value_1984LosAngeles;
                                                break;
                                            case 'S':
                                                if ((String.Compare(chars, 5, "arajevo", 0, 7, false) == 0) && (chars.Length == 12))
                                                    return TypeValueKnownValues.Value_1984Sarajevo;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '8':
                                        switch (chars[4])
                                          {
                                            case 'C':
                                                if ((String.Compare(chars, 5, "algary", 0, 6, false) == 0) && (chars.Length == 11))
                                                    return TypeValueKnownValues.Value_1988Calgary;
                                                break;
                                            case 'S':
                                                if ((String.Compare(chars, 5, "eoul", 0, 4, false) == 0) && (chars.Length == 9))
                                                    return TypeValueKnownValues.Value_1988Seoul;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case '9':
                                switch (chars[3])
                                  {
                                    case '2':
                                        switch (chars[4])
                                          {
                                            case 'A':
                                                if ((String.Compare(chars, 5, "lbertville", 0, 10, false) == 0) && (chars.Length == 15))
                                                    return TypeValueKnownValues.Value_1992Albertville;
                                                break;
                                            case 'B':
                                                if ((String.Compare(chars, 5, "arcelona", 0, 8, false) == 0) && (chars.Length == 13))
                                                    return TypeValueKnownValues.Value_1992Barcelona;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '4':
                                        if ((String.Compare(chars, 4, "Lillehammer", 0, 11, false) == 0) && (chars.Length == 15))
                                            return TypeValueKnownValues.Value_1994Lillehammer;
                                        break;
                                    case '6':
                                        if ((String.Compare(chars, 4, "Atlanta", 0, 7, false) == 0) && (chars.Length == 11))
                                            return TypeValueKnownValues.Value_1996Atlanta;
                                        break;
                                    case '8':
                                        if ((String.Compare(chars, 4, "Nagano", 0, 6, false) == 0) && (chars.Length == 10))
                                            return TypeValueKnownValues.Value_1998Nagano;
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
            case '2':
                if (String.Compare(chars, 1, "0", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case '0':
                            switch (chars[3])
                              {
                                case '0':
                                    if ((String.Compare(chars, 4, "Sydney", 0, 6, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_2000Sydney;
                                    break;
                                case '2':
                                    if ((String.Compare(chars, 4, "SaltLakeCity", 0, 12, false) == 0) && (chars.Length == 16))
                                        return TypeValueKnownValues.Value_2002SaltLakeCity;
                                    break;
                                case '4':
                                    if ((String.Compare(chars, 4, "Athens", 0, 6, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_2004Athens;
                                    break;
                                case '6':
                                    if ((String.Compare(chars, 4, "Turin", 0, 5, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_2006Turin;
                                    break;
                                case '8':
                                    if ((String.Compare(chars, 4, "Beijing", 0, 7, false) == 0) && (chars.Length == 11))
                                        return TypeValueKnownValues.Value_2008Beijing;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case '1':
                            switch (chars[3])
                              {
                                case '0':
                                    if ((String.Compare(chars, 4, "Vancouver", 0, 9, false) == 0) && (chars.Length == 13))
                                        return TypeValueKnownValues.Value_2010Vancouver;
                                    break;
                                case '2':
                                    if ((String.Compare(chars, 4, "London", 0, 6, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_2012London;
                                    break;
                                case '4':
                                    if ((String.Compare(chars, 4, "Sochi", 0, 5, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_2014Sochi;
                                    break;
                                case '6':
                                    if ((String.Compare(chars, 4, "RioDeJaneiro", 0, 12, false) == 0) && (chars.Length == 16))
                                        return TypeValueKnownValues.Value_2016RioDeJaneiro;
                                    break;
                                case '8':
                                    if ((String.Compare(chars, 4, "Pyeongchang", 0, 11, false) == 0) && (chars.Length == 15))
                                        return TypeValueKnownValues.Value_2018Pyeongchang;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case '2':
                            switch (chars[3])
                              {
                                case '0':
                                    if ((String.Compare(chars, 4, "Tokyo", 0, 5, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_2020Tokyo;
                                    break;
                                case '2':
                                    if ((String.Compare(chars, 4, "Beijing", 0, 7, false) == 0) && (chars.Length == 11))
                                        return TypeValueKnownValues.Value_2022Beijing;
                                    break;
                                case '4':
                                    if ((String.Compare(chars, 4, "Paris", 0, 5, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_2024Paris;
                                    break;
                                case '6':
                                    if ((String.Compare(chars, 4, "MilanCortina", 0, 12, false) == 0) && (chars.Length == 16))
                                        return TypeValueKnownValues.Value_2026MilanCortina;
                                    break;
                                case '8':
                                    if ((String.Compare(chars, 4, "LosAngeles", 0, 10, false) == 0) && (chars.Length == 14))
                                        return TypeValueKnownValues.Value_2028LosAngeles;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case '3':
                            if ((String.Compare(chars, 3, "2Brisbane", 0, 9, false) == 0) && (chars.Length == 12))
                                return TypeValueKnownValues.Value_2032Brisbane;
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
            case TypeValueKnownValues.Value_1896Athens:
                return "1896Athens";
            case TypeValueKnownValues.Value_1900Paris:
                return "1900Paris";
            case TypeValueKnownValues.Value_1904StLouis:
                return "1904StLouis";
            case TypeValueKnownValues.Value_1908London:
                return "1908London";
            case TypeValueKnownValues.Value_1912Stockholm:
                return "1912Stockholm";
            case TypeValueKnownValues.Value_1920Antwerp:
                return "1920Antwerp";
            case TypeValueKnownValues.Value_1924Chamonix:
                return "1924Chamonix";
            case TypeValueKnownValues.Value_1924Paris:
                return "1924Paris";
            case TypeValueKnownValues.Value_1928StMoritz:
                return "1928StMoritz";
            case TypeValueKnownValues.Value_1928Amsterdam:
                return "1928Amsterdam";
            case TypeValueKnownValues.Value_1932LakePlacid:
                return "1932LakePlacid";
            case TypeValueKnownValues.Value_1932LosAngeles:
                return "1932LosAngeles";
            case TypeValueKnownValues.Value_1936GarmischPartenkirchen:
                return "1936GarmischPartenkirchen";
            case TypeValueKnownValues.Value_1936Berlin:
                return "1936Berlin";
            case TypeValueKnownValues.Value_1948StMoritz:
                return "1948StMoritz";
            case TypeValueKnownValues.Value_1948London:
                return "1948London";
            case TypeValueKnownValues.Value_1952Oslo:
                return "1952Oslo";
            case TypeValueKnownValues.Value_1952Helsinki:
                return "1952Helsinki";
            case TypeValueKnownValues.Value_1956CortinaDAmpezzo:
                return "1956CortinaDAmpezzo";
            case TypeValueKnownValues.Value_1956Melbourne:
                return "1956Melbourne";
            case TypeValueKnownValues.Value_1960SquawValley:
                return "1960SquawValley";
            case TypeValueKnownValues.Value_1960Rome:
                return "1960Rome";
            case TypeValueKnownValues.Value_1964Innsbruck:
                return "1964Innsbruck";
            case TypeValueKnownValues.Value_1964Tokyo:
                return "1964Tokyo";
            case TypeValueKnownValues.Value_1968Grenoble:
                return "1968Grenoble";
            case TypeValueKnownValues.Value_1968MexicoCity:
                return "1968MexicoCity";
            case TypeValueKnownValues.Value_1972Sapporo:
                return "1972Sapporo";
            case TypeValueKnownValues.Value_1972Munich:
                return "1972Munich";
            case TypeValueKnownValues.Value_1976Innsbruck:
                return "1976Innsbruck";
            case TypeValueKnownValues.Value_1976Montreal:
                return "1976Montreal";
            case TypeValueKnownValues.Value_1980LakePlacid:
                return "1980LakePlacid";
            case TypeValueKnownValues.Value_1980Moscow:
                return "1980Moscow";
            case TypeValueKnownValues.Value_1984Sarajevo:
                return "1984Sarajevo";
            case TypeValueKnownValues.Value_1984LosAngeles:
                return "1984LosAngeles";
            case TypeValueKnownValues.Value_1988Calgary:
                return "1988Calgary";
            case TypeValueKnownValues.Value_1988Seoul:
                return "1988Seoul";
            case TypeValueKnownValues.Value_1992Albertville:
                return "1992Albertville";
            case TypeValueKnownValues.Value_1992Barcelona:
                return "1992Barcelona";
            case TypeValueKnownValues.Value_1994Lillehammer:
                return "1994Lillehammer";
            case TypeValueKnownValues.Value_1996Atlanta:
                return "1996Atlanta";
            case TypeValueKnownValues.Value_1998Nagano:
                return "1998Nagano";
            case TypeValueKnownValues.Value_2000Sydney:
                return "2000Sydney";
            case TypeValueKnownValues.Value_2002SaltLakeCity:
                return "2002SaltLakeCity";
            case TypeValueKnownValues.Value_2004Athens:
                return "2004Athens";
            case TypeValueKnownValues.Value_2006Turin:
                return "2006Turin";
            case TypeValueKnownValues.Value_2008Beijing:
                return "2008Beijing";
            case TypeValueKnownValues.Value_2010Vancouver:
                return "2010Vancouver";
            case TypeValueKnownValues.Value_2012London:
                return "2012London";
            case TypeValueKnownValues.Value_2014Sochi:
                return "2014Sochi";
            case TypeValueKnownValues.Value_2016RioDeJaneiro:
                return "2016RioDeJaneiro";
            case TypeValueKnownValues.Value_2018Pyeongchang:
                return "2018Pyeongchang";
            case TypeValueKnownValues.Value_2020Tokyo:
                return "2020Tokyo";
            case TypeValueKnownValues.Value_2022Beijing:
                return "2022Beijing";
            case TypeValueKnownValues.Value_2024Paris:
                return "2024Paris";
            case TypeValueKnownValues.Value_2026MilanCortina:
                return "2026MilanCortina";
            case TypeValueKnownValues.Value_2028LosAngeles:
                return "2028LosAngeles";
            case TypeValueKnownValues.Value_2032Brisbane:
                return "2032Brisbane";
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
            throw new Exception("The value for field Value of SportsOlympicsGamesCodeJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case '1':
                switch (json_string.getData()[1])
                  {
                    case '8':
                        if ((String.Compare(json_string.getData(), 2, "96Athens", 0, 8, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_1896Athens;
                                goto open_enum_is_done;
                              }
                        break;
                    case '9':
                        switch (json_string.getData()[2])
                          {
                            case '0':
                                switch (json_string.getData()[3])
                                  {
                                    case '0':
                                        if ((String.Compare(json_string.getData(), 4, "Paris", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_1900Paris;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case '4':
                                        if ((String.Compare(json_string.getData(), 4, "StLouis", 0, 7, false) == 0) && (json_string.getData().Length == 11))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_1904StLouis;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case '8':
                                        if ((String.Compare(json_string.getData(), 4, "London", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_1908London;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case '1':
                                if ((String.Compare(json_string.getData(), 3, "2Stockholm", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_1912Stockholm;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case '2':
                                switch (json_string.getData()[3])
                                  {
                                    case '0':
                                        if ((String.Compare(json_string.getData(), 4, "Antwerp", 0, 7, false) == 0) && (json_string.getData().Length == 11))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_1920Antwerp;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case '4':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'C':
                                                if ((String.Compare(json_string.getData(), 5, "hamonix", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1924Chamonix;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'P':
                                                if ((String.Compare(json_string.getData(), 5, "aris", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1924Paris;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '8':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'A':
                                                if ((String.Compare(json_string.getData(), 5, "msterdam", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1928Amsterdam;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'S':
                                                if ((String.Compare(json_string.getData(), 5, "tMoritz", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1928StMoritz;
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
                            case '3':
                                switch (json_string.getData()[3])
                                  {
                                    case '2':
                                        if (String.Compare(json_string.getData(), 4, "L", 0, 1, false) == 0)
                                          {
                                            switch (json_string.getData()[5])
                                              {
                                                case 'a':
                                                    if ((String.Compare(json_string.getData(), 6, "kePlacid", 0, 8, false) == 0) && (json_string.getData().Length == 14))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_1932LakePlacid;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'o':
                                                    if ((String.Compare(json_string.getData(), 6, "sAngeles", 0, 8, false) == 0) && (json_string.getData().Length == 14))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_1932LosAngeles;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case '6':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'B':
                                                if ((String.Compare(json_string.getData(), 5, "erlin", 0, 5, false) == 0) && (json_string.getData().Length == 10))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1936Berlin;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'G':
                                                if ((String.Compare(json_string.getData(), 5, "armischPartenkirchen", 0, 20, false) == 0) && (json_string.getData().Length == 25))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1936GarmischPartenkirchen;
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
                            case '4':
                                if (String.Compare(json_string.getData(), 3, "8", 0, 1, false) == 0)
                                  {
                                    switch (json_string.getData()[4])
                                      {
                                        case 'L':
                                            if ((String.Compare(json_string.getData(), 5, "ondon", 0, 5, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_1948London;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'S':
                                            if ((String.Compare(json_string.getData(), 5, "tMoritz", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_1948StMoritz;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case '5':
                                switch (json_string.getData()[3])
                                  {
                                    case '2':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'H':
                                                if ((String.Compare(json_string.getData(), 5, "elsinki", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1952Helsinki;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'O':
                                                if ((String.Compare(json_string.getData(), 5, "slo", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1952Oslo;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '6':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'C':
                                                if ((String.Compare(json_string.getData(), 5, "ortinaDAmpezzo", 0, 14, false) == 0) && (json_string.getData().Length == 19))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1956CortinaDAmpezzo;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'M':
                                                if ((String.Compare(json_string.getData(), 5, "elbourne", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1956Melbourne;
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
                            case '6':
                                switch (json_string.getData()[3])
                                  {
                                    case '0':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'R':
                                                if ((String.Compare(json_string.getData(), 5, "ome", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1960Rome;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'S':
                                                if ((String.Compare(json_string.getData(), 5, "quawValley", 0, 10, false) == 0) && (json_string.getData().Length == 15))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1960SquawValley;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '4':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'I':
                                                if ((String.Compare(json_string.getData(), 5, "nnsbruck", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1964Innsbruck;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'T':
                                                if ((String.Compare(json_string.getData(), 5, "okyo", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1964Tokyo;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '8':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'G':
                                                if ((String.Compare(json_string.getData(), 5, "renoble", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1968Grenoble;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'M':
                                                if ((String.Compare(json_string.getData(), 5, "exicoCity", 0, 9, false) == 0) && (json_string.getData().Length == 14))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1968MexicoCity;
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
                            case '7':
                                switch (json_string.getData()[3])
                                  {
                                    case '2':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'M':
                                                if ((String.Compare(json_string.getData(), 5, "unich", 0, 5, false) == 0) && (json_string.getData().Length == 10))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1972Munich;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'S':
                                                if ((String.Compare(json_string.getData(), 5, "apporo", 0, 6, false) == 0) && (json_string.getData().Length == 11))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1972Sapporo;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '6':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'I':
                                                if ((String.Compare(json_string.getData(), 5, "nnsbruck", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1976Innsbruck;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'M':
                                                if ((String.Compare(json_string.getData(), 5, "ontreal", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1976Montreal;
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
                            case '8':
                                switch (json_string.getData()[3])
                                  {
                                    case '0':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'L':
                                                if ((String.Compare(json_string.getData(), 5, "akePlacid", 0, 9, false) == 0) && (json_string.getData().Length == 14))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1980LakePlacid;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'M':
                                                if ((String.Compare(json_string.getData(), 5, "oscow", 0, 5, false) == 0) && (json_string.getData().Length == 10))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1980Moscow;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '4':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'L':
                                                if ((String.Compare(json_string.getData(), 5, "osAngeles", 0, 9, false) == 0) && (json_string.getData().Length == 14))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1984LosAngeles;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'S':
                                                if ((String.Compare(json_string.getData(), 5, "arajevo", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1984Sarajevo;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '8':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'C':
                                                if ((String.Compare(json_string.getData(), 5, "algary", 0, 6, false) == 0) && (json_string.getData().Length == 11))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1988Calgary;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'S':
                                                if ((String.Compare(json_string.getData(), 5, "eoul", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1988Seoul;
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
                            case '9':
                                switch (json_string.getData()[3])
                                  {
                                    case '2':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'A':
                                                if ((String.Compare(json_string.getData(), 5, "lbertville", 0, 10, false) == 0) && (json_string.getData().Length == 15))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1992Albertville;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'B':
                                                if ((String.Compare(json_string.getData(), 5, "arcelona", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_1992Barcelona;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '4':
                                        if ((String.Compare(json_string.getData(), 4, "Lillehammer", 0, 11, false) == 0) && (json_string.getData().Length == 15))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_1994Lillehammer;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case '6':
                                        if ((String.Compare(json_string.getData(), 4, "Atlanta", 0, 7, false) == 0) && (json_string.getData().Length == 11))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_1996Atlanta;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case '8':
                                        if ((String.Compare(json_string.getData(), 4, "Nagano", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_1998Nagano;
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
            case '2':
                if (String.Compare(json_string.getData(), 1, "0", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case '0':
                            switch (json_string.getData()[3])
                              {
                                case '0':
                                    if ((String.Compare(json_string.getData(), 4, "Sydney", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_2000Sydney;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case '2':
                                    if ((String.Compare(json_string.getData(), 4, "SaltLakeCity", 0, 12, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_2002SaltLakeCity;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case '4':
                                    if ((String.Compare(json_string.getData(), 4, "Athens", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_2004Athens;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case '6':
                                    if ((String.Compare(json_string.getData(), 4, "Turin", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_2006Turin;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case '8':
                                    if ((String.Compare(json_string.getData(), 4, "Beijing", 0, 7, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_2008Beijing;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case '1':
                            switch (json_string.getData()[3])
                              {
                                case '0':
                                    if ((String.Compare(json_string.getData(), 4, "Vancouver", 0, 9, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_2010Vancouver;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case '2':
                                    if ((String.Compare(json_string.getData(), 4, "London", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_2012London;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case '4':
                                    if ((String.Compare(json_string.getData(), 4, "Sochi", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_2014Sochi;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case '6':
                                    if ((String.Compare(json_string.getData(), 4, "RioDeJaneiro", 0, 12, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_2016RioDeJaneiro;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case '8':
                                    if ((String.Compare(json_string.getData(), 4, "Pyeongchang", 0, 11, false) == 0) && (json_string.getData().Length == 15))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_2018Pyeongchang;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case '2':
                            switch (json_string.getData()[3])
                              {
                                case '0':
                                    if ((String.Compare(json_string.getData(), 4, "Tokyo", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_2020Tokyo;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case '2':
                                    if ((String.Compare(json_string.getData(), 4, "Beijing", 0, 7, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_2022Beijing;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case '4':
                                    if ((String.Compare(json_string.getData(), 4, "Paris", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_2024Paris;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case '6':
                                    if ((String.Compare(json_string.getData(), 4, "MilanCortina", 0, 12, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_2026MilanCortina;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case '8':
                                    if ((String.Compare(json_string.getData(), 4, "LosAngeles", 0, 10, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_2028LosAngeles;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case '3':
                            if ((String.Compare(json_string.getData(), 3, "2Brisbane", 0, 9, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_2032Brisbane;
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
        setValue(the_open_enum);
      }


    public SportsOlympicsGamesCodeJSON()
      {
        flagHasValue = false;
      }

    public SportsOlympicsGamesCodeJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public SportsOlympicsGamesCodeJSON(string init_value)
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

    public SportsOlympicsGamesCodeJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_1896Athens:
                    handler.string_value("1896Athens");
                    break;
                case TypeValueKnownValues.Value_1900Paris:
                    handler.string_value("1900Paris");
                    break;
                case TypeValueKnownValues.Value_1904StLouis:
                    handler.string_value("1904StLouis");
                    break;
                case TypeValueKnownValues.Value_1908London:
                    handler.string_value("1908London");
                    break;
                case TypeValueKnownValues.Value_1912Stockholm:
                    handler.string_value("1912Stockholm");
                    break;
                case TypeValueKnownValues.Value_1920Antwerp:
                    handler.string_value("1920Antwerp");
                    break;
                case TypeValueKnownValues.Value_1924Chamonix:
                    handler.string_value("1924Chamonix");
                    break;
                case TypeValueKnownValues.Value_1924Paris:
                    handler.string_value("1924Paris");
                    break;
                case TypeValueKnownValues.Value_1928StMoritz:
                    handler.string_value("1928StMoritz");
                    break;
                case TypeValueKnownValues.Value_1928Amsterdam:
                    handler.string_value("1928Amsterdam");
                    break;
                case TypeValueKnownValues.Value_1932LakePlacid:
                    handler.string_value("1932LakePlacid");
                    break;
                case TypeValueKnownValues.Value_1932LosAngeles:
                    handler.string_value("1932LosAngeles");
                    break;
                case TypeValueKnownValues.Value_1936GarmischPartenkirchen:
                    handler.string_value("1936GarmischPartenkirchen");
                    break;
                case TypeValueKnownValues.Value_1936Berlin:
                    handler.string_value("1936Berlin");
                    break;
                case TypeValueKnownValues.Value_1948StMoritz:
                    handler.string_value("1948StMoritz");
                    break;
                case TypeValueKnownValues.Value_1948London:
                    handler.string_value("1948London");
                    break;
                case TypeValueKnownValues.Value_1952Oslo:
                    handler.string_value("1952Oslo");
                    break;
                case TypeValueKnownValues.Value_1952Helsinki:
                    handler.string_value("1952Helsinki");
                    break;
                case TypeValueKnownValues.Value_1956CortinaDAmpezzo:
                    handler.string_value("1956CortinaDAmpezzo");
                    break;
                case TypeValueKnownValues.Value_1956Melbourne:
                    handler.string_value("1956Melbourne");
                    break;
                case TypeValueKnownValues.Value_1960SquawValley:
                    handler.string_value("1960SquawValley");
                    break;
                case TypeValueKnownValues.Value_1960Rome:
                    handler.string_value("1960Rome");
                    break;
                case TypeValueKnownValues.Value_1964Innsbruck:
                    handler.string_value("1964Innsbruck");
                    break;
                case TypeValueKnownValues.Value_1964Tokyo:
                    handler.string_value("1964Tokyo");
                    break;
                case TypeValueKnownValues.Value_1968Grenoble:
                    handler.string_value("1968Grenoble");
                    break;
                case TypeValueKnownValues.Value_1968MexicoCity:
                    handler.string_value("1968MexicoCity");
                    break;
                case TypeValueKnownValues.Value_1972Sapporo:
                    handler.string_value("1972Sapporo");
                    break;
                case TypeValueKnownValues.Value_1972Munich:
                    handler.string_value("1972Munich");
                    break;
                case TypeValueKnownValues.Value_1976Innsbruck:
                    handler.string_value("1976Innsbruck");
                    break;
                case TypeValueKnownValues.Value_1976Montreal:
                    handler.string_value("1976Montreal");
                    break;
                case TypeValueKnownValues.Value_1980LakePlacid:
                    handler.string_value("1980LakePlacid");
                    break;
                case TypeValueKnownValues.Value_1980Moscow:
                    handler.string_value("1980Moscow");
                    break;
                case TypeValueKnownValues.Value_1984Sarajevo:
                    handler.string_value("1984Sarajevo");
                    break;
                case TypeValueKnownValues.Value_1984LosAngeles:
                    handler.string_value("1984LosAngeles");
                    break;
                case TypeValueKnownValues.Value_1988Calgary:
                    handler.string_value("1988Calgary");
                    break;
                case TypeValueKnownValues.Value_1988Seoul:
                    handler.string_value("1988Seoul");
                    break;
                case TypeValueKnownValues.Value_1992Albertville:
                    handler.string_value("1992Albertville");
                    break;
                case TypeValueKnownValues.Value_1992Barcelona:
                    handler.string_value("1992Barcelona");
                    break;
                case TypeValueKnownValues.Value_1994Lillehammer:
                    handler.string_value("1994Lillehammer");
                    break;
                case TypeValueKnownValues.Value_1996Atlanta:
                    handler.string_value("1996Atlanta");
                    break;
                case TypeValueKnownValues.Value_1998Nagano:
                    handler.string_value("1998Nagano");
                    break;
                case TypeValueKnownValues.Value_2000Sydney:
                    handler.string_value("2000Sydney");
                    break;
                case TypeValueKnownValues.Value_2002SaltLakeCity:
                    handler.string_value("2002SaltLakeCity");
                    break;
                case TypeValueKnownValues.Value_2004Athens:
                    handler.string_value("2004Athens");
                    break;
                case TypeValueKnownValues.Value_2006Turin:
                    handler.string_value("2006Turin");
                    break;
                case TypeValueKnownValues.Value_2008Beijing:
                    handler.string_value("2008Beijing");
                    break;
                case TypeValueKnownValues.Value_2010Vancouver:
                    handler.string_value("2010Vancouver");
                    break;
                case TypeValueKnownValues.Value_2012London:
                    handler.string_value("2012London");
                    break;
                case TypeValueKnownValues.Value_2014Sochi:
                    handler.string_value("2014Sochi");
                    break;
                case TypeValueKnownValues.Value_2016RioDeJaneiro:
                    handler.string_value("2016RioDeJaneiro");
                    break;
                case TypeValueKnownValues.Value_2018Pyeongchang:
                    handler.string_value("2018Pyeongchang");
                    break;
                case TypeValueKnownValues.Value_2020Tokyo:
                    handler.string_value("2020Tokyo");
                    break;
                case TypeValueKnownValues.Value_2022Beijing:
                    handler.string_value("2022Beijing");
                    break;
                case TypeValueKnownValues.Value_2024Paris:
                    handler.string_value("2024Paris");
                    break;
                case TypeValueKnownValues.Value_2026MilanCortina:
                    handler.string_value("2026MilanCortina");
                    break;
                case TypeValueKnownValues.Value_2028LosAngeles:
                    handler.string_value("2028LosAngeles");
                    break;
                case TypeValueKnownValues.Value_2032Brisbane:
                    handler.string_value("2032Brisbane");
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
                case TypeValueKnownValues.Value_1896Athens:
                    handler.string_value("1896Athens");
                    break;
                case TypeValueKnownValues.Value_1900Paris:
                    handler.string_value("1900Paris");
                    break;
                case TypeValueKnownValues.Value_1904StLouis:
                    handler.string_value("1904StLouis");
                    break;
                case TypeValueKnownValues.Value_1908London:
                    handler.string_value("1908London");
                    break;
                case TypeValueKnownValues.Value_1912Stockholm:
                    handler.string_value("1912Stockholm");
                    break;
                case TypeValueKnownValues.Value_1920Antwerp:
                    handler.string_value("1920Antwerp");
                    break;
                case TypeValueKnownValues.Value_1924Chamonix:
                    handler.string_value("1924Chamonix");
                    break;
                case TypeValueKnownValues.Value_1924Paris:
                    handler.string_value("1924Paris");
                    break;
                case TypeValueKnownValues.Value_1928StMoritz:
                    handler.string_value("1928StMoritz");
                    break;
                case TypeValueKnownValues.Value_1928Amsterdam:
                    handler.string_value("1928Amsterdam");
                    break;
                case TypeValueKnownValues.Value_1932LakePlacid:
                    handler.string_value("1932LakePlacid");
                    break;
                case TypeValueKnownValues.Value_1932LosAngeles:
                    handler.string_value("1932LosAngeles");
                    break;
                case TypeValueKnownValues.Value_1936GarmischPartenkirchen:
                    handler.string_value("1936GarmischPartenkirchen");
                    break;
                case TypeValueKnownValues.Value_1936Berlin:
                    handler.string_value("1936Berlin");
                    break;
                case TypeValueKnownValues.Value_1948StMoritz:
                    handler.string_value("1948StMoritz");
                    break;
                case TypeValueKnownValues.Value_1948London:
                    handler.string_value("1948London");
                    break;
                case TypeValueKnownValues.Value_1952Oslo:
                    handler.string_value("1952Oslo");
                    break;
                case TypeValueKnownValues.Value_1952Helsinki:
                    handler.string_value("1952Helsinki");
                    break;
                case TypeValueKnownValues.Value_1956CortinaDAmpezzo:
                    handler.string_value("1956CortinaDAmpezzo");
                    break;
                case TypeValueKnownValues.Value_1956Melbourne:
                    handler.string_value("1956Melbourne");
                    break;
                case TypeValueKnownValues.Value_1960SquawValley:
                    handler.string_value("1960SquawValley");
                    break;
                case TypeValueKnownValues.Value_1960Rome:
                    handler.string_value("1960Rome");
                    break;
                case TypeValueKnownValues.Value_1964Innsbruck:
                    handler.string_value("1964Innsbruck");
                    break;
                case TypeValueKnownValues.Value_1964Tokyo:
                    handler.string_value("1964Tokyo");
                    break;
                case TypeValueKnownValues.Value_1968Grenoble:
                    handler.string_value("1968Grenoble");
                    break;
                case TypeValueKnownValues.Value_1968MexicoCity:
                    handler.string_value("1968MexicoCity");
                    break;
                case TypeValueKnownValues.Value_1972Sapporo:
                    handler.string_value("1972Sapporo");
                    break;
                case TypeValueKnownValues.Value_1972Munich:
                    handler.string_value("1972Munich");
                    break;
                case TypeValueKnownValues.Value_1976Innsbruck:
                    handler.string_value("1976Innsbruck");
                    break;
                case TypeValueKnownValues.Value_1976Montreal:
                    handler.string_value("1976Montreal");
                    break;
                case TypeValueKnownValues.Value_1980LakePlacid:
                    handler.string_value("1980LakePlacid");
                    break;
                case TypeValueKnownValues.Value_1980Moscow:
                    handler.string_value("1980Moscow");
                    break;
                case TypeValueKnownValues.Value_1984Sarajevo:
                    handler.string_value("1984Sarajevo");
                    break;
                case TypeValueKnownValues.Value_1984LosAngeles:
                    handler.string_value("1984LosAngeles");
                    break;
                case TypeValueKnownValues.Value_1988Calgary:
                    handler.string_value("1988Calgary");
                    break;
                case TypeValueKnownValues.Value_1988Seoul:
                    handler.string_value("1988Seoul");
                    break;
                case TypeValueKnownValues.Value_1992Albertville:
                    handler.string_value("1992Albertville");
                    break;
                case TypeValueKnownValues.Value_1992Barcelona:
                    handler.string_value("1992Barcelona");
                    break;
                case TypeValueKnownValues.Value_1994Lillehammer:
                    handler.string_value("1994Lillehammer");
                    break;
                case TypeValueKnownValues.Value_1996Atlanta:
                    handler.string_value("1996Atlanta");
                    break;
                case TypeValueKnownValues.Value_1998Nagano:
                    handler.string_value("1998Nagano");
                    break;
                case TypeValueKnownValues.Value_2000Sydney:
                    handler.string_value("2000Sydney");
                    break;
                case TypeValueKnownValues.Value_2002SaltLakeCity:
                    handler.string_value("2002SaltLakeCity");
                    break;
                case TypeValueKnownValues.Value_2004Athens:
                    handler.string_value("2004Athens");
                    break;
                case TypeValueKnownValues.Value_2006Turin:
                    handler.string_value("2006Turin");
                    break;
                case TypeValueKnownValues.Value_2008Beijing:
                    handler.string_value("2008Beijing");
                    break;
                case TypeValueKnownValues.Value_2010Vancouver:
                    handler.string_value("2010Vancouver");
                    break;
                case TypeValueKnownValues.Value_2012London:
                    handler.string_value("2012London");
                    break;
                case TypeValueKnownValues.Value_2014Sochi:
                    handler.string_value("2014Sochi");
                    break;
                case TypeValueKnownValues.Value_2016RioDeJaneiro:
                    handler.string_value("2016RioDeJaneiro");
                    break;
                case TypeValueKnownValues.Value_2018Pyeongchang:
                    handler.string_value("2018Pyeongchang");
                    break;
                case TypeValueKnownValues.Value_2020Tokyo:
                    handler.string_value("2020Tokyo");
                    break;
                case TypeValueKnownValues.Value_2022Beijing:
                    handler.string_value("2022Beijing");
                    break;
                case TypeValueKnownValues.Value_2024Paris:
                    handler.string_value("2024Paris");
                    break;
                case TypeValueKnownValues.Value_2026MilanCortina:
                    handler.string_value("2026MilanCortina");
                    break;
                case TypeValueKnownValues.Value_2028LosAngeles:
                    handler.string_value("2028LosAngeles");
                    break;
                case TypeValueKnownValues.Value_2032Brisbane:
                    handler.string_value("2032Brisbane");
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

    public static SportsOlympicsGamesCodeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsGamesCodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsGamesCode", ignore_extras);
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
    public static SportsOlympicsGamesCodeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsGamesCodeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsGamesCodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsGamesCode", ignore_extras);
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
    public static SportsOlympicsGamesCodeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsGamesCodeJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsGamesCodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsGamesCode", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsGamesCodeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsGamesCodeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsGamesCodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsGamesCode", ignore_extras);
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
            SportsOlympicsGamesCodeJSON result = new SportsOlympicsGamesCodeJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(SportsOlympicsGamesCodeJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsOlympicsGamesCode")
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
        protected override void handle_result(SportsOlympicsGamesCodeJSON  result)
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
        public SportsOlympicsGamesCodeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsGamesCodeJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsGamesCodeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsGamesCodeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsGamesCodeJSON>();
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
    public List<SportsOlympicsGamesCodeJSON> value;
  };
  };
