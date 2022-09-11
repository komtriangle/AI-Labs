/* file "BattleshipCoordinateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BattleshipCoordinateJSON : JSONBase
  {
    public enum TypeYCoordinate
      {
        YCoordinate_A,
        YCoordinate_B,
        YCoordinate_C,
        YCoordinate_D,
        YCoordinate_E,
        YCoordinate_F,
        YCoordinate_G,
        YCoordinate_H,
        YCoordinate_I,
        YCoordinate_J,
        YCoordinate_K,
        YCoordinate_L,
        YCoordinate_M,
        YCoordinate_O,
        YCoordinate_P,
        YCoordinate_Q,
        YCoordinate_R,
        YCoordinate_S,
        YCoordinate_T,
        YCoordinate_U,
        YCoordinate_V,
        YCoordinate_W,
        YCoordinate_X,
        YCoordinate_Y,
        YCoordinate_Z
      };

    public static TypeYCoordinate  stringToYCoordinate(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_A;
                break;
            case 'B':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_B;
                break;
            case 'C':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_C;
                break;
            case 'D':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_D;
                break;
            case 'E':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_E;
                break;
            case 'F':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_F;
                break;
            case 'G':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_G;
                break;
            case 'H':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_H;
                break;
            case 'I':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_I;
                break;
            case 'J':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_J;
                break;
            case 'K':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_K;
                break;
            case 'L':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_L;
                break;
            case 'M':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_M;
                break;
            case 'O':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_O;
                break;
            case 'P':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_P;
                break;
            case 'Q':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_Q;
                break;
            case 'R':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_R;
                break;
            case 'S':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_S;
                break;
            case 'T':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_T;
                break;
            case 'U':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_U;
                break;
            case 'V':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_V;
                break;
            case 'W':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_W;
                break;
            case 'X':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_X;
                break;
            case 'Y':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_Y;
                break;
            case 'Z':
                if (chars.Length == 1)
                    return TypeYCoordinate.YCoordinate_Z;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `YCoordinate' is not one of the legal values.");
      }

    public static string  stringFromYCoordinate(TypeYCoordinate the_enum)
      {
        switch (the_enum)
          {
            case TypeYCoordinate.YCoordinate_A:
                return "A";
            case TypeYCoordinate.YCoordinate_B:
                return "B";
            case TypeYCoordinate.YCoordinate_C:
                return "C";
            case TypeYCoordinate.YCoordinate_D:
                return "D";
            case TypeYCoordinate.YCoordinate_E:
                return "E";
            case TypeYCoordinate.YCoordinate_F:
                return "F";
            case TypeYCoordinate.YCoordinate_G:
                return "G";
            case TypeYCoordinate.YCoordinate_H:
                return "H";
            case TypeYCoordinate.YCoordinate_I:
                return "I";
            case TypeYCoordinate.YCoordinate_J:
                return "J";
            case TypeYCoordinate.YCoordinate_K:
                return "K";
            case TypeYCoordinate.YCoordinate_L:
                return "L";
            case TypeYCoordinate.YCoordinate_M:
                return "M";
            case TypeYCoordinate.YCoordinate_O:
                return "O";
            case TypeYCoordinate.YCoordinate_P:
                return "P";
            case TypeYCoordinate.YCoordinate_Q:
                return "Q";
            case TypeYCoordinate.YCoordinate_R:
                return "R";
            case TypeYCoordinate.YCoordinate_S:
                return "S";
            case TypeYCoordinate.YCoordinate_T:
                return "T";
            case TypeYCoordinate.YCoordinate_U:
                return "U";
            case TypeYCoordinate.YCoordinate_V:
                return "V";
            case TypeYCoordinate.YCoordinate_W:
                return "W";
            case TypeYCoordinate.YCoordinate_X:
                return "X";
            case TypeYCoordinate.YCoordinate_Y:
                return "Y";
            case TypeYCoordinate.YCoordinate_Z:
                return "Z";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeResult
      {
        Result_Hit,
        Result_Miss,
        Result_InvalidCoordinate,
        Result_NotUnderstood,
        Result_None
      };

    public static TypeResult  stringToResult(string chars)
      {
        switch (chars[0])
          {
            case 'H':
                if ((String.Compare(chars, 1, "it", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeResult.Result_Hit;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nvalidCoordinate", 0, 16, false) == 0) && (chars.Length == 17))
                    return TypeResult.Result_InvalidCoordinate;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "iss", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeResult.Result_Miss;
                break;
            case 'N':
                if (String.Compare(chars, 1, "o", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'n':
                            if ((String.Compare(chars, 3, "e", 0, 1, false) == 0) && (chars.Length == 4))
                                return TypeResult.Result_None;
                            break;
                        case 't':
                            if ((String.Compare(chars, 3, "Understood", 0, 10, false) == 0) && (chars.Length == 13))
                                return TypeResult.Result_NotUnderstood;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Result' is not one of the legal values.");
      }

    public static string  stringFromResult(TypeResult the_enum)
      {
        switch (the_enum)
          {
            case TypeResult.Result_Hit:
                return "Hit";
            case TypeResult.Result_Miss:
                return "Miss";
            case TypeResult.Result_InvalidCoordinate:
                return "InvalidCoordinate";
            case TypeResult.Result_NotUnderstood:
                return "NotUnderstood";
            case TypeResult.Result_None:
                return "None";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasYCoordinate;
    private TypeYCoordinate storeYCoordinate;
    private bool flagHasXCoordinate;
    private sbyte storeXCoordinate;
    private bool flagHasResult;
    private TypeResult storeResult;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONYCoordinate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field YCoordinate of BattleshipCoordinateJSON is not a string.");
        TypeYCoordinate the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_A;
                        goto enum_is_done;
                      }
                break;
            case 'B':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_B;
                        goto enum_is_done;
                      }
                break;
            case 'C':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_C;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_D;
                        goto enum_is_done;
                      }
                break;
            case 'E':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_E;
                        goto enum_is_done;
                      }
                break;
            case 'F':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_F;
                        goto enum_is_done;
                      }
                break;
            case 'G':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_G;
                        goto enum_is_done;
                      }
                break;
            case 'H':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_H;
                        goto enum_is_done;
                      }
                break;
            case 'I':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_I;
                        goto enum_is_done;
                      }
                break;
            case 'J':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_J;
                        goto enum_is_done;
                      }
                break;
            case 'K':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_K;
                        goto enum_is_done;
                      }
                break;
            case 'L':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_L;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_M;
                        goto enum_is_done;
                      }
                break;
            case 'O':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_O;
                        goto enum_is_done;
                      }
                break;
            case 'P':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_P;
                        goto enum_is_done;
                      }
                break;
            case 'Q':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_Q;
                        goto enum_is_done;
                      }
                break;
            case 'R':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_R;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_S;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_T;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_U;
                        goto enum_is_done;
                      }
                break;
            case 'V':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_V;
                        goto enum_is_done;
                      }
                break;
            case 'W':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_W;
                        goto enum_is_done;
                      }
                break;
            case 'X':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_X;
                        goto enum_is_done;
                      }
                break;
            case 'Y':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_Y;
                        goto enum_is_done;
                      }
                break;
            case 'Z':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeYCoordinate.YCoordinate_Z;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field YCoordinate of BattleshipCoordinateJSON is not one of the legal strings.");
      enum_is_done:;
        setYCoordinate(the_enum);
      }


    private void  fromJSONXCoordinate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field XCoordinate of BattleshipCoordinateJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field XCoordinate of BattleshipCoordinateJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setXCoordinate(extracted_integer);
      }


    private void  fromJSONResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Result of BattleshipCoordinateJSON is not a string.");
        TypeResult the_enum;
        switch (json_string.getData()[0])
          {
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "it", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_enum = TypeResult.Result_Hit;
                        goto enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nvalidCoordinate", 0, 16, false) == 0) && (json_string.getData().Length == 17))
                      {
                        the_enum = TypeResult.Result_InvalidCoordinate;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "iss", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeResult.Result_Miss;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if (String.Compare(json_string.getData(), 1, "o", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'n':
                            if ((String.Compare(json_string.getData(), 3, "e", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                  {
                                    the_enum = TypeResult.Result_None;
                                    goto enum_is_done;
                                  }
                            break;
                        case 't':
                            if ((String.Compare(json_string.getData(), 3, "Understood", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_enum = TypeResult.Result_NotUnderstood;
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
        throw new Exception("The value for field Result of BattleshipCoordinateJSON is not one of the legal strings.");
      enum_is_done:;
        setResult(the_enum);
      }


    public BattleshipCoordinateJSON()
      {
        flagHasYCoordinate = false;
        flagHasXCoordinate = false;
        flagHasResult = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasYCoordinate()
      {
        return flagHasYCoordinate;
      }

    public TypeYCoordinate  getYCoordinate()
      {
        Debug.Assert(flagHasYCoordinate);
        return storeYCoordinate;
      }

    public string  getYCoordinateAsString()
      {
        return stringFromYCoordinate(getYCoordinate());
      }

    public bool  hasXCoordinate()
      {
        return flagHasXCoordinate;
      }

    public sbyte  getXCoordinate()
      {
        Debug.Assert(flagHasXCoordinate);
        return storeXCoordinate;
      }

    public bool  hasResult()
      {
        return flagHasResult;
      }

    public TypeResult  getResult()
      {
        Debug.Assert(flagHasResult);
        return storeResult;
      }

    public string  getResultAsString()
      {
        return stringFromResult(getResult());
      }


    public virtual int extraBattleshipCoordinateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBattleshipCoordinateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBattleshipCoordinateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBattleshipCoordinateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setYCoordinate(TypeYCoordinate new_value)
      {
        flagHasYCoordinate = true;
        storeYCoordinate = new_value;
      }
    public void setYCoordinate(string chars)
      {
        setYCoordinate(stringToYCoordinate(chars));
      }
    public void unsetYCoordinate()
      {
        flagHasYCoordinate = false;
      }
    public void setXCoordinate(sbyte new_value)
      {
        flagHasXCoordinate = true;
        if (new_value < 1)
            throw new Exception("The value for field XCoordinate of BattleshipCoordinateJSON is less than the lower bound (1) for that field.");
        if (new_value > 10)
            throw new Exception("The value for field XCoordinate of BattleshipCoordinateJSON is greater than the upper bound (10) for that field.");
        storeXCoordinate = new_value;
      }
    public void unsetXCoordinate()
      {
        flagHasXCoordinate = false;
      }
    public void setResult(TypeResult new_value)
      {
        flagHasResult = true;
        storeResult = new_value;
      }
    public void setResult(string chars)
      {
        setResult(stringToResult(chars));
      }
    public void unsetResult()
      {
        flagHasResult = false;
      }

    public virtual void extraBattleshipCoordinateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBattleshipCoordinateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBattleshipCoordinateLookup(key);
        if (old_field == null)
          {
            extraBattleshipCoordinateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasYCoordinate);
        if (flagHasYCoordinate)
          {
            handler.start_pair("YCoordinate");
            switch (storeYCoordinate)
              {
                case TypeYCoordinate.YCoordinate_A:
                    handler.string_value("A");
                    break;
                case TypeYCoordinate.YCoordinate_B:
                    handler.string_value("B");
                    break;
                case TypeYCoordinate.YCoordinate_C:
                    handler.string_value("C");
                    break;
                case TypeYCoordinate.YCoordinate_D:
                    handler.string_value("D");
                    break;
                case TypeYCoordinate.YCoordinate_E:
                    handler.string_value("E");
                    break;
                case TypeYCoordinate.YCoordinate_F:
                    handler.string_value("F");
                    break;
                case TypeYCoordinate.YCoordinate_G:
                    handler.string_value("G");
                    break;
                case TypeYCoordinate.YCoordinate_H:
                    handler.string_value("H");
                    break;
                case TypeYCoordinate.YCoordinate_I:
                    handler.string_value("I");
                    break;
                case TypeYCoordinate.YCoordinate_J:
                    handler.string_value("J");
                    break;
                case TypeYCoordinate.YCoordinate_K:
                    handler.string_value("K");
                    break;
                case TypeYCoordinate.YCoordinate_L:
                    handler.string_value("L");
                    break;
                case TypeYCoordinate.YCoordinate_M:
                    handler.string_value("M");
                    break;
                case TypeYCoordinate.YCoordinate_O:
                    handler.string_value("O");
                    break;
                case TypeYCoordinate.YCoordinate_P:
                    handler.string_value("P");
                    break;
                case TypeYCoordinate.YCoordinate_Q:
                    handler.string_value("Q");
                    break;
                case TypeYCoordinate.YCoordinate_R:
                    handler.string_value("R");
                    break;
                case TypeYCoordinate.YCoordinate_S:
                    handler.string_value("S");
                    break;
                case TypeYCoordinate.YCoordinate_T:
                    handler.string_value("T");
                    break;
                case TypeYCoordinate.YCoordinate_U:
                    handler.string_value("U");
                    break;
                case TypeYCoordinate.YCoordinate_V:
                    handler.string_value("V");
                    break;
                case TypeYCoordinate.YCoordinate_W:
                    handler.string_value("W");
                    break;
                case TypeYCoordinate.YCoordinate_X:
                    handler.string_value("X");
                    break;
                case TypeYCoordinate.YCoordinate_Y:
                    handler.string_value("Y");
                    break;
                case TypeYCoordinate.YCoordinate_Z:
                    handler.string_value("Z");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasXCoordinate);
        if (flagHasXCoordinate)
          {
            handler.start_pair("XCoordinate");
            handler.number_value(storeXCoordinate);
          }
        if (flagHasResult)
          {
            handler.start_pair("Result");
            switch (storeResult)
              {
                case TypeResult.Result_Hit:
                    handler.string_value("Hit");
                    break;
                case TypeResult.Result_Miss:
                    handler.string_value("Miss");
                    break;
                case TypeResult.Result_InvalidCoordinate:
                    handler.string_value("InvalidCoordinate");
                    break;
                case TypeResult.Result_NotUnderstood:
                    handler.string_value("NotUnderstood");
                    break;
                case TypeResult.Result_None:
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasYCoordinate()))
          {
            return "When parsing the object for %what%, the \"YCoordinate\" field was missing.";
          }
        if (!(hasXCoordinate()))
          {
            return "When parsing the object for %what%, the \"XCoordinate\" field was missing.";
          }
        return null;
      }

    public static BattleshipCoordinateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BattleshipCoordinateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipCoordinate", ignore_extras);
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
    public static BattleshipCoordinateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BattleshipCoordinateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BattleshipCoordinateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipCoordinate", ignore_extras);
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
    public static BattleshipCoordinateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BattleshipCoordinateJSON from_text(string text, bool ignore_extras)
      {
        BattleshipCoordinateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipCoordinate", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BattleshipCoordinateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BattleshipCoordinateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BattleshipCoordinateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipCoordinate", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorYCoordinate : JSONStringGenerator
          {
            protected FieldGeneratorYCoordinate(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorYCoordinate()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToYCoordinate(result));
              }
            protected abstract void handle_result(TypeYCoordinate result);
          };
    private class FieldHoldingGeneratorYCoordinate : FieldGeneratorYCoordinate
  {
    protected override void handle_result(TypeYCoordinate result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorYCoordinate(String what)
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
    public TypeYCoordinate value;
  };
    private class FieldHoldingArrayGeneratorYCoordinate : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorYCoordinate
      {
        private FieldHoldingArrayGeneratorYCoordinate top;

        protected override void handle_result(TypeYCoordinate result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorYCoordinate init_top)
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
    protected virtual void handle_result(List<TypeYCoordinate> result)
      {
      }

    public FieldHoldingArrayGeneratorYCoordinate(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeYCoordinate>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorYCoordinate()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeYCoordinate>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeYCoordinate> value;
  };
        private FieldHoldingGeneratorYCoordinate fieldGeneratorYCoordinate;
    private class FieldHoldingGeneratorXCoordinate : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorXCoordinate(String what) : base(what, 1, 10)
              {
              }
          };
    private class FieldHoldingArrayGeneratorXCoordinate : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorXCoordinate(String what) : base(what, 1, 10)
              {
              }
          };
        private FieldHoldingGeneratorXCoordinate fieldGeneratorXCoordinate;
    private abstract class FieldGeneratorResult : JSONStringGenerator
          {
            protected FieldGeneratorResult(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorResult()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToResult(result));
              }
            protected abstract void handle_result(TypeResult result);
          };
    private class FieldHoldingGeneratorResult : FieldGeneratorResult
  {
    protected override void handle_result(TypeResult result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorResult(String what)
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
    public TypeResult value;
  };
    private class FieldHoldingArrayGeneratorResult : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorResult
      {
        private FieldHoldingArrayGeneratorResult top;

        protected override void handle_result(TypeResult result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorResult init_top)
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
    protected virtual void handle_result(List<TypeResult> result)
      {
      }

    public FieldHoldingArrayGeneratorResult(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeResult>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorResult()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeResult>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeResult> value;
  };
        private FieldHoldingGeneratorResult fieldGeneratorResult;
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
            BattleshipCoordinateJSON result = new BattleshipCoordinateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBattleshipCoordinateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(BattleshipCoordinateJSON result)
          {
            if (fieldGeneratorYCoordinate.have_value)
              {
                result.setYCoordinate(fieldGeneratorYCoordinate.value);
                fieldGeneratorYCoordinate.have_value = false;
              }
            else if ((!(result.hasYCoordinate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"YCoordinate\" field was missing.");
              }
            if (fieldGeneratorXCoordinate.have_value)
              {
                result.setXCoordinate((sbyte)(fieldGeneratorXCoordinate.value));
                fieldGeneratorXCoordinate.have_value = false;
              }
            else if ((!(result.hasXCoordinate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"XCoordinate\" field was missing.");
              }
            if (fieldGeneratorResult.have_value)
              {
                result.setResult(fieldGeneratorResult.value);
                fieldGeneratorResult.have_value = false;
              }
          }
        protected abstract void handle_result(BattleshipCoordinateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'R':
                    if ((String.Compare(field_name, 1, "esult", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorResult;
                    break;
                case 'X':
                    if ((String.Compare(field_name, 1, "Coordinate", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorXCoordinate;
                    break;
                case 'Y':
                    if ((String.Compare(field_name, 1, "Coordinate", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorYCoordinate;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorYCoordinate = new FieldHoldingGeneratorYCoordinate("field \"YCoordinate\" of the BattleshipCoordinate class");
            fieldGeneratorXCoordinate = new FieldHoldingGeneratorXCoordinate("field \"XCoordinate\" of the BattleshipCoordinate class");
            fieldGeneratorResult = new FieldHoldingGeneratorResult("field \"Result\" of the BattleshipCoordinate class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BattleshipCoordinate class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorYCoordinate = new FieldHoldingGeneratorYCoordinate("field \"YCoordinate\" of the BattleshipCoordinate class");
            fieldGeneratorXCoordinate = new FieldHoldingGeneratorXCoordinate("field \"XCoordinate\" of the BattleshipCoordinate class");
            fieldGeneratorResult = new FieldHoldingGeneratorResult("field \"Result\" of the BattleshipCoordinate class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BattleshipCoordinate class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorYCoordinate.reset();
            fieldGeneratorXCoordinate.reset();
            fieldGeneratorResult.reset();
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
        protected override void handle_result(BattleshipCoordinateJSON  result)
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
        public BattleshipCoordinateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BattleshipCoordinateJSON  result)
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
    protected virtual void handle_result(List<BattleshipCoordinateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BattleshipCoordinateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BattleshipCoordinateJSON>();
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
    public List<BattleshipCoordinateJSON> value;
  };
  };
