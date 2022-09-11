/* file "QueriedStockAttributeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class QueriedStockAttributeJSON : JSONBase
  {
    private bool flagHasAttributeType;
    private StockAttributeJSON  storeAttributeType;
    private bool flagHasStockExchange;
    private QueriedStockExchangeJSON  storeStockExchange;
    private bool flagHasCountry;
    private QueriedStockCountryJSON  storeCountry;
    private bool flagHasDateRange;
    private DateTimeRangeSpecJSON  storeDateRange;
    private bool flagHasNumShares;
    private BigInteger storeNumShares;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONAttributeType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeJSON convert_classy = StockAttributeJSON.from_json(json_value, ignore_extras, true);
        setAttributeType(convert_classy);
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


    private void  fromJSONDateRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateRange(convert_classy);
      }


    private void  fromJSONNumShares(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NumShares of QueriedStockAttributeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NumShares of QueriedStockAttributeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNumShares(extracted_integer);
      }


    public QueriedStockAttributeJSON()
      {
        flagHasAttributeType = false;
        flagHasStockExchange = false;
        flagHasCountry = false;
        flagHasDateRange = false;
        flagHasNumShares = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasAttributeType()
      {
        return flagHasAttributeType;
      }

    public StockAttributeJSON   getAttributeType()
      {
        Debug.Assert(flagHasAttributeType);
        return storeAttributeType;
      }

    public StockAttributeJSON.TypeValue  getAttributeTypeValue()
      {
        return getAttributeType().getValue();
      }

    public string  getAttributeTypeAsString()
      {
        return getAttributeType().getValueAsString();
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

    public bool  hasDateRange()
      {
        return flagHasDateRange;
      }

    public DateTimeRangeSpecJSON   getDateRange()
      {
        Debug.Assert(flagHasDateRange);
        return storeDateRange;
      }

    public bool  hasNumShares()
      {
        return flagHasNumShares;
      }

    public BigInteger  getNumShares()
      {
        Debug.Assert(flagHasNumShares);
        return storeNumShares;
      }


    public virtual int extraQueriedStockAttributeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraQueriedStockAttributeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraQueriedStockAttributeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraQueriedStockAttributeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setAttributeType(StockAttributeJSON  new_value)
      {
        if (flagHasAttributeType)
          {
          }
        flagHasAttributeType = true;
        storeAttributeType = new_value;
      }
    public void setAttributeType(StockAttributeJSON.TypeValue new_value)
      {
        setAttributeType(new StockAttributeJSON(new_value));
      }
    public void setAttributeType(string chars)
      {
        StockAttributeJSON.TypeValueKnownValues known = StockAttributeJSON.stringToValue(chars);
        StockAttributeJSON.TypeValue new_value = new StockAttributeJSON.TypeValue();
        if (known == StockAttributeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setAttributeType(new_value);
      }
    public void unsetAttributeType()
      {
        if (flagHasAttributeType)
          {
          }
        flagHasAttributeType = false;
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
    public void setDateRange(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasDateRange)
          {
          }
        flagHasDateRange = true;
        storeDateRange = new_value;
      }
    public void unsetDateRange()
      {
        if (flagHasDateRange)
          {
          }
        flagHasDateRange = false;
      }
    public void setNumShares(BigInteger new_value)
      {
        flagHasNumShares = true;
        storeNumShares = new_value;
      }
    public void unsetNumShares()
      {
        flagHasNumShares = false;
      }

    public virtual void extraQueriedStockAttributeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraQueriedStockAttributeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraQueriedStockAttributeLookup(key);
        if (old_field == null)
          {
            extraQueriedStockAttributeAppendPair(key, new_component);
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
        if (flagHasAttributeType)
          {
            handler.start_pair("AttributeType");
            if (partial_allowed)
                storeAttributeType.write_partial_as_json(handler);
            else
                storeAttributeType.write_as_json(handler);
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
        if (flagHasDateRange)
          {
            handler.start_pair("DateRange");
            if (partial_allowed)
                storeDateRange.write_partial_as_json(handler);
            else
                storeDateRange.write_as_json(handler);
          }
        if (flagHasNumShares)
          {
            handler.start_pair("NumShares");
            handler.number_value(storeNumShares);
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
        return null;
      }

    public static QueriedStockAttributeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        QueriedStockAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockAttribute", ignore_extras);
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
    public static QueriedStockAttributeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static QueriedStockAttributeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        QueriedStockAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockAttribute", ignore_extras);
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
    public static QueriedStockAttributeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static QueriedStockAttributeJSON from_text(string text, bool ignore_extras)
      {
        QueriedStockAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockAttribute", ignore_extras);
            JSONParse.parse_json_value(text, "Text for QueriedStockAttributeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static QueriedStockAttributeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        QueriedStockAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockAttribute", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private StockAttributeJSON.HoldingGenerator fieldGeneratorAttributeType;
        private QueriedStockExchangeJSON.HoldingGenerator fieldGeneratorStockExchange;
        private QueriedStockCountryJSON.HoldingGenerator fieldGeneratorCountry;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorDateRange;
    private class FieldHoldingGeneratorNumShares : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorNumShares(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorNumShares : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorNumShares(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorNumShares fieldGeneratorNumShares;
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
            QueriedStockAttributeJSON result = new QueriedStockAttributeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraQueriedStockAttributeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(QueriedStockAttributeJSON result)
          {
            if (fieldGeneratorAttributeType.have_value)
              {
                result.setAttributeType(fieldGeneratorAttributeType.value);
                fieldGeneratorAttributeType.have_value = false;
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
            if (fieldGeneratorDateRange.have_value)
              {
                result.setDateRange(fieldGeneratorDateRange.value);
                fieldGeneratorDateRange.have_value = false;
              }
            if (fieldGeneratorNumShares.have_value)
              {
                result.setNumShares(fieldGeneratorNumShares.value);
                fieldGeneratorNumShares.have_value = false;
              }
          }
        protected abstract void handle_result(QueriedStockAttributeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttributeType", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorAttributeType;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "ountry", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorCountry;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ateRange", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorDateRange;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "umShares", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorNumShares;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tockExchange", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorStockExchange;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorAttributeType = new StockAttributeJSON.HoldingGenerator("field \"AttributeType\" of the QueriedStockAttribute class", ignore_extras);
            fieldGeneratorStockExchange = new QueriedStockExchangeJSON.HoldingGenerator("field \"StockExchange\" of the QueriedStockAttribute class", ignore_extras);
            fieldGeneratorCountry = new QueriedStockCountryJSON.HoldingGenerator("field \"Country\" of the QueriedStockAttribute class", ignore_extras);
            fieldGeneratorDateRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateRange\" of the QueriedStockAttribute class", ignore_extras);
            fieldGeneratorNumShares = new FieldHoldingGeneratorNumShares("field \"NumShares\" of the QueriedStockAttribute class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the QueriedStockAttribute class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorAttributeType = new StockAttributeJSON.HoldingGenerator("field \"AttributeType\" of the QueriedStockAttribute class", false);
            fieldGeneratorStockExchange = new QueriedStockExchangeJSON.HoldingGenerator("field \"StockExchange\" of the QueriedStockAttribute class", false);
            fieldGeneratorCountry = new QueriedStockCountryJSON.HoldingGenerator("field \"Country\" of the QueriedStockAttribute class", false);
            fieldGeneratorDateRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateRange\" of the QueriedStockAttribute class", false);
            fieldGeneratorNumShares = new FieldHoldingGeneratorNumShares("field \"NumShares\" of the QueriedStockAttribute class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the QueriedStockAttribute class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorAttributeType.reset();
            fieldGeneratorStockExchange.reset();
            fieldGeneratorCountry.reset();
            fieldGeneratorDateRange.reset();
            fieldGeneratorNumShares.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAttributeType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStockExchange.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCountry.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDateRange.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAttributeType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStockExchange.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCountry.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDateRange.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(QueriedStockAttributeJSON  result)
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
        public QueriedStockAttributeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(QueriedStockAttributeJSON  result)
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
    protected virtual void handle_result(List<QueriedStockAttributeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<QueriedStockAttributeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<QueriedStockAttributeJSON>();
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
    public List<QueriedStockAttributeJSON> value;
  };
  };
