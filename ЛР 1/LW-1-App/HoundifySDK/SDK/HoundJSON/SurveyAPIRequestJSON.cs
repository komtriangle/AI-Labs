/* file "SurveyAPIRequestJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SurveyAPIRequestJSON : JSONBase
  {
    private bool flagHasSurvey;
    private SurveyJSON  storeSurvey;
    private bool flagHasSurveyId;
    private BigInteger storeSurveyId;
    private bool flagHasQuestionIndex;
    private BigInteger storeQuestionIndex;
    private bool flagHasQuestion;
    private SurveyQuestionJSON  storeQuestion;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSurvey(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SurveyJSON convert_classy = SurveyJSON.from_json(json_value, ignore_extras, true);
        setSurvey(convert_classy);
      }


    private void  fromJSONSurveyId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SurveyId of SurveyAPIRequestJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SurveyId of SurveyAPIRequestJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSurveyId(extracted_integer);
      }


    private void  fromJSONQuestionIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field QuestionIndex of SurveyAPIRequestJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field QuestionIndex of SurveyAPIRequestJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setQuestionIndex(extracted_integer);
      }


    private void  fromJSONQuestion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SurveyQuestionJSON convert_classy = SurveyQuestionJSON.from_json(json_value, ignore_extras, true);
        setQuestion(convert_classy);
      }


    public SurveyAPIRequestJSON()
      {
        flagHasSurvey = false;
        flagHasSurveyId = false;
        flagHasQuestionIndex = false;
        flagHasQuestion = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSurvey()
      {
        return flagHasSurvey;
      }

    public SurveyJSON   getSurvey()
      {
        Debug.Assert(flagHasSurvey);
        return storeSurvey;
      }

    public bool  hasSurveyId()
      {
        return flagHasSurveyId;
      }

    public BigInteger  getSurveyId()
      {
        Debug.Assert(flagHasSurveyId);
        return storeSurveyId;
      }

    public bool  hasQuestionIndex()
      {
        return flagHasQuestionIndex;
      }

    public BigInteger  getQuestionIndex()
      {
        Debug.Assert(flagHasQuestionIndex);
        return storeQuestionIndex;
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


    public virtual int extraSurveyAPIRequestComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSurveyAPIRequestComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSurveyAPIRequestComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSurveyAPIRequestLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSurvey(SurveyJSON  new_value)
      {
        if (flagHasSurvey)
          {
          }
        flagHasSurvey = true;
        storeSurvey = new_value;
      }
    public void unsetSurvey()
      {
        if (flagHasSurvey)
          {
          }
        flagHasSurvey = false;
      }
    public void setSurveyId(BigInteger new_value)
      {
        flagHasSurveyId = true;
        if (new_value < 0)
            throw new Exception("The value for field SurveyId of SurveyAPIRequestJSON is less than the lower bound (0) for that field.");
        storeSurveyId = new_value;
      }
    public void unsetSurveyId()
      {
        flagHasSurveyId = false;
      }
    public void setQuestionIndex(BigInteger new_value)
      {
        flagHasQuestionIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field QuestionIndex of SurveyAPIRequestJSON is less than the lower bound (0) for that field.");
        storeQuestionIndex = new_value;
      }
    public void unsetQuestionIndex()
      {
        flagHasQuestionIndex = false;
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

    public virtual void extraSurveyAPIRequestAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSurveyAPIRequestSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSurveyAPIRequestLookup(key);
        if (old_field == null)
          {
            extraSurveyAPIRequestAppendPair(key, new_component);
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
        if (flagHasSurvey)
          {
            handler.start_pair("Survey");
            if (partial_allowed)
                storeSurvey.write_partial_as_json(handler);
            else
                storeSurvey.write_as_json(handler);
          }
        if (flagHasSurveyId)
          {
            handler.start_pair("SurveyId");
            handler.number_value(storeSurveyId);
          }
        if (flagHasQuestionIndex)
          {
            handler.start_pair("QuestionIndex");
            handler.number_value(storeQuestionIndex);
          }
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

    public static SurveyAPIRequestJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyAPIRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyAPIRequest", ignore_extras);
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
    public static SurveyAPIRequestJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SurveyAPIRequestJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyAPIRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyAPIRequest", ignore_extras);
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
    public static SurveyAPIRequestJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SurveyAPIRequestJSON from_text(string text, bool ignore_extras)
      {
        SurveyAPIRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyAPIRequest", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SurveyAPIRequestJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SurveyAPIRequestJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SurveyAPIRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyAPIRequest", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SurveyJSON.HoldingGenerator fieldGeneratorSurvey;
    private class FieldHoldingGeneratorSurveyId : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSurveyId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSurveyId : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSurveyId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSurveyId fieldGeneratorSurveyId;
    private class FieldHoldingGeneratorQuestionIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorQuestionIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorQuestionIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorQuestionIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorQuestionIndex fieldGeneratorQuestionIndex;
        private SurveyQuestionJSON.HoldingGenerator fieldGeneratorQuestion;
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
            SurveyAPIRequestJSON result = new SurveyAPIRequestJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSurveyAPIRequestAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SurveyAPIRequestJSON result)
          {
            if (fieldGeneratorSurvey.have_value)
              {
                result.setSurvey(fieldGeneratorSurvey.value);
                fieldGeneratorSurvey.have_value = false;
              }
            if (fieldGeneratorSurveyId.have_value)
              {
                result.setSurveyId(fieldGeneratorSurveyId.value);
                fieldGeneratorSurveyId.have_value = false;
              }
            if (fieldGeneratorQuestionIndex.have_value)
              {
                result.setQuestionIndex(fieldGeneratorQuestionIndex.value);
                fieldGeneratorQuestionIndex.have_value = false;
              }
            if (fieldGeneratorQuestion.have_value)
              {
                result.setQuestion(fieldGeneratorQuestion.value);
                fieldGeneratorQuestion.have_value = false;
              }
          }
        protected abstract void handle_result(SurveyAPIRequestJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'Q':
                    if (String.Compare(field_name, 1, "uestion", 0, 7, false) == 0)
                      {
                        if (field_name.Length == 8)
                          {
                            return fieldGeneratorQuestion;
                          }
                        switch (field_name[8])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 9, "ndex", 0, 4, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorQuestionIndex;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "urvey", 0, 5, false) == 0)
                      {
                        if (field_name.Length == 6)
                          {
                            return fieldGeneratorSurvey;
                          }
                        switch (field_name[6])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 7, "d", 0, 1, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorSurveyId;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSurvey = new SurveyJSON.HoldingGenerator("field \"Survey\" of the SurveyAPIRequest class", ignore_extras);
            fieldGeneratorSurveyId = new FieldHoldingGeneratorSurveyId("field \"SurveyId\" of the SurveyAPIRequest class");
            fieldGeneratorQuestionIndex = new FieldHoldingGeneratorQuestionIndex("field \"QuestionIndex\" of the SurveyAPIRequest class");
            fieldGeneratorQuestion = new SurveyQuestionJSON.HoldingGenerator("field \"Question\" of the SurveyAPIRequest class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SurveyAPIRequest class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSurvey = new SurveyJSON.HoldingGenerator("field \"Survey\" of the SurveyAPIRequest class", false);
            fieldGeneratorSurveyId = new FieldHoldingGeneratorSurveyId("field \"SurveyId\" of the SurveyAPIRequest class");
            fieldGeneratorQuestionIndex = new FieldHoldingGeneratorQuestionIndex("field \"QuestionIndex\" of the SurveyAPIRequest class");
            fieldGeneratorQuestion = new SurveyQuestionJSON.HoldingGenerator("field \"Question\" of the SurveyAPIRequest class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SurveyAPIRequest class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSurvey.reset();
            fieldGeneratorSurveyId.reset();
            fieldGeneratorQuestionIndex.reset();
            fieldGeneratorQuestion.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSurvey.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorQuestion.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSurvey.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorQuestion.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SurveyAPIRequestJSON  result)
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
        public SurveyAPIRequestJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SurveyAPIRequestJSON  result)
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
    protected virtual void handle_result(List<SurveyAPIRequestJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SurveyAPIRequestJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SurveyAPIRequestJSON>();
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
    public List<SurveyAPIRequestJSON> value;
  };
  };
