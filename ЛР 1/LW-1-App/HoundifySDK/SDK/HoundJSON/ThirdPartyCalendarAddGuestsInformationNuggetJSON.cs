/* file "ThirdPartyCalendarAddGuestsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ThirdPartyCalendarAddGuestsInformationNuggetJSON : ThirdPartyCalendarInformationNuggetJSON
  {
    private bool flagHasEvent;
    private ThirdPartyCalendarEventJSON  storeEvent;
    private bool flagHasNewGuests;
    private List< CalendarAttendeeJSON  > storeNewGuests;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraEventToJSON()
      {
        JSONValueHandler handler_Event = new JSONValueHandler();
        storeEvent.write_as_json(handler_Event);
        return handler_Event.result;
      }

    private JSONValue  extraNewGuestsToJSON()
      {
        JSONArrayValue generated_array_1_NewGuests = new JSONArrayValue();
        for (int num1 = 0; num1 < storeNewGuests.Count; ++num1)
          {
            JSONValueHandler handler_NewGuests = new JSONValueHandler();
            storeNewGuests[num1].write_as_json(handler_NewGuests);
            generated_array_1_NewGuests.appendComponent(handler_NewGuests.result);
          }
        return generated_array_1_NewGuests;
      }


    private void  fromJSONEvent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ThirdPartyCalendarEventJSON convert_classy = ThirdPartyCalendarEventJSON.from_json(json_value, ignore_extras, true);
        setEvent(convert_classy);
      }


    private void  fromJSONNewGuests(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field NewGuests of ThirdPartyCalendarAddGuestsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< CalendarAttendeeJSON  > vector_NewGuests1 = new List< CalendarAttendeeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CalendarAttendeeJSON convert_classy = CalendarAttendeeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_NewGuests1.Add(convert_classy);
          }
        initNewGuests();
        for (int num1 = 0; num1 < vector_NewGuests1.Count; ++num1)
            appendNewGuests(vector_NewGuests1[num1]);
        for (int num1 = 0; num1 < vector_NewGuests1.Count; ++num1)
          {
          }
      }


    public ThirdPartyCalendarAddGuestsInformationNuggetJSON()
      {
        flagHasEvent = false;
        flagHasNewGuests = false;
        storeNewGuests = new List< CalendarAttendeeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getThirdPartyCalendarInformationNuggetType()
      {
        return "ThirdPartyCalendarAddGuestsInformationNugget";
      }

    public bool  hasEvent()
      {
        return flagHasEvent;
      }

    public ThirdPartyCalendarEventJSON   getEvent()
      {
        Debug.Assert(flagHasEvent);
        return storeEvent;
      }

    public bool  hasNewGuests()
      {
        return flagHasNewGuests;
      }

    public int  countOfNewGuests()
      {
        Debug.Assert(flagHasNewGuests);
        return storeNewGuests.Count;
      }

    public CalendarAttendeeJSON   elementOfNewGuests(int element_num)
      {
        Debug.Assert(flagHasNewGuests);
        return storeNewGuests[element_num];
      }

    public List< CalendarAttendeeJSON  >  getNewGuests()
      {
        Debug.Assert(flagHasNewGuests);
        return storeNewGuests;
      }


    public virtual int extraThirdPartyCalendarAddGuestsInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraThirdPartyCalendarAddGuestsInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarAddGuestsInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarAddGuestsInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraThirdPartyCalendarInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasEvent)
            ++result;
        if (flagHasNewGuests)
            ++result;
        result += extraThirdPartyCalendarAddGuestsInformationNuggetComponentCount();
        return result;
      }
    public override string extraThirdPartyCalendarInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasEvent)
          {
            if (remainder == 0)
                return "Event";
            --remainder;
          }
        if (flagHasNewGuests)
          {
            if (remainder == 0)
                return "NewGuests";
            --remainder;
          }
        return extraThirdPartyCalendarAddGuestsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraThirdPartyCalendarInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasEvent)
          {
            if (remainder == 0)
                return extraEventToJSON();
            --remainder;
          }
        if (flagHasNewGuests)
          {
            if (remainder == 0)
                return extraNewGuestsToJSON();
            --remainder;
          }
        return extraThirdPartyCalendarAddGuestsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraThirdPartyCalendarInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "vent", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasEvent ? extraEventToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "ewGuests", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasNewGuests ? extraNewGuestsToJSON() : null);
                break;
            default:
                break;
          }
        return extraThirdPartyCalendarAddGuestsInformationNuggetLookup(field_name);
      }

    public void setEvent(ThirdPartyCalendarEventJSON  new_value)
      {
        if (flagHasEvent)
          {
          }
        flagHasEvent = true;
        storeEvent = new_value;
      }
    public void unsetEvent()
      {
        if (flagHasEvent)
          {
          }
        flagHasEvent = false;
      }
    public void initNewGuests()
      {
        if (flagHasNewGuests)
          {
            for (int num1 = 0; num1 < storeNewGuests.Count; ++num1)
              {
              }
          }
        flagHasNewGuests = true;
        storeNewGuests.Clear();
      }
    public void appendNewGuests(CalendarAttendeeJSON  to_append)
      {
        if (!flagHasNewGuests)
          {
            flagHasNewGuests = true;
            storeNewGuests.Clear();
          }
        Debug.Assert(flagHasNewGuests);
        storeNewGuests.Add(to_append);
      }
    public void unsetNewGuests()
      {
        if (flagHasNewGuests)
          {
            for (int num2 = 0; num2 < storeNewGuests.Count; ++num2)
              {
              }
          }
        flagHasNewGuests = false;
        storeNewGuests.Clear();
      }

    public virtual void extraThirdPartyCalendarAddGuestsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraThirdPartyCalendarAddGuestsInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraThirdPartyCalendarAddGuestsInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraThirdPartyCalendarAddGuestsInformationNuggetAppendPair(key, new_component);
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
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "vent", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONEvent(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ewGuests", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONNewGuests(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraThirdPartyCalendarAddGuestsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraThirdPartyCalendarInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "vent", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONEvent(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ewGuests", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONNewGuests(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraThirdPartyCalendarAddGuestsInformationNuggetSetField(key, new_component);
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
        if (flagHasEvent)
          {
            handler.start_pair("Event");
            if (partial_allowed)
                storeEvent.write_partial_as_json(handler);
            else
                storeEvent.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasNewGuests);
        if (flagHasNewGuests)
          {
            handler.start_pair("NewGuests");
            handler.start_array();
            for (int num1 = 0; num1 < storeNewGuests.Count; ++num1)
              {
                if (partial_allowed)
                    storeNewGuests[num1].write_partial_as_json(handler);
                else
                    storeNewGuests[num1].write_as_json(handler);
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
        if (!(hasNewGuests()))
          {
            return "When parsing the object for %what%, the \"NewGuests\" field was missing.";
          }
        return null;
      }

    public static new ThirdPartyCalendarAddGuestsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarAddGuestsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarAddGuestsInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarAddGuestsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarAddGuestsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarAddGuestsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarAddGuestsInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarAddGuestsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarAddGuestsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ThirdPartyCalendarAddGuestsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarAddGuestsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ThirdPartyCalendarAddGuestsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ThirdPartyCalendarAddGuestsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ThirdPartyCalendarAddGuestsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarAddGuestsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ThirdPartyCalendarInformationNuggetJSON.Generator
      {
        private ThirdPartyCalendarEventJSON.HoldingGenerator fieldGeneratorEvent;
        private CalendarAttendeeJSON.HoldingArrayGenerator fieldGeneratorNewGuests;
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
            if (!(getThirdPartyCalendarInformationNuggetJSONKey().Equals("ThirdPartyCalendarAddGuestsInformationNugget")))
                throw new Exception("The key field has a value other than `ThirdPartyCalendarAddGuestsInformationNugget'.");
            ThirdPartyCalendarAddGuestsInformationNuggetJSON result = new ThirdPartyCalendarAddGuestsInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraThirdPartyCalendarAddGuestsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ThirdPartyCalendarInformationNuggetJSON new_result)
          {
            handle_result((ThirdPartyCalendarAddGuestsInformationNuggetJSON )new_result);
          }
        protected void finish(ThirdPartyCalendarAddGuestsInformationNuggetJSON result)
          {
            if (fieldGeneratorEvent.have_value)
              {
                result.setEvent(fieldGeneratorEvent.value);
                fieldGeneratorEvent.have_value = false;
              }
            if (fieldGeneratorNewGuests.have_value)
              {
                result.initNewGuests();
                int count = fieldGeneratorNewGuests.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNewGuests(fieldGeneratorNewGuests.value[num]);
                  }
                fieldGeneratorNewGuests.value.Clear();
                fieldGeneratorNewGuests.have_value = false;
              }
            else if ((!(result.hasNewGuests())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewGuests\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ThirdPartyCalendarAddGuestsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "vent", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorEvent;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ewGuests", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorNewGuests;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorEvent = new ThirdPartyCalendarEventJSON.HoldingGenerator("field \"Event\" of the ThirdPartyCalendarAddGuestsInformationNugget class", ignore_extras);
            fieldGeneratorNewGuests = new CalendarAttendeeJSON.HoldingArrayGenerator("field \"NewGuests\" of the ThirdPartyCalendarAddGuestsInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ThirdPartyCalendarAddGuestsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorEvent = new ThirdPartyCalendarEventJSON.HoldingGenerator("field \"Event\" of the ThirdPartyCalendarAddGuestsInformationNugget class", false);
            fieldGeneratorNewGuests = new CalendarAttendeeJSON.HoldingArrayGenerator("field \"NewGuests\" of the ThirdPartyCalendarAddGuestsInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ThirdPartyCalendarAddGuestsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorEvent.reset();
            fieldGeneratorNewGuests.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ThirdPartyCalendarAddGuestsInformationNuggetJSON  result)
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
        public ThirdPartyCalendarAddGuestsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ThirdPartyCalendarAddGuestsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ThirdPartyCalendarAddGuestsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ThirdPartyCalendarAddGuestsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ThirdPartyCalendarAddGuestsInformationNuggetJSON>();
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
    public List<ThirdPartyCalendarAddGuestsInformationNuggetJSON> value;
  };
  };
