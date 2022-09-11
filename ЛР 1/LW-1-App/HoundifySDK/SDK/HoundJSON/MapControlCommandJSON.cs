/* file "MapControlCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MapControlCommandJSON : DeviceControlCommandJSON
  {
    public enum TypePanUnit
      {
        PanUnit_Miles,
        PanUnit_Kilometres,
        PanUnit_None
      };

    public static TypePanUnit  stringToPanUnit(string chars)
      {
        switch (chars[0])
          {
            case 'K':
                if ((String.Compare(chars, 1, "ilometres", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypePanUnit.PanUnit_Kilometres;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "iles", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypePanUnit.PanUnit_Miles;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypePanUnit.PanUnit_None;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `PanUnit' is not one of the legal values.");
      }

    public static string  stringFromPanUnit(TypePanUnit the_enum)
      {
        switch (the_enum)
          {
            case TypePanUnit.PanUnit_Miles:
                return "Miles";
            case TypePanUnit.PanUnit_Kilometres:
                return "Kilometres";
            case TypePanUnit.PanUnit_None:
                return "None";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeZoomUnit
      {
        ZoomUnit_Miles,
        ZoomUnit_Feet,
        ZoomUnit_Kilometres,
        ZoomUnit_Metres,
        ZoomUnit_None
      };

    public static TypeZoomUnit  stringToZoomUnit(string chars)
      {
        switch (chars[0])
          {
            case 'F':
                if ((String.Compare(chars, 1, "eet", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeZoomUnit.ZoomUnit_Feet;
                break;
            case 'K':
                if ((String.Compare(chars, 1, "ilometres", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeZoomUnit.ZoomUnit_Kilometres;
                break;
            case 'M':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "tres", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeZoomUnit.ZoomUnit_Metres;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "les", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeZoomUnit.ZoomUnit_Miles;
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeZoomUnit.ZoomUnit_None;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `ZoomUnit' is not one of the legal values.");
      }

    public static string  stringFromZoomUnit(TypeZoomUnit the_enum)
      {
        switch (the_enum)
          {
            case TypeZoomUnit.ZoomUnit_Miles:
                return "Miles";
            case TypeZoomUnit.ZoomUnit_Feet:
                return "Feet";
            case TypeZoomUnit.ZoomUnit_Kilometres:
                return "Kilometres";
            case TypeZoomUnit.ZoomUnit_Metres:
                return "Metres";
            case TypeZoomUnit.ZoomUnit_None:
                return "None";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCommandType;
    private MapControlCommandCommandTypeJSON  storeCommandType;
    private bool flagHasDirection;
    private double storeDirection;
    private string textStoreDirection;
    private bool flagHasPanDistance;
    private double storePanDistance;
    private string textStorePanDistance;
    private bool flagHasPanUnit;
    private TypePanUnit storePanUnit;
    private bool flagHasZoomAmount;
    private double storeZoomAmount;
    private string textStoreZoomAmount;
    private bool flagHasZoomUnit;
    private TypeZoomUnit storeZoomUnit;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCommandTypeToJSON()
      {
        JSONValueHandler handler_CommandType = new JSONValueHandler();
        storeCommandType.write_as_json(handler_CommandType);
        return handler_CommandType.result;
      }

    private JSONValue  extraDirectionToJSON()
      {
        JSONValue generated_rational_Direction;
        if (textStoreDirection != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreDirection);
            generated_rational_Direction = handler.result;
          }
        else if (((double)(long)storeDirection) == storeDirection)
            generated_rational_Direction = new JSONIntegerValue((long)(storeDirection));
        else
            generated_rational_Direction = new JSONRationalValue(storeDirection, 15);
        return generated_rational_Direction;
      }

    private JSONValue  extraPanDistanceToJSON()
      {
        JSONValue generated_rational_PanDistance;
        if (textStorePanDistance != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStorePanDistance);
            generated_rational_PanDistance = handler.result;
          }
        else if (((double)(long)storePanDistance) == storePanDistance)
            generated_rational_PanDistance = new JSONIntegerValue((long)(storePanDistance));
        else
            generated_rational_PanDistance = new JSONRationalValue(storePanDistance, 15);
        return generated_rational_PanDistance;
      }

    private JSONValue  extraPanUnitToJSON()
      {
        JSONStringValue generated_string_PanUnit;
        switch (storePanUnit)
          {
            case TypePanUnit.PanUnit_Miles:
                generated_string_PanUnit = new JSONStringValue("Miles");
                break;
            case TypePanUnit.PanUnit_Kilometres:
                generated_string_PanUnit = new JSONStringValue("Kilometres");
                break;
            case TypePanUnit.PanUnit_None:
                generated_string_PanUnit = new JSONStringValue("None");
                break;
            default:
                Debug.Assert(false);
                generated_string_PanUnit = null;
                break;
          }
        return generated_string_PanUnit;
      }

    private JSONValue  extraZoomAmountToJSON()
      {
        JSONValue generated_rational_ZoomAmount;
        if (textStoreZoomAmount != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreZoomAmount);
            generated_rational_ZoomAmount = handler.result;
          }
        else if (((double)(long)storeZoomAmount) == storeZoomAmount)
            generated_rational_ZoomAmount = new JSONIntegerValue((long)(storeZoomAmount));
        else
            generated_rational_ZoomAmount = new JSONRationalValue(storeZoomAmount, 15);
        return generated_rational_ZoomAmount;
      }

    private JSONValue  extraZoomUnitToJSON()
      {
        JSONStringValue generated_string_ZoomUnit;
        switch (storeZoomUnit)
          {
            case TypeZoomUnit.ZoomUnit_Miles:
                generated_string_ZoomUnit = new JSONStringValue("Miles");
                break;
            case TypeZoomUnit.ZoomUnit_Feet:
                generated_string_ZoomUnit = new JSONStringValue("Feet");
                break;
            case TypeZoomUnit.ZoomUnit_Kilometres:
                generated_string_ZoomUnit = new JSONStringValue("Kilometres");
                break;
            case TypeZoomUnit.ZoomUnit_Metres:
                generated_string_ZoomUnit = new JSONStringValue("Metres");
                break;
            case TypeZoomUnit.ZoomUnit_None:
                generated_string_ZoomUnit = new JSONStringValue("None");
                break;
            default:
                Debug.Assert(false);
                generated_string_ZoomUnit = null;
                break;
          }
        return generated_string_ZoomUnit;
      }


    private void  fromJSONCommandType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapControlCommandCommandTypeJSON convert_classy = MapControlCommandCommandTypeJSON.from_json(json_value, ignore_extras, true);
        setCommandType(convert_classy);
      }


    private void  fromJSONDirection(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Direction of MapControlCommandJSON is not a number.");
              }
          }
        setDirectionText(the_rational_text);
      }


    private void  fromJSONPanDistance(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PanDistance of MapControlCommandJSON is not a number.");
              }
          }
        setPanDistanceText(the_rational_text);
      }


    private void  fromJSONPanUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PanUnit of MapControlCommandJSON is not a string.");
        TypePanUnit the_enum;
        switch (json_string.getData()[0])
          {
            case 'K':
                if ((String.Compare(json_string.getData(), 1, "ilometres", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_enum = TypePanUnit.PanUnit_Kilometres;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "iles", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypePanUnit.PanUnit_Miles;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypePanUnit.PanUnit_None;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field PanUnit of MapControlCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setPanUnit(the_enum);
      }


    private void  fromJSONZoomAmount(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ZoomAmount of MapControlCommandJSON is not a number.");
              }
          }
        setZoomAmountText(the_rational_text);
      }


    private void  fromJSONZoomUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ZoomUnit of MapControlCommandJSON is not a string.");
        TypeZoomUnit the_enum;
        switch (json_string.getData()[0])
          {
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "eet", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeZoomUnit.ZoomUnit_Feet;
                        goto enum_is_done;
                      }
                break;
            case 'K':
                if ((String.Compare(json_string.getData(), 1, "ilometres", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_enum = TypeZoomUnit.ZoomUnit_Kilometres;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "tres", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_enum = TypeZoomUnit.ZoomUnit_Metres;
                                goto enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "les", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_enum = TypeZoomUnit.ZoomUnit_Miles;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeZoomUnit.ZoomUnit_None;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field ZoomUnit of MapControlCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setZoomUnit(the_enum);
      }


    public MapControlCommandJSON()
      {
        flagHasCommandType = false;
        flagHasDirection = false;
        flagHasPanDistance = false;
        flagHasPanUnit = false;
        flagHasZoomAmount = false;
        flagHasZoomUnit = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDeviceControlCommandKind()
      {
        return "MapCommand";
      }

    public bool  hasCommandType()
      {
        return flagHasCommandType;
      }

    public MapControlCommandCommandTypeJSON   getCommandType()
      {
        Debug.Assert(flagHasCommandType);
        return storeCommandType;
      }

    public MapControlCommandCommandTypeJSON.TypeValue  getCommandTypeValue()
      {
        return getCommandType().getValue();
      }

    public string  getCommandTypeAsString()
      {
        return getCommandType().getValueAsString();
      }

    public bool  hasDirection()
      {
        return flagHasDirection;
      }

    public double  getDirection()
      {
        Debug.Assert(flagHasDirection);
        if (textStoreDirection != "")
          {
            return Double.Parse(textStoreDirection);
          }
        return storeDirection;
      }

    public string  getDirectionAsText()
      {
        Debug.Assert(flagHasDirection);
        if (textStoreDirection == "")
          {
            return Convert.ToString(storeDirection);
          }
        else
          {
            return (textStoreDirection);
          }
      }

    public bool  hasPanDistance()
      {
        return flagHasPanDistance;
      }

    public double  getPanDistance()
      {
        Debug.Assert(flagHasPanDistance);
        if (textStorePanDistance != "")
          {
            return Double.Parse(textStorePanDistance);
          }
        return storePanDistance;
      }

    public string  getPanDistanceAsText()
      {
        Debug.Assert(flagHasPanDistance);
        if (textStorePanDistance == "")
          {
            return Convert.ToString(storePanDistance);
          }
        else
          {
            return (textStorePanDistance);
          }
      }

    public bool  hasPanUnit()
      {
        return flagHasPanUnit;
      }

    public TypePanUnit  getPanUnit()
      {
        Debug.Assert(flagHasPanUnit);
        return storePanUnit;
      }

    public string  getPanUnitAsString()
      {
        return stringFromPanUnit(getPanUnit());
      }

    public bool  hasZoomAmount()
      {
        return flagHasZoomAmount;
      }

    public double  getZoomAmount()
      {
        Debug.Assert(flagHasZoomAmount);
        if (textStoreZoomAmount != "")
          {
            return Double.Parse(textStoreZoomAmount);
          }
        return storeZoomAmount;
      }

    public string  getZoomAmountAsText()
      {
        Debug.Assert(flagHasZoomAmount);
        if (textStoreZoomAmount == "")
          {
            return Convert.ToString(storeZoomAmount);
          }
        else
          {
            return (textStoreZoomAmount);
          }
      }

    public bool  hasZoomUnit()
      {
        return flagHasZoomUnit;
      }

    public TypeZoomUnit  getZoomUnit()
      {
        Debug.Assert(flagHasZoomUnit);
        return storeZoomUnit;
      }

    public string  getZoomUnitAsString()
      {
        return stringFromZoomUnit(getZoomUnit());
      }


    public virtual int extraMapControlCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMapControlCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMapControlCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMapControlCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDeviceControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasCommandType)
            ++result;
        if (flagHasDirection)
            ++result;
        if (flagHasPanDistance)
            ++result;
        if (flagHasPanUnit)
            ++result;
        if (flagHasZoomAmount)
            ++result;
        if (flagHasZoomUnit)
            ++result;
        result += extraMapControlCommandComponentCount();
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
        if (flagHasDirection)
          {
            if (remainder == 0)
                return "Direction";
            --remainder;
          }
        if (flagHasPanDistance)
          {
            if (remainder == 0)
                return "PanDistance";
            --remainder;
          }
        if (flagHasPanUnit)
          {
            if (remainder == 0)
                return "PanUnit";
            --remainder;
          }
        if (flagHasZoomAmount)
          {
            if (remainder == 0)
                return "ZoomAmount";
            --remainder;
          }
        if (flagHasZoomUnit)
          {
            if (remainder == 0)
                return "ZoomUnit";
            --remainder;
          }
        return extraMapControlCommandComponentKey(remainder);
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
        if (flagHasDirection)
          {
            if (remainder == 0)
                return extraDirectionToJSON();
            --remainder;
          }
        if (flagHasPanDistance)
          {
            if (remainder == 0)
                return extraPanDistanceToJSON();
            --remainder;
          }
        if (flagHasPanUnit)
          {
            if (remainder == 0)
                return extraPanUnitToJSON();
            --remainder;
          }
        if (flagHasZoomAmount)
          {
            if (remainder == 0)
                return extraZoomAmountToJSON();
            --remainder;
          }
        if (flagHasZoomUnit)
          {
            if (remainder == 0)
                return extraZoomUnitToJSON();
            --remainder;
          }
        return extraMapControlCommandComponentValue(remainder);
      }
    public override JSONValue extraDeviceControlCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasCommandType ? extraCommandTypeToJSON() : null);
                break;
            case 'D':
                if ((String.Compare(field_name, 1, "irection", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasDirection ? extraDirectionToJSON() : null);
                break;
            case 'P':
                if (String.Compare(field_name, 1, "an", 0, 2, false) == 0)
                  {
                    switch (field_name[3])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 4, "istance", 0, 7, false) == 0) && (field_name.Length == 11))
                                return (flagHasPanDistance ? extraPanDistanceToJSON() : null);
                            break;
                        case 'U':
                            if ((String.Compare(field_name, 4, "nit", 0, 3, false) == 0) && (field_name.Length == 7))
                                return (flagHasPanUnit ? extraPanUnitToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Z':
                if (String.Compare(field_name, 1, "oom", 0, 3, false) == 0)
                  {
                    switch (field_name[4])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 5, "mount", 0, 5, false) == 0) && (field_name.Length == 10))
                                return (flagHasZoomAmount ? extraZoomAmountToJSON() : null);
                            break;
                        case 'U':
                            if ((String.Compare(field_name, 5, "nit", 0, 3, false) == 0) && (field_name.Length == 8))
                                return (flagHasZoomUnit ? extraZoomUnitToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraMapControlCommandLookup(field_name);
      }

    public void setCommandType(MapControlCommandCommandTypeJSON  new_value)
      {
        if (flagHasCommandType)
          {
          }
        flagHasCommandType = true;
        storeCommandType = new_value;
      }
    public void setCommandType(MapControlCommandCommandTypeJSON.TypeValue new_value)
      {
        setCommandType(new MapControlCommandCommandTypeJSON(new_value));
      }
    public void setCommandType(string chars)
      {
        setCommandType(new MapControlCommandCommandTypeJSON(chars));
      }
    public void unsetCommandType()
      {
        if (flagHasCommandType)
          {
          }
        flagHasCommandType = false;
      }
    public void setDirection(double new_value)
      {
        flagHasDirection = true;
        if (new_value < 0)
            throw new Exception("The value for field Direction of MapControlCommandJSON is less than the lower bound (0) for that field.");
        if (new_value > 360)
            throw new Exception("The value for field Direction of MapControlCommandJSON is greater than the upper bound (360) for that field.");
        storeDirection = new_value;
        textStoreDirection = "";
      }
    public void setDirectionText(string new_value)
      {
        flagHasDirection = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Direction of MapControlCommandJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field Direction of MapControlCommandJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "360", "", false, "3") > 0)
            throw new Exception("The value for field Direction of MapControlCommandJSON is greater than the upper bound (360) for that field.");
        textStoreDirection = new_value;
      }
    public void unsetDirection()
      {
        flagHasDirection = false;
      }
    public void setPanDistance(double new_value)
      {
        flagHasPanDistance = true;
        storePanDistance = new_value;
        textStorePanDistance = "";
      }
    public void setPanDistanceText(string new_value)
      {
        flagHasPanDistance = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field PanDistance of MapControlCommandJSON is not a valid number.");
        textStorePanDistance = new_value;
      }
    public void unsetPanDistance()
      {
        flagHasPanDistance = false;
      }
    public void setPanUnit(TypePanUnit new_value)
      {
        flagHasPanUnit = true;
        storePanUnit = new_value;
      }
    public void setPanUnit(string chars)
      {
        setPanUnit(stringToPanUnit(chars));
      }
    public void unsetPanUnit()
      {
        flagHasPanUnit = false;
      }
    public void setZoomAmount(double new_value)
      {
        flagHasZoomAmount = true;
        storeZoomAmount = new_value;
        textStoreZoomAmount = "";
      }
    public void setZoomAmountText(string new_value)
      {
        flagHasZoomAmount = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field ZoomAmount of MapControlCommandJSON is not a valid number.");
        textStoreZoomAmount = new_value;
      }
    public void unsetZoomAmount()
      {
        flagHasZoomAmount = false;
      }
    public void setZoomUnit(TypeZoomUnit new_value)
      {
        flagHasZoomUnit = true;
        storeZoomUnit = new_value;
      }
    public void setZoomUnit(string chars)
      {
        setZoomUnit(stringToZoomUnit(chars));
      }
    public void unsetZoomUnit()
      {
        flagHasZoomUnit = false;
      }

    public virtual void extraMapControlCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMapControlCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMapControlCommandLookup(key);
        if (old_field == null)
          {
            extraMapControlCommandAppendPair(key, new_component);
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
            case 'D':
                if ((String.Compare(key, 1, "irection", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONDirection(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if (String.Compare(key, 1, "an", 0, 2, false) == 0)
                  {
                    switch (key[3])
                      {
                        case 'D':
                            if ((String.Compare(key, 4, "istance", 0, 7, false) == 0) && (key.Length == 11))
                                {
                                fromJSONPanDistance(new_component, false);
                                return;
                                }
                            break;
                        case 'U':
                            if ((String.Compare(key, 4, "nit", 0, 3, false) == 0) && (key.Length == 7))
                                {
                                fromJSONPanUnit(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Z':
                if (String.Compare(key, 1, "oom", 0, 3, false) == 0)
                  {
                    switch (key[4])
                      {
                        case 'A':
                            if ((String.Compare(key, 5, "mount", 0, 5, false) == 0) && (key.Length == 10))
                                {
                                fromJSONZoomAmount(new_component, false);
                                return;
                                }
                            break;
                        case 'U':
                            if ((String.Compare(key, 5, "nit", 0, 3, false) == 0) && (key.Length == 8))
                                {
                                fromJSONZoomUnit(new_component, false);
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
        extraMapControlCommandAppendPair(key, new_component);
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
            case 'D':
                if ((String.Compare(key, 1, "irection", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONDirection(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if (String.Compare(key, 1, "an", 0, 2, false) == 0)
                  {
                    switch (key[3])
                      {
                        case 'D':
                            if ((String.Compare(key, 4, "istance", 0, 7, false) == 0) && (key.Length == 11))
                                {
                                fromJSONPanDistance(new_component, false);
                                return;
                                }
                            break;
                        case 'U':
                            if ((String.Compare(key, 4, "nit", 0, 3, false) == 0) && (key.Length == 7))
                                {
                                fromJSONPanUnit(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Z':
                if (String.Compare(key, 1, "oom", 0, 3, false) == 0)
                  {
                    switch (key[4])
                      {
                        case 'A':
                            if ((String.Compare(key, 5, "mount", 0, 5, false) == 0) && (key.Length == 10))
                                {
                                fromJSONZoomAmount(new_component, false);
                                return;
                                }
                            break;
                        case 'U':
                            if ((String.Compare(key, 5, "nit", 0, 3, false) == 0) && (key.Length == 8))
                                {
                                fromJSONZoomUnit(new_component, false);
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
        extraMapControlCommandSetField(key, new_component);
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
        if (flagHasDirection)
          {
            handler.start_pair("Direction");
            if (textStoreDirection != "")
                handler.number_value(textStoreDirection);
            else if (((double)(long)storeDirection) == storeDirection)
                handler.number_value((long)storeDirection);
            else
                handler.number_value(storeDirection);
          }
        if (flagHasPanDistance)
          {
            handler.start_pair("PanDistance");
            if (textStorePanDistance != "")
                handler.number_value(textStorePanDistance);
            else if (((double)(long)storePanDistance) == storePanDistance)
                handler.number_value((long)storePanDistance);
            else
                handler.number_value(storePanDistance);
          }
        if (flagHasPanUnit)
          {
            handler.start_pair("PanUnit");
            switch (storePanUnit)
              {
                case TypePanUnit.PanUnit_Miles:
                    handler.string_value("Miles");
                    break;
                case TypePanUnit.PanUnit_Kilometres:
                    handler.string_value("Kilometres");
                    break;
                case TypePanUnit.PanUnit_None:
                    handler.string_value("None");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasZoomAmount)
          {
            handler.start_pair("ZoomAmount");
            if (textStoreZoomAmount != "")
                handler.number_value(textStoreZoomAmount);
            else if (((double)(long)storeZoomAmount) == storeZoomAmount)
                handler.number_value((long)storeZoomAmount);
            else
                handler.number_value(storeZoomAmount);
          }
        if (flagHasZoomUnit)
          {
            handler.start_pair("ZoomUnit");
            switch (storeZoomUnit)
              {
                case TypeZoomUnit.ZoomUnit_Miles:
                    handler.string_value("Miles");
                    break;
                case TypeZoomUnit.ZoomUnit_Feet:
                    handler.string_value("Feet");
                    break;
                case TypeZoomUnit.ZoomUnit_Kilometres:
                    handler.string_value("Kilometres");
                    break;
                case TypeZoomUnit.ZoomUnit_Metres:
                    handler.string_value("Metres");
                    break;
                case TypeZoomUnit.ZoomUnit_None:
                    handler.string_value("None");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
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

    public static new MapControlCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MapControlCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapControlCommand", ignore_extras);
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
    public static new MapControlCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MapControlCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MapControlCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapControlCommand", ignore_extras);
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
    public static new MapControlCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MapControlCommandJSON from_text(string text, bool ignore_extras)
      {
        MapControlCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapControlCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MapControlCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MapControlCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MapControlCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapControlCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DeviceControlCommandJSON.Generator
      {
        private MapControlCommandCommandTypeJSON.HoldingGenerator fieldGeneratorCommandType;
        private JSONHoldingNumberTextGenerator fieldGeneratorDirection;
        private JSONHoldingNumberTextGenerator fieldGeneratorPanDistance;
    private abstract class FieldGeneratorPanUnit : JSONStringGenerator
          {
            protected FieldGeneratorPanUnit(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorPanUnit()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToPanUnit(result));
              }
            protected abstract void handle_result(TypePanUnit result);
          };
    private class FieldHoldingGeneratorPanUnit : FieldGeneratorPanUnit
  {
    protected override void handle_result(TypePanUnit result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorPanUnit(String what)
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
    public TypePanUnit value;
  };
    private class FieldHoldingArrayGeneratorPanUnit : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorPanUnit
      {
        private FieldHoldingArrayGeneratorPanUnit top;

        protected override void handle_result(TypePanUnit result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorPanUnit init_top)
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
    protected virtual void handle_result(List<TypePanUnit> result)
      {
      }

    public FieldHoldingArrayGeneratorPanUnit(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePanUnit>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorPanUnit()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePanUnit>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypePanUnit> value;
  };
        private FieldHoldingGeneratorPanUnit fieldGeneratorPanUnit;
        private JSONHoldingNumberTextGenerator fieldGeneratorZoomAmount;
    private abstract class FieldGeneratorZoomUnit : JSONStringGenerator
          {
            protected FieldGeneratorZoomUnit(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorZoomUnit()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToZoomUnit(result));
              }
            protected abstract void handle_result(TypeZoomUnit result);
          };
    private class FieldHoldingGeneratorZoomUnit : FieldGeneratorZoomUnit
  {
    protected override void handle_result(TypeZoomUnit result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorZoomUnit(String what)
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
    public TypeZoomUnit value;
  };
    private class FieldHoldingArrayGeneratorZoomUnit : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorZoomUnit
      {
        private FieldHoldingArrayGeneratorZoomUnit top;

        protected override void handle_result(TypeZoomUnit result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorZoomUnit init_top)
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
    protected virtual void handle_result(List<TypeZoomUnit> result)
      {
      }

    public FieldHoldingArrayGeneratorZoomUnit(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeZoomUnit>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorZoomUnit()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeZoomUnit>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeZoomUnit> value;
  };
        private FieldHoldingGeneratorZoomUnit fieldGeneratorZoomUnit;
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
            if (!(getDeviceControlCommandJSONKey().Equals("MapCommand")))
                throw new Exception("The key field has a value other than `MapCommand'.");
            MapControlCommandJSON result = new MapControlCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMapControlCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DeviceControlCommandJSON new_result)
          {
            handle_result((MapControlCommandJSON )new_result);
          }
        protected void finish(MapControlCommandJSON result)
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
            if (fieldGeneratorDirection.have_value)
              {
                result.setDirectionText(fieldGeneratorDirection.value);
                fieldGeneratorDirection.have_value = false;
              }
            if (fieldGeneratorPanDistance.have_value)
              {
                result.setPanDistanceText(fieldGeneratorPanDistance.value);
                fieldGeneratorPanDistance.have_value = false;
              }
            if (fieldGeneratorPanUnit.have_value)
              {
                result.setPanUnit(fieldGeneratorPanUnit.value);
                fieldGeneratorPanUnit.have_value = false;
              }
            if (fieldGeneratorZoomAmount.have_value)
              {
                result.setZoomAmountText(fieldGeneratorZoomAmount.value);
                fieldGeneratorZoomAmount.have_value = false;
              }
            if (fieldGeneratorZoomUnit.have_value)
              {
                result.setZoomUnit(fieldGeneratorZoomUnit.value);
                fieldGeneratorZoomUnit.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MapControlCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCommandType;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "irection", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorDirection;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "an", 0, 2, false) == 0)
                      {
                        switch (field_name[3])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 4, "istance", 0, 7, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorPanDistance;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 4, "nit", 0, 3, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorPanUnit;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'Z':
                    if (String.Compare(field_name, 1, "oom", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 5, "mount", 0, 5, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorZoomAmount;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 5, "nit", 0, 3, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorZoomUnit;
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
            fieldGeneratorCommandType = new MapControlCommandCommandTypeJSON.HoldingGenerator("field \"CommandType\" of the MapControlCommand class", ignore_extras);
            fieldGeneratorDirection = new JSONHoldingNumberTextGenerator("field \"Direction\" of the MapControlCommand class");
            fieldGeneratorPanDistance = new JSONHoldingNumberTextGenerator("field \"PanDistance\" of the MapControlCommand class");
            fieldGeneratorPanUnit = new FieldHoldingGeneratorPanUnit("field \"PanUnit\" of the MapControlCommand class");
            fieldGeneratorZoomAmount = new JSONHoldingNumberTextGenerator("field \"ZoomAmount\" of the MapControlCommand class");
            fieldGeneratorZoomUnit = new FieldHoldingGeneratorZoomUnit("field \"ZoomUnit\" of the MapControlCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MapControlCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCommandType = new MapControlCommandCommandTypeJSON.HoldingGenerator("field \"CommandType\" of the MapControlCommand class", false);
            fieldGeneratorDirection = new JSONHoldingNumberTextGenerator("field \"Direction\" of the MapControlCommand class");
            fieldGeneratorPanDistance = new JSONHoldingNumberTextGenerator("field \"PanDistance\" of the MapControlCommand class");
            fieldGeneratorPanUnit = new FieldHoldingGeneratorPanUnit("field \"PanUnit\" of the MapControlCommand class");
            fieldGeneratorZoomAmount = new JSONHoldingNumberTextGenerator("field \"ZoomAmount\" of the MapControlCommand class");
            fieldGeneratorZoomUnit = new FieldHoldingGeneratorZoomUnit("field \"ZoomUnit\" of the MapControlCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MapControlCommand class");
          }

        public override void reset()
          {
            fieldGeneratorCommandType.reset();
            fieldGeneratorDirection.reset();
            fieldGeneratorPanDistance.reset();
            fieldGeneratorPanUnit.reset();
            fieldGeneratorZoomAmount.reset();
            fieldGeneratorZoomUnit.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MapControlCommandJSON  result)
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
        public MapControlCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MapControlCommandJSON  result)
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
    protected virtual void handle_result(List<MapControlCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MapControlCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MapControlCommandJSON>();
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
    public List<MapControlCommandJSON> value;
  };
  };
