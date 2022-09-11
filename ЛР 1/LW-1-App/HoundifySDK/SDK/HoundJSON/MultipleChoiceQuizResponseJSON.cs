/* file "MultipleChoiceQuizResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MultipleChoiceQuizResponseJSON : InformationNuggetJSON
  {
    private bool flagHasCorrect;
    private bool storeCorrect;
    private bool flagHasCorrectAnswer;
    private string storeCorrectAnswer;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCorrectToJSON()
      {
        JSONValue generated_boolean_Correct = (storeCorrect ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_Correct;
      }

    private JSONValue  extraCorrectAnswerToJSON()
      {
        JSONStringValue generated_string_CorrectAnswer = new JSONStringValue(storeCorrectAnswer);
        return generated_string_CorrectAnswer;
      }


    private void  fromJSONCorrect(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field Correct of MultipleChoiceQuizResponseJSON is not true for false.");
              }
          }
        setCorrect(the_bool);
      }


    private void  fromJSONCorrectAnswer(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CorrectAnswer of MultipleChoiceQuizResponseJSON is not a string.");
        setCorrectAnswer(json_string.getData());
      }


    public MultipleChoiceQuizResponseJSON()
      {
        flagHasCorrect = false;
        flagHasCorrectAnswer = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "MultipleChoiceQuizResponse";
      }

    public bool  hasCorrect()
      {
        return flagHasCorrect;
      }

    public bool  getCorrect()
      {
        Debug.Assert(flagHasCorrect);
        return storeCorrect;
      }

    public bool  hasCorrectAnswer()
      {
        return flagHasCorrectAnswer;
      }

    public string  getCorrectAnswer()
      {
        Debug.Assert(flagHasCorrectAnswer);
        return storeCorrectAnswer;
      }


    public virtual int extraMultipleChoiceQuizResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMultipleChoiceQuizResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMultipleChoiceQuizResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMultipleChoiceQuizResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasCorrect)
            ++result;
        if (flagHasCorrectAnswer)
            ++result;
        result += extraMultipleChoiceQuizResponseComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCorrect)
          {
            if (remainder == 0)
                return "Correct";
            --remainder;
          }
        if (flagHasCorrectAnswer)
          {
            if (remainder == 0)
                return "CorrectAnswer";
            --remainder;
          }
        return extraMultipleChoiceQuizResponseComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCorrect)
          {
            if (remainder == 0)
                return extraCorrectToJSON();
            --remainder;
          }
        if (flagHasCorrectAnswer)
          {
            if (remainder == 0)
                return extraCorrectAnswerToJSON();
            --remainder;
          }
        return extraMultipleChoiceQuizResponseComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "Correct", 0, 7, false) == 0)
          {
            if (field_name.Length == 7)
              {
                return (flagHasCorrect ? extraCorrectToJSON() : null);
              }
            switch (field_name[7])
              {
                case 'A':
                    if ((String.Compare(field_name, 8, "nswer", 0, 5, false) == 0) && (field_name.Length == 13))
                        return (flagHasCorrectAnswer ? extraCorrectAnswerToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraMultipleChoiceQuizResponseLookup(field_name);
      }

    public void setCorrect(bool new_value)
      {
        flagHasCorrect = true;
        storeCorrect = new_value;
      }
    public void unsetCorrect()
      {
        flagHasCorrect = false;
      }
    public void setCorrectAnswer(string new_value)
      {
        flagHasCorrectAnswer = true;
        storeCorrectAnswer = new_value;
      }
    public void unsetCorrectAnswer()
      {
        flagHasCorrectAnswer = false;
      }

    public virtual void extraMultipleChoiceQuizResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMultipleChoiceQuizResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMultipleChoiceQuizResponseLookup(key);
        if (old_field == null)
          {
            extraMultipleChoiceQuizResponseAppendPair(key, new_component);
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
        if (String.Compare(key, 0, "Correct", 0, 7, false) == 0)
          {
            if (key.Length == 7)
              {
                {
                fromJSONCorrect(new_component, false);
                return;
                }
              }
            switch (key[7])
              {
                case 'A':
                    if ((String.Compare(key, 8, "nswer", 0, 5, false) == 0) && (key.Length == 13))
                        {
                        fromJSONCorrectAnswer(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraMultipleChoiceQuizResponseAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Correct", 0, 7, false) == 0)
          {
            if (key.Length == 7)
              {
                {
                fromJSONCorrect(new_component, false);
                return;
                }
              }
            switch (key[7])
              {
                case 'A':
                    if ((String.Compare(key, 8, "nswer", 0, 5, false) == 0) && (key.Length == 13))
                        {
                        fromJSONCorrectAnswer(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraMultipleChoiceQuizResponseSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCorrect);
        if (flagHasCorrect)
          {
            handler.start_pair("Correct");
            handler.boolean_value(storeCorrect);
          }
        if (flagHasCorrectAnswer)
          {
            handler.start_pair("CorrectAnswer");
            handler.string_value(storeCorrectAnswer);
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
        if (!(hasCorrect()))
          {
            return "When parsing the object for %what%, the \"Correct\" field was missing.";
          }
        return null;
      }

    public static new MultipleChoiceQuizResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MultipleChoiceQuizResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizResponse", ignore_extras);
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
    public static new MultipleChoiceQuizResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MultipleChoiceQuizResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MultipleChoiceQuizResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizResponse", ignore_extras);
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
    public static new MultipleChoiceQuizResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MultipleChoiceQuizResponseJSON from_text(string text, bool ignore_extras)
      {
        MultipleChoiceQuizResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MultipleChoiceQuizResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MultipleChoiceQuizResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MultipleChoiceQuizResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizResponse", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorCorrect;
        private JSONHoldingStringGenerator fieldGeneratorCorrectAnswer;
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
            if (!(getInformationNuggetJSONKey().Equals("MultipleChoiceQuizResponse")))
                throw new Exception("The key field has a value other than `MultipleChoiceQuizResponse'.");
            MultipleChoiceQuizResponseJSON result = new MultipleChoiceQuizResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMultipleChoiceQuizResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((MultipleChoiceQuizResponseJSON )new_result);
          }
        protected void finish(MultipleChoiceQuizResponseJSON result)
          {
            if (fieldGeneratorCorrect.have_value)
              {
                result.setCorrect(fieldGeneratorCorrect.value);
                fieldGeneratorCorrect.have_value = false;
              }
            else if ((!(result.hasCorrect())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Correct\" field was missing.");
              }
            if (fieldGeneratorCorrectAnswer.have_value)
              {
                result.setCorrectAnswer(fieldGeneratorCorrectAnswer.value);
                fieldGeneratorCorrectAnswer.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MultipleChoiceQuizResponseJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Correct", 0, 7, false) == 0)
              {
                if (field_name.Length == 7)
                  {
                    return fieldGeneratorCorrect;
                  }
                switch (field_name[7])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 8, "nswer", 0, 5, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorCorrectAnswer;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCorrect = new JSONHoldingBooleanGenerator("field \"Correct\" of the MultipleChoiceQuizResponse class");
            fieldGeneratorCorrectAnswer = new JSONHoldingStringGenerator("field \"CorrectAnswer\" of the MultipleChoiceQuizResponse class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MultipleChoiceQuizResponse class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCorrect = new JSONHoldingBooleanGenerator("field \"Correct\" of the MultipleChoiceQuizResponse class");
            fieldGeneratorCorrectAnswer = new JSONHoldingStringGenerator("field \"CorrectAnswer\" of the MultipleChoiceQuizResponse class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MultipleChoiceQuizResponse class");
          }

        public override void reset()
          {
            fieldGeneratorCorrect.reset();
            fieldGeneratorCorrectAnswer.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MultipleChoiceQuizResponseJSON  result)
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
        public MultipleChoiceQuizResponseJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MultipleChoiceQuizResponseJSON  result)
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
    protected virtual void handle_result(List<MultipleChoiceQuizResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MultipleChoiceQuizResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MultipleChoiceQuizResponseJSON>();
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
    public List<MultipleChoiceQuizResponseJSON> value;
  };
  };
