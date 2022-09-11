/* file "PersonQueriesPersonArrayNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class PersonQueriesPersonArrayNuggetJSON : PersonQueriesAttributeNuggetJSON
  {
    private bool flagHasResult;
    private List< WhoJSON  > storeResult;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraResultToJSON()
      {
        JSONArrayValue generated_array_1_Result = new JSONArrayValue();
        for (int num1 = 0; num1 < storeResult.Count; ++num1)
          {
            JSONValueHandler handler_Result = new JSONValueHandler();
            storeResult[num1].write_as_json(handler_Result);
            generated_array_1_Result.appendComponent(handler_Result.result);
          }
        return generated_array_1_Result;
      }


    private void  fromJSONResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Result of PersonQueriesPersonArrayNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< WhoJSON  > vector_Result1 = new List< WhoJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            WhoJSON convert_classy = WhoJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Result1.Add(convert_classy);
          }
        initResult();
        for (int num1 = 0; num1 < vector_Result1.Count; ++num1)
            appendResult(vector_Result1[num1]);
        for (int num1 = 0; num1 < vector_Result1.Count; ++num1)
          {
          }
      }


    public PersonQueriesPersonArrayNuggetJSON()
      {
        flagHasResult = false;
        storeResult = new List< WhoJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getResultType()
      {
        return "PersonArray";
      }

    public bool  hasResult()
      {
        return flagHasResult;
      }

    public int  countOfResult()
      {
        Debug.Assert(flagHasResult);
        return storeResult.Count;
      }

    public WhoJSON   elementOfResult(int element_num)
      {
        Debug.Assert(flagHasResult);
        return storeResult[element_num];
      }

    public List< WhoJSON  >  getResult()
      {
        Debug.Assert(flagHasResult);
        return storeResult;
      }


    public virtual int extraPersonQueriesPersonArrayNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraPersonQueriesPersonArrayNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraPersonQueriesPersonArrayNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraPersonQueriesPersonArrayNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraPersonQueriesAttributeNuggetComponentCount()
      {
        int result = 0;
        if (flagHasResult)
            ++result;
        result += extraPersonQueriesPersonArrayNuggetComponentCount();
        return result;
      }
    public override string extraPersonQueriesAttributeNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasResult)
          {
            if (remainder == 0)
                return "Result";
            --remainder;
          }
        return extraPersonQueriesPersonArrayNuggetComponentKey(remainder);
      }
    public override JSONValue extraPersonQueriesAttributeNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasResult)
          {
            if (remainder == 0)
                return extraResultToJSON();
            --remainder;
          }
        return extraPersonQueriesPersonArrayNuggetComponentValue(remainder);
      }
    public override JSONValue extraPersonQueriesAttributeNuggetLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Result", 0, 6, false) == 0) && (field_name.Length == 6))
            return (flagHasResult ? extraResultToJSON() : null);
        return extraPersonQueriesPersonArrayNuggetLookup(field_name);
      }

    public void initResult()
      {
        if (flagHasResult)
          {
            for (int num1 = 0; num1 < storeResult.Count; ++num1)
              {
              }
          }
        flagHasResult = true;
        storeResult.Clear();
      }
    public void appendResult(WhoJSON  to_append)
      {
        if (!flagHasResult)
          {
            flagHasResult = true;
            storeResult.Clear();
          }
        Debug.Assert(flagHasResult);
        storeResult.Add(to_append);
      }
    public void unsetResult()
      {
        if (flagHasResult)
          {
            for (int num2 = 0; num2 < storeResult.Count; ++num2)
              {
              }
          }
        flagHasResult = false;
        storeResult.Clear();
      }

    public virtual void extraPersonQueriesPersonArrayNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraPersonQueriesPersonArrayNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraPersonQueriesPersonArrayNuggetLookup(key);
        if (old_field == null)
          {
            extraPersonQueriesPersonArrayNuggetAppendPair(key, new_component);
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
    public override void extraPersonQueriesAttributeNuggetAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Result", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONResult(new_component, false);
            return;
            }
        extraPersonQueriesPersonArrayNuggetAppendPair(key, new_component);
      }
    public override void extraPersonQueriesAttributeNuggetSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Result", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONResult(new_component, false);
            return;
            }
        extraPersonQueriesPersonArrayNuggetSetField(key, new_component);
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
        if (flagHasResult)
          {
            handler.start_pair("Result");
            handler.start_array();
            for (int num1 = 0; num1 < storeResult.Count; ++num1)
              {
                if (partial_allowed)
                    storeResult[num1].write_partial_as_json(handler);
                else
                    storeResult[num1].write_as_json(handler);
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
        return null;
      }

    public static new PersonQueriesPersonArrayNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonQueriesPersonArrayNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonQueriesPersonArrayNugget", ignore_extras);
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
    public static new PersonQueriesPersonArrayNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonQueriesPersonArrayNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonQueriesPersonArrayNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonQueriesPersonArrayNugget", ignore_extras);
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
    public static new PersonQueriesPersonArrayNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonQueriesPersonArrayNuggetJSON from_text(string text, bool ignore_extras)
      {
        PersonQueriesPersonArrayNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonQueriesPersonArrayNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PersonQueriesPersonArrayNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new PersonQueriesPersonArrayNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PersonQueriesPersonArrayNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonQueriesPersonArrayNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PersonQueriesAttributeNuggetJSON.Generator
      {
        private WhoJSON.HoldingArrayGenerator fieldGeneratorResult;
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
            if (!(getPersonQueriesAttributeNuggetJSONKey().Equals("PersonArray")))
                throw new Exception("The key field has a value other than `PersonArray'.");
            PersonQueriesPersonArrayNuggetJSON result = new PersonQueriesPersonArrayNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPersonQueriesPersonArrayNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(PersonQueriesAttributeNuggetJSON new_result)
          {
            handle_result((PersonQueriesPersonArrayNuggetJSON )new_result);
          }
        protected void finish(PersonQueriesPersonArrayNuggetJSON result)
          {
            if (fieldGeneratorResult.have_value)
              {
                result.initResult();
                int count = fieldGeneratorResult.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendResult(fieldGeneratorResult.value[num]);
                  }
                fieldGeneratorResult.value.Clear();
                fieldGeneratorResult.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(PersonQueriesPersonArrayNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Result", 0, 6, false) == 0) && (field_name.Length == 6))
                return fieldGeneratorResult;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorResult = new WhoJSON.HoldingArrayGenerator("field \"Result\" of the PersonQueriesPersonArrayNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the PersonQueriesPersonArrayNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorResult = new WhoJSON.HoldingArrayGenerator("field \"Result\" of the PersonQueriesPersonArrayNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the PersonQueriesPersonArrayNugget class");
          }

        public override void reset()
          {
            fieldGeneratorResult.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(PersonQueriesPersonArrayNuggetJSON  result)
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
        public PersonQueriesPersonArrayNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PersonQueriesPersonArrayNuggetJSON  result)
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
    protected virtual void handle_result(List<PersonQueriesPersonArrayNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PersonQueriesPersonArrayNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PersonQueriesPersonArrayNuggetJSON>();
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
    public List<PersonQueriesPersonArrayNuggetJSON> value;
  };
  };
