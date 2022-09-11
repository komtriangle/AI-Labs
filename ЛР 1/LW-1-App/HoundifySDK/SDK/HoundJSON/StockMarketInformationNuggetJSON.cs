/* file "StockMarketInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StockMarketInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasQueryBlocks;
    private List< StockQueryBlockJSON  > storeQueryBlocks;
    private bool flagHasInvalidDateRequested;
    private bool storeInvalidDateRequested;
    private bool flagHasInvalidAttributeRequested;
    private bool storeInvalidAttributeRequested;
    private bool flagHasClientLocalTime;
    private DateAndOrTimeJSON  storeClientLocalTime;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraQueryBlocksToJSON()
      {
        JSONArrayValue generated_array_1_QueryBlocks = new JSONArrayValue();
        for (int num1 = 0; num1 < storeQueryBlocks.Count; ++num1)
          {
            JSONValueHandler handler_QueryBlocks = new JSONValueHandler();
            storeQueryBlocks[num1].write_as_json(handler_QueryBlocks);
            generated_array_1_QueryBlocks.appendComponent(handler_QueryBlocks.result);
          }
        return generated_array_1_QueryBlocks;
      }

    private JSONValue  extraInvalidDateRequestedToJSON()
      {
        JSONValue generated_boolean_InvalidDateRequested = (storeInvalidDateRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_InvalidDateRequested;
      }

    private JSONValue  extraInvalidAttributeRequestedToJSON()
      {
        JSONValue generated_boolean_InvalidAttributeRequested = (storeInvalidAttributeRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_InvalidAttributeRequested;
      }

    private JSONValue  extraClientLocalTimeToJSON()
      {
        JSONValueHandler handler_ClientLocalTime = new JSONValueHandler();
        storeClientLocalTime.write_as_json(handler_ClientLocalTime);
        return handler_ClientLocalTime.result;
      }


    private void  fromJSONQueryBlocks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field QueryBlocks of StockMarketInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< StockQueryBlockJSON  > vector_QueryBlocks1 = new List< StockQueryBlockJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            StockQueryBlockJSON convert_classy = StockQueryBlockJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_QueryBlocks1.Add(convert_classy);
          }
        initQueryBlocks();
        for (int num1 = 0; num1 < vector_QueryBlocks1.Count; ++num1)
            appendQueryBlocks(vector_QueryBlocks1[num1]);
        for (int num1 = 0; num1 < vector_QueryBlocks1.Count; ++num1)
          {
          }
      }


    private void  fromJSONInvalidDateRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field InvalidDateRequested of StockMarketInformationNuggetJSON is not true for false.");
              }
          }
        setInvalidDateRequested(the_bool);
      }


    private void  fromJSONInvalidAttributeRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field InvalidAttributeRequested of StockMarketInformationNuggetJSON is not true for false.");
              }
          }
        setInvalidAttributeRequested(the_bool);
      }


    private void  fromJSONClientLocalTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setClientLocalTime(convert_classy);
      }


    public StockMarketInformationNuggetJSON()
      {
        flagHasQueryBlocks = false;
        flagHasInvalidDateRequested = false;
        flagHasInvalidAttributeRequested = false;
        flagHasClientLocalTime = false;
        storeQueryBlocks = new List< StockQueryBlockJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "StockMarket";
      }

    public bool  hasQueryBlocks()
      {
        return flagHasQueryBlocks;
      }

    public int  countOfQueryBlocks()
      {
        Debug.Assert(flagHasQueryBlocks);
        return storeQueryBlocks.Count;
      }

    public StockQueryBlockJSON   elementOfQueryBlocks(int element_num)
      {
        Debug.Assert(flagHasQueryBlocks);
        return storeQueryBlocks[element_num];
      }

    public List< StockQueryBlockJSON  >  getQueryBlocks()
      {
        Debug.Assert(flagHasQueryBlocks);
        return storeQueryBlocks;
      }

    public bool  hasInvalidDateRequested()
      {
        return flagHasInvalidDateRequested;
      }

    public bool  getInvalidDateRequested()
      {
        Debug.Assert(flagHasInvalidDateRequested);
        return storeInvalidDateRequested;
      }

    public bool  hasInvalidAttributeRequested()
      {
        return flagHasInvalidAttributeRequested;
      }

    public bool  getInvalidAttributeRequested()
      {
        Debug.Assert(flagHasInvalidAttributeRequested);
        return storeInvalidAttributeRequested;
      }

    public bool  hasClientLocalTime()
      {
        return flagHasClientLocalTime;
      }

    public DateAndOrTimeJSON   getClientLocalTime()
      {
        Debug.Assert(flagHasClientLocalTime);
        return storeClientLocalTime;
      }


    public virtual int extraStockMarketInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockMarketInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockMarketInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockMarketInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasQueryBlocks)
            ++result;
        if (flagHasInvalidDateRequested)
            ++result;
        if (flagHasInvalidAttributeRequested)
            ++result;
        if (flagHasClientLocalTime)
            ++result;
        result += extraStockMarketInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryBlocks)
          {
            if (remainder == 0)
                return "QueryBlocks";
            --remainder;
          }
        if (flagHasInvalidDateRequested)
          {
            if (remainder == 0)
                return "InvalidDateRequested";
            --remainder;
          }
        if (flagHasInvalidAttributeRequested)
          {
            if (remainder == 0)
                return "InvalidAttributeRequested";
            --remainder;
          }
        if (flagHasClientLocalTime)
          {
            if (remainder == 0)
                return "ClientLocalTime";
            --remainder;
          }
        return extraStockMarketInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryBlocks)
          {
            if (remainder == 0)
                return extraQueryBlocksToJSON();
            --remainder;
          }
        if (flagHasInvalidDateRequested)
          {
            if (remainder == 0)
                return extraInvalidDateRequestedToJSON();
            --remainder;
          }
        if (flagHasInvalidAttributeRequested)
          {
            if (remainder == 0)
                return extraInvalidAttributeRequestedToJSON();
            --remainder;
          }
        if (flagHasClientLocalTime)
          {
            if (remainder == 0)
                return extraClientLocalTimeToJSON();
            --remainder;
          }
        return extraStockMarketInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "lientLocalTime", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasClientLocalTime ? extraClientLocalTimeToJSON() : null);
                break;
            case 'I':
                if (String.Compare(field_name, 1, "nvalid", 0, 6, false) == 0)
                  {
                    switch (field_name[7])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 8, "ttributeRequested", 0, 17, false) == 0) && (field_name.Length == 25))
                                return (flagHasInvalidAttributeRequested ? extraInvalidAttributeRequestedToJSON() : null);
                            break;
                        case 'D':
                            if ((String.Compare(field_name, 8, "ateRequested", 0, 12, false) == 0) && (field_name.Length == 20))
                                return (flagHasInvalidDateRequested ? extraInvalidDateRequestedToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Q':
                if ((String.Compare(field_name, 1, "ueryBlocks", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasQueryBlocks ? extraQueryBlocksToJSON() : null);
                break;
            default:
                break;
          }
        return extraStockMarketInformationNuggetLookup(field_name);
      }

    public void initQueryBlocks()
      {
        if (flagHasQueryBlocks)
          {
            for (int num1 = 0; num1 < storeQueryBlocks.Count; ++num1)
              {
              }
          }
        flagHasQueryBlocks = true;
        storeQueryBlocks.Clear();
      }
    public void appendQueryBlocks(StockQueryBlockJSON  to_append)
      {
        if (!flagHasQueryBlocks)
          {
            flagHasQueryBlocks = true;
            storeQueryBlocks.Clear();
          }
        Debug.Assert(flagHasQueryBlocks);
        storeQueryBlocks.Add(to_append);
      }
    public void unsetQueryBlocks()
      {
        if (flagHasQueryBlocks)
          {
            for (int num2 = 0; num2 < storeQueryBlocks.Count; ++num2)
              {
              }
          }
        flagHasQueryBlocks = false;
        storeQueryBlocks.Clear();
      }
    public void setInvalidDateRequested(bool new_value)
      {
        flagHasInvalidDateRequested = true;
        storeInvalidDateRequested = new_value;
      }
    public void unsetInvalidDateRequested()
      {
        flagHasInvalidDateRequested = false;
      }
    public void setInvalidAttributeRequested(bool new_value)
      {
        flagHasInvalidAttributeRequested = true;
        storeInvalidAttributeRequested = new_value;
      }
    public void unsetInvalidAttributeRequested()
      {
        flagHasInvalidAttributeRequested = false;
      }
    public void setClientLocalTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasClientLocalTime)
          {
          }
        flagHasClientLocalTime = true;
        storeClientLocalTime = new_value;
      }
    public void unsetClientLocalTime()
      {
        if (flagHasClientLocalTime)
          {
          }
        flagHasClientLocalTime = false;
      }

    public virtual void extraStockMarketInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockMarketInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockMarketInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraStockMarketInformationNuggetAppendPair(key, new_component);
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
            case 'C':
                if ((String.Compare(key, 1, "lientLocalTime", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONClientLocalTime(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if (String.Compare(key, 1, "nvalid", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'A':
                            if ((String.Compare(key, 8, "ttributeRequested", 0, 17, false) == 0) && (key.Length == 25))
                                {
                                fromJSONInvalidAttributeRequested(new_component, false);
                                return;
                                }
                            break;
                        case 'D':
                            if ((String.Compare(key, 8, "ateRequested", 0, 12, false) == 0) && (key.Length == 20))
                                {
                                fromJSONInvalidDateRequested(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryBlocks", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONQueryBlocks(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraStockMarketInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "lientLocalTime", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONClientLocalTime(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if (String.Compare(key, 1, "nvalid", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'A':
                            if ((String.Compare(key, 8, "ttributeRequested", 0, 17, false) == 0) && (key.Length == 25))
                                {
                                fromJSONInvalidAttributeRequested(new_component, false);
                                return;
                                }
                            break;
                        case 'D':
                            if ((String.Compare(key, 8, "ateRequested", 0, 12, false) == 0) && (key.Length == 20))
                                {
                                fromJSONInvalidDateRequested(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryBlocks", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONQueryBlocks(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraStockMarketInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQueryBlocks);
        if (flagHasQueryBlocks)
          {
            handler.start_pair("QueryBlocks");
            handler.start_array();
            for (int num1 = 0; num1 < storeQueryBlocks.Count; ++num1)
              {
                if (partial_allowed)
                    storeQueryBlocks[num1].write_partial_as_json(handler);
                else
                    storeQueryBlocks[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasInvalidDateRequested);
        if (flagHasInvalidDateRequested)
          {
            handler.start_pair("InvalidDateRequested");
            handler.boolean_value(storeInvalidDateRequested);
          }
        Debug.Assert(partial_allowed || flagHasInvalidAttributeRequested);
        if (flagHasInvalidAttributeRequested)
          {
            handler.start_pair("InvalidAttributeRequested");
            handler.boolean_value(storeInvalidAttributeRequested);
          }
        if (flagHasClientLocalTime)
          {
            handler.start_pair("ClientLocalTime");
            if (partial_allowed)
                storeClientLocalTime.write_partial_as_json(handler);
            else
                storeClientLocalTime.write_as_json(handler);
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
        if (!(hasQueryBlocks()))
          {
            return "When parsing the object for %what%, the \"QueryBlocks\" field was missing.";
          }
        if (!(hasInvalidDateRequested()))
          {
            return "When parsing the object for %what%, the \"InvalidDateRequested\" field was missing.";
          }
        if (!(hasInvalidAttributeRequested()))
          {
            return "When parsing the object for %what%, the \"InvalidAttributeRequested\" field was missing.";
          }
        return null;
      }

    public static new StockMarketInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockMarketInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockMarketInformationNugget", ignore_extras);
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
    public static new StockMarketInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StockMarketInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockMarketInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockMarketInformationNugget", ignore_extras);
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
    public static new StockMarketInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StockMarketInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        StockMarketInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockMarketInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockMarketInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new StockMarketInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockMarketInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockMarketInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private StockQueryBlockJSON.HoldingArrayGenerator fieldGeneratorQueryBlocks;
        private JSONHoldingBooleanGenerator fieldGeneratorInvalidDateRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorInvalidAttributeRequested;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorClientLocalTime;
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
            if (!(getInformationNuggetJSONKey().Equals("StockMarket")))
                throw new Exception("The key field has a value other than `StockMarket'.");
            StockMarketInformationNuggetJSON result = new StockMarketInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockMarketInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((StockMarketInformationNuggetJSON )new_result);
          }
        protected void finish(StockMarketInformationNuggetJSON result)
          {
            if (fieldGeneratorQueryBlocks.have_value)
              {
                result.initQueryBlocks();
                int count = fieldGeneratorQueryBlocks.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendQueryBlocks(fieldGeneratorQueryBlocks.value[num]);
                  }
                fieldGeneratorQueryBlocks.value.Clear();
                fieldGeneratorQueryBlocks.have_value = false;
              }
            else if ((!(result.hasQueryBlocks())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryBlocks\" field was missing.");
              }
            if (fieldGeneratorInvalidDateRequested.have_value)
              {
                result.setInvalidDateRequested(fieldGeneratorInvalidDateRequested.value);
                fieldGeneratorInvalidDateRequested.have_value = false;
              }
            else if ((!(result.hasInvalidDateRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InvalidDateRequested\" field was missing.");
              }
            if (fieldGeneratorInvalidAttributeRequested.have_value)
              {
                result.setInvalidAttributeRequested(fieldGeneratorInvalidAttributeRequested.value);
                fieldGeneratorInvalidAttributeRequested.have_value = false;
              }
            else if ((!(result.hasInvalidAttributeRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InvalidAttributeRequested\" field was missing.");
              }
            if (fieldGeneratorClientLocalTime.have_value)
              {
                result.setClientLocalTime(fieldGeneratorClientLocalTime.value);
                fieldGeneratorClientLocalTime.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(StockMarketInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "lientLocalTime", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorClientLocalTime;
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "nvalid", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 8, "ttributeRequested", 0, 17, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorInvalidAttributeRequested;
                                break;
                            case 'D':
                                if ((String.Compare(field_name, 8, "ateRequested", 0, 12, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorInvalidDateRequested;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryBlocks", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorQueryBlocks;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorQueryBlocks = new StockQueryBlockJSON.HoldingArrayGenerator("field \"QueryBlocks\" of the StockMarketInformationNugget class", ignore_extras);
            fieldGeneratorInvalidDateRequested = new JSONHoldingBooleanGenerator("field \"InvalidDateRequested\" of the StockMarketInformationNugget class");
            fieldGeneratorInvalidAttributeRequested = new JSONHoldingBooleanGenerator("field \"InvalidAttributeRequested\" of the StockMarketInformationNugget class");
            fieldGeneratorClientLocalTime = new DateAndOrTimeJSON.HoldingGenerator("field \"ClientLocalTime\" of the StockMarketInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockMarketInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorQueryBlocks = new StockQueryBlockJSON.HoldingArrayGenerator("field \"QueryBlocks\" of the StockMarketInformationNugget class", false);
            fieldGeneratorInvalidDateRequested = new JSONHoldingBooleanGenerator("field \"InvalidDateRequested\" of the StockMarketInformationNugget class");
            fieldGeneratorInvalidAttributeRequested = new JSONHoldingBooleanGenerator("field \"InvalidAttributeRequested\" of the StockMarketInformationNugget class");
            fieldGeneratorClientLocalTime = new DateAndOrTimeJSON.HoldingGenerator("field \"ClientLocalTime\" of the StockMarketInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockMarketInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorQueryBlocks.reset();
            fieldGeneratorInvalidDateRequested.reset();
            fieldGeneratorInvalidAttributeRequested.reset();
            fieldGeneratorClientLocalTime.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(StockMarketInformationNuggetJSON  result)
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
        public StockMarketInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockMarketInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<StockMarketInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockMarketInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockMarketInformationNuggetJSON>();
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
    public List<StockMarketInformationNuggetJSON> value;
  };
  };
