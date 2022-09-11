/* file "SportsLeagueJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsLeagueJSON : JSONBase
  {
    public enum TypeLeagueCodeKnownValues
      {
        LeagueCode_MLB,
        LeagueCode_NBA,
        LeagueCode_NFL,
        LeagueCode_NHL,
        LeagueCode_NCAAMB,
        LeagueCode_NCAAFB,
        LeagueCode_MLS,
        LeagueCode_CFL,
        LeagueCode_SoccerUEFAChampionsLeague,
        LeagueCode_SoccerPrimeraDivision,
        LeagueCode_SoccerPremierLeague,
        LeagueCode_SoccerSerieA,
        LeagueCode_SoccerLigue1,
        LeagueCode_SoccerBundesliga,
        LeagueCode_SoccerEredivisie,
        LeagueCode_SoccerFirstDivisionA,
        LeagueCode_SoccerSuperLig,
        LeagueCode_SoccerSuperLeague,
        LeagueCode_SoccerPremierLeagueRUS,
        LeagueCode_SoccerPremierLeagueUKR,
        LeagueCode_SoccerPrimeiraLiga,
        LeagueCode_SoccerUEFASuperCup,
        LeagueCode_SoccerEuropaLeague,
        LeagueCode_SoccerYouthLeague,
        LeagueCode_CricketICC,
        LeagueCode_CricketIPL,
        LeagueCode_SoccerPrimeraDivisionARG,
        LeagueCode_SoccerPrimeraDivisionMEX,
        LeagueCode_SoccerBrasileiroSerieA,
        LeagueCode_SoccerInternational,
        LeagueCode_SoccerChineseSuperLeague,
        LeagueCode_SoccerILeague,
        LeagueCode_SoccerIndianSuperLeague,
        LeagueCode_SoccerJLeague,
        LeagueCode_NPB,
        LeagueCode__none
      };
    public struct TypeLeagueCode
      {
        public bool in_known_list;
        public string string_value;
        public TypeLeagueCodeKnownValues list_value;
      };

    public static TypeLeagueCodeKnownValues  stringToLeagueCode(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                switch (chars[1])
                  {
                    case 'F':
                        if ((String.Compare(chars, 2, "L", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeLeagueCodeKnownValues.LeagueCode_CFL;
                        break;
                    case 'r':
                        if (String.Compare(chars, 2, "icketI", 0, 6, false) == 0)
                          {
                            switch (chars[8])
                              {
                                case 'C':
                                    if ((String.Compare(chars, 9, "C", 0, 1, false) == 0) && (chars.Length == 10))
                                        return TypeLeagueCodeKnownValues.LeagueCode_CricketICC;
                                    break;
                                case 'P':
                                    if ((String.Compare(chars, 9, "L", 0, 1, false) == 0) && (chars.Length == 10))
                                        return TypeLeagueCodeKnownValues.LeagueCode_CricketIPL;
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
                                return TypeLeagueCodeKnownValues.LeagueCode_MLB;
                            break;
                        case 'S':
                            if (chars.Length == 3)
                                return TypeLeagueCodeKnownValues.LeagueCode_MLS;
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
                            return TypeLeagueCodeKnownValues.LeagueCode_NBA;
                        break;
                    case 'C':
                        if (String.Compare(chars, 2, "AA", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 5, "B", 0, 1, false) == 0) && (chars.Length == 6))
                                        return TypeLeagueCodeKnownValues.LeagueCode_NCAAFB;
                                    break;
                                case 'M':
                                    if ((String.Compare(chars, 5, "B", 0, 1, false) == 0) && (chars.Length == 6))
                                        return TypeLeagueCodeKnownValues.LeagueCode_NCAAMB;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'F':
                        if ((String.Compare(chars, 2, "L", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeLeagueCodeKnownValues.LeagueCode_NFL;
                        break;
                    case 'H':
                        if ((String.Compare(chars, 2, "L", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeLeagueCodeKnownValues.LeagueCode_NHL;
                        break;
                    case 'P':
                        if ((String.Compare(chars, 2, "B", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeLeagueCodeKnownValues.LeagueCode_NPB;
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
                                        return TypeLeagueCodeKnownValues.LeagueCode_SoccerBrasileiroSerieA;
                                    break;
                                case 'u':
                                    if ((String.Compare(chars, 8, "ndesliga", 0, 8, false) == 0) && (chars.Length == 16))
                                        return TypeLeagueCodeKnownValues.LeagueCode_SoccerBundesliga;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'C':
                            if ((String.Compare(chars, 7, "hineseSuperLeague", 0, 17, false) == 0) && (chars.Length == 24))
                                return TypeLeagueCodeKnownValues.LeagueCode_SoccerChineseSuperLeague;
                            break;
                        case 'E':
                            switch (chars[7])
                              {
                                case 'r':
                                    if ((String.Compare(chars, 8, "edivisie", 0, 8, false) == 0) && (chars.Length == 16))
                                        return TypeLeagueCodeKnownValues.LeagueCode_SoccerEredivisie;
                                    break;
                                case 'u':
                                    if ((String.Compare(chars, 8, "ropaLeague", 0, 10, false) == 0) && (chars.Length == 18))
                                        return TypeLeagueCodeKnownValues.LeagueCode_SoccerEuropaLeague;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'F':
                            if ((String.Compare(chars, 7, "irstDivisionA", 0, 13, false) == 0) && (chars.Length == 20))
                                return TypeLeagueCodeKnownValues.LeagueCode_SoccerFirstDivisionA;
                            break;
                        case 'I':
                            switch (chars[7])
                              {
                                case 'L':
                                    if ((String.Compare(chars, 8, "eague", 0, 5, false) == 0) && (chars.Length == 13))
                                        return TypeLeagueCodeKnownValues.LeagueCode_SoccerILeague;
                                    break;
                                case 'n':
                                    switch (chars[8])
                                      {
                                        case 'd':
                                            if ((String.Compare(chars, 9, "ianSuperLeague", 0, 14, false) == 0) && (chars.Length == 23))
                                                return TypeLeagueCodeKnownValues.LeagueCode_SoccerIndianSuperLeague;
                                            break;
                                        case 't':
                                            if ((String.Compare(chars, 9, "ernational", 0, 10, false) == 0) && (chars.Length == 19))
                                                return TypeLeagueCodeKnownValues.LeagueCode_SoccerInternational;
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
                                return TypeLeagueCodeKnownValues.LeagueCode_SoccerJLeague;
                            break;
                        case 'L':
                            if ((String.Compare(chars, 7, "igue1", 0, 5, false) == 0) && (chars.Length == 12))
                                return TypeLeagueCodeKnownValues.LeagueCode_SoccerLigue1;
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
                                                return TypeLeagueCodeKnownValues.LeagueCode_SoccerPremierLeague;
                                              }
                                            switch (chars[19])
                                              {
                                                case 'R':
                                                    if ((String.Compare(chars, 20, "US", 0, 2, false) == 0) && (chars.Length == 22))
                                                        return TypeLeagueCodeKnownValues.LeagueCode_SoccerPremierLeagueRUS;
                                                    break;
                                                case 'U':
                                                    if ((String.Compare(chars, 20, "KR", 0, 2, false) == 0) && (chars.Length == 22))
                                                        return TypeLeagueCodeKnownValues.LeagueCode_SoccerPremierLeagueUKR;
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
                                                        return TypeLeagueCodeKnownValues.LeagueCode_SoccerPrimeiraLiga;
                                                    break;
                                                case 'r':
                                                    if (String.Compare(chars, 12, "aDivision", 0, 9, false) == 0)
                                                      {
                                                        if (chars.Length == 21)
                                                          {
                                                            return TypeLeagueCodeKnownValues.LeagueCode_SoccerPrimeraDivision;
                                                          }
                                                        switch (chars[21])
                                                          {
                                                            case 'A':
                                                                if ((String.Compare(chars, 22, "RG", 0, 2, false) == 0) && (chars.Length == 24))
                                                                    return TypeLeagueCodeKnownValues.LeagueCode_SoccerPrimeraDivisionARG;
                                                                break;
                                                            case 'M':
                                                                if ((String.Compare(chars, 22, "EX", 0, 2, false) == 0) && (chars.Length == 24))
                                                                    return TypeLeagueCodeKnownValues.LeagueCode_SoccerPrimeraDivisionMEX;
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
                                        return TypeLeagueCodeKnownValues.LeagueCode_SoccerSerieA;
                                    break;
                                case 'u':
                                    if (String.Compare(chars, 8, "perL", 0, 4, false) == 0)
                                      {
                                        switch (chars[12])
                                          {
                                            case 'e':
                                                if ((String.Compare(chars, 13, "ague", 0, 4, false) == 0) && (chars.Length == 17))
                                                    return TypeLeagueCodeKnownValues.LeagueCode_SoccerSuperLeague;
                                                break;
                                            case 'i':
                                                if ((String.Compare(chars, 13, "g", 0, 1, false) == 0) && (chars.Length == 14))
                                                    return TypeLeagueCodeKnownValues.LeagueCode_SoccerSuperLig;
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
                                            return TypeLeagueCodeKnownValues.LeagueCode_SoccerUEFAChampionsLeague;
                                        break;
                                    case 'S':
                                        if ((String.Compare(chars, 11, "uperCup", 0, 7, false) == 0) && (chars.Length == 18))
                                            return TypeLeagueCodeKnownValues.LeagueCode_SoccerUEFASuperCup;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'Y':
                            if ((String.Compare(chars, 7, "outhLeague", 0, 10, false) == 0) && (chars.Length == 17))
                                return TypeLeagueCodeKnownValues.LeagueCode_SoccerYouthLeague;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return TypeLeagueCodeKnownValues.LeagueCode__none;
      }

    public static string  stringFromLeagueCode(TypeLeagueCodeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeLeagueCodeKnownValues.LeagueCode_MLB:
                return "MLB";
            case TypeLeagueCodeKnownValues.LeagueCode_NBA:
                return "NBA";
            case TypeLeagueCodeKnownValues.LeagueCode_NFL:
                return "NFL";
            case TypeLeagueCodeKnownValues.LeagueCode_NHL:
                return "NHL";
            case TypeLeagueCodeKnownValues.LeagueCode_NCAAMB:
                return "NCAAMB";
            case TypeLeagueCodeKnownValues.LeagueCode_NCAAFB:
                return "NCAAFB";
            case TypeLeagueCodeKnownValues.LeagueCode_MLS:
                return "MLS";
            case TypeLeagueCodeKnownValues.LeagueCode_CFL:
                return "CFL";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerUEFAChampionsLeague:
                return "SoccerUEFAChampionsLeague";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerPrimeraDivision:
                return "SoccerPrimeraDivision";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerPremierLeague:
                return "SoccerPremierLeague";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerSerieA:
                return "SoccerSerieA";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerLigue1:
                return "SoccerLigue1";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerBundesliga:
                return "SoccerBundesliga";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerEredivisie:
                return "SoccerEredivisie";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerFirstDivisionA:
                return "SoccerFirstDivisionA";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerSuperLig:
                return "SoccerSuperLig";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerSuperLeague:
                return "SoccerSuperLeague";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerPremierLeagueRUS:
                return "SoccerPremierLeagueRUS";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerPremierLeagueUKR:
                return "SoccerPremierLeagueUKR";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerPrimeiraLiga:
                return "SoccerPrimeiraLiga";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerUEFASuperCup:
                return "SoccerUEFASuperCup";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerEuropaLeague:
                return "SoccerEuropaLeague";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerYouthLeague:
                return "SoccerYouthLeague";
            case TypeLeagueCodeKnownValues.LeagueCode_CricketICC:
                return "CricketICC";
            case TypeLeagueCodeKnownValues.LeagueCode_CricketIPL:
                return "CricketIPL";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerPrimeraDivisionARG:
                return "SoccerPrimeraDivisionARG";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerPrimeraDivisionMEX:
                return "SoccerPrimeraDivisionMEX";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerBrasileiroSerieA:
                return "SoccerBrasileiroSerieA";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerInternational:
                return "SoccerInternational";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerChineseSuperLeague:
                return "SoccerChineseSuperLeague";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerILeague:
                return "SoccerILeague";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerIndianSuperLeague:
                return "SoccerIndianSuperLeague";
            case TypeLeagueCodeKnownValues.LeagueCode_SoccerJLeague:
                return "SoccerJLeague";
            case TypeLeagueCodeKnownValues.LeagueCode_NPB:
                return "NPB";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasLeagueCode;
    private TypeLeagueCode storeLeagueCode;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONLeagueCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LeagueCode of SportsLeagueJSON is not a string.");
        TypeLeagueCode the_open_enum = new TypeLeagueCode();
        switch (json_string.getData()[0])
          {
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'F':
                        if ((String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_CFL;
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
                                            the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_CricketICC;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'P':
                                    if ((String.Compare(json_string.getData(), 9, "L", 0, 1, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_CricketIPL;
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
                                    the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_MLB;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'S':
                            if (json_string.getData().Length == 3)
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_MLS;
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
                                the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_NBA;
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
                                            the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_NCAAFB;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'M':
                                    if ((String.Compare(json_string.getData(), 5, "B", 0, 1, false) == 0) && (json_string.getData().Length == 6))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_NCAAMB;
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
                                the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_NFL;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'H':
                        if ((String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_NHL;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'P':
                        if ((String.Compare(json_string.getData(), 2, "B", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_NPB;
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
                                            the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerBrasileiroSerieA;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'u':
                                    if ((String.Compare(json_string.getData(), 8, "ndesliga", 0, 8, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerBundesliga;
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
                                    the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerChineseSuperLeague;
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
                                            the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerEredivisie;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'u':
                                    if ((String.Compare(json_string.getData(), 8, "ropaLeague", 0, 10, false) == 0) && (json_string.getData().Length == 18))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerEuropaLeague;
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
                                    the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerFirstDivisionA;
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
                                            the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerILeague;
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
                                                    the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerIndianSuperLeague;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 't':
                                            if ((String.Compare(json_string.getData(), 9, "ernational", 0, 10, false) == 0) && (json_string.getData().Length == 19))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerInternational;
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
                                    the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerJLeague;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'L':
                            if ((String.Compare(json_string.getData(), 7, "igue1", 0, 5, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerLigue1;
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
                                                    the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerPremierLeague;
                                                    goto open_enum_is_done;
                                                  }
                                              }
                                            switch (json_string.getData()[19])
                                              {
                                                case 'R':
                                                    if ((String.Compare(json_string.getData(), 20, "US", 0, 2, false) == 0) && (json_string.getData().Length == 22))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerPremierLeagueRUS;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'U':
                                                    if ((String.Compare(json_string.getData(), 20, "KR", 0, 2, false) == 0) && (json_string.getData().Length == 22))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerPremierLeagueUKR;
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
                                                            the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerPrimeiraLiga;
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
                                                                the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerPrimeraDivision;
                                                                goto open_enum_is_done;
                                                              }
                                                          }
                                                        switch (json_string.getData()[21])
                                                          {
                                                            case 'A':
                                                                if ((String.Compare(json_string.getData(), 22, "RG", 0, 2, false) == 0) && (json_string.getData().Length == 24))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerPrimeraDivisionARG;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'M':
                                                                if ((String.Compare(json_string.getData(), 22, "EX", 0, 2, false) == 0) && (json_string.getData().Length == 24))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerPrimeraDivisionMEX;
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
                                            the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerSerieA;
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
                                                        the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerSuperLeague;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'i':
                                                if ((String.Compare(json_string.getData(), 13, "g", 0, 1, false) == 0) && (json_string.getData().Length == 14))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerSuperLig;
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
                                                the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerUEFAChampionsLeague;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'S':
                                        if ((String.Compare(json_string.getData(), 11, "uperCup", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerUEFASuperCup;
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
                                    the_open_enum.list_value = TypeLeagueCodeKnownValues.LeagueCode_SoccerYouthLeague;
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
        setLeagueCode(the_open_enum);
      }


    public SportsLeagueJSON()
      {
        flagHasLeagueCode = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasLeagueCode()
      {
        return flagHasLeagueCode;
      }

    public TypeLeagueCode  getLeagueCode()
      {
        Debug.Assert(flagHasLeagueCode);
        return storeLeagueCode;
      }

    public string  getLeagueCodeAsString()
      {
        TypeLeagueCode result = getLeagueCode();
        if (result.in_known_list)
            return stringFromLeagueCode(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraSportsLeagueComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsLeagueComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsLeagueComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsLeagueLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setLeagueCode(TypeLeagueCode new_value)
      {
        flagHasLeagueCode = true;
        storeLeagueCode = new_value;
      }
    public void setLeagueCode(string chars)
      {
        TypeLeagueCodeKnownValues known = stringToLeagueCode(chars);
        TypeLeagueCode new_value = new TypeLeagueCode();
        if (known == TypeLeagueCodeKnownValues.LeagueCode__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setLeagueCode(new_value);
      }
    public void setLeagueCode(TypeLeagueCodeKnownValues new_value)
      {
        TypeLeagueCode new_full_value = new TypeLeagueCode();
        Debug.Assert(new_value != TypeLeagueCodeKnownValues.LeagueCode__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setLeagueCode(new_full_value);
      }
    public void unsetLeagueCode()
      {
        flagHasLeagueCode = false;
      }

    public virtual void extraSportsLeagueAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsLeagueSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsLeagueLookup(key);
        if (old_field == null)
          {
            extraSportsLeagueAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasLeagueCode);
        if (flagHasLeagueCode)
          {
            handler.start_pair("LeagueCode");
            if (storeLeagueCode.in_known_list)
              {
                switch (storeLeagueCode.list_value)
                  {
                    case TypeLeagueCodeKnownValues.LeagueCode_MLB:
                        handler.string_value("MLB");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_NBA:
                        handler.string_value("NBA");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_NFL:
                        handler.string_value("NFL");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_NHL:
                        handler.string_value("NHL");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_NCAAMB:
                        handler.string_value("NCAAMB");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_NCAAFB:
                        handler.string_value("NCAAFB");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_MLS:
                        handler.string_value("MLS");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_CFL:
                        handler.string_value("CFL");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerUEFAChampionsLeague:
                        handler.string_value("SoccerUEFAChampionsLeague");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerPrimeraDivision:
                        handler.string_value("SoccerPrimeraDivision");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerPremierLeague:
                        handler.string_value("SoccerPremierLeague");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerSerieA:
                        handler.string_value("SoccerSerieA");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerLigue1:
                        handler.string_value("SoccerLigue1");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerBundesliga:
                        handler.string_value("SoccerBundesliga");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerEredivisie:
                        handler.string_value("SoccerEredivisie");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerFirstDivisionA:
                        handler.string_value("SoccerFirstDivisionA");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerSuperLig:
                        handler.string_value("SoccerSuperLig");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerSuperLeague:
                        handler.string_value("SoccerSuperLeague");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerPremierLeagueRUS:
                        handler.string_value("SoccerPremierLeagueRUS");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerPremierLeagueUKR:
                        handler.string_value("SoccerPremierLeagueUKR");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerPrimeiraLiga:
                        handler.string_value("SoccerPrimeiraLiga");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerUEFASuperCup:
                        handler.string_value("SoccerUEFASuperCup");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerEuropaLeague:
                        handler.string_value("SoccerEuropaLeague");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerYouthLeague:
                        handler.string_value("SoccerYouthLeague");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_CricketICC:
                        handler.string_value("CricketICC");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_CricketIPL:
                        handler.string_value("CricketIPL");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerPrimeraDivisionARG:
                        handler.string_value("SoccerPrimeraDivisionARG");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerPrimeraDivisionMEX:
                        handler.string_value("SoccerPrimeraDivisionMEX");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerBrasileiroSerieA:
                        handler.string_value("SoccerBrasileiroSerieA");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerInternational:
                        handler.string_value("SoccerInternational");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerChineseSuperLeague:
                        handler.string_value("SoccerChineseSuperLeague");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerILeague:
                        handler.string_value("SoccerILeague");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerIndianSuperLeague:
                        handler.string_value("SoccerIndianSuperLeague");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_SoccerJLeague:
                        handler.string_value("SoccerJLeague");
                        break;
                    case TypeLeagueCodeKnownValues.LeagueCode_NPB:
                        handler.string_value("NPB");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeLeagueCode.string_value);
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
        if (!(hasLeagueCode()))
          {
            return "When parsing the object for %what%, the \"LeagueCode\" field was missing.";
          }
        return null;
      }

    public static SportsLeagueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsLeagueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeague", ignore_extras);
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
    public static SportsLeagueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsLeagueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsLeagueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeague", ignore_extras);
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
    public static SportsLeagueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsLeagueJSON from_text(string text, bool ignore_extras)
      {
        SportsLeagueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeague", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsLeagueJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsLeagueJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsLeagueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeague", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorLeagueCode : JSONStringGenerator
          {
            protected FieldGeneratorLeagueCode(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorLeagueCode()
              {
              }
            protected override void handle_result(string result)
              {
                TypeLeagueCodeKnownValues known = stringToLeagueCode(result);
                TypeLeagueCode new_value = new TypeLeagueCode();
                if (known == TypeLeagueCodeKnownValues.LeagueCode__none)
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
            protected abstract void handle_result(TypeLeagueCode result);
          };
    private class FieldHoldingGeneratorLeagueCode : FieldGeneratorLeagueCode
  {
    protected override void handle_result(TypeLeagueCode result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorLeagueCode(String what)
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
    public TypeLeagueCode value;
  };
    private class FieldHoldingArrayGeneratorLeagueCode : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLeagueCode
      {
        private FieldHoldingArrayGeneratorLeagueCode top;

        protected override void handle_result(TypeLeagueCode result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLeagueCode init_top)
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
    protected virtual void handle_result(List<TypeLeagueCode> result)
      {
      }

    public FieldHoldingArrayGeneratorLeagueCode(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLeagueCode>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLeagueCode()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLeagueCode>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLeagueCode> value;
  };
        private FieldHoldingGeneratorLeagueCode fieldGeneratorLeagueCode;
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
            SportsLeagueJSON result = new SportsLeagueJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsLeagueAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsLeagueJSON result)
          {
            if (fieldGeneratorLeagueCode.have_value)
              {
                result.setLeagueCode(fieldGeneratorLeagueCode.value);
                fieldGeneratorLeagueCode.have_value = false;
              }
            else if ((!(result.hasLeagueCode())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LeagueCode\" field was missing.");
              }
          }
        protected abstract void handle_result(SportsLeagueJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "LeagueCode", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorLeagueCode;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorLeagueCode = new FieldHoldingGeneratorLeagueCode("field \"LeagueCode\" of the SportsLeague class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsLeague class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorLeagueCode = new FieldHoldingGeneratorLeagueCode("field \"LeagueCode\" of the SportsLeague class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsLeague class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorLeagueCode.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsLeagueJSON  result)
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
        public SportsLeagueJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsLeagueJSON  result)
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
    protected virtual void handle_result(List<SportsLeagueJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsLeagueJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsLeagueJSON>();
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
    public List<SportsLeagueJSON> value;
  };
  };
