/* file "ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON : ThirdPartyCalendarInformationNuggetJSON
  {
    private bool flagHasEvents;
    private List< ThirdPartyCalendarEventJSON  > storeEvents;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraEventsToJSON()
      {
        JSONArrayValue generated_array_1_Events = new JSONArrayValue();
        for (int num1 = 0; num1 < storeEvents.Count; ++num1)
          {
            JSONValueHandler handler_Events = new JSONValueHandler();
            storeEvents[num1].write_as_json(handler_Events);
            generated_array_1_Events.appendComponent(handler_Events.result);
          }
        return generated_array_1_Events;
      }


    private void  fromJSONEvents(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Events of ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< ThirdPartyCalendarEventJSON  > vector_Events1 = new List< ThirdPartyCalendarEventJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            ThirdPartyCalendarEventJSON convert_classy = ThirdPartyCalendarEventJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Events1.Add(convert_classy);
          }
        initEvents();
        for (int num1 = 0; num1 < vector_Events1.Count; ++num1)
            appendEvents(vector_Events1[num1]);
        for (int num1 = 0; num1 < vector_Events1.Count; ++num1)
          {
          }
      }


    public ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON()
      {
        flagHasEvents = false;
        storeEvents = new List< ThirdPartyCalendarEventJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getThirdPartyCalendarInformationNuggetType()
      {
        return "ThirdPartyCalendarCancelCancelEventsInformationNugget";
      }

    public bool  hasEvents()
      {
        return flagHasEvents;
      }

    public int  countOfEvents()
      {
        Debug.Assert(flagHasEvents);
        return storeEvents.Count;
      }

    public ThirdPartyCalendarEventJSON   elementOfEvents(int element_num)
      {
        Debug.Assert(flagHasEvents);
        return storeEvents[element_num];
      }

    public List< ThirdPartyCalendarEventJSON  >  getEvents()
      {
        Debug.Assert(flagHasEvents);
        return storeEvents;
      }


    public virtual int extraThirdPartyCalendarCancelCancelEventsInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraThirdPartyCalendarCancelCancelEventsInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarCancelCancelEventsInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarCancelCancelEventsInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraThirdPartyCalendarInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasEvents)
            ++result;
        result += extraThirdPartyCalendarCancelCancelEventsInformationNuggetComponentCount();
        return result;
      }
    public override string extraThirdPartyCalendarInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasEvents)
          {
            if (remainder == 0)
                return "Events";
            --remainder;
          }
        return extraThirdPartyCalendarCancelCancelEventsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraThirdPartyCalendarInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasEvents)
          {
            if (remainder == 0)
                return extraEventsToJSON();
            --remainder;
          }
        return extraThirdPartyCalendarCancelCancelEventsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraThirdPartyCalendarInformationNuggetLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Events", 0, 6, false) == 0) && (field_name.Length == 6))
            return (flagHasEvents ? extraEventsToJSON() : null);
        return extraThirdPartyCalendarCancelCancelEventsInformationNuggetLookup(field_name);
      }

    public void initEvents()
      {
        if (flagHasEvents)
          {
            for (int num1 = 0; num1 < storeEvents.Count; ++num1)
              {
              }
          }
        flagHasEvents = true;
        storeEvents.Clear();
      }
    public void appendEvents(ThirdPartyCalendarEventJSON  to_append)
      {
        if (!flagHasEvents)
          {
            flagHasEvents = true;
            storeEvents.Clear();
          }
        Debug.Assert(flagHasEvents);
        storeEvents.Add(to_append);
      }
    public void unsetEvents()
      {
        if (flagHasEvents)
          {
            for (int num2 = 0; num2 < storeEvents.Count; ++num2)
              {
              }
          }
        flagHasEvents = false;
        storeEvents.Clear();
      }

    public virtual void extraThirdPartyCalendarCancelCancelEventsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraThirdPartyCalendarCancelCancelEventsInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraThirdPartyCalendarCancelCancelEventsInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraThirdPartyCalendarCancelCancelEventsInformationNuggetAppendPair(key, new_component);
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
    public override void extraThirdPartyCalendarInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Events", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONEvents(new_component, false);
            return;
            }
        extraThirdPartyCalendarCancelCancelEventsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraThirdPartyCalendarInformationNuggetSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Events", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONEvents(new_component, false);
            return;
            }
        extraThirdPartyCalendarCancelCancelEventsInformationNuggetSetField(key, new_component);
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
        if (flagHasEvents)
          {
            handler.start_pair("Events");
            handler.start_array();
            for (int num1 = 0; num1 < storeEvents.Count; ++num1)
              {
                if (partial_allowed)
                    storeEvents[num1].write_partial_as_json(handler);
                else
                    storeEvents[num1].write_as_json(handler);
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

    public static new ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarCancelCancelEventsInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarCancelCancelEventsInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarCancelCancelEventsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarCancelCancelEventsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ThirdPartyCalendarInformationNuggetJSON.Generator
      {
        private ThirdPartyCalendarEventJSON.HoldingArrayGenerator fieldGeneratorEvents;
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
            if (!(getThirdPartyCalendarInformationNuggetJSONKey().Equals("ThirdPartyCalendarCancelCancelEventsInformationNugget")))
                throw new Exception("The key field has a value other than `ThirdPartyCalendarCancelCancelEventsInformationNugget'.");
            ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON result = new ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraThirdPartyCalendarCancelCancelEventsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ThirdPartyCalendarInformationNuggetJSON new_result)
          {
            handle_result((ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON )new_result);
          }
        protected void finish(ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON result)
          {
            if (fieldGeneratorEvents.have_value)
              {
                result.initEvents();
                int count = fieldGeneratorEvents.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendEvents(fieldGeneratorEvents.value[num]);
                  }
                fieldGeneratorEvents.value.Clear();
                fieldGeneratorEvents.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Events", 0, 6, false) == 0) && (field_name.Length == 6))
                return fieldGeneratorEvents;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorEvents = new ThirdPartyCalendarEventJSON.HoldingArrayGenerator("field \"Events\" of the ThirdPartyCalendarCancelCancelEventsInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ThirdPartyCalendarCancelCancelEventsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorEvents = new ThirdPartyCalendarEventJSON.HoldingArrayGenerator("field \"Events\" of the ThirdPartyCalendarCancelCancelEventsInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ThirdPartyCalendarCancelCancelEventsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorEvents.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON  result)
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
        public ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON>();
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
    public List<ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON> value;
  };
  };
