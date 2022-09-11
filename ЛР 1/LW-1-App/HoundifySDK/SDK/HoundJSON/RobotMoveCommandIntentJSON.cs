/* file "RobotMoveCommandIntentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RobotMoveCommandIntentJSON : RobotCommandIntentJSON
  {
    public enum TypeDistanceUnitKnownValues
      {
        DistanceUnit_inch,
        DistanceUnit_foot,
        DistanceUnit_yard,
        DistanceUnit_millimeter,
        DistanceUnit_centimeter,
        DistanceUnit_meter,
        DistanceUnit__none
      };
    public struct TypeDistanceUnit
      {
        public bool in_known_list;
        public string string_value;
        public TypeDistanceUnitKnownValues list_value;
      };

    public static TypeDistanceUnitKnownValues  stringToDistanceUnit(string chars)
      {
        switch (chars[0])
          {
            case 'c':
                if ((String.Compare(chars, 1, "entimeter", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeDistanceUnitKnownValues.DistanceUnit_centimeter;
                break;
            case 'f':
                if ((String.Compare(chars, 1, "oot", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeDistanceUnitKnownValues.DistanceUnit_foot;
                break;
            case 'i':
                if ((String.Compare(chars, 1, "nch", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeDistanceUnitKnownValues.DistanceUnit_inch;
                break;
            case 'm':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "ter", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeDistanceUnitKnownValues.DistanceUnit_meter;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "llimeter", 0, 8, false) == 0) && (chars.Length == 10))
                            return TypeDistanceUnitKnownValues.DistanceUnit_millimeter;
                        break;
                    default:
                        break;
                  }
                break;
            case 'y':
                if ((String.Compare(chars, 1, "ard", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeDistanceUnitKnownValues.DistanceUnit_yard;
                break;
            default:
                break;
          }
        return TypeDistanceUnitKnownValues.DistanceUnit__none;
      }

    public static string  stringFromDistanceUnit(TypeDistanceUnitKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeDistanceUnitKnownValues.DistanceUnit_inch:
                return "inch";
            case TypeDistanceUnitKnownValues.DistanceUnit_foot:
                return "foot";
            case TypeDistanceUnitKnownValues.DistanceUnit_yard:
                return "yard";
            case TypeDistanceUnitKnownValues.DistanceUnit_millimeter:
                return "millimeter";
            case TypeDistanceUnitKnownValues.DistanceUnit_centimeter:
                return "centimeter";
            case TypeDistanceUnitKnownValues.DistanceUnit_meter:
                return "meter";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasDirection;
    private short storeDirection;
    private bool flagHasDistance;
    private double storeDistance;
    private string textStoreDistance;
    private bool flagHasDistanceUnit;
    private TypeDistanceUnit storeDistanceUnit;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraDirectionToJSON()
      {
        JSONIntegerValue generated_integer_Direction = new JSONIntegerValue(storeDirection);
        return generated_integer_Direction;
      }

    private JSONValue  extraDistanceToJSON()
      {
        JSONValue generated_rational_Distance;
        if (textStoreDistance != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreDistance);
            generated_rational_Distance = handler.result;
          }
        else if (((double)(long)storeDistance) == storeDistance)
            generated_rational_Distance = new JSONIntegerValue((long)(storeDistance));
        else
            generated_rational_Distance = new JSONRationalValue(storeDistance, 15);
        return generated_rational_Distance;
      }

    private JSONValue  extraDistanceUnitToJSON()
      {
        JSONStringValue generated_string_DistanceUnit;
        if (!(storeDistanceUnit.in_known_list))
          {
        generated_string_DistanceUnit = new JSONStringValue(storeDistanceUnit.string_value);
          }
        else
          {
        switch (storeDistanceUnit.list_value)
          {
            case TypeDistanceUnitKnownValues.DistanceUnit_inch:
                generated_string_DistanceUnit = new JSONStringValue("inch");
                break;
            case TypeDistanceUnitKnownValues.DistanceUnit_foot:
                generated_string_DistanceUnit = new JSONStringValue("foot");
                break;
            case TypeDistanceUnitKnownValues.DistanceUnit_yard:
                generated_string_DistanceUnit = new JSONStringValue("yard");
                break;
            case TypeDistanceUnitKnownValues.DistanceUnit_millimeter:
                generated_string_DistanceUnit = new JSONStringValue("millimeter");
                break;
            case TypeDistanceUnitKnownValues.DistanceUnit_centimeter:
                generated_string_DistanceUnit = new JSONStringValue("centimeter");
                break;
            case TypeDistanceUnitKnownValues.DistanceUnit_meter:
                generated_string_DistanceUnit = new JSONStringValue("meter");
                break;
            default:
                Debug.Assert(false);
                generated_string_DistanceUnit = null;
                break;
          }
          }
        return generated_string_DistanceUnit;
      }


    private void  fromJSONDirection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        short extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Direction of RobotMoveCommandIntentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Direction of RobotMoveCommandIntentJSON is not an integer.");
              }
            extracted_integer = (short)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (short)(json_integer.getLongInt())        ;
          }
        setDirection(extracted_integer);
      }


    private void  fromJSONDistance(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Distance of RobotMoveCommandIntentJSON is not a number.");
              }
          }
        setDistanceText(the_rational_text);
      }


    private void  fromJSONDistanceUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DistanceUnit of RobotMoveCommandIntentJSON is not a string.");
        TypeDistanceUnit the_open_enum = new TypeDistanceUnit();
        switch (json_string.getData()[0])
          {
            case 'c':
                if ((String.Compare(json_string.getData(), 1, "entimeter", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDistanceUnitKnownValues.DistanceUnit_centimeter;
                        goto open_enum_is_done;
                      }
                break;
            case 'f':
                if ((String.Compare(json_string.getData(), 1, "oot", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDistanceUnitKnownValues.DistanceUnit_foot;
                        goto open_enum_is_done;
                      }
                break;
            case 'i':
                if ((String.Compare(json_string.getData(), 1, "nch", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDistanceUnitKnownValues.DistanceUnit_inch;
                        goto open_enum_is_done;
                      }
                break;
            case 'm':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "ter", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDistanceUnitKnownValues.DistanceUnit_meter;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "llimeter", 0, 8, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDistanceUnitKnownValues.DistanceUnit_millimeter;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'y':
                if ((String.Compare(json_string.getData(), 1, "ard", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDistanceUnitKnownValues.DistanceUnit_yard;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setDistanceUnit(the_open_enum);
      }


    public RobotMoveCommandIntentJSON()
      {
        flagHasDirection = false;
        flagHasDistance = false;
        flagHasDistanceUnit = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRobotIntentKind()
      {
        return "MoveCommand";
      }

    public bool  hasDirection()
      {
        return flagHasDirection;
      }

    public short  getDirection()
      {
        Debug.Assert(flagHasDirection);
        return storeDirection;
      }

    public bool  hasDistance()
      {
        return flagHasDistance;
      }

    public double  getDistance()
      {
        Debug.Assert(flagHasDistance);
        if (textStoreDistance != "")
          {
            return Double.Parse(textStoreDistance);
          }
        return storeDistance;
      }

    public string  getDistanceAsText()
      {
        Debug.Assert(flagHasDistance);
        if (textStoreDistance == "")
          {
            return Convert.ToString(storeDistance);
          }
        else
          {
            return (textStoreDistance);
          }
      }

    public bool  hasDistanceUnit()
      {
        return flagHasDistanceUnit;
      }

    public TypeDistanceUnit  getDistanceUnit()
      {
        Debug.Assert(flagHasDistanceUnit);
        return storeDistanceUnit;
      }

    public string  getDistanceUnitAsString()
      {
        TypeDistanceUnit result = getDistanceUnit();
        if (result.in_known_list)
            return stringFromDistanceUnit(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraRobotMoveCommandIntentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRobotMoveCommandIntentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRobotMoveCommandIntentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRobotMoveCommandIntentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRobotCommandIntentComponentCount()
      {
        int result = 0;
        if (flagHasDirection)
            ++result;
        if (flagHasDistance)
            ++result;
        if (flagHasDistanceUnit)
            ++result;
        result += extraRobotMoveCommandIntentComponentCount();
        return result;
      }
    public override string extraRobotCommandIntentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasDirection)
          {
            if (remainder == 0)
                return "Direction";
            --remainder;
          }
        if (flagHasDistance)
          {
            if (remainder == 0)
                return "Distance";
            --remainder;
          }
        if (flagHasDistanceUnit)
          {
            if (remainder == 0)
                return "DistanceUnit";
            --remainder;
          }
        return extraRobotMoveCommandIntentComponentKey(remainder);
      }
    public override JSONValue extraRobotCommandIntentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasDirection)
          {
            if (remainder == 0)
                return extraDirectionToJSON();
            --remainder;
          }
        if (flagHasDistance)
          {
            if (remainder == 0)
                return extraDistanceToJSON();
            --remainder;
          }
        if (flagHasDistanceUnit)
          {
            if (remainder == 0)
                return extraDistanceUnitToJSON();
            --remainder;
          }
        return extraRobotMoveCommandIntentComponentValue(remainder);
      }
    public override JSONValue extraRobotCommandIntentLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "Di", 0, 2, false) == 0)
          {
            switch (field_name[2])
              {
                case 'r':
                    if ((String.Compare(field_name, 3, "ection", 0, 6, false) == 0) && (field_name.Length == 9))
                        return (flagHasDirection ? extraDirectionToJSON() : null);
                    break;
                case 's':
                    if (String.Compare(field_name, 3, "tance", 0, 5, false) == 0)
                      {
                        if (field_name.Length == 8)
                          {
                            return (flagHasDistance ? extraDistanceToJSON() : null);
                          }
                        switch (field_name[8])
                          {
                            case 'U':
                                if ((String.Compare(field_name, 9, "nit", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return (flagHasDistanceUnit ? extraDistanceUnitToJSON() : null);
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
          }
        return extraRobotMoveCommandIntentLookup(field_name);
      }

    public void setDirection(short new_value)
      {
        flagHasDirection = true;
        if (new_value < -180)
            throw new Exception("The value for field Direction of RobotMoveCommandIntentJSON is less than the lower bound (-180) for that field.");
        if (new_value > 180)
            throw new Exception("The value for field Direction of RobotMoveCommandIntentJSON is greater than the upper bound (180) for that field.");
        storeDirection = new_value;
      }
    public void unsetDirection()
      {
        flagHasDirection = false;
      }
    public void setDistance(double new_value)
      {
        flagHasDistance = true;
        if (new_value < 0)
            throw new Exception("The value for field Distance of RobotMoveCommandIntentJSON is less than the lower bound (0) for that field.");
        storeDistance = new_value;
        textStoreDistance = "";
      }
    public void setDistanceText(string new_value)
      {
        flagHasDistance = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Distance of RobotMoveCommandIntentJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field Distance of RobotMoveCommandIntentJSON is less than the lower bound (0) for that field.");
        textStoreDistance = new_value;
      }
    public void unsetDistance()
      {
        flagHasDistance = false;
      }
    public void setDistanceUnit(TypeDistanceUnit new_value)
      {
        flagHasDistanceUnit = true;
        storeDistanceUnit = new_value;
      }
    public void setDistanceUnit(string chars)
      {
        TypeDistanceUnitKnownValues known = stringToDistanceUnit(chars);
        TypeDistanceUnit new_value = new TypeDistanceUnit();
        if (known == TypeDistanceUnitKnownValues.DistanceUnit__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setDistanceUnit(new_value);
      }
    public void setDistanceUnit(TypeDistanceUnitKnownValues new_value)
      {
        TypeDistanceUnit new_full_value = new TypeDistanceUnit();
        Debug.Assert(new_value != TypeDistanceUnitKnownValues.DistanceUnit__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setDistanceUnit(new_full_value);
      }
    public void unsetDistanceUnit()
      {
        flagHasDistanceUnit = false;
      }

    public virtual void extraRobotMoveCommandIntentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRobotMoveCommandIntentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRobotMoveCommandIntentLookup(key);
        if (old_field == null)
          {
            extraRobotMoveCommandIntentAppendPair(key, new_component);
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
    public override void extraRobotCommandIntentAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Di", 0, 2, false) == 0)
          {
            switch (key[2])
              {
                case 'r':
                    if ((String.Compare(key, 3, "ection", 0, 6, false) == 0) && (key.Length == 9))
                        {
                        fromJSONDirection(new_component, false);
                        return;
                        }
                    break;
                case 's':
                    if (String.Compare(key, 3, "tance", 0, 5, false) == 0)
                      {
                        if (key.Length == 8)
                          {
                            {
                            fromJSONDistance(new_component, false);
                            return;
                            }
                          }
                        switch (key[8])
                          {
                            case 'U':
                                if ((String.Compare(key, 9, "nit", 0, 3, false) == 0) && (key.Length == 12))
                                    {
                                    fromJSONDistanceUnit(new_component, false);
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
          }
        extraRobotMoveCommandIntentAppendPair(key, new_component);
      }
    public override void extraRobotCommandIntentSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Di", 0, 2, false) == 0)
          {
            switch (key[2])
              {
                case 'r':
                    if ((String.Compare(key, 3, "ection", 0, 6, false) == 0) && (key.Length == 9))
                        {
                        fromJSONDirection(new_component, false);
                        return;
                        }
                    break;
                case 's':
                    if (String.Compare(key, 3, "tance", 0, 5, false) == 0)
                      {
                        if (key.Length == 8)
                          {
                            {
                            fromJSONDistance(new_component, false);
                            return;
                            }
                          }
                        switch (key[8])
                          {
                            case 'U':
                                if ((String.Compare(key, 9, "nit", 0, 3, false) == 0) && (key.Length == 12))
                                    {
                                    fromJSONDistanceUnit(new_component, false);
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
          }
        extraRobotMoveCommandIntentSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDirection);
        if (flagHasDirection)
          {
            handler.start_pair("Direction");
            handler.number_value(storeDirection);
          }
        Debug.Assert(partial_allowed || flagHasDistance);
        if (flagHasDistance)
          {
            handler.start_pair("Distance");
            if (textStoreDistance != "")
                handler.number_value(textStoreDistance);
            else if (((double)(long)storeDistance) == storeDistance)
                handler.number_value((long)storeDistance);
            else
                handler.number_value(storeDistance);
          }
        Debug.Assert(partial_allowed || flagHasDistanceUnit);
        if (flagHasDistanceUnit)
          {
            handler.start_pair("DistanceUnit");
            if (storeDistanceUnit.in_known_list)
              {
                switch (storeDistanceUnit.list_value)
                  {
                    case TypeDistanceUnitKnownValues.DistanceUnit_inch:
                        handler.string_value("inch");
                        break;
                    case TypeDistanceUnitKnownValues.DistanceUnit_foot:
                        handler.string_value("foot");
                        break;
                    case TypeDistanceUnitKnownValues.DistanceUnit_yard:
                        handler.string_value("yard");
                        break;
                    case TypeDistanceUnitKnownValues.DistanceUnit_millimeter:
                        handler.string_value("millimeter");
                        break;
                    case TypeDistanceUnitKnownValues.DistanceUnit_centimeter:
                        handler.string_value("centimeter");
                        break;
                    case TypeDistanceUnitKnownValues.DistanceUnit_meter:
                        handler.string_value("meter");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeDistanceUnit.string_value);
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
        if (!(hasDirection()))
          {
            return "When parsing the object for %what%, the \"Direction\" field was missing.";
          }
        if (!(hasDistance()))
          {
            return "When parsing the object for %what%, the \"Distance\" field was missing.";
          }
        if (!(hasDistanceUnit()))
          {
            return "When parsing the object for %what%, the \"DistanceUnit\" field was missing.";
          }
        return null;
      }

    public static new RobotMoveCommandIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RobotMoveCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotMoveCommandIntent", ignore_extras);
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
    public static new RobotMoveCommandIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RobotMoveCommandIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RobotMoveCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotMoveCommandIntent", ignore_extras);
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
    public static new RobotMoveCommandIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RobotMoveCommandIntentJSON from_text(string text, bool ignore_extras)
      {
        RobotMoveCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotMoveCommandIntent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RobotMoveCommandIntentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RobotMoveCommandIntentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RobotMoveCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotMoveCommandIntent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RobotCommandIntentJSON.Generator
      {
    private class FieldHoldingGeneratorDirection : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorDirection(String what) : base(what, -180, 180)
              {
              }
          };
    private class FieldHoldingArrayGeneratorDirection : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorDirection(String what) : base(what, -180, 180)
              {
              }
          };
        private FieldHoldingGeneratorDirection fieldGeneratorDirection;
        private JSONHoldingNumberTextGenerator fieldGeneratorDistance;
    private abstract class FieldGeneratorDistanceUnit : JSONStringGenerator
          {
            protected FieldGeneratorDistanceUnit(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDistanceUnit()
              {
              }
            protected override void handle_result(string result)
              {
                TypeDistanceUnitKnownValues known = stringToDistanceUnit(result);
                TypeDistanceUnit new_value = new TypeDistanceUnit();
                if (known == TypeDistanceUnitKnownValues.DistanceUnit__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeDistanceUnit result);
          };
    private class FieldHoldingGeneratorDistanceUnit : FieldGeneratorDistanceUnit
  {
    protected override void handle_result(TypeDistanceUnit result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDistanceUnit(String what)
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
    public TypeDistanceUnit value;
  };
    private class FieldHoldingArrayGeneratorDistanceUnit : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDistanceUnit
      {
        private FieldHoldingArrayGeneratorDistanceUnit top;

        protected override void handle_result(TypeDistanceUnit result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDistanceUnit init_top)
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
    protected virtual void handle_result(List<TypeDistanceUnit> result)
      {
      }

    public FieldHoldingArrayGeneratorDistanceUnit(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDistanceUnit>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDistanceUnit()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDistanceUnit>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDistanceUnit> value;
  };
        private FieldHoldingGeneratorDistanceUnit fieldGeneratorDistanceUnit;
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
            if (!(getRobotCommandIntentJSONKey().Equals("MoveCommand")))
                throw new Exception("The key field has a value other than `MoveCommand'.");
            RobotMoveCommandIntentJSON result = new RobotMoveCommandIntentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRobotMoveCommandIntentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RobotCommandIntentJSON new_result)
          {
            handle_result((RobotMoveCommandIntentJSON )new_result);
          }
        protected void finish(RobotMoveCommandIntentJSON result)
          {
            if (fieldGeneratorDirection.have_value)
              {
                result.setDirection((short)(fieldGeneratorDirection.value));
                fieldGeneratorDirection.have_value = false;
              }
            else if ((!(result.hasDirection())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Direction\" field was missing.");
              }
            if (fieldGeneratorDistance.have_value)
              {
                result.setDistanceText(fieldGeneratorDistance.value);
                fieldGeneratorDistance.have_value = false;
              }
            else if ((!(result.hasDistance())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Distance\" field was missing.");
              }
            if (fieldGeneratorDistanceUnit.have_value)
              {
                result.setDistanceUnit(fieldGeneratorDistanceUnit.value);
                fieldGeneratorDistanceUnit.have_value = false;
              }
            else if ((!(result.hasDistanceUnit())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DistanceUnit\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(RobotMoveCommandIntentJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Di", 0, 2, false) == 0)
              {
                switch (field_name[2])
                  {
                    case 'r':
                        if ((String.Compare(field_name, 3, "ection", 0, 6, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorDirection;
                        break;
                    case 's':
                        if (String.Compare(field_name, 3, "tance", 0, 5, false) == 0)
                          {
                            if (field_name.Length == 8)
                              {
                                return fieldGeneratorDistance;
                              }
                            switch (field_name[8])
                              {
                                case 'U':
                                    if ((String.Compare(field_name, 9, "nit", 0, 3, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorDistanceUnit;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorDirection = new FieldHoldingGeneratorDirection("field \"Direction\" of the RobotMoveCommandIntent class");
            fieldGeneratorDistance = new JSONHoldingNumberTextGenerator("field \"Distance\" of the RobotMoveCommandIntent class");
            fieldGeneratorDistanceUnit = new FieldHoldingGeneratorDistanceUnit("field \"DistanceUnit\" of the RobotMoveCommandIntent class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RobotMoveCommandIntent class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorDirection = new FieldHoldingGeneratorDirection("field \"Direction\" of the RobotMoveCommandIntent class");
            fieldGeneratorDistance = new JSONHoldingNumberTextGenerator("field \"Distance\" of the RobotMoveCommandIntent class");
            fieldGeneratorDistanceUnit = new FieldHoldingGeneratorDistanceUnit("field \"DistanceUnit\" of the RobotMoveCommandIntent class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RobotMoveCommandIntent class");
          }

        public override void reset()
          {
            fieldGeneratorDirection.reset();
            fieldGeneratorDistance.reset();
            fieldGeneratorDistanceUnit.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RobotMoveCommandIntentJSON  result)
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
        public RobotMoveCommandIntentJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RobotMoveCommandIntentJSON  result)
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
    protected virtual void handle_result(List<RobotMoveCommandIntentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RobotMoveCommandIntentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RobotMoveCommandIntentJSON>();
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
    public List<RobotMoveCommandIntentJSON> value;
  };
  };
