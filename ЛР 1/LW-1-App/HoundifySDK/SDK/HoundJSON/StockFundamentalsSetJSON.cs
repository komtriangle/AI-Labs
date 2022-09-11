/* file "StockFundamentalsSetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StockFundamentalsSetJSON : JSONBase
  {
    public struct TypeAsOfDate
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    public struct TypeCurrency
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    private bool flagHasAsOfDate;
    private TypeAsOfDate storeAsOfDate;
    private bool flagHasCurrency;
    private TypeCurrency storeCurrency;
    private bool flagHasFundamentals;
    private List< StockFundamentalJSON  > storeFundamentals;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONAsOfDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeAsOfDate or_result = new TypeAsOfDate();
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
            throw new Exception("The value for field AsOfDate of StockFundamentalsSetJSON is not one of the allowed values.");
        setAsOfDate(or_result);
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


    private void  fromJSONCurrency(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeCurrency or_result = new TypeCurrency();
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
            throw new Exception("The value for field Currency of StockFundamentalsSetJSON is not one of the allowed values.");
        setCurrency(or_result);
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


    private void  fromJSONFundamentals(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Fundamentals of StockFundamentalsSetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< StockFundamentalJSON  > vector_Fundamentals1 = new List< StockFundamentalJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            StockFundamentalJSON convert_classy = StockFundamentalJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Fundamentals1.Add(convert_classy);
          }
        initFundamentals();
        for (int num1 = 0; num1 < vector_Fundamentals1.Count; ++num1)
            appendFundamentals(vector_Fundamentals1[num1]);
        for (int num1 = 0; num1 < vector_Fundamentals1.Count; ++num1)
          {
          }
      }


    public StockFundamentalsSetJSON()
      {
        flagHasAsOfDate = false;
        flagHasCurrency = false;
        flagHasFundamentals = false;
        storeFundamentals = new List< StockFundamentalJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasAsOfDate()
      {
        return flagHasAsOfDate;
      }

    public TypeAsOfDate  getAsOfDate()
      {
        Debug.Assert(flagHasAsOfDate);
        return storeAsOfDate;
      }

    public bool  hasCurrency()
      {
        return flagHasCurrency;
      }

    public TypeCurrency  getCurrency()
      {
        Debug.Assert(flagHasCurrency);
        return storeCurrency;
      }

    public bool  hasFundamentals()
      {
        return flagHasFundamentals;
      }

    public int  countOfFundamentals()
      {
        Debug.Assert(flagHasFundamentals);
        return storeFundamentals.Count;
      }

    public StockFundamentalJSON   elementOfFundamentals(int element_num)
      {
        Debug.Assert(flagHasFundamentals);
        return storeFundamentals[element_num];
      }

    public List< StockFundamentalJSON  >  getFundamentals()
      {
        Debug.Assert(flagHasFundamentals);
        return storeFundamentals;
      }


    public virtual int extraStockFundamentalsSetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockFundamentalsSetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockFundamentalsSetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockFundamentalsSetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setAsOfDate(TypeAsOfDate new_value)
      {
        flagHasAsOfDate = true;
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
        storeAsOfDate = new_value;
      }
    public void unsetAsOfDate()
      {
        flagHasAsOfDate = false;
      }
    public void setCurrency(TypeCurrency new_value)
      {
        flagHasCurrency = true;
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
        storeCurrency = new_value;
      }
    public void unsetCurrency()
      {
        flagHasCurrency = false;
      }
    public void initFundamentals()
      {
        if (flagHasFundamentals)
          {
            for (int num1 = 0; num1 < storeFundamentals.Count; ++num1)
              {
              }
          }
        flagHasFundamentals = true;
        storeFundamentals.Clear();
      }
    public void appendFundamentals(StockFundamentalJSON  to_append)
      {
        if (!flagHasFundamentals)
          {
            flagHasFundamentals = true;
            storeFundamentals.Clear();
          }
        Debug.Assert(flagHasFundamentals);
        storeFundamentals.Add(to_append);
      }
    public void unsetFundamentals()
      {
        if (flagHasFundamentals)
          {
            for (int num2 = 0; num2 < storeFundamentals.Count; ++num2)
              {
              }
          }
        flagHasFundamentals = false;
        storeFundamentals.Clear();
      }

    public virtual void extraStockFundamentalsSetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockFundamentalsSetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockFundamentalsSetLookup(key);
        if (old_field == null)
          {
            extraStockFundamentalsSetAppendPair(key, new_component);
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
        if (flagHasAsOfDate)
          {
            handler.start_pair("AsOfDate");
            switch (storeAsOfDate.key)
              {
                case 0:
                    handler.string_value(storeAsOfDate.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasCurrency)
          {
            handler.start_pair("Currency");
            switch (storeCurrency.key)
              {
                case 0:
                    handler.string_value(storeCurrency.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasFundamentals);
        if (flagHasFundamentals)
          {
            handler.start_pair("Fundamentals");
            handler.start_array();
            for (int num1 = 0; num1 < storeFundamentals.Count; ++num1)
              {
                if (partial_allowed)
                    storeFundamentals[num1].write_partial_as_json(handler);
                else
                    storeFundamentals[num1].write_as_json(handler);
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
        if (!(hasFundamentals()))
          {
            return "When parsing the object for %what%, the \"Fundamentals\" field was missing.";
          }
        return null;
      }

    public static StockFundamentalsSetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockFundamentalsSetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockFundamentalsSet", ignore_extras);
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
    public static StockFundamentalsSetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockFundamentalsSetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockFundamentalsSetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockFundamentalsSet", ignore_extras);
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
    public static StockFundamentalsSetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockFundamentalsSetJSON from_text(string text, bool ignore_extras)
      {
        StockFundamentalsSetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockFundamentalsSet", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockFundamentalsSetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StockFundamentalsSetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockFundamentalsSetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockFundamentalsSet", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorAsOfDate : JSONParallelGenerator
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
                TypeAsOfDate result = new TypeAsOfDate();
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
            protected abstract void handle_result(TypeAsOfDate result);
            public FieldGeneratorAsOfDate(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"AsOfDate\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"AsOfDate\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorAsOfDate(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"AsOfDate\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"AsOfDate\"");
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
        private class HolderAsOfDate
          {
            private bool have_data;
            private TypeAsOfDate data;
            public HolderAsOfDate()  { have_data = false; }
            public HolderAsOfDate(TypeAsOfDate init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderAsOfDate(HolderAsOfDate other)
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
            public TypeAsOfDate referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorAsOfDate : FieldGeneratorAsOfDate
          {
            protected override void handle_result(TypeAsOfDate result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderAsOfDate(result);
              }

            public FieldHoldingGeneratorAsOfDate(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderAsOfDate value;
          };
    private class FieldHoldingArrayGeneratorAsOfDate : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorAsOfDate
      {
        private FieldHoldingArrayGeneratorAsOfDate top;

        protected override void handle_result(TypeAsOfDate result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorAsOfDate init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeAsOfDate> result)
      {
      }

    public FieldHoldingArrayGeneratorAsOfDate(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeAsOfDate>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorAsOfDate(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeAsOfDate>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeAsOfDate> value;
  };
        private FieldHoldingGeneratorAsOfDate fieldGeneratorAsOfDate;
    private abstract class FieldGeneratorCurrency : JSONParallelGenerator
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
                TypeCurrency result = new TypeCurrency();
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
            protected abstract void handle_result(TypeCurrency result);
            public FieldGeneratorCurrency(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"Currency\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Currency\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorCurrency(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"Currency\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Currency\"");
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
        private class HolderCurrency
          {
            private bool have_data;
            private TypeCurrency data;
            public HolderCurrency()  { have_data = false; }
            public HolderCurrency(TypeCurrency init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderCurrency(HolderCurrency other)
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
            public TypeCurrency referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorCurrency : FieldGeneratorCurrency
          {
            protected override void handle_result(TypeCurrency result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderCurrency(result);
              }

            public FieldHoldingGeneratorCurrency(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderCurrency value;
          };
    private class FieldHoldingArrayGeneratorCurrency : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCurrency
      {
        private FieldHoldingArrayGeneratorCurrency top;

        protected override void handle_result(TypeCurrency result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCurrency init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeCurrency> result)
      {
      }

    public FieldHoldingArrayGeneratorCurrency(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeCurrency>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCurrency(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeCurrency>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCurrency> value;
  };
        private FieldHoldingGeneratorCurrency fieldGeneratorCurrency;
        private StockFundamentalJSON.HoldingArrayGenerator fieldGeneratorFundamentals;
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
            StockFundamentalsSetJSON result = new StockFundamentalsSetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockFundamentalsSetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StockFundamentalsSetJSON result)
          {
            if (fieldGeneratorAsOfDate.have_value)
              {
                result.setAsOfDate(fieldGeneratorAsOfDate.value.referenced());
                fieldGeneratorAsOfDate.have_value = false;
              }
            if (fieldGeneratorCurrency.have_value)
              {
                result.setCurrency(fieldGeneratorCurrency.value.referenced());
                fieldGeneratorCurrency.have_value = false;
              }
            if (fieldGeneratorFundamentals.have_value)
              {
                result.initFundamentals();
                int count = fieldGeneratorFundamentals.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFundamentals(fieldGeneratorFundamentals.value[num]);
                  }
                fieldGeneratorFundamentals.value.Clear();
                fieldGeneratorFundamentals.have_value = false;
              }
            else if ((!(result.hasFundamentals())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Fundamentals\" field was missing.");
              }
          }
        protected abstract void handle_result(StockFundamentalsSetJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "sOfDate", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorAsOfDate;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "urrency", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorCurrency;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "undamentals", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorFundamentals;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorAsOfDate = new FieldHoldingGeneratorAsOfDate("field \"AsOfDate\" of the StockFundamentalsSet class", ignore_extras);
            fieldGeneratorCurrency = new FieldHoldingGeneratorCurrency("field \"Currency\" of the StockFundamentalsSet class", ignore_extras);
            fieldGeneratorFundamentals = new StockFundamentalJSON.HoldingArrayGenerator("field \"Fundamentals\" of the StockFundamentalsSet class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockFundamentalsSet class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorAsOfDate = new FieldHoldingGeneratorAsOfDate("field \"AsOfDate\" of the StockFundamentalsSet class", false);
            fieldGeneratorCurrency = new FieldHoldingGeneratorCurrency("field \"Currency\" of the StockFundamentalsSet class", false);
            fieldGeneratorFundamentals = new StockFundamentalJSON.HoldingArrayGenerator("field \"Fundamentals\" of the StockFundamentalsSet class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockFundamentalsSet class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorAsOfDate.reset();
            fieldGeneratorCurrency.reset();
            fieldGeneratorFundamentals.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFundamentals.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFundamentals.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(StockFundamentalsSetJSON  result)
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
        public StockFundamentalsSetJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockFundamentalsSetJSON  result)
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
    protected virtual void handle_result(List<StockFundamentalsSetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockFundamentalsSetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockFundamentalsSetJSON>();
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
    public List<StockFundamentalsSetJSON> value;
  };
  };
