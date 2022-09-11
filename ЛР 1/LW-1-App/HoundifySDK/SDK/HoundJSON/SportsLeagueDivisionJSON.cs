/* file "SportsLeagueDivisionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsLeagueDivisionJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_MLBAmericanLeague,
        Value_MLBAmericanLeagueEast,
        Value_MLBAmericanLeagueCentral,
        Value_MLBAmericanLeagueWest,
        Value_MLBNationalLeague,
        Value_MLBNationalLeagueEast,
        Value_MLBNationalLeagueCentral,
        Value_MLBNationalLeagueWest,
        Value_NBAEastern,
        Value_NBAEasternAtlantic,
        Value_NBAEasternCentral,
        Value_NBAEasternSoutheast,
        Value_NBAWestern,
        Value_NBAWesternNorthwest,
        Value_NBAWesternPacific,
        Value_NBAWesternSouthwest,
        Value_NFLAFC,
        Value_NFLAFCEast,
        Value_NFLAFCNorth,
        Value_NFLAFCSouth,
        Value_NFLAFCWest,
        Value_NFLNFC,
        Value_NFLNFCEast,
        Value_NFLNFCNorth,
        Value_NFLNFCSouth,
        Value_NFLNFCWest,
        Value_NHLEastern,
        Value_NHLEasternMetropolitan,
        Value_NHLEasternAtlantic,
        Value_NHLWestern,
        Value_NHLWesternCentral,
        Value_NHLWesternPacific,
        Value_NHLNorth,
        Value_NHLEast,
        Value_NHLCentral,
        Value_NHLWest,
        Value_NCAAMBDivisionI,
        Value_NCAAMBDivisionIAmericaEast,
        Value_NCAAMBDivisionIAmericanAthleticConference,
        Value_NCAAMBDivisionIAtlantic10,
        Value_NCAAMBDivisionIAtlanticCoast,
        Value_NCAAMBDivisionIAtlanticSun,
        Value_NCAAMBDivisionIBig12,
        Value_NCAAMBDivisionIBigEast,
        Value_NCAAMBDivisionIBigSky,
        Value_NCAAMBDivisionIBigSouth,
        Value_NCAAMBDivisionIBig10,
        Value_NCAAMBDivisionIBigWest,
        Value_NCAAMBDivisionIColonialAthleticAssociation,
        Value_NCAAMBDivisionIConferenceUSA,
        Value_NCAAMBDivisionIHorizon,
        Value_NCAAMBDivisionIIvyLeague,
        Value_NCAAMBDivisionIMetroAtlanticAthletic,
        Value_NCAAMBDivisionIMidAmerican,
        Value_NCAAMBDivisionIMidAmericanWest,
        Value_NCAAMBDivisionIMidAmericanEast,
        Value_NCAAMBDivisionIMidEastern,
        Value_NCAAMBDivisionIMissouriValley,
        Value_NCAAMBDivisionIMountainWest,
        Value_NCAAMBDivisionINortheast,
        Value_NCAAMBDivisionIOhioValley,
        Value_NCAAMBDivisionIOhioValleyWest,
        Value_NCAAMBDivisionIOhioValleyEast,
        Value_NCAAMBDivisionIPac12,
        Value_NCAAMBDivisionIPatriotLeague,
        Value_NCAAMBDivisionISoutheastern,
        Value_NCAAMBDivisionISouthern,
        Value_NCAAMBDivisionISouthland,
        Value_NCAAMBDivisionISouthwesternAtlantic,
        Value_NCAAMBDivisionISummitLeague,
        Value_NCAAMBDivisionISunBelt,
        Value_NCAAMBDivisionIWestCoast,
        Value_NCAAMBDivisionIWesternAthletic,
        Value_NCAAFBFBS,
        Value_NCAAFBFBSAtlanticCoast,
        Value_NCAAFBFBSAtlanticCoastAtlantic,
        Value_NCAAFBFBSAtlanticCoastCoastal,
        Value_NCAAFBFBSAmericanAthleticConference,
        Value_NCAAFBFBSAmericanAthleticConferenceWest,
        Value_NCAAFBFBSAmericanAthleticConferenceEast,
        Value_NCAAFBFBSBig12,
        Value_NCAAFBFBSBig10,
        Value_NCAAFBFBSBig10East,
        Value_NCAAFBFBSBig10West,
        Value_NCAAFBFBSConferenceUSA,
        Value_NCAAFBFBSConferenceUSAWest,
        Value_NCAAFBFBSConferenceUSAEast,
        Value_NCAAFBFBSIndependents,
        Value_NCAAFBFBSMidAmerican,
        Value_NCAAFBFBSMidAmericanWest,
        Value_NCAAFBFBSMidAmericanEast,
        Value_NCAAFBFBSMountainWest,
        Value_NCAAFBFBSMountainWestMountain,
        Value_NCAAFBFBSMountainWestWest,
        Value_NCAAFBFBSPac12,
        Value_NCAAFBFBSPac12North,
        Value_NCAAFBFBSPac12South,
        Value_NCAAFBFBSSoutheastern,
        Value_NCAAFBFBSSoutheasternWest,
        Value_NCAAFBFBSSoutheasternEast,
        Value_NCAAFBFBSSunBelt,
        Value_NCAAFBFBSSunBeltEast,
        Value_NCAAFBFBSSunBeltWest,
        Value_NCAAFBFCS,
        Value_NCAAFBFCSBigSky,
        Value_NCAAFBFCSBigSouth,
        Value_NCAAFBFCSColonialAthleticAssociation,
        Value_NCAAFBFCSIndependents,
        Value_NCAAFBFCSIvyLeague,
        Value_NCAAFBFCSMidEasternAthletic,
        Value_NCAAFBFCSMissouriValley,
        Value_NCAAFBFCSNortheast,
        Value_NCAAFBFCSOhioValley,
        Value_NCAAFBFCSPatriotLeague,
        Value_NCAAFBFCSPioneerLeague,
        Value_NCAAFBFCSSouthern,
        Value_NCAAFBFCSSouthland,
        Value_NCAAFBFCSSouthwesternAthletic,
        Value_NCAAFBFCSSouthwesternAthleticEast,
        Value_NCAAFBFCSSouthwesternAthleticWest,
        Value_NCAAFBFCSWesternAthletic,
        Value_MLSEastern,
        Value_MLSWestern,
        Value_CFLWest,
        Value_CFLEast,
        Value_MensWorldCupGroupStage,
        Value_MensWorldCupGroupA,
        Value_MensWorldCupGroupB,
        Value_MensWorldCupGroupC,
        Value_MensWorldCupGroupD,
        Value_MensWorldCupGroupE,
        Value_MensWorldCupGroupF,
        Value_MensWorldCupGroupG,
        Value_MensWorldCupGroupH,
        Value_NPBCentral,
        Value_NPBPacific,
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
                if (String.Compare(chars, 1, "FL", 0, 2, false) == 0)
                  {
                    switch (chars[3])
                      {
                        case 'E':
                            if ((String.Compare(chars, 4, "ast", 0, 3, false) == 0) && (chars.Length == 7))
                                return TypeValueKnownValues.Value_CFLEast;
                            break;
                        case 'W':
                            if ((String.Compare(chars, 4, "est", 0, 3, false) == 0) && (chars.Length == 7))
                                return TypeValueKnownValues.Value_CFLWest;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                switch (chars[1])
                  {
                    case 'L':
                        switch (chars[2])
                          {
                            case 'B':
                                switch (chars[3])
                                  {
                                    case 'A':
                                        if (String.Compare(chars, 4, "mericanLeague", 0, 13, false) == 0)
                                          {
                                            if (chars.Length == 17)
                                              {
                                                return TypeValueKnownValues.Value_MLBAmericanLeague;
                                              }
                                            switch (chars[17])
                                              {
                                                case 'C':
                                                    if ((String.Compare(chars, 18, "entral", 0, 6, false) == 0) && (chars.Length == 24))
                                                        return TypeValueKnownValues.Value_MLBAmericanLeagueCentral;
                                                    break;
                                                case 'E':
                                                    if ((String.Compare(chars, 18, "ast", 0, 3, false) == 0) && (chars.Length == 21))
                                                        return TypeValueKnownValues.Value_MLBAmericanLeagueEast;
                                                    break;
                                                case 'W':
                                                    if ((String.Compare(chars, 18, "est", 0, 3, false) == 0) && (chars.Length == 21))
                                                        return TypeValueKnownValues.Value_MLBAmericanLeagueWest;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'N':
                                        if (String.Compare(chars, 4, "ationalLeague", 0, 13, false) == 0)
                                          {
                                            if (chars.Length == 17)
                                              {
                                                return TypeValueKnownValues.Value_MLBNationalLeague;
                                              }
                                            switch (chars[17])
                                              {
                                                case 'C':
                                                    if ((String.Compare(chars, 18, "entral", 0, 6, false) == 0) && (chars.Length == 24))
                                                        return TypeValueKnownValues.Value_MLBNationalLeagueCentral;
                                                    break;
                                                case 'E':
                                                    if ((String.Compare(chars, 18, "ast", 0, 3, false) == 0) && (chars.Length == 21))
                                                        return TypeValueKnownValues.Value_MLBNationalLeagueEast;
                                                    break;
                                                case 'W':
                                                    if ((String.Compare(chars, 18, "est", 0, 3, false) == 0) && (chars.Length == 21))
                                                        return TypeValueKnownValues.Value_MLBNationalLeagueWest;
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
                                switch (chars[3])
                                  {
                                    case 'E':
                                        if ((String.Compare(chars, 4, "astern", 0, 6, false) == 0) && (chars.Length == 10))
                                            return TypeValueKnownValues.Value_MLSEastern;
                                        break;
                                    case 'W':
                                        if ((String.Compare(chars, 4, "estern", 0, 6, false) == 0) && (chars.Length == 10))
                                            return TypeValueKnownValues.Value_MLSWestern;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if (String.Compare(chars, 2, "nsWorldCupGroup", 0, 15, false) == 0)
                          {
                            switch (chars[17])
                              {
                                case 'A':
                                    if (chars.Length == 18)
                                        return TypeValueKnownValues.Value_MensWorldCupGroupA;
                                    break;
                                case 'B':
                                    if (chars.Length == 18)
                                        return TypeValueKnownValues.Value_MensWorldCupGroupB;
                                    break;
                                case 'C':
                                    if (chars.Length == 18)
                                        return TypeValueKnownValues.Value_MensWorldCupGroupC;
                                    break;
                                case 'D':
                                    if (chars.Length == 18)
                                        return TypeValueKnownValues.Value_MensWorldCupGroupD;
                                    break;
                                case 'E':
                                    if (chars.Length == 18)
                                        return TypeValueKnownValues.Value_MensWorldCupGroupE;
                                    break;
                                case 'F':
                                    if (chars.Length == 18)
                                        return TypeValueKnownValues.Value_MensWorldCupGroupF;
                                    break;
                                case 'G':
                                    if (chars.Length == 18)
                                        return TypeValueKnownValues.Value_MensWorldCupGroupG;
                                    break;
                                case 'H':
                                    if (chars.Length == 18)
                                        return TypeValueKnownValues.Value_MensWorldCupGroupH;
                                    break;
                                case 'S':
                                    if ((String.Compare(chars, 18, "tage", 0, 4, false) == 0) && (chars.Length == 22))
                                        return TypeValueKnownValues.Value_MensWorldCupGroupStage;
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
            case 'N':
                switch (chars[1])
                  {
                    case 'B':
                        if (String.Compare(chars, 2, "A", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'E':
                                    if (String.Compare(chars, 4, "astern", 0, 6, false) == 0)
                                      {
                                        if (chars.Length == 10)
                                          {
                                            return TypeValueKnownValues.Value_NBAEastern;
                                          }
                                        switch (chars[10])
                                          {
                                            case 'A':
                                                if ((String.Compare(chars, 11, "tlantic", 0, 7, false) == 0) && (chars.Length == 18))
                                                    return TypeValueKnownValues.Value_NBAEasternAtlantic;
                                                break;
                                            case 'C':
                                                if ((String.Compare(chars, 11, "entral", 0, 6, false) == 0) && (chars.Length == 17))
                                                    return TypeValueKnownValues.Value_NBAEasternCentral;
                                                break;
                                            case 'S':
                                                if ((String.Compare(chars, 11, "outheast", 0, 8, false) == 0) && (chars.Length == 19))
                                                    return TypeValueKnownValues.Value_NBAEasternSoutheast;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'W':
                                    if (String.Compare(chars, 4, "estern", 0, 6, false) == 0)
                                      {
                                        if (chars.Length == 10)
                                          {
                                            return TypeValueKnownValues.Value_NBAWestern;
                                          }
                                        switch (chars[10])
                                          {
                                            case 'N':
                                                if ((String.Compare(chars, 11, "orthwest", 0, 8, false) == 0) && (chars.Length == 19))
                                                    return TypeValueKnownValues.Value_NBAWesternNorthwest;
                                                break;
                                            case 'P':
                                                if ((String.Compare(chars, 11, "acific", 0, 6, false) == 0) && (chars.Length == 17))
                                                    return TypeValueKnownValues.Value_NBAWesternPacific;
                                                break;
                                            case 'S':
                                                if ((String.Compare(chars, 11, "outhwest", 0, 8, false) == 0) && (chars.Length == 19))
                                                    return TypeValueKnownValues.Value_NBAWesternSouthwest;
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
                    case 'C':
                        if (String.Compare(chars, 2, "AA", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'F':
                                    if (String.Compare(chars, 5, "BF", 0, 2, false) == 0)
                                      {
                                        switch (chars[7])
                                          {
                                            case 'B':
                                                if (String.Compare(chars, 8, "S", 0, 1, false) == 0)
                                                  {
                                                    if (chars.Length == 9)
                                                      {
                                                        return TypeValueKnownValues.Value_NCAAFBFBS;
                                                      }
                                                    switch (chars[9])
                                                      {
                                                        case 'A':
                                                            switch (chars[10])
                                                              {
                                                                case 'm':
                                                                    if (String.Compare(chars, 11, "ericanAthleticConference", 0, 24, false) == 0)
                                                                      {
                                                                        if (chars.Length == 35)
                                                                          {
                                                                            return TypeValueKnownValues.Value_NCAAFBFBSAmericanAthleticConference;
                                                                          }
                                                                        switch (chars[35])
                                                                          {
                                                                            case 'E':
                                                                                if ((String.Compare(chars, 36, "ast", 0, 3, false) == 0) && (chars.Length == 39))
                                                                                    return TypeValueKnownValues.Value_NCAAFBFBSAmericanAthleticConferenceEast;
                                                                                break;
                                                                            case 'W':
                                                                                if ((String.Compare(chars, 36, "est", 0, 3, false) == 0) && (chars.Length == 39))
                                                                                    return TypeValueKnownValues.Value_NCAAFBFBSAmericanAthleticConferenceWest;
                                                                                break;
                                                                            default:
                                                                                break;
                                                                          }
                                                                      }
                                                                    break;
                                                                case 't':
                                                                    if (String.Compare(chars, 11, "lanticCoast", 0, 11, false) == 0)
                                                                      {
                                                                        if (chars.Length == 22)
                                                                          {
                                                                            return TypeValueKnownValues.Value_NCAAFBFBSAtlanticCoast;
                                                                          }
                                                                        switch (chars[22])
                                                                          {
                                                                            case 'A':
                                                                                if ((String.Compare(chars, 23, "tlantic", 0, 7, false) == 0) && (chars.Length == 30))
                                                                                    return TypeValueKnownValues.Value_NCAAFBFBSAtlanticCoastAtlantic;
                                                                                break;
                                                                            case 'C':
                                                                                if ((String.Compare(chars, 23, "oastal", 0, 6, false) == 0) && (chars.Length == 29))
                                                                                    return TypeValueKnownValues.Value_NCAAFBFBSAtlanticCoastCoastal;
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
                                                        case 'B':
                                                            if (String.Compare(chars, 10, "ig1", 0, 3, false) == 0)
                                                              {
                                                                switch (chars[13])
                                                                  {
                                                                    case '0':
                                                                        if (chars.Length == 14)
                                                                          {
                                                                            return TypeValueKnownValues.Value_NCAAFBFBSBig10;
                                                                          }
                                                                        switch (chars[14])
                                                                          {
                                                                            case 'E':
                                                                                if ((String.Compare(chars, 15, "ast", 0, 3, false) == 0) && (chars.Length == 18))
                                                                                    return TypeValueKnownValues.Value_NCAAFBFBSBig10East;
                                                                                break;
                                                                            case 'W':
                                                                                if ((String.Compare(chars, 15, "est", 0, 3, false) == 0) && (chars.Length == 18))
                                                                                    return TypeValueKnownValues.Value_NCAAFBFBSBig10West;
                                                                                break;
                                                                            default:
                                                                                break;
                                                                          }
                                                                        break;
                                                                    case '2':
                                                                        if (chars.Length == 14)
                                                                            return TypeValueKnownValues.Value_NCAAFBFBSBig12;
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                              }
                                                            break;
                                                        case 'C':
                                                            if (String.Compare(chars, 10, "onferenceUSA", 0, 12, false) == 0)
                                                              {
                                                                if (chars.Length == 22)
                                                                  {
                                                                    return TypeValueKnownValues.Value_NCAAFBFBSConferenceUSA;
                                                                  }
                                                                switch (chars[22])
                                                                  {
                                                                    case 'E':
                                                                        if ((String.Compare(chars, 23, "ast", 0, 3, false) == 0) && (chars.Length == 26))
                                                                            return TypeValueKnownValues.Value_NCAAFBFBSConferenceUSAEast;
                                                                        break;
                                                                    case 'W':
                                                                        if ((String.Compare(chars, 23, "est", 0, 3, false) == 0) && (chars.Length == 26))
                                                                            return TypeValueKnownValues.Value_NCAAFBFBSConferenceUSAWest;
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                              }
                                                            break;
                                                        case 'I':
                                                            if ((String.Compare(chars, 10, "ndependents", 0, 11, false) == 0) && (chars.Length == 21))
                                                                return TypeValueKnownValues.Value_NCAAFBFBSIndependents;
                                                            break;
                                                        case 'M':
                                                            switch (chars[10])
                                                              {
                                                                case 'i':
                                                                    if (String.Compare(chars, 11, "dAmerican", 0, 9, false) == 0)
                                                                      {
                                                                        if (chars.Length == 20)
                                                                          {
                                                                            return TypeValueKnownValues.Value_NCAAFBFBSMidAmerican;
                                                                          }
                                                                        switch (chars[20])
                                                                          {
                                                                            case 'E':
                                                                                if ((String.Compare(chars, 21, "ast", 0, 3, false) == 0) && (chars.Length == 24))
                                                                                    return TypeValueKnownValues.Value_NCAAFBFBSMidAmericanEast;
                                                                                break;
                                                                            case 'W':
                                                                                if ((String.Compare(chars, 21, "est", 0, 3, false) == 0) && (chars.Length == 24))
                                                                                    return TypeValueKnownValues.Value_NCAAFBFBSMidAmericanWest;
                                                                                break;
                                                                            default:
                                                                                break;
                                                                          }
                                                                      }
                                                                    break;
                                                                case 'o':
                                                                    if (String.Compare(chars, 11, "untainWest", 0, 10, false) == 0)
                                                                      {
                                                                        if (chars.Length == 21)
                                                                          {
                                                                            return TypeValueKnownValues.Value_NCAAFBFBSMountainWest;
                                                                          }
                                                                        switch (chars[21])
                                                                          {
                                                                            case 'M':
                                                                                if ((String.Compare(chars, 22, "ountain", 0, 7, false) == 0) && (chars.Length == 29))
                                                                                    return TypeValueKnownValues.Value_NCAAFBFBSMountainWestMountain;
                                                                                break;
                                                                            case 'W':
                                                                                if ((String.Compare(chars, 22, "est", 0, 3, false) == 0) && (chars.Length == 25))
                                                                                    return TypeValueKnownValues.Value_NCAAFBFBSMountainWestWest;
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
                                                            if (String.Compare(chars, 10, "ac12", 0, 4, false) == 0)
                                                              {
                                                                if (chars.Length == 14)
                                                                  {
                                                                    return TypeValueKnownValues.Value_NCAAFBFBSPac12;
                                                                  }
                                                                switch (chars[14])
                                                                  {
                                                                    case 'N':
                                                                        if ((String.Compare(chars, 15, "orth", 0, 4, false) == 0) && (chars.Length == 19))
                                                                            return TypeValueKnownValues.Value_NCAAFBFBSPac12North;
                                                                        break;
                                                                    case 'S':
                                                                        if ((String.Compare(chars, 15, "outh", 0, 4, false) == 0) && (chars.Length == 19))
                                                                            return TypeValueKnownValues.Value_NCAAFBFBSPac12South;
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                              }
                                                            break;
                                                        case 'S':
                                                            switch (chars[10])
                                                              {
                                                                case 'o':
                                                                    if (String.Compare(chars, 11, "utheastern", 0, 10, false) == 0)
                                                                      {
                                                                        if (chars.Length == 21)
                                                                          {
                                                                            return TypeValueKnownValues.Value_NCAAFBFBSSoutheastern;
                                                                          }
                                                                        switch (chars[21])
                                                                          {
                                                                            case 'E':
                                                                                if ((String.Compare(chars, 22, "ast", 0, 3, false) == 0) && (chars.Length == 25))
                                                                                    return TypeValueKnownValues.Value_NCAAFBFBSSoutheasternEast;
                                                                                break;
                                                                            case 'W':
                                                                                if ((String.Compare(chars, 22, "est", 0, 3, false) == 0) && (chars.Length == 25))
                                                                                    return TypeValueKnownValues.Value_NCAAFBFBSSoutheasternWest;
                                                                                break;
                                                                            default:
                                                                                break;
                                                                          }
                                                                      }
                                                                    break;
                                                                case 'u':
                                                                    if (String.Compare(chars, 11, "nBelt", 0, 5, false) == 0)
                                                                      {
                                                                        if (chars.Length == 16)
                                                                          {
                                                                            return TypeValueKnownValues.Value_NCAAFBFBSSunBelt;
                                                                          }
                                                                        switch (chars[16])
                                                                          {
                                                                            case 'E':
                                                                                if ((String.Compare(chars, 17, "ast", 0, 3, false) == 0) && (chars.Length == 20))
                                                                                    return TypeValueKnownValues.Value_NCAAFBFBSSunBeltEast;
                                                                                break;
                                                                            case 'W':
                                                                                if ((String.Compare(chars, 17, "est", 0, 3, false) == 0) && (chars.Length == 20))
                                                                                    return TypeValueKnownValues.Value_NCAAFBFBSSunBeltWest;
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
                                            case 'C':
                                                if (String.Compare(chars, 8, "S", 0, 1, false) == 0)
                                                  {
                                                    if (chars.Length == 9)
                                                      {
                                                        return TypeValueKnownValues.Value_NCAAFBFCS;
                                                      }
                                                    switch (chars[9])
                                                      {
                                                        case 'B':
                                                            if (String.Compare(chars, 10, "igS", 0, 3, false) == 0)
                                                              {
                                                                switch (chars[13])
                                                                  {
                                                                    case 'k':
                                                                        if ((String.Compare(chars, 14, "y", 0, 1, false) == 0) && (chars.Length == 15))
                                                                            return TypeValueKnownValues.Value_NCAAFBFCSBigSky;
                                                                        break;
                                                                    case 'o':
                                                                        if ((String.Compare(chars, 14, "uth", 0, 3, false) == 0) && (chars.Length == 17))
                                                                            return TypeValueKnownValues.Value_NCAAFBFCSBigSouth;
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                              }
                                                            break;
                                                        case 'C':
                                                            if ((String.Compare(chars, 10, "olonialAthleticAssociation", 0, 26, false) == 0) && (chars.Length == 36))
                                                                return TypeValueKnownValues.Value_NCAAFBFCSColonialAthleticAssociation;
                                                            break;
                                                        case 'I':
                                                            switch (chars[10])
                                                              {
                                                                case 'n':
                                                                    if ((String.Compare(chars, 11, "dependents", 0, 10, false) == 0) && (chars.Length == 21))
                                                                        return TypeValueKnownValues.Value_NCAAFBFCSIndependents;
                                                                    break;
                                                                case 'v':
                                                                    if ((String.Compare(chars, 11, "yLeague", 0, 7, false) == 0) && (chars.Length == 18))
                                                                        return TypeValueKnownValues.Value_NCAAFBFCSIvyLeague;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'M':
                                                            if (String.Compare(chars, 10, "i", 0, 1, false) == 0)
                                                              {
                                                                switch (chars[11])
                                                                  {
                                                                    case 'd':
                                                                        if ((String.Compare(chars, 12, "EasternAthletic", 0, 15, false) == 0) && (chars.Length == 27))
                                                                            return TypeValueKnownValues.Value_NCAAFBFCSMidEasternAthletic;
                                                                        break;
                                                                    case 's':
                                                                        if ((String.Compare(chars, 12, "souriValley", 0, 11, false) == 0) && (chars.Length == 23))
                                                                            return TypeValueKnownValues.Value_NCAAFBFCSMissouriValley;
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                              }
                                                            break;
                                                        case 'N':
                                                            if ((String.Compare(chars, 10, "ortheast", 0, 8, false) == 0) && (chars.Length == 18))
                                                                return TypeValueKnownValues.Value_NCAAFBFCSNortheast;
                                                            break;
                                                        case 'O':
                                                            if ((String.Compare(chars, 10, "hioValley", 0, 9, false) == 0) && (chars.Length == 19))
                                                                return TypeValueKnownValues.Value_NCAAFBFCSOhioValley;
                                                            break;
                                                        case 'P':
                                                            switch (chars[10])
                                                              {
                                                                case 'a':
                                                                    if ((String.Compare(chars, 11, "triotLeague", 0, 11, false) == 0) && (chars.Length == 22))
                                                                        return TypeValueKnownValues.Value_NCAAFBFCSPatriotLeague;
                                                                    break;
                                                                case 'i':
                                                                    if ((String.Compare(chars, 11, "oneerLeague", 0, 11, false) == 0) && (chars.Length == 22))
                                                                        return TypeValueKnownValues.Value_NCAAFBFCSPioneerLeague;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'S':
                                                            if (String.Compare(chars, 10, "outh", 0, 4, false) == 0)
                                                              {
                                                                switch (chars[14])
                                                                  {
                                                                    case 'e':
                                                                        if ((String.Compare(chars, 15, "rn", 0, 2, false) == 0) && (chars.Length == 17))
                                                                            return TypeValueKnownValues.Value_NCAAFBFCSSouthern;
                                                                        break;
                                                                    case 'l':
                                                                        if ((String.Compare(chars, 15, "and", 0, 3, false) == 0) && (chars.Length == 18))
                                                                            return TypeValueKnownValues.Value_NCAAFBFCSSouthland;
                                                                        break;
                                                                    case 'w':
                                                                        if (String.Compare(chars, 15, "esternAthletic", 0, 14, false) == 0)
                                                                          {
                                                                            if (chars.Length == 29)
                                                                              {
                                                                                return TypeValueKnownValues.Value_NCAAFBFCSSouthwesternAthletic;
                                                                              }
                                                                            switch (chars[29])
                                                                              {
                                                                                case 'E':
                                                                                    if ((String.Compare(chars, 30, "ast", 0, 3, false) == 0) && (chars.Length == 33))
                                                                                        return TypeValueKnownValues.Value_NCAAFBFCSSouthwesternAthleticEast;
                                                                                    break;
                                                                                case 'W':
                                                                                    if ((String.Compare(chars, 30, "est", 0, 3, false) == 0) && (chars.Length == 33))
                                                                                        return TypeValueKnownValues.Value_NCAAFBFCSSouthwesternAthleticWest;
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
                                                        case 'W':
                                                            if ((String.Compare(chars, 10, "esternAthletic", 0, 14, false) == 0) && (chars.Length == 24))
                                                                return TypeValueKnownValues.Value_NCAAFBFCSWesternAthletic;
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
                                case 'M':
                                    if (String.Compare(chars, 5, "BDivisionI", 0, 10, false) == 0)
                                      {
                                        if (chars.Length == 15)
                                          {
                                            return TypeValueKnownValues.Value_NCAAMBDivisionI;
                                          }
                                        switch (chars[15])
                                          {
                                            case 'A':
                                                switch (chars[16])
                                                  {
                                                    case 'm':
                                                        if (String.Compare(chars, 17, "erica", 0, 5, false) == 0)
                                                          {
                                                            switch (chars[22])
                                                              {
                                                                case 'E':
                                                                    if ((String.Compare(chars, 23, "ast", 0, 3, false) == 0) && (chars.Length == 26))
                                                                        return TypeValueKnownValues.Value_NCAAMBDivisionIAmericaEast;
                                                                    break;
                                                                case 'n':
                                                                    if ((String.Compare(chars, 23, "AthleticConference", 0, 18, false) == 0) && (chars.Length == 41))
                                                                        return TypeValueKnownValues.Value_NCAAMBDivisionIAmericanAthleticConference;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                          }
                                                        break;
                                                    case 't':
                                                        if (String.Compare(chars, 17, "lantic", 0, 6, false) == 0)
                                                          {
                                                            switch (chars[23])
                                                              {
                                                                case '1':
                                                                    if ((String.Compare(chars, 24, "0", 0, 1, false) == 0) && (chars.Length == 25))
                                                                        return TypeValueKnownValues.Value_NCAAMBDivisionIAtlantic10;
                                                                    break;
                                                                case 'C':
                                                                    if ((String.Compare(chars, 24, "oast", 0, 4, false) == 0) && (chars.Length == 28))
                                                                        return TypeValueKnownValues.Value_NCAAMBDivisionIAtlanticCoast;
                                                                    break;
                                                                case 'S':
                                                                    if ((String.Compare(chars, 24, "un", 0, 2, false) == 0) && (chars.Length == 26))
                                                                        return TypeValueKnownValues.Value_NCAAMBDivisionIAtlanticSun;
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
                                            case 'B':
                                                if (String.Compare(chars, 16, "ig", 0, 2, false) == 0)
                                                  {
                                                    switch (chars[18])
                                                      {
                                                        case '1':
                                                            switch (chars[19])
                                                              {
                                                                case '0':
                                                                    if (chars.Length == 20)
                                                                        return TypeValueKnownValues.Value_NCAAMBDivisionIBig10;
                                                                    break;
                                                                case '2':
                                                                    if (chars.Length == 20)
                                                                        return TypeValueKnownValues.Value_NCAAMBDivisionIBig12;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'E':
                                                            if ((String.Compare(chars, 19, "ast", 0, 3, false) == 0) && (chars.Length == 22))
                                                                return TypeValueKnownValues.Value_NCAAMBDivisionIBigEast;
                                                            break;
                                                        case 'S':
                                                            switch (chars[19])
                                                              {
                                                                case 'k':
                                                                    if ((String.Compare(chars, 20, "y", 0, 1, false) == 0) && (chars.Length == 21))
                                                                        return TypeValueKnownValues.Value_NCAAMBDivisionIBigSky;
                                                                    break;
                                                                case 'o':
                                                                    if ((String.Compare(chars, 20, "uth", 0, 3, false) == 0) && (chars.Length == 23))
                                                                        return TypeValueKnownValues.Value_NCAAMBDivisionIBigSouth;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(chars, 19, "est", 0, 3, false) == 0) && (chars.Length == 22))
                                                                return TypeValueKnownValues.Value_NCAAMBDivisionIBigWest;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'C':
                                                if (String.Compare(chars, 16, "o", 0, 1, false) == 0)
                                                  {
                                                    switch (chars[17])
                                                      {
                                                        case 'l':
                                                            if ((String.Compare(chars, 18, "onialAthleticAssociation", 0, 24, false) == 0) && (chars.Length == 42))
                                                                return TypeValueKnownValues.Value_NCAAMBDivisionIColonialAthleticAssociation;
                                                            break;
                                                        case 'n':
                                                            if ((String.Compare(chars, 18, "ferenceUSA", 0, 10, false) == 0) && (chars.Length == 28))
                                                                return TypeValueKnownValues.Value_NCAAMBDivisionIConferenceUSA;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'H':
                                                if ((String.Compare(chars, 16, "orizon", 0, 6, false) == 0) && (chars.Length == 22))
                                                    return TypeValueKnownValues.Value_NCAAMBDivisionIHorizon;
                                                break;
                                            case 'I':
                                                if ((String.Compare(chars, 16, "vyLeague", 0, 8, false) == 0) && (chars.Length == 24))
                                                    return TypeValueKnownValues.Value_NCAAMBDivisionIIvyLeague;
                                                break;
                                            case 'M':
                                                switch (chars[16])
                                                  {
                                                    case 'e':
                                                        if ((String.Compare(chars, 17, "troAtlanticAthletic", 0, 19, false) == 0) && (chars.Length == 36))
                                                            return TypeValueKnownValues.Value_NCAAMBDivisionIMetroAtlanticAthletic;
                                                        break;
                                                    case 'i':
                                                        switch (chars[17])
                                                          {
                                                            case 'd':
                                                                switch (chars[18])
                                                                  {
                                                                    case 'A':
                                                                        if (String.Compare(chars, 19, "merican", 0, 7, false) == 0)
                                                                          {
                                                                            if (chars.Length == 26)
                                                                              {
                                                                                return TypeValueKnownValues.Value_NCAAMBDivisionIMidAmerican;
                                                                              }
                                                                            switch (chars[26])
                                                                              {
                                                                                case 'E':
                                                                                    if ((String.Compare(chars, 27, "ast", 0, 3, false) == 0) && (chars.Length == 30))
                                                                                        return TypeValueKnownValues.Value_NCAAMBDivisionIMidAmericanEast;
                                                                                    break;
                                                                                case 'W':
                                                                                    if ((String.Compare(chars, 27, "est", 0, 3, false) == 0) && (chars.Length == 30))
                                                                                        return TypeValueKnownValues.Value_NCAAMBDivisionIMidAmericanWest;
                                                                                    break;
                                                                                default:
                                                                                    break;
                                                                              }
                                                                          }
                                                                        break;
                                                                    case 'E':
                                                                        if ((String.Compare(chars, 19, "astern", 0, 6, false) == 0) && (chars.Length == 25))
                                                                            return TypeValueKnownValues.Value_NCAAMBDivisionIMidEastern;
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                                break;
                                                            case 's':
                                                                if ((String.Compare(chars, 18, "souriValley", 0, 11, false) == 0) && (chars.Length == 29))
                                                                    return TypeValueKnownValues.Value_NCAAMBDivisionIMissouriValley;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'o':
                                                        if ((String.Compare(chars, 17, "untainWest", 0, 10, false) == 0) && (chars.Length == 27))
                                                            return TypeValueKnownValues.Value_NCAAMBDivisionIMountainWest;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'N':
                                                if ((String.Compare(chars, 16, "ortheast", 0, 8, false) == 0) && (chars.Length == 24))
                                                    return TypeValueKnownValues.Value_NCAAMBDivisionINortheast;
                                                break;
                                            case 'O':
                                                if (String.Compare(chars, 16, "hioValley", 0, 9, false) == 0)
                                                  {
                                                    if (chars.Length == 25)
                                                      {
                                                        return TypeValueKnownValues.Value_NCAAMBDivisionIOhioValley;
                                                      }
                                                    switch (chars[25])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(chars, 26, "ast", 0, 3, false) == 0) && (chars.Length == 29))
                                                                return TypeValueKnownValues.Value_NCAAMBDivisionIOhioValleyEast;
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(chars, 26, "est", 0, 3, false) == 0) && (chars.Length == 29))
                                                                return TypeValueKnownValues.Value_NCAAMBDivisionIOhioValleyWest;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'P':
                                                if (String.Compare(chars, 16, "a", 0, 1, false) == 0)
                                                  {
                                                    switch (chars[17])
                                                      {
                                                        case 'c':
                                                            if ((String.Compare(chars, 18, "12", 0, 2, false) == 0) && (chars.Length == 20))
                                                                return TypeValueKnownValues.Value_NCAAMBDivisionIPac12;
                                                            break;
                                                        case 't':
                                                            if ((String.Compare(chars, 18, "riotLeague", 0, 10, false) == 0) && (chars.Length == 28))
                                                                return TypeValueKnownValues.Value_NCAAMBDivisionIPatriotLeague;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'S':
                                                switch (chars[16])
                                                  {
                                                    case 'o':
                                                        if (String.Compare(chars, 17, "uth", 0, 3, false) == 0)
                                                          {
                                                            switch (chars[20])
                                                              {
                                                                case 'e':
                                                                    switch (chars[21])
                                                                      {
                                                                        case 'a':
                                                                            if ((String.Compare(chars, 22, "stern", 0, 5, false) == 0) && (chars.Length == 27))
                                                                                return TypeValueKnownValues.Value_NCAAMBDivisionISoutheastern;
                                                                            break;
                                                                        case 'r':
                                                                            if ((String.Compare(chars, 22, "n", 0, 1, false) == 0) && (chars.Length == 23))
                                                                                return TypeValueKnownValues.Value_NCAAMBDivisionISouthern;
                                                                            break;
                                                                        default:
                                                                            break;
                                                                      }
                                                                    break;
                                                                case 'l':
                                                                    if ((String.Compare(chars, 21, "and", 0, 3, false) == 0) && (chars.Length == 24))
                                                                        return TypeValueKnownValues.Value_NCAAMBDivisionISouthland;
                                                                    break;
                                                                case 'w':
                                                                    if ((String.Compare(chars, 21, "esternAtlantic", 0, 14, false) == 0) && (chars.Length == 35))
                                                                        return TypeValueKnownValues.Value_NCAAMBDivisionISouthwesternAtlantic;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                          }
                                                        break;
                                                    case 'u':
                                                        switch (chars[17])
                                                          {
                                                            case 'm':
                                                                if ((String.Compare(chars, 18, "mitLeague", 0, 9, false) == 0) && (chars.Length == 27))
                                                                    return TypeValueKnownValues.Value_NCAAMBDivisionISummitLeague;
                                                                break;
                                                            case 'n':
                                                                if ((String.Compare(chars, 18, "Belt", 0, 4, false) == 0) && (chars.Length == 22))
                                                                    return TypeValueKnownValues.Value_NCAAMBDivisionISunBelt;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'W':
                                                if (String.Compare(chars, 16, "est", 0, 3, false) == 0)
                                                  {
                                                    switch (chars[19])
                                                      {
                                                        case 'C':
                                                            if ((String.Compare(chars, 20, "oast", 0, 4, false) == 0) && (chars.Length == 24))
                                                                return TypeValueKnownValues.Value_NCAAMBDivisionIWestCoast;
                                                            break;
                                                        case 'e':
                                                            if ((String.Compare(chars, 20, "rnAthletic", 0, 10, false) == 0) && (chars.Length == 30))
                                                                return TypeValueKnownValues.Value_NCAAMBDivisionIWesternAthletic;
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
                    case 'F':
                        if (String.Compare(chars, 2, "L", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'A':
                                    if (String.Compare(chars, 4, "FC", 0, 2, false) == 0)
                                      {
                                        if (chars.Length == 6)
                                          {
                                            return TypeValueKnownValues.Value_NFLAFC;
                                          }
                                        switch (chars[6])
                                          {
                                            case 'E':
                                                if ((String.Compare(chars, 7, "ast", 0, 3, false) == 0) && (chars.Length == 10))
                                                    return TypeValueKnownValues.Value_NFLAFCEast;
                                                break;
                                            case 'N':
                                                if ((String.Compare(chars, 7, "orth", 0, 4, false) == 0) && (chars.Length == 11))
                                                    return TypeValueKnownValues.Value_NFLAFCNorth;
                                                break;
                                            case 'S':
                                                if ((String.Compare(chars, 7, "outh", 0, 4, false) == 0) && (chars.Length == 11))
                                                    return TypeValueKnownValues.Value_NFLAFCSouth;
                                                break;
                                            case 'W':
                                                if ((String.Compare(chars, 7, "est", 0, 3, false) == 0) && (chars.Length == 10))
                                                    return TypeValueKnownValues.Value_NFLAFCWest;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'N':
                                    if (String.Compare(chars, 4, "FC", 0, 2, false) == 0)
                                      {
                                        if (chars.Length == 6)
                                          {
                                            return TypeValueKnownValues.Value_NFLNFC;
                                          }
                                        switch (chars[6])
                                          {
                                            case 'E':
                                                if ((String.Compare(chars, 7, "ast", 0, 3, false) == 0) && (chars.Length == 10))
                                                    return TypeValueKnownValues.Value_NFLNFCEast;
                                                break;
                                            case 'N':
                                                if ((String.Compare(chars, 7, "orth", 0, 4, false) == 0) && (chars.Length == 11))
                                                    return TypeValueKnownValues.Value_NFLNFCNorth;
                                                break;
                                            case 'S':
                                                if ((String.Compare(chars, 7, "outh", 0, 4, false) == 0) && (chars.Length == 11))
                                                    return TypeValueKnownValues.Value_NFLNFCSouth;
                                                break;
                                            case 'W':
                                                if ((String.Compare(chars, 7, "est", 0, 3, false) == 0) && (chars.Length == 10))
                                                    return TypeValueKnownValues.Value_NFLNFCWest;
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
                    case 'H':
                        if (String.Compare(chars, 2, "L", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'C':
                                    if ((String.Compare(chars, 4, "entral", 0, 6, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_NHLCentral;
                                    break;
                                case 'E':
                                    if (String.Compare(chars, 4, "ast", 0, 3, false) == 0)
                                      {
                                        if (chars.Length == 7)
                                          {
                                            return TypeValueKnownValues.Value_NHLEast;
                                          }
                                        switch (chars[7])
                                          {
                                            case 'e':
                                                if (String.Compare(chars, 8, "rn", 0, 2, false) == 0)
                                                  {
                                                    if (chars.Length == 10)
                                                      {
                                                        return TypeValueKnownValues.Value_NHLEastern;
                                                      }
                                                    switch (chars[10])
                                                      {
                                                        case 'A':
                                                            if ((String.Compare(chars, 11, "tlantic", 0, 7, false) == 0) && (chars.Length == 18))
                                                                return TypeValueKnownValues.Value_NHLEasternAtlantic;
                                                            break;
                                                        case 'M':
                                                            if ((String.Compare(chars, 11, "etropolitan", 0, 11, false) == 0) && (chars.Length == 22))
                                                                return TypeValueKnownValues.Value_NHLEasternMetropolitan;
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
                                case 'N':
                                    if ((String.Compare(chars, 4, "orth", 0, 4, false) == 0) && (chars.Length == 8))
                                        return TypeValueKnownValues.Value_NHLNorth;
                                    break;
                                case 'W':
                                    if (String.Compare(chars, 4, "est", 0, 3, false) == 0)
                                      {
                                        if (chars.Length == 7)
                                          {
                                            return TypeValueKnownValues.Value_NHLWest;
                                          }
                                        switch (chars[7])
                                          {
                                            case 'e':
                                                if (String.Compare(chars, 8, "rn", 0, 2, false) == 0)
                                                  {
                                                    if (chars.Length == 10)
                                                      {
                                                        return TypeValueKnownValues.Value_NHLWestern;
                                                      }
                                                    switch (chars[10])
                                                      {
                                                        case 'C':
                                                            if ((String.Compare(chars, 11, "entral", 0, 6, false) == 0) && (chars.Length == 17))
                                                                return TypeValueKnownValues.Value_NHLWesternCentral;
                                                            break;
                                                        case 'P':
                                                            if ((String.Compare(chars, 11, "acific", 0, 6, false) == 0) && (chars.Length == 17))
                                                                return TypeValueKnownValues.Value_NHLWesternPacific;
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
                    case 'P':
                        if (String.Compare(chars, 2, "B", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'C':
                                    if ((String.Compare(chars, 4, "entral", 0, 6, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_NPBCentral;
                                    break;
                                case 'P':
                                    if ((String.Compare(chars, 4, "acific", 0, 6, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_NPBPacific;
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
        return TypeValueKnownValues.Value__none;
      }

    public static string  stringFromValue(TypeValueKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeValueKnownValues.Value_MLBAmericanLeague:
                return "MLBAmericanLeague";
            case TypeValueKnownValues.Value_MLBAmericanLeagueEast:
                return "MLBAmericanLeagueEast";
            case TypeValueKnownValues.Value_MLBAmericanLeagueCentral:
                return "MLBAmericanLeagueCentral";
            case TypeValueKnownValues.Value_MLBAmericanLeagueWest:
                return "MLBAmericanLeagueWest";
            case TypeValueKnownValues.Value_MLBNationalLeague:
                return "MLBNationalLeague";
            case TypeValueKnownValues.Value_MLBNationalLeagueEast:
                return "MLBNationalLeagueEast";
            case TypeValueKnownValues.Value_MLBNationalLeagueCentral:
                return "MLBNationalLeagueCentral";
            case TypeValueKnownValues.Value_MLBNationalLeagueWest:
                return "MLBNationalLeagueWest";
            case TypeValueKnownValues.Value_NBAEastern:
                return "NBAEastern";
            case TypeValueKnownValues.Value_NBAEasternAtlantic:
                return "NBAEasternAtlantic";
            case TypeValueKnownValues.Value_NBAEasternCentral:
                return "NBAEasternCentral";
            case TypeValueKnownValues.Value_NBAEasternSoutheast:
                return "NBAEasternSoutheast";
            case TypeValueKnownValues.Value_NBAWestern:
                return "NBAWestern";
            case TypeValueKnownValues.Value_NBAWesternNorthwest:
                return "NBAWesternNorthwest";
            case TypeValueKnownValues.Value_NBAWesternPacific:
                return "NBAWesternPacific";
            case TypeValueKnownValues.Value_NBAWesternSouthwest:
                return "NBAWesternSouthwest";
            case TypeValueKnownValues.Value_NFLAFC:
                return "NFLAFC";
            case TypeValueKnownValues.Value_NFLAFCEast:
                return "NFLAFCEast";
            case TypeValueKnownValues.Value_NFLAFCNorth:
                return "NFLAFCNorth";
            case TypeValueKnownValues.Value_NFLAFCSouth:
                return "NFLAFCSouth";
            case TypeValueKnownValues.Value_NFLAFCWest:
                return "NFLAFCWest";
            case TypeValueKnownValues.Value_NFLNFC:
                return "NFLNFC";
            case TypeValueKnownValues.Value_NFLNFCEast:
                return "NFLNFCEast";
            case TypeValueKnownValues.Value_NFLNFCNorth:
                return "NFLNFCNorth";
            case TypeValueKnownValues.Value_NFLNFCSouth:
                return "NFLNFCSouth";
            case TypeValueKnownValues.Value_NFLNFCWest:
                return "NFLNFCWest";
            case TypeValueKnownValues.Value_NHLEastern:
                return "NHLEastern";
            case TypeValueKnownValues.Value_NHLEasternMetropolitan:
                return "NHLEasternMetropolitan";
            case TypeValueKnownValues.Value_NHLEasternAtlantic:
                return "NHLEasternAtlantic";
            case TypeValueKnownValues.Value_NHLWestern:
                return "NHLWestern";
            case TypeValueKnownValues.Value_NHLWesternCentral:
                return "NHLWesternCentral";
            case TypeValueKnownValues.Value_NHLWesternPacific:
                return "NHLWesternPacific";
            case TypeValueKnownValues.Value_NHLNorth:
                return "NHLNorth";
            case TypeValueKnownValues.Value_NHLEast:
                return "NHLEast";
            case TypeValueKnownValues.Value_NHLCentral:
                return "NHLCentral";
            case TypeValueKnownValues.Value_NHLWest:
                return "NHLWest";
            case TypeValueKnownValues.Value_NCAAMBDivisionI:
                return "NCAAMBDivisionI";
            case TypeValueKnownValues.Value_NCAAMBDivisionIAmericaEast:
                return "NCAAMBDivisionIAmericaEast";
            case TypeValueKnownValues.Value_NCAAMBDivisionIAmericanAthleticConference:
                return "NCAAMBDivisionIAmericanAthleticConference";
            case TypeValueKnownValues.Value_NCAAMBDivisionIAtlantic10:
                return "NCAAMBDivisionIAtlantic10";
            case TypeValueKnownValues.Value_NCAAMBDivisionIAtlanticCoast:
                return "NCAAMBDivisionIAtlanticCoast";
            case TypeValueKnownValues.Value_NCAAMBDivisionIAtlanticSun:
                return "NCAAMBDivisionIAtlanticSun";
            case TypeValueKnownValues.Value_NCAAMBDivisionIBig12:
                return "NCAAMBDivisionIBig12";
            case TypeValueKnownValues.Value_NCAAMBDivisionIBigEast:
                return "NCAAMBDivisionIBigEast";
            case TypeValueKnownValues.Value_NCAAMBDivisionIBigSky:
                return "NCAAMBDivisionIBigSky";
            case TypeValueKnownValues.Value_NCAAMBDivisionIBigSouth:
                return "NCAAMBDivisionIBigSouth";
            case TypeValueKnownValues.Value_NCAAMBDivisionIBig10:
                return "NCAAMBDivisionIBig10";
            case TypeValueKnownValues.Value_NCAAMBDivisionIBigWest:
                return "NCAAMBDivisionIBigWest";
            case TypeValueKnownValues.Value_NCAAMBDivisionIColonialAthleticAssociation:
                return "NCAAMBDivisionIColonialAthleticAssociation";
            case TypeValueKnownValues.Value_NCAAMBDivisionIConferenceUSA:
                return "NCAAMBDivisionIConferenceUSA";
            case TypeValueKnownValues.Value_NCAAMBDivisionIHorizon:
                return "NCAAMBDivisionIHorizon";
            case TypeValueKnownValues.Value_NCAAMBDivisionIIvyLeague:
                return "NCAAMBDivisionIIvyLeague";
            case TypeValueKnownValues.Value_NCAAMBDivisionIMetroAtlanticAthletic:
                return "NCAAMBDivisionIMetroAtlanticAthletic";
            case TypeValueKnownValues.Value_NCAAMBDivisionIMidAmerican:
                return "NCAAMBDivisionIMidAmerican";
            case TypeValueKnownValues.Value_NCAAMBDivisionIMidAmericanWest:
                return "NCAAMBDivisionIMidAmericanWest";
            case TypeValueKnownValues.Value_NCAAMBDivisionIMidAmericanEast:
                return "NCAAMBDivisionIMidAmericanEast";
            case TypeValueKnownValues.Value_NCAAMBDivisionIMidEastern:
                return "NCAAMBDivisionIMidEastern";
            case TypeValueKnownValues.Value_NCAAMBDivisionIMissouriValley:
                return "NCAAMBDivisionIMissouriValley";
            case TypeValueKnownValues.Value_NCAAMBDivisionIMountainWest:
                return "NCAAMBDivisionIMountainWest";
            case TypeValueKnownValues.Value_NCAAMBDivisionINortheast:
                return "NCAAMBDivisionINortheast";
            case TypeValueKnownValues.Value_NCAAMBDivisionIOhioValley:
                return "NCAAMBDivisionIOhioValley";
            case TypeValueKnownValues.Value_NCAAMBDivisionIOhioValleyWest:
                return "NCAAMBDivisionIOhioValleyWest";
            case TypeValueKnownValues.Value_NCAAMBDivisionIOhioValleyEast:
                return "NCAAMBDivisionIOhioValleyEast";
            case TypeValueKnownValues.Value_NCAAMBDivisionIPac12:
                return "NCAAMBDivisionIPac12";
            case TypeValueKnownValues.Value_NCAAMBDivisionIPatriotLeague:
                return "NCAAMBDivisionIPatriotLeague";
            case TypeValueKnownValues.Value_NCAAMBDivisionISoutheastern:
                return "NCAAMBDivisionISoutheastern";
            case TypeValueKnownValues.Value_NCAAMBDivisionISouthern:
                return "NCAAMBDivisionISouthern";
            case TypeValueKnownValues.Value_NCAAMBDivisionISouthland:
                return "NCAAMBDivisionISouthland";
            case TypeValueKnownValues.Value_NCAAMBDivisionISouthwesternAtlantic:
                return "NCAAMBDivisionISouthwesternAtlantic";
            case TypeValueKnownValues.Value_NCAAMBDivisionISummitLeague:
                return "NCAAMBDivisionISummitLeague";
            case TypeValueKnownValues.Value_NCAAMBDivisionISunBelt:
                return "NCAAMBDivisionISunBelt";
            case TypeValueKnownValues.Value_NCAAMBDivisionIWestCoast:
                return "NCAAMBDivisionIWestCoast";
            case TypeValueKnownValues.Value_NCAAMBDivisionIWesternAthletic:
                return "NCAAMBDivisionIWesternAthletic";
            case TypeValueKnownValues.Value_NCAAFBFBS:
                return "NCAAFBFBS";
            case TypeValueKnownValues.Value_NCAAFBFBSAtlanticCoast:
                return "NCAAFBFBSAtlanticCoast";
            case TypeValueKnownValues.Value_NCAAFBFBSAtlanticCoastAtlantic:
                return "NCAAFBFBSAtlanticCoastAtlantic";
            case TypeValueKnownValues.Value_NCAAFBFBSAtlanticCoastCoastal:
                return "NCAAFBFBSAtlanticCoastCoastal";
            case TypeValueKnownValues.Value_NCAAFBFBSAmericanAthleticConference:
                return "NCAAFBFBSAmericanAthleticConference";
            case TypeValueKnownValues.Value_NCAAFBFBSAmericanAthleticConferenceWest:
                return "NCAAFBFBSAmericanAthleticConferenceWest";
            case TypeValueKnownValues.Value_NCAAFBFBSAmericanAthleticConferenceEast:
                return "NCAAFBFBSAmericanAthleticConferenceEast";
            case TypeValueKnownValues.Value_NCAAFBFBSBig12:
                return "NCAAFBFBSBig12";
            case TypeValueKnownValues.Value_NCAAFBFBSBig10:
                return "NCAAFBFBSBig10";
            case TypeValueKnownValues.Value_NCAAFBFBSBig10East:
                return "NCAAFBFBSBig10East";
            case TypeValueKnownValues.Value_NCAAFBFBSBig10West:
                return "NCAAFBFBSBig10West";
            case TypeValueKnownValues.Value_NCAAFBFBSConferenceUSA:
                return "NCAAFBFBSConferenceUSA";
            case TypeValueKnownValues.Value_NCAAFBFBSConferenceUSAWest:
                return "NCAAFBFBSConferenceUSAWest";
            case TypeValueKnownValues.Value_NCAAFBFBSConferenceUSAEast:
                return "NCAAFBFBSConferenceUSAEast";
            case TypeValueKnownValues.Value_NCAAFBFBSIndependents:
                return "NCAAFBFBSIndependents";
            case TypeValueKnownValues.Value_NCAAFBFBSMidAmerican:
                return "NCAAFBFBSMidAmerican";
            case TypeValueKnownValues.Value_NCAAFBFBSMidAmericanWest:
                return "NCAAFBFBSMidAmericanWest";
            case TypeValueKnownValues.Value_NCAAFBFBSMidAmericanEast:
                return "NCAAFBFBSMidAmericanEast";
            case TypeValueKnownValues.Value_NCAAFBFBSMountainWest:
                return "NCAAFBFBSMountainWest";
            case TypeValueKnownValues.Value_NCAAFBFBSMountainWestMountain:
                return "NCAAFBFBSMountainWestMountain";
            case TypeValueKnownValues.Value_NCAAFBFBSMountainWestWest:
                return "NCAAFBFBSMountainWestWest";
            case TypeValueKnownValues.Value_NCAAFBFBSPac12:
                return "NCAAFBFBSPac12";
            case TypeValueKnownValues.Value_NCAAFBFBSPac12North:
                return "NCAAFBFBSPac12North";
            case TypeValueKnownValues.Value_NCAAFBFBSPac12South:
                return "NCAAFBFBSPac12South";
            case TypeValueKnownValues.Value_NCAAFBFBSSoutheastern:
                return "NCAAFBFBSSoutheastern";
            case TypeValueKnownValues.Value_NCAAFBFBSSoutheasternWest:
                return "NCAAFBFBSSoutheasternWest";
            case TypeValueKnownValues.Value_NCAAFBFBSSoutheasternEast:
                return "NCAAFBFBSSoutheasternEast";
            case TypeValueKnownValues.Value_NCAAFBFBSSunBelt:
                return "NCAAFBFBSSunBelt";
            case TypeValueKnownValues.Value_NCAAFBFBSSunBeltEast:
                return "NCAAFBFBSSunBeltEast";
            case TypeValueKnownValues.Value_NCAAFBFBSSunBeltWest:
                return "NCAAFBFBSSunBeltWest";
            case TypeValueKnownValues.Value_NCAAFBFCS:
                return "NCAAFBFCS";
            case TypeValueKnownValues.Value_NCAAFBFCSBigSky:
                return "NCAAFBFCSBigSky";
            case TypeValueKnownValues.Value_NCAAFBFCSBigSouth:
                return "NCAAFBFCSBigSouth";
            case TypeValueKnownValues.Value_NCAAFBFCSColonialAthleticAssociation:
                return "NCAAFBFCSColonialAthleticAssociation";
            case TypeValueKnownValues.Value_NCAAFBFCSIndependents:
                return "NCAAFBFCSIndependents";
            case TypeValueKnownValues.Value_NCAAFBFCSIvyLeague:
                return "NCAAFBFCSIvyLeague";
            case TypeValueKnownValues.Value_NCAAFBFCSMidEasternAthletic:
                return "NCAAFBFCSMidEasternAthletic";
            case TypeValueKnownValues.Value_NCAAFBFCSMissouriValley:
                return "NCAAFBFCSMissouriValley";
            case TypeValueKnownValues.Value_NCAAFBFCSNortheast:
                return "NCAAFBFCSNortheast";
            case TypeValueKnownValues.Value_NCAAFBFCSOhioValley:
                return "NCAAFBFCSOhioValley";
            case TypeValueKnownValues.Value_NCAAFBFCSPatriotLeague:
                return "NCAAFBFCSPatriotLeague";
            case TypeValueKnownValues.Value_NCAAFBFCSPioneerLeague:
                return "NCAAFBFCSPioneerLeague";
            case TypeValueKnownValues.Value_NCAAFBFCSSouthern:
                return "NCAAFBFCSSouthern";
            case TypeValueKnownValues.Value_NCAAFBFCSSouthland:
                return "NCAAFBFCSSouthland";
            case TypeValueKnownValues.Value_NCAAFBFCSSouthwesternAthletic:
                return "NCAAFBFCSSouthwesternAthletic";
            case TypeValueKnownValues.Value_NCAAFBFCSSouthwesternAthleticEast:
                return "NCAAFBFCSSouthwesternAthleticEast";
            case TypeValueKnownValues.Value_NCAAFBFCSSouthwesternAthleticWest:
                return "NCAAFBFCSSouthwesternAthleticWest";
            case TypeValueKnownValues.Value_NCAAFBFCSWesternAthletic:
                return "NCAAFBFCSWesternAthletic";
            case TypeValueKnownValues.Value_MLSEastern:
                return "MLSEastern";
            case TypeValueKnownValues.Value_MLSWestern:
                return "MLSWestern";
            case TypeValueKnownValues.Value_CFLWest:
                return "CFLWest";
            case TypeValueKnownValues.Value_CFLEast:
                return "CFLEast";
            case TypeValueKnownValues.Value_MensWorldCupGroupStage:
                return "MensWorldCupGroupStage";
            case TypeValueKnownValues.Value_MensWorldCupGroupA:
                return "MensWorldCupGroupA";
            case TypeValueKnownValues.Value_MensWorldCupGroupB:
                return "MensWorldCupGroupB";
            case TypeValueKnownValues.Value_MensWorldCupGroupC:
                return "MensWorldCupGroupC";
            case TypeValueKnownValues.Value_MensWorldCupGroupD:
                return "MensWorldCupGroupD";
            case TypeValueKnownValues.Value_MensWorldCupGroupE:
                return "MensWorldCupGroupE";
            case TypeValueKnownValues.Value_MensWorldCupGroupF:
                return "MensWorldCupGroupF";
            case TypeValueKnownValues.Value_MensWorldCupGroupG:
                return "MensWorldCupGroupG";
            case TypeValueKnownValues.Value_MensWorldCupGroupH:
                return "MensWorldCupGroupH";
            case TypeValueKnownValues.Value_NPBCentral:
                return "NPBCentral";
            case TypeValueKnownValues.Value_NPBPacific:
                return "NPBPacific";
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
            throw new Exception("The value for field Value of SportsLeagueDivisionJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'C':
                if (String.Compare(json_string.getData(), 1, "FL", 0, 2, false) == 0)
                  {
                    switch (json_string.getData()[3])
                      {
                        case 'E':
                            if ((String.Compare(json_string.getData(), 4, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_CFLEast;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'W':
                            if ((String.Compare(json_string.getData(), 4, "est", 0, 3, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_CFLWest;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                switch (json_string.getData()[1])
                  {
                    case 'L':
                        switch (json_string.getData()[2])
                          {
                            case 'B':
                                switch (json_string.getData()[3])
                                  {
                                    case 'A':
                                        if (String.Compare(json_string.getData(), 4, "mericanLeague", 0, 13, false) == 0)
                                          {
                                            if (json_string.getData().Length == 17)
                                              {
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_MLBAmericanLeague;
                                                    goto open_enum_is_done;
                                                  }
                                              }
                                            switch (json_string.getData()[17])
                                              {
                                                case 'C':
                                                    if ((String.Compare(json_string.getData(), 18, "entral", 0, 6, false) == 0) && (json_string.getData().Length == 24))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_MLBAmericanLeagueCentral;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'E':
                                                    if ((String.Compare(json_string.getData(), 18, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 21))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_MLBAmericanLeagueEast;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'W':
                                                    if ((String.Compare(json_string.getData(), 18, "est", 0, 3, false) == 0) && (json_string.getData().Length == 21))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_MLBAmericanLeagueWest;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'N':
                                        if (String.Compare(json_string.getData(), 4, "ationalLeague", 0, 13, false) == 0)
                                          {
                                            if (json_string.getData().Length == 17)
                                              {
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_MLBNationalLeague;
                                                    goto open_enum_is_done;
                                                  }
                                              }
                                            switch (json_string.getData()[17])
                                              {
                                                case 'C':
                                                    if ((String.Compare(json_string.getData(), 18, "entral", 0, 6, false) == 0) && (json_string.getData().Length == 24))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_MLBNationalLeagueCentral;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'E':
                                                    if ((String.Compare(json_string.getData(), 18, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 21))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_MLBNationalLeagueEast;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'W':
                                                    if ((String.Compare(json_string.getData(), 18, "est", 0, 3, false) == 0) && (json_string.getData().Length == 21))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_MLBNationalLeagueWest;
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
                                switch (json_string.getData()[3])
                                  {
                                    case 'E':
                                        if ((String.Compare(json_string.getData(), 4, "astern", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_MLSEastern;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'W':
                                        if ((String.Compare(json_string.getData(), 4, "estern", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_MLSWestern;
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
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "nsWorldCupGroup", 0, 15, false) == 0)
                          {
                            switch (json_string.getData()[17])
                              {
                                case 'A':
                                    if (json_string.getData().Length == 18)
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MensWorldCupGroupA;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'B':
                                    if (json_string.getData().Length == 18)
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MensWorldCupGroupB;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'C':
                                    if (json_string.getData().Length == 18)
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MensWorldCupGroupC;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'D':
                                    if (json_string.getData().Length == 18)
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MensWorldCupGroupD;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'E':
                                    if (json_string.getData().Length == 18)
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MensWorldCupGroupE;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'F':
                                    if (json_string.getData().Length == 18)
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MensWorldCupGroupF;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'G':
                                    if (json_string.getData().Length == 18)
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MensWorldCupGroupG;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'H':
                                    if (json_string.getData().Length == 18)
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MensWorldCupGroupH;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'S':
                                    if ((String.Compare(json_string.getData(), 18, "tage", 0, 4, false) == 0) && (json_string.getData().Length == 22))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MensWorldCupGroupStage;
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
            case 'N':
                switch (json_string.getData()[1])
                  {
                    case 'B':
                        if (String.Compare(json_string.getData(), 2, "A", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'E':
                                    if (String.Compare(json_string.getData(), 4, "astern", 0, 6, false) == 0)
                                      {
                                        if (json_string.getData().Length == 10)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_NBAEastern;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[10])
                                          {
                                            case 'A':
                                                if ((String.Compare(json_string.getData(), 11, "tlantic", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NBAEasternAtlantic;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'C':
                                                if ((String.Compare(json_string.getData(), 11, "entral", 0, 6, false) == 0) && (json_string.getData().Length == 17))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NBAEasternCentral;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'S':
                                                if ((String.Compare(json_string.getData(), 11, "outheast", 0, 8, false) == 0) && (json_string.getData().Length == 19))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NBAEasternSoutheast;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'W':
                                    if (String.Compare(json_string.getData(), 4, "estern", 0, 6, false) == 0)
                                      {
                                        if (json_string.getData().Length == 10)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_NBAWestern;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[10])
                                          {
                                            case 'N':
                                                if ((String.Compare(json_string.getData(), 11, "orthwest", 0, 8, false) == 0) && (json_string.getData().Length == 19))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NBAWesternNorthwest;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'P':
                                                if ((String.Compare(json_string.getData(), 11, "acific", 0, 6, false) == 0) && (json_string.getData().Length == 17))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NBAWesternPacific;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'S':
                                                if ((String.Compare(json_string.getData(), 11, "outhwest", 0, 8, false) == 0) && (json_string.getData().Length == 19))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NBAWesternSouthwest;
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
                    case 'C':
                        if (String.Compare(json_string.getData(), 2, "AA", 0, 2, false) == 0)
                          {
                            switch (json_string.getData()[4])
                              {
                                case 'F':
                                    if (String.Compare(json_string.getData(), 5, "BF", 0, 2, false) == 0)
                                      {
                                        switch (json_string.getData()[7])
                                          {
                                            case 'B':
                                                if (String.Compare(json_string.getData(), 8, "S", 0, 1, false) == 0)
                                                  {
                                                    if (json_string.getData().Length == 9)
                                                      {
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBS;
                                                            goto open_enum_is_done;
                                                          }
                                                      }
                                                    switch (json_string.getData()[9])
                                                      {
                                                        case 'A':
                                                            switch (json_string.getData()[10])
                                                              {
                                                                case 'm':
                                                                    if (String.Compare(json_string.getData(), 11, "ericanAthleticConference", 0, 24, false) == 0)
                                                                      {
                                                                        if (json_string.getData().Length == 35)
                                                                          {
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSAmericanAthleticConference;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                          }
                                                                        switch (json_string.getData()[35])
                                                                          {
                                                                            case 'E':
                                                                                if ((String.Compare(json_string.getData(), 36, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 39))
                                                                                      {
                                                                                        the_open_enum.in_known_list = true;
                                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSAmericanAthleticConferenceEast;
                                                                                        goto open_enum_is_done;
                                                                                      }
                                                                                break;
                                                                            case 'W':
                                                                                if ((String.Compare(json_string.getData(), 36, "est", 0, 3, false) == 0) && (json_string.getData().Length == 39))
                                                                                      {
                                                                                        the_open_enum.in_known_list = true;
                                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSAmericanAthleticConferenceWest;
                                                                                        goto open_enum_is_done;
                                                                                      }
                                                                                break;
                                                                            default:
                                                                                break;
                                                                          }
                                                                      }
                                                                    break;
                                                                case 't':
                                                                    if (String.Compare(json_string.getData(), 11, "lanticCoast", 0, 11, false) == 0)
                                                                      {
                                                                        if (json_string.getData().Length == 22)
                                                                          {
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSAtlanticCoast;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                          }
                                                                        switch (json_string.getData()[22])
                                                                          {
                                                                            case 'A':
                                                                                if ((String.Compare(json_string.getData(), 23, "tlantic", 0, 7, false) == 0) && (json_string.getData().Length == 30))
                                                                                      {
                                                                                        the_open_enum.in_known_list = true;
                                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSAtlanticCoastAtlantic;
                                                                                        goto open_enum_is_done;
                                                                                      }
                                                                                break;
                                                                            case 'C':
                                                                                if ((String.Compare(json_string.getData(), 23, "oastal", 0, 6, false) == 0) && (json_string.getData().Length == 29))
                                                                                      {
                                                                                        the_open_enum.in_known_list = true;
                                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSAtlanticCoastCoastal;
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
                                                        case 'B':
                                                            if (String.Compare(json_string.getData(), 10, "ig1", 0, 3, false) == 0)
                                                              {
                                                                switch (json_string.getData()[13])
                                                                  {
                                                                    case '0':
                                                                        if (json_string.getData().Length == 14)
                                                                          {
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSBig10;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                          }
                                                                        switch (json_string.getData()[14])
                                                                          {
                                                                            case 'E':
                                                                                if ((String.Compare(json_string.getData(), 15, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 18))
                                                                                      {
                                                                                        the_open_enum.in_known_list = true;
                                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSBig10East;
                                                                                        goto open_enum_is_done;
                                                                                      }
                                                                                break;
                                                                            case 'W':
                                                                                if ((String.Compare(json_string.getData(), 15, "est", 0, 3, false) == 0) && (json_string.getData().Length == 18))
                                                                                      {
                                                                                        the_open_enum.in_known_list = true;
                                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSBig10West;
                                                                                        goto open_enum_is_done;
                                                                                      }
                                                                                break;
                                                                            default:
                                                                                break;
                                                                          }
                                                                        break;
                                                                    case '2':
                                                                        if (json_string.getData().Length == 14)
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSBig12;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                              }
                                                            break;
                                                        case 'C':
                                                            if (String.Compare(json_string.getData(), 10, "onferenceUSA", 0, 12, false) == 0)
                                                              {
                                                                if (json_string.getData().Length == 22)
                                                                  {
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSConferenceUSA;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                  }
                                                                switch (json_string.getData()[22])
                                                                  {
                                                                    case 'E':
                                                                        if ((String.Compare(json_string.getData(), 23, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 26))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSConferenceUSAEast;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    case 'W':
                                                                        if ((String.Compare(json_string.getData(), 23, "est", 0, 3, false) == 0) && (json_string.getData().Length == 26))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSConferenceUSAWest;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                              }
                                                            break;
                                                        case 'I':
                                                            if ((String.Compare(json_string.getData(), 10, "ndependents", 0, 11, false) == 0) && (json_string.getData().Length == 21))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSIndependents;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'M':
                                                            switch (json_string.getData()[10])
                                                              {
                                                                case 'i':
                                                                    if (String.Compare(json_string.getData(), 11, "dAmerican", 0, 9, false) == 0)
                                                                      {
                                                                        if (json_string.getData().Length == 20)
                                                                          {
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSMidAmerican;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                          }
                                                                        switch (json_string.getData()[20])
                                                                          {
                                                                            case 'E':
                                                                                if ((String.Compare(json_string.getData(), 21, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 24))
                                                                                      {
                                                                                        the_open_enum.in_known_list = true;
                                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSMidAmericanEast;
                                                                                        goto open_enum_is_done;
                                                                                      }
                                                                                break;
                                                                            case 'W':
                                                                                if ((String.Compare(json_string.getData(), 21, "est", 0, 3, false) == 0) && (json_string.getData().Length == 24))
                                                                                      {
                                                                                        the_open_enum.in_known_list = true;
                                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSMidAmericanWest;
                                                                                        goto open_enum_is_done;
                                                                                      }
                                                                                break;
                                                                            default:
                                                                                break;
                                                                          }
                                                                      }
                                                                    break;
                                                                case 'o':
                                                                    if (String.Compare(json_string.getData(), 11, "untainWest", 0, 10, false) == 0)
                                                                      {
                                                                        if (json_string.getData().Length == 21)
                                                                          {
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSMountainWest;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                          }
                                                                        switch (json_string.getData()[21])
                                                                          {
                                                                            case 'M':
                                                                                if ((String.Compare(json_string.getData(), 22, "ountain", 0, 7, false) == 0) && (json_string.getData().Length == 29))
                                                                                      {
                                                                                        the_open_enum.in_known_list = true;
                                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSMountainWestMountain;
                                                                                        goto open_enum_is_done;
                                                                                      }
                                                                                break;
                                                                            case 'W':
                                                                                if ((String.Compare(json_string.getData(), 22, "est", 0, 3, false) == 0) && (json_string.getData().Length == 25))
                                                                                      {
                                                                                        the_open_enum.in_known_list = true;
                                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSMountainWestWest;
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
                                                            if (String.Compare(json_string.getData(), 10, "ac12", 0, 4, false) == 0)
                                                              {
                                                                if (json_string.getData().Length == 14)
                                                                  {
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSPac12;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                  }
                                                                switch (json_string.getData()[14])
                                                                  {
                                                                    case 'N':
                                                                        if ((String.Compare(json_string.getData(), 15, "orth", 0, 4, false) == 0) && (json_string.getData().Length == 19))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSPac12North;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    case 'S':
                                                                        if ((String.Compare(json_string.getData(), 15, "outh", 0, 4, false) == 0) && (json_string.getData().Length == 19))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSPac12South;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                              }
                                                            break;
                                                        case 'S':
                                                            switch (json_string.getData()[10])
                                                              {
                                                                case 'o':
                                                                    if (String.Compare(json_string.getData(), 11, "utheastern", 0, 10, false) == 0)
                                                                      {
                                                                        if (json_string.getData().Length == 21)
                                                                          {
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSSoutheastern;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                          }
                                                                        switch (json_string.getData()[21])
                                                                          {
                                                                            case 'E':
                                                                                if ((String.Compare(json_string.getData(), 22, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 25))
                                                                                      {
                                                                                        the_open_enum.in_known_list = true;
                                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSSoutheasternEast;
                                                                                        goto open_enum_is_done;
                                                                                      }
                                                                                break;
                                                                            case 'W':
                                                                                if ((String.Compare(json_string.getData(), 22, "est", 0, 3, false) == 0) && (json_string.getData().Length == 25))
                                                                                      {
                                                                                        the_open_enum.in_known_list = true;
                                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSSoutheasternWest;
                                                                                        goto open_enum_is_done;
                                                                                      }
                                                                                break;
                                                                            default:
                                                                                break;
                                                                          }
                                                                      }
                                                                    break;
                                                                case 'u':
                                                                    if (String.Compare(json_string.getData(), 11, "nBelt", 0, 5, false) == 0)
                                                                      {
                                                                        if (json_string.getData().Length == 16)
                                                                          {
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSSunBelt;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                          }
                                                                        switch (json_string.getData()[16])
                                                                          {
                                                                            case 'E':
                                                                                if ((String.Compare(json_string.getData(), 17, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 20))
                                                                                      {
                                                                                        the_open_enum.in_known_list = true;
                                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSSunBeltEast;
                                                                                        goto open_enum_is_done;
                                                                                      }
                                                                                break;
                                                                            case 'W':
                                                                                if ((String.Compare(json_string.getData(), 17, "est", 0, 3, false) == 0) && (json_string.getData().Length == 20))
                                                                                      {
                                                                                        the_open_enum.in_known_list = true;
                                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFBSSunBeltWest;
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
                                            case 'C':
                                                if (String.Compare(json_string.getData(), 8, "S", 0, 1, false) == 0)
                                                  {
                                                    if (json_string.getData().Length == 9)
                                                      {
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCS;
                                                            goto open_enum_is_done;
                                                          }
                                                      }
                                                    switch (json_string.getData()[9])
                                                      {
                                                        case 'B':
                                                            if (String.Compare(json_string.getData(), 10, "igS", 0, 3, false) == 0)
                                                              {
                                                                switch (json_string.getData()[13])
                                                                  {
                                                                    case 'k':
                                                                        if ((String.Compare(json_string.getData(), 14, "y", 0, 1, false) == 0) && (json_string.getData().Length == 15))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSBigSky;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    case 'o':
                                                                        if ((String.Compare(json_string.getData(), 14, "uth", 0, 3, false) == 0) && (json_string.getData().Length == 17))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSBigSouth;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                              }
                                                            break;
                                                        case 'C':
                                                            if ((String.Compare(json_string.getData(), 10, "olonialAthleticAssociation", 0, 26, false) == 0) && (json_string.getData().Length == 36))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSColonialAthleticAssociation;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'I':
                                                            switch (json_string.getData()[10])
                                                              {
                                                                case 'n':
                                                                    if ((String.Compare(json_string.getData(), 11, "dependents", 0, 10, false) == 0) && (json_string.getData().Length == 21))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSIndependents;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'v':
                                                                    if ((String.Compare(json_string.getData(), 11, "yLeague", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSIvyLeague;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'M':
                                                            if (String.Compare(json_string.getData(), 10, "i", 0, 1, false) == 0)
                                                              {
                                                                switch (json_string.getData()[11])
                                                                  {
                                                                    case 'd':
                                                                        if ((String.Compare(json_string.getData(), 12, "EasternAthletic", 0, 15, false) == 0) && (json_string.getData().Length == 27))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSMidEasternAthletic;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    case 's':
                                                                        if ((String.Compare(json_string.getData(), 12, "souriValley", 0, 11, false) == 0) && (json_string.getData().Length == 23))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSMissouriValley;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                              }
                                                            break;
                                                        case 'N':
                                                            if ((String.Compare(json_string.getData(), 10, "ortheast", 0, 8, false) == 0) && (json_string.getData().Length == 18))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSNortheast;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'O':
                                                            if ((String.Compare(json_string.getData(), 10, "hioValley", 0, 9, false) == 0) && (json_string.getData().Length == 19))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSOhioValley;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'P':
                                                            switch (json_string.getData()[10])
                                                              {
                                                                case 'a':
                                                                    if ((String.Compare(json_string.getData(), 11, "triotLeague", 0, 11, false) == 0) && (json_string.getData().Length == 22))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSPatriotLeague;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'i':
                                                                    if ((String.Compare(json_string.getData(), 11, "oneerLeague", 0, 11, false) == 0) && (json_string.getData().Length == 22))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSPioneerLeague;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'S':
                                                            if (String.Compare(json_string.getData(), 10, "outh", 0, 4, false) == 0)
                                                              {
                                                                switch (json_string.getData()[14])
                                                                  {
                                                                    case 'e':
                                                                        if ((String.Compare(json_string.getData(), 15, "rn", 0, 2, false) == 0) && (json_string.getData().Length == 17))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSSouthern;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    case 'l':
                                                                        if ((String.Compare(json_string.getData(), 15, "and", 0, 3, false) == 0) && (json_string.getData().Length == 18))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSSouthland;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    case 'w':
                                                                        if (String.Compare(json_string.getData(), 15, "esternAthletic", 0, 14, false) == 0)
                                                                          {
                                                                            if (json_string.getData().Length == 29)
                                                                              {
                                                                                  {
                                                                                    the_open_enum.in_known_list = true;
                                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSSouthwesternAthletic;
                                                                                    goto open_enum_is_done;
                                                                                  }
                                                                              }
                                                                            switch (json_string.getData()[29])
                                                                              {
                                                                                case 'E':
                                                                                    if ((String.Compare(json_string.getData(), 30, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 33))
                                                                                          {
                                                                                            the_open_enum.in_known_list = true;
                                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSSouthwesternAthleticEast;
                                                                                            goto open_enum_is_done;
                                                                                          }
                                                                                    break;
                                                                                case 'W':
                                                                                    if ((String.Compare(json_string.getData(), 30, "est", 0, 3, false) == 0) && (json_string.getData().Length == 33))
                                                                                          {
                                                                                            the_open_enum.in_known_list = true;
                                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSSouthwesternAthleticWest;
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
                                                        case 'W':
                                                            if ((String.Compare(json_string.getData(), 10, "esternAthletic", 0, 14, false) == 0) && (json_string.getData().Length == 24))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFCSWesternAthletic;
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
                                case 'M':
                                    if (String.Compare(json_string.getData(), 5, "BDivisionI", 0, 10, false) == 0)
                                      {
                                        if (json_string.getData().Length == 15)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionI;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[15])
                                          {
                                            case 'A':
                                                switch (json_string.getData()[16])
                                                  {
                                                    case 'm':
                                                        if (String.Compare(json_string.getData(), 17, "erica", 0, 5, false) == 0)
                                                          {
                                                            switch (json_string.getData()[22])
                                                              {
                                                                case 'E':
                                                                    if ((String.Compare(json_string.getData(), 23, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 26))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIAmericaEast;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'n':
                                                                    if ((String.Compare(json_string.getData(), 23, "AthleticConference", 0, 18, false) == 0) && (json_string.getData().Length == 41))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIAmericanAthleticConference;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                          }
                                                        break;
                                                    case 't':
                                                        if (String.Compare(json_string.getData(), 17, "lantic", 0, 6, false) == 0)
                                                          {
                                                            switch (json_string.getData()[23])
                                                              {
                                                                case '1':
                                                                    if ((String.Compare(json_string.getData(), 24, "0", 0, 1, false) == 0) && (json_string.getData().Length == 25))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIAtlantic10;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'C':
                                                                    if ((String.Compare(json_string.getData(), 24, "oast", 0, 4, false) == 0) && (json_string.getData().Length == 28))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIAtlanticCoast;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'S':
                                                                    if ((String.Compare(json_string.getData(), 24, "un", 0, 2, false) == 0) && (json_string.getData().Length == 26))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIAtlanticSun;
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
                                            case 'B':
                                                if (String.Compare(json_string.getData(), 16, "ig", 0, 2, false) == 0)
                                                  {
                                                    switch (json_string.getData()[18])
                                                      {
                                                        case '1':
                                                            switch (json_string.getData()[19])
                                                              {
                                                                case '0':
                                                                    if (json_string.getData().Length == 20)
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIBig10;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case '2':
                                                                    if (json_string.getData().Length == 20)
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIBig12;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'E':
                                                            if ((String.Compare(json_string.getData(), 19, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 22))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIBigEast;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'S':
                                                            switch (json_string.getData()[19])
                                                              {
                                                                case 'k':
                                                                    if ((String.Compare(json_string.getData(), 20, "y", 0, 1, false) == 0) && (json_string.getData().Length == 21))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIBigSky;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'o':
                                                                    if ((String.Compare(json_string.getData(), 20, "uth", 0, 3, false) == 0) && (json_string.getData().Length == 23))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIBigSouth;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(json_string.getData(), 19, "est", 0, 3, false) == 0) && (json_string.getData().Length == 22))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIBigWest;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'C':
                                                if (String.Compare(json_string.getData(), 16, "o", 0, 1, false) == 0)
                                                  {
                                                    switch (json_string.getData()[17])
                                                      {
                                                        case 'l':
                                                            if ((String.Compare(json_string.getData(), 18, "onialAthleticAssociation", 0, 24, false) == 0) && (json_string.getData().Length == 42))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIColonialAthleticAssociation;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'n':
                                                            if ((String.Compare(json_string.getData(), 18, "ferenceUSA", 0, 10, false) == 0) && (json_string.getData().Length == 28))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIConferenceUSA;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'H':
                                                if ((String.Compare(json_string.getData(), 16, "orizon", 0, 6, false) == 0) && (json_string.getData().Length == 22))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIHorizon;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'I':
                                                if ((String.Compare(json_string.getData(), 16, "vyLeague", 0, 8, false) == 0) && (json_string.getData().Length == 24))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIIvyLeague;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'M':
                                                switch (json_string.getData()[16])
                                                  {
                                                    case 'e':
                                                        if ((String.Compare(json_string.getData(), 17, "troAtlanticAthletic", 0, 19, false) == 0) && (json_string.getData().Length == 36))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIMetroAtlanticAthletic;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'i':
                                                        switch (json_string.getData()[17])
                                                          {
                                                            case 'd':
                                                                switch (json_string.getData()[18])
                                                                  {
                                                                    case 'A':
                                                                        if (String.Compare(json_string.getData(), 19, "merican", 0, 7, false) == 0)
                                                                          {
                                                                            if (json_string.getData().Length == 26)
                                                                              {
                                                                                  {
                                                                                    the_open_enum.in_known_list = true;
                                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIMidAmerican;
                                                                                    goto open_enum_is_done;
                                                                                  }
                                                                              }
                                                                            switch (json_string.getData()[26])
                                                                              {
                                                                                case 'E':
                                                                                    if ((String.Compare(json_string.getData(), 27, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 30))
                                                                                          {
                                                                                            the_open_enum.in_known_list = true;
                                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIMidAmericanEast;
                                                                                            goto open_enum_is_done;
                                                                                          }
                                                                                    break;
                                                                                case 'W':
                                                                                    if ((String.Compare(json_string.getData(), 27, "est", 0, 3, false) == 0) && (json_string.getData().Length == 30))
                                                                                          {
                                                                                            the_open_enum.in_known_list = true;
                                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIMidAmericanWest;
                                                                                            goto open_enum_is_done;
                                                                                          }
                                                                                    break;
                                                                                default:
                                                                                    break;
                                                                              }
                                                                          }
                                                                        break;
                                                                    case 'E':
                                                                        if ((String.Compare(json_string.getData(), 19, "astern", 0, 6, false) == 0) && (json_string.getData().Length == 25))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIMidEastern;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                                break;
                                                            case 's':
                                                                if ((String.Compare(json_string.getData(), 18, "souriValley", 0, 11, false) == 0) && (json_string.getData().Length == 29))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIMissouriValley;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'o':
                                                        if ((String.Compare(json_string.getData(), 17, "untainWest", 0, 10, false) == 0) && (json_string.getData().Length == 27))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIMountainWest;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'N':
                                                if ((String.Compare(json_string.getData(), 16, "ortheast", 0, 8, false) == 0) && (json_string.getData().Length == 24))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionINortheast;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'O':
                                                if (String.Compare(json_string.getData(), 16, "hioValley", 0, 9, false) == 0)
                                                  {
                                                    if (json_string.getData().Length == 25)
                                                      {
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIOhioValley;
                                                            goto open_enum_is_done;
                                                          }
                                                      }
                                                    switch (json_string.getData()[25])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(json_string.getData(), 26, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 29))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIOhioValleyEast;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(json_string.getData(), 26, "est", 0, 3, false) == 0) && (json_string.getData().Length == 29))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIOhioValleyWest;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'P':
                                                if (String.Compare(json_string.getData(), 16, "a", 0, 1, false) == 0)
                                                  {
                                                    switch (json_string.getData()[17])
                                                      {
                                                        case 'c':
                                                            if ((String.Compare(json_string.getData(), 18, "12", 0, 2, false) == 0) && (json_string.getData().Length == 20))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIPac12;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 't':
                                                            if ((String.Compare(json_string.getData(), 18, "riotLeague", 0, 10, false) == 0) && (json_string.getData().Length == 28))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIPatriotLeague;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'S':
                                                switch (json_string.getData()[16])
                                                  {
                                                    case 'o':
                                                        if (String.Compare(json_string.getData(), 17, "uth", 0, 3, false) == 0)
                                                          {
                                                            switch (json_string.getData()[20])
                                                              {
                                                                case 'e':
                                                                    switch (json_string.getData()[21])
                                                                      {
                                                                        case 'a':
                                                                            if ((String.Compare(json_string.getData(), 22, "stern", 0, 5, false) == 0) && (json_string.getData().Length == 27))
                                                                                  {
                                                                                    the_open_enum.in_known_list = true;
                                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionISoutheastern;
                                                                                    goto open_enum_is_done;
                                                                                  }
                                                                            break;
                                                                        case 'r':
                                                                            if ((String.Compare(json_string.getData(), 22, "n", 0, 1, false) == 0) && (json_string.getData().Length == 23))
                                                                                  {
                                                                                    the_open_enum.in_known_list = true;
                                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionISouthern;
                                                                                    goto open_enum_is_done;
                                                                                  }
                                                                            break;
                                                                        default:
                                                                            break;
                                                                      }
                                                                    break;
                                                                case 'l':
                                                                    if ((String.Compare(json_string.getData(), 21, "and", 0, 3, false) == 0) && (json_string.getData().Length == 24))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionISouthland;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'w':
                                                                    if ((String.Compare(json_string.getData(), 21, "esternAtlantic", 0, 14, false) == 0) && (json_string.getData().Length == 35))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionISouthwesternAtlantic;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                          }
                                                        break;
                                                    case 'u':
                                                        switch (json_string.getData()[17])
                                                          {
                                                            case 'm':
                                                                if ((String.Compare(json_string.getData(), 18, "mitLeague", 0, 9, false) == 0) && (json_string.getData().Length == 27))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionISummitLeague;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'n':
                                                                if ((String.Compare(json_string.getData(), 18, "Belt", 0, 4, false) == 0) && (json_string.getData().Length == 22))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionISunBelt;
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
                                            case 'W':
                                                if (String.Compare(json_string.getData(), 16, "est", 0, 3, false) == 0)
                                                  {
                                                    switch (json_string.getData()[19])
                                                      {
                                                        case 'C':
                                                            if ((String.Compare(json_string.getData(), 20, "oast", 0, 4, false) == 0) && (json_string.getData().Length == 24))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIWestCoast;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'e':
                                                            if ((String.Compare(json_string.getData(), 20, "rnAthletic", 0, 10, false) == 0) && (json_string.getData().Length == 30))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBDivisionIWesternAthletic;
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
                    case 'F':
                        if (String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'A':
                                    if (String.Compare(json_string.getData(), 4, "FC", 0, 2, false) == 0)
                                      {
                                        if (json_string.getData().Length == 6)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_NFLAFC;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[6])
                                          {
                                            case 'E':
                                                if ((String.Compare(json_string.getData(), 7, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLAFCEast;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'N':
                                                if ((String.Compare(json_string.getData(), 7, "orth", 0, 4, false) == 0) && (json_string.getData().Length == 11))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLAFCNorth;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'S':
                                                if ((String.Compare(json_string.getData(), 7, "outh", 0, 4, false) == 0) && (json_string.getData().Length == 11))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLAFCSouth;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'W':
                                                if ((String.Compare(json_string.getData(), 7, "est", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLAFCWest;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'N':
                                    if (String.Compare(json_string.getData(), 4, "FC", 0, 2, false) == 0)
                                      {
                                        if (json_string.getData().Length == 6)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_NFLNFC;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[6])
                                          {
                                            case 'E':
                                                if ((String.Compare(json_string.getData(), 7, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLNFCEast;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'N':
                                                if ((String.Compare(json_string.getData(), 7, "orth", 0, 4, false) == 0) && (json_string.getData().Length == 11))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLNFCNorth;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'S':
                                                if ((String.Compare(json_string.getData(), 7, "outh", 0, 4, false) == 0) && (json_string.getData().Length == 11))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLNFCSouth;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'W':
                                                if ((String.Compare(json_string.getData(), 7, "est", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLNFCWest;
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
                    case 'H':
                        if (String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'C':
                                    if ((String.Compare(json_string.getData(), 4, "entral", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NHLCentral;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'E':
                                    if (String.Compare(json_string.getData(), 4, "ast", 0, 3, false) == 0)
                                      {
                                        if (json_string.getData().Length == 7)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_NHLEast;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[7])
                                          {
                                            case 'e':
                                                if (String.Compare(json_string.getData(), 8, "rn", 0, 2, false) == 0)
                                                  {
                                                    if (json_string.getData().Length == 10)
                                                      {
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NHLEastern;
                                                            goto open_enum_is_done;
                                                          }
                                                      }
                                                    switch (json_string.getData()[10])
                                                      {
                                                        case 'A':
                                                            if ((String.Compare(json_string.getData(), 11, "tlantic", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLEasternAtlantic;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'M':
                                                            if ((String.Compare(json_string.getData(), 11, "etropolitan", 0, 11, false) == 0) && (json_string.getData().Length == 22))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLEasternMetropolitan;
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
                                case 'N':
                                    if ((String.Compare(json_string.getData(), 4, "orth", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NHLNorth;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'W':
                                    if (String.Compare(json_string.getData(), 4, "est", 0, 3, false) == 0)
                                      {
                                        if (json_string.getData().Length == 7)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_NHLWest;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[7])
                                          {
                                            case 'e':
                                                if (String.Compare(json_string.getData(), 8, "rn", 0, 2, false) == 0)
                                                  {
                                                    if (json_string.getData().Length == 10)
                                                      {
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NHLWestern;
                                                            goto open_enum_is_done;
                                                          }
                                                      }
                                                    switch (json_string.getData()[10])
                                                      {
                                                        case 'C':
                                                            if ((String.Compare(json_string.getData(), 11, "entral", 0, 6, false) == 0) && (json_string.getData().Length == 17))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLWesternCentral;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'P':
                                                            if ((String.Compare(json_string.getData(), 11, "acific", 0, 6, false) == 0) && (json_string.getData().Length == 17))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLWesternPacific;
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
                    case 'P':
                        if (String.Compare(json_string.getData(), 2, "B", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'C':
                                    if ((String.Compare(json_string.getData(), 4, "entral", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NPBCentral;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'P':
                                    if ((String.Compare(json_string.getData(), 4, "acific", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NPBPacific;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setValue(the_open_enum);
      }


    public SportsLeagueDivisionJSON()
      {
        flagHasValue = false;
      }

    public SportsLeagueDivisionJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public SportsLeagueDivisionJSON(string init_value)
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

    public SportsLeagueDivisionJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_MLBAmericanLeague:
                    handler.string_value("MLBAmericanLeague");
                    break;
                case TypeValueKnownValues.Value_MLBAmericanLeagueEast:
                    handler.string_value("MLBAmericanLeagueEast");
                    break;
                case TypeValueKnownValues.Value_MLBAmericanLeagueCentral:
                    handler.string_value("MLBAmericanLeagueCentral");
                    break;
                case TypeValueKnownValues.Value_MLBAmericanLeagueWest:
                    handler.string_value("MLBAmericanLeagueWest");
                    break;
                case TypeValueKnownValues.Value_MLBNationalLeague:
                    handler.string_value("MLBNationalLeague");
                    break;
                case TypeValueKnownValues.Value_MLBNationalLeagueEast:
                    handler.string_value("MLBNationalLeagueEast");
                    break;
                case TypeValueKnownValues.Value_MLBNationalLeagueCentral:
                    handler.string_value("MLBNationalLeagueCentral");
                    break;
                case TypeValueKnownValues.Value_MLBNationalLeagueWest:
                    handler.string_value("MLBNationalLeagueWest");
                    break;
                case TypeValueKnownValues.Value_NBAEastern:
                    handler.string_value("NBAEastern");
                    break;
                case TypeValueKnownValues.Value_NBAEasternAtlantic:
                    handler.string_value("NBAEasternAtlantic");
                    break;
                case TypeValueKnownValues.Value_NBAEasternCentral:
                    handler.string_value("NBAEasternCentral");
                    break;
                case TypeValueKnownValues.Value_NBAEasternSoutheast:
                    handler.string_value("NBAEasternSoutheast");
                    break;
                case TypeValueKnownValues.Value_NBAWestern:
                    handler.string_value("NBAWestern");
                    break;
                case TypeValueKnownValues.Value_NBAWesternNorthwest:
                    handler.string_value("NBAWesternNorthwest");
                    break;
                case TypeValueKnownValues.Value_NBAWesternPacific:
                    handler.string_value("NBAWesternPacific");
                    break;
                case TypeValueKnownValues.Value_NBAWesternSouthwest:
                    handler.string_value("NBAWesternSouthwest");
                    break;
                case TypeValueKnownValues.Value_NFLAFC:
                    handler.string_value("NFLAFC");
                    break;
                case TypeValueKnownValues.Value_NFLAFCEast:
                    handler.string_value("NFLAFCEast");
                    break;
                case TypeValueKnownValues.Value_NFLAFCNorth:
                    handler.string_value("NFLAFCNorth");
                    break;
                case TypeValueKnownValues.Value_NFLAFCSouth:
                    handler.string_value("NFLAFCSouth");
                    break;
                case TypeValueKnownValues.Value_NFLAFCWest:
                    handler.string_value("NFLAFCWest");
                    break;
                case TypeValueKnownValues.Value_NFLNFC:
                    handler.string_value("NFLNFC");
                    break;
                case TypeValueKnownValues.Value_NFLNFCEast:
                    handler.string_value("NFLNFCEast");
                    break;
                case TypeValueKnownValues.Value_NFLNFCNorth:
                    handler.string_value("NFLNFCNorth");
                    break;
                case TypeValueKnownValues.Value_NFLNFCSouth:
                    handler.string_value("NFLNFCSouth");
                    break;
                case TypeValueKnownValues.Value_NFLNFCWest:
                    handler.string_value("NFLNFCWest");
                    break;
                case TypeValueKnownValues.Value_NHLEastern:
                    handler.string_value("NHLEastern");
                    break;
                case TypeValueKnownValues.Value_NHLEasternMetropolitan:
                    handler.string_value("NHLEasternMetropolitan");
                    break;
                case TypeValueKnownValues.Value_NHLEasternAtlantic:
                    handler.string_value("NHLEasternAtlantic");
                    break;
                case TypeValueKnownValues.Value_NHLWestern:
                    handler.string_value("NHLWestern");
                    break;
                case TypeValueKnownValues.Value_NHLWesternCentral:
                    handler.string_value("NHLWesternCentral");
                    break;
                case TypeValueKnownValues.Value_NHLWesternPacific:
                    handler.string_value("NHLWesternPacific");
                    break;
                case TypeValueKnownValues.Value_NHLNorth:
                    handler.string_value("NHLNorth");
                    break;
                case TypeValueKnownValues.Value_NHLEast:
                    handler.string_value("NHLEast");
                    break;
                case TypeValueKnownValues.Value_NHLCentral:
                    handler.string_value("NHLCentral");
                    break;
                case TypeValueKnownValues.Value_NHLWest:
                    handler.string_value("NHLWest");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionI:
                    handler.string_value("NCAAMBDivisionI");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIAmericaEast:
                    handler.string_value("NCAAMBDivisionIAmericaEast");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIAmericanAthleticConference:
                    handler.string_value("NCAAMBDivisionIAmericanAthleticConference");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIAtlantic10:
                    handler.string_value("NCAAMBDivisionIAtlantic10");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIAtlanticCoast:
                    handler.string_value("NCAAMBDivisionIAtlanticCoast");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIAtlanticSun:
                    handler.string_value("NCAAMBDivisionIAtlanticSun");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIBig12:
                    handler.string_value("NCAAMBDivisionIBig12");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIBigEast:
                    handler.string_value("NCAAMBDivisionIBigEast");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIBigSky:
                    handler.string_value("NCAAMBDivisionIBigSky");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIBigSouth:
                    handler.string_value("NCAAMBDivisionIBigSouth");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIBig10:
                    handler.string_value("NCAAMBDivisionIBig10");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIBigWest:
                    handler.string_value("NCAAMBDivisionIBigWest");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIColonialAthleticAssociation:
                    handler.string_value("NCAAMBDivisionIColonialAthleticAssociation");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIConferenceUSA:
                    handler.string_value("NCAAMBDivisionIConferenceUSA");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIHorizon:
                    handler.string_value("NCAAMBDivisionIHorizon");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIIvyLeague:
                    handler.string_value("NCAAMBDivisionIIvyLeague");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIMetroAtlanticAthletic:
                    handler.string_value("NCAAMBDivisionIMetroAtlanticAthletic");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIMidAmerican:
                    handler.string_value("NCAAMBDivisionIMidAmerican");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIMidAmericanWest:
                    handler.string_value("NCAAMBDivisionIMidAmericanWest");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIMidAmericanEast:
                    handler.string_value("NCAAMBDivisionIMidAmericanEast");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIMidEastern:
                    handler.string_value("NCAAMBDivisionIMidEastern");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIMissouriValley:
                    handler.string_value("NCAAMBDivisionIMissouriValley");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIMountainWest:
                    handler.string_value("NCAAMBDivisionIMountainWest");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionINortheast:
                    handler.string_value("NCAAMBDivisionINortheast");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIOhioValley:
                    handler.string_value("NCAAMBDivisionIOhioValley");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIOhioValleyWest:
                    handler.string_value("NCAAMBDivisionIOhioValleyWest");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIOhioValleyEast:
                    handler.string_value("NCAAMBDivisionIOhioValleyEast");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIPac12:
                    handler.string_value("NCAAMBDivisionIPac12");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIPatriotLeague:
                    handler.string_value("NCAAMBDivisionIPatriotLeague");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionISoutheastern:
                    handler.string_value("NCAAMBDivisionISoutheastern");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionISouthern:
                    handler.string_value("NCAAMBDivisionISouthern");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionISouthland:
                    handler.string_value("NCAAMBDivisionISouthland");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionISouthwesternAtlantic:
                    handler.string_value("NCAAMBDivisionISouthwesternAtlantic");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionISummitLeague:
                    handler.string_value("NCAAMBDivisionISummitLeague");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionISunBelt:
                    handler.string_value("NCAAMBDivisionISunBelt");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIWestCoast:
                    handler.string_value("NCAAMBDivisionIWestCoast");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIWesternAthletic:
                    handler.string_value("NCAAMBDivisionIWesternAthletic");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBS:
                    handler.string_value("NCAAFBFBS");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSAtlanticCoast:
                    handler.string_value("NCAAFBFBSAtlanticCoast");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSAtlanticCoastAtlantic:
                    handler.string_value("NCAAFBFBSAtlanticCoastAtlantic");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSAtlanticCoastCoastal:
                    handler.string_value("NCAAFBFBSAtlanticCoastCoastal");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSAmericanAthleticConference:
                    handler.string_value("NCAAFBFBSAmericanAthleticConference");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSAmericanAthleticConferenceWest:
                    handler.string_value("NCAAFBFBSAmericanAthleticConferenceWest");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSAmericanAthleticConferenceEast:
                    handler.string_value("NCAAFBFBSAmericanAthleticConferenceEast");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSBig12:
                    handler.string_value("NCAAFBFBSBig12");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSBig10:
                    handler.string_value("NCAAFBFBSBig10");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSBig10East:
                    handler.string_value("NCAAFBFBSBig10East");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSBig10West:
                    handler.string_value("NCAAFBFBSBig10West");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSConferenceUSA:
                    handler.string_value("NCAAFBFBSConferenceUSA");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSConferenceUSAWest:
                    handler.string_value("NCAAFBFBSConferenceUSAWest");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSConferenceUSAEast:
                    handler.string_value("NCAAFBFBSConferenceUSAEast");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSIndependents:
                    handler.string_value("NCAAFBFBSIndependents");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSMidAmerican:
                    handler.string_value("NCAAFBFBSMidAmerican");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSMidAmericanWest:
                    handler.string_value("NCAAFBFBSMidAmericanWest");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSMidAmericanEast:
                    handler.string_value("NCAAFBFBSMidAmericanEast");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSMountainWest:
                    handler.string_value("NCAAFBFBSMountainWest");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSMountainWestMountain:
                    handler.string_value("NCAAFBFBSMountainWestMountain");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSMountainWestWest:
                    handler.string_value("NCAAFBFBSMountainWestWest");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSPac12:
                    handler.string_value("NCAAFBFBSPac12");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSPac12North:
                    handler.string_value("NCAAFBFBSPac12North");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSPac12South:
                    handler.string_value("NCAAFBFBSPac12South");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSSoutheastern:
                    handler.string_value("NCAAFBFBSSoutheastern");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSSoutheasternWest:
                    handler.string_value("NCAAFBFBSSoutheasternWest");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSSoutheasternEast:
                    handler.string_value("NCAAFBFBSSoutheasternEast");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSSunBelt:
                    handler.string_value("NCAAFBFBSSunBelt");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSSunBeltEast:
                    handler.string_value("NCAAFBFBSSunBeltEast");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSSunBeltWest:
                    handler.string_value("NCAAFBFBSSunBeltWest");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCS:
                    handler.string_value("NCAAFBFCS");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSBigSky:
                    handler.string_value("NCAAFBFCSBigSky");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSBigSouth:
                    handler.string_value("NCAAFBFCSBigSouth");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSColonialAthleticAssociation:
                    handler.string_value("NCAAFBFCSColonialAthleticAssociation");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSIndependents:
                    handler.string_value("NCAAFBFCSIndependents");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSIvyLeague:
                    handler.string_value("NCAAFBFCSIvyLeague");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSMidEasternAthletic:
                    handler.string_value("NCAAFBFCSMidEasternAthletic");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSMissouriValley:
                    handler.string_value("NCAAFBFCSMissouriValley");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSNortheast:
                    handler.string_value("NCAAFBFCSNortheast");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSOhioValley:
                    handler.string_value("NCAAFBFCSOhioValley");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSPatriotLeague:
                    handler.string_value("NCAAFBFCSPatriotLeague");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSPioneerLeague:
                    handler.string_value("NCAAFBFCSPioneerLeague");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSSouthern:
                    handler.string_value("NCAAFBFCSSouthern");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSSouthland:
                    handler.string_value("NCAAFBFCSSouthland");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSSouthwesternAthletic:
                    handler.string_value("NCAAFBFCSSouthwesternAthletic");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSSouthwesternAthleticEast:
                    handler.string_value("NCAAFBFCSSouthwesternAthleticEast");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSSouthwesternAthleticWest:
                    handler.string_value("NCAAFBFCSSouthwesternAthleticWest");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSWesternAthletic:
                    handler.string_value("NCAAFBFCSWesternAthletic");
                    break;
                case TypeValueKnownValues.Value_MLSEastern:
                    handler.string_value("MLSEastern");
                    break;
                case TypeValueKnownValues.Value_MLSWestern:
                    handler.string_value("MLSWestern");
                    break;
                case TypeValueKnownValues.Value_CFLWest:
                    handler.string_value("CFLWest");
                    break;
                case TypeValueKnownValues.Value_CFLEast:
                    handler.string_value("CFLEast");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupStage:
                    handler.string_value("MensWorldCupGroupStage");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupA:
                    handler.string_value("MensWorldCupGroupA");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupB:
                    handler.string_value("MensWorldCupGroupB");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupC:
                    handler.string_value("MensWorldCupGroupC");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupD:
                    handler.string_value("MensWorldCupGroupD");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupE:
                    handler.string_value("MensWorldCupGroupE");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupF:
                    handler.string_value("MensWorldCupGroupF");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupG:
                    handler.string_value("MensWorldCupGroupG");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupH:
                    handler.string_value("MensWorldCupGroupH");
                    break;
                case TypeValueKnownValues.Value_NPBCentral:
                    handler.string_value("NPBCentral");
                    break;
                case TypeValueKnownValues.Value_NPBPacific:
                    handler.string_value("NPBPacific");
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
                case TypeValueKnownValues.Value_MLBAmericanLeague:
                    handler.string_value("MLBAmericanLeague");
                    break;
                case TypeValueKnownValues.Value_MLBAmericanLeagueEast:
                    handler.string_value("MLBAmericanLeagueEast");
                    break;
                case TypeValueKnownValues.Value_MLBAmericanLeagueCentral:
                    handler.string_value("MLBAmericanLeagueCentral");
                    break;
                case TypeValueKnownValues.Value_MLBAmericanLeagueWest:
                    handler.string_value("MLBAmericanLeagueWest");
                    break;
                case TypeValueKnownValues.Value_MLBNationalLeague:
                    handler.string_value("MLBNationalLeague");
                    break;
                case TypeValueKnownValues.Value_MLBNationalLeagueEast:
                    handler.string_value("MLBNationalLeagueEast");
                    break;
                case TypeValueKnownValues.Value_MLBNationalLeagueCentral:
                    handler.string_value("MLBNationalLeagueCentral");
                    break;
                case TypeValueKnownValues.Value_MLBNationalLeagueWest:
                    handler.string_value("MLBNationalLeagueWest");
                    break;
                case TypeValueKnownValues.Value_NBAEastern:
                    handler.string_value("NBAEastern");
                    break;
                case TypeValueKnownValues.Value_NBAEasternAtlantic:
                    handler.string_value("NBAEasternAtlantic");
                    break;
                case TypeValueKnownValues.Value_NBAEasternCentral:
                    handler.string_value("NBAEasternCentral");
                    break;
                case TypeValueKnownValues.Value_NBAEasternSoutheast:
                    handler.string_value("NBAEasternSoutheast");
                    break;
                case TypeValueKnownValues.Value_NBAWestern:
                    handler.string_value("NBAWestern");
                    break;
                case TypeValueKnownValues.Value_NBAWesternNorthwest:
                    handler.string_value("NBAWesternNorthwest");
                    break;
                case TypeValueKnownValues.Value_NBAWesternPacific:
                    handler.string_value("NBAWesternPacific");
                    break;
                case TypeValueKnownValues.Value_NBAWesternSouthwest:
                    handler.string_value("NBAWesternSouthwest");
                    break;
                case TypeValueKnownValues.Value_NFLAFC:
                    handler.string_value("NFLAFC");
                    break;
                case TypeValueKnownValues.Value_NFLAFCEast:
                    handler.string_value("NFLAFCEast");
                    break;
                case TypeValueKnownValues.Value_NFLAFCNorth:
                    handler.string_value("NFLAFCNorth");
                    break;
                case TypeValueKnownValues.Value_NFLAFCSouth:
                    handler.string_value("NFLAFCSouth");
                    break;
                case TypeValueKnownValues.Value_NFLAFCWest:
                    handler.string_value("NFLAFCWest");
                    break;
                case TypeValueKnownValues.Value_NFLNFC:
                    handler.string_value("NFLNFC");
                    break;
                case TypeValueKnownValues.Value_NFLNFCEast:
                    handler.string_value("NFLNFCEast");
                    break;
                case TypeValueKnownValues.Value_NFLNFCNorth:
                    handler.string_value("NFLNFCNorth");
                    break;
                case TypeValueKnownValues.Value_NFLNFCSouth:
                    handler.string_value("NFLNFCSouth");
                    break;
                case TypeValueKnownValues.Value_NFLNFCWest:
                    handler.string_value("NFLNFCWest");
                    break;
                case TypeValueKnownValues.Value_NHLEastern:
                    handler.string_value("NHLEastern");
                    break;
                case TypeValueKnownValues.Value_NHLEasternMetropolitan:
                    handler.string_value("NHLEasternMetropolitan");
                    break;
                case TypeValueKnownValues.Value_NHLEasternAtlantic:
                    handler.string_value("NHLEasternAtlantic");
                    break;
                case TypeValueKnownValues.Value_NHLWestern:
                    handler.string_value("NHLWestern");
                    break;
                case TypeValueKnownValues.Value_NHLWesternCentral:
                    handler.string_value("NHLWesternCentral");
                    break;
                case TypeValueKnownValues.Value_NHLWesternPacific:
                    handler.string_value("NHLWesternPacific");
                    break;
                case TypeValueKnownValues.Value_NHLNorth:
                    handler.string_value("NHLNorth");
                    break;
                case TypeValueKnownValues.Value_NHLEast:
                    handler.string_value("NHLEast");
                    break;
                case TypeValueKnownValues.Value_NHLCentral:
                    handler.string_value("NHLCentral");
                    break;
                case TypeValueKnownValues.Value_NHLWest:
                    handler.string_value("NHLWest");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionI:
                    handler.string_value("NCAAMBDivisionI");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIAmericaEast:
                    handler.string_value("NCAAMBDivisionIAmericaEast");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIAmericanAthleticConference:
                    handler.string_value("NCAAMBDivisionIAmericanAthleticConference");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIAtlantic10:
                    handler.string_value("NCAAMBDivisionIAtlantic10");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIAtlanticCoast:
                    handler.string_value("NCAAMBDivisionIAtlanticCoast");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIAtlanticSun:
                    handler.string_value("NCAAMBDivisionIAtlanticSun");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIBig12:
                    handler.string_value("NCAAMBDivisionIBig12");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIBigEast:
                    handler.string_value("NCAAMBDivisionIBigEast");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIBigSky:
                    handler.string_value("NCAAMBDivisionIBigSky");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIBigSouth:
                    handler.string_value("NCAAMBDivisionIBigSouth");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIBig10:
                    handler.string_value("NCAAMBDivisionIBig10");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIBigWest:
                    handler.string_value("NCAAMBDivisionIBigWest");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIColonialAthleticAssociation:
                    handler.string_value("NCAAMBDivisionIColonialAthleticAssociation");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIConferenceUSA:
                    handler.string_value("NCAAMBDivisionIConferenceUSA");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIHorizon:
                    handler.string_value("NCAAMBDivisionIHorizon");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIIvyLeague:
                    handler.string_value("NCAAMBDivisionIIvyLeague");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIMetroAtlanticAthletic:
                    handler.string_value("NCAAMBDivisionIMetroAtlanticAthletic");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIMidAmerican:
                    handler.string_value("NCAAMBDivisionIMidAmerican");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIMidAmericanWest:
                    handler.string_value("NCAAMBDivisionIMidAmericanWest");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIMidAmericanEast:
                    handler.string_value("NCAAMBDivisionIMidAmericanEast");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIMidEastern:
                    handler.string_value("NCAAMBDivisionIMidEastern");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIMissouriValley:
                    handler.string_value("NCAAMBDivisionIMissouriValley");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIMountainWest:
                    handler.string_value("NCAAMBDivisionIMountainWest");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionINortheast:
                    handler.string_value("NCAAMBDivisionINortheast");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIOhioValley:
                    handler.string_value("NCAAMBDivisionIOhioValley");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIOhioValleyWest:
                    handler.string_value("NCAAMBDivisionIOhioValleyWest");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIOhioValleyEast:
                    handler.string_value("NCAAMBDivisionIOhioValleyEast");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIPac12:
                    handler.string_value("NCAAMBDivisionIPac12");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIPatriotLeague:
                    handler.string_value("NCAAMBDivisionIPatriotLeague");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionISoutheastern:
                    handler.string_value("NCAAMBDivisionISoutheastern");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionISouthern:
                    handler.string_value("NCAAMBDivisionISouthern");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionISouthland:
                    handler.string_value("NCAAMBDivisionISouthland");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionISouthwesternAtlantic:
                    handler.string_value("NCAAMBDivisionISouthwesternAtlantic");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionISummitLeague:
                    handler.string_value("NCAAMBDivisionISummitLeague");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionISunBelt:
                    handler.string_value("NCAAMBDivisionISunBelt");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIWestCoast:
                    handler.string_value("NCAAMBDivisionIWestCoast");
                    break;
                case TypeValueKnownValues.Value_NCAAMBDivisionIWesternAthletic:
                    handler.string_value("NCAAMBDivisionIWesternAthletic");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBS:
                    handler.string_value("NCAAFBFBS");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSAtlanticCoast:
                    handler.string_value("NCAAFBFBSAtlanticCoast");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSAtlanticCoastAtlantic:
                    handler.string_value("NCAAFBFBSAtlanticCoastAtlantic");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSAtlanticCoastCoastal:
                    handler.string_value("NCAAFBFBSAtlanticCoastCoastal");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSAmericanAthleticConference:
                    handler.string_value("NCAAFBFBSAmericanAthleticConference");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSAmericanAthleticConferenceWest:
                    handler.string_value("NCAAFBFBSAmericanAthleticConferenceWest");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSAmericanAthleticConferenceEast:
                    handler.string_value("NCAAFBFBSAmericanAthleticConferenceEast");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSBig12:
                    handler.string_value("NCAAFBFBSBig12");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSBig10:
                    handler.string_value("NCAAFBFBSBig10");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSBig10East:
                    handler.string_value("NCAAFBFBSBig10East");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSBig10West:
                    handler.string_value("NCAAFBFBSBig10West");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSConferenceUSA:
                    handler.string_value("NCAAFBFBSConferenceUSA");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSConferenceUSAWest:
                    handler.string_value("NCAAFBFBSConferenceUSAWest");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSConferenceUSAEast:
                    handler.string_value("NCAAFBFBSConferenceUSAEast");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSIndependents:
                    handler.string_value("NCAAFBFBSIndependents");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSMidAmerican:
                    handler.string_value("NCAAFBFBSMidAmerican");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSMidAmericanWest:
                    handler.string_value("NCAAFBFBSMidAmericanWest");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSMidAmericanEast:
                    handler.string_value("NCAAFBFBSMidAmericanEast");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSMountainWest:
                    handler.string_value("NCAAFBFBSMountainWest");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSMountainWestMountain:
                    handler.string_value("NCAAFBFBSMountainWestMountain");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSMountainWestWest:
                    handler.string_value("NCAAFBFBSMountainWestWest");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSPac12:
                    handler.string_value("NCAAFBFBSPac12");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSPac12North:
                    handler.string_value("NCAAFBFBSPac12North");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSPac12South:
                    handler.string_value("NCAAFBFBSPac12South");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSSoutheastern:
                    handler.string_value("NCAAFBFBSSoutheastern");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSSoutheasternWest:
                    handler.string_value("NCAAFBFBSSoutheasternWest");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSSoutheasternEast:
                    handler.string_value("NCAAFBFBSSoutheasternEast");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSSunBelt:
                    handler.string_value("NCAAFBFBSSunBelt");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSSunBeltEast:
                    handler.string_value("NCAAFBFBSSunBeltEast");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFBSSunBeltWest:
                    handler.string_value("NCAAFBFBSSunBeltWest");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCS:
                    handler.string_value("NCAAFBFCS");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSBigSky:
                    handler.string_value("NCAAFBFCSBigSky");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSBigSouth:
                    handler.string_value("NCAAFBFCSBigSouth");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSColonialAthleticAssociation:
                    handler.string_value("NCAAFBFCSColonialAthleticAssociation");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSIndependents:
                    handler.string_value("NCAAFBFCSIndependents");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSIvyLeague:
                    handler.string_value("NCAAFBFCSIvyLeague");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSMidEasternAthletic:
                    handler.string_value("NCAAFBFCSMidEasternAthletic");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSMissouriValley:
                    handler.string_value("NCAAFBFCSMissouriValley");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSNortheast:
                    handler.string_value("NCAAFBFCSNortheast");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSOhioValley:
                    handler.string_value("NCAAFBFCSOhioValley");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSPatriotLeague:
                    handler.string_value("NCAAFBFCSPatriotLeague");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSPioneerLeague:
                    handler.string_value("NCAAFBFCSPioneerLeague");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSSouthern:
                    handler.string_value("NCAAFBFCSSouthern");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSSouthland:
                    handler.string_value("NCAAFBFCSSouthland");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSSouthwesternAthletic:
                    handler.string_value("NCAAFBFCSSouthwesternAthletic");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSSouthwesternAthleticEast:
                    handler.string_value("NCAAFBFCSSouthwesternAthleticEast");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSSouthwesternAthleticWest:
                    handler.string_value("NCAAFBFCSSouthwesternAthleticWest");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFCSWesternAthletic:
                    handler.string_value("NCAAFBFCSWesternAthletic");
                    break;
                case TypeValueKnownValues.Value_MLSEastern:
                    handler.string_value("MLSEastern");
                    break;
                case TypeValueKnownValues.Value_MLSWestern:
                    handler.string_value("MLSWestern");
                    break;
                case TypeValueKnownValues.Value_CFLWest:
                    handler.string_value("CFLWest");
                    break;
                case TypeValueKnownValues.Value_CFLEast:
                    handler.string_value("CFLEast");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupStage:
                    handler.string_value("MensWorldCupGroupStage");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupA:
                    handler.string_value("MensWorldCupGroupA");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupB:
                    handler.string_value("MensWorldCupGroupB");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupC:
                    handler.string_value("MensWorldCupGroupC");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupD:
                    handler.string_value("MensWorldCupGroupD");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupE:
                    handler.string_value("MensWorldCupGroupE");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupF:
                    handler.string_value("MensWorldCupGroupF");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupG:
                    handler.string_value("MensWorldCupGroupG");
                    break;
                case TypeValueKnownValues.Value_MensWorldCupGroupH:
                    handler.string_value("MensWorldCupGroupH");
                    break;
                case TypeValueKnownValues.Value_NPBCentral:
                    handler.string_value("NPBCentral");
                    break;
                case TypeValueKnownValues.Value_NPBPacific:
                    handler.string_value("NPBPacific");
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

    public static SportsLeagueDivisionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsLeagueDivisionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueDivision", ignore_extras);
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
    public static SportsLeagueDivisionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsLeagueDivisionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsLeagueDivisionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueDivision", ignore_extras);
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
    public static SportsLeagueDivisionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsLeagueDivisionJSON from_text(string text, bool ignore_extras)
      {
        SportsLeagueDivisionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueDivision", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsLeagueDivisionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsLeagueDivisionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsLeagueDivisionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueDivision", ignore_extras);
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
            SportsLeagueDivisionJSON result = new SportsLeagueDivisionJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(SportsLeagueDivisionJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsLeagueDivision")
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
        protected override void handle_result(SportsLeagueDivisionJSON  result)
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
        public SportsLeagueDivisionJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsLeagueDivisionJSON  result)
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
    protected virtual void handle_result(List<SportsLeagueDivisionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsLeagueDivisionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsLeagueDivisionJSON>();
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
    public List<SportsLeagueDivisionJSON> value;
  };
  };
