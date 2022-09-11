/* file "StockMarketConversationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


public class StockMarketConversationJSON : JSONBase
  {
    public static Regex expressionStockAttributes = new Regex("^([0-8]( [0-8])*)?$");
    public static Regex expressionStockListings = new Regex("^[0-1] [0-9]+ [0-9]+ [0-1]( [0-9]+)?$");
    private bool flagHasStockAttributes;
    private string storeStockAttributes;
    private bool flagHasCompoundAttributes;
    private List< CompoundStockAttributeJSON  > storeCompoundAttributes;
    private bool flagHasStockListings;
    private List< string > storeStockListings;
    private bool flagHasRequestedListings;
    private List< StockConversationRequestedListingJSON  > storeRequestedListings;
    private bool flagHasMonetaryAmount;
    private MoneyJSON  storeMonetaryAmount;
    private bool flagHasStockEntitiesData;
    private List< StockEntityDataJSON  > storeStockEntitiesData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStockAttributes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StockAttributes of StockMarketConversationJSON is not a string.");
        setStockAttributes(json_string.getData());
      }


    private void  fromJSONCompoundAttributes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CompoundAttributes of StockMarketConversationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< CompoundStockAttributeJSON  > vector_CompoundAttributes1 = new List< CompoundStockAttributeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CompoundStockAttributeJSON convert_classy = CompoundStockAttributeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_CompoundAttributes1.Add(convert_classy);
          }
        initCompoundAttributes();
        for (int num1 = 0; num1 < vector_CompoundAttributes1.Count; ++num1)
            appendCompoundAttributes(vector_CompoundAttributes1[num1]);
        for (int num1 = 0; num1 < vector_CompoundAttributes1.Count; ++num1)
          {
          }
      }


    private void  fromJSONStockListings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field StockListings of StockMarketConversationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_StockListings1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field StockListings of StockMarketConversationJSON is not a string.");
            vector_StockListings1.Add(json_string.getData());
          }
        initStockListings();
        for (int num2 = 0; num2 < vector_StockListings1.Count; ++num2)
            appendStockListings(vector_StockListings1[num2]);
        for (int num1 = 0; num1 < vector_StockListings1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRequestedListings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RequestedListings of StockMarketConversationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< StockConversationRequestedListingJSON  > vector_RequestedListings1 = new List< StockConversationRequestedListingJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            StockConversationRequestedListingJSON convert_classy = StockConversationRequestedListingJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RequestedListings1.Add(convert_classy);
          }
        initRequestedListings();
        for (int num3 = 0; num3 < vector_RequestedListings1.Count; ++num3)
            appendRequestedListings(vector_RequestedListings1[num3]);
        for (int num1 = 0; num1 < vector_RequestedListings1.Count; ++num1)
          {
          }
      }


    private void  fromJSONMonetaryAmount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setMonetaryAmount(convert_classy);
      }


    private void  fromJSONStockEntitiesData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field StockEntitiesData of StockMarketConversationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< StockEntityDataJSON  > vector_StockEntitiesData1 = new List< StockEntityDataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            StockEntityDataJSON convert_classy = StockEntityDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_StockEntitiesData1.Add(convert_classy);
          }
        initStockEntitiesData();
        for (int num4 = 0; num4 < vector_StockEntitiesData1.Count; ++num4)
            appendStockEntitiesData(vector_StockEntitiesData1[num4]);
        for (int num1 = 0; num1 < vector_StockEntitiesData1.Count; ++num1)
          {
          }
      }


    public StockMarketConversationJSON()
      {
        flagHasStockAttributes = false;
        flagHasCompoundAttributes = false;
        flagHasStockListings = false;
        flagHasRequestedListings = false;
        flagHasMonetaryAmount = false;
        flagHasStockEntitiesData = false;
        storeCompoundAttributes = new List< CompoundStockAttributeJSON  >();
        storeStockListings = new List< string >();
        storeRequestedListings = new List< StockConversationRequestedListingJSON  >();
        storeStockEntitiesData = new List< StockEntityDataJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStockAttributes()
      {
        return flagHasStockAttributes;
      }

    public string  getStockAttributes()
      {
        Debug.Assert(flagHasStockAttributes);
        return storeStockAttributes;
      }

    public bool  hasCompoundAttributes()
      {
        return flagHasCompoundAttributes;
      }

    public int  countOfCompoundAttributes()
      {
        Debug.Assert(flagHasCompoundAttributes);
        return storeCompoundAttributes.Count;
      }

    public CompoundStockAttributeJSON   elementOfCompoundAttributes(int element_num)
      {
        Debug.Assert(flagHasCompoundAttributes);
        return storeCompoundAttributes[element_num];
      }

    public List< CompoundStockAttributeJSON  >  getCompoundAttributes()
      {
        Debug.Assert(flagHasCompoundAttributes);
        return storeCompoundAttributes;
      }

    public bool  hasStockListings()
      {
        return flagHasStockListings;
      }

    public int  countOfStockListings()
      {
        Debug.Assert(flagHasStockListings);
        return storeStockListings.Count;
      }

    public string  elementOfStockListings(int element_num)
      {
        Debug.Assert(flagHasStockListings);
        return storeStockListings[element_num];
      }

    public List< string >  getStockListings()
      {
        Debug.Assert(flagHasStockListings);
        return storeStockListings;
      }

    public bool  hasRequestedListings()
      {
        return flagHasRequestedListings;
      }

    public int  countOfRequestedListings()
      {
        Debug.Assert(flagHasRequestedListings);
        return storeRequestedListings.Count;
      }

    public StockConversationRequestedListingJSON   elementOfRequestedListings(int element_num)
      {
        Debug.Assert(flagHasRequestedListings);
        return storeRequestedListings[element_num];
      }

    public List< StockConversationRequestedListingJSON  >  getRequestedListings()
      {
        Debug.Assert(flagHasRequestedListings);
        return storeRequestedListings;
      }

    public bool  hasMonetaryAmount()
      {
        return flagHasMonetaryAmount;
      }

    public MoneyJSON   getMonetaryAmount()
      {
        Debug.Assert(flagHasMonetaryAmount);
        return storeMonetaryAmount;
      }

    public bool  hasStockEntitiesData()
      {
        return flagHasStockEntitiesData;
      }

    public int  countOfStockEntitiesData()
      {
        Debug.Assert(flagHasStockEntitiesData);
        return storeStockEntitiesData.Count;
      }

    public StockEntityDataJSON   elementOfStockEntitiesData(int element_num)
      {
        Debug.Assert(flagHasStockEntitiesData);
        return storeStockEntitiesData[element_num];
      }

    public List< StockEntityDataJSON  >  getStockEntitiesData()
      {
        Debug.Assert(flagHasStockEntitiesData);
        return storeStockEntitiesData;
      }


    public virtual int extraStockMarketConversationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockMarketConversationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockMarketConversationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockMarketConversationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setStockAttributes(string new_value)
      {
        flagHasStockAttributes = true;
        if (!expressionStockAttributes.IsMatch(new_value))
            throw new Exception("The value is not in the regular expression for field StockAttributes of StockMarketConversationJSON.");
        storeStockAttributes = new_value;
      }
    public void unsetStockAttributes()
      {
        flagHasStockAttributes = false;
      }
    public void initCompoundAttributes()
      {
        if (flagHasCompoundAttributes)
          {
            for (int num1 = 0; num1 < storeCompoundAttributes.Count; ++num1)
              {
              }
          }
        flagHasCompoundAttributes = true;
        storeCompoundAttributes.Clear();
      }
    public void appendCompoundAttributes(CompoundStockAttributeJSON  to_append)
      {
        if (!flagHasCompoundAttributes)
          {
            flagHasCompoundAttributes = true;
            storeCompoundAttributes.Clear();
          }
        Debug.Assert(flagHasCompoundAttributes);
        storeCompoundAttributes.Add(to_append);
      }
    public void unsetCompoundAttributes()
      {
        if (flagHasCompoundAttributes)
          {
            for (int num2 = 0; num2 < storeCompoundAttributes.Count; ++num2)
              {
              }
          }
        flagHasCompoundAttributes = false;
        storeCompoundAttributes.Clear();
      }
    public void initStockListings()
      {
        flagHasStockListings = true;
        storeStockListings.Clear();
      }
    public void appendStockListings(string to_append)
      {
        if (!flagHasStockListings)
          {
            flagHasStockListings = true;
            storeStockListings.Clear();
          }
        Debug.Assert(flagHasStockListings);
        storeStockListings.Add(to_append);
      }
    public void unsetStockListings()
      {
        flagHasStockListings = false;
        storeStockListings.Clear();
      }
    public void initRequestedListings()
      {
        if (flagHasRequestedListings)
          {
            for (int num3 = 0; num3 < storeRequestedListings.Count; ++num3)
              {
              }
          }
        flagHasRequestedListings = true;
        storeRequestedListings.Clear();
      }
    public void appendRequestedListings(StockConversationRequestedListingJSON  to_append)
      {
        if (!flagHasRequestedListings)
          {
            flagHasRequestedListings = true;
            storeRequestedListings.Clear();
          }
        Debug.Assert(flagHasRequestedListings);
        storeRequestedListings.Add(to_append);
      }
    public void unsetRequestedListings()
      {
        if (flagHasRequestedListings)
          {
            for (int num4 = 0; num4 < storeRequestedListings.Count; ++num4)
              {
              }
          }
        flagHasRequestedListings = false;
        storeRequestedListings.Clear();
      }
    public void setMonetaryAmount(MoneyJSON  new_value)
      {
        if (flagHasMonetaryAmount)
          {
          }
        flagHasMonetaryAmount = true;
        storeMonetaryAmount = new_value;
      }
    public void unsetMonetaryAmount()
      {
        if (flagHasMonetaryAmount)
          {
          }
        flagHasMonetaryAmount = false;
      }
    public void initStockEntitiesData()
      {
        if (flagHasStockEntitiesData)
          {
            for (int num5 = 0; num5 < storeStockEntitiesData.Count; ++num5)
              {
              }
          }
        flagHasStockEntitiesData = true;
        storeStockEntitiesData.Clear();
      }
    public void appendStockEntitiesData(StockEntityDataJSON  to_append)
      {
        if (!flagHasStockEntitiesData)
          {
            flagHasStockEntitiesData = true;
            storeStockEntitiesData.Clear();
          }
        Debug.Assert(flagHasStockEntitiesData);
        storeStockEntitiesData.Add(to_append);
      }
    public void unsetStockEntitiesData()
      {
        if (flagHasStockEntitiesData)
          {
            for (int num6 = 0; num6 < storeStockEntitiesData.Count; ++num6)
              {
              }
          }
        flagHasStockEntitiesData = false;
        storeStockEntitiesData.Clear();
      }

    public virtual void extraStockMarketConversationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockMarketConversationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockMarketConversationLookup(key);
        if (old_field == null)
          {
            extraStockMarketConversationAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStockAttributes);
        if (flagHasStockAttributes)
          {
            handler.start_pair("StockAttributes");
            handler.string_value(storeStockAttributes);
          }
        Debug.Assert(partial_allowed || flagHasCompoundAttributes);
        if (flagHasCompoundAttributes)
          {
            handler.start_pair("CompoundAttributes");
            handler.start_array();
            for (int num1 = 0; num1 < storeCompoundAttributes.Count; ++num1)
              {
                if (partial_allowed)
                    storeCompoundAttributes[num1].write_partial_as_json(handler);
                else
                    storeCompoundAttributes[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasStockListings);
        if (flagHasStockListings)
          {
            handler.start_pair("StockListings");
            handler.start_array();
            for (int num2 = 0; num2 < storeStockListings.Count; ++num2)
              {
                handler.string_value(storeStockListings[num2]);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasRequestedListings);
        if (flagHasRequestedListings)
          {
            handler.start_pair("RequestedListings");
            handler.start_array();
            for (int num3 = 0; num3 < storeRequestedListings.Count; ++num3)
              {
                if (partial_allowed)
                    storeRequestedListings[num3].write_partial_as_json(handler);
                else
                    storeRequestedListings[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasMonetaryAmount)
          {
            handler.start_pair("MonetaryAmount");
            if (partial_allowed)
                storeMonetaryAmount.write_partial_as_json(handler);
            else
                storeMonetaryAmount.write_as_json(handler);
          }
        if (flagHasStockEntitiesData)
          {
            handler.start_pair("StockEntitiesData");
            handler.start_array();
            for (int num4 = 0; num4 < storeStockEntitiesData.Count; ++num4)
              {
                if (partial_allowed)
                    storeStockEntitiesData[num4].write_partial_as_json(handler);
                else
                    storeStockEntitiesData[num4].write_as_json(handler);
              }
            handler.finish_array();
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
        if (!(hasStockAttributes()))
          {
            return "When parsing the object for %what%, the \"StockAttributes\" field was missing.";
          }
        if (!(hasCompoundAttributes()))
          {
            return "When parsing the object for %what%, the \"CompoundAttributes\" field was missing.";
          }
        if (!(hasStockListings()))
          {
            return "When parsing the object for %what%, the \"StockListings\" field was missing.";
          }
        if (!(hasRequestedListings()))
          {
            return "When parsing the object for %what%, the \"RequestedListings\" field was missing.";
          }
        return null;
      }

    public static StockMarketConversationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockMarketConversationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockMarketConversation", ignore_extras);
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
    public static StockMarketConversationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockMarketConversationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockMarketConversationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockMarketConversation", ignore_extras);
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
    public static StockMarketConversationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockMarketConversationJSON from_text(string text, bool ignore_extras)
      {
        StockMarketConversationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockMarketConversation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockMarketConversationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StockMarketConversationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockMarketConversationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockMarketConversation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorStockAttributes : JSONStringGenerator
          {
            private Regex checker;
            protected FieldGeneratorStockAttributes()  { checker = new Regex("^([0-8]( [0-8])*)?$"); }
            protected FieldGeneratorStockAttributes(string  what) : base(what) { checker = new Regex("^([0-8]( [0-8])*)?$"); }
            protected void validate(string result)
              {
                if (!(checker.IsMatch(result)))
                    error("The string for %what% doesn't match the required pattern @^([0-8]( [0-8])*)?$@.");
              }
          };
    private class FieldHoldingGeneratorStockAttributes : FieldGeneratorStockAttributes
  {
    protected override void handle_result(string result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorStockAttributes(String what)
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
    public string value;
  };
    private class FieldHoldingArrayGeneratorStockAttributes : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorStockAttributes
      {
        private FieldHoldingArrayGeneratorStockAttributes top;

        protected override void handle_result(string result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorStockAttributes init_top)
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
    protected virtual void handle_result(List<string> result)
      {
      }

    public FieldHoldingArrayGeneratorStockAttributes(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorStockAttributes()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<string> value;
  };
        private FieldHoldingGeneratorStockAttributes fieldGeneratorStockAttributes;
        private CompoundStockAttributeJSON.HoldingArrayGenerator fieldGeneratorCompoundAttributes;
    private abstract class FieldGeneratorStockListings : JSONStringGenerator
          {
            private Regex checker;
            protected FieldGeneratorStockListings()  { checker = new Regex("^[0-1] [0-9]+ [0-9]+ [0-1]( [0-9]+)?$"); }
            protected FieldGeneratorStockListings(string  what) : base(what) { checker = new Regex("^[0-1] [0-9]+ [0-9]+ [0-1]( [0-9]+)?$"); }
            protected void validate(string result)
              {
                if (!(checker.IsMatch(result)))
                    error("The string for %what% doesn't match the required pattern @^[0-1] [0-9]+ [0-9]+ [0-1]( [0-9]+)?$@.");
              }
          };
    private class FieldHoldingGeneratorStockListings : FieldGeneratorStockListings
  {
    protected override void handle_result(string result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorStockListings(String what)
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
    public string value;
  };
    private class FieldHoldingArrayGeneratorStockListings : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorStockListings
      {
        private FieldHoldingArrayGeneratorStockListings top;

        protected override void handle_result(string result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorStockListings init_top)
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
    protected virtual void handle_result(List<string> result)
      {
      }

    public FieldHoldingArrayGeneratorStockListings(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorStockListings()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<string> value;
  };
        private FieldHoldingArrayGeneratorStockListings fieldGeneratorStockListings;
        private StockConversationRequestedListingJSON.HoldingArrayGenerator fieldGeneratorRequestedListings;
        private MoneyJSON.HoldingGenerator fieldGeneratorMonetaryAmount;
        private StockEntityDataJSON.HoldingArrayGenerator fieldGeneratorStockEntitiesData;
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
            StockMarketConversationJSON result = new StockMarketConversationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockMarketConversationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StockMarketConversationJSON result)
          {
            if (fieldGeneratorStockAttributes.have_value)
              {
                result.setStockAttributes(fieldGeneratorStockAttributes.value);
                fieldGeneratorStockAttributes.have_value = false;
              }
            else if ((!(result.hasStockAttributes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StockAttributes\" field was missing.");
              }
            if (fieldGeneratorCompoundAttributes.have_value)
              {
                result.initCompoundAttributes();
                int count = fieldGeneratorCompoundAttributes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCompoundAttributes(fieldGeneratorCompoundAttributes.value[num]);
                  }
                fieldGeneratorCompoundAttributes.value.Clear();
                fieldGeneratorCompoundAttributes.have_value = false;
              }
            else if ((!(result.hasCompoundAttributes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CompoundAttributes\" field was missing.");
              }
            if (fieldGeneratorStockListings.have_value)
              {
                result.initStockListings();
                int count = fieldGeneratorStockListings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStockListings(fieldGeneratorStockListings.value[num]);
                  }
                fieldGeneratorStockListings.value.Clear();
                fieldGeneratorStockListings.have_value = false;
              }
            else if ((!(result.hasStockListings())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StockListings\" field was missing.");
              }
            if (fieldGeneratorRequestedListings.have_value)
              {
                result.initRequestedListings();
                int count = fieldGeneratorRequestedListings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRequestedListings(fieldGeneratorRequestedListings.value[num]);
                  }
                fieldGeneratorRequestedListings.value.Clear();
                fieldGeneratorRequestedListings.have_value = false;
              }
            else if ((!(result.hasRequestedListings())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedListings\" field was missing.");
              }
            if (fieldGeneratorMonetaryAmount.have_value)
              {
                result.setMonetaryAmount(fieldGeneratorMonetaryAmount.value);
                fieldGeneratorMonetaryAmount.have_value = false;
              }
            if (fieldGeneratorStockEntitiesData.have_value)
              {
                result.initStockEntitiesData();
                int count = fieldGeneratorStockEntitiesData.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStockEntitiesData(fieldGeneratorStockEntitiesData.value[num]);
                  }
                fieldGeneratorStockEntitiesData.value.Clear();
                fieldGeneratorStockEntitiesData.have_value = false;
              }
          }
        protected abstract void handle_result(StockMarketConversationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ompoundAttributes", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorCompoundAttributes;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "onetaryAmount", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorMonetaryAmount;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equestedListings", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorRequestedListings;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "tock", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 6, "ttributes", 0, 9, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorStockAttributes;
                                break;
                            case 'E':
                                if ((String.Compare(field_name, 6, "ntitiesData", 0, 11, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorStockEntitiesData;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 6, "istings", 0, 7, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorStockListings;
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
            fieldGeneratorStockAttributes = new FieldHoldingGeneratorStockAttributes("field \"StockAttributes\" of the StockMarketConversation class");
            fieldGeneratorCompoundAttributes = new CompoundStockAttributeJSON.HoldingArrayGenerator("field \"CompoundAttributes\" of the StockMarketConversation class", ignore_extras);
            fieldGeneratorStockListings = new FieldHoldingArrayGeneratorStockListings("field \"StockListings\" of the StockMarketConversation class");
            fieldGeneratorRequestedListings = new StockConversationRequestedListingJSON.HoldingArrayGenerator("field \"RequestedListings\" of the StockMarketConversation class", ignore_extras);
            fieldGeneratorMonetaryAmount = new MoneyJSON.HoldingGenerator("field \"MonetaryAmount\" of the StockMarketConversation class", ignore_extras);
            fieldGeneratorStockEntitiesData = new StockEntityDataJSON.HoldingArrayGenerator("field \"StockEntitiesData\" of the StockMarketConversation class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockMarketConversation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStockAttributes = new FieldHoldingGeneratorStockAttributes("field \"StockAttributes\" of the StockMarketConversation class");
            fieldGeneratorCompoundAttributes = new CompoundStockAttributeJSON.HoldingArrayGenerator("field \"CompoundAttributes\" of the StockMarketConversation class", false);
            fieldGeneratorStockListings = new FieldHoldingArrayGeneratorStockListings("field \"StockListings\" of the StockMarketConversation class");
            fieldGeneratorRequestedListings = new StockConversationRequestedListingJSON.HoldingArrayGenerator("field \"RequestedListings\" of the StockMarketConversation class", false);
            fieldGeneratorMonetaryAmount = new MoneyJSON.HoldingGenerator("field \"MonetaryAmount\" of the StockMarketConversation class", false);
            fieldGeneratorStockEntitiesData = new StockEntityDataJSON.HoldingArrayGenerator("field \"StockEntitiesData\" of the StockMarketConversation class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockMarketConversation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStockAttributes.reset();
            fieldGeneratorCompoundAttributes.reset();
            fieldGeneratorStockListings.reset();
            fieldGeneratorRequestedListings.reset();
            fieldGeneratorMonetaryAmount.reset();
            fieldGeneratorStockEntitiesData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorCompoundAttributes.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestedListings.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMonetaryAmount.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStockEntitiesData.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorCompoundAttributes.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestedListings.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMonetaryAmount.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStockEntitiesData.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(StockMarketConversationJSON  result)
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
        public StockMarketConversationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockMarketConversationJSON  result)
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
    protected virtual void handle_result(List<StockMarketConversationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockMarketConversationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockMarketConversationJSON>();
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
    public List<StockMarketConversationJSON> value;
  };
  };
