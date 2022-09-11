/* file "StockFactSetFundamentalsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StockFactSetFundamentalsJSON : JSONBase
  {
    public struct TypeMessage
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    public struct TypeDelay
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
    private bool flagHasOutcome;
    private string storeOutcome;
    private bool flagHasMessage;
    private TypeMessage storeMessage;
    private bool flagHasDelay;
    private TypeDelay storeDelay;
    private bool flagHasFundamentalsSets;
    private List< StockFundamentalsSetJSON  > storeFundamentalsSets;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONOutcome(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Outcome of StockFactSetFundamentalsJSON is not a string.");
        setOutcome(json_string.getData());
      }


    private void  fromJSONMessage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeMessage or_result = new TypeMessage();
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
            throw new Exception("The value for field Message of StockFactSetFundamentalsJSON is not one of the allowed values.");
        setMessage(or_result);
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


    private void  fromJSONDelay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDelay or_result = new TypeDelay();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONRationalValue json_rational = json_value.rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
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
            throw new Exception("The value for field Delay of StockFactSetFundamentalsJSON is not one of the allowed values.");
        setDelay(or_result);
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


    private void  fromJSONFundamentalsSets(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FundamentalsSets of StockFactSetFundamentalsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< StockFundamentalsSetJSON  > vector_FundamentalsSets1 = new List< StockFundamentalsSetJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            StockFundamentalsSetJSON convert_classy = StockFundamentalsSetJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FundamentalsSets1.Add(convert_classy);
          }
        initFundamentalsSets();
        for (int num1 = 0; num1 < vector_FundamentalsSets1.Count; ++num1)
            appendFundamentalsSets(vector_FundamentalsSets1[num1]);
        for (int num1 = 0; num1 < vector_FundamentalsSets1.Count; ++num1)
          {
          }
      }


    public StockFactSetFundamentalsJSON()
      {
        flagHasOutcome = false;
        flagHasMessage = false;
        flagHasDelay = false;
        flagHasFundamentalsSets = false;
        storeFundamentalsSets = new List< StockFundamentalsSetJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasOutcome()
      {
        return flagHasOutcome;
      }

    public string  getOutcome()
      {
        Debug.Assert(flagHasOutcome);
        return storeOutcome;
      }

    public bool  hasMessage()
      {
        return flagHasMessage;
      }

    public TypeMessage  getMessage()
      {
        Debug.Assert(flagHasMessage);
        return storeMessage;
      }

    public bool  hasDelay()
      {
        return flagHasDelay;
      }

    public TypeDelay  getDelay()
      {
        Debug.Assert(flagHasDelay);
        return storeDelay;
      }

    public bool  hasFundamentalsSets()
      {
        return flagHasFundamentalsSets;
      }

    public int  countOfFundamentalsSets()
      {
        Debug.Assert(flagHasFundamentalsSets);
        return storeFundamentalsSets.Count;
      }

    public StockFundamentalsSetJSON   elementOfFundamentalsSets(int element_num)
      {
        Debug.Assert(flagHasFundamentalsSets);
        return storeFundamentalsSets[element_num];
      }

    public List< StockFundamentalsSetJSON  >  getFundamentalsSets()
      {
        Debug.Assert(flagHasFundamentalsSets);
        return storeFundamentalsSets;
      }


    public virtual int extraStockFactSetFundamentalsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockFactSetFundamentalsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockFactSetFundamentalsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockFactSetFundamentalsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setOutcome(string new_value)
      {
        flagHasOutcome = true;
        storeOutcome = new_value;
      }
    public void unsetOutcome()
      {
        flagHasOutcome = false;
      }
    public void setMessage(TypeMessage new_value)
      {
        flagHasMessage = true;
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
        storeMessage = new_value;
      }
    public void unsetMessage()
      {
        flagHasMessage = false;
      }
    public void setDelay(TypeDelay new_value)
      {
        flagHasDelay = true;
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
        storeDelay = new_value;
      }
    public void unsetDelay()
      {
        flagHasDelay = false;
      }
    public void initFundamentalsSets()
      {
        if (flagHasFundamentalsSets)
          {
            for (int num1 = 0; num1 < storeFundamentalsSets.Count; ++num1)
              {
              }
          }
        flagHasFundamentalsSets = true;
        storeFundamentalsSets.Clear();
      }
    public void appendFundamentalsSets(StockFundamentalsSetJSON  to_append)
      {
        if (!flagHasFundamentalsSets)
          {
            flagHasFundamentalsSets = true;
            storeFundamentalsSets.Clear();
          }
        Debug.Assert(flagHasFundamentalsSets);
        storeFundamentalsSets.Add(to_append);
      }
    public void unsetFundamentalsSets()
      {
        if (flagHasFundamentalsSets)
          {
            for (int num2 = 0; num2 < storeFundamentalsSets.Count; ++num2)
              {
              }
          }
        flagHasFundamentalsSets = false;
        storeFundamentalsSets.Clear();
      }

    public virtual void extraStockFactSetFundamentalsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockFactSetFundamentalsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockFactSetFundamentalsLookup(key);
        if (old_field == null)
          {
            extraStockFactSetFundamentalsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasOutcome);
        if (flagHasOutcome)
          {
            handler.start_pair("Outcome");
            handler.string_value(storeOutcome);
          }
        if (flagHasMessage)
          {
            handler.start_pair("Message");
            switch (storeMessage.key)
              {
                case 0:
                    handler.string_value(storeMessage.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasDelay)
          {
            handler.start_pair("Delay");
            switch (storeDelay.key)
              {
                case 0:
                    if (((double)(long)storeDelay.u.choice0) == storeDelay.u.choice0)
                        handler.number_value((long)storeDelay.u.choice0);
                    else
                        handler.number_value(storeDelay.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasFundamentalsSets);
        if (flagHasFundamentalsSets)
          {
            handler.start_pair("FundamentalsSets");
            handler.start_array();
            for (int num1 = 0; num1 < storeFundamentalsSets.Count; ++num1)
              {
                if (partial_allowed)
                    storeFundamentalsSets[num1].write_partial_as_json(handler);
                else
                    storeFundamentalsSets[num1].write_as_json(handler);
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
        if (!(hasOutcome()))
          {
            return "When parsing the object for %what%, the \"Outcome\" field was missing.";
          }
        if (!(hasFundamentalsSets()))
          {
            return "When parsing the object for %what%, the \"FundamentalsSets\" field was missing.";
          }
        return null;
      }

    public static StockFactSetFundamentalsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockFactSetFundamentalsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockFactSetFundamentals", ignore_extras);
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
    public static StockFactSetFundamentalsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockFactSetFundamentalsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockFactSetFundamentalsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockFactSetFundamentals", ignore_extras);
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
    public static StockFactSetFundamentalsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockFactSetFundamentalsJSON from_text(string text, bool ignore_extras)
      {
        StockFactSetFundamentalsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockFactSetFundamentals", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockFactSetFundamentalsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StockFactSetFundamentalsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockFactSetFundamentalsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockFactSetFundamentals", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorOutcome;
    private abstract class FieldGeneratorMessage : JSONParallelGenerator
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
                TypeMessage result = new TypeMessage();
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
            protected abstract void handle_result(TypeMessage result);
            public FieldGeneratorMessage(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"Message\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Message\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorMessage(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"Message\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Message\"");
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
        private class HolderMessage
          {
            private bool have_data;
            private TypeMessage data;
            public HolderMessage()  { have_data = false; }
            public HolderMessage(TypeMessage init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderMessage(HolderMessage other)
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
            public TypeMessage referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorMessage : FieldGeneratorMessage
          {
            protected override void handle_result(TypeMessage result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderMessage(result);
              }

            public FieldHoldingGeneratorMessage(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderMessage value;
          };
    private class FieldHoldingArrayGeneratorMessage : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorMessage
      {
        private FieldHoldingArrayGeneratorMessage top;

        protected override void handle_result(TypeMessage result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorMessage init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeMessage> result)
      {
      }

    public FieldHoldingArrayGeneratorMessage(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeMessage>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorMessage(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeMessage>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeMessage> value;
  };
        private FieldHoldingGeneratorMessage fieldGeneratorMessage;
    private abstract class FieldGeneratorDelay : JSONParallelGenerator
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
                TypeDelay result = new TypeDelay();
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
            protected abstract void handle_result(TypeDelay result);
            public FieldGeneratorDelay(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"Delay\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Delay\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorDelay(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"Delay\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Delay\"");
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
        private class HolderDelay
          {
            private bool have_data;
            private TypeDelay data;
            public HolderDelay()  { have_data = false; }
            public HolderDelay(TypeDelay init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderDelay(HolderDelay other)
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
            public TypeDelay referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorDelay : FieldGeneratorDelay
          {
            protected override void handle_result(TypeDelay result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderDelay(result);
              }

            public FieldHoldingGeneratorDelay(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderDelay value;
          };
    private class FieldHoldingArrayGeneratorDelay : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDelay
      {
        private FieldHoldingArrayGeneratorDelay top;

        protected override void handle_result(TypeDelay result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDelay init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeDelay> result)
      {
      }

    public FieldHoldingArrayGeneratorDelay(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeDelay>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDelay(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeDelay>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDelay> value;
  };
        private FieldHoldingGeneratorDelay fieldGeneratorDelay;
        private StockFundamentalsSetJSON.HoldingArrayGenerator fieldGeneratorFundamentalsSets;
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
            StockFactSetFundamentalsJSON result = new StockFactSetFundamentalsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockFactSetFundamentalsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StockFactSetFundamentalsJSON result)
          {
            if (fieldGeneratorOutcome.have_value)
              {
                result.setOutcome(fieldGeneratorOutcome.value);
                fieldGeneratorOutcome.have_value = false;
              }
            else if ((!(result.hasOutcome())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Outcome\" field was missing.");
              }
            if (fieldGeneratorMessage.have_value)
              {
                result.setMessage(fieldGeneratorMessage.value.referenced());
                fieldGeneratorMessage.have_value = false;
              }
            if (fieldGeneratorDelay.have_value)
              {
                result.setDelay(fieldGeneratorDelay.value.referenced());
                fieldGeneratorDelay.have_value = false;
              }
            if (fieldGeneratorFundamentalsSets.have_value)
              {
                result.initFundamentalsSets();
                int count = fieldGeneratorFundamentalsSets.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFundamentalsSets(fieldGeneratorFundamentalsSets.value[num]);
                  }
                fieldGeneratorFundamentalsSets.value.Clear();
                fieldGeneratorFundamentalsSets.have_value = false;
              }
            else if ((!(result.hasFundamentalsSets())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FundamentalsSets\" field was missing.");
              }
          }
        protected abstract void handle_result(StockFactSetFundamentalsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "elay", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorDelay;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "undamentalsSets", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorFundamentalsSets;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "essage", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorMessage;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "utcome", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorOutcome;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorOutcome = new JSONHoldingStringGenerator("field \"Outcome\" of the StockFactSetFundamentals class");
            fieldGeneratorMessage = new FieldHoldingGeneratorMessage("field \"Message\" of the StockFactSetFundamentals class", ignore_extras);
            fieldGeneratorDelay = new FieldHoldingGeneratorDelay("field \"Delay\" of the StockFactSetFundamentals class", ignore_extras);
            fieldGeneratorFundamentalsSets = new StockFundamentalsSetJSON.HoldingArrayGenerator("field \"FundamentalsSets\" of the StockFactSetFundamentals class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockFactSetFundamentals class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorOutcome = new JSONHoldingStringGenerator("field \"Outcome\" of the StockFactSetFundamentals class");
            fieldGeneratorMessage = new FieldHoldingGeneratorMessage("field \"Message\" of the StockFactSetFundamentals class", false);
            fieldGeneratorDelay = new FieldHoldingGeneratorDelay("field \"Delay\" of the StockFactSetFundamentals class", false);
            fieldGeneratorFundamentalsSets = new StockFundamentalsSetJSON.HoldingArrayGenerator("field \"FundamentalsSets\" of the StockFactSetFundamentals class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockFactSetFundamentals class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorOutcome.reset();
            fieldGeneratorMessage.reset();
            fieldGeneratorDelay.reset();
            fieldGeneratorFundamentalsSets.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFundamentalsSets.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFundamentalsSets.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(StockFactSetFundamentalsJSON  result)
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
        public StockFactSetFundamentalsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockFactSetFundamentalsJSON  result)
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
    protected virtual void handle_result(List<StockFactSetFundamentalsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockFactSetFundamentalsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockFactSetFundamentalsJSON>();
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
    public List<StockFactSetFundamentalsJSON> value;
  };
  };
