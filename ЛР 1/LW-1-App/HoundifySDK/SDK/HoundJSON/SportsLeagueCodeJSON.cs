/* file "SportsLeagueCodeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsLeagueCodeJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_MLB,
        Value_NBA,
        Value_NFL,
        Value_NHL,
        Value_NCAAMB,
        Value_NCAAFB,
        Value_MLS,
        Value_CFL,
        Value_SoccerUEFAChampionsLeague,
        Value_SoccerPrimeraDivision,
        Value_SoccerPremierLeague,
        Value_SoccerSerieA,
        Value_SoccerLigue1,
        Value_SoccerBundesliga,
        Value_SoccerEredivisie,
        Value_SoccerFirstDivisionA,
        Value_SoccerSuperLig,
        Value_SoccerSuperLeague,
        Value_SoccerPremierLeagueRUS,
        Value_SoccerPremierLeagueUKR,
        Value_SoccerPrimeiraLiga,
        Value_SoccerUEFASuperCup,
        Value_SoccerEuropaLeague,
        Value_SoccerYouthLeague,
        Value_CricketICC,
        Value_CricketIPL,
        Value_SoccerPrimeraDivisionARG,
        Value_SoccerPrimeraDivisionMEX,
        Value_SoccerBrasileiroSerieA,
        Value_SoccerInternational,
        Value_SoccerChineseSuperLeague,
        Value_SoccerILeague,
        Value_SoccerIndianSuperLeague,
        Value_SoccerJLeague,
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
            case 'C':
                switch (chars[1])
                  {
                    case 'F':
                        if ((String.Compare(chars, 2, "L", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeValueKnownValues.Value_CFL;
                        break;
                    case 'r':
                        if (String.Compare(chars, 2, "icketI", 0, 6, false) == 0)
                          {
                            switch (chars[8])
                              {
                                case 'C':
                                    if ((String.Compare(chars, 9, "C", 0, 1, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_CricketICC;
                                    break;
                                case 'P':
                                    if ((String.Compare(chars, 9, "L", 0, 1, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_CricketIPL;
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
            case 'M':
                if (String.Compare(chars, 1, "L", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'B':
                            if (chars.Length == 3)
                                return TypeValueKnownValues.Value_MLB;
                            break;
                        case 'S':
                            if (chars.Length == 3)
                                return TypeValueKnownValues.Value_MLS;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                switch (chars[1])
                  {
                    case 'B':
                        if ((String.Compare(chars, 2, "A", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeValueKnownValues.Value_NBA;
                        break;
                    case 'C':
                        if (String.Compare(chars, 2, "AA", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 5, "B", 0, 1, false) == 0) && (chars.Length == 6))
                                        return TypeValueKnownValues.Value_NCAAFB;
                                    break;
                                case 'M':
                                    if ((String.Compare(chars, 5, "B", 0, 1, false) == 0) && (chars.Length == 6))
                                        return TypeValueKnownValues.Value_NCAAMB;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'F':
                        if ((String.Compare(chars, 2, "L", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeValueKnownValues.Value_NFL;
                        break;
                    case 'H':
                        if ((String.Compare(chars, 2, "L", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeValueKnownValues.Value_NHL;
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if (String.Compare(chars, 1, "occer", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'B':
                            switch (chars[7])
                              {
                                case 'r':
                                    if ((String.Compare(chars, 8, "asileiroSerieA", 0, 14, false) == 0) && (chars.Length == 22))
                                        return TypeValueKnownValues.Value_SoccerBrasileiroSerieA;
                                    break;
                                case 'u':
                                    if ((String.Compare(chars, 8, "ndesliga", 0, 8, false) == 0) && (chars.Length == 16))
                                        return TypeValueKnownValues.Value_SoccerBundesliga;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'C':
                            if ((String.Compare(chars, 7, "hineseSuperLeague", 0, 17, false) == 0) && (chars.Length == 24))
                                return TypeValueKnownValues.Value_SoccerChineseSuperLeague;
                            break;
                        case 'E':
                            switch (chars[7])
                              {
                                case 'r':
                                    if ((String.Compare(chars, 8, "edivisie", 0, 8, false) == 0) && (chars.Length == 16))
                                        return TypeValueKnownValues.Value_SoccerEredivisie;
                                    break;
                                case 'u':
                                    if ((String.Compare(chars, 8, "ropaLeague", 0, 10, false) == 0) && (chars.Length == 18))
                                        return TypeValueKnownValues.Value_SoccerEuropaLeague;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'F':
                            if ((String.Compare(chars, 7, "irstDivisionA", 0, 13, false) == 0) && (chars.Length == 20))
                                return TypeValueKnownValues.Value_SoccerFirstDivisionA;
                            break;
                        case 'I':
                            switch (chars[7])
                              {
                                case 'L':
                                    if ((String.Compare(chars, 8, "eague", 0, 5, false) == 0) && (chars.Length == 13))
                                        return TypeValueKnownValues.Value_SoccerILeague;
                                    break;
                                case 'n':
                                    switch (chars[8])
                                      {
                                        case 'd':
                                            if ((String.Compare(chars, 9, "ianSuperLeague", 0, 14, false) == 0) && (chars.Length == 23))
                                                return TypeValueKnownValues.Value_SoccerIndianSuperLeague;
                                            break;
                                        case 't':
                                            if ((String.Compare(chars, 9, "ernational", 0, 10, false) == 0) && (chars.Length == 19))
                                                return TypeValueKnownValues.Value_SoccerInternational;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'J':
                            if ((String.Compare(chars, 7, "League", 0, 6, false) == 0) && (chars.Length == 13))
                                return TypeValueKnownValues.Value_SoccerJLeague;
                            break;
                        case 'L':
                            if ((String.Compare(chars, 7, "igue1", 0, 5, false) == 0) && (chars.Length == 12))
                                return TypeValueKnownValues.Value_SoccerLigue1;
                            break;
                        case 'P':
                            if (String.Compare(chars, 7, "r", 0, 1, false) == 0)
                              {
                                switch (chars[8])
                                  {
                                    case 'e':
                                        if (String.Compare(chars, 9, "mierLeague", 0, 10, false) == 0)
                                          {
                                            if (chars.Length == 19)
                                              {
                                                return TypeValueKnownValues.Value_SoccerPremierLeague;
                                              }
                                            switch (chars[19])
                                              {
                                                case 'R':
                                                    if ((String.Compare(chars, 20, "US", 0, 2, false) == 0) && (chars.Length == 22))
                                                        return TypeValueKnownValues.Value_SoccerPremierLeagueRUS;
                                                    break;
                                                case 'U':
                                                    if ((String.Compare(chars, 20, "KR", 0, 2, false) == 0) && (chars.Length == 22))
                                                        return TypeValueKnownValues.Value_SoccerPremierLeagueUKR;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'i':
                                        if (String.Compare(chars, 9, "me", 0, 2, false) == 0)
                                          {
                                            switch (chars[11])
                                              {
                                                case 'i':
                                                    if ((String.Compare(chars, 12, "raLiga", 0, 6, false) == 0) && (chars.Length == 18))
                                                        return TypeValueKnownValues.Value_SoccerPrimeiraLiga;
                                                    break;
                                                case 'r':
                                                    if (String.Compare(chars, 12, "aDivision", 0, 9, false) == 0)
                                                      {
                                                        if (chars.Length == 21)
                                                          {
                                                            return TypeValueKnownValues.Value_SoccerPrimeraDivision;
                                                          }
                                                        switch (chars[21])
                                                          {
                                                            case 'A':
                                                                if ((String.Compare(chars, 22, "RG", 0, 2, false) == 0) && (chars.Length == 24))
                                                                    return TypeValueKnownValues.Value_SoccerPrimeraDivisionARG;
                                                                break;
                                                            case 'M':
                                                                if ((String.Compare(chars, 22, "EX", 0, 2, false) == 0) && (chars.Length == 24))
                                                                    return TypeValueKnownValues.Value_SoccerPrimeraDivisionMEX;
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
                        case 'S':
                            switch (chars[7])
                              {
                                case 'e':
                                    if ((String.Compare(chars, 8, "rieA", 0, 4, false) == 0) && (chars.Length == 12))
                                        return TypeValueKnownValues.Value_SoccerSerieA;
                                    break;
                                case 'u':
                                    if (String.Compare(chars, 8, "perL", 0, 4, false) == 0)
                                      {
                                        switch (chars[12])
                                          {
                                            case 'e':
                                                if ((String.Compare(chars, 13, "ague", 0, 4, false) == 0) && (chars.Length == 17))
                                                    return TypeValueKnownValues.Value_SoccerSuperLeague;
                                                break;
                                            case 'i':
                                                if ((String.Compare(chars, 13, "g", 0, 1, false) == 0) && (chars.Length == 14))
                                                    return TypeValueKnownValues.Value_SoccerSuperLig;
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
                        case 'U':
                            if (String.Compare(chars, 7, "EFA", 0, 3, false) == 0)
                              {
                                switch (chars[10])
                                  {
                                    case 'C':
                                        if ((String.Compare(chars, 11, "hampionsLeague", 0, 14, false) == 0) && (chars.Length == 25))
                                            return TypeValueKnownValues.Value_SoccerUEFAChampionsLeague;
                                        break;
                                    case 'S':
                                        if ((String.Compare(chars, 11, "uperCup", 0, 7, false) == 0) && (chars.Length == 18))
                                            return TypeValueKnownValues.Value_SoccerUEFASuperCup;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'Y':
                            if ((String.Compare(chars, 7, "outhLeague", 0, 10, false) == 0) && (chars.Length == 17))
                                return TypeValueKnownValues.Value_SoccerYouthLeague;
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
            case TypeValueKnownValues.Value_MLB:
                return "MLB";
            case TypeValueKnownValues.Value_NBA:
                return "NBA";
            case TypeValueKnownValues.Value_NFL:
                return "NFL";
            case TypeValueKnownValues.Value_NHL:
                return "NHL";
            case TypeValueKnownValues.Value_NCAAMB:
                return "NCAAMB";
            case TypeValueKnownValues.Value_NCAAFB:
                return "NCAAFB";
            case TypeValueKnownValues.Value_MLS:
                return "MLS";
            case TypeValueKnownValues.Value_CFL:
                return "CFL";
            case TypeValueKnownValues.Value_SoccerUEFAChampionsLeague:
                return "SoccerUEFAChampionsLeague";
            case TypeValueKnownValues.Value_SoccerPrimeraDivision:
                return "SoccerPrimeraDivision";
            case TypeValueKnownValues.Value_SoccerPremierLeague:
                return "SoccerPremierLeague";
            case TypeValueKnownValues.Value_SoccerSerieA:
                return "SoccerSerieA";
            case TypeValueKnownValues.Value_SoccerLigue1:
                return "SoccerLigue1";
            case TypeValueKnownValues.Value_SoccerBundesliga:
                return "SoccerBundesliga";
            case TypeValueKnownValues.Value_SoccerEredivisie:
                return "SoccerEredivisie";
            case TypeValueKnownValues.Value_SoccerFirstDivisionA:
                return "SoccerFirstDivisionA";
            case TypeValueKnownValues.Value_SoccerSuperLig:
                return "SoccerSuperLig";
            case TypeValueKnownValues.Value_SoccerSuperLeague:
                return "SoccerSuperLeague";
            case TypeValueKnownValues.Value_SoccerPremierLeagueRUS:
                return "SoccerPremierLeagueRUS";
            case TypeValueKnownValues.Value_SoccerPremierLeagueUKR:
                return "SoccerPremierLeagueUKR";
            case TypeValueKnownValues.Value_SoccerPrimeiraLiga:
                return "SoccerPrimeiraLiga";
            case TypeValueKnownValues.Value_SoccerUEFASuperCup:
                return "SoccerUEFASuperCup";
            case TypeValueKnownValues.Value_SoccerEuropaLeague:
                return "SoccerEuropaLeague";
            case TypeValueKnownValues.Value_SoccerYouthLeague:
                return "SoccerYouthLeague";
            case TypeValueKnownValues.Value_CricketICC:
                return "CricketICC";
            case TypeValueKnownValues.Value_CricketIPL:
                return "CricketIPL";
            case TypeValueKnownValues.Value_SoccerPrimeraDivisionARG:
                return "SoccerPrimeraDivisionARG";
            case TypeValueKnownValues.Value_SoccerPrimeraDivisionMEX:
                return "SoccerPrimeraDivisionMEX";
            case TypeValueKnownValues.Value_SoccerBrasileiroSerieA:
                return "SoccerBrasileiroSerieA";
            case TypeValueKnownValues.Value_SoccerInternational:
                return "SoccerInternational";
            case TypeValueKnownValues.Value_SoccerChineseSuperLeague:
                return "SoccerChineseSuperLeague";
            case TypeValueKnownValues.Value_SoccerILeague:
                return "SoccerILeague";
            case TypeValueKnownValues.Value_SoccerIndianSuperLeague:
                return "SoccerIndianSuperLeague";
            case TypeValueKnownValues.Value_SoccerJLeague:
                return "SoccerJLeague";
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
            throw new Exception("The value for field Value of SportsLeagueCodeJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'F':
                        if ((String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_CFL;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if (String.Compare(json_string.getData(), 2, "icketI", 0, 6, false) == 0)
                          {
                            switch (json_string.getData()[8])
                              {
                                case 'C':
                                    if ((String.Compare(json_string.getData(), 9, "C", 0, 1, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_CricketICC;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'P':
                                    if ((String.Compare(json_string.getData(), 9, "L", 0, 1, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_CricketIPL;
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
            case 'M':
                if (String.Compare(json_string.getData(), 1, "L", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'B':
                            if (json_string.getData().Length == 3)
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_MLB;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'S':
                            if (json_string.getData().Length == 3)
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_MLS;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                switch (json_string.getData()[1])
                  {
                    case 'B':
                        if ((String.Compare(json_string.getData(), 2, "A", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_NBA;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'C':
                        if (String.Compare(json_string.getData(), 2, "AA", 0, 2, false) == 0)
                          {
                            switch (json_string.getData()[4])
                              {
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 5, "B", 0, 1, false) == 0) && (json_string.getData().Length == 6))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFB;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'M':
                                    if ((String.Compare(json_string.getData(), 5, "B", 0, 1, false) == 0) && (json_string.getData().Length == 6))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMB;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'F':
                        if ((String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_NFL;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'H':
                        if ((String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_NHL;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if (String.Compare(json_string.getData(), 1, "occer", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'B':
                            switch (json_string.getData()[7])
                              {
                                case 'r':
                                    if ((String.Compare(json_string.getData(), 8, "asileiroSerieA", 0, 14, false) == 0) && (json_string.getData().Length == 22))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_SoccerBrasileiroSerieA;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'u':
                                    if ((String.Compare(json_string.getData(), 8, "ndesliga", 0, 8, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_SoccerBundesliga;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'C':
                            if ((String.Compare(json_string.getData(), 7, "hineseSuperLeague", 0, 17, false) == 0) && (json_string.getData().Length == 24))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerChineseSuperLeague;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'E':
                            switch (json_string.getData()[7])
                              {
                                case 'r':
                                    if ((String.Compare(json_string.getData(), 8, "edivisie", 0, 8, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_SoccerEredivisie;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'u':
                                    if ((String.Compare(json_string.getData(), 8, "ropaLeague", 0, 10, false) == 0) && (json_string.getData().Length == 18))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_SoccerEuropaLeague;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'F':
                            if ((String.Compare(json_string.getData(), 7, "irstDivisionA", 0, 13, false) == 0) && (json_string.getData().Length == 20))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerFirstDivisionA;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'I':
                            switch (json_string.getData()[7])
                              {
                                case 'L':
                                    if ((String.Compare(json_string.getData(), 8, "eague", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_SoccerILeague;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'n':
                                    switch (json_string.getData()[8])
                                      {
                                        case 'd':
                                            if ((String.Compare(json_string.getData(), 9, "ianSuperLeague", 0, 14, false) == 0) && (json_string.getData().Length == 23))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerIndianSuperLeague;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 't':
                                            if ((String.Compare(json_string.getData(), 9, "ernational", 0, 10, false) == 0) && (json_string.getData().Length == 19))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternational;
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
                        case 'J':
                            if ((String.Compare(json_string.getData(), 7, "League", 0, 6, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerJLeague;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'L':
                            if ((String.Compare(json_string.getData(), 7, "igue1", 0, 5, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerLigue1;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'P':
                            if (String.Compare(json_string.getData(), 7, "r", 0, 1, false) == 0)
                              {
                                switch (json_string.getData()[8])
                                  {
                                    case 'e':
                                        if (String.Compare(json_string.getData(), 9, "mierLeague", 0, 10, false) == 0)
                                          {
                                            if (json_string.getData().Length == 19)
                                              {
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerPremierLeague;
                                                    goto open_enum_is_done;
                                                  }
                                              }
                                            switch (json_string.getData()[19])
                                              {
                                                case 'R':
                                                    if ((String.Compare(json_string.getData(), 20, "US", 0, 2, false) == 0) && (json_string.getData().Length == 22))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_SoccerPremierLeagueRUS;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'U':
                                                    if ((String.Compare(json_string.getData(), 20, "KR", 0, 2, false) == 0) && (json_string.getData().Length == 22))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_SoccerPremierLeagueUKR;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'i':
                                        if (String.Compare(json_string.getData(), 9, "me", 0, 2, false) == 0)
                                          {
                                            switch (json_string.getData()[11])
                                              {
                                                case 'i':
                                                    if ((String.Compare(json_string.getData(), 12, "raLiga", 0, 6, false) == 0) && (json_string.getData().Length == 18))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_SoccerPrimeiraLiga;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'r':
                                                    if (String.Compare(json_string.getData(), 12, "aDivision", 0, 9, false) == 0)
                                                      {
                                                        if (json_string.getData().Length == 21)
                                                          {
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerPrimeraDivision;
                                                                goto open_enum_is_done;
                                                              }
                                                          }
                                                        switch (json_string.getData()[21])
                                                          {
                                                            case 'A':
                                                                if ((String.Compare(json_string.getData(), 22, "RG", 0, 2, false) == 0) && (json_string.getData().Length == 24))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_SoccerPrimeraDivisionARG;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'M':
                                                                if ((String.Compare(json_string.getData(), 22, "EX", 0, 2, false) == 0) && (json_string.getData().Length == 24))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_SoccerPrimeraDivisionMEX;
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
                        case 'S':
                            switch (json_string.getData()[7])
                              {
                                case 'e':
                                    if ((String.Compare(json_string.getData(), 8, "rieA", 0, 4, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_SoccerSerieA;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'u':
                                    if (String.Compare(json_string.getData(), 8, "perL", 0, 4, false) == 0)
                                      {
                                        switch (json_string.getData()[12])
                                          {
                                            case 'e':
                                                if ((String.Compare(json_string.getData(), 13, "ague", 0, 4, false) == 0) && (json_string.getData().Length == 17))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_SoccerSuperLeague;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'i':
                                                if ((String.Compare(json_string.getData(), 13, "g", 0, 1, false) == 0) && (json_string.getData().Length == 14))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_SoccerSuperLig;
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
                        case 'U':
                            if (String.Compare(json_string.getData(), 7, "EFA", 0, 3, false) == 0)
                              {
                                switch (json_string.getData()[10])
                                  {
                                    case 'C':
                                        if ((String.Compare(json_string.getData(), 11, "hampionsLeague", 0, 14, false) == 0) && (json_string.getData().Length == 25))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerUEFAChampionsLeague;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'S':
                                        if ((String.Compare(json_string.getData(), 11, "uperCup", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerUEFASuperCup;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'Y':
                            if ((String.Compare(json_string.getData(), 7, "outhLeague", 0, 10, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerYouthLeague;
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


    public SportsLeagueCodeJSON()
      {
        flagHasValue = false;
      }

    public SportsLeagueCodeJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public SportsLeagueCodeJSON(string init_value)
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

    public SportsLeagueCodeJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_MLB:
                    handler.string_value("MLB");
                    break;
                case TypeValueKnownValues.Value_NBA:
                    handler.string_value("NBA");
                    break;
                case TypeValueKnownValues.Value_NFL:
                    handler.string_value("NFL");
                    break;
                case TypeValueKnownValues.Value_NHL:
                    handler.string_value("NHL");
                    break;
                case TypeValueKnownValues.Value_NCAAMB:
                    handler.string_value("NCAAMB");
                    break;
                case TypeValueKnownValues.Value_NCAAFB:
                    handler.string_value("NCAAFB");
                    break;
                case TypeValueKnownValues.Value_MLS:
                    handler.string_value("MLS");
                    break;
                case TypeValueKnownValues.Value_CFL:
                    handler.string_value("CFL");
                    break;
                case TypeValueKnownValues.Value_SoccerUEFAChampionsLeague:
                    handler.string_value("SoccerUEFAChampionsLeague");
                    break;
                case TypeValueKnownValues.Value_SoccerPrimeraDivision:
                    handler.string_value("SoccerPrimeraDivision");
                    break;
                case TypeValueKnownValues.Value_SoccerPremierLeague:
                    handler.string_value("SoccerPremierLeague");
                    break;
                case TypeValueKnownValues.Value_SoccerSerieA:
                    handler.string_value("SoccerSerieA");
                    break;
                case TypeValueKnownValues.Value_SoccerLigue1:
                    handler.string_value("SoccerLigue1");
                    break;
                case TypeValueKnownValues.Value_SoccerBundesliga:
                    handler.string_value("SoccerBundesliga");
                    break;
                case TypeValueKnownValues.Value_SoccerEredivisie:
                    handler.string_value("SoccerEredivisie");
                    break;
                case TypeValueKnownValues.Value_SoccerFirstDivisionA:
                    handler.string_value("SoccerFirstDivisionA");
                    break;
                case TypeValueKnownValues.Value_SoccerSuperLig:
                    handler.string_value("SoccerSuperLig");
                    break;
                case TypeValueKnownValues.Value_SoccerSuperLeague:
                    handler.string_value("SoccerSuperLeague");
                    break;
                case TypeValueKnownValues.Value_SoccerPremierLeagueRUS:
                    handler.string_value("SoccerPremierLeagueRUS");
                    break;
                case TypeValueKnownValues.Value_SoccerPremierLeagueUKR:
                    handler.string_value("SoccerPremierLeagueUKR");
                    break;
                case TypeValueKnownValues.Value_SoccerPrimeiraLiga:
                    handler.string_value("SoccerPrimeiraLiga");
                    break;
                case TypeValueKnownValues.Value_SoccerUEFASuperCup:
                    handler.string_value("SoccerUEFASuperCup");
                    break;
                case TypeValueKnownValues.Value_SoccerEuropaLeague:
                    handler.string_value("SoccerEuropaLeague");
                    break;
                case TypeValueKnownValues.Value_SoccerYouthLeague:
                    handler.string_value("SoccerYouthLeague");
                    break;
                case TypeValueKnownValues.Value_CricketICC:
                    handler.string_value("CricketICC");
                    break;
                case TypeValueKnownValues.Value_CricketIPL:
                    handler.string_value("CricketIPL");
                    break;
                case TypeValueKnownValues.Value_SoccerPrimeraDivisionARG:
                    handler.string_value("SoccerPrimeraDivisionARG");
                    break;
                case TypeValueKnownValues.Value_SoccerPrimeraDivisionMEX:
                    handler.string_value("SoccerPrimeraDivisionMEX");
                    break;
                case TypeValueKnownValues.Value_SoccerBrasileiroSerieA:
                    handler.string_value("SoccerBrasileiroSerieA");
                    break;
                case TypeValueKnownValues.Value_SoccerInternational:
                    handler.string_value("SoccerInternational");
                    break;
                case TypeValueKnownValues.Value_SoccerChineseSuperLeague:
                    handler.string_value("SoccerChineseSuperLeague");
                    break;
                case TypeValueKnownValues.Value_SoccerILeague:
                    handler.string_value("SoccerILeague");
                    break;
                case TypeValueKnownValues.Value_SoccerIndianSuperLeague:
                    handler.string_value("SoccerIndianSuperLeague");
                    break;
                case TypeValueKnownValues.Value_SoccerJLeague:
                    handler.string_value("SoccerJLeague");
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
                case TypeValueKnownValues.Value_MLB:
                    handler.string_value("MLB");
                    break;
                case TypeValueKnownValues.Value_NBA:
                    handler.string_value("NBA");
                    break;
                case TypeValueKnownValues.Value_NFL:
                    handler.string_value("NFL");
                    break;
                case TypeValueKnownValues.Value_NHL:
                    handler.string_value("NHL");
                    break;
                case TypeValueKnownValues.Value_NCAAMB:
                    handler.string_value("NCAAMB");
                    break;
                case TypeValueKnownValues.Value_NCAAFB:
                    handler.string_value("NCAAFB");
                    break;
                case TypeValueKnownValues.Value_MLS:
                    handler.string_value("MLS");
                    break;
                case TypeValueKnownValues.Value_CFL:
                    handler.string_value("CFL");
                    break;
                case TypeValueKnownValues.Value_SoccerUEFAChampionsLeague:
                    handler.string_value("SoccerUEFAChampionsLeague");
                    break;
                case TypeValueKnownValues.Value_SoccerPrimeraDivision:
                    handler.string_value("SoccerPrimeraDivision");
                    break;
                case TypeValueKnownValues.Value_SoccerPremierLeague:
                    handler.string_value("SoccerPremierLeague");
                    break;
                case TypeValueKnownValues.Value_SoccerSerieA:
                    handler.string_value("SoccerSerieA");
                    break;
                case TypeValueKnownValues.Value_SoccerLigue1:
                    handler.string_value("SoccerLigue1");
                    break;
                case TypeValueKnownValues.Value_SoccerBundesliga:
                    handler.string_value("SoccerBundesliga");
                    break;
                case TypeValueKnownValues.Value_SoccerEredivisie:
                    handler.string_value("SoccerEredivisie");
                    break;
                case TypeValueKnownValues.Value_SoccerFirstDivisionA:
                    handler.string_value("SoccerFirstDivisionA");
                    break;
                case TypeValueKnownValues.Value_SoccerSuperLig:
                    handler.string_value("SoccerSuperLig");
                    break;
                case TypeValueKnownValues.Value_SoccerSuperLeague:
                    handler.string_value("SoccerSuperLeague");
                    break;
                case TypeValueKnownValues.Value_SoccerPremierLeagueRUS:
                    handler.string_value("SoccerPremierLeagueRUS");
                    break;
                case TypeValueKnownValues.Value_SoccerPremierLeagueUKR:
                    handler.string_value("SoccerPremierLeagueUKR");
                    break;
                case TypeValueKnownValues.Value_SoccerPrimeiraLiga:
                    handler.string_value("SoccerPrimeiraLiga");
                    break;
                case TypeValueKnownValues.Value_SoccerUEFASuperCup:
                    handler.string_value("SoccerUEFASuperCup");
                    break;
                case TypeValueKnownValues.Value_SoccerEuropaLeague:
                    handler.string_value("SoccerEuropaLeague");
                    break;
                case TypeValueKnownValues.Value_SoccerYouthLeague:
                    handler.string_value("SoccerYouthLeague");
                    break;
                case TypeValueKnownValues.Value_CricketICC:
                    handler.string_value("CricketICC");
                    break;
                case TypeValueKnownValues.Value_CricketIPL:
                    handler.string_value("CricketIPL");
                    break;
                case TypeValueKnownValues.Value_SoccerPrimeraDivisionARG:
                    handler.string_value("SoccerPrimeraDivisionARG");
                    break;
                case TypeValueKnownValues.Value_SoccerPrimeraDivisionMEX:
                    handler.string_value("SoccerPrimeraDivisionMEX");
                    break;
                case TypeValueKnownValues.Value_SoccerBrasileiroSerieA:
                    handler.string_value("SoccerBrasileiroSerieA");
                    break;
                case TypeValueKnownValues.Value_SoccerInternational:
                    handler.string_value("SoccerInternational");
                    break;
                case TypeValueKnownValues.Value_SoccerChineseSuperLeague:
                    handler.string_value("SoccerChineseSuperLeague");
                    break;
                case TypeValueKnownValues.Value_SoccerILeague:
                    handler.string_value("SoccerILeague");
                    break;
                case TypeValueKnownValues.Value_SoccerIndianSuperLeague:
                    handler.string_value("SoccerIndianSuperLeague");
                    break;
                case TypeValueKnownValues.Value_SoccerJLeague:
                    handler.string_value("SoccerJLeague");
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

    public static SportsLeagueCodeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsLeagueCodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueCode", ignore_extras);
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
    public static SportsLeagueCodeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsLeagueCodeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsLeagueCodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueCode", ignore_extras);
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
    public static SportsLeagueCodeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsLeagueCodeJSON from_text(string text, bool ignore_extras)
      {
        SportsLeagueCodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueCode", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsLeagueCodeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsLeagueCodeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsLeagueCodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueCode", ignore_extras);
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
            SportsLeagueCodeJSON result = new SportsLeagueCodeJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(SportsLeagueCodeJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsLeagueCode")
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
        protected override void handle_result(SportsLeagueCodeJSON  result)
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
        public SportsLeagueCodeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsLeagueCodeJSON  result)
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
    protected virtual void handle_result(List<SportsLeagueCodeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsLeagueCodeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsLeagueCodeJSON>();
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
    public List<SportsLeagueCodeJSON> value;
  };
  };
