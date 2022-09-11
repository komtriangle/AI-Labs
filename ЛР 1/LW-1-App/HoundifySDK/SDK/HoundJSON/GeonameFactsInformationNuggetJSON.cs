/* file "GeonameFactsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class GeonameFactsInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasInputData;
    private List< GeonameFactsInputDataJSON  > storeInputData;
    private bool flagHasResults;
    private List< GeonameObjectJSON  > storeResults;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraInputDataToJSON()
      {
        JSONArrayValue generated_array_1_InputData = new JSONArrayValue();
        for (int num1 = 0; num1 < storeInputData.Count; ++num1)
          {
            JSONValueHandler handler_InputData = new JSONValueHandler();
            storeInputData[num1].write_as_json(handler_InputData);
            generated_array_1_InputData.appendComponent(handler_InputData.result);
          }
        return generated_array_1_InputData;
      }

    private JSONValue  extraResultsToJSON()
      {
        JSONArrayValue generated_array_2_Results = new JSONArrayValue();
        for (int num2 = 0; num2 < storeResults.Count; ++num2)
          {
            JSONValueHandler handler_Results = new JSONValueHandler();
            storeResults[num2].write_as_json(handler_Results);
            generated_array_2_Results.appendComponent(handler_Results.result);
          }
        return generated_array_2_Results;
      }


    private void  fromJSONInputData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InputData of GeonameFactsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< GeonameFactsInputDataJSON  > vector_InputData1 = new List< GeonameFactsInputDataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            GeonameFactsInputDataJSON convert_classy = GeonameFactsInputDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_InputData1.Add(convert_classy);
          }
        initInputData();
        for (int num1 = 0; num1 < vector_InputData1.Count; ++num1)
            appendInputData(vector_InputData1[num1]);
        for (int num1 = 0; num1 < vector_InputData1.Count; ++num1)
          {
          }
      }


    private void  fromJSONResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Results of GeonameFactsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< GeonameObjectJSON  > vector_Results1 = new List< GeonameObjectJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            GeonameObjectJSON convert_classy = GeonameObjectJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Results1.Add(convert_classy);
          }
        initResults();
        for (int num2 = 0; num2 < vector_Results1.Count; ++num2)
            appendResults(vector_Results1[num2]);
        for (int num1 = 0; num1 < vector_Results1.Count; ++num1)
          {
          }
      }


    public GeonameFactsInformationNuggetJSON()
      {
        flagHasInputData = false;
        flagHasResults = false;
        storeInputData = new List< GeonameFactsInputDataJSON  >();
        storeResults = new List< GeonameObjectJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "GeonameFacts";
      }

    public bool  hasInputData()
      {
        return flagHasInputData;
      }

    public int  countOfInputData()
      {
        Debug.Assert(flagHasInputData);
        return storeInputData.Count;
      }

    public GeonameFactsInputDataJSON   elementOfInputData(int element_num)
      {
        Debug.Assert(flagHasInputData);
        return storeInputData[element_num];
      }

    public List< GeonameFactsInputDataJSON  >  getInputData()
      {
        Debug.Assert(flagHasInputData);
        return storeInputData;
      }

    public bool  hasResults()
      {
        return flagHasResults;
      }

    public int  countOfResults()
      {
        Debug.Assert(flagHasResults);
        return storeResults.Count;
      }

    public GeonameObjectJSON   elementOfResults(int element_num)
      {
        Debug.Assert(flagHasResults);
        return storeResults[element_num];
      }

    public List< GeonameObjectJSON  >  getResults()
      {
        Debug.Assert(flagHasResults);
        return storeResults;
      }


    public virtual int extraGeonameFactsInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraGeonameFactsInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraGeonameFactsInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraGeonameFactsInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasInputData)
            ++result;
        if (flagHasResults)
            ++result;
        result += extraGeonameFactsInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasInputData)
          {
            if (remainder == 0)
                return "InputData";
            --remainder;
          }
        if (flagHasResults)
          {
            if (remainder == 0)
                return "Results";
            --remainder;
          }
        return extraGeonameFactsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasInputData)
          {
            if (remainder == 0)
                return extraInputDataToJSON();
            --remainder;
          }
        if (flagHasResults)
          {
            if (remainder == 0)
                return extraResultsToJSON();
            --remainder;
          }
        return extraGeonameFactsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'I':
                if ((String.Compare(field_name, 1, "nputData", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasInputData ? extraInputDataToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "esults", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasResults ? extraResultsToJSON() : null);
                break;
            default:
                break;
          }
        return extraGeonameFactsInformationNuggetLookup(field_name);
      }

    public void initInputData()
      {
        if (flagHasInputData)
          {
            for (int num1 = 0; num1 < storeInputData.Count; ++num1)
              {
              }
          }
        flagHasInputData = true;
        storeInputData.Clear();
      }
    public void appendInputData(GeonameFactsInputDataJSON  to_append)
      {
        if (!flagHasInputData)
          {
            flagHasInputData = true;
            storeInputData.Clear();
          }
        Debug.Assert(flagHasInputData);
        storeInputData.Add(to_append);
      }
    public void unsetInputData()
      {
        if (flagHasInputData)
          {
            for (int num2 = 0; num2 < storeInputData.Count; ++num2)
              {
              }
          }
        flagHasInputData = false;
        storeInputData.Clear();
      }
    public void initResults()
      {
        if (flagHasResults)
          {
            for (int num3 = 0; num3 < storeResults.Count; ++num3)
              {
              }
          }
        flagHasResults = true;
        storeResults.Clear();
      }
    public void appendResults(GeonameObjectJSON  to_append)
      {
        if (!flagHasResults)
          {
            flagHasResults = true;
            storeResults.Clear();
          }
        Debug.Assert(flagHasResults);
        storeResults.Add(to_append);
      }
    public void unsetResults()
      {
        if (flagHasResults)
          {
            for (int num4 = 0; num4 < storeResults.Count; ++num4)
              {
              }
          }
        flagHasResults = false;
        storeResults.Clear();
      }

    public virtual void extraGeonameFactsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraGeonameFactsInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraGeonameFactsInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraGeonameFactsInformationNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "nputData", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONInputData(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "esults", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONResults(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraGeonameFactsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "nputData", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONInputData(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "esults", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONResults(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraGeonameFactsInformationNuggetSetField(key, new_component);
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
        if (flagHasInputData)
          {
            handler.start_pair("InputData");
            handler.start_array();
            for (int num1 = 0; num1 < storeInputData.Count; ++num1)
              {
                if (partial_allowed)
                    storeInputData[num1].write_partial_as_json(handler);
                else
                    storeInputData[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasResults)
          {
            handler.start_pair("Results");
            handler.start_array();
            for (int num2 = 0; num2 < storeResults.Count; ++num2)
              {
                if (partial_allowed)
                    storeResults[num2].write_partial_as_json(handler);
                else
                    storeResults[num2].write_as_json(handler);
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
        return null;
      }

    public static new GeonameFactsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeonameFactsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameFactsInformationNugget", ignore_extras);
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
    public static new GeonameFactsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GeonameFactsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeonameFactsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameFactsInformationNugget", ignore_extras);
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
    public static new GeonameFactsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GeonameFactsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        GeonameFactsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameFactsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GeonameFactsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new GeonameFactsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GeonameFactsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameFactsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private GeonameFactsInputDataJSON.HoldingArrayGenerator fieldGeneratorInputData;
        private GeonameObjectJSON.HoldingArrayGenerator fieldGeneratorResults;
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
            if (!(getInformationNuggetJSONKey().Equals("GeonameFacts")))
                throw new Exception("The key field has a value other than `GeonameFacts'.");
            GeonameFactsInformationNuggetJSON result = new GeonameFactsInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGeonameFactsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((GeonameFactsInformationNuggetJSON )new_result);
          }
        protected void finish(GeonameFactsInformationNuggetJSON result)
          {
            if (fieldGeneratorInputData.have_value)
              {
                result.initInputData();
                int count = fieldGeneratorInputData.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInputData(fieldGeneratorInputData.value[num]);
                  }
                fieldGeneratorInputData.value.Clear();
                fieldGeneratorInputData.have_value = false;
              }
            if (fieldGeneratorResults.have_value)
              {
                result.initResults();
                int count = fieldGeneratorResults.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendResults(fieldGeneratorResults.value[num]);
                  }
                fieldGeneratorResults.value.Clear();
                fieldGeneratorResults.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(GeonameFactsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "nputData", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorInputData;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "esults", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorResults;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorInputData = new GeonameFactsInputDataJSON.HoldingArrayGenerator("field \"InputData\" of the GeonameFactsInformationNugget class", ignore_extras);
            fieldGeneratorResults = new GeonameObjectJSON.HoldingArrayGenerator("field \"Results\" of the GeonameFactsInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the GeonameFactsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorInputData = new GeonameFactsInputDataJSON.HoldingArrayGenerator("field \"InputData\" of the GeonameFactsInformationNugget class", false);
            fieldGeneratorResults = new GeonameObjectJSON.HoldingArrayGenerator("field \"Results\" of the GeonameFactsInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the GeonameFactsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorInputData.reset();
            fieldGeneratorResults.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(GeonameFactsInformationNuggetJSON  result)
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
        public GeonameFactsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GeonameFactsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<GeonameFactsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GeonameFactsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GeonameFactsInformationNuggetJSON>();
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
    public List<GeonameFactsInformationNuggetJSON> value;
  };
  };
