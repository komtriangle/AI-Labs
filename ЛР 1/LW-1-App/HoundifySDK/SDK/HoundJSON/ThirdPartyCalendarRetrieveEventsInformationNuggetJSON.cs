/* file "ThirdPartyCalendarRetrieveEventsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ThirdPartyCalendarRetrieveEventsInformationNuggetJSON : ThirdPartyCalendarInformationNuggetJSON
  {
    private bool flagHasRetrievedEvents;
    private List< CalendarEventSpecifierJSON  > storeRetrievedEvents;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraRetrievedEventsToJSON()
      {
        JSONArrayValue generated_array_1_RetrievedEvents = new JSONArrayValue();
        for (int num1 = 0; num1 < storeRetrievedEvents.Count; ++num1)
          {
            JSONValueHandler handler_RetrievedEvents = new JSONValueHandler();
            storeRetrievedEvents[num1].write_as_json(handler_RetrievedEvents);
            generated_array_1_RetrievedEvents.appendComponent(handler_RetrievedEvents.result);
          }
        return generated_array_1_RetrievedEvents;
      }


    private void  fromJSONRetrievedEvents(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RetrievedEvents of ThirdPartyCalendarRetrieveEventsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< CalendarEventSpecifierJSON  > vector_RetrievedEvents1 = new List< CalendarEventSpecifierJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CalendarEventSpecifierJSON convert_classy = CalendarEventSpecifierJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RetrievedEvents1.Add(convert_classy);
          }
        initRetrievedEvents();
        for (int num1 = 0; num1 < vector_RetrievedEvents1.Count; ++num1)
            appendRetrievedEvents(vector_RetrievedEvents1[num1]);
        for (int num1 = 0; num1 < vector_RetrievedEvents1.Count; ++num1)
          {
          }
      }


    public ThirdPartyCalendarRetrieveEventsInformationNuggetJSON()
      {
        flagHasRetrievedEvents = false;
        storeRetrievedEvents = new List< CalendarEventSpecifierJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getThirdPartyCalendarInformationNuggetType()
      {
        return "ThirdPartyCalendarRetrieveEventsInformationNugget";
      }

    public bool  hasRetrievedEvents()
      {
        return flagHasRetrievedEvents;
      }

    public int  countOfRetrievedEvents()
      {
        Debug.Assert(flagHasRetrievedEvents);
        return storeRetrievedEvents.Count;
      }

    public CalendarEventSpecifierJSON   elementOfRetrievedEvents(int element_num)
      {
        Debug.Assert(flagHasRetrievedEvents);
        return storeRetrievedEvents[element_num];
      }

    public List< CalendarEventSpecifierJSON  >  getRetrievedEvents()
      {
        Debug.Assert(flagHasRetrievedEvents);
        return storeRetrievedEvents;
      }


    public virtual int extraThirdPartyCalendarRetrieveEventsInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraThirdPartyCalendarRetrieveEventsInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarRetrieveEventsInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarRetrieveEventsInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraThirdPartyCalendarInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasRetrievedEvents)
            ++result;
        result += extraThirdPartyCalendarRetrieveEventsInformationNuggetComponentCount();
        return result;
      }
    public override string extraThirdPartyCalendarInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasRetrievedEvents)
          {
            if (remainder == 0)
                return "RetrievedEvents";
            --remainder;
          }
        return extraThirdPartyCalendarRetrieveEventsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraThirdPartyCalendarInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasRetrievedEvents)
          {
            if (remainder == 0)
                return extraRetrievedEventsToJSON();
            --remainder;
          }
        return extraThirdPartyCalendarRetrieveEventsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraThirdPartyCalendarInformationNuggetLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "RetrievedEvents", 0, 15, false) == 0) && (field_name.Length == 15))
            return (flagHasRetrievedEvents ? extraRetrievedEventsToJSON() : null);
        return extraThirdPartyCalendarRetrieveEventsInformationNuggetLookup(field_name);
      }

    public void initRetrievedEvents()
      {
        if (flagHasRetrievedEvents)
          {
            for (int num1 = 0; num1 < storeRetrievedEvents.Count; ++num1)
              {
              }
          }
        flagHasRetrievedEvents = true;
        storeRetrievedEvents.Clear();
      }
    public void appendRetrievedEvents(CalendarEventSpecifierJSON  to_append)
      {
        if (!flagHasRetrievedEvents)
          {
            flagHasRetrievedEvents = true;
            storeRetrievedEvents.Clear();
          }
        Debug.Assert(flagHasRetrievedEvents);
        storeRetrievedEvents.Add(to_append);
      }
    public void unsetRetrievedEvents()
      {
        if (flagHasRetrievedEvents)
          {
            for (int num2 = 0; num2 < storeRetrievedEvents.Count; ++num2)
              {
              }
          }
        flagHasRetrievedEvents = false;
        storeRetrievedEvents.Clear();
      }

    public virtual void extraThirdPartyCalendarRetrieveEventsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraThirdPartyCalendarRetrieveEventsInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraThirdPartyCalendarRetrieveEventsInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraThirdPartyCalendarRetrieveEventsInformationNuggetAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "RetrievedEvents", 0, 15, false) == 0) && (key.Length == 15))
            {
            fromJSONRetrievedEvents(new_component, false);
            return;
            }
        extraThirdPartyCalendarRetrieveEventsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraThirdPartyCalendarInformationNuggetSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "RetrievedEvents", 0, 15, false) == 0) && (key.Length == 15))
            {
            fromJSONRetrievedEvents(new_component, false);
            return;
            }
        extraThirdPartyCalendarRetrieveEventsInformationNuggetSetField(key, new_component);
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
        if (flagHasRetrievedEvents)
          {
            handler.start_pair("RetrievedEvents");
            handler.start_array();
            for (int num1 = 0; num1 < storeRetrievedEvents.Count; ++num1)
              {
                if (partial_allowed)
                    storeRetrievedEvents[num1].write_partial_as_json(handler);
                else
                    storeRetrievedEvents[num1].write_as_json(handler);
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

    public static new ThirdPartyCalendarRetrieveEventsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarRetrieveEventsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarRetrieveEventsInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarRetrieveEventsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarRetrieveEventsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarRetrieveEventsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarRetrieveEventsInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarRetrieveEventsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarRetrieveEventsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ThirdPartyCalendarRetrieveEventsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarRetrieveEventsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ThirdPartyCalendarRetrieveEventsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ThirdPartyCalendarRetrieveEventsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ThirdPartyCalendarRetrieveEventsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarRetrieveEventsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ThirdPartyCalendarInformationNuggetJSON.Generator
      {
        private CalendarEventSpecifierJSON.HoldingArrayGenerator fieldGeneratorRetrievedEvents;
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
            if (!(getThirdPartyCalendarInformationNuggetJSONKey().Equals("ThirdPartyCalendarRetrieveEventsInformationNugget")))
                throw new Exception("The key field has a value other than `ThirdPartyCalendarRetrieveEventsInformationNugget'.");
            ThirdPartyCalendarRetrieveEventsInformationNuggetJSON result = new ThirdPartyCalendarRetrieveEventsInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraThirdPartyCalendarRetrieveEventsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ThirdPartyCalendarInformationNuggetJSON new_result)
          {
            handle_result((ThirdPartyCalendarRetrieveEventsInformationNuggetJSON )new_result);
          }
        protected void finish(ThirdPartyCalendarRetrieveEventsInformationNuggetJSON result)
          {
            if (fieldGeneratorRetrievedEvents.have_value)
              {
                result.initRetrievedEvents();
                int count = fieldGeneratorRetrievedEvents.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRetrievedEvents(fieldGeneratorRetrievedEvents.value[num]);
                  }
                fieldGeneratorRetrievedEvents.value.Clear();
                fieldGeneratorRetrievedEvents.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ThirdPartyCalendarRetrieveEventsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "RetrievedEvents", 0, 15, false) == 0) && (field_name.Length == 15))
                return fieldGeneratorRetrievedEvents;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorRetrievedEvents = new CalendarEventSpecifierJSON.HoldingArrayGenerator("field \"RetrievedEvents\" of the ThirdPartyCalendarRetrieveEventsInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ThirdPartyCalendarRetrieveEventsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorRetrievedEvents = new CalendarEventSpecifierJSON.HoldingArrayGenerator("field \"RetrievedEvents\" of the ThirdPartyCalendarRetrieveEventsInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ThirdPartyCalendarRetrieveEventsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorRetrievedEvents.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ThirdPartyCalendarRetrieveEventsInformationNuggetJSON  result)
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
        public ThirdPartyCalendarRetrieveEventsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ThirdPartyCalendarRetrieveEventsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ThirdPartyCalendarRetrieveEventsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ThirdPartyCalendarRetrieveEventsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ThirdPartyCalendarRetrieveEventsInformationNuggetJSON>();
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
    public List<ThirdPartyCalendarRetrieveEventsInformationNuggetJSON> value;
  };
  };
