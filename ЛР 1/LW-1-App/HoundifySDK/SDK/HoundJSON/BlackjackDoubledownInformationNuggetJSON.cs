/* file "BlackjackDoubledownInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BlackjackDoubledownInformationNuggetJSON : BlackjackInformationNuggetJSON
  {
    private bool flagHasImageURL;
    private string storeImageURL;
    private bool flagHasBankroll;
    private double storeBankroll;
    private string textStoreBankroll;
    private bool flagHasPlayerHand;
    private BlackjackHandJSON  storePlayerHand;
    private bool flagHasPlayerHandTotal;
    private sbyte storePlayerHandTotal;
    private bool flagHasDealerHand;
    private BlackjackHandJSON  storeDealerHand;
    private bool flagHasDealerHandTotal;
    private sbyte storeDealerHandTotal;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraImageURLToJSON()
      {
        JSONStringValue generated_string_ImageURL = new JSONStringValue(storeImageURL);
        return generated_string_ImageURL;
      }

    private JSONValue  extraBankrollToJSON()
      {
        JSONValue generated_rational_Bankroll;
        if (textStoreBankroll != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreBankroll);
            generated_rational_Bankroll = handler.result;
          }
        else if (((double)(long)storeBankroll) == storeBankroll)
            generated_rational_Bankroll = new JSONIntegerValue((long)(storeBankroll));
        else
            generated_rational_Bankroll = new JSONRationalValue(storeBankroll, 15);
        return generated_rational_Bankroll;
      }

    private JSONValue  extraPlayerHandToJSON()
      {
        JSONValueHandler handler_PlayerHand = new JSONValueHandler();
        storePlayerHand.write_as_json(handler_PlayerHand);
        return handler_PlayerHand.result;
      }

    private JSONValue  extraPlayerHandTotalToJSON()
      {
        JSONIntegerValue generated_integer_PlayerHandTotal = new JSONIntegerValue(storePlayerHandTotal);
        return generated_integer_PlayerHandTotal;
      }

    private JSONValue  extraDealerHandToJSON()
      {
        JSONValueHandler handler_DealerHand = new JSONValueHandler();
        storeDealerHand.write_as_json(handler_DealerHand);
        return handler_DealerHand.result;
      }

    private JSONValue  extraDealerHandTotalToJSON()
      {
        JSONIntegerValue generated_integer_DealerHandTotal = new JSONIntegerValue(storeDealerHandTotal);
        return generated_integer_DealerHandTotal;
      }


    private void  fromJSONImageURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ImageURL of BlackjackDoubledownInformationNuggetJSON is not a string.");
        setImageURL(json_string.getData());
      }


    private void  fromJSONBankroll(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Bankroll of BlackjackDoubledownInformationNuggetJSON is not a number.");
              }
          }
        setBankrollText(the_rational_text);
      }


    private void  fromJSONPlayerHand(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BlackjackHandJSON convert_classy = BlackjackHandJSON.from_json(json_value, ignore_extras, true);
        setPlayerHand(convert_classy);
      }


    private void  fromJSONPlayerHandTotal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field PlayerHandTotal of BlackjackDoubledownInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PlayerHandTotal of BlackjackDoubledownInformationNuggetJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setPlayerHandTotal(extracted_integer);
      }


    private void  fromJSONDealerHand(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BlackjackHandJSON convert_classy = BlackjackHandJSON.from_json(json_value, ignore_extras, true);
        setDealerHand(convert_classy);
      }


    private void  fromJSONDealerHandTotal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DealerHandTotal of BlackjackDoubledownInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DealerHandTotal of BlackjackDoubledownInformationNuggetJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setDealerHandTotal(extracted_integer);
      }


    public BlackjackDoubledownInformationNuggetJSON()
      {
        flagHasImageURL = false;
        flagHasBankroll = false;
        flagHasPlayerHand = false;
        flagHasPlayerHandTotal = false;
        flagHasDealerHand = false;
        flagHasDealerHandTotal = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getBlackjackNuggetKind()
      {
        return "BlackjackDoubledownCommand";
      }

    public bool  hasImageURL()
      {
        return flagHasImageURL;
      }

    public string  getImageURL()
      {
        Debug.Assert(flagHasImageURL);
        return storeImageURL;
      }

    public bool  hasBankroll()
      {
        return flagHasBankroll;
      }

    public double  getBankroll()
      {
        Debug.Assert(flagHasBankroll);
        if (textStoreBankroll != "")
          {
            return Double.Parse(textStoreBankroll);
          }
        return storeBankroll;
      }

    public string  getBankrollAsText()
      {
        Debug.Assert(flagHasBankroll);
        if (textStoreBankroll == "")
          {
            return Convert.ToString(storeBankroll);
          }
        else
          {
            return (textStoreBankroll);
          }
      }

    public bool  hasPlayerHand()
      {
        return flagHasPlayerHand;
      }

    public BlackjackHandJSON   getPlayerHand()
      {
        Debug.Assert(flagHasPlayerHand);
        return storePlayerHand;
      }

    public bool  hasPlayerHandTotal()
      {
        return flagHasPlayerHandTotal;
      }

    public sbyte  getPlayerHandTotal()
      {
        Debug.Assert(flagHasPlayerHandTotal);
        return storePlayerHandTotal;
      }

    public bool  hasDealerHand()
      {
        return flagHasDealerHand;
      }

    public BlackjackHandJSON   getDealerHand()
      {
        Debug.Assert(flagHasDealerHand);
        return storeDealerHand;
      }

    public bool  hasDealerHandTotal()
      {
        return flagHasDealerHandTotal;
      }

    public sbyte  getDealerHandTotal()
      {
        Debug.Assert(flagHasDealerHandTotal);
        return storeDealerHandTotal;
      }


    public virtual int extraBlackjackDoubledownInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBlackjackDoubledownInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBlackjackDoubledownInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBlackjackDoubledownInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraBlackjackInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasImageURL)
            ++result;
        if (flagHasBankroll)
            ++result;
        if (flagHasPlayerHand)
            ++result;
        if (flagHasPlayerHandTotal)
            ++result;
        if (flagHasDealerHand)
            ++result;
        if (flagHasDealerHandTotal)
            ++result;
        result += extraBlackjackDoubledownInformationNuggetComponentCount();
        return result;
      }
    public override string extraBlackjackInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasImageURL)
          {
            if (remainder == 0)
                return "ImageURL";
            --remainder;
          }
        if (flagHasBankroll)
          {
            if (remainder == 0)
                return "Bankroll";
            --remainder;
          }
        if (flagHasPlayerHand)
          {
            if (remainder == 0)
                return "PlayerHand";
            --remainder;
          }
        if (flagHasPlayerHandTotal)
          {
            if (remainder == 0)
                return "PlayerHandTotal";
            --remainder;
          }
        if (flagHasDealerHand)
          {
            if (remainder == 0)
                return "DealerHand";
            --remainder;
          }
        if (flagHasDealerHandTotal)
          {
            if (remainder == 0)
                return "DealerHandTotal";
            --remainder;
          }
        return extraBlackjackDoubledownInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraBlackjackInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasImageURL)
          {
            if (remainder == 0)
                return extraImageURLToJSON();
            --remainder;
          }
        if (flagHasBankroll)
          {
            if (remainder == 0)
                return extraBankrollToJSON();
            --remainder;
          }
        if (flagHasPlayerHand)
          {
            if (remainder == 0)
                return extraPlayerHandToJSON();
            --remainder;
          }
        if (flagHasPlayerHandTotal)
          {
            if (remainder == 0)
                return extraPlayerHandTotalToJSON();
            --remainder;
          }
        if (flagHasDealerHand)
          {
            if (remainder == 0)
                return extraDealerHandToJSON();
            --remainder;
          }
        if (flagHasDealerHandTotal)
          {
            if (remainder == 0)
                return extraDealerHandTotalToJSON();
            --remainder;
          }
        return extraBlackjackDoubledownInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraBlackjackInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'B':
                if ((String.Compare(field_name, 1, "ankroll", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasBankroll ? extraBankrollToJSON() : null);
                break;
            case 'D':
                if (String.Compare(field_name, 1, "ealerHand", 0, 9, false) == 0)
                  {
                    if (field_name.Length == 10)
                      {
                        return (flagHasDealerHand ? extraDealerHandToJSON() : null);
                      }
                    switch (field_name[10])
                      {
                        case 'T':
                            if ((String.Compare(field_name, 11, "otal", 0, 4, false) == 0) && (field_name.Length == 15))
                                return (flagHasDealerHandTotal ? extraDealerHandTotalToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "mageURL", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasImageURL ? extraImageURLToJSON() : null);
                break;
            case 'P':
                if (String.Compare(field_name, 1, "layerHand", 0, 9, false) == 0)
                  {
                    if (field_name.Length == 10)
                      {
                        return (flagHasPlayerHand ? extraPlayerHandToJSON() : null);
                      }
                    switch (field_name[10])
                      {
                        case 'T':
                            if ((String.Compare(field_name, 11, "otal", 0, 4, false) == 0) && (field_name.Length == 15))
                                return (flagHasPlayerHandTotal ? extraPlayerHandTotalToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraBlackjackDoubledownInformationNuggetLookup(field_name);
      }

    public void setImageURL(string new_value)
      {
        flagHasImageURL = true;
        storeImageURL = new_value;
      }
    public void unsetImageURL()
      {
        flagHasImageURL = false;
      }
    public void setBankroll(double new_value)
      {
        flagHasBankroll = true;
        if (new_value < 0)
            throw new Exception("The value for field Bankroll of BlackjackDoubledownInformationNuggetJSON is less than the lower bound (0) for that field.");
        storeBankroll = new_value;
        textStoreBankroll = "";
      }
    public void setBankrollText(string new_value)
      {
        flagHasBankroll = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Bankroll of BlackjackDoubledownInformationNuggetJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field Bankroll of BlackjackDoubledownInformationNuggetJSON is less than the lower bound (0) for that field.");
        textStoreBankroll = new_value;
      }
    public void unsetBankroll()
      {
        flagHasBankroll = false;
      }
    public void setPlayerHand(BlackjackHandJSON  new_value)
      {
        if (flagHasPlayerHand)
          {
          }
        flagHasPlayerHand = true;
        storePlayerHand = new_value;
      }
    public void unsetPlayerHand()
      {
        if (flagHasPlayerHand)
          {
          }
        flagHasPlayerHand = false;
      }
    public void setPlayerHandTotal(sbyte new_value)
      {
        flagHasPlayerHandTotal = true;
        if (new_value < 6)
            throw new Exception("The value for field PlayerHandTotal of BlackjackDoubledownInformationNuggetJSON is less than the lower bound (6) for that field.");
        if (new_value > 30)
            throw new Exception("The value for field PlayerHandTotal of BlackjackDoubledownInformationNuggetJSON is greater than the upper bound (30) for that field.");
        storePlayerHandTotal = new_value;
      }
    public void unsetPlayerHandTotal()
      {
        flagHasPlayerHandTotal = false;
      }
    public void setDealerHand(BlackjackHandJSON  new_value)
      {
        if (flagHasDealerHand)
          {
          }
        flagHasDealerHand = true;
        storeDealerHand = new_value;
      }
    public void unsetDealerHand()
      {
        if (flagHasDealerHand)
          {
          }
        flagHasDealerHand = false;
      }
    public void setDealerHandTotal(sbyte new_value)
      {
        flagHasDealerHandTotal = true;
        if (new_value < 4)
            throw new Exception("The value for field DealerHandTotal of BlackjackDoubledownInformationNuggetJSON is less than the lower bound (4) for that field.");
        if (new_value > 26)
            throw new Exception("The value for field DealerHandTotal of BlackjackDoubledownInformationNuggetJSON is greater than the upper bound (26) for that field.");
        storeDealerHandTotal = new_value;
      }
    public void unsetDealerHandTotal()
      {
        flagHasDealerHandTotal = false;
      }

    public virtual void extraBlackjackDoubledownInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBlackjackDoubledownInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBlackjackDoubledownInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraBlackjackDoubledownInformationNuggetAppendPair(key, new_component);
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
    public override void extraBlackjackInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'B':
                if ((String.Compare(key, 1, "ankroll", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONBankroll(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if (String.Compare(key, 1, "ealerHand", 0, 9, false) == 0)
                  {
                    if (key.Length == 10)
                      {
                        {
                        fromJSONDealerHand(new_component, false);
                        return;
                        }
                      }
                    switch (key[10])
                      {
                        case 'T':
                            if ((String.Compare(key, 11, "otal", 0, 4, false) == 0) && (key.Length == 15))
                                {
                                fromJSONDealerHandTotal(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if ((String.Compare(key, 1, "mageURL", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONImageURL(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if (String.Compare(key, 1, "layerHand", 0, 9, false) == 0)
                  {
                    if (key.Length == 10)
                      {
                        {
                        fromJSONPlayerHand(new_component, false);
                        return;
                        }
                      }
                    switch (key[10])
                      {
                        case 'T':
                            if ((String.Compare(key, 11, "otal", 0, 4, false) == 0) && (key.Length == 15))
                                {
                                fromJSONPlayerHandTotal(new_component, false);
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
        extraBlackjackDoubledownInformationNuggetAppendPair(key, new_component);
      }
    public override void extraBlackjackInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'B':
                if ((String.Compare(key, 1, "ankroll", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONBankroll(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if (String.Compare(key, 1, "ealerHand", 0, 9, false) == 0)
                  {
                    if (key.Length == 10)
                      {
                        {
                        fromJSONDealerHand(new_component, false);
                        return;
                        }
                      }
                    switch (key[10])
                      {
                        case 'T':
                            if ((String.Compare(key, 11, "otal", 0, 4, false) == 0) && (key.Length == 15))
                                {
                                fromJSONDealerHandTotal(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if ((String.Compare(key, 1, "mageURL", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONImageURL(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if (String.Compare(key, 1, "layerHand", 0, 9, false) == 0)
                  {
                    if (key.Length == 10)
                      {
                        {
                        fromJSONPlayerHand(new_component, false);
                        return;
                        }
                      }
                    switch (key[10])
                      {
                        case 'T':
                            if ((String.Compare(key, 11, "otal", 0, 4, false) == 0) && (key.Length == 15))
                                {
                                fromJSONPlayerHandTotal(new_component, false);
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
        extraBlackjackDoubledownInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasImageURL);
        if (flagHasImageURL)
          {
            handler.start_pair("ImageURL");
            handler.string_value(storeImageURL);
          }
        Debug.Assert(partial_allowed || flagHasBankroll);
        if (flagHasBankroll)
          {
            handler.start_pair("Bankroll");
            if (textStoreBankroll != "")
                handler.number_value(textStoreBankroll);
            else if (((double)(long)storeBankroll) == storeBankroll)
                handler.number_value((long)storeBankroll);
            else
                handler.number_value(storeBankroll);
          }
        Debug.Assert(partial_allowed || flagHasPlayerHand);
        if (flagHasPlayerHand)
          {
            handler.start_pair("PlayerHand");
            if (partial_allowed)
                storePlayerHand.write_partial_as_json(handler);
            else
                storePlayerHand.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasPlayerHandTotal);
        if (flagHasPlayerHandTotal)
          {
            handler.start_pair("PlayerHandTotal");
            handler.number_value(storePlayerHandTotal);
          }
        Debug.Assert(partial_allowed || flagHasDealerHand);
        if (flagHasDealerHand)
          {
            handler.start_pair("DealerHand");
            if (partial_allowed)
                storeDealerHand.write_partial_as_json(handler);
            else
                storeDealerHand.write_as_json(handler);
          }
        if (flagHasDealerHandTotal)
          {
            handler.start_pair("DealerHandTotal");
            handler.number_value(storeDealerHandTotal);
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
        if (!(hasImageURL()))
          {
            return "When parsing the object for %what%, the \"ImageURL\" field was missing.";
          }
        if (!(hasBankroll()))
          {
            return "When parsing the object for %what%, the \"Bankroll\" field was missing.";
          }
        if (!(hasPlayerHand()))
          {
            return "When parsing the object for %what%, the \"PlayerHand\" field was missing.";
          }
        if (!(hasPlayerHandTotal()))
          {
            return "When parsing the object for %what%, the \"PlayerHandTotal\" field was missing.";
          }
        if (!(hasDealerHand()))
          {
            return "When parsing the object for %what%, the \"DealerHand\" field was missing.";
          }
        return null;
      }

    public static new BlackjackDoubledownInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BlackjackDoubledownInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BlackjackDoubledownInformationNugget", ignore_extras);
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
    public static new BlackjackDoubledownInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BlackjackDoubledownInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BlackjackDoubledownInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BlackjackDoubledownInformationNugget", ignore_extras);
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
    public static new BlackjackDoubledownInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BlackjackDoubledownInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        BlackjackDoubledownInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BlackjackDoubledownInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BlackjackDoubledownInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new BlackjackDoubledownInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BlackjackDoubledownInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BlackjackDoubledownInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : BlackjackInformationNuggetJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorImageURL;
        private JSONHoldingNumberTextGenerator fieldGeneratorBankroll;
        private BlackjackHandJSON.HoldingGenerator fieldGeneratorPlayerHand;
    private class FieldHoldingGeneratorPlayerHandTotal : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorPlayerHandTotal(String what) : base(what, 6, 30)
              {
              }
          };
    private class FieldHoldingArrayGeneratorPlayerHandTotal : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorPlayerHandTotal(String what) : base(what, 6, 30)
              {
              }
          };
        private FieldHoldingGeneratorPlayerHandTotal fieldGeneratorPlayerHandTotal;
        private BlackjackHandJSON.HoldingGenerator fieldGeneratorDealerHand;
    private class FieldHoldingGeneratorDealerHandTotal : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorDealerHandTotal(String what) : base(what, 4, 26)
              {
              }
          };
    private class FieldHoldingArrayGeneratorDealerHandTotal : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorDealerHandTotal(String what) : base(what, 4, 26)
              {
              }
          };
        private FieldHoldingGeneratorDealerHandTotal fieldGeneratorDealerHandTotal;
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
            if (!(getBlackjackInformationNuggetJSONKey().Equals("BlackjackDoubledownCommand")))
                throw new Exception("The key field has a value other than `BlackjackDoubledownCommand'.");
            BlackjackDoubledownInformationNuggetJSON result = new BlackjackDoubledownInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBlackjackDoubledownInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(BlackjackInformationNuggetJSON new_result)
          {
            handle_result((BlackjackDoubledownInformationNuggetJSON )new_result);
          }
        protected void finish(BlackjackDoubledownInformationNuggetJSON result)
          {
            if (fieldGeneratorImageURL.have_value)
              {
                result.setImageURL(fieldGeneratorImageURL.value);
                fieldGeneratorImageURL.have_value = false;
              }
            else if ((!(result.hasImageURL())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ImageURL\" field was missing.");
              }
            if (fieldGeneratorBankroll.have_value)
              {
                result.setBankrollText(fieldGeneratorBankroll.value);
                fieldGeneratorBankroll.have_value = false;
              }
            else if ((!(result.hasBankroll())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Bankroll\" field was missing.");
              }
            if (fieldGeneratorPlayerHand.have_value)
              {
                result.setPlayerHand(fieldGeneratorPlayerHand.value);
                fieldGeneratorPlayerHand.have_value = false;
              }
            else if ((!(result.hasPlayerHand())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PlayerHand\" field was missing.");
              }
            if (fieldGeneratorPlayerHandTotal.have_value)
              {
                result.setPlayerHandTotal((sbyte)(fieldGeneratorPlayerHandTotal.value));
                fieldGeneratorPlayerHandTotal.have_value = false;
              }
            else if ((!(result.hasPlayerHandTotal())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PlayerHandTotal\" field was missing.");
              }
            if (fieldGeneratorDealerHand.have_value)
              {
                result.setDealerHand(fieldGeneratorDealerHand.value);
                fieldGeneratorDealerHand.have_value = false;
              }
            else if ((!(result.hasDealerHand())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DealerHand\" field was missing.");
              }
            if (fieldGeneratorDealerHandTotal.have_value)
              {
                result.setDealerHandTotal((sbyte)(fieldGeneratorDealerHandTotal.value));
                fieldGeneratorDealerHandTotal.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(BlackjackDoubledownInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "ankroll", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorBankroll;
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "ealerHand", 0, 9, false) == 0)
                      {
                        if (field_name.Length == 10)
                          {
                            return fieldGeneratorDealerHand;
                          }
                        switch (field_name[10])
                          {
                            case 'T':
                                if ((String.Compare(field_name, 11, "otal", 0, 4, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorDealerHandTotal;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "mageURL", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorImageURL;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "layerHand", 0, 9, false) == 0)
                      {
                        if (field_name.Length == 10)
                          {
                            return fieldGeneratorPlayerHand;
                          }
                        switch (field_name[10])
                          {
                            case 'T':
                                if ((String.Compare(field_name, 11, "otal", 0, 4, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorPlayerHandTotal;
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
            fieldGeneratorImageURL = new JSONHoldingStringGenerator("field \"ImageURL\" of the BlackjackDoubledownInformationNugget class");
            fieldGeneratorBankroll = new JSONHoldingNumberTextGenerator("field \"Bankroll\" of the BlackjackDoubledownInformationNugget class");
            fieldGeneratorPlayerHand = new BlackjackHandJSON.HoldingGenerator("field \"PlayerHand\" of the BlackjackDoubledownInformationNugget class", ignore_extras);
            fieldGeneratorPlayerHandTotal = new FieldHoldingGeneratorPlayerHandTotal("field \"PlayerHandTotal\" of the BlackjackDoubledownInformationNugget class");
            fieldGeneratorDealerHand = new BlackjackHandJSON.HoldingGenerator("field \"DealerHand\" of the BlackjackDoubledownInformationNugget class", ignore_extras);
            fieldGeneratorDealerHandTotal = new FieldHoldingGeneratorDealerHandTotal("field \"DealerHandTotal\" of the BlackjackDoubledownInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BlackjackDoubledownInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorImageURL = new JSONHoldingStringGenerator("field \"ImageURL\" of the BlackjackDoubledownInformationNugget class");
            fieldGeneratorBankroll = new JSONHoldingNumberTextGenerator("field \"Bankroll\" of the BlackjackDoubledownInformationNugget class");
            fieldGeneratorPlayerHand = new BlackjackHandJSON.HoldingGenerator("field \"PlayerHand\" of the BlackjackDoubledownInformationNugget class", false);
            fieldGeneratorPlayerHandTotal = new FieldHoldingGeneratorPlayerHandTotal("field \"PlayerHandTotal\" of the BlackjackDoubledownInformationNugget class");
            fieldGeneratorDealerHand = new BlackjackHandJSON.HoldingGenerator("field \"DealerHand\" of the BlackjackDoubledownInformationNugget class", false);
            fieldGeneratorDealerHandTotal = new FieldHoldingGeneratorDealerHandTotal("field \"DealerHandTotal\" of the BlackjackDoubledownInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BlackjackDoubledownInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorImageURL.reset();
            fieldGeneratorBankroll.reset();
            fieldGeneratorPlayerHand.reset();
            fieldGeneratorPlayerHandTotal.reset();
            fieldGeneratorDealerHand.reset();
            fieldGeneratorDealerHandTotal.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(BlackjackDoubledownInformationNuggetJSON  result)
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
        public BlackjackDoubledownInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BlackjackDoubledownInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<BlackjackDoubledownInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BlackjackDoubledownInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BlackjackDoubledownInformationNuggetJSON>();
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
    public List<BlackjackDoubledownInformationNuggetJSON> value;
  };
  };
