/* file "SurveyScaleQuestionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SurveyScaleQuestionJSON : SurveyQuestionJSON
  {
    private bool flagHasLowerBound;
    private BigInteger storeLowerBound;
    private bool flagHasUpperBound;
    private BigInteger storeUpperBound;
    private bool flagHasAnswer;
    private BigInteger storeAnswer;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraLowerBoundToJSON()
      {
        JSONIntegerValue generated_integer_LowerBound = new JSONIntegerValue(storeLowerBound);
        return generated_integer_LowerBound;
      }

    private JSONValue  extraUpperBoundToJSON()
      {
        JSONIntegerValue generated_integer_UpperBound = new JSONIntegerValue(storeUpperBound);
        return generated_integer_UpperBound;
      }

    private JSONValue  extraAnswerToJSON()
      {
        JSONIntegerValue generated_integer_Answer = new JSONIntegerValue(storeAnswer);
        return generated_integer_Answer;
      }


    private void  fromJSONLowerBound(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field LowerBound of SurveyScaleQuestionJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field LowerBound of SurveyScaleQuestionJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setLowerBound(extracted_integer);
      }


    private void  fromJSONUpperBound(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field UpperBound of SurveyScaleQuestionJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field UpperBound of SurveyScaleQuestionJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setUpperBound(extracted_integer);
      }


    private void  fromJSONAnswer(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Answer of SurveyScaleQuestionJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Answer of SurveyScaleQuestionJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setAnswer(extracted_integer);
      }


    public SurveyScaleQuestionJSON()
      {
        flagHasLowerBound = false;
        flagHasUpperBound = false;
        flagHasAnswer = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getAnswerKind()
      {
        return "SurveyScale";
      }

    public bool  hasLowerBound()
      {
        return flagHasLowerBound;
      }

    public BigInteger  getLowerBound()
      {
        Debug.Assert(flagHasLowerBound);
        return storeLowerBound;
      }

    public bool  hasUpperBound()
      {
        return flagHasUpperBound;
      }

    public BigInteger  getUpperBound()
      {
        Debug.Assert(flagHasUpperBound);
        return storeUpperBound;
      }

    public bool  hasAnswer()
      {
        return flagHasAnswer;
      }

    public BigInteger  getAnswer()
      {
        Debug.Assert(flagHasAnswer);
        return storeAnswer;
      }


    public virtual int extraSurveyScaleQuestionComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSurveyScaleQuestionComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSurveyScaleQuestionComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSurveyScaleQuestionLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSurveyQuestionComponentCount()
      {
        int result = 0;
        if (flagHasLowerBound)
            ++result;
        if (flagHasUpperBound)
            ++result;
        if (flagHasAnswer)
            ++result;
        result += extraSurveyScaleQuestionComponentCount();
        return result;
      }
    public override string extraSurveyQuestionComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasLowerBound)
          {
            if (remainder == 0)
                return "LowerBound";
            --remainder;
          }
        if (flagHasUpperBound)
          {
            if (remainder == 0)
                return "UpperBound";
            --remainder;
          }
        if (flagHasAnswer)
          {
            if (remainder == 0)
                return "Answer";
            --remainder;
          }
        return extraSurveyScaleQuestionComponentKey(remainder);
      }
    public override JSONValue extraSurveyQuestionComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasLowerBound)
          {
            if (remainder == 0)
                return extraLowerBoundToJSON();
            --remainder;
          }
        if (flagHasUpperBound)
          {
            if (remainder == 0)
                return extraUpperBoundToJSON();
            --remainder;
          }
        if (flagHasAnswer)
          {
            if (remainder == 0)
                return extraAnswerToJSON();
            --remainder;
          }
        return extraSurveyScaleQuestionComponentValue(remainder);
      }
    public override JSONValue extraSurveyQuestionLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "nswer", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasAnswer ? extraAnswerToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "owerBound", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasLowerBound ? extraLowerBoundToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "pperBound", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasUpperBound ? extraUpperBoundToJSON() : null);
                break;
            default:
                break;
          }
        return extraSurveyScaleQuestionLookup(field_name);
      }

    public void setLowerBound(BigInteger new_value)
      {
        flagHasLowerBound = true;
        if (new_value < 1)
            throw new Exception("The value for field LowerBound of SurveyScaleQuestionJSON is less than the lower bound (1) for that field.");
        storeLowerBound = new_value;
      }
    public void unsetLowerBound()
      {
        flagHasLowerBound = false;
      }
    public void setUpperBound(BigInteger new_value)
      {
        flagHasUpperBound = true;
        if (new_value < 1)
            throw new Exception("The value for field UpperBound of SurveyScaleQuestionJSON is less than the lower bound (1) for that field.");
        storeUpperBound = new_value;
      }
    public void unsetUpperBound()
      {
        flagHasUpperBound = false;
      }
    public void setAnswer(BigInteger new_value)
      {
        flagHasAnswer = true;
        if (new_value < 1)
            throw new Exception("The value for field Answer of SurveyScaleQuestionJSON is less than the lower bound (1) for that field.");
        storeAnswer = new_value;
      }
    public void unsetAnswer()
      {
        flagHasAnswer = false;
      }

    public virtual void extraSurveyScaleQuestionAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSurveyScaleQuestionSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSurveyScaleQuestionLookup(key);
        if (old_field == null)
          {
            extraSurveyScaleQuestionAppendPair(key, new_component);
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
    public override void extraSurveyQuestionAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "nswer", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONAnswer(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "owerBound", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONLowerBound(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "pperBound", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONUpperBound(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSurveyScaleQuestionAppendPair(key, new_component);
      }
    public override void extraSurveyQuestionSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "nswer", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONAnswer(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "owerBound", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONLowerBound(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "pperBound", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONUpperBound(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSurveyScaleQuestionSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasLowerBound);
        if (flagHasLowerBound)
          {
            handler.start_pair("LowerBound");
            handler.number_value(storeLowerBound);
          }
        Debug.Assert(partial_allowed || flagHasUpperBound);
        if (flagHasUpperBound)
          {
            handler.start_pair("UpperBound");
            handler.number_value(storeUpperBound);
          }
        if (flagHasAnswer)
          {
            handler.start_pair("Answer");
            handler.number_value(storeAnswer);
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
        if (!(hasLowerBound()))
          {
            return "When parsing the object for %what%, the \"LowerBound\" field was missing.";
          }
        if (!(hasUpperBound()))
          {
            return "When parsing the object for %what%, the \"UpperBound\" field was missing.";
          }
        return null;
      }

    public static new SurveyScaleQuestionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyScaleQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyScaleQuestion", ignore_extras);
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
    public static new SurveyScaleQuestionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SurveyScaleQuestionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyScaleQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyScaleQuestion", ignore_extras);
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
    public static new SurveyScaleQuestionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SurveyScaleQuestionJSON from_text(string text, bool ignore_extras)
      {
        SurveyScaleQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyScaleQuestion", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SurveyScaleQuestionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SurveyScaleQuestionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SurveyScaleQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyScaleQuestion", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SurveyQuestionJSON.Generator
      {
    private class FieldHoldingGeneratorLowerBound : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorLowerBound(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorLowerBound : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorLowerBound(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorLowerBound fieldGeneratorLowerBound;
    private class FieldHoldingGeneratorUpperBound : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorUpperBound(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorUpperBound : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorUpperBound(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorUpperBound fieldGeneratorUpperBound;
    private class FieldHoldingGeneratorAnswer : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorAnswer(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorAnswer : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorAnswer(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorAnswer fieldGeneratorAnswer;
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
            if (!(getSurveyQuestionJSONKey().Equals("SurveyScale")))
                throw new Exception("The key field has a value other than `SurveyScale'.");
            SurveyScaleQuestionJSON result = new SurveyScaleQuestionJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSurveyScaleQuestionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SurveyQuestionJSON new_result)
          {
            handle_result((SurveyScaleQuestionJSON )new_result);
          }
        protected void finish(SurveyScaleQuestionJSON result)
          {
            if (fieldGeneratorLowerBound.have_value)
              {
                result.setLowerBound(fieldGeneratorLowerBound.value);
                fieldGeneratorLowerBound.have_value = false;
              }
            else if ((!(result.hasLowerBound())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LowerBound\" field was missing.");
              }
            if (fieldGeneratorUpperBound.have_value)
              {
                result.setUpperBound(fieldGeneratorUpperBound.value);
                fieldGeneratorUpperBound.have_value = false;
              }
            else if ((!(result.hasUpperBound())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UpperBound\" field was missing.");
              }
            if (fieldGeneratorAnswer.have_value)
              {
                result.setAnswer(fieldGeneratorAnswer.value);
                fieldGeneratorAnswer.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SurveyScaleQuestionJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "nswer", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorAnswer;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "owerBound", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorLowerBound;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "pperBound", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorUpperBound;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorLowerBound = new FieldHoldingGeneratorLowerBound("field \"LowerBound\" of the SurveyScaleQuestion class");
            fieldGeneratorUpperBound = new FieldHoldingGeneratorUpperBound("field \"UpperBound\" of the SurveyScaleQuestion class");
            fieldGeneratorAnswer = new FieldHoldingGeneratorAnswer("field \"Answer\" of the SurveyScaleQuestion class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SurveyScaleQuestion class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorLowerBound = new FieldHoldingGeneratorLowerBound("field \"LowerBound\" of the SurveyScaleQuestion class");
            fieldGeneratorUpperBound = new FieldHoldingGeneratorUpperBound("field \"UpperBound\" of the SurveyScaleQuestion class");
            fieldGeneratorAnswer = new FieldHoldingGeneratorAnswer("field \"Answer\" of the SurveyScaleQuestion class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SurveyScaleQuestion class");
          }

        public override void reset()
          {
            fieldGeneratorLowerBound.reset();
            fieldGeneratorUpperBound.reset();
            fieldGeneratorAnswer.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SurveyScaleQuestionJSON  result)
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
        public SurveyScaleQuestionJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SurveyScaleQuestionJSON  result)
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
    protected virtual void handle_result(List<SurveyScaleQuestionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SurveyScaleQuestionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SurveyScaleQuestionJSON>();
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
    public List<SurveyScaleQuestionJSON> value;
  };
  };
