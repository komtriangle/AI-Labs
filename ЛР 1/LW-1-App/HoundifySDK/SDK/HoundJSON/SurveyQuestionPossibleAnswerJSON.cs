/* file "SurveyQuestionPossibleAnswerJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SurveyQuestionPossibleAnswerJSON : JSONBase
  {
    private bool flagHasText;
    private string storeText;
    private bool flagHasAnswerExpressions;
    private List< string > storeAnswerExpressions;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Text of SurveyQuestionPossibleAnswerJSON is not a string.");
        setText(json_string.getData());
      }


    private void  fromJSONAnswerExpressions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AnswerExpressions of SurveyQuestionPossibleAnswerJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_AnswerExpressions1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field AnswerExpressions of SurveyQuestionPossibleAnswerJSON is not a string.");
            vector_AnswerExpressions1.Add(json_string.getData());
          }
        initAnswerExpressions();
        for (int num1 = 0; num1 < vector_AnswerExpressions1.Count; ++num1)
            appendAnswerExpressions(vector_AnswerExpressions1[num1]);
        for (int num1 = 0; num1 < vector_AnswerExpressions1.Count; ++num1)
          {
          }
      }


    public SurveyQuestionPossibleAnswerJSON()
      {
        flagHasText = false;
        flagHasAnswerExpressions = false;
        storeAnswerExpressions = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasText()
      {
        return flagHasText;
      }

    public string  getText()
      {
        Debug.Assert(flagHasText);
        return storeText;
      }

    public bool  hasAnswerExpressions()
      {
        return flagHasAnswerExpressions;
      }

    public int  countOfAnswerExpressions()
      {
        Debug.Assert(flagHasAnswerExpressions);
        return storeAnswerExpressions.Count;
      }

    public string  elementOfAnswerExpressions(int element_num)
      {
        Debug.Assert(flagHasAnswerExpressions);
        return storeAnswerExpressions[element_num];
      }

    public List< string >  getAnswerExpressions()
      {
        Debug.Assert(flagHasAnswerExpressions);
        return storeAnswerExpressions;
      }


    public virtual int extraSurveyQuestionPossibleAnswerComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSurveyQuestionPossibleAnswerComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSurveyQuestionPossibleAnswerComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSurveyQuestionPossibleAnswerLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setText(string new_value)
      {
        flagHasText = true;
        storeText = new_value;
      }
    public void unsetText()
      {
        flagHasText = false;
      }
    public void initAnswerExpressions()
      {
        flagHasAnswerExpressions = true;
        storeAnswerExpressions.Clear();
      }
    public void appendAnswerExpressions(string to_append)
      {
        if (!flagHasAnswerExpressions)
          {
            flagHasAnswerExpressions = true;
            storeAnswerExpressions.Clear();
          }
        Debug.Assert(flagHasAnswerExpressions);
        storeAnswerExpressions.Add(to_append);
      }
    public void unsetAnswerExpressions()
      {
        flagHasAnswerExpressions = false;
        storeAnswerExpressions.Clear();
      }

    public virtual void extraSurveyQuestionPossibleAnswerAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSurveyQuestionPossibleAnswerSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSurveyQuestionPossibleAnswerLookup(key);
        if (old_field == null)
          {
            extraSurveyQuestionPossibleAnswerAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasText);
        if (flagHasText)
          {
            handler.start_pair("Text");
            handler.string_value(storeText);
          }
        Debug.Assert(partial_allowed || flagHasAnswerExpressions);
        if (flagHasAnswerExpressions)
          {
            handler.start_pair("AnswerExpressions");
            handler.start_array();
            for (int num1 = 0; num1 < storeAnswerExpressions.Count; ++num1)
              {
                handler.string_value(storeAnswerExpressions[num1]);
              }
            handler.finish_array();
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
        if (!(hasText()))
          {
            return "When parsing the object for %what%, the \"Text\" field was missing.";
          }
        if (!(hasAnswerExpressions()))
          {
            return "When parsing the object for %what%, the \"AnswerExpressions\" field was missing.";
          }
        return null;
      }

    public static SurveyQuestionPossibleAnswerJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyQuestionPossibleAnswerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyQuestionPossibleAnswer", ignore_extras);
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
    public static SurveyQuestionPossibleAnswerJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SurveyQuestionPossibleAnswerJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyQuestionPossibleAnswerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyQuestionPossibleAnswer", ignore_extras);
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
    public static SurveyQuestionPossibleAnswerJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SurveyQuestionPossibleAnswerJSON from_text(string text, bool ignore_extras)
      {
        SurveyQuestionPossibleAnswerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyQuestionPossibleAnswer", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SurveyQuestionPossibleAnswerJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SurveyQuestionPossibleAnswerJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SurveyQuestionPossibleAnswerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyQuestionPossibleAnswer", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorText;
        private JSONHoldingStringArrayGenerator fieldGeneratorAnswerExpressions;
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
            SurveyQuestionPossibleAnswerJSON result = new SurveyQuestionPossibleAnswerJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSurveyQuestionPossibleAnswerAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SurveyQuestionPossibleAnswerJSON result)
          {
            if (fieldGeneratorText.have_value)
              {
                result.setText(fieldGeneratorText.value);
                fieldGeneratorText.have_value = false;
              }
            else if ((!(result.hasText())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Text\" field was missing.");
              }
            if (fieldGeneratorAnswerExpressions.have_value)
              {
                result.initAnswerExpressions();
                int count = fieldGeneratorAnswerExpressions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAnswerExpressions(fieldGeneratorAnswerExpressions.value[num]);
                  }
                fieldGeneratorAnswerExpressions.value.Clear();
                fieldGeneratorAnswerExpressions.have_value = false;
              }
            else if ((!(result.hasAnswerExpressions())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AnswerExpressions\" field was missing.");
              }
          }
        protected abstract void handle_result(SurveyQuestionPossibleAnswerJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "nswerExpressions", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorAnswerExpressions;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ext", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorText;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the SurveyQuestionPossibleAnswer class");
            fieldGeneratorAnswerExpressions = new JSONHoldingStringArrayGenerator("field \"AnswerExpressions\" of the SurveyQuestionPossibleAnswer class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SurveyQuestionPossibleAnswer class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the SurveyQuestionPossibleAnswer class");
            fieldGeneratorAnswerExpressions = new JSONHoldingStringArrayGenerator("field \"AnswerExpressions\" of the SurveyQuestionPossibleAnswer class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SurveyQuestionPossibleAnswer class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorText.reset();
            fieldGeneratorAnswerExpressions.reset();
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
        protected override void handle_result(SurveyQuestionPossibleAnswerJSON  result)
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
        public SurveyQuestionPossibleAnswerJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SurveyQuestionPossibleAnswerJSON  result)
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
    protected virtual void handle_result(List<SurveyQuestionPossibleAnswerJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SurveyQuestionPossibleAnswerJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SurveyQuestionPossibleAnswerJSON>();
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
    public List<SurveyQuestionPossibleAnswerJSON> value;
  };
  };
