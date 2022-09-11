/* file "HomeAutomationQueryHintJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationQueryHintJSON : JSONBase
  {
    private bool flagHasOperations;
    private List< HomeAutomationOperationJSON  > storeOperations;
    private bool flagHasProperties;
    private List< HomeAutomationPropertyJSON  > storeProperties;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONOperations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Operations of HomeAutomationQueryHintJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Operations of HomeAutomationQueryHintJSON has too few elements.");
        List< HomeAutomationOperationJSON  > vector_Operations1 = new List< HomeAutomationOperationJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HomeAutomationOperationJSON convert_classy = HomeAutomationOperationJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Operations1.Add(convert_classy);
          }
        Debug.Assert(vector_Operations1.Count >= 1);
        initOperations();
        for (int num1 = 0; num1 < vector_Operations1.Count; ++num1)
            appendOperations(vector_Operations1[num1]);
        for (int num1 = 0; num1 < vector_Operations1.Count; ++num1)
          {
          }
      }


    private void  fromJSONProperties(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Properties of HomeAutomationQueryHintJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Properties of HomeAutomationQueryHintJSON has too few elements.");
        List< HomeAutomationPropertyJSON  > vector_Properties1 = new List< HomeAutomationPropertyJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HomeAutomationPropertyJSON convert_classy = HomeAutomationPropertyJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Properties1.Add(convert_classy);
          }
        Debug.Assert(vector_Properties1.Count >= 1);
        initProperties();
        for (int num2 = 0; num2 < vector_Properties1.Count; ++num2)
            appendProperties(vector_Properties1[num2]);
        for (int num1 = 0; num1 < vector_Properties1.Count; ++num1)
          {
          }
      }


    public HomeAutomationQueryHintJSON()
      {
        flagHasOperations = false;
        flagHasProperties = false;
        storeOperations = new List< HomeAutomationOperationJSON  >();
        storeProperties = new List< HomeAutomationPropertyJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasOperations()
      {
        return flagHasOperations;
      }

    public int  countOfOperations()
      {
        Debug.Assert(flagHasOperations);
        return storeOperations.Count;
      }

    public HomeAutomationOperationJSON   elementOfOperations(int element_num)
      {
        Debug.Assert(flagHasOperations);
        return storeOperations[element_num];
      }

    public List< HomeAutomationOperationJSON  >  getOperations()
      {
        Debug.Assert(flagHasOperations);
        return storeOperations;
      }

    public bool  hasProperties()
      {
        return flagHasProperties;
      }

    public int  countOfProperties()
      {
        Debug.Assert(flagHasProperties);
        return storeProperties.Count;
      }

    public HomeAutomationPropertyJSON   elementOfProperties(int element_num)
      {
        Debug.Assert(flagHasProperties);
        return storeProperties[element_num];
      }

    public List< HomeAutomationPropertyJSON  >  getProperties()
      {
        Debug.Assert(flagHasProperties);
        return storeProperties;
      }


    public virtual int extraHomeAutomationQueryHintComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationQueryHintComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationQueryHintComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationQueryHintLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initOperations()
      {
        if (flagHasOperations)
          {
            for (int num1 = 0; num1 < storeOperations.Count; ++num1)
              {
              }
          }
        flagHasOperations = true;
        storeOperations.Clear();
      }
    public void appendOperations(HomeAutomationOperationJSON  to_append)
      {
        if (!flagHasOperations)
          {
            flagHasOperations = true;
            storeOperations.Clear();
          }
        Debug.Assert(flagHasOperations);
        storeOperations.Add(to_append);
      }
    public void appendOperations(HomeAutomationOperationJSON.TypeValue new_value)
      {
        appendOperations(new HomeAutomationOperationJSON(new_value));
      }
    public void appendOperations(string chars)
      {
        HomeAutomationOperationJSON.TypeValueKnownValues known = HomeAutomationOperationJSON.stringToValue(chars);
        HomeAutomationOperationJSON.TypeValue new_value = new HomeAutomationOperationJSON.TypeValue();
        if (known == HomeAutomationOperationJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendOperations(new_value);
      }
    public void unsetOperations()
      {
        if (flagHasOperations)
          {
            for (int num2 = 0; num2 < storeOperations.Count; ++num2)
              {
              }
          }
        flagHasOperations = false;
        storeOperations.Clear();
      }
    public void initProperties()
      {
        if (flagHasProperties)
          {
            for (int num3 = 0; num3 < storeProperties.Count; ++num3)
              {
              }
          }
        flagHasProperties = true;
        storeProperties.Clear();
      }
    public void appendProperties(HomeAutomationPropertyJSON  to_append)
      {
        if (!flagHasProperties)
          {
            flagHasProperties = true;
            storeProperties.Clear();
          }
        Debug.Assert(flagHasProperties);
        storeProperties.Add(to_append);
      }
    public void appendProperties(HomeAutomationPropertyJSON.TypeValue new_value)
      {
        appendProperties(new HomeAutomationPropertyJSON(new_value));
      }
    public void appendProperties(string chars)
      {
        HomeAutomationPropertyJSON.TypeValueKnownValues known = HomeAutomationPropertyJSON.stringToValue(chars);
        HomeAutomationPropertyJSON.TypeValue new_value = new HomeAutomationPropertyJSON.TypeValue();
        if (known == HomeAutomationPropertyJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendProperties(new_value);
      }
    public void unsetProperties()
      {
        if (flagHasProperties)
          {
            for (int num4 = 0; num4 < storeProperties.Count; ++num4)
              {
              }
          }
        flagHasProperties = false;
        storeProperties.Clear();
      }

    public virtual void extraHomeAutomationQueryHintAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationQueryHintSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationQueryHintLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationQueryHintAppendPair(key, new_component);
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
        if (flagHasOperations)
          {
            handler.start_pair("Operations");
            Debug.Assert(storeOperations.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeOperations.Count; ++num1)
              {
                if (partial_allowed)
                    storeOperations[num1].write_partial_as_json(handler);
                else
                    storeOperations[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasProperties)
          {
            handler.start_pair("Properties");
            Debug.Assert(storeProperties.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeProperties.Count; ++num2)
              {
                if (partial_allowed)
                    storeProperties[num2].write_partial_as_json(handler);
                else
                    storeProperties[num2].write_as_json(handler);
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
        return null;
      }

    public static HomeAutomationQueryHintJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationQueryHintJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationQueryHint", ignore_extras);
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
    public static HomeAutomationQueryHintJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationQueryHintJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationQueryHintJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationQueryHint", ignore_extras);
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
    public static HomeAutomationQueryHintJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationQueryHintJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationQueryHintJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationQueryHint", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationQueryHintJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HomeAutomationQueryHintJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationQueryHintJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationQueryHint", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private HomeAutomationOperationJSON.HoldingArrayGenerator fieldGeneratorOperations;
        private HomeAutomationPropertyJSON.HoldingArrayGenerator fieldGeneratorProperties;
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
            HomeAutomationQueryHintJSON result = new HomeAutomationQueryHintJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationQueryHintAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HomeAutomationQueryHintJSON result)
          {
            if (fieldGeneratorOperations.have_value)
              {
                result.initOperations();
                int count = fieldGeneratorOperations.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendOperations(fieldGeneratorOperations.value[num]);
                  }
                fieldGeneratorOperations.value.Clear();
                fieldGeneratorOperations.have_value = false;
              }
            if (fieldGeneratorProperties.have_value)
              {
                result.initProperties();
                int count = fieldGeneratorProperties.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendProperties(fieldGeneratorProperties.value[num]);
                  }
                fieldGeneratorProperties.value.Clear();
                fieldGeneratorProperties.have_value = false;
              }
          }
        protected abstract void handle_result(HomeAutomationQueryHintJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'O':
                    if ((String.Compare(field_name, 1, "perations", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorOperations;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "roperties", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorProperties;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorOperations = new HomeAutomationOperationJSON.HoldingArrayGenerator("field \"Operations\" of the HomeAutomationQueryHint class", ignore_extras);
            fieldGeneratorProperties = new HomeAutomationPropertyJSON.HoldingArrayGenerator("field \"Properties\" of the HomeAutomationQueryHint class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationQueryHint class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorOperations = new HomeAutomationOperationJSON.HoldingArrayGenerator("field \"Operations\" of the HomeAutomationQueryHint class", false);
            fieldGeneratorProperties = new HomeAutomationPropertyJSON.HoldingArrayGenerator("field \"Properties\" of the HomeAutomationQueryHint class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationQueryHint class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorOperations.reset();
            fieldGeneratorProperties.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorOperations.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorProperties.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorOperations.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorProperties.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationQueryHintJSON  result)
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
        public HomeAutomationQueryHintJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationQueryHintJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationQueryHintJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationQueryHintJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationQueryHintJSON>();
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
    public List<HomeAutomationQueryHintJSON> value;
  };
  };
