/* file "SportsStandingsArgumentQueryTypeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsStandingsArgumentQueryTypeJSON : SportsStandingsArgumentJSON
  {
    private bool flagHasQueryType;
    private SportsStandingsQueryTypeJSON  storeQueryType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraQueryTypeToJSON()
      {
        JSONValueHandler handler_QueryType = new JSONValueHandler();
        storeQueryType.write_as_json(handler_QueryType);
        return handler_QueryType.result;
      }


    private void  fromJSONQueryType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsStandingsQueryTypeJSON convert_classy = SportsStandingsQueryTypeJSON.from_json(json_value, ignore_extras, true);
        setQueryType(convert_classy);
      }


    public SportsStandingsArgumentQueryTypeJSON()
      {
        flagHasQueryType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsStandingsArgumentKind()
      {
        return "QueryType";
      }

    public bool  hasQueryType()
      {
        return flagHasQueryType;
      }

    public SportsStandingsQueryTypeJSON   getQueryType()
      {
        Debug.Assert(flagHasQueryType);
        return storeQueryType;
      }

    public SportsStandingsQueryTypeJSON.TypeValue  getQueryTypeValue()
      {
        return getQueryType().getValue();
      }

    public string  getQueryTypeAsString()
      {
        return getQueryType().getValueAsString();
      }


    public virtual int extraSportsStandingsArgumentQueryTypeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsStandingsArgumentQueryTypeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsStandingsArgumentQueryTypeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsStandingsArgumentQueryTypeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsStandingsArgumentComponentCount()
      {
        int result = 0;
        if (flagHasQueryType)
            ++result;
        result += extraSportsStandingsArgumentQueryTypeComponentCount();
        return result;
      }
    public override string extraSportsStandingsArgumentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryType)
          {
            if (remainder == 0)
                return "QueryType";
            --remainder;
          }
        return extraSportsStandingsArgumentQueryTypeComponentKey(remainder);
      }
    public override JSONValue extraSportsStandingsArgumentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryType)
          {
            if (remainder == 0)
                return extraQueryTypeToJSON();
            --remainder;
          }
        return extraSportsStandingsArgumentQueryTypeComponentValue(remainder);
      }
    public override JSONValue extraSportsStandingsArgumentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "QueryType", 0, 9, false) == 0) && (field_name.Length == 9))
            return (flagHasQueryType ? extraQueryTypeToJSON() : null);
        return extraSportsStandingsArgumentQueryTypeLookup(field_name);
      }

    public void setQueryType(SportsStandingsQueryTypeJSON  new_value)
      {
        if (flagHasQueryType)
          {
          }
        flagHasQueryType = true;
        storeQueryType = new_value;
      }
    public void setQueryType(SportsStandingsQueryTypeJSON.TypeValue new_value)
      {
        setQueryType(new SportsStandingsQueryTypeJSON(new_value));
      }
    public void setQueryType(string chars)
      {
        SportsStandingsQueryTypeJSON.TypeValueKnownValues known = SportsStandingsQueryTypeJSON.stringToValue(chars);
        SportsStandingsQueryTypeJSON.TypeValue new_value = new SportsStandingsQueryTypeJSON.TypeValue();
        if (known == SportsStandingsQueryTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setQueryType(new_value);
      }
    public void unsetQueryType()
      {
        if (flagHasQueryType)
          {
          }
        flagHasQueryType = false;
      }

    public virtual void extraSportsStandingsArgumentQueryTypeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsStandingsArgumentQueryTypeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsStandingsArgumentQueryTypeLookup(key);
        if (old_field == null)
          {
            extraSportsStandingsArgumentQueryTypeAppendPair(key, new_component);
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
    public override void extraSportsStandingsArgumentAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "QueryType", 0, 9, false) == 0) && (key.Length == 9))
            {
            fromJSONQueryType(new_component, false);
            return;
            }
        extraSportsStandingsArgumentQueryTypeAppendPair(key, new_component);
      }
    public override void extraSportsStandingsArgumentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "QueryType", 0, 9, false) == 0) && (key.Length == 9))
            {
            fromJSONQueryType(new_component, false);
            return;
            }
        extraSportsStandingsArgumentQueryTypeSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQueryType);
        if (flagHasQueryType)
          {
            handler.start_pair("QueryType");
            if (partial_allowed)
                storeQueryType.write_partial_as_json(handler);
            else
                storeQueryType.write_as_json(handler);
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
        if (!(hasQueryType()))
          {
            return "When parsing the object for %what%, the \"QueryType\" field was missing.";
          }
        return null;
      }

    public static new SportsStandingsArgumentQueryTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsArgumentQueryTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentQueryType", ignore_extras);
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
    public static new SportsStandingsArgumentQueryTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsStandingsArgumentQueryTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsArgumentQueryTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentQueryType", ignore_extras);
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
    public static new SportsStandingsArgumentQueryTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsStandingsArgumentQueryTypeJSON from_text(string text, bool ignore_extras)
      {
        SportsStandingsArgumentQueryTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentQueryType", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStandingsArgumentQueryTypeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsStandingsArgumentQueryTypeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStandingsArgumentQueryTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentQueryType", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsStandingsArgumentJSON.Generator
      {
        private SportsStandingsQueryTypeJSON.HoldingGenerator fieldGeneratorQueryType;
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
            if (!(getSportsStandingsArgumentJSONKey().Equals("QueryType")))
                throw new Exception("The key field has a value other than `QueryType'.");
            SportsStandingsArgumentQueryTypeJSON result = new SportsStandingsArgumentQueryTypeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStandingsArgumentQueryTypeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsStandingsArgumentJSON new_result)
          {
            handle_result((SportsStandingsArgumentQueryTypeJSON )new_result);
          }
        protected void finish(SportsStandingsArgumentQueryTypeJSON result)
          {
            if (fieldGeneratorQueryType.have_value)
              {
                result.setQueryType(fieldGeneratorQueryType.value);
                fieldGeneratorQueryType.have_value = false;
              }
            else if ((!(result.hasQueryType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryType\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsStandingsArgumentQueryTypeJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "QueryType", 0, 9, false) == 0) && (field_name.Length == 9))
                return fieldGeneratorQueryType;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorQueryType = new SportsStandingsQueryTypeJSON.HoldingGenerator("field \"QueryType\" of the SportsStandingsArgumentQueryType class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsStandingsArgumentQueryType class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorQueryType = new SportsStandingsQueryTypeJSON.HoldingGenerator("field \"QueryType\" of the SportsStandingsArgumentQueryType class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsStandingsArgumentQueryType class");
          }

        public override void reset()
          {
            fieldGeneratorQueryType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsStandingsArgumentQueryTypeJSON  result)
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
        public SportsStandingsArgumentQueryTypeJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStandingsArgumentQueryTypeJSON  result)
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
    protected virtual void handle_result(List<SportsStandingsArgumentQueryTypeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStandingsArgumentQueryTypeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStandingsArgumentQueryTypeJSON>();
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
    public List<SportsStandingsArgumentQueryTypeJSON> value;
  };
  };
