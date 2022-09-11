/* file "StockListingDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StockListingDataJSON : JSONBase
  {
    private bool flagHasSpokenSymbol;
    private string storeSpokenSymbol;
    private bool flagHasDisplaySymbol;
    private string storeDisplaySymbol;
    private bool flagHasDataSourceName;
    private string storeDataSourceName;
    private bool flagHasDataSourceCode;
    private string storeDataSourceCode;
    private bool flagHasStockExchange;
    private QueriedStockExchangeJSON  storeStockExchange;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSpokenSymbol(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenSymbol of StockListingDataJSON is not a string.");
        setSpokenSymbol(json_string.getData());
      }


    private void  fromJSONDisplaySymbol(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DisplaySymbol of StockListingDataJSON is not a string.");
        setDisplaySymbol(json_string.getData());
      }


    private void  fromJSONDataSourceName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DataSourceName of StockListingDataJSON is not a string.");
        setDataSourceName(json_string.getData());
      }


    private void  fromJSONDataSourceCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DataSourceCode of StockListingDataJSON is not a string.");
        setDataSourceCode(json_string.getData());
      }


    private void  fromJSONStockExchange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        QueriedStockExchangeJSON convert_classy = QueriedStockExchangeJSON.from_json(json_value, ignore_extras, true);
        setStockExchange(convert_classy);
      }


    public StockListingDataJSON()
      {
        flagHasSpokenSymbol = false;
        flagHasDisplaySymbol = false;
        flagHasDataSourceName = false;
        flagHasDataSourceCode = false;
        flagHasStockExchange = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSpokenSymbol()
      {
        return flagHasSpokenSymbol;
      }

    public string  getSpokenSymbol()
      {
        Debug.Assert(flagHasSpokenSymbol);
        return storeSpokenSymbol;
      }

    public bool  hasDisplaySymbol()
      {
        return flagHasDisplaySymbol;
      }

    public string  getDisplaySymbol()
      {
        Debug.Assert(flagHasDisplaySymbol);
        return storeDisplaySymbol;
      }

    public bool  hasDataSourceName()
      {
        return flagHasDataSourceName;
      }

    public string  getDataSourceName()
      {
        Debug.Assert(flagHasDataSourceName);
        return storeDataSourceName;
      }

    public bool  hasDataSourceCode()
      {
        return flagHasDataSourceCode;
      }

    public string  getDataSourceCode()
      {
        Debug.Assert(flagHasDataSourceCode);
        return storeDataSourceCode;
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


    public virtual int extraStockListingDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockListingDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockListingDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockListingDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSpokenSymbol(string new_value)
      {
        flagHasSpokenSymbol = true;
        storeSpokenSymbol = new_value;
      }
    public void unsetSpokenSymbol()
      {
        flagHasSpokenSymbol = false;
      }
    public void setDisplaySymbol(string new_value)
      {
        flagHasDisplaySymbol = true;
        storeDisplaySymbol = new_value;
      }
    public void unsetDisplaySymbol()
      {
        flagHasDisplaySymbol = false;
      }
    public void setDataSourceName(string new_value)
      {
        flagHasDataSourceName = true;
        storeDataSourceName = new_value;
      }
    public void unsetDataSourceName()
      {
        flagHasDataSourceName = false;
      }
    public void setDataSourceCode(string new_value)
      {
        flagHasDataSourceCode = true;
        storeDataSourceCode = new_value;
      }
    public void unsetDataSourceCode()
      {
        flagHasDataSourceCode = false;
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

    public virtual void extraStockListingDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockListingDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockListingDataLookup(key);
        if (old_field == null)
          {
            extraStockListingDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSpokenSymbol);
        if (flagHasSpokenSymbol)
          {
            handler.start_pair("SpokenSymbol");
            handler.string_value(storeSpokenSymbol);
          }
        Debug.Assert(partial_allowed || flagHasDisplaySymbol);
        if (flagHasDisplaySymbol)
          {
            handler.start_pair("DisplaySymbol");
            handler.string_value(storeDisplaySymbol);
          }
        Debug.Assert(partial_allowed || flagHasDataSourceName);
        if (flagHasDataSourceName)
          {
            handler.start_pair("DataSourceName");
            handler.string_value(storeDataSourceName);
          }
        Debug.Assert(partial_allowed || flagHasDataSourceCode);
        if (flagHasDataSourceCode)
          {
            handler.start_pair("DataSourceCode");
            handler.string_value(storeDataSourceCode);
          }
        if (flagHasStockExchange)
          {
            handler.start_pair("StockExchange");
            if (partial_allowed)
                storeStockExchange.write_partial_as_json(handler);
            else
                storeStockExchange.write_as_json(handler);
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
        if (!(hasSpokenSymbol()))
          {
            return "When parsing the object for %what%, the \"SpokenSymbol\" field was missing.";
          }
        if (!(hasDisplaySymbol()))
          {
            return "When parsing the object for %what%, the \"DisplaySymbol\" field was missing.";
          }
        if (!(hasDataSourceName()))
          {
            return "When parsing the object for %what%, the \"DataSourceName\" field was missing.";
          }
        if (!(hasDataSourceCode()))
          {
            return "When parsing the object for %what%, the \"DataSourceCode\" field was missing.";
          }
        return null;
      }

    public static StockListingDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockListingDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockListingData", ignore_extras);
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
    public static StockListingDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockListingDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockListingDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockListingData", ignore_extras);
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
    public static StockListingDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockListingDataJSON from_text(string text, bool ignore_extras)
      {
        StockListingDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockListingData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockListingDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StockListingDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockListingDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockListingData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorSpokenSymbol;
        private JSONHoldingStringGenerator fieldGeneratorDisplaySymbol;
        private JSONHoldingStringGenerator fieldGeneratorDataSourceName;
        private JSONHoldingStringGenerator fieldGeneratorDataSourceCode;
        private QueriedStockExchangeJSON.HoldingGenerator fieldGeneratorStockExchange;
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
            StockListingDataJSON result = new StockListingDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockListingDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StockListingDataJSON result)
          {
            if (fieldGeneratorSpokenSymbol.have_value)
              {
                result.setSpokenSymbol(fieldGeneratorSpokenSymbol.value);
                fieldGeneratorSpokenSymbol.have_value = false;
              }
            else if ((!(result.hasSpokenSymbol())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenSymbol\" field was missing.");
              }
            if (fieldGeneratorDisplaySymbol.have_value)
              {
                result.setDisplaySymbol(fieldGeneratorDisplaySymbol.value);
                fieldGeneratorDisplaySymbol.have_value = false;
              }
            else if ((!(result.hasDisplaySymbol())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DisplaySymbol\" field was missing.");
              }
            if (fieldGeneratorDataSourceName.have_value)
              {
                result.setDataSourceName(fieldGeneratorDataSourceName.value);
                fieldGeneratorDataSourceName.have_value = false;
              }
            else if ((!(result.hasDataSourceName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DataSourceName\" field was missing.");
              }
            if (fieldGeneratorDataSourceCode.have_value)
              {
                result.setDataSourceCode(fieldGeneratorDataSourceCode.value);
                fieldGeneratorDataSourceCode.have_value = false;
              }
            else if ((!(result.hasDataSourceCode())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DataSourceCode\" field was missing.");
              }
            if (fieldGeneratorStockExchange.have_value)
              {
                result.setStockExchange(fieldGeneratorStockExchange.value);
                fieldGeneratorStockExchange.have_value = false;
              }
          }
        protected abstract void handle_result(StockListingDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "taSource", 0, 8, false) == 0)
                              {
                                switch (field_name[10])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 11, "ode", 0, 3, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorDataSourceCode;
                                        break;
                                    case 'N':
                                        if ((String.Compare(field_name, 11, "ame", 0, 3, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorDataSourceName;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "splaySymbol", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorDisplaySymbol;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'p':
                            if ((String.Compare(field_name, 2, "okenSymbol", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorSpokenSymbol;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "ockExchange", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorStockExchange;
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
            fieldGeneratorSpokenSymbol = new JSONHoldingStringGenerator("field \"SpokenSymbol\" of the StockListingData class");
            fieldGeneratorDisplaySymbol = new JSONHoldingStringGenerator("field \"DisplaySymbol\" of the StockListingData class");
            fieldGeneratorDataSourceName = new JSONHoldingStringGenerator("field \"DataSourceName\" of the StockListingData class");
            fieldGeneratorDataSourceCode = new JSONHoldingStringGenerator("field \"DataSourceCode\" of the StockListingData class");
            fieldGeneratorStockExchange = new QueriedStockExchangeJSON.HoldingGenerator("field \"StockExchange\" of the StockListingData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockListingData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSpokenSymbol = new JSONHoldingStringGenerator("field \"SpokenSymbol\" of the StockListingData class");
            fieldGeneratorDisplaySymbol = new JSONHoldingStringGenerator("field \"DisplaySymbol\" of the StockListingData class");
            fieldGeneratorDataSourceName = new JSONHoldingStringGenerator("field \"DataSourceName\" of the StockListingData class");
            fieldGeneratorDataSourceCode = new JSONHoldingStringGenerator("field \"DataSourceCode\" of the StockListingData class");
            fieldGeneratorStockExchange = new QueriedStockExchangeJSON.HoldingGenerator("field \"StockExchange\" of the StockListingData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockListingData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSpokenSymbol.reset();
            fieldGeneratorDisplaySymbol.reset();
            fieldGeneratorDataSourceName.reset();
            fieldGeneratorDataSourceCode.reset();
            fieldGeneratorStockExchange.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorStockExchange.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorStockExchange.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(StockListingDataJSON  result)
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
        public StockListingDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockListingDataJSON  result)
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
    protected virtual void handle_result(List<StockListingDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockListingDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockListingDataJSON>();
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
    public List<StockListingDataJSON> value;
  };
  };
