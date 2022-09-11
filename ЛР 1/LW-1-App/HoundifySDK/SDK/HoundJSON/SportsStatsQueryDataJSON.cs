/* file "SportsStatsQueryDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsStatsQueryDataJSON : JSONBase
  {
    public enum TypeCardinalityKnownValues
      {
        Cardinality_Single,
        Cardinality_Multiple,
        Cardinality__none
      };
    public struct TypeCardinality
      {
        public bool in_known_list;
        public string string_value;
        public TypeCardinalityKnownValues list_value;
      };

    public static TypeCardinalityKnownValues  stringToCardinality(string chars)
      {
        switch (chars[0])
          {
            case 'M':
                if ((String.Compare(chars, 1, "ultiple", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeCardinalityKnownValues.Cardinality_Multiple;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "ingle", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeCardinalityKnownValues.Cardinality_Single;
                break;
            default:
                break;
          }
        return TypeCardinalityKnownValues.Cardinality__none;
      }

    public static string  stringFromCardinality(TypeCardinalityKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeCardinalityKnownValues.Cardinality_Single:
                return "Single";
            case TypeCardinalityKnownValues.Cardinality_Multiple:
                return "Multiple";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeErrorKnownValues
      {
        Error_DataUnavailable,
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
        if ((String.Compare(chars, 0, "DataUnavailable", 0, 15, false) == 0) && (chars.Length == 15))
            return TypeErrorKnownValues.Error_DataUnavailable;
        return TypeErrorKnownValues.Error__none;
      }

    public static string  stringFromError(TypeErrorKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeErrorKnownValues.Error_DataUnavailable:
                return "DataUnavailable";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasTeamOrPlayer;
    private SportsTeamOrPlayerJSON  storeTeamOrPlayer;
    private bool flagHasStatisticsTypeAndValue;
    private List< SportsStatsTypeAndValueJSON  > storeStatisticsTypeAndValue;
    private bool flagHasSeason;
    private SportsSeasonResolvedJSON  storeSeason;
    private bool flagHasGame;
    private SportsGameJSON  storeGame;
    private bool flagHasCardinality;
    private TypeCardinality storeCardinality;
    private bool flagHasError;
    private TypeError storeError;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTeamOrPlayer(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsTeamOrPlayerJSON convert_classy = SportsTeamOrPlayerJSON.from_json(json_value, ignore_extras, true);
        setTeamOrPlayer(convert_classy);
      }


    private void  fromJSONStatisticsTypeAndValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field StatisticsTypeAndValue of SportsStatsQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsStatsTypeAndValueJSON  > vector_StatisticsTypeAndValue1 = new List< SportsStatsTypeAndValueJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsStatsTypeAndValueJSON convert_classy = SportsStatsTypeAndValueJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_StatisticsTypeAndValue1.Add(convert_classy);
          }
        initStatisticsTypeAndValue();
        for (int num1 = 0; num1 < vector_StatisticsTypeAndValue1.Count; ++num1)
            appendStatisticsTypeAndValue(vector_StatisticsTypeAndValue1[num1]);
        for (int num1 = 0; num1 < vector_StatisticsTypeAndValue1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSeason(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsSeasonResolvedJSON convert_classy = SportsSeasonResolvedJSON.from_json(json_value, ignore_extras, true);
        setSeason(convert_classy);
      }


    private void  fromJSONGame(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsGameJSON convert_classy = SportsGameJSON.from_json(json_value, ignore_extras, true);
        setGame(convert_classy);
      }


    private void  fromJSONCardinality(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Cardinality of SportsStatsQueryDataJSON is not a string.");
        TypeCardinality the_open_enum = new TypeCardinality();
        switch (json_string.getData()[0])
          {
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "ultiple", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCardinalityKnownValues.Cardinality_Multiple;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "ingle", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCardinalityKnownValues.Cardinality_Single;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setCardinality(the_open_enum);
      }


    private void  fromJSONError(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Error of SportsStatsQueryDataJSON is not a string.");
        TypeError the_open_enum = new TypeError();
        if ((String.Compare(json_string.getData(), 0, "DataUnavailable", 0, 15, false) == 0) && (json_string.getData().Length == 15))
              {
                the_open_enum.in_known_list = true;
                the_open_enum.list_value = TypeErrorKnownValues.Error_DataUnavailable;
                goto open_enum_is_done;
              }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setError(the_open_enum);
      }


    public SportsStatsQueryDataJSON()
      {
        flagHasTeamOrPlayer = false;
        flagHasStatisticsTypeAndValue = false;
        flagHasSeason = false;
        flagHasGame = false;
        flagHasCardinality = false;
        flagHasError = false;
        storeStatisticsTypeAndValue = new List< SportsStatsTypeAndValueJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTeamOrPlayer()
      {
        return flagHasTeamOrPlayer;
      }

    public SportsTeamOrPlayerJSON   getTeamOrPlayer()
      {
        Debug.Assert(flagHasTeamOrPlayer);
        return storeTeamOrPlayer;
      }

    public SportsTeamOrPlayerJSON.TypeValue  getTeamOrPlayerValue()
      {
        return getTeamOrPlayer().getValue();
      }

    public bool  hasStatisticsTypeAndValue()
      {
        return flagHasStatisticsTypeAndValue;
      }

    public int  countOfStatisticsTypeAndValue()
      {
        Debug.Assert(flagHasStatisticsTypeAndValue);
        return storeStatisticsTypeAndValue.Count;
      }

    public SportsStatsTypeAndValueJSON   elementOfStatisticsTypeAndValue(int element_num)
      {
        Debug.Assert(flagHasStatisticsTypeAndValue);
        return storeStatisticsTypeAndValue[element_num];
      }

    public List< SportsStatsTypeAndValueJSON  >  getStatisticsTypeAndValue()
      {
        Debug.Assert(flagHasStatisticsTypeAndValue);
        return storeStatisticsTypeAndValue;
      }

    public bool  hasSeason()
      {
        return flagHasSeason;
      }

    public SportsSeasonResolvedJSON   getSeason()
      {
        Debug.Assert(flagHasSeason);
        return storeSeason;
      }

    public bool  hasGame()
      {
        return flagHasGame;
      }

    public SportsGameJSON   getGame()
      {
        Debug.Assert(flagHasGame);
        return storeGame;
      }

    public bool  hasCardinality()
      {
        return flagHasCardinality;
      }

    public TypeCardinality  getCardinality()
      {
        Debug.Assert(flagHasCardinality);
        return storeCardinality;
      }

    public string  getCardinalityAsString()
      {
        TypeCardinality result = getCardinality();
        if (result.in_known_list)
            return stringFromCardinality(result.list_value);
        else
            return result.string_value;
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


    public virtual int extraSportsStatsQueryDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsStatsQueryDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsStatsQueryDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsStatsQueryDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setTeamOrPlayer(SportsTeamOrPlayerJSON  new_value)
      {
        if (flagHasTeamOrPlayer)
          {
          }
        flagHasTeamOrPlayer = true;
        storeTeamOrPlayer = new_value;
      }
    public void setTeamOrPlayer(SportsTeamOrPlayerJSON.TypeValue new_value)
      {
        setTeamOrPlayer(new SportsTeamOrPlayerJSON(new_value));
      }
    public void unsetTeamOrPlayer()
      {
        if (flagHasTeamOrPlayer)
          {
          }
        flagHasTeamOrPlayer = false;
      }
    public void initStatisticsTypeAndValue()
      {
        if (flagHasStatisticsTypeAndValue)
          {
            for (int num1 = 0; num1 < storeStatisticsTypeAndValue.Count; ++num1)
              {
              }
          }
        flagHasStatisticsTypeAndValue = true;
        storeStatisticsTypeAndValue.Clear();
      }
    public void appendStatisticsTypeAndValue(SportsStatsTypeAndValueJSON  to_append)
      {
        if (!flagHasStatisticsTypeAndValue)
          {
            flagHasStatisticsTypeAndValue = true;
            storeStatisticsTypeAndValue.Clear();
          }
        Debug.Assert(flagHasStatisticsTypeAndValue);
        storeStatisticsTypeAndValue.Add(to_append);
      }
    public void unsetStatisticsTypeAndValue()
      {
        if (flagHasStatisticsTypeAndValue)
          {
            for (int num2 = 0; num2 < storeStatisticsTypeAndValue.Count; ++num2)
              {
              }
          }
        flagHasStatisticsTypeAndValue = false;
        storeStatisticsTypeAndValue.Clear();
      }
    public void setSeason(SportsSeasonResolvedJSON  new_value)
      {
        if (flagHasSeason)
          {
          }
        flagHasSeason = true;
        storeSeason = new_value;
      }
    public void unsetSeason()
      {
        if (flagHasSeason)
          {
          }
        flagHasSeason = false;
      }
    public void setGame(SportsGameJSON  new_value)
      {
        if (flagHasGame)
          {
          }
        flagHasGame = true;
        storeGame = new_value;
      }
    public void unsetGame()
      {
        if (flagHasGame)
          {
          }
        flagHasGame = false;
      }
    public void setCardinality(TypeCardinality new_value)
      {
        flagHasCardinality = true;
        storeCardinality = new_value;
      }
    public void setCardinality(string chars)
      {
        TypeCardinalityKnownValues known = stringToCardinality(chars);
        TypeCardinality new_value = new TypeCardinality();
        if (known == TypeCardinalityKnownValues.Cardinality__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setCardinality(new_value);
      }
    public void setCardinality(TypeCardinalityKnownValues new_value)
      {
        TypeCardinality new_full_value = new TypeCardinality();
        Debug.Assert(new_value != TypeCardinalityKnownValues.Cardinality__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setCardinality(new_full_value);
      }
    public void unsetCardinality()
      {
        flagHasCardinality = false;
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

    public virtual void extraSportsStatsQueryDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsStatsQueryDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsStatsQueryDataLookup(key);
        if (old_field == null)
          {
            extraSportsStatsQueryDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasTeamOrPlayer);
        if (flagHasTeamOrPlayer)
          {
            handler.start_pair("TeamOrPlayer");
            if (partial_allowed)
                storeTeamOrPlayer.write_partial_as_json(handler);
            else
                storeTeamOrPlayer.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasStatisticsTypeAndValue);
        if (flagHasStatisticsTypeAndValue)
          {
            handler.start_pair("StatisticsTypeAndValue");
            handler.start_array();
            for (int num1 = 0; num1 < storeStatisticsTypeAndValue.Count; ++num1)
              {
                if (partial_allowed)
                    storeStatisticsTypeAndValue[num1].write_partial_as_json(handler);
                else
                    storeStatisticsTypeAndValue[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSeason)
          {
            handler.start_pair("Season");
            if (partial_allowed)
                storeSeason.write_partial_as_json(handler);
            else
                storeSeason.write_as_json(handler);
          }
        if (flagHasGame)
          {
            handler.start_pair("Game");
            if (partial_allowed)
                storeGame.write_partial_as_json(handler);
            else
                storeGame.write_as_json(handler);
          }
        if (flagHasCardinality)
          {
            handler.start_pair("Cardinality");
            if (storeCardinality.in_known_list)
              {
                switch (storeCardinality.list_value)
                  {
                    case TypeCardinalityKnownValues.Cardinality_Single:
                        handler.string_value("Single");
                        break;
                    case TypeCardinalityKnownValues.Cardinality_Multiple:
                        handler.string_value("Multiple");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeCardinality.string_value);
              }
          }
        if (flagHasError)
          {
            handler.start_pair("Error");
            if (storeError.in_known_list)
              {
                switch (storeError.list_value)
                  {
                    case TypeErrorKnownValues.Error_DataUnavailable:
                        handler.string_value("DataUnavailable");
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
        if (!(hasTeamOrPlayer()))
          {
            return "When parsing the object for %what%, the \"TeamOrPlayer\" field was missing.";
          }
        if (!(hasStatisticsTypeAndValue()))
          {
            return "When parsing the object for %what%, the \"StatisticsTypeAndValue\" field was missing.";
          }
        return null;
      }

    public static SportsStatsQueryDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStatsQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsQueryData", ignore_extras);
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
    public static SportsStatsQueryDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStatsQueryDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStatsQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsQueryData", ignore_extras);
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
    public static SportsStatsQueryDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStatsQueryDataJSON from_text(string text, bool ignore_extras)
      {
        SportsStatsQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsQueryData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStatsQueryDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsStatsQueryDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStatsQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsQueryData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsTeamOrPlayerJSON.HoldingGenerator fieldGeneratorTeamOrPlayer;
        private SportsStatsTypeAndValueJSON.HoldingArrayGenerator fieldGeneratorStatisticsTypeAndValue;
        private SportsSeasonResolvedJSON.HoldingGenerator fieldGeneratorSeason;
        private SportsGameJSON.HoldingGenerator fieldGeneratorGame;
    private abstract class FieldGeneratorCardinality : JSONStringGenerator
          {
            protected FieldGeneratorCardinality(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCardinality()
              {
              }
            protected override void handle_result(string result)
              {
                TypeCardinalityKnownValues known = stringToCardinality(result);
                TypeCardinality new_value = new TypeCardinality();
                if (known == TypeCardinalityKnownValues.Cardinality__none)
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
            protected abstract void handle_result(TypeCardinality result);
          };
    private class FieldHoldingGeneratorCardinality : FieldGeneratorCardinality
  {
    protected override void handle_result(TypeCardinality result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCardinality(String what)
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
    public TypeCardinality value;
  };
    private class FieldHoldingArrayGeneratorCardinality : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCardinality
      {
        private FieldHoldingArrayGeneratorCardinality top;

        protected override void handle_result(TypeCardinality result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCardinality init_top)
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
    protected virtual void handle_result(List<TypeCardinality> result)
      {
      }

    public FieldHoldingArrayGeneratorCardinality(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCardinality>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCardinality()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCardinality>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCardinality> value;
  };
        private FieldHoldingGeneratorCardinality fieldGeneratorCardinality;
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
            SportsStatsQueryDataJSON result = new SportsStatsQueryDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStatsQueryDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsStatsQueryDataJSON result)
          {
            if (fieldGeneratorTeamOrPlayer.have_value)
              {
                result.setTeamOrPlayer(fieldGeneratorTeamOrPlayer.value);
                fieldGeneratorTeamOrPlayer.have_value = false;
              }
            else if ((!(result.hasTeamOrPlayer())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TeamOrPlayer\" field was missing.");
              }
            if (fieldGeneratorStatisticsTypeAndValue.have_value)
              {
                result.initStatisticsTypeAndValue();
                int count = fieldGeneratorStatisticsTypeAndValue.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStatisticsTypeAndValue(fieldGeneratorStatisticsTypeAndValue.value[num]);
                  }
                fieldGeneratorStatisticsTypeAndValue.value.Clear();
                fieldGeneratorStatisticsTypeAndValue.have_value = false;
              }
            else if ((!(result.hasStatisticsTypeAndValue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StatisticsTypeAndValue\" field was missing.");
              }
            if (fieldGeneratorSeason.have_value)
              {
                result.setSeason(fieldGeneratorSeason.value);
                fieldGeneratorSeason.have_value = false;
              }
            if (fieldGeneratorGame.have_value)
              {
                result.setGame(fieldGeneratorGame.value);
                fieldGeneratorGame.have_value = false;
              }
            if (fieldGeneratorCardinality.have_value)
              {
                result.setCardinality(fieldGeneratorCardinality.value);
                fieldGeneratorCardinality.have_value = false;
              }
            if (fieldGeneratorError.have_value)
              {
                result.setError(fieldGeneratorError.value);
                fieldGeneratorError.have_value = false;
              }
          }
        protected abstract void handle_result(SportsStatsQueryDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ardinality", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCardinality;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "rror", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorError;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorGame;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "ason", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorSeason;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "atisticsTypeAndValue", 0, 20, false) == 0) && (field_name.Length == 22))
                                return fieldGeneratorStatisticsTypeAndValue;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "eamOrPlayer", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorTeamOrPlayer;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTeamOrPlayer = new SportsTeamOrPlayerJSON.HoldingGenerator("field \"TeamOrPlayer\" of the SportsStatsQueryData class", ignore_extras);
            fieldGeneratorStatisticsTypeAndValue = new SportsStatsTypeAndValueJSON.HoldingArrayGenerator("field \"StatisticsTypeAndValue\" of the SportsStatsQueryData class", ignore_extras);
            fieldGeneratorSeason = new SportsSeasonResolvedJSON.HoldingGenerator("field \"Season\" of the SportsStatsQueryData class", ignore_extras);
            fieldGeneratorGame = new SportsGameJSON.HoldingGenerator("field \"Game\" of the SportsStatsQueryData class", ignore_extras);
            fieldGeneratorCardinality = new FieldHoldingGeneratorCardinality("field \"Cardinality\" of the SportsStatsQueryData class");
            fieldGeneratorError = new FieldHoldingGeneratorError("field \"Error\" of the SportsStatsQueryData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsStatsQueryData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTeamOrPlayer = new SportsTeamOrPlayerJSON.HoldingGenerator("field \"TeamOrPlayer\" of the SportsStatsQueryData class", false);
            fieldGeneratorStatisticsTypeAndValue = new SportsStatsTypeAndValueJSON.HoldingArrayGenerator("field \"StatisticsTypeAndValue\" of the SportsStatsQueryData class", false);
            fieldGeneratorSeason = new SportsSeasonResolvedJSON.HoldingGenerator("field \"Season\" of the SportsStatsQueryData class", false);
            fieldGeneratorGame = new SportsGameJSON.HoldingGenerator("field \"Game\" of the SportsStatsQueryData class", false);
            fieldGeneratorCardinality = new FieldHoldingGeneratorCardinality("field \"Cardinality\" of the SportsStatsQueryData class");
            fieldGeneratorError = new FieldHoldingGeneratorError("field \"Error\" of the SportsStatsQueryData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsStatsQueryData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTeamOrPlayer.reset();
            fieldGeneratorStatisticsTypeAndValue.reset();
            fieldGeneratorSeason.reset();
            fieldGeneratorGame.reset();
            fieldGeneratorCardinality.reset();
            fieldGeneratorError.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTeamOrPlayer.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStatisticsTypeAndValue.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSeason.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorGame.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTeamOrPlayer.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStatisticsTypeAndValue.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSeason.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorGame.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsStatsQueryDataJSON  result)
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
        public SportsStatsQueryDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStatsQueryDataJSON  result)
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
    protected virtual void handle_result(List<SportsStatsQueryDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStatsQueryDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStatsQueryDataJSON>();
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
    public List<SportsStatsQueryDataJSON> value;
  };
  };
