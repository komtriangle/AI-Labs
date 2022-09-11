/* file "StockInvalidListingJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StockInvalidListingJSON : JSONBase
  {
    private bool flagHasSymbol;
    private StockAttributeValueJSON  storeSymbol;
    private bool flagHasShortName;
    private StockAttributeValueJSON  storeShortName;
    private bool flagHasShortPossessiveName;
    private StockAttributeValueJSON  storeShortPossessiveName;
    private bool flagHasMediumName;
    private StockAttributeValueJSON  storeMediumName;
    private bool flagHasLongName;
    private StockAttributeValueJSON  storeLongName;
    private bool flagHasListingRequestType;
    private StockListingRequestTypeJSON  storeListingRequestType;
    private bool flagHasExchangeExplicit;
    private bool storeExchangeExplicit;
    private bool flagHasRequestedStockExchangeShortName;
    private StockAttributeValueJSON  storeRequestedStockExchangeShortName;
    private bool flagHasRequestedStockExchangeLongName;
    private StockAttributeValueJSON  storeRequestedStockExchangeLongName;
    private bool flagHasRequestedStockExchangeSymbol;
    private StockAttributeValueJSON  storeRequestedStockExchangeSymbol;
    private bool flagHasAlternateListing;
    private StockListingJSON  storeAlternateListing;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSymbol(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setSymbol(convert_classy);
      }


    private void  fromJSONShortName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setShortName(convert_classy);
      }


    private void  fromJSONShortPossessiveName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setShortPossessiveName(convert_classy);
      }


    private void  fromJSONMediumName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setMediumName(convert_classy);
      }


    private void  fromJSONLongName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setLongName(convert_classy);
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
                throw new Exception("The value for field ExchangeExplicit of StockInvalidListingJSON is not true for false.");
              }
          }
        setExchangeExplicit(the_bool);
      }


    private void  fromJSONRequestedStockExchangeShortName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setRequestedStockExchangeShortName(convert_classy);
      }


    private void  fromJSONRequestedStockExchangeLongName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setRequestedStockExchangeLongName(convert_classy);
      }


    private void  fromJSONRequestedStockExchangeSymbol(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setRequestedStockExchangeSymbol(convert_classy);
      }


    private void  fromJSONAlternateListing(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockListingJSON convert_classy = StockListingJSON.from_json(json_value, ignore_extras, true);
        setAlternateListing(convert_classy);
      }


    public StockInvalidListingJSON()
      {
        flagHasSymbol = false;
        flagHasShortName = false;
        flagHasShortPossessiveName = false;
        flagHasMediumName = false;
        flagHasLongName = false;
        flagHasListingRequestType = false;
        flagHasExchangeExplicit = false;
        flagHasRequestedStockExchangeShortName = false;
        flagHasRequestedStockExchangeLongName = false;
        flagHasRequestedStockExchangeSymbol = false;
        flagHasAlternateListing = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSymbol()
      {
        return flagHasSymbol;
      }

    public StockAttributeValueJSON   getSymbol()
      {
        Debug.Assert(flagHasSymbol);
        return storeSymbol;
      }

    public bool  hasShortName()
      {
        return flagHasShortName;
      }

    public StockAttributeValueJSON   getShortName()
      {
        Debug.Assert(flagHasShortName);
        return storeShortName;
      }

    public bool  hasShortPossessiveName()
      {
        return flagHasShortPossessiveName;
      }

    public StockAttributeValueJSON   getShortPossessiveName()
      {
        Debug.Assert(flagHasShortPossessiveName);
        return storeShortPossessiveName;
      }

    public bool  hasMediumName()
      {
        return flagHasMediumName;
      }

    public StockAttributeValueJSON   getMediumName()
      {
        Debug.Assert(flagHasMediumName);
        return storeMediumName;
      }

    public bool  hasLongName()
      {
        return flagHasLongName;
      }

    public StockAttributeValueJSON   getLongName()
      {
        Debug.Assert(flagHasLongName);
        return storeLongName;
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

    public bool  hasRequestedStockExchangeShortName()
      {
        return flagHasRequestedStockExchangeShortName;
      }

    public StockAttributeValueJSON   getRequestedStockExchangeShortName()
      {
        Debug.Assert(flagHasRequestedStockExchangeShortName);
        return storeRequestedStockExchangeShortName;
      }

    public bool  hasRequestedStockExchangeLongName()
      {
        return flagHasRequestedStockExchangeLongName;
      }

    public StockAttributeValueJSON   getRequestedStockExchangeLongName()
      {
        Debug.Assert(flagHasRequestedStockExchangeLongName);
        return storeRequestedStockExchangeLongName;
      }

    public bool  hasRequestedStockExchangeSymbol()
      {
        return flagHasRequestedStockExchangeSymbol;
      }

    public StockAttributeValueJSON   getRequestedStockExchangeSymbol()
      {
        Debug.Assert(flagHasRequestedStockExchangeSymbol);
        return storeRequestedStockExchangeSymbol;
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


    public virtual int extraStockInvalidListingComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockInvalidListingComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockInvalidListingComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockInvalidListingLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSymbol(StockAttributeValueJSON  new_value)
      {
        if (flagHasSymbol)
          {
          }
        flagHasSymbol = true;
        storeSymbol = new_value;
      }
    public void unsetSymbol()
      {
        if (flagHasSymbol)
          {
          }
        flagHasSymbol = false;
      }
    public void setShortName(StockAttributeValueJSON  new_value)
      {
        if (flagHasShortName)
          {
          }
        flagHasShortName = true;
        storeShortName = new_value;
      }
    public void unsetShortName()
      {
        if (flagHasShortName)
          {
          }
        flagHasShortName = false;
      }
    public void setShortPossessiveName(StockAttributeValueJSON  new_value)
      {
        if (flagHasShortPossessiveName)
          {
          }
        flagHasShortPossessiveName = true;
        storeShortPossessiveName = new_value;
      }
    public void unsetShortPossessiveName()
      {
        if (flagHasShortPossessiveName)
          {
          }
        flagHasShortPossessiveName = false;
      }
    public void setMediumName(StockAttributeValueJSON  new_value)
      {
        if (flagHasMediumName)
          {
          }
        flagHasMediumName = true;
        storeMediumName = new_value;
      }
    public void unsetMediumName()
      {
        if (flagHasMediumName)
          {
          }
        flagHasMediumName = false;
      }
    public void setLongName(StockAttributeValueJSON  new_value)
      {
        if (flagHasLongName)
          {
          }
        flagHasLongName = true;
        storeLongName = new_value;
      }
    public void unsetLongName()
      {
        if (flagHasLongName)
          {
          }
        flagHasLongName = false;
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
    public void setRequestedStockExchangeShortName(StockAttributeValueJSON  new_value)
      {
        if (flagHasRequestedStockExchangeShortName)
          {
          }
        flagHasRequestedStockExchangeShortName = true;
        storeRequestedStockExchangeShortName = new_value;
      }
    public void unsetRequestedStockExchangeShortName()
      {
        if (flagHasRequestedStockExchangeShortName)
          {
          }
        flagHasRequestedStockExchangeShortName = false;
      }
    public void setRequestedStockExchangeLongName(StockAttributeValueJSON  new_value)
      {
        if (flagHasRequestedStockExchangeLongName)
          {
          }
        flagHasRequestedStockExchangeLongName = true;
        storeRequestedStockExchangeLongName = new_value;
      }
    public void unsetRequestedStockExchangeLongName()
      {
        if (flagHasRequestedStockExchangeLongName)
          {
          }
        flagHasRequestedStockExchangeLongName = false;
      }
    public void setRequestedStockExchangeSymbol(StockAttributeValueJSON  new_value)
      {
        if (flagHasRequestedStockExchangeSymbol)
          {
          }
        flagHasRequestedStockExchangeSymbol = true;
        storeRequestedStockExchangeSymbol = new_value;
      }
    public void unsetRequestedStockExchangeSymbol()
      {
        if (flagHasRequestedStockExchangeSymbol)
          {
          }
        flagHasRequestedStockExchangeSymbol = false;
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

    public virtual void extraStockInvalidListingAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockInvalidListingSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockInvalidListingLookup(key);
        if (old_field == null)
          {
            extraStockInvalidListingAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSymbol);
        if (flagHasSymbol)
          {
            handler.start_pair("Symbol");
            if (partial_allowed)
                storeSymbol.write_partial_as_json(handler);
            else
                storeSymbol.write_as_json(handler);
          }
        if (flagHasShortName)
          {
            handler.start_pair("ShortName");
            if (partial_allowed)
                storeShortName.write_partial_as_json(handler);
            else
                storeShortName.write_as_json(handler);
          }
        if (flagHasShortPossessiveName)
          {
            handler.start_pair("ShortPossessiveName");
            if (partial_allowed)
                storeShortPossessiveName.write_partial_as_json(handler);
            else
                storeShortPossessiveName.write_as_json(handler);
          }
        if (flagHasMediumName)
          {
            handler.start_pair("MediumName");
            if (partial_allowed)
                storeMediumName.write_partial_as_json(handler);
            else
                storeMediumName.write_as_json(handler);
          }
        if (flagHasLongName)
          {
            handler.start_pair("LongName");
            if (partial_allowed)
                storeLongName.write_partial_as_json(handler);
            else
                storeLongName.write_as_json(handler);
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
        if (flagHasRequestedStockExchangeShortName)
          {
            handler.start_pair("RequestedStockExchangeShortName");
            if (partial_allowed)
                storeRequestedStockExchangeShortName.write_partial_as_json(handler);
            else
                storeRequestedStockExchangeShortName.write_as_json(handler);
          }
        if (flagHasRequestedStockExchangeLongName)
          {
            handler.start_pair("RequestedStockExchangeLongName");
            if (partial_allowed)
                storeRequestedStockExchangeLongName.write_partial_as_json(handler);
            else
                storeRequestedStockExchangeLongName.write_as_json(handler);
          }
        if (flagHasRequestedStockExchangeSymbol)
          {
            handler.start_pair("RequestedStockExchangeSymbol");
            if (partial_allowed)
                storeRequestedStockExchangeSymbol.write_partial_as_json(handler);
            else
                storeRequestedStockExchangeSymbol.write_as_json(handler);
          }
        if (flagHasAlternateListing)
          {
            handler.start_pair("AlternateListing");
            if (partial_allowed)
                storeAlternateListing.write_partial_as_json(handler);
            else
                storeAlternateListing.write_as_json(handler);
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
        if (!(hasSymbol()))
          {
            return "When parsing the object for %what%, the \"Symbol\" field was missing.";
          }
        if (!(hasListingRequestType()))
          {
            return "When parsing the object for %what%, the \"ListingRequestType\" field was missing.";
          }
        if (!(hasExchangeExplicit()))
          {
            return "When parsing the object for %what%, the \"ExchangeExplicit\" field was missing.";
          }
        return null;
      }

    public static StockInvalidListingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockInvalidListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockInvalidListing", ignore_extras);
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
    public static StockInvalidListingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockInvalidListingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockInvalidListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockInvalidListing", ignore_extras);
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
    public static StockInvalidListingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockInvalidListingJSON from_text(string text, bool ignore_extras)
      {
        StockInvalidListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockInvalidListing", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockInvalidListingJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StockInvalidListingJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockInvalidListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockInvalidListing", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorSymbol;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorShortName;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorShortPossessiveName;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorMediumName;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorLongName;
        private StockListingRequestTypeJSON.HoldingGenerator fieldGeneratorListingRequestType;
        private JSONHoldingBooleanGenerator fieldGeneratorExchangeExplicit;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorRequestedStockExchangeShortName;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorRequestedStockExchangeLongName;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorRequestedStockExchangeSymbol;
        private StockListingJSON.HoldingGenerator fieldGeneratorAlternateListing;
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
            StockInvalidListingJSON result = new StockInvalidListingJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockInvalidListingAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StockInvalidListingJSON result)
          {
            if (fieldGeneratorSymbol.have_value)
              {
                result.setSymbol(fieldGeneratorSymbol.value);
                fieldGeneratorSymbol.have_value = false;
              }
            else if ((!(result.hasSymbol())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Symbol\" field was missing.");
              }
            if (fieldGeneratorShortName.have_value)
              {
                result.setShortName(fieldGeneratorShortName.value);
                fieldGeneratorShortName.have_value = false;
              }
            if (fieldGeneratorShortPossessiveName.have_value)
              {
                result.setShortPossessiveName(fieldGeneratorShortPossessiveName.value);
                fieldGeneratorShortPossessiveName.have_value = false;
              }
            if (fieldGeneratorMediumName.have_value)
              {
                result.setMediumName(fieldGeneratorMediumName.value);
                fieldGeneratorMediumName.have_value = false;
              }
            if (fieldGeneratorLongName.have_value)
              {
                result.setLongName(fieldGeneratorLongName.value);
                fieldGeneratorLongName.have_value = false;
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
            if (fieldGeneratorRequestedStockExchangeShortName.have_value)
              {
                result.setRequestedStockExchangeShortName(fieldGeneratorRequestedStockExchangeShortName.value);
                fieldGeneratorRequestedStockExchangeShortName.have_value = false;
              }
            if (fieldGeneratorRequestedStockExchangeLongName.have_value)
              {
                result.setRequestedStockExchangeLongName(fieldGeneratorRequestedStockExchangeLongName.value);
                fieldGeneratorRequestedStockExchangeLongName.have_value = false;
              }
            if (fieldGeneratorRequestedStockExchangeSymbol.have_value)
              {
                result.setRequestedStockExchangeSymbol(fieldGeneratorRequestedStockExchangeSymbol.value);
                fieldGeneratorRequestedStockExchangeSymbol.have_value = false;
              }
            if (fieldGeneratorAlternateListing.have_value)
              {
                result.setAlternateListing(fieldGeneratorAlternateListing.value);
                fieldGeneratorAlternateListing.have_value = false;
              }
          }
        protected abstract void handle_result(StockInvalidListingJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "lternateListing", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorAlternateListing;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "xchangeExplicit", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorExchangeExplicit;
                    break;
                case 'L':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "stingRequestType", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorListingRequestType;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "ngName", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorLongName;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "ediumName", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorMediumName;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "equestedStockExchange", 0, 21, false) == 0)
                      {
                        switch (field_name[22])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 23, "ongName", 0, 7, false) == 0) && (field_name.Length == 30))
                                    return fieldGeneratorRequestedStockExchangeLongName;
                                break;
                            case 'S':
                                switch (field_name[23])
                                  {
                                    case 'h':
                                        if ((String.Compare(field_name, 24, "ortName", 0, 7, false) == 0) && (field_name.Length == 31))
                                            return fieldGeneratorRequestedStockExchangeShortName;
                                        break;
                                    case 'y':
                                        if ((String.Compare(field_name, 24, "mbol", 0, 4, false) == 0) && (field_name.Length == 28))
                                            return fieldGeneratorRequestedStockExchangeSymbol;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'h':
                            if (String.Compare(field_name, 2, "ort", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'N':
                                        if ((String.Compare(field_name, 6, "ame", 0, 3, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorShortName;
                                        break;
                                    case 'P':
                                        if ((String.Compare(field_name, 6, "ossessiveName", 0, 13, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorShortPossessiveName;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'y':
                            if ((String.Compare(field_name, 2, "mbol", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorSymbol;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSymbol = new StockAttributeValueJSON.HoldingGenerator("field \"Symbol\" of the StockInvalidListing class", ignore_extras);
            fieldGeneratorShortName = new StockAttributeValueJSON.HoldingGenerator("field \"ShortName\" of the StockInvalidListing class", ignore_extras);
            fieldGeneratorShortPossessiveName = new StockAttributeValueJSON.HoldingGenerator("field \"ShortPossessiveName\" of the StockInvalidListing class", ignore_extras);
            fieldGeneratorMediumName = new StockAttributeValueJSON.HoldingGenerator("field \"MediumName\" of the StockInvalidListing class", ignore_extras);
            fieldGeneratorLongName = new StockAttributeValueJSON.HoldingGenerator("field \"LongName\" of the StockInvalidListing class", ignore_extras);
            fieldGeneratorListingRequestType = new StockListingRequestTypeJSON.HoldingGenerator("field \"ListingRequestType\" of the StockInvalidListing class", ignore_extras);
            fieldGeneratorExchangeExplicit = new JSONHoldingBooleanGenerator("field \"ExchangeExplicit\" of the StockInvalidListing class");
            fieldGeneratorRequestedStockExchangeShortName = new StockAttributeValueJSON.HoldingGenerator("field \"RequestedStockExchangeShortName\" of the StockInvalidListing class", ignore_extras);
            fieldGeneratorRequestedStockExchangeLongName = new StockAttributeValueJSON.HoldingGenerator("field \"RequestedStockExchangeLongName\" of the StockInvalidListing class", ignore_extras);
            fieldGeneratorRequestedStockExchangeSymbol = new StockAttributeValueJSON.HoldingGenerator("field \"RequestedStockExchangeSymbol\" of the StockInvalidListing class", ignore_extras);
            fieldGeneratorAlternateListing = new StockListingJSON.HoldingGenerator("field \"AlternateListing\" of the StockInvalidListing class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockInvalidListing class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSymbol = new StockAttributeValueJSON.HoldingGenerator("field \"Symbol\" of the StockInvalidListing class", false);
            fieldGeneratorShortName = new StockAttributeValueJSON.HoldingGenerator("field \"ShortName\" of the StockInvalidListing class", false);
            fieldGeneratorShortPossessiveName = new StockAttributeValueJSON.HoldingGenerator("field \"ShortPossessiveName\" of the StockInvalidListing class", false);
            fieldGeneratorMediumName = new StockAttributeValueJSON.HoldingGenerator("field \"MediumName\" of the StockInvalidListing class", false);
            fieldGeneratorLongName = new StockAttributeValueJSON.HoldingGenerator("field \"LongName\" of the StockInvalidListing class", false);
            fieldGeneratorListingRequestType = new StockListingRequestTypeJSON.HoldingGenerator("field \"ListingRequestType\" of the StockInvalidListing class", false);
            fieldGeneratorExchangeExplicit = new JSONHoldingBooleanGenerator("field \"ExchangeExplicit\" of the StockInvalidListing class");
            fieldGeneratorRequestedStockExchangeShortName = new StockAttributeValueJSON.HoldingGenerator("field \"RequestedStockExchangeShortName\" of the StockInvalidListing class", false);
            fieldGeneratorRequestedStockExchangeLongName = new StockAttributeValueJSON.HoldingGenerator("field \"RequestedStockExchangeLongName\" of the StockInvalidListing class", false);
            fieldGeneratorRequestedStockExchangeSymbol = new StockAttributeValueJSON.HoldingGenerator("field \"RequestedStockExchangeSymbol\" of the StockInvalidListing class", false);
            fieldGeneratorAlternateListing = new StockListingJSON.HoldingGenerator("field \"AlternateListing\" of the StockInvalidListing class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockInvalidListing class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSymbol.reset();
            fieldGeneratorShortName.reset();
            fieldGeneratorShortPossessiveName.reset();
            fieldGeneratorMediumName.reset();
            fieldGeneratorLongName.reset();
            fieldGeneratorListingRequestType.reset();
            fieldGeneratorExchangeExplicit.reset();
            fieldGeneratorRequestedStockExchangeShortName.reset();
            fieldGeneratorRequestedStockExchangeLongName.reset();
            fieldGeneratorRequestedStockExchangeSymbol.reset();
            fieldGeneratorAlternateListing.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSymbol.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorShortName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorShortPossessiveName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMediumName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLongName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorListingRequestType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestedStockExchangeShortName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestedStockExchangeLongName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestedStockExchangeSymbol.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAlternateListing.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSymbol.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorShortName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorShortPossessiveName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMediumName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLongName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorListingRequestType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestedStockExchangeShortName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestedStockExchangeLongName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestedStockExchangeSymbol.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAlternateListing.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(StockInvalidListingJSON  result)
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
        public StockInvalidListingJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockInvalidListingJSON  result)
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
    protected virtual void handle_result(List<StockInvalidListingJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockInvalidListingJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockInvalidListingJSON>();
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
    public List<StockInvalidListingJSON> value;
  };
  };
