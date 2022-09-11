/* file "DisambiguateCommandNativeDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DisambiguateCommandNativeDataJSON : JSONBase
  {
    private bool flagHasMultiSelect;
    private bool storeMultiSelect;
    private bool flagHasChoiceList;
    private List< DisambiguateChoiceJSON  > storeChoiceList;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


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
                throw new Exception("The value for field MultiSelect of DisambiguateCommandNativeDataJSON is not true for false.");
              }
          }
        setMultiSelect(the_bool);
      }


    private void  fromJSONChoiceList(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ChoiceList of DisambiguateCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field ChoiceList of DisambiguateCommandNativeDataJSON has too few elements.");
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


    public DisambiguateCommandNativeDataJSON()
      {
        flagHasMultiSelect = false;
        flagHasChoiceList = false;
        storeChoiceList = new List< DisambiguateChoiceJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

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


    public virtual int extraDisambiguateCommandNativeDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDisambiguateCommandNativeDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDisambiguateCommandNativeDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDisambiguateCommandNativeDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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

    public virtual void extraDisambiguateCommandNativeDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDisambiguateCommandNativeDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDisambiguateCommandNativeDataLookup(key);
        if (old_field == null)
          {
            extraDisambiguateCommandNativeDataAppendPair(key, new_component);
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
        if (flagHasMultiSelect)
          {
            handler.start_pair("MultiSelect");
            handler.boolean_value(storeMultiSelect);
          }
        Debug.Assert(partial_allowed || flagHasChoiceList);
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
        if (!(hasChoiceList()))
          {
            return "When parsing the object for %what%, the \"ChoiceList\" field was missing.";
          }
        return null;
      }

    public static DisambiguateCommandNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisambiguateCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateCommandNativeData", ignore_extras);
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
    public static DisambiguateCommandNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DisambiguateCommandNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisambiguateCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateCommandNativeData", ignore_extras);
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
    public static DisambiguateCommandNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DisambiguateCommandNativeDataJSON from_text(string text, bool ignore_extras)
      {
        DisambiguateCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateCommandNativeData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DisambiguateCommandNativeDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DisambiguateCommandNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DisambiguateCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateCommandNativeData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorMultiSelect;
        private DisambiguateChoiceJSON.HoldingArrayGenerator fieldGeneratorChoiceList;
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
            DisambiguateCommandNativeDataJSON result = new DisambiguateCommandNativeDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDisambiguateCommandNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DisambiguateCommandNativeDataJSON result)
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
            else if ((!(result.hasChoiceList())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ChoiceList\" field was missing.");
              }
          }
        protected abstract void handle_result(DisambiguateCommandNativeDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "hoiceList", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorChoiceList;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "ultiSelect", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorMultiSelect;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorMultiSelect = new JSONHoldingBooleanGenerator("field \"MultiSelect\" of the DisambiguateCommandNativeData class");
            fieldGeneratorChoiceList = new DisambiguateChoiceJSON.HoldingArrayGenerator("field \"ChoiceList\" of the DisambiguateCommandNativeData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DisambiguateCommandNativeData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorMultiSelect = new JSONHoldingBooleanGenerator("field \"MultiSelect\" of the DisambiguateCommandNativeData class");
            fieldGeneratorChoiceList = new DisambiguateChoiceJSON.HoldingArrayGenerator("field \"ChoiceList\" of the DisambiguateCommandNativeData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DisambiguateCommandNativeData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorMultiSelect.reset();
            fieldGeneratorChoiceList.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorChoiceList.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorChoiceList.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(DisambiguateCommandNativeDataJSON  result)
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
        public DisambiguateCommandNativeDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DisambiguateCommandNativeDataJSON  result)
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
    protected virtual void handle_result(List<DisambiguateCommandNativeDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DisambiguateCommandNativeDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DisambiguateCommandNativeDataJSON>();
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
    public List<DisambiguateCommandNativeDataJSON> value;
  };
  };
