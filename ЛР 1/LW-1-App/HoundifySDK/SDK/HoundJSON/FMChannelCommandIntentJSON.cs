/* file "FMChannelCommandIntentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FMChannelCommandIntentJSON : RadioCommandIntentJSON
  {
    private bool flagHasChannel;
    private double storeChannel;
    private string textStoreChannel;
    private bool flagHasHDSpecified;
    private bool storeHDSpecified;
    private bool flagHasTuningTarget;
    private TuningTargetJSON  storeTuningTarget;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraChannelToJSON()
      {
        JSONValue generated_rational_Channel;
        if (textStoreChannel != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreChannel);
            generated_rational_Channel = handler.result;
          }
        else if (((double)(long)storeChannel) == storeChannel)
            generated_rational_Channel = new JSONIntegerValue((long)(storeChannel));
        else
            generated_rational_Channel = new JSONRationalValue(storeChannel, 15);
        return generated_rational_Channel;
      }

    private JSONValue  extraHDSpecifiedToJSON()
      {
        JSONValue generated_boolean_HDSpecified = (storeHDSpecified ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_HDSpecified;
      }

    private JSONValue  extraTuningTargetToJSON()
      {
        JSONValueHandler handler_TuningTarget = new JSONValueHandler();
        storeTuningTarget.write_as_json(handler_TuningTarget);
        return handler_TuningTarget.result;
      }


    private void  fromJSONChannel(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Channel of FMChannelCommandIntentJSON is not a number.");
              }
          }
        setChannelText(the_rational_text);
      }


    private void  fromJSONHDSpecified(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HDSpecified of FMChannelCommandIntentJSON is not true for false.");
              }
          }
        setHDSpecified(the_bool);
      }


    private void  fromJSONTuningTarget(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TuningTargetJSON convert_classy = TuningTargetJSON.from_json(json_value, ignore_extras, true);
        setTuningTarget(convert_classy);
      }


    public FMChannelCommandIntentJSON()
      {
        flagHasChannel = false;
        flagHasHDSpecified = false;
        flagHasTuningTarget = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRadioIntentKind()
      {
        return "FMChannel";
      }

    public bool  hasChannel()
      {
        return flagHasChannel;
      }

    public double  getChannel()
      {
        Debug.Assert(flagHasChannel);
        if (textStoreChannel != "")
          {
            return Double.Parse(textStoreChannel);
          }
        return storeChannel;
      }

    public string  getChannelAsText()
      {
        Debug.Assert(flagHasChannel);
        if (textStoreChannel == "")
          {
            return Convert.ToString(storeChannel);
          }
        else
          {
            return (textStoreChannel);
          }
      }

    public bool  hasHDSpecified()
      {
        return flagHasHDSpecified;
      }

    public bool  getHDSpecified()
      {
        Debug.Assert(flagHasHDSpecified);
        return storeHDSpecified;
      }

    public bool  hasTuningTarget()
      {
        return flagHasTuningTarget;
      }

    public TuningTargetJSON   getTuningTarget()
      {
        Debug.Assert(flagHasTuningTarget);
        return storeTuningTarget;
      }


    public virtual int extraFMChannelCommandIntentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFMChannelCommandIntentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFMChannelCommandIntentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFMChannelCommandIntentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRadioCommandIntentComponentCount()
      {
        int result = 0;
        if (flagHasChannel)
            ++result;
        if (flagHasHDSpecified)
            ++result;
        if (flagHasTuningTarget)
            ++result;
        result += extraFMChannelCommandIntentComponentCount();
        return result;
      }
    public override string extraRadioCommandIntentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasChannel)
          {
            if (remainder == 0)
                return "Channel";
            --remainder;
          }
        if (flagHasHDSpecified)
          {
            if (remainder == 0)
                return "HDSpecified";
            --remainder;
          }
        if (flagHasTuningTarget)
          {
            if (remainder == 0)
                return "TuningTarget";
            --remainder;
          }
        return extraFMChannelCommandIntentComponentKey(remainder);
      }
    public override JSONValue extraRadioCommandIntentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasChannel)
          {
            if (remainder == 0)
                return extraChannelToJSON();
            --remainder;
          }
        if (flagHasHDSpecified)
          {
            if (remainder == 0)
                return extraHDSpecifiedToJSON();
            --remainder;
          }
        if (flagHasTuningTarget)
          {
            if (remainder == 0)
                return extraTuningTargetToJSON();
            --remainder;
          }
        return extraFMChannelCommandIntentComponentValue(remainder);
      }
    public override JSONValue extraRadioCommandIntentLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "hannel", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasChannel ? extraChannelToJSON() : null);
                break;
            case 'H':
                if ((String.Compare(field_name, 1, "DSpecified", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasHDSpecified ? extraHDSpecifiedToJSON() : null);
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "uningTarget", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasTuningTarget ? extraTuningTargetToJSON() : null);
                break;
            default:
                break;
          }
        return extraFMChannelCommandIntentLookup(field_name);
      }

    public void setChannel(double new_value)
      {
        flagHasChannel = true;
        if (new_value < 65.8)
            throw new Exception("The value for field Channel of FMChannelCommandIntentJSON is less than the lower bound (65.8) for that field.");
        if (new_value > 108)
            throw new Exception("The value for field Channel of FMChannelCommandIntentJSON is greater than the upper bound (108) for that field.");
        storeChannel = new_value;
        textStoreChannel = "";
      }
    public void setChannelText(string new_value)
      {
        flagHasChannel = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Channel of FMChannelCommandIntentJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "658", "", false, "2") < 0)
            throw new Exception("The value for field Channel of FMChannelCommandIntentJSON is less than the lower bound (65.8) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "108", "", false, "3") > 0)
            throw new Exception("The value for field Channel of FMChannelCommandIntentJSON is greater than the upper bound (108) for that field.");
        textStoreChannel = new_value;
      }
    public void unsetChannel()
      {
        flagHasChannel = false;
      }
    public void setHDSpecified(bool new_value)
      {
        flagHasHDSpecified = true;
        storeHDSpecified = new_value;
      }
    public void unsetHDSpecified()
      {
        flagHasHDSpecified = false;
      }
    public void setTuningTarget(TuningTargetJSON  new_value)
      {
        if (flagHasTuningTarget)
          {
          }
        flagHasTuningTarget = true;
        storeTuningTarget = new_value;
      }
    public void unsetTuningTarget()
      {
        if (flagHasTuningTarget)
          {
          }
        flagHasTuningTarget = false;
      }

    public virtual void extraFMChannelCommandIntentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFMChannelCommandIntentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFMChannelCommandIntentLookup(key);
        if (old_field == null)
          {
            extraFMChannelCommandIntentAppendPair(key, new_component);
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
    public override void extraRadioCommandIntentAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hannel", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONChannel(new_component, false);
                    return;
                    }
                break;
            case 'H':
                if ((String.Compare(key, 1, "DSpecified", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONHDSpecified(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "uningTarget", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONTuningTarget(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraFMChannelCommandIntentAppendPair(key, new_component);
      }
    public override void extraRadioCommandIntentSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hannel", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONChannel(new_component, false);
                    return;
                    }
                break;
            case 'H':
                if ((String.Compare(key, 1, "DSpecified", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONHDSpecified(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "uningTarget", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONTuningTarget(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraFMChannelCommandIntentSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasChannel);
        if (flagHasChannel)
          {
            handler.start_pair("Channel");
            if (textStoreChannel != "")
                handler.number_value(textStoreChannel);
            else if (((double)(long)storeChannel) == storeChannel)
                handler.number_value((long)storeChannel);
            else
                handler.number_value(storeChannel);
          }
        Debug.Assert(partial_allowed || flagHasHDSpecified);
        if (flagHasHDSpecified)
          {
            handler.start_pair("HDSpecified");
            handler.boolean_value(storeHDSpecified);
          }
        if (flagHasTuningTarget)
          {
            handler.start_pair("TuningTarget");
            if (partial_allowed)
                storeTuningTarget.write_partial_as_json(handler);
            else
                storeTuningTarget.write_as_json(handler);
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
        if (!(hasChannel()))
          {
            return "When parsing the object for %what%, the \"Channel\" field was missing.";
          }
        if (!(hasHDSpecified()))
          {
            return "When parsing the object for %what%, the \"HDSpecified\" field was missing.";
          }
        return null;
      }

    public static new FMChannelCommandIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FMChannelCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FMChannelCommandIntent", ignore_extras);
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
    public static new FMChannelCommandIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FMChannelCommandIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FMChannelCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FMChannelCommandIntent", ignore_extras);
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
    public static new FMChannelCommandIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FMChannelCommandIntentJSON from_text(string text, bool ignore_extras)
      {
        FMChannelCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FMChannelCommandIntent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FMChannelCommandIntentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new FMChannelCommandIntentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FMChannelCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FMChannelCommandIntent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RadioCommandIntentJSON.Generator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratorChannel;
        private JSONHoldingBooleanGenerator fieldGeneratorHDSpecified;
        private TuningTargetJSON.HoldingGenerator fieldGeneratorTuningTarget;
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
            if (!(getRadioCommandIntentJSONKey().Equals("FMChannel")))
                throw new Exception("The key field has a value other than `FMChannel'.");
            FMChannelCommandIntentJSON result = new FMChannelCommandIntentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFMChannelCommandIntentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RadioCommandIntentJSON new_result)
          {
            handle_result((FMChannelCommandIntentJSON )new_result);
          }
        protected void finish(FMChannelCommandIntentJSON result)
          {
            if (fieldGeneratorChannel.have_value)
              {
                result.setChannelText(fieldGeneratorChannel.value);
                fieldGeneratorChannel.have_value = false;
              }
            else if ((!(result.hasChannel())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Channel\" field was missing.");
              }
            if (fieldGeneratorHDSpecified.have_value)
              {
                result.setHDSpecified(fieldGeneratorHDSpecified.value);
                fieldGeneratorHDSpecified.have_value = false;
              }
            else if ((!(result.hasHDSpecified())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"HDSpecified\" field was missing.");
              }
            if (fieldGeneratorTuningTarget.have_value)
              {
                result.setTuningTarget(fieldGeneratorTuningTarget.value);
                fieldGeneratorTuningTarget.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(FMChannelCommandIntentJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "hannel", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorChannel;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "DSpecified", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorHDSpecified;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "uningTarget", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorTuningTarget;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorChannel = new JSONHoldingNumberTextGenerator("field \"Channel\" of the FMChannelCommandIntent class");
            fieldGeneratorHDSpecified = new JSONHoldingBooleanGenerator("field \"HDSpecified\" of the FMChannelCommandIntent class");
            fieldGeneratorTuningTarget = new TuningTargetJSON.HoldingGenerator("field \"TuningTarget\" of the FMChannelCommandIntent class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FMChannelCommandIntent class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorChannel = new JSONHoldingNumberTextGenerator("field \"Channel\" of the FMChannelCommandIntent class");
            fieldGeneratorHDSpecified = new JSONHoldingBooleanGenerator("field \"HDSpecified\" of the FMChannelCommandIntent class");
            fieldGeneratorTuningTarget = new TuningTargetJSON.HoldingGenerator("field \"TuningTarget\" of the FMChannelCommandIntent class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FMChannelCommandIntent class");
          }

        public override void reset()
          {
            fieldGeneratorChannel.reset();
            fieldGeneratorHDSpecified.reset();
            fieldGeneratorTuningTarget.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(FMChannelCommandIntentJSON  result)
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
        public FMChannelCommandIntentJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FMChannelCommandIntentJSON  result)
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
    protected virtual void handle_result(List<FMChannelCommandIntentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FMChannelCommandIntentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FMChannelCommandIntentJSON>();
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
    public List<FMChannelCommandIntentJSON> value;
  };
  };
