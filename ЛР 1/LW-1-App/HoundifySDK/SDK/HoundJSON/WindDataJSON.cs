/* file "WindDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WindDataJSON : JSONBase
  {
    public enum TypeDirectionAbbreviationKnownValues
      {
        DirectionAbbreviation_Variable,
        DirectionAbbreviation_N,
        DirectionAbbreviation_S,
        DirectionAbbreviation_E,
        DirectionAbbreviation_W,
        DirectionAbbreviation_NW,
        DirectionAbbreviation_NE,
        DirectionAbbreviation_SW,
        DirectionAbbreviation_SE,
        DirectionAbbreviation_NNW,
        DirectionAbbreviation_NNE,
        DirectionAbbreviation_SSW,
        DirectionAbbreviation_SSE,
        DirectionAbbreviation_WNW,
        DirectionAbbreviation_WSW,
        DirectionAbbreviation_ENE,
        DirectionAbbreviation_ESE,
        DirectionAbbreviation__none
      };
    public struct TypeDirectionAbbreviation
      {
        public bool in_known_list;
        public string string_value;
        public TypeDirectionAbbreviationKnownValues list_value;
      };

    public static TypeDirectionAbbreviationKnownValues  stringToDirectionAbbreviation(string chars)
      {
        switch (chars[0])
          {
            case 'E':
                if (chars.Length == 1)
                  {
                    return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_E;
                  }
                switch (chars[1])
                  {
                    case 'N':
                        if ((String.Compare(chars, 2, "E", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_ENE;
                        break;
                    case 'S':
                        if ((String.Compare(chars, 2, "E", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_ESE;
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if (chars.Length == 1)
                  {
                    return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_N;
                  }
                switch (chars[1])
                  {
                    case 'E':
                        if (chars.Length == 2)
                            return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_NE;
                        break;
                    case 'N':
                        switch (chars[2])
                          {
                            case 'E':
                                if (chars.Length == 3)
                                    return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_NNE;
                                break;
                            case 'W':
                                if (chars.Length == 3)
                                    return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_NNW;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'W':
                        if (chars.Length == 2)
                            return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_NW;
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if (chars.Length == 1)
                  {
                    return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_S;
                  }
                switch (chars[1])
                  {
                    case 'E':
                        if (chars.Length == 2)
                            return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_SE;
                        break;
                    case 'S':
                        switch (chars[2])
                          {
                            case 'E':
                                if (chars.Length == 3)
                                    return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_SSE;
                                break;
                            case 'W':
                                if (chars.Length == 3)
                                    return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_SSW;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'W':
                        if (chars.Length == 2)
                            return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_SW;
                        break;
                    default:
                        break;
                  }
                break;
            case 'V':
                if ((String.Compare(chars, 1, "ariable", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_Variable;
                break;
            case 'W':
                if (chars.Length == 1)
                  {
                    return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_W;
                  }
                switch (chars[1])
                  {
                    case 'N':
                        if ((String.Compare(chars, 2, "W", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_WNW;
                        break;
                    case 'S':
                        if ((String.Compare(chars, 2, "W", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_WSW;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return TypeDirectionAbbreviationKnownValues.DirectionAbbreviation__none;
      }

    public static string  stringFromDirectionAbbreviation(TypeDirectionAbbreviationKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_Variable:
                return "Variable";
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_N:
                return "N";
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_S:
                return "S";
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_E:
                return "E";
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_W:
                return "W";
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_NW:
                return "NW";
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_NE:
                return "NE";
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_SW:
                return "SW";
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_SE:
                return "SE";
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_NNW:
                return "NNW";
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_NNE:
                return "NNE";
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_SSW:
                return "SSW";
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_SSE:
                return "SSE";
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_WNW:
                return "WNW";
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_WSW:
                return "WSW";
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_ENE:
                return "ENE";
            case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_ESE:
                return "ESE";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasValue;
    private UnitsValue_WindJSON  storeValue;
    private bool flagHasDirectionAbbreviation;
    private TypeDirectionAbbreviation storeDirectionAbbreviation;
    private bool flagHasDirectionText;
    private string storeDirectionText;
    private bool flagHasDirectionTextWritten;
    private string storeDirectionTextWritten;
    private bool flagHasDirectionDegrees;
    private short storeDirectionDegrees;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UnitsValue_WindJSON convert_classy = UnitsValue_WindJSON.from_json(json_value, ignore_extras, true);
        setValue(convert_classy);
      }


    private void  fromJSONDirectionAbbreviation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DirectionAbbreviation of WindDataJSON is not a string.");
        TypeDirectionAbbreviation the_open_enum = new TypeDirectionAbbreviation();
        switch (json_string.getData()[0])
          {
            case 'E':
                if (json_string.getData().Length == 1)
                  {
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_E;
                        goto open_enum_is_done;
                      }
                  }
                switch (json_string.getData()[1])
                  {
                    case 'N':
                        if ((String.Compare(json_string.getData(), 2, "E", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_ENE;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'S':
                        if ((String.Compare(json_string.getData(), 2, "E", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_ESE;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if (json_string.getData().Length == 1)
                  {
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_N;
                        goto open_enum_is_done;
                      }
                  }
                switch (json_string.getData()[1])
                  {
                    case 'E':
                        if (json_string.getData().Length == 2)
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_NE;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'N':
                        switch (json_string.getData()[2])
                          {
                            case 'E':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_NNE;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'W':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_NNW;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'W':
                        if (json_string.getData().Length == 2)
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_NW;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if (json_string.getData().Length == 1)
                  {
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_S;
                        goto open_enum_is_done;
                      }
                  }
                switch (json_string.getData()[1])
                  {
                    case 'E':
                        if (json_string.getData().Length == 2)
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_SE;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'S':
                        switch (json_string.getData()[2])
                          {
                            case 'E':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_SSE;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'W':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_SSW;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'W':
                        if (json_string.getData().Length == 2)
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_SW;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'V':
                if ((String.Compare(json_string.getData(), 1, "ariable", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_Variable;
                        goto open_enum_is_done;
                      }
                break;
            case 'W':
                if (json_string.getData().Length == 1)
                  {
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_W;
                        goto open_enum_is_done;
                      }
                  }
                switch (json_string.getData()[1])
                  {
                    case 'N':
                        if ((String.Compare(json_string.getData(), 2, "W", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_WNW;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'S':
                        if ((String.Compare(json_string.getData(), 2, "W", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_WSW;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setDirectionAbbreviation(the_open_enum);
      }


    private void  fromJSONDirectionText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DirectionText of WindDataJSON is not a string.");
        setDirectionText(json_string.getData());
      }


    private void  fromJSONDirectionTextWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DirectionTextWritten of WindDataJSON is not a string.");
        setDirectionTextWritten(json_string.getData());
      }


    private void  fromJSONDirectionDegrees(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        short extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DirectionDegrees of WindDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DirectionDegrees of WindDataJSON is not an integer.");
              }
            extracted_integer = (short)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (short)(json_integer.getLongInt())        ;
          }
        setDirectionDegrees(extracted_integer);
      }


    public WindDataJSON()
      {
        flagHasValue = false;
        flagHasDirectionAbbreviation = false;
        flagHasDirectionText = false;
        flagHasDirectionTextWritten = false;
        flagHasDirectionDegrees = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public UnitsValue_WindJSON   getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }

    public bool  hasDirectionAbbreviation()
      {
        return flagHasDirectionAbbreviation;
      }

    public TypeDirectionAbbreviation  getDirectionAbbreviation()
      {
        Debug.Assert(flagHasDirectionAbbreviation);
        return storeDirectionAbbreviation;
      }

    public string  getDirectionAbbreviationAsString()
      {
        TypeDirectionAbbreviation result = getDirectionAbbreviation();
        if (result.in_known_list)
            return stringFromDirectionAbbreviation(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasDirectionText()
      {
        return flagHasDirectionText;
      }

    public string  getDirectionText()
      {
        Debug.Assert(flagHasDirectionText);
        return storeDirectionText;
      }

    public bool  hasDirectionTextWritten()
      {
        return flagHasDirectionTextWritten;
      }

    public string  getDirectionTextWritten()
      {
        Debug.Assert(flagHasDirectionTextWritten);
        return storeDirectionTextWritten;
      }

    public bool  hasDirectionDegrees()
      {
        return flagHasDirectionDegrees;
      }

    public short  getDirectionDegrees()
      {
        Debug.Assert(flagHasDirectionDegrees);
        return storeDirectionDegrees;
      }


    public virtual int extraWindDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWindDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWindDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWindDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setValue(UnitsValue_WindJSON  new_value)
      {
        if (flagHasValue)
          {
          }
        flagHasValue = true;
        storeValue = new_value;
      }
    public void unsetValue()
      {
        if (flagHasValue)
          {
          }
        flagHasValue = false;
      }
    public void setDirectionAbbreviation(TypeDirectionAbbreviation new_value)
      {
        flagHasDirectionAbbreviation = true;
        storeDirectionAbbreviation = new_value;
      }
    public void setDirectionAbbreviation(string chars)
      {
        TypeDirectionAbbreviationKnownValues known = stringToDirectionAbbreviation(chars);
        TypeDirectionAbbreviation new_value = new TypeDirectionAbbreviation();
        if (known == TypeDirectionAbbreviationKnownValues.DirectionAbbreviation__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setDirectionAbbreviation(new_value);
      }
    public void setDirectionAbbreviation(TypeDirectionAbbreviationKnownValues new_value)
      {
        TypeDirectionAbbreviation new_full_value = new TypeDirectionAbbreviation();
        Debug.Assert(new_value != TypeDirectionAbbreviationKnownValues.DirectionAbbreviation__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setDirectionAbbreviation(new_full_value);
      }
    public void unsetDirectionAbbreviation()
      {
        flagHasDirectionAbbreviation = false;
      }
    public void setDirectionText(string new_value)
      {
        flagHasDirectionText = true;
        storeDirectionText = new_value;
      }
    public void unsetDirectionText()
      {
        flagHasDirectionText = false;
      }
    public void setDirectionTextWritten(string new_value)
      {
        flagHasDirectionTextWritten = true;
        storeDirectionTextWritten = new_value;
      }
    public void unsetDirectionTextWritten()
      {
        flagHasDirectionTextWritten = false;
      }
    public void setDirectionDegrees(short new_value)
      {
        flagHasDirectionDegrees = true;
        if (new_value < 0)
            throw new Exception("The value for field DirectionDegrees of WindDataJSON is less than the lower bound (0) for that field.");
        if (new_value > 360)
            throw new Exception("The value for field DirectionDegrees of WindDataJSON is greater than the upper bound (360) for that field.");
        storeDirectionDegrees = new_value;
      }
    public void unsetDirectionDegrees()
      {
        flagHasDirectionDegrees = false;
      }

    public virtual void extraWindDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWindDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWindDataLookup(key);
        if (old_field == null)
          {
            extraWindDataAppendPair(key, new_component);
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
        if (flagHasValue)
          {
            handler.start_pair("Value");
            if (partial_allowed)
                storeValue.write_partial_as_json(handler);
            else
                storeValue.write_as_json(handler);
          }
        if (flagHasDirectionAbbreviation)
          {
            handler.start_pair("DirectionAbbreviation");
            if (storeDirectionAbbreviation.in_known_list)
              {
                switch (storeDirectionAbbreviation.list_value)
                  {
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_Variable:
                        handler.string_value("Variable");
                        break;
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_N:
                        handler.string_value("N");
                        break;
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_S:
                        handler.string_value("S");
                        break;
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_E:
                        handler.string_value("E");
                        break;
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_W:
                        handler.string_value("W");
                        break;
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_NW:
                        handler.string_value("NW");
                        break;
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_NE:
                        handler.string_value("NE");
                        break;
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_SW:
                        handler.string_value("SW");
                        break;
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_SE:
                        handler.string_value("SE");
                        break;
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_NNW:
                        handler.string_value("NNW");
                        break;
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_NNE:
                        handler.string_value("NNE");
                        break;
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_SSW:
                        handler.string_value("SSW");
                        break;
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_SSE:
                        handler.string_value("SSE");
                        break;
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_WNW:
                        handler.string_value("WNW");
                        break;
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_WSW:
                        handler.string_value("WSW");
                        break;
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_ENE:
                        handler.string_value("ENE");
                        break;
                    case TypeDirectionAbbreviationKnownValues.DirectionAbbreviation_ESE:
                        handler.string_value("ESE");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeDirectionAbbreviation.string_value);
              }
          }
        if (flagHasDirectionText)
          {
            handler.start_pair("DirectionText");
            handler.string_value(storeDirectionText);
          }
        if (flagHasDirectionTextWritten)
          {
            handler.start_pair("DirectionTextWritten");
            handler.string_value(storeDirectionTextWritten);
          }
        if (flagHasDirectionDegrees)
          {
            handler.start_pair("DirectionDegrees");
            handler.number_value(storeDirectionDegrees);
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

    public static WindDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WindDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WindData", ignore_extras);
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
    public static WindDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WindDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WindDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WindData", ignore_extras);
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
    public static WindDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WindDataJSON from_text(string text, bool ignore_extras)
      {
        WindDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WindData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WindDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static WindDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WindDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WindData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private UnitsValue_WindJSON.HoldingGenerator fieldGeneratorValue;
    private abstract class FieldGeneratorDirectionAbbreviation : JSONStringGenerator
          {
            protected FieldGeneratorDirectionAbbreviation(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDirectionAbbreviation()
              {
              }
            protected override void handle_result(string result)
              {
                TypeDirectionAbbreviationKnownValues known = stringToDirectionAbbreviation(result);
                TypeDirectionAbbreviation new_value = new TypeDirectionAbbreviation();
                if (known == TypeDirectionAbbreviationKnownValues.DirectionAbbreviation__none)
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
            protected abstract void handle_result(TypeDirectionAbbreviation result);
          };
    private class FieldHoldingGeneratorDirectionAbbreviation : FieldGeneratorDirectionAbbreviation
  {
    protected override void handle_result(TypeDirectionAbbreviation result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDirectionAbbreviation(String what)
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
    public TypeDirectionAbbreviation value;
  };
    private class FieldHoldingArrayGeneratorDirectionAbbreviation : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDirectionAbbreviation
      {
        private FieldHoldingArrayGeneratorDirectionAbbreviation top;

        protected override void handle_result(TypeDirectionAbbreviation result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDirectionAbbreviation init_top)
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
    protected virtual void handle_result(List<TypeDirectionAbbreviation> result)
      {
      }

    public FieldHoldingArrayGeneratorDirectionAbbreviation(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDirectionAbbreviation>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDirectionAbbreviation()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDirectionAbbreviation>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDirectionAbbreviation> value;
  };
        private FieldHoldingGeneratorDirectionAbbreviation fieldGeneratorDirectionAbbreviation;
        private JSONHoldingStringGenerator fieldGeneratorDirectionText;
        private JSONHoldingStringGenerator fieldGeneratorDirectionTextWritten;
    private class FieldHoldingGeneratorDirectionDegrees : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorDirectionDegrees(String what) : base(what, 0, 360)
              {
              }
          };
    private class FieldHoldingArrayGeneratorDirectionDegrees : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorDirectionDegrees(String what) : base(what, 0, 360)
              {
              }
          };
        private FieldHoldingGeneratorDirectionDegrees fieldGeneratorDirectionDegrees;
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
            WindDataJSON result = new WindDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWindDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(WindDataJSON result)
          {
            if (fieldGeneratorValue.have_value)
              {
                result.setValue(fieldGeneratorValue.value);
                fieldGeneratorValue.have_value = false;
              }
            if (fieldGeneratorDirectionAbbreviation.have_value)
              {
                result.setDirectionAbbreviation(fieldGeneratorDirectionAbbreviation.value);
                fieldGeneratorDirectionAbbreviation.have_value = false;
              }
            if (fieldGeneratorDirectionText.have_value)
              {
                result.setDirectionText(fieldGeneratorDirectionText.value);
                fieldGeneratorDirectionText.have_value = false;
              }
            if (fieldGeneratorDirectionTextWritten.have_value)
              {
                result.setDirectionTextWritten(fieldGeneratorDirectionTextWritten.value);
                fieldGeneratorDirectionTextWritten.have_value = false;
              }
            if (fieldGeneratorDirectionDegrees.have_value)
              {
                result.setDirectionDegrees((short)(fieldGeneratorDirectionDegrees.value));
                fieldGeneratorDirectionDegrees.have_value = false;
              }
          }
        protected abstract void handle_result(WindDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "irection", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 10, "bbreviation", 0, 11, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorDirectionAbbreviation;
                                break;
                            case 'D':
                                if ((String.Compare(field_name, 10, "egrees", 0, 6, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorDirectionDegrees;
                                break;
                            case 'T':
                                if (String.Compare(field_name, 10, "ext", 0, 3, false) == 0)
                                  {
                                    if (field_name.Length == 13)
                                      {
                                        return fieldGeneratorDirectionText;
                                      }
                                    switch (field_name[13])
                                      {
                                        case 'W':
                                            if ((String.Compare(field_name, 14, "ritten", 0, 6, false) == 0) && (field_name.Length == 20))
                                                return fieldGeneratorDirectionTextWritten;
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
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorValue = new UnitsValue_WindJSON.HoldingGenerator("field \"Value\" of the WindData class", ignore_extras);
            fieldGeneratorDirectionAbbreviation = new FieldHoldingGeneratorDirectionAbbreviation("field \"DirectionAbbreviation\" of the WindData class");
            fieldGeneratorDirectionText = new JSONHoldingStringGenerator("field \"DirectionText\" of the WindData class");
            fieldGeneratorDirectionTextWritten = new JSONHoldingStringGenerator("field \"DirectionTextWritten\" of the WindData class");
            fieldGeneratorDirectionDegrees = new FieldHoldingGeneratorDirectionDegrees("field \"DirectionDegrees\" of the WindData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WindData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorValue = new UnitsValue_WindJSON.HoldingGenerator("field \"Value\" of the WindData class", false);
            fieldGeneratorDirectionAbbreviation = new FieldHoldingGeneratorDirectionAbbreviation("field \"DirectionAbbreviation\" of the WindData class");
            fieldGeneratorDirectionText = new JSONHoldingStringGenerator("field \"DirectionText\" of the WindData class");
            fieldGeneratorDirectionTextWritten = new JSONHoldingStringGenerator("field \"DirectionTextWritten\" of the WindData class");
            fieldGeneratorDirectionDegrees = new FieldHoldingGeneratorDirectionDegrees("field \"DirectionDegrees\" of the WindData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WindData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorValue.reset();
            fieldGeneratorDirectionAbbreviation.reset();
            fieldGeneratorDirectionText.reset();
            fieldGeneratorDirectionTextWritten.reset();
            fieldGeneratorDirectionDegrees.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(WindDataJSON  result)
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
        public WindDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WindDataJSON  result)
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
    protected virtual void handle_result(List<WindDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WindDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WindDataJSON>();
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
    public List<WindDataJSON> value;
  };
  };
