/* file "ScheduledEventSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ScheduledEventSpecJSON : JSONBase
  {
    private bool flagHasStartDateAndTime;
    private DateAndOrTimeJSON  storeStartDateAndTime;
    private bool flagHasEndDateAndTime;
    private DateAndOrTimeJSON  storeEndDateAndTime;
    private bool flagHasTimeZone;
    private string storeTimeZone;
    private bool flagHasScheduledEventName;
    private string storeScheduledEventName;
    private bool flagHasScheduledEventNameSpoken;
    private string storeScheduledEventNameSpoken;
    private bool flagHasIsMultiDay;
    private bool storeIsMultiDay;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStartDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStartDateAndTime(convert_classy);
      }


    private void  fromJSONEndDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setEndDateAndTime(convert_classy);
      }


    private void  fromJSONTimeZone(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TimeZone of ScheduledEventSpecJSON is not a string.");
        setTimeZone(json_string.getData());
      }


    private void  fromJSONScheduledEventName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ScheduledEventName of ScheduledEventSpecJSON is not a string.");
        setScheduledEventName(json_string.getData());
      }


    private void  fromJSONScheduledEventNameSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ScheduledEventNameSpoken of ScheduledEventSpecJSON is not a string.");
        setScheduledEventNameSpoken(json_string.getData());
      }


    private void  fromJSONIsMultiDay(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsMultiDay of ScheduledEventSpecJSON is not true for false.");
              }
          }
        setIsMultiDay(the_bool);
      }


    public ScheduledEventSpecJSON()
      {
        flagHasStartDateAndTime = false;
        flagHasEndDateAndTime = false;
        flagHasTimeZone = false;
        flagHasScheduledEventName = false;
        flagHasScheduledEventNameSpoken = false;
        flagHasIsMultiDay = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStartDateAndTime()
      {
        return flagHasStartDateAndTime;
      }

    public DateAndOrTimeJSON   getStartDateAndTime()
      {
        Debug.Assert(flagHasStartDateAndTime);
        return storeStartDateAndTime;
      }

    public bool  hasEndDateAndTime()
      {
        return flagHasEndDateAndTime;
      }

    public DateAndOrTimeJSON   getEndDateAndTime()
      {
        Debug.Assert(flagHasEndDateAndTime);
        return storeEndDateAndTime;
      }

    public bool  hasTimeZone()
      {
        return flagHasTimeZone;
      }

    public string  getTimeZone()
      {
        Debug.Assert(flagHasTimeZone);
        return storeTimeZone;
      }

    public bool  hasScheduledEventName()
      {
        return flagHasScheduledEventName;
      }

    public string  getScheduledEventName()
      {
        Debug.Assert(flagHasScheduledEventName);
        return storeScheduledEventName;
      }

    public bool  hasScheduledEventNameSpoken()
      {
        return flagHasScheduledEventNameSpoken;
      }

    public string  getScheduledEventNameSpoken()
      {
        Debug.Assert(flagHasScheduledEventNameSpoken);
        return storeScheduledEventNameSpoken;
      }

    public bool  hasIsMultiDay()
      {
        return flagHasIsMultiDay;
      }

    public bool  getIsMultiDay()
      {
        Debug.Assert(flagHasIsMultiDay);
        return storeIsMultiDay;
      }


    public virtual int extraScheduledEventSpecComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraScheduledEventSpecComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraScheduledEventSpecComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraScheduledEventSpecLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setStartDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStartDateAndTime)
          {
          }
        flagHasStartDateAndTime = true;
        storeStartDateAndTime = new_value;
      }
    public void unsetStartDateAndTime()
      {
        if (flagHasStartDateAndTime)
          {
          }
        flagHasStartDateAndTime = false;
      }
    public void setEndDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasEndDateAndTime)
          {
          }
        flagHasEndDateAndTime = true;
        storeEndDateAndTime = new_value;
      }
    public void unsetEndDateAndTime()
      {
        if (flagHasEndDateAndTime)
          {
          }
        flagHasEndDateAndTime = false;
      }
    public void setTimeZone(string new_value)
      {
        flagHasTimeZone = true;
        storeTimeZone = new_value;
      }
    public void unsetTimeZone()
      {
        flagHasTimeZone = false;
      }
    public void setScheduledEventName(string new_value)
      {
        flagHasScheduledEventName = true;
        storeScheduledEventName = new_value;
      }
    public void unsetScheduledEventName()
      {
        flagHasScheduledEventName = false;
      }
    public void setScheduledEventNameSpoken(string new_value)
      {
        flagHasScheduledEventNameSpoken = true;
        storeScheduledEventNameSpoken = new_value;
      }
    public void unsetScheduledEventNameSpoken()
      {
        flagHasScheduledEventNameSpoken = false;
      }
    public void setIsMultiDay(bool new_value)
      {
        flagHasIsMultiDay = true;
        storeIsMultiDay = new_value;
      }
    public void unsetIsMultiDay()
      {
        flagHasIsMultiDay = false;
      }

    public virtual void extraScheduledEventSpecAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraScheduledEventSpecSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraScheduledEventSpecLookup(key);
        if (old_field == null)
          {
            extraScheduledEventSpecAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStartDateAndTime);
        if (flagHasStartDateAndTime)
          {
            handler.start_pair("StartDateAndTime");
            if (partial_allowed)
                storeStartDateAndTime.write_partial_as_json(handler);
            else
                storeStartDateAndTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasEndDateAndTime);
        if (flagHasEndDateAndTime)
          {
            handler.start_pair("EndDateAndTime");
            if (partial_allowed)
                storeEndDateAndTime.write_partial_as_json(handler);
            else
                storeEndDateAndTime.write_as_json(handler);
          }
        if (flagHasTimeZone)
          {
            handler.start_pair("TimeZone");
            handler.string_value(storeTimeZone);
          }
        Debug.Assert(partial_allowed || flagHasScheduledEventName);
        if (flagHasScheduledEventName)
          {
            handler.start_pair("ScheduledEventName");
            handler.string_value(storeScheduledEventName);
          }
        Debug.Assert(partial_allowed || flagHasScheduledEventNameSpoken);
        if (flagHasScheduledEventNameSpoken)
          {
            handler.start_pair("ScheduledEventNameSpoken");
            handler.string_value(storeScheduledEventNameSpoken);
          }
        Debug.Assert(partial_allowed || flagHasIsMultiDay);
        if (flagHasIsMultiDay)
          {
            handler.start_pair("IsMultiDay");
            handler.boolean_value(storeIsMultiDay);
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
        if (!(hasStartDateAndTime()))
          {
            return "When parsing the object for %what%, the \"StartDateAndTime\" field was missing.";
          }
        if (!(hasEndDateAndTime()))
          {
            return "When parsing the object for %what%, the \"EndDateAndTime\" field was missing.";
          }
        if (!(hasScheduledEventName()))
          {
            return "When parsing the object for %what%, the \"ScheduledEventName\" field was missing.";
          }
        if (!(hasScheduledEventNameSpoken()))
          {
            return "When parsing the object for %what%, the \"ScheduledEventNameSpoken\" field was missing.";
          }
        if (!(hasIsMultiDay()))
          {
            return "When parsing the object for %what%, the \"IsMultiDay\" field was missing.";
          }
        return null;
      }

    public static ScheduledEventSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ScheduledEventSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ScheduledEventSpec", ignore_extras);
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
    public static ScheduledEventSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ScheduledEventSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ScheduledEventSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ScheduledEventSpec", ignore_extras);
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
    public static ScheduledEventSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ScheduledEventSpecJSON from_text(string text, bool ignore_extras)
      {
        ScheduledEventSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ScheduledEventSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ScheduledEventSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ScheduledEventSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ScheduledEventSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ScheduledEventSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartDateAndTime;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndDateAndTime;
        private JSONHoldingStringGenerator fieldGeneratorTimeZone;
        private JSONHoldingStringGenerator fieldGeneratorScheduledEventName;
        private JSONHoldingStringGenerator fieldGeneratorScheduledEventNameSpoken;
        private JSONHoldingBooleanGenerator fieldGeneratorIsMultiDay;
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
            ScheduledEventSpecJSON result = new ScheduledEventSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraScheduledEventSpecAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ScheduledEventSpecJSON result)
          {
            if (fieldGeneratorStartDateAndTime.have_value)
              {
                result.setStartDateAndTime(fieldGeneratorStartDateAndTime.value);
                fieldGeneratorStartDateAndTime.have_value = false;
              }
            else if ((!(result.hasStartDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartDateAndTime\" field was missing.");
              }
            if (fieldGeneratorEndDateAndTime.have_value)
              {
                result.setEndDateAndTime(fieldGeneratorEndDateAndTime.value);
                fieldGeneratorEndDateAndTime.have_value = false;
              }
            else if ((!(result.hasEndDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndDateAndTime\" field was missing.");
              }
            if (fieldGeneratorTimeZone.have_value)
              {
                result.setTimeZone(fieldGeneratorTimeZone.value);
                fieldGeneratorTimeZone.have_value = false;
              }
            if (fieldGeneratorScheduledEventName.have_value)
              {
                result.setScheduledEventName(fieldGeneratorScheduledEventName.value);
                fieldGeneratorScheduledEventName.have_value = false;
              }
            else if ((!(result.hasScheduledEventName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ScheduledEventName\" field was missing.");
              }
            if (fieldGeneratorScheduledEventNameSpoken.have_value)
              {
                result.setScheduledEventNameSpoken(fieldGeneratorScheduledEventNameSpoken.value);
                fieldGeneratorScheduledEventNameSpoken.have_value = false;
              }
            else if ((!(result.hasScheduledEventNameSpoken())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ScheduledEventNameSpoken\" field was missing.");
              }
            if (fieldGeneratorIsMultiDay.have_value)
              {
                result.setIsMultiDay(fieldGeneratorIsMultiDay.value);
                fieldGeneratorIsMultiDay.have_value = false;
              }
            else if ((!(result.hasIsMultiDay())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsMultiDay\" field was missing.");
              }
          }
        protected abstract void handle_result(ScheduledEventSpecJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "ndDateAndTime", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorEndDateAndTime;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sMultiDay", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorIsMultiDay;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'c':
                            if (String.Compare(field_name, 2, "heduledEventName", 0, 16, false) == 0)
                              {
                                if (field_name.Length == 18)
                                  {
                                    return fieldGeneratorScheduledEventName;
                                  }
                                switch (field_name[18])
                                  {
                                    case 'S':
                                        if ((String.Compare(field_name, 19, "poken", 0, 5, false) == 0) && (field_name.Length == 24))
                                            return fieldGeneratorScheduledEventNameSpoken;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "artDateAndTime", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorStartDateAndTime;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "imeZone", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorTimeZone;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorStartDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndTime\" of the ScheduledEventSpec class", ignore_extras);
            fieldGeneratorEndDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndTime\" of the ScheduledEventSpec class", ignore_extras);
            fieldGeneratorTimeZone = new JSONHoldingStringGenerator("field \"TimeZone\" of the ScheduledEventSpec class");
            fieldGeneratorScheduledEventName = new JSONHoldingStringGenerator("field \"ScheduledEventName\" of the ScheduledEventSpec class");
            fieldGeneratorScheduledEventNameSpoken = new JSONHoldingStringGenerator("field \"ScheduledEventNameSpoken\" of the ScheduledEventSpec class");
            fieldGeneratorIsMultiDay = new JSONHoldingBooleanGenerator("field \"IsMultiDay\" of the ScheduledEventSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ScheduledEventSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStartDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndTime\" of the ScheduledEventSpec class", false);
            fieldGeneratorEndDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndTime\" of the ScheduledEventSpec class", false);
            fieldGeneratorTimeZone = new JSONHoldingStringGenerator("field \"TimeZone\" of the ScheduledEventSpec class");
            fieldGeneratorScheduledEventName = new JSONHoldingStringGenerator("field \"ScheduledEventName\" of the ScheduledEventSpec class");
            fieldGeneratorScheduledEventNameSpoken = new JSONHoldingStringGenerator("field \"ScheduledEventNameSpoken\" of the ScheduledEventSpec class");
            fieldGeneratorIsMultiDay = new JSONHoldingBooleanGenerator("field \"IsMultiDay\" of the ScheduledEventSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ScheduledEventSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStartDateAndTime.reset();
            fieldGeneratorEndDateAndTime.reset();
            fieldGeneratorTimeZone.reset();
            fieldGeneratorScheduledEventName.reset();
            fieldGeneratorScheduledEventNameSpoken.reset();
            fieldGeneratorIsMultiDay.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorStartDateAndTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEndDateAndTime.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorStartDateAndTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEndDateAndTime.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ScheduledEventSpecJSON  result)
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
        public ScheduledEventSpecJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ScheduledEventSpecJSON  result)
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
    protected virtual void handle_result(List<ScheduledEventSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ScheduledEventSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ScheduledEventSpecJSON>();
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
    public List<ScheduledEventSpecJSON> value;
  };
  };
