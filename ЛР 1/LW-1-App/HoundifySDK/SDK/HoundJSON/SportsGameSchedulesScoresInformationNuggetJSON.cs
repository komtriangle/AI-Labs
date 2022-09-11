/* file "SportsGameSchedulesScoresInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsGameSchedulesScoresInformationNuggetJSON : SportsInformationNuggetJSON
  {
    private bool flagHasQueryData;
    private List< SportsGameSchedulesScoresQueryDataJSON  > storeQueryData;
    private bool flagHasGames;
    private List< SportsGameJSON  > storeGames;
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

    private JSONValue  extraGamesToJSON()
      {
        JSONArrayValue generated_array_2_Games = new JSONArrayValue();
        for (int num2 = 0; num2 < storeGames.Count; ++num2)
          {
            JSONValueHandler handler_Games = new JSONValueHandler();
            storeGames[num2].write_as_json(handler_Games);
            generated_array_2_Games.appendComponent(handler_Games.result);
          }
        return generated_array_2_Games;
      }


    private void  fromJSONQueryData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field QueryData of SportsGameSchedulesScoresInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field QueryData of SportsGameSchedulesScoresInformationNuggetJSON has too few elements.");
        List< SportsGameSchedulesScoresQueryDataJSON  > vector_QueryData1 = new List< SportsGameSchedulesScoresQueryDataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsGameSchedulesScoresQueryDataJSON convert_classy = SportsGameSchedulesScoresQueryDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_QueryData1.Add(convert_classy);
          }
        Debug.Assert(vector_QueryData1.Count >= 1);
        initQueryData();
        for (int num1 = 0; num1 < vector_QueryData1.Count; ++num1)
            appendQueryData(vector_QueryData1[num1]);
        for (int num1 = 0; num1 < vector_QueryData1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGames(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Games of SportsGameSchedulesScoresInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Games of SportsGameSchedulesScoresInformationNuggetJSON has too few elements.");
        List< SportsGameJSON  > vector_Games1 = new List< SportsGameJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsGameJSON convert_classy = SportsGameJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Games1.Add(convert_classy);
          }
        Debug.Assert(vector_Games1.Count >= 1);
        initGames();
        for (int num2 = 0; num2 < vector_Games1.Count; ++num2)
            appendGames(vector_Games1[num2]);
        for (int num1 = 0; num1 < vector_Games1.Count; ++num1)
          {
          }
      }


    public SportsGameSchedulesScoresInformationNuggetJSON()
      {
        flagHasQueryData = false;
        flagHasGames = false;
        storeQueryData = new List< SportsGameSchedulesScoresQueryDataJSON  >();
        storeGames = new List< SportsGameJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsNuggetKind()
      {
        return "SportsGameSchedulesScores";
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

    public SportsGameSchedulesScoresQueryDataJSON   elementOfQueryData(int element_num)
      {
        Debug.Assert(flagHasQueryData);
        return storeQueryData[element_num];
      }

    public List< SportsGameSchedulesScoresQueryDataJSON  >  getQueryData()
      {
        Debug.Assert(flagHasQueryData);
        return storeQueryData;
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


    public virtual int extraSportsGameSchedulesScoresInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsGameSchedulesScoresInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsGameSchedulesScoresInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsGameSchedulesScoresInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasQueryData)
            ++result;
        if (flagHasGames)
            ++result;
        result += extraSportsGameSchedulesScoresInformationNuggetComponentCount();
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
        if (flagHasGames)
          {
            if (remainder == 0)
                return "Games";
            --remainder;
          }
        return extraSportsGameSchedulesScoresInformationNuggetComponentKey(remainder);
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
        if (flagHasGames)
          {
            if (remainder == 0)
                return extraGamesToJSON();
            --remainder;
          }
        return extraSportsGameSchedulesScoresInformationNuggetComponentValue(remainder);
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
            default:
                break;
          }
        return extraSportsGameSchedulesScoresInformationNuggetLookup(field_name);
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
    public void appendQueryData(SportsGameSchedulesScoresQueryDataJSON  to_append)
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
    public void initGames()
      {
        if (flagHasGames)
          {
            for (int num3 = 0; num3 < storeGames.Count; ++num3)
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
            for (int num4 = 0; num4 < storeGames.Count; ++num4)
              {
              }
          }
        flagHasGames = false;
        storeGames.Clear();
      }

    public virtual void extraSportsGameSchedulesScoresInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsGameSchedulesScoresInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsGameSchedulesScoresInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraSportsGameSchedulesScoresInformationNuggetAppendPair(key, new_component);
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
            default:
                break;
          }
        extraSportsGameSchedulesScoresInformationNuggetAppendPair(key, new_component);
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
            default:
                break;
          }
        extraSportsGameSchedulesScoresInformationNuggetSetField(key, new_component);
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
            Debug.Assert(storeQueryData.Count >= 1);
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
        if (flagHasGames)
          {
            handler.start_pair("Games");
            Debug.Assert(storeGames.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeGames.Count; ++num2)
              {
                if (partial_allowed)
                    storeGames[num2].write_partial_as_json(handler);
                else
                    storeGames[num2].write_as_json(handler);
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

    public static new SportsGameSchedulesScoresInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsGameSchedulesScoresInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGameSchedulesScoresInformationNugget", ignore_extras);
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
    public static new SportsGameSchedulesScoresInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsGameSchedulesScoresInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsGameSchedulesScoresInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGameSchedulesScoresInformationNugget", ignore_extras);
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
    public static new SportsGameSchedulesScoresInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsGameSchedulesScoresInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        SportsGameSchedulesScoresInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGameSchedulesScoresInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsGameSchedulesScoresInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsGameSchedulesScoresInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsGameSchedulesScoresInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGameSchedulesScoresInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsInformationNuggetJSON.Generator
      {
        private SportsGameSchedulesScoresQueryDataJSON.HoldingArrayGenerator fieldGeneratorQueryData;
        private SportsGameJSON.HoldingArrayGenerator fieldGeneratorGames;
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
            if (!(getSportsInformationNuggetJSONKey().Equals("SportsGameSchedulesScores")))
                throw new Exception("The key field has a value other than `SportsGameSchedulesScores'.");
            SportsGameSchedulesScoresInformationNuggetJSON result = new SportsGameSchedulesScoresInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsGameSchedulesScoresInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsInformationNuggetJSON new_result)
          {
            handle_result((SportsGameSchedulesScoresInformationNuggetJSON )new_result);
          }
        protected void finish(SportsGameSchedulesScoresInformationNuggetJSON result)
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
            base.finish(result);
          }
        protected abstract void handle_result(SportsGameSchedulesScoresInformationNuggetJSON new_result);
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
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorQueryData = new SportsGameSchedulesScoresQueryDataJSON.HoldingArrayGenerator("field \"QueryData\" of the SportsGameSchedulesScoresInformationNugget class", ignore_extras);
            fieldGeneratorGames = new SportsGameJSON.HoldingArrayGenerator("field \"Games\" of the SportsGameSchedulesScoresInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsGameSchedulesScoresInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorQueryData = new SportsGameSchedulesScoresQueryDataJSON.HoldingArrayGenerator("field \"QueryData\" of the SportsGameSchedulesScoresInformationNugget class", false);
            fieldGeneratorGames = new SportsGameJSON.HoldingArrayGenerator("field \"Games\" of the SportsGameSchedulesScoresInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsGameSchedulesScoresInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorQueryData.reset();
            fieldGeneratorGames.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsGameSchedulesScoresInformationNuggetJSON  result)
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
        public SportsGameSchedulesScoresInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsGameSchedulesScoresInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<SportsGameSchedulesScoresInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsGameSchedulesScoresInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsGameSchedulesScoresInformationNuggetJSON>();
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
    public List<SportsGameSchedulesScoresInformationNuggetJSON> value;
  };
  };
