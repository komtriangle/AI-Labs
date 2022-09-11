/* file "BrightnessCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BrightnessCommandJSON : DeviceControlCommandJSON
  {
    public enum TypeCommandType
      {
        CommandType_AdjustBrightness,
        CommandType_SetBrightness,
        CommandType_InvertColorsOn,
        CommandType_InvertColorsOff,
        CommandType_NightShiftOn,
        CommandType_NightShiftOff
      };

    public static TypeCommandType  stringToCommandType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "djustBrightness", 0, 15, false) == 0) && (chars.Length == 16))
                    return TypeCommandType.CommandType_AdjustBrightness;
                break;
            case 'I':
                if (String.Compare(chars, 1, "nvertColorsO", 0, 12, false) == 0)
                  {
                    switch (chars[13])
                      {
                        case 'f':
                            if ((String.Compare(chars, 14, "f", 0, 1, false) == 0) && (chars.Length == 15))
                                return TypeCommandType.CommandType_InvertColorsOff;
                            break;
                        case 'n':
                            if (chars.Length == 14)
                                return TypeCommandType.CommandType_InvertColorsOn;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if (String.Compare(chars, 1, "ightShiftO", 0, 10, false) == 0)
                  {
                    switch (chars[11])
                      {
                        case 'f':
                            if ((String.Compare(chars, 12, "f", 0, 1, false) == 0) && (chars.Length == 13))
                                return TypeCommandType.CommandType_NightShiftOff;
                            break;
                        case 'n':
                            if (chars.Length == 12)
                                return TypeCommandType.CommandType_NightShiftOn;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(chars, 1, "etBrightness", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeCommandType.CommandType_SetBrightness;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `CommandType' is not one of the legal values.");
      }

    public static string  stringFromCommandType(TypeCommandType the_enum)
      {
        switch (the_enum)
          {
            case TypeCommandType.CommandType_AdjustBrightness:
                return "AdjustBrightness";
            case TypeCommandType.CommandType_SetBrightness:
                return "SetBrightness";
            case TypeCommandType.CommandType_InvertColorsOn:
                return "InvertColorsOn";
            case TypeCommandType.CommandType_InvertColorsOff:
                return "InvertColorsOff";
            case TypeCommandType.CommandType_NightShiftOn:
                return "NightShiftOn";
            case TypeCommandType.CommandType_NightShiftOff:
                return "NightShiftOff";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCommandType;
    private TypeCommandType storeCommandType;
    private bool flagHasBrightnessValue;
    private double storeBrightnessValue;
    private string textStoreBrightnessValue;
    private bool flagHasBrightnessLevel;
    private double storeBrightnessLevel;
    private string textStoreBrightnessLevel;
    private bool flagHasBrightnessDelta;
    private double storeBrightnessDelta;
    private string textStoreBrightnessDelta;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCommandTypeToJSON()
      {
        JSONStringValue generated_string_CommandType;
        switch (storeCommandType)
          {
            case TypeCommandType.CommandType_AdjustBrightness:
                generated_string_CommandType = new JSONStringValue("AdjustBrightness");
                break;
            case TypeCommandType.CommandType_SetBrightness:
                generated_string_CommandType = new JSONStringValue("SetBrightness");
                break;
            case TypeCommandType.CommandType_InvertColorsOn:
                generated_string_CommandType = new JSONStringValue("InvertColorsOn");
                break;
            case TypeCommandType.CommandType_InvertColorsOff:
                generated_string_CommandType = new JSONStringValue("InvertColorsOff");
                break;
            case TypeCommandType.CommandType_NightShiftOn:
                generated_string_CommandType = new JSONStringValue("NightShiftOn");
                break;
            case TypeCommandType.CommandType_NightShiftOff:
                generated_string_CommandType = new JSONStringValue("NightShiftOff");
                break;
            default:
                Debug.Assert(false);
                generated_string_CommandType = null;
                break;
          }
        return generated_string_CommandType;
      }

    private JSONValue  extraBrightnessValueToJSON()
      {
        JSONValue generated_rational_BrightnessValue;
        if (textStoreBrightnessValue != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreBrightnessValue);
            generated_rational_BrightnessValue = handler.result;
          }
        else if (((double)(long)storeBrightnessValue) == storeBrightnessValue)
            generated_rational_BrightnessValue = new JSONIntegerValue((long)(storeBrightnessValue));
        else
            generated_rational_BrightnessValue = new JSONRationalValue(storeBrightnessValue, 15);
        return generated_rational_BrightnessValue;
      }

    private JSONValue  extraBrightnessLevelToJSON()
      {
        JSONValue generated_rational_BrightnessLevel;
        if (textStoreBrightnessLevel != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreBrightnessLevel);
            generated_rational_BrightnessLevel = handler.result;
          }
        else if (((double)(long)storeBrightnessLevel) == storeBrightnessLevel)
            generated_rational_BrightnessLevel = new JSONIntegerValue((long)(storeBrightnessLevel));
        else
            generated_rational_BrightnessLevel = new JSONRationalValue(storeBrightnessLevel, 15);
        return generated_rational_BrightnessLevel;
      }

    private JSONValue  extraBrightnessDeltaToJSON()
      {
        JSONValue generated_rational_BrightnessDelta;
        if (textStoreBrightnessDelta != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreBrightnessDelta);
            generated_rational_BrightnessDelta = handler.result;
          }
        else if (((double)(long)storeBrightnessDelta) == storeBrightnessDelta)
            generated_rational_BrightnessDelta = new JSONIntegerValue((long)(storeBrightnessDelta));
        else
            generated_rational_BrightnessDelta = new JSONRationalValue(storeBrightnessDelta, 15);
        return generated_rational_BrightnessDelta;
      }


    private void  fromJSONCommandType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandType of BrightnessCommandJSON is not a string.");
        TypeCommandType the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "djustBrightness", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                      {
                        the_enum = TypeCommandType.CommandType_AdjustBrightness;
                        goto enum_is_done;
                      }
                break;
            case 'I':
                if (String.Compare(json_string.getData(), 1, "nvertColorsO", 0, 12, false) == 0)
                  {
                    switch (json_string.getData()[13])
                      {
                        case 'f':
                            if ((String.Compare(json_string.getData(), 14, "f", 0, 1, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_enum = TypeCommandType.CommandType_InvertColorsOff;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'n':
                            if (json_string.getData().Length == 14)
                                  {
                                    the_enum = TypeCommandType.CommandType_InvertColorsOn;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if (String.Compare(json_string.getData(), 1, "ightShiftO", 0, 10, false) == 0)
                  {
                    switch (json_string.getData()[11])
                      {
                        case 'f':
                            if ((String.Compare(json_string.getData(), 12, "f", 0, 1, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_enum = TypeCommandType.CommandType_NightShiftOff;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'n':
                            if (json_string.getData().Length == 12)
                                  {
                                    the_enum = TypeCommandType.CommandType_NightShiftOn;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "etBrightness", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_enum = TypeCommandType.CommandType_SetBrightness;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field CommandType of BrightnessCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setCommandType(the_enum);
      }


    private void  fromJSONBrightnessValue(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field BrightnessValue of BrightnessCommandJSON is not a number.");
              }
          }
        setBrightnessValueText(the_rational_text);
      }


    private void  fromJSONBrightnessLevel(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field BrightnessLevel of BrightnessCommandJSON is not a number.");
              }
          }
        setBrightnessLevelText(the_rational_text);
      }


    private void  fromJSONBrightnessDelta(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field BrightnessDelta of BrightnessCommandJSON is not a number.");
              }
          }
        setBrightnessDeltaText(the_rational_text);
      }


    public BrightnessCommandJSON()
      {
        flagHasCommandType = false;
        flagHasBrightnessValue = false;
        flagHasBrightnessLevel = false;
        flagHasBrightnessDelta = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDeviceControlCommandKind()
      {
        return "BrightnessCommand";
      }

    public bool  hasCommandType()
      {
        return flagHasCommandType;
      }

    public TypeCommandType  getCommandType()
      {
        Debug.Assert(flagHasCommandType);
        return storeCommandType;
      }

    public string  getCommandTypeAsString()
      {
        return stringFromCommandType(getCommandType());
      }

    public bool  hasBrightnessValue()
      {
        return flagHasBrightnessValue;
      }

    public double  getBrightnessValue()
      {
        Debug.Assert(flagHasBrightnessValue);
        if (textStoreBrightnessValue != "")
          {
            return Double.Parse(textStoreBrightnessValue);
          }
        return storeBrightnessValue;
      }

    public string  getBrightnessValueAsText()
      {
        Debug.Assert(flagHasBrightnessValue);
        if (textStoreBrightnessValue == "")
          {
            return Convert.ToString(storeBrightnessValue);
          }
        else
          {
            return (textStoreBrightnessValue);
          }
      }

    public bool  hasBrightnessLevel()
      {
        return flagHasBrightnessLevel;
      }

    public double  getBrightnessLevel()
      {
        Debug.Assert(flagHasBrightnessLevel);
        if (textStoreBrightnessLevel != "")
          {
            return Double.Parse(textStoreBrightnessLevel);
          }
        return storeBrightnessLevel;
      }

    public string  getBrightnessLevelAsText()
      {
        Debug.Assert(flagHasBrightnessLevel);
        if (textStoreBrightnessLevel == "")
          {
            return Convert.ToString(storeBrightnessLevel);
          }
        else
          {
            return (textStoreBrightnessLevel);
          }
      }

    public bool  hasBrightnessDelta()
      {
        return flagHasBrightnessDelta;
      }

    public double  getBrightnessDelta()
      {
        Debug.Assert(flagHasBrightnessDelta);
        if (textStoreBrightnessDelta != "")
          {
            return Double.Parse(textStoreBrightnessDelta);
          }
        return storeBrightnessDelta;
      }

    public string  getBrightnessDeltaAsText()
      {
        Debug.Assert(flagHasBrightnessDelta);
        if (textStoreBrightnessDelta == "")
          {
            return Convert.ToString(storeBrightnessDelta);
          }
        else
          {
            return (textStoreBrightnessDelta);
          }
      }


    public virtual int extraBrightnessCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBrightnessCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBrightnessCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBrightnessCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDeviceControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasCommandType)
            ++result;
        if (flagHasBrightnessValue)
            ++result;
        if (flagHasBrightnessLevel)
            ++result;
        if (flagHasBrightnessDelta)
            ++result;
        result += extraBrightnessCommandComponentCount();
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
        if (flagHasBrightnessValue)
          {
            if (remainder == 0)
                return "BrightnessValue";
            --remainder;
          }
        if (flagHasBrightnessLevel)
          {
            if (remainder == 0)
                return "BrightnessLevel";
            --remainder;
          }
        if (flagHasBrightnessDelta)
          {
            if (remainder == 0)
                return "BrightnessDelta";
            --remainder;
          }
        return extraBrightnessCommandComponentKey(remainder);
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
        if (flagHasBrightnessValue)
          {
            if (remainder == 0)
                return extraBrightnessValueToJSON();
            --remainder;
          }
        if (flagHasBrightnessLevel)
          {
            if (remainder == 0)
                return extraBrightnessLevelToJSON();
            --remainder;
          }
        if (flagHasBrightnessDelta)
          {
            if (remainder == 0)
                return extraBrightnessDeltaToJSON();
            --remainder;
          }
        return extraBrightnessCommandComponentValue(remainder);
      }
    public override JSONValue extraDeviceControlCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'B':
                if (String.Compare(field_name, 1, "rightness", 0, 9, false) == 0)
                  {
                    switch (field_name[10])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 11, "elta", 0, 4, false) == 0) && (field_name.Length == 15))
                                return (flagHasBrightnessDelta ? extraBrightnessDeltaToJSON() : null);
                            break;
                        case 'L':
                            if ((String.Compare(field_name, 11, "evel", 0, 4, false) == 0) && (field_name.Length == 15))
                                return (flagHasBrightnessLevel ? extraBrightnessLevelToJSON() : null);
                            break;
                        case 'V':
                            if ((String.Compare(field_name, 11, "alue", 0, 4, false) == 0) && (field_name.Length == 15))
                                return (flagHasBrightnessValue ? extraBrightnessValueToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'C':
                if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasCommandType ? extraCommandTypeToJSON() : null);
                break;
            default:
                break;
          }
        return extraBrightnessCommandLookup(field_name);
      }

    public void setCommandType(TypeCommandType new_value)
      {
        flagHasCommandType = true;
        storeCommandType = new_value;
      }
    public void setCommandType(string chars)
      {
        setCommandType(stringToCommandType(chars));
      }
    public void unsetCommandType()
      {
        flagHasCommandType = false;
      }
    public void setBrightnessValue(double new_value)
      {
        flagHasBrightnessValue = true;
        if (new_value < 0)
            throw new Exception("The value for field BrightnessValue of BrightnessCommandJSON is less than the lower bound (0) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field BrightnessValue of BrightnessCommandJSON is greater than the upper bound (1) for that field.");
        storeBrightnessValue = new_value;
        textStoreBrightnessValue = "";
      }
    public void setBrightnessValueText(string new_value)
      {
        flagHasBrightnessValue = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field BrightnessValue of BrightnessCommandJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field BrightnessValue of BrightnessCommandJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
            throw new Exception("The value for field BrightnessValue of BrightnessCommandJSON is greater than the upper bound (1) for that field.");
        textStoreBrightnessValue = new_value;
      }
    public void unsetBrightnessValue()
      {
        flagHasBrightnessValue = false;
      }
    public void setBrightnessLevel(double new_value)
      {
        flagHasBrightnessLevel = true;
        storeBrightnessLevel = new_value;
        textStoreBrightnessLevel = "";
      }
    public void setBrightnessLevelText(string new_value)
      {
        flagHasBrightnessLevel = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field BrightnessLevel of BrightnessCommandJSON is not a valid number.");
        textStoreBrightnessLevel = new_value;
      }
    public void unsetBrightnessLevel()
      {
        flagHasBrightnessLevel = false;
      }
    public void setBrightnessDelta(double new_value)
      {
        flagHasBrightnessDelta = true;
        if (new_value < -1)
            throw new Exception("The value for field BrightnessDelta of BrightnessCommandJSON is less than the lower bound (-1) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field BrightnessDelta of BrightnessCommandJSON is greater than the upper bound (1) for that field.");
        storeBrightnessDelta = new_value;
        textStoreBrightnessDelta = "";
      }
    public void setBrightnessDeltaText(string new_value)
      {
        flagHasBrightnessDelta = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field BrightnessDelta of BrightnessCommandJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "1", "", false, "1") < 0)
            throw new Exception("The value for field BrightnessDelta of BrightnessCommandJSON is less than the lower bound (-1) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
            throw new Exception("The value for field BrightnessDelta of BrightnessCommandJSON is greater than the upper bound (1) for that field.");
        textStoreBrightnessDelta = new_value;
      }
    public void unsetBrightnessDelta()
      {
        flagHasBrightnessDelta = false;
      }

    public virtual void extraBrightnessCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBrightnessCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBrightnessCommandLookup(key);
        if (old_field == null)
          {
            extraBrightnessCommandAppendPair(key, new_component);
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
            case 'B':
                if (String.Compare(key, 1, "rightness", 0, 9, false) == 0)
                  {
                    switch (key[10])
                      {
                        case 'D':
                            if ((String.Compare(key, 11, "elta", 0, 4, false) == 0) && (key.Length == 15))
                                {
                                fromJSONBrightnessDelta(new_component, false);
                                return;
                                }
                            break;
                        case 'L':
                            if ((String.Compare(key, 11, "evel", 0, 4, false) == 0) && (key.Length == 15))
                                {
                                fromJSONBrightnessLevel(new_component, false);
                                return;
                                }
                            break;
                        case 'V':
                            if ((String.Compare(key, 11, "alue", 0, 4, false) == 0) && (key.Length == 15))
                                {
                                fromJSONBrightnessValue(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'C':
                if ((String.Compare(key, 1, "ommandType", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONCommandType(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraBrightnessCommandAppendPair(key, new_component);
      }
    public override void extraDeviceControlCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'B':
                if (String.Compare(key, 1, "rightness", 0, 9, false) == 0)
                  {
                    switch (key[10])
                      {
                        case 'D':
                            if ((String.Compare(key, 11, "elta", 0, 4, false) == 0) && (key.Length == 15))
                                {
                                fromJSONBrightnessDelta(new_component, false);
                                return;
                                }
                            break;
                        case 'L':
                            if ((String.Compare(key, 11, "evel", 0, 4, false) == 0) && (key.Length == 15))
                                {
                                fromJSONBrightnessLevel(new_component, false);
                                return;
                                }
                            break;
                        case 'V':
                            if ((String.Compare(key, 11, "alue", 0, 4, false) == 0) && (key.Length == 15))
                                {
                                fromJSONBrightnessValue(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'C':
                if ((String.Compare(key, 1, "ommandType", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONCommandType(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraBrightnessCommandSetField(key, new_component);
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
            switch (storeCommandType)
              {
                case TypeCommandType.CommandType_AdjustBrightness:
                    handler.string_value("AdjustBrightness");
                    break;
                case TypeCommandType.CommandType_SetBrightness:
                    handler.string_value("SetBrightness");
                    break;
                case TypeCommandType.CommandType_InvertColorsOn:
                    handler.string_value("InvertColorsOn");
                    break;
                case TypeCommandType.CommandType_InvertColorsOff:
                    handler.string_value("InvertColorsOff");
                    break;
                case TypeCommandType.CommandType_NightShiftOn:
                    handler.string_value("NightShiftOn");
                    break;
                case TypeCommandType.CommandType_NightShiftOff:
                    handler.string_value("NightShiftOff");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasBrightnessValue)
          {
            handler.start_pair("BrightnessValue");
            if (textStoreBrightnessValue != "")
                handler.number_value(textStoreBrightnessValue);
            else if (((double)(long)storeBrightnessValue) == storeBrightnessValue)
                handler.number_value((long)storeBrightnessValue);
            else
                handler.number_value(storeBrightnessValue);
          }
        if (flagHasBrightnessLevel)
          {
            handler.start_pair("BrightnessLevel");
            if (textStoreBrightnessLevel != "")
                handler.number_value(textStoreBrightnessLevel);
            else if (((double)(long)storeBrightnessLevel) == storeBrightnessLevel)
                handler.number_value((long)storeBrightnessLevel);
            else
                handler.number_value(storeBrightnessLevel);
          }
        if (flagHasBrightnessDelta)
          {
            handler.start_pair("BrightnessDelta");
            if (textStoreBrightnessDelta != "")
                handler.number_value(textStoreBrightnessDelta);
            else if (((double)(long)storeBrightnessDelta) == storeBrightnessDelta)
                handler.number_value((long)storeBrightnessDelta);
            else
                handler.number_value(storeBrightnessDelta);
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

    public static new BrightnessCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BrightnessCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BrightnessCommand", ignore_extras);
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
    public static new BrightnessCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BrightnessCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BrightnessCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BrightnessCommand", ignore_extras);
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
    public static new BrightnessCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BrightnessCommandJSON from_text(string text, bool ignore_extras)
      {
        BrightnessCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BrightnessCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BrightnessCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new BrightnessCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BrightnessCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BrightnessCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DeviceControlCommandJSON.Generator
      {
    private abstract class FieldGeneratorCommandType : JSONStringGenerator
          {
            protected FieldGeneratorCommandType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCommandType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToCommandType(result));
              }
            protected abstract void handle_result(TypeCommandType result);
          };
    private class FieldHoldingGeneratorCommandType : FieldGeneratorCommandType
  {
    protected override void handle_result(TypeCommandType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCommandType(String what)
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
    public TypeCommandType value;
  };
    private class FieldHoldingArrayGeneratorCommandType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCommandType
      {
        private FieldHoldingArrayGeneratorCommandType top;

        protected override void handle_result(TypeCommandType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCommandType init_top)
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
    protected virtual void handle_result(List<TypeCommandType> result)
      {
      }

    public FieldHoldingArrayGeneratorCommandType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCommandType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCommandType> value;
  };
        private FieldHoldingGeneratorCommandType fieldGeneratorCommandType;
        private JSONHoldingNumberTextGenerator fieldGeneratorBrightnessValue;
        private JSONHoldingNumberTextGenerator fieldGeneratorBrightnessLevel;
        private JSONHoldingNumberTextGenerator fieldGeneratorBrightnessDelta;
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
            if (!(getDeviceControlCommandJSONKey().Equals("BrightnessCommand")))
                throw new Exception("The key field has a value other than `BrightnessCommand'.");
            BrightnessCommandJSON result = new BrightnessCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBrightnessCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DeviceControlCommandJSON new_result)
          {
            handle_result((BrightnessCommandJSON )new_result);
          }
        protected void finish(BrightnessCommandJSON result)
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
            if (fieldGeneratorBrightnessValue.have_value)
              {
                result.setBrightnessValueText(fieldGeneratorBrightnessValue.value);
                fieldGeneratorBrightnessValue.have_value = false;
              }
            if (fieldGeneratorBrightnessLevel.have_value)
              {
                result.setBrightnessLevelText(fieldGeneratorBrightnessLevel.value);
                fieldGeneratorBrightnessLevel.have_value = false;
              }
            if (fieldGeneratorBrightnessDelta.have_value)
              {
                result.setBrightnessDeltaText(fieldGeneratorBrightnessDelta.value);
                fieldGeneratorBrightnessDelta.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(BrightnessCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if (String.Compare(field_name, 1, "rightness", 0, 9, false) == 0)
                      {
                        switch (field_name[10])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 11, "elta", 0, 4, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorBrightnessDelta;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 11, "evel", 0, 4, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorBrightnessLevel;
                                break;
                            case 'V':
                                if ((String.Compare(field_name, 11, "alue", 0, 4, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorBrightnessValue;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCommandType;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the BrightnessCommand class");
            fieldGeneratorBrightnessValue = new JSONHoldingNumberTextGenerator("field \"BrightnessValue\" of the BrightnessCommand class");
            fieldGeneratorBrightnessLevel = new JSONHoldingNumberTextGenerator("field \"BrightnessLevel\" of the BrightnessCommand class");
            fieldGeneratorBrightnessDelta = new JSONHoldingNumberTextGenerator("field \"BrightnessDelta\" of the BrightnessCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BrightnessCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the BrightnessCommand class");
            fieldGeneratorBrightnessValue = new JSONHoldingNumberTextGenerator("field \"BrightnessValue\" of the BrightnessCommand class");
            fieldGeneratorBrightnessLevel = new JSONHoldingNumberTextGenerator("field \"BrightnessLevel\" of the BrightnessCommand class");
            fieldGeneratorBrightnessDelta = new JSONHoldingNumberTextGenerator("field \"BrightnessDelta\" of the BrightnessCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BrightnessCommand class");
          }

        public override void reset()
          {
            fieldGeneratorCommandType.reset();
            fieldGeneratorBrightnessValue.reset();
            fieldGeneratorBrightnessLevel.reset();
            fieldGeneratorBrightnessDelta.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(BrightnessCommandJSON  result)
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
        public BrightnessCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BrightnessCommandJSON  result)
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
    protected virtual void handle_result(List<BrightnessCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BrightnessCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BrightnessCommandJSON>();
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
    public List<BrightnessCommandJSON> value;
  };
  };
