/* file "SportsPlayoffTriviaInputDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsPlayoffTriviaInputDataJSON : JSONBase
  {
    public enum TypeTypeKnownValues
      {
        Type_CountOfOutcomesBySpecificTeam,
        Type_TeamWithHighestOutcomeCount,
        Type_YearOfOutcomeBySpecificTeam,
        Type_SeriesInformation,
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
            case 'C':
                if ((String.Compare(chars, 1, "ountOfOutcomesBySpecificTeam", 0, 28, false) == 0) && (chars.Length == 29))
                    return TypeTypeKnownValues.Type_CountOfOutcomesBySpecificTeam;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "eriesInformation", 0, 16, false) == 0) && (chars.Length == 17))
                    return TypeTypeKnownValues.Type_SeriesInformation;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "eamWithHighestOutcomeCount", 0, 26, false) == 0) && (chars.Length == 27))
                    return TypeTypeKnownValues.Type_TeamWithHighestOutcomeCount;
                break;
            case 'Y':
                if ((String.Compare(chars, 1, "earOfOutcomeBySpecificTeam", 0, 26, false) == 0) && (chars.Length == 27))
                    return TypeTypeKnownValues.Type_YearOfOutcomeBySpecificTeam;
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
            case TypeTypeKnownValues.Type_CountOfOutcomesBySpecificTeam:
                return "CountOfOutcomesBySpecificTeam";
            case TypeTypeKnownValues.Type_TeamWithHighestOutcomeCount:
                return "TeamWithHighestOutcomeCount";
            case TypeTypeKnownValues.Type_YearOfOutcomeBySpecificTeam:
                return "YearOfOutcomeBySpecificTeam";
            case TypeTypeKnownValues.Type_SeriesInformation:
                return "SeriesInformation";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeErrorKnownValues
      {
        Error_PlayoffTypeUnknown,
        Error_DataIncomplete,
        Error_IncompatibleData,
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
            case 'D':
                if ((String.Compare(chars, 1, "ataIncomplete", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeErrorKnownValues.Error_DataIncomplete;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "ncompatibleData", 0, 15, false) == 0) && (chars.Length == 16))
                    return TypeErrorKnownValues.Error_IncompatibleData;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "layoffTypeUnknown", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeErrorKnownValues.Error_PlayoffTypeUnknown;
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
            case TypeErrorKnownValues.Error_PlayoffTypeUnknown:
                return "PlayoffTypeUnknown";
            case TypeErrorKnownValues.Error_DataIncomplete:
                return "DataIncomplete";
            case TypeErrorKnownValues.Error_IncompatibleData:
                return "IncompatibleData";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasType;
    private TypeType storeType;
    private bool flagHasOutcome;
    private SportsPlayoffTriviaOutcomeJSON  storeOutcome;
    private bool flagHasLeague;
    private SportsLeagueCodeJSON  storeLeague;
    private bool flagHasIsPlayoffsGeneral;
    private bool storeIsPlayoffsGeneral;
    private bool flagHasIsLeagueTitle;
    private bool storeIsLeagueTitle;
    private bool flagHasSpecialGameType;
    private SportsPlayoffSpecialGameJSON  storeSpecialGameType;
    private bool flagHasTournament;
    private SportsTournamentJSON  storeTournament;
    private bool flagHasChronologicalOrdinal;
    private BigInteger storeChronologicalOrdinal;
    private bool flagHasRank;
    private BigInteger storeRank;
    private bool flagHasIsSingleGame;
    private bool storeIsSingleGame;
    private bool flagHasSortOrderReversed;
    private bool storeSortOrderReversed;
    private bool flagHasTeams;
    private List< SportsTeamNewJSON  > storeTeams;
    private bool flagHasSeason;
    private List< SportsSeasonResolvedJSON  > storeSeason;
    private bool flagHasOutcomeCount;
    private BigInteger storeOutcomeCount;
    private bool flagHasRankResult;
    private BigInteger storeRankResult;
    private bool flagHasError;
    private TypeError storeError;
    private bool flagHasRankIndices;
    private List< BigInteger > storeRankIndices;
    private bool flagHasSeriesIndices;
    private List< BigInteger > storeSeriesIndices;
    private bool flagHasGamesIndices;
    private List< BigInteger > storeGamesIndices;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Type of SportsPlayoffTriviaInputDataJSON is not a string.");
        TypeType the_open_enum = new TypeType();
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "ountOfOutcomesBySpecificTeam", 0, 28, false) == 0) && (json_string.getData().Length == 29))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_CountOfOutcomesBySpecificTeam;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "eriesInformation", 0, 16, false) == 0) && (json_string.getData().Length == 17))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_SeriesInformation;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "eamWithHighestOutcomeCount", 0, 26, false) == 0) && (json_string.getData().Length == 27))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_TeamWithHighestOutcomeCount;
                        goto open_enum_is_done;
                      }
                break;
            case 'Y':
                if ((String.Compare(json_string.getData(), 1, "earOfOutcomeBySpecificTeam", 0, 26, false) == 0) && (json_string.getData().Length == 27))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_YearOfOutcomeBySpecificTeam;
                        goto open_enum_is_done;
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


    private void  fromJSONOutcome(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsPlayoffTriviaOutcomeJSON convert_classy = SportsPlayoffTriviaOutcomeJSON.from_json(json_value, ignore_extras, true);
        setOutcome(convert_classy);
      }


    private void  fromJSONLeague(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsLeagueCodeJSON convert_classy = SportsLeagueCodeJSON.from_json(json_value, ignore_extras, true);
        setLeague(convert_classy);
      }


    private void  fromJSONIsPlayoffsGeneral(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsPlayoffsGeneral of SportsPlayoffTriviaInputDataJSON is not true for false.");
              }
          }
        setIsPlayoffsGeneral(the_bool);
      }


    private void  fromJSONIsLeagueTitle(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsLeagueTitle of SportsPlayoffTriviaInputDataJSON is not true for false.");
              }
          }
        setIsLeagueTitle(the_bool);
      }


    private void  fromJSONSpecialGameType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsPlayoffSpecialGameJSON convert_classy = SportsPlayoffSpecialGameJSON.from_json(json_value, ignore_extras, true);
        setSpecialGameType(convert_classy);
      }


    private void  fromJSONTournament(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsTournamentJSON convert_classy = SportsTournamentJSON.from_json(json_value, ignore_extras, true);
        setTournament(convert_classy);
      }


    private void  fromJSONChronologicalOrdinal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ChronologicalOrdinal of SportsPlayoffTriviaInputDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ChronologicalOrdinal of SportsPlayoffTriviaInputDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setChronologicalOrdinal(extracted_integer);
      }


    private void  fromJSONRank(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Rank of SportsPlayoffTriviaInputDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Rank of SportsPlayoffTriviaInputDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRank(extracted_integer);
      }


    private void  fromJSONIsSingleGame(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsSingleGame of SportsPlayoffTriviaInputDataJSON is not true for false.");
              }
          }
        setIsSingleGame(the_bool);
      }


    private void  fromJSONSortOrderReversed(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SortOrderReversed of SportsPlayoffTriviaInputDataJSON is not true for false.");
              }
          }
        setSortOrderReversed(the_bool);
      }


    private void  fromJSONTeams(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Teams of SportsPlayoffTriviaInputDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Teams of SportsPlayoffTriviaInputDataJSON has too few elements.");
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


    private void  fromJSONSeason(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Season of SportsPlayoffTriviaInputDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Season of SportsPlayoffTriviaInputDataJSON has too few elements.");
        List< SportsSeasonResolvedJSON  > vector_Season1 = new List< SportsSeasonResolvedJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsSeasonResolvedJSON convert_classy = SportsSeasonResolvedJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Season1.Add(convert_classy);
          }
        Debug.Assert(vector_Season1.Count >= 1);
        initSeason();
        for (int num2 = 0; num2 < vector_Season1.Count; ++num2)
            appendSeason(vector_Season1[num2]);
        for (int num1 = 0; num1 < vector_Season1.Count; ++num1)
          {
          }
      }


    private void  fromJSONOutcomeCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field OutcomeCount of SportsPlayoffTriviaInputDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field OutcomeCount of SportsPlayoffTriviaInputDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setOutcomeCount(extracted_integer);
      }


    private void  fromJSONRankResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field RankResult of SportsPlayoffTriviaInputDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RankResult of SportsPlayoffTriviaInputDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRankResult(extracted_integer);
      }


    private void  fromJSONError(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Error of SportsPlayoffTriviaInputDataJSON is not a string.");
        TypeError the_open_enum = new TypeError();
        switch (json_string.getData()[0])
          {
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ataIncomplete", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeErrorKnownValues.Error_DataIncomplete;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "ncompatibleData", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeErrorKnownValues.Error_IncompatibleData;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "layoffTypeUnknown", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeErrorKnownValues.Error_PlayoffTypeUnknown;
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


    private void  fromJSONRankIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RankIndices of SportsPlayoffTriviaInputDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field RankIndices of SportsPlayoffTriviaInputDataJSON has too few elements.");
        List< BigInteger > vector_RankIndices1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field RankIndices of SportsPlayoffTriviaInputDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field RankIndices of SportsPlayoffTriviaInputDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_RankIndices1.Add(extracted_integer);
          }
        Debug.Assert(vector_RankIndices1.Count >= 1);
        initRankIndices();
        for (int num3 = 0; num3 < vector_RankIndices1.Count; ++num3)
            appendRankIndices(vector_RankIndices1[num3]);
        for (int num1 = 0; num1 < vector_RankIndices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSeriesIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SeriesIndices of SportsPlayoffTriviaInputDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field SeriesIndices of SportsPlayoffTriviaInputDataJSON has too few elements.");
        List< BigInteger > vector_SeriesIndices1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field SeriesIndices of SportsPlayoffTriviaInputDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field SeriesIndices of SportsPlayoffTriviaInputDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_SeriesIndices1.Add(extracted_integer);
          }
        Debug.Assert(vector_SeriesIndices1.Count >= 1);
        initSeriesIndices();
        for (int num4 = 0; num4 < vector_SeriesIndices1.Count; ++num4)
            appendSeriesIndices(vector_SeriesIndices1[num4]);
        for (int num1 = 0; num1 < vector_SeriesIndices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGamesIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field GamesIndices of SportsPlayoffTriviaInputDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field GamesIndices of SportsPlayoffTriviaInputDataJSON has too few elements.");
        List< BigInteger > vector_GamesIndices1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field GamesIndices of SportsPlayoffTriviaInputDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field GamesIndices of SportsPlayoffTriviaInputDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_GamesIndices1.Add(extracted_integer);
          }
        Debug.Assert(vector_GamesIndices1.Count >= 1);
        initGamesIndices();
        for (int num5 = 0; num5 < vector_GamesIndices1.Count; ++num5)
            appendGamesIndices(vector_GamesIndices1[num5]);
        for (int num1 = 0; num1 < vector_GamesIndices1.Count; ++num1)
          {
          }
      }


    public SportsPlayoffTriviaInputDataJSON()
      {
        flagHasType = false;
        flagHasOutcome = false;
        flagHasLeague = false;
        flagHasIsPlayoffsGeneral = false;
        flagHasIsLeagueTitle = false;
        flagHasSpecialGameType = false;
        flagHasTournament = false;
        flagHasChronologicalOrdinal = false;
        flagHasRank = false;
        flagHasIsSingleGame = false;
        flagHasSortOrderReversed = false;
        flagHasTeams = false;
        flagHasSeason = false;
        flagHasOutcomeCount = false;
        flagHasRankResult = false;
        flagHasError = false;
        flagHasRankIndices = false;
        flagHasSeriesIndices = false;
        flagHasGamesIndices = false;
        storeTeams = new List< SportsTeamNewJSON  >();
        storeSeason = new List< SportsSeasonResolvedJSON  >();
        storeRankIndices = new List< BigInteger >();
        storeSeriesIndices = new List< BigInteger >();
        storeGamesIndices = new List< BigInteger >();
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

    public bool  hasOutcome()
      {
        return flagHasOutcome;
      }

    public SportsPlayoffTriviaOutcomeJSON   getOutcome()
      {
        Debug.Assert(flagHasOutcome);
        return storeOutcome;
      }

    public SportsPlayoffTriviaOutcomeJSON.TypeValue  getOutcomeValue()
      {
        return getOutcome().getValue();
      }

    public string  getOutcomeAsString()
      {
        return getOutcome().getValueAsString();
      }

    public bool  hasLeague()
      {
        return flagHasLeague;
      }

    public SportsLeagueCodeJSON   getLeague()
      {
        Debug.Assert(flagHasLeague);
        return storeLeague;
      }

    public SportsLeagueCodeJSON.TypeValue  getLeagueValue()
      {
        return getLeague().getValue();
      }

    public string  getLeagueAsString()
      {
        return getLeague().getValueAsString();
      }

    public bool  hasIsPlayoffsGeneral()
      {
        return flagHasIsPlayoffsGeneral;
      }

    public bool  getIsPlayoffsGeneral()
      {
        Debug.Assert(flagHasIsPlayoffsGeneral);
        return storeIsPlayoffsGeneral;
      }

    public bool  hasIsLeagueTitle()
      {
        return flagHasIsLeagueTitle;
      }

    public bool  getIsLeagueTitle()
      {
        Debug.Assert(flagHasIsLeagueTitle);
        return storeIsLeagueTitle;
      }

    public bool  hasSpecialGameType()
      {
        return flagHasSpecialGameType;
      }

    public SportsPlayoffSpecialGameJSON   getSpecialGameType()
      {
        Debug.Assert(flagHasSpecialGameType);
        return storeSpecialGameType;
      }

    public SportsPlayoffSpecialGameJSON.TypeValue  getSpecialGameTypeValue()
      {
        return getSpecialGameType().getValue();
      }

    public string  getSpecialGameTypeAsString()
      {
        return getSpecialGameType().getValueAsString();
      }

    public bool  hasTournament()
      {
        return flagHasTournament;
      }

    public SportsTournamentJSON   getTournament()
      {
        Debug.Assert(flagHasTournament);
        return storeTournament;
      }

    public bool  hasChronologicalOrdinal()
      {
        return flagHasChronologicalOrdinal;
      }

    public BigInteger  getChronologicalOrdinal()
      {
        Debug.Assert(flagHasChronologicalOrdinal);
        return storeChronologicalOrdinal;
      }

    public bool  hasRank()
      {
        return flagHasRank;
      }

    public BigInteger  getRank()
      {
        Debug.Assert(flagHasRank);
        return storeRank;
      }

    public bool  hasIsSingleGame()
      {
        return flagHasIsSingleGame;
      }

    public bool  getIsSingleGame()
      {
        Debug.Assert(flagHasIsSingleGame);
        return storeIsSingleGame;
      }

    public bool  hasSortOrderReversed()
      {
        return flagHasSortOrderReversed;
      }

    public bool  getSortOrderReversed()
      {
        Debug.Assert(flagHasSortOrderReversed);
        return storeSortOrderReversed;
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

    public bool  hasSeason()
      {
        return flagHasSeason;
      }

    public int  countOfSeason()
      {
        Debug.Assert(flagHasSeason);
        return storeSeason.Count;
      }

    public SportsSeasonResolvedJSON   elementOfSeason(int element_num)
      {
        Debug.Assert(flagHasSeason);
        return storeSeason[element_num];
      }

    public List< SportsSeasonResolvedJSON  >  getSeason()
      {
        Debug.Assert(flagHasSeason);
        return storeSeason;
      }

    public bool  hasOutcomeCount()
      {
        return flagHasOutcomeCount;
      }

    public BigInteger  getOutcomeCount()
      {
        Debug.Assert(flagHasOutcomeCount);
        return storeOutcomeCount;
      }

    public bool  hasRankResult()
      {
        return flagHasRankResult;
      }

    public BigInteger  getRankResult()
      {
        Debug.Assert(flagHasRankResult);
        return storeRankResult;
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

    public bool  hasRankIndices()
      {
        return flagHasRankIndices;
      }

    public int  countOfRankIndices()
      {
        Debug.Assert(flagHasRankIndices);
        return storeRankIndices.Count;
      }

    public BigInteger  elementOfRankIndices(int element_num)
      {
        Debug.Assert(flagHasRankIndices);
        return storeRankIndices[element_num];
      }

    public List< BigInteger >  getRankIndices()
      {
        Debug.Assert(flagHasRankIndices);
        return storeRankIndices;
      }

    public bool  hasSeriesIndices()
      {
        return flagHasSeriesIndices;
      }

    public int  countOfSeriesIndices()
      {
        Debug.Assert(flagHasSeriesIndices);
        return storeSeriesIndices.Count;
      }

    public BigInteger  elementOfSeriesIndices(int element_num)
      {
        Debug.Assert(flagHasSeriesIndices);
        return storeSeriesIndices[element_num];
      }

    public List< BigInteger >  getSeriesIndices()
      {
        Debug.Assert(flagHasSeriesIndices);
        return storeSeriesIndices;
      }

    public bool  hasGamesIndices()
      {
        return flagHasGamesIndices;
      }

    public int  countOfGamesIndices()
      {
        Debug.Assert(flagHasGamesIndices);
        return storeGamesIndices.Count;
      }

    public BigInteger  elementOfGamesIndices(int element_num)
      {
        Debug.Assert(flagHasGamesIndices);
        return storeGamesIndices[element_num];
      }

    public List< BigInteger >  getGamesIndices()
      {
        Debug.Assert(flagHasGamesIndices);
        return storeGamesIndices;
      }


    public virtual int extraSportsPlayoffTriviaInputDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsPlayoffTriviaInputDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsPlayoffTriviaInputDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsPlayoffTriviaInputDataLookup(string field_name)
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
    public void setOutcome(SportsPlayoffTriviaOutcomeJSON  new_value)
      {
        if (flagHasOutcome)
          {
          }
        flagHasOutcome = true;
        storeOutcome = new_value;
      }
    public void setOutcome(SportsPlayoffTriviaOutcomeJSON.TypeValue new_value)
      {
        setOutcome(new SportsPlayoffTriviaOutcomeJSON(new_value));
      }
    public void setOutcome(string chars)
      {
        SportsPlayoffTriviaOutcomeJSON.TypeValueKnownValues known = SportsPlayoffTriviaOutcomeJSON.stringToValue(chars);
        SportsPlayoffTriviaOutcomeJSON.TypeValue new_value = new SportsPlayoffTriviaOutcomeJSON.TypeValue();
        if (known == SportsPlayoffTriviaOutcomeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setOutcome(new_value);
      }
    public void unsetOutcome()
      {
        if (flagHasOutcome)
          {
          }
        flagHasOutcome = false;
      }
    public void setLeague(SportsLeagueCodeJSON  new_value)
      {
        if (flagHasLeague)
          {
          }
        flagHasLeague = true;
        storeLeague = new_value;
      }
    public void setLeague(SportsLeagueCodeJSON.TypeValue new_value)
      {
        setLeague(new SportsLeagueCodeJSON(new_value));
      }
    public void setLeague(string chars)
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
        setLeague(new_value);
      }
    public void unsetLeague()
      {
        if (flagHasLeague)
          {
          }
        flagHasLeague = false;
      }
    public void setIsPlayoffsGeneral(bool new_value)
      {
        flagHasIsPlayoffsGeneral = true;
        storeIsPlayoffsGeneral = new_value;
      }
    public void unsetIsPlayoffsGeneral()
      {
        flagHasIsPlayoffsGeneral = false;
      }
    public void setIsLeagueTitle(bool new_value)
      {
        flagHasIsLeagueTitle = true;
        storeIsLeagueTitle = new_value;
      }
    public void unsetIsLeagueTitle()
      {
        flagHasIsLeagueTitle = false;
      }
    public void setSpecialGameType(SportsPlayoffSpecialGameJSON  new_value)
      {
        if (flagHasSpecialGameType)
          {
          }
        flagHasSpecialGameType = true;
        storeSpecialGameType = new_value;
      }
    public void setSpecialGameType(SportsPlayoffSpecialGameJSON.TypeValue new_value)
      {
        setSpecialGameType(new SportsPlayoffSpecialGameJSON(new_value));
      }
    public void setSpecialGameType(string chars)
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
        setSpecialGameType(new_value);
      }
    public void unsetSpecialGameType()
      {
        if (flagHasSpecialGameType)
          {
          }
        flagHasSpecialGameType = false;
      }
    public void setTournament(SportsTournamentJSON  new_value)
      {
        if (flagHasTournament)
          {
          }
        flagHasTournament = true;
        storeTournament = new_value;
      }
    public void unsetTournament()
      {
        if (flagHasTournament)
          {
          }
        flagHasTournament = false;
      }
    public void setChronologicalOrdinal(BigInteger new_value)
      {
        flagHasChronologicalOrdinal = true;
        storeChronologicalOrdinal = new_value;
      }
    public void unsetChronologicalOrdinal()
      {
        flagHasChronologicalOrdinal = false;
      }
    public void setRank(BigInteger new_value)
      {
        flagHasRank = true;
        if (new_value < 1)
            throw new Exception("The value for field Rank of SportsPlayoffTriviaInputDataJSON is less than the lower bound (1) for that field.");
        storeRank = new_value;
      }
    public void unsetRank()
      {
        flagHasRank = false;
      }
    public void setIsSingleGame(bool new_value)
      {
        flagHasIsSingleGame = true;
        storeIsSingleGame = new_value;
      }
    public void unsetIsSingleGame()
      {
        flagHasIsSingleGame = false;
      }
    public void setSortOrderReversed(bool new_value)
      {
        flagHasSortOrderReversed = true;
        storeSortOrderReversed = new_value;
      }
    public void unsetSortOrderReversed()
      {
        flagHasSortOrderReversed = false;
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
    public void initSeason()
      {
        if (flagHasSeason)
          {
            for (int num3 = 0; num3 < storeSeason.Count; ++num3)
              {
              }
          }
        flagHasSeason = true;
        storeSeason.Clear();
      }
    public void appendSeason(SportsSeasonResolvedJSON  to_append)
      {
        if (!flagHasSeason)
          {
            flagHasSeason = true;
            storeSeason.Clear();
          }
        Debug.Assert(flagHasSeason);
        storeSeason.Add(to_append);
      }
    public void unsetSeason()
      {
        if (flagHasSeason)
          {
            for (int num4 = 0; num4 < storeSeason.Count; ++num4)
              {
              }
          }
        flagHasSeason = false;
        storeSeason.Clear();
      }
    public void setOutcomeCount(BigInteger new_value)
      {
        flagHasOutcomeCount = true;
        if (new_value < -1)
            throw new Exception("The value for field OutcomeCount of SportsPlayoffTriviaInputDataJSON is less than the lower bound (-1) for that field.");
        storeOutcomeCount = new_value;
      }
    public void unsetOutcomeCount()
      {
        flagHasOutcomeCount = false;
      }
    public void setRankResult(BigInteger new_value)
      {
        flagHasRankResult = true;
        if (new_value < -1)
            throw new Exception("The value for field RankResult of SportsPlayoffTriviaInputDataJSON is less than the lower bound (-1) for that field.");
        storeRankResult = new_value;
      }
    public void unsetRankResult()
      {
        flagHasRankResult = false;
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
    public void initRankIndices()
      {
        flagHasRankIndices = true;
        storeRankIndices.Clear();
      }
    public void appendRankIndices(BigInteger to_append)
      {
        if (!flagHasRankIndices)
          {
            flagHasRankIndices = true;
            storeRankIndices.Clear();
          }
        Debug.Assert(flagHasRankIndices);
        storeRankIndices.Add(to_append);
      }
    public void unsetRankIndices()
      {
        flagHasRankIndices = false;
        storeRankIndices.Clear();
      }
    public void initSeriesIndices()
      {
        flagHasSeriesIndices = true;
        storeSeriesIndices.Clear();
      }
    public void appendSeriesIndices(BigInteger to_append)
      {
        if (!flagHasSeriesIndices)
          {
            flagHasSeriesIndices = true;
            storeSeriesIndices.Clear();
          }
        Debug.Assert(flagHasSeriesIndices);
        storeSeriesIndices.Add(to_append);
      }
    public void unsetSeriesIndices()
      {
        flagHasSeriesIndices = false;
        storeSeriesIndices.Clear();
      }
    public void initGamesIndices()
      {
        flagHasGamesIndices = true;
        storeGamesIndices.Clear();
      }
    public void appendGamesIndices(BigInteger to_append)
      {
        if (!flagHasGamesIndices)
          {
            flagHasGamesIndices = true;
            storeGamesIndices.Clear();
          }
        Debug.Assert(flagHasGamesIndices);
        storeGamesIndices.Add(to_append);
      }
    public void unsetGamesIndices()
      {
        flagHasGamesIndices = false;
        storeGamesIndices.Clear();
      }

    public virtual void extraSportsPlayoffTriviaInputDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsPlayoffTriviaInputDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsPlayoffTriviaInputDataLookup(key);
        if (old_field == null)
          {
            extraSportsPlayoffTriviaInputDataAppendPair(key, new_component);
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
                    case TypeTypeKnownValues.Type_CountOfOutcomesBySpecificTeam:
                        handler.string_value("CountOfOutcomesBySpecificTeam");
                        break;
                    case TypeTypeKnownValues.Type_TeamWithHighestOutcomeCount:
                        handler.string_value("TeamWithHighestOutcomeCount");
                        break;
                    case TypeTypeKnownValues.Type_YearOfOutcomeBySpecificTeam:
                        handler.string_value("YearOfOutcomeBySpecificTeam");
                        break;
                    case TypeTypeKnownValues.Type_SeriesInformation:
                        handler.string_value("SeriesInformation");
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
        if (flagHasOutcome)
          {
            handler.start_pair("Outcome");
            if (partial_allowed)
                storeOutcome.write_partial_as_json(handler);
            else
                storeOutcome.write_as_json(handler);
          }
        if (flagHasLeague)
          {
            handler.start_pair("League");
            if (partial_allowed)
                storeLeague.write_partial_as_json(handler);
            else
                storeLeague.write_as_json(handler);
          }
        if (flagHasIsPlayoffsGeneral)
          {
            handler.start_pair("IsPlayoffsGeneral");
            handler.boolean_value(storeIsPlayoffsGeneral);
          }
        if (flagHasIsLeagueTitle)
          {
            handler.start_pair("IsLeagueTitle");
            handler.boolean_value(storeIsLeagueTitle);
          }
        if (flagHasSpecialGameType)
          {
            handler.start_pair("SpecialGameType");
            if (partial_allowed)
                storeSpecialGameType.write_partial_as_json(handler);
            else
                storeSpecialGameType.write_as_json(handler);
          }
        if (flagHasTournament)
          {
            handler.start_pair("Tournament");
            if (partial_allowed)
                storeTournament.write_partial_as_json(handler);
            else
                storeTournament.write_as_json(handler);
          }
        if (flagHasChronologicalOrdinal)
          {
            handler.start_pair("ChronologicalOrdinal");
            handler.number_value(storeChronologicalOrdinal);
          }
        if (flagHasRank)
          {
            handler.start_pair("Rank");
            handler.number_value(storeRank);
          }
        if (flagHasIsSingleGame)
          {
            handler.start_pair("IsSingleGame");
            handler.boolean_value(storeIsSingleGame);
          }
        if (flagHasSortOrderReversed)
          {
            handler.start_pair("SortOrderReversed");
            handler.boolean_value(storeSortOrderReversed);
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
        if (flagHasSeason)
          {
            handler.start_pair("Season");
            Debug.Assert(storeSeason.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeSeason.Count; ++num2)
              {
                if (partial_allowed)
                    storeSeason[num2].write_partial_as_json(handler);
                else
                    storeSeason[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasOutcomeCount)
          {
            handler.start_pair("OutcomeCount");
            handler.number_value(storeOutcomeCount);
          }
        if (flagHasRankResult)
          {
            handler.start_pair("RankResult");
            handler.number_value(storeRankResult);
          }
        if (flagHasError)
          {
            handler.start_pair("Error");
            if (storeError.in_known_list)
              {
                switch (storeError.list_value)
                  {
                    case TypeErrorKnownValues.Error_PlayoffTypeUnknown:
                        handler.string_value("PlayoffTypeUnknown");
                        break;
                    case TypeErrorKnownValues.Error_DataIncomplete:
                        handler.string_value("DataIncomplete");
                        break;
                    case TypeErrorKnownValues.Error_IncompatibleData:
                        handler.string_value("IncompatibleData");
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
        if (flagHasRankIndices)
          {
            handler.start_pair("RankIndices");
            Debug.Assert(storeRankIndices.Count >= 1);
            handler.start_array();
            for (int num3 = 0; num3 < storeRankIndices.Count; ++num3)
              {
                handler.number_value(storeRankIndices[num3]);
              }
            handler.finish_array();
          }
        if (flagHasSeriesIndices)
          {
            handler.start_pair("SeriesIndices");
            Debug.Assert(storeSeriesIndices.Count >= 1);
            handler.start_array();
            for (int num4 = 0; num4 < storeSeriesIndices.Count; ++num4)
              {
                handler.number_value(storeSeriesIndices[num4]);
              }
            handler.finish_array();
          }
        if (flagHasGamesIndices)
          {
            handler.start_pair("GamesIndices");
            Debug.Assert(storeGamesIndices.Count >= 1);
            handler.start_array();
            for (int num5 = 0; num5 < storeGamesIndices.Count; ++num5)
              {
                handler.number_value(storeGamesIndices[num5]);
              }
            handler.finish_array();
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

    public static SportsPlayoffTriviaInputDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayoffTriviaInputDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaInputData", ignore_extras);
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
    public static SportsPlayoffTriviaInputDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayoffTriviaInputDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayoffTriviaInputDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaInputData", ignore_extras);
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
    public static SportsPlayoffTriviaInputDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayoffTriviaInputDataJSON from_text(string text, bool ignore_extras)
      {
        SportsPlayoffTriviaInputDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaInputData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsPlayoffTriviaInputDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsPlayoffTriviaInputDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsPlayoffTriviaInputDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaInputData", ignore_extras);
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
        private SportsPlayoffTriviaOutcomeJSON.HoldingGenerator fieldGeneratorOutcome;
        private SportsLeagueCodeJSON.HoldingGenerator fieldGeneratorLeague;
        private JSONHoldingBooleanGenerator fieldGeneratorIsPlayoffsGeneral;
        private JSONHoldingBooleanGenerator fieldGeneratorIsLeagueTitle;
        private SportsPlayoffSpecialGameJSON.HoldingGenerator fieldGeneratorSpecialGameType;
        private SportsTournamentJSON.HoldingGenerator fieldGeneratorTournament;
    private class FieldHoldingGeneratorChronologicalOrdinal : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorChronologicalOrdinal(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorChronologicalOrdinal : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorChronologicalOrdinal(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorChronologicalOrdinal fieldGeneratorChronologicalOrdinal;
    private class FieldHoldingGeneratorRank : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorRank(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorRank : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorRank(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorRank fieldGeneratorRank;
        private JSONHoldingBooleanGenerator fieldGeneratorIsSingleGame;
        private JSONHoldingBooleanGenerator fieldGeneratorSortOrderReversed;
        private SportsTeamNewJSON.HoldingArrayGenerator fieldGeneratorTeams;
        private SportsSeasonResolvedJSON.HoldingArrayGenerator fieldGeneratorSeason;
    private class FieldHoldingGeneratorOutcomeCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorOutcomeCount(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorOutcomeCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorOutcomeCount(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
        private FieldHoldingGeneratorOutcomeCount fieldGeneratorOutcomeCount;
    private class FieldHoldingGeneratorRankResult : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorRankResult(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorRankResult : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorRankResult(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
        private FieldHoldingGeneratorRankResult fieldGeneratorRankResult;
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
    private class FieldHoldingGeneratorRankIndices : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorRankIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorRankIndices : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorRankIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorRankIndices fieldGeneratorRankIndices;
    private class FieldHoldingGeneratorSeriesIndices : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSeriesIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSeriesIndices : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSeriesIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorSeriesIndices fieldGeneratorSeriesIndices;
    private class FieldHoldingGeneratorGamesIndices : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGamesIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGamesIndices : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGamesIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorGamesIndices fieldGeneratorGamesIndices;
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
            SportsPlayoffTriviaInputDataJSON result = new SportsPlayoffTriviaInputDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsPlayoffTriviaInputDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsPlayoffTriviaInputDataJSON result)
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
            if (fieldGeneratorOutcome.have_value)
              {
                result.setOutcome(fieldGeneratorOutcome.value);
                fieldGeneratorOutcome.have_value = false;
              }
            if (fieldGeneratorLeague.have_value)
              {
                result.setLeague(fieldGeneratorLeague.value);
                fieldGeneratorLeague.have_value = false;
              }
            if (fieldGeneratorIsPlayoffsGeneral.have_value)
              {
                result.setIsPlayoffsGeneral(fieldGeneratorIsPlayoffsGeneral.value);
                fieldGeneratorIsPlayoffsGeneral.have_value = false;
              }
            if (fieldGeneratorIsLeagueTitle.have_value)
              {
                result.setIsLeagueTitle(fieldGeneratorIsLeagueTitle.value);
                fieldGeneratorIsLeagueTitle.have_value = false;
              }
            if (fieldGeneratorSpecialGameType.have_value)
              {
                result.setSpecialGameType(fieldGeneratorSpecialGameType.value);
                fieldGeneratorSpecialGameType.have_value = false;
              }
            if (fieldGeneratorTournament.have_value)
              {
                result.setTournament(fieldGeneratorTournament.value);
                fieldGeneratorTournament.have_value = false;
              }
            if (fieldGeneratorChronologicalOrdinal.have_value)
              {
                result.setChronologicalOrdinal(fieldGeneratorChronologicalOrdinal.value);
                fieldGeneratorChronologicalOrdinal.have_value = false;
              }
            if (fieldGeneratorRank.have_value)
              {
                result.setRank(fieldGeneratorRank.value);
                fieldGeneratorRank.have_value = false;
              }
            if (fieldGeneratorIsSingleGame.have_value)
              {
                result.setIsSingleGame(fieldGeneratorIsSingleGame.value);
                fieldGeneratorIsSingleGame.have_value = false;
              }
            if (fieldGeneratorSortOrderReversed.have_value)
              {
                result.setSortOrderReversed(fieldGeneratorSortOrderReversed.value);
                fieldGeneratorSortOrderReversed.have_value = false;
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
            if (fieldGeneratorSeason.have_value)
              {
                result.initSeason();
                int count = fieldGeneratorSeason.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSeason(fieldGeneratorSeason.value[num]);
                  }
                fieldGeneratorSeason.value.Clear();
                fieldGeneratorSeason.have_value = false;
              }
            if (fieldGeneratorOutcomeCount.have_value)
              {
                result.setOutcomeCount(fieldGeneratorOutcomeCount.value);
                fieldGeneratorOutcomeCount.have_value = false;
              }
            if (fieldGeneratorRankResult.have_value)
              {
                result.setRankResult(fieldGeneratorRankResult.value);
                fieldGeneratorRankResult.have_value = false;
              }
            if (fieldGeneratorError.have_value)
              {
                result.setError(fieldGeneratorError.value);
                fieldGeneratorError.have_value = false;
              }
            if (fieldGeneratorRankIndices.have_value)
              {
                result.initRankIndices();
                int count = fieldGeneratorRankIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRankIndices(fieldGeneratorRankIndices.value[num]);
                  }
                fieldGeneratorRankIndices.value.Clear();
                fieldGeneratorRankIndices.have_value = false;
              }
            if (fieldGeneratorSeriesIndices.have_value)
              {
                result.initSeriesIndices();
                int count = fieldGeneratorSeriesIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSeriesIndices(fieldGeneratorSeriesIndices.value[num]);
                  }
                fieldGeneratorSeriesIndices.value.Clear();
                fieldGeneratorSeriesIndices.have_value = false;
              }
            if (fieldGeneratorGamesIndices.have_value)
              {
                result.initGamesIndices();
                int count = fieldGeneratorGamesIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGamesIndices(fieldGeneratorGamesIndices.value[num]);
                  }
                fieldGeneratorGamesIndices.value.Clear();
                fieldGeneratorGamesIndices.have_value = false;
              }
          }
        protected abstract void handle_result(SportsPlayoffTriviaInputDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "hronologicalOrdinal", 0, 19, false) == 0) && (field_name.Length == 20))
                        return fieldGeneratorChronologicalOrdinal;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "rror", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorError;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "amesIndices", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorGamesIndices;
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "s", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 3, "eagueTitle", 0, 10, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorIsLeagueTitle;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 3, "layoffsGeneral", 0, 14, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorIsPlayoffsGeneral;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 3, "ingleGame", 0, 9, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorIsSingleGame;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "eague", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorLeague;
                    break;
                case 'O':
                    if (String.Compare(field_name, 1, "utcome", 0, 6, false) == 0)
                      {
                        if (field_name.Length == 7)
                          {
                            return fieldGeneratorOutcome;
                          }
                        switch (field_name[7])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 8, "ount", 0, 4, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorOutcomeCount;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "ank", 0, 3, false) == 0)
                      {
                        if (field_name.Length == 4)
                          {
                            return fieldGeneratorRank;
                          }
                        switch (field_name[4])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 5, "ndices", 0, 6, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorRankIndices;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 5, "esult", 0, 5, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorRankResult;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            switch (field_name[2])
                              {
                                case 'a':
                                    if ((String.Compare(field_name, 3, "son", 0, 3, false) == 0) && (field_name.Length == 6))
                                        return fieldGeneratorSeason;
                                    break;
                                case 'r':
                                    if ((String.Compare(field_name, 3, "iesIndices", 0, 10, false) == 0) && (field_name.Length == 13))
                                        return fieldGeneratorSeriesIndices;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "rtOrderReversed", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorSortOrderReversed;
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
                        case 'o':
                            if ((String.Compare(field_name, 2, "urnament", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorTournament;
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
            fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorOutcome = new SportsPlayoffTriviaOutcomeJSON.HoldingGenerator("field \"Outcome\" of the SportsPlayoffTriviaInputData class", ignore_extras);
            fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the SportsPlayoffTriviaInputData class", ignore_extras);
            fieldGeneratorIsPlayoffsGeneral = new JSONHoldingBooleanGenerator("field \"IsPlayoffsGeneral\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorIsLeagueTitle = new JSONHoldingBooleanGenerator("field \"IsLeagueTitle\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorSpecialGameType = new SportsPlayoffSpecialGameJSON.HoldingGenerator("field \"SpecialGameType\" of the SportsPlayoffTriviaInputData class", ignore_extras);
            fieldGeneratorTournament = new SportsTournamentJSON.HoldingGenerator("field \"Tournament\" of the SportsPlayoffTriviaInputData class", ignore_extras);
            fieldGeneratorChronologicalOrdinal = new FieldHoldingGeneratorChronologicalOrdinal("field \"ChronologicalOrdinal\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorIsSingleGame = new JSONHoldingBooleanGenerator("field \"IsSingleGame\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorSortOrderReversed = new JSONHoldingBooleanGenerator("field \"SortOrderReversed\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorTeams = new SportsTeamNewJSON.HoldingArrayGenerator("field \"Teams\" of the SportsPlayoffTriviaInputData class", ignore_extras);
            fieldGeneratorSeason = new SportsSeasonResolvedJSON.HoldingArrayGenerator("field \"Season\" of the SportsPlayoffTriviaInputData class", ignore_extras);
            fieldGeneratorOutcomeCount = new FieldHoldingGeneratorOutcomeCount("field \"OutcomeCount\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorRankResult = new FieldHoldingGeneratorRankResult("field \"RankResult\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorError = new FieldHoldingGeneratorError("field \"Error\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorRankIndices = new FieldHoldingArrayGeneratorRankIndices("field \"RankIndices\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorSeriesIndices = new FieldHoldingArrayGeneratorSeriesIndices("field \"SeriesIndices\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorGamesIndices = new FieldHoldingArrayGeneratorGamesIndices("field \"GamesIndices\" of the SportsPlayoffTriviaInputData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsPlayoffTriviaInputData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorOutcome = new SportsPlayoffTriviaOutcomeJSON.HoldingGenerator("field \"Outcome\" of the SportsPlayoffTriviaInputData class", false);
            fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the SportsPlayoffTriviaInputData class", false);
            fieldGeneratorIsPlayoffsGeneral = new JSONHoldingBooleanGenerator("field \"IsPlayoffsGeneral\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorIsLeagueTitle = new JSONHoldingBooleanGenerator("field \"IsLeagueTitle\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorSpecialGameType = new SportsPlayoffSpecialGameJSON.HoldingGenerator("field \"SpecialGameType\" of the SportsPlayoffTriviaInputData class", false);
            fieldGeneratorTournament = new SportsTournamentJSON.HoldingGenerator("field \"Tournament\" of the SportsPlayoffTriviaInputData class", false);
            fieldGeneratorChronologicalOrdinal = new FieldHoldingGeneratorChronologicalOrdinal("field \"ChronologicalOrdinal\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorIsSingleGame = new JSONHoldingBooleanGenerator("field \"IsSingleGame\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorSortOrderReversed = new JSONHoldingBooleanGenerator("field \"SortOrderReversed\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorTeams = new SportsTeamNewJSON.HoldingArrayGenerator("field \"Teams\" of the SportsPlayoffTriviaInputData class", false);
            fieldGeneratorSeason = new SportsSeasonResolvedJSON.HoldingArrayGenerator("field \"Season\" of the SportsPlayoffTriviaInputData class", false);
            fieldGeneratorOutcomeCount = new FieldHoldingGeneratorOutcomeCount("field \"OutcomeCount\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorRankResult = new FieldHoldingGeneratorRankResult("field \"RankResult\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorError = new FieldHoldingGeneratorError("field \"Error\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorRankIndices = new FieldHoldingArrayGeneratorRankIndices("field \"RankIndices\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorSeriesIndices = new FieldHoldingArrayGeneratorSeriesIndices("field \"SeriesIndices\" of the SportsPlayoffTriviaInputData class");
            fieldGeneratorGamesIndices = new FieldHoldingArrayGeneratorGamesIndices("field \"GamesIndices\" of the SportsPlayoffTriviaInputData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsPlayoffTriviaInputData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorType.reset();
            fieldGeneratorOutcome.reset();
            fieldGeneratorLeague.reset();
            fieldGeneratorIsPlayoffsGeneral.reset();
            fieldGeneratorIsLeagueTitle.reset();
            fieldGeneratorSpecialGameType.reset();
            fieldGeneratorTournament.reset();
            fieldGeneratorChronologicalOrdinal.reset();
            fieldGeneratorRank.reset();
            fieldGeneratorIsSingleGame.reset();
            fieldGeneratorSortOrderReversed.reset();
            fieldGeneratorTeams.reset();
            fieldGeneratorSeason.reset();
            fieldGeneratorOutcomeCount.reset();
            fieldGeneratorRankResult.reset();
            fieldGeneratorError.reset();
            fieldGeneratorRankIndices.reset();
            fieldGeneratorSeriesIndices.reset();
            fieldGeneratorGamesIndices.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorOutcome.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLeague.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSpecialGameType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTournament.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTeams.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSeason.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorOutcome.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLeague.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSpecialGameType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTournament.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTeams.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSeason.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsPlayoffTriviaInputDataJSON  result)
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
        public SportsPlayoffTriviaInputDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsPlayoffTriviaInputDataJSON  result)
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
    protected virtual void handle_result(List<SportsPlayoffTriviaInputDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsPlayoffTriviaInputDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsPlayoffTriviaInputDataJSON>();
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
    public List<SportsPlayoffTriviaInputDataJSON> value;
  };
  };
