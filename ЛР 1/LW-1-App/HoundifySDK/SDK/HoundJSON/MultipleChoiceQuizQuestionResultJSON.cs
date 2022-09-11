/* file "MultipleChoiceQuizQuestionResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MultipleChoiceQuizQuestionResultJSON : CommandResultJSON
  {
    private bool flagHasQuestion;
    private MultipleChoiceQuizQuestionJSON  storeQuestion;
    private bool flagHasStatusCode;
    private sbyte storeStatusCode;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraQuestionToJSON()
      {
        JSONValueHandler handler_Question = new JSONValueHandler();
        storeQuestion.write_as_json(handler_Question);
        return handler_Question.result;
      }

    private JSONValue  extraStatusCodeToJSON()
      {
        JSONIntegerValue generated_integer_StatusCode = new JSONIntegerValue(storeStatusCode);
        return generated_integer_StatusCode;
      }


    private void  fromJSONQuestion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MultipleChoiceQuizQuestionJSON convert_classy = MultipleChoiceQuizQuestionJSON.from_json(json_value, ignore_extras, true);
        setQuestion(convert_classy);
      }


    private void  fromJSONStatusCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field StatusCode of MultipleChoiceQuizQuestionResultJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field StatusCode of MultipleChoiceQuizQuestionResultJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setStatusCode(extracted_integer);
      }


    public MultipleChoiceQuizQuestionResultJSON()
      {
        flagHasQuestion = false;
        flagHasStatusCode = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandKind()
      {
        return "MultipleChoiceQuizQuestionResult";
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

    public bool  hasStatusCode()
      {
        return flagHasStatusCode;
      }

    public sbyte  getStatusCode()
      {
        Debug.Assert(flagHasStatusCode);
        return storeStatusCode;
      }


    public virtual int extraMultipleChoiceQuizQuestionResultComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMultipleChoiceQuizQuestionResultComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMultipleChoiceQuizQuestionResultComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMultipleChoiceQuizQuestionResultLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasQuestion)
            ++result;
        if (flagHasStatusCode)
            ++result;
        result += extraMultipleChoiceQuizQuestionResultComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasQuestion)
          {
            if (remainder == 0)
                return "Question";
            --remainder;
          }
        if (flagHasStatusCode)
          {
            if (remainder == 0)
                return "StatusCode";
            --remainder;
          }
        return extraMultipleChoiceQuizQuestionResultComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasQuestion)
          {
            if (remainder == 0)
                return extraQuestionToJSON();
            --remainder;
          }
        if (flagHasStatusCode)
          {
            if (remainder == 0)
                return extraStatusCodeToJSON();
            --remainder;
          }
        return extraMultipleChoiceQuizQuestionResultComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'Q':
                if ((String.Compare(field_name, 1, "uestion", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasQuestion ? extraQuestionToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "tatusCode", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasStatusCode ? extraStatusCodeToJSON() : null);
                break;
            default:
                break;
          }
        return extraMultipleChoiceQuizQuestionResultLookup(field_name);
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
    public void setStatusCode(sbyte new_value)
      {
        flagHasStatusCode = true;
        if (new_value < 0)
            throw new Exception("The value for field StatusCode of MultipleChoiceQuizQuestionResultJSON is less than the lower bound (0) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field StatusCode of MultipleChoiceQuizQuestionResultJSON is greater than the upper bound (1) for that field.");
        storeStatusCode = new_value;
      }
    public void unsetStatusCode()
      {
        flagHasStatusCode = false;
      }

    public virtual void extraMultipleChoiceQuizQuestionResultAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMultipleChoiceQuizQuestionResultSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMultipleChoiceQuizQuestionResultLookup(key);
        if (old_field == null)
          {
            extraMultipleChoiceQuizQuestionResultAppendPair(key, new_component);
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
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'Q':
                if ((String.Compare(key, 1, "uestion", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONQuestion(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tatusCode", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONStatusCode(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMultipleChoiceQuizQuestionResultAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'Q':
                if ((String.Compare(key, 1, "uestion", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONQuestion(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tatusCode", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONStatusCode(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMultipleChoiceQuizQuestionResultSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStatusCode);
        if (flagHasStatusCode)
          {
            handler.start_pair("StatusCode");
            handler.number_value(storeStatusCode);
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
        if (!(hasStatusCode()))
          {
            return "When parsing the object for %what%, the \"StatusCode\" field was missing.";
          }
        return null;
      }

    public static new MultipleChoiceQuizQuestionResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MultipleChoiceQuizQuestionResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizQuestionResult", ignore_extras);
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
    public static new MultipleChoiceQuizQuestionResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MultipleChoiceQuizQuestionResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MultipleChoiceQuizQuestionResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizQuestionResult", ignore_extras);
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
    public static new MultipleChoiceQuizQuestionResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MultipleChoiceQuizQuestionResultJSON from_text(string text, bool ignore_extras)
      {
        MultipleChoiceQuizQuestionResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizQuestionResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MultipleChoiceQuizQuestionResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MultipleChoiceQuizQuestionResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MultipleChoiceQuizQuestionResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizQuestionResult", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private MultipleChoiceQuizQuestionJSON.HoldingGenerator fieldGeneratorQuestion;
    private class FieldHoldingGeneratorStatusCode : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorStatusCode(String what) : base(what, 0, 1)
              {
              }
          };
    private class FieldHoldingArrayGeneratorStatusCode : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorStatusCode(String what) : base(what, 0, 1)
              {
              }
          };
        private FieldHoldingGeneratorStatusCode fieldGeneratorStatusCode;
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
            if (!(getCommandResultJSONKey().Equals("MultipleChoiceQuizQuestionResult")))
                throw new Exception("The key field has a value other than `MultipleChoiceQuizQuestionResult'.");
            MultipleChoiceQuizQuestionResultJSON result = new MultipleChoiceQuizQuestionResultJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMultipleChoiceQuizQuestionResultAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((MultipleChoiceQuizQuestionResultJSON )new_result);
          }
        protected void finish(MultipleChoiceQuizQuestionResultJSON result)
          {
            if (fieldGeneratorQuestion.have_value)
              {
                result.setQuestion(fieldGeneratorQuestion.value);
                fieldGeneratorQuestion.have_value = false;
              }
            if (fieldGeneratorStatusCode.have_value)
              {
                result.setStatusCode((sbyte)(fieldGeneratorStatusCode.value));
                fieldGeneratorStatusCode.have_value = false;
              }
            else if ((!(result.hasStatusCode())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StatusCode\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(MultipleChoiceQuizQuestionResultJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'Q':
                    if ((String.Compare(field_name, 1, "uestion", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorQuestion;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tatusCode", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorStatusCode;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorQuestion = new MultipleChoiceQuizQuestionJSON.HoldingGenerator("field \"Question\" of the MultipleChoiceQuizQuestionResult class", ignore_extras);
            fieldGeneratorStatusCode = new FieldHoldingGeneratorStatusCode("field \"StatusCode\" of the MultipleChoiceQuizQuestionResult class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MultipleChoiceQuizQuestionResult class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorQuestion = new MultipleChoiceQuizQuestionJSON.HoldingGenerator("field \"Question\" of the MultipleChoiceQuizQuestionResult class", false);
            fieldGeneratorStatusCode = new FieldHoldingGeneratorStatusCode("field \"StatusCode\" of the MultipleChoiceQuizQuestionResult class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MultipleChoiceQuizQuestionResult class");
          }

        public override void reset()
          {
            fieldGeneratorQuestion.reset();
            fieldGeneratorStatusCode.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MultipleChoiceQuizQuestionResultJSON  result)
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
        public MultipleChoiceQuizQuestionResultJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MultipleChoiceQuizQuestionResultJSON  result)
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
    protected virtual void handle_result(List<MultipleChoiceQuizQuestionResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MultipleChoiceQuizQuestionResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MultipleChoiceQuizQuestionResultJSON>();
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
    public List<MultipleChoiceQuizQuestionResultJSON> value;
  };
  };
