/* file "ThirdPartyCalendarAvailableRoomsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ThirdPartyCalendarAvailableRoomsInformationNuggetJSON : ThirdPartyCalendarInformationNuggetJSON
  {
    private bool flagHasRooms;
    private List< CalendarMeetingRoomJSON  > storeRooms;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraRoomsToJSON()
      {
        JSONArrayValue generated_array_1_Rooms = new JSONArrayValue();
        for (int num1 = 0; num1 < storeRooms.Count; ++num1)
          {
            JSONValueHandler handler_Rooms = new JSONValueHandler();
            storeRooms[num1].write_as_json(handler_Rooms);
            generated_array_1_Rooms.appendComponent(handler_Rooms.result);
          }
        return generated_array_1_Rooms;
      }


    private void  fromJSONRooms(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Rooms of ThirdPartyCalendarAvailableRoomsInformationNuggetJSON is not an array.");
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


    public ThirdPartyCalendarAvailableRoomsInformationNuggetJSON()
      {
        flagHasRooms = false;
        storeRooms = new List< CalendarMeetingRoomJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getThirdPartyCalendarInformationNuggetType()
      {
        return "ThirdPartyCalendarAvailableRoomsInformationNugget";
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


    public virtual int extraThirdPartyCalendarAvailableRoomsInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraThirdPartyCalendarAvailableRoomsInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarAvailableRoomsInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarAvailableRoomsInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraThirdPartyCalendarInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasRooms)
            ++result;
        result += extraThirdPartyCalendarAvailableRoomsInformationNuggetComponentCount();
        return result;
      }
    public override string extraThirdPartyCalendarInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasRooms)
          {
            if (remainder == 0)
                return "Rooms";
            --remainder;
          }
        return extraThirdPartyCalendarAvailableRoomsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraThirdPartyCalendarInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasRooms)
          {
            if (remainder == 0)
                return extraRoomsToJSON();
            --remainder;
          }
        return extraThirdPartyCalendarAvailableRoomsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraThirdPartyCalendarInformationNuggetLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Rooms", 0, 5, false) == 0) && (field_name.Length == 5))
            return (flagHasRooms ? extraRoomsToJSON() : null);
        return extraThirdPartyCalendarAvailableRoomsInformationNuggetLookup(field_name);
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

    public virtual void extraThirdPartyCalendarAvailableRoomsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraThirdPartyCalendarAvailableRoomsInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraThirdPartyCalendarAvailableRoomsInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraThirdPartyCalendarAvailableRoomsInformationNuggetAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "Rooms", 0, 5, false) == 0) && (key.Length == 5))
            {
            fromJSONRooms(new_component, false);
            return;
            }
        extraThirdPartyCalendarAvailableRoomsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraThirdPartyCalendarInformationNuggetSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Rooms", 0, 5, false) == 0) && (key.Length == 5))
            {
            fromJSONRooms(new_component, false);
            return;
            }
        extraThirdPartyCalendarAvailableRoomsInformationNuggetSetField(key, new_component);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new ThirdPartyCalendarAvailableRoomsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarAvailableRoomsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarAvailableRoomsInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarAvailableRoomsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarAvailableRoomsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarAvailableRoomsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarAvailableRoomsInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarAvailableRoomsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarAvailableRoomsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ThirdPartyCalendarAvailableRoomsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarAvailableRoomsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ThirdPartyCalendarAvailableRoomsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ThirdPartyCalendarAvailableRoomsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ThirdPartyCalendarAvailableRoomsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarAvailableRoomsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ThirdPartyCalendarInformationNuggetJSON.Generator
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
            if (!(getThirdPartyCalendarInformationNuggetJSONKey().Equals("ThirdPartyCalendarAvailableRoomsInformationNugget")))
                throw new Exception("The key field has a value other than `ThirdPartyCalendarAvailableRoomsInformationNugget'.");
            ThirdPartyCalendarAvailableRoomsInformationNuggetJSON result = new ThirdPartyCalendarAvailableRoomsInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraThirdPartyCalendarAvailableRoomsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ThirdPartyCalendarInformationNuggetJSON new_result)
          {
            handle_result((ThirdPartyCalendarAvailableRoomsInformationNuggetJSON )new_result);
          }
        protected void finish(ThirdPartyCalendarAvailableRoomsInformationNuggetJSON result)
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
            base.finish(result);
          }
        protected abstract void handle_result(ThirdPartyCalendarAvailableRoomsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Rooms", 0, 5, false) == 0) && (field_name.Length == 5))
                return fieldGeneratorRooms;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorRooms = new CalendarMeetingRoomJSON.HoldingArrayGenerator("field \"Rooms\" of the ThirdPartyCalendarAvailableRoomsInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ThirdPartyCalendarAvailableRoomsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorRooms = new CalendarMeetingRoomJSON.HoldingArrayGenerator("field \"Rooms\" of the ThirdPartyCalendarAvailableRoomsInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ThirdPartyCalendarAvailableRoomsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorRooms.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ThirdPartyCalendarAvailableRoomsInformationNuggetJSON  result)
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
        public ThirdPartyCalendarAvailableRoomsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ThirdPartyCalendarAvailableRoomsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ThirdPartyCalendarAvailableRoomsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ThirdPartyCalendarAvailableRoomsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ThirdPartyCalendarAvailableRoomsInformationNuggetJSON>();
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
    public List<ThirdPartyCalendarAvailableRoomsInformationNuggetJSON> value;
  };
  };
