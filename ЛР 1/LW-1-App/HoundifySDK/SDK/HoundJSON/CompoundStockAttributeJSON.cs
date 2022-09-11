/* file "CompoundStockAttributeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CompoundStockAttributeJSON : JSONBase
  {
    private bool flagHasAttributeType;
    private StockAttributeJSON  storeAttributeType;
    private bool flagHasStockExchangeShortName;
    private StockAttributeValueJSON  storeStockExchangeShortName;
    private bool flagHasStockExchangeLongName;
    private StockAttributeValueJSON  storeStockExchangeLongName;
    private bool flagHasStockExchangeSymbol;
    private StockAttributeValueJSON  storeStockExchangeSymbol;
    private bool flagHasCountryName;
    private StockAttributeValueJSON  storeCountryName;
    private bool flagHasDateRange;
    private DateTimeRangeSpecJSON  storeDateRange;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONAttributeType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeJSON convert_classy = StockAttributeJSON.from_json(json_value, ignore_extras, true);
        setAttributeType(convert_classy);
      }


    private void  fromJSONStockExchangeShortName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setStockExchangeShortName(convert_classy);
      }


    private void  fromJSONStockExchangeLongName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setStockExchangeLongName(convert_classy);
      }


    private void  fromJSONStockExchangeSymbol(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setStockExchangeSymbol(convert_classy);
      }


    private void  fromJSONCountryName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setCountryName(convert_classy);
      }


    private void  fromJSONDateRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateRange(convert_classy);
      }


    public CompoundStockAttributeJSON()
      {
        flagHasAttributeType = false;
        flagHasStockExchangeShortName = false;
        flagHasStockExchangeLongName = false;
        flagHasStockExchangeSymbol = false;
        flagHasCountryName = false;
        flagHasDateRange = false;
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

    public bool  hasStockExchangeShortName()
      {
        return flagHasStockExchangeShortName;
      }

    public StockAttributeValueJSON   getStockExchangeShortName()
      {
        Debug.Assert(flagHasStockExchangeShortName);
        return storeStockExchangeShortName;
      }

    public bool  hasStockExchangeLongName()
      {
        return flagHasStockExchangeLongName;
      }

    public StockAttributeValueJSON   getStockExchangeLongName()
      {
        Debug.Assert(flagHasStockExchangeLongName);
        return storeStockExchangeLongName;
      }

    public bool  hasStockExchangeSymbol()
      {
        return flagHasStockExchangeSymbol;
      }

    public StockAttributeValueJSON   getStockExchangeSymbol()
      {
        Debug.Assert(flagHasStockExchangeSymbol);
        return storeStockExchangeSymbol;
      }

    public bool  hasCountryName()
      {
        return flagHasCountryName;
      }

    public StockAttributeValueJSON   getCountryName()
      {
        Debug.Assert(flagHasCountryName);
        return storeCountryName;
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


    public virtual int extraCompoundStockAttributeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCompoundStockAttributeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCompoundStockAttributeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCompoundStockAttributeLookup(string field_name)
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
    public void setStockExchangeShortName(StockAttributeValueJSON  new_value)
      {
        if (flagHasStockExchangeShortName)
          {
          }
        flagHasStockExchangeShortName = true;
        storeStockExchangeShortName = new_value;
      }
    public void unsetStockExchangeShortName()
      {
        if (flagHasStockExchangeShortName)
          {
          }
        flagHasStockExchangeShortName = false;
      }
    public void setStockExchangeLongName(StockAttributeValueJSON  new_value)
      {
        if (flagHasStockExchangeLongName)
          {
          }
        flagHasStockExchangeLongName = true;
        storeStockExchangeLongName = new_value;
      }
    public void unsetStockExchangeLongName()
      {
        if (flagHasStockExchangeLongName)
          {
          }
        flagHasStockExchangeLongName = false;
      }
    public void setStockExchangeSymbol(StockAttributeValueJSON  new_value)
      {
        if (flagHasStockExchangeSymbol)
          {
          }
        flagHasStockExchangeSymbol = true;
        storeStockExchangeSymbol = new_value;
      }
    public void unsetStockExchangeSymbol()
      {
        if (flagHasStockExchangeSymbol)
          {
          }
        flagHasStockExchangeSymbol = false;
      }
    public void setCountryName(StockAttributeValueJSON  new_value)
      {
        if (flagHasCountryName)
          {
          }
        flagHasCountryName = true;
        storeCountryName = new_value;
      }
    public void unsetCountryName()
      {
        if (flagHasCountryName)
          {
          }
        flagHasCountryName = false;
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

    public virtual void extraCompoundStockAttributeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCompoundStockAttributeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCompoundStockAttributeLookup(key);
        if (old_field == null)
          {
            extraCompoundStockAttributeAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasAttributeType);
        if (flagHasAttributeType)
          {
            handler.start_pair("AttributeType");
            if (partial_allowed)
                storeAttributeType.write_partial_as_json(handler);
            else
                storeAttributeType.write_as_json(handler);
          }
        if (flagHasStockExchangeShortName)
          {
            handler.start_pair("StockExchangeShortName");
            if (partial_allowed)
                storeStockExchangeShortName.write_partial_as_json(handler);
            else
                storeStockExchangeShortName.write_as_json(handler);
          }
        if (flagHasStockExchangeLongName)
          {
            handler.start_pair("StockExchangeLongName");
            if (partial_allowed)
                storeStockExchangeLongName.write_partial_as_json(handler);
            else
                storeStockExchangeLongName.write_as_json(handler);
          }
        if (flagHasStockExchangeSymbol)
          {
            handler.start_pair("StockExchangeSymbol");
            if (partial_allowed)
                storeStockExchangeSymbol.write_partial_as_json(handler);
            else
                storeStockExchangeSymbol.write_as_json(handler);
          }
        if (flagHasCountryName)
          {
            handler.start_pair("CountryName");
            if (partial_allowed)
                storeCountryName.write_partial_as_json(handler);
            else
                storeCountryName.write_as_json(handler);
          }
        if (flagHasDateRange)
          {
            handler.start_pair("DateRange");
            if (partial_allowed)
                storeDateRange.write_partial_as_json(handler);
            else
                storeDateRange.write_as_json(handler);
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
        if (!(hasAttributeType()))
          {
            return "When parsing the object for %what%, the \"AttributeType\" field was missing.";
          }
        return null;
      }

    public static CompoundStockAttributeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CompoundStockAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CompoundStockAttribute", ignore_extras);
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
    public static CompoundStockAttributeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CompoundStockAttributeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CompoundStockAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CompoundStockAttribute", ignore_extras);
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
    public static CompoundStockAttributeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CompoundStockAttributeJSON from_text(string text, bool ignore_extras)
      {
        CompoundStockAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CompoundStockAttribute", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CompoundStockAttributeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CompoundStockAttributeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CompoundStockAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CompoundStockAttribute", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private StockAttributeJSON.HoldingGenerator fieldGeneratorAttributeType;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorStockExchangeShortName;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorStockExchangeLongName;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorStockExchangeSymbol;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorCountryName;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorDateRange;
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
            CompoundStockAttributeJSON result = new CompoundStockAttributeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCompoundStockAttributeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CompoundStockAttributeJSON result)
          {
            if (fieldGeneratorAttributeType.have_value)
              {
                result.setAttributeType(fieldGeneratorAttributeType.value);
                fieldGeneratorAttributeType.have_value = false;
              }
            else if ((!(result.hasAttributeType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AttributeType\" field was missing.");
              }
            if (fieldGeneratorStockExchangeShortName.have_value)
              {
                result.setStockExchangeShortName(fieldGeneratorStockExchangeShortName.value);
                fieldGeneratorStockExchangeShortName.have_value = false;
              }
            if (fieldGeneratorStockExchangeLongName.have_value)
              {
                result.setStockExchangeLongName(fieldGeneratorStockExchangeLongName.value);
                fieldGeneratorStockExchangeLongName.have_value = false;
              }
            if (fieldGeneratorStockExchangeSymbol.have_value)
              {
                result.setStockExchangeSymbol(fieldGeneratorStockExchangeSymbol.value);
                fieldGeneratorStockExchangeSymbol.have_value = false;
              }
            if (fieldGeneratorCountryName.have_value)
              {
                result.setCountryName(fieldGeneratorCountryName.value);
                fieldGeneratorCountryName.have_value = false;
              }
            if (fieldGeneratorDateRange.have_value)
              {
                result.setDateRange(fieldGeneratorDateRange.value);
                fieldGeneratorDateRange.have_value = false;
              }
          }
        protected abstract void handle_result(CompoundStockAttributeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttributeType", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorAttributeType;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "ountryName", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCountryName;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ateRange", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorDateRange;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "tockExchange", 0, 12, false) == 0)
                      {
                        switch (field_name[13])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 14, "ongName", 0, 7, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorStockExchangeLongName;
                                break;
                            case 'S':
                                switch (field_name[14])
                                  {
                                    case 'h':
                                        if ((String.Compare(field_name, 15, "ortName", 0, 7, false) == 0) && (field_name.Length == 22))
                                            return fieldGeneratorStockExchangeShortName;
                                        break;
                                    case 'y':
                                        if ((String.Compare(field_name, 15, "mbol", 0, 4, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorStockExchangeSymbol;
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
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorAttributeType = new StockAttributeJSON.HoldingGenerator("field \"AttributeType\" of the CompoundStockAttribute class", ignore_extras);
            fieldGeneratorStockExchangeShortName = new StockAttributeValueJSON.HoldingGenerator("field \"StockExchangeShortName\" of the CompoundStockAttribute class", ignore_extras);
            fieldGeneratorStockExchangeLongName = new StockAttributeValueJSON.HoldingGenerator("field \"StockExchangeLongName\" of the CompoundStockAttribute class", ignore_extras);
            fieldGeneratorStockExchangeSymbol = new StockAttributeValueJSON.HoldingGenerator("field \"StockExchangeSymbol\" of the CompoundStockAttribute class", ignore_extras);
            fieldGeneratorCountryName = new StockAttributeValueJSON.HoldingGenerator("field \"CountryName\" of the CompoundStockAttribute class", ignore_extras);
            fieldGeneratorDateRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateRange\" of the CompoundStockAttribute class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CompoundStockAttribute class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorAttributeType = new StockAttributeJSON.HoldingGenerator("field \"AttributeType\" of the CompoundStockAttribute class", false);
            fieldGeneratorStockExchangeShortName = new StockAttributeValueJSON.HoldingGenerator("field \"StockExchangeShortName\" of the CompoundStockAttribute class", false);
            fieldGeneratorStockExchangeLongName = new StockAttributeValueJSON.HoldingGenerator("field \"StockExchangeLongName\" of the CompoundStockAttribute class", false);
            fieldGeneratorStockExchangeSymbol = new StockAttributeValueJSON.HoldingGenerator("field \"StockExchangeSymbol\" of the CompoundStockAttribute class", false);
            fieldGeneratorCountryName = new StockAttributeValueJSON.HoldingGenerator("field \"CountryName\" of the CompoundStockAttribute class", false);
            fieldGeneratorDateRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateRange\" of the CompoundStockAttribute class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CompoundStockAttribute class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorAttributeType.reset();
            fieldGeneratorStockExchangeShortName.reset();
            fieldGeneratorStockExchangeLongName.reset();
            fieldGeneratorStockExchangeSymbol.reset();
            fieldGeneratorCountryName.reset();
            fieldGeneratorDateRange.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAttributeType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStockExchangeShortName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStockExchangeLongName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStockExchangeSymbol.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCountryName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDateRange.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAttributeType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStockExchangeShortName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStockExchangeLongName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStockExchangeSymbol.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCountryName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDateRange.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CompoundStockAttributeJSON  result)
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
        public CompoundStockAttributeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CompoundStockAttributeJSON  result)
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
    protected virtual void handle_result(List<CompoundStockAttributeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CompoundStockAttributeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CompoundStockAttributeJSON>();
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
    public List<CompoundStockAttributeJSON> value;
  };
  };
