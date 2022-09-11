/* file "StockEntityTableDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class StockEntityTableDataJSON : StockEntityDataJSON
  {
    private bool flagHasEntityID;
    private BigInteger storeEntityID;
    private bool flagHasListingRequestType;
    private StockListingRequestTypeJSON  storeListingRequestType;
    private bool flagHasDataSourceName;
    private string storeDataSourceName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraEntityIDToJSON()
      {
        JSONIntegerValue generated_integer_EntityID = new JSONIntegerValue(storeEntityID);
        return generated_integer_EntityID;
      }

    private JSONValue  extraListingRequestTypeToJSON()
      {
        JSONValueHandler handler_ListingRequestType = new JSONValueHandler();
        storeListingRequestType.write_as_json(handler_ListingRequestType);
        return handler_ListingRequestType.result;
      }

    private JSONValue  extraDataSourceNameToJSON()
      {
        JSONStringValue generated_string_DataSourceName = new JSONStringValue(storeDataSourceName);
        return generated_string_DataSourceName;
      }


    private void  fromJSONEntityID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field EntityID of StockEntityTableDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field EntityID of StockEntityTableDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setEntityID(extracted_integer);
      }


    private void  fromJSONListingRequestType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockListingRequestTypeJSON convert_classy = StockListingRequestTypeJSON.from_json(json_value, ignore_extras, true);
        setListingRequestType(convert_classy);
      }


    private void  fromJSONDataSourceName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DataSourceName of StockEntityTableDataJSON is not a string.");
        setDataSourceName(json_string.getData());
      }


    public StockEntityTableDataJSON()
      {
        flagHasEntityID = false;
        flagHasListingRequestType = false;
        flagHasDataSourceName = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getStockEntityDataKind()
      {
        return "StockEntityTableData";
      }

    public bool  hasEntityID()
      {
        return flagHasEntityID;
      }

    public BigInteger  getEntityID()
      {
        Debug.Assert(flagHasEntityID);
        return storeEntityID;
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

    public bool  hasDataSourceName()
      {
        return flagHasDataSourceName;
      }

    public string  getDataSourceName()
      {
        Debug.Assert(flagHasDataSourceName);
        return storeDataSourceName;
      }


    public virtual int extraStockEntityTableDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockEntityTableDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockEntityTableDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockEntityTableDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraStockEntityDataComponentCount()
      {
        int result = 0;
        if (flagHasEntityID)
            ++result;
        if (flagHasListingRequestType)
            ++result;
        if (flagHasDataSourceName)
            ++result;
        result += extraStockEntityTableDataComponentCount();
        return result;
      }
    public override string extraStockEntityDataComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasEntityID)
          {
            if (remainder == 0)
                return "EntityID";
            --remainder;
          }
        if (flagHasListingRequestType)
          {
            if (remainder == 0)
                return "ListingRequestType";
            --remainder;
          }
        if (flagHasDataSourceName)
          {
            if (remainder == 0)
                return "DataSourceName";
            --remainder;
          }
        return extraStockEntityTableDataComponentKey(remainder);
      }
    public override JSONValue extraStockEntityDataComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasEntityID)
          {
            if (remainder == 0)
                return extraEntityIDToJSON();
            --remainder;
          }
        if (flagHasListingRequestType)
          {
            if (remainder == 0)
                return extraListingRequestTypeToJSON();
            --remainder;
          }
        if (flagHasDataSourceName)
          {
            if (remainder == 0)
                return extraDataSourceNameToJSON();
            --remainder;
          }
        return extraStockEntityTableDataComponentValue(remainder);
      }
    public override JSONValue extraStockEntityDataLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "ataSourceName", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasDataSourceName ? extraDataSourceNameToJSON() : null);
                break;
            case 'E':
                if ((String.Compare(field_name, 1, "ntityID", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasEntityID ? extraEntityIDToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "istingRequestType", 0, 17, false) == 0) && (field_name.Length == 18))
                    return (flagHasListingRequestType ? extraListingRequestTypeToJSON() : null);
                break;
            default:
                break;
          }
        return extraStockEntityTableDataLookup(field_name);
      }

    public void setEntityID(BigInteger new_value)
      {
        flagHasEntityID = true;
        storeEntityID = new_value;
      }
    public void unsetEntityID()
      {
        flagHasEntityID = false;
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
    public void setDataSourceName(string new_value)
      {
        flagHasDataSourceName = true;
        storeDataSourceName = new_value;
      }
    public void unsetDataSourceName()
      {
        flagHasDataSourceName = false;
      }

    public virtual void extraStockEntityTableDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockEntityTableDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockEntityTableDataLookup(key);
        if (old_field == null)
          {
            extraStockEntityTableDataAppendPair(key, new_component);
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
    public override void extraStockEntityDataAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "ataSourceName", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONDataSourceName(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "ntityID", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONEntityID(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "istingRequestType", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONListingRequestType(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraStockEntityTableDataAppendPair(key, new_component);
      }
    public override void extraStockEntityDataSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "ataSourceName", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONDataSourceName(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "ntityID", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONEntityID(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "istingRequestType", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONListingRequestType(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraStockEntityTableDataSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasEntityID);
        if (flagHasEntityID)
          {
            handler.start_pair("EntityID");
            handler.number_value(storeEntityID);
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
        Debug.Assert(partial_allowed || flagHasDataSourceName);
        if (flagHasDataSourceName)
          {
            handler.start_pair("DataSourceName");
            handler.string_value(storeDataSourceName);
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
        if (!(hasEntityID()))
          {
            return "When parsing the object for %what%, the \"EntityID\" field was missing.";
          }
        if (!(hasListingRequestType()))
          {
            return "When parsing the object for %what%, the \"ListingRequestType\" field was missing.";
          }
        if (!(hasDataSourceName()))
          {
            return "When parsing the object for %what%, the \"DataSourceName\" field was missing.";
          }
        return null;
      }

    public static new StockEntityTableDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockEntityTableDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockEntityTableData", ignore_extras);
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
    public static new StockEntityTableDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StockEntityTableDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockEntityTableDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockEntityTableData", ignore_extras);
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
    public static new StockEntityTableDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StockEntityTableDataJSON from_text(string text, bool ignore_extras)
      {
        StockEntityTableDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockEntityTableData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockEntityTableDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new StockEntityTableDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockEntityTableDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockEntityTableData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : StockEntityDataJSON.Generator
      {
    private class FieldHoldingGeneratorEntityID : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorEntityID(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorEntityID : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorEntityID(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorEntityID fieldGeneratorEntityID;
        private StockListingRequestTypeJSON.HoldingGenerator fieldGeneratorListingRequestType;
        private JSONHoldingStringGenerator fieldGeneratorDataSourceName;
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
            if (!(getStockEntityDataJSONKey().Equals("StockEntityTableData")))
                throw new Exception("The key field has a value other than `StockEntityTableData'.");
            StockEntityTableDataJSON result = new StockEntityTableDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockEntityTableDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(StockEntityDataJSON new_result)
          {
            handle_result((StockEntityTableDataJSON )new_result);
          }
        protected void finish(StockEntityTableDataJSON result)
          {
            if (fieldGeneratorEntityID.have_value)
              {
                result.setEntityID(fieldGeneratorEntityID.value);
                fieldGeneratorEntityID.have_value = false;
              }
            else if ((!(result.hasEntityID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EntityID\" field was missing.");
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
            if (fieldGeneratorDataSourceName.have_value)
              {
                result.setDataSourceName(fieldGeneratorDataSourceName.value);
                fieldGeneratorDataSourceName.have_value = false;
              }
            else if ((!(result.hasDataSourceName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DataSourceName\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(StockEntityTableDataJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ataSourceName", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorDataSourceName;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "ntityID", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorEntityID;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "istingRequestType", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorListingRequestType;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorEntityID = new FieldHoldingGeneratorEntityID("field \"EntityID\" of the StockEntityTableData class");
            fieldGeneratorListingRequestType = new StockListingRequestTypeJSON.HoldingGenerator("field \"ListingRequestType\" of the StockEntityTableData class", ignore_extras);
            fieldGeneratorDataSourceName = new JSONHoldingStringGenerator("field \"DataSourceName\" of the StockEntityTableData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockEntityTableData class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorEntityID = new FieldHoldingGeneratorEntityID("field \"EntityID\" of the StockEntityTableData class");
            fieldGeneratorListingRequestType = new StockListingRequestTypeJSON.HoldingGenerator("field \"ListingRequestType\" of the StockEntityTableData class", false);
            fieldGeneratorDataSourceName = new JSONHoldingStringGenerator("field \"DataSourceName\" of the StockEntityTableData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockEntityTableData class");
          }

        public override void reset()
          {
            fieldGeneratorEntityID.reset();
            fieldGeneratorListingRequestType.reset();
            fieldGeneratorDataSourceName.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(StockEntityTableDataJSON  result)
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
        public StockEntityTableDataJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockEntityTableDataJSON  result)
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
    protected virtual void handle_result(List<StockEntityTableDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockEntityTableDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockEntityTableDataJSON>();
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
    public List<StockEntityTableDataJSON> value;
  };
  };
