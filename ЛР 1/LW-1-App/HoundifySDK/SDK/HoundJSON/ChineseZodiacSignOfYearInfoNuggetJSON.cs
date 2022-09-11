/* file "ChineseZodiacSignOfYearInfoNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class ChineseZodiacSignOfYearInfoNuggetJSON : ChineseZodiacInfoNuggetJSON
  {
    private bool flagHasYear;
    private BigInteger storeYear;
    private bool flagHasChineseYear;
    private string storeChineseYear;
    private bool flagHasZodiacSign;
    private string storeZodiacSign;
    private bool flagHasZodiacSignInEnglish;
    private ChineseZodiacSignJSON  storeZodiacSignInEnglish;
    private bool flagHasTenseIndicator;
    private sbyte storeTenseIndicator;
    private bool flagHasYesOrNo;
    private bool storeYesOrNo;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraYearToJSON()
      {
        JSONIntegerValue generated_integer_Year = new JSONIntegerValue(storeYear);
        return generated_integer_Year;
      }

    private JSONValue  extraChineseYearToJSON()
      {
        JSONStringValue generated_string_ChineseYear = new JSONStringValue(storeChineseYear);
        return generated_string_ChineseYear;
      }

    private JSONValue  extraZodiacSignToJSON()
      {
        JSONStringValue generated_string_ZodiacSign = new JSONStringValue(storeZodiacSign);
        return generated_string_ZodiacSign;
      }

    private JSONValue  extraZodiacSignInEnglishToJSON()
      {
        JSONValueHandler handler_ZodiacSignInEnglish = new JSONValueHandler();
        storeZodiacSignInEnglish.write_as_json(handler_ZodiacSignInEnglish);
        return handler_ZodiacSignInEnglish.result;
      }

    private JSONValue  extraTenseIndicatorToJSON()
      {
        JSONIntegerValue generated_integer_TenseIndicator = new JSONIntegerValue(storeTenseIndicator);
        return generated_integer_TenseIndicator;
      }

    private JSONValue  extraYesOrNoToJSON()
      {
        JSONValue generated_boolean_YesOrNo = (storeYesOrNo ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_YesOrNo;
      }


    private void  fromJSONYear(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Year of ChineseZodiacSignOfYearInfoNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Year of ChineseZodiacSignOfYearInfoNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setYear(extracted_integer);
      }


    private void  fromJSONChineseYear(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ChineseYear of ChineseZodiacSignOfYearInfoNuggetJSON is not a string.");
        setChineseYear(json_string.getData());
      }


    private void  fromJSONZodiacSign(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ZodiacSign of ChineseZodiacSignOfYearInfoNuggetJSON is not a string.");
        setZodiacSign(json_string.getData());
      }


    private void  fromJSONZodiacSignInEnglish(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ChineseZodiacSignJSON convert_classy = ChineseZodiacSignJSON.from_json(json_value, ignore_extras, true);
        setZodiacSignInEnglish(convert_classy);
      }


    private void  fromJSONTenseIndicator(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TenseIndicator of ChineseZodiacSignOfYearInfoNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TenseIndicator of ChineseZodiacSignOfYearInfoNuggetJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setTenseIndicator(extracted_integer);
      }


    private void  fromJSONYesOrNo(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field YesOrNo of ChineseZodiacSignOfYearInfoNuggetJSON is not true for false.");
              }
          }
        setYesOrNo(the_bool);
      }


    public ChineseZodiacSignOfYearInfoNuggetJSON()
      {
        flagHasYear = false;
        flagHasChineseYear = false;
        flagHasZodiacSign = false;
        flagHasZodiacSignInEnglish = false;
        flagHasTenseIndicator = false;
        flagHasYesOrNo = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getChineseZodiacInfoNuggetKind()
      {
        return "ChineseZodiacSignOfYearInfoNugget";
      }

    public bool  hasYear()
      {
        return flagHasYear;
      }

    public BigInteger  getYear()
      {
        Debug.Assert(flagHasYear);
        return storeYear;
      }

    public bool  hasChineseYear()
      {
        return flagHasChineseYear;
      }

    public string  getChineseYear()
      {
        Debug.Assert(flagHasChineseYear);
        return storeChineseYear;
      }

    public bool  hasZodiacSign()
      {
        return flagHasZodiacSign;
      }

    public string  getZodiacSign()
      {
        Debug.Assert(flagHasZodiacSign);
        return storeZodiacSign;
      }

    public bool  hasZodiacSignInEnglish()
      {
        return flagHasZodiacSignInEnglish;
      }

    public ChineseZodiacSignJSON   getZodiacSignInEnglish()
      {
        Debug.Assert(flagHasZodiacSignInEnglish);
        return storeZodiacSignInEnglish;
      }

    public ChineseZodiacSignJSON.TypeValue  getZodiacSignInEnglishValue()
      {
        return getZodiacSignInEnglish().getValue();
      }

    public string  getZodiacSignInEnglishAsString()
      {
        return getZodiacSignInEnglish().getValueAsString();
      }

    public bool  hasTenseIndicator()
      {
        return flagHasTenseIndicator;
      }

    public sbyte  getTenseIndicator()
      {
        Debug.Assert(flagHasTenseIndicator);
        return storeTenseIndicator;
      }

    public bool  hasYesOrNo()
      {
        return flagHasYesOrNo;
      }

    public bool  getYesOrNo()
      {
        Debug.Assert(flagHasYesOrNo);
        return storeYesOrNo;
      }


    public virtual int extraChineseZodiacSignOfYearInfoNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraChineseZodiacSignOfYearInfoNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraChineseZodiacSignOfYearInfoNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraChineseZodiacSignOfYearInfoNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraChineseZodiacInfoNuggetComponentCount()
      {
        int result = 0;
        if (flagHasYear)
            ++result;
        if (flagHasChineseYear)
            ++result;
        if (flagHasZodiacSign)
            ++result;
        if (flagHasZodiacSignInEnglish)
            ++result;
        if (flagHasTenseIndicator)
            ++result;
        if (flagHasYesOrNo)
            ++result;
        result += extraChineseZodiacSignOfYearInfoNuggetComponentCount();
        return result;
      }
    public override string extraChineseZodiacInfoNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasYear)
          {
            if (remainder == 0)
                return "Year";
            --remainder;
          }
        if (flagHasChineseYear)
          {
            if (remainder == 0)
                return "ChineseYear";
            --remainder;
          }
        if (flagHasZodiacSign)
          {
            if (remainder == 0)
                return "ZodiacSign";
            --remainder;
          }
        if (flagHasZodiacSignInEnglish)
          {
            if (remainder == 0)
                return "ZodiacSignInEnglish";
            --remainder;
          }
        if (flagHasTenseIndicator)
          {
            if (remainder == 0)
                return "TenseIndicator";
            --remainder;
          }
        if (flagHasYesOrNo)
          {
            if (remainder == 0)
                return "YesOrNo";
            --remainder;
          }
        return extraChineseZodiacSignOfYearInfoNuggetComponentKey(remainder);
      }
    public override JSONValue extraChineseZodiacInfoNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasYear)
          {
            if (remainder == 0)
                return extraYearToJSON();
            --remainder;
          }
        if (flagHasChineseYear)
          {
            if (remainder == 0)
                return extraChineseYearToJSON();
            --remainder;
          }
        if (flagHasZodiacSign)
          {
            if (remainder == 0)
                return extraZodiacSignToJSON();
            --remainder;
          }
        if (flagHasZodiacSignInEnglish)
          {
            if (remainder == 0)
                return extraZodiacSignInEnglishToJSON();
            --remainder;
          }
        if (flagHasTenseIndicator)
          {
            if (remainder == 0)
                return extraTenseIndicatorToJSON();
            --remainder;
          }
        if (flagHasYesOrNo)
          {
            if (remainder == 0)
                return extraYesOrNoToJSON();
            --remainder;
          }
        return extraChineseZodiacSignOfYearInfoNuggetComponentValue(remainder);
      }
    public override JSONValue extraChineseZodiacInfoNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "hineseYear", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasChineseYear ? extraChineseYearToJSON() : null);
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "enseIndicator", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasTenseIndicator ? extraTenseIndicatorToJSON() : null);
                break;
            case 'Y':
                if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                  {
                    switch (field_name[2])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 3, "r", 0, 1, false) == 0) && (field_name.Length == 4))
                                return (flagHasYear ? extraYearToJSON() : null);
                            break;
                        case 's':
                            if ((String.Compare(field_name, 3, "OrNo", 0, 4, false) == 0) && (field_name.Length == 7))
                                return (flagHasYesOrNo ? extraYesOrNoToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Z':
                if (String.Compare(field_name, 1, "odiacSign", 0, 9, false) == 0)
                  {
                    if (field_name.Length == 10)
                      {
                        return (flagHasZodiacSign ? extraZodiacSignToJSON() : null);
                      }
                    switch (field_name[10])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 11, "nEnglish", 0, 8, false) == 0) && (field_name.Length == 19))
                                return (flagHasZodiacSignInEnglish ? extraZodiacSignInEnglishToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraChineseZodiacSignOfYearInfoNuggetLookup(field_name);
      }

    public void setYear(BigInteger new_value)
      {
        flagHasYear = true;
        storeYear = new_value;
      }
    public void unsetYear()
      {
        flagHasYear = false;
      }
    public void setChineseYear(string new_value)
      {
        flagHasChineseYear = true;
        storeChineseYear = new_value;
      }
    public void unsetChineseYear()
      {
        flagHasChineseYear = false;
      }
    public void setZodiacSign(string new_value)
      {
        flagHasZodiacSign = true;
        storeZodiacSign = new_value;
      }
    public void unsetZodiacSign()
      {
        flagHasZodiacSign = false;
      }
    public void setZodiacSignInEnglish(ChineseZodiacSignJSON  new_value)
      {
        if (flagHasZodiacSignInEnglish)
          {
          }
        flagHasZodiacSignInEnglish = true;
        storeZodiacSignInEnglish = new_value;
      }
    public void setZodiacSignInEnglish(ChineseZodiacSignJSON.TypeValue new_value)
      {
        setZodiacSignInEnglish(new ChineseZodiacSignJSON(new_value));
      }
    public void setZodiacSignInEnglish(string chars)
      {
        ChineseZodiacSignJSON.TypeValueKnownValues known = ChineseZodiacSignJSON.stringToValue(chars);
        ChineseZodiacSignJSON.TypeValue new_value = new ChineseZodiacSignJSON.TypeValue();
        if (known == ChineseZodiacSignJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setZodiacSignInEnglish(new_value);
      }
    public void unsetZodiacSignInEnglish()
      {
        if (flagHasZodiacSignInEnglish)
          {
          }
        flagHasZodiacSignInEnglish = false;
      }
    public void setTenseIndicator(sbyte new_value)
      {
        flagHasTenseIndicator = true;
        if (new_value < -1)
            throw new Exception("The value for field TenseIndicator of ChineseZodiacSignOfYearInfoNuggetJSON is less than the lower bound (-1) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field TenseIndicator of ChineseZodiacSignOfYearInfoNuggetJSON is greater than the upper bound (1) for that field.");
        storeTenseIndicator = new_value;
      }
    public void unsetTenseIndicator()
      {
        flagHasTenseIndicator = false;
      }
    public void setYesOrNo(bool new_value)
      {
        flagHasYesOrNo = true;
        storeYesOrNo = new_value;
      }
    public void unsetYesOrNo()
      {
        flagHasYesOrNo = false;
      }

    public virtual void extraChineseZodiacSignOfYearInfoNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraChineseZodiacSignOfYearInfoNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraChineseZodiacSignOfYearInfoNuggetLookup(key);
        if (old_field == null)
          {
            extraChineseZodiacSignOfYearInfoNuggetAppendPair(key, new_component);
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
    public override void extraChineseZodiacInfoNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hineseYear", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONChineseYear(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "enseIndicator", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONTenseIndicator(new_component, false);
                    return;
                    }
                break;
            case 'Y':
                if (String.Compare(key, 1, "e", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'a':
                            if ((String.Compare(key, 3, "r", 0, 1, false) == 0) && (key.Length == 4))
                                {
                                fromJSONYear(new_component, false);
                                return;
                                }
                            break;
                        case 's':
                            if ((String.Compare(key, 3, "OrNo", 0, 4, false) == 0) && (key.Length == 7))
                                {
                                fromJSONYesOrNo(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Z':
                if (String.Compare(key, 1, "odiacSign", 0, 9, false) == 0)
                  {
                    if (key.Length == 10)
                      {
                        {
                        fromJSONZodiacSign(new_component, false);
                        return;
                        }
                      }
                    switch (key[10])
                      {
                        case 'I':
                            if ((String.Compare(key, 11, "nEnglish", 0, 8, false) == 0) && (key.Length == 19))
                                {
                                fromJSONZodiacSignInEnglish(new_component, false);
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
        extraChineseZodiacSignOfYearInfoNuggetAppendPair(key, new_component);
      }
    public override void extraChineseZodiacInfoNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hineseYear", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONChineseYear(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "enseIndicator", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONTenseIndicator(new_component, false);
                    return;
                    }
                break;
            case 'Y':
                if (String.Compare(key, 1, "e", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'a':
                            if ((String.Compare(key, 3, "r", 0, 1, false) == 0) && (key.Length == 4))
                                {
                                fromJSONYear(new_component, false);
                                return;
                                }
                            break;
                        case 's':
                            if ((String.Compare(key, 3, "OrNo", 0, 4, false) == 0) && (key.Length == 7))
                                {
                                fromJSONYesOrNo(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Z':
                if (String.Compare(key, 1, "odiacSign", 0, 9, false) == 0)
                  {
                    if (key.Length == 10)
                      {
                        {
                        fromJSONZodiacSign(new_component, false);
                        return;
                        }
                      }
                    switch (key[10])
                      {
                        case 'I':
                            if ((String.Compare(key, 11, "nEnglish", 0, 8, false) == 0) && (key.Length == 19))
                                {
                                fromJSONZodiacSignInEnglish(new_component, false);
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
        extraChineseZodiacSignOfYearInfoNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasYear);
        if (flagHasYear)
          {
            handler.start_pair("Year");
            handler.number_value(storeYear);
          }
        if (flagHasChineseYear)
          {
            handler.start_pair("ChineseYear");
            handler.string_value(storeChineseYear);
          }
        Debug.Assert(partial_allowed || flagHasZodiacSign);
        if (flagHasZodiacSign)
          {
            handler.start_pair("ZodiacSign");
            handler.string_value(storeZodiacSign);
          }
        Debug.Assert(partial_allowed || flagHasZodiacSignInEnglish);
        if (flagHasZodiacSignInEnglish)
          {
            handler.start_pair("ZodiacSignInEnglish");
            if (partial_allowed)
                storeZodiacSignInEnglish.write_partial_as_json(handler);
            else
                storeZodiacSignInEnglish.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasTenseIndicator);
        if (flagHasTenseIndicator)
          {
            handler.start_pair("TenseIndicator");
            handler.number_value(storeTenseIndicator);
          }
        if (flagHasYesOrNo)
          {
            handler.start_pair("YesOrNo");
            handler.boolean_value(storeYesOrNo);
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
        if (!(hasYear()))
          {
            return "When parsing the object for %what%, the \"Year\" field was missing.";
          }
        if (!(hasZodiacSign()))
          {
            return "When parsing the object for %what%, the \"ZodiacSign\" field was missing.";
          }
        if (!(hasZodiacSignInEnglish()))
          {
            return "When parsing the object for %what%, the \"ZodiacSignInEnglish\" field was missing.";
          }
        if (!(hasTenseIndicator()))
          {
            return "When parsing the object for %what%, the \"TenseIndicator\" field was missing.";
          }
        return null;
      }

    public static new ChineseZodiacSignOfYearInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChineseZodiacSignOfYearInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacSignOfYearInfoNugget", ignore_extras);
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
    public static new ChineseZodiacSignOfYearInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ChineseZodiacSignOfYearInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChineseZodiacSignOfYearInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacSignOfYearInfoNugget", ignore_extras);
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
    public static new ChineseZodiacSignOfYearInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ChineseZodiacSignOfYearInfoNuggetJSON from_text(string text, bool ignore_extras)
      {
        ChineseZodiacSignOfYearInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacSignOfYearInfoNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ChineseZodiacSignOfYearInfoNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ChineseZodiacSignOfYearInfoNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ChineseZodiacSignOfYearInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacSignOfYearInfoNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ChineseZodiacInfoNuggetJSON.Generator
      {
    private class FieldHoldingGeneratorYear : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorYear(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorYear : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorYear(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorYear fieldGeneratorYear;
        private JSONHoldingStringGenerator fieldGeneratorChineseYear;
        private JSONHoldingStringGenerator fieldGeneratorZodiacSign;
        private ChineseZodiacSignJSON.HoldingGenerator fieldGeneratorZodiacSignInEnglish;
    private class FieldHoldingGeneratorTenseIndicator : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorTenseIndicator(String what) : base(what, -1, 1)
              {
              }
          };
    private class FieldHoldingArrayGeneratorTenseIndicator : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorTenseIndicator(String what) : base(what, -1, 1)
              {
              }
          };
        private FieldHoldingGeneratorTenseIndicator fieldGeneratorTenseIndicator;
        private JSONHoldingBooleanGenerator fieldGeneratorYesOrNo;
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
            if (!(getChineseZodiacInfoNuggetJSONKey().Equals("ChineseZodiacSignOfYearInfoNugget")))
                throw new Exception("The key field has a value other than `ChineseZodiacSignOfYearInfoNugget'.");
            ChineseZodiacSignOfYearInfoNuggetJSON result = new ChineseZodiacSignOfYearInfoNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraChineseZodiacSignOfYearInfoNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ChineseZodiacInfoNuggetJSON new_result)
          {
            handle_result((ChineseZodiacSignOfYearInfoNuggetJSON )new_result);
          }
        protected void finish(ChineseZodiacSignOfYearInfoNuggetJSON result)
          {
            if (fieldGeneratorYear.have_value)
              {
                result.setYear(fieldGeneratorYear.value);
                fieldGeneratorYear.have_value = false;
              }
            else if ((!(result.hasYear())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Year\" field was missing.");
              }
            if (fieldGeneratorChineseYear.have_value)
              {
                result.setChineseYear(fieldGeneratorChineseYear.value);
                fieldGeneratorChineseYear.have_value = false;
              }
            if (fieldGeneratorZodiacSign.have_value)
              {
                result.setZodiacSign(fieldGeneratorZodiacSign.value);
                fieldGeneratorZodiacSign.have_value = false;
              }
            else if ((!(result.hasZodiacSign())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ZodiacSign\" field was missing.");
              }
            if (fieldGeneratorZodiacSignInEnglish.have_value)
              {
                result.setZodiacSignInEnglish(fieldGeneratorZodiacSignInEnglish.value);
                fieldGeneratorZodiacSignInEnglish.have_value = false;
              }
            else if ((!(result.hasZodiacSignInEnglish())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ZodiacSignInEnglish\" field was missing.");
              }
            if (fieldGeneratorTenseIndicator.have_value)
              {
                result.setTenseIndicator((sbyte)(fieldGeneratorTenseIndicator.value));
                fieldGeneratorTenseIndicator.have_value = false;
              }
            else if ((!(result.hasTenseIndicator())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TenseIndicator\" field was missing.");
              }
            if (fieldGeneratorYesOrNo.have_value)
              {
                result.setYesOrNo(fieldGeneratorYesOrNo.value);
                fieldGeneratorYesOrNo.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ChineseZodiacSignOfYearInfoNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "hineseYear", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorChineseYear;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "enseIndicator", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorTenseIndicator;
                    break;
                case 'Y':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 3, "r", 0, 1, false) == 0) && (field_name.Length == 4))
                                    return fieldGeneratorYear;
                                break;
                            case 's':
                                if ((String.Compare(field_name, 3, "OrNo", 0, 4, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorYesOrNo;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'Z':
                    if (String.Compare(field_name, 1, "odiacSign", 0, 9, false) == 0)
                      {
                        if (field_name.Length == 10)
                          {
                            return fieldGeneratorZodiacSign;
                          }
                        switch (field_name[10])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 11, "nEnglish", 0, 8, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorZodiacSignInEnglish;
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
            fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the ChineseZodiacSignOfYearInfoNugget class");
            fieldGeneratorChineseYear = new JSONHoldingStringGenerator("field \"ChineseYear\" of the ChineseZodiacSignOfYearInfoNugget class");
            fieldGeneratorZodiacSign = new JSONHoldingStringGenerator("field \"ZodiacSign\" of the ChineseZodiacSignOfYearInfoNugget class");
            fieldGeneratorZodiacSignInEnglish = new ChineseZodiacSignJSON.HoldingGenerator("field \"ZodiacSignInEnglish\" of the ChineseZodiacSignOfYearInfoNugget class", ignore_extras);
            fieldGeneratorTenseIndicator = new FieldHoldingGeneratorTenseIndicator("field \"TenseIndicator\" of the ChineseZodiacSignOfYearInfoNugget class");
            fieldGeneratorYesOrNo = new JSONHoldingBooleanGenerator("field \"YesOrNo\" of the ChineseZodiacSignOfYearInfoNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ChineseZodiacSignOfYearInfoNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the ChineseZodiacSignOfYearInfoNugget class");
            fieldGeneratorChineseYear = new JSONHoldingStringGenerator("field \"ChineseYear\" of the ChineseZodiacSignOfYearInfoNugget class");
            fieldGeneratorZodiacSign = new JSONHoldingStringGenerator("field \"ZodiacSign\" of the ChineseZodiacSignOfYearInfoNugget class");
            fieldGeneratorZodiacSignInEnglish = new ChineseZodiacSignJSON.HoldingGenerator("field \"ZodiacSignInEnglish\" of the ChineseZodiacSignOfYearInfoNugget class", false);
            fieldGeneratorTenseIndicator = new FieldHoldingGeneratorTenseIndicator("field \"TenseIndicator\" of the ChineseZodiacSignOfYearInfoNugget class");
            fieldGeneratorYesOrNo = new JSONHoldingBooleanGenerator("field \"YesOrNo\" of the ChineseZodiacSignOfYearInfoNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ChineseZodiacSignOfYearInfoNugget class");
          }

        public override void reset()
          {
            fieldGeneratorYear.reset();
            fieldGeneratorChineseYear.reset();
            fieldGeneratorZodiacSign.reset();
            fieldGeneratorZodiacSignInEnglish.reset();
            fieldGeneratorTenseIndicator.reset();
            fieldGeneratorYesOrNo.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ChineseZodiacSignOfYearInfoNuggetJSON  result)
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
        public ChineseZodiacSignOfYearInfoNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ChineseZodiacSignOfYearInfoNuggetJSON  result)
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
    protected virtual void handle_result(List<ChineseZodiacSignOfYearInfoNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ChineseZodiacSignOfYearInfoNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ChineseZodiacSignOfYearInfoNuggetJSON>();
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
    public List<ChineseZodiacSignOfYearInfoNuggetJSON> value;
  };
  };
