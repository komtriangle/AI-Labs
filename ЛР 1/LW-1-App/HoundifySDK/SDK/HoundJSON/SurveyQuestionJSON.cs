/* file "SurveyQuestionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class SurveyQuestionJSON : JSONBase
  {
    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasComment;
    private string storeComment;
    private bool flagHasIsOptional;
    private bool storeIsOptional;
    private bool flagHasMedia;
    private SurveyMediaJSON  storeMedia;


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of SurveyQuestionJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONComment(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Comment of SurveyQuestionJSON is not a string.");
        setComment(json_string.getData());
      }


    private void  fromJSONIsOptional(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsOptional of SurveyQuestionJSON is not true for false.");
              }
          }
        setIsOptional(the_bool);
      }


    private void  fromJSONMedia(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SurveyMediaJSON convert_classy = SurveyMediaJSON.from_json(json_value, ignore_extras, true);
        setMedia(convert_classy);
      }


    public SurveyQuestionJSON()
      {
        flagHasTitle = false;
        flagHasComment = false;
        flagHasIsOptional = false;
        flagHasMedia = false;
      }

    public abstract string getAnswerKind();
    public bool  hasTitle()
      {
        return flagHasTitle;
      }

    public string  getTitle()
      {
        Debug.Assert(flagHasTitle);
        return storeTitle;
      }

    public bool  hasComment()
      {
        return flagHasComment;
      }

    public string  getComment()
      {
        Debug.Assert(flagHasComment);
        return storeComment;
      }

    public bool  hasIsOptional()
      {
        return flagHasIsOptional;
      }

    public bool  getIsOptional()
      {
        Debug.Assert(flagHasIsOptional);
        return storeIsOptional;
      }

    public bool  hasMedia()
      {
        return flagHasMedia;
      }

    public SurveyMediaJSON   getMedia()
      {
        Debug.Assert(flagHasMedia);
        return storeMedia;
      }


    public abstract int extraSurveyQuestionComponentCount();
    public abstract string extraSurveyQuestionComponentKey(int component_num);
    public abstract JSONValue extraSurveyQuestionComponentValue(int component_num);
    public abstract JSONValue extraSurveyQuestionLookup(string field_name);

    public void setTitle(string new_value)
      {
        flagHasTitle = true;
        storeTitle = new_value;
      }
    public void unsetTitle()
      {
        flagHasTitle = false;
      }
    public void setComment(string new_value)
      {
        flagHasComment = true;
        storeComment = new_value;
      }
    public void unsetComment()
      {
        flagHasComment = false;
      }
    public void setIsOptional(bool new_value)
      {
        flagHasIsOptional = true;
        storeIsOptional = new_value;
      }
    public void unsetIsOptional()
      {
        flagHasIsOptional = false;
      }
    public void setMedia(SurveyMediaJSON  new_value)
      {
        if (flagHasMedia)
          {
          }
        flagHasMedia = true;
        storeMedia = new_value;
      }
    public void unsetMedia()
      {
        if (flagHasMedia)
          {
          }
        flagHasMedia = false;
      }

    public abstract void extraSurveyQuestionAppendPair(string key, JSONValue new_component);
    public abstract void extraSurveyQuestionSetField(string key, JSONValue new_component);

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        handler.pair("AnswerKind", getAnswerKind());
        Debug.Assert(partial_allowed || flagHasTitle);
        if (flagHasTitle)
          {
            handler.start_pair("Title");
            handler.string_value(storeTitle);
          }
        if (flagHasComment)
          {
            handler.start_pair("Comment");
            handler.string_value(storeComment);
          }
        if (flagHasIsOptional)
          {
            handler.start_pair("IsOptional");
            handler.boolean_value(storeIsOptional);
          }
        if (flagHasMedia)
          {
            handler.start_pair("Media");
            if (partial_allowed)
                storeMedia.write_partial_as_json(handler);
            else
                storeMedia.write_as_json(handler);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasTitle()))
          {
            return "When parsing the object for %what%, the \"Title\" field was missing.";
          }
        return null;
      }

    public static SurveyQuestionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyQuestion", ignore_extras);
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
    public static SurveyQuestionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SurveyQuestionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyQuestion", ignore_extras);
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
    public static SurveyQuestionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SurveyQuestionJSON from_text(string text, bool ignore_extras)
      {
        SurveyQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyQuestion", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SurveyQuestionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SurveyQuestionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SurveyQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyQuestion", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingStringGenerator fieldGeneratorComment;
        private JSONHoldingBooleanGenerator fieldGeneratorIsOptional;
        private SurveyMediaJSON.HoldingGenerator fieldGeneratorMedia;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `AnswerKind' field is missing.");
            SurveyQuestionJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSurveyQuestionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getSurveyQuestionJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `AnswerKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(SurveyQuestionJSON result)
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
            if (fieldGeneratorComment.have_value)
              {
                result.setComment(fieldGeneratorComment.value);
                fieldGeneratorComment.have_value = false;
              }
            if (fieldGeneratorIsOptional.have_value)
              {
                result.setIsOptional(fieldGeneratorIsOptional.value);
                fieldGeneratorIsOptional.have_value = false;
              }
            if (fieldGeneratorMedia.have_value)
              {
                result.setMedia(fieldGeneratorMedia.value);
                fieldGeneratorMedia.have_value = false;
              }
          }
        protected abstract void handle_result(SurveyQuestionJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "nswerKind", 0, 9, false) == 0) && (field_name.Length == 10))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "omment", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorComment;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sOptional", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorIsOptional;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "edia", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorMedia;
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
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the SurveyQuestion class");
            fieldGeneratorComment = new JSONHoldingStringGenerator("field \"Comment\" of the SurveyQuestion class");
            fieldGeneratorIsOptional = new JSONHoldingBooleanGenerator("field \"IsOptional\" of the SurveyQuestion class");
            fieldGeneratorMedia = new SurveyMediaJSON.HoldingGenerator("field \"Media\" of the SurveyQuestion class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"AnswerKind\" of the SurveyQuestion class");
            set_what("the SurveyQuestion class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the SurveyQuestion class");
            fieldGeneratorComment = new JSONHoldingStringGenerator("field \"Comment\" of the SurveyQuestion class");
            fieldGeneratorIsOptional = new JSONHoldingBooleanGenerator("field \"IsOptional\" of the SurveyQuestion class");
            fieldGeneratorMedia = new SurveyMediaJSON.HoldingGenerator("field \"Media\" of the SurveyQuestion class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"AnswerKind\" of the SurveyQuestion class");
            set_what("the SurveyQuestion class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTitle.reset();
            fieldGeneratorComment.reset();
            fieldGeneratorIsOptional.reset();
            fieldGeneratorMedia.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorMedia.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorMedia.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SurveyQuestionJSON  result)
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
        public SurveyQuestionJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SurveyQuestionJSON  result)
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
    protected virtual void handle_result(List<SurveyQuestionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SurveyQuestionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SurveyQuestionJSON>();
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
    public List<SurveyQuestionJSON> value;
  };
    class GenericSurveyQuestionJSON : SurveyQuestionJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericSurveyQuestionJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getAnswerKind()  { return key; }
        public override int extraSurveyQuestionComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraSurveyQuestionComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraSurveyQuestionComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraSurveyQuestionLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraSurveyQuestionAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraSurveyQuestionSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraSurveyQuestionLookup(key);
            if (old_field == null)
              {
                extraSurveyQuestionAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static SurveyQuestionJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "Survey", 0, 6, false) == 0)
      {
        switch (key[6])
          {
            case 'C':
                if ((String.Compare(key, 7, "hoice", 0, 5, false) == 0) && (key.Length == 12))
                    return new SurveyChoiceQuestionJSON();
                break;
            case 'F':
                if ((String.Compare(key, 7, "reeText", 0, 7, false) == 0) && (key.Length == 14))
                    return new SurveyTextQuestionJSON();
                break;
            case 'S':
                if ((String.Compare(key, 7, "cale", 0, 4, false) == 0) && (key.Length == 11))
                    return new SurveyScaleQuestionJSON();
                break;
            default:
                break;
          }
      }

        return new GenericSurveyQuestionJSON(key);
      }
  };
