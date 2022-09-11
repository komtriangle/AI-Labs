/* file "StockRequestedListingJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StockRequestedListingJSON : JSONBase
  {
    public struct TypeRemoteDelay
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public double choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    private bool flagHasStockListing;
    private StockListingJSON  storeStockListing;
    private bool flagHasListingRequestType;
    private StockListingRequestTypeJSON  storeListingRequestType;
    private bool flagHasExchangeExplicit;
    private bool storeExchangeExplicit;
    private bool flagHasPrimaryHasData;
    private bool storePrimaryHasData;
    private bool flagHasAllowDataWarnings;
    private bool storeAllowDataWarnings;
    private bool flagHasAlternateListing;
    private StockListingJSON  storeAlternateListing;
    private bool flagHasRemoteDelay;
    private List< TypeRemoteDelay > storeRemoteDelay;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStockListing(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockListingJSON convert_classy = StockListingJSON.from_json(json_value, ignore_extras, true);
        setStockListing(convert_classy);
      }


    private void  fromJSONListingRequestType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockListingRequestTypeJSON convert_classy = StockListingRequestTypeJSON.from_json(json_value, ignore_extras, true);
        setListingRequestType(convert_classy);
      }


    private void  fromJSONExchangeExplicit(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ExchangeExplicit of StockRequestedListingJSON is not true for false.");
              }
          }
        setExchangeExplicit(the_bool);
      }


    private void  fromJSONPrimaryHasData(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PrimaryHasData of StockRequestedListingJSON is not true for false.");
              }
          }
        setPrimaryHasData(the_bool);
      }


    private void  fromJSONAllowDataWarnings(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AllowDataWarnings of StockRequestedListingJSON is not true for false.");
              }
          }
        setAllowDataWarnings(the_bool);
      }


    private void  fromJSONAlternateListing(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockListingJSON convert_classy = StockListingJSON.from_json(json_value, ignore_extras, true);
        setAlternateListing(convert_classy);
      }


    private void  fromJSONRemoteDelay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RemoteDelay of StockRequestedListingJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeRemoteDelay > vector_RemoteDelay1 = new List< TypeRemoteDelay >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeRemoteDelay or_result = new TypeRemoteDelay();
            bool or_done = false;
            if (!or_done)
              {
                try
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
                            throw new Exception("The value for ??? is not a number.");
                          }
                      }
                    or_result.u.choice0 = the_double;
                    or_result.key = 0;
                    or_done = true;
                  }
                catch (Exception )
                  {
                  }
              }
            if (!or_done)
              {
                try
                  {
                    or_result.key = 1;
                    or_done = true;
                  }
                catch (Exception )
                  {
                  }
              }
            if (!or_done)
                throw new Exception("The value for an element of field RemoteDelay of StockRequestedListingJSON is not one of the allowed values.");
            vector_RemoteDelay1.Add(or_result);
          }
        initRemoteDelay();
        for (int num1 = 0; num1 < vector_RemoteDelay1.Count; ++num1)
            appendRemoteDelay(vector_RemoteDelay1[num1]);
        for (int num1 = 0; num1 < vector_RemoteDelay1.Count; ++num1)
          {
            switch (vector_RemoteDelay1[num1].key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
      }


    public StockRequestedListingJSON()
      {
        flagHasStockListing = false;
        flagHasListingRequestType = false;
        flagHasExchangeExplicit = false;
        flagHasPrimaryHasData = false;
        flagHasAllowDataWarnings = false;
        flagHasAlternateListing = false;
        flagHasRemoteDelay = false;
        storeRemoteDelay = new List< TypeRemoteDelay >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStockListing()
      {
        return flagHasStockListing;
      }

    public StockListingJSON   getStockListing()
      {
        Debug.Assert(flagHasStockListing);
        return storeStockListing;
      }

    public bool  hasListingRequestType()
      {
        return flagHasListingRequestType;
      }

    public StockListingRequestTypeJSON   getListingRequestType()
      {
        Debug.Assert(flagHasListingRequestType);
        return storeListingRequestType;
      }

    public StockListingRequestTypeJSON.TypeValue  getListingRequestTypeValue()
      {
        return getListingRequestType().getValue();
      }

    public string  getListingRequestTypeAsString()
      {
        return getListingRequestType().getValueAsString();
      }

    public bool  hasExchangeExplicit()
      {
        return flagHasExchangeExplicit;
      }

    public bool  getExchangeExplicit()
      {
        Debug.Assert(flagHasExchangeExplicit);
        return storeExchangeExplicit;
      }

    public bool  hasPrimaryHasData()
      {
        return flagHasPrimaryHasData;
      }

    public bool  getPrimaryHasData()
      {
        Debug.Assert(flagHasPrimaryHasData);
        return storePrimaryHasData;
      }

    public bool  hasAllowDataWarnings()
      {
        return flagHasAllowDataWarnings;
      }

    public bool  getAllowDataWarnings()
      {
        Debug.Assert(flagHasAllowDataWarnings);
        return storeAllowDataWarnings;
      }

    public bool  hasAlternateListing()
      {
        return flagHasAlternateListing;
      }

    public StockListingJSON   getAlternateListing()
      {
        Debug.Assert(flagHasAlternateListing);
        return storeAlternateListing;
      }

    public bool  hasRemoteDelay()
      {
        return flagHasRemoteDelay;
      }

    public int  countOfRemoteDelay()
      {
        Debug.Assert(flagHasRemoteDelay);
        return storeRemoteDelay.Count;
      }

    public TypeRemoteDelay  elementOfRemoteDelay(int element_num)
      {
        Debug.Assert(flagHasRemoteDelay);
        return storeRemoteDelay[element_num];
      }

    public List< TypeRemoteDelay >  getRemoteDelay()
      {
        Debug.Assert(flagHasRemoteDelay);
        return storeRemoteDelay;
      }


    public virtual int extraStockRequestedListingComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockRequestedListingComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockRequestedListingComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockRequestedListingLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setStockListing(StockListingJSON  new_value)
      {
        if (flagHasStockListing)
          {
          }
        flagHasStockListing = true;
        storeStockListing = new_value;
      }
    public void unsetStockListing()
      {
        if (flagHasStockListing)
          {
          }
        flagHasStockListing = false;
      }
    public void setListingRequestType(StockListingRequestTypeJSON  new_value)
      {
        if (flagHasListingRequestType)
          {
          }
        flagHasListingRequestType = true;
        storeListingRequestType = new_value;
      }
    public void setListingRequestType(StockListingRequestTypeJSON.TypeValue new_value)
      {
        setListingRequestType(new StockListingRequestTypeJSON(new_value));
      }
    public void setListingRequestType(string chars)
      {
        StockListingRequestTypeJSON.TypeValueKnownValues known = StockListingRequestTypeJSON.stringToValue(chars);
        StockListingRequestTypeJSON.TypeValue new_value = new StockListingRequestTypeJSON.TypeValue();
        if (known == StockListingRequestTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setListingRequestType(new_value);
      }
    public void unsetListingRequestType()
      {
        if (flagHasListingRequestType)
          {
          }
        flagHasListingRequestType = false;
      }
    public void setExchangeExplicit(bool new_value)
      {
        flagHasExchangeExplicit = true;
        storeExchangeExplicit = new_value;
      }
    public void unsetExchangeExplicit()
      {
        flagHasExchangeExplicit = false;
      }
    public void setPrimaryHasData(bool new_value)
      {
        flagHasPrimaryHasData = true;
        storePrimaryHasData = new_value;
      }
    public void unsetPrimaryHasData()
      {
        flagHasPrimaryHasData = false;
      }
    public void setAllowDataWarnings(bool new_value)
      {
        flagHasAllowDataWarnings = true;
        storeAllowDataWarnings = new_value;
      }
    public void unsetAllowDataWarnings()
      {
        flagHasAllowDataWarnings = false;
      }
    public void setAlternateListing(StockListingJSON  new_value)
      {
        if (flagHasAlternateListing)
          {
          }
        flagHasAlternateListing = true;
        storeAlternateListing = new_value;
      }
    public void unsetAlternateListing()
      {
        if (flagHasAlternateListing)
          {
          }
        flagHasAlternateListing = false;
      }
    public void initRemoteDelay()
      {
        flagHasRemoteDelay = true;
        storeRemoteDelay.Clear();
      }
    public void appendRemoteDelay(TypeRemoteDelay to_append)
      {
        if (!flagHasRemoteDelay)
          {
            flagHasRemoteDelay = true;
            storeRemoteDelay.Clear();
          }
        Debug.Assert(flagHasRemoteDelay);
        storeRemoteDelay.Add(to_append);
      }
    public void unsetRemoteDelay()
      {
        flagHasRemoteDelay = false;
        storeRemoteDelay.Clear();
      }

    public virtual void extraStockRequestedListingAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockRequestedListingSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockRequestedListingLookup(key);
        if (old_field == null)
          {
            extraStockRequestedListingAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStockListing);
        if (flagHasStockListing)
          {
            handler.start_pair("StockListing");
            if (partial_allowed)
                storeStockListing.write_partial_as_json(handler);
            else
                storeStockListing.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasListingRequestType);
        if (flagHasListingRequestType)
          {
            handler.start_pair("ListingRequestType");
            if (partial_allowed)
                storeListingRequestType.write_partial_as_json(handler);
            else
                storeListingRequestType.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasExchangeExplicit);
        if (flagHasExchangeExplicit)
          {
            handler.start_pair("ExchangeExplicit");
            handler.boolean_value(storeExchangeExplicit);
          }
        Debug.Assert(partial_allowed || flagHasPrimaryHasData);
        if (flagHasPrimaryHasData)
          {
            handler.start_pair("PrimaryHasData");
            handler.boolean_value(storePrimaryHasData);
          }
        Debug.Assert(partial_allowed || flagHasAllowDataWarnings);
        if (flagHasAllowDataWarnings)
          {
            handler.start_pair("AllowDataWarnings");
            handler.boolean_value(storeAllowDataWarnings);
          }
        if (flagHasAlternateListing)
          {
            handler.start_pair("AlternateListing");
            if (partial_allowed)
                storeAlternateListing.write_partial_as_json(handler);
            else
                storeAlternateListing.write_as_json(handler);
          }
        if (flagHasRemoteDelay)
          {
            handler.start_pair("RemoteDelay");
            handler.start_array();
            for (int num1 = 0; num1 < storeRemoteDelay.Count; ++num1)
              {
                switch (storeRemoteDelay[num1].key)
                  {
                    case 0:
                        if (((double)(long)storeRemoteDelay[num1].u.choice0) == storeRemoteDelay[num1].u.choice0)
                            handler.number_value((long)storeRemoteDelay[num1].u.choice0);
                        else
                            handler.number_value(storeRemoteDelay[num1].u.choice0);
                        break;
                    case 1:
                        handler.null_value();
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
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
        if (!(hasStockListing()))
          {
            return "When parsing the object for %what%, the \"StockListing\" field was missing.";
          }
        if (!(hasListingRequestType()))
          {
            return "When parsing the object for %what%, the \"ListingRequestType\" field was missing.";
          }
        if (!(hasExchangeExplicit()))
          {
            return "When parsing the object for %what%, the \"ExchangeExplicit\" field was missing.";
          }
        if (!(hasPrimaryHasData()))
          {
            return "When parsing the object for %what%, the \"PrimaryHasData\" field was missing.";
          }
        if (!(hasAllowDataWarnings()))
          {
            return "When parsing the object for %what%, the \"AllowDataWarnings\" field was missing.";
          }
        return null;
      }

    public static StockRequestedListingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockRequestedListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockRequestedListing", ignore_extras);
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
    public static StockRequestedListingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockRequestedListingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockRequestedListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockRequestedListing", ignore_extras);
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
    public static StockRequestedListingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockRequestedListingJSON from_text(string text, bool ignore_extras)
      {
        StockRequestedListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockRequestedListing", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockRequestedListingJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StockRequestedListingJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockRequestedListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockRequestedListing", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private StockListingJSON.HoldingGenerator fieldGeneratorStockListing;
        private StockListingRequestTypeJSON.HoldingGenerator fieldGeneratorListingRequestType;
        private JSONHoldingBooleanGenerator fieldGeneratorExchangeExplicit;
        private JSONHoldingBooleanGenerator fieldGeneratorPrimaryHasData;
        private JSONHoldingBooleanGenerator fieldGeneratorAllowDataWarnings;
        private StockListingJSON.HoldingGenerator fieldGeneratorAlternateListing;
    private abstract class FieldGeneratorRemoteDelay : JSONParallelGenerator
          {
            private JSONHoldingNumberTextGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeRemoteDelay result = new TypeRemoteDelay();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = Double.Parse(field0.value);
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeRemoteDelay result);
            public FieldGeneratorRemoteDelay(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"RemoteDelay\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"RemoteDelay\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorRemoteDelay(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"RemoteDelay\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"RemoteDelay\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderRemoteDelay
          {
            private bool have_data;
            private TypeRemoteDelay data;
            public HolderRemoteDelay()  { have_data = false; }
            public HolderRemoteDelay(TypeRemoteDelay init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderRemoteDelay(HolderRemoteDelay other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeRemoteDelay referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorRemoteDelay : FieldGeneratorRemoteDelay
          {
            protected override void handle_result(TypeRemoteDelay result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderRemoteDelay(result);
              }

            public FieldHoldingGeneratorRemoteDelay(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderRemoteDelay value;
          };
    private class FieldHoldingArrayGeneratorRemoteDelay : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorRemoteDelay
      {
        private FieldHoldingArrayGeneratorRemoteDelay top;

        protected override void handle_result(TypeRemoteDelay result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorRemoteDelay init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeRemoteDelay> result)
      {
      }

    public FieldHoldingArrayGeneratorRemoteDelay(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeRemoteDelay>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorRemoteDelay(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeRemoteDelay>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeRemoteDelay> value;
  };
        private FieldHoldingArrayGeneratorRemoteDelay fieldGeneratorRemoteDelay;
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
            StockRequestedListingJSON result = new StockRequestedListingJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockRequestedListingAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StockRequestedListingJSON result)
          {
            if (fieldGeneratorStockListing.have_value)
              {
                result.setStockListing(fieldGeneratorStockListing.value);
                fieldGeneratorStockListing.have_value = false;
              }
            else if ((!(result.hasStockListing())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StockListing\" field was missing.");
              }
            if (fieldGeneratorListingRequestType.have_value)
              {
                result.setListingRequestType(fieldGeneratorListingRequestType.value);
                fieldGeneratorListingRequestType.have_value = false;
              }
            else if ((!(result.hasListingRequestType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ListingRequestType\" field was missing.");
              }
            if (fieldGeneratorExchangeExplicit.have_value)
              {
                result.setExchangeExplicit(fieldGeneratorExchangeExplicit.value);
                fieldGeneratorExchangeExplicit.have_value = false;
              }
            else if ((!(result.hasExchangeExplicit())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ExchangeExplicit\" field was missing.");
              }
            if (fieldGeneratorPrimaryHasData.have_value)
              {
                result.setPrimaryHasData(fieldGeneratorPrimaryHasData.value);
                fieldGeneratorPrimaryHasData.have_value = false;
              }
            else if ((!(result.hasPrimaryHasData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PrimaryHasData\" field was missing.");
              }
            if (fieldGeneratorAllowDataWarnings.have_value)
              {
                result.setAllowDataWarnings(fieldGeneratorAllowDataWarnings.value);
                fieldGeneratorAllowDataWarnings.have_value = false;
              }
            else if ((!(result.hasAllowDataWarnings())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AllowDataWarnings\" field was missing.");
              }
            if (fieldGeneratorAlternateListing.have_value)
              {
                result.setAlternateListing(fieldGeneratorAlternateListing.value);
                fieldGeneratorAlternateListing.have_value = false;
              }
            if (fieldGeneratorRemoteDelay.have_value)
              {
                result.initRemoteDelay();
                int count = fieldGeneratorRemoteDelay.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRemoteDelay(fieldGeneratorRemoteDelay.value[num]);
                  }
                fieldGeneratorRemoteDelay.value.Clear();
                fieldGeneratorRemoteDelay.have_value = false;
              }
          }
        protected abstract void handle_result(StockRequestedListingJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "l", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'l':
                                if ((String.Compare(field_name, 3, "owDataWarnings", 0, 14, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorAllowDataWarnings;
                                break;
                            case 't':
                                if ((String.Compare(field_name, 3, "ernateListing", 0, 13, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorAlternateListing;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "xchangeExplicit", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorExchangeExplicit;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "istingRequestType", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorListingRequestType;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "rimaryHasData", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorPrimaryHasData;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "emoteDelay", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorRemoteDelay;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tockListing", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorStockListing;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorStockListing = new StockListingJSON.HoldingGenerator("field \"StockListing\" of the StockRequestedListing class", ignore_extras);
            fieldGeneratorListingRequestType = new StockListingRequestTypeJSON.HoldingGenerator("field \"ListingRequestType\" of the StockRequestedListing class", ignore_extras);
            fieldGeneratorExchangeExplicit = new JSONHoldingBooleanGenerator("field \"ExchangeExplicit\" of the StockRequestedListing class");
            fieldGeneratorPrimaryHasData = new JSONHoldingBooleanGenerator("field \"PrimaryHasData\" of the StockRequestedListing class");
            fieldGeneratorAllowDataWarnings = new JSONHoldingBooleanGenerator("field \"AllowDataWarnings\" of the StockRequestedListing class");
            fieldGeneratorAlternateListing = new StockListingJSON.HoldingGenerator("field \"AlternateListing\" of the StockRequestedListing class", ignore_extras);
            fieldGeneratorRemoteDelay = new FieldHoldingArrayGeneratorRemoteDelay("field \"RemoteDelay\" of the StockRequestedListing class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockRequestedListing class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStockListing = new StockListingJSON.HoldingGenerator("field \"StockListing\" of the StockRequestedListing class", false);
            fieldGeneratorListingRequestType = new StockListingRequestTypeJSON.HoldingGenerator("field \"ListingRequestType\" of the StockRequestedListing class", false);
            fieldGeneratorExchangeExplicit = new JSONHoldingBooleanGenerator("field \"ExchangeExplicit\" of the StockRequestedListing class");
            fieldGeneratorPrimaryHasData = new JSONHoldingBooleanGenerator("field \"PrimaryHasData\" of the StockRequestedListing class");
            fieldGeneratorAllowDataWarnings = new JSONHoldingBooleanGenerator("field \"AllowDataWarnings\" of the StockRequestedListing class");
            fieldGeneratorAlternateListing = new StockListingJSON.HoldingGenerator("field \"AlternateListing\" of the StockRequestedListing class", false);
            fieldGeneratorRemoteDelay = new FieldHoldingArrayGeneratorRemoteDelay("field \"RemoteDelay\" of the StockRequestedListing class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockRequestedListing class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStockListing.reset();
            fieldGeneratorListingRequestType.reset();
            fieldGeneratorExchangeExplicit.reset();
            fieldGeneratorPrimaryHasData.reset();
            fieldGeneratorAllowDataWarnings.reset();
            fieldGeneratorAlternateListing.reset();
            fieldGeneratorRemoteDelay.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorStockListing.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorListingRequestType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAlternateListing.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorStockListing.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorListingRequestType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAlternateListing.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(StockRequestedListingJSON  result)
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
        public StockRequestedListingJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockRequestedListingJSON  result)
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
    protected virtual void handle_result(List<StockRequestedListingJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockRequestedListingJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockRequestedListingJSON>();
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
    public List<StockRequestedListingJSON> value;
  };
  };
