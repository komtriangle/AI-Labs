/* file "CalendarEventSpecifierJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CalendarEventSpecifierJSON : JSONBase
  {
    private bool flagHasID;
    private string storeID;
    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasLocation;
    private string storeLocation;
    private bool flagHasStart;
    private DateAndOrTimeJSON  storeStart;
    private bool flagHasEnd;
    private DateAndOrTimeJSON  storeEnd;
    private bool flagHasAttendees;
    private List< CalendarAttendeeJSON  > storeAttendees;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ID of CalendarEventSpecifierJSON is not a string.");
        setID(json_string.getData());
      }


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of CalendarEventSpecifierJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Location of CalendarEventSpecifierJSON is not a string.");
        setLocation(json_string.getData());
      }


    private void  fromJSONStart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStart(convert_classy);
      }


    private void  fromJSONEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setEnd(convert_classy);
      }


    private void  fromJSONAttendees(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Attendees of CalendarEventSpecifierJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< CalendarAttendeeJSON  > vector_Attendees1 = new List< CalendarAttendeeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CalendarAttendeeJSON convert_classy = CalendarAttendeeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Attendees1.Add(convert_classy);
          }
        initAttendees();
        for (int num1 = 0; num1 < vector_Attendees1.Count; ++num1)
            appendAttendees(vector_Attendees1[num1]);
        for (int num1 = 0; num1 < vector_Attendees1.Count; ++num1)
          {
          }
      }


    public CalendarEventSpecifierJSON()
      {
        flagHasID = false;
        flagHasTitle = false;
        flagHasLocation = false;
        flagHasStart = false;
        flagHasEnd = false;
        flagHasAttendees = false;
        storeAttendees = new List< CalendarAttendeeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasID()
      {
        return flagHasID;
      }

    public string  getID()
      {
        Debug.Assert(flagHasID);
        return storeID;
      }

    public bool  hasTitle()
      {
        return flagHasTitle;
      }

    public string  getTitle()
      {
        Debug.Assert(flagHasTitle);
        return storeTitle;
      }

    public bool  hasLocation()
      {
        return flagHasLocation;
      }

    public string  getLocation()
      {
        Debug.Assert(flagHasLocation);
        return storeLocation;
      }

    public bool  hasStart()
      {
        return flagHasStart;
      }

    public DateAndOrTimeJSON   getStart()
      {
        Debug.Assert(flagHasStart);
        return storeStart;
      }

    public bool  hasEnd()
      {
        return flagHasEnd;
      }

    public DateAndOrTimeJSON   getEnd()
      {
        Debug.Assert(flagHasEnd);
        return storeEnd;
      }

    public bool  hasAttendees()
      {
        return flagHasAttendees;
      }

    public int  countOfAttendees()
      {
        Debug.Assert(flagHasAttendees);
        return storeAttendees.Count;
      }

    public CalendarAttendeeJSON   elementOfAttendees(int element_num)
      {
        Debug.Assert(flagHasAttendees);
        return storeAttendees[element_num];
      }

    public List< CalendarAttendeeJSON  >  getAttendees()
      {
        Debug.Assert(flagHasAttendees);
        return storeAttendees;
      }


    public virtual int extraCalendarEventSpecifierComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCalendarEventSpecifierComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCalendarEventSpecifierComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCalendarEventSpecifierLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setID(string new_value)
      {
        flagHasID = true;
        storeID = new_value;
      }
    public void unsetID()
      {
        flagHasID = false;
      }
    public void setTitle(string new_value)
      {
        flagHasTitle = true;
        storeTitle = new_value;
      }
    public void unsetTitle()
      {
        flagHasTitle = false;
      }
    public void setLocation(string new_value)
      {
        flagHasLocation = true;
        storeLocation = new_value;
      }
    public void unsetLocation()
      {
        flagHasLocation = false;
      }
    public void setStart(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStart)
          {
          }
        flagHasStart = true;
        storeStart = new_value;
      }
    public void unsetStart()
      {
        if (flagHasStart)
          {
          }
        flagHasStart = false;
      }
    public void setEnd(DateAndOrTimeJSON  new_value)
      {
        if (flagHasEnd)
          {
          }
        flagHasEnd = true;
        storeEnd = new_value;
      }
    public void unsetEnd()
      {
        if (flagHasEnd)
          {
          }
        flagHasEnd = false;
      }
    public void initAttendees()
      {
        if (flagHasAttendees)
          {
            for (int num1 = 0; num1 < storeAttendees.Count; ++num1)
              {
              }
          }
        flagHasAttendees = true;
        storeAttendees.Clear();
      }
    public void appendAttendees(CalendarAttendeeJSON  to_append)
      {
        if (!flagHasAttendees)
          {
            flagHasAttendees = true;
            storeAttendees.Clear();
          }
        Debug.Assert(flagHasAttendees);
        storeAttendees.Add(to_append);
      }
    public void unsetAttendees()
      {
        if (flagHasAttendees)
          {
            for (int num2 = 0; num2 < storeAttendees.Count; ++num2)
              {
              }
          }
        flagHasAttendees = false;
        storeAttendees.Clear();
      }

    public virtual void extraCalendarEventSpecifierAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCalendarEventSpecifierSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCalendarEventSpecifierLookup(key);
        if (old_field == null)
          {
            extraCalendarEventSpecifierAppendPair(key, new_component);
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
        if (flagHasID)
          {
            handler.start_pair("ID");
            handler.string_value(storeID);
          }
        if (flagHasTitle)
          {
            handler.start_pair("Title");
            handler.string_value(storeTitle);
          }
        if (flagHasLocation)
          {
            handler.start_pair("Location");
            handler.string_value(storeLocation);
          }
        if (flagHasStart)
          {
            handler.start_pair("Start");
            if (partial_allowed)
                storeStart.write_partial_as_json(handler);
            else
                storeStart.write_as_json(handler);
          }
        if (flagHasEnd)
          {
            handler.start_pair("End");
            if (partial_allowed)
                storeEnd.write_partial_as_json(handler);
            else
                storeEnd.write_as_json(handler);
          }
        if (flagHasAttendees)
          {
            handler.start_pair("Attendees");
            handler.start_array();
            for (int num1 = 0; num1 < storeAttendees.Count; ++num1)
              {
                if (partial_allowed)
                    storeAttendees[num1].write_partial_as_json(handler);
                else
                    storeAttendees[num1].write_as_json(handler);
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static CalendarEventSpecifierJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarEventSpecifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarEventSpecifier", ignore_extras);
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
    public static CalendarEventSpecifierJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CalendarEventSpecifierJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarEventSpecifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarEventSpecifier", ignore_extras);
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
    public static CalendarEventSpecifierJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CalendarEventSpecifierJSON from_text(string text, bool ignore_extras)
      {
        CalendarEventSpecifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarEventSpecifier", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CalendarEventSpecifierJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CalendarEventSpecifierJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CalendarEventSpecifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarEventSpecifier", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorID;
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingStringGenerator fieldGeneratorLocation;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStart;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEnd;
        private CalendarAttendeeJSON.HoldingArrayGenerator fieldGeneratorAttendees;
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
            CalendarEventSpecifierJSON result = new CalendarEventSpecifierJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCalendarEventSpecifierAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CalendarEventSpecifierJSON result)
          {
            if (fieldGeneratorID.have_value)
              {
                result.setID(fieldGeneratorID.value);
                fieldGeneratorID.have_value = false;
              }
            if (fieldGeneratorTitle.have_value)
              {
                result.setTitle(fieldGeneratorTitle.value);
                fieldGeneratorTitle.have_value = false;
              }
            if (fieldGeneratorLocation.have_value)
              {
                result.setLocation(fieldGeneratorLocation.value);
                fieldGeneratorLocation.have_value = false;
              }
            if (fieldGeneratorStart.have_value)
              {
                result.setStart(fieldGeneratorStart.value);
                fieldGeneratorStart.have_value = false;
              }
            if (fieldGeneratorEnd.have_value)
              {
                result.setEnd(fieldGeneratorEnd.value);
                fieldGeneratorEnd.have_value = false;
              }
            if (fieldGeneratorAttendees.have_value)
              {
                result.initAttendees();
                int count = fieldGeneratorAttendees.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAttendees(fieldGeneratorAttendees.value[num]);
                  }
                fieldGeneratorAttendees.value.Clear();
                fieldGeneratorAttendees.have_value = false;
              }
          }
        protected abstract void handle_result(CalendarEventSpecifierJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttendees", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorAttendees;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "nd", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorEnd;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorID;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLocation;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tart", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorStart;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorTitle;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the CalendarEventSpecifier class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the CalendarEventSpecifier class");
            fieldGeneratorLocation = new JSONHoldingStringGenerator("field \"Location\" of the CalendarEventSpecifier class");
            fieldGeneratorStart = new DateAndOrTimeJSON.HoldingGenerator("field \"Start\" of the CalendarEventSpecifier class", ignore_extras);
            fieldGeneratorEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"End\" of the CalendarEventSpecifier class", ignore_extras);
            fieldGeneratorAttendees = new CalendarAttendeeJSON.HoldingArrayGenerator("field \"Attendees\" of the CalendarEventSpecifier class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CalendarEventSpecifier class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the CalendarEventSpecifier class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the CalendarEventSpecifier class");
            fieldGeneratorLocation = new JSONHoldingStringGenerator("field \"Location\" of the CalendarEventSpecifier class");
            fieldGeneratorStart = new DateAndOrTimeJSON.HoldingGenerator("field \"Start\" of the CalendarEventSpecifier class", false);
            fieldGeneratorEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"End\" of the CalendarEventSpecifier class", false);
            fieldGeneratorAttendees = new CalendarAttendeeJSON.HoldingArrayGenerator("field \"Attendees\" of the CalendarEventSpecifier class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CalendarEventSpecifier class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorID.reset();
            fieldGeneratorTitle.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorStart.reset();
            fieldGeneratorEnd.reset();
            fieldGeneratorAttendees.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorStart.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEnd.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAttendees.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorStart.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEnd.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAttendees.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CalendarEventSpecifierJSON  result)
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
        public CalendarEventSpecifierJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CalendarEventSpecifierJSON  result)
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
    protected virtual void handle_result(List<CalendarEventSpecifierJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CalendarEventSpecifierJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CalendarEventSpecifierJSON>();
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
    public List<CalendarEventSpecifierJSON> value;
  };
  };
