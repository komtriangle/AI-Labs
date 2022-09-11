/* file "ThirdPartyCalendarAddReminderInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class ThirdPartyCalendarAddReminderInformationNuggetJSON : ThirdPartyCalendarInformationNuggetJSON
  {
    private bool flagHasEvent;
    private ThirdPartyCalendarEventJSON  storeEvent;
    private bool flagHasReminder;
    private CalendarReminderJSON  storeReminder;
    private bool flagHasReminderWasReplaced;
    private bool storeReminderWasReplaced;
    private bool flagHasTooManyReminders;
    private bool storeTooManyReminders;
    private bool flagHasReminderTimeTruncatedTo;
    private BigInteger storeReminderTimeTruncatedTo;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraEventToJSON()
      {
        JSONValueHandler handler_Event = new JSONValueHandler();
        storeEvent.write_as_json(handler_Event);
        return handler_Event.result;
      }

    private JSONValue  extraReminderToJSON()
      {
        JSONValueHandler handler_Reminder = new JSONValueHandler();
        storeReminder.write_as_json(handler_Reminder);
        return handler_Reminder.result;
      }

    private JSONValue  extraReminderWasReplacedToJSON()
      {
        JSONValue generated_boolean_ReminderWasReplaced = (storeReminderWasReplaced ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_ReminderWasReplaced;
      }

    private JSONValue  extraTooManyRemindersToJSON()
      {
        JSONValue generated_boolean_TooManyReminders = (storeTooManyReminders ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_TooManyReminders;
      }

    private JSONValue  extraReminderTimeTruncatedToToJSON()
      {
        JSONIntegerValue generated_integer_ReminderTimeTruncatedTo = new JSONIntegerValue(storeReminderTimeTruncatedTo);
        return generated_integer_ReminderTimeTruncatedTo;
      }


    private void  fromJSONEvent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ThirdPartyCalendarEventJSON convert_classy = ThirdPartyCalendarEventJSON.from_json(json_value, ignore_extras, true);
        setEvent(convert_classy);
      }


    private void  fromJSONReminder(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CalendarReminderJSON convert_classy = CalendarReminderJSON.from_json(json_value, ignore_extras, true);
        setReminder(convert_classy);
      }


    private void  fromJSONReminderWasReplaced(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ReminderWasReplaced of ThirdPartyCalendarAddReminderInformationNuggetJSON is not true for false.");
              }
          }
        setReminderWasReplaced(the_bool);
      }


    private void  fromJSONTooManyReminders(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TooManyReminders of ThirdPartyCalendarAddReminderInformationNuggetJSON is not true for false.");
              }
          }
        setTooManyReminders(the_bool);
      }


    private void  fromJSONReminderTimeTruncatedTo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ReminderTimeTruncatedTo of ThirdPartyCalendarAddReminderInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ReminderTimeTruncatedTo of ThirdPartyCalendarAddReminderInformationNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setReminderTimeTruncatedTo(extracted_integer);
      }


    public ThirdPartyCalendarAddReminderInformationNuggetJSON()
      {
        flagHasEvent = false;
        flagHasReminder = false;
        flagHasReminderWasReplaced = false;
        flagHasTooManyReminders = false;
        flagHasReminderTimeTruncatedTo = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getThirdPartyCalendarInformationNuggetType()
      {
        return "ThirdPartyCalendarAddReminderInformationNugget";
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

    public bool  hasReminder()
      {
        return flagHasReminder;
      }

    public CalendarReminderJSON   getReminder()
      {
        Debug.Assert(flagHasReminder);
        return storeReminder;
      }

    public bool  hasReminderWasReplaced()
      {
        return flagHasReminderWasReplaced;
      }

    public bool  getReminderWasReplaced()
      {
        Debug.Assert(flagHasReminderWasReplaced);
        return storeReminderWasReplaced;
      }

    public bool  hasTooManyReminders()
      {
        return flagHasTooManyReminders;
      }

    public bool  getTooManyReminders()
      {
        Debug.Assert(flagHasTooManyReminders);
        return storeTooManyReminders;
      }

    public bool  hasReminderTimeTruncatedTo()
      {
        return flagHasReminderTimeTruncatedTo;
      }

    public BigInteger  getReminderTimeTruncatedTo()
      {
        Debug.Assert(flagHasReminderTimeTruncatedTo);
        return storeReminderTimeTruncatedTo;
      }


    public virtual int extraThirdPartyCalendarAddReminderInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraThirdPartyCalendarAddReminderInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarAddReminderInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarAddReminderInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraThirdPartyCalendarInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasEvent)
            ++result;
        if (flagHasReminder)
            ++result;
        if (flagHasReminderWasReplaced)
            ++result;
        if (flagHasTooManyReminders)
            ++result;
        if (flagHasReminderTimeTruncatedTo)
            ++result;
        result += extraThirdPartyCalendarAddReminderInformationNuggetComponentCount();
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
        if (flagHasReminder)
          {
            if (remainder == 0)
                return "Reminder";
            --remainder;
          }
        if (flagHasReminderWasReplaced)
          {
            if (remainder == 0)
                return "ReminderWasReplaced";
            --remainder;
          }
        if (flagHasTooManyReminders)
          {
            if (remainder == 0)
                return "TooManyReminders";
            --remainder;
          }
        if (flagHasReminderTimeTruncatedTo)
          {
            if (remainder == 0)
                return "ReminderTimeTruncatedTo";
            --remainder;
          }
        return extraThirdPartyCalendarAddReminderInformationNuggetComponentKey(remainder);
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
        if (flagHasReminder)
          {
            if (remainder == 0)
                return extraReminderToJSON();
            --remainder;
          }
        if (flagHasReminderWasReplaced)
          {
            if (remainder == 0)
                return extraReminderWasReplacedToJSON();
            --remainder;
          }
        if (flagHasTooManyReminders)
          {
            if (remainder == 0)
                return extraTooManyRemindersToJSON();
            --remainder;
          }
        if (flagHasReminderTimeTruncatedTo)
          {
            if (remainder == 0)
                return extraReminderTimeTruncatedToToJSON();
            --remainder;
          }
        return extraThirdPartyCalendarAddReminderInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraThirdPartyCalendarInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "vent", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasEvent ? extraEventToJSON() : null);
                break;
            case 'R':
                if (String.Compare(field_name, 1, "eminder", 0, 7, false) == 0)
                  {
                    if (field_name.Length == 8)
                      {
                        return (flagHasReminder ? extraReminderToJSON() : null);
                      }
                    switch (field_name[8])
                      {
                        case 'T':
                            if ((String.Compare(field_name, 9, "imeTruncatedTo", 0, 14, false) == 0) && (field_name.Length == 23))
                                return (flagHasReminderTimeTruncatedTo ? extraReminderTimeTruncatedToToJSON() : null);
                            break;
                        case 'W':
                            if ((String.Compare(field_name, 9, "asReplaced", 0, 10, false) == 0) && (field_name.Length == 19))
                                return (flagHasReminderWasReplaced ? extraReminderWasReplacedToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "ooManyReminders", 0, 15, false) == 0) && (field_name.Length == 16))
                    return (flagHasTooManyReminders ? extraTooManyRemindersToJSON() : null);
                break;
            default:
                break;
          }
        return extraThirdPartyCalendarAddReminderInformationNuggetLookup(field_name);
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
    public void setReminder(CalendarReminderJSON  new_value)
      {
        if (flagHasReminder)
          {
          }
        flagHasReminder = true;
        storeReminder = new_value;
      }
    public void unsetReminder()
      {
        if (flagHasReminder)
          {
          }
        flagHasReminder = false;
      }
    public void setReminderWasReplaced(bool new_value)
      {
        flagHasReminderWasReplaced = true;
        storeReminderWasReplaced = new_value;
      }
    public void unsetReminderWasReplaced()
      {
        flagHasReminderWasReplaced = false;
      }
    public void setTooManyReminders(bool new_value)
      {
        flagHasTooManyReminders = true;
        storeTooManyReminders = new_value;
      }
    public void unsetTooManyReminders()
      {
        flagHasTooManyReminders = false;
      }
    public void setReminderTimeTruncatedTo(BigInteger new_value)
      {
        flagHasReminderTimeTruncatedTo = true;
        storeReminderTimeTruncatedTo = new_value;
      }
    public void unsetReminderTimeTruncatedTo()
      {
        flagHasReminderTimeTruncatedTo = false;
      }

    public virtual void extraThirdPartyCalendarAddReminderInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraThirdPartyCalendarAddReminderInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraThirdPartyCalendarAddReminderInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraThirdPartyCalendarAddReminderInformationNuggetAppendPair(key, new_component);
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
            case 'R':
                if (String.Compare(key, 1, "eminder", 0, 7, false) == 0)
                  {
                    if (key.Length == 8)
                      {
                        {
                        fromJSONReminder(new_component, false);
                        return;
                        }
                      }
                    switch (key[8])
                      {
                        case 'T':
                            if ((String.Compare(key, 9, "imeTruncatedTo", 0, 14, false) == 0) && (key.Length == 23))
                                {
                                fromJSONReminderTimeTruncatedTo(new_component, false);
                                return;
                                }
                            break;
                        case 'W':
                            if ((String.Compare(key, 9, "asReplaced", 0, 10, false) == 0) && (key.Length == 19))
                                {
                                fromJSONReminderWasReplaced(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'T':
                if ((String.Compare(key, 1, "ooManyReminders", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONTooManyReminders(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraThirdPartyCalendarAddReminderInformationNuggetAppendPair(key, new_component);
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
            case 'R':
                if (String.Compare(key, 1, "eminder", 0, 7, false) == 0)
                  {
                    if (key.Length == 8)
                      {
                        {
                        fromJSONReminder(new_component, false);
                        return;
                        }
                      }
                    switch (key[8])
                      {
                        case 'T':
                            if ((String.Compare(key, 9, "imeTruncatedTo", 0, 14, false) == 0) && (key.Length == 23))
                                {
                                fromJSONReminderTimeTruncatedTo(new_component, false);
                                return;
                                }
                            break;
                        case 'W':
                            if ((String.Compare(key, 9, "asReplaced", 0, 10, false) == 0) && (key.Length == 19))
                                {
                                fromJSONReminderWasReplaced(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'T':
                if ((String.Compare(key, 1, "ooManyReminders", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONTooManyReminders(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraThirdPartyCalendarAddReminderInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasEvent);
        if (flagHasEvent)
          {
            handler.start_pair("Event");
            if (partial_allowed)
                storeEvent.write_partial_as_json(handler);
            else
                storeEvent.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasReminder);
        if (flagHasReminder)
          {
            handler.start_pair("Reminder");
            if (partial_allowed)
                storeReminder.write_partial_as_json(handler);
            else
                storeReminder.write_as_json(handler);
          }
        if (flagHasReminderWasReplaced)
          {
            handler.start_pair("ReminderWasReplaced");
            handler.boolean_value(storeReminderWasReplaced);
          }
        if (flagHasTooManyReminders)
          {
            handler.start_pair("TooManyReminders");
            handler.boolean_value(storeTooManyReminders);
          }
        if (flagHasReminderTimeTruncatedTo)
          {
            handler.start_pair("ReminderTimeTruncatedTo");
            handler.number_value(storeReminderTimeTruncatedTo);
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
        if (!(hasEvent()))
          {
            return "When parsing the object for %what%, the \"Event\" field was missing.";
          }
        if (!(hasReminder()))
          {
            return "When parsing the object for %what%, the \"Reminder\" field was missing.";
          }
        return null;
      }

    public static new ThirdPartyCalendarAddReminderInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarAddReminderInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarAddReminderInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarAddReminderInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarAddReminderInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarAddReminderInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarAddReminderInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarAddReminderInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarAddReminderInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ThirdPartyCalendarAddReminderInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarAddReminderInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ThirdPartyCalendarAddReminderInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ThirdPartyCalendarAddReminderInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ThirdPartyCalendarAddReminderInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarAddReminderInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ThirdPartyCalendarInformationNuggetJSON.Generator
      {
        private ThirdPartyCalendarEventJSON.HoldingGenerator fieldGeneratorEvent;
        private CalendarReminderJSON.HoldingGenerator fieldGeneratorReminder;
        private JSONHoldingBooleanGenerator fieldGeneratorReminderWasReplaced;
        private JSONHoldingBooleanGenerator fieldGeneratorTooManyReminders;
    private class FieldHoldingGeneratorReminderTimeTruncatedTo : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorReminderTimeTruncatedTo(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorReminderTimeTruncatedTo : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorReminderTimeTruncatedTo(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorReminderTimeTruncatedTo fieldGeneratorReminderTimeTruncatedTo;
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
            if (!(getThirdPartyCalendarInformationNuggetJSONKey().Equals("ThirdPartyCalendarAddReminderInformationNugget")))
                throw new Exception("The key field has a value other than `ThirdPartyCalendarAddReminderInformationNugget'.");
            ThirdPartyCalendarAddReminderInformationNuggetJSON result = new ThirdPartyCalendarAddReminderInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraThirdPartyCalendarAddReminderInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ThirdPartyCalendarInformationNuggetJSON new_result)
          {
            handle_result((ThirdPartyCalendarAddReminderInformationNuggetJSON )new_result);
          }
        protected void finish(ThirdPartyCalendarAddReminderInformationNuggetJSON result)
          {
            if (fieldGeneratorEvent.have_value)
              {
                result.setEvent(fieldGeneratorEvent.value);
                fieldGeneratorEvent.have_value = false;
              }
            else if ((!(result.hasEvent())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Event\" field was missing.");
              }
            if (fieldGeneratorReminder.have_value)
              {
                result.setReminder(fieldGeneratorReminder.value);
                fieldGeneratorReminder.have_value = false;
              }
            else if ((!(result.hasReminder())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Reminder\" field was missing.");
              }
            if (fieldGeneratorReminderWasReplaced.have_value)
              {
                result.setReminderWasReplaced(fieldGeneratorReminderWasReplaced.value);
                fieldGeneratorReminderWasReplaced.have_value = false;
              }
            if (fieldGeneratorTooManyReminders.have_value)
              {
                result.setTooManyReminders(fieldGeneratorTooManyReminders.value);
                fieldGeneratorTooManyReminders.have_value = false;
              }
            if (fieldGeneratorReminderTimeTruncatedTo.have_value)
              {
                result.setReminderTimeTruncatedTo(fieldGeneratorReminderTimeTruncatedTo.value);
                fieldGeneratorReminderTimeTruncatedTo.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ThirdPartyCalendarAddReminderInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "vent", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorEvent;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "eminder", 0, 7, false) == 0)
                      {
                        if (field_name.Length == 8)
                          {
                            return fieldGeneratorReminder;
                          }
                        switch (field_name[8])
                          {
                            case 'T':
                                if ((String.Compare(field_name, 9, "imeTruncatedTo", 0, 14, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorReminderTimeTruncatedTo;
                                break;
                            case 'W':
                                if ((String.Compare(field_name, 9, "asReplaced", 0, 10, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorReminderWasReplaced;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ooManyReminders", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorTooManyReminders;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorEvent = new ThirdPartyCalendarEventJSON.HoldingGenerator("field \"Event\" of the ThirdPartyCalendarAddReminderInformationNugget class", ignore_extras);
            fieldGeneratorReminder = new CalendarReminderJSON.HoldingGenerator("field \"Reminder\" of the ThirdPartyCalendarAddReminderInformationNugget class", ignore_extras);
            fieldGeneratorReminderWasReplaced = new JSONHoldingBooleanGenerator("field \"ReminderWasReplaced\" of the ThirdPartyCalendarAddReminderInformationNugget class");
            fieldGeneratorTooManyReminders = new JSONHoldingBooleanGenerator("field \"TooManyReminders\" of the ThirdPartyCalendarAddReminderInformationNugget class");
            fieldGeneratorReminderTimeTruncatedTo = new FieldHoldingGeneratorReminderTimeTruncatedTo("field \"ReminderTimeTruncatedTo\" of the ThirdPartyCalendarAddReminderInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ThirdPartyCalendarAddReminderInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorEvent = new ThirdPartyCalendarEventJSON.HoldingGenerator("field \"Event\" of the ThirdPartyCalendarAddReminderInformationNugget class", false);
            fieldGeneratorReminder = new CalendarReminderJSON.HoldingGenerator("field \"Reminder\" of the ThirdPartyCalendarAddReminderInformationNugget class", false);
            fieldGeneratorReminderWasReplaced = new JSONHoldingBooleanGenerator("field \"ReminderWasReplaced\" of the ThirdPartyCalendarAddReminderInformationNugget class");
            fieldGeneratorTooManyReminders = new JSONHoldingBooleanGenerator("field \"TooManyReminders\" of the ThirdPartyCalendarAddReminderInformationNugget class");
            fieldGeneratorReminderTimeTruncatedTo = new FieldHoldingGeneratorReminderTimeTruncatedTo("field \"ReminderTimeTruncatedTo\" of the ThirdPartyCalendarAddReminderInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ThirdPartyCalendarAddReminderInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorEvent.reset();
            fieldGeneratorReminder.reset();
            fieldGeneratorReminderWasReplaced.reset();
            fieldGeneratorTooManyReminders.reset();
            fieldGeneratorReminderTimeTruncatedTo.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ThirdPartyCalendarAddReminderInformationNuggetJSON  result)
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
        public ThirdPartyCalendarAddReminderInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ThirdPartyCalendarAddReminderInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ThirdPartyCalendarAddReminderInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ThirdPartyCalendarAddReminderInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ThirdPartyCalendarAddReminderInformationNuggetJSON>();
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
    public List<ThirdPartyCalendarAddReminderInformationNuggetJSON> value;
  };
  };
