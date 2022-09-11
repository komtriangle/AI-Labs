/* file "IntegerIntervalJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class IntegerIntervalJSON : JSONBase
  {
    private bool flagHasLeftEndpoint;
    private IntegerEndpointJSON  storeLeftEndpoint;
    private bool flagHasRightEndpoint;
    private IntegerEndpointJSON  storeRightEndpoint;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONLeftEndpoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IntegerEndpointJSON convert_classy = IntegerEndpointJSON.from_json(json_value, ignore_extras, true);
        setLeftEndpoint(convert_classy);
      }


    private void  fromJSONRightEndpoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IntegerEndpointJSON convert_classy = IntegerEndpointJSON.from_json(json_value, ignore_extras, true);
        setRightEndpoint(convert_classy);
      }


    public IntegerIntervalJSON()
      {
        flagHasLeftEndpoint = false;
        flagHasRightEndpoint = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasLeftEndpoint()
      {
        return flagHasLeftEndpoint;
      }

    public IntegerEndpointJSON   getLeftEndpoint()
      {
        Debug.Assert(flagHasLeftEndpoint);
        return storeLeftEndpoint;
      }

    public bool  hasRightEndpoint()
      {
        return flagHasRightEndpoint;
      }

    public IntegerEndpointJSON   getRightEndpoint()
      {
        Debug.Assert(flagHasRightEndpoint);
        return storeRightEndpoint;
      }


    public virtual int extraIntegerIntervalComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIntegerIntervalComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIntegerIntervalComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIntegerIntervalLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setLeftEndpoint(IntegerEndpointJSON  new_value)
      {
        if (flagHasLeftEndpoint)
          {
          }
        flagHasLeftEndpoint = true;
        storeLeftEndpoint = new_value;
      }
    public void unsetLeftEndpoint()
      {
        if (flagHasLeftEndpoint)
          {
          }
        flagHasLeftEndpoint = false;
      }
    public void setRightEndpoint(IntegerEndpointJSON  new_value)
      {
        if (flagHasRightEndpoint)
          {
          }
        flagHasRightEndpoint = true;
        storeRightEndpoint = new_value;
      }
    public void unsetRightEndpoint()
      {
        if (flagHasRightEndpoint)
          {
          }
        flagHasRightEndpoint = false;
      }

    public virtual void extraIntegerIntervalAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIntegerIntervalSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIntegerIntervalLookup(key);
        if (old_field == null)
          {
            extraIntegerIntervalAppendPair(key, new_component);
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
        if (flagHasLeftEndpoint)
          {
            handler.start_pair("LeftEndpoint");
            if (partial_allowed)
                storeLeftEndpoint.write_partial_as_json(handler);
            else
                storeLeftEndpoint.write_as_json(handler);
          }
        if (flagHasRightEndpoint)
          {
            handler.start_pair("RightEndpoint");
            if (partial_allowed)
                storeRightEndpoint.write_partial_as_json(handler);
            else
                storeRightEndpoint.write_as_json(handler);
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

    public static IntegerIntervalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IntegerIntervalJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IntegerInterval", ignore_extras);
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
    public static IntegerIntervalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IntegerIntervalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IntegerIntervalJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IntegerInterval", ignore_extras);
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
    public static IntegerIntervalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IntegerIntervalJSON from_text(string text, bool ignore_extras)
      {
        IntegerIntervalJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IntegerInterval", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IntegerIntervalJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IntegerIntervalJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IntegerIntervalJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IntegerInterval", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private IntegerEndpointJSON.HoldingGenerator fieldGeneratorLeftEndpoint;
        private IntegerEndpointJSON.HoldingGenerator fieldGeneratorRightEndpoint;
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
            IntegerIntervalJSON result = new IntegerIntervalJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIntegerIntervalAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IntegerIntervalJSON result)
          {
            if (fieldGeneratorLeftEndpoint.have_value)
              {
                result.setLeftEndpoint(fieldGeneratorLeftEndpoint.value);
                fieldGeneratorLeftEndpoint.have_value = false;
              }
            if (fieldGeneratorRightEndpoint.have_value)
              {
                result.setRightEndpoint(fieldGeneratorRightEndpoint.value);
                fieldGeneratorRightEndpoint.have_value = false;
              }
          }
        protected abstract void handle_result(IntegerIntervalJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'L':
                    if ((String.Compare(field_name, 1, "eftEndpoint", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorLeftEndpoint;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ightEndpoint", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorRightEndpoint;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorLeftEndpoint = new IntegerEndpointJSON.HoldingGenerator("field \"LeftEndpoint\" of the IntegerInterval class", ignore_extras);
            fieldGeneratorRightEndpoint = new IntegerEndpointJSON.HoldingGenerator("field \"RightEndpoint\" of the IntegerInterval class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IntegerInterval class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorLeftEndpoint = new IntegerEndpointJSON.HoldingGenerator("field \"LeftEndpoint\" of the IntegerInterval class", false);
            fieldGeneratorRightEndpoint = new IntegerEndpointJSON.HoldingGenerator("field \"RightEndpoint\" of the IntegerInterval class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IntegerInterval class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorLeftEndpoint.reset();
            fieldGeneratorRightEndpoint.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorLeftEndpoint.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRightEndpoint.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorLeftEndpoint.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRightEndpoint.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(IntegerIntervalJSON  result)
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
        public IntegerIntervalJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IntegerIntervalJSON  result)
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
    protected virtual void handle_result(List<IntegerIntervalJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IntegerIntervalJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IntegerIntervalJSON>();
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
    public List<IntegerIntervalJSON> value;
  };
  };
