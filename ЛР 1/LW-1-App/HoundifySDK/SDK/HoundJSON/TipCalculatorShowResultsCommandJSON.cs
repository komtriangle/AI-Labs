/* file "TipCalculatorShowResultsCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TipCalculatorShowResultsCommandJSON : TipCalculatorCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        private bool flagHasTipCalculatorInputData;
        private TipCalculatorInputDataJSON  storeTipCalculatorInputData;
        private bool flagHasTipPercentageResult;
        private double storeTipPercentageResult;
        private string textStoreTipPercentageResult;
        private bool flagHasTipAmountResult;
        private MoneyJSON  storeTipAmountResult;
        private bool flagHasStandardTipPercentages;
        private List< Double > storeStandardTipPercentages;
        private bool flagHasStandardTipAmounts;
        private List< MoneyJSON  > storeStandardTipAmounts;
        private bool flagHasUsingStandardTip;
        private bool storeUsingStandardTip;
        private bool flagHasTotalAmountResult;
        private MoneyJSON  storeTotalAmountResult;
        private bool flagHasShareOfTotal;
        private MoneyJSON  storeShareOfTotal;
        private bool flagHasShareOfTip;
        private MoneyJSON  storeShareOfTip;
        private bool flagHasNotUnderstood;
        private bool storeNotUnderstood;
        private bool flagHasResultError;
        private string storeResultError;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONTipCalculatorInputData(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TipCalculatorInputDataJSON convert_classy = TipCalculatorInputDataJSON.from_json(json_value, ignore_extras, true);
            setTipCalculatorInputData(convert_classy);
          }


        private void  fromJSONTipPercentageResult(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field TipPercentageResult of TypeNativeDataJSON is not a number.");
                  }
              }
            setTipPercentageResultText(the_rational_text);
          }


        private void  fromJSONTipAmountResult(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setTipAmountResult(convert_classy);
          }


        private void  fromJSONStandardTipPercentages(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field StandardTipPercentages of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field StandardTipPercentages of TypeNativeDataJSON has too few elements.");
            List< Double > vector_StandardTipPercentages1 = new List< Double >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
                    if (json_integer != null)
                      {
                        the_double = json_integer.getLongInt();
                      }
                    else
                      {
                        throw new Exception("The value for an element of field StandardTipPercentages of TypeNativeDataJSON is not a number.");
                      }
                  }
                vector_StandardTipPercentages1.Add(the_double);
              }
            Debug.Assert(vector_StandardTipPercentages1.Count >= 1);
            initStandardTipPercentages();
            for (int num1 = 0; num1 < vector_StandardTipPercentages1.Count; ++num1)
                appendStandardTipPercentages(vector_StandardTipPercentages1[num1]);
            for (int num1 = 0; num1 < vector_StandardTipPercentages1.Count; ++num1)
              {
              }
          }


        private void  fromJSONStandardTipAmounts(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field StandardTipAmounts of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field StandardTipAmounts of TypeNativeDataJSON has too few elements.");
            List< MoneyJSON  > vector_StandardTipAmounts1 = new List< MoneyJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                MoneyJSON convert_classy = MoneyJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_StandardTipAmounts1.Add(convert_classy);
              }
            Debug.Assert(vector_StandardTipAmounts1.Count >= 1);
            initStandardTipAmounts();
            for (int num2 = 0; num2 < vector_StandardTipAmounts1.Count; ++num2)
                appendStandardTipAmounts(vector_StandardTipAmounts1[num2]);
            for (int num1 = 0; num1 < vector_StandardTipAmounts1.Count; ++num1)
              {
              }
          }


        private void  fromJSONUsingStandardTip(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field UsingStandardTip of TypeNativeDataJSON is not true for false.");
                  }
              }
            setUsingStandardTip(the_bool);
          }


        private void  fromJSONTotalAmountResult(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setTotalAmountResult(convert_classy);
          }


        private void  fromJSONShareOfTotal(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setShareOfTotal(convert_classy);
          }


        private void  fromJSONShareOfTip(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setShareOfTip(convert_classy);
          }


        private void  fromJSONNotUnderstood(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field NotUnderstood of TypeNativeDataJSON is not true for false.");
                  }
              }
            setNotUnderstood(the_bool);
          }


        private void  fromJSONResultError(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ResultError of TypeNativeDataJSON is not a string.");
            setResultError(json_string.getData());
          }


        public TypeNativeDataJSON()
          {
            flagHasTipCalculatorInputData = false;
            flagHasTipPercentageResult = false;
            flagHasTipAmountResult = false;
            flagHasStandardTipPercentages = false;
            flagHasStandardTipAmounts = false;
            flagHasUsingStandardTip = false;
            flagHasTotalAmountResult = false;
            flagHasShareOfTotal = false;
            flagHasShareOfTip = false;
            flagHasNotUnderstood = false;
            flagHasResultError = false;
            storeStandardTipPercentages = new List< Double >();
            storeStandardTipAmounts = new List< MoneyJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasTipCalculatorInputData()
          {
            return flagHasTipCalculatorInputData;
          }

        public TipCalculatorInputDataJSON   getTipCalculatorInputData()
          {
            Debug.Assert(flagHasTipCalculatorInputData);
            return storeTipCalculatorInputData;
          }

        public bool  hasTipPercentageResult()
          {
            return flagHasTipPercentageResult;
          }

        public double  getTipPercentageResult()
          {
            Debug.Assert(flagHasTipPercentageResult);
            if (textStoreTipPercentageResult != "")
              {
                return Double.Parse(textStoreTipPercentageResult);
              }
            return storeTipPercentageResult;
          }

        public string  getTipPercentageResultAsText()
          {
            Debug.Assert(flagHasTipPercentageResult);
            if (textStoreTipPercentageResult == "")
              {
                return Convert.ToString(storeTipPercentageResult);
              }
            else
              {
                return (textStoreTipPercentageResult);
              }
          }

        public bool  hasTipAmountResult()
          {
            return flagHasTipAmountResult;
          }

        public MoneyJSON   getTipAmountResult()
          {
            Debug.Assert(flagHasTipAmountResult);
            return storeTipAmountResult;
          }

        public bool  hasStandardTipPercentages()
          {
            return flagHasStandardTipPercentages;
          }

        public int  countOfStandardTipPercentages()
          {
            Debug.Assert(flagHasStandardTipPercentages);
            return storeStandardTipPercentages.Count;
          }

        public double  elementOfStandardTipPercentages(int element_num)
          {
            Debug.Assert(flagHasStandardTipPercentages);
            return storeStandardTipPercentages[element_num];
          }

        public List< Double >  getStandardTipPercentages()
          {
            Debug.Assert(flagHasStandardTipPercentages);
            return storeStandardTipPercentages;
          }

        public bool  hasStandardTipAmounts()
          {
            return flagHasStandardTipAmounts;
          }

        public int  countOfStandardTipAmounts()
          {
            Debug.Assert(flagHasStandardTipAmounts);
            return storeStandardTipAmounts.Count;
          }

        public MoneyJSON   elementOfStandardTipAmounts(int element_num)
          {
            Debug.Assert(flagHasStandardTipAmounts);
            return storeStandardTipAmounts[element_num];
          }

        public List< MoneyJSON  >  getStandardTipAmounts()
          {
            Debug.Assert(flagHasStandardTipAmounts);
            return storeStandardTipAmounts;
          }

        public bool  hasUsingStandardTip()
          {
            return flagHasUsingStandardTip;
          }

        public bool  getUsingStandardTip()
          {
            Debug.Assert(flagHasUsingStandardTip);
            return storeUsingStandardTip;
          }

        public bool  hasTotalAmountResult()
          {
            return flagHasTotalAmountResult;
          }

        public MoneyJSON   getTotalAmountResult()
          {
            Debug.Assert(flagHasTotalAmountResult);
            return storeTotalAmountResult;
          }

        public bool  hasShareOfTotal()
          {
            return flagHasShareOfTotal;
          }

        public MoneyJSON   getShareOfTotal()
          {
            Debug.Assert(flagHasShareOfTotal);
            return storeShareOfTotal;
          }

        public bool  hasShareOfTip()
          {
            return flagHasShareOfTip;
          }

        public MoneyJSON   getShareOfTip()
          {
            Debug.Assert(flagHasShareOfTip);
            return storeShareOfTip;
          }

        public bool  hasNotUnderstood()
          {
            return flagHasNotUnderstood;
          }

        public bool  getNotUnderstood()
          {
            Debug.Assert(flagHasNotUnderstood);
            return storeNotUnderstood;
          }

        public bool  hasResultError()
          {
            return flagHasResultError;
          }

        public string  getResultError()
          {
            Debug.Assert(flagHasResultError);
            return storeResultError;
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

        public void setTipCalculatorInputData(TipCalculatorInputDataJSON  new_value)
          {
            if (flagHasTipCalculatorInputData)
              {
              }
            flagHasTipCalculatorInputData = true;
            storeTipCalculatorInputData = new_value;
          }
        public void unsetTipCalculatorInputData()
          {
            if (flagHasTipCalculatorInputData)
              {
              }
            flagHasTipCalculatorInputData = false;
          }
        public void setTipPercentageResult(double new_value)
          {
            flagHasTipPercentageResult = true;
            if (new_value < 0)
                throw new Exception("The value for field TipPercentageResult of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeTipPercentageResult = new_value;
            textStoreTipPercentageResult = "";
          }
        public void setTipPercentageResultText(string new_value)
          {
            flagHasTipPercentageResult = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field TipPercentageResult of TypeNativeDataJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field TipPercentageResult of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            textStoreTipPercentageResult = new_value;
          }
        public void unsetTipPercentageResult()
          {
            flagHasTipPercentageResult = false;
          }
        public void setTipAmountResult(MoneyJSON  new_value)
          {
            if (flagHasTipAmountResult)
              {
              }
            flagHasTipAmountResult = true;
            storeTipAmountResult = new_value;
          }
        public void unsetTipAmountResult()
          {
            if (flagHasTipAmountResult)
              {
              }
            flagHasTipAmountResult = false;
          }
        public void initStandardTipPercentages()
          {
            flagHasStandardTipPercentages = true;
            storeStandardTipPercentages.Clear();
          }
        public void appendStandardTipPercentages(double to_append)
          {
            if (!flagHasStandardTipPercentages)
              {
                flagHasStandardTipPercentages = true;
                storeStandardTipPercentages.Clear();
              }
            Debug.Assert(flagHasStandardTipPercentages);
            storeStandardTipPercentages.Add(to_append);
          }
        public void unsetStandardTipPercentages()
          {
            flagHasStandardTipPercentages = false;
            storeStandardTipPercentages.Clear();
          }
        public void initStandardTipAmounts()
          {
            if (flagHasStandardTipAmounts)
              {
                for (int num1 = 0; num1 < storeStandardTipAmounts.Count; ++num1)
                  {
                  }
              }
            flagHasStandardTipAmounts = true;
            storeStandardTipAmounts.Clear();
          }
        public void appendStandardTipAmounts(MoneyJSON  to_append)
          {
            if (!flagHasStandardTipAmounts)
              {
                flagHasStandardTipAmounts = true;
                storeStandardTipAmounts.Clear();
              }
            Debug.Assert(flagHasStandardTipAmounts);
            storeStandardTipAmounts.Add(to_append);
          }
        public void unsetStandardTipAmounts()
          {
            if (flagHasStandardTipAmounts)
              {
                for (int num2 = 0; num2 < storeStandardTipAmounts.Count; ++num2)
                  {
                  }
              }
            flagHasStandardTipAmounts = false;
            storeStandardTipAmounts.Clear();
          }
        public void setUsingStandardTip(bool new_value)
          {
            flagHasUsingStandardTip = true;
            storeUsingStandardTip = new_value;
          }
        public void unsetUsingStandardTip()
          {
            flagHasUsingStandardTip = false;
          }
        public void setTotalAmountResult(MoneyJSON  new_value)
          {
            if (flagHasTotalAmountResult)
              {
              }
            flagHasTotalAmountResult = true;
            storeTotalAmountResult = new_value;
          }
        public void unsetTotalAmountResult()
          {
            if (flagHasTotalAmountResult)
              {
              }
            flagHasTotalAmountResult = false;
          }
        public void setShareOfTotal(MoneyJSON  new_value)
          {
            if (flagHasShareOfTotal)
              {
              }
            flagHasShareOfTotal = true;
            storeShareOfTotal = new_value;
          }
        public void unsetShareOfTotal()
          {
            if (flagHasShareOfTotal)
              {
              }
            flagHasShareOfTotal = false;
          }
        public void setShareOfTip(MoneyJSON  new_value)
          {
            if (flagHasShareOfTip)
              {
              }
            flagHasShareOfTip = true;
            storeShareOfTip = new_value;
          }
        public void unsetShareOfTip()
          {
            if (flagHasShareOfTip)
              {
              }
            flagHasShareOfTip = false;
          }
        public void setNotUnderstood(bool new_value)
          {
            flagHasNotUnderstood = true;
            storeNotUnderstood = new_value;
          }
        public void unsetNotUnderstood()
          {
            flagHasNotUnderstood = false;
          }
        public void setResultError(string new_value)
          {
            flagHasResultError = true;
            storeResultError = new_value;
          }
        public void unsetResultError()
          {
            flagHasResultError = false;
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
            Debug.Assert(partial_allowed || flagHasTipCalculatorInputData);
            if (flagHasTipCalculatorInputData)
              {
                handler.start_pair("TipCalculatorInputData");
                if (partial_allowed)
                    storeTipCalculatorInputData.write_partial_as_json(handler);
                else
                    storeTipCalculatorInputData.write_as_json(handler);
              }
            if (flagHasTipPercentageResult)
              {
                handler.start_pair("TipPercentageResult");
                if (textStoreTipPercentageResult != "")
                    handler.number_value(textStoreTipPercentageResult);
                else if (((double)(long)storeTipPercentageResult) == storeTipPercentageResult)
                    handler.number_value((long)storeTipPercentageResult);
                else
                    handler.number_value(storeTipPercentageResult);
              }
            if (flagHasTipAmountResult)
              {
                handler.start_pair("TipAmountResult");
                if (partial_allowed)
                    storeTipAmountResult.write_partial_as_json(handler);
                else
                    storeTipAmountResult.write_as_json(handler);
              }
            if (flagHasStandardTipPercentages)
              {
                handler.start_pair("StandardTipPercentages");
                Debug.Assert(storeStandardTipPercentages.Count >= 1);
                handler.start_array();
                for (int num1 = 0; num1 < storeStandardTipPercentages.Count; ++num1)
                  {
                    if (((double)(long)storeStandardTipPercentages[num1]) == storeStandardTipPercentages[num1])
                        handler.number_value((long)storeStandardTipPercentages[num1]);
                    else
                        handler.number_value(storeStandardTipPercentages[num1]);
                  }
                handler.finish_array();
              }
            if (flagHasStandardTipAmounts)
              {
                handler.start_pair("StandardTipAmounts");
                Debug.Assert(storeStandardTipAmounts.Count >= 1);
                handler.start_array();
                for (int num2 = 0; num2 < storeStandardTipAmounts.Count; ++num2)
                  {
                    if (partial_allowed)
                        storeStandardTipAmounts[num2].write_partial_as_json(handler);
                    else
                        storeStandardTipAmounts[num2].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasUsingStandardTip)
              {
                handler.start_pair("UsingStandardTip");
                handler.boolean_value(storeUsingStandardTip);
              }
            if (flagHasTotalAmountResult)
              {
                handler.start_pair("TotalAmountResult");
                if (partial_allowed)
                    storeTotalAmountResult.write_partial_as_json(handler);
                else
                    storeTotalAmountResult.write_as_json(handler);
              }
            if (flagHasShareOfTotal)
              {
                handler.start_pair("ShareOfTotal");
                if (partial_allowed)
                    storeShareOfTotal.write_partial_as_json(handler);
                else
                    storeShareOfTotal.write_as_json(handler);
              }
            if (flagHasShareOfTip)
              {
                handler.start_pair("ShareOfTip");
                if (partial_allowed)
                    storeShareOfTip.write_partial_as_json(handler);
                else
                    storeShareOfTip.write_as_json(handler);
              }
            if (flagHasNotUnderstood)
              {
                handler.start_pair("NotUnderstood");
                handler.boolean_value(storeNotUnderstood);
              }
            if (flagHasResultError)
              {
                handler.start_pair("ResultError");
                handler.string_value(storeResultError);
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
            if (!(hasTipCalculatorInputData()))
              {
                return "When parsing the object for %what%, the \"TipCalculatorInputData\" field was missing.";
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
            private TipCalculatorInputDataJSON.HoldingGenerator fieldGeneratorTipCalculatorInputData;
            private JSONHoldingNumberTextGenerator fieldGeneratorTipPercentageResult;
            private MoneyJSON.HoldingGenerator fieldGeneratorTipAmountResult;
            private JSONHoldingNumberTextArrayGenerator fieldGeneratorStandardTipPercentages;
            private MoneyJSON.HoldingArrayGenerator fieldGeneratorStandardTipAmounts;
            private JSONHoldingBooleanGenerator fieldGeneratorUsingStandardTip;
            private MoneyJSON.HoldingGenerator fieldGeneratorTotalAmountResult;
            private MoneyJSON.HoldingGenerator fieldGeneratorShareOfTotal;
            private MoneyJSON.HoldingGenerator fieldGeneratorShareOfTip;
            private JSONHoldingBooleanGenerator fieldGeneratorNotUnderstood;
            private JSONHoldingStringGenerator fieldGeneratorResultError;
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
                if (fieldGeneratorTipCalculatorInputData.have_value)
                  {
                    result.setTipCalculatorInputData(fieldGeneratorTipCalculatorInputData.value);
                    fieldGeneratorTipCalculatorInputData.have_value = false;
                  }
                else if ((!(result.hasTipCalculatorInputData())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"TipCalculatorInputData\" field was missing.");
                  }
                if (fieldGeneratorTipPercentageResult.have_value)
                  {
                    result.setTipPercentageResultText(fieldGeneratorTipPercentageResult.value);
                    fieldGeneratorTipPercentageResult.have_value = false;
                  }
                if (fieldGeneratorTipAmountResult.have_value)
                  {
                    result.setTipAmountResult(fieldGeneratorTipAmountResult.value);
                    fieldGeneratorTipAmountResult.have_value = false;
                  }
                if (fieldGeneratorStandardTipPercentages.have_value)
                  {
                    result.initStandardTipPercentages();
                    int count = fieldGeneratorStandardTipPercentages.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendStandardTipPercentages(Double.Parse(fieldGeneratorStandardTipPercentages.value[num]));
                      }
                    fieldGeneratorStandardTipPercentages.value.Clear();
                    fieldGeneratorStandardTipPercentages.have_value = false;
                  }
                if (fieldGeneratorStandardTipAmounts.have_value)
                  {
                    result.initStandardTipAmounts();
                    int count = fieldGeneratorStandardTipAmounts.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendStandardTipAmounts(fieldGeneratorStandardTipAmounts.value[num]);
                      }
                    fieldGeneratorStandardTipAmounts.value.Clear();
                    fieldGeneratorStandardTipAmounts.have_value = false;
                  }
                if (fieldGeneratorUsingStandardTip.have_value)
                  {
                    result.setUsingStandardTip(fieldGeneratorUsingStandardTip.value);
                    fieldGeneratorUsingStandardTip.have_value = false;
                  }
                if (fieldGeneratorTotalAmountResult.have_value)
                  {
                    result.setTotalAmountResult(fieldGeneratorTotalAmountResult.value);
                    fieldGeneratorTotalAmountResult.have_value = false;
                  }
                if (fieldGeneratorShareOfTotal.have_value)
                  {
                    result.setShareOfTotal(fieldGeneratorShareOfTotal.value);
                    fieldGeneratorShareOfTotal.have_value = false;
                  }
                if (fieldGeneratorShareOfTip.have_value)
                  {
                    result.setShareOfTip(fieldGeneratorShareOfTip.value);
                    fieldGeneratorShareOfTip.have_value = false;
                  }
                if (fieldGeneratorNotUnderstood.have_value)
                  {
                    result.setNotUnderstood(fieldGeneratorNotUnderstood.value);
                    fieldGeneratorNotUnderstood.have_value = false;
                  }
                if (fieldGeneratorResultError.have_value)
                  {
                    result.setResultError(fieldGeneratorResultError.value);
                    fieldGeneratorResultError.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'N':
                        if ((String.Compare(field_name, 1, "otUnderstood", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorNotUnderstood;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "esultError", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorResultError;
                        break;
                    case 'S':
                        switch (field_name[1])
                          {
                            case 'h':
                                if (String.Compare(field_name, 2, "areOfT", 0, 6, false) == 0)
                                  {
                                    switch (field_name[8])
                                      {
                                        case 'i':
                                            if ((String.Compare(field_name, 9, "p", 0, 1, false) == 0) && (field_name.Length == 10))
                                                return fieldGeneratorShareOfTip;
                                            break;
                                        case 'o':
                                            if ((String.Compare(field_name, 9, "tal", 0, 3, false) == 0) && (field_name.Length == 12))
                                                return fieldGeneratorShareOfTotal;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 't':
                                if (String.Compare(field_name, 2, "andardTip", 0, 9, false) == 0)
                                  {
                                    switch (field_name[11])
                                      {
                                        case 'A':
                                            if ((String.Compare(field_name, 12, "mounts", 0, 6, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorStandardTipAmounts;
                                            break;
                                        case 'P':
                                            if ((String.Compare(field_name, 12, "ercentages", 0, 10, false) == 0) && (field_name.Length == 22))
                                                return fieldGeneratorStandardTipPercentages;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'T':
                        switch (field_name[1])
                          {
                            case 'i':
                                if (String.Compare(field_name, 2, "p", 0, 1, false) == 0)
                                  {
                                    switch (field_name[3])
                                      {
                                        case 'A':
                                            if ((String.Compare(field_name, 4, "mountResult", 0, 11, false) == 0) && (field_name.Length == 15))
                                                return fieldGeneratorTipAmountResult;
                                            break;
                                        case 'C':
                                            if ((String.Compare(field_name, 4, "alculatorInputData", 0, 18, false) == 0) && (field_name.Length == 22))
                                                return fieldGeneratorTipCalculatorInputData;
                                            break;
                                        case 'P':
                                            if ((String.Compare(field_name, 4, "ercentageResult", 0, 15, false) == 0) && (field_name.Length == 19))
                                                return fieldGeneratorTipPercentageResult;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 2, "talAmountResult", 0, 15, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorTotalAmountResult;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'U':
                        if ((String.Compare(field_name, 1, "singStandardTip", 0, 15, false) == 0) && (field_name.Length == 16))
                            return fieldGeneratorUsingStandardTip;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorTipCalculatorInputData = new TipCalculatorInputDataJSON.HoldingGenerator("field \"TipCalculatorInputData\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorTipPercentageResult = new JSONHoldingNumberTextGenerator("field \"TipPercentageResult\" of the TypeNativeData class");
                fieldGeneratorTipAmountResult = new MoneyJSON.HoldingGenerator("field \"TipAmountResult\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorStandardTipPercentages = new JSONHoldingNumberTextArrayGenerator("field \"StandardTipPercentages\" of the TypeNativeData class");
                fieldGeneratorStandardTipAmounts = new MoneyJSON.HoldingArrayGenerator("field \"StandardTipAmounts\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorUsingStandardTip = new JSONHoldingBooleanGenerator("field \"UsingStandardTip\" of the TypeNativeData class");
                fieldGeneratorTotalAmountResult = new MoneyJSON.HoldingGenerator("field \"TotalAmountResult\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorShareOfTotal = new MoneyJSON.HoldingGenerator("field \"ShareOfTotal\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorShareOfTip = new MoneyJSON.HoldingGenerator("field \"ShareOfTip\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorNotUnderstood = new JSONHoldingBooleanGenerator("field \"NotUnderstood\" of the TypeNativeData class");
                fieldGeneratorResultError = new JSONHoldingStringGenerator("field \"ResultError\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTipCalculatorInputData = new TipCalculatorInputDataJSON.HoldingGenerator("field \"TipCalculatorInputData\" of the TypeNativeData class", false);
                fieldGeneratorTipPercentageResult = new JSONHoldingNumberTextGenerator("field \"TipPercentageResult\" of the TypeNativeData class");
                fieldGeneratorTipAmountResult = new MoneyJSON.HoldingGenerator("field \"TipAmountResult\" of the TypeNativeData class", false);
                fieldGeneratorStandardTipPercentages = new JSONHoldingNumberTextArrayGenerator("field \"StandardTipPercentages\" of the TypeNativeData class");
                fieldGeneratorStandardTipAmounts = new MoneyJSON.HoldingArrayGenerator("field \"StandardTipAmounts\" of the TypeNativeData class", false);
                fieldGeneratorUsingStandardTip = new JSONHoldingBooleanGenerator("field \"UsingStandardTip\" of the TypeNativeData class");
                fieldGeneratorTotalAmountResult = new MoneyJSON.HoldingGenerator("field \"TotalAmountResult\" of the TypeNativeData class", false);
                fieldGeneratorShareOfTotal = new MoneyJSON.HoldingGenerator("field \"ShareOfTotal\" of the TypeNativeData class", false);
                fieldGeneratorShareOfTip = new MoneyJSON.HoldingGenerator("field \"ShareOfTip\" of the TypeNativeData class", false);
                fieldGeneratorNotUnderstood = new JSONHoldingBooleanGenerator("field \"NotUnderstood\" of the TypeNativeData class");
                fieldGeneratorResultError = new JSONHoldingStringGenerator("field \"ResultError\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTipCalculatorInputData.reset();
                fieldGeneratorTipPercentageResult.reset();
                fieldGeneratorTipAmountResult.reset();
                fieldGeneratorStandardTipPercentages.reset();
                fieldGeneratorStandardTipAmounts.reset();
                fieldGeneratorUsingStandardTip.reset();
                fieldGeneratorTotalAmountResult.reset();
                fieldGeneratorShareOfTotal.reset();
                fieldGeneratorShareOfTip.reset();
                fieldGeneratorNotUnderstood.reset();
                fieldGeneratorResultError.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorTipCalculatorInputData.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorTipAmountResult.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorStandardTipAmounts.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorTotalAmountResult.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorShareOfTotal.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorShareOfTip.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorTipCalculatorInputData.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorTipAmountResult.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorStandardTipAmounts.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorTotalAmountResult.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorShareOfTotal.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorShareOfTip.set_allow_unpolished(new_allow_unpolished);
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


    public TipCalculatorShowResultsCommandJSON()
      {
        flagHasNativeData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getTipCalculatorCommandKind()
      {
        return "TipCalculatorShowResultsCommand";
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


    public virtual int extraTipCalculatorShowResultsCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTipCalculatorShowResultsCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTipCalculatorShowResultsCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTipCalculatorShowResultsCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraTipCalculatorCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        result += extraTipCalculatorShowResultsCommandComponentCount();
        return result;
      }
    public override string extraTipCalculatorCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraTipCalculatorShowResultsCommandComponentKey(remainder);
      }
    public override JSONValue extraTipCalculatorCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraTipCalculatorShowResultsCommandComponentValue(remainder);
      }
    public override JSONValue extraTipCalculatorCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasNativeData ? extraNativeDataToJSON() : null);
        return extraTipCalculatorShowResultsCommandLookup(field_name);
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

    public virtual void extraTipCalculatorShowResultsCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTipCalculatorShowResultsCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTipCalculatorShowResultsCommandLookup(key);
        if (old_field == null)
          {
            extraTipCalculatorShowResultsCommandAppendPair(key, new_component);
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
    public override void extraTipCalculatorCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraTipCalculatorShowResultsCommandAppendPair(key, new_component);
      }
    public override void extraTipCalculatorCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraTipCalculatorShowResultsCommandSetField(key, new_component);
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
        return null;
      }

    public static new TipCalculatorShowResultsCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TipCalculatorShowResultsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TipCalculatorShowResultsCommand", ignore_extras);
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
    public static new TipCalculatorShowResultsCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TipCalculatorShowResultsCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TipCalculatorShowResultsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TipCalculatorShowResultsCommand", ignore_extras);
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
    public static new TipCalculatorShowResultsCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TipCalculatorShowResultsCommandJSON from_text(string text, bool ignore_extras)
      {
        TipCalculatorShowResultsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TipCalculatorShowResultsCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TipCalculatorShowResultsCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TipCalculatorShowResultsCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TipCalculatorShowResultsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TipCalculatorShowResultsCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : TipCalculatorCommandJSON.Generator
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
            if (!(getTipCalculatorCommandJSONKey().Equals("TipCalculatorShowResultsCommand")))
                throw new Exception("The key field has a value other than `TipCalculatorShowResultsCommand'.");
            TipCalculatorShowResultsCommandJSON result = new TipCalculatorShowResultsCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTipCalculatorShowResultsCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(TipCalculatorCommandJSON new_result)
          {
            handle_result((TipCalculatorShowResultsCommandJSON )new_result);
          }
        protected void finish(TipCalculatorShowResultsCommandJSON result)
          {
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(TipCalculatorShowResultsCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorNativeData;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the TipCalculatorShowResultsCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TipCalculatorShowResultsCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the TipCalculatorShowResultsCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TipCalculatorShowResultsCommand class");
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
        protected override void handle_result(TipCalculatorShowResultsCommandJSON  result)
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
        public TipCalculatorShowResultsCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TipCalculatorShowResultsCommandJSON  result)
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
    protected virtual void handle_result(List<TipCalculatorShowResultsCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TipCalculatorShowResultsCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TipCalculatorShowResultsCommandJSON>();
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
    public List<TipCalculatorShowResultsCommandJSON> value;
  };
  };
