/* file "CalendarUploadEventsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CalendarUploadEventsInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasActionSuccessful;
    private bool storeActionSuccessful;
    private bool flagHasUploadedEvents;
    private List< CalendarEventSpecifierJSON  > storeUploadedEvents;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraActionSuccessfulToJSON()
      {
        JSONValue generated_boolean_ActionSuccessful = (storeActionSuccessful ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_ActionSuccessful;
      }

    private JSONValue  extraUploadedEventsToJSON()
      {
        JSONArrayValue generated_array_1_UploadedEvents = new JSONArrayValue();
        for (int num1 = 0; num1 < storeUploadedEvents.Count; ++num1)
          {
            JSONValueHandler handler_UploadedEvents = new JSONValueHandler();
            storeUploadedEvents[num1].write_as_json(handler_UploadedEvents);
            generated_array_1_UploadedEvents.appendComponent(handler_UploadedEvents.result);
          }
        return generated_array_1_UploadedEvents;
      }


    private void  fromJSONActionSuccessful(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field ActionSuccessful of CalendarUploadEventsInformationNuggetJSON is not true for false.");
              }
          }
        setActionSuccessful(the_bool);
      }


    private void  fromJSONUploadedEvents(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field UploadedEvents of CalendarUploadEventsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< CalendarEventSpecifierJSON  > vector_UploadedEvents1 = new List< CalendarEventSpecifierJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CalendarEventSpecifierJSON convert_classy = CalendarEventSpecifierJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_UploadedEvents1.Add(convert_classy);
          }
        initUploadedEvents();
        for (int num1 = 0; num1 < vector_UploadedEvents1.Count; ++num1)
            appendUploadedEvents(vector_UploadedEvents1[num1]);
        for (int num1 = 0; num1 < vector_UploadedEvents1.Count; ++num1)
          {
          }
      }


    public CalendarUploadEventsInformationNuggetJSON()
      {
        flagHasActionSuccessful = false;
        flagHasUploadedEvents = false;
        storeUploadedEvents = new List< CalendarEventSpecifierJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "CalendarUploadEventsInformationNugget";
      }

    public bool  hasActionSuccessful()
      {
        return flagHasActionSuccessful;
      }

    public bool  getActionSuccessful()
      {
        Debug.Assert(flagHasActionSuccessful);
        return storeActionSuccessful;
      }

    public bool  hasUploadedEvents()
      {
        return flagHasUploadedEvents;
      }

    public int  countOfUploadedEvents()
      {
        Debug.Assert(flagHasUploadedEvents);
        return storeUploadedEvents.Count;
      }

    public CalendarEventSpecifierJSON   elementOfUploadedEvents(int element_num)
      {
        Debug.Assert(flagHasUploadedEvents);
        return storeUploadedEvents[element_num];
      }

    public List< CalendarEventSpecifierJSON  >  getUploadedEvents()
      {
        Debug.Assert(flagHasUploadedEvents);
        return storeUploadedEvents;
      }


    public virtual int extraCalendarUploadEventsInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCalendarUploadEventsInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCalendarUploadEventsInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCalendarUploadEventsInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasActionSuccessful)
            ++result;
        if (flagHasUploadedEvents)
            ++result;
        result += extraCalendarUploadEventsInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasActionSuccessful)
          {
            if (remainder == 0)
                return "ActionSuccessful";
            --remainder;
          }
        if (flagHasUploadedEvents)
          {
            if (remainder == 0)
                return "UploadedEvents";
            --remainder;
          }
        return extraCalendarUploadEventsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasActionSuccessful)
          {
            if (remainder == 0)
                return extraActionSuccessfulToJSON();
            --remainder;
          }
        if (flagHasUploadedEvents)
          {
            if (remainder == 0)
                return extraUploadedEventsToJSON();
            --remainder;
          }
        return extraCalendarUploadEventsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "ctionSuccessful", 0, 15, false) == 0) && (field_name.Length == 16))
                    return (flagHasActionSuccessful ? extraActionSuccessfulToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "ploadedEvents", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasUploadedEvents ? extraUploadedEventsToJSON() : null);
                break;
            default:
                break;
          }
        return extraCalendarUploadEventsInformationNuggetLookup(field_name);
      }

    public void setActionSuccessful(bool new_value)
      {
        flagHasActionSuccessful = true;
        storeActionSuccessful = new_value;
      }
    public void unsetActionSuccessful()
      {
        flagHasActionSuccessful = false;
      }
    public void initUploadedEvents()
      {
        if (flagHasUploadedEvents)
          {
            for (int num1 = 0; num1 < storeUploadedEvents.Count; ++num1)
              {
              }
          }
        flagHasUploadedEvents = true;
        storeUploadedEvents.Clear();
      }
    public void appendUploadedEvents(CalendarEventSpecifierJSON  to_append)
      {
        if (!flagHasUploadedEvents)
          {
            flagHasUploadedEvents = true;
            storeUploadedEvents.Clear();
          }
        Debug.Assert(flagHasUploadedEvents);
        storeUploadedEvents.Add(to_append);
      }
    public void unsetUploadedEvents()
      {
        if (flagHasUploadedEvents)
          {
            for (int num2 = 0; num2 < storeUploadedEvents.Count; ++num2)
              {
              }
          }
        flagHasUploadedEvents = false;
        storeUploadedEvents.Clear();
      }

    public virtual void extraCalendarUploadEventsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCalendarUploadEventsInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCalendarUploadEventsInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraCalendarUploadEventsInformationNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ctionSuccessful", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONActionSuccessful(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "ploadedEvents", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONUploadedEvents(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCalendarUploadEventsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ctionSuccessful", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONActionSuccessful(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "ploadedEvents", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONUploadedEvents(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCalendarUploadEventsInformationNuggetSetField(key, new_component);
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
        if (flagHasActionSuccessful)
          {
            handler.start_pair("ActionSuccessful");
            handler.boolean_value(storeActionSuccessful);
          }
        if (flagHasUploadedEvents)
          {
            handler.start_pair("UploadedEvents");
            handler.start_array();
            for (int num1 = 0; num1 < storeUploadedEvents.Count; ++num1)
              {
                if (partial_allowed)
                    storeUploadedEvents[num1].write_partial_as_json(handler);
                else
                    storeUploadedEvents[num1].write_as_json(handler);
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

    public static new CalendarUploadEventsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarUploadEventsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarUploadEventsInformationNugget", ignore_extras);
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
    public static new CalendarUploadEventsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CalendarUploadEventsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarUploadEventsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarUploadEventsInformationNugget", ignore_extras);
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
    public static new CalendarUploadEventsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CalendarUploadEventsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        CalendarUploadEventsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarUploadEventsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CalendarUploadEventsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CalendarUploadEventsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CalendarUploadEventsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarUploadEventsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorActionSuccessful;
        private CalendarEventSpecifierJSON.HoldingArrayGenerator fieldGeneratorUploadedEvents;
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
            if (!(getInformationNuggetJSONKey().Equals("CalendarUploadEventsInformationNugget")))
                throw new Exception("The key field has a value other than `CalendarUploadEventsInformationNugget'.");
            CalendarUploadEventsInformationNuggetJSON result = new CalendarUploadEventsInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCalendarUploadEventsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((CalendarUploadEventsInformationNuggetJSON )new_result);
          }
        protected void finish(CalendarUploadEventsInformationNuggetJSON result)
          {
            if (fieldGeneratorActionSuccessful.have_value)
              {
                result.setActionSuccessful(fieldGeneratorActionSuccessful.value);
                fieldGeneratorActionSuccessful.have_value = false;
              }
            if (fieldGeneratorUploadedEvents.have_value)
              {
                result.initUploadedEvents();
                int count = fieldGeneratorUploadedEvents.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendUploadedEvents(fieldGeneratorUploadedEvents.value[num]);
                  }
                fieldGeneratorUploadedEvents.value.Clear();
                fieldGeneratorUploadedEvents.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(CalendarUploadEventsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ctionSuccessful", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorActionSuccessful;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "ploadedEvents", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorUploadedEvents;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorActionSuccessful = new JSONHoldingBooleanGenerator("field \"ActionSuccessful\" of the CalendarUploadEventsInformationNugget class");
            fieldGeneratorUploadedEvents = new CalendarEventSpecifierJSON.HoldingArrayGenerator("field \"UploadedEvents\" of the CalendarUploadEventsInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CalendarUploadEventsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorActionSuccessful = new JSONHoldingBooleanGenerator("field \"ActionSuccessful\" of the CalendarUploadEventsInformationNugget class");
            fieldGeneratorUploadedEvents = new CalendarEventSpecifierJSON.HoldingArrayGenerator("field \"UploadedEvents\" of the CalendarUploadEventsInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CalendarUploadEventsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorActionSuccessful.reset();
            fieldGeneratorUploadedEvents.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CalendarUploadEventsInformationNuggetJSON  result)
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
        public CalendarUploadEventsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CalendarUploadEventsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<CalendarUploadEventsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CalendarUploadEventsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CalendarUploadEventsInformationNuggetJSON>();
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
    public List<CalendarUploadEventsInformationNuggetJSON> value;
  };
  };
