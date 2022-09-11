/* file "VoiceActivityDetectionMinimaJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class VoiceActivityDetectionMinimaJSON : JSONBase
  {
    private bool flagHasMaxSilenceSeconds;
    private double storeMaxSilenceSeconds;
    private string textStoreMaxSilenceSeconds;
    private bool flagHasMaxSilenceAfterFullQuerySeconds;
    private double storeMaxSilenceAfterFullQuerySeconds;
    private string textStoreMaxSilenceAfterFullQuerySeconds;
    private bool flagHasMaxSilenceAfterPartialQuerySeconds;
    private double storeMaxSilenceAfterPartialQuerySeconds;
    private string textStoreMaxSilenceAfterPartialQuerySeconds;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONMaxSilenceSeconds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field MaxSilenceSeconds of VoiceActivityDetectionMinimaJSON is not a number.");
              }
          }
        setMaxSilenceSecondsText(the_rational_text);
      }


    private void  fromJSONMaxSilenceAfterFullQuerySeconds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field MaxSilenceAfterFullQuerySeconds of VoiceActivityDetectionMinimaJSON is not a number.");
              }
          }
        setMaxSilenceAfterFullQuerySecondsText(the_rational_text);
      }


    private void  fromJSONMaxSilenceAfterPartialQuerySeconds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field MaxSilenceAfterPartialQuerySeconds of VoiceActivityDetectionMinimaJSON is not a number.");
              }
          }
        setMaxSilenceAfterPartialQuerySecondsText(the_rational_text);
      }


    public VoiceActivityDetectionMinimaJSON()
      {
        flagHasMaxSilenceSeconds = false;
        flagHasMaxSilenceAfterFullQuerySeconds = false;
        flagHasMaxSilenceAfterPartialQuerySeconds = false;
        storeMaxSilenceSeconds = 0;
        storeMaxSilenceAfterFullQuerySeconds = 0;
        storeMaxSilenceAfterPartialQuerySeconds = 0;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasMaxSilenceSeconds()
      {
        return flagHasMaxSilenceSeconds;
      }

    public double  getMaxSilenceSeconds()
      {
        if (textStoreMaxSilenceSeconds != "")
          {
            return Double.Parse(textStoreMaxSilenceSeconds);
          }
        return storeMaxSilenceSeconds;
      }

    public string  getMaxSilenceSecondsAsText()
      {
        if (textStoreMaxSilenceSeconds == "")
          {
            return Convert.ToString(storeMaxSilenceSeconds);
          }
        else
          {
            return (textStoreMaxSilenceSeconds);
          }
      }

    public bool  hasMaxSilenceAfterFullQuerySeconds()
      {
        return flagHasMaxSilenceAfterFullQuerySeconds;
      }

    public double  getMaxSilenceAfterFullQuerySeconds()
      {
        if (textStoreMaxSilenceAfterFullQuerySeconds != "")
          {
            return Double.Parse(textStoreMaxSilenceAfterFullQuerySeconds);
          }
        return storeMaxSilenceAfterFullQuerySeconds;
      }

    public string  getMaxSilenceAfterFullQuerySecondsAsText()
      {
        if (textStoreMaxSilenceAfterFullQuerySeconds == "")
          {
            return Convert.ToString(storeMaxSilenceAfterFullQuerySeconds);
          }
        else
          {
            return (textStoreMaxSilenceAfterFullQuerySeconds);
          }
      }

    public bool  hasMaxSilenceAfterPartialQuerySeconds()
      {
        return flagHasMaxSilenceAfterPartialQuerySeconds;
      }

    public double  getMaxSilenceAfterPartialQuerySeconds()
      {
        if (textStoreMaxSilenceAfterPartialQuerySeconds != "")
          {
            return Double.Parse(textStoreMaxSilenceAfterPartialQuerySeconds);
          }
        return storeMaxSilenceAfterPartialQuerySeconds;
      }

    public string  getMaxSilenceAfterPartialQuerySecondsAsText()
      {
        if (textStoreMaxSilenceAfterPartialQuerySeconds == "")
          {
            return Convert.ToString(storeMaxSilenceAfterPartialQuerySeconds);
          }
        else
          {
            return (textStoreMaxSilenceAfterPartialQuerySeconds);
          }
      }


    public virtual int extraVoiceActivityDetectionMinimaComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraVoiceActivityDetectionMinimaComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraVoiceActivityDetectionMinimaComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraVoiceActivityDetectionMinimaLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setMaxSilenceSeconds(double new_value)
      {
        flagHasMaxSilenceSeconds = true;
        if (new_value < 0)
            throw new Exception("The value for field MaxSilenceSeconds of VoiceActivityDetectionMinimaJSON is less than the lower bound (0) for that field.");
        storeMaxSilenceSeconds = new_value;
        textStoreMaxSilenceSeconds = "";
      }
    public void setMaxSilenceSecondsText(string new_value)
      {
        flagHasMaxSilenceSeconds = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field MaxSilenceSeconds of VoiceActivityDetectionMinimaJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field MaxSilenceSeconds of VoiceActivityDetectionMinimaJSON is less than the lower bound (0) for that field.");
        textStoreMaxSilenceSeconds = new_value;
      }
    public void unsetMaxSilenceSeconds()
      {
        flagHasMaxSilenceSeconds = false;
      }
    public void setMaxSilenceAfterFullQuerySeconds(double new_value)
      {
        flagHasMaxSilenceAfterFullQuerySeconds = true;
        if (new_value < 0)
            throw new Exception("The value for field MaxSilenceAfterFullQuerySeconds of VoiceActivityDetectionMinimaJSON is less than the lower bound (0) for that field.");
        storeMaxSilenceAfterFullQuerySeconds = new_value;
        textStoreMaxSilenceAfterFullQuerySeconds = "";
      }
    public void setMaxSilenceAfterFullQuerySecondsText(string new_value)
      {
        flagHasMaxSilenceAfterFullQuerySeconds = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field MaxSilenceAfterFullQuerySeconds of VoiceActivityDetectionMinimaJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field MaxSilenceAfterFullQuerySeconds of VoiceActivityDetectionMinimaJSON is less than the lower bound (0) for that field.");
        textStoreMaxSilenceAfterFullQuerySeconds = new_value;
      }
    public void unsetMaxSilenceAfterFullQuerySeconds()
      {
        flagHasMaxSilenceAfterFullQuerySeconds = false;
      }
    public void setMaxSilenceAfterPartialQuerySeconds(double new_value)
      {
        flagHasMaxSilenceAfterPartialQuerySeconds = true;
        if (new_value < 0)
            throw new Exception("The value for field MaxSilenceAfterPartialQuerySeconds of VoiceActivityDetectionMinimaJSON is less than the lower bound (0) for that field.");
        storeMaxSilenceAfterPartialQuerySeconds = new_value;
        textStoreMaxSilenceAfterPartialQuerySeconds = "";
      }
    public void setMaxSilenceAfterPartialQuerySecondsText(string new_value)
      {
        flagHasMaxSilenceAfterPartialQuerySeconds = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field MaxSilenceAfterPartialQuerySeconds of VoiceActivityDetectionMinimaJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field MaxSilenceAfterPartialQuerySeconds of VoiceActivityDetectionMinimaJSON is less than the lower bound (0) for that field.");
        textStoreMaxSilenceAfterPartialQuerySeconds = new_value;
      }
    public void unsetMaxSilenceAfterPartialQuerySeconds()
      {
        flagHasMaxSilenceAfterPartialQuerySeconds = false;
      }

    public virtual void extraVoiceActivityDetectionMinimaAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraVoiceActivityDetectionMinimaSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraVoiceActivityDetectionMinimaLookup(key);
        if (old_field == null)
          {
            extraVoiceActivityDetectionMinimaAppendPair(key, new_component);
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
        if (flagHasMaxSilenceSeconds)
          {
            handler.start_pair("MaxSilenceSeconds");
            if (textStoreMaxSilenceSeconds != "")
                handler.number_value(textStoreMaxSilenceSeconds);
            else if (((double)(long)storeMaxSilenceSeconds) == storeMaxSilenceSeconds)
                handler.number_value((long)storeMaxSilenceSeconds);
            else
                handler.number_value(storeMaxSilenceSeconds);
          }
        if (flagHasMaxSilenceAfterFullQuerySeconds)
          {
            handler.start_pair("MaxSilenceAfterFullQuerySeconds");
            if (textStoreMaxSilenceAfterFullQuerySeconds != "")
                handler.number_value(textStoreMaxSilenceAfterFullQuerySeconds);
            else if (((double)(long)storeMaxSilenceAfterFullQuerySeconds) == storeMaxSilenceAfterFullQuerySeconds)
                handler.number_value((long)storeMaxSilenceAfterFullQuerySeconds);
            else
                handler.number_value(storeMaxSilenceAfterFullQuerySeconds);
          }
        if (flagHasMaxSilenceAfterPartialQuerySeconds)
          {
            handler.start_pair("MaxSilenceAfterPartialQuerySeconds");
            if (textStoreMaxSilenceAfterPartialQuerySeconds != "")
                handler.number_value(textStoreMaxSilenceAfterPartialQuerySeconds);
            else if (((double)(long)storeMaxSilenceAfterPartialQuerySeconds) == storeMaxSilenceAfterPartialQuerySeconds)
                handler.number_value((long)storeMaxSilenceAfterPartialQuerySeconds);
            else
                handler.number_value(storeMaxSilenceAfterPartialQuerySeconds);
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

    public static VoiceActivityDetectionMinimaJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        VoiceActivityDetectionMinimaJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type VoiceActivityDetectionMinima", ignore_extras);
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
    public static VoiceActivityDetectionMinimaJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static VoiceActivityDetectionMinimaJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        VoiceActivityDetectionMinimaJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type VoiceActivityDetectionMinima", ignore_extras);
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
    public static VoiceActivityDetectionMinimaJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static VoiceActivityDetectionMinimaJSON from_text(string text, bool ignore_extras)
      {
        VoiceActivityDetectionMinimaJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type VoiceActivityDetectionMinima", ignore_extras);
            JSONParse.parse_json_value(text, "Text for VoiceActivityDetectionMinimaJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static VoiceActivityDetectionMinimaJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        VoiceActivityDetectionMinimaJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type VoiceActivityDetectionMinima", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratorMaxSilenceSeconds;
        private JSONHoldingNumberTextGenerator fieldGeneratorMaxSilenceAfterFullQuerySeconds;
        private JSONHoldingNumberTextGenerator fieldGeneratorMaxSilenceAfterPartialQuerySeconds;
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
            VoiceActivityDetectionMinimaJSON result = new VoiceActivityDetectionMinimaJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraVoiceActivityDetectionMinimaAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(VoiceActivityDetectionMinimaJSON result)
          {
            if (fieldGeneratorMaxSilenceSeconds.have_value)
              {
                result.setMaxSilenceSecondsText(fieldGeneratorMaxSilenceSeconds.value);
                fieldGeneratorMaxSilenceSeconds.have_value = false;
              }
            if (fieldGeneratorMaxSilenceAfterFullQuerySeconds.have_value)
              {
                result.setMaxSilenceAfterFullQuerySecondsText(fieldGeneratorMaxSilenceAfterFullQuerySeconds.value);
                fieldGeneratorMaxSilenceAfterFullQuerySeconds.have_value = false;
              }
            if (fieldGeneratorMaxSilenceAfterPartialQuerySeconds.have_value)
              {
                result.setMaxSilenceAfterPartialQuerySecondsText(fieldGeneratorMaxSilenceAfterPartialQuerySeconds.value);
                fieldGeneratorMaxSilenceAfterPartialQuerySeconds.have_value = false;
              }
          }
        protected abstract void handle_result(VoiceActivityDetectionMinimaJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "MaxSilence", 0, 10, false) == 0)
              {
                switch (field_name[10])
                  {
                    case 'A':
                        if (String.Compare(field_name, 11, "fter", 0, 4, false) == 0)
                          {
                            switch (field_name[15])
                              {
                                case 'F':
                                    if ((String.Compare(field_name, 16, "ullQuerySeconds", 0, 15, false) == 0) && (field_name.Length == 31))
                                        return fieldGeneratorMaxSilenceAfterFullQuerySeconds;
                                    break;
                                case 'P':
                                    if ((String.Compare(field_name, 16, "artialQuerySeconds", 0, 18, false) == 0) && (field_name.Length == 34))
                                        return fieldGeneratorMaxSilenceAfterPartialQuerySeconds;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 11, "econds", 0, 6, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorMaxSilenceSeconds;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorMaxSilenceSeconds = new JSONHoldingNumberTextGenerator("field \"MaxSilenceSeconds\" of the VoiceActivityDetectionMinima class");
            fieldGeneratorMaxSilenceAfterFullQuerySeconds = new JSONHoldingNumberTextGenerator("field \"MaxSilenceAfterFullQuerySeconds\" of the VoiceActivityDetectionMinima class");
            fieldGeneratorMaxSilenceAfterPartialQuerySeconds = new JSONHoldingNumberTextGenerator("field \"MaxSilenceAfterPartialQuerySeconds\" of the VoiceActivityDetectionMinima class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the VoiceActivityDetectionMinima class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorMaxSilenceSeconds = new JSONHoldingNumberTextGenerator("field \"MaxSilenceSeconds\" of the VoiceActivityDetectionMinima class");
            fieldGeneratorMaxSilenceAfterFullQuerySeconds = new JSONHoldingNumberTextGenerator("field \"MaxSilenceAfterFullQuerySeconds\" of the VoiceActivityDetectionMinima class");
            fieldGeneratorMaxSilenceAfterPartialQuerySeconds = new JSONHoldingNumberTextGenerator("field \"MaxSilenceAfterPartialQuerySeconds\" of the VoiceActivityDetectionMinima class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the VoiceActivityDetectionMinima class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorMaxSilenceSeconds.reset();
            fieldGeneratorMaxSilenceAfterFullQuerySeconds.reset();
            fieldGeneratorMaxSilenceAfterPartialQuerySeconds.reset();
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
        protected override void handle_result(VoiceActivityDetectionMinimaJSON  result)
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
        public VoiceActivityDetectionMinimaJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(VoiceActivityDetectionMinimaJSON  result)
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
    protected virtual void handle_result(List<VoiceActivityDetectionMinimaJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<VoiceActivityDetectionMinimaJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<VoiceActivityDetectionMinimaJSON>();
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
    public List<VoiceActivityDetectionMinimaJSON> value;
  };
  };
