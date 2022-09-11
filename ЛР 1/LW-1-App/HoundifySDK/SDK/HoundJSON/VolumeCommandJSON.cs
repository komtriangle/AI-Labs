/* file "VolumeCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class VolumeCommandJSON : DeviceControlCommandJSON
  {
    private bool flagHasCommandType;
    private VolumeControlCommandTypeJSON  storeCommandType;
    private bool flagHasVolumeValue;
    private double storeVolumeValue;
    private string textStoreVolumeValue;
    private bool flagHasVolumeLevel;
    private double storeVolumeLevel;
    private string textStoreVolumeLevel;
    private bool flagHasVolumeDelta;
    private double storeVolumeDelta;
    private string textStoreVolumeDelta;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCommandTypeToJSON()
      {
        JSONValueHandler handler_CommandType = new JSONValueHandler();
        storeCommandType.write_as_json(handler_CommandType);
        return handler_CommandType.result;
      }

    private JSONValue  extraVolumeValueToJSON()
      {
        JSONValue generated_rational_VolumeValue;
        if (textStoreVolumeValue != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreVolumeValue);
            generated_rational_VolumeValue = handler.result;
          }
        else if (((double)(long)storeVolumeValue) == storeVolumeValue)
            generated_rational_VolumeValue = new JSONIntegerValue((long)(storeVolumeValue));
        else
            generated_rational_VolumeValue = new JSONRationalValue(storeVolumeValue, 15);
        return generated_rational_VolumeValue;
      }

    private JSONValue  extraVolumeLevelToJSON()
      {
        JSONValue generated_rational_VolumeLevel;
        if (textStoreVolumeLevel != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreVolumeLevel);
            generated_rational_VolumeLevel = handler.result;
          }
        else if (((double)(long)storeVolumeLevel) == storeVolumeLevel)
            generated_rational_VolumeLevel = new JSONIntegerValue((long)(storeVolumeLevel));
        else
            generated_rational_VolumeLevel = new JSONRationalValue(storeVolumeLevel, 15);
        return generated_rational_VolumeLevel;
      }

    private JSONValue  extraVolumeDeltaToJSON()
      {
        JSONValue generated_rational_VolumeDelta;
        if (textStoreVolumeDelta != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreVolumeDelta);
            generated_rational_VolumeDelta = handler.result;
          }
        else if (((double)(long)storeVolumeDelta) == storeVolumeDelta)
            generated_rational_VolumeDelta = new JSONIntegerValue((long)(storeVolumeDelta));
        else
            generated_rational_VolumeDelta = new JSONRationalValue(storeVolumeDelta, 15);
        return generated_rational_VolumeDelta;
      }


    private void  fromJSONCommandType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        VolumeControlCommandTypeJSON convert_classy = VolumeControlCommandTypeJSON.from_json(json_value, ignore_extras, true);
        setCommandType(convert_classy);
      }


    private void  fromJSONVolumeValue(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field VolumeValue of VolumeCommandJSON is not a number.");
              }
          }
        setVolumeValueText(the_rational_text);
      }


    private void  fromJSONVolumeLevel(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field VolumeLevel of VolumeCommandJSON is not a number.");
              }
          }
        setVolumeLevelText(the_rational_text);
      }


    private void  fromJSONVolumeDelta(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field VolumeDelta of VolumeCommandJSON is not a number.");
              }
          }
        setVolumeDeltaText(the_rational_text);
      }


    public VolumeCommandJSON()
      {
        flagHasCommandType = false;
        flagHasVolumeValue = false;
        flagHasVolumeLevel = false;
        flagHasVolumeDelta = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDeviceControlCommandKind()
      {
        return "VolumeCommand";
      }

    public bool  hasCommandType()
      {
        return flagHasCommandType;
      }

    public VolumeControlCommandTypeJSON   getCommandType()
      {
        Debug.Assert(flagHasCommandType);
        return storeCommandType;
      }

    public VolumeControlCommandTypeJSON.TypeValue  getCommandTypeValue()
      {
        return getCommandType().getValue();
      }

    public string  getCommandTypeAsString()
      {
        return getCommandType().getValueAsString();
      }

    public bool  hasVolumeValue()
      {
        return flagHasVolumeValue;
      }

    public double  getVolumeValue()
      {
        Debug.Assert(flagHasVolumeValue);
        if (textStoreVolumeValue != "")
          {
            return Double.Parse(textStoreVolumeValue);
          }
        return storeVolumeValue;
      }

    public string  getVolumeValueAsText()
      {
        Debug.Assert(flagHasVolumeValue);
        if (textStoreVolumeValue == "")
          {
            return Convert.ToString(storeVolumeValue);
          }
        else
          {
            return (textStoreVolumeValue);
          }
      }

    public bool  hasVolumeLevel()
      {
        return flagHasVolumeLevel;
      }

    public double  getVolumeLevel()
      {
        Debug.Assert(flagHasVolumeLevel);
        if (textStoreVolumeLevel != "")
          {
            return Double.Parse(textStoreVolumeLevel);
          }
        return storeVolumeLevel;
      }

    public string  getVolumeLevelAsText()
      {
        Debug.Assert(flagHasVolumeLevel);
        if (textStoreVolumeLevel == "")
          {
            return Convert.ToString(storeVolumeLevel);
          }
        else
          {
            return (textStoreVolumeLevel);
          }
      }

    public bool  hasVolumeDelta()
      {
        return flagHasVolumeDelta;
      }

    public double  getVolumeDelta()
      {
        Debug.Assert(flagHasVolumeDelta);
        if (textStoreVolumeDelta != "")
          {
            return Double.Parse(textStoreVolumeDelta);
          }
        return storeVolumeDelta;
      }

    public string  getVolumeDeltaAsText()
      {
        Debug.Assert(flagHasVolumeDelta);
        if (textStoreVolumeDelta == "")
          {
            return Convert.ToString(storeVolumeDelta);
          }
        else
          {
            return (textStoreVolumeDelta);
          }
      }


    public virtual int extraVolumeCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraVolumeCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraVolumeCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraVolumeCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDeviceControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasCommandType)
            ++result;
        if (flagHasVolumeValue)
            ++result;
        if (flagHasVolumeLevel)
            ++result;
        if (flagHasVolumeDelta)
            ++result;
        result += extraVolumeCommandComponentCount();
        return result;
      }
    public override string extraDeviceControlCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCommandType)
          {
            if (remainder == 0)
                return "CommandType";
            --remainder;
          }
        if (flagHasVolumeValue)
          {
            if (remainder == 0)
                return "VolumeValue";
            --remainder;
          }
        if (flagHasVolumeLevel)
          {
            if (remainder == 0)
                return "VolumeLevel";
            --remainder;
          }
        if (flagHasVolumeDelta)
          {
            if (remainder == 0)
                return "VolumeDelta";
            --remainder;
          }
        return extraVolumeCommandComponentKey(remainder);
      }
    public override JSONValue extraDeviceControlCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCommandType)
          {
            if (remainder == 0)
                return extraCommandTypeToJSON();
            --remainder;
          }
        if (flagHasVolumeValue)
          {
            if (remainder == 0)
                return extraVolumeValueToJSON();
            --remainder;
          }
        if (flagHasVolumeLevel)
          {
            if (remainder == 0)
                return extraVolumeLevelToJSON();
            --remainder;
          }
        if (flagHasVolumeDelta)
          {
            if (remainder == 0)
                return extraVolumeDeltaToJSON();
            --remainder;
          }
        return extraVolumeCommandComponentValue(remainder);
      }
    public override JSONValue extraDeviceControlCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasCommandType ? extraCommandTypeToJSON() : null);
                break;
            case 'V':
                if (String.Compare(field_name, 1, "olume", 0, 5, false) == 0)
                  {
                    switch (field_name[6])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 7, "elta", 0, 4, false) == 0) && (field_name.Length == 11))
                                return (flagHasVolumeDelta ? extraVolumeDeltaToJSON() : null);
                            break;
                        case 'L':
                            if ((String.Compare(field_name, 7, "evel", 0, 4, false) == 0) && (field_name.Length == 11))
                                return (flagHasVolumeLevel ? extraVolumeLevelToJSON() : null);
                            break;
                        case 'V':
                            if ((String.Compare(field_name, 7, "alue", 0, 4, false) == 0) && (field_name.Length == 11))
                                return (flagHasVolumeValue ? extraVolumeValueToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraVolumeCommandLookup(field_name);
      }

    public void setCommandType(VolumeControlCommandTypeJSON  new_value)
      {
        if (flagHasCommandType)
          {
          }
        flagHasCommandType = true;
        storeCommandType = new_value;
      }
    public void setCommandType(VolumeControlCommandTypeJSON.TypeValue new_value)
      {
        setCommandType(new VolumeControlCommandTypeJSON(new_value));
      }
    public void setCommandType(string chars)
      {
        setCommandType(new VolumeControlCommandTypeJSON(chars));
      }
    public void unsetCommandType()
      {
        if (flagHasCommandType)
          {
          }
        flagHasCommandType = false;
      }
    public void setVolumeValue(double new_value)
      {
        flagHasVolumeValue = true;
        if (new_value < 0)
            throw new Exception("The value for field VolumeValue of VolumeCommandJSON is less than the lower bound (0) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field VolumeValue of VolumeCommandJSON is greater than the upper bound (1) for that field.");
        storeVolumeValue = new_value;
        textStoreVolumeValue = "";
      }
    public void setVolumeValueText(string new_value)
      {
        flagHasVolumeValue = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field VolumeValue of VolumeCommandJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field VolumeValue of VolumeCommandJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
            throw new Exception("The value for field VolumeValue of VolumeCommandJSON is greater than the upper bound (1) for that field.");
        textStoreVolumeValue = new_value;
      }
    public void unsetVolumeValue()
      {
        flagHasVolumeValue = false;
      }
    public void setVolumeLevel(double new_value)
      {
        flagHasVolumeLevel = true;
        storeVolumeLevel = new_value;
        textStoreVolumeLevel = "";
      }
    public void setVolumeLevelText(string new_value)
      {
        flagHasVolumeLevel = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field VolumeLevel of VolumeCommandJSON is not a valid number.");
        textStoreVolumeLevel = new_value;
      }
    public void unsetVolumeLevel()
      {
        flagHasVolumeLevel = false;
      }
    public void setVolumeDelta(double new_value)
      {
        flagHasVolumeDelta = true;
        if (new_value < -1)
            throw new Exception("The value for field VolumeDelta of VolumeCommandJSON is less than the lower bound (-1) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field VolumeDelta of VolumeCommandJSON is greater than the upper bound (1) for that field.");
        storeVolumeDelta = new_value;
        textStoreVolumeDelta = "";
      }
    public void setVolumeDeltaText(string new_value)
      {
        flagHasVolumeDelta = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field VolumeDelta of VolumeCommandJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "1", "", false, "1") < 0)
            throw new Exception("The value for field VolumeDelta of VolumeCommandJSON is less than the lower bound (-1) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
            throw new Exception("The value for field VolumeDelta of VolumeCommandJSON is greater than the upper bound (1) for that field.");
        textStoreVolumeDelta = new_value;
      }
    public void unsetVolumeDelta()
      {
        flagHasVolumeDelta = false;
      }

    public virtual void extraVolumeCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraVolumeCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraVolumeCommandLookup(key);
        if (old_field == null)
          {
            extraVolumeCommandAppendPair(key, new_component);
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
    public override void extraDeviceControlCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ommandType", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONCommandType(new_component, false);
                    return;
                    }
                break;
            case 'V':
                if (String.Compare(key, 1, "olume", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'D':
                            if ((String.Compare(key, 7, "elta", 0, 4, false) == 0) && (key.Length == 11))
                                {
                                fromJSONVolumeDelta(new_component, false);
                                return;
                                }
                            break;
                        case 'L':
                            if ((String.Compare(key, 7, "evel", 0, 4, false) == 0) && (key.Length == 11))
                                {
                                fromJSONVolumeLevel(new_component, false);
                                return;
                                }
                            break;
                        case 'V':
                            if ((String.Compare(key, 7, "alue", 0, 4, false) == 0) && (key.Length == 11))
                                {
                                fromJSONVolumeValue(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraVolumeCommandAppendPair(key, new_component);
      }
    public override void extraDeviceControlCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ommandType", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONCommandType(new_component, false);
                    return;
                    }
                break;
            case 'V':
                if (String.Compare(key, 1, "olume", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'D':
                            if ((String.Compare(key, 7, "elta", 0, 4, false) == 0) && (key.Length == 11))
                                {
                                fromJSONVolumeDelta(new_component, false);
                                return;
                                }
                            break;
                        case 'L':
                            if ((String.Compare(key, 7, "evel", 0, 4, false) == 0) && (key.Length == 11))
                                {
                                fromJSONVolumeLevel(new_component, false);
                                return;
                                }
                            break;
                        case 'V':
                            if ((String.Compare(key, 7, "alue", 0, 4, false) == 0) && (key.Length == 11))
                                {
                                fromJSONVolumeValue(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraVolumeCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCommandType);
        if (flagHasCommandType)
          {
            handler.start_pair("CommandType");
            if (partial_allowed)
                storeCommandType.write_partial_as_json(handler);
            else
                storeCommandType.write_as_json(handler);
          }
        if (flagHasVolumeValue)
          {
            handler.start_pair("VolumeValue");
            if (textStoreVolumeValue != "")
                handler.number_value(textStoreVolumeValue);
            else if (((double)(long)storeVolumeValue) == storeVolumeValue)
                handler.number_value((long)storeVolumeValue);
            else
                handler.number_value(storeVolumeValue);
          }
        if (flagHasVolumeLevel)
          {
            handler.start_pair("VolumeLevel");
            if (textStoreVolumeLevel != "")
                handler.number_value(textStoreVolumeLevel);
            else if (((double)(long)storeVolumeLevel) == storeVolumeLevel)
                handler.number_value((long)storeVolumeLevel);
            else
                handler.number_value(storeVolumeLevel);
          }
        if (flagHasVolumeDelta)
          {
            handler.start_pair("VolumeDelta");
            if (textStoreVolumeDelta != "")
                handler.number_value(textStoreVolumeDelta);
            else if (((double)(long)storeVolumeDelta) == storeVolumeDelta)
                handler.number_value((long)storeVolumeDelta);
            else
                handler.number_value(storeVolumeDelta);
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
        if (!(hasCommandType()))
          {
            return "When parsing the object for %what%, the \"CommandType\" field was missing.";
          }
        return null;
      }

    public static new VolumeCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        VolumeCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type VolumeCommand", ignore_extras);
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
    public static new VolumeCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new VolumeCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        VolumeCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type VolumeCommand", ignore_extras);
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
    public static new VolumeCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new VolumeCommandJSON from_text(string text, bool ignore_extras)
      {
        VolumeCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type VolumeCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for VolumeCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new VolumeCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        VolumeCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type VolumeCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DeviceControlCommandJSON.Generator
      {
        private VolumeControlCommandTypeJSON.HoldingGenerator fieldGeneratorCommandType;
        private JSONHoldingNumberTextGenerator fieldGeneratorVolumeValue;
        private JSONHoldingNumberTextGenerator fieldGeneratorVolumeLevel;
        private JSONHoldingNumberTextGenerator fieldGeneratorVolumeDelta;
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
            if (!(getDeviceControlCommandJSONKey().Equals("VolumeCommand")))
                throw new Exception("The key field has a value other than `VolumeCommand'.");
            VolumeCommandJSON result = new VolumeCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraVolumeCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DeviceControlCommandJSON new_result)
          {
            handle_result((VolumeCommandJSON )new_result);
          }
        protected void finish(VolumeCommandJSON result)
          {
            if (fieldGeneratorCommandType.have_value)
              {
                result.setCommandType(fieldGeneratorCommandType.value);
                fieldGeneratorCommandType.have_value = false;
              }
            else if ((!(result.hasCommandType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CommandType\" field was missing.");
              }
            if (fieldGeneratorVolumeValue.have_value)
              {
                result.setVolumeValueText(fieldGeneratorVolumeValue.value);
                fieldGeneratorVolumeValue.have_value = false;
              }
            if (fieldGeneratorVolumeLevel.have_value)
              {
                result.setVolumeLevelText(fieldGeneratorVolumeLevel.value);
                fieldGeneratorVolumeLevel.have_value = false;
              }
            if (fieldGeneratorVolumeDelta.have_value)
              {
                result.setVolumeDeltaText(fieldGeneratorVolumeDelta.value);
                fieldGeneratorVolumeDelta.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(VolumeCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCommandType;
                    break;
                case 'V':
                    if (String.Compare(field_name, 1, "olume", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 7, "elta", 0, 4, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorVolumeDelta;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 7, "evel", 0, 4, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorVolumeLevel;
                                break;
                            case 'V':
                                if ((String.Compare(field_name, 7, "alue", 0, 4, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorVolumeValue;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCommandType = new VolumeControlCommandTypeJSON.HoldingGenerator("field \"CommandType\" of the VolumeCommand class", ignore_extras);
            fieldGeneratorVolumeValue = new JSONHoldingNumberTextGenerator("field \"VolumeValue\" of the VolumeCommand class");
            fieldGeneratorVolumeLevel = new JSONHoldingNumberTextGenerator("field \"VolumeLevel\" of the VolumeCommand class");
            fieldGeneratorVolumeDelta = new JSONHoldingNumberTextGenerator("field \"VolumeDelta\" of the VolumeCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the VolumeCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCommandType = new VolumeControlCommandTypeJSON.HoldingGenerator("field \"CommandType\" of the VolumeCommand class", false);
            fieldGeneratorVolumeValue = new JSONHoldingNumberTextGenerator("field \"VolumeValue\" of the VolumeCommand class");
            fieldGeneratorVolumeLevel = new JSONHoldingNumberTextGenerator("field \"VolumeLevel\" of the VolumeCommand class");
            fieldGeneratorVolumeDelta = new JSONHoldingNumberTextGenerator("field \"VolumeDelta\" of the VolumeCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the VolumeCommand class");
          }

        public override void reset()
          {
            fieldGeneratorCommandType.reset();
            fieldGeneratorVolumeValue.reset();
            fieldGeneratorVolumeLevel.reset();
            fieldGeneratorVolumeDelta.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(VolumeCommandJSON  result)
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
        public VolumeCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(VolumeCommandJSON  result)
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
    protected virtual void handle_result(List<VolumeCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<VolumeCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<VolumeCommandJSON>();
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
    public List<VolumeCommandJSON> value;
  };
  };
