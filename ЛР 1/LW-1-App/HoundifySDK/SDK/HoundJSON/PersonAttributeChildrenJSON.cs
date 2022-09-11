/* file "PersonAttributeChildrenJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class PersonAttributeChildrenJSON : PersonAttributePersonArrayJSON
  {
    private bool flagHasParameters;
    private PersonAttributeChildrenParametersJSON  storeParameters;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraParametersToJSON()
      {
        JSONValueHandler handler_Parameters = new JSONValueHandler();
        storeParameters.write_as_json(handler_Parameters);
        return handler_Parameters.result;
      }


    private void  fromJSONParameters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PersonAttributeChildrenParametersJSON convert_classy = PersonAttributeChildrenParametersJSON.from_json(json_value, ignore_extras, true);
        setParameters(convert_classy);
      }


    public PersonAttributeChildrenJSON()
      {
        flagHasParameters = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getPersonAttribute()
      {
        return "Children";
      }

    public bool  hasParameters()
      {
        return flagHasParameters;
      }

    public PersonAttributeChildrenParametersJSON   getParameters()
      {
        Debug.Assert(flagHasParameters);
        return storeParameters;
      }


    public virtual int extraPersonAttributeChildrenComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraPersonAttributeChildrenComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraPersonAttributeChildrenComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraPersonAttributeChildrenLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraPersonAttributePersonArrayComponentCount()
      {
        int result = 0;
        if (flagHasParameters)
            ++result;
        result += extraPersonAttributeChildrenComponentCount();
        return result;
      }
    public override string extraPersonAttributePersonArrayComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasParameters)
          {
            if (remainder == 0)
                return "Parameters";
            --remainder;
          }
        return extraPersonAttributeChildrenComponentKey(remainder);
      }
    public override JSONValue extraPersonAttributePersonArrayComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasParameters)
          {
            if (remainder == 0)
                return extraParametersToJSON();
            --remainder;
          }
        return extraPersonAttributeChildrenComponentValue(remainder);
      }
    public override JSONValue extraPersonAttributePersonArrayLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Parameters", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasParameters ? extraParametersToJSON() : null);
        return extraPersonAttributeChildrenLookup(field_name);
      }

    public void setParameters(PersonAttributeChildrenParametersJSON  new_value)
      {
        if (flagHasParameters)
          {
          }
        flagHasParameters = true;
        storeParameters = new_value;
      }
    public void unsetParameters()
      {
        if (flagHasParameters)
          {
          }
        flagHasParameters = false;
      }

    public virtual void extraPersonAttributeChildrenAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraPersonAttributeChildrenSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraPersonAttributeChildrenLookup(key);
        if (old_field == null)
          {
            extraPersonAttributeChildrenAppendPair(key, new_component);
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
    public override void extraPersonAttributePersonArrayAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Parameters", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONParameters(new_component, false);
            return;
            }
        extraPersonAttributeChildrenAppendPair(key, new_component);
      }
    public override void extraPersonAttributePersonArraySetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Parameters", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONParameters(new_component, false);
            return;
            }
        extraPersonAttributeChildrenSetField(key, new_component);
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
        if (flagHasParameters)
          {
            handler.start_pair("Parameters");
            if (partial_allowed)
                storeParameters.write_partial_as_json(handler);
            else
                storeParameters.write_as_json(handler);
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

    public static new PersonAttributeChildrenJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonAttributeChildrenJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeChildren", ignore_extras);
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
    public static new PersonAttributeChildrenJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonAttributeChildrenJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonAttributeChildrenJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeChildren", ignore_extras);
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
    public static new PersonAttributeChildrenJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonAttributeChildrenJSON from_text(string text, bool ignore_extras)
      {
        PersonAttributeChildrenJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeChildren", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PersonAttributeChildrenJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new PersonAttributeChildrenJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PersonAttributeChildrenJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeChildren", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PersonAttributePersonArrayJSON.Generator
      {
        private PersonAttributeChildrenParametersJSON.HoldingGenerator fieldGeneratorParameters;
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
            if (!(getPersonAttributePersonArrayJSONKey().Equals("Children")))
                throw new Exception("The key field has a value other than `Children'.");
            PersonAttributeChildrenJSON result = new PersonAttributeChildrenJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPersonAttributeChildrenAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(PersonAttributePersonArrayJSON new_result)
          {
            handle_result((PersonAttributeChildrenJSON )new_result);
          }
        protected void finish(PersonAttributeChildrenJSON result)
          {
            if (fieldGeneratorParameters.have_value)
              {
                result.setParameters(fieldGeneratorParameters.value);
                fieldGeneratorParameters.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(PersonAttributeChildrenJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Parameters", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorParameters;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorParameters = new PersonAttributeChildrenParametersJSON.HoldingGenerator("field \"Parameters\" of the PersonAttributeChildren class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the PersonAttributeChildren class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorParameters = new PersonAttributeChildrenParametersJSON.HoldingGenerator("field \"Parameters\" of the PersonAttributeChildren class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the PersonAttributeChildren class");
          }

        public override void reset()
          {
            fieldGeneratorParameters.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(PersonAttributeChildrenJSON  result)
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
        public PersonAttributeChildrenJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PersonAttributeChildrenJSON  result)
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
    protected virtual void handle_result(List<PersonAttributeChildrenJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PersonAttributeChildrenJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PersonAttributeChildrenJSON>();
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
    public List<PersonAttributeChildrenJSON> value;
  };
  };
