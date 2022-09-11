/* file "SportsPlayoffSpecialGameJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsPlayoffSpecialGameJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_NFLWildcardAFC,
        Value_NFLWildcardNFC,
        Value_NFLDivisionalAFC,
        Value_NFLDivisionalNFC,
        Value_NFLConferenceAFC,
        Value_NFLConferenceNFC,
        Value_NFLSuperBowl,
        Value_NHLConferenceQuarterFinalsEastern,
        Value_NHLConferenceQuarterFinalsWestern,
        Value_NHLConferenceSemiFinalsEastern,
        Value_NHLConferenceSemiFinalsWestern,
        Value_NHLConferenceFinalsEastern,
        Value_NHLConferenceFinalsWestern,
        Value_NHLStanleyCup,
        Value_NHLAllStarGame,
        Value_NHLAllStarGameFinals,
        Value_NHLAllStarGameAtlanticMetropolitan,
        Value_NHLAllStarGamePacificCentral,
        Value_NHLStanleyCupSemiFinals,
        Value_NHLDivisionSemiFinalsEast,
        Value_NHLDivisionFinalsEast,
        Value_NHLDivisionSemiFinalsNorth,
        Value_NHLDivisionFinalsNorth,
        Value_NHLDivisionSemiFinalsCentral,
        Value_NHLDivisionFinalsCentral,
        Value_NHLDivisionSemiFinalsWest,
        Value_NHLDivisionFinalsWest,
        Value_MLBWildcardAmericanLeague,
        Value_MLBWildcardNationalLeague,
        Value_MLBDivisionalAmericanLeague,
        Value_MLBDivisionalNationalLeague,
        Value_MLBChampionshipAmericanLeague,
        Value_MLBChampionshipNationalLeague,
        Value_MLBWorldSeries,
        Value_MLBAllStarGame,
        Value_NBAConferenceQuarterFinalsEastern,
        Value_NBAConferenceQuarterFinalsWestern,
        Value_NBAConferenceSemiFinalsEastern,
        Value_NBAConferenceSemiFinalsWestern,
        Value_NBAConferenceFinalsEastern,
        Value_NBAConferenceFinalsWestern,
        Value_NBAFinals,
        Value_NBAAllStarGame,
        Value_MLSConferenceQuarterFinalsEastern,
        Value_MLSConferenceQuarterFinalsWestern,
        Value_MLSConferenceSemiFinalsEastern,
        Value_MLSConferenceSemiFinalsWestern,
        Value_MLSConferenceFinalsEastern,
        Value_MLSConferenceFinalsWestern,
        Value_MLSCup,
        Value_NCAAFBRoseBowl,
        Value_NCAAFBOrangeBowl,
        Value_NCAAFBSugarBowl,
        Value_NCAAFBCottonBowlClassic,
        Value_NCAAFBPeachBowl,
        Value_NCAAFBFiestaBowl,
        Value_NCAAFBSunBowl,
        Value_NCAAFBTaxSlayerBowl,
        Value_NCAAFBCitrusBowl,
        Value_NCAAFBLibertyBowl,
        Value_NCAAFBIndependenceBowl,
        Value_NCAAFBHolidayBowl,
        Value_NCAAFBOutbackBowl,
        Value_NCAAFBCactusBowl,
        Value_NCAAFBRussellAthleticBowl,
        Value_NCAAFBLasVegasBowl,
        Value_NCAAFBAlamoBowl,
        Value_NCAAFBFamousIdahoPotatoBowl,
        Value_NCAAFBMusicCityBowl,
        Value_NCAAFBGoDaddyBowl,
        Value_NCAAFBNewOrleansBowl,
        Value_NCAAFBFosterFarmsBowl,
        Value_NCAAFBHawaiiBowl,
        Value_NCAAFBBelkBowl,
        Value_NCAAFBArmedForcesBowl,
        Value_NCAAFBPoinsettiaBowl,
        Value_NCAAFBTexasBowl,
        Value_NCAAFBBirminghamBowl,
        Value_NCAAFBNewMexicoBowl,
        Value_NCAAFBMilitaryBowl,
        Value_NCAAFBStPetersburgBowl,
        Value_NCAAFBPinstripeBowl,
        Value_NCAAFBHeartOfDallasBowl,
        Value_NCAAFBBahamasBowl,
        Value_NCAAFBBocaRatonBowl,
        Value_NCAAFBCamelliaBowl,
        Value_NCAAFBMiamiBeachBowl,
        Value_NCAAFBQuickLaneBowl,
        Value_NCAAFBCureBowl,
        Value_NCAAFBArizonaBowl,
        Value_NCAAFBPAC12Championship,
        Value_NCAAFBConferenceUSAChampionship,
        Value_NCAAFBBigTenChampionship,
        Value_NCAAFBCFPNationalChampionship,
        Value_NCAAFBSECChampionship,
        Value_NCAAFBMACChampionship,
        Value_NCAAFBACCChampionship,
        Value_NCAAFBMWCChampionship,
        Value_NCAAMBFirstFour,
        Value_NCAAMBMidwestRegionalFirstRound,
        Value_NCAAMBSouthRegionalFirstRound,
        Value_NCAAMBWestRegionalFirstRound,
        Value_NCAAMBEastRegionalFirstRound,
        Value_NCAAMBMidwestRegionalSecondRound,
        Value_NCAAMBSouthRegionalSecondRound,
        Value_NCAAMBWestRegionalSecondRound,
        Value_NCAAMBEastRegionalSecondRound,
        Value_NCAAMBMidwestRegionalThirdRound,
        Value_NCAAMBSouthRegionalThirdRound,
        Value_NCAAMBWestRegionalThirdRound,
        Value_NCAAMBEastRegionalThirdRound,
        Value_NCAAMBMidwestRegionalSweet16,
        Value_NCAAMBSouthRegionalSweet16,
        Value_NCAAMBWestRegionalSweet16,
        Value_NCAAMBEastRegionalSweet16,
        Value_NCAAMBMidwestRegionalElite8,
        Value_NCAAMBSouthRegionalElite8,
        Value_NCAAMBWestRegionalElite8,
        Value_NCAAMBEastRegionalElite8,
        Value_NCAAMBFinalFourSemiFinals,
        Value_NCAAMBFinalFourFinals,
        Value_NCAAMBCITFirstRound,
        Value_NCAAMBCITSecondRound,
        Value_NCAAMBCITQuarterfinals,
        Value_NCAAMBCITSemifinals,
        Value_NCAAMBCITChampionship,
        Value_NCAAMBCBIFirstRound,
        Value_NCAAMBCBIQuarterfinals,
        Value_NCAAMBCBISemifinals,
        Value_NCAAMBCBIChampionship,
        Value_NCAAMBNITFirstRound,
        Value_NCAAMBNITSecondRound,
        Value_NCAAMBNITQuarterfinals,
        Value_NCAAMBNITSemifinals,
        Value_NCAAMBNITChampionship,
        Value_CFLSemiFinalsEast,
        Value_CFLSemiFinalsWest,
        Value_CFLFinalsEast,
        Value_CFLFinalsWest,
        Value_CFLGreyCup,
        Value_UEFAChampionsLeagueRoundOf16,
        Value_UEFAChampionsLeagueQuarterFinals,
        Value_UEFAChampionsLeagueSemiFinals,
        Value_UEFAChampionsLeagueFinal,
        Value_EuropaLeagueRoundOf32,
        Value_EuropaLeagueRoundOf16,
        Value_EuropaLeagueQuarterFinals,
        Value_EuropaLeagueSemiFinals,
        Value_EuropaLeagueFinal,
        Value_UEFASuperCup,
        Value_SoccerInternationalMensWorldCupGroupA,
        Value_SoccerInternationalMensWorldCupGroupB,
        Value_SoccerInternationalMensWorldCupGroupC,
        Value_SoccerInternationalMensWorldCupGroupD,
        Value_SoccerInternationalMensWorldCupGroupE,
        Value_SoccerInternationalMensWorldCupGroupF,
        Value_SoccerInternationalMensWorldCupGroupG,
        Value_SoccerInternationalMensWorldCupGroupH,
        Value_SoccerInternationalMensWorldCupGroupStage,
        Value_SoccerInternationalMensWorldCupRoundOf16,
        Value_SoccerInternationalMensWorldCupQuarterFinals,
        Value_SoccerInternationalMensWorldCupSemiFinals,
        Value_SoccerInternationalMensWorldCup3rdPlaceFinal,
        Value_SoccerInternationalMensWorldCupFinal,
        Value_SoccerInternationalMensWorldCupKnockoutStage,
        Value_CricketICCWorldCupFinal,
        Value_CricketICCWorldCupSemiFinal,
        Value_CricketIPLFinal,
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
                        if (String.Compare(chars, 2, "L", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'F':
                                    if (String.Compare(chars, 4, "inals", 0, 5, false) == 0)
                                      {
                                        switch (chars[9])
                                          {
                                            case 'E':
                                                if ((String.Compare(chars, 10, "ast", 0, 3, false) == 0) && (chars.Length == 13))
                                                    return TypeValueKnownValues.Value_CFLFinalsEast;
                                                break;
                                            case 'W':
                                                if ((String.Compare(chars, 10, "est", 0, 3, false) == 0) && (chars.Length == 13))
                                                    return TypeValueKnownValues.Value_CFLFinalsWest;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'G':
                                    if ((String.Compare(chars, 4, "reyCup", 0, 6, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_CFLGreyCup;
                                    break;
                                case 'S':
                                    if (String.Compare(chars, 4, "emiFinals", 0, 9, false) == 0)
                                      {
                                        switch (chars[13])
                                          {
                                            case 'E':
                                                if ((String.Compare(chars, 14, "ast", 0, 3, false) == 0) && (chars.Length == 17))
                                                    return TypeValueKnownValues.Value_CFLSemiFinalsEast;
                                                break;
                                            case 'W':
                                                if ((String.Compare(chars, 14, "est", 0, 3, false) == 0) && (chars.Length == 17))
                                                    return TypeValueKnownValues.Value_CFLSemiFinalsWest;
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
                        if (String.Compare(chars, 2, "icketI", 0, 6, false) == 0)
                          {
                            switch (chars[8])
                              {
                                case 'C':
                                    if (String.Compare(chars, 9, "CWorldCup", 0, 9, false) == 0)
                                      {
                                        switch (chars[18])
                                          {
                                            case 'F':
                                                if ((String.Compare(chars, 19, "inal", 0, 4, false) == 0) && (chars.Length == 23))
                                                    return TypeValueKnownValues.Value_CricketICCWorldCupFinal;
                                                break;
                                            case 'S':
                                                if ((String.Compare(chars, 19, "emiFinal", 0, 8, false) == 0) && (chars.Length == 27))
                                                    return TypeValueKnownValues.Value_CricketICCWorldCupSemiFinal;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'P':
                                    if ((String.Compare(chars, 9, "LFinal", 0, 6, false) == 0) && (chars.Length == 15))
                                        return TypeValueKnownValues.Value_CricketIPLFinal;
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
            case 'E':
                if (String.Compare(chars, 1, "uropaLeague", 0, 11, false) == 0)
                  {
                    switch (chars[12])
                      {
                        case 'F':
                            if ((String.Compare(chars, 13, "inal", 0, 4, false) == 0) && (chars.Length == 17))
                                return TypeValueKnownValues.Value_EuropaLeagueFinal;
                            break;
                        case 'Q':
                            if ((String.Compare(chars, 13, "uarterFinals", 0, 12, false) == 0) && (chars.Length == 25))
                                return TypeValueKnownValues.Value_EuropaLeagueQuarterFinals;
                            break;
                        case 'R':
                            if (String.Compare(chars, 13, "oundOf", 0, 6, false) == 0)
                              {
                                switch (chars[19])
                                  {
                                    case '1':
                                        if ((String.Compare(chars, 20, "6", 0, 1, false) == 0) && (chars.Length == 21))
                                            return TypeValueKnownValues.Value_EuropaLeagueRoundOf16;
                                        break;
                                    case '3':
                                        if ((String.Compare(chars, 20, "2", 0, 1, false) == 0) && (chars.Length == 21))
                                            return TypeValueKnownValues.Value_EuropaLeagueRoundOf32;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'S':
                            if ((String.Compare(chars, 13, "emiFinals", 0, 9, false) == 0) && (chars.Length == 22))
                                return TypeValueKnownValues.Value_EuropaLeagueSemiFinals;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if (String.Compare(chars, 1, "L", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'B':
                            switch (chars[3])
                              {
                                case 'A':
                                    if ((String.Compare(chars, 4, "llStarGame", 0, 10, false) == 0) && (chars.Length == 14))
                                        return TypeValueKnownValues.Value_MLBAllStarGame;
                                    break;
                                case 'C':
                                    if (String.Compare(chars, 4, "hampionship", 0, 11, false) == 0)
                                      {
                                        switch (chars[15])
                                          {
                                            case 'A':
                                                if ((String.Compare(chars, 16, "mericanLeague", 0, 13, false) == 0) && (chars.Length == 29))
                                                    return TypeValueKnownValues.Value_MLBChampionshipAmericanLeague;
                                                break;
                                            case 'N':
                                                if ((String.Compare(chars, 16, "ationalLeague", 0, 13, false) == 0) && (chars.Length == 29))
                                                    return TypeValueKnownValues.Value_MLBChampionshipNationalLeague;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'D':
                                    if (String.Compare(chars, 4, "ivisional", 0, 9, false) == 0)
                                      {
                                        switch (chars[13])
                                          {
                                            case 'A':
                                                if ((String.Compare(chars, 14, "mericanLeague", 0, 13, false) == 0) && (chars.Length == 27))
                                                    return TypeValueKnownValues.Value_MLBDivisionalAmericanLeague;
                                                break;
                                            case 'N':
                                                if ((String.Compare(chars, 14, "ationalLeague", 0, 13, false) == 0) && (chars.Length == 27))
                                                    return TypeValueKnownValues.Value_MLBDivisionalNationalLeague;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'W':
                                    switch (chars[4])
                                      {
                                        case 'i':
                                            if (String.Compare(chars, 5, "ldcard", 0, 6, false) == 0)
                                              {
                                                switch (chars[11])
                                                  {
                                                    case 'A':
                                                        if ((String.Compare(chars, 12, "mericanLeague", 0, 13, false) == 0) && (chars.Length == 25))
                                                            return TypeValueKnownValues.Value_MLBWildcardAmericanLeague;
                                                        break;
                                                    case 'N':
                                                        if ((String.Compare(chars, 12, "ationalLeague", 0, 13, false) == 0) && (chars.Length == 25))
                                                            return TypeValueKnownValues.Value_MLBWildcardNationalLeague;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'o':
                                            if ((String.Compare(chars, 5, "rldSeries", 0, 9, false) == 0) && (chars.Length == 14))
                                                return TypeValueKnownValues.Value_MLBWorldSeries;
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
                            if (String.Compare(chars, 3, "C", 0, 1, false) == 0)
                              {
                                switch (chars[4])
                                  {
                                    case 'o':
                                        if (String.Compare(chars, 5, "nference", 0, 8, false) == 0)
                                          {
                                            switch (chars[13])
                                              {
                                                case 'F':
                                                    if (String.Compare(chars, 14, "inals", 0, 5, false) == 0)
                                                      {
                                                        switch (chars[19])
                                                          {
                                                            case 'E':
                                                                if ((String.Compare(chars, 20, "astern", 0, 6, false) == 0) && (chars.Length == 26))
                                                                    return TypeValueKnownValues.Value_MLSConferenceFinalsEastern;
                                                                break;
                                                            case 'W':
                                                                if ((String.Compare(chars, 20, "estern", 0, 6, false) == 0) && (chars.Length == 26))
                                                                    return TypeValueKnownValues.Value_MLSConferenceFinalsWestern;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'Q':
                                                    if (String.Compare(chars, 14, "uarterFinals", 0, 12, false) == 0)
                                                      {
                                                        switch (chars[26])
                                                          {
                                                            case 'E':
                                                                if ((String.Compare(chars, 27, "astern", 0, 6, false) == 0) && (chars.Length == 33))
                                                                    return TypeValueKnownValues.Value_MLSConferenceQuarterFinalsEastern;
                                                                break;
                                                            case 'W':
                                                                if ((String.Compare(chars, 27, "estern", 0, 6, false) == 0) && (chars.Length == 33))
                                                                    return TypeValueKnownValues.Value_MLSConferenceQuarterFinalsWestern;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'S':
                                                    if (String.Compare(chars, 14, "emiFinals", 0, 9, false) == 0)
                                                      {
                                                        switch (chars[23])
                                                          {
                                                            case 'E':
                                                                if ((String.Compare(chars, 24, "astern", 0, 6, false) == 0) && (chars.Length == 30))
                                                                    return TypeValueKnownValues.Value_MLSConferenceSemiFinalsEastern;
                                                                break;
                                                            case 'W':
                                                                if ((String.Compare(chars, 24, "estern", 0, 6, false) == 0) && (chars.Length == 30))
                                                                    return TypeValueKnownValues.Value_MLSConferenceSemiFinalsWestern;
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
                                        if ((String.Compare(chars, 5, "p", 0, 1, false) == 0) && (chars.Length == 6))
                                            return TypeValueKnownValues.Value_MLSCup;
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
                switch (chars[1])
                  {
                    case 'B':
                        if (String.Compare(chars, 2, "A", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'A':
                                    if ((String.Compare(chars, 4, "llStarGame", 0, 10, false) == 0) && (chars.Length == 14))
                                        return TypeValueKnownValues.Value_NBAAllStarGame;
                                    break;
                                case 'C':
                                    if (String.Compare(chars, 4, "onference", 0, 9, false) == 0)
                                      {
                                        switch (chars[13])
                                          {
                                            case 'F':
                                                if (String.Compare(chars, 14, "inals", 0, 5, false) == 0)
                                                  {
                                                    switch (chars[19])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(chars, 20, "astern", 0, 6, false) == 0) && (chars.Length == 26))
                                                                return TypeValueKnownValues.Value_NBAConferenceFinalsEastern;
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(chars, 20, "estern", 0, 6, false) == 0) && (chars.Length == 26))
                                                                return TypeValueKnownValues.Value_NBAConferenceFinalsWestern;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'Q':
                                                if (String.Compare(chars, 14, "uarterFinals", 0, 12, false) == 0)
                                                  {
                                                    switch (chars[26])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(chars, 27, "astern", 0, 6, false) == 0) && (chars.Length == 33))
                                                                return TypeValueKnownValues.Value_NBAConferenceQuarterFinalsEastern;
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(chars, 27, "estern", 0, 6, false) == 0) && (chars.Length == 33))
                                                                return TypeValueKnownValues.Value_NBAConferenceQuarterFinalsWestern;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'S':
                                                if (String.Compare(chars, 14, "emiFinals", 0, 9, false) == 0)
                                                  {
                                                    switch (chars[23])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(chars, 24, "astern", 0, 6, false) == 0) && (chars.Length == 30))
                                                                return TypeValueKnownValues.Value_NBAConferenceSemiFinalsEastern;
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(chars, 24, "estern", 0, 6, false) == 0) && (chars.Length == 30))
                                                                return TypeValueKnownValues.Value_NBAConferenceSemiFinalsWestern;
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
                                    if ((String.Compare(chars, 4, "inals", 0, 5, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_NBAFinals;
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
                                                switch (chars[7])
                                                  {
                                                    case 'C':
                                                        if ((String.Compare(chars, 8, "CChampionship", 0, 13, false) == 0) && (chars.Length == 21))
                                                            return TypeValueKnownValues.Value_NCAAFBACCChampionship;
                                                        break;
                                                    case 'l':
                                                        if ((String.Compare(chars, 8, "amoBowl", 0, 7, false) == 0) && (chars.Length == 15))
                                                            return TypeValueKnownValues.Value_NCAAFBAlamoBowl;
                                                        break;
                                                    case 'r':
                                                        switch (chars[8])
                                                          {
                                                            case 'i':
                                                                if ((String.Compare(chars, 9, "zonaBowl", 0, 8, false) == 0) && (chars.Length == 17))
                                                                    return TypeValueKnownValues.Value_NCAAFBArizonaBowl;
                                                                break;
                                                            case 'm':
                                                                if ((String.Compare(chars, 9, "edForcesBowl", 0, 12, false) == 0) && (chars.Length == 21))
                                                                    return TypeValueKnownValues.Value_NCAAFBArmedForcesBowl;
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
                                                switch (chars[7])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(chars, 8, "hamasBowl", 0, 9, false) == 0) && (chars.Length == 17))
                                                            return TypeValueKnownValues.Value_NCAAFBBahamasBowl;
                                                        break;
                                                    case 'e':
                                                        if ((String.Compare(chars, 8, "lkBowl", 0, 6, false) == 0) && (chars.Length == 14))
                                                            return TypeValueKnownValues.Value_NCAAFBBelkBowl;
                                                        break;
                                                    case 'i':
                                                        switch (chars[8])
                                                          {
                                                            case 'g':
                                                                if ((String.Compare(chars, 9, "TenChampionship", 0, 15, false) == 0) && (chars.Length == 24))
                                                                    return TypeValueKnownValues.Value_NCAAFBBigTenChampionship;
                                                                break;
                                                            case 'r':
                                                                if ((String.Compare(chars, 9, "minghamBowl", 0, 11, false) == 0) && (chars.Length == 20))
                                                                    return TypeValueKnownValues.Value_NCAAFBBirminghamBowl;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'o':
                                                        if ((String.Compare(chars, 8, "caRatonBowl", 0, 11, false) == 0) && (chars.Length == 19))
                                                            return TypeValueKnownValues.Value_NCAAFBBocaRatonBowl;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'C':
                                                switch (chars[7])
                                                  {
                                                    case 'F':
                                                        if ((String.Compare(chars, 8, "PNationalChampionship", 0, 21, false) == 0) && (chars.Length == 29))
                                                            return TypeValueKnownValues.Value_NCAAFBCFPNationalChampionship;
                                                        break;
                                                    case 'a':
                                                        switch (chars[8])
                                                          {
                                                            case 'c':
                                                                if ((String.Compare(chars, 9, "tusBowl", 0, 7, false) == 0) && (chars.Length == 16))
                                                                    return TypeValueKnownValues.Value_NCAAFBCactusBowl;
                                                                break;
                                                            case 'm':
                                                                if ((String.Compare(chars, 9, "elliaBowl", 0, 9, false) == 0) && (chars.Length == 18))
                                                                    return TypeValueKnownValues.Value_NCAAFBCamelliaBowl;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'i':
                                                        if ((String.Compare(chars, 8, "trusBowl", 0, 8, false) == 0) && (chars.Length == 16))
                                                            return TypeValueKnownValues.Value_NCAAFBCitrusBowl;
                                                        break;
                                                    case 'o':
                                                        switch (chars[8])
                                                          {
                                                            case 'n':
                                                                if ((String.Compare(chars, 9, "ferenceUSAChampionship", 0, 22, false) == 0) && (chars.Length == 31))
                                                                    return TypeValueKnownValues.Value_NCAAFBConferenceUSAChampionship;
                                                                break;
                                                            case 't':
                                                                if ((String.Compare(chars, 9, "tonBowlClassic", 0, 14, false) == 0) && (chars.Length == 23))
                                                                    return TypeValueKnownValues.Value_NCAAFBCottonBowlClassic;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(chars, 8, "reBowl", 0, 6, false) == 0) && (chars.Length == 14))
                                                            return TypeValueKnownValues.Value_NCAAFBCureBowl;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'F':
                                                switch (chars[7])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(chars, 8, "mousIdahoPotatoBowl", 0, 19, false) == 0) && (chars.Length == 27))
                                                            return TypeValueKnownValues.Value_NCAAFBFamousIdahoPotatoBowl;
                                                        break;
                                                    case 'i':
                                                        if ((String.Compare(chars, 8, "estaBowl", 0, 8, false) == 0) && (chars.Length == 16))
                                                            return TypeValueKnownValues.Value_NCAAFBFiestaBowl;
                                                        break;
                                                    case 'o':
                                                        if ((String.Compare(chars, 8, "sterFarmsBowl", 0, 13, false) == 0) && (chars.Length == 21))
                                                            return TypeValueKnownValues.Value_NCAAFBFosterFarmsBowl;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'G':
                                                if ((String.Compare(chars, 7, "oDaddyBowl", 0, 10, false) == 0) && (chars.Length == 17))
                                                    return TypeValueKnownValues.Value_NCAAFBGoDaddyBowl;
                                                break;
                                            case 'H':
                                                switch (chars[7])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(chars, 8, "waiiBowl", 0, 8, false) == 0) && (chars.Length == 16))
                                                            return TypeValueKnownValues.Value_NCAAFBHawaiiBowl;
                                                        break;
                                                    case 'e':
                                                        if ((String.Compare(chars, 8, "artOfDallasBowl", 0, 15, false) == 0) && (chars.Length == 23))
                                                            return TypeValueKnownValues.Value_NCAAFBHeartOfDallasBowl;
                                                        break;
                                                    case 'o':
                                                        if ((String.Compare(chars, 8, "lidayBowl", 0, 9, false) == 0) && (chars.Length == 17))
                                                            return TypeValueKnownValues.Value_NCAAFBHolidayBowl;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'I':
                                                if ((String.Compare(chars, 7, "ndependenceBowl", 0, 15, false) == 0) && (chars.Length == 22))
                                                    return TypeValueKnownValues.Value_NCAAFBIndependenceBowl;
                                                break;
                                            case 'L':
                                                switch (chars[7])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(chars, 8, "sVegasBowl", 0, 10, false) == 0) && (chars.Length == 18))
                                                            return TypeValueKnownValues.Value_NCAAFBLasVegasBowl;
                                                        break;
                                                    case 'i':
                                                        if ((String.Compare(chars, 8, "bertyBowl", 0, 9, false) == 0) && (chars.Length == 17))
                                                            return TypeValueKnownValues.Value_NCAAFBLibertyBowl;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'M':
                                                switch (chars[7])
                                                  {
                                                    case 'A':
                                                        if ((String.Compare(chars, 8, "CChampionship", 0, 13, false) == 0) && (chars.Length == 21))
                                                            return TypeValueKnownValues.Value_NCAAFBMACChampionship;
                                                        break;
                                                    case 'W':
                                                        if ((String.Compare(chars, 8, "CChampionship", 0, 13, false) == 0) && (chars.Length == 21))
                                                            return TypeValueKnownValues.Value_NCAAFBMWCChampionship;
                                                        break;
                                                    case 'i':
                                                        switch (chars[8])
                                                          {
                                                            case 'a':
                                                                if ((String.Compare(chars, 9, "miBeachBowl", 0, 11, false) == 0) && (chars.Length == 20))
                                                                    return TypeValueKnownValues.Value_NCAAFBMiamiBeachBowl;
                                                                break;
                                                            case 'l':
                                                                if ((String.Compare(chars, 9, "itaryBowl", 0, 9, false) == 0) && (chars.Length == 18))
                                                                    return TypeValueKnownValues.Value_NCAAFBMilitaryBowl;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(chars, 8, "sicCityBowl", 0, 11, false) == 0) && (chars.Length == 19))
                                                            return TypeValueKnownValues.Value_NCAAFBMusicCityBowl;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'N':
                                                if (String.Compare(chars, 7, "ew", 0, 2, false) == 0)
                                                  {
                                                    switch (chars[9])
                                                      {
                                                        case 'M':
                                                            if ((String.Compare(chars, 10, "exicoBowl", 0, 9, false) == 0) && (chars.Length == 19))
                                                                return TypeValueKnownValues.Value_NCAAFBNewMexicoBowl;
                                                            break;
                                                        case 'O':
                                                            if ((String.Compare(chars, 10, "rleansBowl", 0, 10, false) == 0) && (chars.Length == 20))
                                                                return TypeValueKnownValues.Value_NCAAFBNewOrleansBowl;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'O':
                                                switch (chars[7])
                                                  {
                                                    case 'r':
                                                        if ((String.Compare(chars, 8, "angeBowl", 0, 8, false) == 0) && (chars.Length == 16))
                                                            return TypeValueKnownValues.Value_NCAAFBOrangeBowl;
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(chars, 8, "tbackBowl", 0, 9, false) == 0) && (chars.Length == 17))
                                                            return TypeValueKnownValues.Value_NCAAFBOutbackBowl;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'P':
                                                switch (chars[7])
                                                  {
                                                    case 'A':
                                                        if ((String.Compare(chars, 8, "C12Championship", 0, 15, false) == 0) && (chars.Length == 23))
                                                            return TypeValueKnownValues.Value_NCAAFBPAC12Championship;
                                                        break;
                                                    case 'e':
                                                        if ((String.Compare(chars, 8, "achBowl", 0, 7, false) == 0) && (chars.Length == 15))
                                                            return TypeValueKnownValues.Value_NCAAFBPeachBowl;
                                                        break;
                                                    case 'i':
                                                        if ((String.Compare(chars, 8, "nstripeBowl", 0, 11, false) == 0) && (chars.Length == 19))
                                                            return TypeValueKnownValues.Value_NCAAFBPinstripeBowl;
                                                        break;
                                                    case 'o':
                                                        if ((String.Compare(chars, 8, "insettiaBowl", 0, 12, false) == 0) && (chars.Length == 20))
                                                            return TypeValueKnownValues.Value_NCAAFBPoinsettiaBowl;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'Q':
                                                if ((String.Compare(chars, 7, "uickLaneBowl", 0, 12, false) == 0) && (chars.Length == 19))
                                                    return TypeValueKnownValues.Value_NCAAFBQuickLaneBowl;
                                                break;
                                            case 'R':
                                                switch (chars[7])
                                                  {
                                                    case 'o':
                                                        if ((String.Compare(chars, 8, "seBowl", 0, 6, false) == 0) && (chars.Length == 14))
                                                            return TypeValueKnownValues.Value_NCAAFBRoseBowl;
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(chars, 8, "ssellAthleticBowl", 0, 17, false) == 0) && (chars.Length == 25))
                                                            return TypeValueKnownValues.Value_NCAAFBRussellAthleticBowl;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'S':
                                                switch (chars[7])
                                                  {
                                                    case 'E':
                                                        if ((String.Compare(chars, 8, "CChampionship", 0, 13, false) == 0) && (chars.Length == 21))
                                                            return TypeValueKnownValues.Value_NCAAFBSECChampionship;
                                                        break;
                                                    case 't':
                                                        if ((String.Compare(chars, 8, "PetersburgBowl", 0, 14, false) == 0) && (chars.Length == 22))
                                                            return TypeValueKnownValues.Value_NCAAFBStPetersburgBowl;
                                                        break;
                                                    case 'u':
                                                        switch (chars[8])
                                                          {
                                                            case 'g':
                                                                if ((String.Compare(chars, 9, "arBowl", 0, 6, false) == 0) && (chars.Length == 15))
                                                                    return TypeValueKnownValues.Value_NCAAFBSugarBowl;
                                                                break;
                                                            case 'n':
                                                                if ((String.Compare(chars, 9, "Bowl", 0, 4, false) == 0) && (chars.Length == 13))
                                                                    return TypeValueKnownValues.Value_NCAAFBSunBowl;
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
                                                switch (chars[7])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(chars, 8, "xSlayerBowl", 0, 11, false) == 0) && (chars.Length == 19))
                                                            return TypeValueKnownValues.Value_NCAAFBTaxSlayerBowl;
                                                        break;
                                                    case 'e':
                                                        if ((String.Compare(chars, 8, "xasBowl", 0, 7, false) == 0) && (chars.Length == 15))
                                                            return TypeValueKnownValues.Value_NCAAFBTexasBowl;
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
                                case 'M':
                                    if (String.Compare(chars, 5, "B", 0, 1, false) == 0)
                                      {
                                        switch (chars[6])
                                          {
                                            case 'C':
                                                switch (chars[7])
                                                  {
                                                    case 'B':
                                                        if (String.Compare(chars, 8, "I", 0, 1, false) == 0)
                                                          {
                                                            switch (chars[9])
                                                              {
                                                                case 'C':
                                                                    if ((String.Compare(chars, 10, "hampionship", 0, 11, false) == 0) && (chars.Length == 21))
                                                                        return TypeValueKnownValues.Value_NCAAMBCBIChampionship;
                                                                    break;
                                                                case 'F':
                                                                    if ((String.Compare(chars, 10, "irstRound", 0, 9, false) == 0) && (chars.Length == 19))
                                                                        return TypeValueKnownValues.Value_NCAAMBCBIFirstRound;
                                                                    break;
                                                                case 'Q':
                                                                    if ((String.Compare(chars, 10, "uarterfinals", 0, 12, false) == 0) && (chars.Length == 22))
                                                                        return TypeValueKnownValues.Value_NCAAMBCBIQuarterfinals;
                                                                    break;
                                                                case 'S':
                                                                    if ((String.Compare(chars, 10, "emifinals", 0, 9, false) == 0) && (chars.Length == 19))
                                                                        return TypeValueKnownValues.Value_NCAAMBCBISemifinals;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                          }
                                                        break;
                                                    case 'I':
                                                        if (String.Compare(chars, 8, "T", 0, 1, false) == 0)
                                                          {
                                                            switch (chars[9])
                                                              {
                                                                case 'C':
                                                                    if ((String.Compare(chars, 10, "hampionship", 0, 11, false) == 0) && (chars.Length == 21))
                                                                        return TypeValueKnownValues.Value_NCAAMBCITChampionship;
                                                                    break;
                                                                case 'F':
                                                                    if ((String.Compare(chars, 10, "irstRound", 0, 9, false) == 0) && (chars.Length == 19))
                                                                        return TypeValueKnownValues.Value_NCAAMBCITFirstRound;
                                                                    break;
                                                                case 'Q':
                                                                    if ((String.Compare(chars, 10, "uarterfinals", 0, 12, false) == 0) && (chars.Length == 22))
                                                                        return TypeValueKnownValues.Value_NCAAMBCITQuarterfinals;
                                                                    break;
                                                                case 'S':
                                                                    if (String.Compare(chars, 10, "e", 0, 1, false) == 0)
                                                                      {
                                                                        switch (chars[11])
                                                                          {
                                                                            case 'c':
                                                                                if ((String.Compare(chars, 12, "ondRound", 0, 8, false) == 0) && (chars.Length == 20))
                                                                                    return TypeValueKnownValues.Value_NCAAMBCITSecondRound;
                                                                                break;
                                                                            case 'm':
                                                                                if ((String.Compare(chars, 12, "ifinals", 0, 7, false) == 0) && (chars.Length == 19))
                                                                                    return TypeValueKnownValues.Value_NCAAMBCITSemifinals;
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
                                            case 'E':
                                                if (String.Compare(chars, 7, "astRegional", 0, 11, false) == 0)
                                                  {
                                                    switch (chars[18])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(chars, 19, "lite8", 0, 5, false) == 0) && (chars.Length == 24))
                                                                return TypeValueKnownValues.Value_NCAAMBEastRegionalElite8;
                                                            break;
                                                        case 'F':
                                                            if ((String.Compare(chars, 19, "irstRound", 0, 9, false) == 0) && (chars.Length == 28))
                                                                return TypeValueKnownValues.Value_NCAAMBEastRegionalFirstRound;
                                                            break;
                                                        case 'S':
                                                            switch (chars[19])
                                                              {
                                                                case 'e':
                                                                    if ((String.Compare(chars, 20, "condRound", 0, 9, false) == 0) && (chars.Length == 29))
                                                                        return TypeValueKnownValues.Value_NCAAMBEastRegionalSecondRound;
                                                                    break;
                                                                case 'w':
                                                                    if ((String.Compare(chars, 20, "eet16", 0, 5, false) == 0) && (chars.Length == 25))
                                                                        return TypeValueKnownValues.Value_NCAAMBEastRegionalSweet16;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'T':
                                                            if ((String.Compare(chars, 19, "hirdRound", 0, 9, false) == 0) && (chars.Length == 28))
                                                                return TypeValueKnownValues.Value_NCAAMBEastRegionalThirdRound;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'F':
                                                if (String.Compare(chars, 7, "i", 0, 1, false) == 0)
                                                  {
                                                    switch (chars[8])
                                                      {
                                                        case 'n':
                                                            if (String.Compare(chars, 9, "alFour", 0, 6, false) == 0)
                                                              {
                                                                switch (chars[15])
                                                                  {
                                                                    case 'F':
                                                                        if ((String.Compare(chars, 16, "inals", 0, 5, false) == 0) && (chars.Length == 21))
                                                                            return TypeValueKnownValues.Value_NCAAMBFinalFourFinals;
                                                                        break;
                                                                    case 'S':
                                                                        if ((String.Compare(chars, 16, "emiFinals", 0, 9, false) == 0) && (chars.Length == 25))
                                                                            return TypeValueKnownValues.Value_NCAAMBFinalFourSemiFinals;
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                              }
                                                            break;
                                                        case 'r':
                                                            if ((String.Compare(chars, 9, "stFour", 0, 6, false) == 0) && (chars.Length == 15))
                                                                return TypeValueKnownValues.Value_NCAAMBFirstFour;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'M':
                                                if (String.Compare(chars, 7, "idwestRegional", 0, 14, false) == 0)
                                                  {
                                                    switch (chars[21])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(chars, 22, "lite8", 0, 5, false) == 0) && (chars.Length == 27))
                                                                return TypeValueKnownValues.Value_NCAAMBMidwestRegionalElite8;
                                                            break;
                                                        case 'F':
                                                            if ((String.Compare(chars, 22, "irstRound", 0, 9, false) == 0) && (chars.Length == 31))
                                                                return TypeValueKnownValues.Value_NCAAMBMidwestRegionalFirstRound;
                                                            break;
                                                        case 'S':
                                                            switch (chars[22])
                                                              {
                                                                case 'e':
                                                                    if ((String.Compare(chars, 23, "condRound", 0, 9, false) == 0) && (chars.Length == 32))
                                                                        return TypeValueKnownValues.Value_NCAAMBMidwestRegionalSecondRound;
                                                                    break;
                                                                case 'w':
                                                                    if ((String.Compare(chars, 23, "eet16", 0, 5, false) == 0) && (chars.Length == 28))
                                                                        return TypeValueKnownValues.Value_NCAAMBMidwestRegionalSweet16;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'T':
                                                            if ((String.Compare(chars, 22, "hirdRound", 0, 9, false) == 0) && (chars.Length == 31))
                                                                return TypeValueKnownValues.Value_NCAAMBMidwestRegionalThirdRound;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'N':
                                                if (String.Compare(chars, 7, "IT", 0, 2, false) == 0)
                                                  {
                                                    switch (chars[9])
                                                      {
                                                        case 'C':
                                                            if ((String.Compare(chars, 10, "hampionship", 0, 11, false) == 0) && (chars.Length == 21))
                                                                return TypeValueKnownValues.Value_NCAAMBNITChampionship;
                                                            break;
                                                        case 'F':
                                                            if ((String.Compare(chars, 10, "irstRound", 0, 9, false) == 0) && (chars.Length == 19))
                                                                return TypeValueKnownValues.Value_NCAAMBNITFirstRound;
                                                            break;
                                                        case 'Q':
                                                            if ((String.Compare(chars, 10, "uarterfinals", 0, 12, false) == 0) && (chars.Length == 22))
                                                                return TypeValueKnownValues.Value_NCAAMBNITQuarterfinals;
                                                            break;
                                                        case 'S':
                                                            if (String.Compare(chars, 10, "e", 0, 1, false) == 0)
                                                              {
                                                                switch (chars[11])
                                                                  {
                                                                    case 'c':
                                                                        if ((String.Compare(chars, 12, "ondRound", 0, 8, false) == 0) && (chars.Length == 20))
                                                                            return TypeValueKnownValues.Value_NCAAMBNITSecondRound;
                                                                        break;
                                                                    case 'm':
                                                                        if ((String.Compare(chars, 12, "ifinals", 0, 7, false) == 0) && (chars.Length == 19))
                                                                            return TypeValueKnownValues.Value_NCAAMBNITSemifinals;
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
                                                if (String.Compare(chars, 7, "outhRegional", 0, 12, false) == 0)
                                                  {
                                                    switch (chars[19])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(chars, 20, "lite8", 0, 5, false) == 0) && (chars.Length == 25))
                                                                return TypeValueKnownValues.Value_NCAAMBSouthRegionalElite8;
                                                            break;
                                                        case 'F':
                                                            if ((String.Compare(chars, 20, "irstRound", 0, 9, false) == 0) && (chars.Length == 29))
                                                                return TypeValueKnownValues.Value_NCAAMBSouthRegionalFirstRound;
                                                            break;
                                                        case 'S':
                                                            switch (chars[20])
                                                              {
                                                                case 'e':
                                                                    if ((String.Compare(chars, 21, "condRound", 0, 9, false) == 0) && (chars.Length == 30))
                                                                        return TypeValueKnownValues.Value_NCAAMBSouthRegionalSecondRound;
                                                                    break;
                                                                case 'w':
                                                                    if ((String.Compare(chars, 21, "eet16", 0, 5, false) == 0) && (chars.Length == 26))
                                                                        return TypeValueKnownValues.Value_NCAAMBSouthRegionalSweet16;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'T':
                                                            if ((String.Compare(chars, 20, "hirdRound", 0, 9, false) == 0) && (chars.Length == 29))
                                                                return TypeValueKnownValues.Value_NCAAMBSouthRegionalThirdRound;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'W':
                                                if (String.Compare(chars, 7, "estRegional", 0, 11, false) == 0)
                                                  {
                                                    switch (chars[18])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(chars, 19, "lite8", 0, 5, false) == 0) && (chars.Length == 24))
                                                                return TypeValueKnownValues.Value_NCAAMBWestRegionalElite8;
                                                            break;
                                                        case 'F':
                                                            if ((String.Compare(chars, 19, "irstRound", 0, 9, false) == 0) && (chars.Length == 28))
                                                                return TypeValueKnownValues.Value_NCAAMBWestRegionalFirstRound;
                                                            break;
                                                        case 'S':
                                                            switch (chars[19])
                                                              {
                                                                case 'e':
                                                                    if ((String.Compare(chars, 20, "condRound", 0, 9, false) == 0) && (chars.Length == 29))
                                                                        return TypeValueKnownValues.Value_NCAAMBWestRegionalSecondRound;
                                                                    break;
                                                                case 'w':
                                                                    if ((String.Compare(chars, 20, "eet16", 0, 5, false) == 0) && (chars.Length == 25))
                                                                        return TypeValueKnownValues.Value_NCAAMBWestRegionalSweet16;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'T':
                                                            if ((String.Compare(chars, 19, "hirdRound", 0, 9, false) == 0) && (chars.Length == 28))
                                                                return TypeValueKnownValues.Value_NCAAMBWestRegionalThirdRound;
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
                                case 'C':
                                    if (String.Compare(chars, 4, "onference", 0, 9, false) == 0)
                                      {
                                        switch (chars[13])
                                          {
                                            case 'A':
                                                if ((String.Compare(chars, 14, "FC", 0, 2, false) == 0) && (chars.Length == 16))
                                                    return TypeValueKnownValues.Value_NFLConferenceAFC;
                                                break;
                                            case 'N':
                                                if ((String.Compare(chars, 14, "FC", 0, 2, false) == 0) && (chars.Length == 16))
                                                    return TypeValueKnownValues.Value_NFLConferenceNFC;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'D':
                                    if (String.Compare(chars, 4, "ivisional", 0, 9, false) == 0)
                                      {
                                        switch (chars[13])
                                          {
                                            case 'A':
                                                if ((String.Compare(chars, 14, "FC", 0, 2, false) == 0) && (chars.Length == 16))
                                                    return TypeValueKnownValues.Value_NFLDivisionalAFC;
                                                break;
                                            case 'N':
                                                if ((String.Compare(chars, 14, "FC", 0, 2, false) == 0) && (chars.Length == 16))
                                                    return TypeValueKnownValues.Value_NFLDivisionalNFC;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'S':
                                    if ((String.Compare(chars, 4, "uperBowl", 0, 8, false) == 0) && (chars.Length == 12))
                                        return TypeValueKnownValues.Value_NFLSuperBowl;
                                    break;
                                case 'W':
                                    if (String.Compare(chars, 4, "ildcard", 0, 7, false) == 0)
                                      {
                                        switch (chars[11])
                                          {
                                            case 'A':
                                                if ((String.Compare(chars, 12, "FC", 0, 2, false) == 0) && (chars.Length == 14))
                                                    return TypeValueKnownValues.Value_NFLWildcardAFC;
                                                break;
                                            case 'N':
                                                if ((String.Compare(chars, 12, "FC", 0, 2, false) == 0) && (chars.Length == 14))
                                                    return TypeValueKnownValues.Value_NFLWildcardNFC;
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
                                case 'A':
                                    if (String.Compare(chars, 4, "llStarGame", 0, 10, false) == 0)
                                      {
                                        if (chars.Length == 14)
                                          {
                                            return TypeValueKnownValues.Value_NHLAllStarGame;
                                          }
                                        switch (chars[14])
                                          {
                                            case 'A':
                                                if ((String.Compare(chars, 15, "tlanticMetropolitan", 0, 19, false) == 0) && (chars.Length == 34))
                                                    return TypeValueKnownValues.Value_NHLAllStarGameAtlanticMetropolitan;
                                                break;
                                            case 'F':
                                                if ((String.Compare(chars, 15, "inals", 0, 5, false) == 0) && (chars.Length == 20))
                                                    return TypeValueKnownValues.Value_NHLAllStarGameFinals;
                                                break;
                                            case 'P':
                                                if ((String.Compare(chars, 15, "acificCentral", 0, 13, false) == 0) && (chars.Length == 28))
                                                    return TypeValueKnownValues.Value_NHLAllStarGamePacificCentral;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'C':
                                    if (String.Compare(chars, 4, "onference", 0, 9, false) == 0)
                                      {
                                        switch (chars[13])
                                          {
                                            case 'F':
                                                if (String.Compare(chars, 14, "inals", 0, 5, false) == 0)
                                                  {
                                                    switch (chars[19])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(chars, 20, "astern", 0, 6, false) == 0) && (chars.Length == 26))
                                                                return TypeValueKnownValues.Value_NHLConferenceFinalsEastern;
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(chars, 20, "estern", 0, 6, false) == 0) && (chars.Length == 26))
                                                                return TypeValueKnownValues.Value_NHLConferenceFinalsWestern;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'Q':
                                                if (String.Compare(chars, 14, "uarterFinals", 0, 12, false) == 0)
                                                  {
                                                    switch (chars[26])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(chars, 27, "astern", 0, 6, false) == 0) && (chars.Length == 33))
                                                                return TypeValueKnownValues.Value_NHLConferenceQuarterFinalsEastern;
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(chars, 27, "estern", 0, 6, false) == 0) && (chars.Length == 33))
                                                                return TypeValueKnownValues.Value_NHLConferenceQuarterFinalsWestern;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'S':
                                                if (String.Compare(chars, 14, "emiFinals", 0, 9, false) == 0)
                                                  {
                                                    switch (chars[23])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(chars, 24, "astern", 0, 6, false) == 0) && (chars.Length == 30))
                                                                return TypeValueKnownValues.Value_NHLConferenceSemiFinalsEastern;
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(chars, 24, "estern", 0, 6, false) == 0) && (chars.Length == 30))
                                                                return TypeValueKnownValues.Value_NHLConferenceSemiFinalsWestern;
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
                                case 'D':
                                    if (String.Compare(chars, 4, "ivision", 0, 7, false) == 0)
                                      {
                                        switch (chars[11])
                                          {
                                            case 'F':
                                                if (String.Compare(chars, 12, "inals", 0, 5, false) == 0)
                                                  {
                                                    switch (chars[17])
                                                      {
                                                        case 'C':
                                                            if ((String.Compare(chars, 18, "entral", 0, 6, false) == 0) && (chars.Length == 24))
                                                                return TypeValueKnownValues.Value_NHLDivisionFinalsCentral;
                                                            break;
                                                        case 'E':
                                                            if ((String.Compare(chars, 18, "ast", 0, 3, false) == 0) && (chars.Length == 21))
                                                                return TypeValueKnownValues.Value_NHLDivisionFinalsEast;
                                                            break;
                                                        case 'N':
                                                            if ((String.Compare(chars, 18, "orth", 0, 4, false) == 0) && (chars.Length == 22))
                                                                return TypeValueKnownValues.Value_NHLDivisionFinalsNorth;
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(chars, 18, "est", 0, 3, false) == 0) && (chars.Length == 21))
                                                                return TypeValueKnownValues.Value_NHLDivisionFinalsWest;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'S':
                                                if (String.Compare(chars, 12, "emiFinals", 0, 9, false) == 0)
                                                  {
                                                    switch (chars[21])
                                                      {
                                                        case 'C':
                                                            if ((String.Compare(chars, 22, "entral", 0, 6, false) == 0) && (chars.Length == 28))
                                                                return TypeValueKnownValues.Value_NHLDivisionSemiFinalsCentral;
                                                            break;
                                                        case 'E':
                                                            if ((String.Compare(chars, 22, "ast", 0, 3, false) == 0) && (chars.Length == 25))
                                                                return TypeValueKnownValues.Value_NHLDivisionSemiFinalsEast;
                                                            break;
                                                        case 'N':
                                                            if ((String.Compare(chars, 22, "orth", 0, 4, false) == 0) && (chars.Length == 26))
                                                                return TypeValueKnownValues.Value_NHLDivisionSemiFinalsNorth;
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(chars, 22, "est", 0, 3, false) == 0) && (chars.Length == 25))
                                                                return TypeValueKnownValues.Value_NHLDivisionSemiFinalsWest;
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
                                    if (String.Compare(chars, 4, "tanleyCup", 0, 9, false) == 0)
                                      {
                                        if (chars.Length == 13)
                                          {
                                            return TypeValueKnownValues.Value_NHLStanleyCup;
                                          }
                                        switch (chars[13])
                                          {
                                            case 'S':
                                                if ((String.Compare(chars, 14, "emiFinals", 0, 9, false) == 0) && (chars.Length == 23))
                                                    return TypeValueKnownValues.Value_NHLStanleyCupSemiFinals;
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
            case 'S':
                if (String.Compare(chars, 1, "occerInternationalMensWorldCup", 0, 30, false) == 0)
                  {
                    switch (chars[31])
                      {
                        case '3':
                            if ((String.Compare(chars, 32, "rdPlaceFinal", 0, 12, false) == 0) && (chars.Length == 44))
                                return TypeValueKnownValues.Value_SoccerInternationalMensWorldCup3rdPlaceFinal;
                            break;
                        case 'F':
                            if ((String.Compare(chars, 32, "inal", 0, 4, false) == 0) && (chars.Length == 36))
                                return TypeValueKnownValues.Value_SoccerInternationalMensWorldCupFinal;
                            break;
                        case 'G':
                            if (String.Compare(chars, 32, "roup", 0, 4, false) == 0)
                              {
                                switch (chars[36])
                                  {
                                    case 'A':
                                        if (chars.Length == 37)
                                            return TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupA;
                                        break;
                                    case 'B':
                                        if (chars.Length == 37)
                                            return TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupB;
                                        break;
                                    case 'C':
                                        if (chars.Length == 37)
                                            return TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupC;
                                        break;
                                    case 'D':
                                        if (chars.Length == 37)
                                            return TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupD;
                                        break;
                                    case 'E':
                                        if (chars.Length == 37)
                                            return TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupE;
                                        break;
                                    case 'F':
                                        if (chars.Length == 37)
                                            return TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupF;
                                        break;
                                    case 'G':
                                        if (chars.Length == 37)
                                            return TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupG;
                                        break;
                                    case 'H':
                                        if (chars.Length == 37)
                                            return TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupH;
                                        break;
                                    case 'S':
                                        if ((String.Compare(chars, 37, "tage", 0, 4, false) == 0) && (chars.Length == 41))
                                            return TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupStage;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'K':
                            if ((String.Compare(chars, 32, "nockoutStage", 0, 12, false) == 0) && (chars.Length == 44))
                                return TypeValueKnownValues.Value_SoccerInternationalMensWorldCupKnockoutStage;
                            break;
                        case 'Q':
                            if ((String.Compare(chars, 32, "uarterFinals", 0, 12, false) == 0) && (chars.Length == 44))
                                return TypeValueKnownValues.Value_SoccerInternationalMensWorldCupQuarterFinals;
                            break;
                        case 'R':
                            if ((String.Compare(chars, 32, "oundOf16", 0, 8, false) == 0) && (chars.Length == 40))
                                return TypeValueKnownValues.Value_SoccerInternationalMensWorldCupRoundOf16;
                            break;
                        case 'S':
                            if ((String.Compare(chars, 32, "emiFinals", 0, 9, false) == 0) && (chars.Length == 41))
                                return TypeValueKnownValues.Value_SoccerInternationalMensWorldCupSemiFinals;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'U':
                if (String.Compare(chars, 1, "EFA", 0, 3, false) == 0)
                  {
                    switch (chars[4])
                      {
                        case 'C':
                            if (String.Compare(chars, 5, "hampionsLeague", 0, 14, false) == 0)
                              {
                                switch (chars[19])
                                  {
                                    case 'F':
                                        if ((String.Compare(chars, 20, "inal", 0, 4, false) == 0) && (chars.Length == 24))
                                            return TypeValueKnownValues.Value_UEFAChampionsLeagueFinal;
                                        break;
                                    case 'Q':
                                        if ((String.Compare(chars, 20, "uarterFinals", 0, 12, false) == 0) && (chars.Length == 32))
                                            return TypeValueKnownValues.Value_UEFAChampionsLeagueQuarterFinals;
                                        break;
                                    case 'R':
                                        if ((String.Compare(chars, 20, "oundOf16", 0, 8, false) == 0) && (chars.Length == 28))
                                            return TypeValueKnownValues.Value_UEFAChampionsLeagueRoundOf16;
                                        break;
                                    case 'S':
                                        if ((String.Compare(chars, 20, "emiFinals", 0, 9, false) == 0) && (chars.Length == 29))
                                            return TypeValueKnownValues.Value_UEFAChampionsLeagueSemiFinals;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'S':
                            if ((String.Compare(chars, 5, "uperCup", 0, 7, false) == 0) && (chars.Length == 12))
                                return TypeValueKnownValues.Value_UEFASuperCup;
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
            case TypeValueKnownValues.Value_NFLWildcardAFC:
                return "NFLWildcardAFC";
            case TypeValueKnownValues.Value_NFLWildcardNFC:
                return "NFLWildcardNFC";
            case TypeValueKnownValues.Value_NFLDivisionalAFC:
                return "NFLDivisionalAFC";
            case TypeValueKnownValues.Value_NFLDivisionalNFC:
                return "NFLDivisionalNFC";
            case TypeValueKnownValues.Value_NFLConferenceAFC:
                return "NFLConferenceAFC";
            case TypeValueKnownValues.Value_NFLConferenceNFC:
                return "NFLConferenceNFC";
            case TypeValueKnownValues.Value_NFLSuperBowl:
                return "NFLSuperBowl";
            case TypeValueKnownValues.Value_NHLConferenceQuarterFinalsEastern:
                return "NHLConferenceQuarterFinalsEastern";
            case TypeValueKnownValues.Value_NHLConferenceQuarterFinalsWestern:
                return "NHLConferenceQuarterFinalsWestern";
            case TypeValueKnownValues.Value_NHLConferenceSemiFinalsEastern:
                return "NHLConferenceSemiFinalsEastern";
            case TypeValueKnownValues.Value_NHLConferenceSemiFinalsWestern:
                return "NHLConferenceSemiFinalsWestern";
            case TypeValueKnownValues.Value_NHLConferenceFinalsEastern:
                return "NHLConferenceFinalsEastern";
            case TypeValueKnownValues.Value_NHLConferenceFinalsWestern:
                return "NHLConferenceFinalsWestern";
            case TypeValueKnownValues.Value_NHLStanleyCup:
                return "NHLStanleyCup";
            case TypeValueKnownValues.Value_NHLAllStarGame:
                return "NHLAllStarGame";
            case TypeValueKnownValues.Value_NHLAllStarGameFinals:
                return "NHLAllStarGameFinals";
            case TypeValueKnownValues.Value_NHLAllStarGameAtlanticMetropolitan:
                return "NHLAllStarGameAtlanticMetropolitan";
            case TypeValueKnownValues.Value_NHLAllStarGamePacificCentral:
                return "NHLAllStarGamePacificCentral";
            case TypeValueKnownValues.Value_NHLStanleyCupSemiFinals:
                return "NHLStanleyCupSemiFinals";
            case TypeValueKnownValues.Value_NHLDivisionSemiFinalsEast:
                return "NHLDivisionSemiFinalsEast";
            case TypeValueKnownValues.Value_NHLDivisionFinalsEast:
                return "NHLDivisionFinalsEast";
            case TypeValueKnownValues.Value_NHLDivisionSemiFinalsNorth:
                return "NHLDivisionSemiFinalsNorth";
            case TypeValueKnownValues.Value_NHLDivisionFinalsNorth:
                return "NHLDivisionFinalsNorth";
            case TypeValueKnownValues.Value_NHLDivisionSemiFinalsCentral:
                return "NHLDivisionSemiFinalsCentral";
            case TypeValueKnownValues.Value_NHLDivisionFinalsCentral:
                return "NHLDivisionFinalsCentral";
            case TypeValueKnownValues.Value_NHLDivisionSemiFinalsWest:
                return "NHLDivisionSemiFinalsWest";
            case TypeValueKnownValues.Value_NHLDivisionFinalsWest:
                return "NHLDivisionFinalsWest";
            case TypeValueKnownValues.Value_MLBWildcardAmericanLeague:
                return "MLBWildcardAmericanLeague";
            case TypeValueKnownValues.Value_MLBWildcardNationalLeague:
                return "MLBWildcardNationalLeague";
            case TypeValueKnownValues.Value_MLBDivisionalAmericanLeague:
                return "MLBDivisionalAmericanLeague";
            case TypeValueKnownValues.Value_MLBDivisionalNationalLeague:
                return "MLBDivisionalNationalLeague";
            case TypeValueKnownValues.Value_MLBChampionshipAmericanLeague:
                return "MLBChampionshipAmericanLeague";
            case TypeValueKnownValues.Value_MLBChampionshipNationalLeague:
                return "MLBChampionshipNationalLeague";
            case TypeValueKnownValues.Value_MLBWorldSeries:
                return "MLBWorldSeries";
            case TypeValueKnownValues.Value_MLBAllStarGame:
                return "MLBAllStarGame";
            case TypeValueKnownValues.Value_NBAConferenceQuarterFinalsEastern:
                return "NBAConferenceQuarterFinalsEastern";
            case TypeValueKnownValues.Value_NBAConferenceQuarterFinalsWestern:
                return "NBAConferenceQuarterFinalsWestern";
            case TypeValueKnownValues.Value_NBAConferenceSemiFinalsEastern:
                return "NBAConferenceSemiFinalsEastern";
            case TypeValueKnownValues.Value_NBAConferenceSemiFinalsWestern:
                return "NBAConferenceSemiFinalsWestern";
            case TypeValueKnownValues.Value_NBAConferenceFinalsEastern:
                return "NBAConferenceFinalsEastern";
            case TypeValueKnownValues.Value_NBAConferenceFinalsWestern:
                return "NBAConferenceFinalsWestern";
            case TypeValueKnownValues.Value_NBAFinals:
                return "NBAFinals";
            case TypeValueKnownValues.Value_NBAAllStarGame:
                return "NBAAllStarGame";
            case TypeValueKnownValues.Value_MLSConferenceQuarterFinalsEastern:
                return "MLSConferenceQuarterFinalsEastern";
            case TypeValueKnownValues.Value_MLSConferenceQuarterFinalsWestern:
                return "MLSConferenceQuarterFinalsWestern";
            case TypeValueKnownValues.Value_MLSConferenceSemiFinalsEastern:
                return "MLSConferenceSemiFinalsEastern";
            case TypeValueKnownValues.Value_MLSConferenceSemiFinalsWestern:
                return "MLSConferenceSemiFinalsWestern";
            case TypeValueKnownValues.Value_MLSConferenceFinalsEastern:
                return "MLSConferenceFinalsEastern";
            case TypeValueKnownValues.Value_MLSConferenceFinalsWestern:
                return "MLSConferenceFinalsWestern";
            case TypeValueKnownValues.Value_MLSCup:
                return "MLSCup";
            case TypeValueKnownValues.Value_NCAAFBRoseBowl:
                return "NCAAFBRoseBowl";
            case TypeValueKnownValues.Value_NCAAFBOrangeBowl:
                return "NCAAFBOrangeBowl";
            case TypeValueKnownValues.Value_NCAAFBSugarBowl:
                return "NCAAFBSugarBowl";
            case TypeValueKnownValues.Value_NCAAFBCottonBowlClassic:
                return "NCAAFBCottonBowlClassic";
            case TypeValueKnownValues.Value_NCAAFBPeachBowl:
                return "NCAAFBPeachBowl";
            case TypeValueKnownValues.Value_NCAAFBFiestaBowl:
                return "NCAAFBFiestaBowl";
            case TypeValueKnownValues.Value_NCAAFBSunBowl:
                return "NCAAFBSunBowl";
            case TypeValueKnownValues.Value_NCAAFBTaxSlayerBowl:
                return "NCAAFBTaxSlayerBowl";
            case TypeValueKnownValues.Value_NCAAFBCitrusBowl:
                return "NCAAFBCitrusBowl";
            case TypeValueKnownValues.Value_NCAAFBLibertyBowl:
                return "NCAAFBLibertyBowl";
            case TypeValueKnownValues.Value_NCAAFBIndependenceBowl:
                return "NCAAFBIndependenceBowl";
            case TypeValueKnownValues.Value_NCAAFBHolidayBowl:
                return "NCAAFBHolidayBowl";
            case TypeValueKnownValues.Value_NCAAFBOutbackBowl:
                return "NCAAFBOutbackBowl";
            case TypeValueKnownValues.Value_NCAAFBCactusBowl:
                return "NCAAFBCactusBowl";
            case TypeValueKnownValues.Value_NCAAFBRussellAthleticBowl:
                return "NCAAFBRussellAthleticBowl";
            case TypeValueKnownValues.Value_NCAAFBLasVegasBowl:
                return "NCAAFBLasVegasBowl";
            case TypeValueKnownValues.Value_NCAAFBAlamoBowl:
                return "NCAAFBAlamoBowl";
            case TypeValueKnownValues.Value_NCAAFBFamousIdahoPotatoBowl:
                return "NCAAFBFamousIdahoPotatoBowl";
            case TypeValueKnownValues.Value_NCAAFBMusicCityBowl:
                return "NCAAFBMusicCityBowl";
            case TypeValueKnownValues.Value_NCAAFBGoDaddyBowl:
                return "NCAAFBGoDaddyBowl";
            case TypeValueKnownValues.Value_NCAAFBNewOrleansBowl:
                return "NCAAFBNewOrleansBowl";
            case TypeValueKnownValues.Value_NCAAFBFosterFarmsBowl:
                return "NCAAFBFosterFarmsBowl";
            case TypeValueKnownValues.Value_NCAAFBHawaiiBowl:
                return "NCAAFBHawaiiBowl";
            case TypeValueKnownValues.Value_NCAAFBBelkBowl:
                return "NCAAFBBelkBowl";
            case TypeValueKnownValues.Value_NCAAFBArmedForcesBowl:
                return "NCAAFBArmedForcesBowl";
            case TypeValueKnownValues.Value_NCAAFBPoinsettiaBowl:
                return "NCAAFBPoinsettiaBowl";
            case TypeValueKnownValues.Value_NCAAFBTexasBowl:
                return "NCAAFBTexasBowl";
            case TypeValueKnownValues.Value_NCAAFBBirminghamBowl:
                return "NCAAFBBirminghamBowl";
            case TypeValueKnownValues.Value_NCAAFBNewMexicoBowl:
                return "NCAAFBNewMexicoBowl";
            case TypeValueKnownValues.Value_NCAAFBMilitaryBowl:
                return "NCAAFBMilitaryBowl";
            case TypeValueKnownValues.Value_NCAAFBStPetersburgBowl:
                return "NCAAFBStPetersburgBowl";
            case TypeValueKnownValues.Value_NCAAFBPinstripeBowl:
                return "NCAAFBPinstripeBowl";
            case TypeValueKnownValues.Value_NCAAFBHeartOfDallasBowl:
                return "NCAAFBHeartOfDallasBowl";
            case TypeValueKnownValues.Value_NCAAFBBahamasBowl:
                return "NCAAFBBahamasBowl";
            case TypeValueKnownValues.Value_NCAAFBBocaRatonBowl:
                return "NCAAFBBocaRatonBowl";
            case TypeValueKnownValues.Value_NCAAFBCamelliaBowl:
                return "NCAAFBCamelliaBowl";
            case TypeValueKnownValues.Value_NCAAFBMiamiBeachBowl:
                return "NCAAFBMiamiBeachBowl";
            case TypeValueKnownValues.Value_NCAAFBQuickLaneBowl:
                return "NCAAFBQuickLaneBowl";
            case TypeValueKnownValues.Value_NCAAFBCureBowl:
                return "NCAAFBCureBowl";
            case TypeValueKnownValues.Value_NCAAFBArizonaBowl:
                return "NCAAFBArizonaBowl";
            case TypeValueKnownValues.Value_NCAAFBPAC12Championship:
                return "NCAAFBPAC12Championship";
            case TypeValueKnownValues.Value_NCAAFBConferenceUSAChampionship:
                return "NCAAFBConferenceUSAChampionship";
            case TypeValueKnownValues.Value_NCAAFBBigTenChampionship:
                return "NCAAFBBigTenChampionship";
            case TypeValueKnownValues.Value_NCAAFBCFPNationalChampionship:
                return "NCAAFBCFPNationalChampionship";
            case TypeValueKnownValues.Value_NCAAFBSECChampionship:
                return "NCAAFBSECChampionship";
            case TypeValueKnownValues.Value_NCAAFBMACChampionship:
                return "NCAAFBMACChampionship";
            case TypeValueKnownValues.Value_NCAAFBACCChampionship:
                return "NCAAFBACCChampionship";
            case TypeValueKnownValues.Value_NCAAFBMWCChampionship:
                return "NCAAFBMWCChampionship";
            case TypeValueKnownValues.Value_NCAAMBFirstFour:
                return "NCAAMBFirstFour";
            case TypeValueKnownValues.Value_NCAAMBMidwestRegionalFirstRound:
                return "NCAAMBMidwestRegionalFirstRound";
            case TypeValueKnownValues.Value_NCAAMBSouthRegionalFirstRound:
                return "NCAAMBSouthRegionalFirstRound";
            case TypeValueKnownValues.Value_NCAAMBWestRegionalFirstRound:
                return "NCAAMBWestRegionalFirstRound";
            case TypeValueKnownValues.Value_NCAAMBEastRegionalFirstRound:
                return "NCAAMBEastRegionalFirstRound";
            case TypeValueKnownValues.Value_NCAAMBMidwestRegionalSecondRound:
                return "NCAAMBMidwestRegionalSecondRound";
            case TypeValueKnownValues.Value_NCAAMBSouthRegionalSecondRound:
                return "NCAAMBSouthRegionalSecondRound";
            case TypeValueKnownValues.Value_NCAAMBWestRegionalSecondRound:
                return "NCAAMBWestRegionalSecondRound";
            case TypeValueKnownValues.Value_NCAAMBEastRegionalSecondRound:
                return "NCAAMBEastRegionalSecondRound";
            case TypeValueKnownValues.Value_NCAAMBMidwestRegionalThirdRound:
                return "NCAAMBMidwestRegionalThirdRound";
            case TypeValueKnownValues.Value_NCAAMBSouthRegionalThirdRound:
                return "NCAAMBSouthRegionalThirdRound";
            case TypeValueKnownValues.Value_NCAAMBWestRegionalThirdRound:
                return "NCAAMBWestRegionalThirdRound";
            case TypeValueKnownValues.Value_NCAAMBEastRegionalThirdRound:
                return "NCAAMBEastRegionalThirdRound";
            case TypeValueKnownValues.Value_NCAAMBMidwestRegionalSweet16:
                return "NCAAMBMidwestRegionalSweet16";
            case TypeValueKnownValues.Value_NCAAMBSouthRegionalSweet16:
                return "NCAAMBSouthRegionalSweet16";
            case TypeValueKnownValues.Value_NCAAMBWestRegionalSweet16:
                return "NCAAMBWestRegionalSweet16";
            case TypeValueKnownValues.Value_NCAAMBEastRegionalSweet16:
                return "NCAAMBEastRegionalSweet16";
            case TypeValueKnownValues.Value_NCAAMBMidwestRegionalElite8:
                return "NCAAMBMidwestRegionalElite8";
            case TypeValueKnownValues.Value_NCAAMBSouthRegionalElite8:
                return "NCAAMBSouthRegionalElite8";
            case TypeValueKnownValues.Value_NCAAMBWestRegionalElite8:
                return "NCAAMBWestRegionalElite8";
            case TypeValueKnownValues.Value_NCAAMBEastRegionalElite8:
                return "NCAAMBEastRegionalElite8";
            case TypeValueKnownValues.Value_NCAAMBFinalFourSemiFinals:
                return "NCAAMBFinalFourSemiFinals";
            case TypeValueKnownValues.Value_NCAAMBFinalFourFinals:
                return "NCAAMBFinalFourFinals";
            case TypeValueKnownValues.Value_NCAAMBCITFirstRound:
                return "NCAAMBCITFirstRound";
            case TypeValueKnownValues.Value_NCAAMBCITSecondRound:
                return "NCAAMBCITSecondRound";
            case TypeValueKnownValues.Value_NCAAMBCITQuarterfinals:
                return "NCAAMBCITQuarterfinals";
            case TypeValueKnownValues.Value_NCAAMBCITSemifinals:
                return "NCAAMBCITSemifinals";
            case TypeValueKnownValues.Value_NCAAMBCITChampionship:
                return "NCAAMBCITChampionship";
            case TypeValueKnownValues.Value_NCAAMBCBIFirstRound:
                return "NCAAMBCBIFirstRound";
            case TypeValueKnownValues.Value_NCAAMBCBIQuarterfinals:
                return "NCAAMBCBIQuarterfinals";
            case TypeValueKnownValues.Value_NCAAMBCBISemifinals:
                return "NCAAMBCBISemifinals";
            case TypeValueKnownValues.Value_NCAAMBCBIChampionship:
                return "NCAAMBCBIChampionship";
            case TypeValueKnownValues.Value_NCAAMBNITFirstRound:
                return "NCAAMBNITFirstRound";
            case TypeValueKnownValues.Value_NCAAMBNITSecondRound:
                return "NCAAMBNITSecondRound";
            case TypeValueKnownValues.Value_NCAAMBNITQuarterfinals:
                return "NCAAMBNITQuarterfinals";
            case TypeValueKnownValues.Value_NCAAMBNITSemifinals:
                return "NCAAMBNITSemifinals";
            case TypeValueKnownValues.Value_NCAAMBNITChampionship:
                return "NCAAMBNITChampionship";
            case TypeValueKnownValues.Value_CFLSemiFinalsEast:
                return "CFLSemiFinalsEast";
            case TypeValueKnownValues.Value_CFLSemiFinalsWest:
                return "CFLSemiFinalsWest";
            case TypeValueKnownValues.Value_CFLFinalsEast:
                return "CFLFinalsEast";
            case TypeValueKnownValues.Value_CFLFinalsWest:
                return "CFLFinalsWest";
            case TypeValueKnownValues.Value_CFLGreyCup:
                return "CFLGreyCup";
            case TypeValueKnownValues.Value_UEFAChampionsLeagueRoundOf16:
                return "UEFAChampionsLeagueRoundOf16";
            case TypeValueKnownValues.Value_UEFAChampionsLeagueQuarterFinals:
                return "UEFAChampionsLeagueQuarterFinals";
            case TypeValueKnownValues.Value_UEFAChampionsLeagueSemiFinals:
                return "UEFAChampionsLeagueSemiFinals";
            case TypeValueKnownValues.Value_UEFAChampionsLeagueFinal:
                return "UEFAChampionsLeagueFinal";
            case TypeValueKnownValues.Value_EuropaLeagueRoundOf32:
                return "EuropaLeagueRoundOf32";
            case TypeValueKnownValues.Value_EuropaLeagueRoundOf16:
                return "EuropaLeagueRoundOf16";
            case TypeValueKnownValues.Value_EuropaLeagueQuarterFinals:
                return "EuropaLeagueQuarterFinals";
            case TypeValueKnownValues.Value_EuropaLeagueSemiFinals:
                return "EuropaLeagueSemiFinals";
            case TypeValueKnownValues.Value_EuropaLeagueFinal:
                return "EuropaLeagueFinal";
            case TypeValueKnownValues.Value_UEFASuperCup:
                return "UEFASuperCup";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupA:
                return "SoccerInternationalMensWorldCupGroupA";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupB:
                return "SoccerInternationalMensWorldCupGroupB";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupC:
                return "SoccerInternationalMensWorldCupGroupC";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupD:
                return "SoccerInternationalMensWorldCupGroupD";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupE:
                return "SoccerInternationalMensWorldCupGroupE";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupF:
                return "SoccerInternationalMensWorldCupGroupF";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupG:
                return "SoccerInternationalMensWorldCupGroupG";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupH:
                return "SoccerInternationalMensWorldCupGroupH";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupStage:
                return "SoccerInternationalMensWorldCupGroupStage";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupRoundOf16:
                return "SoccerInternationalMensWorldCupRoundOf16";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupQuarterFinals:
                return "SoccerInternationalMensWorldCupQuarterFinals";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupSemiFinals:
                return "SoccerInternationalMensWorldCupSemiFinals";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCup3rdPlaceFinal:
                return "SoccerInternationalMensWorldCup3rdPlaceFinal";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupFinal:
                return "SoccerInternationalMensWorldCupFinal";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupKnockoutStage:
                return "SoccerInternationalMensWorldCupKnockoutStage";
            case TypeValueKnownValues.Value_CricketICCWorldCupFinal:
                return "CricketICCWorldCupFinal";
            case TypeValueKnownValues.Value_CricketICCWorldCupSemiFinal:
                return "CricketICCWorldCupSemiFinal";
            case TypeValueKnownValues.Value_CricketIPLFinal:
                return "CricketIPLFinal";
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
            throw new Exception("The value for field Value of SportsPlayoffSpecialGameJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'F':
                        if (String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'F':
                                    if (String.Compare(json_string.getData(), 4, "inals", 0, 5, false) == 0)
                                      {
                                        switch (json_string.getData()[9])
                                          {
                                            case 'E':
                                                if ((String.Compare(json_string.getData(), 10, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_CFLFinalsEast;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'W':
                                                if ((String.Compare(json_string.getData(), 10, "est", 0, 3, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_CFLFinalsWest;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'G':
                                    if ((String.Compare(json_string.getData(), 4, "reyCup", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_CFLGreyCup;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'S':
                                    if (String.Compare(json_string.getData(), 4, "emiFinals", 0, 9, false) == 0)
                                      {
                                        switch (json_string.getData()[13])
                                          {
                                            case 'E':
                                                if ((String.Compare(json_string.getData(), 14, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 17))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_CFLSemiFinalsEast;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'W':
                                                if ((String.Compare(json_string.getData(), 14, "est", 0, 3, false) == 0) && (json_string.getData().Length == 17))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_CFLSemiFinalsWest;
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
                        if (String.Compare(json_string.getData(), 2, "icketI", 0, 6, false) == 0)
                          {
                            switch (json_string.getData()[8])
                              {
                                case 'C':
                                    if (String.Compare(json_string.getData(), 9, "CWorldCup", 0, 9, false) == 0)
                                      {
                                        switch (json_string.getData()[18])
                                          {
                                            case 'F':
                                                if ((String.Compare(json_string.getData(), 19, "inal", 0, 4, false) == 0) && (json_string.getData().Length == 23))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_CricketICCWorldCupFinal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'S':
                                                if ((String.Compare(json_string.getData(), 19, "emiFinal", 0, 8, false) == 0) && (json_string.getData().Length == 27))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_CricketICCWorldCupSemiFinal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'P':
                                    if ((String.Compare(json_string.getData(), 9, "LFinal", 0, 6, false) == 0) && (json_string.getData().Length == 15))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_CricketIPLFinal;
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
            case 'E':
                if (String.Compare(json_string.getData(), 1, "uropaLeague", 0, 11, false) == 0)
                  {
                    switch (json_string.getData()[12])
                      {
                        case 'F':
                            if ((String.Compare(json_string.getData(), 13, "inal", 0, 4, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_EuropaLeagueFinal;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'Q':
                            if ((String.Compare(json_string.getData(), 13, "uarterFinals", 0, 12, false) == 0) && (json_string.getData().Length == 25))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_EuropaLeagueQuarterFinals;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'R':
                            if (String.Compare(json_string.getData(), 13, "oundOf", 0, 6, false) == 0)
                              {
                                switch (json_string.getData()[19])
                                  {
                                    case '1':
                                        if ((String.Compare(json_string.getData(), 20, "6", 0, 1, false) == 0) && (json_string.getData().Length == 21))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_EuropaLeagueRoundOf16;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case '3':
                                        if ((String.Compare(json_string.getData(), 20, "2", 0, 1, false) == 0) && (json_string.getData().Length == 21))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_EuropaLeagueRoundOf32;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'S':
                            if ((String.Compare(json_string.getData(), 13, "emiFinals", 0, 9, false) == 0) && (json_string.getData().Length == 22))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_EuropaLeagueSemiFinals;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if (String.Compare(json_string.getData(), 1, "L", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'B':
                            switch (json_string.getData()[3])
                              {
                                case 'A':
                                    if ((String.Compare(json_string.getData(), 4, "llStarGame", 0, 10, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_MLBAllStarGame;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'C':
                                    if (String.Compare(json_string.getData(), 4, "hampionship", 0, 11, false) == 0)
                                      {
                                        switch (json_string.getData()[15])
                                          {
                                            case 'A':
                                                if ((String.Compare(json_string.getData(), 16, "mericanLeague", 0, 13, false) == 0) && (json_string.getData().Length == 29))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_MLBChampionshipAmericanLeague;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'N':
                                                if ((String.Compare(json_string.getData(), 16, "ationalLeague", 0, 13, false) == 0) && (json_string.getData().Length == 29))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_MLBChampionshipNationalLeague;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'D':
                                    if (String.Compare(json_string.getData(), 4, "ivisional", 0, 9, false) == 0)
                                      {
                                        switch (json_string.getData()[13])
                                          {
                                            case 'A':
                                                if ((String.Compare(json_string.getData(), 14, "mericanLeague", 0, 13, false) == 0) && (json_string.getData().Length == 27))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_MLBDivisionalAmericanLeague;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'N':
                                                if ((String.Compare(json_string.getData(), 14, "ationalLeague", 0, 13, false) == 0) && (json_string.getData().Length == 27))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_MLBDivisionalNationalLeague;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'W':
                                    switch (json_string.getData()[4])
                                      {
                                        case 'i':
                                            if (String.Compare(json_string.getData(), 5, "ldcard", 0, 6, false) == 0)
                                              {
                                                switch (json_string.getData()[11])
                                                  {
                                                    case 'A':
                                                        if ((String.Compare(json_string.getData(), 12, "mericanLeague", 0, 13, false) == 0) && (json_string.getData().Length == 25))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_MLBWildcardAmericanLeague;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'N':
                                                        if ((String.Compare(json_string.getData(), 12, "ationalLeague", 0, 13, false) == 0) && (json_string.getData().Length == 25))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_MLBWildcardNationalLeague;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'o':
                                            if ((String.Compare(json_string.getData(), 5, "rldSeries", 0, 9, false) == 0) && (json_string.getData().Length == 14))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_MLBWorldSeries;
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
                            if (String.Compare(json_string.getData(), 3, "C", 0, 1, false) == 0)
                              {
                                switch (json_string.getData()[4])
                                  {
                                    case 'o':
                                        if (String.Compare(json_string.getData(), 5, "nference", 0, 8, false) == 0)
                                          {
                                            switch (json_string.getData()[13])
                                              {
                                                case 'F':
                                                    if (String.Compare(json_string.getData(), 14, "inals", 0, 5, false) == 0)
                                                      {
                                                        switch (json_string.getData()[19])
                                                          {
                                                            case 'E':
                                                                if ((String.Compare(json_string.getData(), 20, "astern", 0, 6, false) == 0) && (json_string.getData().Length == 26))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_MLSConferenceFinalsEastern;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'W':
                                                                if ((String.Compare(json_string.getData(), 20, "estern", 0, 6, false) == 0) && (json_string.getData().Length == 26))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_MLSConferenceFinalsWestern;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'Q':
                                                    if (String.Compare(json_string.getData(), 14, "uarterFinals", 0, 12, false) == 0)
                                                      {
                                                        switch (json_string.getData()[26])
                                                          {
                                                            case 'E':
                                                                if ((String.Compare(json_string.getData(), 27, "astern", 0, 6, false) == 0) && (json_string.getData().Length == 33))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_MLSConferenceQuarterFinalsEastern;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'W':
                                                                if ((String.Compare(json_string.getData(), 27, "estern", 0, 6, false) == 0) && (json_string.getData().Length == 33))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_MLSConferenceQuarterFinalsWestern;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'S':
                                                    if (String.Compare(json_string.getData(), 14, "emiFinals", 0, 9, false) == 0)
                                                      {
                                                        switch (json_string.getData()[23])
                                                          {
                                                            case 'E':
                                                                if ((String.Compare(json_string.getData(), 24, "astern", 0, 6, false) == 0) && (json_string.getData().Length == 30))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_MLSConferenceSemiFinalsEastern;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'W':
                                                                if ((String.Compare(json_string.getData(), 24, "estern", 0, 6, false) == 0) && (json_string.getData().Length == 30))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_MLSConferenceSemiFinalsWestern;
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
                                        if ((String.Compare(json_string.getData(), 5, "p", 0, 1, false) == 0) && (json_string.getData().Length == 6))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_MLSCup;
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
                switch (json_string.getData()[1])
                  {
                    case 'B':
                        if (String.Compare(json_string.getData(), 2, "A", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'A':
                                    if ((String.Compare(json_string.getData(), 4, "llStarGame", 0, 10, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NBAAllStarGame;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'C':
                                    if (String.Compare(json_string.getData(), 4, "onference", 0, 9, false) == 0)
                                      {
                                        switch (json_string.getData()[13])
                                          {
                                            case 'F':
                                                if (String.Compare(json_string.getData(), 14, "inals", 0, 5, false) == 0)
                                                  {
                                                    switch (json_string.getData()[19])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(json_string.getData(), 20, "astern", 0, 6, false) == 0) && (json_string.getData().Length == 26))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NBAConferenceFinalsEastern;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(json_string.getData(), 20, "estern", 0, 6, false) == 0) && (json_string.getData().Length == 26))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NBAConferenceFinalsWestern;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'Q':
                                                if (String.Compare(json_string.getData(), 14, "uarterFinals", 0, 12, false) == 0)
                                                  {
                                                    switch (json_string.getData()[26])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(json_string.getData(), 27, "astern", 0, 6, false) == 0) && (json_string.getData().Length == 33))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NBAConferenceQuarterFinalsEastern;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(json_string.getData(), 27, "estern", 0, 6, false) == 0) && (json_string.getData().Length == 33))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NBAConferenceQuarterFinalsWestern;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'S':
                                                if (String.Compare(json_string.getData(), 14, "emiFinals", 0, 9, false) == 0)
                                                  {
                                                    switch (json_string.getData()[23])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(json_string.getData(), 24, "astern", 0, 6, false) == 0) && (json_string.getData().Length == 30))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NBAConferenceSemiFinalsEastern;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(json_string.getData(), 24, "estern", 0, 6, false) == 0) && (json_string.getData().Length == 30))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NBAConferenceSemiFinalsWestern;
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
                                    if ((String.Compare(json_string.getData(), 4, "inals", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NBAFinals;
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
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'C':
                                                        if ((String.Compare(json_string.getData(), 8, "CChampionship", 0, 13, false) == 0) && (json_string.getData().Length == 21))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBACCChampionship;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'l':
                                                        if ((String.Compare(json_string.getData(), 8, "amoBowl", 0, 7, false) == 0) && (json_string.getData().Length == 15))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBAlamoBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'r':
                                                        switch (json_string.getData()[8])
                                                          {
                                                            case 'i':
                                                                if ((String.Compare(json_string.getData(), 9, "zonaBowl", 0, 8, false) == 0) && (json_string.getData().Length == 17))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBArizonaBowl;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'm':
                                                                if ((String.Compare(json_string.getData(), 9, "edForcesBowl", 0, 12, false) == 0) && (json_string.getData().Length == 21))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBArmedForcesBowl;
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
                                            case 'B':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(json_string.getData(), 8, "hamasBowl", 0, 9, false) == 0) && (json_string.getData().Length == 17))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBBahamasBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'e':
                                                        if ((String.Compare(json_string.getData(), 8, "lkBowl", 0, 6, false) == 0) && (json_string.getData().Length == 14))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBBelkBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'i':
                                                        switch (json_string.getData()[8])
                                                          {
                                                            case 'g':
                                                                if ((String.Compare(json_string.getData(), 9, "TenChampionship", 0, 15, false) == 0) && (json_string.getData().Length == 24))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBBigTenChampionship;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'r':
                                                                if ((String.Compare(json_string.getData(), 9, "minghamBowl", 0, 11, false) == 0) && (json_string.getData().Length == 20))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBBirminghamBowl;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'o':
                                                        if ((String.Compare(json_string.getData(), 8, "caRatonBowl", 0, 11, false) == 0) && (json_string.getData().Length == 19))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBBocaRatonBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'C':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'F':
                                                        if ((String.Compare(json_string.getData(), 8, "PNationalChampionship", 0, 21, false) == 0) && (json_string.getData().Length == 29))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBCFPNationalChampionship;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'a':
                                                        switch (json_string.getData()[8])
                                                          {
                                                            case 'c':
                                                                if ((String.Compare(json_string.getData(), 9, "tusBowl", 0, 7, false) == 0) && (json_string.getData().Length == 16))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBCactusBowl;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'm':
                                                                if ((String.Compare(json_string.getData(), 9, "elliaBowl", 0, 9, false) == 0) && (json_string.getData().Length == 18))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBCamelliaBowl;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'i':
                                                        if ((String.Compare(json_string.getData(), 8, "trusBowl", 0, 8, false) == 0) && (json_string.getData().Length == 16))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBCitrusBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'o':
                                                        switch (json_string.getData()[8])
                                                          {
                                                            case 'n':
                                                                if ((String.Compare(json_string.getData(), 9, "ferenceUSAChampionship", 0, 22, false) == 0) && (json_string.getData().Length == 31))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBConferenceUSAChampionship;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 't':
                                                                if ((String.Compare(json_string.getData(), 9, "tonBowlClassic", 0, 14, false) == 0) && (json_string.getData().Length == 23))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBCottonBowlClassic;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(json_string.getData(), 8, "reBowl", 0, 6, false) == 0) && (json_string.getData().Length == 14))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBCureBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'F':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(json_string.getData(), 8, "mousIdahoPotatoBowl", 0, 19, false) == 0) && (json_string.getData().Length == 27))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFamousIdahoPotatoBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'i':
                                                        if ((String.Compare(json_string.getData(), 8, "estaBowl", 0, 8, false) == 0) && (json_string.getData().Length == 16))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFiestaBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'o':
                                                        if ((String.Compare(json_string.getData(), 8, "sterFarmsBowl", 0, 13, false) == 0) && (json_string.getData().Length == 21))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBFosterFarmsBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'G':
                                                if ((String.Compare(json_string.getData(), 7, "oDaddyBowl", 0, 10, false) == 0) && (json_string.getData().Length == 17))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBGoDaddyBowl;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'H':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(json_string.getData(), 8, "waiiBowl", 0, 8, false) == 0) && (json_string.getData().Length == 16))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBHawaiiBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'e':
                                                        if ((String.Compare(json_string.getData(), 8, "artOfDallasBowl", 0, 15, false) == 0) && (json_string.getData().Length == 23))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBHeartOfDallasBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'o':
                                                        if ((String.Compare(json_string.getData(), 8, "lidayBowl", 0, 9, false) == 0) && (json_string.getData().Length == 17))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBHolidayBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'I':
                                                if ((String.Compare(json_string.getData(), 7, "ndependenceBowl", 0, 15, false) == 0) && (json_string.getData().Length == 22))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBIndependenceBowl;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'L':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(json_string.getData(), 8, "sVegasBowl", 0, 10, false) == 0) && (json_string.getData().Length == 18))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBLasVegasBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'i':
                                                        if ((String.Compare(json_string.getData(), 8, "bertyBowl", 0, 9, false) == 0) && (json_string.getData().Length == 17))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBLibertyBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'M':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'A':
                                                        if ((String.Compare(json_string.getData(), 8, "CChampionship", 0, 13, false) == 0) && (json_string.getData().Length == 21))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBMACChampionship;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'W':
                                                        if ((String.Compare(json_string.getData(), 8, "CChampionship", 0, 13, false) == 0) && (json_string.getData().Length == 21))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBMWCChampionship;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'i':
                                                        switch (json_string.getData()[8])
                                                          {
                                                            case 'a':
                                                                if ((String.Compare(json_string.getData(), 9, "miBeachBowl", 0, 11, false) == 0) && (json_string.getData().Length == 20))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBMiamiBeachBowl;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'l':
                                                                if ((String.Compare(json_string.getData(), 9, "itaryBowl", 0, 9, false) == 0) && (json_string.getData().Length == 18))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBMilitaryBowl;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(json_string.getData(), 8, "sicCityBowl", 0, 11, false) == 0) && (json_string.getData().Length == 19))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBMusicCityBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'N':
                                                if (String.Compare(json_string.getData(), 7, "ew", 0, 2, false) == 0)
                                                  {
                                                    switch (json_string.getData()[9])
                                                      {
                                                        case 'M':
                                                            if ((String.Compare(json_string.getData(), 10, "exicoBowl", 0, 9, false) == 0) && (json_string.getData().Length == 19))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBNewMexicoBowl;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'O':
                                                            if ((String.Compare(json_string.getData(), 10, "rleansBowl", 0, 10, false) == 0) && (json_string.getData().Length == 20))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBNewOrleansBowl;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'O':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'r':
                                                        if ((String.Compare(json_string.getData(), 8, "angeBowl", 0, 8, false) == 0) && (json_string.getData().Length == 16))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBOrangeBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(json_string.getData(), 8, "tbackBowl", 0, 9, false) == 0) && (json_string.getData().Length == 17))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBOutbackBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'P':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'A':
                                                        if ((String.Compare(json_string.getData(), 8, "C12Championship", 0, 15, false) == 0) && (json_string.getData().Length == 23))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBPAC12Championship;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'e':
                                                        if ((String.Compare(json_string.getData(), 8, "achBowl", 0, 7, false) == 0) && (json_string.getData().Length == 15))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBPeachBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'i':
                                                        if ((String.Compare(json_string.getData(), 8, "nstripeBowl", 0, 11, false) == 0) && (json_string.getData().Length == 19))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBPinstripeBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'o':
                                                        if ((String.Compare(json_string.getData(), 8, "insettiaBowl", 0, 12, false) == 0) && (json_string.getData().Length == 20))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBPoinsettiaBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'Q':
                                                if ((String.Compare(json_string.getData(), 7, "uickLaneBowl", 0, 12, false) == 0) && (json_string.getData().Length == 19))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBQuickLaneBowl;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'R':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'o':
                                                        if ((String.Compare(json_string.getData(), 8, "seBowl", 0, 6, false) == 0) && (json_string.getData().Length == 14))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBRoseBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(json_string.getData(), 8, "ssellAthleticBowl", 0, 17, false) == 0) && (json_string.getData().Length == 25))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBRussellAthleticBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'S':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'E':
                                                        if ((String.Compare(json_string.getData(), 8, "CChampionship", 0, 13, false) == 0) && (json_string.getData().Length == 21))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBSECChampionship;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 't':
                                                        if ((String.Compare(json_string.getData(), 8, "PetersburgBowl", 0, 14, false) == 0) && (json_string.getData().Length == 22))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBStPetersburgBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'u':
                                                        switch (json_string.getData()[8])
                                                          {
                                                            case 'g':
                                                                if ((String.Compare(json_string.getData(), 9, "arBowl", 0, 6, false) == 0) && (json_string.getData().Length == 15))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBSugarBowl;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'n':
                                                                if ((String.Compare(json_string.getData(), 9, "Bowl", 0, 4, false) == 0) && (json_string.getData().Length == 13))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBSunBowl;
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
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(json_string.getData(), 8, "xSlayerBowl", 0, 11, false) == 0) && (json_string.getData().Length == 19))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBTaxSlayerBowl;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'e':
                                                        if ((String.Compare(json_string.getData(), 8, "xasBowl", 0, 7, false) == 0) && (json_string.getData().Length == 15))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAFBTexasBowl;
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
                                case 'M':
                                    if (String.Compare(json_string.getData(), 5, "B", 0, 1, false) == 0)
                                      {
                                        switch (json_string.getData()[6])
                                          {
                                            case 'C':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'B':
                                                        if (String.Compare(json_string.getData(), 8, "I", 0, 1, false) == 0)
                                                          {
                                                            switch (json_string.getData()[9])
                                                              {
                                                                case 'C':
                                                                    if ((String.Compare(json_string.getData(), 10, "hampionship", 0, 11, false) == 0) && (json_string.getData().Length == 21))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBCBIChampionship;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'F':
                                                                    if ((String.Compare(json_string.getData(), 10, "irstRound", 0, 9, false) == 0) && (json_string.getData().Length == 19))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBCBIFirstRound;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'Q':
                                                                    if ((String.Compare(json_string.getData(), 10, "uarterfinals", 0, 12, false) == 0) && (json_string.getData().Length == 22))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBCBIQuarterfinals;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'S':
                                                                    if ((String.Compare(json_string.getData(), 10, "emifinals", 0, 9, false) == 0) && (json_string.getData().Length == 19))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBCBISemifinals;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                          }
                                                        break;
                                                    case 'I':
                                                        if (String.Compare(json_string.getData(), 8, "T", 0, 1, false) == 0)
                                                          {
                                                            switch (json_string.getData()[9])
                                                              {
                                                                case 'C':
                                                                    if ((String.Compare(json_string.getData(), 10, "hampionship", 0, 11, false) == 0) && (json_string.getData().Length == 21))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBCITChampionship;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'F':
                                                                    if ((String.Compare(json_string.getData(), 10, "irstRound", 0, 9, false) == 0) && (json_string.getData().Length == 19))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBCITFirstRound;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'Q':
                                                                    if ((String.Compare(json_string.getData(), 10, "uarterfinals", 0, 12, false) == 0) && (json_string.getData().Length == 22))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBCITQuarterfinals;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'S':
                                                                    if (String.Compare(json_string.getData(), 10, "e", 0, 1, false) == 0)
                                                                      {
                                                                        switch (json_string.getData()[11])
                                                                          {
                                                                            case 'c':
                                                                                if ((String.Compare(json_string.getData(), 12, "ondRound", 0, 8, false) == 0) && (json_string.getData().Length == 20))
                                                                                      {
                                                                                        the_open_enum.in_known_list = true;
                                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBCITSecondRound;
                                                                                        goto open_enum_is_done;
                                                                                      }
                                                                                break;
                                                                            case 'm':
                                                                                if ((String.Compare(json_string.getData(), 12, "ifinals", 0, 7, false) == 0) && (json_string.getData().Length == 19))
                                                                                      {
                                                                                        the_open_enum.in_known_list = true;
                                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBCITSemifinals;
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
                                            case 'E':
                                                if (String.Compare(json_string.getData(), 7, "astRegional", 0, 11, false) == 0)
                                                  {
                                                    switch (json_string.getData()[18])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(json_string.getData(), 19, "lite8", 0, 5, false) == 0) && (json_string.getData().Length == 24))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBEastRegionalElite8;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'F':
                                                            if ((String.Compare(json_string.getData(), 19, "irstRound", 0, 9, false) == 0) && (json_string.getData().Length == 28))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBEastRegionalFirstRound;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'S':
                                                            switch (json_string.getData()[19])
                                                              {
                                                                case 'e':
                                                                    if ((String.Compare(json_string.getData(), 20, "condRound", 0, 9, false) == 0) && (json_string.getData().Length == 29))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBEastRegionalSecondRound;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'w':
                                                                    if ((String.Compare(json_string.getData(), 20, "eet16", 0, 5, false) == 0) && (json_string.getData().Length == 25))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBEastRegionalSweet16;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'T':
                                                            if ((String.Compare(json_string.getData(), 19, "hirdRound", 0, 9, false) == 0) && (json_string.getData().Length == 28))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBEastRegionalThirdRound;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'F':
                                                if (String.Compare(json_string.getData(), 7, "i", 0, 1, false) == 0)
                                                  {
                                                    switch (json_string.getData()[8])
                                                      {
                                                        case 'n':
                                                            if (String.Compare(json_string.getData(), 9, "alFour", 0, 6, false) == 0)
                                                              {
                                                                switch (json_string.getData()[15])
                                                                  {
                                                                    case 'F':
                                                                        if ((String.Compare(json_string.getData(), 16, "inals", 0, 5, false) == 0) && (json_string.getData().Length == 21))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBFinalFourFinals;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    case 'S':
                                                                        if ((String.Compare(json_string.getData(), 16, "emiFinals", 0, 9, false) == 0) && (json_string.getData().Length == 25))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBFinalFourSemiFinals;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                              }
                                                            break;
                                                        case 'r':
                                                            if ((String.Compare(json_string.getData(), 9, "stFour", 0, 6, false) == 0) && (json_string.getData().Length == 15))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBFirstFour;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'M':
                                                if (String.Compare(json_string.getData(), 7, "idwestRegional", 0, 14, false) == 0)
                                                  {
                                                    switch (json_string.getData()[21])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(json_string.getData(), 22, "lite8", 0, 5, false) == 0) && (json_string.getData().Length == 27))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBMidwestRegionalElite8;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'F':
                                                            if ((String.Compare(json_string.getData(), 22, "irstRound", 0, 9, false) == 0) && (json_string.getData().Length == 31))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBMidwestRegionalFirstRound;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'S':
                                                            switch (json_string.getData()[22])
                                                              {
                                                                case 'e':
                                                                    if ((String.Compare(json_string.getData(), 23, "condRound", 0, 9, false) == 0) && (json_string.getData().Length == 32))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBMidwestRegionalSecondRound;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'w':
                                                                    if ((String.Compare(json_string.getData(), 23, "eet16", 0, 5, false) == 0) && (json_string.getData().Length == 28))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBMidwestRegionalSweet16;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'T':
                                                            if ((String.Compare(json_string.getData(), 22, "hirdRound", 0, 9, false) == 0) && (json_string.getData().Length == 31))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBMidwestRegionalThirdRound;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'N':
                                                if (String.Compare(json_string.getData(), 7, "IT", 0, 2, false) == 0)
                                                  {
                                                    switch (json_string.getData()[9])
                                                      {
                                                        case 'C':
                                                            if ((String.Compare(json_string.getData(), 10, "hampionship", 0, 11, false) == 0) && (json_string.getData().Length == 21))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBNITChampionship;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'F':
                                                            if ((String.Compare(json_string.getData(), 10, "irstRound", 0, 9, false) == 0) && (json_string.getData().Length == 19))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBNITFirstRound;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'Q':
                                                            if ((String.Compare(json_string.getData(), 10, "uarterfinals", 0, 12, false) == 0) && (json_string.getData().Length == 22))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBNITQuarterfinals;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'S':
                                                            if (String.Compare(json_string.getData(), 10, "e", 0, 1, false) == 0)
                                                              {
                                                                switch (json_string.getData()[11])
                                                                  {
                                                                    case 'c':
                                                                        if ((String.Compare(json_string.getData(), 12, "ondRound", 0, 8, false) == 0) && (json_string.getData().Length == 20))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBNITSecondRound;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    case 'm':
                                                                        if ((String.Compare(json_string.getData(), 12, "ifinals", 0, 7, false) == 0) && (json_string.getData().Length == 19))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBNITSemifinals;
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
                                            case 'S':
                                                if (String.Compare(json_string.getData(), 7, "outhRegional", 0, 12, false) == 0)
                                                  {
                                                    switch (json_string.getData()[19])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(json_string.getData(), 20, "lite8", 0, 5, false) == 0) && (json_string.getData().Length == 25))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBSouthRegionalElite8;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'F':
                                                            if ((String.Compare(json_string.getData(), 20, "irstRound", 0, 9, false) == 0) && (json_string.getData().Length == 29))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBSouthRegionalFirstRound;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'S':
                                                            switch (json_string.getData()[20])
                                                              {
                                                                case 'e':
                                                                    if ((String.Compare(json_string.getData(), 21, "condRound", 0, 9, false) == 0) && (json_string.getData().Length == 30))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBSouthRegionalSecondRound;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'w':
                                                                    if ((String.Compare(json_string.getData(), 21, "eet16", 0, 5, false) == 0) && (json_string.getData().Length == 26))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBSouthRegionalSweet16;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'T':
                                                            if ((String.Compare(json_string.getData(), 20, "hirdRound", 0, 9, false) == 0) && (json_string.getData().Length == 29))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBSouthRegionalThirdRound;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'W':
                                                if (String.Compare(json_string.getData(), 7, "estRegional", 0, 11, false) == 0)
                                                  {
                                                    switch (json_string.getData()[18])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(json_string.getData(), 19, "lite8", 0, 5, false) == 0) && (json_string.getData().Length == 24))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBWestRegionalElite8;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'F':
                                                            if ((String.Compare(json_string.getData(), 19, "irstRound", 0, 9, false) == 0) && (json_string.getData().Length == 28))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBWestRegionalFirstRound;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'S':
                                                            switch (json_string.getData()[19])
                                                              {
                                                                case 'e':
                                                                    if ((String.Compare(json_string.getData(), 20, "condRound", 0, 9, false) == 0) && (json_string.getData().Length == 29))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBWestRegionalSecondRound;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'w':
                                                                    if ((String.Compare(json_string.getData(), 20, "eet16", 0, 5, false) == 0) && (json_string.getData().Length == 25))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBWestRegionalSweet16;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                            break;
                                                        case 'T':
                                                            if ((String.Compare(json_string.getData(), 19, "hirdRound", 0, 9, false) == 0) && (json_string.getData().Length == 28))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBWestRegionalThirdRound;
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
                                case 'C':
                                    if (String.Compare(json_string.getData(), 4, "onference", 0, 9, false) == 0)
                                      {
                                        switch (json_string.getData()[13])
                                          {
                                            case 'A':
                                                if ((String.Compare(json_string.getData(), 14, "FC", 0, 2, false) == 0) && (json_string.getData().Length == 16))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLConferenceAFC;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'N':
                                                if ((String.Compare(json_string.getData(), 14, "FC", 0, 2, false) == 0) && (json_string.getData().Length == 16))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLConferenceNFC;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'D':
                                    if (String.Compare(json_string.getData(), 4, "ivisional", 0, 9, false) == 0)
                                      {
                                        switch (json_string.getData()[13])
                                          {
                                            case 'A':
                                                if ((String.Compare(json_string.getData(), 14, "FC", 0, 2, false) == 0) && (json_string.getData().Length == 16))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLDivisionalAFC;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'N':
                                                if ((String.Compare(json_string.getData(), 14, "FC", 0, 2, false) == 0) && (json_string.getData().Length == 16))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLDivisionalNFC;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'S':
                                    if ((String.Compare(json_string.getData(), 4, "uperBowl", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NFLSuperBowl;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'W':
                                    if (String.Compare(json_string.getData(), 4, "ildcard", 0, 7, false) == 0)
                                      {
                                        switch (json_string.getData()[11])
                                          {
                                            case 'A':
                                                if ((String.Compare(json_string.getData(), 12, "FC", 0, 2, false) == 0) && (json_string.getData().Length == 14))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLWildcardAFC;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'N':
                                                if ((String.Compare(json_string.getData(), 12, "FC", 0, 2, false) == 0) && (json_string.getData().Length == 14))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NFLWildcardNFC;
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
                                case 'A':
                                    if (String.Compare(json_string.getData(), 4, "llStarGame", 0, 10, false) == 0)
                                      {
                                        if (json_string.getData().Length == 14)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_NHLAllStarGame;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[14])
                                          {
                                            case 'A':
                                                if ((String.Compare(json_string.getData(), 15, "tlanticMetropolitan", 0, 19, false) == 0) && (json_string.getData().Length == 34))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NHLAllStarGameAtlanticMetropolitan;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'F':
                                                if ((String.Compare(json_string.getData(), 15, "inals", 0, 5, false) == 0) && (json_string.getData().Length == 20))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NHLAllStarGameFinals;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'P':
                                                if ((String.Compare(json_string.getData(), 15, "acificCentral", 0, 13, false) == 0) && (json_string.getData().Length == 28))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NHLAllStarGamePacificCentral;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'C':
                                    if (String.Compare(json_string.getData(), 4, "onference", 0, 9, false) == 0)
                                      {
                                        switch (json_string.getData()[13])
                                          {
                                            case 'F':
                                                if (String.Compare(json_string.getData(), 14, "inals", 0, 5, false) == 0)
                                                  {
                                                    switch (json_string.getData()[19])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(json_string.getData(), 20, "astern", 0, 6, false) == 0) && (json_string.getData().Length == 26))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLConferenceFinalsEastern;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(json_string.getData(), 20, "estern", 0, 6, false) == 0) && (json_string.getData().Length == 26))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLConferenceFinalsWestern;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'Q':
                                                if (String.Compare(json_string.getData(), 14, "uarterFinals", 0, 12, false) == 0)
                                                  {
                                                    switch (json_string.getData()[26])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(json_string.getData(), 27, "astern", 0, 6, false) == 0) && (json_string.getData().Length == 33))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLConferenceQuarterFinalsEastern;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(json_string.getData(), 27, "estern", 0, 6, false) == 0) && (json_string.getData().Length == 33))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLConferenceQuarterFinalsWestern;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'S':
                                                if (String.Compare(json_string.getData(), 14, "emiFinals", 0, 9, false) == 0)
                                                  {
                                                    switch (json_string.getData()[23])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(json_string.getData(), 24, "astern", 0, 6, false) == 0) && (json_string.getData().Length == 30))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLConferenceSemiFinalsEastern;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(json_string.getData(), 24, "estern", 0, 6, false) == 0) && (json_string.getData().Length == 30))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLConferenceSemiFinalsWestern;
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
                                case 'D':
                                    if (String.Compare(json_string.getData(), 4, "ivision", 0, 7, false) == 0)
                                      {
                                        switch (json_string.getData()[11])
                                          {
                                            case 'F':
                                                if (String.Compare(json_string.getData(), 12, "inals", 0, 5, false) == 0)
                                                  {
                                                    switch (json_string.getData()[17])
                                                      {
                                                        case 'C':
                                                            if ((String.Compare(json_string.getData(), 18, "entral", 0, 6, false) == 0) && (json_string.getData().Length == 24))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLDivisionFinalsCentral;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'E':
                                                            if ((String.Compare(json_string.getData(), 18, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 21))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLDivisionFinalsEast;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'N':
                                                            if ((String.Compare(json_string.getData(), 18, "orth", 0, 4, false) == 0) && (json_string.getData().Length == 22))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLDivisionFinalsNorth;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(json_string.getData(), 18, "est", 0, 3, false) == 0) && (json_string.getData().Length == 21))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLDivisionFinalsWest;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'S':
                                                if (String.Compare(json_string.getData(), 12, "emiFinals", 0, 9, false) == 0)
                                                  {
                                                    switch (json_string.getData()[21])
                                                      {
                                                        case 'C':
                                                            if ((String.Compare(json_string.getData(), 22, "entral", 0, 6, false) == 0) && (json_string.getData().Length == 28))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLDivisionSemiFinalsCentral;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'E':
                                                            if ((String.Compare(json_string.getData(), 22, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 25))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLDivisionSemiFinalsEast;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'N':
                                                            if ((String.Compare(json_string.getData(), 22, "orth", 0, 4, false) == 0) && (json_string.getData().Length == 26))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLDivisionSemiFinalsNorth;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(json_string.getData(), 22, "est", 0, 3, false) == 0) && (json_string.getData().Length == 25))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_NHLDivisionSemiFinalsWest;
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
                                case 'S':
                                    if (String.Compare(json_string.getData(), 4, "tanleyCup", 0, 9, false) == 0)
                                      {
                                        if (json_string.getData().Length == 13)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_NHLStanleyCup;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[13])
                                          {
                                            case 'S':
                                                if ((String.Compare(json_string.getData(), 14, "emiFinals", 0, 9, false) == 0) && (json_string.getData().Length == 23))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_NHLStanleyCupSemiFinals;
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
            case 'S':
                if (String.Compare(json_string.getData(), 1, "occerInternationalMensWorldCup", 0, 30, false) == 0)
                  {
                    switch (json_string.getData()[31])
                      {
                        case '3':
                            if ((String.Compare(json_string.getData(), 32, "rdPlaceFinal", 0, 12, false) == 0) && (json_string.getData().Length == 44))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCup3rdPlaceFinal;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'F':
                            if ((String.Compare(json_string.getData(), 32, "inal", 0, 4, false) == 0) && (json_string.getData().Length == 36))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCupFinal;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'G':
                            if (String.Compare(json_string.getData(), 32, "roup", 0, 4, false) == 0)
                              {
                                switch (json_string.getData()[36])
                                  {
                                    case 'A':
                                        if (json_string.getData().Length == 37)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupA;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'B':
                                        if (json_string.getData().Length == 37)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupB;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'C':
                                        if (json_string.getData().Length == 37)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupC;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'D':
                                        if (json_string.getData().Length == 37)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupD;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'E':
                                        if (json_string.getData().Length == 37)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupE;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'F':
                                        if (json_string.getData().Length == 37)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupF;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'G':
                                        if (json_string.getData().Length == 37)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupG;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'H':
                                        if (json_string.getData().Length == 37)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupH;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'S':
                                        if ((String.Compare(json_string.getData(), 37, "tage", 0, 4, false) == 0) && (json_string.getData().Length == 41))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupStage;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'K':
                            if ((String.Compare(json_string.getData(), 32, "nockoutStage", 0, 12, false) == 0) && (json_string.getData().Length == 44))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCupKnockoutStage;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'Q':
                            if ((String.Compare(json_string.getData(), 32, "uarterFinals", 0, 12, false) == 0) && (json_string.getData().Length == 44))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCupQuarterFinals;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'R':
                            if ((String.Compare(json_string.getData(), 32, "oundOf16", 0, 8, false) == 0) && (json_string.getData().Length == 40))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCupRoundOf16;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'S':
                            if ((String.Compare(json_string.getData(), 32, "emiFinals", 0, 9, false) == 0) && (json_string.getData().Length == 41))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCupSemiFinals;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'U':
                if (String.Compare(json_string.getData(), 1, "EFA", 0, 3, false) == 0)
                  {
                    switch (json_string.getData()[4])
                      {
                        case 'C':
                            if (String.Compare(json_string.getData(), 5, "hampionsLeague", 0, 14, false) == 0)
                              {
                                switch (json_string.getData()[19])
                                  {
                                    case 'F':
                                        if ((String.Compare(json_string.getData(), 20, "inal", 0, 4, false) == 0) && (json_string.getData().Length == 24))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_UEFAChampionsLeagueFinal;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'Q':
                                        if ((String.Compare(json_string.getData(), 20, "uarterFinals", 0, 12, false) == 0) && (json_string.getData().Length == 32))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_UEFAChampionsLeagueQuarterFinals;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'R':
                                        if ((String.Compare(json_string.getData(), 20, "oundOf16", 0, 8, false) == 0) && (json_string.getData().Length == 28))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_UEFAChampionsLeagueRoundOf16;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'S':
                                        if ((String.Compare(json_string.getData(), 20, "emiFinals", 0, 9, false) == 0) && (json_string.getData().Length == 29))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_UEFAChampionsLeagueSemiFinals;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'S':
                            if ((String.Compare(json_string.getData(), 5, "uperCup", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_UEFASuperCup;
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


    public SportsPlayoffSpecialGameJSON()
      {
        flagHasValue = false;
      }

    public SportsPlayoffSpecialGameJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public SportsPlayoffSpecialGameJSON(string init_value)
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

    public SportsPlayoffSpecialGameJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_NFLWildcardAFC:
                    handler.string_value("NFLWildcardAFC");
                    break;
                case TypeValueKnownValues.Value_NFLWildcardNFC:
                    handler.string_value("NFLWildcardNFC");
                    break;
                case TypeValueKnownValues.Value_NFLDivisionalAFC:
                    handler.string_value("NFLDivisionalAFC");
                    break;
                case TypeValueKnownValues.Value_NFLDivisionalNFC:
                    handler.string_value("NFLDivisionalNFC");
                    break;
                case TypeValueKnownValues.Value_NFLConferenceAFC:
                    handler.string_value("NFLConferenceAFC");
                    break;
                case TypeValueKnownValues.Value_NFLConferenceNFC:
                    handler.string_value("NFLConferenceNFC");
                    break;
                case TypeValueKnownValues.Value_NFLSuperBowl:
                    handler.string_value("NFLSuperBowl");
                    break;
                case TypeValueKnownValues.Value_NHLConferenceQuarterFinalsEastern:
                    handler.string_value("NHLConferenceQuarterFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_NHLConferenceQuarterFinalsWestern:
                    handler.string_value("NHLConferenceQuarterFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_NHLConferenceSemiFinalsEastern:
                    handler.string_value("NHLConferenceSemiFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_NHLConferenceSemiFinalsWestern:
                    handler.string_value("NHLConferenceSemiFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_NHLConferenceFinalsEastern:
                    handler.string_value("NHLConferenceFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_NHLConferenceFinalsWestern:
                    handler.string_value("NHLConferenceFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_NHLStanleyCup:
                    handler.string_value("NHLStanleyCup");
                    break;
                case TypeValueKnownValues.Value_NHLAllStarGame:
                    handler.string_value("NHLAllStarGame");
                    break;
                case TypeValueKnownValues.Value_NHLAllStarGameFinals:
                    handler.string_value("NHLAllStarGameFinals");
                    break;
                case TypeValueKnownValues.Value_NHLAllStarGameAtlanticMetropolitan:
                    handler.string_value("NHLAllStarGameAtlanticMetropolitan");
                    break;
                case TypeValueKnownValues.Value_NHLAllStarGamePacificCentral:
                    handler.string_value("NHLAllStarGamePacificCentral");
                    break;
                case TypeValueKnownValues.Value_NHLStanleyCupSemiFinals:
                    handler.string_value("NHLStanleyCupSemiFinals");
                    break;
                case TypeValueKnownValues.Value_NHLDivisionSemiFinalsEast:
                    handler.string_value("NHLDivisionSemiFinalsEast");
                    break;
                case TypeValueKnownValues.Value_NHLDivisionFinalsEast:
                    handler.string_value("NHLDivisionFinalsEast");
                    break;
                case TypeValueKnownValues.Value_NHLDivisionSemiFinalsNorth:
                    handler.string_value("NHLDivisionSemiFinalsNorth");
                    break;
                case TypeValueKnownValues.Value_NHLDivisionFinalsNorth:
                    handler.string_value("NHLDivisionFinalsNorth");
                    break;
                case TypeValueKnownValues.Value_NHLDivisionSemiFinalsCentral:
                    handler.string_value("NHLDivisionSemiFinalsCentral");
                    break;
                case TypeValueKnownValues.Value_NHLDivisionFinalsCentral:
                    handler.string_value("NHLDivisionFinalsCentral");
                    break;
                case TypeValueKnownValues.Value_NHLDivisionSemiFinalsWest:
                    handler.string_value("NHLDivisionSemiFinalsWest");
                    break;
                case TypeValueKnownValues.Value_NHLDivisionFinalsWest:
                    handler.string_value("NHLDivisionFinalsWest");
                    break;
                case TypeValueKnownValues.Value_MLBWildcardAmericanLeague:
                    handler.string_value("MLBWildcardAmericanLeague");
                    break;
                case TypeValueKnownValues.Value_MLBWildcardNationalLeague:
                    handler.string_value("MLBWildcardNationalLeague");
                    break;
                case TypeValueKnownValues.Value_MLBDivisionalAmericanLeague:
                    handler.string_value("MLBDivisionalAmericanLeague");
                    break;
                case TypeValueKnownValues.Value_MLBDivisionalNationalLeague:
                    handler.string_value("MLBDivisionalNationalLeague");
                    break;
                case TypeValueKnownValues.Value_MLBChampionshipAmericanLeague:
                    handler.string_value("MLBChampionshipAmericanLeague");
                    break;
                case TypeValueKnownValues.Value_MLBChampionshipNationalLeague:
                    handler.string_value("MLBChampionshipNationalLeague");
                    break;
                case TypeValueKnownValues.Value_MLBWorldSeries:
                    handler.string_value("MLBWorldSeries");
                    break;
                case TypeValueKnownValues.Value_MLBAllStarGame:
                    handler.string_value("MLBAllStarGame");
                    break;
                case TypeValueKnownValues.Value_NBAConferenceQuarterFinalsEastern:
                    handler.string_value("NBAConferenceQuarterFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_NBAConferenceQuarterFinalsWestern:
                    handler.string_value("NBAConferenceQuarterFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_NBAConferenceSemiFinalsEastern:
                    handler.string_value("NBAConferenceSemiFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_NBAConferenceSemiFinalsWestern:
                    handler.string_value("NBAConferenceSemiFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_NBAConferenceFinalsEastern:
                    handler.string_value("NBAConferenceFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_NBAConferenceFinalsWestern:
                    handler.string_value("NBAConferenceFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_NBAFinals:
                    handler.string_value("NBAFinals");
                    break;
                case TypeValueKnownValues.Value_NBAAllStarGame:
                    handler.string_value("NBAAllStarGame");
                    break;
                case TypeValueKnownValues.Value_MLSConferenceQuarterFinalsEastern:
                    handler.string_value("MLSConferenceQuarterFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_MLSConferenceQuarterFinalsWestern:
                    handler.string_value("MLSConferenceQuarterFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_MLSConferenceSemiFinalsEastern:
                    handler.string_value("MLSConferenceSemiFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_MLSConferenceSemiFinalsWestern:
                    handler.string_value("MLSConferenceSemiFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_MLSConferenceFinalsEastern:
                    handler.string_value("MLSConferenceFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_MLSConferenceFinalsWestern:
                    handler.string_value("MLSConferenceFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_MLSCup:
                    handler.string_value("MLSCup");
                    break;
                case TypeValueKnownValues.Value_NCAAFBRoseBowl:
                    handler.string_value("NCAAFBRoseBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBOrangeBowl:
                    handler.string_value("NCAAFBOrangeBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBSugarBowl:
                    handler.string_value("NCAAFBSugarBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBCottonBowlClassic:
                    handler.string_value("NCAAFBCottonBowlClassic");
                    break;
                case TypeValueKnownValues.Value_NCAAFBPeachBowl:
                    handler.string_value("NCAAFBPeachBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFiestaBowl:
                    handler.string_value("NCAAFBFiestaBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBSunBowl:
                    handler.string_value("NCAAFBSunBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBTaxSlayerBowl:
                    handler.string_value("NCAAFBTaxSlayerBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBCitrusBowl:
                    handler.string_value("NCAAFBCitrusBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBLibertyBowl:
                    handler.string_value("NCAAFBLibertyBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBIndependenceBowl:
                    handler.string_value("NCAAFBIndependenceBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBHolidayBowl:
                    handler.string_value("NCAAFBHolidayBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBOutbackBowl:
                    handler.string_value("NCAAFBOutbackBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBCactusBowl:
                    handler.string_value("NCAAFBCactusBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBRussellAthleticBowl:
                    handler.string_value("NCAAFBRussellAthleticBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBLasVegasBowl:
                    handler.string_value("NCAAFBLasVegasBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBAlamoBowl:
                    handler.string_value("NCAAFBAlamoBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFamousIdahoPotatoBowl:
                    handler.string_value("NCAAFBFamousIdahoPotatoBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBMusicCityBowl:
                    handler.string_value("NCAAFBMusicCityBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBGoDaddyBowl:
                    handler.string_value("NCAAFBGoDaddyBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBNewOrleansBowl:
                    handler.string_value("NCAAFBNewOrleansBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFosterFarmsBowl:
                    handler.string_value("NCAAFBFosterFarmsBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBHawaiiBowl:
                    handler.string_value("NCAAFBHawaiiBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBBelkBowl:
                    handler.string_value("NCAAFBBelkBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBArmedForcesBowl:
                    handler.string_value("NCAAFBArmedForcesBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBPoinsettiaBowl:
                    handler.string_value("NCAAFBPoinsettiaBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBTexasBowl:
                    handler.string_value("NCAAFBTexasBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBBirminghamBowl:
                    handler.string_value("NCAAFBBirminghamBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBNewMexicoBowl:
                    handler.string_value("NCAAFBNewMexicoBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBMilitaryBowl:
                    handler.string_value("NCAAFBMilitaryBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBStPetersburgBowl:
                    handler.string_value("NCAAFBStPetersburgBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBPinstripeBowl:
                    handler.string_value("NCAAFBPinstripeBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBHeartOfDallasBowl:
                    handler.string_value("NCAAFBHeartOfDallasBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBBahamasBowl:
                    handler.string_value("NCAAFBBahamasBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBBocaRatonBowl:
                    handler.string_value("NCAAFBBocaRatonBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBCamelliaBowl:
                    handler.string_value("NCAAFBCamelliaBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBMiamiBeachBowl:
                    handler.string_value("NCAAFBMiamiBeachBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBQuickLaneBowl:
                    handler.string_value("NCAAFBQuickLaneBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBCureBowl:
                    handler.string_value("NCAAFBCureBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBArizonaBowl:
                    handler.string_value("NCAAFBArizonaBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBPAC12Championship:
                    handler.string_value("NCAAFBPAC12Championship");
                    break;
                case TypeValueKnownValues.Value_NCAAFBConferenceUSAChampionship:
                    handler.string_value("NCAAFBConferenceUSAChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAFBBigTenChampionship:
                    handler.string_value("NCAAFBBigTenChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAFBCFPNationalChampionship:
                    handler.string_value("NCAAFBCFPNationalChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAFBSECChampionship:
                    handler.string_value("NCAAFBSECChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAFBMACChampionship:
                    handler.string_value("NCAAFBMACChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAFBACCChampionship:
                    handler.string_value("NCAAFBACCChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAFBMWCChampionship:
                    handler.string_value("NCAAFBMWCChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAMBFirstFour:
                    handler.string_value("NCAAMBFirstFour");
                    break;
                case TypeValueKnownValues.Value_NCAAMBMidwestRegionalFirstRound:
                    handler.string_value("NCAAMBMidwestRegionalFirstRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBSouthRegionalFirstRound:
                    handler.string_value("NCAAMBSouthRegionalFirstRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBWestRegionalFirstRound:
                    handler.string_value("NCAAMBWestRegionalFirstRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBEastRegionalFirstRound:
                    handler.string_value("NCAAMBEastRegionalFirstRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBMidwestRegionalSecondRound:
                    handler.string_value("NCAAMBMidwestRegionalSecondRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBSouthRegionalSecondRound:
                    handler.string_value("NCAAMBSouthRegionalSecondRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBWestRegionalSecondRound:
                    handler.string_value("NCAAMBWestRegionalSecondRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBEastRegionalSecondRound:
                    handler.string_value("NCAAMBEastRegionalSecondRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBMidwestRegionalThirdRound:
                    handler.string_value("NCAAMBMidwestRegionalThirdRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBSouthRegionalThirdRound:
                    handler.string_value("NCAAMBSouthRegionalThirdRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBWestRegionalThirdRound:
                    handler.string_value("NCAAMBWestRegionalThirdRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBEastRegionalThirdRound:
                    handler.string_value("NCAAMBEastRegionalThirdRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBMidwestRegionalSweet16:
                    handler.string_value("NCAAMBMidwestRegionalSweet16");
                    break;
                case TypeValueKnownValues.Value_NCAAMBSouthRegionalSweet16:
                    handler.string_value("NCAAMBSouthRegionalSweet16");
                    break;
                case TypeValueKnownValues.Value_NCAAMBWestRegionalSweet16:
                    handler.string_value("NCAAMBWestRegionalSweet16");
                    break;
                case TypeValueKnownValues.Value_NCAAMBEastRegionalSweet16:
                    handler.string_value("NCAAMBEastRegionalSweet16");
                    break;
                case TypeValueKnownValues.Value_NCAAMBMidwestRegionalElite8:
                    handler.string_value("NCAAMBMidwestRegionalElite8");
                    break;
                case TypeValueKnownValues.Value_NCAAMBSouthRegionalElite8:
                    handler.string_value("NCAAMBSouthRegionalElite8");
                    break;
                case TypeValueKnownValues.Value_NCAAMBWestRegionalElite8:
                    handler.string_value("NCAAMBWestRegionalElite8");
                    break;
                case TypeValueKnownValues.Value_NCAAMBEastRegionalElite8:
                    handler.string_value("NCAAMBEastRegionalElite8");
                    break;
                case TypeValueKnownValues.Value_NCAAMBFinalFourSemiFinals:
                    handler.string_value("NCAAMBFinalFourSemiFinals");
                    break;
                case TypeValueKnownValues.Value_NCAAMBFinalFourFinals:
                    handler.string_value("NCAAMBFinalFourFinals");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCITFirstRound:
                    handler.string_value("NCAAMBCITFirstRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCITSecondRound:
                    handler.string_value("NCAAMBCITSecondRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCITQuarterfinals:
                    handler.string_value("NCAAMBCITQuarterfinals");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCITSemifinals:
                    handler.string_value("NCAAMBCITSemifinals");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCITChampionship:
                    handler.string_value("NCAAMBCITChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCBIFirstRound:
                    handler.string_value("NCAAMBCBIFirstRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCBIQuarterfinals:
                    handler.string_value("NCAAMBCBIQuarterfinals");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCBISemifinals:
                    handler.string_value("NCAAMBCBISemifinals");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCBIChampionship:
                    handler.string_value("NCAAMBCBIChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAMBNITFirstRound:
                    handler.string_value("NCAAMBNITFirstRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBNITSecondRound:
                    handler.string_value("NCAAMBNITSecondRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBNITQuarterfinals:
                    handler.string_value("NCAAMBNITQuarterfinals");
                    break;
                case TypeValueKnownValues.Value_NCAAMBNITSemifinals:
                    handler.string_value("NCAAMBNITSemifinals");
                    break;
                case TypeValueKnownValues.Value_NCAAMBNITChampionship:
                    handler.string_value("NCAAMBNITChampionship");
                    break;
                case TypeValueKnownValues.Value_CFLSemiFinalsEast:
                    handler.string_value("CFLSemiFinalsEast");
                    break;
                case TypeValueKnownValues.Value_CFLSemiFinalsWest:
                    handler.string_value("CFLSemiFinalsWest");
                    break;
                case TypeValueKnownValues.Value_CFLFinalsEast:
                    handler.string_value("CFLFinalsEast");
                    break;
                case TypeValueKnownValues.Value_CFLFinalsWest:
                    handler.string_value("CFLFinalsWest");
                    break;
                case TypeValueKnownValues.Value_CFLGreyCup:
                    handler.string_value("CFLGreyCup");
                    break;
                case TypeValueKnownValues.Value_UEFAChampionsLeagueRoundOf16:
                    handler.string_value("UEFAChampionsLeagueRoundOf16");
                    break;
                case TypeValueKnownValues.Value_UEFAChampionsLeagueQuarterFinals:
                    handler.string_value("UEFAChampionsLeagueQuarterFinals");
                    break;
                case TypeValueKnownValues.Value_UEFAChampionsLeagueSemiFinals:
                    handler.string_value("UEFAChampionsLeagueSemiFinals");
                    break;
                case TypeValueKnownValues.Value_UEFAChampionsLeagueFinal:
                    handler.string_value("UEFAChampionsLeagueFinal");
                    break;
                case TypeValueKnownValues.Value_EuropaLeagueRoundOf32:
                    handler.string_value("EuropaLeagueRoundOf32");
                    break;
                case TypeValueKnownValues.Value_EuropaLeagueRoundOf16:
                    handler.string_value("EuropaLeagueRoundOf16");
                    break;
                case TypeValueKnownValues.Value_EuropaLeagueQuarterFinals:
                    handler.string_value("EuropaLeagueQuarterFinals");
                    break;
                case TypeValueKnownValues.Value_EuropaLeagueSemiFinals:
                    handler.string_value("EuropaLeagueSemiFinals");
                    break;
                case TypeValueKnownValues.Value_EuropaLeagueFinal:
                    handler.string_value("EuropaLeagueFinal");
                    break;
                case TypeValueKnownValues.Value_UEFASuperCup:
                    handler.string_value("UEFASuperCup");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupA:
                    handler.string_value("SoccerInternationalMensWorldCupGroupA");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupB:
                    handler.string_value("SoccerInternationalMensWorldCupGroupB");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupC:
                    handler.string_value("SoccerInternationalMensWorldCupGroupC");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupD:
                    handler.string_value("SoccerInternationalMensWorldCupGroupD");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupE:
                    handler.string_value("SoccerInternationalMensWorldCupGroupE");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupF:
                    handler.string_value("SoccerInternationalMensWorldCupGroupF");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupG:
                    handler.string_value("SoccerInternationalMensWorldCupGroupG");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupH:
                    handler.string_value("SoccerInternationalMensWorldCupGroupH");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupStage:
                    handler.string_value("SoccerInternationalMensWorldCupGroupStage");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupRoundOf16:
                    handler.string_value("SoccerInternationalMensWorldCupRoundOf16");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupQuarterFinals:
                    handler.string_value("SoccerInternationalMensWorldCupQuarterFinals");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupSemiFinals:
                    handler.string_value("SoccerInternationalMensWorldCupSemiFinals");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCup3rdPlaceFinal:
                    handler.string_value("SoccerInternationalMensWorldCup3rdPlaceFinal");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupFinal:
                    handler.string_value("SoccerInternationalMensWorldCupFinal");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupKnockoutStage:
                    handler.string_value("SoccerInternationalMensWorldCupKnockoutStage");
                    break;
                case TypeValueKnownValues.Value_CricketICCWorldCupFinal:
                    handler.string_value("CricketICCWorldCupFinal");
                    break;
                case TypeValueKnownValues.Value_CricketICCWorldCupSemiFinal:
                    handler.string_value("CricketICCWorldCupSemiFinal");
                    break;
                case TypeValueKnownValues.Value_CricketIPLFinal:
                    handler.string_value("CricketIPLFinal");
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
                case TypeValueKnownValues.Value_NFLWildcardAFC:
                    handler.string_value("NFLWildcardAFC");
                    break;
                case TypeValueKnownValues.Value_NFLWildcardNFC:
                    handler.string_value("NFLWildcardNFC");
                    break;
                case TypeValueKnownValues.Value_NFLDivisionalAFC:
                    handler.string_value("NFLDivisionalAFC");
                    break;
                case TypeValueKnownValues.Value_NFLDivisionalNFC:
                    handler.string_value("NFLDivisionalNFC");
                    break;
                case TypeValueKnownValues.Value_NFLConferenceAFC:
                    handler.string_value("NFLConferenceAFC");
                    break;
                case TypeValueKnownValues.Value_NFLConferenceNFC:
                    handler.string_value("NFLConferenceNFC");
                    break;
                case TypeValueKnownValues.Value_NFLSuperBowl:
                    handler.string_value("NFLSuperBowl");
                    break;
                case TypeValueKnownValues.Value_NHLConferenceQuarterFinalsEastern:
                    handler.string_value("NHLConferenceQuarterFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_NHLConferenceQuarterFinalsWestern:
                    handler.string_value("NHLConferenceQuarterFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_NHLConferenceSemiFinalsEastern:
                    handler.string_value("NHLConferenceSemiFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_NHLConferenceSemiFinalsWestern:
                    handler.string_value("NHLConferenceSemiFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_NHLConferenceFinalsEastern:
                    handler.string_value("NHLConferenceFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_NHLConferenceFinalsWestern:
                    handler.string_value("NHLConferenceFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_NHLStanleyCup:
                    handler.string_value("NHLStanleyCup");
                    break;
                case TypeValueKnownValues.Value_NHLAllStarGame:
                    handler.string_value("NHLAllStarGame");
                    break;
                case TypeValueKnownValues.Value_NHLAllStarGameFinals:
                    handler.string_value("NHLAllStarGameFinals");
                    break;
                case TypeValueKnownValues.Value_NHLAllStarGameAtlanticMetropolitan:
                    handler.string_value("NHLAllStarGameAtlanticMetropolitan");
                    break;
                case TypeValueKnownValues.Value_NHLAllStarGamePacificCentral:
                    handler.string_value("NHLAllStarGamePacificCentral");
                    break;
                case TypeValueKnownValues.Value_NHLStanleyCupSemiFinals:
                    handler.string_value("NHLStanleyCupSemiFinals");
                    break;
                case TypeValueKnownValues.Value_NHLDivisionSemiFinalsEast:
                    handler.string_value("NHLDivisionSemiFinalsEast");
                    break;
                case TypeValueKnownValues.Value_NHLDivisionFinalsEast:
                    handler.string_value("NHLDivisionFinalsEast");
                    break;
                case TypeValueKnownValues.Value_NHLDivisionSemiFinalsNorth:
                    handler.string_value("NHLDivisionSemiFinalsNorth");
                    break;
                case TypeValueKnownValues.Value_NHLDivisionFinalsNorth:
                    handler.string_value("NHLDivisionFinalsNorth");
                    break;
                case TypeValueKnownValues.Value_NHLDivisionSemiFinalsCentral:
                    handler.string_value("NHLDivisionSemiFinalsCentral");
                    break;
                case TypeValueKnownValues.Value_NHLDivisionFinalsCentral:
                    handler.string_value("NHLDivisionFinalsCentral");
                    break;
                case TypeValueKnownValues.Value_NHLDivisionSemiFinalsWest:
                    handler.string_value("NHLDivisionSemiFinalsWest");
                    break;
                case TypeValueKnownValues.Value_NHLDivisionFinalsWest:
                    handler.string_value("NHLDivisionFinalsWest");
                    break;
                case TypeValueKnownValues.Value_MLBWildcardAmericanLeague:
                    handler.string_value("MLBWildcardAmericanLeague");
                    break;
                case TypeValueKnownValues.Value_MLBWildcardNationalLeague:
                    handler.string_value("MLBWildcardNationalLeague");
                    break;
                case TypeValueKnownValues.Value_MLBDivisionalAmericanLeague:
                    handler.string_value("MLBDivisionalAmericanLeague");
                    break;
                case TypeValueKnownValues.Value_MLBDivisionalNationalLeague:
                    handler.string_value("MLBDivisionalNationalLeague");
                    break;
                case TypeValueKnownValues.Value_MLBChampionshipAmericanLeague:
                    handler.string_value("MLBChampionshipAmericanLeague");
                    break;
                case TypeValueKnownValues.Value_MLBChampionshipNationalLeague:
                    handler.string_value("MLBChampionshipNationalLeague");
                    break;
                case TypeValueKnownValues.Value_MLBWorldSeries:
                    handler.string_value("MLBWorldSeries");
                    break;
                case TypeValueKnownValues.Value_MLBAllStarGame:
                    handler.string_value("MLBAllStarGame");
                    break;
                case TypeValueKnownValues.Value_NBAConferenceQuarterFinalsEastern:
                    handler.string_value("NBAConferenceQuarterFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_NBAConferenceQuarterFinalsWestern:
                    handler.string_value("NBAConferenceQuarterFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_NBAConferenceSemiFinalsEastern:
                    handler.string_value("NBAConferenceSemiFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_NBAConferenceSemiFinalsWestern:
                    handler.string_value("NBAConferenceSemiFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_NBAConferenceFinalsEastern:
                    handler.string_value("NBAConferenceFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_NBAConferenceFinalsWestern:
                    handler.string_value("NBAConferenceFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_NBAFinals:
                    handler.string_value("NBAFinals");
                    break;
                case TypeValueKnownValues.Value_NBAAllStarGame:
                    handler.string_value("NBAAllStarGame");
                    break;
                case TypeValueKnownValues.Value_MLSConferenceQuarterFinalsEastern:
                    handler.string_value("MLSConferenceQuarterFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_MLSConferenceQuarterFinalsWestern:
                    handler.string_value("MLSConferenceQuarterFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_MLSConferenceSemiFinalsEastern:
                    handler.string_value("MLSConferenceSemiFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_MLSConferenceSemiFinalsWestern:
                    handler.string_value("MLSConferenceSemiFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_MLSConferenceFinalsEastern:
                    handler.string_value("MLSConferenceFinalsEastern");
                    break;
                case TypeValueKnownValues.Value_MLSConferenceFinalsWestern:
                    handler.string_value("MLSConferenceFinalsWestern");
                    break;
                case TypeValueKnownValues.Value_MLSCup:
                    handler.string_value("MLSCup");
                    break;
                case TypeValueKnownValues.Value_NCAAFBRoseBowl:
                    handler.string_value("NCAAFBRoseBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBOrangeBowl:
                    handler.string_value("NCAAFBOrangeBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBSugarBowl:
                    handler.string_value("NCAAFBSugarBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBCottonBowlClassic:
                    handler.string_value("NCAAFBCottonBowlClassic");
                    break;
                case TypeValueKnownValues.Value_NCAAFBPeachBowl:
                    handler.string_value("NCAAFBPeachBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFiestaBowl:
                    handler.string_value("NCAAFBFiestaBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBSunBowl:
                    handler.string_value("NCAAFBSunBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBTaxSlayerBowl:
                    handler.string_value("NCAAFBTaxSlayerBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBCitrusBowl:
                    handler.string_value("NCAAFBCitrusBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBLibertyBowl:
                    handler.string_value("NCAAFBLibertyBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBIndependenceBowl:
                    handler.string_value("NCAAFBIndependenceBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBHolidayBowl:
                    handler.string_value("NCAAFBHolidayBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBOutbackBowl:
                    handler.string_value("NCAAFBOutbackBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBCactusBowl:
                    handler.string_value("NCAAFBCactusBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBRussellAthleticBowl:
                    handler.string_value("NCAAFBRussellAthleticBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBLasVegasBowl:
                    handler.string_value("NCAAFBLasVegasBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBAlamoBowl:
                    handler.string_value("NCAAFBAlamoBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFamousIdahoPotatoBowl:
                    handler.string_value("NCAAFBFamousIdahoPotatoBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBMusicCityBowl:
                    handler.string_value("NCAAFBMusicCityBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBGoDaddyBowl:
                    handler.string_value("NCAAFBGoDaddyBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBNewOrleansBowl:
                    handler.string_value("NCAAFBNewOrleansBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBFosterFarmsBowl:
                    handler.string_value("NCAAFBFosterFarmsBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBHawaiiBowl:
                    handler.string_value("NCAAFBHawaiiBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBBelkBowl:
                    handler.string_value("NCAAFBBelkBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBArmedForcesBowl:
                    handler.string_value("NCAAFBArmedForcesBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBPoinsettiaBowl:
                    handler.string_value("NCAAFBPoinsettiaBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBTexasBowl:
                    handler.string_value("NCAAFBTexasBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBBirminghamBowl:
                    handler.string_value("NCAAFBBirminghamBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBNewMexicoBowl:
                    handler.string_value("NCAAFBNewMexicoBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBMilitaryBowl:
                    handler.string_value("NCAAFBMilitaryBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBStPetersburgBowl:
                    handler.string_value("NCAAFBStPetersburgBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBPinstripeBowl:
                    handler.string_value("NCAAFBPinstripeBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBHeartOfDallasBowl:
                    handler.string_value("NCAAFBHeartOfDallasBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBBahamasBowl:
                    handler.string_value("NCAAFBBahamasBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBBocaRatonBowl:
                    handler.string_value("NCAAFBBocaRatonBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBCamelliaBowl:
                    handler.string_value("NCAAFBCamelliaBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBMiamiBeachBowl:
                    handler.string_value("NCAAFBMiamiBeachBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBQuickLaneBowl:
                    handler.string_value("NCAAFBQuickLaneBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBCureBowl:
                    handler.string_value("NCAAFBCureBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBArizonaBowl:
                    handler.string_value("NCAAFBArizonaBowl");
                    break;
                case TypeValueKnownValues.Value_NCAAFBPAC12Championship:
                    handler.string_value("NCAAFBPAC12Championship");
                    break;
                case TypeValueKnownValues.Value_NCAAFBConferenceUSAChampionship:
                    handler.string_value("NCAAFBConferenceUSAChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAFBBigTenChampionship:
                    handler.string_value("NCAAFBBigTenChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAFBCFPNationalChampionship:
                    handler.string_value("NCAAFBCFPNationalChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAFBSECChampionship:
                    handler.string_value("NCAAFBSECChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAFBMACChampionship:
                    handler.string_value("NCAAFBMACChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAFBACCChampionship:
                    handler.string_value("NCAAFBACCChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAFBMWCChampionship:
                    handler.string_value("NCAAFBMWCChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAMBFirstFour:
                    handler.string_value("NCAAMBFirstFour");
                    break;
                case TypeValueKnownValues.Value_NCAAMBMidwestRegionalFirstRound:
                    handler.string_value("NCAAMBMidwestRegionalFirstRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBSouthRegionalFirstRound:
                    handler.string_value("NCAAMBSouthRegionalFirstRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBWestRegionalFirstRound:
                    handler.string_value("NCAAMBWestRegionalFirstRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBEastRegionalFirstRound:
                    handler.string_value("NCAAMBEastRegionalFirstRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBMidwestRegionalSecondRound:
                    handler.string_value("NCAAMBMidwestRegionalSecondRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBSouthRegionalSecondRound:
                    handler.string_value("NCAAMBSouthRegionalSecondRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBWestRegionalSecondRound:
                    handler.string_value("NCAAMBWestRegionalSecondRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBEastRegionalSecondRound:
                    handler.string_value("NCAAMBEastRegionalSecondRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBMidwestRegionalThirdRound:
                    handler.string_value("NCAAMBMidwestRegionalThirdRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBSouthRegionalThirdRound:
                    handler.string_value("NCAAMBSouthRegionalThirdRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBWestRegionalThirdRound:
                    handler.string_value("NCAAMBWestRegionalThirdRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBEastRegionalThirdRound:
                    handler.string_value("NCAAMBEastRegionalThirdRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBMidwestRegionalSweet16:
                    handler.string_value("NCAAMBMidwestRegionalSweet16");
                    break;
                case TypeValueKnownValues.Value_NCAAMBSouthRegionalSweet16:
                    handler.string_value("NCAAMBSouthRegionalSweet16");
                    break;
                case TypeValueKnownValues.Value_NCAAMBWestRegionalSweet16:
                    handler.string_value("NCAAMBWestRegionalSweet16");
                    break;
                case TypeValueKnownValues.Value_NCAAMBEastRegionalSweet16:
                    handler.string_value("NCAAMBEastRegionalSweet16");
                    break;
                case TypeValueKnownValues.Value_NCAAMBMidwestRegionalElite8:
                    handler.string_value("NCAAMBMidwestRegionalElite8");
                    break;
                case TypeValueKnownValues.Value_NCAAMBSouthRegionalElite8:
                    handler.string_value("NCAAMBSouthRegionalElite8");
                    break;
                case TypeValueKnownValues.Value_NCAAMBWestRegionalElite8:
                    handler.string_value("NCAAMBWestRegionalElite8");
                    break;
                case TypeValueKnownValues.Value_NCAAMBEastRegionalElite8:
                    handler.string_value("NCAAMBEastRegionalElite8");
                    break;
                case TypeValueKnownValues.Value_NCAAMBFinalFourSemiFinals:
                    handler.string_value("NCAAMBFinalFourSemiFinals");
                    break;
                case TypeValueKnownValues.Value_NCAAMBFinalFourFinals:
                    handler.string_value("NCAAMBFinalFourFinals");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCITFirstRound:
                    handler.string_value("NCAAMBCITFirstRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCITSecondRound:
                    handler.string_value("NCAAMBCITSecondRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCITQuarterfinals:
                    handler.string_value("NCAAMBCITQuarterfinals");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCITSemifinals:
                    handler.string_value("NCAAMBCITSemifinals");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCITChampionship:
                    handler.string_value("NCAAMBCITChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCBIFirstRound:
                    handler.string_value("NCAAMBCBIFirstRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCBIQuarterfinals:
                    handler.string_value("NCAAMBCBIQuarterfinals");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCBISemifinals:
                    handler.string_value("NCAAMBCBISemifinals");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCBIChampionship:
                    handler.string_value("NCAAMBCBIChampionship");
                    break;
                case TypeValueKnownValues.Value_NCAAMBNITFirstRound:
                    handler.string_value("NCAAMBNITFirstRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBNITSecondRound:
                    handler.string_value("NCAAMBNITSecondRound");
                    break;
                case TypeValueKnownValues.Value_NCAAMBNITQuarterfinals:
                    handler.string_value("NCAAMBNITQuarterfinals");
                    break;
                case TypeValueKnownValues.Value_NCAAMBNITSemifinals:
                    handler.string_value("NCAAMBNITSemifinals");
                    break;
                case TypeValueKnownValues.Value_NCAAMBNITChampionship:
                    handler.string_value("NCAAMBNITChampionship");
                    break;
                case TypeValueKnownValues.Value_CFLSemiFinalsEast:
                    handler.string_value("CFLSemiFinalsEast");
                    break;
                case TypeValueKnownValues.Value_CFLSemiFinalsWest:
                    handler.string_value("CFLSemiFinalsWest");
                    break;
                case TypeValueKnownValues.Value_CFLFinalsEast:
                    handler.string_value("CFLFinalsEast");
                    break;
                case TypeValueKnownValues.Value_CFLFinalsWest:
                    handler.string_value("CFLFinalsWest");
                    break;
                case TypeValueKnownValues.Value_CFLGreyCup:
                    handler.string_value("CFLGreyCup");
                    break;
                case TypeValueKnownValues.Value_UEFAChampionsLeagueRoundOf16:
                    handler.string_value("UEFAChampionsLeagueRoundOf16");
                    break;
                case TypeValueKnownValues.Value_UEFAChampionsLeagueQuarterFinals:
                    handler.string_value("UEFAChampionsLeagueQuarterFinals");
                    break;
                case TypeValueKnownValues.Value_UEFAChampionsLeagueSemiFinals:
                    handler.string_value("UEFAChampionsLeagueSemiFinals");
                    break;
                case TypeValueKnownValues.Value_UEFAChampionsLeagueFinal:
                    handler.string_value("UEFAChampionsLeagueFinal");
                    break;
                case TypeValueKnownValues.Value_EuropaLeagueRoundOf32:
                    handler.string_value("EuropaLeagueRoundOf32");
                    break;
                case TypeValueKnownValues.Value_EuropaLeagueRoundOf16:
                    handler.string_value("EuropaLeagueRoundOf16");
                    break;
                case TypeValueKnownValues.Value_EuropaLeagueQuarterFinals:
                    handler.string_value("EuropaLeagueQuarterFinals");
                    break;
                case TypeValueKnownValues.Value_EuropaLeagueSemiFinals:
                    handler.string_value("EuropaLeagueSemiFinals");
                    break;
                case TypeValueKnownValues.Value_EuropaLeagueFinal:
                    handler.string_value("EuropaLeagueFinal");
                    break;
                case TypeValueKnownValues.Value_UEFASuperCup:
                    handler.string_value("UEFASuperCup");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupA:
                    handler.string_value("SoccerInternationalMensWorldCupGroupA");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupB:
                    handler.string_value("SoccerInternationalMensWorldCupGroupB");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupC:
                    handler.string_value("SoccerInternationalMensWorldCupGroupC");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupD:
                    handler.string_value("SoccerInternationalMensWorldCupGroupD");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupE:
                    handler.string_value("SoccerInternationalMensWorldCupGroupE");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupF:
                    handler.string_value("SoccerInternationalMensWorldCupGroupF");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupG:
                    handler.string_value("SoccerInternationalMensWorldCupGroupG");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupH:
                    handler.string_value("SoccerInternationalMensWorldCupGroupH");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupGroupStage:
                    handler.string_value("SoccerInternationalMensWorldCupGroupStage");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupRoundOf16:
                    handler.string_value("SoccerInternationalMensWorldCupRoundOf16");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupQuarterFinals:
                    handler.string_value("SoccerInternationalMensWorldCupQuarterFinals");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupSemiFinals:
                    handler.string_value("SoccerInternationalMensWorldCupSemiFinals");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCup3rdPlaceFinal:
                    handler.string_value("SoccerInternationalMensWorldCup3rdPlaceFinal");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupFinal:
                    handler.string_value("SoccerInternationalMensWorldCupFinal");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupKnockoutStage:
                    handler.string_value("SoccerInternationalMensWorldCupKnockoutStage");
                    break;
                case TypeValueKnownValues.Value_CricketICCWorldCupFinal:
                    handler.string_value("CricketICCWorldCupFinal");
                    break;
                case TypeValueKnownValues.Value_CricketICCWorldCupSemiFinal:
                    handler.string_value("CricketICCWorldCupSemiFinal");
                    break;
                case TypeValueKnownValues.Value_CricketIPLFinal:
                    handler.string_value("CricketIPLFinal");
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

    public static SportsPlayoffSpecialGameJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayoffSpecialGameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffSpecialGame", ignore_extras);
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
    public static SportsPlayoffSpecialGameJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayoffSpecialGameJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayoffSpecialGameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffSpecialGame", ignore_extras);
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
    public static SportsPlayoffSpecialGameJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayoffSpecialGameJSON from_text(string text, bool ignore_extras)
      {
        SportsPlayoffSpecialGameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffSpecialGame", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsPlayoffSpecialGameJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsPlayoffSpecialGameJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsPlayoffSpecialGameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffSpecialGame", ignore_extras);
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
            SportsPlayoffSpecialGameJSON result = new SportsPlayoffSpecialGameJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(SportsPlayoffSpecialGameJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsPlayoffSpecialGame")
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
        protected override void handle_result(SportsPlayoffSpecialGameJSON  result)
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
        public SportsPlayoffSpecialGameJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsPlayoffSpecialGameJSON  result)
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
    protected virtual void handle_result(List<SportsPlayoffSpecialGameJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsPlayoffSpecialGameJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsPlayoffSpecialGameJSON>();
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
    public List<SportsPlayoffSpecialGameJSON> value;
  };
  };
