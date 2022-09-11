/* file "ScaleQuestionSuccessorSelectorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ScaleQuestionSuccessorSelectorJSON : SurveyGraphNodeSuccessorSelectorJSON
  {
    private bool flagHasAnswerRanges;
    private List< AnswerRangeJSON  > storeAnswerRanges;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraAnswerRangesToJSON()
      {
        JSONArrayValue generated_array_1_AnswerRanges = new JSONArrayValue();
        for (int num1 = 0; num1 < storeAnswerRanges.Count; ++num1)
          {
            JSONValueHandler handler_AnswerRanges = new JSONValueHandler();
            storeAnswerRanges[num1].write_as_json(handler_AnswerRanges);
            generated_array_1_AnswerRanges.appendComponent(handler_AnswerRanges.result);
          }
        return generated_array_1_AnswerRanges;
      }


    private void  fromJSONAnswerRanges(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AnswerRanges of ScaleQuestionSuccessorSelectorJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< AnswerRangeJSON  > vector_AnswerRanges1 = new List< AnswerRangeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AnswerRangeJSON convert_classy = AnswerRangeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AnswerRanges1.Add(convert_classy);
          }
        initAnswerRanges();
        for (int num1 = 0; num1 < vector_AnswerRanges1.Count; ++num1)
            appendAnswerRanges(vector_AnswerRanges1[num1]);
        for (int num1 = 0; num1 < vector_AnswerRanges1.Count; ++num1)
          {
          }
      }


    public ScaleQuestionSuccessorSelectorJSON()
      {
        flagHasAnswerRanges = false;
        storeAnswerRanges = new List< AnswerRangeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getQuestionType()
      {
        return "SurveyScaleQuestion";
      }

    public bool  hasAnswerRanges()
      {
        return flagHasAnswerRanges;
      }

    public int  countOfAnswerRanges()
      {
        Debug.Assert(flagHasAnswerRanges);
        return storeAnswerRanges.Count;
      }

    public AnswerRangeJSON   elementOfAnswerRanges(int element_num)
      {
        Debug.Assert(flagHasAnswerRanges);
        return storeAnswerRanges[element_num];
      }

    public List< AnswerRangeJSON  >  getAnswerRanges()
      {
        Debug.Assert(flagHasAnswerRanges);
        return storeAnswerRanges;
      }


    public virtual int extraScaleQuestionSuccessorSelectorComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraScaleQuestionSuccessorSelectorComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraScaleQuestionSuccessorSelectorComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraScaleQuestionSuccessorSelectorLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSurveyGraphNodeSuccessorSelectorComponentCount()
      {
        int result = 0;
        if (flagHasAnswerRanges)
            ++result;
        result += extraScaleQuestionSuccessorSelectorComponentCount();
        return result;
      }
    public override string extraSurveyGraphNodeSuccessorSelectorComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAnswerRanges)
          {
            if (remainder == 0)
                return "AnswerRanges";
            --remainder;
          }
        return extraScaleQuestionSuccessorSelectorComponentKey(remainder);
      }
    public override JSONValue extraSurveyGraphNodeSuccessorSelectorComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAnswerRanges)
          {
            if (remainder == 0)
                return extraAnswerRangesToJSON();
            --remainder;
          }
        return extraScaleQuestionSuccessorSelectorComponentValue(remainder);
      }
    public override JSONValue extraSurveyGraphNodeSuccessorSelectorLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "AnswerRanges", 0, 12, false) == 0) && (field_name.Length == 12))
            return (flagHasAnswerRanges ? extraAnswerRangesToJSON() : null);
        return extraScaleQuestionSuccessorSelectorLookup(field_name);
      }

    public void initAnswerRanges()
      {
        if (flagHasAnswerRanges)
          {
            for (int num1 = 0; num1 < storeAnswerRanges.Count; ++num1)
              {
              }
          }
        flagHasAnswerRanges = true;
        storeAnswerRanges.Clear();
      }
    public void appendAnswerRanges(AnswerRangeJSON  to_append)
      {
        if (!flagHasAnswerRanges)
          {
            flagHasAnswerRanges = true;
            storeAnswerRanges.Clear();
          }
        Debug.Assert(flagHasAnswerRanges);
        storeAnswerRanges.Add(to_append);
      }
    public void unsetAnswerRanges()
      {
        if (flagHasAnswerRanges)
          {
            for (int num2 = 0; num2 < storeAnswerRanges.Count; ++num2)
              {
              }
          }
        flagHasAnswerRanges = false;
        storeAnswerRanges.Clear();
      }

    public virtual void extraScaleQuestionSuccessorSelectorAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraScaleQuestionSuccessorSelectorSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraScaleQuestionSuccessorSelectorLookup(key);
        if (old_field == null)
          {
            extraScaleQuestionSuccessorSelectorAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "AnswerRanges", 0, 12, false) == 0) && (key.Length == 12))
            {
            fromJSONAnswerRanges(new_component, false);
            return;
            }
        extraScaleQuestionSuccessorSelectorAppendPair(key, new_component);
      }
    public override void extraSurveyGraphNodeSuccessorSelectorSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "AnswerRanges", 0, 12, false) == 0) && (key.Length == 12))
            {
            fromJSONAnswerRanges(new_component, false);
            return;
            }
        extraScaleQuestionSuccessorSelectorSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasAnswerRanges);
        if (flagHasAnswerRanges)
          {
            handler.start_pair("AnswerRanges");
            handler.start_array();
            for (int num1 = 0; num1 < storeAnswerRanges.Count; ++num1)
              {
                if (partial_allowed)
                    storeAnswerRanges[num1].write_partial_as_json(handler);
                else
                    storeAnswerRanges[num1].write_as_json(handler);
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
        if (!(hasAnswerRanges()))
          {
            return "When parsing the object for %what%, the \"AnswerRanges\" field was missing.";
          }
        return null;
      }

    public static new ScaleQuestionSuccessorSelectorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ScaleQuestionSuccessorSelectorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ScaleQuestionSuccessorSelector", ignore_extras);
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
    public static new ScaleQuestionSuccessorSelectorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ScaleQuestionSuccessorSelectorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ScaleQuestionSuccessorSelectorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ScaleQuestionSuccessorSelector", ignore_extras);
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
    public static new ScaleQuestionSuccessorSelectorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ScaleQuestionSuccessorSelectorJSON from_text(string text, bool ignore_extras)
      {
        ScaleQuestionSuccessorSelectorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ScaleQuestionSuccessorSelector", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ScaleQuestionSuccessorSelectorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ScaleQuestionSuccessorSelectorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ScaleQuestionSuccessorSelectorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ScaleQuestionSuccessorSelector", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SurveyGraphNodeSuccessorSelectorJSON.Generator
      {
        private AnswerRangeJSON.HoldingArrayGenerator fieldGeneratorAnswerRanges;
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
            if (!(getSurveyGraphNodeSuccessorSelectorJSONKey().Equals("SurveyScaleQuestion")))
                throw new Exception("The key field has a value other than `SurveyScaleQuestion'.");
            ScaleQuestionSuccessorSelectorJSON result = new ScaleQuestionSuccessorSelectorJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraScaleQuestionSuccessorSelectorAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SurveyGraphNodeSuccessorSelectorJSON new_result)
          {
            handle_result((ScaleQuestionSuccessorSelectorJSON )new_result);
          }
        protected void finish(ScaleQuestionSuccessorSelectorJSON result)
          {
            if (fieldGeneratorAnswerRanges.have_value)
              {
                result.initAnswerRanges();
                int count = fieldGeneratorAnswerRanges.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAnswerRanges(fieldGeneratorAnswerRanges.value[num]);
                  }
                fieldGeneratorAnswerRanges.value.Clear();
                fieldGeneratorAnswerRanges.have_value = false;
              }
            else if ((!(result.hasAnswerRanges())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AnswerRanges\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ScaleQuestionSuccessorSelectorJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "AnswerRanges", 0, 12, false) == 0) && (field_name.Length == 12))
                return fieldGeneratorAnswerRanges;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAnswerRanges = new AnswerRangeJSON.HoldingArrayGenerator("field \"AnswerRanges\" of the ScaleQuestionSuccessorSelector class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ScaleQuestionSuccessorSelector class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAnswerRanges = new AnswerRangeJSON.HoldingArrayGenerator("field \"AnswerRanges\" of the ScaleQuestionSuccessorSelector class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ScaleQuestionSuccessorSelector class");
          }

        public override void reset()
          {
            fieldGeneratorAnswerRanges.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ScaleQuestionSuccessorSelectorJSON  result)
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
        public ScaleQuestionSuccessorSelectorJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ScaleQuestionSuccessorSelectorJSON  result)
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
    protected virtual void handle_result(List<ScaleQuestionSuccessorSelectorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ScaleQuestionSuccessorSelectorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ScaleQuestionSuccessorSelectorJSON>();
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
    public List<ScaleQuestionSuccessorSelectorJSON> value;
  };
  };
