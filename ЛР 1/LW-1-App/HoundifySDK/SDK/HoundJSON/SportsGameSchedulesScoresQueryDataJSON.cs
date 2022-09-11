/* file "SportsGameSchedulesScoresQueryDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsGameSchedulesScoresQueryDataJSON : JSONBase
  {
    public enum TypeTypeKnownValues
      {
        Type_Score,
        Type_Schedule,
        Type_ScoreOrSchedule,
        Type_Location,
        Type_BroadcastNetwork,
        Type__none
      };
    public struct TypeType
      {
        public bool in_known_list;
        public string string_value;
        public TypeTypeKnownValues list_value;
      };

    public static TypeTypeKnownValues  stringToType(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "roadcastNetwork", 0, 15, false) == 0) && (chars.Length == 16))
                    return TypeTypeKnownValues.Type_BroadcastNetwork;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "ocation", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeTypeKnownValues.Type_Location;
                break;
            case 'S':
                if (String.Compare(chars, 1, "c", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'h':
                            if ((String.Compare(chars, 3, "edule", 0, 5, false) == 0) && (chars.Length == 8))
                                return TypeTypeKnownValues.Type_Schedule;
                            break;
                        case 'o':
                            if (String.Compare(chars, 3, "re", 0, 2, false) == 0)
                              {
                                if (chars.Length == 5)
                                  {
                                    return TypeTypeKnownValues.Type_Score;
                                  }
                                switch (chars[5])
                                  {
                                    case 'O':
                                        if ((String.Compare(chars, 6, "rSchedule", 0, 9, false) == 0) && (chars.Length == 15))
                                            return TypeTypeKnownValues.Type_ScoreOrSchedule;
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
        return TypeTypeKnownValues.Type__none;
      }

    public static string  stringFromType(TypeTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeTypeKnownValues.Type_Score:
                return "Score";
            case TypeTypeKnownValues.Type_Schedule:
                return "Schedule";
            case TypeTypeKnownValues.Type_ScoreOrSchedule:
                return "ScoreOrSchedule";
            case TypeTypeKnownValues.Type_Location:
                return "Location";
            case TypeTypeKnownValues.Type_BroadcastNetwork:
                return "BroadcastNetwork";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeHomeAwayKnownValues
      {
        HomeAway_Home,
        HomeAway_Away,
        HomeAway__none
      };
    public struct TypeHomeAway
      {
        public bool in_known_list;
        public string string_value;
        public TypeHomeAwayKnownValues list_value;
      };

    public static TypeHomeAwayKnownValues  stringToHomeAway(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "way", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeHomeAwayKnownValues.HomeAway_Away;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "ome", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeHomeAwayKnownValues.HomeAway_Home;
                break;
            default:
                break;
          }
        return TypeHomeAwayKnownValues.HomeAway__none;
      }

    public static string  stringFromHomeAway(TypeHomeAwayKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeHomeAwayKnownValues.HomeAway_Home:
                return "Home";
            case TypeHomeAwayKnownValues.HomeAway_Away:
                return "Away";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeQueryGameOutcomeKnownValues
      {
        QueryGameOutcome_Won,
        QueryGameOutcome_Lost,
        QueryGameOutcome_Tied,
        QueryGameOutcome__none
      };
    public struct TypeQueryGameOutcome
      {
        public bool in_known_list;
        public string string_value;
        public TypeQueryGameOutcomeKnownValues list_value;
      };

    public static TypeQueryGameOutcomeKnownValues  stringToQueryGameOutcome(string chars)
      {
        switch (chars[0])
          {
            case 'L':
                if ((String.Compare(chars, 1, "ost", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeQueryGameOutcomeKnownValues.QueryGameOutcome_Lost;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "ied", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeQueryGameOutcomeKnownValues.QueryGameOutcome_Tied;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "on", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeQueryGameOutcomeKnownValues.QueryGameOutcome_Won;
                break;
            default:
                break;
          }
        return TypeQueryGameOutcomeKnownValues.QueryGameOutcome__none;
      }

    public static string  stringFromQueryGameOutcome(TypeQueryGameOutcomeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeQueryGameOutcomeKnownValues.QueryGameOutcome_Won:
                return "Won";
            case TypeQueryGameOutcomeKnownValues.QueryGameOutcome_Lost:
                return "Lost";
            case TypeQueryGameOutcomeKnownValues.QueryGameOutcome_Tied:
                return "Tied";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeResultTypeKnownValues
      {
        ResultType_Team,
        ResultType_Generic,
        ResultType_Series,
        ResultType_PlayoffsComplete,
        ResultType__none
      };
    public struct TypeResultType
      {
        public bool in_known_list;
        public string string_value;
        public TypeResultTypeKnownValues list_value;
      };

    public static TypeResultTypeKnownValues  stringToResultType(string chars)
      {
        switch (chars[0])
          {
            case 'G':
                if ((String.Compare(chars, 1, "eneric", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeResultTypeKnownValues.ResultType_Generic;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "layoffsComplete", 0, 15, false) == 0) && (chars.Length == 16))
                    return TypeResultTypeKnownValues.ResultType_PlayoffsComplete;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "eries", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeResultTypeKnownValues.ResultType_Series;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "eam", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeResultTypeKnownValues.ResultType_Team;
                break;
            default:
                break;
          }
        return TypeResultTypeKnownValues.ResultType__none;
      }

    public static string  stringFromResultType(TypeResultTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeResultTypeKnownValues.ResultType_Team:
                return "Team";
            case TypeResultTypeKnownValues.ResultType_Generic:
                return "Generic";
            case TypeResultTypeKnownValues.ResultType_Series:
                return "Series";
            case TypeResultTypeKnownValues.ResultType_PlayoffsComplete:
                return "PlayoffsComplete";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeErrorKnownValues
      {
        Error_NoGamesFound,
        Error_LeagueNotSupported,
        Error_LocationUnavailable,
        Error__none
      };
    public struct TypeError
      {
        public bool in_known_list;
        public string string_value;
        public TypeErrorKnownValues list_value;
      };

    public static TypeErrorKnownValues  stringToError(string chars)
      {
        switch (chars[0])
          {
            case 'L':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "agueNotSupported", 0, 16, false) == 0) && (chars.Length == 18))
                            return TypeErrorKnownValues.Error_LeagueNotSupported;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "cationUnavailable", 0, 17, false) == 0) && (chars.Length == 19))
                            return TypeErrorKnownValues.Error_LocationUnavailable;
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if ((String.Compare(chars, 1, "oGamesFound", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeErrorKnownValues.Error_NoGamesFound;
                break;
            default:
                break;
          }
        return TypeErrorKnownValues.Error__none;
      }

    public static string  stringFromError(TypeErrorKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeErrorKnownValues.Error_NoGamesFound:
                return "NoGamesFound";
            case TypeErrorKnownValues.Error_LeagueNotSupported:
                return "LeagueNotSupported";
            case TypeErrorKnownValues.Error_LocationUnavailable:
                return "LocationUnavailable";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasType;
    private TypeType storeType;
    private bool flagHasTeams;
    private List< SportsTeamNewJSON  > storeTeams;
    private bool flagHasLeagues;
    private List< SportsLeagueCodeJSON  > storeLeagues;
    private bool flagHasDateTimeRange;
    private DateTimeRangeSpecJSON  storeDateTimeRange;
    private bool flagHasLocation;
    private MapLocationJSON  storeLocation;
    private bool flagHasHomeAway;
    private TypeHomeAway storeHomeAway;
    private bool flagHasSeasonType;
    private SportsSeasonTypeJSON  storeSeasonType;
    private bool flagHasSpecialGameType;
    private List< SportsPlayoffSpecialGameJSON  > storeSpecialGameType;
    private bool flagHasSeriesGameNumber;
    private BigInteger storeSeriesGameNumber;
    private bool flagHasQueryGameOutcome;
    private TypeQueryGameOutcome storeQueryGameOutcome;
    private bool flagHasQueryMentionedGame;
    private bool storeQueryMentionedGame;
    private bool flagHasResultType;
    private TypeResultType storeResultType;
    private bool flagHasSeriesStatus;
    private List< SportsSeriesStatusNewJSON  > storeSeriesStatus;
    private bool flagHasDateTimeRangeLocationDropped;
    private bool storeDateTimeRangeLocationDropped;
    private bool flagHasGamesIndicesBestMatches;
    private List< BigInteger > storeGamesIndicesBestMatches;
    private bool flagHasGamesIndicesSecondaryMatches;
    private List< BigInteger > storeGamesIndicesSecondaryMatches;
    private bool flagHasGamesIndicesRecentGames;
    private List< BigInteger > storeGamesIndicesRecentGames;
    private bool flagHasGamesIndicesUpcomingGames;
    private List< BigInteger > storeGamesIndicesUpcomingGames;
    private bool flagHasInferredUserFavoriteTeamIndex;
    private sbyte storeInferredUserFavoriteTeamIndex;
    private bool flagHasError;
    private TypeError storeError;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Type of SportsGameSchedulesScoresQueryDataJSON is not a string.");
        TypeType the_open_enum = new TypeType();
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "roadcastNetwork", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_BroadcastNetwork;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ocation", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_Location;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if (String.Compare(json_string.getData(), 1, "c", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'h':
                            if ((String.Compare(json_string.getData(), 3, "edule", 0, 5, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeTypeKnownValues.Type_Schedule;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'o':
                            if (String.Compare(json_string.getData(), 3, "re", 0, 2, false) == 0)
                              {
                                if (json_string.getData().Length == 5)
                                  {
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeTypeKnownValues.Type_Score;
                                        goto open_enum_is_done;
                                      }
                                  }
                                switch (json_string.getData()[5])
                                  {
                                    case 'O':
                                        if ((String.Compare(json_string.getData(), 6, "rSchedule", 0, 9, false) == 0) && (json_string.getData().Length == 15))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeTypeKnownValues.Type_ScoreOrSchedule;
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
        setType(the_open_enum);
      }


    private void  fromJSONTeams(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Teams of SportsGameSchedulesScoresQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Teams of SportsGameSchedulesScoresQueryDataJSON has too few elements.");
        List< SportsTeamNewJSON  > vector_Teams1 = new List< SportsTeamNewJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsTeamNewJSON convert_classy = SportsTeamNewJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Teams1.Add(convert_classy);
          }
        Debug.Assert(vector_Teams1.Count >= 1);
        initTeams();
        for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
            appendTeams(vector_Teams1[num1]);
        for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
          {
          }
      }


    private void  fromJSONLeagues(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Leagues of SportsGameSchedulesScoresQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Leagues of SportsGameSchedulesScoresQueryDataJSON has too few elements.");
        List< SportsLeagueCodeJSON  > vector_Leagues1 = new List< SportsLeagueCodeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsLeagueCodeJSON convert_classy = SportsLeagueCodeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Leagues1.Add(convert_classy);
          }
        Debug.Assert(vector_Leagues1.Count >= 1);
        initLeagues();
        for (int num2 = 0; num2 < vector_Leagues1.Count; ++num2)
            appendLeagues(vector_Leagues1[num2]);
        for (int num1 = 0; num1 < vector_Leagues1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDateTimeRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateTimeRange(convert_classy);
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setLocation(convert_classy);
      }


    private void  fromJSONHomeAway(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HomeAway of SportsGameSchedulesScoresQueryDataJSON is not a string.");
        TypeHomeAway the_open_enum = new TypeHomeAway();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "way", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeHomeAwayKnownValues.HomeAway_Away;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "ome", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeHomeAwayKnownValues.HomeAway_Home;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setHomeAway(the_open_enum);
      }


    private void  fromJSONSeasonType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsSeasonTypeJSON convert_classy = SportsSeasonTypeJSON.from_json(json_value, ignore_extras, true);
        setSeasonType(convert_classy);
      }


    private void  fromJSONSpecialGameType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SpecialGameType of SportsGameSchedulesScoresQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field SpecialGameType of SportsGameSchedulesScoresQueryDataJSON has too few elements.");
        List< SportsPlayoffSpecialGameJSON  > vector_SpecialGameType1 = new List< SportsPlayoffSpecialGameJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsPlayoffSpecialGameJSON convert_classy = SportsPlayoffSpecialGameJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_SpecialGameType1.Add(convert_classy);
          }
        Debug.Assert(vector_SpecialGameType1.Count >= 1);
        initSpecialGameType();
        for (int num3 = 0; num3 < vector_SpecialGameType1.Count; ++num3)
            appendSpecialGameType(vector_SpecialGameType1[num3]);
        for (int num1 = 0; num1 < vector_SpecialGameType1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSeriesGameNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SeriesGameNumber of SportsGameSchedulesScoresQueryDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SeriesGameNumber of SportsGameSchedulesScoresQueryDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSeriesGameNumber(extracted_integer);
      }


    private void  fromJSONQueryGameOutcome(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QueryGameOutcome of SportsGameSchedulesScoresQueryDataJSON is not a string.");
        TypeQueryGameOutcome the_open_enum = new TypeQueryGameOutcome();
        switch (json_string.getData()[0])
          {
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ost", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryGameOutcomeKnownValues.QueryGameOutcome_Lost;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "ied", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryGameOutcomeKnownValues.QueryGameOutcome_Tied;
                        goto open_enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "on", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryGameOutcomeKnownValues.QueryGameOutcome_Won;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setQueryGameOutcome(the_open_enum);
      }


    private void  fromJSONQueryMentionedGame(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field QueryMentionedGame of SportsGameSchedulesScoresQueryDataJSON is not true for false.");
              }
          }
        setQueryMentionedGame(the_bool);
      }


    private void  fromJSONResultType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResultType of SportsGameSchedulesScoresQueryDataJSON is not a string.");
        TypeResultType the_open_enum = new TypeResultType();
        switch (json_string.getData()[0])
          {
            case 'G':
                if ((String.Compare(json_string.getData(), 1, "eneric", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeResultTypeKnownValues.ResultType_Generic;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "layoffsComplete", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeResultTypeKnownValues.ResultType_PlayoffsComplete;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "eries", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeResultTypeKnownValues.ResultType_Series;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "eam", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeResultTypeKnownValues.ResultType_Team;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setResultType(the_open_enum);
      }


    private void  fromJSONSeriesStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SeriesStatus of SportsGameSchedulesScoresQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field SeriesStatus of SportsGameSchedulesScoresQueryDataJSON has too few elements.");
        List< SportsSeriesStatusNewJSON  > vector_SeriesStatus1 = new List< SportsSeriesStatusNewJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsSeriesStatusNewJSON convert_classy = SportsSeriesStatusNewJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_SeriesStatus1.Add(convert_classy);
          }
        Debug.Assert(vector_SeriesStatus1.Count >= 1);
        initSeriesStatus();
        for (int num4 = 0; num4 < vector_SeriesStatus1.Count; ++num4)
            appendSeriesStatus(vector_SeriesStatus1[num4]);
        for (int num1 = 0; num1 < vector_SeriesStatus1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDateTimeRangeLocationDropped(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field DateTimeRangeLocationDropped of SportsGameSchedulesScoresQueryDataJSON is not true for false.");
              }
          }
        setDateTimeRangeLocationDropped(the_bool);
      }


    private void  fromJSONGamesIndicesBestMatches(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field GamesIndicesBestMatches of SportsGameSchedulesScoresQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field GamesIndicesBestMatches of SportsGameSchedulesScoresQueryDataJSON has too few elements.");
        List< BigInteger > vector_GamesIndicesBestMatches1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field GamesIndicesBestMatches of SportsGameSchedulesScoresQueryDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field GamesIndicesBestMatches of SportsGameSchedulesScoresQueryDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_GamesIndicesBestMatches1.Add(extracted_integer);
          }
        Debug.Assert(vector_GamesIndicesBestMatches1.Count >= 1);
        initGamesIndicesBestMatches();
        for (int num5 = 0; num5 < vector_GamesIndicesBestMatches1.Count; ++num5)
            appendGamesIndicesBestMatches(vector_GamesIndicesBestMatches1[num5]);
        for (int num1 = 0; num1 < vector_GamesIndicesBestMatches1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGamesIndicesSecondaryMatches(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field GamesIndicesSecondaryMatches of SportsGameSchedulesScoresQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field GamesIndicesSecondaryMatches of SportsGameSchedulesScoresQueryDataJSON has too few elements.");
        List< BigInteger > vector_GamesIndicesSecondaryMatches1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field GamesIndicesSecondaryMatches of SportsGameSchedulesScoresQueryDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field GamesIndicesSecondaryMatches of SportsGameSchedulesScoresQueryDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_GamesIndicesSecondaryMatches1.Add(extracted_integer);
          }
        Debug.Assert(vector_GamesIndicesSecondaryMatches1.Count >= 1);
        initGamesIndicesSecondaryMatches();
        for (int num6 = 0; num6 < vector_GamesIndicesSecondaryMatches1.Count; ++num6)
            appendGamesIndicesSecondaryMatches(vector_GamesIndicesSecondaryMatches1[num6]);
        for (int num1 = 0; num1 < vector_GamesIndicesSecondaryMatches1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGamesIndicesRecentGames(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field GamesIndicesRecentGames of SportsGameSchedulesScoresQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field GamesIndicesRecentGames of SportsGameSchedulesScoresQueryDataJSON has too few elements.");
        List< BigInteger > vector_GamesIndicesRecentGames1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field GamesIndicesRecentGames of SportsGameSchedulesScoresQueryDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field GamesIndicesRecentGames of SportsGameSchedulesScoresQueryDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_GamesIndicesRecentGames1.Add(extracted_integer);
          }
        Debug.Assert(vector_GamesIndicesRecentGames1.Count >= 1);
        initGamesIndicesRecentGames();
        for (int num7 = 0; num7 < vector_GamesIndicesRecentGames1.Count; ++num7)
            appendGamesIndicesRecentGames(vector_GamesIndicesRecentGames1[num7]);
        for (int num1 = 0; num1 < vector_GamesIndicesRecentGames1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGamesIndicesUpcomingGames(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field GamesIndicesUpcomingGames of SportsGameSchedulesScoresQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field GamesIndicesUpcomingGames of SportsGameSchedulesScoresQueryDataJSON has too few elements.");
        List< BigInteger > vector_GamesIndicesUpcomingGames1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field GamesIndicesUpcomingGames of SportsGameSchedulesScoresQueryDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field GamesIndicesUpcomingGames of SportsGameSchedulesScoresQueryDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_GamesIndicesUpcomingGames1.Add(extracted_integer);
          }
        Debug.Assert(vector_GamesIndicesUpcomingGames1.Count >= 1);
        initGamesIndicesUpcomingGames();
        for (int num8 = 0; num8 < vector_GamesIndicesUpcomingGames1.Count; ++num8)
            appendGamesIndicesUpcomingGames(vector_GamesIndicesUpcomingGames1[num8]);
        for (int num1 = 0; num1 < vector_GamesIndicesUpcomingGames1.Count; ++num1)
          {
          }
      }


    private void  fromJSONInferredUserFavoriteTeamIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field InferredUserFavoriteTeamIndex of SportsGameSchedulesScoresQueryDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field InferredUserFavoriteTeamIndex of SportsGameSchedulesScoresQueryDataJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setInferredUserFavoriteTeamIndex(extracted_integer);
      }


    private void  fromJSONError(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Error of SportsGameSchedulesScoresQueryDataJSON is not a string.");
        TypeError the_open_enum = new TypeError();
        switch (json_string.getData()[0])
          {
            case 'L':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "agueNotSupported", 0, 16, false) == 0) && (json_string.getData().Length == 18))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeErrorKnownValues.Error_LeagueNotSupported;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "cationUnavailable", 0, 17, false) == 0) && (json_string.getData().Length == 19))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeErrorKnownValues.Error_LocationUnavailable;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "oGamesFound", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeErrorKnownValues.Error_NoGamesFound;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setError(the_open_enum);
      }


    public SportsGameSchedulesScoresQueryDataJSON()
      {
        flagHasType = false;
        flagHasTeams = false;
        flagHasLeagues = false;
        flagHasDateTimeRange = false;
        flagHasLocation = false;
        flagHasHomeAway = false;
        flagHasSeasonType = false;
        flagHasSpecialGameType = false;
        flagHasSeriesGameNumber = false;
        flagHasQueryGameOutcome = false;
        flagHasQueryMentionedGame = false;
        flagHasResultType = false;
        flagHasSeriesStatus = false;
        flagHasDateTimeRangeLocationDropped = false;
        flagHasGamesIndicesBestMatches = false;
        flagHasGamesIndicesSecondaryMatches = false;
        flagHasGamesIndicesRecentGames = false;
        flagHasGamesIndicesUpcomingGames = false;
        flagHasInferredUserFavoriteTeamIndex = false;
        flagHasError = false;
        storeTeams = new List< SportsTeamNewJSON  >();
        storeLeagues = new List< SportsLeagueCodeJSON  >();
        storeSpecialGameType = new List< SportsPlayoffSpecialGameJSON  >();
        storeSeriesStatus = new List< SportsSeriesStatusNewJSON  >();
        storeGamesIndicesBestMatches = new List< BigInteger >();
        storeGamesIndicesSecondaryMatches = new List< BigInteger >();
        storeGamesIndicesRecentGames = new List< BigInteger >();
        storeGamesIndicesUpcomingGames = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public TypeType  getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }

    public string  getTypeAsString()
      {
        TypeType result = getType();
        if (result.in_known_list)
            return stringFromType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasTeams()
      {
        return flagHasTeams;
      }

    public int  countOfTeams()
      {
        Debug.Assert(flagHasTeams);
        return storeTeams.Count;
      }

    public SportsTeamNewJSON   elementOfTeams(int element_num)
      {
        Debug.Assert(flagHasTeams);
        return storeTeams[element_num];
      }

    public List< SportsTeamNewJSON  >  getTeams()
      {
        Debug.Assert(flagHasTeams);
        return storeTeams;
      }

    public bool  hasLeagues()
      {
        return flagHasLeagues;
      }

    public int  countOfLeagues()
      {
        Debug.Assert(flagHasLeagues);
        return storeLeagues.Count;
      }

    public SportsLeagueCodeJSON   elementOfLeagues(int element_num)
      {
        Debug.Assert(flagHasLeagues);
        return storeLeagues[element_num];
      }

    public List< SportsLeagueCodeJSON  >  getLeagues()
      {
        Debug.Assert(flagHasLeagues);
        return storeLeagues;
      }

    public bool  hasDateTimeRange()
      {
        return flagHasDateTimeRange;
      }

    public DateTimeRangeSpecJSON   getDateTimeRange()
      {
        Debug.Assert(flagHasDateTimeRange);
        return storeDateTimeRange;
      }

    public bool  hasLocation()
      {
        return flagHasLocation;
      }

    public MapLocationJSON   getLocation()
      {
        Debug.Assert(flagHasLocation);
        return storeLocation;
      }

    public bool  hasHomeAway()
      {
        return flagHasHomeAway;
      }

    public TypeHomeAway  getHomeAway()
      {
        Debug.Assert(flagHasHomeAway);
        return storeHomeAway;
      }

    public string  getHomeAwayAsString()
      {
        TypeHomeAway result = getHomeAway();
        if (result.in_known_list)
            return stringFromHomeAway(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasSeasonType()
      {
        return flagHasSeasonType;
      }

    public SportsSeasonTypeJSON   getSeasonType()
      {
        Debug.Assert(flagHasSeasonType);
        return storeSeasonType;
      }

    public SportsSeasonTypeJSON.TypeValue  getSeasonTypeValue()
      {
        return getSeasonType().getValue();
      }

    public string  getSeasonTypeAsString()
      {
        return getSeasonType().getValueAsString();
      }

    public bool  hasSpecialGameType()
      {
        return flagHasSpecialGameType;
      }

    public int  countOfSpecialGameType()
      {
        Debug.Assert(flagHasSpecialGameType);
        return storeSpecialGameType.Count;
      }

    public SportsPlayoffSpecialGameJSON   elementOfSpecialGameType(int element_num)
      {
        Debug.Assert(flagHasSpecialGameType);
        return storeSpecialGameType[element_num];
      }

    public List< SportsPlayoffSpecialGameJSON  >  getSpecialGameType()
      {
        Debug.Assert(flagHasSpecialGameType);
        return storeSpecialGameType;
      }

    public bool  hasSeriesGameNumber()
      {
        return flagHasSeriesGameNumber;
      }

    public BigInteger  getSeriesGameNumber()
      {
        Debug.Assert(flagHasSeriesGameNumber);
        return storeSeriesGameNumber;
      }

    public bool  hasQueryGameOutcome()
      {
        return flagHasQueryGameOutcome;
      }

    public TypeQueryGameOutcome  getQueryGameOutcome()
      {
        Debug.Assert(flagHasQueryGameOutcome);
        return storeQueryGameOutcome;
      }

    public string  getQueryGameOutcomeAsString()
      {
        TypeQueryGameOutcome result = getQueryGameOutcome();
        if (result.in_known_list)
            return stringFromQueryGameOutcome(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasQueryMentionedGame()
      {
        return flagHasQueryMentionedGame;
      }

    public bool  getQueryMentionedGame()
      {
        Debug.Assert(flagHasQueryMentionedGame);
        return storeQueryMentionedGame;
      }

    public bool  hasResultType()
      {
        return flagHasResultType;
      }

    public TypeResultType  getResultType()
      {
        Debug.Assert(flagHasResultType);
        return storeResultType;
      }

    public string  getResultTypeAsString()
      {
        TypeResultType result = getResultType();
        if (result.in_known_list)
            return stringFromResultType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasSeriesStatus()
      {
        return flagHasSeriesStatus;
      }

    public int  countOfSeriesStatus()
      {
        Debug.Assert(flagHasSeriesStatus);
        return storeSeriesStatus.Count;
      }

    public SportsSeriesStatusNewJSON   elementOfSeriesStatus(int element_num)
      {
        Debug.Assert(flagHasSeriesStatus);
        return storeSeriesStatus[element_num];
      }

    public List< SportsSeriesStatusNewJSON  >  getSeriesStatus()
      {
        Debug.Assert(flagHasSeriesStatus);
        return storeSeriesStatus;
      }

    public bool  hasDateTimeRangeLocationDropped()
      {
        return flagHasDateTimeRangeLocationDropped;
      }

    public bool  getDateTimeRangeLocationDropped()
      {
        Debug.Assert(flagHasDateTimeRangeLocationDropped);
        return storeDateTimeRangeLocationDropped;
      }

    public bool  hasGamesIndicesBestMatches()
      {
        return flagHasGamesIndicesBestMatches;
      }

    public int  countOfGamesIndicesBestMatches()
      {
        Debug.Assert(flagHasGamesIndicesBestMatches);
        return storeGamesIndicesBestMatches.Count;
      }

    public BigInteger  elementOfGamesIndicesBestMatches(int element_num)
      {
        Debug.Assert(flagHasGamesIndicesBestMatches);
        return storeGamesIndicesBestMatches[element_num];
      }

    public List< BigInteger >  getGamesIndicesBestMatches()
      {
        Debug.Assert(flagHasGamesIndicesBestMatches);
        return storeGamesIndicesBestMatches;
      }

    public bool  hasGamesIndicesSecondaryMatches()
      {
        return flagHasGamesIndicesSecondaryMatches;
      }

    public int  countOfGamesIndicesSecondaryMatches()
      {
        Debug.Assert(flagHasGamesIndicesSecondaryMatches);
        return storeGamesIndicesSecondaryMatches.Count;
      }

    public BigInteger  elementOfGamesIndicesSecondaryMatches(int element_num)
      {
        Debug.Assert(flagHasGamesIndicesSecondaryMatches);
        return storeGamesIndicesSecondaryMatches[element_num];
      }

    public List< BigInteger >  getGamesIndicesSecondaryMatches()
      {
        Debug.Assert(flagHasGamesIndicesSecondaryMatches);
        return storeGamesIndicesSecondaryMatches;
      }

    public bool  hasGamesIndicesRecentGames()
      {
        return flagHasGamesIndicesRecentGames;
      }

    public int  countOfGamesIndicesRecentGames()
      {
        Debug.Assert(flagHasGamesIndicesRecentGames);
        return storeGamesIndicesRecentGames.Count;
      }

    public BigInteger  elementOfGamesIndicesRecentGames(int element_num)
      {
        Debug.Assert(flagHasGamesIndicesRecentGames);
        return storeGamesIndicesRecentGames[element_num];
      }

    public List< BigInteger >  getGamesIndicesRecentGames()
      {
        Debug.Assert(flagHasGamesIndicesRecentGames);
        return storeGamesIndicesRecentGames;
      }

    public bool  hasGamesIndicesUpcomingGames()
      {
        return flagHasGamesIndicesUpcomingGames;
      }

    public int  countOfGamesIndicesUpcomingGames()
      {
        Debug.Assert(flagHasGamesIndicesUpcomingGames);
        return storeGamesIndicesUpcomingGames.Count;
      }

    public BigInteger  elementOfGamesIndicesUpcomingGames(int element_num)
      {
        Debug.Assert(flagHasGamesIndicesUpcomingGames);
        return storeGamesIndicesUpcomingGames[element_num];
      }

    public List< BigInteger >  getGamesIndicesUpcomingGames()
      {
        Debug.Assert(flagHasGamesIndicesUpcomingGames);
        return storeGamesIndicesUpcomingGames;
      }

    public bool  hasInferredUserFavoriteTeamIndex()
      {
        return flagHasInferredUserFavoriteTeamIndex;
      }

    public sbyte  getInferredUserFavoriteTeamIndex()
      {
        Debug.Assert(flagHasInferredUserFavoriteTeamIndex);
        return storeInferredUserFavoriteTeamIndex;
      }

    public bool  hasError()
      {
        return flagHasError;
      }

    public TypeError  getError()
      {
        Debug.Assert(flagHasError);
        return storeError;
      }

    public string  getErrorAsString()
      {
        TypeError result = getError();
        if (result.in_known_list)
            return stringFromError(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraSportsGameSchedulesScoresQueryDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsGameSchedulesScoresQueryDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsGameSchedulesScoresQueryDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsGameSchedulesScoresQueryDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setType(TypeType new_value)
      {
        flagHasType = true;
        storeType = new_value;
      }
    public void setType(string chars)
      {
        TypeTypeKnownValues known = stringToType(chars);
        TypeType new_value = new TypeType();
        if (known == TypeTypeKnownValues.Type__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setType(new_value);
      }
    public void setType(TypeTypeKnownValues new_value)
      {
        TypeType new_full_value = new TypeType();
        Debug.Assert(new_value != TypeTypeKnownValues.Type__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setType(new_full_value);
      }
    public void unsetType()
      {
        flagHasType = false;
      }
    public void initTeams()
      {
        if (flagHasTeams)
          {
            for (int num1 = 0; num1 < storeTeams.Count; ++num1)
              {
              }
          }
        flagHasTeams = true;
        storeTeams.Clear();
      }
    public void appendTeams(SportsTeamNewJSON  to_append)
      {
        if (!flagHasTeams)
          {
            flagHasTeams = true;
            storeTeams.Clear();
          }
        Debug.Assert(flagHasTeams);
        storeTeams.Add(to_append);
      }
    public void unsetTeams()
      {
        if (flagHasTeams)
          {
            for (int num2 = 0; num2 < storeTeams.Count; ++num2)
              {
              }
          }
        flagHasTeams = false;
        storeTeams.Clear();
      }
    public void initLeagues()
      {
        if (flagHasLeagues)
          {
            for (int num3 = 0; num3 < storeLeagues.Count; ++num3)
              {
              }
          }
        flagHasLeagues = true;
        storeLeagues.Clear();
      }
    public void appendLeagues(SportsLeagueCodeJSON  to_append)
      {
        if (!flagHasLeagues)
          {
            flagHasLeagues = true;
            storeLeagues.Clear();
          }
        Debug.Assert(flagHasLeagues);
        storeLeagues.Add(to_append);
      }
    public void appendLeagues(SportsLeagueCodeJSON.TypeValue new_value)
      {
        appendLeagues(new SportsLeagueCodeJSON(new_value));
      }
    public void appendLeagues(string chars)
      {
        SportsLeagueCodeJSON.TypeValueKnownValues known = SportsLeagueCodeJSON.stringToValue(chars);
        SportsLeagueCodeJSON.TypeValue new_value = new SportsLeagueCodeJSON.TypeValue();
        if (known == SportsLeagueCodeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendLeagues(new_value);
      }
    public void unsetLeagues()
      {
        if (flagHasLeagues)
          {
            for (int num4 = 0; num4 < storeLeagues.Count; ++num4)
              {
              }
          }
        flagHasLeagues = false;
        storeLeagues.Clear();
      }
    public void setDateTimeRange(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasDateTimeRange)
          {
          }
        flagHasDateTimeRange = true;
        storeDateTimeRange = new_value;
      }
    public void unsetDateTimeRange()
      {
        if (flagHasDateTimeRange)
          {
          }
        flagHasDateTimeRange = false;
      }
    public void setLocation(MapLocationJSON  new_value)
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = true;
        storeLocation = new_value;
      }
    public void unsetLocation()
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = false;
      }
    public void setHomeAway(TypeHomeAway new_value)
      {
        flagHasHomeAway = true;
        storeHomeAway = new_value;
      }
    public void setHomeAway(string chars)
      {
        TypeHomeAwayKnownValues known = stringToHomeAway(chars);
        TypeHomeAway new_value = new TypeHomeAway();
        if (known == TypeHomeAwayKnownValues.HomeAway__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setHomeAway(new_value);
      }
    public void setHomeAway(TypeHomeAwayKnownValues new_value)
      {
        TypeHomeAway new_full_value = new TypeHomeAway();
        Debug.Assert(new_value != TypeHomeAwayKnownValues.HomeAway__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setHomeAway(new_full_value);
      }
    public void unsetHomeAway()
      {
        flagHasHomeAway = false;
      }
    public void setSeasonType(SportsSeasonTypeJSON  new_value)
      {
        if (flagHasSeasonType)
          {
          }
        flagHasSeasonType = true;
        storeSeasonType = new_value;
      }
    public void setSeasonType(SportsSeasonTypeJSON.TypeValue new_value)
      {
        setSeasonType(new SportsSeasonTypeJSON(new_value));
      }
    public void setSeasonType(string chars)
      {
        SportsSeasonTypeJSON.TypeValueKnownValues known = SportsSeasonTypeJSON.stringToValue(chars);
        SportsSeasonTypeJSON.TypeValue new_value = new SportsSeasonTypeJSON.TypeValue();
        if (known == SportsSeasonTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSeasonType(new_value);
      }
    public void unsetSeasonType()
      {
        if (flagHasSeasonType)
          {
          }
        flagHasSeasonType = false;
      }
    public void initSpecialGameType()
      {
        if (flagHasSpecialGameType)
          {
            for (int num5 = 0; num5 < storeSpecialGameType.Count; ++num5)
              {
              }
          }
        flagHasSpecialGameType = true;
        storeSpecialGameType.Clear();
      }
    public void appendSpecialGameType(SportsPlayoffSpecialGameJSON  to_append)
      {
        if (!flagHasSpecialGameType)
          {
            flagHasSpecialGameType = true;
            storeSpecialGameType.Clear();
          }
        Debug.Assert(flagHasSpecialGameType);
        storeSpecialGameType.Add(to_append);
      }
    public void appendSpecialGameType(SportsPlayoffSpecialGameJSON.TypeValue new_value)
      {
        appendSpecialGameType(new SportsPlayoffSpecialGameJSON(new_value));
      }
    public void appendSpecialGameType(string chars)
      {
        SportsPlayoffSpecialGameJSON.TypeValueKnownValues known = SportsPlayoffSpecialGameJSON.stringToValue(chars);
        SportsPlayoffSpecialGameJSON.TypeValue new_value = new SportsPlayoffSpecialGameJSON.TypeValue();
        if (known == SportsPlayoffSpecialGameJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendSpecialGameType(new_value);
      }
    public void unsetSpecialGameType()
      {
        if (flagHasSpecialGameType)
          {
            for (int num6 = 0; num6 < storeSpecialGameType.Count; ++num6)
              {
              }
          }
        flagHasSpecialGameType = false;
        storeSpecialGameType.Clear();
      }
    public void setSeriesGameNumber(BigInteger new_value)
      {
        flagHasSeriesGameNumber = true;
        if (new_value < 1)
            throw new Exception("The value for field SeriesGameNumber of SportsGameSchedulesScoresQueryDataJSON is less than the lower bound (1) for that field.");
        storeSeriesGameNumber = new_value;
      }
    public void unsetSeriesGameNumber()
      {
        flagHasSeriesGameNumber = false;
      }
    public void setQueryGameOutcome(TypeQueryGameOutcome new_value)
      {
        flagHasQueryGameOutcome = true;
        storeQueryGameOutcome = new_value;
      }
    public void setQueryGameOutcome(string chars)
      {
        TypeQueryGameOutcomeKnownValues known = stringToQueryGameOutcome(chars);
        TypeQueryGameOutcome new_value = new TypeQueryGameOutcome();
        if (known == TypeQueryGameOutcomeKnownValues.QueryGameOutcome__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setQueryGameOutcome(new_value);
      }
    public void setQueryGameOutcome(TypeQueryGameOutcomeKnownValues new_value)
      {
        TypeQueryGameOutcome new_full_value = new TypeQueryGameOutcome();
        Debug.Assert(new_value != TypeQueryGameOutcomeKnownValues.QueryGameOutcome__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setQueryGameOutcome(new_full_value);
      }
    public void unsetQueryGameOutcome()
      {
        flagHasQueryGameOutcome = false;
      }
    public void setQueryMentionedGame(bool new_value)
      {
        flagHasQueryMentionedGame = true;
        storeQueryMentionedGame = new_value;
      }
    public void unsetQueryMentionedGame()
      {
        flagHasQueryMentionedGame = false;
      }
    public void setResultType(TypeResultType new_value)
      {
        flagHasResultType = true;
        storeResultType = new_value;
      }
    public void setResultType(string chars)
      {
        TypeResultTypeKnownValues known = stringToResultType(chars);
        TypeResultType new_value = new TypeResultType();
        if (known == TypeResultTypeKnownValues.ResultType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setResultType(new_value);
      }
    public void setResultType(TypeResultTypeKnownValues new_value)
      {
        TypeResultType new_full_value = new TypeResultType();
        Debug.Assert(new_value != TypeResultTypeKnownValues.ResultType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setResultType(new_full_value);
      }
    public void unsetResultType()
      {
        flagHasResultType = false;
      }
    public void initSeriesStatus()
      {
        if (flagHasSeriesStatus)
          {
            for (int num7 = 0; num7 < storeSeriesStatus.Count; ++num7)
              {
              }
          }
        flagHasSeriesStatus = true;
        storeSeriesStatus.Clear();
      }
    public void appendSeriesStatus(SportsSeriesStatusNewJSON  to_append)
      {
        if (!flagHasSeriesStatus)
          {
            flagHasSeriesStatus = true;
            storeSeriesStatus.Clear();
          }
        Debug.Assert(flagHasSeriesStatus);
        storeSeriesStatus.Add(to_append);
      }
    public void unsetSeriesStatus()
      {
        if (flagHasSeriesStatus)
          {
            for (int num8 = 0; num8 < storeSeriesStatus.Count; ++num8)
              {
              }
          }
        flagHasSeriesStatus = false;
        storeSeriesStatus.Clear();
      }
    public void setDateTimeRangeLocationDropped(bool new_value)
      {
        flagHasDateTimeRangeLocationDropped = true;
        storeDateTimeRangeLocationDropped = new_value;
      }
    public void unsetDateTimeRangeLocationDropped()
      {
        flagHasDateTimeRangeLocationDropped = false;
      }
    public void initGamesIndicesBestMatches()
      {
        flagHasGamesIndicesBestMatches = true;
        storeGamesIndicesBestMatches.Clear();
      }
    public void appendGamesIndicesBestMatches(BigInteger to_append)
      {
        if (!flagHasGamesIndicesBestMatches)
          {
            flagHasGamesIndicesBestMatches = true;
            storeGamesIndicesBestMatches.Clear();
          }
        Debug.Assert(flagHasGamesIndicesBestMatches);
        storeGamesIndicesBestMatches.Add(to_append);
      }
    public void unsetGamesIndicesBestMatches()
      {
        flagHasGamesIndicesBestMatches = false;
        storeGamesIndicesBestMatches.Clear();
      }
    public void initGamesIndicesSecondaryMatches()
      {
        flagHasGamesIndicesSecondaryMatches = true;
        storeGamesIndicesSecondaryMatches.Clear();
      }
    public void appendGamesIndicesSecondaryMatches(BigInteger to_append)
      {
        if (!flagHasGamesIndicesSecondaryMatches)
          {
            flagHasGamesIndicesSecondaryMatches = true;
            storeGamesIndicesSecondaryMatches.Clear();
          }
        Debug.Assert(flagHasGamesIndicesSecondaryMatches);
        storeGamesIndicesSecondaryMatches.Add(to_append);
      }
    public void unsetGamesIndicesSecondaryMatches()
      {
        flagHasGamesIndicesSecondaryMatches = false;
        storeGamesIndicesSecondaryMatches.Clear();
      }
    public void initGamesIndicesRecentGames()
      {
        flagHasGamesIndicesRecentGames = true;
        storeGamesIndicesRecentGames.Clear();
      }
    public void appendGamesIndicesRecentGames(BigInteger to_append)
      {
        if (!flagHasGamesIndicesRecentGames)
          {
            flagHasGamesIndicesRecentGames = true;
            storeGamesIndicesRecentGames.Clear();
          }
        Debug.Assert(flagHasGamesIndicesRecentGames);
        storeGamesIndicesRecentGames.Add(to_append);
      }
    public void unsetGamesIndicesRecentGames()
      {
        flagHasGamesIndicesRecentGames = false;
        storeGamesIndicesRecentGames.Clear();
      }
    public void initGamesIndicesUpcomingGames()
      {
        flagHasGamesIndicesUpcomingGames = true;
        storeGamesIndicesUpcomingGames.Clear();
      }
    public void appendGamesIndicesUpcomingGames(BigInteger to_append)
      {
        if (!flagHasGamesIndicesUpcomingGames)
          {
            flagHasGamesIndicesUpcomingGames = true;
            storeGamesIndicesUpcomingGames.Clear();
          }
        Debug.Assert(flagHasGamesIndicesUpcomingGames);
        storeGamesIndicesUpcomingGames.Add(to_append);
      }
    public void unsetGamesIndicesUpcomingGames()
      {
        flagHasGamesIndicesUpcomingGames = false;
        storeGamesIndicesUpcomingGames.Clear();
      }
    public void setInferredUserFavoriteTeamIndex(sbyte new_value)
      {
        flagHasInferredUserFavoriteTeamIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field InferredUserFavoriteTeamIndex of SportsGameSchedulesScoresQueryDataJSON is less than the lower bound (0) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field InferredUserFavoriteTeamIndex of SportsGameSchedulesScoresQueryDataJSON is greater than the upper bound (1) for that field.");
        storeInferredUserFavoriteTeamIndex = new_value;
      }
    public void unsetInferredUserFavoriteTeamIndex()
      {
        flagHasInferredUserFavoriteTeamIndex = false;
      }
    public void setError(TypeError new_value)
      {
        flagHasError = true;
        storeError = new_value;
      }
    public void setError(string chars)
      {
        TypeErrorKnownValues known = stringToError(chars);
        TypeError new_value = new TypeError();
        if (known == TypeErrorKnownValues.Error__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setError(new_value);
      }
    public void setError(TypeErrorKnownValues new_value)
      {
        TypeError new_full_value = new TypeError();
        Debug.Assert(new_value != TypeErrorKnownValues.Error__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setError(new_full_value);
      }
    public void unsetError()
      {
        flagHasError = false;
      }

    public virtual void extraSportsGameSchedulesScoresQueryDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsGameSchedulesScoresQueryDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsGameSchedulesScoresQueryDataLookup(key);
        if (old_field == null)
          {
            extraSportsGameSchedulesScoresQueryDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasType);
        if (flagHasType)
          {
            handler.start_pair("Type");
            if (storeType.in_known_list)
              {
                switch (storeType.list_value)
                  {
                    case TypeTypeKnownValues.Type_Score:
                        handler.string_value("Score");
                        break;
                    case TypeTypeKnownValues.Type_Schedule:
                        handler.string_value("Schedule");
                        break;
                    case TypeTypeKnownValues.Type_ScoreOrSchedule:
                        handler.string_value("ScoreOrSchedule");
                        break;
                    case TypeTypeKnownValues.Type_Location:
                        handler.string_value("Location");
                        break;
                    case TypeTypeKnownValues.Type_BroadcastNetwork:
                        handler.string_value("BroadcastNetwork");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeType.string_value);
              }
          }
        if (flagHasTeams)
          {
            handler.start_pair("Teams");
            Debug.Assert(storeTeams.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeTeams.Count; ++num1)
              {
                if (partial_allowed)
                    storeTeams[num1].write_partial_as_json(handler);
                else
                    storeTeams[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasLeagues)
          {
            handler.start_pair("Leagues");
            Debug.Assert(storeLeagues.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeLeagues.Count; ++num2)
              {
                if (partial_allowed)
                    storeLeagues[num2].write_partial_as_json(handler);
                else
                    storeLeagues[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDateTimeRange)
          {
            handler.start_pair("DateTimeRange");
            if (partial_allowed)
                storeDateTimeRange.write_partial_as_json(handler);
            else
                storeDateTimeRange.write_as_json(handler);
          }
        if (flagHasLocation)
          {
            handler.start_pair("Location");
            if (partial_allowed)
                storeLocation.write_partial_as_json(handler);
            else
                storeLocation.write_as_json(handler);
          }
        if (flagHasHomeAway)
          {
            handler.start_pair("HomeAway");
            if (storeHomeAway.in_known_list)
              {
                switch (storeHomeAway.list_value)
                  {
                    case TypeHomeAwayKnownValues.HomeAway_Home:
                        handler.string_value("Home");
                        break;
                    case TypeHomeAwayKnownValues.HomeAway_Away:
                        handler.string_value("Away");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeHomeAway.string_value);
              }
          }
        if (flagHasSeasonType)
          {
            handler.start_pair("SeasonType");
            if (partial_allowed)
                storeSeasonType.write_partial_as_json(handler);
            else
                storeSeasonType.write_as_json(handler);
          }
        if (flagHasSpecialGameType)
          {
            handler.start_pair("SpecialGameType");
            Debug.Assert(storeSpecialGameType.Count >= 1);
            handler.start_array();
            for (int num3 = 0; num3 < storeSpecialGameType.Count; ++num3)
              {
                if (partial_allowed)
                    storeSpecialGameType[num3].write_partial_as_json(handler);
                else
                    storeSpecialGameType[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSeriesGameNumber)
          {
            handler.start_pair("SeriesGameNumber");
            handler.number_value(storeSeriesGameNumber);
          }
        if (flagHasQueryGameOutcome)
          {
            handler.start_pair("QueryGameOutcome");
            if (storeQueryGameOutcome.in_known_list)
              {
                switch (storeQueryGameOutcome.list_value)
                  {
                    case TypeQueryGameOutcomeKnownValues.QueryGameOutcome_Won:
                        handler.string_value("Won");
                        break;
                    case TypeQueryGameOutcomeKnownValues.QueryGameOutcome_Lost:
                        handler.string_value("Lost");
                        break;
                    case TypeQueryGameOutcomeKnownValues.QueryGameOutcome_Tied:
                        handler.string_value("Tied");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeQueryGameOutcome.string_value);
              }
          }
        if (flagHasQueryMentionedGame)
          {
            handler.start_pair("QueryMentionedGame");
            handler.boolean_value(storeQueryMentionedGame);
          }
        if (flagHasResultType)
          {
            handler.start_pair("ResultType");
            if (storeResultType.in_known_list)
              {
                switch (storeResultType.list_value)
                  {
                    case TypeResultTypeKnownValues.ResultType_Team:
                        handler.string_value("Team");
                        break;
                    case TypeResultTypeKnownValues.ResultType_Generic:
                        handler.string_value("Generic");
                        break;
                    case TypeResultTypeKnownValues.ResultType_Series:
                        handler.string_value("Series");
                        break;
                    case TypeResultTypeKnownValues.ResultType_PlayoffsComplete:
                        handler.string_value("PlayoffsComplete");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeResultType.string_value);
              }
          }
        if (flagHasSeriesStatus)
          {
            handler.start_pair("SeriesStatus");
            Debug.Assert(storeSeriesStatus.Count >= 1);
            handler.start_array();
            for (int num4 = 0; num4 < storeSeriesStatus.Count; ++num4)
              {
                if (partial_allowed)
                    storeSeriesStatus[num4].write_partial_as_json(handler);
                else
                    storeSeriesStatus[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDateTimeRangeLocationDropped)
          {
            handler.start_pair("DateTimeRangeLocationDropped");
            handler.boolean_value(storeDateTimeRangeLocationDropped);
          }
        if (flagHasGamesIndicesBestMatches)
          {
            handler.start_pair("GamesIndicesBestMatches");
            Debug.Assert(storeGamesIndicesBestMatches.Count >= 1);
            handler.start_array();
            for (int num5 = 0; num5 < storeGamesIndicesBestMatches.Count; ++num5)
              {
                handler.number_value(storeGamesIndicesBestMatches[num5]);
              }
            handler.finish_array();
          }
        if (flagHasGamesIndicesSecondaryMatches)
          {
            handler.start_pair("GamesIndicesSecondaryMatches");
            Debug.Assert(storeGamesIndicesSecondaryMatches.Count >= 1);
            handler.start_array();
            for (int num6 = 0; num6 < storeGamesIndicesSecondaryMatches.Count; ++num6)
              {
                handler.number_value(storeGamesIndicesSecondaryMatches[num6]);
              }
            handler.finish_array();
          }
        if (flagHasGamesIndicesRecentGames)
          {
            handler.start_pair("GamesIndicesRecentGames");
            Debug.Assert(storeGamesIndicesRecentGames.Count >= 1);
            handler.start_array();
            for (int num7 = 0; num7 < storeGamesIndicesRecentGames.Count; ++num7)
              {
                handler.number_value(storeGamesIndicesRecentGames[num7]);
              }
            handler.finish_array();
          }
        if (flagHasGamesIndicesUpcomingGames)
          {
            handler.start_pair("GamesIndicesUpcomingGames");
            Debug.Assert(storeGamesIndicesUpcomingGames.Count >= 1);
            handler.start_array();
            for (int num8 = 0; num8 < storeGamesIndicesUpcomingGames.Count; ++num8)
              {
                handler.number_value(storeGamesIndicesUpcomingGames[num8]);
              }
            handler.finish_array();
          }
        if (flagHasInferredUserFavoriteTeamIndex)
          {
            handler.start_pair("InferredUserFavoriteTeamIndex");
            handler.number_value(storeInferredUserFavoriteTeamIndex);
          }
        if (flagHasError)
          {
            handler.start_pair("Error");
            if (storeError.in_known_list)
              {
                switch (storeError.list_value)
                  {
                    case TypeErrorKnownValues.Error_NoGamesFound:
                        handler.string_value("NoGamesFound");
                        break;
                    case TypeErrorKnownValues.Error_LeagueNotSupported:
                        handler.string_value("LeagueNotSupported");
                        break;
                    case TypeErrorKnownValues.Error_LocationUnavailable:
                        handler.string_value("LocationUnavailable");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeError.string_value);
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
        if (!(hasType()))
          {
            return "When parsing the object for %what%, the \"Type\" field was missing.";
          }
        return null;
      }

    public static SportsGameSchedulesScoresQueryDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsGameSchedulesScoresQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGameSchedulesScoresQueryData", ignore_extras);
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
    public static SportsGameSchedulesScoresQueryDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsGameSchedulesScoresQueryDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsGameSchedulesScoresQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGameSchedulesScoresQueryData", ignore_extras);
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
    public static SportsGameSchedulesScoresQueryDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsGameSchedulesScoresQueryDataJSON from_text(string text, bool ignore_extras)
      {
        SportsGameSchedulesScoresQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGameSchedulesScoresQueryData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsGameSchedulesScoresQueryDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsGameSchedulesScoresQueryDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsGameSchedulesScoresQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGameSchedulesScoresQueryData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorType : JSONStringGenerator
          {
            protected FieldGeneratorType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeTypeKnownValues known = stringToType(result);
                TypeType new_value = new TypeType();
                if (known == TypeTypeKnownValues.Type__none)
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
            protected abstract void handle_result(TypeType result);
          };
    private class FieldHoldingGeneratorType : FieldGeneratorType
  {
    protected override void handle_result(TypeType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorType(String what)
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
    public TypeType value;
  };
    private class FieldHoldingArrayGeneratorType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorType
      {
        private FieldHoldingArrayGeneratorType top;

        protected override void handle_result(TypeType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorType init_top)
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
    protected virtual void handle_result(List<TypeType> result)
      {
      }

    public FieldHoldingArrayGeneratorType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeType> value;
  };
        private FieldHoldingGeneratorType fieldGeneratorType;
        private SportsTeamNewJSON.HoldingArrayGenerator fieldGeneratorTeams;
        private SportsLeagueCodeJSON.HoldingArrayGenerator fieldGeneratorLeagues;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorDateTimeRange;
        private MapLocationJSON.HoldingGenerator fieldGeneratorLocation;
    private abstract class FieldGeneratorHomeAway : JSONStringGenerator
          {
            protected FieldGeneratorHomeAway(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorHomeAway()
              {
              }
            protected override void handle_result(string result)
              {
                TypeHomeAwayKnownValues known = stringToHomeAway(result);
                TypeHomeAway new_value = new TypeHomeAway();
                if (known == TypeHomeAwayKnownValues.HomeAway__none)
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
            protected abstract void handle_result(TypeHomeAway result);
          };
    private class FieldHoldingGeneratorHomeAway : FieldGeneratorHomeAway
  {
    protected override void handle_result(TypeHomeAway result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorHomeAway(String what)
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
    public TypeHomeAway value;
  };
    private class FieldHoldingArrayGeneratorHomeAway : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorHomeAway
      {
        private FieldHoldingArrayGeneratorHomeAway top;

        protected override void handle_result(TypeHomeAway result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorHomeAway init_top)
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
    protected virtual void handle_result(List<TypeHomeAway> result)
      {
      }

    public FieldHoldingArrayGeneratorHomeAway(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeHomeAway>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorHomeAway()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeHomeAway>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeHomeAway> value;
  };
        private FieldHoldingGeneratorHomeAway fieldGeneratorHomeAway;
        private SportsSeasonTypeJSON.HoldingGenerator fieldGeneratorSeasonType;
        private SportsPlayoffSpecialGameJSON.HoldingArrayGenerator fieldGeneratorSpecialGameType;
    private class FieldHoldingGeneratorSeriesGameNumber : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSeriesGameNumber(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSeriesGameNumber : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSeriesGameNumber(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorSeriesGameNumber fieldGeneratorSeriesGameNumber;
    private abstract class FieldGeneratorQueryGameOutcome : JSONStringGenerator
          {
            protected FieldGeneratorQueryGameOutcome(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorQueryGameOutcome()
              {
              }
            protected override void handle_result(string result)
              {
                TypeQueryGameOutcomeKnownValues known = stringToQueryGameOutcome(result);
                TypeQueryGameOutcome new_value = new TypeQueryGameOutcome();
                if (known == TypeQueryGameOutcomeKnownValues.QueryGameOutcome__none)
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
            protected abstract void handle_result(TypeQueryGameOutcome result);
          };
    private class FieldHoldingGeneratorQueryGameOutcome : FieldGeneratorQueryGameOutcome
  {
    protected override void handle_result(TypeQueryGameOutcome result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorQueryGameOutcome(String what)
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
    public TypeQueryGameOutcome value;
  };
    private class FieldHoldingArrayGeneratorQueryGameOutcome : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorQueryGameOutcome
      {
        private FieldHoldingArrayGeneratorQueryGameOutcome top;

        protected override void handle_result(TypeQueryGameOutcome result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorQueryGameOutcome init_top)
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
    protected virtual void handle_result(List<TypeQueryGameOutcome> result)
      {
      }

    public FieldHoldingArrayGeneratorQueryGameOutcome(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryGameOutcome>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorQueryGameOutcome()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryGameOutcome>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeQueryGameOutcome> value;
  };
        private FieldHoldingGeneratorQueryGameOutcome fieldGeneratorQueryGameOutcome;
        private JSONHoldingBooleanGenerator fieldGeneratorQueryMentionedGame;
    private abstract class FieldGeneratorResultType : JSONStringGenerator
          {
            protected FieldGeneratorResultType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorResultType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeResultTypeKnownValues known = stringToResultType(result);
                TypeResultType new_value = new TypeResultType();
                if (known == TypeResultTypeKnownValues.ResultType__none)
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
            protected abstract void handle_result(TypeResultType result);
          };
    private class FieldHoldingGeneratorResultType : FieldGeneratorResultType
  {
    protected override void handle_result(TypeResultType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorResultType(String what)
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
    public TypeResultType value;
  };
    private class FieldHoldingArrayGeneratorResultType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorResultType
      {
        private FieldHoldingArrayGeneratorResultType top;

        protected override void handle_result(TypeResultType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorResultType init_top)
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
    protected virtual void handle_result(List<TypeResultType> result)
      {
      }

    public FieldHoldingArrayGeneratorResultType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeResultType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorResultType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeResultType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeResultType> value;
  };
        private FieldHoldingGeneratorResultType fieldGeneratorResultType;
        private SportsSeriesStatusNewJSON.HoldingArrayGenerator fieldGeneratorSeriesStatus;
        private JSONHoldingBooleanGenerator fieldGeneratorDateTimeRangeLocationDropped;
    private class FieldHoldingGeneratorGamesIndicesBestMatches : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGamesIndicesBestMatches(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGamesIndicesBestMatches : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGamesIndicesBestMatches(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorGamesIndicesBestMatches fieldGeneratorGamesIndicesBestMatches;
    private class FieldHoldingGeneratorGamesIndicesSecondaryMatches : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGamesIndicesSecondaryMatches(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGamesIndicesSecondaryMatches : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGamesIndicesSecondaryMatches(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorGamesIndicesSecondaryMatches fieldGeneratorGamesIndicesSecondaryMatches;
    private class FieldHoldingGeneratorGamesIndicesRecentGames : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGamesIndicesRecentGames(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGamesIndicesRecentGames : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGamesIndicesRecentGames(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorGamesIndicesRecentGames fieldGeneratorGamesIndicesRecentGames;
    private class FieldHoldingGeneratorGamesIndicesUpcomingGames : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGamesIndicesUpcomingGames(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGamesIndicesUpcomingGames : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGamesIndicesUpcomingGames(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorGamesIndicesUpcomingGames fieldGeneratorGamesIndicesUpcomingGames;
    private class FieldHoldingGeneratorInferredUserFavoriteTeamIndex : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorInferredUserFavoriteTeamIndex(String what) : base(what, 0, 1)
              {
              }
          };
    private class FieldHoldingArrayGeneratorInferredUserFavoriteTeamIndex : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorInferredUserFavoriteTeamIndex(String what) : base(what, 0, 1)
              {
              }
          };
        private FieldHoldingGeneratorInferredUserFavoriteTeamIndex fieldGeneratorInferredUserFavoriteTeamIndex;
    private abstract class FieldGeneratorError : JSONStringGenerator
          {
            protected FieldGeneratorError(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorError()
              {
              }
            protected override void handle_result(string result)
              {
                TypeErrorKnownValues known = stringToError(result);
                TypeError new_value = new TypeError();
                if (known == TypeErrorKnownValues.Error__none)
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
            protected abstract void handle_result(TypeError result);
          };
    private class FieldHoldingGeneratorError : FieldGeneratorError
  {
    protected override void handle_result(TypeError result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorError(String what)
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
    public TypeError value;
  };
    private class FieldHoldingArrayGeneratorError : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorError
      {
        private FieldHoldingArrayGeneratorError top;

        protected override void handle_result(TypeError result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorError init_top)
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
    protected virtual void handle_result(List<TypeError> result)
      {
      }

    public FieldHoldingArrayGeneratorError(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeError>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorError()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeError>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeError> value;
  };
        private FieldHoldingGeneratorError fieldGeneratorError;
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
            SportsGameSchedulesScoresQueryDataJSON result = new SportsGameSchedulesScoresQueryDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsGameSchedulesScoresQueryDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsGameSchedulesScoresQueryDataJSON result)
          {
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
            else if ((!(result.hasType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Type\" field was missing.");
              }
            if (fieldGeneratorTeams.have_value)
              {
                result.initTeams();
                int count = fieldGeneratorTeams.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTeams(fieldGeneratorTeams.value[num]);
                  }
                fieldGeneratorTeams.value.Clear();
                fieldGeneratorTeams.have_value = false;
              }
            if (fieldGeneratorLeagues.have_value)
              {
                result.initLeagues();
                int count = fieldGeneratorLeagues.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendLeagues(fieldGeneratorLeagues.value[num]);
                  }
                fieldGeneratorLeagues.value.Clear();
                fieldGeneratorLeagues.have_value = false;
              }
            if (fieldGeneratorDateTimeRange.have_value)
              {
                result.setDateTimeRange(fieldGeneratorDateTimeRange.value);
                fieldGeneratorDateTimeRange.have_value = false;
              }
            if (fieldGeneratorLocation.have_value)
              {
                result.setLocation(fieldGeneratorLocation.value);
                fieldGeneratorLocation.have_value = false;
              }
            if (fieldGeneratorHomeAway.have_value)
              {
                result.setHomeAway(fieldGeneratorHomeAway.value);
                fieldGeneratorHomeAway.have_value = false;
              }
            if (fieldGeneratorSeasonType.have_value)
              {
                result.setSeasonType(fieldGeneratorSeasonType.value);
                fieldGeneratorSeasonType.have_value = false;
              }
            if (fieldGeneratorSpecialGameType.have_value)
              {
                result.initSpecialGameType();
                int count = fieldGeneratorSpecialGameType.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSpecialGameType(fieldGeneratorSpecialGameType.value[num]);
                  }
                fieldGeneratorSpecialGameType.value.Clear();
                fieldGeneratorSpecialGameType.have_value = false;
              }
            if (fieldGeneratorSeriesGameNumber.have_value)
              {
                result.setSeriesGameNumber(fieldGeneratorSeriesGameNumber.value);
                fieldGeneratorSeriesGameNumber.have_value = false;
              }
            if (fieldGeneratorQueryGameOutcome.have_value)
              {
                result.setQueryGameOutcome(fieldGeneratorQueryGameOutcome.value);
                fieldGeneratorQueryGameOutcome.have_value = false;
              }
            if (fieldGeneratorQueryMentionedGame.have_value)
              {
                result.setQueryMentionedGame(fieldGeneratorQueryMentionedGame.value);
                fieldGeneratorQueryMentionedGame.have_value = false;
              }
            if (fieldGeneratorResultType.have_value)
              {
                result.setResultType(fieldGeneratorResultType.value);
                fieldGeneratorResultType.have_value = false;
              }
            if (fieldGeneratorSeriesStatus.have_value)
              {
                result.initSeriesStatus();
                int count = fieldGeneratorSeriesStatus.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSeriesStatus(fieldGeneratorSeriesStatus.value[num]);
                  }
                fieldGeneratorSeriesStatus.value.Clear();
                fieldGeneratorSeriesStatus.have_value = false;
              }
            if (fieldGeneratorDateTimeRangeLocationDropped.have_value)
              {
                result.setDateTimeRangeLocationDropped(fieldGeneratorDateTimeRangeLocationDropped.value);
                fieldGeneratorDateTimeRangeLocationDropped.have_value = false;
              }
            if (fieldGeneratorGamesIndicesBestMatches.have_value)
              {
                result.initGamesIndicesBestMatches();
                int count = fieldGeneratorGamesIndicesBestMatches.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGamesIndicesBestMatches(fieldGeneratorGamesIndicesBestMatches.value[num]);
                  }
                fieldGeneratorGamesIndicesBestMatches.value.Clear();
                fieldGeneratorGamesIndicesBestMatches.have_value = false;
              }
            if (fieldGeneratorGamesIndicesSecondaryMatches.have_value)
              {
                result.initGamesIndicesSecondaryMatches();
                int count = fieldGeneratorGamesIndicesSecondaryMatches.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGamesIndicesSecondaryMatches(fieldGeneratorGamesIndicesSecondaryMatches.value[num]);
                  }
                fieldGeneratorGamesIndicesSecondaryMatches.value.Clear();
                fieldGeneratorGamesIndicesSecondaryMatches.have_value = false;
              }
            if (fieldGeneratorGamesIndicesRecentGames.have_value)
              {
                result.initGamesIndicesRecentGames();
                int count = fieldGeneratorGamesIndicesRecentGames.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGamesIndicesRecentGames(fieldGeneratorGamesIndicesRecentGames.value[num]);
                  }
                fieldGeneratorGamesIndicesRecentGames.value.Clear();
                fieldGeneratorGamesIndicesRecentGames.have_value = false;
              }
            if (fieldGeneratorGamesIndicesUpcomingGames.have_value)
              {
                result.initGamesIndicesUpcomingGames();
                int count = fieldGeneratorGamesIndicesUpcomingGames.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGamesIndicesUpcomingGames(fieldGeneratorGamesIndicesUpcomingGames.value[num]);
                  }
                fieldGeneratorGamesIndicesUpcomingGames.value.Clear();
                fieldGeneratorGamesIndicesUpcomingGames.have_value = false;
              }
            if (fieldGeneratorInferredUserFavoriteTeamIndex.have_value)
              {
                result.setInferredUserFavoriteTeamIndex((sbyte)(fieldGeneratorInferredUserFavoriteTeamIndex.value));
                fieldGeneratorInferredUserFavoriteTeamIndex.have_value = false;
              }
            if (fieldGeneratorError.have_value)
              {
                result.setError(fieldGeneratorError.value);
                fieldGeneratorError.have_value = false;
              }
          }
        protected abstract void handle_result(SportsGameSchedulesScoresQueryDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "ateTimeRange", 0, 12, false) == 0)
                      {
                        if (field_name.Length == 13)
                          {
                            return fieldGeneratorDateTimeRange;
                          }
                        switch (field_name[13])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 14, "ocationDropped", 0, 14, false) == 0) && (field_name.Length == 28))
                                    return fieldGeneratorDateTimeRangeLocationDropped;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "rror", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorError;
                    break;
                case 'G':
                    if (String.Compare(field_name, 1, "amesIndices", 0, 11, false) == 0)
                      {
                        switch (field_name[12])
                          {
                            case 'B':
                                if ((String.Compare(field_name, 13, "estMatches", 0, 10, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorGamesIndicesBestMatches;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 13, "ecentGames", 0, 10, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorGamesIndicesRecentGames;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 13, "econdaryMatches", 0, 15, false) == 0) && (field_name.Length == 28))
                                    return fieldGeneratorGamesIndicesSecondaryMatches;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 13, "pcomingGames", 0, 12, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorGamesIndicesUpcomingGames;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "omeAway", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorHomeAway;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nferredUserFavoriteTeamIndex", 0, 28, false) == 0) && (field_name.Length == 29))
                        return fieldGeneratorInferredUserFavoriteTeamIndex;
                    break;
                case 'L':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "agues", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorLeagues;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "cation", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorLocation;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'Q':
                    if (String.Compare(field_name, 1, "uery", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'G':
                                if ((String.Compare(field_name, 6, "ameOutcome", 0, 10, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorQueryGameOutcome;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 6, "entionedGame", 0, 12, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorQueryMentionedGame;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "esultType", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorResultType;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            switch (field_name[2])
                              {
                                case 'a':
                                    if ((String.Compare(field_name, 3, "sonType", 0, 7, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorSeasonType;
                                    break;
                                case 'r':
                                    if (String.Compare(field_name, 3, "ies", 0, 3, false) == 0)
                                      {
                                        switch (field_name[6])
                                          {
                                            case 'G':
                                                if ((String.Compare(field_name, 7, "ameNumber", 0, 9, false) == 0) && (field_name.Length == 16))
                                                    return fieldGeneratorSeriesGameNumber;
                                                break;
                                            case 'S':
                                                if ((String.Compare(field_name, 7, "tatus", 0, 5, false) == 0) && (field_name.Length == 12))
                                                    return fieldGeneratorSeriesStatus;
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
                        case 'p':
                            if ((String.Compare(field_name, 2, "ecialGameType", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorSpecialGameType;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "ams", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorTeams;
                            break;
                        case 'y':
                            if ((String.Compare(field_name, 2, "pe", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorType;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorTeams = new SportsTeamNewJSON.HoldingArrayGenerator("field \"Teams\" of the SportsGameSchedulesScoresQueryData class", ignore_extras);
            fieldGeneratorLeagues = new SportsLeagueCodeJSON.HoldingArrayGenerator("field \"Leagues\" of the SportsGameSchedulesScoresQueryData class", ignore_extras);
            fieldGeneratorDateTimeRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRange\" of the SportsGameSchedulesScoresQueryData class", ignore_extras);
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the SportsGameSchedulesScoresQueryData class", ignore_extras);
            fieldGeneratorHomeAway = new FieldHoldingGeneratorHomeAway("field \"HomeAway\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorSeasonType = new SportsSeasonTypeJSON.HoldingGenerator("field \"SeasonType\" of the SportsGameSchedulesScoresQueryData class", ignore_extras);
            fieldGeneratorSpecialGameType = new SportsPlayoffSpecialGameJSON.HoldingArrayGenerator("field \"SpecialGameType\" of the SportsGameSchedulesScoresQueryData class", ignore_extras);
            fieldGeneratorSeriesGameNumber = new FieldHoldingGeneratorSeriesGameNumber("field \"SeriesGameNumber\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorQueryGameOutcome = new FieldHoldingGeneratorQueryGameOutcome("field \"QueryGameOutcome\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorQueryMentionedGame = new JSONHoldingBooleanGenerator("field \"QueryMentionedGame\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorResultType = new FieldHoldingGeneratorResultType("field \"ResultType\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorSeriesStatus = new SportsSeriesStatusNewJSON.HoldingArrayGenerator("field \"SeriesStatus\" of the SportsGameSchedulesScoresQueryData class", ignore_extras);
            fieldGeneratorDateTimeRangeLocationDropped = new JSONHoldingBooleanGenerator("field \"DateTimeRangeLocationDropped\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorGamesIndicesBestMatches = new FieldHoldingArrayGeneratorGamesIndicesBestMatches("field \"GamesIndicesBestMatches\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorGamesIndicesSecondaryMatches = new FieldHoldingArrayGeneratorGamesIndicesSecondaryMatches("field \"GamesIndicesSecondaryMatches\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorGamesIndicesRecentGames = new FieldHoldingArrayGeneratorGamesIndicesRecentGames("field \"GamesIndicesRecentGames\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorGamesIndicesUpcomingGames = new FieldHoldingArrayGeneratorGamesIndicesUpcomingGames("field \"GamesIndicesUpcomingGames\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorInferredUserFavoriteTeamIndex = new FieldHoldingGeneratorInferredUserFavoriteTeamIndex("field \"InferredUserFavoriteTeamIndex\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorError = new FieldHoldingGeneratorError("field \"Error\" of the SportsGameSchedulesScoresQueryData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsGameSchedulesScoresQueryData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorTeams = new SportsTeamNewJSON.HoldingArrayGenerator("field \"Teams\" of the SportsGameSchedulesScoresQueryData class", false);
            fieldGeneratorLeagues = new SportsLeagueCodeJSON.HoldingArrayGenerator("field \"Leagues\" of the SportsGameSchedulesScoresQueryData class", false);
            fieldGeneratorDateTimeRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRange\" of the SportsGameSchedulesScoresQueryData class", false);
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the SportsGameSchedulesScoresQueryData class", false);
            fieldGeneratorHomeAway = new FieldHoldingGeneratorHomeAway("field \"HomeAway\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorSeasonType = new SportsSeasonTypeJSON.HoldingGenerator("field \"SeasonType\" of the SportsGameSchedulesScoresQueryData class", false);
            fieldGeneratorSpecialGameType = new SportsPlayoffSpecialGameJSON.HoldingArrayGenerator("field \"SpecialGameType\" of the SportsGameSchedulesScoresQueryData class", false);
            fieldGeneratorSeriesGameNumber = new FieldHoldingGeneratorSeriesGameNumber("field \"SeriesGameNumber\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorQueryGameOutcome = new FieldHoldingGeneratorQueryGameOutcome("field \"QueryGameOutcome\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorQueryMentionedGame = new JSONHoldingBooleanGenerator("field \"QueryMentionedGame\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorResultType = new FieldHoldingGeneratorResultType("field \"ResultType\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorSeriesStatus = new SportsSeriesStatusNewJSON.HoldingArrayGenerator("field \"SeriesStatus\" of the SportsGameSchedulesScoresQueryData class", false);
            fieldGeneratorDateTimeRangeLocationDropped = new JSONHoldingBooleanGenerator("field \"DateTimeRangeLocationDropped\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorGamesIndicesBestMatches = new FieldHoldingArrayGeneratorGamesIndicesBestMatches("field \"GamesIndicesBestMatches\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorGamesIndicesSecondaryMatches = new FieldHoldingArrayGeneratorGamesIndicesSecondaryMatches("field \"GamesIndicesSecondaryMatches\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorGamesIndicesRecentGames = new FieldHoldingArrayGeneratorGamesIndicesRecentGames("field \"GamesIndicesRecentGames\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorGamesIndicesUpcomingGames = new FieldHoldingArrayGeneratorGamesIndicesUpcomingGames("field \"GamesIndicesUpcomingGames\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorInferredUserFavoriteTeamIndex = new FieldHoldingGeneratorInferredUserFavoriteTeamIndex("field \"InferredUserFavoriteTeamIndex\" of the SportsGameSchedulesScoresQueryData class");
            fieldGeneratorError = new FieldHoldingGeneratorError("field \"Error\" of the SportsGameSchedulesScoresQueryData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsGameSchedulesScoresQueryData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorType.reset();
            fieldGeneratorTeams.reset();
            fieldGeneratorLeagues.reset();
            fieldGeneratorDateTimeRange.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorHomeAway.reset();
            fieldGeneratorSeasonType.reset();
            fieldGeneratorSpecialGameType.reset();
            fieldGeneratorSeriesGameNumber.reset();
            fieldGeneratorQueryGameOutcome.reset();
            fieldGeneratorQueryMentionedGame.reset();
            fieldGeneratorResultType.reset();
            fieldGeneratorSeriesStatus.reset();
            fieldGeneratorDateTimeRangeLocationDropped.reset();
            fieldGeneratorGamesIndicesBestMatches.reset();
            fieldGeneratorGamesIndicesSecondaryMatches.reset();
            fieldGeneratorGamesIndicesRecentGames.reset();
            fieldGeneratorGamesIndicesUpcomingGames.reset();
            fieldGeneratorInferredUserFavoriteTeamIndex.reset();
            fieldGeneratorError.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTeams.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLeagues.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDateTimeRange.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSeasonType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSpecialGameType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSeriesStatus.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTeams.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLeagues.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDateTimeRange.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSeasonType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSpecialGameType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSeriesStatus.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsGameSchedulesScoresQueryDataJSON  result)
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
        public SportsGameSchedulesScoresQueryDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsGameSchedulesScoresQueryDataJSON  result)
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
    protected virtual void handle_result(List<SportsGameSchedulesScoresQueryDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsGameSchedulesScoresQueryDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsGameSchedulesScoresQueryDataJSON>();
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
    public List<SportsGameSchedulesScoresQueryDataJSON> value;
  };
  };
