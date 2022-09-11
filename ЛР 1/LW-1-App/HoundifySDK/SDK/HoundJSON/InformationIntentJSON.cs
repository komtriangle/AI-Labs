/* file "InformationIntentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class InformationIntentJSON : CommandIntentJSON
  {
    private bool flagHasInformationNuggets;
    private List< InformationNuggetIntentJSON  > storeInformationNuggets;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraInformationNuggetsToJSON()
      {
        JSONArrayValue generated_array_1_InformationNuggets = new JSONArrayValue();
        for (int num1 = 0; num1 < storeInformationNuggets.Count; ++num1)
          {
            JSONValueHandler handler_InformationNuggets = new JSONValueHandler();
            storeInformationNuggets[num1].write_as_json(handler_InformationNuggets);
            generated_array_1_InformationNuggets.appendComponent(handler_InformationNuggets.result);
          }
        return generated_array_1_InformationNuggets;
      }


    private void  fromJSONInformationNuggets(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InformationNuggets of InformationIntentJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field InformationNuggets of InformationIntentJSON has too few elements.");
        List< InformationNuggetIntentJSON  > vector_InformationNuggets1 = new List< InformationNuggetIntentJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            InformationNuggetIntentJSON convert_classy = InformationNuggetIntentJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_InformationNuggets1.Add(convert_classy);
          }
        Debug.Assert(vector_InformationNuggets1.Count >= 1);
        initInformationNuggets();
        for (int num1 = 0; num1 < vector_InformationNuggets1.Count; ++num1)
            appendInformationNuggets(vector_InformationNuggets1[num1]);
        for (int num1 = 0; num1 < vector_InformationNuggets1.Count; ++num1)
          {
          }
      }


    public InformationIntentJSON()
      {
        flagHasInformationNuggets = false;
        storeInformationNuggets = new List< InformationNuggetIntentJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandIntentKind()
      {
        return "Information";
      }

    public bool  hasInformationNuggets()
      {
        return flagHasInformationNuggets;
      }

    public int  countOfInformationNuggets()
      {
        Debug.Assert(flagHasInformationNuggets);
        return storeInformationNuggets.Count;
      }

    public InformationNuggetIntentJSON   elementOfInformationNuggets(int element_num)
      {
        Debug.Assert(flagHasInformationNuggets);
        return storeInformationNuggets[element_num];
      }

    public List< InformationNuggetIntentJSON  >  getInformationNuggets()
      {
        Debug.Assert(flagHasInformationNuggets);
        return storeInformationNuggets;
      }


    public virtual int extraInformationIntentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraInformationIntentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraInformationIntentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraInformationIntentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandIntentComponentCount()
      {
        int result = 0;
        if (flagHasInformationNuggets)
            ++result;
        result += extraInformationIntentComponentCount();
        return result;
      }
    public override string extraCommandIntentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasInformationNuggets)
          {
            if (remainder == 0)
                return "InformationNuggets";
            --remainder;
          }
        return extraInformationIntentComponentKey(remainder);
      }
    public override JSONValue extraCommandIntentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasInformationNuggets)
          {
            if (remainder == 0)
                return extraInformationNuggetsToJSON();
            --remainder;
          }
        return extraInformationIntentComponentValue(remainder);
      }
    public override JSONValue extraCommandIntentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "InformationNuggets", 0, 18, false) == 0) && (field_name.Length == 18))
            return (flagHasInformationNuggets ? extraInformationNuggetsToJSON() : null);
        return extraInformationIntentLookup(field_name);
      }

    public void initInformationNuggets()
      {
        if (flagHasInformationNuggets)
          {
            for (int num1 = 0; num1 < storeInformationNuggets.Count; ++num1)
              {
              }
          }
        flagHasInformationNuggets = true;
        storeInformationNuggets.Clear();
      }
    public void appendInformationNuggets(InformationNuggetIntentJSON  to_append)
      {
        if (!flagHasInformationNuggets)
          {
            flagHasInformationNuggets = true;
            storeInformationNuggets.Clear();
          }
        Debug.Assert(flagHasInformationNuggets);
        storeInformationNuggets.Add(to_append);
      }
    public void unsetInformationNuggets()
      {
        if (flagHasInformationNuggets)
          {
            for (int num2 = 0; num2 < storeInformationNuggets.Count; ++num2)
              {
              }
          }
        flagHasInformationNuggets = false;
        storeInformationNuggets.Clear();
      }

    public virtual void extraInformationIntentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraInformationIntentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraInformationIntentLookup(key);
        if (old_field == null)
          {
            extraInformationIntentAppendPair(key, new_component);
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
    public override void extraCommandIntentAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "InformationNuggets", 0, 18, false) == 0) && (key.Length == 18))
            {
            fromJSONInformationNuggets(new_component, false);
            return;
            }
        extraInformationIntentAppendPair(key, new_component);
      }
    public override void extraCommandIntentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "InformationNuggets", 0, 18, false) == 0) && (key.Length == 18))
            {
            fromJSONInformationNuggets(new_component, false);
            return;
            }
        extraInformationIntentSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasInformationNuggets);
        if (flagHasInformationNuggets)
          {
            handler.start_pair("InformationNuggets");
            Debug.Assert(storeInformationNuggets.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeInformationNuggets.Count; ++num1)
              {
                if (partial_allowed)
                    storeInformationNuggets[num1].write_partial_as_json(handler);
                else
                    storeInformationNuggets[num1].write_as_json(handler);
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
        if (!(hasInformationNuggets()))
          {
            return "When parsing the object for %what%, the \"InformationNuggets\" field was missing.";
          }
        return null;
      }

    public static new InformationIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        InformationIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type InformationIntent", ignore_extras);
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
    public static new InformationIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new InformationIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        InformationIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type InformationIntent", ignore_extras);
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
    public static new InformationIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new InformationIntentJSON from_text(string text, bool ignore_extras)
      {
        InformationIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type InformationIntent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for InformationIntentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new InformationIntentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        InformationIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type InformationIntent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandIntentJSON.Generator
      {
        private InformationNuggetIntentJSON.HoldingArrayGenerator fieldGeneratorInformationNuggets;
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
            if (!(getCommandIntentJSONKey().Equals("Information")))
                throw new Exception("The key field has a value other than `Information'.");
            InformationIntentJSON result = new InformationIntentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraInformationIntentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandIntentJSON new_result)
          {
            handle_result((InformationIntentJSON )new_result);
          }
        protected void finish(InformationIntentJSON result)
          {
            if (fieldGeneratorInformationNuggets.have_value)
              {
                result.initInformationNuggets();
                int count = fieldGeneratorInformationNuggets.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInformationNuggets(fieldGeneratorInformationNuggets.value[num]);
                  }
                fieldGeneratorInformationNuggets.value.Clear();
                fieldGeneratorInformationNuggets.have_value = false;
              }
            else if ((!(result.hasInformationNuggets())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InformationNuggets\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(InformationIntentJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "InformationNuggets", 0, 18, false) == 0) && (field_name.Length == 18))
                return fieldGeneratorInformationNuggets;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorInformationNuggets = new InformationNuggetIntentJSON.HoldingArrayGenerator("field \"InformationNuggets\" of the InformationIntent class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the InformationIntent class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorInformationNuggets = new InformationNuggetIntentJSON.HoldingArrayGenerator("field \"InformationNuggets\" of the InformationIntent class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the InformationIntent class");
          }

        public override void reset()
          {
            fieldGeneratorInformationNuggets.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(InformationIntentJSON  result)
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
        public InformationIntentJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(InformationIntentJSON  result)
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
    protected virtual void handle_result(List<InformationIntentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<InformationIntentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<InformationIntentJSON>();
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
    public List<InformationIntentJSON> value;
  };
  };
