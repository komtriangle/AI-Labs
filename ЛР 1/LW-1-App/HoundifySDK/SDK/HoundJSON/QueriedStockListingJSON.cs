/* file "QueriedStockListingJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class QueriedStockListingJSON : JSONBase
  {
    private bool flagHasStockEntityData;
    private StockEntityDataJSON  storeStockEntityData;
    private bool flagHasListingRequestType;
    private StockListingRequestTypeJSON  storeListingRequestType;
    private bool flagHasStockExchange;
    private QueriedStockExchangeJSON  storeStockExchange;
    private bool flagHasCountry;
    private QueriedStockCountryJSON  storeCountry;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStockEntityData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockEntityDataJSON convert_classy = StockEntityDataJSON.from_json(json_value, ignore_extras, true);
        setStockEntityData(convert_classy);
      }


    private void  fromJSONListingRequestType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockListingRequestTypeJSON convert_classy = StockListingRequestTypeJSON.from_json(json_value, ignore_extras, true);
        setListingRequestType(convert_classy);
      }


    private void  fromJSONStockExchange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        QueriedStockExchangeJSON convert_classy = QueriedStockExchangeJSON.from_json(json_value, ignore_extras, true);
        setStockExchange(convert_classy);
      }


    private void  fromJSONCountry(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        QueriedStockCountryJSON convert_classy = QueriedStockCountryJSON.from_json(json_value, ignore_extras, true);
        setCountry(convert_classy);
      }


    public QueriedStockListingJSON()
      {
        flagHasStockEntityData = false;
        flagHasListingRequestType = false;
        flagHasStockExchange = false;
        flagHasCountry = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStockEntityData()
      {
        return flagHasStockEntityData;
      }

    public StockEntityDataJSON   getStockEntityData()
      {
        Debug.Assert(flagHasStockEntityData);
        return storeStockEntityData;
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

    public bool  hasStockExchange()
      {
        return flagHasStockExchange;
      }

    public QueriedStockExchangeJSON   getStockExchange()
      {
        Debug.Assert(flagHasStockExchange);
        return storeStockExchange;
      }

    public bool  hasCountry()
      {
        return flagHasCountry;
      }

    public QueriedStockCountryJSON   getCountry()
      {
        Debug.Assert(flagHasCountry);
        return storeCountry;
      }


    public virtual int extraQueriedStockListingComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraQueriedStockListingComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraQueriedStockListingComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraQueriedStockListingLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setStockEntityData(StockEntityDataJSON  new_value)
      {
        if (flagHasStockEntityData)
          {
          }
        flagHasStockEntityData = true;
        storeStockEntityData = new_value;
      }
    public void unsetStockEntityData()
      {
        if (flagHasStockEntityData)
          {
          }
        flagHasStockEntityData = false;
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
    public void setStockExchange(QueriedStockExchangeJSON  new_value)
      {
        if (flagHasStockExchange)
          {
          }
        flagHasStockExchange = true;
        storeStockExchange = new_value;
      }
    public void unsetStockExchange()
      {
        if (flagHasStockExchange)
          {
          }
        flagHasStockExchange = false;
      }
    public void setCountry(QueriedStockCountryJSON  new_value)
      {
        if (flagHasCountry)
          {
          }
        flagHasCountry = true;
        storeCountry = new_value;
      }
    public void unsetCountry()
      {
        if (flagHasCountry)
          {
          }
        flagHasCountry = false;
      }

    public virtual void extraQueriedStockListingAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraQueriedStockListingSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraQueriedStockListingLookup(key);
        if (old_field == null)
          {
            extraQueriedStockListingAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStockEntityData);
        if (flagHasStockEntityData)
          {
            handler.start_pair("StockEntityData");
            if (partial_allowed)
                storeStockEntityData.write_partial_as_json(handler);
            else
                storeStockEntityData.write_as_json(handler);
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
        if (flagHasStockExchange)
          {
            handler.start_pair("StockExchange");
            if (partial_allowed)
                storeStockExchange.write_partial_as_json(handler);
            else
                storeStockExchange.write_as_json(handler);
          }
        if (flagHasCountry)
          {
            handler.start_pair("Country");
            if (partial_allowed)
                storeCountry.write_partial_as_json(handler);
            else
                storeCountry.write_as_json(handler);
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
        if (!(hasStockEntityData()))
          {
            return "When parsing the object for %what%, the \"StockEntityData\" field was missing.";
          }
        if (!(hasListingRequestType()))
          {
            return "When parsing the object for %what%, the \"ListingRequestType\" field was missing.";
          }
        return null;
      }

    public static QueriedStockListingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        QueriedStockListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockListing", ignore_extras);
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
    public static QueriedStockListingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static QueriedStockListingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        QueriedStockListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockListing", ignore_extras);
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
    public static QueriedStockListingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static QueriedStockListingJSON from_text(string text, bool ignore_extras)
      {
        QueriedStockListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockListing", ignore_extras);
            JSONParse.parse_json_value(text, "Text for QueriedStockListingJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static QueriedStockListingJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        QueriedStockListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockListing", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private StockEntityDataJSON.HoldingGenerator fieldGeneratorStockEntityData;
        private StockListingRequestTypeJSON.HoldingGenerator fieldGeneratorListingRequestType;
        private QueriedStockExchangeJSON.HoldingGenerator fieldGeneratorStockExchange;
        private QueriedStockCountryJSON.HoldingGenerator fieldGeneratorCountry;
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
            QueriedStockListingJSON result = new QueriedStockListingJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraQueriedStockListingAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(QueriedStockListingJSON result)
          {
            if (fieldGeneratorStockEntityData.have_value)
              {
                result.setStockEntityData(fieldGeneratorStockEntityData.value);
                fieldGeneratorStockEntityData.have_value = false;
              }
            else if ((!(result.hasStockEntityData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StockEntityData\" field was missing.");
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
            if (fieldGeneratorStockExchange.have_value)
              {
                result.setStockExchange(fieldGeneratorStockExchange.value);
                fieldGeneratorStockExchange.have_value = false;
              }
            if (fieldGeneratorCountry.have_value)
              {
                result.setCountry(fieldGeneratorCountry.value);
                fieldGeneratorCountry.have_value = false;
              }
          }
        protected abstract void handle_result(QueriedStockListingJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ountry", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorCountry;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "istingRequestType", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorListingRequestType;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "tockE", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'n':
                                if ((String.Compare(field_name, 7, "tityData", 0, 8, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorStockEntityData;
                                break;
                            case 'x':
                                if ((String.Compare(field_name, 7, "change", 0, 6, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorStockExchange;
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
            fieldGeneratorStockEntityData = new StockEntityDataJSON.HoldingGenerator("field \"StockEntityData\" of the QueriedStockListing class", ignore_extras);
            fieldGeneratorListingRequestType = new StockListingRequestTypeJSON.HoldingGenerator("field \"ListingRequestType\" of the QueriedStockListing class", ignore_extras);
            fieldGeneratorStockExchange = new QueriedStockExchangeJSON.HoldingGenerator("field \"StockExchange\" of the QueriedStockListing class", ignore_extras);
            fieldGeneratorCountry = new QueriedStockCountryJSON.HoldingGenerator("field \"Country\" of the QueriedStockListing class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the QueriedStockListing class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStockEntityData = new StockEntityDataJSON.HoldingGenerator("field \"StockEntityData\" of the QueriedStockListing class", false);
            fieldGeneratorListingRequestType = new StockListingRequestTypeJSON.HoldingGenerator("field \"ListingRequestType\" of the QueriedStockListing class", false);
            fieldGeneratorStockExchange = new QueriedStockExchangeJSON.HoldingGenerator("field \"StockExchange\" of the QueriedStockListing class", false);
            fieldGeneratorCountry = new QueriedStockCountryJSON.HoldingGenerator("field \"Country\" of the QueriedStockListing class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the QueriedStockListing class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStockEntityData.reset();
            fieldGeneratorListingRequestType.reset();
            fieldGeneratorStockExchange.reset();
            fieldGeneratorCountry.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorStockEntityData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorListingRequestType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStockExchange.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCountry.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorStockEntityData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorListingRequestType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStockExchange.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCountry.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(QueriedStockListingJSON  result)
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
        public QueriedStockListingJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(QueriedStockListingJSON  result)
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
    protected virtual void handle_result(List<QueriedStockListingJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<QueriedStockListingJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<QueriedStockListingJSON>();
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
    public List<QueriedStockListingJSON> value;
  };
  };
