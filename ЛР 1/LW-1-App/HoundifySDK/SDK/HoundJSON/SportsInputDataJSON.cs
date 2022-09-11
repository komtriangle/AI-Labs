/* file "SportsInputDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsInputDataJSON : JSONBase
  {
    public enum TypeQueryTypeKnownValues
      {
        QueryType_Score,
        QueryType_Schedule,
        QueryType_Location,
        QueryType_ScoreOrSchedule,
        QueryType_BroadcastNetwork,
        QueryType__none
      };
    public struct TypeQueryType
      {
        public bool in_known_list;
        public string string_value;
        public TypeQueryTypeKnownValues list_value;
      };

    public static TypeQueryTypeKnownValues  stringToQueryType(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "roadcastNetwork", 0, 15, false) == 0) && (chars.Length == 16))
                    return TypeQueryTypeKnownValues.QueryType_BroadcastNetwork;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "ocation", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeQueryTypeKnownValues.QueryType_Location;
                break;
            case 'S':
                if (String.Compare(chars, 1, "c", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'h':
                            if ((String.Compare(chars, 3, "edule", 0, 5, false) == 0) && (chars.Length == 8))
                                return TypeQueryTypeKnownValues.QueryType_Schedule;
                            break;
                        case 'o':
                            if (String.Compare(chars, 3, "re", 0, 2, false) == 0)
                              {
                                if (chars.Length == 5)
                                  {
                                    return TypeQueryTypeKnownValues.QueryType_Score;
                                  }
                                switch (chars[5])
                                  {
                                    case 'O':
                                        if ((String.Compare(chars, 6, "rSchedule", 0, 9, false) == 0) && (chars.Length == 15))
                                            return TypeQueryTypeKnownValues.QueryType_ScoreOrSchedule;
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
        return TypeQueryTypeKnownValues.QueryType__none;
      }

    public static string  stringFromQueryType(TypeQueryTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeQueryTypeKnownValues.QueryType_Score:
                return "Score";
            case TypeQueryTypeKnownValues.QueryType_Schedule:
                return "Schedule";
            case TypeQueryTypeKnownValues.QueryType_Location:
                return "Location";
            case TypeQueryTypeKnownValues.QueryType_ScoreOrSchedule:
                return "ScoreOrSchedule";
            case TypeQueryTypeKnownValues.QueryType_BroadcastNetwork:
                return "BroadcastNetwork";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeHA
      {
        HA_Unknown,
        HA_Home,
        HA_Away
      };

    public static TypeHA  stringToHA(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "way", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeHA.HA_Away;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "ome", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeHA.HA_Home;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeHA.HA_Unknown;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `HA' is not one of the legal values.");
      }

    public static string  stringFromHA(TypeHA the_enum)
      {
        switch (the_enum)
          {
            case TypeHA.HA_Unknown:
                return "Unknown";
            case TypeHA.HA_Home:
                return "Home";
            case TypeHA.HA_Away:
                return "Away";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeWinOrLose
      {
        WinOrLose_Win,
        WinOrLose_Lose,
        WinOrLose_Tie,
        WinOrLose_Unknown
      };

    public static TypeWinOrLose  stringToWinOrLose(string chars)
      {
        switch (chars[0])
          {
            case 'L':
                if ((String.Compare(chars, 1, "ose", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeWinOrLose.WinOrLose_Lose;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "ie", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeWinOrLose.WinOrLose_Tie;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeWinOrLose.WinOrLose_Unknown;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "in", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeWinOrLose.WinOrLose_Win;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `WinOrLose' is not one of the legal values.");
      }

    public static string  stringFromWinOrLose(TypeWinOrLose the_enum)
      {
        switch (the_enum)
          {
            case TypeWinOrLose.WinOrLose_Win:
                return "Win";
            case TypeWinOrLose.WinOrLose_Lose:
                return "Lose";
            case TypeWinOrLose.WinOrLose_Tie:
                return "Tie";
            case TypeWinOrLose.WinOrLose_Unknown:
                return "Unknown";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasQueryType;
    private TypeQueryType storeQueryType;
    private bool flagHasTeams;
    private List< SportsTeamJSON  > storeTeams;
    private bool flagHasStartDateAndOrTimeSpecInput;
    private DateAndOrTimeSpecJSON  storeStartDateAndOrTimeSpecInput;
    private bool flagHasEndDateAndOrTimeSpecInput;
    private DateAndOrTimeSpecJSON  storeEndDateAndOrTimeSpecInput;
    private bool flagHasSearchLocation;
    private MapLocationJSON  storeSearchLocation;
    private bool flagHasHA;
    private TypeHA storeHA;
    private bool flagHasIsPlayoffsSpecialGame;
    private bool storeIsPlayoffsSpecialGame;
    private bool flagHasPlayoffSpecialGame;
    private List< SportsPlayoffSpecialGameContainerJSON  > storePlayoffSpecialGame;
    private bool flagHasPlayoffGameNumber;
    private BigInteger storePlayoffGameNumber;
    private bool flagHasTournament;
    private List< SportsTournamentJSON  > storeTournament;
    private bool flagHasWinOrLose;
    private TypeWinOrLose storeWinOrLose;
    private bool flagHasMentionedGame;
    private bool storeMentionedGame;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONQueryType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QueryType of SportsInputDataJSON is not a string.");
        TypeQueryType the_open_enum = new TypeQueryType();
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "roadcastNetwork", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_BroadcastNetwork;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ocation", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_Location;
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
                                    the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_Schedule;
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
                                        the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_Score;
                                        goto open_enum_is_done;
                                      }
                                  }
                                switch (json_string.getData()[5])
                                  {
                                    case 'O':
                                        if ((String.Compare(json_string.getData(), 6, "rSchedule", 0, 9, false) == 0) && (json_string.getData().Length == 15))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_ScoreOrSchedule;
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
        setQueryType(the_open_enum);
      }


    private void  fromJSONTeams(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Teams of SportsInputDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Teams of SportsInputDataJSON has too few elements.");
        List< SportsTeamJSON  > vector_Teams1 = new List< SportsTeamJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsTeamJSON convert_classy = SportsTeamJSON.from_json(json_array1.component(num1), ignore_extras, true);
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


    private void  fromJSONStartDateAndOrTimeSpecInput(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeSpecJSON convert_classy = DateAndOrTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setStartDateAndOrTimeSpecInput(convert_classy);
      }


    private void  fromJSONEndDateAndOrTimeSpecInput(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeSpecJSON convert_classy = DateAndOrTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setEndDateAndOrTimeSpecInput(convert_classy);
      }


    private void  fromJSONSearchLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setSearchLocation(convert_classy);
      }


    private void  fromJSONHA(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HA of SportsInputDataJSON is not a string.");
        TypeHA the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "way", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeHA.HA_Away;
                        goto enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "ome", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeHA.HA_Home;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeHA.HA_Unknown;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field HA of SportsInputDataJSON is not one of the legal strings.");
      enum_is_done:;
        setHA(the_enum);
      }


    private void  fromJSONIsPlayoffsSpecialGame(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsPlayoffsSpecialGame of SportsInputDataJSON is not true for false.");
              }
          }
        setIsPlayoffsSpecialGame(the_bool);
      }


    private void  fromJSONPlayoffSpecialGame(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PlayoffSpecialGame of SportsInputDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field PlayoffSpecialGame of SportsInputDataJSON has too few elements.");
        List< SportsPlayoffSpecialGameContainerJSON  > vector_PlayoffSpecialGame1 = new List< SportsPlayoffSpecialGameContainerJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsPlayoffSpecialGameContainerJSON convert_classy = SportsPlayoffSpecialGameContainerJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_PlayoffSpecialGame1.Add(convert_classy);
          }
        Debug.Assert(vector_PlayoffSpecialGame1.Count >= 1);
        initPlayoffSpecialGame();
        for (int num2 = 0; num2 < vector_PlayoffSpecialGame1.Count; ++num2)
            appendPlayoffSpecialGame(vector_PlayoffSpecialGame1[num2]);
        for (int num1 = 0; num1 < vector_PlayoffSpecialGame1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPlayoffGameNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field PlayoffGameNumber of SportsInputDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PlayoffGameNumber of SportsInputDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setPlayoffGameNumber(extracted_integer);
      }


    private void  fromJSONTournament(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Tournament of SportsInputDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Tournament of SportsInputDataJSON has too few elements.");
        List< SportsTournamentJSON  > vector_Tournament1 = new List< SportsTournamentJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsTournamentJSON convert_classy = SportsTournamentJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Tournament1.Add(convert_classy);
          }
        Debug.Assert(vector_Tournament1.Count >= 1);
        initTournament();
        for (int num3 = 0; num3 < vector_Tournament1.Count; ++num3)
            appendTournament(vector_Tournament1[num3]);
        for (int num1 = 0; num1 < vector_Tournament1.Count; ++num1)
          {
          }
      }


    private void  fromJSONWinOrLose(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WinOrLose of SportsInputDataJSON is not a string.");
        TypeWinOrLose the_enum;
        switch (json_string.getData()[0])
          {
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ose", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeWinOrLose.WinOrLose_Lose;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "ie", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_enum = TypeWinOrLose.WinOrLose_Tie;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeWinOrLose.WinOrLose_Unknown;
                        goto enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "in", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_enum = TypeWinOrLose.WinOrLose_Win;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field WinOrLose of SportsInputDataJSON is not one of the legal strings.");
      enum_is_done:;
        setWinOrLose(the_enum);
      }


    private void  fromJSONMentionedGame(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MentionedGame of SportsInputDataJSON is not true for false.");
              }
          }
        setMentionedGame(the_bool);
      }


    public SportsInputDataJSON()
      {
        flagHasQueryType = false;
        flagHasTeams = false;
        flagHasStartDateAndOrTimeSpecInput = false;
        flagHasEndDateAndOrTimeSpecInput = false;
        flagHasSearchLocation = false;
        flagHasHA = false;
        flagHasIsPlayoffsSpecialGame = false;
        flagHasPlayoffSpecialGame = false;
        flagHasPlayoffGameNumber = false;
        flagHasTournament = false;
        flagHasWinOrLose = false;
        flagHasMentionedGame = false;
        storeTeams = new List< SportsTeamJSON  >();
        storePlayoffSpecialGame = new List< SportsPlayoffSpecialGameContainerJSON  >();
        storeTournament = new List< SportsTournamentJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasQueryType()
      {
        return flagHasQueryType;
      }

    public TypeQueryType  getQueryType()
      {
        Debug.Assert(flagHasQueryType);
        return storeQueryType;
      }

    public string  getQueryTypeAsString()
      {
        TypeQueryType result = getQueryType();
        if (result.in_known_list)
            return stringFromQueryType(result.list_value);
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

    public SportsTeamJSON   elementOfTeams(int element_num)
      {
        Debug.Assert(flagHasTeams);
        return storeTeams[element_num];
      }

    public List< SportsTeamJSON  >  getTeams()
      {
        Debug.Assert(flagHasTeams);
        return storeTeams;
      }

    public bool  hasStartDateAndOrTimeSpecInput()
      {
        return flagHasStartDateAndOrTimeSpecInput;
      }

    public DateAndOrTimeSpecJSON   getStartDateAndOrTimeSpecInput()
      {
        Debug.Assert(flagHasStartDateAndOrTimeSpecInput);
        return storeStartDateAndOrTimeSpecInput;
      }

    public bool  hasEndDateAndOrTimeSpecInput()
      {
        return flagHasEndDateAndOrTimeSpecInput;
      }

    public DateAndOrTimeSpecJSON   getEndDateAndOrTimeSpecInput()
      {
        Debug.Assert(flagHasEndDateAndOrTimeSpecInput);
        return storeEndDateAndOrTimeSpecInput;
      }

    public bool  hasSearchLocation()
      {
        return flagHasSearchLocation;
      }

    public MapLocationJSON   getSearchLocation()
      {
        Debug.Assert(flagHasSearchLocation);
        return storeSearchLocation;
      }

    public bool  hasHA()
      {
        return flagHasHA;
      }

    public TypeHA  getHA()
      {
        Debug.Assert(flagHasHA);
        return storeHA;
      }

    public string  getHAAsString()
      {
        return stringFromHA(getHA());
      }

    public bool  hasIsPlayoffsSpecialGame()
      {
        return flagHasIsPlayoffsSpecialGame;
      }

    public bool  getIsPlayoffsSpecialGame()
      {
        Debug.Assert(flagHasIsPlayoffsSpecialGame);
        return storeIsPlayoffsSpecialGame;
      }

    public bool  hasPlayoffSpecialGame()
      {
        return flagHasPlayoffSpecialGame;
      }

    public int  countOfPlayoffSpecialGame()
      {
        Debug.Assert(flagHasPlayoffSpecialGame);
        return storePlayoffSpecialGame.Count;
      }

    public SportsPlayoffSpecialGameContainerJSON   elementOfPlayoffSpecialGame(int element_num)
      {
        Debug.Assert(flagHasPlayoffSpecialGame);
        return storePlayoffSpecialGame[element_num];
      }

    public List< SportsPlayoffSpecialGameContainerJSON  >  getPlayoffSpecialGame()
      {
        Debug.Assert(flagHasPlayoffSpecialGame);
        return storePlayoffSpecialGame;
      }

    public bool  hasPlayoffGameNumber()
      {
        return flagHasPlayoffGameNumber;
      }

    public BigInteger  getPlayoffGameNumber()
      {
        Debug.Assert(flagHasPlayoffGameNumber);
        return storePlayoffGameNumber;
      }

    public bool  hasTournament()
      {
        return flagHasTournament;
      }

    public int  countOfTournament()
      {
        Debug.Assert(flagHasTournament);
        return storeTournament.Count;
      }

    public SportsTournamentJSON   elementOfTournament(int element_num)
      {
        Debug.Assert(flagHasTournament);
        return storeTournament[element_num];
      }

    public List< SportsTournamentJSON  >  getTournament()
      {
        Debug.Assert(flagHasTournament);
        return storeTournament;
      }

    public bool  hasWinOrLose()
      {
        return flagHasWinOrLose;
      }

    public TypeWinOrLose  getWinOrLose()
      {
        Debug.Assert(flagHasWinOrLose);
        return storeWinOrLose;
      }

    public string  getWinOrLoseAsString()
      {
        return stringFromWinOrLose(getWinOrLose());
      }

    public bool  hasMentionedGame()
      {
        return flagHasMentionedGame;
      }

    public bool  getMentionedGame()
      {
        Debug.Assert(flagHasMentionedGame);
        return storeMentionedGame;
      }


    public virtual int extraSportsInputDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsInputDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsInputDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsInputDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setQueryType(TypeQueryType new_value)
      {
        flagHasQueryType = true;
        storeQueryType = new_value;
      }
    public void setQueryType(string chars)
      {
        TypeQueryTypeKnownValues known = stringToQueryType(chars);
        TypeQueryType new_value = new TypeQueryType();
        if (known == TypeQueryTypeKnownValues.QueryType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setQueryType(new_value);
      }
    public void setQueryType(TypeQueryTypeKnownValues new_value)
      {
        TypeQueryType new_full_value = new TypeQueryType();
        Debug.Assert(new_value != TypeQueryTypeKnownValues.QueryType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setQueryType(new_full_value);
      }
    public void unsetQueryType()
      {
        flagHasQueryType = false;
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
    public void appendTeams(SportsTeamJSON  to_append)
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
    public void setStartDateAndOrTimeSpecInput(DateAndOrTimeSpecJSON  new_value)
      {
        if (flagHasStartDateAndOrTimeSpecInput)
          {
          }
        flagHasStartDateAndOrTimeSpecInput = true;
        storeStartDateAndOrTimeSpecInput = new_value;
      }
    public void unsetStartDateAndOrTimeSpecInput()
      {
        if (flagHasStartDateAndOrTimeSpecInput)
          {
          }
        flagHasStartDateAndOrTimeSpecInput = false;
      }
    public void setEndDateAndOrTimeSpecInput(DateAndOrTimeSpecJSON  new_value)
      {
        if (flagHasEndDateAndOrTimeSpecInput)
          {
          }
        flagHasEndDateAndOrTimeSpecInput = true;
        storeEndDateAndOrTimeSpecInput = new_value;
      }
    public void unsetEndDateAndOrTimeSpecInput()
      {
        if (flagHasEndDateAndOrTimeSpecInput)
          {
          }
        flagHasEndDateAndOrTimeSpecInput = false;
      }
    public void setSearchLocation(MapLocationJSON  new_value)
      {
        if (flagHasSearchLocation)
          {
          }
        flagHasSearchLocation = true;
        storeSearchLocation = new_value;
      }
    public void unsetSearchLocation()
      {
        if (flagHasSearchLocation)
          {
          }
        flagHasSearchLocation = false;
      }
    public void setHA(TypeHA new_value)
      {
        flagHasHA = true;
        storeHA = new_value;
      }
    public void setHA(string chars)
      {
        setHA(stringToHA(chars));
      }
    public void unsetHA()
      {
        flagHasHA = false;
      }
    public void setIsPlayoffsSpecialGame(bool new_value)
      {
        flagHasIsPlayoffsSpecialGame = true;
        storeIsPlayoffsSpecialGame = new_value;
      }
    public void unsetIsPlayoffsSpecialGame()
      {
        flagHasIsPlayoffsSpecialGame = false;
      }
    public void initPlayoffSpecialGame()
      {
        if (flagHasPlayoffSpecialGame)
          {
            for (int num3 = 0; num3 < storePlayoffSpecialGame.Count; ++num3)
              {
              }
          }
        flagHasPlayoffSpecialGame = true;
        storePlayoffSpecialGame.Clear();
      }
    public void appendPlayoffSpecialGame(SportsPlayoffSpecialGameContainerJSON  to_append)
      {
        if (!flagHasPlayoffSpecialGame)
          {
            flagHasPlayoffSpecialGame = true;
            storePlayoffSpecialGame.Clear();
          }
        Debug.Assert(flagHasPlayoffSpecialGame);
        storePlayoffSpecialGame.Add(to_append);
      }
    public void unsetPlayoffSpecialGame()
      {
        if (flagHasPlayoffSpecialGame)
          {
            for (int num4 = 0; num4 < storePlayoffSpecialGame.Count; ++num4)
              {
              }
          }
        flagHasPlayoffSpecialGame = false;
        storePlayoffSpecialGame.Clear();
      }
    public void setPlayoffGameNumber(BigInteger new_value)
      {
        flagHasPlayoffGameNumber = true;
        if (new_value < 1)
            throw new Exception("The value for field PlayoffGameNumber of SportsInputDataJSON is less than the lower bound (1) for that field.");
        storePlayoffGameNumber = new_value;
      }
    public void unsetPlayoffGameNumber()
      {
        flagHasPlayoffGameNumber = false;
      }
    public void initTournament()
      {
        if (flagHasTournament)
          {
            for (int num5 = 0; num5 < storeTournament.Count; ++num5)
              {
              }
          }
        flagHasTournament = true;
        storeTournament.Clear();
      }
    public void appendTournament(SportsTournamentJSON  to_append)
      {
        if (!flagHasTournament)
          {
            flagHasTournament = true;
            storeTournament.Clear();
          }
        Debug.Assert(flagHasTournament);
        storeTournament.Add(to_append);
      }
    public void unsetTournament()
      {
        if (flagHasTournament)
          {
            for (int num6 = 0; num6 < storeTournament.Count; ++num6)
              {
              }
          }
        flagHasTournament = false;
        storeTournament.Clear();
      }
    public void setWinOrLose(TypeWinOrLose new_value)
      {
        flagHasWinOrLose = true;
        storeWinOrLose = new_value;
      }
    public void setWinOrLose(string chars)
      {
        setWinOrLose(stringToWinOrLose(chars));
      }
    public void unsetWinOrLose()
      {
        flagHasWinOrLose = false;
      }
    public void setMentionedGame(bool new_value)
      {
        flagHasMentionedGame = true;
        storeMentionedGame = new_value;
      }
    public void unsetMentionedGame()
      {
        flagHasMentionedGame = false;
      }

    public virtual void extraSportsInputDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsInputDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsInputDataLookup(key);
        if (old_field == null)
          {
            extraSportsInputDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQueryType);
        if (flagHasQueryType)
          {
            handler.start_pair("QueryType");
            if (storeQueryType.in_known_list)
              {
                switch (storeQueryType.list_value)
                  {
                    case TypeQueryTypeKnownValues.QueryType_Score:
                        handler.string_value("Score");
                        break;
                    case TypeQueryTypeKnownValues.QueryType_Schedule:
                        handler.string_value("Schedule");
                        break;
                    case TypeQueryTypeKnownValues.QueryType_Location:
                        handler.string_value("Location");
                        break;
                    case TypeQueryTypeKnownValues.QueryType_ScoreOrSchedule:
                        handler.string_value("ScoreOrSchedule");
                        break;
                    case TypeQueryTypeKnownValues.QueryType_BroadcastNetwork:
                        handler.string_value("BroadcastNetwork");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeQueryType.string_value);
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
        if (flagHasStartDateAndOrTimeSpecInput)
          {
            handler.start_pair("StartDateAndOrTimeSpecInput");
            if (partial_allowed)
                storeStartDateAndOrTimeSpecInput.write_partial_as_json(handler);
            else
                storeStartDateAndOrTimeSpecInput.write_as_json(handler);
          }
        if (flagHasEndDateAndOrTimeSpecInput)
          {
            handler.start_pair("EndDateAndOrTimeSpecInput");
            if (partial_allowed)
                storeEndDateAndOrTimeSpecInput.write_partial_as_json(handler);
            else
                storeEndDateAndOrTimeSpecInput.write_as_json(handler);
          }
        if (flagHasSearchLocation)
          {
            handler.start_pair("SearchLocation");
            if (partial_allowed)
                storeSearchLocation.write_partial_as_json(handler);
            else
                storeSearchLocation.write_as_json(handler);
          }
        if (flagHasHA)
          {
            handler.start_pair("HA");
            switch (storeHA)
              {
                case TypeHA.HA_Unknown:
                    handler.string_value("Unknown");
                    break;
                case TypeHA.HA_Home:
                    handler.string_value("Home");
                    break;
                case TypeHA.HA_Away:
                    handler.string_value("Away");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasIsPlayoffsSpecialGame)
          {
            handler.start_pair("IsPlayoffsSpecialGame");
            handler.boolean_value(storeIsPlayoffsSpecialGame);
          }
        if (flagHasPlayoffSpecialGame)
          {
            handler.start_pair("PlayoffSpecialGame");
            Debug.Assert(storePlayoffSpecialGame.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storePlayoffSpecialGame.Count; ++num2)
              {
                if (partial_allowed)
                    storePlayoffSpecialGame[num2].write_partial_as_json(handler);
                else
                    storePlayoffSpecialGame[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasPlayoffGameNumber)
          {
            handler.start_pair("PlayoffGameNumber");
            handler.number_value(storePlayoffGameNumber);
          }
        if (flagHasTournament)
          {
            handler.start_pair("Tournament");
            Debug.Assert(storeTournament.Count >= 1);
            handler.start_array();
            for (int num3 = 0; num3 < storeTournament.Count; ++num3)
              {
                if (partial_allowed)
                    storeTournament[num3].write_partial_as_json(handler);
                else
                    storeTournament[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasWinOrLose)
          {
            handler.start_pair("WinOrLose");
            switch (storeWinOrLose)
              {
                case TypeWinOrLose.WinOrLose_Win:
                    handler.string_value("Win");
                    break;
                case TypeWinOrLose.WinOrLose_Lose:
                    handler.string_value("Lose");
                    break;
                case TypeWinOrLose.WinOrLose_Tie:
                    handler.string_value("Tie");
                    break;
                case TypeWinOrLose.WinOrLose_Unknown:
                    handler.string_value("Unknown");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasMentionedGame)
          {
            handler.start_pair("MentionedGame");
            handler.boolean_value(storeMentionedGame);
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
        if (!(hasQueryType()))
          {
            return "When parsing the object for %what%, the \"QueryType\" field was missing.";
          }
        return null;
      }

    public static SportsInputDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsInputDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsInputData", ignore_extras);
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
    public static SportsInputDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsInputDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsInputDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsInputData", ignore_extras);
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
    public static SportsInputDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsInputDataJSON from_text(string text, bool ignore_extras)
      {
        SportsInputDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsInputData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsInputDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsInputDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsInputDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsInputData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorQueryType : JSONStringGenerator
          {
            protected FieldGeneratorQueryType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorQueryType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeQueryTypeKnownValues known = stringToQueryType(result);
                TypeQueryType new_value = new TypeQueryType();
                if (known == TypeQueryTypeKnownValues.QueryType__none)
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
            protected abstract void handle_result(TypeQueryType result);
          };
    private class FieldHoldingGeneratorQueryType : FieldGeneratorQueryType
  {
    protected override void handle_result(TypeQueryType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorQueryType(String what)
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
    public TypeQueryType value;
  };
    private class FieldHoldingArrayGeneratorQueryType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorQueryType
      {
        private FieldHoldingArrayGeneratorQueryType top;

        protected override void handle_result(TypeQueryType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorQueryType init_top)
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
    protected virtual void handle_result(List<TypeQueryType> result)
      {
      }

    public FieldHoldingArrayGeneratorQueryType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorQueryType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeQueryType> value;
  };
        private FieldHoldingGeneratorQueryType fieldGeneratorQueryType;
        private SportsTeamJSON.HoldingArrayGenerator fieldGeneratorTeams;
        private DateAndOrTimeSpecJSON.HoldingGenerator fieldGeneratorStartDateAndOrTimeSpecInput;
        private DateAndOrTimeSpecJSON.HoldingGenerator fieldGeneratorEndDateAndOrTimeSpecInput;
        private MapLocationJSON.HoldingGenerator fieldGeneratorSearchLocation;
    private abstract class FieldGeneratorHA : JSONStringGenerator
          {
            protected FieldGeneratorHA(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorHA()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToHA(result));
              }
            protected abstract void handle_result(TypeHA result);
          };
    private class FieldHoldingGeneratorHA : FieldGeneratorHA
  {
    protected override void handle_result(TypeHA result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorHA(String what)
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
    public TypeHA value;
  };
    private class FieldHoldingArrayGeneratorHA : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorHA
      {
        private FieldHoldingArrayGeneratorHA top;

        protected override void handle_result(TypeHA result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorHA init_top)
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
    protected virtual void handle_result(List<TypeHA> result)
      {
      }

    public FieldHoldingArrayGeneratorHA(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeHA>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorHA()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeHA>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeHA> value;
  };
        private FieldHoldingGeneratorHA fieldGeneratorHA;
        private JSONHoldingBooleanGenerator fieldGeneratorIsPlayoffsSpecialGame;
        private SportsPlayoffSpecialGameContainerJSON.HoldingArrayGenerator fieldGeneratorPlayoffSpecialGame;
    private class FieldHoldingGeneratorPlayoffGameNumber : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorPlayoffGameNumber(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorPlayoffGameNumber : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorPlayoffGameNumber(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorPlayoffGameNumber fieldGeneratorPlayoffGameNumber;
        private SportsTournamentJSON.HoldingArrayGenerator fieldGeneratorTournament;
    private abstract class FieldGeneratorWinOrLose : JSONStringGenerator
          {
            protected FieldGeneratorWinOrLose(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorWinOrLose()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToWinOrLose(result));
              }
            protected abstract void handle_result(TypeWinOrLose result);
          };
    private class FieldHoldingGeneratorWinOrLose : FieldGeneratorWinOrLose
  {
    protected override void handle_result(TypeWinOrLose result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorWinOrLose(String what)
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
    public TypeWinOrLose value;
  };
    private class FieldHoldingArrayGeneratorWinOrLose : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorWinOrLose
      {
        private FieldHoldingArrayGeneratorWinOrLose top;

        protected override void handle_result(TypeWinOrLose result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorWinOrLose init_top)
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
    protected virtual void handle_result(List<TypeWinOrLose> result)
      {
      }

    public FieldHoldingArrayGeneratorWinOrLose(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeWinOrLose>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorWinOrLose()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeWinOrLose>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeWinOrLose> value;
  };
        private FieldHoldingGeneratorWinOrLose fieldGeneratorWinOrLose;
        private JSONHoldingBooleanGenerator fieldGeneratorMentionedGame;
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
            SportsInputDataJSON result = new SportsInputDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsInputDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsInputDataJSON result)
          {
            if (fieldGeneratorQueryType.have_value)
              {
                result.setQueryType(fieldGeneratorQueryType.value);
                fieldGeneratorQueryType.have_value = false;
              }
            else if ((!(result.hasQueryType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryType\" field was missing.");
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
            if (fieldGeneratorStartDateAndOrTimeSpecInput.have_value)
              {
                result.setStartDateAndOrTimeSpecInput(fieldGeneratorStartDateAndOrTimeSpecInput.value);
                fieldGeneratorStartDateAndOrTimeSpecInput.have_value = false;
              }
            if (fieldGeneratorEndDateAndOrTimeSpecInput.have_value)
              {
                result.setEndDateAndOrTimeSpecInput(fieldGeneratorEndDateAndOrTimeSpecInput.value);
                fieldGeneratorEndDateAndOrTimeSpecInput.have_value = false;
              }
            if (fieldGeneratorSearchLocation.have_value)
              {
                result.setSearchLocation(fieldGeneratorSearchLocation.value);
                fieldGeneratorSearchLocation.have_value = false;
              }
            if (fieldGeneratorHA.have_value)
              {
                result.setHA(fieldGeneratorHA.value);
                fieldGeneratorHA.have_value = false;
              }
            if (fieldGeneratorIsPlayoffsSpecialGame.have_value)
              {
                result.setIsPlayoffsSpecialGame(fieldGeneratorIsPlayoffsSpecialGame.value);
                fieldGeneratorIsPlayoffsSpecialGame.have_value = false;
              }
            if (fieldGeneratorPlayoffSpecialGame.have_value)
              {
                result.initPlayoffSpecialGame();
                int count = fieldGeneratorPlayoffSpecialGame.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPlayoffSpecialGame(fieldGeneratorPlayoffSpecialGame.value[num]);
                  }
                fieldGeneratorPlayoffSpecialGame.value.Clear();
                fieldGeneratorPlayoffSpecialGame.have_value = false;
              }
            if (fieldGeneratorPlayoffGameNumber.have_value)
              {
                result.setPlayoffGameNumber(fieldGeneratorPlayoffGameNumber.value);
                fieldGeneratorPlayoffGameNumber.have_value = false;
              }
            if (fieldGeneratorTournament.have_value)
              {
                result.initTournament();
                int count = fieldGeneratorTournament.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTournament(fieldGeneratorTournament.value[num]);
                  }
                fieldGeneratorTournament.value.Clear();
                fieldGeneratorTournament.have_value = false;
              }
            if (fieldGeneratorWinOrLose.have_value)
              {
                result.setWinOrLose(fieldGeneratorWinOrLose.value);
                fieldGeneratorWinOrLose.have_value = false;
              }
            if (fieldGeneratorMentionedGame.have_value)
              {
                result.setMentionedGame(fieldGeneratorMentionedGame.value);
                fieldGeneratorMentionedGame.have_value = false;
              }
          }
        protected abstract void handle_result(SportsInputDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "ndDateAndOrTimeSpecInput", 0, 24, false) == 0) && (field_name.Length == 25))
                        return fieldGeneratorEndDateAndOrTimeSpecInput;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "A", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorHA;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sPlayoffsSpecialGame", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorIsPlayoffsSpecialGame;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "entionedGame", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorMentionedGame;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "layoff", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'G':
                                if ((String.Compare(field_name, 8, "ameNumber", 0, 9, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorPlayoffGameNumber;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 8, "pecialGame", 0, 10, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorPlayoffSpecialGame;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryType", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorQueryType;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "archLocation", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorSearchLocation;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "artDateAndOrTimeSpecInput", 0, 25, false) == 0) && (field_name.Length == 27))
                                return fieldGeneratorStartDateAndOrTimeSpecInput;
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
                        case 'o':
                            if ((String.Compare(field_name, 2, "urnament", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorTournament;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "inOrLose", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorWinOrLose;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the SportsInputData class");
            fieldGeneratorTeams = new SportsTeamJSON.HoldingArrayGenerator("field \"Teams\" of the SportsInputData class", ignore_extras);
            fieldGeneratorStartDateAndOrTimeSpecInput = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"StartDateAndOrTimeSpecInput\" of the SportsInputData class", ignore_extras);
            fieldGeneratorEndDateAndOrTimeSpecInput = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"EndDateAndOrTimeSpecInput\" of the SportsInputData class", ignore_extras);
            fieldGeneratorSearchLocation = new MapLocationJSON.HoldingGenerator("field \"SearchLocation\" of the SportsInputData class", ignore_extras);
            fieldGeneratorHA = new FieldHoldingGeneratorHA("field \"HA\" of the SportsInputData class");
            fieldGeneratorIsPlayoffsSpecialGame = new JSONHoldingBooleanGenerator("field \"IsPlayoffsSpecialGame\" of the SportsInputData class");
            fieldGeneratorPlayoffSpecialGame = new SportsPlayoffSpecialGameContainerJSON.HoldingArrayGenerator("field \"PlayoffSpecialGame\" of the SportsInputData class", ignore_extras);
            fieldGeneratorPlayoffGameNumber = new FieldHoldingGeneratorPlayoffGameNumber("field \"PlayoffGameNumber\" of the SportsInputData class");
            fieldGeneratorTournament = new SportsTournamentJSON.HoldingArrayGenerator("field \"Tournament\" of the SportsInputData class", ignore_extras);
            fieldGeneratorWinOrLose = new FieldHoldingGeneratorWinOrLose("field \"WinOrLose\" of the SportsInputData class");
            fieldGeneratorMentionedGame = new JSONHoldingBooleanGenerator("field \"MentionedGame\" of the SportsInputData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsInputData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the SportsInputData class");
            fieldGeneratorTeams = new SportsTeamJSON.HoldingArrayGenerator("field \"Teams\" of the SportsInputData class", false);
            fieldGeneratorStartDateAndOrTimeSpecInput = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"StartDateAndOrTimeSpecInput\" of the SportsInputData class", false);
            fieldGeneratorEndDateAndOrTimeSpecInput = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"EndDateAndOrTimeSpecInput\" of the SportsInputData class", false);
            fieldGeneratorSearchLocation = new MapLocationJSON.HoldingGenerator("field \"SearchLocation\" of the SportsInputData class", false);
            fieldGeneratorHA = new FieldHoldingGeneratorHA("field \"HA\" of the SportsInputData class");
            fieldGeneratorIsPlayoffsSpecialGame = new JSONHoldingBooleanGenerator("field \"IsPlayoffsSpecialGame\" of the SportsInputData class");
            fieldGeneratorPlayoffSpecialGame = new SportsPlayoffSpecialGameContainerJSON.HoldingArrayGenerator("field \"PlayoffSpecialGame\" of the SportsInputData class", false);
            fieldGeneratorPlayoffGameNumber = new FieldHoldingGeneratorPlayoffGameNumber("field \"PlayoffGameNumber\" of the SportsInputData class");
            fieldGeneratorTournament = new SportsTournamentJSON.HoldingArrayGenerator("field \"Tournament\" of the SportsInputData class", false);
            fieldGeneratorWinOrLose = new FieldHoldingGeneratorWinOrLose("field \"WinOrLose\" of the SportsInputData class");
            fieldGeneratorMentionedGame = new JSONHoldingBooleanGenerator("field \"MentionedGame\" of the SportsInputData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsInputData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQueryType.reset();
            fieldGeneratorTeams.reset();
            fieldGeneratorStartDateAndOrTimeSpecInput.reset();
            fieldGeneratorEndDateAndOrTimeSpecInput.reset();
            fieldGeneratorSearchLocation.reset();
            fieldGeneratorHA.reset();
            fieldGeneratorIsPlayoffsSpecialGame.reset();
            fieldGeneratorPlayoffSpecialGame.reset();
            fieldGeneratorPlayoffGameNumber.reset();
            fieldGeneratorTournament.reset();
            fieldGeneratorWinOrLose.reset();
            fieldGeneratorMentionedGame.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTeams.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStartDateAndOrTimeSpecInput.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEndDateAndOrTimeSpecInput.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSearchLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPlayoffSpecialGame.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTournament.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTeams.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStartDateAndOrTimeSpecInput.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEndDateAndOrTimeSpecInput.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSearchLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPlayoffSpecialGame.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTournament.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsInputDataJSON  result)
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
        public SportsInputDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsInputDataJSON  result)
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
    protected virtual void handle_result(List<SportsInputDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsInputDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsInputDataJSON>();
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
    public List<SportsInputDataJSON> value;
  };
  };
