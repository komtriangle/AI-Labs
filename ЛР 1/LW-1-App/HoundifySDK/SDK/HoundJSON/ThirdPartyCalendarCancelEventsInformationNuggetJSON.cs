/* file "ThirdPartyCalendarCancelEventsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ThirdPartyCalendarCancelEventsInformationNuggetJSON : ThirdPartyCalendarInformationNuggetJSON
  {
    private bool flagHasUserHasToConfirm;
    private bool storeUserHasToConfirm;
    private bool flagHasEvents;
    private List< ThirdPartyCalendarEventJSON  > storeEvents;
    private bool flagHasQuery;
    private CalendarQueryJSON  storeQuery;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraUserHasToConfirmToJSON()
      {
        JSONValue generated_boolean_UserHasToConfirm = (storeUserHasToConfirm ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_UserHasToConfirm;
      }

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

    private JSONValue  extraQueryToJSON()
      {
        JSONValueHandler handler_Query = new JSONValueHandler();
        storeQuery.write_as_json(handler_Query);
        return handler_Query.result;
      }


    private void  fromJSONUserHasToConfirm(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserHasToConfirm of ThirdPartyCalendarCancelEventsInformationNuggetJSON is not true for false.");
              }
          }
        setUserHasToConfirm(the_bool);
      }


    private void  fromJSONEvents(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Events of ThirdPartyCalendarCancelEventsInformationNuggetJSON is not an array.");
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


    private void  fromJSONQuery(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CalendarQueryJSON convert_classy = CalendarQueryJSON.from_json(json_value, ignore_extras, true);
        setQuery(convert_classy);
      }


    public ThirdPartyCalendarCancelEventsInformationNuggetJSON()
      {
        flagHasUserHasToConfirm = false;
        flagHasEvents = false;
        flagHasQuery = false;
        storeEvents = new List< ThirdPartyCalendarEventJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getThirdPartyCalendarInformationNuggetType()
      {
        return "ThirdPartyCalendarCancelEventsInformationNugget";
      }

    public bool  hasUserHasToConfirm()
      {
        return flagHasUserHasToConfirm;
      }

    public bool  getUserHasToConfirm()
      {
        Debug.Assert(flagHasUserHasToConfirm);
        return storeUserHasToConfirm;
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

    public bool  hasQuery()
      {
        return flagHasQuery;
      }

    public CalendarQueryJSON   getQuery()
      {
        Debug.Assert(flagHasQuery);
        return storeQuery;
      }


    public virtual int extraThirdPartyCalendarCancelEventsInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraThirdPartyCalendarCancelEventsInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarCancelEventsInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarCancelEventsInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraThirdPartyCalendarInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasUserHasToConfirm)
            ++result;
        if (flagHasEvents)
            ++result;
        if (flagHasQuery)
            ++result;
        result += extraThirdPartyCalendarCancelEventsInformationNuggetComponentCount();
        return result;
      }
    public override string extraThirdPartyCalendarInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasUserHasToConfirm)
          {
            if (remainder == 0)
                return "UserHasToConfirm";
            --remainder;
          }
        if (flagHasEvents)
          {
            if (remainder == 0)
                return "Events";
            --remainder;
          }
        if (flagHasQuery)
          {
            if (remainder == 0)
                return "Query";
            --remainder;
          }
        return extraThirdPartyCalendarCancelEventsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraThirdPartyCalendarInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasUserHasToConfirm)
          {
            if (remainder == 0)
                return extraUserHasToConfirmToJSON();
            --remainder;
          }
        if (flagHasEvents)
          {
            if (remainder == 0)
                return extraEventsToJSON();
            --remainder;
          }
        if (flagHasQuery)
          {
            if (remainder == 0)
                return extraQueryToJSON();
            --remainder;
          }
        return extraThirdPartyCalendarCancelEventsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraThirdPartyCalendarInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "vents", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasEvents ? extraEventsToJSON() : null);
                break;
            case 'Q':
                if ((String.Compare(field_name, 1, "uery", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasQuery ? extraQueryToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "serHasToConfirm", 0, 15, false) == 0) && (field_name.Length == 16))
                    return (flagHasUserHasToConfirm ? extraUserHasToConfirmToJSON() : null);
                break;
            default:
                break;
          }
        return extraThirdPartyCalendarCancelEventsInformationNuggetLookup(field_name);
      }

    public void setUserHasToConfirm(bool new_value)
      {
        flagHasUserHasToConfirm = true;
        storeUserHasToConfirm = new_value;
      }
    public void unsetUserHasToConfirm()
      {
        flagHasUserHasToConfirm = false;
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
    public void setQuery(CalendarQueryJSON  new_value)
      {
        if (flagHasQuery)
          {
          }
        flagHasQuery = true;
        storeQuery = new_value;
      }
    public void unsetQuery()
      {
        if (flagHasQuery)
          {
          }
        flagHasQuery = false;
      }

    public virtual void extraThirdPartyCalendarCancelEventsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraThirdPartyCalendarCancelEventsInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraThirdPartyCalendarCancelEventsInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraThirdPartyCalendarCancelEventsInformationNuggetAppendPair(key, new_component);
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
                if ((String.Compare(key, 1, "vents", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONEvents(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "uery", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONQuery(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serHasToConfirm", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONUserHasToConfirm(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraThirdPartyCalendarCancelEventsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraThirdPartyCalendarInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "vents", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONEvents(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "uery", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONQuery(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serHasToConfirm", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONUserHasToConfirm(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraThirdPartyCalendarCancelEventsInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasUserHasToConfirm);
        if (flagHasUserHasToConfirm)
          {
            handler.start_pair("UserHasToConfirm");
            handler.boolean_value(storeUserHasToConfirm);
          }
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
        if (flagHasQuery)
          {
            handler.start_pair("Query");
            if (partial_allowed)
                storeQuery.write_partial_as_json(handler);
            else
                storeQuery.write_as_json(handler);
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
        if (!(hasUserHasToConfirm()))
          {
            return "When parsing the object for %what%, the \"UserHasToConfirm\" field was missing.";
          }
        return null;
      }

    public static new ThirdPartyCalendarCancelEventsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarCancelEventsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarCancelEventsInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarCancelEventsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarCancelEventsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarCancelEventsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarCancelEventsInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarCancelEventsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarCancelEventsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ThirdPartyCalendarCancelEventsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarCancelEventsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ThirdPartyCalendarCancelEventsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ThirdPartyCalendarCancelEventsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ThirdPartyCalendarCancelEventsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarCancelEventsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ThirdPartyCalendarInformationNuggetJSON.Generator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorUserHasToConfirm;
        private ThirdPartyCalendarEventJSON.HoldingArrayGenerator fieldGeneratorEvents;
        private CalendarQueryJSON.HoldingGenerator fieldGeneratorQuery;
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
            if (!(getThirdPartyCalendarInformationNuggetJSONKey().Equals("ThirdPartyCalendarCancelEventsInformationNugget")))
                throw new Exception("The key field has a value other than `ThirdPartyCalendarCancelEventsInformationNugget'.");
            ThirdPartyCalendarCancelEventsInformationNuggetJSON result = new ThirdPartyCalendarCancelEventsInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraThirdPartyCalendarCancelEventsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ThirdPartyCalendarInformationNuggetJSON new_result)
          {
            handle_result((ThirdPartyCalendarCancelEventsInformationNuggetJSON )new_result);
          }
        protected void finish(ThirdPartyCalendarCancelEventsInformationNuggetJSON result)
          {
            if (fieldGeneratorUserHasToConfirm.have_value)
              {
                result.setUserHasToConfirm(fieldGeneratorUserHasToConfirm.value);
                fieldGeneratorUserHasToConfirm.have_value = false;
              }
            else if ((!(result.hasUserHasToConfirm())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UserHasToConfirm\" field was missing.");
              }
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
            if (fieldGeneratorQuery.have_value)
              {
                result.setQuery(fieldGeneratorQuery.value);
                fieldGeneratorQuery.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ThirdPartyCalendarCancelEventsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "vents", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorEvents;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "uery", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorQuery;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serHasToConfirm", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorUserHasToConfirm;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorUserHasToConfirm = new JSONHoldingBooleanGenerator("field \"UserHasToConfirm\" of the ThirdPartyCalendarCancelEventsInformationNugget class");
            fieldGeneratorEvents = new ThirdPartyCalendarEventJSON.HoldingArrayGenerator("field \"Events\" of the ThirdPartyCalendarCancelEventsInformationNugget class", ignore_extras);
            fieldGeneratorQuery = new CalendarQueryJSON.HoldingGenerator("field \"Query\" of the ThirdPartyCalendarCancelEventsInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ThirdPartyCalendarCancelEventsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorUserHasToConfirm = new JSONHoldingBooleanGenerator("field \"UserHasToConfirm\" of the ThirdPartyCalendarCancelEventsInformationNugget class");
            fieldGeneratorEvents = new ThirdPartyCalendarEventJSON.HoldingArrayGenerator("field \"Events\" of the ThirdPartyCalendarCancelEventsInformationNugget class", false);
            fieldGeneratorQuery = new CalendarQueryJSON.HoldingGenerator("field \"Query\" of the ThirdPartyCalendarCancelEventsInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ThirdPartyCalendarCancelEventsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorUserHasToConfirm.reset();
            fieldGeneratorEvents.reset();
            fieldGeneratorQuery.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ThirdPartyCalendarCancelEventsInformationNuggetJSON  result)
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
        public ThirdPartyCalendarCancelEventsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ThirdPartyCalendarCancelEventsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ThirdPartyCalendarCancelEventsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ThirdPartyCalendarCancelEventsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ThirdPartyCalendarCancelEventsInformationNuggetJSON>();
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
    public List<ThirdPartyCalendarCancelEventsInformationNuggetJSON> value;
  };
  };
