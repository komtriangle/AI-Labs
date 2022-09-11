/* file "DisambiguateCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class DisambiguateCommandJSON : CommandResultJSON
  {
    private bool flagHasMultiSelect;
    private bool storeMultiSelect;
    private bool flagHasChoiceList;
    private List< DisambiguateChoiceJSON  > storeChoiceList;
    private bool flagHasNativeData;
    private DisambiguateCommandNativeDataJSON  storeNativeData;


    private JSONValue  extraMultiSelectToJSON()
      {
        JSONValue generated_boolean_MultiSelect = (storeMultiSelect ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_MultiSelect;
      }

    private JSONValue  extraChoiceListToJSON()
      {
        JSONArrayValue generated_array_1_ChoiceList = new JSONArrayValue();
        for (int num1 = 0; num1 < storeChoiceList.Count; ++num1)
          {
            JSONValueHandler handler_ChoiceList = new JSONValueHandler();
            storeChoiceList[num1].write_as_json(handler_ChoiceList);
            generated_array_1_ChoiceList.appendComponent(handler_ChoiceList.result);
          }
        return generated_array_1_ChoiceList;
      }

    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }


    private void  fromJSONMultiSelect(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MultiSelect of DisambiguateCommandJSON is not true for false.");
              }
          }
        setMultiSelect(the_bool);
      }


    private void  fromJSONChoiceList(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ChoiceList of DisambiguateCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field ChoiceList of DisambiguateCommandJSON has too few elements.");
        List< DisambiguateChoiceJSON  > vector_ChoiceList1 = new List< DisambiguateChoiceJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            DisambiguateChoiceJSON convert_classy = DisambiguateChoiceJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ChoiceList1.Add(convert_classy);
          }
        Debug.Assert(vector_ChoiceList1.Count >= 2);
        initChoiceList();
        for (int num1 = 0; num1 < vector_ChoiceList1.Count; ++num1)
            appendChoiceList(vector_ChoiceList1[num1]);
        for (int num1 = 0; num1 < vector_ChoiceList1.Count; ++num1)
          {
          }
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DisambiguateCommandNativeDataJSON convert_classy = DisambiguateCommandNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    public DisambiguateCommandJSON()
      {
        flagHasMultiSelect = false;
        flagHasChoiceList = false;
        flagHasNativeData = false;
        storeChoiceList = new List< DisambiguateChoiceJSON  >();
      }

    public override string  getCommandKind()
      {
        return "DisambiguateCommand";
      }

    public abstract string getDisambiguateCommandKind();
    public bool  hasMultiSelect()
      {
        return flagHasMultiSelect;
      }

    public bool  getMultiSelect()
      {
        Debug.Assert(flagHasMultiSelect);
        return storeMultiSelect;
      }

    public bool  hasChoiceList()
      {
        return flagHasChoiceList;
      }

    public int  countOfChoiceList()
      {
        Debug.Assert(flagHasChoiceList);
        return storeChoiceList.Count;
      }

    public DisambiguateChoiceJSON   elementOfChoiceList(int element_num)
      {
        Debug.Assert(flagHasChoiceList);
        return storeChoiceList[element_num];
      }

    public List< DisambiguateChoiceJSON  >  getChoiceList()
      {
        Debug.Assert(flagHasChoiceList);
        return storeChoiceList;
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public DisambiguateCommandNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }


    public abstract int extraDisambiguateCommandComponentCount();
    public abstract string extraDisambiguateCommandComponentKey(int component_num);
    public abstract JSONValue extraDisambiguateCommandComponentValue(int component_num);
    public abstract JSONValue extraDisambiguateCommandLookup(string field_name);
    public override int extraCommandResultComponentCount()
      {
        int result = 1;
        if (flagHasMultiSelect)
            ++result;
        if (flagHasChoiceList)
            ++result;
        if (flagHasNativeData)
            ++result;
        result += extraDisambiguateCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        if (component_num == 0)
            return "DisambiguateCommandKind";
        int remainder = (component_num - 1);
        if (flagHasMultiSelect)
          {
            if (remainder == 0)
                return "MultiSelect";
            --remainder;
          }
        if (flagHasChoiceList)
          {
            if (remainder == 0)
                return "ChoiceList";
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraDisambiguateCommandComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getDisambiguateCommandKind());
        int remainder = (component_num - 1);
        if (flagHasMultiSelect)
          {
            if (remainder == 0)
                return extraMultiSelectToJSON();
            --remainder;
          }
        if (flagHasChoiceList)
          {
            if (remainder == 0)
                return extraChoiceListToJSON();
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraDisambiguateCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "hoiceList", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasChoiceList ? extraChoiceListToJSON() : null);
                break;
            case 'D':
                if ((String.Compare(field_name, 1, "isambiguateCommandKind", 0, 22, false) == 0) && (field_name.Length == 23))
                    return new JSONStringValue(getDisambiguateCommandKind());
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "ultiSelect", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasMultiSelect ? extraMultiSelectToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasNativeData ? extraNativeDataToJSON() : null);
                break;
            default:
                break;
          }
        return extraDisambiguateCommandLookup(field_name);
      }

    public void setMultiSelect(bool new_value)
      {
        flagHasMultiSelect = true;
        storeMultiSelect = new_value;
      }
    public void unsetMultiSelect()
      {
        flagHasMultiSelect = false;
      }
    public void initChoiceList()
      {
        if (flagHasChoiceList)
          {
            for (int num1 = 0; num1 < storeChoiceList.Count; ++num1)
              {
              }
          }
        flagHasChoiceList = true;
        storeChoiceList.Clear();
      }
    public void appendChoiceList(DisambiguateChoiceJSON  to_append)
      {
        if (!flagHasChoiceList)
          {
            flagHasChoiceList = true;
            storeChoiceList.Clear();
          }
        Debug.Assert(flagHasChoiceList);
        storeChoiceList.Add(to_append);
      }
    public void unsetChoiceList()
      {
        if (flagHasChoiceList)
          {
            for (int num2 = 0; num2 < storeChoiceList.Count; ++num2)
              {
              }
          }
        flagHasChoiceList = false;
        storeChoiceList.Clear();
      }
    public void setNativeData(DisambiguateCommandNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
      }
    public virtual void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
      }

    public abstract void extraDisambiguateCommandAppendPair(string key, JSONValue new_component);
    public abstract void extraDisambiguateCommandSetField(string key, JSONValue new_component);
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hoiceList", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONChoiceList(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "isambiguateCommandKind", 0, 22, false) == 0) && (key.Length == 23))
                    return;
                break;
            case 'M':
                if ((String.Compare(key, 1, "ultiSelect", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONMultiSelect(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDisambiguateCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hoiceList", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONChoiceList(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "isambiguateCommandKind", 0, 22, false) == 0) && (key.Length == 23))
                    return;
                break;
            case 'M':
                if ((String.Compare(key, 1, "ultiSelect", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONMultiSelect(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDisambiguateCommandSetField(key, new_component);
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        handler.pair("DisambiguateCommandKind", getDisambiguateCommandKind());
        if (flagHasMultiSelect)
          {
            handler.start_pair("MultiSelect");
            handler.boolean_value(storeMultiSelect);
          }
        if (flagHasChoiceList)
          {
            handler.start_pair("ChoiceList");
            Debug.Assert(storeChoiceList.Count >= 2);
            handler.start_array();
            for (int num1 = 0; num1 < storeChoiceList.Count; ++num1)
              {
                if (partial_allowed)
                    storeChoiceList[num1].write_partial_as_json(handler);
                else
                    storeChoiceList[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        writeFieldNativeData(handler);
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual void writeFieldNativeData(JSONHandler handler)
      {
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            storeNativeData.write_as_json(handler);
          }
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new DisambiguateCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisambiguateCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateCommand", ignore_extras);
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
    public static new DisambiguateCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DisambiguateCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisambiguateCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateCommand", ignore_extras);
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
    public static new DisambiguateCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DisambiguateCommandJSON from_text(string text, bool ignore_extras)
      {
        DisambiguateCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DisambiguateCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DisambiguateCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DisambiguateCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorMultiSelect;
        private DisambiguateChoiceJSON.HoldingArrayGenerator fieldGeneratorChoiceList;
        private DisambiguateCommandNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `DisambiguateCommandKind' field is missing.");
            if (!(getCommandResultJSONKey().Equals("DisambiguateCommand")))
                throw new Exception("The key field has a value other than `DisambiguateCommand'.");
            DisambiguateCommandJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDisambiguateCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getDisambiguateCommandJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `DisambiguateCommandKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((DisambiguateCommandJSON )new_result);
          }
        protected void finish(DisambiguateCommandJSON result)
          {
            if (fieldGeneratorMultiSelect.have_value)
              {
                result.setMultiSelect(fieldGeneratorMultiSelect.value);
                fieldGeneratorMultiSelect.have_value = false;
              }
            if (fieldGeneratorChoiceList.have_value)
              {
                result.initChoiceList();
                int count = fieldGeneratorChoiceList.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendChoiceList(fieldGeneratorChoiceList.value[num]);
                  }
                fieldGeneratorChoiceList.value.Clear();
                fieldGeneratorChoiceList.have_value = false;
              }
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(DisambiguateCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "hoiceList", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorChoiceList;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "isambiguateCommandKind", 0, 22, false) == 0) && (field_name.Length == 23))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "ultiSelect", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorMultiSelect;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorNativeData;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorMultiSelect = new JSONHoldingBooleanGenerator("field \"MultiSelect\" of the DisambiguateCommand class");
            fieldGeneratorChoiceList = new DisambiguateChoiceJSON.HoldingArrayGenerator("field \"ChoiceList\" of the DisambiguateCommand class", ignore_extras);
            fieldGeneratorNativeData = new DisambiguateCommandNativeDataJSON.HoldingGenerator("field \"NativeData\" of the DisambiguateCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"DisambiguateCommandKind\" of the DisambiguateCommand class");
            set_what("the DisambiguateCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorMultiSelect = new JSONHoldingBooleanGenerator("field \"MultiSelect\" of the DisambiguateCommand class");
            fieldGeneratorChoiceList = new DisambiguateChoiceJSON.HoldingArrayGenerator("field \"ChoiceList\" of the DisambiguateCommand class", false);
            fieldGeneratorNativeData = new DisambiguateCommandNativeDataJSON.HoldingGenerator("field \"NativeData\" of the DisambiguateCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"DisambiguateCommandKind\" of the DisambiguateCommand class");
            set_what("the DisambiguateCommand class");
          }

        public override void reset()
          {
            fieldGeneratorMultiSelect.reset();
            fieldGeneratorChoiceList.reset();
            fieldGeneratorNativeData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(DisambiguateCommandJSON  result)
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
        public DisambiguateCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DisambiguateCommandJSON  result)
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
    protected virtual void handle_result(List<DisambiguateCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DisambiguateCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DisambiguateCommandJSON>();
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
    public List<DisambiguateCommandJSON> value;
  };
    class GenericDisambiguateCommandJSON : DisambiguateCommandJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericDisambiguateCommandJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getDisambiguateCommandKind()  { return key; }
        public override int extraDisambiguateCommandComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraDisambiguateCommandComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraDisambiguateCommandComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraDisambiguateCommandLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraDisambiguateCommandAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraDisambiguateCommandSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraDisambiguateCommandLookup(key);
            if (old_field == null)
              {
                extraDisambiguateCommandAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static new DisambiguateCommandJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'C':
            switch (key[1])
              {
                case 'a':
                    if (String.Compare(key, 2, "ll", 0, 2, false) == 0)
                      {
                        switch (key[4])
                          {
                            case 'O':
                                if ((String.Compare(key, 5, "neContactNumberAmbiguous", 0, 24, false) == 0) && (key.Length == 29))
                                    return new CallOneContactNumberAmbiguousCommandJSON();
                                break;
                            case 'W':
                                if ((String.Compare(key, 5, "hichContactAmbiguous", 0, 20, false) == 0) && (key.Length == 25))
                                    return new CallWhichContactAmbiguousCommandJSON();
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'o':
                    if (String.Compare(key, 2, "ntact", 0, 5, false) == 0)
                      {
                        switch (key[7])
                          {
                            case 'A':
                                if ((String.Compare(key, 8, "ddressDisambiguation", 0, 20, false) == 0) && (key.Length == 28))
                                  {
                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("ContactAddressDisambiguationKind") ? other_field_index["ContactAddressDisambiguationKind"] : null));
                                    if (key_value == null)
                                        throw new Exception("The `ContactAddressDisambiguationKind' field is missing.");
                                    JSONStringValue key_string_value = key_value.string_value();
                                    if (key_string_value == null)
                                        throw new Exception("The `ContactAddressDisambiguationKind' field has a non-string value.");
                                    return ContactAddressDisambiguationCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                                  }
                                break;
                            case 'D':
                                if ((String.Compare(key, 8, "isambiguation", 0, 13, false) == 0) && (key.Length == 21))
                                  {
                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("ContactDisambiguationKind") ? other_field_index["ContactDisambiguationKind"] : null));
                                    if (key_value == null)
                                        throw new Exception("The `ContactDisambiguationKind' field is missing.");
                                    JSONStringValue key_string_value = key_value.string_value();
                                    if (key_string_value == null)
                                        throw new Exception("The `ContactDisambiguationKind' field has a non-string value.");
                                    return ContactDisambiguationCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                                  }
                                break;
                            case 'E':
                                if ((String.Compare(key, 8, "mailAddressDisambiguation", 0, 25, false) == 0) && (key.Length == 33))
                                  {
                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("ContactEmailAddressDisambiguationKind") ? other_field_index["ContactEmailAddressDisambiguationKind"] : null));
                                    if (key_value == null)
                                        throw new Exception("The `ContactEmailAddressDisambiguationKind' field is missing.");
                                    JSONStringValue key_string_value = key_value.string_value();
                                    if (key_string_value == null)
                                        throw new Exception("The `ContactEmailAddressDisambiguationKind' field has a non-string value.");
                                    return ContactEmailAddressDisambiguationCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                                  }
                                break;
                            case 'P':
                                if ((String.Compare(key, 8, "honeNumberDisambiguation", 0, 24, false) == 0) && (key.Length == 32))
                                  {
                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("ContactPhoneNumberDisambiguationKind") ? other_field_index["ContactPhoneNumberDisambiguationKind"] : null));
                                    if (key_value == null)
                                        throw new Exception("The `ContactPhoneNumberDisambiguationKind' field is missing.");
                                    JSONStringValue key_string_value = key_value.string_value();
                                    if (key_string_value == null)
                                        throw new Exception("The `ContactPhoneNumberDisambiguationKind' field has a non-string value.");
                                    return ContactPhoneNumberDisambiguationCommandJSON.createForKey(key_string_value.getData(), other_field_index);
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
            break;
        case 'D':
            if (String.Compare(key, 1, "i", 0, 1, false) == 0)
              {
                switch (key[2])
                  {
                    case 'a':
                        if ((String.Compare(key, 3, "lOneContactNumberAmbiguous", 0, 26, false) == 0) && (key.Length == 29))
                            return new DialOneContactNumberAmbiguousCommandJSON();
                        break;
                    case 's':
                        if ((String.Compare(key, 3, "ambiguateCommunicationCommand", 0, 29, false) == 0) && (key.Length == 32))
                            return new DisambiguateCommunicationCommandJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'H':
            if (String.Compare(key, 1, "omeAutomation", 0, 13, false) == 0)
              {
                switch (key[14])
                  {
                    case 'C':
                        if ((String.Compare(key, 15, "ontrolDisambiguateSpecifierCommand", 0, 34, false) == 0) && (key.Length == 49))
                            return new HomeAutomationControlDisambiguateSpecifierCommandJSON();
                        break;
                    case 'Q':
                        if ((String.Compare(key, 15, "ueryDisambiguateSpecifierCommand", 0, 32, false) == 0) && (key.Length == 47))
                            return new HomeAutomationQueryDisambiguateSpecifierCommandJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'S':
            switch (key[1])
              {
                case 'M':
                    if (String.Compare(key, 2, "SDisambiguateP", 0, 14, false) == 0)
                      {
                        switch (key[16])
                          {
                            case 'e':
                                if ((String.Compare(key, 17, "rsonsCommand", 0, 12, false) == 0) && (key.Length == 29))
                                    return new SMSDisambiguatePersonsCommandJSON();
                                break;
                            case 'h':
                                if ((String.Compare(key, 17, "oneNumbersCommand", 0, 17, false) == 0) && (key.Length == 34))
                                    return new SMSDisambiguatePhoneNumbersCommandJSON();
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'h':
                    if ((String.Compare(key, 2, "owWhichContactAmbiguous", 0, 23, false) == 0) && (key.Length == 25))
                        return new ShowWhichContactAmbiguousCommandJSON();
                    break;
                default:
                    break;
              }
            break;
        default:
            break;
      }

        return new GenericDisambiguateCommandJSON(key);
      }
  };
