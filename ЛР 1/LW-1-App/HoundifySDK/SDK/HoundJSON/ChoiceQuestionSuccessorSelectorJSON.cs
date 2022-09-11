/* file "ChoiceQuestionSuccessorSelectorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ChoiceQuestionSuccessorSelectorJSON : SurveyGraphNodeSuccessorSelectorJSON
  {
    private bool flagHasAnswerOptions;
    private List< AnswerOptionsJSON  > storeAnswerOptions;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraAnswerOptionsToJSON()
      {
        JSONArrayValue generated_array_1_AnswerOptions = new JSONArrayValue();
        for (int num1 = 0; num1 < storeAnswerOptions.Count; ++num1)
          {
            JSONValueHandler handler_AnswerOptions = new JSONValueHandler();
            storeAnswerOptions[num1].write_as_json(handler_AnswerOptions);
            generated_array_1_AnswerOptions.appendComponent(handler_AnswerOptions.result);
          }
        return generated_array_1_AnswerOptions;
      }


    private void  fromJSONAnswerOptions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AnswerOptions of ChoiceQuestionSuccessorSelectorJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< AnswerOptionsJSON  > vector_AnswerOptions1 = new List< AnswerOptionsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AnswerOptionsJSON convert_classy = AnswerOptionsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AnswerOptions1.Add(convert_classy);
          }
        initAnswerOptions();
        for (int num1 = 0; num1 < vector_AnswerOptions1.Count; ++num1)
            appendAnswerOptions(vector_AnswerOptions1[num1]);
        for (int num1 = 0; num1 < vector_AnswerOptions1.Count; ++num1)
          {
          }
      }


    public ChoiceQuestionSuccessorSelectorJSON()
      {
        flagHasAnswerOptions = false;
        storeAnswerOptions = new List< AnswerOptionsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getQuestionType()
      {
        return "SurveyChoiceQuestion";
      }

    public bool  hasAnswerOptions()
      {
        return flagHasAnswerOptions;
      }

    public int  countOfAnswerOptions()
      {
        Debug.Assert(flagHasAnswerOptions);
        return storeAnswerOptions.Count;
      }

    public AnswerOptionsJSON   elementOfAnswerOptions(int element_num)
      {
        Debug.Assert(flagHasAnswerOptions);
        return storeAnswerOptions[element_num];
      }

    public List< AnswerOptionsJSON  >  getAnswerOptions()
      {
        Debug.Assert(flagHasAnswerOptions);
        return storeAnswerOptions;
      }


    public virtual int extraChoiceQuestionSuccessorSelectorComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraChoiceQuestionSuccessorSelectorComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraChoiceQuestionSuccessorSelectorComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraChoiceQuestionSuccessorSelectorLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSurveyGraphNodeSuccessorSelectorComponentCount()
      {
        int result = 0;
        if (flagHasAnswerOptions)
            ++result;
        result += extraChoiceQuestionSuccessorSelectorComponentCount();
        return result;
      }
    public override string extraSurveyGraphNodeSuccessorSelectorComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAnswerOptions)
          {
            if (remainder == 0)
                return "AnswerOptions";
            --remainder;
          }
        return extraChoiceQuestionSuccessorSelectorComponentKey(remainder);
      }
    public override JSONValue extraSurveyGraphNodeSuccessorSelectorComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAnswerOptions)
          {
            if (remainder == 0)
                return extraAnswerOptionsToJSON();
            --remainder;
          }
        return extraChoiceQuestionSuccessorSelectorComponentValue(remainder);
      }
    public override JSONValue extraSurveyGraphNodeSuccessorSelectorLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "AnswerOptions", 0, 13, false) == 0) && (field_name.Length == 13))
            return (flagHasAnswerOptions ? extraAnswerOptionsToJSON() : null);
        return extraChoiceQuestionSuccessorSelectorLookup(field_name);
      }

    public void initAnswerOptions()
      {
        if (flagHasAnswerOptions)
          {
            for (int num1 = 0; num1 < storeAnswerOptions.Count; ++num1)
              {
              }
          }
        flagHasAnswerOptions = true;
        storeAnswerOptions.Clear();
      }
    public void appendAnswerOptions(AnswerOptionsJSON  to_append)
      {
        if (!flagHasAnswerOptions)
          {
            flagHasAnswerOptions = true;
            storeAnswerOptions.Clear();
          }
        Debug.Assert(flagHasAnswerOptions);
        storeAnswerOptions.Add(to_append);
      }
    public void unsetAnswerOptions()
      {
        if (flagHasAnswerOptions)
          {
            for (int num2 = 0; num2 < storeAnswerOptions.Count; ++num2)
              {
              }
          }
        flagHasAnswerOptions = false;
        storeAnswerOptions.Clear();
      }

    public virtual void extraChoiceQuestionSuccessorSelectorAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraChoiceQuestionSuccessorSelectorSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraChoiceQuestionSuccessorSelectorLookup(key);
        if (old_field == null)
          {
            extraChoiceQuestionSuccessorSelectorAppendPair(key, new_component);
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
    public override void extraSurveyGraphNodeSuccessorSelectorAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "AnswerOptions", 0, 13, false) == 0) && (key.Length == 13))
            {
            fromJSONAnswerOptions(new_component, false);
            return;
            }
        extraChoiceQuestionSuccessorSelectorAppendPair(key, new_component);
      }
    public override void extraSurveyGraphNodeSuccessorSelectorSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "AnswerOptions", 0, 13, false) == 0) && (key.Length == 13))
            {
            fromJSONAnswerOptions(new_component, false);
            return;
            }
        extraChoiceQuestionSuccessorSelectorSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasAnswerOptions);
        if (flagHasAnswerOptions)
          {
            handler.start_pair("AnswerOptions");
            handler.start_array();
            for (int num1 = 0; num1 < storeAnswerOptions.Count; ++num1)
              {
                if (partial_allowed)
                    storeAnswerOptions[num1].write_partial_as_json(handler);
                else
                    storeAnswerOptions[num1].write_as_json(handler);
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
        if (!(hasAnswerOptions()))
          {
            return "When parsing the object for %what%, the \"AnswerOptions\" field was missing.";
          }
        return null;
      }

    public static new ChoiceQuestionSuccessorSelectorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChoiceQuestionSuccessorSelectorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChoiceQuestionSuccessorSelector", ignore_extras);
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
    public static new ChoiceQuestionSuccessorSelectorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ChoiceQuestionSuccessorSelectorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChoiceQuestionSuccessorSelectorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChoiceQuestionSuccessorSelector", ignore_extras);
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
    public static new ChoiceQuestionSuccessorSelectorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ChoiceQuestionSuccessorSelectorJSON from_text(string text, bool ignore_extras)
      {
        ChoiceQuestionSuccessorSelectorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChoiceQuestionSuccessorSelector", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ChoiceQuestionSuccessorSelectorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ChoiceQuestionSuccessorSelectorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ChoiceQuestionSuccessorSelectorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChoiceQuestionSuccessorSelector", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SurveyGraphNodeSuccessorSelectorJSON.Generator
      {
        private AnswerOptionsJSON.HoldingArrayGenerator fieldGeneratorAnswerOptions;
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
            if (!(getSurveyGraphNodeSuccessorSelectorJSONKey().Equals("SurveyChoiceQuestion")))
                throw new Exception("The key field has a value other than `SurveyChoiceQuestion'.");
            ChoiceQuestionSuccessorSelectorJSON result = new ChoiceQuestionSuccessorSelectorJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraChoiceQuestionSuccessorSelectorAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SurveyGraphNodeSuccessorSelectorJSON new_result)
          {
            handle_result((ChoiceQuestionSuccessorSelectorJSON )new_result);
          }
        protected void finish(ChoiceQuestionSuccessorSelectorJSON result)
          {
            if (fieldGeneratorAnswerOptions.have_value)
              {
                result.initAnswerOptions();
                int count = fieldGeneratorAnswerOptions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAnswerOptions(fieldGeneratorAnswerOptions.value[num]);
                  }
                fieldGeneratorAnswerOptions.value.Clear();
                fieldGeneratorAnswerOptions.have_value = false;
              }
            else if ((!(result.hasAnswerOptions())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AnswerOptions\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ChoiceQuestionSuccessorSelectorJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "AnswerOptions", 0, 13, false) == 0) && (field_name.Length == 13))
                return fieldGeneratorAnswerOptions;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAnswerOptions = new AnswerOptionsJSON.HoldingArrayGenerator("field \"AnswerOptions\" of the ChoiceQuestionSuccessorSelector class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ChoiceQuestionSuccessorSelector class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAnswerOptions = new AnswerOptionsJSON.HoldingArrayGenerator("field \"AnswerOptions\" of the ChoiceQuestionSuccessorSelector class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ChoiceQuestionSuccessorSelector class");
          }

        public override void reset()
          {
            fieldGeneratorAnswerOptions.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ChoiceQuestionSuccessorSelectorJSON  result)
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
        public ChoiceQuestionSuccessorSelectorJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ChoiceQuestionSuccessorSelectorJSON  result)
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
    protected virtual void handle_result(List<ChoiceQuestionSuccessorSelectorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ChoiceQuestionSuccessorSelectorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ChoiceQuestionSuccessorSelectorJSON>();
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
    public List<ChoiceQuestionSuccessorSelectorJSON> value;
  };
  };
