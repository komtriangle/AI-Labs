/* file "SportsLeagueLeadersInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsLeagueLeadersInformationNuggetJSON : SportsInformationNuggetJSON
  {
    private bool flagHasQueryData;
    private List< SportsLeagueLeadersQueryDataJSON  > storeQueryData;
    private bool flagHasLeagueLeaders;
    private List< SportsLeagueLeadersJSON  > storeLeagueLeaders;
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

    private JSONValue  extraLeagueLeadersToJSON()
      {
        JSONArrayValue generated_array_2_LeagueLeaders = new JSONArrayValue();
        for (int num2 = 0; num2 < storeLeagueLeaders.Count; ++num2)
          {
            JSONValueHandler handler_LeagueLeaders = new JSONValueHandler();
            storeLeagueLeaders[num2].write_as_json(handler_LeagueLeaders);
            generated_array_2_LeagueLeaders.appendComponent(handler_LeagueLeaders.result);
          }
        return generated_array_2_LeagueLeaders;
      }


    private void  fromJSONQueryData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field QueryData of SportsLeagueLeadersInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field QueryData of SportsLeagueLeadersInformationNuggetJSON has too few elements.");
        List< SportsLeagueLeadersQueryDataJSON  > vector_QueryData1 = new List< SportsLeagueLeadersQueryDataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsLeagueLeadersQueryDataJSON convert_classy = SportsLeagueLeadersQueryDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
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


    private void  fromJSONLeagueLeaders(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field LeagueLeaders of SportsLeagueLeadersInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field LeagueLeaders of SportsLeagueLeadersInformationNuggetJSON has too few elements.");
        List< SportsLeagueLeadersJSON  > vector_LeagueLeaders1 = new List< SportsLeagueLeadersJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsLeagueLeadersJSON convert_classy = SportsLeagueLeadersJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_LeagueLeaders1.Add(convert_classy);
          }
        Debug.Assert(vector_LeagueLeaders1.Count >= 1);
        initLeagueLeaders();
        for (int num2 = 0; num2 < vector_LeagueLeaders1.Count; ++num2)
            appendLeagueLeaders(vector_LeagueLeaders1[num2]);
        for (int num1 = 0; num1 < vector_LeagueLeaders1.Count; ++num1)
          {
          }
      }


    public SportsLeagueLeadersInformationNuggetJSON()
      {
        flagHasQueryData = false;
        flagHasLeagueLeaders = false;
        storeQueryData = new List< SportsLeagueLeadersQueryDataJSON  >();
        storeLeagueLeaders = new List< SportsLeagueLeadersJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsNuggetKind()
      {
        return "SportsLeagueLeaders";
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

    public SportsLeagueLeadersQueryDataJSON   elementOfQueryData(int element_num)
      {
        Debug.Assert(flagHasQueryData);
        return storeQueryData[element_num];
      }

    public List< SportsLeagueLeadersQueryDataJSON  >  getQueryData()
      {
        Debug.Assert(flagHasQueryData);
        return storeQueryData;
      }

    public bool  hasLeagueLeaders()
      {
        return flagHasLeagueLeaders;
      }

    public int  countOfLeagueLeaders()
      {
        Debug.Assert(flagHasLeagueLeaders);
        return storeLeagueLeaders.Count;
      }

    public SportsLeagueLeadersJSON   elementOfLeagueLeaders(int element_num)
      {
        Debug.Assert(flagHasLeagueLeaders);
        return storeLeagueLeaders[element_num];
      }

    public List< SportsLeagueLeadersJSON  >  getLeagueLeaders()
      {
        Debug.Assert(flagHasLeagueLeaders);
        return storeLeagueLeaders;
      }


    public virtual int extraSportsLeagueLeadersInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsLeagueLeadersInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsLeagueLeadersInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsLeagueLeadersInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasQueryData)
            ++result;
        if (flagHasLeagueLeaders)
            ++result;
        result += extraSportsLeagueLeadersInformationNuggetComponentCount();
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
        if (flagHasLeagueLeaders)
          {
            if (remainder == 0)
                return "LeagueLeaders";
            --remainder;
          }
        return extraSportsLeagueLeadersInformationNuggetComponentKey(remainder);
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
        if (flagHasLeagueLeaders)
          {
            if (remainder == 0)
                return extraLeagueLeadersToJSON();
            --remainder;
          }
        return extraSportsLeagueLeadersInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraSportsInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'L':
                if ((String.Compare(field_name, 1, "eagueLeaders", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasLeagueLeaders ? extraLeagueLeadersToJSON() : null);
                break;
            case 'Q':
                if ((String.Compare(field_name, 1, "ueryData", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasQueryData ? extraQueryDataToJSON() : null);
                break;
            default:
                break;
          }
        return extraSportsLeagueLeadersInformationNuggetLookup(field_name);
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
    public void appendQueryData(SportsLeagueLeadersQueryDataJSON  to_append)
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
    public void initLeagueLeaders()
      {
        if (flagHasLeagueLeaders)
          {
            for (int num3 = 0; num3 < storeLeagueLeaders.Count; ++num3)
              {
              }
          }
        flagHasLeagueLeaders = true;
        storeLeagueLeaders.Clear();
      }
    public void appendLeagueLeaders(SportsLeagueLeadersJSON  to_append)
      {
        if (!flagHasLeagueLeaders)
          {
            flagHasLeagueLeaders = true;
            storeLeagueLeaders.Clear();
          }
        Debug.Assert(flagHasLeagueLeaders);
        storeLeagueLeaders.Add(to_append);
      }
    public void unsetLeagueLeaders()
      {
        if (flagHasLeagueLeaders)
          {
            for (int num4 = 0; num4 < storeLeagueLeaders.Count; ++num4)
              {
              }
          }
        flagHasLeagueLeaders = false;
        storeLeagueLeaders.Clear();
      }

    public virtual void extraSportsLeagueLeadersInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsLeagueLeadersInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsLeagueLeadersInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraSportsLeagueLeadersInformationNuggetAppendPair(key, new_component);
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
            case 'L':
                if ((String.Compare(key, 1, "eagueLeaders", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONLeagueLeaders(new_component, false);
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
        extraSportsLeagueLeadersInformationNuggetAppendPair(key, new_component);
      }
    public override void extraSportsInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'L':
                if ((String.Compare(key, 1, "eagueLeaders", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONLeagueLeaders(new_component, false);
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
        extraSportsLeagueLeadersInformationNuggetSetField(key, new_component);
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
        if (flagHasLeagueLeaders)
          {
            handler.start_pair("LeagueLeaders");
            Debug.Assert(storeLeagueLeaders.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeLeagueLeaders.Count; ++num2)
              {
                if (partial_allowed)
                    storeLeagueLeaders[num2].write_partial_as_json(handler);
                else
                    storeLeagueLeaders[num2].write_as_json(handler);
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

    public static new SportsLeagueLeadersInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsLeagueLeadersInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueLeadersInformationNugget", ignore_extras);
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
    public static new SportsLeagueLeadersInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsLeagueLeadersInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsLeagueLeadersInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueLeadersInformationNugget", ignore_extras);
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
    public static new SportsLeagueLeadersInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsLeagueLeadersInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        SportsLeagueLeadersInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueLeadersInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsLeagueLeadersInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsLeagueLeadersInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsLeagueLeadersInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueLeadersInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsInformationNuggetJSON.Generator
      {
        private SportsLeagueLeadersQueryDataJSON.HoldingArrayGenerator fieldGeneratorQueryData;
        private SportsLeagueLeadersJSON.HoldingArrayGenerator fieldGeneratorLeagueLeaders;
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
            if (!(getSportsInformationNuggetJSONKey().Equals("SportsLeagueLeaders")))
                throw new Exception("The key field has a value other than `SportsLeagueLeaders'.");
            SportsLeagueLeadersInformationNuggetJSON result = new SportsLeagueLeadersInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsLeagueLeadersInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsInformationNuggetJSON new_result)
          {
            handle_result((SportsLeagueLeadersInformationNuggetJSON )new_result);
          }
        protected void finish(SportsLeagueLeadersInformationNuggetJSON result)
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
            if (fieldGeneratorLeagueLeaders.have_value)
              {
                result.initLeagueLeaders();
                int count = fieldGeneratorLeagueLeaders.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendLeagueLeaders(fieldGeneratorLeagueLeaders.value[num]);
                  }
                fieldGeneratorLeagueLeaders.value.Clear();
                fieldGeneratorLeagueLeaders.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsLeagueLeadersInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'L':
                    if ((String.Compare(field_name, 1, "eagueLeaders", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorLeagueLeaders;
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
            fieldGeneratorQueryData = new SportsLeagueLeadersQueryDataJSON.HoldingArrayGenerator("field \"QueryData\" of the SportsLeagueLeadersInformationNugget class", ignore_extras);
            fieldGeneratorLeagueLeaders = new SportsLeagueLeadersJSON.HoldingArrayGenerator("field \"LeagueLeaders\" of the SportsLeagueLeadersInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsLeagueLeadersInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorQueryData = new SportsLeagueLeadersQueryDataJSON.HoldingArrayGenerator("field \"QueryData\" of the SportsLeagueLeadersInformationNugget class", false);
            fieldGeneratorLeagueLeaders = new SportsLeagueLeadersJSON.HoldingArrayGenerator("field \"LeagueLeaders\" of the SportsLeagueLeadersInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsLeagueLeadersInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorQueryData.reset();
            fieldGeneratorLeagueLeaders.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsLeagueLeadersInformationNuggetJSON  result)
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
        public SportsLeagueLeadersInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsLeagueLeadersInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<SportsLeagueLeadersInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsLeagueLeadersInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsLeagueLeadersInformationNuggetJSON>();
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
    public List<SportsLeagueLeadersInformationNuggetJSON> value;
  };
  };
