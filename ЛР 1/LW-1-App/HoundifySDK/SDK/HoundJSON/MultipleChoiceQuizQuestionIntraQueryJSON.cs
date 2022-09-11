/* file "MultipleChoiceQuizQuestionIntraQueryJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MultipleChoiceQuizQuestionIntraQueryJSON : JSONBase
  {
    private bool flagHasQuestion;
    private MultipleChoiceQuizQuestionJSON  storeQuestion;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONQuestion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MultipleChoiceQuizQuestionJSON convert_classy = MultipleChoiceQuizQuestionJSON.from_json(json_value, ignore_extras, true);
        setQuestion(convert_classy);
      }


    public MultipleChoiceQuizQuestionIntraQueryJSON()
      {
        flagHasQuestion = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasQuestion()
      {
        return flagHasQuestion;
      }

    public MultipleChoiceQuizQuestionJSON   getQuestion()
      {
        Debug.Assert(flagHasQuestion);
        return storeQuestion;
      }


    public virtual int extraMultipleChoiceQuizQuestionIntraQueryComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMultipleChoiceQuizQuestionIntraQueryComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMultipleChoiceQuizQuestionIntraQueryComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMultipleChoiceQuizQuestionIntraQueryLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setQuestion(MultipleChoiceQuizQuestionJSON  new_value)
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

    public virtual void extraMultipleChoiceQuizQuestionIntraQueryAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMultipleChoiceQuizQuestionIntraQuerySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMultipleChoiceQuizQuestionIntraQueryLookup(key);
        if (old_field == null)
          {
            extraMultipleChoiceQuizQuestionIntraQueryAppendPair(key, new_component);
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
        if (flagHasQuestion)
          {
            handler.start_pair("Question");
            if (partial_allowed)
                storeQuestion.write_partial_as_json(handler);
            else
                storeQuestion.write_as_json(handler);
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
        return null;
      }

    public static MultipleChoiceQuizQuestionIntraQueryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MultipleChoiceQuizQuestionIntraQueryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizQuestionIntraQuery", ignore_extras);
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
    public static MultipleChoiceQuizQuestionIntraQueryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MultipleChoiceQuizQuestionIntraQueryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MultipleChoiceQuizQuestionIntraQueryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizQuestionIntraQuery", ignore_extras);
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
    public static MultipleChoiceQuizQuestionIntraQueryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MultipleChoiceQuizQuestionIntraQueryJSON from_text(string text, bool ignore_extras)
      {
        MultipleChoiceQuizQuestionIntraQueryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizQuestionIntraQuery", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MultipleChoiceQuizQuestionIntraQueryJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MultipleChoiceQuizQuestionIntraQueryJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MultipleChoiceQuizQuestionIntraQueryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizQuestionIntraQuery", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private MultipleChoiceQuizQuestionJSON.HoldingGenerator fieldGeneratorQuestion;
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
            MultipleChoiceQuizQuestionIntraQueryJSON result = new MultipleChoiceQuizQuestionIntraQueryJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMultipleChoiceQuizQuestionIntraQueryAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MultipleChoiceQuizQuestionIntraQueryJSON result)
          {
            if (fieldGeneratorQuestion.have_value)
              {
                result.setQuestion(fieldGeneratorQuestion.value);
                fieldGeneratorQuestion.have_value = false;
              }
          }
        protected abstract void handle_result(MultipleChoiceQuizQuestionIntraQueryJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Question", 0, 8, false) == 0) && (field_name.Length == 8))
                return fieldGeneratorQuestion;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorQuestion = new MultipleChoiceQuizQuestionJSON.HoldingGenerator("field \"Question\" of the MultipleChoiceQuizQuestionIntraQuery class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MultipleChoiceQuizQuestionIntraQuery class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQuestion = new MultipleChoiceQuizQuestionJSON.HoldingGenerator("field \"Question\" of the MultipleChoiceQuizQuestionIntraQuery class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MultipleChoiceQuizQuestionIntraQuery class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQuestion.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorQuestion.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorQuestion.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MultipleChoiceQuizQuestionIntraQueryJSON  result)
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
        public MultipleChoiceQuizQuestionIntraQueryJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MultipleChoiceQuizQuestionIntraQueryJSON  result)
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
    protected virtual void handle_result(List<MultipleChoiceQuizQuestionIntraQueryJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MultipleChoiceQuizQuestionIntraQueryJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MultipleChoiceQuizQuestionIntraQueryJSON>();
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
    public List<MultipleChoiceQuizQuestionIntraQueryJSON> value;
  };
  };
