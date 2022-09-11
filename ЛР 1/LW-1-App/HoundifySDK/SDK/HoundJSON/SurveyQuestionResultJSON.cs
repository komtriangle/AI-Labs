/* file "SurveyQuestionResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SurveyQuestionResultJSON : SurveyResultJSON
  {
    private bool flagHasQuestion;
    private SurveyQuestionJSON  storeQuestion;
    private bool flagHasNextQuestion;
    private SurveyQuestionJSON  storeNextQuestion;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraQuestionToJSON()
      {
        JSONValueHandler handler_Question = new JSONValueHandler();
        storeQuestion.write_as_json(handler_Question);
        return handler_Question.result;
      }

    private JSONValue  extraNextQuestionToJSON()
      {
        JSONValueHandler handler_NextQuestion = new JSONValueHandler();
        storeNextQuestion.write_as_json(handler_NextQuestion);
        return handler_NextQuestion.result;
      }


    private void  fromJSONQuestion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SurveyQuestionJSON convert_classy = SurveyQuestionJSON.from_json(json_value, ignore_extras, true);
        setQuestion(convert_classy);
      }


    private void  fromJSONNextQuestion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SurveyQuestionJSON convert_classy = SurveyQuestionJSON.from_json(json_value, ignore_extras, true);
        setNextQuestion(convert_classy);
      }


    public SurveyQuestionResultJSON()
      {
        flagHasQuestion = false;
        flagHasNextQuestion = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSurveyResultType()
      {
        return "SurveyQuestionResult";
      }

    public bool  hasQuestion()
      {
        return flagHasQuestion;
      }

    public SurveyQuestionJSON   getQuestion()
      {
        Debug.Assert(flagHasQuestion);
        return storeQuestion;
      }

    public bool  hasNextQuestion()
      {
        return flagHasNextQuestion;
      }

    public SurveyQuestionJSON   getNextQuestion()
      {
        Debug.Assert(flagHasNextQuestion);
        return storeNextQuestion;
      }


    public virtual int extraSurveyQuestionResultComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSurveyQuestionResultComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSurveyQuestionResultComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSurveyQuestionResultLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSurveyResultComponentCount()
      {
        int result = 0;
        if (flagHasQuestion)
            ++result;
        if (flagHasNextQuestion)
            ++result;
        result += extraSurveyQuestionResultComponentCount();
        return result;
      }
    public override string extraSurveyResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasQuestion)
          {
            if (remainder == 0)
                return "Question";
            --remainder;
          }
        if (flagHasNextQuestion)
          {
            if (remainder == 0)
                return "NextQuestion";
            --remainder;
          }
        return extraSurveyQuestionResultComponentKey(remainder);
      }
    public override JSONValue extraSurveyResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasQuestion)
          {
            if (remainder == 0)
                return extraQuestionToJSON();
            --remainder;
          }
        if (flagHasNextQuestion)
          {
            if (remainder == 0)
                return extraNextQuestionToJSON();
            --remainder;
          }
        return extraSurveyQuestionResultComponentValue(remainder);
      }
    public override JSONValue extraSurveyResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'N':
                if ((String.Compare(field_name, 1, "extQuestion", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasNextQuestion ? extraNextQuestionToJSON() : null);
                break;
            case 'Q':
                if ((String.Compare(field_name, 1, "uestion", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasQuestion ? extraQuestionToJSON() : null);
                break;
            default:
                break;
          }
        return extraSurveyQuestionResultLookup(field_name);
      }

    public void setQuestion(SurveyQuestionJSON  new_value)
      {
        if (flagHasQuestion)
          {
          }
        flagHasQuestion = true;
        storeQuestion = new_value;
      }
    public void unsetQuestion()
      {
        if (flagHasQuestion)
          {
          }
        flagHasQuestion = false;
      }
    public void setNextQuestion(SurveyQuestionJSON  new_value)
      {
        if (flagHasNextQuestion)
          {
          }
        flagHasNextQuestion = true;
        storeNextQuestion = new_value;
      }
    public void unsetNextQuestion()
      {
        if (flagHasNextQuestion)
          {
          }
        flagHasNextQuestion = false;
      }

    public virtual void extraSurveyQuestionResultAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSurveyQuestionResultSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSurveyQuestionResultLookup(key);
        if (old_field == null)
          {
            extraSurveyQuestionResultAppendPair(key, new_component);
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
    public override void extraSurveyResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'N':
                if ((String.Compare(key, 1, "extQuestion", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONNextQuestion(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "uestion", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONQuestion(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSurveyQuestionResultAppendPair(key, new_component);
      }
    public override void extraSurveyResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'N':
                if ((String.Compare(key, 1, "extQuestion", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONNextQuestion(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "uestion", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONQuestion(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSurveyQuestionResultSetField(key, new_component);
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
        if (flagHasQuestion)
          {
            handler.start_pair("Question");
            if (partial_allowed)
                storeQuestion.write_partial_as_json(handler);
            else
                storeQuestion.write_as_json(handler);
          }
        if (flagHasNextQuestion)
          {
            handler.start_pair("NextQuestion");
            if (partial_allowed)
                storeNextQuestion.write_partial_as_json(handler);
            else
                storeNextQuestion.write_as_json(handler);
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

    public static new SurveyQuestionResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyQuestionResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyQuestionResult", ignore_extras);
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
    public static new SurveyQuestionResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SurveyQuestionResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyQuestionResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyQuestionResult", ignore_extras);
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
    public static new SurveyQuestionResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SurveyQuestionResultJSON from_text(string text, bool ignore_extras)
      {
        SurveyQuestionResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyQuestionResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SurveyQuestionResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SurveyQuestionResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SurveyQuestionResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyQuestionResult", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SurveyResultJSON.Generator
      {
        private SurveyQuestionJSON.HoldingGenerator fieldGeneratorQuestion;
        private SurveyQuestionJSON.HoldingGenerator fieldGeneratorNextQuestion;
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
            if (!(getSurveyResultJSONKey().Equals("SurveyQuestionResult")))
                throw new Exception("The key field has a value other than `SurveyQuestionResult'.");
            SurveyQuestionResultJSON result = new SurveyQuestionResultJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSurveyQuestionResultAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SurveyResultJSON new_result)
          {
            handle_result((SurveyQuestionResultJSON )new_result);
          }
        protected void finish(SurveyQuestionResultJSON result)
          {
            if (fieldGeneratorQuestion.have_value)
              {
                result.setQuestion(fieldGeneratorQuestion.value);
                fieldGeneratorQuestion.have_value = false;
              }
            if (fieldGeneratorNextQuestion.have_value)
              {
                result.setNextQuestion(fieldGeneratorNextQuestion.value);
                fieldGeneratorNextQuestion.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SurveyQuestionResultJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'N':
                    if ((String.Compare(field_name, 1, "extQuestion", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorNextQuestion;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "uestion", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorQuestion;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorQuestion = new SurveyQuestionJSON.HoldingGenerator("field \"Question\" of the SurveyQuestionResult class", ignore_extras);
            fieldGeneratorNextQuestion = new SurveyQuestionJSON.HoldingGenerator("field \"NextQuestion\" of the SurveyQuestionResult class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SurveyQuestionResult class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorQuestion = new SurveyQuestionJSON.HoldingGenerator("field \"Question\" of the SurveyQuestionResult class", false);
            fieldGeneratorNextQuestion = new SurveyQuestionJSON.HoldingGenerator("field \"NextQuestion\" of the SurveyQuestionResult class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SurveyQuestionResult class");
          }

        public override void reset()
          {
            fieldGeneratorQuestion.reset();
            fieldGeneratorNextQuestion.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SurveyQuestionResultJSON  result)
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
        public SurveyQuestionResultJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SurveyQuestionResultJSON  result)
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
    protected virtual void handle_result(List<SurveyQuestionResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SurveyQuestionResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SurveyQuestionResultJSON>();
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
    public List<SurveyQuestionResultJSON> value;
  };
  };
