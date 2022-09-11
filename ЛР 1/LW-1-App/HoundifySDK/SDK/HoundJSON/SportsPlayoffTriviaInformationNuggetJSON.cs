/* file "SportsPlayoffTriviaInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsPlayoffTriviaInformationNuggetJSON : SportsInformationNuggetJSON
  {
    private bool flagHasQueryData;
    private List< SportsPlayoffTriviaInputDataJSON  > storeQueryData;
    private bool flagHasRanks;
    private List< SportsPlayoffTriviaRanksJSON  > storeRanks;
    private bool flagHasGames;
    private List< SportsGameJSON  > storeGames;
    private bool flagHasSeries;
    private List< SportsSeriesStatusNewJSON  > storeSeries;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraQueryDataToJSON()
      {
        JSONArrayValue generated_array_1_QueryData = new JSONArrayValue();
        for (int num1 = 0; num1 < storeQueryData.Count; ++num1)
          {
            JSONValueHandler handler_QueryData = new JSONValueHandler();
            storeQueryData[num1].write_as_json(handler_QueryData);
            generated_array_1_QueryData.appendComponent(handler_QueryData.result);
          }
        return generated_array_1_QueryData;
      }

    private JSONValue  extraRanksToJSON()
      {
        JSONArrayValue generated_array_2_Ranks = new JSONArrayValue();
        for (int num2 = 0; num2 < storeRanks.Count; ++num2)
          {
            JSONValueHandler handler_Ranks = new JSONValueHandler();
            storeRanks[num2].write_as_json(handler_Ranks);
            generated_array_2_Ranks.appendComponent(handler_Ranks.result);
          }
        return generated_array_2_Ranks;
      }

    private JSONValue  extraGamesToJSON()
      {
        JSONArrayValue generated_array_3_Games = new JSONArrayValue();
        for (int num3 = 0; num3 < storeGames.Count; ++num3)
          {
            JSONValueHandler handler_Games = new JSONValueHandler();
            storeGames[num3].write_as_json(handler_Games);
            generated_array_3_Games.appendComponent(handler_Games.result);
          }
        return generated_array_3_Games;
      }

    private JSONValue  extraSeriesToJSON()
      {
        JSONArrayValue generated_array_4_Series = new JSONArrayValue();
        for (int num4 = 0; num4 < storeSeries.Count; ++num4)
          {
            JSONValueHandler handler_Series = new JSONValueHandler();
            storeSeries[num4].write_as_json(handler_Series);
            generated_array_4_Series.appendComponent(handler_Series.result);
          }
        return generated_array_4_Series;
      }


    private void  fromJSONQueryData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field QueryData of SportsPlayoffTriviaInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsPlayoffTriviaInputDataJSON  > vector_QueryData1 = new List< SportsPlayoffTriviaInputDataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsPlayoffTriviaInputDataJSON convert_classy = SportsPlayoffTriviaInputDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_QueryData1.Add(convert_classy);
          }
        initQueryData();
        for (int num1 = 0; num1 < vector_QueryData1.Count; ++num1)
            appendQueryData(vector_QueryData1[num1]);
        for (int num1 = 0; num1 < vector_QueryData1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRanks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Ranks of SportsPlayoffTriviaInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsPlayoffTriviaRanksJSON  > vector_Ranks1 = new List< SportsPlayoffTriviaRanksJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsPlayoffTriviaRanksJSON convert_classy = SportsPlayoffTriviaRanksJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Ranks1.Add(convert_classy);
          }
        initRanks();
        for (int num2 = 0; num2 < vector_Ranks1.Count; ++num2)
            appendRanks(vector_Ranks1[num2]);
        for (int num1 = 0; num1 < vector_Ranks1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGames(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Games of SportsPlayoffTriviaInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsGameJSON  > vector_Games1 = new List< SportsGameJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsGameJSON convert_classy = SportsGameJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Games1.Add(convert_classy);
          }
        initGames();
        for (int num3 = 0; num3 < vector_Games1.Count; ++num3)
            appendGames(vector_Games1[num3]);
        for (int num1 = 0; num1 < vector_Games1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSeries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Series of SportsPlayoffTriviaInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsSeriesStatusNewJSON  > vector_Series1 = new List< SportsSeriesStatusNewJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsSeriesStatusNewJSON convert_classy = SportsSeriesStatusNewJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Series1.Add(convert_classy);
          }
        initSeries();
        for (int num4 = 0; num4 < vector_Series1.Count; ++num4)
            appendSeries(vector_Series1[num4]);
        for (int num1 = 0; num1 < vector_Series1.Count; ++num1)
          {
          }
      }


    public SportsPlayoffTriviaInformationNuggetJSON()
      {
        flagHasQueryData = false;
        flagHasRanks = false;
        flagHasGames = false;
        flagHasSeries = false;
        storeQueryData = new List< SportsPlayoffTriviaInputDataJSON  >();
        storeRanks = new List< SportsPlayoffTriviaRanksJSON  >();
        storeGames = new List< SportsGameJSON  >();
        storeSeries = new List< SportsSeriesStatusNewJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsNuggetKind()
      {
        return "SportsPlayoffTrivia";
      }

    public bool  hasQueryData()
      {
        return flagHasQueryData;
      }

    public int  countOfQueryData()
      {
        Debug.Assert(flagHasQueryData);
        return storeQueryData.Count;
      }

    public SportsPlayoffTriviaInputDataJSON   elementOfQueryData(int element_num)
      {
        Debug.Assert(flagHasQueryData);
        return storeQueryData[element_num];
      }

    public List< SportsPlayoffTriviaInputDataJSON  >  getQueryData()
      {
        Debug.Assert(flagHasQueryData);
        return storeQueryData;
      }

    public bool  hasRanks()
      {
        return flagHasRanks;
      }

    public int  countOfRanks()
      {
        Debug.Assert(flagHasRanks);
        return storeRanks.Count;
      }

    public SportsPlayoffTriviaRanksJSON   elementOfRanks(int element_num)
      {
        Debug.Assert(flagHasRanks);
        return storeRanks[element_num];
      }

    public List< SportsPlayoffTriviaRanksJSON  >  getRanks()
      {
        Debug.Assert(flagHasRanks);
        return storeRanks;
      }

    public bool  hasGames()
      {
        return flagHasGames;
      }

    public int  countOfGames()
      {
        Debug.Assert(flagHasGames);
        return storeGames.Count;
      }

    public SportsGameJSON   elementOfGames(int element_num)
      {
        Debug.Assert(flagHasGames);
        return storeGames[element_num];
      }

    public List< SportsGameJSON  >  getGames()
      {
        Debug.Assert(flagHasGames);
        return storeGames;
      }

    public bool  hasSeries()
      {
        return flagHasSeries;
      }

    public int  countOfSeries()
      {
        Debug.Assert(flagHasSeries);
        return storeSeries.Count;
      }

    public SportsSeriesStatusNewJSON   elementOfSeries(int element_num)
      {
        Debug.Assert(flagHasSeries);
        return storeSeries[element_num];
      }

    public List< SportsSeriesStatusNewJSON  >  getSeries()
      {
        Debug.Assert(flagHasSeries);
        return storeSeries;
      }


    public virtual int extraSportsPlayoffTriviaInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsPlayoffTriviaInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsPlayoffTriviaInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsPlayoffTriviaInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasQueryData)
            ++result;
        if (flagHasRanks)
            ++result;
        if (flagHasGames)
            ++result;
        if (flagHasSeries)
            ++result;
        result += extraSportsPlayoffTriviaInformationNuggetComponentCount();
        return result;
      }
    public override string extraSportsInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryData)
          {
            if (remainder == 0)
                return "QueryData";
            --remainder;
          }
        if (flagHasRanks)
          {
            if (remainder == 0)
                return "Ranks";
            --remainder;
          }
        if (flagHasGames)
          {
            if (remainder == 0)
                return "Games";
            --remainder;
          }
        if (flagHasSeries)
          {
            if (remainder == 0)
                return "Series";
            --remainder;
          }
        return extraSportsPlayoffTriviaInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraSportsInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryData)
          {
            if (remainder == 0)
                return extraQueryDataToJSON();
            --remainder;
          }
        if (flagHasRanks)
          {
            if (remainder == 0)
                return extraRanksToJSON();
            --remainder;
          }
        if (flagHasGames)
          {
            if (remainder == 0)
                return extraGamesToJSON();
            --remainder;
          }
        if (flagHasSeries)
          {
            if (remainder == 0)
                return extraSeriesToJSON();
            --remainder;
          }
        return extraSportsPlayoffTriviaInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraSportsInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'G':
                if ((String.Compare(field_name, 1, "ames", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasGames ? extraGamesToJSON() : null);
                break;
            case 'Q':
                if ((String.Compare(field_name, 1, "ueryData", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasQueryData ? extraQueryDataToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "anks", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasRanks ? extraRanksToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "eries", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasSeries ? extraSeriesToJSON() : null);
                break;
            default:
                break;
          }
        return extraSportsPlayoffTriviaInformationNuggetLookup(field_name);
      }

    public void initQueryData()
      {
        if (flagHasQueryData)
          {
            for (int num1 = 0; num1 < storeQueryData.Count; ++num1)
              {
              }
          }
        flagHasQueryData = true;
        storeQueryData.Clear();
      }
    public void appendQueryData(SportsPlayoffTriviaInputDataJSON  to_append)
      {
        if (!flagHasQueryData)
          {
            flagHasQueryData = true;
            storeQueryData.Clear();
          }
        Debug.Assert(flagHasQueryData);
        storeQueryData.Add(to_append);
      }
    public void unsetQueryData()
      {
        if (flagHasQueryData)
          {
            for (int num2 = 0; num2 < storeQueryData.Count; ++num2)
              {
              }
          }
        flagHasQueryData = false;
        storeQueryData.Clear();
      }
    public void initRanks()
      {
        if (flagHasRanks)
          {
            for (int num3 = 0; num3 < storeRanks.Count; ++num3)
              {
              }
          }
        flagHasRanks = true;
        storeRanks.Clear();
      }
    public void appendRanks(SportsPlayoffTriviaRanksJSON  to_append)
      {
        if (!flagHasRanks)
          {
            flagHasRanks = true;
            storeRanks.Clear();
          }
        Debug.Assert(flagHasRanks);
        storeRanks.Add(to_append);
      }
    public void unsetRanks()
      {
        if (flagHasRanks)
          {
            for (int num4 = 0; num4 < storeRanks.Count; ++num4)
              {
              }
          }
        flagHasRanks = false;
        storeRanks.Clear();
      }
    public void initGames()
      {
        if (flagHasGames)
          {
            for (int num5 = 0; num5 < storeGames.Count; ++num5)
              {
              }
          }
        flagHasGames = true;
        storeGames.Clear();
      }
    public void appendGames(SportsGameJSON  to_append)
      {
        if (!flagHasGames)
          {
            flagHasGames = true;
            storeGames.Clear();
          }
        Debug.Assert(flagHasGames);
        storeGames.Add(to_append);
      }
    public void unsetGames()
      {
        if (flagHasGames)
          {
            for (int num6 = 0; num6 < storeGames.Count; ++num6)
              {
              }
          }
        flagHasGames = false;
        storeGames.Clear();
      }
    public void initSeries()
      {
        if (flagHasSeries)
          {
            for (int num7 = 0; num7 < storeSeries.Count; ++num7)
              {
              }
          }
        flagHasSeries = true;
        storeSeries.Clear();
      }
    public void appendSeries(SportsSeriesStatusNewJSON  to_append)
      {
        if (!flagHasSeries)
          {
            flagHasSeries = true;
            storeSeries.Clear();
          }
        Debug.Assert(flagHasSeries);
        storeSeries.Add(to_append);
      }
    public void unsetSeries()
      {
        if (flagHasSeries)
          {
            for (int num8 = 0; num8 < storeSeries.Count; ++num8)
              {
              }
          }
        flagHasSeries = false;
        storeSeries.Clear();
      }

    public virtual void extraSportsPlayoffTriviaInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsPlayoffTriviaInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsPlayoffTriviaInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraSportsPlayoffTriviaInformationNuggetAppendPair(key, new_component);
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
    public override void extraSportsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'G':
                if ((String.Compare(key, 1, "ames", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONGames(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryData", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONQueryData(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "anks", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONRanks(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "eries", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONSeries(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSportsPlayoffTriviaInformationNuggetAppendPair(key, new_component);
      }
    public override void extraSportsInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'G':
                if ((String.Compare(key, 1, "ames", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONGames(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryData", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONQueryData(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "anks", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONRanks(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "eries", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONSeries(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSportsPlayoffTriviaInformationNuggetSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasQueryData);
        if (flagHasQueryData)
          {
            handler.start_pair("QueryData");
            handler.start_array();
            for (int num1 = 0; num1 < storeQueryData.Count; ++num1)
              {
                if (partial_allowed)
                    storeQueryData[num1].write_partial_as_json(handler);
                else
                    storeQueryData[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRanks)
          {
            handler.start_pair("Ranks");
            handler.start_array();
            for (int num2 = 0; num2 < storeRanks.Count; ++num2)
              {
                if (partial_allowed)
                    storeRanks[num2].write_partial_as_json(handler);
                else
                    storeRanks[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasGames)
          {
            handler.start_pair("Games");
            handler.start_array();
            for (int num3 = 0; num3 < storeGames.Count; ++num3)
              {
                if (partial_allowed)
                    storeGames[num3].write_partial_as_json(handler);
                else
                    storeGames[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSeries)
          {
            handler.start_pair("Series");
            handler.start_array();
            for (int num4 = 0; num4 < storeSeries.Count; ++num4)
              {
                if (partial_allowed)
                    storeSeries[num4].write_partial_as_json(handler);
                else
                    storeSeries[num4].write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasQueryData()))
          {
            return "When parsing the object for %what%, the \"QueryData\" field was missing.";
          }
        return null;
      }

    public static new SportsPlayoffTriviaInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayoffTriviaInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaInformationNugget", ignore_extras);
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
    public static new SportsPlayoffTriviaInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsPlayoffTriviaInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayoffTriviaInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaInformationNugget", ignore_extras);
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
    public static new SportsPlayoffTriviaInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsPlayoffTriviaInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        SportsPlayoffTriviaInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsPlayoffTriviaInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsPlayoffTriviaInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsPlayoffTriviaInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsInformationNuggetJSON.Generator
      {
        private SportsPlayoffTriviaInputDataJSON.HoldingArrayGenerator fieldGeneratorQueryData;
        private SportsPlayoffTriviaRanksJSON.HoldingArrayGenerator fieldGeneratorRanks;
        private SportsGameJSON.HoldingArrayGenerator fieldGeneratorGames;
        private SportsSeriesStatusNewJSON.HoldingArrayGenerator fieldGeneratorSeries;
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
            if (!(getSportsInformationNuggetJSONKey().Equals("SportsPlayoffTrivia")))
                throw new Exception("The key field has a value other than `SportsPlayoffTrivia'.");
            SportsPlayoffTriviaInformationNuggetJSON result = new SportsPlayoffTriviaInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsPlayoffTriviaInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsInformationNuggetJSON new_result)
          {
            handle_result((SportsPlayoffTriviaInformationNuggetJSON )new_result);
          }
        protected void finish(SportsPlayoffTriviaInformationNuggetJSON result)
          {
            if (fieldGeneratorQueryData.have_value)
              {
                result.initQueryData();
                int count = fieldGeneratorQueryData.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendQueryData(fieldGeneratorQueryData.value[num]);
                  }
                fieldGeneratorQueryData.value.Clear();
                fieldGeneratorQueryData.have_value = false;
              }
            else if ((!(result.hasQueryData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryData\" field was missing.");
              }
            if (fieldGeneratorRanks.have_value)
              {
                result.initRanks();
                int count = fieldGeneratorRanks.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRanks(fieldGeneratorRanks.value[num]);
                  }
                fieldGeneratorRanks.value.Clear();
                fieldGeneratorRanks.have_value = false;
              }
            if (fieldGeneratorGames.have_value)
              {
                result.initGames();
                int count = fieldGeneratorGames.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGames(fieldGeneratorGames.value[num]);
                  }
                fieldGeneratorGames.value.Clear();
                fieldGeneratorGames.have_value = false;
              }
            if (fieldGeneratorSeries.have_value)
              {
                result.initSeries();
                int count = fieldGeneratorSeries.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSeries(fieldGeneratorSeries.value[num]);
                  }
                fieldGeneratorSeries.value.Clear();
                fieldGeneratorSeries.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsPlayoffTriviaInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'G':
                    if ((String.Compare(field_name, 1, "ames", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorGames;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryData", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorQueryData;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "anks", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorRanks;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "eries", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorSeries;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorQueryData = new SportsPlayoffTriviaInputDataJSON.HoldingArrayGenerator("field \"QueryData\" of the SportsPlayoffTriviaInformationNugget class", ignore_extras);
            fieldGeneratorRanks = new SportsPlayoffTriviaRanksJSON.HoldingArrayGenerator("field \"Ranks\" of the SportsPlayoffTriviaInformationNugget class", ignore_extras);
            fieldGeneratorGames = new SportsGameJSON.HoldingArrayGenerator("field \"Games\" of the SportsPlayoffTriviaInformationNugget class", ignore_extras);
            fieldGeneratorSeries = new SportsSeriesStatusNewJSON.HoldingArrayGenerator("field \"Series\" of the SportsPlayoffTriviaInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsPlayoffTriviaInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorQueryData = new SportsPlayoffTriviaInputDataJSON.HoldingArrayGenerator("field \"QueryData\" of the SportsPlayoffTriviaInformationNugget class", false);
            fieldGeneratorRanks = new SportsPlayoffTriviaRanksJSON.HoldingArrayGenerator("field \"Ranks\" of the SportsPlayoffTriviaInformationNugget class", false);
            fieldGeneratorGames = new SportsGameJSON.HoldingArrayGenerator("field \"Games\" of the SportsPlayoffTriviaInformationNugget class", false);
            fieldGeneratorSeries = new SportsSeriesStatusNewJSON.HoldingArrayGenerator("field \"Series\" of the SportsPlayoffTriviaInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsPlayoffTriviaInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorQueryData.reset();
            fieldGeneratorRanks.reset();
            fieldGeneratorGames.reset();
            fieldGeneratorSeries.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsPlayoffTriviaInformationNuggetJSON  result)
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
        public SportsPlayoffTriviaInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsPlayoffTriviaInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<SportsPlayoffTriviaInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsPlayoffTriviaInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsPlayoffTriviaInformationNuggetJSON>();
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
    public List<SportsPlayoffTriviaInformationNuggetJSON> value;
  };
  };
