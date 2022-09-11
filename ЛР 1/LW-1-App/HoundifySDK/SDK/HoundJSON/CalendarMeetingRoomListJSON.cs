/* file "CalendarMeetingRoomListJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CalendarMeetingRoomListJSON : JSONBase
  {
    private bool flagHasRooms;
    private List< CalendarMeetingRoomJSON  > storeRooms;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONRooms(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Rooms of CalendarMeetingRoomListJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< CalendarMeetingRoomJSON  > vector_Rooms1 = new List< CalendarMeetingRoomJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CalendarMeetingRoomJSON convert_classy = CalendarMeetingRoomJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Rooms1.Add(convert_classy);
          }
        initRooms();
        for (int num1 = 0; num1 < vector_Rooms1.Count; ++num1)
            appendRooms(vector_Rooms1[num1]);
        for (int num1 = 0; num1 < vector_Rooms1.Count; ++num1)
          {
          }
      }


    public CalendarMeetingRoomListJSON()
      {
        flagHasRooms = false;
        storeRooms = new List< CalendarMeetingRoomJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasRooms()
      {
        return flagHasRooms;
      }

    public int  countOfRooms()
      {
        Debug.Assert(flagHasRooms);
        return storeRooms.Count;
      }

    public CalendarMeetingRoomJSON   elementOfRooms(int element_num)
      {
        Debug.Assert(flagHasRooms);
        return storeRooms[element_num];
      }

    public List< CalendarMeetingRoomJSON  >  getRooms()
      {
        Debug.Assert(flagHasRooms);
        return storeRooms;
      }


    public virtual int extraCalendarMeetingRoomListComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCalendarMeetingRoomListComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCalendarMeetingRoomListComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCalendarMeetingRoomListLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initRooms()
      {
        if (flagHasRooms)
          {
            for (int num1 = 0; num1 < storeRooms.Count; ++num1)
              {
              }
          }
        flagHasRooms = true;
        storeRooms.Clear();
      }
    public void appendRooms(CalendarMeetingRoomJSON  to_append)
      {
        if (!flagHasRooms)
          {
            flagHasRooms = true;
            storeRooms.Clear();
          }
        Debug.Assert(flagHasRooms);
        storeRooms.Add(to_append);
      }
    public void unsetRooms()
      {
        if (flagHasRooms)
          {
            for (int num2 = 0; num2 < storeRooms.Count; ++num2)
              {
              }
          }
        flagHasRooms = false;
        storeRooms.Clear();
      }

    public virtual void extraCalendarMeetingRoomListAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCalendarMeetingRoomListSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCalendarMeetingRoomListLookup(key);
        if (old_field == null)
          {
            extraCalendarMeetingRoomListAppendPair(key, new_component);
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
        if (flagHasRooms)
          {
            handler.start_pair("Rooms");
            handler.start_array();
            for (int num1 = 0; num1 < storeRooms.Count; ++num1)
              {
                if (partial_allowed)
                    storeRooms[num1].write_partial_as_json(handler);
                else
                    storeRooms[num1].write_as_json(handler);
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

    public static CalendarMeetingRoomListJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarMeetingRoomListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarMeetingRoomList", ignore_extras);
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
    public static CalendarMeetingRoomListJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CalendarMeetingRoomListJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarMeetingRoomListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarMeetingRoomList", ignore_extras);
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
    public static CalendarMeetingRoomListJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CalendarMeetingRoomListJSON from_text(string text, bool ignore_extras)
      {
        CalendarMeetingRoomListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarMeetingRoomList", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CalendarMeetingRoomListJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CalendarMeetingRoomListJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CalendarMeetingRoomListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarMeetingRoomList", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private CalendarMeetingRoomJSON.HoldingArrayGenerator fieldGeneratorRooms;
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
            CalendarMeetingRoomListJSON result = new CalendarMeetingRoomListJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCalendarMeetingRoomListAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CalendarMeetingRoomListJSON result)
          {
            if (fieldGeneratorRooms.have_value)
              {
                result.initRooms();
                int count = fieldGeneratorRooms.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRooms(fieldGeneratorRooms.value[num]);
                  }
                fieldGeneratorRooms.value.Clear();
                fieldGeneratorRooms.have_value = false;
              }
          }
        protected abstract void handle_result(CalendarMeetingRoomListJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Rooms", 0, 5, false) == 0) && (field_name.Length == 5))
                return fieldGeneratorRooms;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorRooms = new CalendarMeetingRoomJSON.HoldingArrayGenerator("field \"Rooms\" of the CalendarMeetingRoomList class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CalendarMeetingRoomList class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorRooms = new CalendarMeetingRoomJSON.HoldingArrayGenerator("field \"Rooms\" of the CalendarMeetingRoomList class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CalendarMeetingRoomList class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorRooms.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorRooms.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorRooms.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CalendarMeetingRoomListJSON  result)
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
        public CalendarMeetingRoomListJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CalendarMeetingRoomListJSON  result)
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
    protected virtual void handle_result(List<CalendarMeetingRoomListJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CalendarMeetingRoomListJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CalendarMeetingRoomListJSON>();
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
    public List<CalendarMeetingRoomListJSON> value;
  };
  };
