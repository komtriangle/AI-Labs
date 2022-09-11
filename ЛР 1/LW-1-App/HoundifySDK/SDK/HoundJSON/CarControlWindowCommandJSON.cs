/* file "CarControlWindowCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarControlWindowCommandJSON : CarControlCommandJSON
  {
    public enum TypeCommandType
      {
        CommandType_OpenWindow,
        CommandType_CloseWindow,
        CommandType_WipersAutomatic,
        CommandType_WipersLowSpeed,
        CommandType_WipersHighSpeed,
        CommandType_WipersOff,
        CommandType_Defog,
        CommandType_DefogOff
      };

    public static TypeCommandType  stringToCommandType(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "loseWindow", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeCommandType.CommandType_CloseWindow;
                break;
            case 'D':
                if (String.Compare(chars, 1, "efog", 0, 4, false) == 0)
                  {
                    if (chars.Length == 5)
                      {
                        return TypeCommandType.CommandType_Defog;
                      }
                    switch (chars[5])
                      {
                        case 'O':
                            if ((String.Compare(chars, 6, "ff", 0, 2, false) == 0) && (chars.Length == 8))
                                return TypeCommandType.CommandType_DefogOff;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'O':
                if ((String.Compare(chars, 1, "penWindow", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeCommandType.CommandType_OpenWindow;
                break;
            case 'W':
                if (String.Compare(chars, 1, "ipers", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'A':
                            if ((String.Compare(chars, 7, "utomatic", 0, 8, false) == 0) && (chars.Length == 15))
                                return TypeCommandType.CommandType_WipersAutomatic;
                            break;
                        case 'H':
                            if ((String.Compare(chars, 7, "ighSpeed", 0, 8, false) == 0) && (chars.Length == 15))
                                return TypeCommandType.CommandType_WipersHighSpeed;
                            break;
                        case 'L':
                            if ((String.Compare(chars, 7, "owSpeed", 0, 7, false) == 0) && (chars.Length == 14))
                                return TypeCommandType.CommandType_WipersLowSpeed;
                            break;
                        case 'O':
                            if ((String.Compare(chars, 7, "ff", 0, 2, false) == 0) && (chars.Length == 9))
                                return TypeCommandType.CommandType_WipersOff;
                            break;
                        default:
                            break;
                      }
                  }
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
            case TypeCommandType.CommandType_OpenWindow:
                return "OpenWindow";
            case TypeCommandType.CommandType_CloseWindow:
                return "CloseWindow";
            case TypeCommandType.CommandType_WipersAutomatic:
                return "WipersAutomatic";
            case TypeCommandType.CommandType_WipersLowSpeed:
                return "WipersLowSpeed";
            case TypeCommandType.CommandType_WipersHighSpeed:
                return "WipersHighSpeed";
            case TypeCommandType.CommandType_WipersOff:
                return "WipersOff";
            case TypeCommandType.CommandType_Defog:
                return "Defog";
            case TypeCommandType.CommandType_DefogOff:
                return "DefogOff";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCommandType;
    private TypeCommandType storeCommandType;
    private bool flagHasMovementAmount;
    private double storeMovementAmount;
    private string textStoreMovementAmount;
    private bool flagHasWindowSelection;
    private CarWindowSelectionJSON  storeWindowSelection;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCommandTypeToJSON()
      {
        JSONStringValue generated_string_CommandType;
        switch (storeCommandType)
          {
            case TypeCommandType.CommandType_OpenWindow:
                generated_string_CommandType = new JSONStringValue("OpenWindow");
                break;
            case TypeCommandType.CommandType_CloseWindow:
                generated_string_CommandType = new JSONStringValue("CloseWindow");
                break;
            case TypeCommandType.CommandType_WipersAutomatic:
                generated_string_CommandType = new JSONStringValue("WipersAutomatic");
                break;
            case TypeCommandType.CommandType_WipersLowSpeed:
                generated_string_CommandType = new JSONStringValue("WipersLowSpeed");
                break;
            case TypeCommandType.CommandType_WipersHighSpeed:
                generated_string_CommandType = new JSONStringValue("WipersHighSpeed");
                break;
            case TypeCommandType.CommandType_WipersOff:
                generated_string_CommandType = new JSONStringValue("WipersOff");
                break;
            case TypeCommandType.CommandType_Defog:
                generated_string_CommandType = new JSONStringValue("Defog");
                break;
            case TypeCommandType.CommandType_DefogOff:
                generated_string_CommandType = new JSONStringValue("DefogOff");
                break;
            default:
                Debug.Assert(false);
                generated_string_CommandType = null;
                break;
          }
        return generated_string_CommandType;
      }

    private JSONValue  extraMovementAmountToJSON()
      {
        JSONValue generated_rational_MovementAmount;
        if (textStoreMovementAmount != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreMovementAmount);
            generated_rational_MovementAmount = handler.result;
          }
        else if (((double)(long)storeMovementAmount) == storeMovementAmount)
            generated_rational_MovementAmount = new JSONIntegerValue((long)(storeMovementAmount));
        else
            generated_rational_MovementAmount = new JSONRationalValue(storeMovementAmount, 15);
        return generated_rational_MovementAmount;
      }

    private JSONValue  extraWindowSelectionToJSON()
      {
        JSONValueHandler handler_WindowSelection = new JSONValueHandler();
        storeWindowSelection.write_as_json(handler_WindowSelection);
        return handler_WindowSelection.result;
      }


    private void  fromJSONCommandType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandType of CarControlWindowCommandJSON is not a string.");
        TypeCommandType the_enum;
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "loseWindow", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_enum = TypeCommandType.CommandType_CloseWindow;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if (String.Compare(json_string.getData(), 1, "efog", 0, 4, false) == 0)
                  {
                    if (json_string.getData().Length == 5)
                      {
                          {
                            the_enum = TypeCommandType.CommandType_Defog;
                            goto enum_is_done;
                          }
                      }
                    switch (json_string.getData()[5])
                      {
                        case 'O':
                            if ((String.Compare(json_string.getData(), 6, "ff", 0, 2, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_enum = TypeCommandType.CommandType_DefogOff;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "penWindow", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_enum = TypeCommandType.CommandType_OpenWindow;
                        goto enum_is_done;
                      }
                break;
            case 'W':
                if (String.Compare(json_string.getData(), 1, "ipers", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 7, "utomatic", 0, 8, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_enum = TypeCommandType.CommandType_WipersAutomatic;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'H':
                            if ((String.Compare(json_string.getData(), 7, "ighSpeed", 0, 8, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_enum = TypeCommandType.CommandType_WipersHighSpeed;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'L':
                            if ((String.Compare(json_string.getData(), 7, "owSpeed", 0, 7, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_enum = TypeCommandType.CommandType_WipersLowSpeed;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'O':
                            if ((String.Compare(json_string.getData(), 7, "ff", 0, 2, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_enum = TypeCommandType.CommandType_WipersOff;
                                    goto enum_is_done;
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
        throw new Exception("The value for field CommandType of CarControlWindowCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setCommandType(the_enum);
      }


    private void  fromJSONMovementAmount(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MovementAmount of CarControlWindowCommandJSON is not a number.");
              }
          }
        setMovementAmountText(the_rational_text);
      }


    private void  fromJSONWindowSelection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CarWindowSelectionJSON convert_classy = CarWindowSelectionJSON.from_json(json_value, ignore_extras, true);
        setWindowSelection(convert_classy);
      }


    public CarControlWindowCommandJSON()
      {
        flagHasCommandType = false;
        flagHasMovementAmount = false;
        flagHasWindowSelection = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCarControlCommandKind()
      {
        return "CarControlWindowCommand";
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

    public bool  hasMovementAmount()
      {
        return flagHasMovementAmount;
      }

    public double  getMovementAmount()
      {
        Debug.Assert(flagHasMovementAmount);
        if (textStoreMovementAmount != "")
          {
            return Double.Parse(textStoreMovementAmount);
          }
        return storeMovementAmount;
      }

    public string  getMovementAmountAsText()
      {
        Debug.Assert(flagHasMovementAmount);
        if (textStoreMovementAmount == "")
          {
            return Convert.ToString(storeMovementAmount);
          }
        else
          {
            return (textStoreMovementAmount);
          }
      }

    public bool  hasWindowSelection()
      {
        return flagHasWindowSelection;
      }

    public CarWindowSelectionJSON   getWindowSelection()
      {
        Debug.Assert(flagHasWindowSelection);
        return storeWindowSelection;
      }


    public virtual int extraCarControlWindowCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCarControlWindowCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCarControlWindowCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCarControlWindowCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCarControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasCommandType)
            ++result;
        if (flagHasMovementAmount)
            ++result;
        if (flagHasWindowSelection)
            ++result;
        result += extraCarControlWindowCommandComponentCount();
        return result;
      }
    public override string extraCarControlCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCommandType)
          {
            if (remainder == 0)
                return "CommandType";
            --remainder;
          }
        if (flagHasMovementAmount)
          {
            if (remainder == 0)
                return "MovementAmount";
            --remainder;
          }
        if (flagHasWindowSelection)
          {
            if (remainder == 0)
                return "WindowSelection";
            --remainder;
          }
        return extraCarControlWindowCommandComponentKey(remainder);
      }
    public override JSONValue extraCarControlCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCommandType)
          {
            if (remainder == 0)
                return extraCommandTypeToJSON();
            --remainder;
          }
        if (flagHasMovementAmount)
          {
            if (remainder == 0)
                return extraMovementAmountToJSON();
            --remainder;
          }
        if (flagHasWindowSelection)
          {
            if (remainder == 0)
                return extraWindowSelectionToJSON();
            --remainder;
          }
        return extraCarControlWindowCommandComponentValue(remainder);
      }
    public override JSONValue extraCarControlCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasCommandType ? extraCommandTypeToJSON() : null);
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "ovementAmount", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasMovementAmount ? extraMovementAmountToJSON() : null);
                break;
            case 'W':
                if ((String.Compare(field_name, 1, "indowSelection", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasWindowSelection ? extraWindowSelectionToJSON() : null);
                break;
            default:
                break;
          }
        return extraCarControlWindowCommandLookup(field_name);
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
    public void setMovementAmount(double new_value)
      {
        flagHasMovementAmount = true;
        if (new_value < 0)
            throw new Exception("The value for field MovementAmount of CarControlWindowCommandJSON is less than the lower bound (0) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field MovementAmount of CarControlWindowCommandJSON is greater than the upper bound (1) for that field.");
        storeMovementAmount = new_value;
        textStoreMovementAmount = "";
      }
    public void setMovementAmountText(string new_value)
      {
        flagHasMovementAmount = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field MovementAmount of CarControlWindowCommandJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field MovementAmount of CarControlWindowCommandJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
            throw new Exception("The value for field MovementAmount of CarControlWindowCommandJSON is greater than the upper bound (1) for that field.");
        textStoreMovementAmount = new_value;
      }
    public void unsetMovementAmount()
      {
        flagHasMovementAmount = false;
      }
    public void setWindowSelection(CarWindowSelectionJSON  new_value)
      {
        if (flagHasWindowSelection)
          {
          }
        flagHasWindowSelection = true;
        storeWindowSelection = new_value;
      }
    public void unsetWindowSelection()
      {
        if (flagHasWindowSelection)
          {
          }
        flagHasWindowSelection = false;
      }

    public virtual void extraCarControlWindowCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCarControlWindowCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCarControlWindowCommandLookup(key);
        if (old_field == null)
          {
            extraCarControlWindowCommandAppendPair(key, new_component);
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
    public override void extraCarControlCommandAppendPair(string key, JSONValue new_component)
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
            case 'M':
                if ((String.Compare(key, 1, "ovementAmount", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONMovementAmount(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if ((String.Compare(key, 1, "indowSelection", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONWindowSelection(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCarControlWindowCommandAppendPair(key, new_component);
      }
    public override void extraCarControlCommandSetField(string key, JSONValue new_component)
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
            case 'M':
                if ((String.Compare(key, 1, "ovementAmount", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONMovementAmount(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if ((String.Compare(key, 1, "indowSelection", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONWindowSelection(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCarControlWindowCommandSetField(key, new_component);
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
                case TypeCommandType.CommandType_OpenWindow:
                    handler.string_value("OpenWindow");
                    break;
                case TypeCommandType.CommandType_CloseWindow:
                    handler.string_value("CloseWindow");
                    break;
                case TypeCommandType.CommandType_WipersAutomatic:
                    handler.string_value("WipersAutomatic");
                    break;
                case TypeCommandType.CommandType_WipersLowSpeed:
                    handler.string_value("WipersLowSpeed");
                    break;
                case TypeCommandType.CommandType_WipersHighSpeed:
                    handler.string_value("WipersHighSpeed");
                    break;
                case TypeCommandType.CommandType_WipersOff:
                    handler.string_value("WipersOff");
                    break;
                case TypeCommandType.CommandType_Defog:
                    handler.string_value("Defog");
                    break;
                case TypeCommandType.CommandType_DefogOff:
                    handler.string_value("DefogOff");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasMovementAmount)
          {
            handler.start_pair("MovementAmount");
            if (textStoreMovementAmount != "")
                handler.number_value(textStoreMovementAmount);
            else if (((double)(long)storeMovementAmount) == storeMovementAmount)
                handler.number_value((long)storeMovementAmount);
            else
                handler.number_value(storeMovementAmount);
          }
        Debug.Assert(partial_allowed || flagHasWindowSelection);
        if (flagHasWindowSelection)
          {
            handler.start_pair("WindowSelection");
            if (partial_allowed)
                storeWindowSelection.write_partial_as_json(handler);
            else
                storeWindowSelection.write_as_json(handler);
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
        if (!(hasWindowSelection()))
          {
            return "When parsing the object for %what%, the \"WindowSelection\" field was missing.";
          }
        return null;
      }

    public static new CarControlWindowCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlWindowCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlWindowCommand", ignore_extras);
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
    public static new CarControlWindowCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlWindowCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlWindowCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlWindowCommand", ignore_extras);
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
    public static new CarControlWindowCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlWindowCommandJSON from_text(string text, bool ignore_extras)
      {
        CarControlWindowCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlWindowCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarControlWindowCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CarControlWindowCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarControlWindowCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlWindowCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CarControlCommandJSON.Generator
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
        private JSONHoldingNumberTextGenerator fieldGeneratorMovementAmount;
        private CarWindowSelectionJSON.HoldingGenerator fieldGeneratorWindowSelection;
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
            if (!(getCarControlCommandJSONKey().Equals("CarControlWindowCommand")))
                throw new Exception("The key field has a value other than `CarControlWindowCommand'.");
            CarControlWindowCommandJSON result = new CarControlWindowCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCarControlWindowCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CarControlCommandJSON new_result)
          {
            handle_result((CarControlWindowCommandJSON )new_result);
          }
        protected void finish(CarControlWindowCommandJSON result)
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
            if (fieldGeneratorMovementAmount.have_value)
              {
                result.setMovementAmountText(fieldGeneratorMovementAmount.value);
                fieldGeneratorMovementAmount.have_value = false;
              }
            if (fieldGeneratorWindowSelection.have_value)
              {
                result.setWindowSelection(fieldGeneratorWindowSelection.value);
                fieldGeneratorWindowSelection.have_value = false;
              }
            else if ((!(result.hasWindowSelection())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WindowSelection\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(CarControlWindowCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCommandType;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "ovementAmount", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorMovementAmount;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "indowSelection", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorWindowSelection;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlWindowCommand class");
            fieldGeneratorMovementAmount = new JSONHoldingNumberTextGenerator("field \"MovementAmount\" of the CarControlWindowCommand class");
            fieldGeneratorWindowSelection = new CarWindowSelectionJSON.HoldingGenerator("field \"WindowSelection\" of the CarControlWindowCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CarControlWindowCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlWindowCommand class");
            fieldGeneratorMovementAmount = new JSONHoldingNumberTextGenerator("field \"MovementAmount\" of the CarControlWindowCommand class");
            fieldGeneratorWindowSelection = new CarWindowSelectionJSON.HoldingGenerator("field \"WindowSelection\" of the CarControlWindowCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CarControlWindowCommand class");
          }

        public override void reset()
          {
            fieldGeneratorCommandType.reset();
            fieldGeneratorMovementAmount.reset();
            fieldGeneratorWindowSelection.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CarControlWindowCommandJSON  result)
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
        public CarControlWindowCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarControlWindowCommandJSON  result)
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
    protected virtual void handle_result(List<CarControlWindowCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarControlWindowCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarControlWindowCommandJSON>();
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
    public List<CarControlWindowCommandJSON> value;
  };
  };
