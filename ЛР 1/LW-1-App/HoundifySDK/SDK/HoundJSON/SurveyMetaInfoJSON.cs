/* file "SurveyMetaInfoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SurveyMetaInfoJSON : JSONBase
  {
    private bool flagHasIsAnonymous;
    private bool storeIsAnonymous;
    private bool flagHasDuration;
    private BigInteger storeDuration;
    private bool flagHasSubmissionDate;
    private DateAndOrTimeJSON  storeSubmissionDate;
    private bool flagHasUrl;
    private string storeUrl;
    private bool flagHasResultsArePublic;
    private bool storeResultsArePublic;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONIsAnonymous(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsAnonymous of SurveyMetaInfoJSON is not true for false.");
              }
          }
        setIsAnonymous(the_bool);
      }


    private void  fromJSONDuration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Duration of SurveyMetaInfoJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Duration of SurveyMetaInfoJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDuration(extracted_integer);
      }


    private void  fromJSONSubmissionDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setSubmissionDate(convert_classy);
      }


    private void  fromJSONUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Url of SurveyMetaInfoJSON is not a string.");
        setUrl(json_string.getData());
      }


    private void  fromJSONResultsArePublic(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ResultsArePublic of SurveyMetaInfoJSON is not true for false.");
              }
          }
        setResultsArePublic(the_bool);
      }


    public SurveyMetaInfoJSON()
      {
        flagHasIsAnonymous = false;
        flagHasDuration = false;
        flagHasSubmissionDate = false;
        flagHasUrl = false;
        flagHasResultsArePublic = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasIsAnonymous()
      {
        return flagHasIsAnonymous;
      }

    public bool  getIsAnonymous()
      {
        Debug.Assert(flagHasIsAnonymous);
        return storeIsAnonymous;
      }

    public bool  hasDuration()
      {
        return flagHasDuration;
      }

    public BigInteger  getDuration()
      {
        Debug.Assert(flagHasDuration);
        return storeDuration;
      }

    public bool  hasSubmissionDate()
      {
        return flagHasSubmissionDate;
      }

    public DateAndOrTimeJSON   getSubmissionDate()
      {
        Debug.Assert(flagHasSubmissionDate);
        return storeSubmissionDate;
      }

    public bool  hasUrl()
      {
        return flagHasUrl;
      }

    public string  getUrl()
      {
        Debug.Assert(flagHasUrl);
        return storeUrl;
      }

    public bool  hasResultsArePublic()
      {
        return flagHasResultsArePublic;
      }

    public bool  getResultsArePublic()
      {
        Debug.Assert(flagHasResultsArePublic);
        return storeResultsArePublic;
      }


    public virtual int extraSurveyMetaInfoComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSurveyMetaInfoComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSurveyMetaInfoComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSurveyMetaInfoLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setIsAnonymous(bool new_value)
      {
        flagHasIsAnonymous = true;
        storeIsAnonymous = new_value;
      }
    public void unsetIsAnonymous()
      {
        flagHasIsAnonymous = false;
      }
    public void setDuration(BigInteger new_value)
      {
        flagHasDuration = true;
        if (new_value < 1)
            throw new Exception("The value for field Duration of SurveyMetaInfoJSON is less than the lower bound (1) for that field.");
        storeDuration = new_value;
      }
    public void unsetDuration()
      {
        flagHasDuration = false;
      }
    public void setSubmissionDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasSubmissionDate)
          {
          }
        flagHasSubmissionDate = true;
        storeSubmissionDate = new_value;
      }
    public void unsetSubmissionDate()
      {
        if (flagHasSubmissionDate)
          {
          }
        flagHasSubmissionDate = false;
      }
    public void setUrl(string new_value)
      {
        flagHasUrl = true;
        storeUrl = new_value;
      }
    public void unsetUrl()
      {
        flagHasUrl = false;
      }
    public void setResultsArePublic(bool new_value)
      {
        flagHasResultsArePublic = true;
        storeResultsArePublic = new_value;
      }
    public void unsetResultsArePublic()
      {
        flagHasResultsArePublic = false;
      }

    public virtual void extraSurveyMetaInfoAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSurveyMetaInfoSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSurveyMetaInfoLookup(key);
        if (old_field == null)
          {
            extraSurveyMetaInfoAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasIsAnonymous);
        if (flagHasIsAnonymous)
          {
            handler.start_pair("IsAnonymous");
            handler.boolean_value(storeIsAnonymous);
          }
        if (flagHasDuration)
          {
            handler.start_pair("Duration");
            handler.number_value(storeDuration);
          }
        Debug.Assert(partial_allowed || flagHasSubmissionDate);
        if (flagHasSubmissionDate)
          {
            handler.start_pair("SubmissionDate");
            if (partial_allowed)
                storeSubmissionDate.write_partial_as_json(handler);
            else
                storeSubmissionDate.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasUrl);
        if (flagHasUrl)
          {
            handler.start_pair("Url");
            handler.string_value(storeUrl);
          }
        Debug.Assert(partial_allowed || flagHasResultsArePublic);
        if (flagHasResultsArePublic)
          {
            handler.start_pair("ResultsArePublic");
            handler.boolean_value(storeResultsArePublic);
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
        if (!(hasIsAnonymous()))
          {
            return "When parsing the object for %what%, the \"IsAnonymous\" field was missing.";
          }
        if (!(hasSubmissionDate()))
          {
            return "When parsing the object for %what%, the \"SubmissionDate\" field was missing.";
          }
        if (!(hasUrl()))
          {
            return "When parsing the object for %what%, the \"Url\" field was missing.";
          }
        if (!(hasResultsArePublic()))
          {
            return "When parsing the object for %what%, the \"ResultsArePublic\" field was missing.";
          }
        return null;
      }

    public static SurveyMetaInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyMetaInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyMetaInfo", ignore_extras);
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
    public static SurveyMetaInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SurveyMetaInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyMetaInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyMetaInfo", ignore_extras);
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
    public static SurveyMetaInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SurveyMetaInfoJSON from_text(string text, bool ignore_extras)
      {
        SurveyMetaInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyMetaInfo", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SurveyMetaInfoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SurveyMetaInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SurveyMetaInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyMetaInfo", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorIsAnonymous;
    private class FieldHoldingGeneratorDuration : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorDuration(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorDuration : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorDuration(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorDuration fieldGeneratorDuration;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorSubmissionDate;
        private JSONHoldingStringGenerator fieldGeneratorUrl;
        private JSONHoldingBooleanGenerator fieldGeneratorResultsArePublic;
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
            SurveyMetaInfoJSON result = new SurveyMetaInfoJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSurveyMetaInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SurveyMetaInfoJSON result)
          {
            if (fieldGeneratorIsAnonymous.have_value)
              {
                result.setIsAnonymous(fieldGeneratorIsAnonymous.value);
                fieldGeneratorIsAnonymous.have_value = false;
              }
            else if ((!(result.hasIsAnonymous())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsAnonymous\" field was missing.");
              }
            if (fieldGeneratorDuration.have_value)
              {
                result.setDuration(fieldGeneratorDuration.value);
                fieldGeneratorDuration.have_value = false;
              }
            if (fieldGeneratorSubmissionDate.have_value)
              {
                result.setSubmissionDate(fieldGeneratorSubmissionDate.value);
                fieldGeneratorSubmissionDate.have_value = false;
              }
            else if ((!(result.hasSubmissionDate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SubmissionDate\" field was missing.");
              }
            if (fieldGeneratorUrl.have_value)
              {
                result.setUrl(fieldGeneratorUrl.value);
                fieldGeneratorUrl.have_value = false;
              }
            else if ((!(result.hasUrl())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Url\" field was missing.");
              }
            if (fieldGeneratorResultsArePublic.have_value)
              {
                result.setResultsArePublic(fieldGeneratorResultsArePublic.value);
                fieldGeneratorResultsArePublic.have_value = false;
              }
            else if ((!(result.hasResultsArePublic())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ResultsArePublic\" field was missing.");
              }
          }
        protected abstract void handle_result(SurveyMetaInfoJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "uration", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorDuration;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sAnonymous", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorIsAnonymous;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "esultsArePublic", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorResultsArePublic;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ubmissionDate", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorSubmissionDate;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "rl", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorUrl;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorIsAnonymous = new JSONHoldingBooleanGenerator("field \"IsAnonymous\" of the SurveyMetaInfo class");
            fieldGeneratorDuration = new FieldHoldingGeneratorDuration("field \"Duration\" of the SurveyMetaInfo class");
            fieldGeneratorSubmissionDate = new DateAndOrTimeJSON.HoldingGenerator("field \"SubmissionDate\" of the SurveyMetaInfo class", ignore_extras);
            fieldGeneratorUrl = new JSONHoldingStringGenerator("field \"Url\" of the SurveyMetaInfo class");
            fieldGeneratorResultsArePublic = new JSONHoldingBooleanGenerator("field \"ResultsArePublic\" of the SurveyMetaInfo class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SurveyMetaInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorIsAnonymous = new JSONHoldingBooleanGenerator("field \"IsAnonymous\" of the SurveyMetaInfo class");
            fieldGeneratorDuration = new FieldHoldingGeneratorDuration("field \"Duration\" of the SurveyMetaInfo class");
            fieldGeneratorSubmissionDate = new DateAndOrTimeJSON.HoldingGenerator("field \"SubmissionDate\" of the SurveyMetaInfo class", false);
            fieldGeneratorUrl = new JSONHoldingStringGenerator("field \"Url\" of the SurveyMetaInfo class");
            fieldGeneratorResultsArePublic = new JSONHoldingBooleanGenerator("field \"ResultsArePublic\" of the SurveyMetaInfo class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SurveyMetaInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorIsAnonymous.reset();
            fieldGeneratorDuration.reset();
            fieldGeneratorSubmissionDate.reset();
            fieldGeneratorUrl.reset();
            fieldGeneratorResultsArePublic.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSubmissionDate.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSubmissionDate.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SurveyMetaInfoJSON  result)
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
        public SurveyMetaInfoJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SurveyMetaInfoJSON  result)
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
    protected virtual void handle_result(List<SurveyMetaInfoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SurveyMetaInfoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SurveyMetaInfoJSON>();
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
    public List<SurveyMetaInfoJSON> value;
  };
  };
