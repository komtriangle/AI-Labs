/* file "SurveyIntraQueryStateItemJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SurveyIntraQueryStateItemJSON : JSONBase
  {
    private bool flagHasSurveyId;
    private BigInteger storeSurveyId;
    private bool flagHasSurveyTitle;
    private string storeSurveyTitle;
    private bool flagHasCurrentQuestion;
    private BigInteger storeCurrentQuestion;
    private bool flagHasNextQuestion;
    private SurveyQuestionJSON  storeNextQuestion;
    private bool flagHasCurrentMode;
    private string storeCurrentMode;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


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
                throw new Exception("The value for field SurveyId of SurveyIntraQueryStateItemJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SurveyId of SurveyIntraQueryStateItemJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSurveyId(extracted_integer);
      }


    private void  fromJSONSurveyTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SurveyTitle of SurveyIntraQueryStateItemJSON is not a string.");
        setSurveyTitle(json_string.getData());
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
                throw new Exception("The value for field CurrentQuestion of SurveyIntraQueryStateItemJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CurrentQuestion of SurveyIntraQueryStateItemJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCurrentQuestion(extracted_integer);
      }


    private void  fromJSONNextQuestion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SurveyQuestionJSON convert_classy = SurveyQuestionJSON.from_json(json_value, ignore_extras, true);
        setNextQuestion(convert_classy);
      }


    private void  fromJSONCurrentMode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CurrentMode of SurveyIntraQueryStateItemJSON is not a string.");
        setCurrentMode(json_string.getData());
      }


    public SurveyIntraQueryStateItemJSON()
      {
        flagHasSurveyId = false;
        flagHasSurveyTitle = false;
        flagHasCurrentQuestion = false;
        flagHasNextQuestion = false;
        flagHasCurrentMode = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasSurveyTitle()
      {
        return flagHasSurveyTitle;
      }

    public string  getSurveyTitle()
      {
        Debug.Assert(flagHasSurveyTitle);
        return storeSurveyTitle;
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

    public bool  hasNextQuestion()
      {
        return flagHasNextQuestion;
      }

    public SurveyQuestionJSON   getNextQuestion()
      {
        Debug.Assert(flagHasNextQuestion);
        return storeNextQuestion;
      }

    public bool  hasCurrentMode()
      {
        return flagHasCurrentMode;
      }

    public string  getCurrentMode()
      {
        Debug.Assert(flagHasCurrentMode);
        return storeCurrentMode;
      }


    public virtual int extraSurveyIntraQueryStateItemComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSurveyIntraQueryStateItemComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSurveyIntraQueryStateItemComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSurveyIntraQueryStateItemLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSurveyId(BigInteger new_value)
      {
        flagHasSurveyId = true;
        if (new_value < 0)
            throw new Exception("The value for field SurveyId of SurveyIntraQueryStateItemJSON is less than the lower bound (0) for that field.");
        storeSurveyId = new_value;
      }
    public void unsetSurveyId()
      {
        flagHasSurveyId = false;
      }
    public void setSurveyTitle(string new_value)
      {
        flagHasSurveyTitle = true;
        storeSurveyTitle = new_value;
      }
    public void unsetSurveyTitle()
      {
        flagHasSurveyTitle = false;
      }
    public void setCurrentQuestion(BigInteger new_value)
      {
        flagHasCurrentQuestion = true;
        if (new_value < 0)
            throw new Exception("The value for field CurrentQuestion of SurveyIntraQueryStateItemJSON is less than the lower bound (0) for that field.");
        storeCurrentQuestion = new_value;
      }
    public void unsetCurrentQuestion()
      {
        flagHasCurrentQuestion = false;
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
    public void setCurrentMode(string new_value)
      {
        flagHasCurrentMode = true;
        storeCurrentMode = new_value;
      }
    public void unsetCurrentMode()
      {
        flagHasCurrentMode = false;
      }

    public virtual void extraSurveyIntraQueryStateItemAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSurveyIntraQueryStateItemSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSurveyIntraQueryStateItemLookup(key);
        if (old_field == null)
          {
            extraSurveyIntraQueryStateItemAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSurveyId);
        if (flagHasSurveyId)
          {
            handler.start_pair("SurveyId");
            handler.number_value(storeSurveyId);
          }
        Debug.Assert(partial_allowed || flagHasSurveyTitle);
        if (flagHasSurveyTitle)
          {
            handler.start_pair("SurveyTitle");
            handler.string_value(storeSurveyTitle);
          }
        Debug.Assert(partial_allowed || flagHasCurrentQuestion);
        if (flagHasCurrentQuestion)
          {
            handler.start_pair("CurrentQuestion");
            handler.number_value(storeCurrentQuestion);
          }
        if (flagHasNextQuestion)
          {
            handler.start_pair("NextQuestion");
            if (partial_allowed)
                storeNextQuestion.write_partial_as_json(handler);
            else
                storeNextQuestion.write_as_json(handler);
          }
        if (flagHasCurrentMode)
          {
            handler.start_pair("CurrentMode");
            handler.string_value(storeCurrentMode);
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
        if (!(hasSurveyId()))
          {
            return "When parsing the object for %what%, the \"SurveyId\" field was missing.";
          }
        if (!(hasSurveyTitle()))
          {
            return "When parsing the object for %what%, the \"SurveyTitle\" field was missing.";
          }
        if (!(hasCurrentQuestion()))
          {
            return "When parsing the object for %what%, the \"CurrentQuestion\" field was missing.";
          }
        return null;
      }

    public static SurveyIntraQueryStateItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyIntraQueryStateItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyIntraQueryStateItem", ignore_extras);
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
    public static SurveyIntraQueryStateItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SurveyIntraQueryStateItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyIntraQueryStateItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyIntraQueryStateItem", ignore_extras);
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
    public static SurveyIntraQueryStateItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SurveyIntraQueryStateItemJSON from_text(string text, bool ignore_extras)
      {
        SurveyIntraQueryStateItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyIntraQueryStateItem", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SurveyIntraQueryStateItemJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SurveyIntraQueryStateItemJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SurveyIntraQueryStateItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyIntraQueryStateItem", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
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
        private JSONHoldingStringGenerator fieldGeneratorSurveyTitle;
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
        private SurveyQuestionJSON.HoldingGenerator fieldGeneratorNextQuestion;
        private JSONHoldingStringGenerator fieldGeneratorCurrentMode;
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
            SurveyIntraQueryStateItemJSON result = new SurveyIntraQueryStateItemJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSurveyIntraQueryStateItemAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SurveyIntraQueryStateItemJSON result)
          {
            if (fieldGeneratorSurveyId.have_value)
              {
                result.setSurveyId(fieldGeneratorSurveyId.value);
                fieldGeneratorSurveyId.have_value = false;
              }
            else if ((!(result.hasSurveyId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SurveyId\" field was missing.");
              }
            if (fieldGeneratorSurveyTitle.have_value)
              {
                result.setSurveyTitle(fieldGeneratorSurveyTitle.value);
                fieldGeneratorSurveyTitle.have_value = false;
              }
            else if ((!(result.hasSurveyTitle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SurveyTitle\" field was missing.");
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
            if (fieldGeneratorNextQuestion.have_value)
              {
                result.setNextQuestion(fieldGeneratorNextQuestion.value);
                fieldGeneratorNextQuestion.have_value = false;
              }
            if (fieldGeneratorCurrentMode.have_value)
              {
                result.setCurrentMode(fieldGeneratorCurrentMode.value);
                fieldGeneratorCurrentMode.have_value = false;
              }
          }
        protected abstract void handle_result(SurveyIntraQueryStateItemJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "urrent", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'M':
                                if ((String.Compare(field_name, 8, "ode", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorCurrentMode;
                                break;
                            case 'Q':
                                if ((String.Compare(field_name, 8, "uestion", 0, 7, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorCurrentQuestion;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "extQuestion", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorNextQuestion;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "urvey", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 7, "d", 0, 1, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorSurveyId;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 7, "itle", 0, 4, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorSurveyTitle;
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
            fieldGeneratorSurveyId = new FieldHoldingGeneratorSurveyId("field \"SurveyId\" of the SurveyIntraQueryStateItem class");
            fieldGeneratorSurveyTitle = new JSONHoldingStringGenerator("field \"SurveyTitle\" of the SurveyIntraQueryStateItem class");
            fieldGeneratorCurrentQuestion = new FieldHoldingGeneratorCurrentQuestion("field \"CurrentQuestion\" of the SurveyIntraQueryStateItem class");
            fieldGeneratorNextQuestion = new SurveyQuestionJSON.HoldingGenerator("field \"NextQuestion\" of the SurveyIntraQueryStateItem class", ignore_extras);
            fieldGeneratorCurrentMode = new JSONHoldingStringGenerator("field \"CurrentMode\" of the SurveyIntraQueryStateItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SurveyIntraQueryStateItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSurveyId = new FieldHoldingGeneratorSurveyId("field \"SurveyId\" of the SurveyIntraQueryStateItem class");
            fieldGeneratorSurveyTitle = new JSONHoldingStringGenerator("field \"SurveyTitle\" of the SurveyIntraQueryStateItem class");
            fieldGeneratorCurrentQuestion = new FieldHoldingGeneratorCurrentQuestion("field \"CurrentQuestion\" of the SurveyIntraQueryStateItem class");
            fieldGeneratorNextQuestion = new SurveyQuestionJSON.HoldingGenerator("field \"NextQuestion\" of the SurveyIntraQueryStateItem class", false);
            fieldGeneratorCurrentMode = new JSONHoldingStringGenerator("field \"CurrentMode\" of the SurveyIntraQueryStateItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SurveyIntraQueryStateItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSurveyId.reset();
            fieldGeneratorSurveyTitle.reset();
            fieldGeneratorCurrentQuestion.reset();
            fieldGeneratorNextQuestion.reset();
            fieldGeneratorCurrentMode.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorNextQuestion.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorNextQuestion.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SurveyIntraQueryStateItemJSON  result)
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
        public SurveyIntraQueryStateItemJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SurveyIntraQueryStateItemJSON  result)
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
    protected virtual void handle_result(List<SurveyIntraQueryStateItemJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SurveyIntraQueryStateItemJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SurveyIntraQueryStateItemJSON>();
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
    public List<SurveyIntraQueryStateItemJSON> value;
  };
  };
