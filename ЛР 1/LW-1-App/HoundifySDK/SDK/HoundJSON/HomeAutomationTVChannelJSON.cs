/* file "HomeAutomationTVChannelJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HomeAutomationTVChannelJSON : TVChannelJSON
  {
    private bool flagHasChannelDelta;
    private BigInteger storeChannelDelta;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraChannelDeltaToJSON()
      {
        JSONIntegerValue generated_integer_ChannelDelta = new JSONIntegerValue(storeChannelDelta);
        return generated_integer_ChannelDelta;
      }


    private void  fromJSONChannelDelta(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ChannelDelta of HomeAutomationTVChannelJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ChannelDelta of HomeAutomationTVChannelJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setChannelDelta(extracted_integer);
      }


    public HomeAutomationTVChannelJSON()
      {
        flagHasChannelDelta = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasChannelDelta()
      {
        return flagHasChannelDelta;
      }

    public BigInteger  getChannelDelta()
      {
        Debug.Assert(flagHasChannelDelta);
        return storeChannelDelta;
      }


    public virtual int extraHomeAutomationTVChannelComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationTVChannelComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationTVChannelComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationTVChannelLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraTVChannelComponentCount()
      {
        int result = 0;
        if (flagHasChannelDelta)
            ++result;
        result += extraHomeAutomationTVChannelComponentCount();
        return result;
      }
    public override string extraTVChannelComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasChannelDelta)
          {
            if (remainder == 0)
                return "ChannelDelta";
            --remainder;
          }
        return extraHomeAutomationTVChannelComponentKey(remainder);
      }
    public override JSONValue extraTVChannelComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasChannelDelta)
          {
            if (remainder == 0)
                return extraChannelDeltaToJSON();
            --remainder;
          }
        return extraHomeAutomationTVChannelComponentValue(remainder);
      }
    public override JSONValue extraTVChannelLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "ChannelDelta", 0, 12, false) == 0) && (field_name.Length == 12))
            return (flagHasChannelDelta ? extraChannelDeltaToJSON() : null);
        return extraHomeAutomationTVChannelLookup(field_name);
      }

    public void setChannelDelta(BigInteger new_value)
      {
        flagHasChannelDelta = true;
        storeChannelDelta = new_value;
      }
    public void unsetChannelDelta()
      {
        flagHasChannelDelta = false;
      }

    public virtual void extraHomeAutomationTVChannelAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationTVChannelSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationTVChannelLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationTVChannelAppendPair(key, new_component);
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
    public override void extraTVChannelAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "ChannelDelta", 0, 12, false) == 0) && (key.Length == 12))
            {
            fromJSONChannelDelta(new_component, false);
            return;
            }
        extraHomeAutomationTVChannelAppendPair(key, new_component);
      }
    public override void extraTVChannelSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "ChannelDelta", 0, 12, false) == 0) && (key.Length == 12))
            {
            fromJSONChannelDelta(new_component, false);
            return;
            }
        extraHomeAutomationTVChannelSetField(key, new_component);
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
        if (flagHasChannelDelta)
          {
            handler.start_pair("ChannelDelta");
            handler.number_value(storeChannelDelta);
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

    public static new HomeAutomationTVChannelJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationTVChannelJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationTVChannel", ignore_extras);
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
    public static new HomeAutomationTVChannelJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HomeAutomationTVChannelJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationTVChannelJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationTVChannel", ignore_extras);
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
    public static new HomeAutomationTVChannelJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HomeAutomationTVChannelJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationTVChannelJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationTVChannel", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationTVChannelJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new HomeAutomationTVChannelJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationTVChannelJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationTVChannel", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : TVChannelJSON.Generator
      {
    private class FieldHoldingGeneratorChannelDelta : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorChannelDelta(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorChannelDelta : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorChannelDelta(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorChannelDelta fieldGeneratorChannelDelta;
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
            HomeAutomationTVChannelJSON result = new HomeAutomationTVChannelJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationTVChannelAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(TVChannelJSON new_result)
          {
            handle_result((HomeAutomationTVChannelJSON )new_result);
          }
        protected void finish(HomeAutomationTVChannelJSON result)
          {
            if (fieldGeneratorChannelDelta.have_value)
              {
                result.setChannelDelta(fieldGeneratorChannelDelta.value);
                fieldGeneratorChannelDelta.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(HomeAutomationTVChannelJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "ChannelDelta", 0, 12, false) == 0) && (field_name.Length == 12))
                return fieldGeneratorChannelDelta;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorChannelDelta = new FieldHoldingGeneratorChannelDelta("field \"ChannelDelta\" of the HomeAutomationTVChannel class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationTVChannel class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorChannelDelta = new FieldHoldingGeneratorChannelDelta("field \"ChannelDelta\" of the HomeAutomationTVChannel class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationTVChannel class");
          }

        public override void reset()
          {
            fieldGeneratorChannelDelta.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationTVChannelJSON  result)
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
        public HomeAutomationTVChannelJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationTVChannelJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationTVChannelJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationTVChannelJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationTVChannelJSON>();
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
    public List<HomeAutomationTVChannelJSON> value;
  };
    public static HomeAutomationTVChannelJSON from_TVChannelJSON_json(TVChannelJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        HomeAutomationTVChannelJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type HomeAutomationTVChannel", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
