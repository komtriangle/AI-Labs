/* file "BlackjackNotUnderstoodCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BlackjackNotUnderstoodCommandJSON : BlackjackCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        private bool flagHasImageURL;
        private string storeImageURL;
        private bool flagHasBankroll;
        private double storeBankroll;
        private string textStoreBankroll;
        private bool flagHasBetAmount;
        private double storeBetAmount;
        private string textStoreBetAmount;
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


        private void  fromJSONImageURL(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ImageURL of TypeNativeDataJSON is not a string.");
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
                    throw new Exception("The value for field Bankroll of TypeNativeDataJSON is not a number.");
                  }
              }
            setBankrollText(the_rational_text);
          }


        private void  fromJSONBetAmount(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field BetAmount of TypeNativeDataJSON is not a number.");
                  }
              }
            setBetAmountText(the_rational_text);
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
                    throw new Exception("The value for field PlayerHandTotal of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field PlayerHandTotal of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
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
                    throw new Exception("The value for field DealerHandTotal of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field DealerHandTotal of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setDealerHandTotal(extracted_integer);
          }


        public TypeNativeDataJSON()
          {
            flagHasImageURL = false;
            flagHasBankroll = false;
            flagHasBetAmount = false;
            flagHasPlayerHand = false;
            flagHasPlayerHandTotal = false;
            flagHasDealerHand = false;
            flagHasDealerHandTotal = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
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

        public bool  hasBetAmount()
          {
            return flagHasBetAmount;
          }

        public double  getBetAmount()
          {
            Debug.Assert(flagHasBetAmount);
            if (textStoreBetAmount != "")
              {
                return Double.Parse(textStoreBetAmount);
              }
            return storeBetAmount;
          }

        public string  getBetAmountAsText()
          {
            Debug.Assert(flagHasBetAmount);
            if (textStoreBetAmount == "")
              {
                return Convert.ToString(storeBetAmount);
              }
            else
              {
                return (textStoreBetAmount);
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


        public virtual int extraTypeNativeDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNativeDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNativeDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNativeDataLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
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
                throw new Exception("The value for field Bankroll of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeBankroll = new_value;
            textStoreBankroll = "";
          }
        public void setBankrollText(string new_value)
          {
            flagHasBankroll = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Bankroll of TypeNativeDataJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field Bankroll of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            textStoreBankroll = new_value;
          }
        public void unsetBankroll()
          {
            flagHasBankroll = false;
          }
        public void setBetAmount(double new_value)
          {
            flagHasBetAmount = true;
            storeBetAmount = new_value;
            textStoreBetAmount = "";
          }
        public void setBetAmountText(string new_value)
          {
            flagHasBetAmount = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field BetAmount of TypeNativeDataJSON is not a valid number.");
            textStoreBetAmount = new_value;
          }
        public void unsetBetAmount()
          {
            flagHasBetAmount = false;
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
            if (new_value < 4)
                throw new Exception("The value for field PlayerHandTotal of TypeNativeDataJSON is less than the lower bound (4) for that field.");
            if (new_value > 20)
                throw new Exception("The value for field PlayerHandTotal of TypeNativeDataJSON is greater than the upper bound (20) for that field.");
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
            if (new_value < 2)
                throw new Exception("The value for field DealerHandTotal of TypeNativeDataJSON is less than the lower bound (2) for that field.");
            if (new_value > 11)
                throw new Exception("The value for field DealerHandTotal of TypeNativeDataJSON is greater than the upper bound (11) for that field.");
            storeDealerHandTotal = new_value;
          }
        public void unsetDealerHandTotal()
          {
            flagHasDealerHandTotal = false;
          }

        public virtual void extraTypeNativeDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNativeDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNativeDataLookup(key);
            if (old_field == null)
              {
                extraTypeNativeDataAppendPair(key, new_component);
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
            if (flagHasBetAmount)
              {
                handler.start_pair("BetAmount");
                if (textStoreBetAmount != "")
                    handler.number_value(textStoreBetAmount);
                else if (((double)(long)storeBetAmount) == storeBetAmount)
                    handler.number_value((long)storeBetAmount);
                else
                    handler.number_value(storeBetAmount);
              }
            if (flagHasPlayerHand)
              {
                handler.start_pair("PlayerHand");
                if (partial_allowed)
                    storePlayerHand.write_partial_as_json(handler);
                else
                    storePlayerHand.write_as_json(handler);
              }
            if (flagHasPlayerHandTotal)
              {
                handler.start_pair("PlayerHandTotal");
                handler.number_value(storePlayerHandTotal);
              }
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
        public virtual string missing_field_error(bool allow_unpolished)
          {
            if (!(hasImageURL()))
              {
                return "When parsing the object for %what%, the \"ImageURL\" field was missing.";
              }
            if (!(hasBankroll()))
              {
                return "When parsing the object for %what%, the \"Bankroll\" field was missing.";
              }
            return null;
          }

        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_text(string text, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNativeDataJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorImageURL;
            private JSONHoldingNumberTextGenerator fieldGeneratorBankroll;
            private JSONHoldingNumberTextGenerator fieldGeneratorBetAmount;
            private BlackjackHandJSON.HoldingGenerator fieldGeneratorPlayerHand;
        private class FieldHoldingGeneratorPlayerHandTotal : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorPlayerHandTotal(String what) : base(what, 4, 20)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorPlayerHandTotal : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorPlayerHandTotal(String what) : base(what, 4, 20)
                  {
                  }
              };
            private FieldHoldingGeneratorPlayerHandTotal fieldGeneratorPlayerHandTotal;
            private BlackjackHandJSON.HoldingGenerator fieldGeneratorDealerHand;
        private class FieldHoldingGeneratorDealerHandTotal : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorDealerHandTotal(String what) : base(what, 2, 11)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorDealerHandTotal : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorDealerHandTotal(String what) : base(what, 2, 11)
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
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
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
                if (fieldGeneratorBetAmount.have_value)
                  {
                    result.setBetAmountText(fieldGeneratorBetAmount.value);
                    fieldGeneratorBetAmount.have_value = false;
                  }
                if (fieldGeneratorPlayerHand.have_value)
                  {
                    result.setPlayerHand(fieldGeneratorPlayerHand.value);
                    fieldGeneratorPlayerHand.have_value = false;
                  }
                if (fieldGeneratorPlayerHandTotal.have_value)
                  {
                    result.setPlayerHandTotal((sbyte)(fieldGeneratorPlayerHandTotal.value));
                    fieldGeneratorPlayerHandTotal.have_value = false;
                  }
                if (fieldGeneratorDealerHand.have_value)
                  {
                    result.setDealerHand(fieldGeneratorDealerHand.value);
                    fieldGeneratorDealerHand.have_value = false;
                  }
                if (fieldGeneratorDealerHandTotal.have_value)
                  {
                    result.setDealerHandTotal((sbyte)(fieldGeneratorDealerHandTotal.value));
                    fieldGeneratorDealerHandTotal.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'B':
                        switch (field_name[1])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 2, "nkroll", 0, 6, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorBankroll;
                                break;
                            case 'e':
                                if ((String.Compare(field_name, 2, "tAmount", 0, 7, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorBetAmount;
                                break;
                            default:
                                break;
                          }
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
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorImageURL = new JSONHoldingStringGenerator("field \"ImageURL\" of the TypeNativeData class");
                fieldGeneratorBankroll = new JSONHoldingNumberTextGenerator("field \"Bankroll\" of the TypeNativeData class");
                fieldGeneratorBetAmount = new JSONHoldingNumberTextGenerator("field \"BetAmount\" of the TypeNativeData class");
                fieldGeneratorPlayerHand = new BlackjackHandJSON.HoldingGenerator("field \"PlayerHand\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorPlayerHandTotal = new FieldHoldingGeneratorPlayerHandTotal("field \"PlayerHandTotal\" of the TypeNativeData class");
                fieldGeneratorDealerHand = new BlackjackHandJSON.HoldingGenerator("field \"DealerHand\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorDealerHandTotal = new FieldHoldingGeneratorDealerHandTotal("field \"DealerHandTotal\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorImageURL = new JSONHoldingStringGenerator("field \"ImageURL\" of the TypeNativeData class");
                fieldGeneratorBankroll = new JSONHoldingNumberTextGenerator("field \"Bankroll\" of the TypeNativeData class");
                fieldGeneratorBetAmount = new JSONHoldingNumberTextGenerator("field \"BetAmount\" of the TypeNativeData class");
                fieldGeneratorPlayerHand = new BlackjackHandJSON.HoldingGenerator("field \"PlayerHand\" of the TypeNativeData class", false);
                fieldGeneratorPlayerHandTotal = new FieldHoldingGeneratorPlayerHandTotal("field \"PlayerHandTotal\" of the TypeNativeData class");
                fieldGeneratorDealerHand = new BlackjackHandJSON.HoldingGenerator("field \"DealerHand\" of the TypeNativeData class", false);
                fieldGeneratorDealerHandTotal = new FieldHoldingGeneratorDealerHandTotal("field \"DealerHandTotal\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorImageURL.reset();
                fieldGeneratorBankroll.reset();
                fieldGeneratorBetAmount.reset();
                fieldGeneratorPlayerHand.reset();
                fieldGeneratorPlayerHandTotal.reset();
                fieldGeneratorDealerHand.reset();
                fieldGeneratorDealerHandTotal.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorPlayerHand.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorDealerHand.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorPlayerHand.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorDealerHand.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeNativeDataJSON  result)
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
            public TypeNativeDataJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNativeDataJSON  result)
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
        protected virtual void handle_result(List<TypeNativeDataJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNativeDataJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNativeDataJSON>();
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
        public List<TypeNativeDataJSON> value;
      };
      };
    private bool flagHasNativeData;
    private TypeNativeDataJSON  storeNativeData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    public BlackjackNotUnderstoodCommandJSON()
      {
        flagHasNativeData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getBlackjackCommandKind()
      {
        return "BlackjackNotUnderstoodCommand";
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public TypeNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }


    public virtual int extraBlackjackNotUnderstoodCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBlackjackNotUnderstoodCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBlackjackNotUnderstoodCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBlackjackNotUnderstoodCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraBlackjackCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        result += extraBlackjackNotUnderstoodCommandComponentCount();
        return result;
      }
    public override string extraBlackjackCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraBlackjackNotUnderstoodCommandComponentKey(remainder);
      }
    public override JSONValue extraBlackjackCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraBlackjackNotUnderstoodCommandComponentValue(remainder);
      }
    public override JSONValue extraBlackjackCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasNativeData ? extraNativeDataToJSON() : null);
        return extraBlackjackNotUnderstoodCommandLookup(field_name);
      }

    public void setNativeData(TypeNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
      }

    public virtual void extraBlackjackNotUnderstoodCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBlackjackNotUnderstoodCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBlackjackNotUnderstoodCommandLookup(key);
        if (old_field == null)
          {
            extraBlackjackNotUnderstoodCommandAppendPair(key, new_component);
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
    public override void extraBlackjackCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraBlackjackNotUnderstoodCommandAppendPair(key, new_component);
      }
    public override void extraBlackjackCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraBlackjackNotUnderstoodCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNativeData);
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
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
        if (!(hasNativeData()))
          {
            return "When parsing the object for %what%, the \"NativeData\" field was missing.";
          }
        return null;
      }

    public static new BlackjackNotUnderstoodCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BlackjackNotUnderstoodCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BlackjackNotUnderstoodCommand", ignore_extras);
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
    public static new BlackjackNotUnderstoodCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BlackjackNotUnderstoodCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BlackjackNotUnderstoodCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BlackjackNotUnderstoodCommand", ignore_extras);
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
    public static new BlackjackNotUnderstoodCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BlackjackNotUnderstoodCommandJSON from_text(string text, bool ignore_extras)
      {
        BlackjackNotUnderstoodCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BlackjackNotUnderstoodCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BlackjackNotUnderstoodCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new BlackjackNotUnderstoodCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BlackjackNotUnderstoodCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BlackjackNotUnderstoodCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : BlackjackCommandJSON.Generator
      {
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
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
            if (!(getBlackjackCommandJSONKey().Equals("BlackjackNotUnderstoodCommand")))
                throw new Exception("The key field has a value other than `BlackjackNotUnderstoodCommand'.");
            BlackjackNotUnderstoodCommandJSON result = new BlackjackNotUnderstoodCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBlackjackNotUnderstoodCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(BlackjackCommandJSON new_result)
          {
            handle_result((BlackjackNotUnderstoodCommandJSON )new_result);
          }
        protected void finish(BlackjackNotUnderstoodCommandJSON result)
          {
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            else if ((!(result.hasNativeData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NativeData\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(BlackjackNotUnderstoodCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorNativeData;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the BlackjackNotUnderstoodCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BlackjackNotUnderstoodCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the BlackjackNotUnderstoodCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BlackjackNotUnderstoodCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(BlackjackNotUnderstoodCommandJSON  result)
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
        public BlackjackNotUnderstoodCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BlackjackNotUnderstoodCommandJSON  result)
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
    protected virtual void handle_result(List<BlackjackNotUnderstoodCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BlackjackNotUnderstoodCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BlackjackNotUnderstoodCommandJSON>();
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
    public List<BlackjackNotUnderstoodCommandJSON> value;
  };
  };
