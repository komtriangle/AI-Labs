/* file "HomeAutomationChangeChannelCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationChangeChannelCommandJSON : HomeAutomationControlCommandJSON
  {
    private bool flagHasChannel;
    private HomeAutomationTVChannelJSON  storeChannel;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraChannelToJSON()
      {
        JSONValueHandler handler_Channel = new JSONValueHandler();
        storeChannel.write_as_json(handler_Channel);
        return handler_Channel.result;
      }


    private void  fromJSONChannel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationTVChannelJSON convert_classy = HomeAutomationTVChannelJSON.from_json(json_value, ignore_extras, true);
        setChannel(convert_classy);
      }


    public HomeAutomationChangeChannelCommandJSON()
      {
        flagHasChannel = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getHomeAutomationControlCommandKind()
      {
        return "HomeAutomationChangeChannelCommand";
      }

    public bool  hasChannel()
      {
        return flagHasChannel;
      }

    public HomeAutomationTVChannelJSON   getChannel()
      {
        Debug.Assert(flagHasChannel);
        return storeChannel;
      }


    public virtual int extraHomeAutomationChangeChannelCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationChangeChannelCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationChangeChannelCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationChangeChannelCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraHomeAutomationControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasChannel)
            ++result;
        result += extraHomeAutomationChangeChannelCommandComponentCount();
        return result;
      }
    public override string extraHomeAutomationControlCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasChannel)
          {
            if (remainder == 0)
                return "Channel";
            --remainder;
          }
        return extraHomeAutomationChangeChannelCommandComponentKey(remainder);
      }
    public override JSONValue extraHomeAutomationControlCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasChannel)
          {
            if (remainder == 0)
                return extraChannelToJSON();
            --remainder;
          }
        return extraHomeAutomationChangeChannelCommandComponentValue(remainder);
      }
    public override JSONValue extraHomeAutomationControlCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Channel", 0, 7, false) == 0) && (field_name.Length == 7))
            return (flagHasChannel ? extraChannelToJSON() : null);
        return extraHomeAutomationChangeChannelCommandLookup(field_name);
      }

    public void setChannel(HomeAutomationTVChannelJSON  new_value)
      {
        if (flagHasChannel)
          {
          }
        flagHasChannel = true;
        storeChannel = new_value;
      }
    public void unsetChannel()
      {
        if (flagHasChannel)
          {
          }
        flagHasChannel = false;
      }

    public virtual void extraHomeAutomationChangeChannelCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationChangeChannelCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationChangeChannelCommandLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationChangeChannelCommandAppendPair(key, new_component);
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
    public override void extraHomeAutomationControlCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Channel", 0, 7, false) == 0) && (key.Length == 7))
            {
            fromJSONChannel(new_component, false);
            return;
            }
        extraHomeAutomationChangeChannelCommandAppendPair(key, new_component);
      }
    public override void extraHomeAutomationControlCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Channel", 0, 7, false) == 0) && (key.Length == 7))
            {
            fromJSONChannel(new_component, false);
            return;
            }
        extraHomeAutomationChangeChannelCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasChannel);
        if (flagHasChannel)
          {
            handler.start_pair("Channel");
            if (partial_allowed)
                storeChannel.write_partial_as_json(handler);
            else
                storeChannel.write_as_json(handler);
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
        if (!(hasChannel()))
          {
            return "When parsing the object for %what%, the \"Channel\" field was missing.";
          }
        return null;
      }

    public static new HomeAutomationChangeChannelCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationChangeChannelCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationChangeChannelCommand", ignore_extras);
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
    public static new HomeAutomationChangeChannelCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HomeAutomationChangeChannelCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationChangeChannelCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationChangeChannelCommand", ignore_extras);
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
    public static new HomeAutomationChangeChannelCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HomeAutomationChangeChannelCommandJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationChangeChannelCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationChangeChannelCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationChangeChannelCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new HomeAutomationChangeChannelCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationChangeChannelCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationChangeChannelCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : HomeAutomationControlCommandJSON.Generator
      {
        private HomeAutomationTVChannelJSON.HoldingGenerator fieldGeneratorChannel;
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
            if (!(getHomeAutomationControlCommandJSONKey().Equals("HomeAutomationChangeChannelCommand")))
                throw new Exception("The key field has a value other than `HomeAutomationChangeChannelCommand'.");
            HomeAutomationChangeChannelCommandJSON result = new HomeAutomationChangeChannelCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationChangeChannelCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(HomeAutomationControlCommandJSON new_result)
          {
            handle_result((HomeAutomationChangeChannelCommandJSON )new_result);
          }
        protected void finish(HomeAutomationChangeChannelCommandJSON result)
          {
            if (fieldGeneratorChannel.have_value)
              {
                result.setChannel(fieldGeneratorChannel.value);
                fieldGeneratorChannel.have_value = false;
              }
            else if ((!(result.hasChannel())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Channel\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(HomeAutomationChangeChannelCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Channel", 0, 7, false) == 0) && (field_name.Length == 7))
                return fieldGeneratorChannel;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorChannel = new HomeAutomationTVChannelJSON.HoldingGenerator("field \"Channel\" of the HomeAutomationChangeChannelCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationChangeChannelCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorChannel = new HomeAutomationTVChannelJSON.HoldingGenerator("field \"Channel\" of the HomeAutomationChangeChannelCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationChangeChannelCommand class");
          }

        public override void reset()
          {
            fieldGeneratorChannel.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationChangeChannelCommandJSON  result)
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
        public HomeAutomationChangeChannelCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationChangeChannelCommandJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationChangeChannelCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationChangeChannelCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationChangeChannelCommandJSON>();
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
    public List<HomeAutomationChangeChannelCommandJSON> value;
  };
  };
