/* file "StockFundamentalJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StockFundamentalJSON : JSONBase
  {
    public struct TypeReportType
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    public struct TypeIsRestated
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeValue
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    public struct TypeDate
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    public struct TypeLastUpdated
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    public struct TypeUnit
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    private bool flagHasType;
    private string storeType;
    private bool flagHasReportType;
    private TypeReportType storeReportType;
    private bool flagHasIsRestated;
    private TypeIsRestated storeIsRestated;
    private bool flagHasValue;
    private TypeValue storeValue;
    private bool flagHasDate;
    private TypeDate storeDate;
    private bool flagHasLastUpdated;
    private TypeLastUpdated storeLastUpdated;
    private bool flagHasUnit;
    private TypeUnit storeUnit;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Type of StockFundamentalJSON is not a string.");
        setType(json_string.getData());
      }


    private void  fromJSONReportType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeReportType or_result = new TypeReportType();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
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
            throw new Exception("The value for field ReportType of StockFundamentalJSON is not one of the allowed values.");
        setReportType(or_result);
        switch (or_result.key)
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


    private void  fromJSONIsRestated(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeIsRestated or_result = new TypeIsRestated();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
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
                        throw new Exception("The value for ??? is not true for false.");
                      }
                  }
                or_result.u.choice0 = the_bool;
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
            throw new Exception("The value for field IsRestated of StockFundamentalJSON is not one of the allowed values.");
        setIsRestated(or_result);
        switch (or_result.key)
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


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeValue or_result = new TypeValue();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
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
            throw new Exception("The value for field Value of StockFundamentalJSON is not one of the allowed values.");
        setValue(or_result);
        switch (or_result.key)
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


    private void  fromJSONDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDate or_result = new TypeDate();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
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
            throw new Exception("The value for field Date of StockFundamentalJSON is not one of the allowed values.");
        setDate(or_result);
        switch (or_result.key)
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


    private void  fromJSONLastUpdated(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeLastUpdated or_result = new TypeLastUpdated();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
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
            throw new Exception("The value for field LastUpdated of StockFundamentalJSON is not one of the allowed values.");
        setLastUpdated(or_result);
        switch (or_result.key)
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


    private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeUnit or_result = new TypeUnit();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
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
            throw new Exception("The value for field Unit of StockFundamentalJSON is not one of the allowed values.");
        setUnit(or_result);
        switch (or_result.key)
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


    public StockFundamentalJSON()
      {
        flagHasType = false;
        flagHasReportType = false;
        flagHasIsRestated = false;
        flagHasValue = false;
        flagHasDate = false;
        flagHasLastUpdated = false;
        flagHasUnit = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public string  getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }

    public bool  hasReportType()
      {
        return flagHasReportType;
      }

    public TypeReportType  getReportType()
      {
        Debug.Assert(flagHasReportType);
        return storeReportType;
      }

    public bool  hasIsRestated()
      {
        return flagHasIsRestated;
      }

    public TypeIsRestated  getIsRestated()
      {
        Debug.Assert(flagHasIsRestated);
        return storeIsRestated;
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public TypeValue  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }

    public bool  hasDate()
      {
        return flagHasDate;
      }

    public TypeDate  getDate()
      {
        Debug.Assert(flagHasDate);
        return storeDate;
      }

    public bool  hasLastUpdated()
      {
        return flagHasLastUpdated;
      }

    public TypeLastUpdated  getLastUpdated()
      {
        Debug.Assert(flagHasLastUpdated);
        return storeLastUpdated;
      }

    public bool  hasUnit()
      {
        return flagHasUnit;
      }

    public TypeUnit  getUnit()
      {
        Debug.Assert(flagHasUnit);
        return storeUnit;
      }


    public virtual int extraStockFundamentalComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockFundamentalComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockFundamentalComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockFundamentalLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setType(string new_value)
      {
        flagHasType = true;
        storeType = new_value;
      }
    public void unsetType()
      {
        flagHasType = false;
      }
    public void setReportType(TypeReportType new_value)
      {
        flagHasReportType = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeReportType = new_value;
      }
    public void unsetReportType()
      {
        flagHasReportType = false;
      }
    public void setIsRestated(TypeIsRestated new_value)
      {
        flagHasIsRestated = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeIsRestated = new_value;
      }
    public void unsetIsRestated()
      {
        flagHasIsRestated = false;
      }
    public void setValue(TypeValue new_value)
      {
        flagHasValue = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeValue = new_value;
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }
    public void setDate(TypeDate new_value)
      {
        flagHasDate = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeDate = new_value;
      }
    public void unsetDate()
      {
        flagHasDate = false;
      }
    public void setLastUpdated(TypeLastUpdated new_value)
      {
        flagHasLastUpdated = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeLastUpdated = new_value;
      }
    public void unsetLastUpdated()
      {
        flagHasLastUpdated = false;
      }
    public void setUnit(TypeUnit new_value)
      {
        flagHasUnit = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeUnit = new_value;
      }
    public void unsetUnit()
      {
        flagHasUnit = false;
      }

    public virtual void extraStockFundamentalAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockFundamentalSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockFundamentalLookup(key);
        if (old_field == null)
          {
            extraStockFundamentalAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasType);
        if (flagHasType)
          {
            handler.start_pair("Type");
            handler.string_value(storeType);
          }
        if (flagHasReportType)
          {
            handler.start_pair("ReportType");
            switch (storeReportType.key)
              {
                case 0:
                    handler.string_value(storeReportType.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasIsRestated)
          {
            handler.start_pair("IsRestated");
            switch (storeIsRestated.key)
              {
                case 0:
                    handler.boolean_value(storeIsRestated.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasValue)
          {
            handler.start_pair("Value");
            switch (storeValue.key)
              {
                case 0:
                    handler.string_value(storeValue.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasDate)
          {
            handler.start_pair("Date");
            switch (storeDate.key)
              {
                case 0:
                    handler.string_value(storeDate.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasLastUpdated)
          {
            handler.start_pair("LastUpdated");
            switch (storeLastUpdated.key)
              {
                case 0:
                    handler.string_value(storeLastUpdated.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasUnit)
          {
            handler.start_pair("Unit");
            switch (storeUnit.key)
              {
                case 0:
                    handler.string_value(storeUnit.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
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
        if (!(hasType()))
          {
            return "When parsing the object for %what%, the \"Type\" field was missing.";
          }
        return null;
      }

    public static StockFundamentalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockFundamentalJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockFundamental", ignore_extras);
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
    public static StockFundamentalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockFundamentalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockFundamentalJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockFundamental", ignore_extras);
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
    public static StockFundamentalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockFundamentalJSON from_text(string text, bool ignore_extras)
      {
        StockFundamentalJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockFundamental", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockFundamentalJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StockFundamentalJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockFundamentalJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockFundamental", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorType;
    private abstract class FieldGeneratorReportType : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeReportType result = new TypeReportType();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
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
            protected abstract void handle_result(TypeReportType result);
            public FieldGeneratorReportType(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"ReportType\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"ReportType\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorReportType(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"ReportType\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"ReportType\"");
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
        private class HolderReportType
          {
            private bool have_data;
            private TypeReportType data;
            public HolderReportType()  { have_data = false; }
            public HolderReportType(TypeReportType init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderReportType(HolderReportType other)
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
            public TypeReportType referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorReportType : FieldGeneratorReportType
          {
            protected override void handle_result(TypeReportType result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderReportType(result);
              }

            public FieldHoldingGeneratorReportType(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderReportType value;
          };
    private class FieldHoldingArrayGeneratorReportType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorReportType
      {
        private FieldHoldingArrayGeneratorReportType top;

        protected override void handle_result(TypeReportType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorReportType init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeReportType> result)
      {
      }

    public FieldHoldingArrayGeneratorReportType(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeReportType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorReportType(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeReportType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeReportType> value;
  };
        private FieldHoldingGeneratorReportType fieldGeneratorReportType;
    private abstract class FieldGeneratorIsRestated : JSONParallelGenerator
          {
            private JSONHoldingBooleanGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeIsRestated result = new TypeIsRestated();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
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
            protected abstract void handle_result(TypeIsRestated result);
            public FieldGeneratorIsRestated(bool ignore_extras)
              {
                    field0 = new JSONHoldingBooleanGenerator("option 0 of field \"IsRestated\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"IsRestated\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorIsRestated(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingBooleanGenerator("option 0 of field \"IsRestated\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"IsRestated\"");
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
        private class HolderIsRestated
          {
            private bool have_data;
            private TypeIsRestated data;
            public HolderIsRestated()  { have_data = false; }
            public HolderIsRestated(TypeIsRestated init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderIsRestated(HolderIsRestated other)
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
            public TypeIsRestated referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorIsRestated : FieldGeneratorIsRestated
          {
            protected override void handle_result(TypeIsRestated result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderIsRestated(result);
              }

            public FieldHoldingGeneratorIsRestated(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderIsRestated value;
          };
    private class FieldHoldingArrayGeneratorIsRestated : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorIsRestated
      {
        private FieldHoldingArrayGeneratorIsRestated top;

        protected override void handle_result(TypeIsRestated result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorIsRestated init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeIsRestated> result)
      {
      }

    public FieldHoldingArrayGeneratorIsRestated(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeIsRestated>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorIsRestated(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeIsRestated>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeIsRestated> value;
  };
        private FieldHoldingGeneratorIsRestated fieldGeneratorIsRestated;
    private abstract class FieldGeneratorValue : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeValue result = new TypeValue();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
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
            protected abstract void handle_result(TypeValue result);
            public FieldGeneratorValue(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"Value\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Value\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorValue(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"Value\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Value\"");
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
        private class HolderValue
          {
            private bool have_data;
            private TypeValue data;
            public HolderValue()  { have_data = false; }
            public HolderValue(TypeValue init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderValue(HolderValue other)
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
            public TypeValue referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorValue : FieldGeneratorValue
          {
            protected override void handle_result(TypeValue result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderValue(result);
              }

            public FieldHoldingGeneratorValue(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderValue value;
          };
    private class FieldHoldingArrayGeneratorValue : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorValue
      {
        private FieldHoldingArrayGeneratorValue top;

        protected override void handle_result(TypeValue result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorValue init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeValue> result)
      {
      }

    public FieldHoldingArrayGeneratorValue(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeValue>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorValue(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeValue>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeValue> value;
  };
        private FieldHoldingGeneratorValue fieldGeneratorValue;
    private abstract class FieldGeneratorDate : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeDate result = new TypeDate();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
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
            protected abstract void handle_result(TypeDate result);
            public FieldGeneratorDate(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"Date\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Date\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorDate(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"Date\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Date\"");
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
        private class HolderDate
          {
            private bool have_data;
            private TypeDate data;
            public HolderDate()  { have_data = false; }
            public HolderDate(TypeDate init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderDate(HolderDate other)
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
            public TypeDate referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorDate : FieldGeneratorDate
          {
            protected override void handle_result(TypeDate result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderDate(result);
              }

            public FieldHoldingGeneratorDate(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderDate value;
          };
    private class FieldHoldingArrayGeneratorDate : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDate
      {
        private FieldHoldingArrayGeneratorDate top;

        protected override void handle_result(TypeDate result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDate init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeDate> result)
      {
      }

    public FieldHoldingArrayGeneratorDate(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeDate>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDate(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeDate>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDate> value;
  };
        private FieldHoldingGeneratorDate fieldGeneratorDate;
    private abstract class FieldGeneratorLastUpdated : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeLastUpdated result = new TypeLastUpdated();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
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
            protected abstract void handle_result(TypeLastUpdated result);
            public FieldGeneratorLastUpdated(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"LastUpdated\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"LastUpdated\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorLastUpdated(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"LastUpdated\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"LastUpdated\"");
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
        private class HolderLastUpdated
          {
            private bool have_data;
            private TypeLastUpdated data;
            public HolderLastUpdated()  { have_data = false; }
            public HolderLastUpdated(TypeLastUpdated init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderLastUpdated(HolderLastUpdated other)
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
            public TypeLastUpdated referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorLastUpdated : FieldGeneratorLastUpdated
          {
            protected override void handle_result(TypeLastUpdated result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderLastUpdated(result);
              }

            public FieldHoldingGeneratorLastUpdated(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderLastUpdated value;
          };
    private class FieldHoldingArrayGeneratorLastUpdated : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLastUpdated
      {
        private FieldHoldingArrayGeneratorLastUpdated top;

        protected override void handle_result(TypeLastUpdated result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLastUpdated init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeLastUpdated> result)
      {
      }

    public FieldHoldingArrayGeneratorLastUpdated(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeLastUpdated>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLastUpdated(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeLastUpdated>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLastUpdated> value;
  };
        private FieldHoldingGeneratorLastUpdated fieldGeneratorLastUpdated;
    private abstract class FieldGeneratorUnit : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeUnit result = new TypeUnit();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
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
            protected abstract void handle_result(TypeUnit result);
            public FieldGeneratorUnit(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"Unit\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Unit\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorUnit(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"Unit\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Unit\"");
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
        private class HolderUnit
          {
            private bool have_data;
            private TypeUnit data;
            public HolderUnit()  { have_data = false; }
            public HolderUnit(TypeUnit init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderUnit(HolderUnit other)
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
            public TypeUnit referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorUnit : FieldGeneratorUnit
          {
            protected override void handle_result(TypeUnit result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderUnit(result);
              }

            public FieldHoldingGeneratorUnit(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderUnit value;
          };
    private class FieldHoldingArrayGeneratorUnit : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorUnit
      {
        private FieldHoldingArrayGeneratorUnit top;

        protected override void handle_result(TypeUnit result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorUnit init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeUnit> result)
      {
      }

    public FieldHoldingArrayGeneratorUnit(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeUnit>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorUnit(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeUnit>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeUnit> value;
  };
        private FieldHoldingGeneratorUnit fieldGeneratorUnit;
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
            StockFundamentalJSON result = new StockFundamentalJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockFundamentalAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StockFundamentalJSON result)
          {
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
            else if ((!(result.hasType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Type\" field was missing.");
              }
            if (fieldGeneratorReportType.have_value)
              {
                result.setReportType(fieldGeneratorReportType.value.referenced());
                fieldGeneratorReportType.have_value = false;
              }
            if (fieldGeneratorIsRestated.have_value)
              {
                result.setIsRestated(fieldGeneratorIsRestated.value.referenced());
                fieldGeneratorIsRestated.have_value = false;
              }
            if (fieldGeneratorValue.have_value)
              {
                result.setValue(fieldGeneratorValue.value.referenced());
                fieldGeneratorValue.have_value = false;
              }
            if (fieldGeneratorDate.have_value)
              {
                result.setDate(fieldGeneratorDate.value.referenced());
                fieldGeneratorDate.have_value = false;
              }
            if (fieldGeneratorLastUpdated.have_value)
              {
                result.setLastUpdated(fieldGeneratorLastUpdated.value.referenced());
                fieldGeneratorLastUpdated.have_value = false;
              }
            if (fieldGeneratorUnit.have_value)
              {
                result.setUnit(fieldGeneratorUnit.value.referenced());
                fieldGeneratorUnit.have_value = false;
              }
          }
        protected abstract void handle_result(StockFundamentalJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ate", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorDate;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sRestated", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorIsRestated;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "astUpdated", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorLastUpdated;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "eportType", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorReportType;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorType;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "nit", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorUnit;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorType = new JSONHoldingStringGenerator("field \"Type\" of the StockFundamental class");
            fieldGeneratorReportType = new FieldHoldingGeneratorReportType("field \"ReportType\" of the StockFundamental class", ignore_extras);
            fieldGeneratorIsRestated = new FieldHoldingGeneratorIsRestated("field \"IsRestated\" of the StockFundamental class", ignore_extras);
            fieldGeneratorValue = new FieldHoldingGeneratorValue("field \"Value\" of the StockFundamental class", ignore_extras);
            fieldGeneratorDate = new FieldHoldingGeneratorDate("field \"Date\" of the StockFundamental class", ignore_extras);
            fieldGeneratorLastUpdated = new FieldHoldingGeneratorLastUpdated("field \"LastUpdated\" of the StockFundamental class", ignore_extras);
            fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the StockFundamental class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockFundamental class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorType = new JSONHoldingStringGenerator("field \"Type\" of the StockFundamental class");
            fieldGeneratorReportType = new FieldHoldingGeneratorReportType("field \"ReportType\" of the StockFundamental class", false);
            fieldGeneratorIsRestated = new FieldHoldingGeneratorIsRestated("field \"IsRestated\" of the StockFundamental class", false);
            fieldGeneratorValue = new FieldHoldingGeneratorValue("field \"Value\" of the StockFundamental class", false);
            fieldGeneratorDate = new FieldHoldingGeneratorDate("field \"Date\" of the StockFundamental class", false);
            fieldGeneratorLastUpdated = new FieldHoldingGeneratorLastUpdated("field \"LastUpdated\" of the StockFundamental class", false);
            fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the StockFundamental class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockFundamental class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorType.reset();
            fieldGeneratorReportType.reset();
            fieldGeneratorIsRestated.reset();
            fieldGeneratorValue.reset();
            fieldGeneratorDate.reset();
            fieldGeneratorLastUpdated.reset();
            fieldGeneratorUnit.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(StockFundamentalJSON  result)
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
        public StockFundamentalJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockFundamentalJSON  result)
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
    protected virtual void handle_result(List<StockFundamentalJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockFundamentalJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockFundamentalJSON>();
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
    public List<StockFundamentalJSON> value;
  };
  };
