/* file "StockQueryBlockJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StockQueryBlockJSON : JSONBase
  {
    private bool flagHasOldConversation;
    private bool storeOldConversation;
    private bool flagHasRequestedAttributes;
    private List< CompoundStockAttributeJSON  > storeRequestedAttributes;
    private bool flagHasRequestedListings;
    private List< StockRequestedListingJSON  > storeRequestedListings;
    private bool flagHasInvalidListings;
    private List< StockInvalidListingJSON  > storeInvalidListings;
    private bool flagHasGeneralMarketQuery;
    private bool storeGeneralMarketQuery;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONOldConversation(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OldConversation of StockQueryBlockJSON is not true for false.");
              }
          }
        setOldConversation(the_bool);
      }


    private void  fromJSONRequestedAttributes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RequestedAttributes of StockQueryBlockJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< CompoundStockAttributeJSON  > vector_RequestedAttributes1 = new List< CompoundStockAttributeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CompoundStockAttributeJSON convert_classy = CompoundStockAttributeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RequestedAttributes1.Add(convert_classy);
          }
        initRequestedAttributes();
        for (int num1 = 0; num1 < vector_RequestedAttributes1.Count; ++num1)
            appendRequestedAttributes(vector_RequestedAttributes1[num1]);
        for (int num1 = 0; num1 < vector_RequestedAttributes1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRequestedListings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RequestedListings of StockQueryBlockJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< StockRequestedListingJSON  > vector_RequestedListings1 = new List< StockRequestedListingJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            StockRequestedListingJSON convert_classy = StockRequestedListingJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RequestedListings1.Add(convert_classy);
          }
        initRequestedListings();
        for (int num2 = 0; num2 < vector_RequestedListings1.Count; ++num2)
            appendRequestedListings(vector_RequestedListings1[num2]);
        for (int num1 = 0; num1 < vector_RequestedListings1.Count; ++num1)
          {
          }
      }


    private void  fromJSONInvalidListings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InvalidListings of StockQueryBlockJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< StockInvalidListingJSON  > vector_InvalidListings1 = new List< StockInvalidListingJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            StockInvalidListingJSON convert_classy = StockInvalidListingJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_InvalidListings1.Add(convert_classy);
          }
        initInvalidListings();
        for (int num3 = 0; num3 < vector_InvalidListings1.Count; ++num3)
            appendInvalidListings(vector_InvalidListings1[num3]);
        for (int num1 = 0; num1 < vector_InvalidListings1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGeneralMarketQuery(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field GeneralMarketQuery of StockQueryBlockJSON is not true for false.");
              }
          }
        setGeneralMarketQuery(the_bool);
      }


    public StockQueryBlockJSON()
      {
        flagHasOldConversation = false;
        flagHasRequestedAttributes = false;
        flagHasRequestedListings = false;
        flagHasInvalidListings = false;
        flagHasGeneralMarketQuery = false;
        storeRequestedAttributes = new List< CompoundStockAttributeJSON  >();
        storeRequestedListings = new List< StockRequestedListingJSON  >();
        storeInvalidListings = new List< StockInvalidListingJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasOldConversation()
      {
        return flagHasOldConversation;
      }

    public bool  getOldConversation()
      {
        Debug.Assert(flagHasOldConversation);
        return storeOldConversation;
      }

    public bool  hasRequestedAttributes()
      {
        return flagHasRequestedAttributes;
      }

    public int  countOfRequestedAttributes()
      {
        Debug.Assert(flagHasRequestedAttributes);
        return storeRequestedAttributes.Count;
      }

    public CompoundStockAttributeJSON   elementOfRequestedAttributes(int element_num)
      {
        Debug.Assert(flagHasRequestedAttributes);
        return storeRequestedAttributes[element_num];
      }

    public List< CompoundStockAttributeJSON  >  getRequestedAttributes()
      {
        Debug.Assert(flagHasRequestedAttributes);
        return storeRequestedAttributes;
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

    public StockRequestedListingJSON   elementOfRequestedListings(int element_num)
      {
        Debug.Assert(flagHasRequestedListings);
        return storeRequestedListings[element_num];
      }

    public List< StockRequestedListingJSON  >  getRequestedListings()
      {
        Debug.Assert(flagHasRequestedListings);
        return storeRequestedListings;
      }

    public bool  hasInvalidListings()
      {
        return flagHasInvalidListings;
      }

    public int  countOfInvalidListings()
      {
        Debug.Assert(flagHasInvalidListings);
        return storeInvalidListings.Count;
      }

    public StockInvalidListingJSON   elementOfInvalidListings(int element_num)
      {
        Debug.Assert(flagHasInvalidListings);
        return storeInvalidListings[element_num];
      }

    public List< StockInvalidListingJSON  >  getInvalidListings()
      {
        Debug.Assert(flagHasInvalidListings);
        return storeInvalidListings;
      }

    public bool  hasGeneralMarketQuery()
      {
        return flagHasGeneralMarketQuery;
      }

    public bool  getGeneralMarketQuery()
      {
        Debug.Assert(flagHasGeneralMarketQuery);
        return storeGeneralMarketQuery;
      }


    public virtual int extraStockQueryBlockComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockQueryBlockComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockQueryBlockComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockQueryBlockLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setOldConversation(bool new_value)
      {
        flagHasOldConversation = true;
        storeOldConversation = new_value;
      }
    public void unsetOldConversation()
      {
        flagHasOldConversation = false;
      }
    public void initRequestedAttributes()
      {
        if (flagHasRequestedAttributes)
          {
            for (int num1 = 0; num1 < storeRequestedAttributes.Count; ++num1)
              {
              }
          }
        flagHasRequestedAttributes = true;
        storeRequestedAttributes.Clear();
      }
    public void appendRequestedAttributes(CompoundStockAttributeJSON  to_append)
      {
        if (!flagHasRequestedAttributes)
          {
            flagHasRequestedAttributes = true;
            storeRequestedAttributes.Clear();
          }
        Debug.Assert(flagHasRequestedAttributes);
        storeRequestedAttributes.Add(to_append);
      }
    public void unsetRequestedAttributes()
      {
        if (flagHasRequestedAttributes)
          {
            for (int num2 = 0; num2 < storeRequestedAttributes.Count; ++num2)
              {
              }
          }
        flagHasRequestedAttributes = false;
        storeRequestedAttributes.Clear();
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
    public void appendRequestedListings(StockRequestedListingJSON  to_append)
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
    public void initInvalidListings()
      {
        if (flagHasInvalidListings)
          {
            for (int num5 = 0; num5 < storeInvalidListings.Count; ++num5)
              {
              }
          }
        flagHasInvalidListings = true;
        storeInvalidListings.Clear();
      }
    public void appendInvalidListings(StockInvalidListingJSON  to_append)
      {
        if (!flagHasInvalidListings)
          {
            flagHasInvalidListings = true;
            storeInvalidListings.Clear();
          }
        Debug.Assert(flagHasInvalidListings);
        storeInvalidListings.Add(to_append);
      }
    public void unsetInvalidListings()
      {
        if (flagHasInvalidListings)
          {
            for (int num6 = 0; num6 < storeInvalidListings.Count; ++num6)
              {
              }
          }
        flagHasInvalidListings = false;
        storeInvalidListings.Clear();
      }
    public void setGeneralMarketQuery(bool new_value)
      {
        flagHasGeneralMarketQuery = true;
        storeGeneralMarketQuery = new_value;
      }
    public void unsetGeneralMarketQuery()
      {
        flagHasGeneralMarketQuery = false;
      }

    public virtual void extraStockQueryBlockAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockQueryBlockSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockQueryBlockLookup(key);
        if (old_field == null)
          {
            extraStockQueryBlockAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasOldConversation);
        if (flagHasOldConversation)
          {
            handler.start_pair("OldConversation");
            handler.boolean_value(storeOldConversation);
          }
        Debug.Assert(partial_allowed || flagHasRequestedAttributes);
        if (flagHasRequestedAttributes)
          {
            handler.start_pair("RequestedAttributes");
            handler.start_array();
            for (int num1 = 0; num1 < storeRequestedAttributes.Count; ++num1)
              {
                if (partial_allowed)
                    storeRequestedAttributes[num1].write_partial_as_json(handler);
                else
                    storeRequestedAttributes[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasRequestedListings);
        if (flagHasRequestedListings)
          {
            handler.start_pair("RequestedListings");
            handler.start_array();
            for (int num2 = 0; num2 < storeRequestedListings.Count; ++num2)
              {
                if (partial_allowed)
                    storeRequestedListings[num2].write_partial_as_json(handler);
                else
                    storeRequestedListings[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasInvalidListings);
        if (flagHasInvalidListings)
          {
            handler.start_pair("InvalidListings");
            handler.start_array();
            for (int num3 = 0; num3 < storeInvalidListings.Count; ++num3)
              {
                if (partial_allowed)
                    storeInvalidListings[num3].write_partial_as_json(handler);
                else
                    storeInvalidListings[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasGeneralMarketQuery)
          {
            handler.start_pair("GeneralMarketQuery");
            handler.boolean_value(storeGeneralMarketQuery);
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
        if (!(hasOldConversation()))
          {
            return "When parsing the object for %what%, the \"OldConversation\" field was missing.";
          }
        if (!(hasRequestedAttributes()))
          {
            return "When parsing the object for %what%, the \"RequestedAttributes\" field was missing.";
          }
        if (!(hasRequestedListings()))
          {
            return "When parsing the object for %what%, the \"RequestedListings\" field was missing.";
          }
        if (!(hasInvalidListings()))
          {
            return "When parsing the object for %what%, the \"InvalidListings\" field was missing.";
          }
        return null;
      }

    public static StockQueryBlockJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockQueryBlockJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockQueryBlock", ignore_extras);
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
    public static StockQueryBlockJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockQueryBlockJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockQueryBlockJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockQueryBlock", ignore_extras);
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
    public static StockQueryBlockJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockQueryBlockJSON from_text(string text, bool ignore_extras)
      {
        StockQueryBlockJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockQueryBlock", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockQueryBlockJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StockQueryBlockJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockQueryBlockJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockQueryBlock", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorOldConversation;
        private CompoundStockAttributeJSON.HoldingArrayGenerator fieldGeneratorRequestedAttributes;
        private StockRequestedListingJSON.HoldingArrayGenerator fieldGeneratorRequestedListings;
        private StockInvalidListingJSON.HoldingArrayGenerator fieldGeneratorInvalidListings;
        private JSONHoldingBooleanGenerator fieldGeneratorGeneralMarketQuery;
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
            StockQueryBlockJSON result = new StockQueryBlockJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockQueryBlockAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StockQueryBlockJSON result)
          {
            if (fieldGeneratorOldConversation.have_value)
              {
                result.setOldConversation(fieldGeneratorOldConversation.value);
                fieldGeneratorOldConversation.have_value = false;
              }
            else if ((!(result.hasOldConversation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OldConversation\" field was missing.");
              }
            if (fieldGeneratorRequestedAttributes.have_value)
              {
                result.initRequestedAttributes();
                int count = fieldGeneratorRequestedAttributes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRequestedAttributes(fieldGeneratorRequestedAttributes.value[num]);
                  }
                fieldGeneratorRequestedAttributes.value.Clear();
                fieldGeneratorRequestedAttributes.have_value = false;
              }
            else if ((!(result.hasRequestedAttributes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedAttributes\" field was missing.");
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
            if (fieldGeneratorInvalidListings.have_value)
              {
                result.initInvalidListings();
                int count = fieldGeneratorInvalidListings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInvalidListings(fieldGeneratorInvalidListings.value[num]);
                  }
                fieldGeneratorInvalidListings.value.Clear();
                fieldGeneratorInvalidListings.have_value = false;
              }
            else if ((!(result.hasInvalidListings())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InvalidListings\" field was missing.");
              }
            if (fieldGeneratorGeneralMarketQuery.have_value)
              {
                result.setGeneralMarketQuery(fieldGeneratorGeneralMarketQuery.value);
                fieldGeneratorGeneralMarketQuery.have_value = false;
              }
          }
        protected abstract void handle_result(StockQueryBlockJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'G':
                    if ((String.Compare(field_name, 1, "eneralMarketQuery", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorGeneralMarketQuery;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nvalidListings", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorInvalidListings;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "ldConversation", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorOldConversation;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "equested", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 10, "ttributes", 0, 9, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorRequestedAttributes;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 10, "istings", 0, 7, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorRequestedListings;
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
            fieldGeneratorOldConversation = new JSONHoldingBooleanGenerator("field \"OldConversation\" of the StockQueryBlock class");
            fieldGeneratorRequestedAttributes = new CompoundStockAttributeJSON.HoldingArrayGenerator("field \"RequestedAttributes\" of the StockQueryBlock class", ignore_extras);
            fieldGeneratorRequestedListings = new StockRequestedListingJSON.HoldingArrayGenerator("field \"RequestedListings\" of the StockQueryBlock class", ignore_extras);
            fieldGeneratorInvalidListings = new StockInvalidListingJSON.HoldingArrayGenerator("field \"InvalidListings\" of the StockQueryBlock class", ignore_extras);
            fieldGeneratorGeneralMarketQuery = new JSONHoldingBooleanGenerator("field \"GeneralMarketQuery\" of the StockQueryBlock class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockQueryBlock class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorOldConversation = new JSONHoldingBooleanGenerator("field \"OldConversation\" of the StockQueryBlock class");
            fieldGeneratorRequestedAttributes = new CompoundStockAttributeJSON.HoldingArrayGenerator("field \"RequestedAttributes\" of the StockQueryBlock class", false);
            fieldGeneratorRequestedListings = new StockRequestedListingJSON.HoldingArrayGenerator("field \"RequestedListings\" of the StockQueryBlock class", false);
            fieldGeneratorInvalidListings = new StockInvalidListingJSON.HoldingArrayGenerator("field \"InvalidListings\" of the StockQueryBlock class", false);
            fieldGeneratorGeneralMarketQuery = new JSONHoldingBooleanGenerator("field \"GeneralMarketQuery\" of the StockQueryBlock class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockQueryBlock class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorOldConversation.reset();
            fieldGeneratorRequestedAttributes.reset();
            fieldGeneratorRequestedListings.reset();
            fieldGeneratorInvalidListings.reset();
            fieldGeneratorGeneralMarketQuery.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorRequestedAttributes.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestedListings.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorInvalidListings.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorRequestedAttributes.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestedListings.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorInvalidListings.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(StockQueryBlockJSON  result)
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
        public StockQueryBlockJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockQueryBlockJSON  result)
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
    protected virtual void handle_result(List<StockQueryBlockJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockQueryBlockJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockQueryBlockJSON>();
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
    public List<StockQueryBlockJSON> value;
  };
  };
