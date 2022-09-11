/* file "UnionSetOfTimeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UnionSetOfTimeJSON : SetOfTimeJSON
  {
    private bool flagHasComponents;
    private List< SetOfTimeJSON  > storeComponents;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraComponentsToJSON()
      {
        JSONArrayValue generated_array_1_Components = new JSONArrayValue();
        for (int num1 = 0; num1 < storeComponents.Count; ++num1)
          {
            JSONValueHandler handler_Components = new JSONValueHandler();
            storeComponents[num1].write_as_json(handler_Components);
            generated_array_1_Components.appendComponent(handler_Components.result);
          }
        return generated_array_1_Components;
      }


    private void  fromJSONComponents(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Components of UnionSetOfTimeJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field Components of UnionSetOfTimeJSON has too few elements.");
        List< SetOfTimeJSON  > vector_Components1 = new List< SetOfTimeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SetOfTimeJSON convert_classy = SetOfTimeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Components1.Add(convert_classy);
          }
        Debug.Assert(vector_Components1.Count >= 2);
        initComponents();
        for (int num1 = 0; num1 < vector_Components1.Count; ++num1)
            appendComponents(vector_Components1[num1]);
        for (int num1 = 0; num1 < vector_Components1.Count; ++num1)
          {
          }
      }


    public UnionSetOfTimeJSON()
      {
        flagHasComponents = false;
        storeComponents = new List< SetOfTimeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSetOfTimeKind()
      {
        return "Union";
      }

    public bool  hasComponents()
      {
        return flagHasComponents;
      }

    public int  countOfComponents()
      {
        Debug.Assert(flagHasComponents);
        return storeComponents.Count;
      }

    public SetOfTimeJSON   elementOfComponents(int element_num)
      {
        Debug.Assert(flagHasComponents);
        return storeComponents[element_num];
      }

    public List< SetOfTimeJSON  >  getComponents()
      {
        Debug.Assert(flagHasComponents);
        return storeComponents;
      }


    public virtual int extraUnionSetOfTimeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUnionSetOfTimeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUnionSetOfTimeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUnionSetOfTimeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSetOfTimeComponentCount()
      {
        int result = 0;
        if (flagHasComponents)
            ++result;
        result += extraUnionSetOfTimeComponentCount();
        return result;
      }
    public override string extraSetOfTimeComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasComponents)
          {
            if (remainder == 0)
                return "Components";
            --remainder;
          }
        return extraUnionSetOfTimeComponentKey(remainder);
      }
    public override JSONValue extraSetOfTimeComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasComponents)
          {
            if (remainder == 0)
                return extraComponentsToJSON();
            --remainder;
          }
        return extraUnionSetOfTimeComponentValue(remainder);
      }
    public override JSONValue extraSetOfTimeLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Components", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasComponents ? extraComponentsToJSON() : null);
        return extraUnionSetOfTimeLookup(field_name);
      }

    public void initComponents()
      {
        if (flagHasComponents)
          {
            for (int num1 = 0; num1 < storeComponents.Count; ++num1)
              {
              }
          }
        flagHasComponents = true;
        storeComponents.Clear();
      }
    public void appendComponents(SetOfTimeJSON  to_append)
      {
        if (!flagHasComponents)
          {
            flagHasComponents = true;
            storeComponents.Clear();
          }
        Debug.Assert(flagHasComponents);
        storeComponents.Add(to_append);
      }
    public void unsetComponents()
      {
        if (flagHasComponents)
          {
            for (int num2 = 0; num2 < storeComponents.Count; ++num2)
              {
              }
          }
        flagHasComponents = false;
        storeComponents.Clear();
      }

    public virtual void extraUnionSetOfTimeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUnionSetOfTimeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUnionSetOfTimeLookup(key);
        if (old_field == null)
          {
            extraUnionSetOfTimeAppendPair(key, new_component);
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
    public override void extraSetOfTimeAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Components", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONComponents(new_component, false);
            return;
            }
        extraUnionSetOfTimeAppendPair(key, new_component);
      }
    public override void extraSetOfTimeSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Components", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONComponents(new_component, false);
            return;
            }
        extraUnionSetOfTimeSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasComponents);
        if (flagHasComponents)
          {
            handler.start_pair("Components");
            Debug.Assert(storeComponents.Count >= 2);
            handler.start_array();
            for (int num1 = 0; num1 < storeComponents.Count; ++num1)
              {
                if (partial_allowed)
                    storeComponents[num1].write_partial_as_json(handler);
                else
                    storeComponents[num1].write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasComponents()))
          {
            return "When parsing the object for %what%, the \"Components\" field was missing.";
          }
        return null;
      }

    public static new UnionSetOfTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnionSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnionSetOfTime", ignore_extras);
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
    public static new UnionSetOfTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UnionSetOfTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnionSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnionSetOfTime", ignore_extras);
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
    public static new UnionSetOfTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UnionSetOfTimeJSON from_text(string text, bool ignore_extras)
      {
        UnionSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnionSetOfTime", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UnionSetOfTimeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UnionSetOfTimeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UnionSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnionSetOfTime", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SetOfTimeJSON.Generator
      {
        private SetOfTimeJSON.HoldingArrayGenerator fieldGeneratorComponents;
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
            if (!(getSetOfTimeJSONKey().Equals("Union")))
                throw new Exception("The key field has a value other than `Union'.");
            UnionSetOfTimeJSON result = new UnionSetOfTimeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUnionSetOfTimeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SetOfTimeJSON new_result)
          {
            handle_result((UnionSetOfTimeJSON )new_result);
          }
        protected void finish(UnionSetOfTimeJSON result)
          {
            if (fieldGeneratorComponents.have_value)
              {
                result.initComponents();
                int count = fieldGeneratorComponents.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendComponents(fieldGeneratorComponents.value[num]);
                  }
                fieldGeneratorComponents.value.Clear();
                fieldGeneratorComponents.have_value = false;
              }
            else if ((!(result.hasComponents())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Components\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(UnionSetOfTimeJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Components", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorComponents;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorComponents = new SetOfTimeJSON.HoldingArrayGenerator("field \"Components\" of the UnionSetOfTime class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UnionSetOfTime class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorComponents = new SetOfTimeJSON.HoldingArrayGenerator("field \"Components\" of the UnionSetOfTime class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UnionSetOfTime class");
          }

        public override void reset()
          {
            fieldGeneratorComponents.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UnionSetOfTimeJSON  result)
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
        public UnionSetOfTimeJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UnionSetOfTimeJSON  result)
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
    protected virtual void handle_result(List<UnionSetOfTimeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UnionSetOfTimeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UnionSetOfTimeJSON>();
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
    public List<UnionSetOfTimeJSON> value;
  };
  };
