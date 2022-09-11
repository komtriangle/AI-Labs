/* file "SportsPlayerPositionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsPlayerPositionJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_Unknown,
        Value_MLBCatcher,
        Value_MLBInfield,
        Value_MLBFirstBase,
        Value_MLBSecondBase,
        Value_MLBThirdBase,
        Value_MLBShortStop,
        Value_MLBOutfield,
        Value_MLBLeftField,
        Value_MLBCenterField,
        Value_MLBPitcher,
        Value_MLBRightField,
        Value_MLBReliefPitcher,
        Value_MLBStartingPitcher,
        Value_MLBDesignatedHitter,
        Value_NHLUnknown,
        Value_NHLCenter,
        Value_NHLForward,
        Value_NHLDefense,
        Value_NHLGoalie,
        Value_NHLLeftWing,
        Value_NHLRightWing,
        Value_NBAUnknown,
        Value_NBACenter,
        Value_NBAPowerForward,
        Value_NBAPointGuard,
        Value_NBASmallForward,
        Value_NBAShootingGuard,
        Value_NCAAMBUnknown,
        Value_NCAAMBCenter,
        Value_NCAAMBCenterForward,
        Value_NCAAMBForward,
        Value_NCAAMBForwardCenter,
        Value_NCAAMBForwardGuard,
        Value_NCAAMBGuard,
        Value_NCAAMBGuardForward,
        Value_NFLUnknown,
        Value_NFLCenter,
        Value_NFLFullback,
        Value_NFLOffensiveGuard,
        Value_NFLOffensiveLineman,
        Value_NFLOffensiveTackle,
        Value_NFLQuarterback,
        Value_NFLRunningBack,
        Value_NFLTightEnd,
        Value_NFLWideReceiver,
        Value_NFLCornerback,
        Value_NFLDefensiveBack,
        Value_NFLDefensiveEnd,
        Value_NFLDefensiveTackle,
        Value_NFLFreeSafety,
        Value_NFLLinebacker,
        Value_NFLMiddleLinebacker,
        Value_NFLNoseTackle,
        Value_NFLOutsideLinebacker,
        Value_NFLSafety,
        Value_NFLStrongSafety,
        Value_NFLKicker,
        Value_NFLLongSnapper,
        Value_NFLPunter,
        Value_NFLGeneralDefense,
        Value_NFLGeneralDefensiveLine,
        Value_NFLGeneralOffense,
        Value_NFLGeneralSpecialTeams,
        Value_NCAAFBUnknown,
        Value_NCAAFBCenter,
        Value_NCAAFBFullback,
        Value_NCAAFBOffensiveGuard,
        Value_NCAAFBOffensiveLineman,
        Value_NCAAFBOffensiveTackle,
        Value_NCAAFBQuarterback,
        Value_NCAAFBRunningBack,
        Value_NCAAFBTightEnd,
        Value_NCAAFBWideReceiver,
        Value_NCAAFBCornerback,
        Value_NCAAFBDefensiveLine,
        Value_NCAAFBDefensiveBack,
        Value_NCAAFBDefensiveEnd,
        Value_NCAAFBDefensiveTackle,
        Value_NCAAFBFreeSafety,
        Value_NCAAFBLinebacker,
        Value_NCAAFBMiddleLinebacker,
        Value_NCAAFBNoseTackle,
        Value_NCAAFBOutsideLinebacker,
        Value_NCAAFBSafety,
        Value_NCAAFBStrongSafety,
        Value_NCAAFBKicker,
        Value_NCAAFBLongSnapper,
        Value_NCAAFBPunter,
        Value_NCAAFBKickerPunter,
        Value_NCAAFBAthlete,
        Value_NCAAFBGeneralDefense,
        Value_NCAAFBGeneralOffense,
        Value_NCAAFBGeneralSpecialTeams,
        Value_SoccerForward,
        Value_SoccerMidfielder,
        Value_SoccerDefender,
        Value_SoccerGoalkeeper,
        Value_SoccerLeftBack,
        Value_SoccerRightBack,
        Value_SoccerCenterBack,
        Value_SoccerFullBack,
        Value_SoccerWingBack,
        Value_SoccerSweeper,
        Value_SoccerCenterMidfielder,
        Value_SoccerDefensiveMidfielder,
        Value_SoccerAttackingMidfielder,
        Value_SoccerWideMidfielder,
        Value_SoccerLeftMidfielder,
        Value_SoccerRightMidfielder,
        Value_SoccerCenterForward,
        Value_SoccerSecondStriker,
        Value_SoccerInsideLeft,
        Value_SoccerInsideRight,
        Value_SoccerWinger,
        Value_SoccerOutsideLeft,
        Value_SoccerOutsideRight,
        Value_CricketBatsman,
        Value_CricketBowler,
        Value_CricketAllRounder,
        Value_CricketWicketKeeper,
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
                if (String.Compare(chars, 1, "ricket", 0, 6, false) == 0)
                  {
                    switch (chars[7])
                      {
                        case 'A':
                            if ((String.Compare(chars, 8, "llRounder", 0, 9, false) == 0) && (chars.Length == 17))
                                return TypeValueKnownValues.Value_CricketAllRounder;
                            break;
                        case 'B':
                            switch (chars[8])
                              {
                                case 'a':
                                    if ((String.Compare(chars, 9, "tsman", 0, 5, false) == 0) && (chars.Length == 14))
                                        return TypeValueKnownValues.Value_CricketBatsman;
                                    break;
                                case 'o':
                                    if ((String.Compare(chars, 9, "wler", 0, 4, false) == 0) && (chars.Length == 13))
                                        return TypeValueKnownValues.Value_CricketBowler;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'W':
                            if ((String.Compare(chars, 8, "icketKeeper", 0, 11, false) == 0) && (chars.Length == 19))
                                return TypeValueKnownValues.Value_CricketWicketKeeper;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if (String.Compare(chars, 1, "LB", 0, 2, false) == 0)
                  {
                    switch (chars[3])
                      {
                        case 'C':
                            switch (chars[4])
                              {
                                case 'a':
                                    if ((String.Compare(chars, 5, "tcher", 0, 5, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_MLBCatcher;
                                    break;
                                case 'e':
                                    if ((String.Compare(chars, 5, "nterField", 0, 9, false) == 0) && (chars.Length == 14))
                                        return TypeValueKnownValues.Value_MLBCenterField;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'D':
                            if ((String.Compare(chars, 4, "esignatedHitter", 0, 15, false) == 0) && (chars.Length == 19))
                                return TypeValueKnownValues.Value_MLBDesignatedHitter;
                            break;
                        case 'F':
                            if ((String.Compare(chars, 4, "irstBase", 0, 8, false) == 0) && (chars.Length == 12))
                                return TypeValueKnownValues.Value_MLBFirstBase;
                            break;
                        case 'I':
                            if ((String.Compare(chars, 4, "nfield", 0, 6, false) == 0) && (chars.Length == 10))
                                return TypeValueKnownValues.Value_MLBInfield;
                            break;
                        case 'L':
                            if ((String.Compare(chars, 4, "eftField", 0, 8, false) == 0) && (chars.Length == 12))
                                return TypeValueKnownValues.Value_MLBLeftField;
                            break;
                        case 'O':
                            if ((String.Compare(chars, 4, "utfield", 0, 7, false) == 0) && (chars.Length == 11))
                                return TypeValueKnownValues.Value_MLBOutfield;
                            break;
                        case 'P':
                            if ((String.Compare(chars, 4, "itcher", 0, 6, false) == 0) && (chars.Length == 10))
                                return TypeValueKnownValues.Value_MLBPitcher;
                            break;
                        case 'R':
                            switch (chars[4])
                              {
                                case 'e':
                                    if ((String.Compare(chars, 5, "liefPitcher", 0, 11, false) == 0) && (chars.Length == 16))
                                        return TypeValueKnownValues.Value_MLBReliefPitcher;
                                    break;
                                case 'i':
                                    if ((String.Compare(chars, 5, "ghtField", 0, 8, false) == 0) && (chars.Length == 13))
                                        return TypeValueKnownValues.Value_MLBRightField;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'S':
                            switch (chars[4])
                              {
                                case 'e':
                                    if ((String.Compare(chars, 5, "condBase", 0, 8, false) == 0) && (chars.Length == 13))
                                        return TypeValueKnownValues.Value_MLBSecondBase;
                                    break;
                                case 'h':
                                    if ((String.Compare(chars, 5, "ortStop", 0, 7, false) == 0) && (chars.Length == 12))
                                        return TypeValueKnownValues.Value_MLBShortStop;
                                    break;
                                case 't':
                                    if ((String.Compare(chars, 5, "artingPitcher", 0, 13, false) == 0) && (chars.Length == 18))
                                        return TypeValueKnownValues.Value_MLBStartingPitcher;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'T':
                            if ((String.Compare(chars, 4, "hirdBase", 0, 8, false) == 0) && (chars.Length == 12))
                                return TypeValueKnownValues.Value_MLBThirdBase;
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
                        if (String.Compare(chars, 2, "A", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'C':
                                    if ((String.Compare(chars, 4, "enter", 0, 5, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_NBACenter;
                                    break;
                                case 'P':
                                    if (String.Compare(chars, 4, "o", 0, 1, false) == 0)
                                      {
                                        switch (chars[5])
                                          {
                                            case 'i':
                                                if ((String.Compare(chars, 6, "ntGuard", 0, 7, false) == 0) && (chars.Length == 13))
                                                    return TypeValueKnownValues.Value_NBAPointGuard;
                                                break;
                                            case 'w':
                                                if ((String.Compare(chars, 6, "erForward", 0, 9, false) == 0) && (chars.Length == 15))
                                                    return TypeValueKnownValues.Value_NBAPowerForward;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'S':
                                    switch (chars[4])
                                      {
                                        case 'h':
                                            if ((String.Compare(chars, 5, "ootingGuard", 0, 11, false) == 0) && (chars.Length == 16))
                                                return TypeValueKnownValues.Value_NBAShootingGuard;
                                            break;
                                        case 'm':
                                            if ((String.Compare(chars, 5, "allForward", 0, 10, false) == 0) && (chars.Length == 15))
                                                return TypeValueKnownValues.Value_NBASmallForward;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'U':
                                    if ((String.Compare(chars, 4, "nknown", 0, 6, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_NBAUnknown;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'C':
                        if (String.Compare(chars, 2, "AA", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'F':
                                    if (String.Compare(chars, 5, "B", 0, 1, false) == 0)
                                      {
                                        switch (chars[6])
                                          {
                                            case 'A':
                                                if ((String.Compare(chars, 7, "thlete", 0, 6, false) == 0) && (chars.Length == 13))
                                                    return TypeValueKnownValues.Value_NCAAFBAthlete;
                                                break;
                                            case 'C':
                                                switch (chars[7])
                                                  {
                                                    case 'e':
                                                        if ((String.Compare(chars, 8, "nter", 0, 4, false) == 0) && (chars.Length == 12))
                                                            return TypeValueKnownValues.Value_NCAAFBCenter;
                                                        break;
                                                    case 'o':
                                                        if ((String.Compare(chars, 8, "rnerback", 0, 8, false) == 0) && (chars.Length == 16))
                                                            return TypeValueKnownValues.Value_NCAAFBCornerback;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'D':
                                                if (String.Compare(chars, 7, "efensive", 0, 8, false) == 0)
                                                  {
                                                    switch (chars[15])
                                                      {
                                                        case 'B':
                                                            if ((String.Compare(chars, 16, "ack", 0, 3, false) == 0) && (chars.Length == 19))
                                                                return TypeValueKnownValues.Value_NCAAFBDefensiveBack;
                                                            break;
                                                        case 'E':
                                                            if ((String.Compare(chars, 16, "nd", 0, 2, false) == 0) && (chars.Length == 18))
                                                                return TypeValueKnownValues.Value_NCAAFBDefensiveEnd;
                                                            break;
                                                        case 'L':
                                                            if ((String.Compare(chars, 16, "ine", 0, 3, false) == 0) && (chars.Length == 19))
                                                                return TypeValueKnownValues.Value_NCAAFBDefensiveLine;
                                                            break;
                                                        case 'T':
                                                            if ((String.Compare(chars, 16, "ackle", 0, 5, false) == 0) && (chars.Length == 21))
                                                                return TypeValueKnownValues.Value_NCAAFBDefensiveTackle;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'F':
                                                switch (chars[7])
                                                  {
                                                    case 'r':
                                                        if ((String.Compare(chars, 8, "eeSafety", 0, 8, false) == 0) && (chars.Length == 16))
                                                            return TypeValueKnownValues.Value_NCAAFBFreeSafety;
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(chars, 8, "llback", 0, 6, false) == 0) && (chars.Length == 14))
                                                            return TypeValueKnownValues.Value_NCAAFBFullback;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'G':
                                                if (String.Compare(chars, 7, "eneral", 0, 6, false) == 0)
                                                  {
                                                    switch (chars[13])
                                                      {
                                                        case 'D':
                                                            if ((String.Compare(chars, 14, "efense", 0, 6, false) == 0) && (chars.Length == 20))
                                                                return TypeValueKnownValues.Value_NCAAFBGeneralDefense;
                                                            break;
                                                        case 'O':
                                                            if ((String.Compare(chars, 14, "ffense", 0, 6, false) == 0) && (chars.Length == 20))
                                                                return TypeValueKnownValues.Value_NCAAFBGeneralOffense;
                                                            break;
                                                        case 'S':
                                                            if ((String.Compare(chars, 14, "pecialTeams", 0, 11, false) == 0) && (chars.Length == 25))
                                                                return TypeValueKnownValues.Value_NCAAFBGeneralSpecialTeams;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'K':
                                                if (String.Compare(chars, 7, "icker", 0, 5, false) == 0)
                                                  {
                                                    if (chars.Length == 12)
                                                      {
                                                        return TypeValueKnownValues.Value_NCAAFBKicker;
                                                      }
                                                    switch (chars[12])
                                                      {
                                                        case 'P':
                                                            if ((String.Compare(chars, 13, "unter", 0, 5, false) == 0) && (chars.Length == 18))
                                                                return TypeValueKnownValues.Value_NCAAFBKickerPunter;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'L':
                                                switch (chars[7])
                                                  {
                                                    case 'i':
                                                        if ((String.Compare(chars, 8, "nebacker", 0, 8, false) == 0) && (chars.Length == 16))
                                                            return TypeValueKnownValues.Value_NCAAFBLinebacker;
                                                        break;
                                                    case 'o':
                                                        if ((String.Compare(chars, 8, "ngSnapper", 0, 9, false) == 0) && (chars.Length == 17))
                                                            return TypeValueKnownValues.Value_NCAAFBLongSnapper;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'M':
                                                if ((String.Compare(chars, 7, "iddleLinebacker", 0, 15, false) == 0) && (chars.Length == 22))
                                                    return TypeValueKnownValues.Value_NCAAFBMiddleLinebacker;
                                                break;
                                            case 'N':
                                                if ((String.Compare(chars, 7, "oseTackle", 0, 9, false) == 0) && (chars.Length == 16))
                                                    return TypeValueKnownValues.Value_NCAAFBNoseTackle;
                                                break;
                                            case 'O':
                                                switch (chars[7])
                                                  {
                                                    case 'f':
                                                        if (String.Compare(chars, 8, "fensive", 0, 7, false) == 0)
                                                          {
                                                            switch (chars[15])
                                                              {
                                                                case 'G':
                                                                    if ((String.Compare(chars, 16, "uard", 0, 4, false) == 0) && (chars.Length == 20))
                                                                        return TypeValueKnownValues.Value_NCAAFBOffensiveGuard;
                                                                    break;
                                                                case 'L':
                                                                    if ((String.Compare(chars, 16, "ineman", 0, 6, false) == 0) && (chars.Length == 22))
                                                                        return TypeValueKnownValues.Value_NCAAFBOffensiveLineman;
                                                                    break;
                                                                case 'T':
                                                                    if ((String.Compare(chars, 16, "ackle", 0, 5, false) == 0) && (chars.Length == 21))
                                                                        return TypeValueKnownValues.Value_NCAAFBOffensiveTackle;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                          }
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(chars, 8, "tsideLinebacker", 0, 15, false) == 0) && (chars.Length == 23))
                                                            return TypeValueKnownValues.Value_NCAAFBOutsideLinebacker;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'P':
                                                if ((String.Compare(chars, 7, "unter", 0, 5, false) == 0) && (chars.Length == 12))
                                                    return TypeValueKnownValues.Value_NCAAFBPunter;
                                                break;
                                            case 'Q':
                                                if ((String.Compare(chars, 7, "uarterback", 0, 10, false) == 0) && (chars.Length == 17))
                                                    return TypeValueKnownValues.Value_NCAAFBQuarterback;
                                                break;
                                            case 'R':
                                                if ((String.Compare(chars, 7, "unningBack", 0, 10, false) == 0) && (chars.Length == 17))
                                                    return TypeValueKnownValues.Value_NCAAFBRunningBack;
                                                break;
                                            case 'S':
                                                switch (chars[7])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(chars, 8, "fety", 0, 4, false) == 0) && (chars.Length == 12))
                                                            return TypeValueKnownValues.Value_NCAAFBSafety;
                                                        break;
                                                    case 't':
                                                        if ((String.Compare(chars, 8, "rongSafety", 0, 10, false) == 0) && (chars.Length == 18))
                                                            return TypeValueKnownValues.Value_NCAAFBStrongSafety;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'T':
                                                if ((String.Compare(chars, 7, "ightEnd", 0, 7, false) == 0) && (chars.Length == 14))
                                                    return TypeValueKnownValues.Value_NCAAFBTightEnd;
                                                break;
                                            case 'U':
                                                if ((String.Compare(chars, 7, "nknown", 0, 6, false) == 0) && (chars.Length == 13))
                                                    return TypeValueKnownValues.Value_NCAAFBUnknown;
                                                break;
                                            case 'W':
                                                if ((String.Compare(chars, 7, "ideReceiver", 0, 11, false) == 0) && (chars.Length == 18))
                                                    return TypeValueKnownValues.Value_NCAAFBWideReceiver;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'M':
                                    if (String.Compare(chars, 5, "B", 0, 1, false) == 0)
                                      {
                                        switch (chars[6])
                                          {
                                            case 'C':
                                                if (String.Compare(chars, 7, "enter", 0, 5, false) == 0)
                                                  {
                                                    if (chars.Length == 12)
                                                      {
                                                        return TypeValueKnownValues.Value_NCAAMBCenter;
                                                      }
                                                    switch (chars[12])
                                                      {
                                                        case 'F':
                                                            if ((String.Compare(chars, 13, "orward", 0, 6, false) == 0) && (chars.Length == 19))
                                                                return TypeValueKnownValues.Value_NCAAMBCenterForward;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'F':
                                                if (String.Compare(chars, 7, "orward", 0, 6, false) == 0)
                                                  {
                                                    if (chars.Length == 13)
                                                      {
                                                        return TypeValueKnownValues.Value_NCAAMBForward;
                                                      }
                                                    switch (chars[13])
                                                      {
                                                        case 'C':
                                                            if ((String.Compare(chars, 14, "enter", 0, 5, false) == 0) && (chars.Length == 19))
                                                                return TypeValueKnownValues.Value_NCAAMBForwardCenter;
                                                            break;
                                                        case 'G':
                                                            if ((String.Compare(chars, 14, "uard", 0, 4, false) == 0) && (chars.Length == 18))
                                                                return TypeValueKnownValues.Value_NCAAMBForwardGuard;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'G':
                                                if (String.Compare(chars, 7, "uard", 0, 4, false) == 0)
                                                  {
                                                    if (chars.Length == 11)
                                                      {
                                                        return TypeValueKnownValues.Value_NCAAMBGuard;
                                                      }
                                                    switch (chars[11])
                                                      {
                                                        case 'F':
                                                            if ((String.Compare(chars, 12, "orward", 0, 6, false) == 0) && (chars.Length == 18))
                                                                return TypeValueKnownValues.Value_NCAAMBGuardForward;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'U':
                                                if ((String.Compare(chars, 7, "nknown", 0, 6, false) == 0) && (chars.Length == 13))
                                                    return TypeValueKnownValues.Value_NCAAMBUnknown;
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
                    case 'F':
                        if (String.Compare(chars, 2, "L", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'C':
                                    switch (chars[4])
                                      {
                                        case 'e':
                                            if ((String.Compare(chars, 5, "nter", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_NFLCenter;
                                            break;
                                        case 'o':
                                            if ((String.Compare(chars, 5, "rnerback", 0, 8, false) == 0) && (chars.Length == 13))
                                                return TypeValueKnownValues.Value_NFLCornerback;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'D':
                                    if (String.Compare(chars, 4, "efensive", 0, 8, false) == 0)
                                      {
                                        switch (chars[12])
                                          {
                                            case 'B':
                                                if ((String.Compare(chars, 13, "ack", 0, 3, false) == 0) && (chars.Length == 16))
                                                    return TypeValueKnownValues.Value_NFLDefensiveBack;
                                                break;
                                            case 'E':
                                                if ((String.Compare(chars, 13, "nd", 0, 2, false) == 0) && (chars.Length == 15))
                                                    return TypeValueKnownValues.Value_NFLDefensiveEnd;
                                                break;
                                            case 'T':
                                                if ((String.Compare(chars, 13, "ackle", 0, 5, false) == 0) && (chars.Length == 18))
                                                    return TypeValueKnownValues.Value_NFLDefensiveTackle;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'F':
                                    switch (chars[4])
                                      {
                                        case 'r':
                                            if ((String.Compare(chars, 5, "eeSafety", 0, 8, false) == 0) && (chars.Length == 13))
                                                return TypeValueKnownValues.Value_NFLFreeSafety;
                                            break;
                                        case 'u':
                                            if ((String.Compare(chars, 5, "llback", 0, 6, false) == 0) && (chars.Length == 11))
                                                return TypeValueKnownValues.Value_NFLFullback;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'G':
                                    if (String.Compare(chars, 4, "eneral", 0, 6, false) == 0)
                                      {
                                        switch (chars[10])
                                          {
                                            case 'D':
                                                if (String.Compare(chars, 11, "efens", 0, 5, false) == 0)
                                                  {
                                                    switch (chars[16])
                                                      {
                                                        case 'e':
                                                            if (chars.Length == 17)
                                                                return TypeValueKnownValues.Value_NFLGeneralDefense;
                                                            break;
                                                        case 'i':
                                                            if ((String.Compare(chars, 17, "veLine", 0, 6, false) == 0) && (chars.Length == 23))
                                                                return TypeValueKnownValues.Value_NFLGeneralDefensiveLine;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'O':
                                                if ((String.Compare(chars, 11, "ffense", 0, 6, false) == 0) && (chars.Length == 17))
                                                    return TypeValueKnownValues.Value_NFLGeneralOffense;
                                                break;
                                            case 'S':
                                                if ((String.Compare(chars, 11, "pecialTeams", 0, 11, false) == 0) && (chars.Length == 22))
                                                    return TypeValueKnownValues.Value_NFLGeneralSpecialTeams;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'K':
                                    if ((String.Compare(chars, 4, "icker", 0, 5, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_NFLKicker;
                                    break;
                                case 'L':
                                    switch (chars[4])
                                      {
                                        case 'i':
                                            if ((String.Compare(chars, 5, "nebacker", 0, 8, false) == 0) && (chars.Length == 13))
                                                return TypeValueKnownValues.Value_NFLLinebacker;
                                            break;
                                        case 'o':
                                            if ((String.Compare(chars, 5, "ngSnapper", 0, 9, false) == 0) && (chars.Length == 14))
                                                return TypeValueKnownValues.Value_NFLLongSnapper;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'M':
                                    if ((String.Compare(chars, 4, "iddleLinebacker", 0, 15, false) == 0) && (chars.Length == 19))
                                        return TypeValueKnownValues.Value_NFLMiddleLinebacker;
                                    break;
                                case 'N':
                                    if ((String.Compare(chars, 4, "oseTackle", 0, 9, false) == 0) && (chars.Length == 13))
                                        return TypeValueKnownValues.Value_NFLNoseTackle;
                                    break;
                                case 'O':
                                    switch (chars[4])
                                      {
                                        case 'f':
                                            if (String.Compare(chars, 5, "fensive", 0, 7, false) == 0)
                                              {
                                                switch (chars[12])
                                                  {
                                                    case 'G':
                                                        if ((String.Compare(chars, 13, "uard", 0, 4, false) == 0) && (chars.Length == 17))
                                                            return TypeValueKnownValues.Value_NFLOffensiveGuard;
                                                        break;
                                                    case 'L':
                                                        if ((String.Compare(chars, 13, "ineman", 0, 6, false) == 0) && (chars.Length == 19))
                                                            return TypeValueKnownValues.Value_NFLOffensiveLineman;
                                                        break;
                                                    case 'T':
                                                        if ((String.Compare(chars, 13, "ackle", 0, 5, false) == 0) && (chars.Length == 18))
                                                            return TypeValueKnownValues.Value_NFLOffensiveTackle;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'u':
                                            if ((String.Compare(chars, 5, "tsideLinebacker", 0, 15, false) == 0) && (chars.Length == 20))
                                                return TypeValueKnownValues.Value_NFLOutsideLinebacker;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'P':
                                    if ((String.Compare(chars, 4, "unter", 0, 5, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_NFLPunter;
                                    break;
                                case 'Q':
                                    if ((String.Compare(chars, 4, "uarterback", 0, 10, false) == 0) && (chars.Length == 14))
                                        return TypeValueKnownValues.Value_NFLQuarterback;
                                    break;
                                case 'R':
                                    if ((String.Compare(chars, 4, "unningBack", 0, 10, false) == 0) && (chars.Length == 14))
                                        return TypeValueKnownValues.Value_NFLRunningBack;
                                    break;
                                case 'S':
                                    switch (chars[4])
                                      {
                                        case 'a':
                                            if ((String.Compare(chars, 5, "fety", 0, 4, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_NFLSafety;
                                            break;
                                        case 't':
                                            if ((String.Compare(chars, 5, "rongSafety", 0, 10, false) == 0) && (chars.Length == 15))
                                                return TypeValueKnownValues.Value_NFLStrongSafety;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'T':
                                    if ((String.Compare(chars, 4, "ightEnd", 0, 7, false) == 0) && (chars.Length == 11))
                                        return TypeValueKnownValues.Value_NFLTightEnd;
                                    break;
                                case 'U':
                                    if ((String.Compare(chars, 4, "nknown", 0, 6, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_NFLUnknown;
                                    break;
                                case 'W':
                                    if ((String.Compare(chars, 4, "ideReceiver", 0, 11, false) == 0) && (chars.Length == 15))
                                        return TypeValueKnownValues.Value_NFLWideReceiver;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'H':
                        if (String.Compare(chars, 2, "L", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'C':
                                    if ((String.Compare(chars, 4, "enter", 0, 5, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_NHLCenter;
                                    break;
                                case 'D':
                                    if ((String.Compare(chars, 4, "efense", 0, 6, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_NHLDefense;
                                    break;
                                case 'F':
                                    if ((String.Compare(chars, 4, "orward", 0, 6, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_NHLForward;
                                    break;
                                case 'G':
                                    if ((String.Compare(chars, 4, "oalie", 0, 5, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_NHLGoalie;
                                    break;
                                case 'L':
                                    if ((String.Compare(chars, 4, "eftWing", 0, 7, false) == 0) && (chars.Length == 11))
                                        return TypeValueKnownValues.Value_NHLLeftWing;
                                    break;
                                case 'R':
                                    if ((String.Compare(chars, 4, "ightWing", 0, 8, false) == 0) && (chars.Length == 12))
                                        return TypeValueKnownValues.Value_NHLRightWing;
                                    break;
                                case 'U':
                                    if ((String.Compare(chars, 4, "nknown", 0, 6, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_NHLUnknown;
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
            case 'S':
                if (String.Compare(chars, 1, "occer", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'A':
                            if ((String.Compare(chars, 7, "ttackingMidfielder", 0, 18, false) == 0) && (chars.Length == 25))
                                return TypeValueKnownValues.Value_SoccerAttackingMidfielder;
                            break;
                        case 'C':
                            if (String.Compare(chars, 7, "enter", 0, 5, false) == 0)
                              {
                                switch (chars[12])
                                  {
                                    case 'B':
                                        if ((String.Compare(chars, 13, "ack", 0, 3, false) == 0) && (chars.Length == 16))
                                            return TypeValueKnownValues.Value_SoccerCenterBack;
                                        break;
                                    case 'F':
                                        if ((String.Compare(chars, 13, "orward", 0, 6, false) == 0) && (chars.Length == 19))
                                            return TypeValueKnownValues.Value_SoccerCenterForward;
                                        break;
                                    case 'M':
                                        if ((String.Compare(chars, 13, "idfielder", 0, 9, false) == 0) && (chars.Length == 22))
                                            return TypeValueKnownValues.Value_SoccerCenterMidfielder;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'D':
                            if (String.Compare(chars, 7, "efen", 0, 4, false) == 0)
                              {
                                switch (chars[11])
                                  {
                                    case 'd':
                                        if ((String.Compare(chars, 12, "er", 0, 2, false) == 0) && (chars.Length == 14))
                                            return TypeValueKnownValues.Value_SoccerDefender;
                                        break;
                                    case 's':
                                        if ((String.Compare(chars, 12, "iveMidfielder", 0, 13, false) == 0) && (chars.Length == 25))
                                            return TypeValueKnownValues.Value_SoccerDefensiveMidfielder;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'F':
                            switch (chars[7])
                              {
                                case 'o':
                                    if ((String.Compare(chars, 8, "rward", 0, 5, false) == 0) && (chars.Length == 13))
                                        return TypeValueKnownValues.Value_SoccerForward;
                                    break;
                                case 'u':
                                    if ((String.Compare(chars, 8, "llBack", 0, 6, false) == 0) && (chars.Length == 14))
                                        return TypeValueKnownValues.Value_SoccerFullBack;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'G':
                            if ((String.Compare(chars, 7, "oalkeeper", 0, 9, false) == 0) && (chars.Length == 16))
                                return TypeValueKnownValues.Value_SoccerGoalkeeper;
                            break;
                        case 'I':
                            if (String.Compare(chars, 7, "nside", 0, 5, false) == 0)
                              {
                                switch (chars[12])
                                  {
                                    case 'L':
                                        if ((String.Compare(chars, 13, "eft", 0, 3, false) == 0) && (chars.Length == 16))
                                            return TypeValueKnownValues.Value_SoccerInsideLeft;
                                        break;
                                    case 'R':
                                        if ((String.Compare(chars, 13, "ight", 0, 4, false) == 0) && (chars.Length == 17))
                                            return TypeValueKnownValues.Value_SoccerInsideRight;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'L':
                            if (String.Compare(chars, 7, "eft", 0, 3, false) == 0)
                              {
                                switch (chars[10])
                                  {
                                    case 'B':
                                        if ((String.Compare(chars, 11, "ack", 0, 3, false) == 0) && (chars.Length == 14))
                                            return TypeValueKnownValues.Value_SoccerLeftBack;
                                        break;
                                    case 'M':
                                        if ((String.Compare(chars, 11, "idfielder", 0, 9, false) == 0) && (chars.Length == 20))
                                            return TypeValueKnownValues.Value_SoccerLeftMidfielder;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'M':
                            if ((String.Compare(chars, 7, "idfielder", 0, 9, false) == 0) && (chars.Length == 16))
                                return TypeValueKnownValues.Value_SoccerMidfielder;
                            break;
                        case 'O':
                            if (String.Compare(chars, 7, "utside", 0, 6, false) == 0)
                              {
                                switch (chars[13])
                                  {
                                    case 'L':
                                        if ((String.Compare(chars, 14, "eft", 0, 3, false) == 0) && (chars.Length == 17))
                                            return TypeValueKnownValues.Value_SoccerOutsideLeft;
                                        break;
                                    case 'R':
                                        if ((String.Compare(chars, 14, "ight", 0, 4, false) == 0) && (chars.Length == 18))
                                            return TypeValueKnownValues.Value_SoccerOutsideRight;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'R':
                            if (String.Compare(chars, 7, "ight", 0, 4, false) == 0)
                              {
                                switch (chars[11])
                                  {
                                    case 'B':
                                        if ((String.Compare(chars, 12, "ack", 0, 3, false) == 0) && (chars.Length == 15))
                                            return TypeValueKnownValues.Value_SoccerRightBack;
                                        break;
                                    case 'M':
                                        if ((String.Compare(chars, 12, "idfielder", 0, 9, false) == 0) && (chars.Length == 21))
                                            return TypeValueKnownValues.Value_SoccerRightMidfielder;
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
                                    if ((String.Compare(chars, 8, "condStriker", 0, 11, false) == 0) && (chars.Length == 19))
                                        return TypeValueKnownValues.Value_SoccerSecondStriker;
                                    break;
                                case 'w':
                                    if ((String.Compare(chars, 8, "eeper", 0, 5, false) == 0) && (chars.Length == 13))
                                        return TypeValueKnownValues.Value_SoccerSweeper;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'W':
                            if (String.Compare(chars, 7, "i", 0, 1, false) == 0)
                              {
                                switch (chars[8])
                                  {
                                    case 'd':
                                        if ((String.Compare(chars, 9, "eMidfielder", 0, 11, false) == 0) && (chars.Length == 20))
                                            return TypeValueKnownValues.Value_SoccerWideMidfielder;
                                        break;
                                    case 'n':
                                        if (String.Compare(chars, 9, "g", 0, 1, false) == 0)
                                          {
                                            switch (chars[10])
                                              {
                                                case 'B':
                                                    if ((String.Compare(chars, 11, "ack", 0, 3, false) == 0) && (chars.Length == 14))
                                                        return TypeValueKnownValues.Value_SoccerWingBack;
                                                    break;
                                                case 'e':
                                                    if ((String.Compare(chars, 11, "r", 0, 1, false) == 0) && (chars.Length == 12))
                                                        return TypeValueKnownValues.Value_SoccerWinger;
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
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeValueKnownValues.Value_Unknown;
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
            case TypeValueKnownValues.Value_MLBCatcher:
                return "MLBCatcher";
            case TypeValueKnownValues.Value_MLBInfield:
                return "MLBInfield";
            case TypeValueKnownValues.Value_MLBFirstBase:
                return "MLBFirstBase";
            case TypeValueKnownValues.Value_MLBSecondBase:
                return "MLBSecondBase";
            case TypeValueKnownValues.Value_MLBThirdBase:
                return "MLBThirdBase";
            case TypeValueKnownValues.Value_MLBShortStop:
                return "MLBShortStop";
            case TypeValueKnownValues.Value_MLBOutfield:
                return "MLBOutfield";
            case TypeValueKnownValues.Value_MLBLeftField:
                return "MLBLeftField";
            case TypeValueKnownValues.Value_MLBCenterField:
                return "MLBCenterField";
            case TypeValueKnownValues.Value_MLBPitcher:
                return "MLBPitcher";
            case TypeValueKnownValues.Value_MLBRightField:
                return "MLBRightField";
            case TypeValueKnownValues.Value_MLBReliefPitcher:
                return "MLBReliefPitcher";
            case TypeValueKnownValues.Value_MLBStartingPitcher:
                return "MLBStartingPitcher";
            case TypeValueKnownValues.Value_MLBDesignatedHitter:
                return "MLBDesignatedHitter";
            case TypeValueKnownValues.Value_NHLUnknown:
                return "NHLUnknown";
            case TypeValueKnownValues.Value_NHLCenter:
                return "NHLCenter";
            case TypeValueKnownValues.Value_NHLForward:
                return "NHLForward";
            case TypeValueKnownValues.Value_NHLDefense:
                return "NHLDefense";
            case TypeValueKnownValues.Value_NHLGoalie:
                return "NHLGoalie";
            case TypeValueKnownValues.Value_NHLLeftWing:
                return "NHLLeftWing";
            case TypeValueKnownValues.Value_NHLRightWing:
                return "NHLRightWing";
            case TypeValueKnownValues.Value_NBAUnknown:
                return "NBAUnknown";
            case TypeValueKnownValues.Value_NBACenter:
                return "NBACenter";
            case TypeValueKnownValues.Value_NBAPowerForward:
                return "NBAPowerForward";
            case TypeValueKnownValues.Value_NBAPointGuard:
                return "NBAPointGuard";
            case TypeValueKnownValues.Value_NBASmallForward:
                return "NBASmallForward";
            case TypeValueKnownValues.Value_NBAShootingGuard:
                return "NBAShootingGuard";
            case TypeValueKnownValues.Value_NCAAMBUnknown:
                return "NCAAMBUnknown";
            case TypeValueKnownValues.Value_NCAAMBCenter:
                return "NCAAMBCenter";
            case TypeValueKnownValues.Value_NCAAMBCenterForward:
                return "NCAAMBCenterForward";
            case TypeValueKnownValues.Value_NCAAMBForward:
                return "NCAAMBForward";
            case TypeValueKnownValues.Value_NCAAMBForwardCenter:
                return "NCAAMBForwardCenter";
            case TypeValueKnownValues.Value_NCAAMBForwardGuard:
                return "NCAAMBForwardGuard";
            case TypeValueKnownValues.Value_NCAAMBGuard:
                return "NCAAMBGuard";
            case TypeValueKnownValues.Value_NCAAMBGuardForward:
                return "NCAAMBGuardForward";
            case TypeValueKnownValues.Value_NFLUnknown:
                return "NFLUnknown";
            case TypeValueKnownValues.Value_NFLCenter:
                return "NFLCenter";
            case TypeValueKnownValues.Value_NFLFullback:
                return "NFLFullback";
            case TypeValueKnownValues.Value_NFLOffensiveGuard:
                return "NFLOffensiveGuard";
            case TypeValueKnownValues.Value_NFLOffensiveLineman:
                return "NFLOffensiveLineman";
            case TypeValueKnownValues.Value_NFLOffensiveTackle:
                return "NFLOffensiveTackle";
            case TypeValueKnownValues.Value_NFLQuarterback:
                return "NFLQuarterback";
            case TypeValueKnownValues.Value_NFLRunningBack:
                return "NFLRunningBack";
            case TypeValueKnownValues.Value_NFLTightEnd:
                return "NFLTightEnd";
            case TypeValueKnownValues.Value_NFLWideReceiver:
                return "NFLWideReceiver";
            case TypeValueKnownValues.Value_NFLCornerback:
                return "NFLCornerback";
            case TypeValueKnownValues.Value_NFLDefensiveBack:
                return "NFLDefensiveBack";
            case TypeValueKnownValues.Value_NFLDefensiveEnd:
                return "NFLDefensiveEnd";
            case TypeValueKnownValues.Value_NFLDefensiveTackle:
                return "NFLDefensiveTackle";
            case TypeValueKnownValues.Value_NFLFreeSafety:
                return "NFLFreeSafety";
            case TypeValueKnownValues.Value_NFLLinebacker:
                return "NFLLinebacker";
            case TypeValueKnownValues.Value_NFLMiddleLinebacker:
                return "NFLMiddleLinebacker";
            case TypeValueKnownValues.Value_NFLNoseTackle:
                return "NFLNoseTackle";
            case TypeValueKnownValues.Value_NFLOutsideLinebacker:
                return "NFLOutsideLinebacker";
            case TypeValueKnownValues.Value_NFLSafety:
                return "NFLSafety";
            case TypeValueKnownValues.Value_NFLStrongSafety:
                return "NFLStrongSafety";
            case TypeValueKnownValues.Value_NFLKicker:
                return "NFLKicker";
            case TypeValueKnownValues.Value_NFLLongSnapper:
                return "NFLLongSnapper";
            case TypeValueKnownValues.Value_NFLPunter:
                return "NFLPunter";
            case TypeValueKnownValues.Value_NFLGeneralDefense:
                return "NFLGeneralDefense";
            case TypeValueKnownValues.Value_NFLGeneralDefensiveLine:
                return "NFLGeneralDefensiveLine";
            case TypeValueKnownValues.Value_NFLGeneralOffense:
                return "NFLGeneralOffense";
            case TypeValueKnownValues.Value_NFLGeneralSpecialTeams:
                return "NFLGeneralSpecialTeams";
            case TypeValueKnownValues.Value_NCAAFBUnknown:
                return "NCAAFBUnknown";
            case TypeValueKnownValues.Value_NCAAFBCenter:
                return "NCAAFBCenter";
            case TypeValueKnownValues.Value_NCAAFBFullback:
                return "NCAAFBFullback";
            case TypeValueKnownValues.Value_NCAAFBOffensiveGuard:
                return "NCAAFBOffensiveGuard";
            case TypeValueKnownValues.Value_NCAAFBOffensiveLineman:
                return "NCAAFBOffensiveLineman";
            case TypeValueKnownValues.Value_NCAAFBOffensiveTackle:
                return "NCAAFBOffensiveTackle";
            case TypeValueKnownValues.Value_NCAAFBQuarterback:
                return "NCAAFBQuarterback";
            case TypeValueKnownValues.Value_NCAAFBRunningBack:
                return "NCAAFBRunningBack";
            case TypeValueKnownValues.Value_NCAAFBTightEnd:
                return "NCAAFBTightEnd";
            case TypeValueKnownValues.Value_NCAAFBWideReceiver:
                return "NCAAFBWideReceiver";
            case TypeValueKnownValues.Value_NCAAFBCornerback:
                return "NCAAFBCornerback";
            case TypeValueKnownValues.Value_NCAAFBDefensiveLine:
                return "NCAAFBDefensiveLine";
            case TypeValueKnownValues.Value_NCAAFBDefensiveBack:
                return "NCAAFBDefensiveBack";
            case TypeValueKnownValues.Value_NCAAFBDefensiveEnd:
                return "NCAAFBDefensiveEnd";
            case TypeValueKnownValues.Value_NCAAFBDefensiveTackle:
                return "NCAAFBDefensiveTackle";
            case TypeValueKnownValues.Value_NCAAFBFreeSafety:
                return "NCAAFBFreeSafety";
            case TypeValueKnownValues.Value_NCAAFBLinebacker:
                return "NCAAFBLinebacker";
            case TypeValueKnownValues.Value_NCAAFBMiddleLinebacker:
                return "NCAAFBMiddleLinebacker";
            case TypeValueKnownValues.Value_NCAAFBNoseTackle:
                return "NCAAFBNoseTackle";
            case TypeValueKnownValues.Value_NCAAFBOutsideLinebacker:
                return "NCAAFBOutsideLinebacker";
            case TypeValueKnownValues.Value_NCAAFBSafety:
                return "NCAAFBSafety";
            case TypeValueKnownValues.Value_NCAAFBStrongSafety:
                return "NCAAFBStrongSafety";
            case TypeValueKnownValues.Value_NCAAFBKicker:
                return "NCAAFBKicker";
            case TypeValueKnownValues.Value_NCAAFBLongSnapper:
                return "NCAAFBLongSnapper";
            case TypeValueKnownValues.Value_NCAAFBPunter:
                return "NCAAFBPunter";
            case TypeValueKnownValues.Value_NCAAFBKickerPunter:
                return "NCAAFBKickerPunter";
            case TypeValueKnownValues.Value_NCAAFBAthlete:
                return "NCAAFBAthlete";
            case TypeValueKnownValues.Value_NCAAFBGeneralDefense:
                return "NCAAFBGeneralDefense";
            case TypeValueKnownValues.Value_NCAAFBGeneralOffense:
                return "NCAAFBGeneralOffense";
            case TypeValueKnownValues.Value_NCAAFBGeneralSpecialTeams:
                return "NCAAFBGeneralSpecialTeams";
            case TypeValueKnownValues.Value_SoccerForward:
                return "SoccerForward";
            case TypeValueKnownValues.Value_SoccerMidfielder:
                return "SoccerMidfielder";
            case TypeValueKnownValues.Value_SoccerDefender:
                return "SoccerDefender";
            case TypeValueKnownValues.Value_SoccerGoalkeeper:
                return "SoccerGoalkeeper";
            case TypeValueKnownValues.Value_SoccerLeftBack:
                return "SoccerLeftBack";
            case TypeValueKnownValues.Value_SoccerRightBack:
                return "SoccerRightBack";
            case TypeValueKnownValues.Value_SoccerCenterBack:
                return "SoccerCenterBack";
            case TypeValueKnownValues.Value_SoccerFullBack:
                return "SoccerFullBack";
            case TypeValueKnownValues.Value_SoccerWingBack:
                return "SoccerWingBack";
            case TypeValueKnownValues.Value_SoccerSweeper:
                return "SoccerSweeper";
            case TypeValueKnownValues.Value_SoccerCenterMidfielder:
                return "SoccerCenterMidfielder";
            case TypeValueKnownValues.Value_SoccerDefensiveMidfielder:
                return "SoccerDefensiveMidfielder";
            case TypeValueKnownValues.Value_SoccerAttackingMidfielder:
                return "SoccerAttackingMidfielder";
            case TypeValueKnownValues.Value_SoccerWideMidfielder:
                return "SoccerWideMidfielder";
            case TypeValueKnownValues.Value_SoccerLeftMidfielder:
                return "SoccerLeftMidfielder";
            case TypeValueKnownValues.Value_SoccerRightMidfielder:
                return "SoccerRightMidfielder";
            case TypeValueKnownValues.Value_SoccerCenterForward:
                return "SoccerCenterForward";
            case TypeValueKnownValues.Value_SoccerSecondStriker:
                return "SoccerSecondStriker";
            case TypeValueKnownValues.Value_SoccerInsideLeft:
                return "SoccerInsideLeft";
            case TypeValueKnownValues.Value_SoccerInsideRight:
                return "SoccerInsideRight";
            case TypeValueKnownValues.Value_SoccerWinger:
                return "SoccerWinger";
            case TypeValueKnownValues.Value_SoccerOutsideLeft:
                return "SoccerOutsideLeft";
            case TypeValueKnownValues.Value_SoccerOutsideRight:
                return "SoccerOutsideRight";
            case TypeValueKnownValues.Value_CricketBatsman:
                return "CricketBatsman";
            case TypeValueKnownValues.Value_CricketBowler:
                return "CricketBowler";
            case TypeValueKnownValues.Value_CricketAllRounder:
                return "CricketAllRounder";
            case TypeValueKnownValues.Value_CricketWicketKeeper:
                return "CricketWicketKeeper";
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
            throw new Exception("The value for field Value of SportsPlayerPositionJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'C':
                if (String.Compare(json_string.getData(), 1, "ricket", 0, 6, false) == 0)
                  {
                    switch (json_string.getData()[7])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 8, "llRounder", 0, 9, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_CricketAllRounder;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'B':
                            switch (json_string.getData()[8])
                              {
                                case 'a':
                                    if ((String.Compare(json_string.getData(), 9, "tsman", 0, 5, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_CricketBatsman;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'o':
                                    if ((String.Compare(json_string.getData(), 9, "wler", 0, 4, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_CricketBowler;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'W':
                            if ((String.Compare(json_string.getData(), 8, "icketKeeper", 0, 11, false) == 0) && (json_string.getData().Length == 19))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_CricketWicketKeeper;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if (String.Compare(json_string.getData(), 1, "LB", 0, 2, false) == 0)
                  {
                    switch (json_string.getData()[3])
                      {
                        case 'C':
                            switch (json_string.getData()[4])
                              {
                                case 'a':
                                    if ((String.Compare(json_string.getData(), 5, "tcher", 0, 5, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MLBCatcher;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'e':
                                    if ((String.Compare(json_string.getData(), 5, "nterField", 0, 9, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MLBCenterField;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'D':
                            if ((String.Compare(json_string.getData(), 4, "esignatedHitter", 0, 15, false) == 0) && (json_string.getData().Length == 19))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_MLBDesignatedHitter;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'F':
                            if ((String.Compare(json_string.getData(), 4, "irstBase", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_MLBFirstBase;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'I':
                            if ((String.Compare(json_string.getData(), 4, "nfield", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_MLBInfield;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'L':
                            if ((String.Compare(json_string.getData(), 4, "eftField", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_MLBLeftField;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'O':
                            if ((String.Compare(json_string.getData(), 4, "utfield", 0, 7, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_MLBOutfield;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'P':
                            if ((String.Compare(json_string.getData(), 4, "itcher", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_MLBPitcher;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'R':
                            switch (json_string.getData()[4])
                              {
                                case 'e':
                                    if ((String.Compare(json_string.getData(), 5, "liefPitcher", 0, 11, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MLBReliefPitcher;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'i':
                                    if ((String.Compare(json_string.getData(), 5, "ghtField", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MLBRightField;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'S':
                            switch (json_string.getData()[4])
                              {
                                case 'e':
                                    if ((String.Compare(json_string.getData(), 5, "condBase", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MLBSecondBase;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'h':
                                    if ((String.Compare(json_string.getData(), 5, "ortStop", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MLBShortStop;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 't':
                                    if ((String.Compare(json_string.getData(), 5, "artingPitcher", 0, 13, false) == 0) && (json_string.getData().Length == 18))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MLBStartingPitcher;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'T':
                            if ((String.Compare(json_string.getData(), 4, "hirdBase", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_MLBThirdBase;
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
                        if (String.Compare(json_string.getData(), 2, "A", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'C':
                                    if ((String.Compare(json_string.getData(), 4, "enter", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NBACenter;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'P':
                                    if (String.Compare(json_string.getData(), 4, "o", 0, 1, false) == 0)
                                      {
                                        switch (json_string.getData()[5])
                                          {
                                            case 'i':
                                                if ((String.Compare(json_string.getData(), 6, "ntGuard", 0, 7, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NBAPointGuard;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'w':
                                                if ((String.Compare(json_string.getData(), 6, "erForward", 0, 9, false) == 0) && (json_string.getData().Length == 15))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NBAPowerForward;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'S':
                                    switch (json_string.getData()[4])
                                      {
                                        case 'h':
                                            if ((String.Compare(json_string.getData(), 5, "ootingGuard", 0, 11, false) == 0) && (json_string.getData().Length == 16))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NBAShootingGuard;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'm':
                                            if ((String.Compare(json_string.getData(), 5, "allForward", 0, 10, false) == 0) && (json_string.getData().Length == 15))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NBASmallForward;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'U':
                                    if ((String.Compare(json_string.getData(), 4, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NBAUnknown;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'C':
                        if (String.Compare(json_string.getData(), 2, "AA", 0, 2, false) == 0)
                          {
                            switch (json_string.getData()[4])
                              {
                                case 'F':
                                    if (String.Compare(json_string.getData(), 5, "B", 0, 1, false) == 0)
                                      {
                                        switch (json_string.getData()[6])
                                          {
                                            case 'A':
                                                if ((String.Compare(json_string.getData(), 7, "thlete", 0, 6, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBAthlete;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'C':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'e':
                                                        if ((String.Compare(json_string.getData(), 8, "nter", 0, 4, false) == 0) && (json_string.getData().Length == 12))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBCenter;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'o':
                                                        if ((String.Compare(json_string.getData(), 8, "rnerback", 0, 8, false) == 0) && (json_string.getData().Length == 16))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBCornerback;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'D':
                                                if (String.Compare(json_string.getData(), 7, "efensive", 0, 8, false) == 0)
                                                  {
                                                    switch (json_string.getData()[15])
                                                      {
                                                        case 'B':
                                                            if ((String.Compare(json_string.getData(), 16, "ack", 0, 3, false) == 0) && (json_string.getData().Length == 19))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBDefensiveBack;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'E':
                                                            if ((String.Compare(json_string.getData(), 16, "nd", 0, 2, false) == 0) && (json_string.getData().Length == 18))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBDefensiveEnd;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'L':
                                                            if ((String.Compare(json_string.getData(), 16, "ine", 0, 3, false) == 0) && (json_string.getData().Length == 19))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBDefensiveLine;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'T':
                                                            if ((String.Compare(json_string.getData(), 16, "ackle", 0, 5, false) == 0) && (json_string.getData().Length == 21))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBDefensiveTackle;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'F':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'r':
                                                        if ((String.Compare(json_string.getData(), 8, "eeSafety", 0, 8, false) == 0) && (json_string.getData().Length == 16))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFreeSafety;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(json_string.getData(), 8, "llback", 0, 6, false) == 0) && (json_string.getData().Length == 14))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFullback;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'G':
                                                if (String.Compare(json_string.getData(), 7, "eneral", 0, 6, false) == 0)
                                                  {
                                                    switch (json_string.getData()[13])
                                                      {
                                                        case 'D':
                                                            if ((String.Compare(json_string.getData(), 14, "efense", 0, 6, false) == 0) && (json_string.getData().Length == 20))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBGeneralDefense;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'O':
                                                            if ((String.Compare(json_string.getData(), 14, "ffense", 0, 6, false) == 0) && (json_string.getData().Length == 20))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBGeneralOffense;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'S':
                                                            if ((String.Compare(json_string.getData(), 14, "pecialTeams", 0, 11, false) == 0) && (json_string.getData().Length == 25))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBGeneralSpecialTeams;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'K':
                                                if (String.Compare(json_string.getData(), 7, "icker", 0, 5, false) == 0)
                                                  {
                                                    if (json_string.getData().Length == 12)
                                                      {
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBKicker;
                                                            goto open_enum_is_done;
                                                          }
                                                      }
                                                    switch (json_string.getData()[12])
                                                      {
                                                        case 'P':
                                                            if ((String.Compare(json_string.getData(), 13, "unter", 0, 5, false) == 0) && (json_string.getData().Length == 18))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBKickerPunter;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'L':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'i':
                                                        if ((String.Compare(json_string.getData(), 8, "nebacker", 0, 8, false) == 0) && (json_string.getData().Length == 16))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBLinebacker;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'o':
                                                        if ((String.Compare(json_string.getData(), 8, "ngSnapper", 0, 9, false) == 0) && (json_string.getData().Length == 17))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBLongSnapper;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'M':
                                                if ((String.Compare(json_string.getData(), 7, "iddleLinebacker", 0, 15, false) == 0) && (json_string.getData().Length == 22))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBMiddleLinebacker;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'N':
                                                if ((String.Compare(json_string.getData(), 7, "oseTackle", 0, 9, false) == 0) && (json_string.getData().Length == 16))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBNoseTackle;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'O':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'f':
                                                        if (String.Compare(json_string.getData(), 8, "fensive", 0, 7, false) == 0)
                                                          {
                                                            switch (json_string.getData()[15])
                                                              {
                                                                case 'G':
                                                                    if ((String.Compare(json_string.getData(), 16, "uard", 0, 4, false) == 0) && (json_string.getData().Length == 20))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBOffensiveGuard;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'L':
                                                                    if ((String.Compare(json_string.getData(), 16, "ineman", 0, 6, false) == 0) && (json_string.getData().Length == 22))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBOffensiveLineman;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'T':
                                                                    if ((String.Compare(json_string.getData(), 16, "ackle", 0, 5, false) == 0) && (json_string.getData().Length == 21))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBOffensiveTackle;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                          }
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(json_string.getData(), 8, "tsideLinebacker", 0, 15, false) == 0) && (json_string.getData().Length == 23))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBOutsideLinebacker;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'P':
                                                if ((String.Compare(json_string.getData(), 7, "unter", 0, 5, false) == 0) && (json_string.getData().Length == 12))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBPunter;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'Q':
                                                if ((String.Compare(json_string.getData(), 7, "uarterback", 0, 10, false) == 0) && (json_string.getData().Length == 17))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBQuarterback;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'R':
                                                if ((String.Compare(json_string.getData(), 7, "unningBack", 0, 10, false) == 0) && (json_string.getData().Length == 17))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBRunningBack;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'S':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(json_string.getData(), 8, "fety", 0, 4, false) == 0) && (json_string.getData().Length == 12))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBSafety;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 't':
                                                        if ((String.Compare(json_string.getData(), 8, "rongSafety", 0, 10, false) == 0) && (json_string.getData().Length == 18))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBStrongSafety;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'T':
                                                if ((String.Compare(json_string.getData(), 7, "ightEnd", 0, 7, false) == 0) && (json_string.getData().Length == 14))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBTightEnd;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'U':
                                                if ((String.Compare(json_string.getData(), 7, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBUnknown;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'W':
                                                if ((String.Compare(json_string.getData(), 7, "ideReceiver", 0, 11, false) == 0) && (json_string.getData().Length == 18))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBWideReceiver;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'M':
                                    if (String.Compare(json_string.getData(), 5, "B", 0, 1, false) == 0)
                                      {
                                        switch (json_string.getData()[6])
                                          {
                                            case 'C':
                                                if (String.Compare(json_string.getData(), 7, "enter", 0, 5, false) == 0)
                                                  {
                                                    if (json_string.getData().Length == 12)
                                                      {
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBCenter;
                                                            goto open_enum_is_done;
                                                          }
                                                      }
                                                    switch (json_string.getData()[12])
                                                      {
                                                        case 'F':
                                                            if ((String.Compare(json_string.getData(), 13, "orward", 0, 6, false) == 0) && (json_string.getData().Length == 19))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBCenterForward;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'F':
                                                if (String.Compare(json_string.getData(), 7, "orward", 0, 6, false) == 0)
                                                  {
                                                    if (json_string.getData().Length == 13)
                                                      {
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBForward;
                                                            goto open_enum_is_done;
                                                          }
                                                      }
                                                    switch (json_string.getData()[13])
                                                      {
                                                        case 'C':
                                                            if ((String.Compare(json_string.getData(), 14, "enter", 0, 5, false) == 0) && (json_string.getData().Length == 19))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBForwardCenter;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'G':
                                                            if ((String.Compare(json_string.getData(), 14, "uard", 0, 4, false) == 0) && (json_string.getData().Length == 18))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBForwardGuard;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'G':
                                                if (String.Compare(json_string.getData(), 7, "uard", 0, 4, false) == 0)
                                                  {
                                                    if (json_string.getData().Length == 11)
                                                      {
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBGuard;
                                                            goto open_enum_is_done;
                                                          }
                                                      }
                                                    switch (json_string.getData()[11])
                                                      {
                                                        case 'F':
                                                            if ((String.Compare(json_string.getData(), 12, "orward", 0, 6, false) == 0) && (json_string.getData().Length == 18))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBGuardForward;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'U':
                                                if ((String.Compare(json_string.getData(), 7, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBUnknown;
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
                    case 'F':
                        if (String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'C':
                                    switch (json_string.getData()[4])
                                      {
                                        case 'e':
                                            if ((String.Compare(json_string.getData(), 5, "nter", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NFLCenter;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'o':
                                            if ((String.Compare(json_string.getData(), 5, "rnerback", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NFLCornerback;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'D':
                                    if (String.Compare(json_string.getData(), 4, "efensive", 0, 8, false) == 0)
                                      {
                                        switch (json_string.getData()[12])
                                          {
                                            case 'B':
                                                if ((String.Compare(json_string.getData(), 13, "ack", 0, 3, false) == 0) && (json_string.getData().Length == 16))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLDefensiveBack;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'E':
                                                if ((String.Compare(json_string.getData(), 13, "nd", 0, 2, false) == 0) && (json_string.getData().Length == 15))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLDefensiveEnd;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'T':
                                                if ((String.Compare(json_string.getData(), 13, "ackle", 0, 5, false) == 0) && (json_string.getData().Length == 18))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLDefensiveTackle;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'F':
                                    switch (json_string.getData()[4])
                                      {
                                        case 'r':
                                            if ((String.Compare(json_string.getData(), 5, "eeSafety", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NFLFreeSafety;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'u':
                                            if ((String.Compare(json_string.getData(), 5, "llback", 0, 6, false) == 0) && (json_string.getData().Length == 11))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NFLFullback;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'G':
                                    if (String.Compare(json_string.getData(), 4, "eneral", 0, 6, false) == 0)
                                      {
                                        switch (json_string.getData()[10])
                                          {
                                            case 'D':
                                                if (String.Compare(json_string.getData(), 11, "efens", 0, 5, false) == 0)
                                                  {
                                                    switch (json_string.getData()[16])
                                                      {
                                                        case 'e':
                                                            if (json_string.getData().Length == 17)
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NFLGeneralDefense;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'i':
                                                            if ((String.Compare(json_string.getData(), 17, "veLine", 0, 6, false) == 0) && (json_string.getData().Length == 23))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NFLGeneralDefensiveLine;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'O':
                                                if ((String.Compare(json_string.getData(), 11, "ffense", 0, 6, false) == 0) && (json_string.getData().Length == 17))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLGeneralOffense;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'S':
                                                if ((String.Compare(json_string.getData(), 11, "pecialTeams", 0, 11, false) == 0) && (json_string.getData().Length == 22))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLGeneralSpecialTeams;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'K':
                                    if ((String.Compare(json_string.getData(), 4, "icker", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NFLKicker;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'L':
                                    switch (json_string.getData()[4])
                                      {
                                        case 'i':
                                            if ((String.Compare(json_string.getData(), 5, "nebacker", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NFLLinebacker;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'o':
                                            if ((String.Compare(json_string.getData(), 5, "ngSnapper", 0, 9, false) == 0) && (json_string.getData().Length == 14))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NFLLongSnapper;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'M':
                                    if ((String.Compare(json_string.getData(), 4, "iddleLinebacker", 0, 15, false) == 0) && (json_string.getData().Length == 19))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NFLMiddleLinebacker;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'N':
                                    if ((String.Compare(json_string.getData(), 4, "oseTackle", 0, 9, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NFLNoseTackle;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'O':
                                    switch (json_string.getData()[4])
                                      {
                                        case 'f':
                                            if (String.Compare(json_string.getData(), 5, "fensive", 0, 7, false) == 0)
                                              {
                                                switch (json_string.getData()[12])
                                                  {
                                                    case 'G':
                                                        if ((String.Compare(json_string.getData(), 13, "uard", 0, 4, false) == 0) && (json_string.getData().Length == 17))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NFLOffensiveGuard;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'L':
                                                        if ((String.Compare(json_string.getData(), 13, "ineman", 0, 6, false) == 0) && (json_string.getData().Length == 19))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NFLOffensiveLineman;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'T':
                                                        if ((String.Compare(json_string.getData(), 13, "ackle", 0, 5, false) == 0) && (json_string.getData().Length == 18))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NFLOffensiveTackle;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'u':
                                            if ((String.Compare(json_string.getData(), 5, "tsideLinebacker", 0, 15, false) == 0) && (json_string.getData().Length == 20))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NFLOutsideLinebacker;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'P':
                                    if ((String.Compare(json_string.getData(), 4, "unter", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NFLPunter;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'Q':
                                    if ((String.Compare(json_string.getData(), 4, "uarterback", 0, 10, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NFLQuarterback;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'R':
                                    if ((String.Compare(json_string.getData(), 4, "unningBack", 0, 10, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NFLRunningBack;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'S':
                                    switch (json_string.getData()[4])
                                      {
                                        case 'a':
                                            if ((String.Compare(json_string.getData(), 5, "fety", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NFLSafety;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 't':
                                            if ((String.Compare(json_string.getData(), 5, "rongSafety", 0, 10, false) == 0) && (json_string.getData().Length == 15))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NFLStrongSafety;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'T':
                                    if ((String.Compare(json_string.getData(), 4, "ightEnd", 0, 7, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NFLTightEnd;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'U':
                                    if ((String.Compare(json_string.getData(), 4, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NFLUnknown;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'W':
                                    if ((String.Compare(json_string.getData(), 4, "ideReceiver", 0, 11, false) == 0) && (json_string.getData().Length == 15))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NFLWideReceiver;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'H':
                        if (String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'C':
                                    if ((String.Compare(json_string.getData(), 4, "enter", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NHLCenter;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'D':
                                    if ((String.Compare(json_string.getData(), 4, "efense", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NHLDefense;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 4, "orward", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NHLForward;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'G':
                                    if ((String.Compare(json_string.getData(), 4, "oalie", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NHLGoalie;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'L':
                                    if ((String.Compare(json_string.getData(), 4, "eftWing", 0, 7, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NHLLeftWing;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'R':
                                    if ((String.Compare(json_string.getData(), 4, "ightWing", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NHLRightWing;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'U':
                                    if ((String.Compare(json_string.getData(), 4, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NHLUnknown;
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
            case 'S':
                if (String.Compare(json_string.getData(), 1, "occer", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 7, "ttackingMidfielder", 0, 18, false) == 0) && (json_string.getData().Length == 25))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerAttackingMidfielder;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'C':
                            if (String.Compare(json_string.getData(), 7, "enter", 0, 5, false) == 0)
                              {
                                switch (json_string.getData()[12])
                                  {
                                    case 'B':
                                        if ((String.Compare(json_string.getData(), 13, "ack", 0, 3, false) == 0) && (json_string.getData().Length == 16))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerCenterBack;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'F':
                                        if ((String.Compare(json_string.getData(), 13, "orward", 0, 6, false) == 0) && (json_string.getData().Length == 19))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerCenterForward;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'M':
                                        if ((String.Compare(json_string.getData(), 13, "idfielder", 0, 9, false) == 0) && (json_string.getData().Length == 22))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerCenterMidfielder;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'D':
                            if (String.Compare(json_string.getData(), 7, "efen", 0, 4, false) == 0)
                              {
                                switch (json_string.getData()[11])
                                  {
                                    case 'd':
                                        if ((String.Compare(json_string.getData(), 12, "er", 0, 2, false) == 0) && (json_string.getData().Length == 14))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerDefender;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 's':
                                        if ((String.Compare(json_string.getData(), 12, "iveMidfielder", 0, 13, false) == 0) && (json_string.getData().Length == 25))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerDefensiveMidfielder;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'F':
                            switch (json_string.getData()[7])
                              {
                                case 'o':
                                    if ((String.Compare(json_string.getData(), 8, "rward", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_SoccerForward;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'u':
                                    if ((String.Compare(json_string.getData(), 8, "llBack", 0, 6, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_SoccerFullBack;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'G':
                            if ((String.Compare(json_string.getData(), 7, "oalkeeper", 0, 9, false) == 0) && (json_string.getData().Length == 16))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerGoalkeeper;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'I':
                            if (String.Compare(json_string.getData(), 7, "nside", 0, 5, false) == 0)
                              {
                                switch (json_string.getData()[12])
                                  {
                                    case 'L':
                                        if ((String.Compare(json_string.getData(), 13, "eft", 0, 3, false) == 0) && (json_string.getData().Length == 16))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInsideLeft;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'R':
                                        if ((String.Compare(json_string.getData(), 13, "ight", 0, 4, false) == 0) && (json_string.getData().Length == 17))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInsideRight;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'L':
                            if (String.Compare(json_string.getData(), 7, "eft", 0, 3, false) == 0)
                              {
                                switch (json_string.getData()[10])
                                  {
                                    case 'B':
                                        if ((String.Compare(json_string.getData(), 11, "ack", 0, 3, false) == 0) && (json_string.getData().Length == 14))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerLeftBack;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'M':
                                        if ((String.Compare(json_string.getData(), 11, "idfielder", 0, 9, false) == 0) && (json_string.getData().Length == 20))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerLeftMidfielder;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'M':
                            if ((String.Compare(json_string.getData(), 7, "idfielder", 0, 9, false) == 0) && (json_string.getData().Length == 16))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerMidfielder;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'O':
                            if (String.Compare(json_string.getData(), 7, "utside", 0, 6, false) == 0)
                              {
                                switch (json_string.getData()[13])
                                  {
                                    case 'L':
                                        if ((String.Compare(json_string.getData(), 14, "eft", 0, 3, false) == 0) && (json_string.getData().Length == 17))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerOutsideLeft;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'R':
                                        if ((String.Compare(json_string.getData(), 14, "ight", 0, 4, false) == 0) && (json_string.getData().Length == 18))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerOutsideRight;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'R':
                            if (String.Compare(json_string.getData(), 7, "ight", 0, 4, false) == 0)
                              {
                                switch (json_string.getData()[11])
                                  {
                                    case 'B':
                                        if ((String.Compare(json_string.getData(), 12, "ack", 0, 3, false) == 0) && (json_string.getData().Length == 15))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerRightBack;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'M':
                                        if ((String.Compare(json_string.getData(), 12, "idfielder", 0, 9, false) == 0) && (json_string.getData().Length == 21))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerRightMidfielder;
                                                goto open_enum_is_done;
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
                                    if ((String.Compare(json_string.getData(), 8, "condStriker", 0, 11, false) == 0) && (json_string.getData().Length == 19))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_SoccerSecondStriker;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'w':
                                    if ((String.Compare(json_string.getData(), 8, "eeper", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_SoccerSweeper;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'W':
                            if (String.Compare(json_string.getData(), 7, "i", 0, 1, false) == 0)
                              {
                                switch (json_string.getData()[8])
                                  {
                                    case 'd':
                                        if ((String.Compare(json_string.getData(), 9, "eMidfielder", 0, 11, false) == 0) && (json_string.getData().Length == 20))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerWideMidfielder;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'n':
                                        if (String.Compare(json_string.getData(), 9, "g", 0, 1, false) == 0)
                                          {
                                            switch (json_string.getData()[10])
                                              {
                                                case 'B':
                                                    if ((String.Compare(json_string.getData(), 11, "ack", 0, 3, false) == 0) && (json_string.getData().Length == 14))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_SoccerWingBack;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'e':
                                                    if ((String.Compare(json_string.getData(), 11, "r", 0, 1, false) == 0) && (json_string.getData().Length == 12))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_SoccerWinger;
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
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Unknown;
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


    public SportsPlayerPositionJSON()
      {
        flagHasValue = false;
      }

    public SportsPlayerPositionJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public SportsPlayerPositionJSON(string init_value)
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

    public SportsPlayerPositionJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_MLBCatcher:
                    handler.string_value("MLBCatcher");
                    break;
                case TypeValueKnownValues.Value_MLBInfield:
                    handler.string_value("MLBInfield");
                    break;
                case TypeValueKnownValues.Value_MLBFirstBase:
                    handler.string_value("MLBFirstBase");
                    break;
                case TypeValueKnownValues.Value_MLBSecondBase:
                    handler.string_value("MLBSecondBase");
                    break;
                case TypeValueKnownValues.Value_MLBThirdBase:
                    handler.string_value("MLBThirdBase");
                    break;
                case TypeValueKnownValues.Value_MLBShortStop:
                    handler.string_value("MLBShortStop");
                    break;
                case TypeValueKnownValues.Value_MLBOutfield:
                    handler.string_value("MLBOutfield");
                    break;
                case TypeValueKnownValues.Value_MLBLeftField:
                    handler.string_value("MLBLeftField");
                    break;
                case TypeValueKnownValues.Value_MLBCenterField:
                    handler.string_value("MLBCenterField");
                    break;
                case TypeValueKnownValues.Value_MLBPitcher:
                    handler.string_value("MLBPitcher");
                    break;
                case TypeValueKnownValues.Value_MLBRightField:
                    handler.string_value("MLBRightField");
                    break;
                case TypeValueKnownValues.Value_MLBReliefPitcher:
                    handler.string_value("MLBReliefPitcher");
                    break;
                case TypeValueKnownValues.Value_MLBStartingPitcher:
                    handler.string_value("MLBStartingPitcher");
                    break;
                case TypeValueKnownValues.Value_MLBDesignatedHitter:
                    handler.string_value("MLBDesignatedHitter");
                    break;
                case TypeValueKnownValues.Value_NHLUnknown:
                    handler.string_value("NHLUnknown");
                    break;
                case TypeValueKnownValues.Value_NHLCenter:
                    handler.string_value("NHLCenter");
                    break;
                case TypeValueKnownValues.Value_NHLForward:
                    handler.string_value("NHLForward");
                    break;
                case TypeValueKnownValues.Value_NHLDefense:
                    handler.string_value("NHLDefense");
                    break;
                case TypeValueKnownValues.Value_NHLGoalie:
                    handler.string_value("NHLGoalie");
                    break;
                case TypeValueKnownValues.Value_NHLLeftWing:
                    handler.string_value("NHLLeftWing");
                    break;
                case TypeValueKnownValues.Value_NHLRightWing:
                    handler.string_value("NHLRightWing");
                    break;
                case TypeValueKnownValues.Value_NBAUnknown:
                    handler.string_value("NBAUnknown");
                    break;
                case TypeValueKnownValues.Value_NBACenter:
                    handler.string_value("NBACenter");
                    break;
                case TypeValueKnownValues.Value_NBAPowerForward:
                    handler.string_value("NBAPowerForward");
                    break;
                case TypeValueKnownValues.Value_NBAPointGuard:
                    handler.string_value("NBAPointGuard");
                    break;
                case TypeValueKnownValues.Value_NBASmallForward:
                    handler.string_value("NBASmallForward");
                    break;
                case TypeValueKnownValues.Value_NBAShootingGuard:
                    handler.string_value("NBAShootingGuard");
                    break;
                case TypeValueKnownValues.Value_NCAAMBUnknown:
                    handler.string_value("NCAAMBUnknown");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCenter:
                    handler.string_value("NCAAMBCenter");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCenterForward:
                    handler.string_value("NCAAMBCenterForward");
                    break;
                case TypeValueKnownValues.Value_NCAAMBForward:
                    handler.string_value("NCAAMBForward");
                    break;
                case TypeValueKnownValues.Value_NCAAMBForwardCenter:
                    handler.string_value("NCAAMBForwardCenter");
                    break;
                case TypeValueKnownValues.Value_NCAAMBForwardGuard:
                    handler.string_value("NCAAMBForwardGuard");
                    break;
                case TypeValueKnownValues.Value_NCAAMBGuard:
                    handler.string_value("NCAAMBGuard");
                    break;
                case TypeValueKnownValues.Value_NCAAMBGuardForward:
                    handler.string_value("NCAAMBGuardForward");
                    break;
                case TypeValueKnownValues.Value_NFLUnknown:
                    handler.string_value("NFLUnknown");
                    break;
                case TypeValueKnownValues.Value_NFLCenter:
                    handler.string_value("NFLCenter");
                    break;
                case TypeValueKnownValues.Value_NFLFullback:
                    handler.string_value("NFLFullback");
                    break;
                case TypeValueKnownValues.Value_NFLOffensiveGuard:
                    handler.string_value("NFLOffensiveGuard");
                    break;
                case TypeValueKnownValues.Value_NFLOffensiveLineman:
                    handler.string_value("NFLOffensiveLineman");
                    break;
                case TypeValueKnownValues.Value_NFLOffensiveTackle:
                    handler.string_value("NFLOffensiveTackle");
                    break;
                case TypeValueKnownValues.Value_NFLQuarterback:
                    handler.string_value("NFLQuarterback");
                    break;
                case TypeValueKnownValues.Value_NFLRunningBack:
                    handler.string_value("NFLRunningBack");
                    break;
                case TypeValueKnownValues.Value_NFLTightEnd:
                    handler.string_value("NFLTightEnd");
                    break;
                case TypeValueKnownValues.Value_NFLWideReceiver:
                    handler.string_value("NFLWideReceiver");
                    break;
                case TypeValueKnownValues.Value_NFLCornerback:
                    handler.string_value("NFLCornerback");
                    break;
                case TypeValueKnownValues.Value_NFLDefensiveBack:
                    handler.string_value("NFLDefensiveBack");
                    break;
                case TypeValueKnownValues.Value_NFLDefensiveEnd:
                    handler.string_value("NFLDefensiveEnd");
                    break;
                case TypeValueKnownValues.Value_NFLDefensiveTackle:
                    handler.string_value("NFLDefensiveTackle");
                    break;
                case TypeValueKnownValues.Value_NFLFreeSafety:
                    handler.string_value("NFLFreeSafety");
                    break;
                case TypeValueKnownValues.Value_NFLLinebacker:
                    handler.string_value("NFLLinebacker");
                    break;
                case TypeValueKnownValues.Value_NFLMiddleLinebacker:
                    handler.string_value("NFLMiddleLinebacker");
                    break;
                case TypeValueKnownValues.Value_NFLNoseTackle:
                    handler.string_value("NFLNoseTackle");
                    break;
                case TypeValueKnownValues.Value_NFLOutsideLinebacker:
                    handler.string_value("NFLOutsideLinebacker");
                    break;
                case TypeValueKnownValues.Value_NFLSafety:
                    handler.string_value("NFLSafety");
                    break;
                case TypeValueKnownValues.Value_NFLStrongSafety:
                    handler.string_value("NFLStrongSafety");
                    break;
                case TypeValueKnownValues.Value_NFLKicker:
                    handler.string_value("NFLKicker");
                    break;
                case TypeValueKnownValues.Value_NFLLongSnapper:
                    handler.string_value("NFLLongSnapper");
                    break;
                case TypeValueKnownValues.Value_NFLPunter:
                    handler.string_value("NFLPunter");
                    break;
                case TypeValueKnownValues.Value_NFLGeneralDefense:
                    handler.string_value("NFLGeneralDefense");
                    break;
                case TypeValueKnownValues.Value_NFLGeneralDefensiveLine:
                    handler.string_value("NFLGeneralDefensiveLine");
                    break;
                case TypeValueKnownValues.Value_NFLGeneralOffense:
                    handler.string_value("NFLGeneralOffense");
                    break;
                case TypeValueKnownValues.Value_NFLGeneralSpecialTeams:
                    handler.string_value("NFLGeneralSpecialTeams");
                    break;
                case TypeValueKnownValues.Value_NCAAFBUnknown:
                    handler.string_value("NCAAFBUnknown");
                    break;
                case TypeValueKnownValues.Value_NCAAFBCenter:
                    handler.string_value("NCAAFBCenter");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFullback:
                    handler.string_value("NCAAFBFullback");
                    break;
                case TypeValueKnownValues.Value_NCAAFBOffensiveGuard:
                    handler.string_value("NCAAFBOffensiveGuard");
                    break;
                case TypeValueKnownValues.Value_NCAAFBOffensiveLineman:
                    handler.string_value("NCAAFBOffensiveLineman");
                    break;
                case TypeValueKnownValues.Value_NCAAFBOffensiveTackle:
                    handler.string_value("NCAAFBOffensiveTackle");
                    break;
                case TypeValueKnownValues.Value_NCAAFBQuarterback:
                    handler.string_value("NCAAFBQuarterback");
                    break;
                case TypeValueKnownValues.Value_NCAAFBRunningBack:
                    handler.string_value("NCAAFBRunningBack");
                    break;
                case TypeValueKnownValues.Value_NCAAFBTightEnd:
                    handler.string_value("NCAAFBTightEnd");
                    break;
                case TypeValueKnownValues.Value_NCAAFBWideReceiver:
                    handler.string_value("NCAAFBWideReceiver");
                    break;
                case TypeValueKnownValues.Value_NCAAFBCornerback:
                    handler.string_value("NCAAFBCornerback");
                    break;
                case TypeValueKnownValues.Value_NCAAFBDefensiveLine:
                    handler.string_value("NCAAFBDefensiveLine");
                    break;
                case TypeValueKnownValues.Value_NCAAFBDefensiveBack:
                    handler.string_value("NCAAFBDefensiveBack");
                    break;
                case TypeValueKnownValues.Value_NCAAFBDefensiveEnd:
                    handler.string_value("NCAAFBDefensiveEnd");
                    break;
                case TypeValueKnownValues.Value_NCAAFBDefensiveTackle:
                    handler.string_value("NCAAFBDefensiveTackle");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFreeSafety:
                    handler.string_value("NCAAFBFreeSafety");
                    break;
                case TypeValueKnownValues.Value_NCAAFBLinebacker:
                    handler.string_value("NCAAFBLinebacker");
                    break;
                case TypeValueKnownValues.Value_NCAAFBMiddleLinebacker:
                    handler.string_value("NCAAFBMiddleLinebacker");
                    break;
                case TypeValueKnownValues.Value_NCAAFBNoseTackle:
                    handler.string_value("NCAAFBNoseTackle");
                    break;
                case TypeValueKnownValues.Value_NCAAFBOutsideLinebacker:
                    handler.string_value("NCAAFBOutsideLinebacker");
                    break;
                case TypeValueKnownValues.Value_NCAAFBSafety:
                    handler.string_value("NCAAFBSafety");
                    break;
                case TypeValueKnownValues.Value_NCAAFBStrongSafety:
                    handler.string_value("NCAAFBStrongSafety");
                    break;
                case TypeValueKnownValues.Value_NCAAFBKicker:
                    handler.string_value("NCAAFBKicker");
                    break;
                case TypeValueKnownValues.Value_NCAAFBLongSnapper:
                    handler.string_value("NCAAFBLongSnapper");
                    break;
                case TypeValueKnownValues.Value_NCAAFBPunter:
                    handler.string_value("NCAAFBPunter");
                    break;
                case TypeValueKnownValues.Value_NCAAFBKickerPunter:
                    handler.string_value("NCAAFBKickerPunter");
                    break;
                case TypeValueKnownValues.Value_NCAAFBAthlete:
                    handler.string_value("NCAAFBAthlete");
                    break;
                case TypeValueKnownValues.Value_NCAAFBGeneralDefense:
                    handler.string_value("NCAAFBGeneralDefense");
                    break;
                case TypeValueKnownValues.Value_NCAAFBGeneralOffense:
                    handler.string_value("NCAAFBGeneralOffense");
                    break;
                case TypeValueKnownValues.Value_NCAAFBGeneralSpecialTeams:
                    handler.string_value("NCAAFBGeneralSpecialTeams");
                    break;
                case TypeValueKnownValues.Value_SoccerForward:
                    handler.string_value("SoccerForward");
                    break;
                case TypeValueKnownValues.Value_SoccerMidfielder:
                    handler.string_value("SoccerMidfielder");
                    break;
                case TypeValueKnownValues.Value_SoccerDefender:
                    handler.string_value("SoccerDefender");
                    break;
                case TypeValueKnownValues.Value_SoccerGoalkeeper:
                    handler.string_value("SoccerGoalkeeper");
                    break;
                case TypeValueKnownValues.Value_SoccerLeftBack:
                    handler.string_value("SoccerLeftBack");
                    break;
                case TypeValueKnownValues.Value_SoccerRightBack:
                    handler.string_value("SoccerRightBack");
                    break;
                case TypeValueKnownValues.Value_SoccerCenterBack:
                    handler.string_value("SoccerCenterBack");
                    break;
                case TypeValueKnownValues.Value_SoccerFullBack:
                    handler.string_value("SoccerFullBack");
                    break;
                case TypeValueKnownValues.Value_SoccerWingBack:
                    handler.string_value("SoccerWingBack");
                    break;
                case TypeValueKnownValues.Value_SoccerSweeper:
                    handler.string_value("SoccerSweeper");
                    break;
                case TypeValueKnownValues.Value_SoccerCenterMidfielder:
                    handler.string_value("SoccerCenterMidfielder");
                    break;
                case TypeValueKnownValues.Value_SoccerDefensiveMidfielder:
                    handler.string_value("SoccerDefensiveMidfielder");
                    break;
                case TypeValueKnownValues.Value_SoccerAttackingMidfielder:
                    handler.string_value("SoccerAttackingMidfielder");
                    break;
                case TypeValueKnownValues.Value_SoccerWideMidfielder:
                    handler.string_value("SoccerWideMidfielder");
                    break;
                case TypeValueKnownValues.Value_SoccerLeftMidfielder:
                    handler.string_value("SoccerLeftMidfielder");
                    break;
                case TypeValueKnownValues.Value_SoccerRightMidfielder:
                    handler.string_value("SoccerRightMidfielder");
                    break;
                case TypeValueKnownValues.Value_SoccerCenterForward:
                    handler.string_value("SoccerCenterForward");
                    break;
                case TypeValueKnownValues.Value_SoccerSecondStriker:
                    handler.string_value("SoccerSecondStriker");
                    break;
                case TypeValueKnownValues.Value_SoccerInsideLeft:
                    handler.string_value("SoccerInsideLeft");
                    break;
                case TypeValueKnownValues.Value_SoccerInsideRight:
                    handler.string_value("SoccerInsideRight");
                    break;
                case TypeValueKnownValues.Value_SoccerWinger:
                    handler.string_value("SoccerWinger");
                    break;
                case TypeValueKnownValues.Value_SoccerOutsideLeft:
                    handler.string_value("SoccerOutsideLeft");
                    break;
                case TypeValueKnownValues.Value_SoccerOutsideRight:
                    handler.string_value("SoccerOutsideRight");
                    break;
                case TypeValueKnownValues.Value_CricketBatsman:
                    handler.string_value("CricketBatsman");
                    break;
                case TypeValueKnownValues.Value_CricketBowler:
                    handler.string_value("CricketBowler");
                    break;
                case TypeValueKnownValues.Value_CricketAllRounder:
                    handler.string_value("CricketAllRounder");
                    break;
                case TypeValueKnownValues.Value_CricketWicketKeeper:
                    handler.string_value("CricketWicketKeeper");
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
                case TypeValueKnownValues.Value_MLBCatcher:
                    handler.string_value("MLBCatcher");
                    break;
                case TypeValueKnownValues.Value_MLBInfield:
                    handler.string_value("MLBInfield");
                    break;
                case TypeValueKnownValues.Value_MLBFirstBase:
                    handler.string_value("MLBFirstBase");
                    break;
                case TypeValueKnownValues.Value_MLBSecondBase:
                    handler.string_value("MLBSecondBase");
                    break;
                case TypeValueKnownValues.Value_MLBThirdBase:
                    handler.string_value("MLBThirdBase");
                    break;
                case TypeValueKnownValues.Value_MLBShortStop:
                    handler.string_value("MLBShortStop");
                    break;
                case TypeValueKnownValues.Value_MLBOutfield:
                    handler.string_value("MLBOutfield");
                    break;
                case TypeValueKnownValues.Value_MLBLeftField:
                    handler.string_value("MLBLeftField");
                    break;
                case TypeValueKnownValues.Value_MLBCenterField:
                    handler.string_value("MLBCenterField");
                    break;
                case TypeValueKnownValues.Value_MLBPitcher:
                    handler.string_value("MLBPitcher");
                    break;
                case TypeValueKnownValues.Value_MLBRightField:
                    handler.string_value("MLBRightField");
                    break;
                case TypeValueKnownValues.Value_MLBReliefPitcher:
                    handler.string_value("MLBReliefPitcher");
                    break;
                case TypeValueKnownValues.Value_MLBStartingPitcher:
                    handler.string_value("MLBStartingPitcher");
                    break;
                case TypeValueKnownValues.Value_MLBDesignatedHitter:
                    handler.string_value("MLBDesignatedHitter");
                    break;
                case TypeValueKnownValues.Value_NHLUnknown:
                    handler.string_value("NHLUnknown");
                    break;
                case TypeValueKnownValues.Value_NHLCenter:
                    handler.string_value("NHLCenter");
                    break;
                case TypeValueKnownValues.Value_NHLForward:
                    handler.string_value("NHLForward");
                    break;
                case TypeValueKnownValues.Value_NHLDefense:
                    handler.string_value("NHLDefense");
                    break;
                case TypeValueKnownValues.Value_NHLGoalie:
                    handler.string_value("NHLGoalie");
                    break;
                case TypeValueKnownValues.Value_NHLLeftWing:
                    handler.string_value("NHLLeftWing");
                    break;
                case TypeValueKnownValues.Value_NHLRightWing:
                    handler.string_value("NHLRightWing");
                    break;
                case TypeValueKnownValues.Value_NBAUnknown:
                    handler.string_value("NBAUnknown");
                    break;
                case TypeValueKnownValues.Value_NBACenter:
                    handler.string_value("NBACenter");
                    break;
                case TypeValueKnownValues.Value_NBAPowerForward:
                    handler.string_value("NBAPowerForward");
                    break;
                case TypeValueKnownValues.Value_NBAPointGuard:
                    handler.string_value("NBAPointGuard");
                    break;
                case TypeValueKnownValues.Value_NBASmallForward:
                    handler.string_value("NBASmallForward");
                    break;
                case TypeValueKnownValues.Value_NBAShootingGuard:
                    handler.string_value("NBAShootingGuard");
                    break;
                case TypeValueKnownValues.Value_NCAAMBUnknown:
                    handler.string_value("NCAAMBUnknown");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCenter:
                    handler.string_value("NCAAMBCenter");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCenterForward:
                    handler.string_value("NCAAMBCenterForward");
                    break;
                case TypeValueKnownValues.Value_NCAAMBForward:
                    handler.string_value("NCAAMBForward");
                    break;
                case TypeValueKnownValues.Value_NCAAMBForwardCenter:
                    handler.string_value("NCAAMBForwardCenter");
                    break;
                case TypeValueKnownValues.Value_NCAAMBForwardGuard:
                    handler.string_value("NCAAMBForwardGuard");
                    break;
                case TypeValueKnownValues.Value_NCAAMBGuard:
                    handler.string_value("NCAAMBGuard");
                    break;
                case TypeValueKnownValues.Value_NCAAMBGuardForward:
                    handler.string_value("NCAAMBGuardForward");
                    break;
                case TypeValueKnownValues.Value_NFLUnknown:
                    handler.string_value("NFLUnknown");
                    break;
                case TypeValueKnownValues.Value_NFLCenter:
                    handler.string_value("NFLCenter");
                    break;
                case TypeValueKnownValues.Value_NFLFullback:
                    handler.string_value("NFLFullback");
                    break;
                case TypeValueKnownValues.Value_NFLOffensiveGuard:
                    handler.string_value("NFLOffensiveGuard");
                    break;
                case TypeValueKnownValues.Value_NFLOffensiveLineman:
                    handler.string_value("NFLOffensiveLineman");
                    break;
                case TypeValueKnownValues.Value_NFLOffensiveTackle:
                    handler.string_value("NFLOffensiveTackle");
                    break;
                case TypeValueKnownValues.Value_NFLQuarterback:
                    handler.string_value("NFLQuarterback");
                    break;
                case TypeValueKnownValues.Value_NFLRunningBack:
                    handler.string_value("NFLRunningBack");
                    break;
                case TypeValueKnownValues.Value_NFLTightEnd:
                    handler.string_value("NFLTightEnd");
                    break;
                case TypeValueKnownValues.Value_NFLWideReceiver:
                    handler.string_value("NFLWideReceiver");
                    break;
                case TypeValueKnownValues.Value_NFLCornerback:
                    handler.string_value("NFLCornerback");
                    break;
                case TypeValueKnownValues.Value_NFLDefensiveBack:
                    handler.string_value("NFLDefensiveBack");
                    break;
                case TypeValueKnownValues.Value_NFLDefensiveEnd:
                    handler.string_value("NFLDefensiveEnd");
                    break;
                case TypeValueKnownValues.Value_NFLDefensiveTackle:
                    handler.string_value("NFLDefensiveTackle");
                    break;
                case TypeValueKnownValues.Value_NFLFreeSafety:
                    handler.string_value("NFLFreeSafety");
                    break;
                case TypeValueKnownValues.Value_NFLLinebacker:
                    handler.string_value("NFLLinebacker");
                    break;
                case TypeValueKnownValues.Value_NFLMiddleLinebacker:
                    handler.string_value("NFLMiddleLinebacker");
                    break;
                case TypeValueKnownValues.Value_NFLNoseTackle:
                    handler.string_value("NFLNoseTackle");
                    break;
                case TypeValueKnownValues.Value_NFLOutsideLinebacker:
                    handler.string_value("NFLOutsideLinebacker");
                    break;
                case TypeValueKnownValues.Value_NFLSafety:
                    handler.string_value("NFLSafety");
                    break;
                case TypeValueKnownValues.Value_NFLStrongSafety:
                    handler.string_value("NFLStrongSafety");
                    break;
                case TypeValueKnownValues.Value_NFLKicker:
                    handler.string_value("NFLKicker");
                    break;
                case TypeValueKnownValues.Value_NFLLongSnapper:
                    handler.string_value("NFLLongSnapper");
                    break;
                case TypeValueKnownValues.Value_NFLPunter:
                    handler.string_value("NFLPunter");
                    break;
                case TypeValueKnownValues.Value_NFLGeneralDefense:
                    handler.string_value("NFLGeneralDefense");
                    break;
                case TypeValueKnownValues.Value_NFLGeneralDefensiveLine:
                    handler.string_value("NFLGeneralDefensiveLine");
                    break;
                case TypeValueKnownValues.Value_NFLGeneralOffense:
                    handler.string_value("NFLGeneralOffense");
                    break;
                case TypeValueKnownValues.Value_NFLGeneralSpecialTeams:
                    handler.string_value("NFLGeneralSpecialTeams");
                    break;
                case TypeValueKnownValues.Value_NCAAFBUnknown:
                    handler.string_value("NCAAFBUnknown");
                    break;
                case TypeValueKnownValues.Value_NCAAFBCenter:
                    handler.string_value("NCAAFBCenter");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFullback:
                    handler.string_value("NCAAFBFullback");
                    break;
                case TypeValueKnownValues.Value_NCAAFBOffensiveGuard:
                    handler.string_value("NCAAFBOffensiveGuard");
                    break;
                case TypeValueKnownValues.Value_NCAAFBOffensiveLineman:
                    handler.string_value("NCAAFBOffensiveLineman");
                    break;
                case TypeValueKnownValues.Value_NCAAFBOffensiveTackle:
                    handler.string_value("NCAAFBOffensiveTackle");
                    break;
                case TypeValueKnownValues.Value_NCAAFBQuarterback:
                    handler.string_value("NCAAFBQuarterback");
                    break;
                case TypeValueKnownValues.Value_NCAAFBRunningBack:
                    handler.string_value("NCAAFBRunningBack");
                    break;
                case TypeValueKnownValues.Value_NCAAFBTightEnd:
                    handler.string_value("NCAAFBTightEnd");
                    break;
                case TypeValueKnownValues.Value_NCAAFBWideReceiver:
                    handler.string_value("NCAAFBWideReceiver");
                    break;
                case TypeValueKnownValues.Value_NCAAFBCornerback:
                    handler.string_value("NCAAFBCornerback");
                    break;
                case TypeValueKnownValues.Value_NCAAFBDefensiveLine:
                    handler.string_value("NCAAFBDefensiveLine");
                    break;
                case TypeValueKnownValues.Value_NCAAFBDefensiveBack:
                    handler.string_value("NCAAFBDefensiveBack");
                    break;
                case TypeValueKnownValues.Value_NCAAFBDefensiveEnd:
                    handler.string_value("NCAAFBDefensiveEnd");
                    break;
                case TypeValueKnownValues.Value_NCAAFBDefensiveTackle:
                    handler.string_value("NCAAFBDefensiveTackle");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFreeSafety:
                    handler.string_value("NCAAFBFreeSafety");
                    break;
                case TypeValueKnownValues.Value_NCAAFBLinebacker:
                    handler.string_value("NCAAFBLinebacker");
                    break;
                case TypeValueKnownValues.Value_NCAAFBMiddleLinebacker:
                    handler.string_value("NCAAFBMiddleLinebacker");
                    break;
                case TypeValueKnownValues.Value_NCAAFBNoseTackle:
                    handler.string_value("NCAAFBNoseTackle");
                    break;
                case TypeValueKnownValues.Value_NCAAFBOutsideLinebacker:
                    handler.string_value("NCAAFBOutsideLinebacker");
                    break;
                case TypeValueKnownValues.Value_NCAAFBSafety:
                    handler.string_value("NCAAFBSafety");
                    break;
                case TypeValueKnownValues.Value_NCAAFBStrongSafety:
                    handler.string_value("NCAAFBStrongSafety");
                    break;
                case TypeValueKnownValues.Value_NCAAFBKicker:
                    handler.string_value("NCAAFBKicker");
                    break;
                case TypeValueKnownValues.Value_NCAAFBLongSnapper:
                    handler.string_value("NCAAFBLongSnapper");
                    break;
                case TypeValueKnownValues.Value_NCAAFBPunter:
                    handler.string_value("NCAAFBPunter");
                    break;
                case TypeValueKnownValues.Value_NCAAFBKickerPunter:
                    handler.string_value("NCAAFBKickerPunter");
                    break;
                case TypeValueKnownValues.Value_NCAAFBAthlete:
                    handler.string_value("NCAAFBAthlete");
                    break;
                case TypeValueKnownValues.Value_NCAAFBGeneralDefense:
                    handler.string_value("NCAAFBGeneralDefense");
                    break;
                case TypeValueKnownValues.Value_NCAAFBGeneralOffense:
                    handler.string_value("NCAAFBGeneralOffense");
                    break;
                case TypeValueKnownValues.Value_NCAAFBGeneralSpecialTeams:
                    handler.string_value("NCAAFBGeneralSpecialTeams");
                    break;
                case TypeValueKnownValues.Value_SoccerForward:
                    handler.string_value("SoccerForward");
                    break;
                case TypeValueKnownValues.Value_SoccerMidfielder:
                    handler.string_value("SoccerMidfielder");
                    break;
                case TypeValueKnownValues.Value_SoccerDefender:
                    handler.string_value("SoccerDefender");
                    break;
                case TypeValueKnownValues.Value_SoccerGoalkeeper:
                    handler.string_value("SoccerGoalkeeper");
                    break;
                case TypeValueKnownValues.Value_SoccerLeftBack:
                    handler.string_value("SoccerLeftBack");
                    break;
                case TypeValueKnownValues.Value_SoccerRightBack:
                    handler.string_value("SoccerRightBack");
                    break;
                case TypeValueKnownValues.Value_SoccerCenterBack:
                    handler.string_value("SoccerCenterBack");
                    break;
                case TypeValueKnownValues.Value_SoccerFullBack:
                    handler.string_value("SoccerFullBack");
                    break;
                case TypeValueKnownValues.Value_SoccerWingBack:
                    handler.string_value("SoccerWingBack");
                    break;
                case TypeValueKnownValues.Value_SoccerSweeper:
                    handler.string_value("SoccerSweeper");
                    break;
                case TypeValueKnownValues.Value_SoccerCenterMidfielder:
                    handler.string_value("SoccerCenterMidfielder");
                    break;
                case TypeValueKnownValues.Value_SoccerDefensiveMidfielder:
                    handler.string_value("SoccerDefensiveMidfielder");
                    break;
                case TypeValueKnownValues.Value_SoccerAttackingMidfielder:
                    handler.string_value("SoccerAttackingMidfielder");
                    break;
                case TypeValueKnownValues.Value_SoccerWideMidfielder:
                    handler.string_value("SoccerWideMidfielder");
                    break;
                case TypeValueKnownValues.Value_SoccerLeftMidfielder:
                    handler.string_value("SoccerLeftMidfielder");
                    break;
                case TypeValueKnownValues.Value_SoccerRightMidfielder:
                    handler.string_value("SoccerRightMidfielder");
                    break;
                case TypeValueKnownValues.Value_SoccerCenterForward:
                    handler.string_value("SoccerCenterForward");
                    break;
                case TypeValueKnownValues.Value_SoccerSecondStriker:
                    handler.string_value("SoccerSecondStriker");
                    break;
                case TypeValueKnownValues.Value_SoccerInsideLeft:
                    handler.string_value("SoccerInsideLeft");
                    break;
                case TypeValueKnownValues.Value_SoccerInsideRight:
                    handler.string_value("SoccerInsideRight");
                    break;
                case TypeValueKnownValues.Value_SoccerWinger:
                    handler.string_value("SoccerWinger");
                    break;
                case TypeValueKnownValues.Value_SoccerOutsideLeft:
                    handler.string_value("SoccerOutsideLeft");
                    break;
                case TypeValueKnownValues.Value_SoccerOutsideRight:
                    handler.string_value("SoccerOutsideRight");
                    break;
                case TypeValueKnownValues.Value_CricketBatsman:
                    handler.string_value("CricketBatsman");
                    break;
                case TypeValueKnownValues.Value_CricketBowler:
                    handler.string_value("CricketBowler");
                    break;
                case TypeValueKnownValues.Value_CricketAllRounder:
                    handler.string_value("CricketAllRounder");
                    break;
                case TypeValueKnownValues.Value_CricketWicketKeeper:
                    handler.string_value("CricketWicketKeeper");
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

    public static SportsPlayerPositionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayerPositionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayerPosition", ignore_extras);
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
    public static SportsPlayerPositionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayerPositionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayerPositionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayerPosition", ignore_extras);
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
    public static SportsPlayerPositionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayerPositionJSON from_text(string text, bool ignore_extras)
      {
        SportsPlayerPositionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayerPosition", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsPlayerPositionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsPlayerPositionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsPlayerPositionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayerPosition", ignore_extras);
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
            SportsPlayerPositionJSON result = new SportsPlayerPositionJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(SportsPlayerPositionJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsPlayerPosition")
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
        protected override void handle_result(SportsPlayerPositionJSON  result)
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
        public SportsPlayerPositionJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsPlayerPositionJSON  result)
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
    protected virtual void handle_result(List<SportsPlayerPositionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsPlayerPositionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsPlayerPositionJSON>();
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
    public List<SportsPlayerPositionJSON> value;
  };
  };
