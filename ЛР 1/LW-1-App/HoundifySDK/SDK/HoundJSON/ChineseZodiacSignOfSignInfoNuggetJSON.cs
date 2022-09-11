/* file "ChineseZodiacSignOfSignInfoNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class ChineseZodiacSignOfSignInfoNuggetJSON : ChineseZodiacInfoNuggetJSON
  {
    private bool flagHasResultSign;
    private string storeResultSign;
    private bool flagHasQuerySign;
    private string storeQuerySign;
    private bool flagHasResultSignInEnglish;
    private ChineseZodiacSignJSON  storeResultSignInEnglish;
    private bool flagHasQuerySignInEnglish;
    private ChineseZodiacSignJSON  storeQuerySignInEnglish;
    private bool flagHasOrdinal;
    private BigInteger storeOrdinal;
    private bool flagHasCycled;
    private bool storeCycled;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraResultSignToJSON()
      {
        JSONStringValue generated_string_ResultSign = new JSONStringValue(storeResultSign);
        return generated_string_ResultSign;
      }

    private JSONValue  extraQuerySignToJSON()
      {
        JSONStringValue generated_string_QuerySign = new JSONStringValue(storeQuerySign);
        return generated_string_QuerySign;
      }

    private JSONValue  extraResultSignInEnglishToJSON()
      {
        JSONValueHandler handler_ResultSignInEnglish = new JSONValueHandler();
        storeResultSignInEnglish.write_as_json(handler_ResultSignInEnglish);
        return handler_ResultSignInEnglish.result;
      }

    private JSONValue  extraQuerySignInEnglishToJSON()
      {
        JSONValueHandler handler_QuerySignInEnglish = new JSONValueHandler();
        storeQuerySignInEnglish.write_as_json(handler_QuerySignInEnglish);
        return handler_QuerySignInEnglish.result;
      }

    private JSONValue  extraOrdinalToJSON()
      {
        JSONIntegerValue generated_integer_Ordinal = new JSONIntegerValue(storeOrdinal);
        return generated_integer_Ordinal;
      }

    private JSONValue  extraCycledToJSON()
      {
        JSONValue generated_boolean_Cycled = (storeCycled ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_Cycled;
      }


    private void  fromJSONResultSign(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResultSign of ChineseZodiacSignOfSignInfoNuggetJSON is not a string.");
        setResultSign(json_string.getData());
      }


    private void  fromJSONQuerySign(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QuerySign of ChineseZodiacSignOfSignInfoNuggetJSON is not a string.");
        setQuerySign(json_string.getData());
      }


    private void  fromJSONResultSignInEnglish(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ChineseZodiacSignJSON convert_classy = ChineseZodiacSignJSON.from_json(json_value, ignore_extras, true);
        setResultSignInEnglish(convert_classy);
      }


    private void  fromJSONQuerySignInEnglish(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ChineseZodiacSignJSON convert_classy = ChineseZodiacSignJSON.from_json(json_value, ignore_extras, true);
        setQuerySignInEnglish(convert_classy);
      }


    private void  fromJSONOrdinal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Ordinal of ChineseZodiacSignOfSignInfoNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Ordinal of ChineseZodiacSignOfSignInfoNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setOrdinal(extracted_integer);
      }


    private void  fromJSONCycled(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Cycled of ChineseZodiacSignOfSignInfoNuggetJSON is not true for false.");
              }
          }
        setCycled(the_bool);
      }


    public ChineseZodiacSignOfSignInfoNuggetJSON()
      {
        flagHasResultSign = false;
        flagHasQuerySign = false;
        flagHasResultSignInEnglish = false;
        flagHasQuerySignInEnglish = false;
        flagHasOrdinal = false;
        flagHasCycled = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getChineseZodiacInfoNuggetKind()
      {
        return "ChineseZodiacSignOfSignInfoNugget";
      }

    public bool  hasResultSign()
      {
        return flagHasResultSign;
      }

    public string  getResultSign()
      {
        Debug.Assert(flagHasResultSign);
        return storeResultSign;
      }

    public bool  hasQuerySign()
      {
        return flagHasQuerySign;
      }

    public string  getQuerySign()
      {
        Debug.Assert(flagHasQuerySign);
        return storeQuerySign;
      }

    public bool  hasResultSignInEnglish()
      {
        return flagHasResultSignInEnglish;
      }

    public ChineseZodiacSignJSON   getResultSignInEnglish()
      {
        Debug.Assert(flagHasResultSignInEnglish);
        return storeResultSignInEnglish;
      }

    public ChineseZodiacSignJSON.TypeValue  getResultSignInEnglishValue()
      {
        return getResultSignInEnglish().getValue();
      }

    public string  getResultSignInEnglishAsString()
      {
        return getResultSignInEnglish().getValueAsString();
      }

    public bool  hasQuerySignInEnglish()
      {
        return flagHasQuerySignInEnglish;
      }

    public ChineseZodiacSignJSON   getQuerySignInEnglish()
      {
        Debug.Assert(flagHasQuerySignInEnglish);
        return storeQuerySignInEnglish;
      }

    public ChineseZodiacSignJSON.TypeValue  getQuerySignInEnglishValue()
      {
        return getQuerySignInEnglish().getValue();
      }

    public string  getQuerySignInEnglishAsString()
      {
        return getQuerySignInEnglish().getValueAsString();
      }

    public bool  hasOrdinal()
      {
        return flagHasOrdinal;
      }

    public BigInteger  getOrdinal()
      {
        Debug.Assert(flagHasOrdinal);
        return storeOrdinal;
      }

    public bool  hasCycled()
      {
        return flagHasCycled;
      }

    public bool  getCycled()
      {
        Debug.Assert(flagHasCycled);
        return storeCycled;
      }


    public virtual int extraChineseZodiacSignOfSignInfoNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraChineseZodiacSignOfSignInfoNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraChineseZodiacSignOfSignInfoNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraChineseZodiacSignOfSignInfoNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraChineseZodiacInfoNuggetComponentCount()
      {
        int result = 0;
        if (flagHasResultSign)
            ++result;
        if (flagHasQuerySign)
            ++result;
        if (flagHasResultSignInEnglish)
            ++result;
        if (flagHasQuerySignInEnglish)
            ++result;
        if (flagHasOrdinal)
            ++result;
        if (flagHasCycled)
            ++result;
        result += extraChineseZodiacSignOfSignInfoNuggetComponentCount();
        return result;
      }
    public override string extraChineseZodiacInfoNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasResultSign)
          {
            if (remainder == 0)
                return "ResultSign";
            --remainder;
          }
        if (flagHasQuerySign)
          {
            if (remainder == 0)
                return "QuerySign";
            --remainder;
          }
        if (flagHasResultSignInEnglish)
          {
            if (remainder == 0)
                return "ResultSignInEnglish";
            --remainder;
          }
        if (flagHasQuerySignInEnglish)
          {
            if (remainder == 0)
                return "QuerySignInEnglish";
            --remainder;
          }
        if (flagHasOrdinal)
          {
            if (remainder == 0)
                return "Ordinal";
            --remainder;
          }
        if (flagHasCycled)
          {
            if (remainder == 0)
                return "Cycled";
            --remainder;
          }
        return extraChineseZodiacSignOfSignInfoNuggetComponentKey(remainder);
      }
    public override JSONValue extraChineseZodiacInfoNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasResultSign)
          {
            if (remainder == 0)
                return extraResultSignToJSON();
            --remainder;
          }
        if (flagHasQuerySign)
          {
            if (remainder == 0)
                return extraQuerySignToJSON();
            --remainder;
          }
        if (flagHasResultSignInEnglish)
          {
            if (remainder == 0)
                return extraResultSignInEnglishToJSON();
            --remainder;
          }
        if (flagHasQuerySignInEnglish)
          {
            if (remainder == 0)
                return extraQuerySignInEnglishToJSON();
            --remainder;
          }
        if (flagHasOrdinal)
          {
            if (remainder == 0)
                return extraOrdinalToJSON();
            --remainder;
          }
        if (flagHasCycled)
          {
            if (remainder == 0)
                return extraCycledToJSON();
            --remainder;
          }
        return extraChineseZodiacSignOfSignInfoNuggetComponentValue(remainder);
      }
    public override JSONValue extraChineseZodiacInfoNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "ycled", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasCycled ? extraCycledToJSON() : null);
                break;
            case 'O':
                if ((String.Compare(field_name, 1, "rdinal", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasOrdinal ? extraOrdinalToJSON() : null);
                break;
            case 'Q':
                if (String.Compare(field_name, 1, "uerySign", 0, 8, false) == 0)
                  {
                    if (field_name.Length == 9)
                      {
                        return (flagHasQuerySign ? extraQuerySignToJSON() : null);
                      }
                    switch (field_name[9])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 10, "nEnglish", 0, 8, false) == 0) && (field_name.Length == 18))
                                return (flagHasQuerySignInEnglish ? extraQuerySignInEnglishToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if (String.Compare(field_name, 1, "esultSign", 0, 9, false) == 0)
                  {
                    if (field_name.Length == 10)
                      {
                        return (flagHasResultSign ? extraResultSignToJSON() : null);
                      }
                    switch (field_name[10])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 11, "nEnglish", 0, 8, false) == 0) && (field_name.Length == 19))
                                return (flagHasResultSignInEnglish ? extraResultSignInEnglishToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraChineseZodiacSignOfSignInfoNuggetLookup(field_name);
      }

    public void setResultSign(string new_value)
      {
        flagHasResultSign = true;
        storeResultSign = new_value;
      }
    public void unsetResultSign()
      {
        flagHasResultSign = false;
      }
    public void setQuerySign(string new_value)
      {
        flagHasQuerySign = true;
        storeQuerySign = new_value;
      }
    public void unsetQuerySign()
      {
        flagHasQuerySign = false;
      }
    public void setResultSignInEnglish(ChineseZodiacSignJSON  new_value)
      {
        if (flagHasResultSignInEnglish)
          {
          }
        flagHasResultSignInEnglish = true;
        storeResultSignInEnglish = new_value;
      }
    public void setResultSignInEnglish(ChineseZodiacSignJSON.TypeValue new_value)
      {
        setResultSignInEnglish(new ChineseZodiacSignJSON(new_value));
      }
    public void setResultSignInEnglish(string chars)
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
        setResultSignInEnglish(new_value);
      }
    public void unsetResultSignInEnglish()
      {
        if (flagHasResultSignInEnglish)
          {
          }
        flagHasResultSignInEnglish = false;
      }
    public void setQuerySignInEnglish(ChineseZodiacSignJSON  new_value)
      {
        if (flagHasQuerySignInEnglish)
          {
          }
        flagHasQuerySignInEnglish = true;
        storeQuerySignInEnglish = new_value;
      }
    public void setQuerySignInEnglish(ChineseZodiacSignJSON.TypeValue new_value)
      {
        setQuerySignInEnglish(new ChineseZodiacSignJSON(new_value));
      }
    public void setQuerySignInEnglish(string chars)
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
        setQuerySignInEnglish(new_value);
      }
    public void unsetQuerySignInEnglish()
      {
        if (flagHasQuerySignInEnglish)
          {
          }
        flagHasQuerySignInEnglish = false;
      }
    public void setOrdinal(BigInteger new_value)
      {
        flagHasOrdinal = true;
        storeOrdinal = new_value;
      }
    public void unsetOrdinal()
      {
        flagHasOrdinal = false;
      }
    public void setCycled(bool new_value)
      {
        flagHasCycled = true;
        storeCycled = new_value;
      }
    public void unsetCycled()
      {
        flagHasCycled = false;
      }

    public virtual void extraChineseZodiacSignOfSignInfoNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraChineseZodiacSignOfSignInfoNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraChineseZodiacSignOfSignInfoNuggetLookup(key);
        if (old_field == null)
          {
            extraChineseZodiacSignOfSignInfoNuggetAppendPair(key, new_component);
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
                if ((String.Compare(key, 1, "ycled", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONCycled(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "rdinal", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONOrdinal(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if (String.Compare(key, 1, "uerySign", 0, 8, false) == 0)
                  {
                    if (key.Length == 9)
                      {
                        {
                        fromJSONQuerySign(new_component, false);
                        return;
                        }
                      }
                    switch (key[9])
                      {
                        case 'I':
                            if ((String.Compare(key, 10, "nEnglish", 0, 8, false) == 0) && (key.Length == 18))
                                {
                                fromJSONQuerySignInEnglish(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if (String.Compare(key, 1, "esultSign", 0, 9, false) == 0)
                  {
                    if (key.Length == 10)
                      {
                        {
                        fromJSONResultSign(new_component, false);
                        return;
                        }
                      }
                    switch (key[10])
                      {
                        case 'I':
                            if ((String.Compare(key, 11, "nEnglish", 0, 8, false) == 0) && (key.Length == 19))
                                {
                                fromJSONResultSignInEnglish(new_component, false);
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
        extraChineseZodiacSignOfSignInfoNuggetAppendPair(key, new_component);
      }
    public override void extraChineseZodiacInfoNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ycled", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONCycled(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "rdinal", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONOrdinal(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if (String.Compare(key, 1, "uerySign", 0, 8, false) == 0)
                  {
                    if (key.Length == 9)
                      {
                        {
                        fromJSONQuerySign(new_component, false);
                        return;
                        }
                      }
                    switch (key[9])
                      {
                        case 'I':
                            if ((String.Compare(key, 10, "nEnglish", 0, 8, false) == 0) && (key.Length == 18))
                                {
                                fromJSONQuerySignInEnglish(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if (String.Compare(key, 1, "esultSign", 0, 9, false) == 0)
                  {
                    if (key.Length == 10)
                      {
                        {
                        fromJSONResultSign(new_component, false);
                        return;
                        }
                      }
                    switch (key[10])
                      {
                        case 'I':
                            if ((String.Compare(key, 11, "nEnglish", 0, 8, false) == 0) && (key.Length == 19))
                                {
                                fromJSONResultSignInEnglish(new_component, false);
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
        extraChineseZodiacSignOfSignInfoNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasResultSign);
        if (flagHasResultSign)
          {
            handler.start_pair("ResultSign");
            handler.string_value(storeResultSign);
          }
        Debug.Assert(partial_allowed || flagHasQuerySign);
        if (flagHasQuerySign)
          {
            handler.start_pair("QuerySign");
            handler.string_value(storeQuerySign);
          }
        Debug.Assert(partial_allowed || flagHasResultSignInEnglish);
        if (flagHasResultSignInEnglish)
          {
            handler.start_pair("ResultSignInEnglish");
            if (partial_allowed)
                storeResultSignInEnglish.write_partial_as_json(handler);
            else
                storeResultSignInEnglish.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasQuerySignInEnglish);
        if (flagHasQuerySignInEnglish)
          {
            handler.start_pair("QuerySignInEnglish");
            if (partial_allowed)
                storeQuerySignInEnglish.write_partial_as_json(handler);
            else
                storeQuerySignInEnglish.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasOrdinal);
        if (flagHasOrdinal)
          {
            handler.start_pair("Ordinal");
            handler.number_value(storeOrdinal);
          }
        Debug.Assert(partial_allowed || flagHasCycled);
        if (flagHasCycled)
          {
            handler.start_pair("Cycled");
            handler.boolean_value(storeCycled);
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
        if (!(hasResultSign()))
          {
            return "When parsing the object for %what%, the \"ResultSign\" field was missing.";
          }
        if (!(hasQuerySign()))
          {
            return "When parsing the object for %what%, the \"QuerySign\" field was missing.";
          }
        if (!(hasResultSignInEnglish()))
          {
            return "When parsing the object for %what%, the \"ResultSignInEnglish\" field was missing.";
          }
        if (!(hasQuerySignInEnglish()))
          {
            return "When parsing the object for %what%, the \"QuerySignInEnglish\" field was missing.";
          }
        if (!(hasOrdinal()))
          {
            return "When parsing the object for %what%, the \"Ordinal\" field was missing.";
          }
        if (!(hasCycled()))
          {
            return "When parsing the object for %what%, the \"Cycled\" field was missing.";
          }
        return null;
      }

    public static new ChineseZodiacSignOfSignInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChineseZodiacSignOfSignInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacSignOfSignInfoNugget", ignore_extras);
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
    public static new ChineseZodiacSignOfSignInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ChineseZodiacSignOfSignInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChineseZodiacSignOfSignInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacSignOfSignInfoNugget", ignore_extras);
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
    public static new ChineseZodiacSignOfSignInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ChineseZodiacSignOfSignInfoNuggetJSON from_text(string text, bool ignore_extras)
      {
        ChineseZodiacSignOfSignInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacSignOfSignInfoNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ChineseZodiacSignOfSignInfoNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ChineseZodiacSignOfSignInfoNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ChineseZodiacSignOfSignInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacSignOfSignInfoNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ChineseZodiacInfoNuggetJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorResultSign;
        private JSONHoldingStringGenerator fieldGeneratorQuerySign;
        private ChineseZodiacSignJSON.HoldingGenerator fieldGeneratorResultSignInEnglish;
        private ChineseZodiacSignJSON.HoldingGenerator fieldGeneratorQuerySignInEnglish;
    private class FieldHoldingGeneratorOrdinal : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorOrdinal(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorOrdinal : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorOrdinal(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorOrdinal fieldGeneratorOrdinal;
        private JSONHoldingBooleanGenerator fieldGeneratorCycled;
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
            if (!(getChineseZodiacInfoNuggetJSONKey().Equals("ChineseZodiacSignOfSignInfoNugget")))
                throw new Exception("The key field has a value other than `ChineseZodiacSignOfSignInfoNugget'.");
            ChineseZodiacSignOfSignInfoNuggetJSON result = new ChineseZodiacSignOfSignInfoNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraChineseZodiacSignOfSignInfoNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ChineseZodiacInfoNuggetJSON new_result)
          {
            handle_result((ChineseZodiacSignOfSignInfoNuggetJSON )new_result);
          }
        protected void finish(ChineseZodiacSignOfSignInfoNuggetJSON result)
          {
            if (fieldGeneratorResultSign.have_value)
              {
                result.setResultSign(fieldGeneratorResultSign.value);
                fieldGeneratorResultSign.have_value = false;
              }
            else if ((!(result.hasResultSign())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ResultSign\" field was missing.");
              }
            if (fieldGeneratorQuerySign.have_value)
              {
                result.setQuerySign(fieldGeneratorQuerySign.value);
                fieldGeneratorQuerySign.have_value = false;
              }
            else if ((!(result.hasQuerySign())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QuerySign\" field was missing.");
              }
            if (fieldGeneratorResultSignInEnglish.have_value)
              {
                result.setResultSignInEnglish(fieldGeneratorResultSignInEnglish.value);
                fieldGeneratorResultSignInEnglish.have_value = false;
              }
            else if ((!(result.hasResultSignInEnglish())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ResultSignInEnglish\" field was missing.");
              }
            if (fieldGeneratorQuerySignInEnglish.have_value)
              {
                result.setQuerySignInEnglish(fieldGeneratorQuerySignInEnglish.value);
                fieldGeneratorQuerySignInEnglish.have_value = false;
              }
            else if ((!(result.hasQuerySignInEnglish())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QuerySignInEnglish\" field was missing.");
              }
            if (fieldGeneratorOrdinal.have_value)
              {
                result.setOrdinal(fieldGeneratorOrdinal.value);
                fieldGeneratorOrdinal.have_value = false;
              }
            else if ((!(result.hasOrdinal())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Ordinal\" field was missing.");
              }
            if (fieldGeneratorCycled.have_value)
              {
                result.setCycled(fieldGeneratorCycled.value);
                fieldGeneratorCycled.have_value = false;
              }
            else if ((!(result.hasCycled())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Cycled\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ChineseZodiacSignOfSignInfoNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ycled", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorCycled;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "rdinal", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorOrdinal;
                    break;
                case 'Q':
                    if (String.Compare(field_name, 1, "uerySign", 0, 8, false) == 0)
                      {
                        if (field_name.Length == 9)
                          {
                            return fieldGeneratorQuerySign;
                          }
                        switch (field_name[9])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 10, "nEnglish", 0, 8, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorQuerySignInEnglish;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "esultSign", 0, 9, false) == 0)
                      {
                        if (field_name.Length == 10)
                          {
                            return fieldGeneratorResultSign;
                          }
                        switch (field_name[10])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 11, "nEnglish", 0, 8, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorResultSignInEnglish;
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
            fieldGeneratorResultSign = new JSONHoldingStringGenerator("field \"ResultSign\" of the ChineseZodiacSignOfSignInfoNugget class");
            fieldGeneratorQuerySign = new JSONHoldingStringGenerator("field \"QuerySign\" of the ChineseZodiacSignOfSignInfoNugget class");
            fieldGeneratorResultSignInEnglish = new ChineseZodiacSignJSON.HoldingGenerator("field \"ResultSignInEnglish\" of the ChineseZodiacSignOfSignInfoNugget class", ignore_extras);
            fieldGeneratorQuerySignInEnglish = new ChineseZodiacSignJSON.HoldingGenerator("field \"QuerySignInEnglish\" of the ChineseZodiacSignOfSignInfoNugget class", ignore_extras);
            fieldGeneratorOrdinal = new FieldHoldingGeneratorOrdinal("field \"Ordinal\" of the ChineseZodiacSignOfSignInfoNugget class");
            fieldGeneratorCycled = new JSONHoldingBooleanGenerator("field \"Cycled\" of the ChineseZodiacSignOfSignInfoNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ChineseZodiacSignOfSignInfoNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorResultSign = new JSONHoldingStringGenerator("field \"ResultSign\" of the ChineseZodiacSignOfSignInfoNugget class");
            fieldGeneratorQuerySign = new JSONHoldingStringGenerator("field \"QuerySign\" of the ChineseZodiacSignOfSignInfoNugget class");
            fieldGeneratorResultSignInEnglish = new ChineseZodiacSignJSON.HoldingGenerator("field \"ResultSignInEnglish\" of the ChineseZodiacSignOfSignInfoNugget class", false);
            fieldGeneratorQuerySignInEnglish = new ChineseZodiacSignJSON.HoldingGenerator("field \"QuerySignInEnglish\" of the ChineseZodiacSignOfSignInfoNugget class", false);
            fieldGeneratorOrdinal = new FieldHoldingGeneratorOrdinal("field \"Ordinal\" of the ChineseZodiacSignOfSignInfoNugget class");
            fieldGeneratorCycled = new JSONHoldingBooleanGenerator("field \"Cycled\" of the ChineseZodiacSignOfSignInfoNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ChineseZodiacSignOfSignInfoNugget class");
          }

        public override void reset()
          {
            fieldGeneratorResultSign.reset();
            fieldGeneratorQuerySign.reset();
            fieldGeneratorResultSignInEnglish.reset();
            fieldGeneratorQuerySignInEnglish.reset();
            fieldGeneratorOrdinal.reset();
            fieldGeneratorCycled.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ChineseZodiacSignOfSignInfoNuggetJSON  result)
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
        public ChineseZodiacSignOfSignInfoNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ChineseZodiacSignOfSignInfoNuggetJSON  result)
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
    protected virtual void handle_result(List<ChineseZodiacSignOfSignInfoNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ChineseZodiacSignOfSignInfoNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ChineseZodiacSignOfSignInfoNuggetJSON>();
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
    public List<ChineseZodiacSignOfSignInfoNuggetJSON> value;
  };
  };
