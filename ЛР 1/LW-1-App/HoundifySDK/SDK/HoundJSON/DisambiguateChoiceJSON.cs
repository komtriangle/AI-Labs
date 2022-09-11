/* file "DisambiguateChoiceJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DisambiguateChoiceJSON : JSONBase
  {
    private bool flagHasQueryText;
    private string storeQueryText;
    private bool flagHasPrimaryText;
    private string storePrimaryText;
    private bool flagHasPrimaryTextLabel;
    private string storePrimaryTextLabel;
    private bool flagHasSecondaryText;
    private string storeSecondaryText;
    private bool flagHasSecondaryTextLabel;
    private string storeSecondaryTextLabel;
    private bool flagHasImageURL;
    private string storeImageURL;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONQueryText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QueryText of DisambiguateChoiceJSON is not a string.");
        setQueryText(json_string.getData());
      }


    private void  fromJSONPrimaryText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PrimaryText of DisambiguateChoiceJSON is not a string.");
        setPrimaryText(json_string.getData());
      }


    private void  fromJSONPrimaryTextLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PrimaryTextLabel of DisambiguateChoiceJSON is not a string.");
        setPrimaryTextLabel(json_string.getData());
      }


    private void  fromJSONSecondaryText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SecondaryText of DisambiguateChoiceJSON is not a string.");
        setSecondaryText(json_string.getData());
      }


    private void  fromJSONSecondaryTextLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SecondaryTextLabel of DisambiguateChoiceJSON is not a string.");
        setSecondaryTextLabel(json_string.getData());
      }


    private void  fromJSONImageURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ImageURL of DisambiguateChoiceJSON is not a string.");
        setImageURL(json_string.getData());
      }


    public DisambiguateChoiceJSON()
      {
        flagHasQueryText = false;
        flagHasPrimaryText = false;
        flagHasPrimaryTextLabel = false;
        flagHasSecondaryText = false;
        flagHasSecondaryTextLabel = false;
        flagHasImageURL = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasQueryText()
      {
        return flagHasQueryText;
      }

    public string  getQueryText()
      {
        Debug.Assert(flagHasQueryText);
        return storeQueryText;
      }

    public bool  hasPrimaryText()
      {
        return flagHasPrimaryText;
      }

    public string  getPrimaryText()
      {
        Debug.Assert(flagHasPrimaryText);
        return storePrimaryText;
      }

    public bool  hasPrimaryTextLabel()
      {
        return flagHasPrimaryTextLabel;
      }

    public string  getPrimaryTextLabel()
      {
        Debug.Assert(flagHasPrimaryTextLabel);
        return storePrimaryTextLabel;
      }

    public bool  hasSecondaryText()
      {
        return flagHasSecondaryText;
      }

    public string  getSecondaryText()
      {
        Debug.Assert(flagHasSecondaryText);
        return storeSecondaryText;
      }

    public bool  hasSecondaryTextLabel()
      {
        return flagHasSecondaryTextLabel;
      }

    public string  getSecondaryTextLabel()
      {
        Debug.Assert(flagHasSecondaryTextLabel);
        return storeSecondaryTextLabel;
      }

    public bool  hasImageURL()
      {
        return flagHasImageURL;
      }

    public string  getImageURL()
      {
        Debug.Assert(flagHasImageURL);
        return storeImageURL;
      }


    public virtual int extraDisambiguateChoiceComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDisambiguateChoiceComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDisambiguateChoiceComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDisambiguateChoiceLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setQueryText(string new_value)
      {
        flagHasQueryText = true;
        storeQueryText = new_value;
      }
    public void unsetQueryText()
      {
        flagHasQueryText = false;
      }
    public void setPrimaryText(string new_value)
      {
        flagHasPrimaryText = true;
        storePrimaryText = new_value;
      }
    public void unsetPrimaryText()
      {
        flagHasPrimaryText = false;
      }
    public void setPrimaryTextLabel(string new_value)
      {
        flagHasPrimaryTextLabel = true;
        storePrimaryTextLabel = new_value;
      }
    public void unsetPrimaryTextLabel()
      {
        flagHasPrimaryTextLabel = false;
      }
    public void setSecondaryText(string new_value)
      {
        flagHasSecondaryText = true;
        storeSecondaryText = new_value;
      }
    public void unsetSecondaryText()
      {
        flagHasSecondaryText = false;
      }
    public void setSecondaryTextLabel(string new_value)
      {
        flagHasSecondaryTextLabel = true;
        storeSecondaryTextLabel = new_value;
      }
    public void unsetSecondaryTextLabel()
      {
        flagHasSecondaryTextLabel = false;
      }
    public void setImageURL(string new_value)
      {
        flagHasImageURL = true;
        storeImageURL = new_value;
      }
    public void unsetImageURL()
      {
        flagHasImageURL = false;
      }

    public virtual void extraDisambiguateChoiceAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDisambiguateChoiceSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDisambiguateChoiceLookup(key);
        if (old_field == null)
          {
            extraDisambiguateChoiceAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQueryText);
        if (flagHasQueryText)
          {
            handler.start_pair("QueryText");
            handler.string_value(storeQueryText);
          }
        Debug.Assert(partial_allowed || flagHasPrimaryText);
        if (flagHasPrimaryText)
          {
            handler.start_pair("PrimaryText");
            handler.string_value(storePrimaryText);
          }
        if (flagHasPrimaryTextLabel)
          {
            handler.start_pair("PrimaryTextLabel");
            handler.string_value(storePrimaryTextLabel);
          }
        if (flagHasSecondaryText)
          {
            handler.start_pair("SecondaryText");
            handler.string_value(storeSecondaryText);
          }
        if (flagHasSecondaryTextLabel)
          {
            handler.start_pair("SecondaryTextLabel");
            handler.string_value(storeSecondaryTextLabel);
          }
        if (flagHasImageURL)
          {
            handler.start_pair("ImageURL");
            handler.string_value(storeImageURL);
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
        if (!(hasQueryText()))
          {
            return "When parsing the object for %what%, the \"QueryText\" field was missing.";
          }
        if (!(hasPrimaryText()))
          {
            return "When parsing the object for %what%, the \"PrimaryText\" field was missing.";
          }
        return null;
      }

    public static DisambiguateChoiceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisambiguateChoiceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateChoice", ignore_extras);
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
    public static DisambiguateChoiceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DisambiguateChoiceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisambiguateChoiceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateChoice", ignore_extras);
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
    public static DisambiguateChoiceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DisambiguateChoiceJSON from_text(string text, bool ignore_extras)
      {
        DisambiguateChoiceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateChoice", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DisambiguateChoiceJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DisambiguateChoiceJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DisambiguateChoiceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateChoice", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorQueryText;
        private JSONHoldingStringGenerator fieldGeneratorPrimaryText;
        private JSONHoldingStringGenerator fieldGeneratorPrimaryTextLabel;
        private JSONHoldingStringGenerator fieldGeneratorSecondaryText;
        private JSONHoldingStringGenerator fieldGeneratorSecondaryTextLabel;
        private JSONHoldingStringGenerator fieldGeneratorImageURL;
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
            DisambiguateChoiceJSON result = new DisambiguateChoiceJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDisambiguateChoiceAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DisambiguateChoiceJSON result)
          {
            if (fieldGeneratorQueryText.have_value)
              {
                result.setQueryText(fieldGeneratorQueryText.value);
                fieldGeneratorQueryText.have_value = false;
              }
            else if ((!(result.hasQueryText())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryText\" field was missing.");
              }
            if (fieldGeneratorPrimaryText.have_value)
              {
                result.setPrimaryText(fieldGeneratorPrimaryText.value);
                fieldGeneratorPrimaryText.have_value = false;
              }
            else if ((!(result.hasPrimaryText())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PrimaryText\" field was missing.");
              }
            if (fieldGeneratorPrimaryTextLabel.have_value)
              {
                result.setPrimaryTextLabel(fieldGeneratorPrimaryTextLabel.value);
                fieldGeneratorPrimaryTextLabel.have_value = false;
              }
            if (fieldGeneratorSecondaryText.have_value)
              {
                result.setSecondaryText(fieldGeneratorSecondaryText.value);
                fieldGeneratorSecondaryText.have_value = false;
              }
            if (fieldGeneratorSecondaryTextLabel.have_value)
              {
                result.setSecondaryTextLabel(fieldGeneratorSecondaryTextLabel.value);
                fieldGeneratorSecondaryTextLabel.have_value = false;
              }
            if (fieldGeneratorImageURL.have_value)
              {
                result.setImageURL(fieldGeneratorImageURL.value);
                fieldGeneratorImageURL.have_value = false;
              }
          }
        protected abstract void handle_result(DisambiguateChoiceJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "mageURL", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorImageURL;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "rimaryText", 0, 10, false) == 0)
                      {
                        if (field_name.Length == 11)
                          {
                            return fieldGeneratorPrimaryText;
                          }
                        switch (field_name[11])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 12, "abel", 0, 4, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorPrimaryTextLabel;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryText", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorQueryText;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "econdaryText", 0, 12, false) == 0)
                      {
                        if (field_name.Length == 13)
                          {
                            return fieldGeneratorSecondaryText;
                          }
                        switch (field_name[13])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 14, "abel", 0, 4, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorSecondaryTextLabel;
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
            fieldGeneratorQueryText = new JSONHoldingStringGenerator("field \"QueryText\" of the DisambiguateChoice class");
            fieldGeneratorPrimaryText = new JSONHoldingStringGenerator("field \"PrimaryText\" of the DisambiguateChoice class");
            fieldGeneratorPrimaryTextLabel = new JSONHoldingStringGenerator("field \"PrimaryTextLabel\" of the DisambiguateChoice class");
            fieldGeneratorSecondaryText = new JSONHoldingStringGenerator("field \"SecondaryText\" of the DisambiguateChoice class");
            fieldGeneratorSecondaryTextLabel = new JSONHoldingStringGenerator("field \"SecondaryTextLabel\" of the DisambiguateChoice class");
            fieldGeneratorImageURL = new JSONHoldingStringGenerator("field \"ImageURL\" of the DisambiguateChoice class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DisambiguateChoice class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQueryText = new JSONHoldingStringGenerator("field \"QueryText\" of the DisambiguateChoice class");
            fieldGeneratorPrimaryText = new JSONHoldingStringGenerator("field \"PrimaryText\" of the DisambiguateChoice class");
            fieldGeneratorPrimaryTextLabel = new JSONHoldingStringGenerator("field \"PrimaryTextLabel\" of the DisambiguateChoice class");
            fieldGeneratorSecondaryText = new JSONHoldingStringGenerator("field \"SecondaryText\" of the DisambiguateChoice class");
            fieldGeneratorSecondaryTextLabel = new JSONHoldingStringGenerator("field \"SecondaryTextLabel\" of the DisambiguateChoice class");
            fieldGeneratorImageURL = new JSONHoldingStringGenerator("field \"ImageURL\" of the DisambiguateChoice class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DisambiguateChoice class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQueryText.reset();
            fieldGeneratorPrimaryText.reset();
            fieldGeneratorPrimaryTextLabel.reset();
            fieldGeneratorSecondaryText.reset();
            fieldGeneratorSecondaryTextLabel.reset();
            fieldGeneratorImageURL.reset();
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
        protected override void handle_result(DisambiguateChoiceJSON  result)
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
        public DisambiguateChoiceJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DisambiguateChoiceJSON  result)
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
    protected virtual void handle_result(List<DisambiguateChoiceJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DisambiguateChoiceJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DisambiguateChoiceJSON>();
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
    public List<DisambiguateChoiceJSON> value;
  };
  };
