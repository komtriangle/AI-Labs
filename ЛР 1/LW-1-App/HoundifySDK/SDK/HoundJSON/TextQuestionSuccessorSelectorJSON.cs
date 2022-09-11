/* file "TextQuestionSuccessorSelectorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class TextQuestionSuccessorSelectorJSON : SurveyGraphNodeSuccessorSelectorJSON
  {
    private bool flagHasIfAnsweredSuccessor;
    private BigInteger storeIfAnsweredSuccessor;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraIfAnsweredSuccessorToJSON()
      {
        JSONIntegerValue generated_integer_IfAnsweredSuccessor = new JSONIntegerValue(storeIfAnsweredSuccessor);
        return generated_integer_IfAnsweredSuccessor;
      }


    private void  fromJSONIfAnsweredSuccessor(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field IfAnsweredSuccessor of TextQuestionSuccessorSelectorJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field IfAnsweredSuccessor of TextQuestionSuccessorSelectorJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setIfAnsweredSuccessor(extracted_integer);
      }


    public TextQuestionSuccessorSelectorJSON()
      {
        flagHasIfAnsweredSuccessor = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getQuestionType()
      {
        return "SurveyTextQuestion";
      }

    public bool  hasIfAnsweredSuccessor()
      {
        return flagHasIfAnsweredSuccessor;
      }

    public BigInteger  getIfAnsweredSuccessor()
      {
        Debug.Assert(flagHasIfAnsweredSuccessor);
        return storeIfAnsweredSuccessor;
      }


    public virtual int extraTextQuestionSuccessorSelectorComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTextQuestionSuccessorSelectorComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTextQuestionSuccessorSelectorComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTextQuestionSuccessorSelectorLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSurveyGraphNodeSuccessorSelectorComponentCount()
      {
        int result = 0;
        if (flagHasIfAnsweredSuccessor)
            ++result;
        result += extraTextQuestionSuccessorSelectorComponentCount();
        return result;
      }
    public override string extraSurveyGraphNodeSuccessorSelectorComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasIfAnsweredSuccessor)
          {
            if (remainder == 0)
                return "IfAnsweredSuccessor";
            --remainder;
          }
        return extraTextQuestionSuccessorSelectorComponentKey(remainder);
      }
    public override JSONValue extraSurveyGraphNodeSuccessorSelectorComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasIfAnsweredSuccessor)
          {
            if (remainder == 0)
                return extraIfAnsweredSuccessorToJSON();
            --remainder;
          }
        return extraTextQuestionSuccessorSelectorComponentValue(remainder);
      }
    public override JSONValue extraSurveyGraphNodeSuccessorSelectorLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "IfAnsweredSuccessor", 0, 19, false) == 0) && (field_name.Length == 19))
            return (flagHasIfAnsweredSuccessor ? extraIfAnsweredSuccessorToJSON() : null);
        return extraTextQuestionSuccessorSelectorLookup(field_name);
      }

    public void setIfAnsweredSuccessor(BigInteger new_value)
      {
        flagHasIfAnsweredSuccessor = true;
        if (new_value < 0)
            throw new Exception("The value for field IfAnsweredSuccessor of TextQuestionSuccessorSelectorJSON is less than the lower bound (0) for that field.");
        storeIfAnsweredSuccessor = new_value;
      }
    public void unsetIfAnsweredSuccessor()
      {
        flagHasIfAnsweredSuccessor = false;
      }

    public virtual void extraTextQuestionSuccessorSelectorAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTextQuestionSuccessorSelectorSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTextQuestionSuccessorSelectorLookup(key);
        if (old_field == null)
          {
            extraTextQuestionSuccessorSelectorAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "IfAnsweredSuccessor", 0, 19, false) == 0) && (key.Length == 19))
            {
            fromJSONIfAnsweredSuccessor(new_component, false);
            return;
            }
        extraTextQuestionSuccessorSelectorAppendPair(key, new_component);
      }
    public override void extraSurveyGraphNodeSuccessorSelectorSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "IfAnsweredSuccessor", 0, 19, false) == 0) && (key.Length == 19))
            {
            fromJSONIfAnsweredSuccessor(new_component, false);
            return;
            }
        extraTextQuestionSuccessorSelectorSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasIfAnsweredSuccessor);
        if (flagHasIfAnsweredSuccessor)
          {
            handler.start_pair("IfAnsweredSuccessor");
            handler.number_value(storeIfAnsweredSuccessor);
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
        if (!(hasIfAnsweredSuccessor()))
          {
            return "When parsing the object for %what%, the \"IfAnsweredSuccessor\" field was missing.";
          }
        return null;
      }

    public static new TextQuestionSuccessorSelectorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TextQuestionSuccessorSelectorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TextQuestionSuccessorSelector", ignore_extras);
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
    public static new TextQuestionSuccessorSelectorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TextQuestionSuccessorSelectorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TextQuestionSuccessorSelectorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TextQuestionSuccessorSelector", ignore_extras);
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
    public static new TextQuestionSuccessorSelectorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TextQuestionSuccessorSelectorJSON from_text(string text, bool ignore_extras)
      {
        TextQuestionSuccessorSelectorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TextQuestionSuccessorSelector", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TextQuestionSuccessorSelectorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TextQuestionSuccessorSelectorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TextQuestionSuccessorSelectorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TextQuestionSuccessorSelector", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SurveyGraphNodeSuccessorSelectorJSON.Generator
      {
    private class FieldHoldingGeneratorIfAnsweredSuccessor : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorIfAnsweredSuccessor(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorIfAnsweredSuccessor : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorIfAnsweredSuccessor(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorIfAnsweredSuccessor fieldGeneratorIfAnsweredSuccessor;
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
            if (!(getSurveyGraphNodeSuccessorSelectorJSONKey().Equals("SurveyTextQuestion")))
                throw new Exception("The key field has a value other than `SurveyTextQuestion'.");
            TextQuestionSuccessorSelectorJSON result = new TextQuestionSuccessorSelectorJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTextQuestionSuccessorSelectorAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SurveyGraphNodeSuccessorSelectorJSON new_result)
          {
            handle_result((TextQuestionSuccessorSelectorJSON )new_result);
          }
        protected void finish(TextQuestionSuccessorSelectorJSON result)
          {
            if (fieldGeneratorIfAnsweredSuccessor.have_value)
              {
                result.setIfAnsweredSuccessor(fieldGeneratorIfAnsweredSuccessor.value);
                fieldGeneratorIfAnsweredSuccessor.have_value = false;
              }
            else if ((!(result.hasIfAnsweredSuccessor())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IfAnsweredSuccessor\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(TextQuestionSuccessorSelectorJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "IfAnsweredSuccessor", 0, 19, false) == 0) && (field_name.Length == 19))
                return fieldGeneratorIfAnsweredSuccessor;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorIfAnsweredSuccessor = new FieldHoldingGeneratorIfAnsweredSuccessor("field \"IfAnsweredSuccessor\" of the TextQuestionSuccessorSelector class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TextQuestionSuccessorSelector class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorIfAnsweredSuccessor = new FieldHoldingGeneratorIfAnsweredSuccessor("field \"IfAnsweredSuccessor\" of the TextQuestionSuccessorSelector class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TextQuestionSuccessorSelector class");
          }

        public override void reset()
          {
            fieldGeneratorIfAnsweredSuccessor.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(TextQuestionSuccessorSelectorJSON  result)
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
        public TextQuestionSuccessorSelectorJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TextQuestionSuccessorSelectorJSON  result)
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
    protected virtual void handle_result(List<TextQuestionSuccessorSelectorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TextQuestionSuccessorSelectorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TextQuestionSuccessorSelectorJSON>();
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
    public List<TextQuestionSuccessorSelectorJSON> value;
  };
  };
