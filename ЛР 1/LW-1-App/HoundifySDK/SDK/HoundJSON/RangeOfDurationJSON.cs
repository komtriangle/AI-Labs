/* file "RangeOfDurationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RangeOfDurationJSON : JSONBase
  {
    private bool flagHasLeftEndpoint;
    private DurationEndpointJSON  storeLeftEndpoint;
    private bool flagHasRightEndpoint;
    private DurationEndpointJSON  storeRightEndpoint;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONLeftEndpoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DurationEndpointJSON convert_classy = DurationEndpointJSON.from_json(json_value, ignore_extras, true);
        setLeftEndpoint(convert_classy);
      }


    private void  fromJSONRightEndpoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DurationEndpointJSON convert_classy = DurationEndpointJSON.from_json(json_value, ignore_extras, true);
        setRightEndpoint(convert_classy);
      }


    public RangeOfDurationJSON()
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

    public DurationEndpointJSON   getLeftEndpoint()
      {
        Debug.Assert(flagHasLeftEndpoint);
        return storeLeftEndpoint;
      }

    public bool  hasRightEndpoint()
      {
        return flagHasRightEndpoint;
      }

    public DurationEndpointJSON   getRightEndpoint()
      {
        Debug.Assert(flagHasRightEndpoint);
        return storeRightEndpoint;
      }


    public virtual int extraRangeOfDurationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRangeOfDurationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRangeOfDurationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRangeOfDurationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setLeftEndpoint(DurationEndpointJSON  new_value)
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
    public void setRightEndpoint(DurationEndpointJSON  new_value)
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

    public virtual void extraRangeOfDurationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRangeOfDurationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRangeOfDurationLookup(key);
        if (old_field == null)
          {
            extraRangeOfDurationAppendPair(key, new_component);
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

    public static RangeOfDurationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RangeOfDurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RangeOfDuration", ignore_extras);
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
    public static RangeOfDurationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RangeOfDurationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RangeOfDurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RangeOfDuration", ignore_extras);
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
    public static RangeOfDurationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RangeOfDurationJSON from_text(string text, bool ignore_extras)
      {
        RangeOfDurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RangeOfDuration", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RangeOfDurationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RangeOfDurationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RangeOfDurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RangeOfDuration", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private DurationEndpointJSON.HoldingGenerator fieldGeneratorLeftEndpoint;
        private DurationEndpointJSON.HoldingGenerator fieldGeneratorRightEndpoint;
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
            RangeOfDurationJSON result = new RangeOfDurationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRangeOfDurationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RangeOfDurationJSON result)
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
        protected abstract void handle_result(RangeOfDurationJSON new_result);
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
            fieldGeneratorLeftEndpoint = new DurationEndpointJSON.HoldingGenerator("field \"LeftEndpoint\" of the RangeOfDuration class", ignore_extras);
            fieldGeneratorRightEndpoint = new DurationEndpointJSON.HoldingGenerator("field \"RightEndpoint\" of the RangeOfDuration class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RangeOfDuration class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorLeftEndpoint = new DurationEndpointJSON.HoldingGenerator("field \"LeftEndpoint\" of the RangeOfDuration class", false);
            fieldGeneratorRightEndpoint = new DurationEndpointJSON.HoldingGenerator("field \"RightEndpoint\" of the RangeOfDuration class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RangeOfDuration class");
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
        protected override void handle_result(RangeOfDurationJSON  result)
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
        public RangeOfDurationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RangeOfDurationJSON  result)
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
    protected virtual void handle_result(List<RangeOfDurationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RangeOfDurationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RangeOfDurationJSON>();
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
    public List<RangeOfDurationJSON> value;
  };
  };
