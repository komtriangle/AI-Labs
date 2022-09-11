/* file "AgeCalculatorStartCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AgeCalculatorStartCommandJSON : CommandResultJSON
  {
    public enum TypeMode
      {
        Mode_AgeCalculatorStart
      };

    public static TypeMode  stringToMode(string chars)
      {
        if ((String.Compare(chars, 0, "AgeCalculatorStart", 0, 18, false) == 0) && (chars.Length == 18))
            return TypeMode.Mode_AgeCalculatorStart;
        throw new Exception("The value for field `Mode' is not one of the legal values.");
      }

    public static string  stringFromMode(TypeMode the_enum)
      {
        switch (the_enum)
          {
            case TypeMode.Mode_AgeCalculatorStart:
                return "AgeCalculatorStart";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasMode;
    private bool flagHasUnderstood;
    private bool storeUnderstood;
    private bool flagHasInvalidBornDateWasGiven;
    private bool storeInvalidBornDateWasGiven;
    private bool flagHasDestinationDate;
    private DateAndOrTimeJSON  storeDestinationDate;
    private bool flagHasDestinationIsNow;
    private bool storeDestinationIsNow;
    private bool flagHasDestinationIsToday;
    private bool storeDestinationIsToday;
    private bool flagHasNowDate;
    private DateAndOrTimeJSON  storeNowDate;
    private bool flagHasPerspective;
    private AgeCalculatorPerspectiveJSON  storePerspective;


    private JSONValue  extraModeToJSON()
      {
        JSONStringValue generated_string_Mode;
        generated_string_Mode = new JSONStringValue("AgeCalculatorStart");
        return generated_string_Mode;
      }

    private JSONValue  extraUnderstoodToJSON()
      {
        JSONValue generated_boolean_Understood = (storeUnderstood ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_Understood;
      }

    private JSONValue  extraInvalidBornDateWasGivenToJSON()
      {
        JSONValue generated_boolean_InvalidBornDateWasGiven = (storeInvalidBornDateWasGiven ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_InvalidBornDateWasGiven;
      }

    private JSONValue  extraDestinationDateToJSON()
      {
        JSONValueHandler handler_DestinationDate = new JSONValueHandler();
        storeDestinationDate.write_as_json(handler_DestinationDate);
        return handler_DestinationDate.result;
      }

    private JSONValue  extraDestinationIsNowToJSON()
      {
        JSONValue generated_boolean_DestinationIsNow = (storeDestinationIsNow ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_DestinationIsNow;
      }

    private JSONValue  extraDestinationIsTodayToJSON()
      {
        JSONValue generated_boolean_DestinationIsToday = (storeDestinationIsToday ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_DestinationIsToday;
      }

    private JSONValue  extraNowDateToJSON()
      {
        JSONValueHandler handler_NowDate = new JSONValueHandler();
        storeNowDate.write_as_json(handler_NowDate);
        return handler_NowDate.result;
      }

    private JSONValue  extraPerspectiveToJSON()
      {
        JSONValueHandler handler_Perspective = new JSONValueHandler();
        storePerspective.write_as_json(handler_Perspective);
        return handler_Perspective.result;
      }


    private void  fromJSONMode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Mode of AgeCalculatorStartCommandJSON is not a string.");
        if (!(json_string.getData().Equals("AgeCalculatorStart")))
            throw new Exception("The value for field Mode of AgeCalculatorStartCommandJSON is not `AgeCalculatorStart'.");
        setMode();
      }


    private void  fromJSONUnderstood(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Understood of AgeCalculatorStartCommandJSON is not true for false.");
              }
          }
        setUnderstood(the_bool);
      }


    private void  fromJSONInvalidBornDateWasGiven(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field InvalidBornDateWasGiven of AgeCalculatorStartCommandJSON is not true for false.");
              }
          }
        setInvalidBornDateWasGiven(the_bool);
      }


    private void  fromJSONDestinationDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setDestinationDate(convert_classy);
      }


    private void  fromJSONDestinationIsNow(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DestinationIsNow of AgeCalculatorStartCommandJSON is not true for false.");
              }
          }
        setDestinationIsNow(the_bool);
      }


    private void  fromJSONDestinationIsToday(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DestinationIsToday of AgeCalculatorStartCommandJSON is not true for false.");
              }
          }
        setDestinationIsToday(the_bool);
      }


    private void  fromJSONNowDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setNowDate(convert_classy);
      }


    private void  fromJSONPerspective(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AgeCalculatorPerspectiveJSON convert_classy = AgeCalculatorPerspectiveJSON.from_json(json_value, ignore_extras, true);
        setPerspective(convert_classy);
      }


    public AgeCalculatorStartCommandJSON()
      {
        flagHasMode = false;
        flagHasUnderstood = false;
        flagHasInvalidBornDateWasGiven = false;
        flagHasDestinationDate = false;
        flagHasDestinationIsNow = false;
        flagHasDestinationIsToday = false;
        flagHasNowDate = false;
        flagHasPerspective = false;
      }

    public override string  getCommandKind()
      {
        return "AgeCalculatorStartCommand";
      }

    public bool  hasMode()
      {
        return flagHasMode;
      }

    public TypeMode  getMode()
      {
        Debug.Assert(flagHasMode);
        return TypeMode.Mode_AgeCalculatorStart;
      }

    public string  getModeAsString()
      {
        return stringFromMode(getMode());
      }

    public bool  hasUnderstood()
      {
        return flagHasUnderstood;
      }

    public bool  getUnderstood()
      {
        Debug.Assert(flagHasUnderstood);
        return storeUnderstood;
      }

    public bool  hasInvalidBornDateWasGiven()
      {
        return flagHasInvalidBornDateWasGiven;
      }

    public bool  getInvalidBornDateWasGiven()
      {
        Debug.Assert(flagHasInvalidBornDateWasGiven);
        return storeInvalidBornDateWasGiven;
      }

    public bool  hasDestinationDate()
      {
        return flagHasDestinationDate;
      }

    public DateAndOrTimeJSON   getDestinationDate()
      {
        Debug.Assert(flagHasDestinationDate);
        return storeDestinationDate;
      }

    public bool  hasDestinationIsNow()
      {
        return flagHasDestinationIsNow;
      }

    public bool  getDestinationIsNow()
      {
        Debug.Assert(flagHasDestinationIsNow);
        return storeDestinationIsNow;
      }

    public bool  hasDestinationIsToday()
      {
        return flagHasDestinationIsToday;
      }

    public bool  getDestinationIsToday()
      {
        Debug.Assert(flagHasDestinationIsToday);
        return storeDestinationIsToday;
      }

    public bool  hasNowDate()
      {
        return flagHasNowDate;
      }

    public DateAndOrTimeJSON   getNowDate()
      {
        Debug.Assert(flagHasNowDate);
        return storeNowDate;
      }

    public bool  hasPerspective()
      {
        return flagHasPerspective;
      }

    public AgeCalculatorPerspectiveJSON   getPerspective()
      {
        Debug.Assert(flagHasPerspective);
        return storePerspective;
      }

    public AgeCalculatorPerspectiveJSON.TypeValue  getPerspectiveValue()
      {
        return getPerspective().getValue();
      }

    public string  getPerspectiveAsString()
      {
        return getPerspective().getValueAsString();
      }


    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasMode)
            ++result;
        if (flagHasUnderstood)
            ++result;
        if (flagHasInvalidBornDateWasGiven)
            ++result;
        if (flagHasDestinationDate)
            ++result;
        if (flagHasDestinationIsNow)
            ++result;
        if (flagHasDestinationIsToday)
            ++result;
        if (flagHasNowDate)
            ++result;
        if (flagHasPerspective)
            ++result;
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasMode)
          {
            if (remainder == 0)
                return "Mode";
            --remainder;
          }
        if (flagHasUnderstood)
          {
            if (remainder == 0)
                return "Understood";
            --remainder;
          }
        if (flagHasInvalidBornDateWasGiven)
          {
            if (remainder == 0)
                return "InvalidBornDateWasGiven";
            --remainder;
          }
        if (flagHasDestinationDate)
          {
            if (remainder == 0)
                return "DestinationDate";
            --remainder;
          }
        if (flagHasDestinationIsNow)
          {
            if (remainder == 0)
                return "DestinationIsNow";
            --remainder;
          }
        if (flagHasDestinationIsToday)
          {
            if (remainder == 0)
                return "DestinationIsToday";
            --remainder;
          }
        if (flagHasNowDate)
          {
            if (remainder == 0)
                return "NowDate";
            --remainder;
          }
        if (flagHasPerspective)
          {
            if (remainder == 0)
                return "Perspective";
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasMode)
          {
            if (remainder == 0)
                return extraModeToJSON();
            --remainder;
          }
        if (flagHasUnderstood)
          {
            if (remainder == 0)
                return extraUnderstoodToJSON();
            --remainder;
          }
        if (flagHasInvalidBornDateWasGiven)
          {
            if (remainder == 0)
                return extraInvalidBornDateWasGivenToJSON();
            --remainder;
          }
        if (flagHasDestinationDate)
          {
            if (remainder == 0)
                return extraDestinationDateToJSON();
            --remainder;
          }
        if (flagHasDestinationIsNow)
          {
            if (remainder == 0)
                return extraDestinationIsNowToJSON();
            --remainder;
          }
        if (flagHasDestinationIsToday)
          {
            if (remainder == 0)
                return extraDestinationIsTodayToJSON();
            --remainder;
          }
        if (flagHasNowDate)
          {
            if (remainder == 0)
                return extraNowDateToJSON();
            --remainder;
          }
        if (flagHasPerspective)
          {
            if (remainder == 0)
                return extraPerspectiveToJSON();
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if (String.Compare(field_name, 1, "estination", 0, 10, false) == 0)
                  {
                    switch (field_name[11])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 12, "ate", 0, 3, false) == 0) && (field_name.Length == 15))
                                return (flagHasDestinationDate ? extraDestinationDateToJSON() : null);
                            break;
                        case 'I':
                            if (String.Compare(field_name, 12, "s", 0, 1, false) == 0)
                              {
                                switch (field_name[13])
                                  {
                                    case 'N':
                                        if ((String.Compare(field_name, 14, "ow", 0, 2, false) == 0) && (field_name.Length == 16))
                                            return (flagHasDestinationIsNow ? extraDestinationIsNowToJSON() : null);
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 14, "oday", 0, 4, false) == 0) && (field_name.Length == 18))
                                            return (flagHasDestinationIsToday ? extraDestinationIsTodayToJSON() : null);
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
            case 'I':
                if ((String.Compare(field_name, 1, "nvalidBornDateWasGiven", 0, 22, false) == 0) && (field_name.Length == 23))
                    return (flagHasInvalidBornDateWasGiven ? extraInvalidBornDateWasGivenToJSON() : null);
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "ode", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasMode ? extraModeToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "owDate", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasNowDate ? extraNowDateToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "erspective", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasPerspective ? extraPerspectiveToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "nderstood", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasUnderstood ? extraUnderstoodToJSON() : null);
                break;
            default:
                break;
          }
        return null;
      }

    public void setMode()
      {
        flagHasMode = true;
      }
    public void setMode(TypeMode new_value)
      {
        setMode();
      }
    public void setMode(string chars)
      {
        setMode(stringToMode(chars));
      }
    public void unsetMode()
      {
        flagHasMode = false;
      }
    public void setUnderstood(bool new_value)
      {
        flagHasUnderstood = true;
        storeUnderstood = new_value;
      }
    public void unsetUnderstood()
      {
        flagHasUnderstood = false;
      }
    public void setInvalidBornDateWasGiven(bool new_value)
      {
        flagHasInvalidBornDateWasGiven = true;
        storeInvalidBornDateWasGiven = new_value;
      }
    public void unsetInvalidBornDateWasGiven()
      {
        flagHasInvalidBornDateWasGiven = false;
      }
    public void setDestinationDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasDestinationDate)
          {
          }
        flagHasDestinationDate = true;
        storeDestinationDate = new_value;
      }
    public void unsetDestinationDate()
      {
        if (flagHasDestinationDate)
          {
          }
        flagHasDestinationDate = false;
      }
    public void setDestinationIsNow(bool new_value)
      {
        flagHasDestinationIsNow = true;
        storeDestinationIsNow = new_value;
      }
    public void unsetDestinationIsNow()
      {
        flagHasDestinationIsNow = false;
      }
    public void setDestinationIsToday(bool new_value)
      {
        flagHasDestinationIsToday = true;
        storeDestinationIsToday = new_value;
      }
    public void unsetDestinationIsToday()
      {
        flagHasDestinationIsToday = false;
      }
    public void setNowDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasNowDate)
          {
          }
        flagHasNowDate = true;
        storeNowDate = new_value;
      }
    public void unsetNowDate()
      {
        if (flagHasNowDate)
          {
          }
        flagHasNowDate = false;
      }
    public void setPerspective(AgeCalculatorPerspectiveJSON  new_value)
      {
        if (flagHasPerspective)
          {
          }
        flagHasPerspective = true;
        storePerspective = new_value;
      }
    public void setPerspective(AgeCalculatorPerspectiveJSON.TypeValue new_value)
      {
        setPerspective(new AgeCalculatorPerspectiveJSON(new_value));
      }
    public void setPerspective(string chars)
      {
        setPerspective(new AgeCalculatorPerspectiveJSON(chars));
      }
    public void unsetPerspective()
      {
        if (flagHasPerspective)
          {
          }
        flagHasPerspective = false;
      }

    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if (String.Compare(key, 1, "estination", 0, 10, false) == 0)
                  {
                    switch (key[11])
                      {
                        case 'D':
                            if ((String.Compare(key, 12, "ate", 0, 3, false) == 0) && (key.Length == 15))
                                {
                                fromJSONDestinationDate(new_component, false);
                                return;
                                }
                            break;
                        case 'I':
                            if (String.Compare(key, 12, "s", 0, 1, false) == 0)
                              {
                                switch (key[13])
                                  {
                                    case 'N':
                                        if ((String.Compare(key, 14, "ow", 0, 2, false) == 0) && (key.Length == 16))
                                            {
                                            fromJSONDestinationIsNow(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'T':
                                        if ((String.Compare(key, 14, "oday", 0, 4, false) == 0) && (key.Length == 18))
                                            {
                                            fromJSONDestinationIsToday(new_component, false);
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
                break;
            case 'I':
                if ((String.Compare(key, 1, "nvalidBornDateWasGiven", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONInvalidBornDateWasGiven(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "ode", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONMode(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "owDate", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONNowDate(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "erspective", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONPerspective(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "nderstood", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONUnderstood(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if (String.Compare(key, 1, "estination", 0, 10, false) == 0)
                  {
                    switch (key[11])
                      {
                        case 'D':
                            if ((String.Compare(key, 12, "ate", 0, 3, false) == 0) && (key.Length == 15))
                                {
                                fromJSONDestinationDate(new_component, false);
                                return;
                                }
                            break;
                        case 'I':
                            if (String.Compare(key, 12, "s", 0, 1, false) == 0)
                              {
                                switch (key[13])
                                  {
                                    case 'N':
                                        if ((String.Compare(key, 14, "ow", 0, 2, false) == 0) && (key.Length == 16))
                                            {
                                            fromJSONDestinationIsNow(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'T':
                                        if ((String.Compare(key, 14, "oday", 0, 4, false) == 0) && (key.Length == 18))
                                            {
                                            fromJSONDestinationIsToday(new_component, false);
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
                break;
            case 'I':
                if ((String.Compare(key, 1, "nvalidBornDateWasGiven", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONInvalidBornDateWasGiven(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "ode", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONMode(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "owDate", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONNowDate(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "erspective", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONPerspective(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "nderstood", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONUnderstood(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        if (flagHasMode)
          {
            handler.start_pair("Mode");
            handler.string_value("AgeCalculatorStart");
          }
        if (flagHasUnderstood)
          {
            handler.start_pair("Understood");
            handler.boolean_value(storeUnderstood);
          }
        if (flagHasInvalidBornDateWasGiven)
          {
            handler.start_pair("InvalidBornDateWasGiven");
            handler.boolean_value(storeInvalidBornDateWasGiven);
          }
        Debug.Assert(partial_allowed || flagHasDestinationDate);
        if (flagHasDestinationDate)
          {
            handler.start_pair("DestinationDate");
            if (partial_allowed)
                storeDestinationDate.write_partial_as_json(handler);
            else
                storeDestinationDate.write_as_json(handler);
          }
        if (flagHasDestinationIsNow)
          {
            handler.start_pair("DestinationIsNow");
            handler.boolean_value(storeDestinationIsNow);
          }
        if (flagHasDestinationIsToday)
          {
            handler.start_pair("DestinationIsToday");
            handler.boolean_value(storeDestinationIsToday);
          }
        if (flagHasNowDate)
          {
            handler.start_pair("NowDate");
            if (partial_allowed)
                storeNowDate.write_partial_as_json(handler);
            else
                storeNowDate.write_as_json(handler);
          }
        if (flagHasPerspective)
          {
            handler.start_pair("Perspective");
            if (partial_allowed)
                storePerspective.write_partial_as_json(handler);
            else
                storePerspective.write_as_json(handler);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasDestinationDate()))
          {
            return "When parsing the object for %what%, the \"DestinationDate\" field was missing.";
          }
        return null;
      }

    public static new AgeCalculatorStartCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AgeCalculatorStartCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AgeCalculatorStartCommand", ignore_extras);
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
    public static new AgeCalculatorStartCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AgeCalculatorStartCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AgeCalculatorStartCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AgeCalculatorStartCommand", ignore_extras);
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
    public static new AgeCalculatorStartCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AgeCalculatorStartCommandJSON from_text(string text, bool ignore_extras)
      {
        AgeCalculatorStartCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AgeCalculatorStartCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AgeCalculatorStartCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new AgeCalculatorStartCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AgeCalculatorStartCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AgeCalculatorStartCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
    private abstract class FieldGeneratorMode : JSONStringGenerator
          {
            protected FieldGeneratorMode(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorMode()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToMode(result));
              }
            protected abstract void handle_result(TypeMode result);
          };
    private class FieldHoldingGeneratorMode : FieldGeneratorMode
  {
    protected override void handle_result(TypeMode result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorMode(String what)
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
    public TypeMode value;
  };
    private class FieldHoldingArrayGeneratorMode : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorMode
      {
        private FieldHoldingArrayGeneratorMode top;

        protected override void handle_result(TypeMode result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorMode init_top)
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
    protected virtual void handle_result(List<TypeMode> result)
      {
      }

    public FieldHoldingArrayGeneratorMode(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMode>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorMode()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMode>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeMode> value;
  };
        private FieldHoldingGeneratorMode fieldGeneratorMode;
        private JSONHoldingBooleanGenerator fieldGeneratorUnderstood;
        private JSONHoldingBooleanGenerator fieldGeneratorInvalidBornDateWasGiven;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorDestinationDate;
        private JSONHoldingBooleanGenerator fieldGeneratorDestinationIsNow;
        private JSONHoldingBooleanGenerator fieldGeneratorDestinationIsToday;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorNowDate;
        private AgeCalculatorPerspectiveJSON.HoldingGenerator fieldGeneratorPerspective;

        protected override void start()
          {
          }
        protected override JSONHandler start_field(string field_name)
          {
            JSONHandler result = start_known_field(field_name);
            if (result != null)
                return result;
            string message = "";
            message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
            throw new Exception(message);
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            if (!(getCommandResultJSONKey().Equals("AgeCalculatorStartCommand")))
                throw new Exception("The key field has a value other than `AgeCalculatorStartCommand'.");
            AgeCalculatorStartCommandJSON result = new AgeCalculatorStartCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((AgeCalculatorStartCommandJSON )new_result);
          }
        protected void finish(AgeCalculatorStartCommandJSON result)
          {
            if (fieldGeneratorMode.have_value)
              {
                result.setMode();
                fieldGeneratorMode.have_value = false;
              }
            if (fieldGeneratorUnderstood.have_value)
              {
                result.setUnderstood(fieldGeneratorUnderstood.value);
                fieldGeneratorUnderstood.have_value = false;
              }
            if (fieldGeneratorInvalidBornDateWasGiven.have_value)
              {
                result.setInvalidBornDateWasGiven(fieldGeneratorInvalidBornDateWasGiven.value);
                fieldGeneratorInvalidBornDateWasGiven.have_value = false;
              }
            if (fieldGeneratorDestinationDate.have_value)
              {
                result.setDestinationDate(fieldGeneratorDestinationDate.value);
                fieldGeneratorDestinationDate.have_value = false;
              }
            else if ((!(result.hasDestinationDate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DestinationDate\" field was missing.");
              }
            if (fieldGeneratorDestinationIsNow.have_value)
              {
                result.setDestinationIsNow(fieldGeneratorDestinationIsNow.value);
                fieldGeneratorDestinationIsNow.have_value = false;
              }
            if (fieldGeneratorDestinationIsToday.have_value)
              {
                result.setDestinationIsToday(fieldGeneratorDestinationIsToday.value);
                fieldGeneratorDestinationIsToday.have_value = false;
              }
            if (fieldGeneratorNowDate.have_value)
              {
                result.setNowDate(fieldGeneratorNowDate.value);
                fieldGeneratorNowDate.have_value = false;
              }
            if (fieldGeneratorPerspective.have_value)
              {
                result.setPerspective(fieldGeneratorPerspective.value);
                fieldGeneratorPerspective.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(AgeCalculatorStartCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "estination", 0, 10, false) == 0)
                      {
                        switch (field_name[11])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 12, "ate", 0, 3, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorDestinationDate;
                                break;
                            case 'I':
                                if (String.Compare(field_name, 12, "s", 0, 1, false) == 0)
                                  {
                                    switch (field_name[13])
                                      {
                                        case 'N':
                                            if ((String.Compare(field_name, 14, "ow", 0, 2, false) == 0) && (field_name.Length == 16))
                                                return fieldGeneratorDestinationIsNow;
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 14, "oday", 0, 4, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorDestinationIsToday;
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
                case 'I':
                    if ((String.Compare(field_name, 1, "nvalidBornDateWasGiven", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorInvalidBornDateWasGiven;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "ode", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorMode;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "owDate", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorNowDate;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "erspective", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorPerspective;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "nderstood", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorUnderstood;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorMode = new FieldHoldingGeneratorMode("field \"Mode\" of the AgeCalculatorStartCommand class");
            fieldGeneratorUnderstood = new JSONHoldingBooleanGenerator("field \"Understood\" of the AgeCalculatorStartCommand class");
            fieldGeneratorInvalidBornDateWasGiven = new JSONHoldingBooleanGenerator("field \"InvalidBornDateWasGiven\" of the AgeCalculatorStartCommand class");
            fieldGeneratorDestinationDate = new DateAndOrTimeJSON.HoldingGenerator("field \"DestinationDate\" of the AgeCalculatorStartCommand class", ignore_extras);
            fieldGeneratorDestinationIsNow = new JSONHoldingBooleanGenerator("field \"DestinationIsNow\" of the AgeCalculatorStartCommand class");
            fieldGeneratorDestinationIsToday = new JSONHoldingBooleanGenerator("field \"DestinationIsToday\" of the AgeCalculatorStartCommand class");
            fieldGeneratorNowDate = new DateAndOrTimeJSON.HoldingGenerator("field \"NowDate\" of the AgeCalculatorStartCommand class", ignore_extras);
            fieldGeneratorPerspective = new AgeCalculatorPerspectiveJSON.HoldingGenerator("field \"Perspective\" of the AgeCalculatorStartCommand class", ignore_extras);
            set_what("the AgeCalculatorStartCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorMode = new FieldHoldingGeneratorMode("field \"Mode\" of the AgeCalculatorStartCommand class");
            fieldGeneratorUnderstood = new JSONHoldingBooleanGenerator("field \"Understood\" of the AgeCalculatorStartCommand class");
            fieldGeneratorInvalidBornDateWasGiven = new JSONHoldingBooleanGenerator("field \"InvalidBornDateWasGiven\" of the AgeCalculatorStartCommand class");
            fieldGeneratorDestinationDate = new DateAndOrTimeJSON.HoldingGenerator("field \"DestinationDate\" of the AgeCalculatorStartCommand class", false);
            fieldGeneratorDestinationIsNow = new JSONHoldingBooleanGenerator("field \"DestinationIsNow\" of the AgeCalculatorStartCommand class");
            fieldGeneratorDestinationIsToday = new JSONHoldingBooleanGenerator("field \"DestinationIsToday\" of the AgeCalculatorStartCommand class");
            fieldGeneratorNowDate = new DateAndOrTimeJSON.HoldingGenerator("field \"NowDate\" of the AgeCalculatorStartCommand class", false);
            fieldGeneratorPerspective = new AgeCalculatorPerspectiveJSON.HoldingGenerator("field \"Perspective\" of the AgeCalculatorStartCommand class", false);
            set_what("the AgeCalculatorStartCommand class");
          }

        public override void reset()
          {
            fieldGeneratorMode.reset();
            fieldGeneratorUnderstood.reset();
            fieldGeneratorInvalidBornDateWasGiven.reset();
            fieldGeneratorDestinationDate.reset();
            fieldGeneratorDestinationIsNow.reset();
            fieldGeneratorDestinationIsToday.reset();
            fieldGeneratorNowDate.reset();
            fieldGeneratorPerspective.reset();
            base.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(AgeCalculatorStartCommandJSON  result)
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
        public AgeCalculatorStartCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AgeCalculatorStartCommandJSON  result)
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
    protected virtual void handle_result(List<AgeCalculatorStartCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AgeCalculatorStartCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AgeCalculatorStartCommandJSON>();
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
    public List<AgeCalculatorStartCommandJSON> value;
  };
  };
