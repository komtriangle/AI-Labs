/* file "SmartTVUserCustomInputSourceRequestInfoFieldJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SmartTVUserCustomInputSourceRequestInfoFieldJSON : JSONBase
  {
    private bool flagHasCustomInputSources;
    private List< SmartTVCustomInputSourceJSON  > storeCustomInputSources;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCustomInputSources(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CustomInputSources of SmartTVUserCustomInputSourceRequestInfoFieldJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SmartTVCustomInputSourceJSON  > vector_CustomInputSources1 = new List< SmartTVCustomInputSourceJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SmartTVCustomInputSourceJSON convert_classy = SmartTVCustomInputSourceJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_CustomInputSources1.Add(convert_classy);
          }
        initCustomInputSources();
        for (int num1 = 0; num1 < vector_CustomInputSources1.Count; ++num1)
            appendCustomInputSources(vector_CustomInputSources1[num1]);
        for (int num1 = 0; num1 < vector_CustomInputSources1.Count; ++num1)
          {
          }
      }


    public SmartTVUserCustomInputSourceRequestInfoFieldJSON()
      {
        flagHasCustomInputSources = false;
        storeCustomInputSources = new List< SmartTVCustomInputSourceJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCustomInputSources()
      {
        return flagHasCustomInputSources;
      }

    public int  countOfCustomInputSources()
      {
        Debug.Assert(flagHasCustomInputSources);
        return storeCustomInputSources.Count;
      }

    public SmartTVCustomInputSourceJSON   elementOfCustomInputSources(int element_num)
      {
        Debug.Assert(flagHasCustomInputSources);
        return storeCustomInputSources[element_num];
      }

    public List< SmartTVCustomInputSourceJSON  >  getCustomInputSources()
      {
        Debug.Assert(flagHasCustomInputSources);
        return storeCustomInputSources;
      }


    public virtual int extraSmartTVUserCustomInputSourceRequestInfoFieldComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSmartTVUserCustomInputSourceRequestInfoFieldComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSmartTVUserCustomInputSourceRequestInfoFieldComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSmartTVUserCustomInputSourceRequestInfoFieldLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initCustomInputSources()
      {
        if (flagHasCustomInputSources)
          {
            for (int num1 = 0; num1 < storeCustomInputSources.Count; ++num1)
              {
              }
          }
        flagHasCustomInputSources = true;
        storeCustomInputSources.Clear();
      }
    public void appendCustomInputSources(SmartTVCustomInputSourceJSON  to_append)
      {
        if (!flagHasCustomInputSources)
          {
            flagHasCustomInputSources = true;
            storeCustomInputSources.Clear();
          }
        Debug.Assert(flagHasCustomInputSources);
        storeCustomInputSources.Add(to_append);
      }
    public void unsetCustomInputSources()
      {
        if (flagHasCustomInputSources)
          {
            for (int num2 = 0; num2 < storeCustomInputSources.Count; ++num2)
              {
              }
          }
        flagHasCustomInputSources = false;
        storeCustomInputSources.Clear();
      }

    public virtual void extraSmartTVUserCustomInputSourceRequestInfoFieldAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSmartTVUserCustomInputSourceRequestInfoFieldSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSmartTVUserCustomInputSourceRequestInfoFieldLookup(key);
        if (old_field == null)
          {
            extraSmartTVUserCustomInputSourceRequestInfoFieldAppendPair(key, new_component);
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
        if (flagHasCustomInputSources)
          {
            handler.start_pair("CustomInputSources");
            handler.start_array();
            for (int num1 = 0; num1 < storeCustomInputSources.Count; ++num1)
              {
                if (partial_allowed)
                    storeCustomInputSources[num1].write_partial_as_json(handler);
                else
                    storeCustomInputSources[num1].write_as_json(handler);
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

    public static SmartTVUserCustomInputSourceRequestInfoFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SmartTVUserCustomInputSourceRequestInfoFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SmartTVUserCustomInputSourceRequestInfoField", ignore_extras);
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
    public static SmartTVUserCustomInputSourceRequestInfoFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SmartTVUserCustomInputSourceRequestInfoFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SmartTVUserCustomInputSourceRequestInfoFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SmartTVUserCustomInputSourceRequestInfoField", ignore_extras);
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
    public static SmartTVUserCustomInputSourceRequestInfoFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SmartTVUserCustomInputSourceRequestInfoFieldJSON from_text(string text, bool ignore_extras)
      {
        SmartTVUserCustomInputSourceRequestInfoFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SmartTVUserCustomInputSourceRequestInfoField", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SmartTVUserCustomInputSourceRequestInfoFieldJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SmartTVUserCustomInputSourceRequestInfoFieldJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SmartTVUserCustomInputSourceRequestInfoFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SmartTVUserCustomInputSourceRequestInfoField", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SmartTVCustomInputSourceJSON.HoldingArrayGenerator fieldGeneratorCustomInputSources;
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
            SmartTVUserCustomInputSourceRequestInfoFieldJSON result = new SmartTVUserCustomInputSourceRequestInfoFieldJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSmartTVUserCustomInputSourceRequestInfoFieldAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SmartTVUserCustomInputSourceRequestInfoFieldJSON result)
          {
            if (fieldGeneratorCustomInputSources.have_value)
              {
                result.initCustomInputSources();
                int count = fieldGeneratorCustomInputSources.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCustomInputSources(fieldGeneratorCustomInputSources.value[num]);
                  }
                fieldGeneratorCustomInputSources.value.Clear();
                fieldGeneratorCustomInputSources.have_value = false;
              }
          }
        protected abstract void handle_result(SmartTVUserCustomInputSourceRequestInfoFieldJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "CustomInputSources", 0, 18, false) == 0) && (field_name.Length == 18))
                return fieldGeneratorCustomInputSources;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCustomInputSources = new SmartTVCustomInputSourceJSON.HoldingArrayGenerator("field \"CustomInputSources\" of the SmartTVUserCustomInputSourceRequestInfoField class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SmartTVUserCustomInputSourceRequestInfoField class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCustomInputSources = new SmartTVCustomInputSourceJSON.HoldingArrayGenerator("field \"CustomInputSources\" of the SmartTVUserCustomInputSourceRequestInfoField class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SmartTVUserCustomInputSourceRequestInfoField class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCustomInputSources.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorCustomInputSources.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorCustomInputSources.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SmartTVUserCustomInputSourceRequestInfoFieldJSON  result)
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
        public SmartTVUserCustomInputSourceRequestInfoFieldJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SmartTVUserCustomInputSourceRequestInfoFieldJSON  result)
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
    protected virtual void handle_result(List<SmartTVUserCustomInputSourceRequestInfoFieldJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SmartTVUserCustomInputSourceRequestInfoFieldJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SmartTVUserCustomInputSourceRequestInfoFieldJSON>();
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
    public List<SmartTVUserCustomInputSourceRequestInfoFieldJSON> value;
  };
  };
