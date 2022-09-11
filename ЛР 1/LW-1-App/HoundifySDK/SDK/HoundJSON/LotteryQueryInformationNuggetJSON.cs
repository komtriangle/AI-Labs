/* file "LotteryQueryInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class LotteryQueryInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasLotteryGameInfo;
    private List< LotteryGameInfoJSON  > storeLotteryGameInfo;
    private bool flagHasLastDrawNumbersRequested;
    private bool storeLastDrawNumbersRequested;
    private bool flagHasNextDrawDateRequested;
    private bool storeNextDrawDateRequested;
    private bool flagHasNextDrawJackpotRequested;
    private bool storeNextDrawJackpotRequested;
    private bool flagHasAttribution;
    private AttributionJSON  storeAttribution;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraLotteryGameInfoToJSON()
      {
        JSONArrayValue generated_array_1_LotteryGameInfo = new JSONArrayValue();
        for (int num1 = 0; num1 < storeLotteryGameInfo.Count; ++num1)
          {
            JSONValueHandler handler_LotteryGameInfo = new JSONValueHandler();
            storeLotteryGameInfo[num1].write_as_json(handler_LotteryGameInfo);
            generated_array_1_LotteryGameInfo.appendComponent(handler_LotteryGameInfo.result);
          }
        return generated_array_1_LotteryGameInfo;
      }

    private JSONValue  extraLastDrawNumbersRequestedToJSON()
      {
        JSONValue generated_boolean_LastDrawNumbersRequested = (storeLastDrawNumbersRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_LastDrawNumbersRequested;
      }

    private JSONValue  extraNextDrawDateRequestedToJSON()
      {
        JSONValue generated_boolean_NextDrawDateRequested = (storeNextDrawDateRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_NextDrawDateRequested;
      }

    private JSONValue  extraNextDrawJackpotRequestedToJSON()
      {
        JSONValue generated_boolean_NextDrawJackpotRequested = (storeNextDrawJackpotRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_NextDrawJackpotRequested;
      }

    private JSONValue  extraAttributionToJSON()
      {
        JSONValueHandler handler_Attribution = new JSONValueHandler();
        storeAttribution.write_as_json(handler_Attribution);
        return handler_Attribution.result;
      }


    private void  fromJSONLotteryGameInfo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field LotteryGameInfo of LotteryQueryInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field LotteryGameInfo of LotteryQueryInformationNuggetJSON has too few elements.");
        List< LotteryGameInfoJSON  > vector_LotteryGameInfo1 = new List< LotteryGameInfoJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            LotteryGameInfoJSON convert_classy = LotteryGameInfoJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_LotteryGameInfo1.Add(convert_classy);
          }
        Debug.Assert(vector_LotteryGameInfo1.Count >= 1);
        initLotteryGameInfo();
        for (int num1 = 0; num1 < vector_LotteryGameInfo1.Count; ++num1)
            appendLotteryGameInfo(vector_LotteryGameInfo1[num1]);
        for (int num1 = 0; num1 < vector_LotteryGameInfo1.Count; ++num1)
          {
          }
      }


    private void  fromJSONLastDrawNumbersRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field LastDrawNumbersRequested of LotteryQueryInformationNuggetJSON is not true for false.");
              }
          }
        setLastDrawNumbersRequested(the_bool);
      }


    private void  fromJSONNextDrawDateRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field NextDrawDateRequested of LotteryQueryInformationNuggetJSON is not true for false.");
              }
          }
        setNextDrawDateRequested(the_bool);
      }


    private void  fromJSONNextDrawJackpotRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field NextDrawJackpotRequested of LotteryQueryInformationNuggetJSON is not true for false.");
              }
          }
        setNextDrawJackpotRequested(the_bool);
      }


    private void  fromJSONAttribution(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AttributionJSON convert_classy = AttributionJSON.from_json(json_value, ignore_extras, true);
        setAttribution(convert_classy);
      }


    public LotteryQueryInformationNuggetJSON()
      {
        flagHasLotteryGameInfo = false;
        flagHasLastDrawNumbersRequested = false;
        flagHasNextDrawDateRequested = false;
        flagHasNextDrawJackpotRequested = false;
        flagHasAttribution = false;
        storeLotteryGameInfo = new List< LotteryGameInfoJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "LotteryQueryInformationNugget";
      }

    public bool  hasLotteryGameInfo()
      {
        return flagHasLotteryGameInfo;
      }

    public int  countOfLotteryGameInfo()
      {
        Debug.Assert(flagHasLotteryGameInfo);
        return storeLotteryGameInfo.Count;
      }

    public LotteryGameInfoJSON   elementOfLotteryGameInfo(int element_num)
      {
        Debug.Assert(flagHasLotteryGameInfo);
        return storeLotteryGameInfo[element_num];
      }

    public List< LotteryGameInfoJSON  >  getLotteryGameInfo()
      {
        Debug.Assert(flagHasLotteryGameInfo);
        return storeLotteryGameInfo;
      }

    public bool  hasLastDrawNumbersRequested()
      {
        return flagHasLastDrawNumbersRequested;
      }

    public bool  getLastDrawNumbersRequested()
      {
        Debug.Assert(flagHasLastDrawNumbersRequested);
        return storeLastDrawNumbersRequested;
      }

    public bool  hasNextDrawDateRequested()
      {
        return flagHasNextDrawDateRequested;
      }

    public bool  getNextDrawDateRequested()
      {
        Debug.Assert(flagHasNextDrawDateRequested);
        return storeNextDrawDateRequested;
      }

    public bool  hasNextDrawJackpotRequested()
      {
        return flagHasNextDrawJackpotRequested;
      }

    public bool  getNextDrawJackpotRequested()
      {
        Debug.Assert(flagHasNextDrawJackpotRequested);
        return storeNextDrawJackpotRequested;
      }

    public bool  hasAttribution()
      {
        return flagHasAttribution;
      }

    public AttributionJSON   getAttribution()
      {
        Debug.Assert(flagHasAttribution);
        return storeAttribution;
      }


    public virtual int extraLotteryQueryInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraLotteryQueryInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraLotteryQueryInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraLotteryQueryInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasLotteryGameInfo)
            ++result;
        if (flagHasLastDrawNumbersRequested)
            ++result;
        if (flagHasNextDrawDateRequested)
            ++result;
        if (flagHasNextDrawJackpotRequested)
            ++result;
        if (flagHasAttribution)
            ++result;
        result += extraLotteryQueryInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasLotteryGameInfo)
          {
            if (remainder == 0)
                return "LotteryGameInfo";
            --remainder;
          }
        if (flagHasLastDrawNumbersRequested)
          {
            if (remainder == 0)
                return "LastDrawNumbersRequested";
            --remainder;
          }
        if (flagHasNextDrawDateRequested)
          {
            if (remainder == 0)
                return "NextDrawDateRequested";
            --remainder;
          }
        if (flagHasNextDrawJackpotRequested)
          {
            if (remainder == 0)
                return "NextDrawJackpotRequested";
            --remainder;
          }
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return "Attribution";
            --remainder;
          }
        return extraLotteryQueryInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasLotteryGameInfo)
          {
            if (remainder == 0)
                return extraLotteryGameInfoToJSON();
            --remainder;
          }
        if (flagHasLastDrawNumbersRequested)
          {
            if (remainder == 0)
                return extraLastDrawNumbersRequestedToJSON();
            --remainder;
          }
        if (flagHasNextDrawDateRequested)
          {
            if (remainder == 0)
                return extraNextDrawDateRequestedToJSON();
            --remainder;
          }
        if (flagHasNextDrawJackpotRequested)
          {
            if (remainder == 0)
                return extraNextDrawJackpotRequestedToJSON();
            --remainder;
          }
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return extraAttributionToJSON();
            --remainder;
          }
        return extraLotteryQueryInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "ttribution", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasAttribution ? extraAttributionToJSON() : null);
                break;
            case 'L':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "stDrawNumbersRequested", 0, 22, false) == 0) && (field_name.Length == 24))
                            return (flagHasLastDrawNumbersRequested ? extraLastDrawNumbersRequestedToJSON() : null);
                        break;
                    case 'o':
                        if ((String.Compare(field_name, 2, "tteryGameInfo", 0, 13, false) == 0) && (field_name.Length == 15))
                            return (flagHasLotteryGameInfo ? extraLotteryGameInfoToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if (String.Compare(field_name, 1, "extDraw", 0, 7, false) == 0)
                  {
                    switch (field_name[8])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 9, "ateRequested", 0, 12, false) == 0) && (field_name.Length == 21))
                                return (flagHasNextDrawDateRequested ? extraNextDrawDateRequestedToJSON() : null);
                            break;
                        case 'J':
                            if ((String.Compare(field_name, 9, "ackpotRequested", 0, 15, false) == 0) && (field_name.Length == 24))
                                return (flagHasNextDrawJackpotRequested ? extraNextDrawJackpotRequestedToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraLotteryQueryInformationNuggetLookup(field_name);
      }

    public void initLotteryGameInfo()
      {
        if (flagHasLotteryGameInfo)
          {
            for (int num1 = 0; num1 < storeLotteryGameInfo.Count; ++num1)
              {
              }
          }
        flagHasLotteryGameInfo = true;
        storeLotteryGameInfo.Clear();
      }
    public void appendLotteryGameInfo(LotteryGameInfoJSON  to_append)
      {
        if (!flagHasLotteryGameInfo)
          {
            flagHasLotteryGameInfo = true;
            storeLotteryGameInfo.Clear();
          }
        Debug.Assert(flagHasLotteryGameInfo);
        storeLotteryGameInfo.Add(to_append);
      }
    public void unsetLotteryGameInfo()
      {
        if (flagHasLotteryGameInfo)
          {
            for (int num2 = 0; num2 < storeLotteryGameInfo.Count; ++num2)
              {
              }
          }
        flagHasLotteryGameInfo = false;
        storeLotteryGameInfo.Clear();
      }
    public void setLastDrawNumbersRequested(bool new_value)
      {
        flagHasLastDrawNumbersRequested = true;
        storeLastDrawNumbersRequested = new_value;
      }
    public void unsetLastDrawNumbersRequested()
      {
        flagHasLastDrawNumbersRequested = false;
      }
    public void setNextDrawDateRequested(bool new_value)
      {
        flagHasNextDrawDateRequested = true;
        storeNextDrawDateRequested = new_value;
      }
    public void unsetNextDrawDateRequested()
      {
        flagHasNextDrawDateRequested = false;
      }
    public void setNextDrawJackpotRequested(bool new_value)
      {
        flagHasNextDrawJackpotRequested = true;
        storeNextDrawJackpotRequested = new_value;
      }
    public void unsetNextDrawJackpotRequested()
      {
        flagHasNextDrawJackpotRequested = false;
      }
    public void setAttribution(AttributionJSON  new_value)
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = true;
        storeAttribution = new_value;
      }
    public void unsetAttribution()
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = false;
      }

    public virtual void extraLotteryQueryInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraLotteryQueryInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraLotteryQueryInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraLotteryQueryInformationNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ttribution", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAttribution(new_component, false);
                    return;
                    }
                break;
            case 'L':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "stDrawNumbersRequested", 0, 22, false) == 0) && (key.Length == 24))
                            {
                            fromJSONLastDrawNumbersRequested(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "tteryGameInfo", 0, 13, false) == 0) && (key.Length == 15))
                            {
                            fromJSONLotteryGameInfo(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if (String.Compare(key, 1, "extDraw", 0, 7, false) == 0)
                  {
                    switch (key[8])
                      {
                        case 'D':
                            if ((String.Compare(key, 9, "ateRequested", 0, 12, false) == 0) && (key.Length == 21))
                                {
                                fromJSONNextDrawDateRequested(new_component, false);
                                return;
                                }
                            break;
                        case 'J':
                            if ((String.Compare(key, 9, "ackpotRequested", 0, 15, false) == 0) && (key.Length == 24))
                                {
                                fromJSONNextDrawJackpotRequested(new_component, false);
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
        extraLotteryQueryInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ttribution", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAttribution(new_component, false);
                    return;
                    }
                break;
            case 'L':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "stDrawNumbersRequested", 0, 22, false) == 0) && (key.Length == 24))
                            {
                            fromJSONLastDrawNumbersRequested(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "tteryGameInfo", 0, 13, false) == 0) && (key.Length == 15))
                            {
                            fromJSONLotteryGameInfo(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if (String.Compare(key, 1, "extDraw", 0, 7, false) == 0)
                  {
                    switch (key[8])
                      {
                        case 'D':
                            if ((String.Compare(key, 9, "ateRequested", 0, 12, false) == 0) && (key.Length == 21))
                                {
                                fromJSONNextDrawDateRequested(new_component, false);
                                return;
                                }
                            break;
                        case 'J':
                            if ((String.Compare(key, 9, "ackpotRequested", 0, 15, false) == 0) && (key.Length == 24))
                                {
                                fromJSONNextDrawJackpotRequested(new_component, false);
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
        extraLotteryQueryInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasLotteryGameInfo);
        if (flagHasLotteryGameInfo)
          {
            handler.start_pair("LotteryGameInfo");
            Debug.Assert(storeLotteryGameInfo.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeLotteryGameInfo.Count; ++num1)
              {
                if (partial_allowed)
                    storeLotteryGameInfo[num1].write_partial_as_json(handler);
                else
                    storeLotteryGameInfo[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasLastDrawNumbersRequested);
        if (flagHasLastDrawNumbersRequested)
          {
            handler.start_pair("LastDrawNumbersRequested");
            handler.boolean_value(storeLastDrawNumbersRequested);
          }
        Debug.Assert(partial_allowed || flagHasNextDrawDateRequested);
        if (flagHasNextDrawDateRequested)
          {
            handler.start_pair("NextDrawDateRequested");
            handler.boolean_value(storeNextDrawDateRequested);
          }
        Debug.Assert(partial_allowed || flagHasNextDrawJackpotRequested);
        if (flagHasNextDrawJackpotRequested)
          {
            handler.start_pair("NextDrawJackpotRequested");
            handler.boolean_value(storeNextDrawJackpotRequested);
          }
        if (flagHasAttribution)
          {
            handler.start_pair("Attribution");
            if (partial_allowed)
                storeAttribution.write_partial_as_json(handler);
            else
                storeAttribution.write_as_json(handler);
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
        if (!(hasLotteryGameInfo()))
          {
            return "When parsing the object for %what%, the \"LotteryGameInfo\" field was missing.";
          }
        if (!(hasLastDrawNumbersRequested()))
          {
            return "When parsing the object for %what%, the \"LastDrawNumbersRequested\" field was missing.";
          }
        if (!(hasNextDrawDateRequested()))
          {
            return "When parsing the object for %what%, the \"NextDrawDateRequested\" field was missing.";
          }
        if (!(hasNextDrawJackpotRequested()))
          {
            return "When parsing the object for %what%, the \"NextDrawJackpotRequested\" field was missing.";
          }
        return null;
      }

    public static new LotteryQueryInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LotteryQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LotteryQueryInformationNugget", ignore_extras);
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
    public static new LotteryQueryInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new LotteryQueryInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LotteryQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LotteryQueryInformationNugget", ignore_extras);
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
    public static new LotteryQueryInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new LotteryQueryInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        LotteryQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LotteryQueryInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for LotteryQueryInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new LotteryQueryInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        LotteryQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LotteryQueryInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private LotteryGameInfoJSON.HoldingArrayGenerator fieldGeneratorLotteryGameInfo;
        private JSONHoldingBooleanGenerator fieldGeneratorLastDrawNumbersRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorNextDrawDateRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorNextDrawJackpotRequested;
        private AttributionJSON.HoldingGenerator fieldGeneratorAttribution;
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
            if (!(getInformationNuggetJSONKey().Equals("LotteryQueryInformationNugget")))
                throw new Exception("The key field has a value other than `LotteryQueryInformationNugget'.");
            LotteryQueryInformationNuggetJSON result = new LotteryQueryInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraLotteryQueryInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((LotteryQueryInformationNuggetJSON )new_result);
          }
        protected void finish(LotteryQueryInformationNuggetJSON result)
          {
            if (fieldGeneratorLotteryGameInfo.have_value)
              {
                result.initLotteryGameInfo();
                int count = fieldGeneratorLotteryGameInfo.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendLotteryGameInfo(fieldGeneratorLotteryGameInfo.value[num]);
                  }
                fieldGeneratorLotteryGameInfo.value.Clear();
                fieldGeneratorLotteryGameInfo.have_value = false;
              }
            else if ((!(result.hasLotteryGameInfo())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LotteryGameInfo\" field was missing.");
              }
            if (fieldGeneratorLastDrawNumbersRequested.have_value)
              {
                result.setLastDrawNumbersRequested(fieldGeneratorLastDrawNumbersRequested.value);
                fieldGeneratorLastDrawNumbersRequested.have_value = false;
              }
            else if ((!(result.hasLastDrawNumbersRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LastDrawNumbersRequested\" field was missing.");
              }
            if (fieldGeneratorNextDrawDateRequested.have_value)
              {
                result.setNextDrawDateRequested(fieldGeneratorNextDrawDateRequested.value);
                fieldGeneratorNextDrawDateRequested.have_value = false;
              }
            else if ((!(result.hasNextDrawDateRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NextDrawDateRequested\" field was missing.");
              }
            if (fieldGeneratorNextDrawJackpotRequested.have_value)
              {
                result.setNextDrawJackpotRequested(fieldGeneratorNextDrawJackpotRequested.value);
                fieldGeneratorNextDrawJackpotRequested.have_value = false;
              }
            else if ((!(result.hasNextDrawJackpotRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NextDrawJackpotRequested\" field was missing.");
              }
            if (fieldGeneratorAttribution.have_value)
              {
                result.setAttribution(fieldGeneratorAttribution.value);
                fieldGeneratorAttribution.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(LotteryQueryInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttribution", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorAttribution;
                    break;
                case 'L':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "stDrawNumbersRequested", 0, 22, false) == 0) && (field_name.Length == 24))
                                return fieldGeneratorLastDrawNumbersRequested;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "tteryGameInfo", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorLotteryGameInfo;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'N':
                    if (String.Compare(field_name, 1, "extDraw", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 9, "ateRequested", 0, 12, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorNextDrawDateRequested;
                                break;
                            case 'J':
                                if ((String.Compare(field_name, 9, "ackpotRequested", 0, 15, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorNextDrawJackpotRequested;
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
            fieldGeneratorLotteryGameInfo = new LotteryGameInfoJSON.HoldingArrayGenerator("field \"LotteryGameInfo\" of the LotteryQueryInformationNugget class", ignore_extras);
            fieldGeneratorLastDrawNumbersRequested = new JSONHoldingBooleanGenerator("field \"LastDrawNumbersRequested\" of the LotteryQueryInformationNugget class");
            fieldGeneratorNextDrawDateRequested = new JSONHoldingBooleanGenerator("field \"NextDrawDateRequested\" of the LotteryQueryInformationNugget class");
            fieldGeneratorNextDrawJackpotRequested = new JSONHoldingBooleanGenerator("field \"NextDrawJackpotRequested\" of the LotteryQueryInformationNugget class");
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the LotteryQueryInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the LotteryQueryInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorLotteryGameInfo = new LotteryGameInfoJSON.HoldingArrayGenerator("field \"LotteryGameInfo\" of the LotteryQueryInformationNugget class", false);
            fieldGeneratorLastDrawNumbersRequested = new JSONHoldingBooleanGenerator("field \"LastDrawNumbersRequested\" of the LotteryQueryInformationNugget class");
            fieldGeneratorNextDrawDateRequested = new JSONHoldingBooleanGenerator("field \"NextDrawDateRequested\" of the LotteryQueryInformationNugget class");
            fieldGeneratorNextDrawJackpotRequested = new JSONHoldingBooleanGenerator("field \"NextDrawJackpotRequested\" of the LotteryQueryInformationNugget class");
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the LotteryQueryInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the LotteryQueryInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorLotteryGameInfo.reset();
            fieldGeneratorLastDrawNumbersRequested.reset();
            fieldGeneratorNextDrawDateRequested.reset();
            fieldGeneratorNextDrawJackpotRequested.reset();
            fieldGeneratorAttribution.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(LotteryQueryInformationNuggetJSON  result)
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
        public LotteryQueryInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(LotteryQueryInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<LotteryQueryInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<LotteryQueryInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<LotteryQueryInformationNuggetJSON>();
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
    public List<LotteryQueryInformationNuggetJSON> value;
  };
  };
