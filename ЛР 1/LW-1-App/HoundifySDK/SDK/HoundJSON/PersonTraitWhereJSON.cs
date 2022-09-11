/* file "PersonTraitWhereJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class PersonTraitWhereJSON : PersonTraitJSON
  {
    private bool flagHasWhereValue;
    private MapLocationJSON  storeWhereValue;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraWhereValueToJSON()
      {
        JSONValueHandler handler_WhereValue = new JSONValueHandler();
        storeWhereValue.write_as_json(handler_WhereValue);
        return handler_WhereValue.result;
      }


    private void  fromJSONWhereValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setWhereValue(convert_classy);
      }


    public PersonTraitWhereJSON()
      {
        flagHasWhereValue = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getTraitType()
      {
        return "Where";
      }

    public bool  hasWhereValue()
      {
        return flagHasWhereValue;
      }

    public MapLocationJSON   getWhereValue()
      {
        Debug.Assert(flagHasWhereValue);
        return storeWhereValue;
      }


    public virtual int extraPersonTraitWhereComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraPersonTraitWhereComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraPersonTraitWhereComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraPersonTraitWhereLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraPersonTraitComponentCount()
      {
        int result = 0;
        if (flagHasWhereValue)
            ++result;
        result += extraPersonTraitWhereComponentCount();
        return result;
      }
    public override string extraPersonTraitComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasWhereValue)
          {
            if (remainder == 0)
                return "WhereValue";
            --remainder;
          }
        return extraPersonTraitWhereComponentKey(remainder);
      }
    public override JSONValue extraPersonTraitComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasWhereValue)
          {
            if (remainder == 0)
                return extraWhereValueToJSON();
            --remainder;
          }
        return extraPersonTraitWhereComponentValue(remainder);
      }
    public override JSONValue extraPersonTraitLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "WhereValue", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasWhereValue ? extraWhereValueToJSON() : null);
        return extraPersonTraitWhereLookup(field_name);
      }

    public void setWhereValue(MapLocationJSON  new_value)
      {
        if (flagHasWhereValue)
          {
          }
        flagHasWhereValue = true;
        storeWhereValue = new_value;
      }
    public void unsetWhereValue()
      {
        if (flagHasWhereValue)
          {
          }
        flagHasWhereValue = false;
      }

    public virtual void extraPersonTraitWhereAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraPersonTraitWhereSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraPersonTraitWhereLookup(key);
        if (old_field == null)
          {
            extraPersonTraitWhereAppendPair(key, new_component);
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
    public override void extraPersonTraitAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "WhereValue", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONWhereValue(new_component, false);
            return;
            }
        extraPersonTraitWhereAppendPair(key, new_component);
      }
    public override void extraPersonTraitSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "WhereValue", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONWhereValue(new_component, false);
            return;
            }
        extraPersonTraitWhereSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasWhereValue);
        if (flagHasWhereValue)
          {
            handler.start_pair("WhereValue");
            if (partial_allowed)
                storeWhereValue.write_partial_as_json(handler);
            else
                storeWhereValue.write_as_json(handler);
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
        if (!(hasWhereValue()))
          {
            return "When parsing the object for %what%, the \"WhereValue\" field was missing.";
          }
        return null;
      }

    public static new PersonTraitWhereJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonTraitWhereJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonTraitWhere", ignore_extras);
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
    public static new PersonTraitWhereJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonTraitWhereJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonTraitWhereJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonTraitWhere", ignore_extras);
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
    public static new PersonTraitWhereJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonTraitWhereJSON from_text(string text, bool ignore_extras)
      {
        PersonTraitWhereJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonTraitWhere", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PersonTraitWhereJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new PersonTraitWhereJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PersonTraitWhereJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonTraitWhere", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PersonTraitJSON.Generator
      {
        private MapLocationJSON.HoldingGenerator fieldGeneratorWhereValue;
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
            if (!(getPersonTraitJSONKey().Equals("Where")))
                throw new Exception("The key field has a value other than `Where'.");
            PersonTraitWhereJSON result = new PersonTraitWhereJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPersonTraitWhereAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(PersonTraitJSON new_result)
          {
            handle_result((PersonTraitWhereJSON )new_result);
          }
        protected void finish(PersonTraitWhereJSON result)
          {
            if (fieldGeneratorWhereValue.have_value)
              {
                result.setWhereValue(fieldGeneratorWhereValue.value);
                fieldGeneratorWhereValue.have_value = false;
              }
            else if ((!(result.hasWhereValue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WhereValue\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(PersonTraitWhereJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "WhereValue", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorWhereValue;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorWhereValue = new MapLocationJSON.HoldingGenerator("field \"WhereValue\" of the PersonTraitWhere class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the PersonTraitWhere class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorWhereValue = new MapLocationJSON.HoldingGenerator("field \"WhereValue\" of the PersonTraitWhere class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the PersonTraitWhere class");
          }

        public override void reset()
          {
            fieldGeneratorWhereValue.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(PersonTraitWhereJSON  result)
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
        public PersonTraitWhereJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PersonTraitWhereJSON  result)
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
    protected virtual void handle_result(List<PersonTraitWhereJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PersonTraitWhereJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PersonTraitWhereJSON>();
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
    public List<PersonTraitWhereJSON> value;
  };
  };
