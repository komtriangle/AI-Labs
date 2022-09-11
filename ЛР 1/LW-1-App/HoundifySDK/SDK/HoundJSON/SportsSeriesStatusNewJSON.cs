/* file "SportsSeriesStatusNewJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsSeriesStatusNewJSON : JSONBase
  {
    public enum TypeStatusKnownValues
      {
        Status_Upcoming,
        Status_Ongoing,
        Status_Complete,
        Status__none
      };
    public struct TypeStatus
      {
        public bool in_known_list;
        public string string_value;
        public TypeStatusKnownValues list_value;
      };

    public static TypeStatusKnownValues  stringToStatus(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "omplete", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeStatusKnownValues.Status_Complete;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "ngoing", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeStatusKnownValues.Status_Ongoing;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "pcoming", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeStatusKnownValues.Status_Upcoming;
                break;
            default:
                break;
          }
        return TypeStatusKnownValues.Status__none;
      }

    public static string  stringFromStatus(TypeStatusKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeStatusKnownValues.Status_Upcoming:
                return "Upcoming";
            case TypeStatusKnownValues.Status_Ongoing:
                return "Ongoing";
            case TypeStatusKnownValues.Status_Complete:
                return "Complete";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasStatus;
    private TypeStatus storeStatus;
    private bool flagHasSpecialGameType;
    private SportsPlayoffSpecialGameJSON  storeSpecialGameType;
    private bool flagHasTeams;
    private List< SportsTeamNewJSON  > storeTeams;
    private bool flagHasScore;
    private List< BigInteger > storeScore;
    private bool flagHasSoccerAwayGoals;
    private List< BigInteger > storeSoccerAwayGoals;
    private bool flagHasGamesIndices;
    private List< BigInteger > storeGamesIndices;
    private bool flagHasIsAggregateScores;
    private bool storeIsAggregateScores;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Status of SportsSeriesStatusNewJSON is not a string.");
        TypeStatus the_open_enum = new TypeStatus();
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "omplete", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_Complete;
                        goto open_enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "ngoing", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_Ongoing;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "pcoming", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_Upcoming;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setStatus(the_open_enum);
      }


    private void  fromJSONSpecialGameType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsPlayoffSpecialGameJSON convert_classy = SportsPlayoffSpecialGameJSON.from_json(json_value, ignore_extras, true);
        setSpecialGameType(convert_classy);
      }


    private void  fromJSONTeams(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Teams of SportsSeriesStatusNewJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field Teams of SportsSeriesStatusNewJSON has too few elements.");
        List< SportsTeamNewJSON  > vector_Teams1 = new List< SportsTeamNewJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsTeamNewJSON convert_classy = SportsTeamNewJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Teams1.Add(convert_classy);
          }
        Debug.Assert(vector_Teams1.Count >= 2);
        initTeams();
        for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
            appendTeams(vector_Teams1[num1]);
        for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
          {
          }
      }


    private void  fromJSONScore(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Score of SportsSeriesStatusNewJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field Score of SportsSeriesStatusNewJSON has too few elements.");
        List< BigInteger > vector_Score1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field Score of SportsSeriesStatusNewJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field Score of SportsSeriesStatusNewJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_Score1.Add(extracted_integer);
          }
        Debug.Assert(vector_Score1.Count >= 2);
        initScore();
        for (int num2 = 0; num2 < vector_Score1.Count; ++num2)
            appendScore(vector_Score1[num2]);
        for (int num1 = 0; num1 < vector_Score1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSoccerAwayGoals(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SoccerAwayGoals of SportsSeriesStatusNewJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field SoccerAwayGoals of SportsSeriesStatusNewJSON has too few elements.");
        List< BigInteger > vector_SoccerAwayGoals1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field SoccerAwayGoals of SportsSeriesStatusNewJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field SoccerAwayGoals of SportsSeriesStatusNewJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_SoccerAwayGoals1.Add(extracted_integer);
          }
        Debug.Assert(vector_SoccerAwayGoals1.Count >= 2);
        initSoccerAwayGoals();
        for (int num3 = 0; num3 < vector_SoccerAwayGoals1.Count; ++num3)
            appendSoccerAwayGoals(vector_SoccerAwayGoals1[num3]);
        for (int num1 = 0; num1 < vector_SoccerAwayGoals1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGamesIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field GamesIndices of SportsSeriesStatusNewJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field GamesIndices of SportsSeriesStatusNewJSON has too few elements.");
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
                    throw new Exception("The value for an element of field GamesIndices of SportsSeriesStatusNewJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field GamesIndices of SportsSeriesStatusNewJSON is not an integer.");
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
        for (int num4 = 0; num4 < vector_GamesIndices1.Count; ++num4)
            appendGamesIndices(vector_GamesIndices1[num4]);
        for (int num1 = 0; num1 < vector_GamesIndices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONIsAggregateScores(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsAggregateScores of SportsSeriesStatusNewJSON is not true for false.");
              }
          }
        setIsAggregateScores(the_bool);
      }


    public SportsSeriesStatusNewJSON()
      {
        flagHasStatus = false;
        flagHasSpecialGameType = false;
        flagHasTeams = false;
        flagHasScore = false;
        flagHasSoccerAwayGoals = false;
        flagHasGamesIndices = false;
        flagHasIsAggregateScores = false;
        storeTeams = new List< SportsTeamNewJSON  >();
        storeScore = new List< BigInteger >();
        storeSoccerAwayGoals = new List< BigInteger >();
        storeGamesIndices = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStatus()
      {
        return flagHasStatus;
      }

    public TypeStatus  getStatus()
      {
        Debug.Assert(flagHasStatus);
        return storeStatus;
      }

    public string  getStatusAsString()
      {
        TypeStatus result = getStatus();
        if (result.in_known_list)
            return stringFromStatus(result.list_value);
        else
            return result.string_value;
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

    public bool  hasScore()
      {
        return flagHasScore;
      }

    public int  countOfScore()
      {
        Debug.Assert(flagHasScore);
        return storeScore.Count;
      }

    public BigInteger  elementOfScore(int element_num)
      {
        Debug.Assert(flagHasScore);
        return storeScore[element_num];
      }

    public List< BigInteger >  getScore()
      {
        Debug.Assert(flagHasScore);
        return storeScore;
      }

    public bool  hasSoccerAwayGoals()
      {
        return flagHasSoccerAwayGoals;
      }

    public int  countOfSoccerAwayGoals()
      {
        Debug.Assert(flagHasSoccerAwayGoals);
        return storeSoccerAwayGoals.Count;
      }

    public BigInteger  elementOfSoccerAwayGoals(int element_num)
      {
        Debug.Assert(flagHasSoccerAwayGoals);
        return storeSoccerAwayGoals[element_num];
      }

    public List< BigInteger >  getSoccerAwayGoals()
      {
        Debug.Assert(flagHasSoccerAwayGoals);
        return storeSoccerAwayGoals;
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

    public bool  hasIsAggregateScores()
      {
        return flagHasIsAggregateScores;
      }

    public bool  getIsAggregateScores()
      {
        Debug.Assert(flagHasIsAggregateScores);
        return storeIsAggregateScores;
      }


    public virtual int extraSportsSeriesStatusNewComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsSeriesStatusNewComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsSeriesStatusNewComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsSeriesStatusNewLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setStatus(TypeStatus new_value)
      {
        flagHasStatus = true;
        storeStatus = new_value;
      }
    public void setStatus(string chars)
      {
        TypeStatusKnownValues known = stringToStatus(chars);
        TypeStatus new_value = new TypeStatus();
        if (known == TypeStatusKnownValues.Status__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setStatus(new_value);
      }
    public void setStatus(TypeStatusKnownValues new_value)
      {
        TypeStatus new_full_value = new TypeStatus();
        Debug.Assert(new_value != TypeStatusKnownValues.Status__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setStatus(new_full_value);
      }
    public void unsetStatus()
      {
        flagHasStatus = false;
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
    public void initScore()
      {
        flagHasScore = true;
        storeScore.Clear();
      }
    public void appendScore(BigInteger to_append)
      {
        if (!flagHasScore)
          {
            flagHasScore = true;
            storeScore.Clear();
          }
        Debug.Assert(flagHasScore);
        storeScore.Add(to_append);
      }
    public void unsetScore()
      {
        flagHasScore = false;
        storeScore.Clear();
      }
    public void initSoccerAwayGoals()
      {
        flagHasSoccerAwayGoals = true;
        storeSoccerAwayGoals.Clear();
      }
    public void appendSoccerAwayGoals(BigInteger to_append)
      {
        if (!flagHasSoccerAwayGoals)
          {
            flagHasSoccerAwayGoals = true;
            storeSoccerAwayGoals.Clear();
          }
        Debug.Assert(flagHasSoccerAwayGoals);
        storeSoccerAwayGoals.Add(to_append);
      }
    public void unsetSoccerAwayGoals()
      {
        flagHasSoccerAwayGoals = false;
        storeSoccerAwayGoals.Clear();
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
    public void setIsAggregateScores(bool new_value)
      {
        flagHasIsAggregateScores = true;
        storeIsAggregateScores = new_value;
      }
    public void unsetIsAggregateScores()
      {
        flagHasIsAggregateScores = false;
      }

    public virtual void extraSportsSeriesStatusNewAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsSeriesStatusNewSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsSeriesStatusNewLookup(key);
        if (old_field == null)
          {
            extraSportsSeriesStatusNewAppendPair(key, new_component);
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
        if (flagHasStatus)
          {
            handler.start_pair("Status");
            if (storeStatus.in_known_list)
              {
                switch (storeStatus.list_value)
                  {
                    case TypeStatusKnownValues.Status_Upcoming:
                        handler.string_value("Upcoming");
                        break;
                    case TypeStatusKnownValues.Status_Ongoing:
                        handler.string_value("Ongoing");
                        break;
                    case TypeStatusKnownValues.Status_Complete:
                        handler.string_value("Complete");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeStatus.string_value);
              }
          }
        if (flagHasSpecialGameType)
          {
            handler.start_pair("SpecialGameType");
            if (partial_allowed)
                storeSpecialGameType.write_partial_as_json(handler);
            else
                storeSpecialGameType.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasTeams);
        if (flagHasTeams)
          {
            handler.start_pair("Teams");
            Debug.Assert(storeTeams.Count >= 2);
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
        if (flagHasScore)
          {
            handler.start_pair("Score");
            Debug.Assert(storeScore.Count >= 2);
            handler.start_array();
            for (int num2 = 0; num2 < storeScore.Count; ++num2)
              {
                handler.number_value(storeScore[num2]);
              }
            handler.finish_array();
          }
        if (flagHasSoccerAwayGoals)
          {
            handler.start_pair("SoccerAwayGoals");
            Debug.Assert(storeSoccerAwayGoals.Count >= 2);
            handler.start_array();
            for (int num3 = 0; num3 < storeSoccerAwayGoals.Count; ++num3)
              {
                handler.number_value(storeSoccerAwayGoals[num3]);
              }
            handler.finish_array();
          }
        if (flagHasGamesIndices)
          {
            handler.start_pair("GamesIndices");
            Debug.Assert(storeGamesIndices.Count >= 1);
            handler.start_array();
            for (int num4 = 0; num4 < storeGamesIndices.Count; ++num4)
              {
                handler.number_value(storeGamesIndices[num4]);
              }
            handler.finish_array();
          }
        if (flagHasIsAggregateScores)
          {
            handler.start_pair("IsAggregateScores");
            handler.boolean_value(storeIsAggregateScores);
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
        if (!(hasTeams()))
          {
            return "When parsing the object for %what%, the \"Teams\" field was missing.";
          }
        return null;
      }

    public static SportsSeriesStatusNewJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsSeriesStatusNewJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsSeriesStatusNew", ignore_extras);
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
    public static SportsSeriesStatusNewJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsSeriesStatusNewJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsSeriesStatusNewJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsSeriesStatusNew", ignore_extras);
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
    public static SportsSeriesStatusNewJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsSeriesStatusNewJSON from_text(string text, bool ignore_extras)
      {
        SportsSeriesStatusNewJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsSeriesStatusNew", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsSeriesStatusNewJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsSeriesStatusNewJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsSeriesStatusNewJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsSeriesStatusNew", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorStatus : JSONStringGenerator
          {
            protected FieldGeneratorStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorStatus()
              {
              }
            protected override void handle_result(string result)
              {
                TypeStatusKnownValues known = stringToStatus(result);
                TypeStatus new_value = new TypeStatus();
                if (known == TypeStatusKnownValues.Status__none)
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
            protected abstract void handle_result(TypeStatus result);
          };
    private class FieldHoldingGeneratorStatus : FieldGeneratorStatus
  {
    protected override void handle_result(TypeStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorStatus(String what)
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
    public TypeStatus value;
  };
    private class FieldHoldingArrayGeneratorStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorStatus
      {
        private FieldHoldingArrayGeneratorStatus top;

        protected override void handle_result(TypeStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorStatus init_top)
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
    protected virtual void handle_result(List<TypeStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeStatus> value;
  };
        private FieldHoldingGeneratorStatus fieldGeneratorStatus;
        private SportsPlayoffSpecialGameJSON.HoldingGenerator fieldGeneratorSpecialGameType;
        private SportsTeamNewJSON.HoldingArrayGenerator fieldGeneratorTeams;
    private class FieldHoldingGeneratorScore : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorScore(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorScore : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorScore(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorScore fieldGeneratorScore;
    private class FieldHoldingGeneratorSoccerAwayGoals : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSoccerAwayGoals(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSoccerAwayGoals : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSoccerAwayGoals(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorSoccerAwayGoals fieldGeneratorSoccerAwayGoals;
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
        private JSONHoldingBooleanGenerator fieldGeneratorIsAggregateScores;
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
            SportsSeriesStatusNewJSON result = new SportsSeriesStatusNewJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsSeriesStatusNewAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsSeriesStatusNewJSON result)
          {
            if (fieldGeneratorStatus.have_value)
              {
                result.setStatus(fieldGeneratorStatus.value);
                fieldGeneratorStatus.have_value = false;
              }
            if (fieldGeneratorSpecialGameType.have_value)
              {
                result.setSpecialGameType(fieldGeneratorSpecialGameType.value);
                fieldGeneratorSpecialGameType.have_value = false;
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
            else if ((!(result.hasTeams())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Teams\" field was missing.");
              }
            if (fieldGeneratorScore.have_value)
              {
                result.initScore();
                int count = fieldGeneratorScore.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendScore(fieldGeneratorScore.value[num]);
                  }
                fieldGeneratorScore.value.Clear();
                fieldGeneratorScore.have_value = false;
              }
            if (fieldGeneratorSoccerAwayGoals.have_value)
              {
                result.initSoccerAwayGoals();
                int count = fieldGeneratorSoccerAwayGoals.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSoccerAwayGoals(fieldGeneratorSoccerAwayGoals.value[num]);
                  }
                fieldGeneratorSoccerAwayGoals.value.Clear();
                fieldGeneratorSoccerAwayGoals.have_value = false;
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
            if (fieldGeneratorIsAggregateScores.have_value)
              {
                result.setIsAggregateScores(fieldGeneratorIsAggregateScores.value);
                fieldGeneratorIsAggregateScores.have_value = false;
              }
          }
        protected abstract void handle_result(SportsSeriesStatusNewJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'G':
                    if ((String.Compare(field_name, 1, "amesIndices", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorGamesIndices;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sAggregateScores", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorIsAggregateScores;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'c':
                            if ((String.Compare(field_name, 2, "ore", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorScore;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "ccerAwayGoals", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorSoccerAwayGoals;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "ecialGameType", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorSpecialGameType;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "atus", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorStatus;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "eams", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorTeams;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the SportsSeriesStatusNew class");
            fieldGeneratorSpecialGameType = new SportsPlayoffSpecialGameJSON.HoldingGenerator("field \"SpecialGameType\" of the SportsSeriesStatusNew class", ignore_extras);
            fieldGeneratorTeams = new SportsTeamNewJSON.HoldingArrayGenerator("field \"Teams\" of the SportsSeriesStatusNew class", ignore_extras);
            fieldGeneratorScore = new FieldHoldingArrayGeneratorScore("field \"Score\" of the SportsSeriesStatusNew class");
            fieldGeneratorSoccerAwayGoals = new FieldHoldingArrayGeneratorSoccerAwayGoals("field \"SoccerAwayGoals\" of the SportsSeriesStatusNew class");
            fieldGeneratorGamesIndices = new FieldHoldingArrayGeneratorGamesIndices("field \"GamesIndices\" of the SportsSeriesStatusNew class");
            fieldGeneratorIsAggregateScores = new JSONHoldingBooleanGenerator("field \"IsAggregateScores\" of the SportsSeriesStatusNew class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsSeriesStatusNew class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the SportsSeriesStatusNew class");
            fieldGeneratorSpecialGameType = new SportsPlayoffSpecialGameJSON.HoldingGenerator("field \"SpecialGameType\" of the SportsSeriesStatusNew class", false);
            fieldGeneratorTeams = new SportsTeamNewJSON.HoldingArrayGenerator("field \"Teams\" of the SportsSeriesStatusNew class", false);
            fieldGeneratorScore = new FieldHoldingArrayGeneratorScore("field \"Score\" of the SportsSeriesStatusNew class");
            fieldGeneratorSoccerAwayGoals = new FieldHoldingArrayGeneratorSoccerAwayGoals("field \"SoccerAwayGoals\" of the SportsSeriesStatusNew class");
            fieldGeneratorGamesIndices = new FieldHoldingArrayGeneratorGamesIndices("field \"GamesIndices\" of the SportsSeriesStatusNew class");
            fieldGeneratorIsAggregateScores = new JSONHoldingBooleanGenerator("field \"IsAggregateScores\" of the SportsSeriesStatusNew class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsSeriesStatusNew class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStatus.reset();
            fieldGeneratorSpecialGameType.reset();
            fieldGeneratorTeams.reset();
            fieldGeneratorScore.reset();
            fieldGeneratorSoccerAwayGoals.reset();
            fieldGeneratorGamesIndices.reset();
            fieldGeneratorIsAggregateScores.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSpecialGameType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTeams.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSpecialGameType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTeams.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsSeriesStatusNewJSON  result)
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
        public SportsSeriesStatusNewJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsSeriesStatusNewJSON  result)
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
    protected virtual void handle_result(List<SportsSeriesStatusNewJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsSeriesStatusNewJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsSeriesStatusNewJSON>();
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
    public List<SportsSeriesStatusNewJSON> value;
  };
  };
