/* file "SurveyParsingDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SurveyParsingDataJSON : JSONBase
  {
    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasCurrentQuestion;
    private BigInteger storeCurrentQuestion;
    private bool flagHasQuestionCount;
    private BigInteger storeQuestionCount;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of SurveyParsingDataJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONCurrentQuestion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CurrentQuestion of SurveyParsingDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CurrentQuestion of SurveyParsingDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCurrentQuestion(extracted_integer);
      }


    private void  fromJSONQuestionCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field QuestionCount of SurveyParsingDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field QuestionCount of SurveyParsingDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setQuestionCount(extracted_integer);
      }


    public SurveyParsingDataJSON()
      {
        flagHasTitle = false;
        flagHasCurrentQuestion = false;
        flagHasQuestionCount = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTitle()
      {
        return flagHasTitle;
      }

    public string  getTitle()
      {
        Debug.Assert(flagHasTitle);
        return storeTitle;
      }

    public bool  hasCurrentQuestion()
      {
        return flagHasCurrentQuestion;
      }

    public BigInteger  getCurrentQuestion()
      {
        Debug.Assert(flagHasCurrentQuestion);
        return storeCurrentQuestion;
      }

    public bool  hasQuestionCount()
      {
        return flagHasQuestionCount;
      }

    public BigInteger  getQuestionCount()
      {
        Debug.Assert(flagHasQuestionCount);
        return storeQuestionCount;
      }


    public virtual int extraSurveyParsingDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSurveyParsingDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSurveyParsingDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSurveyParsingDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setTitle(string new_value)
      {
        flagHasTitle = true;
        storeTitle = new_value;
      }
    public void unsetTitle()
      {
        flagHasTitle = false;
      }
    public void setCurrentQuestion(BigInteger new_value)
      {
        flagHasCurrentQuestion = true;
        if (new_value < 0)
            throw new Exception("The value for field CurrentQuestion of SurveyParsingDataJSON is less than the lower bound (0) for that field.");
        storeCurrentQuestion = new_value;
      }
    public void unsetCurrentQuestion()
      {
        flagHasCurrentQuestion = false;
      }
    public void setQuestionCount(BigInteger new_value)
      {
        flagHasQuestionCount = true;
        if (new_value < 0)
            throw new Exception("The value for field QuestionCount of SurveyParsingDataJSON is less than the lower bound (0) for that field.");
        storeQuestionCount = new_value;
      }
    public void unsetQuestionCount()
      {
        flagHasQuestionCount = false;
      }

    public virtual void extraSurveyParsingDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSurveyParsingDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSurveyParsingDataLookup(key);
        if (old_field == null)
          {
            extraSurveyParsingDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasTitle);
        if (flagHasTitle)
          {
            handler.start_pair("Title");
            handler.string_value(storeTitle);
          }
        Debug.Assert(partial_allowed || flagHasCurrentQuestion);
        if (flagHasCurrentQuestion)
          {
            handler.start_pair("CurrentQuestion");
            handler.number_value(storeCurrentQuestion);
          }
        Debug.Assert(partial_allowed || flagHasQuestionCount);
        if (flagHasQuestionCount)
          {
            handler.start_pair("QuestionCount");
            handler.number_value(storeQuestionCount);
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
        if (!(hasTitle()))
          {
            return "When parsing the object for %what%, the \"Title\" field was missing.";
          }
        if (!(hasCurrentQuestion()))
          {
            return "When parsing the object for %what%, the \"CurrentQuestion\" field was missing.";
          }
        if (!(hasQuestionCount()))
          {
            return "When parsing the object for %what%, the \"QuestionCount\" field was missing.";
          }
        return null;
      }

    public static SurveyParsingDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyParsingDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyParsingData", ignore_extras);
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
    public static SurveyParsingDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SurveyParsingDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyParsingDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyParsingData", ignore_extras);
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
    public static SurveyParsingDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SurveyParsingDataJSON from_text(string text, bool ignore_extras)
      {
        SurveyParsingDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyParsingData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SurveyParsingDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SurveyParsingDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SurveyParsingDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyParsingData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorTitle;
    private class FieldHoldingGeneratorCurrentQuestion : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorCurrentQuestion(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorCurrentQuestion : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorCurrentQuestion(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorCurrentQuestion fieldGeneratorCurrentQuestion;
    private class FieldHoldingGeneratorQuestionCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorQuestionCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorQuestionCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorQuestionCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorQuestionCount fieldGeneratorQuestionCount;
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
            SurveyParsingDataJSON result = new SurveyParsingDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSurveyParsingDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SurveyParsingDataJSON result)
          {
            if (fieldGeneratorTitle.have_value)
              {
                result.setTitle(fieldGeneratorTitle.value);
                fieldGeneratorTitle.have_value = false;
              }
            else if ((!(result.hasTitle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Title\" field was missing.");
              }
            if (fieldGeneratorCurrentQuestion.have_value)
              {
                result.setCurrentQuestion(fieldGeneratorCurrentQuestion.value);
                fieldGeneratorCurrentQuestion.have_value = false;
              }
            else if ((!(result.hasCurrentQuestion())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CurrentQuestion\" field was missing.");
              }
            if (fieldGeneratorQuestionCount.have_value)
              {
                result.setQuestionCount(fieldGeneratorQuestionCount.value);
                fieldGeneratorQuestionCount.have_value = false;
              }
            else if ((!(result.hasQuestionCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QuestionCount\" field was missing.");
              }
          }
        protected abstract void handle_result(SurveyParsingDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "urrentQuestion", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorCurrentQuestion;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "uestionCount", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorQuestionCount;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorTitle;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the SurveyParsingData class");
            fieldGeneratorCurrentQuestion = new FieldHoldingGeneratorCurrentQuestion("field \"CurrentQuestion\" of the SurveyParsingData class");
            fieldGeneratorQuestionCount = new FieldHoldingGeneratorQuestionCount("field \"QuestionCount\" of the SurveyParsingData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SurveyParsingData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the SurveyParsingData class");
            fieldGeneratorCurrentQuestion = new FieldHoldingGeneratorCurrentQuestion("field \"CurrentQuestion\" of the SurveyParsingData class");
            fieldGeneratorQuestionCount = new FieldHoldingGeneratorQuestionCount("field \"QuestionCount\" of the SurveyParsingData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SurveyParsingData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTitle.reset();
            fieldGeneratorCurrentQuestion.reset();
            fieldGeneratorQuestionCount.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SurveyParsingDataJSON  result)
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
        public SurveyParsingDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SurveyParsingDataJSON  result)
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
    protected virtual void handle_result(List<SurveyParsingDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SurveyParsingDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SurveyParsingDataJSON>();
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
    public List<SurveyParsingDataJSON> value;
  };
  };
