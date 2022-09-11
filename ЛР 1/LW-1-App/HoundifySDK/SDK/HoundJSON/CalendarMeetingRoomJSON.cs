/* file "CalendarMeetingRoomJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class CalendarMeetingRoomJSON : JSONBase
  {
    public enum TypeTypeKnownValues
      {
        Type_PhoneRoom,
        Type_ConferenceRoom,
        Type_MeetingRoom,
        Type_VideoChatRoom,
        Type_NonMeetingRoom,
        Type_Unknown,
        Type__none
      };
    public struct TypeType
      {
        public bool in_known_list;
        public string string_value;
        public TypeTypeKnownValues list_value;
      };

    public static TypeTypeKnownValues  stringToType(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "onferenceRoom", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeTypeKnownValues.Type_ConferenceRoom;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "eetingRoom", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeTypeKnownValues.Type_MeetingRoom;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "onMeetingRoom", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeTypeKnownValues.Type_NonMeetingRoom;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "honeRoom", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeTypeKnownValues.Type_PhoneRoom;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeTypeKnownValues.Type_Unknown;
                break;
            case 'V':
                if ((String.Compare(chars, 1, "ideoChatRoom", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeTypeKnownValues.Type_VideoChatRoom;
                break;
            default:
                break;
          }
        return TypeTypeKnownValues.Type__none;
      }

    public static string  stringFromType(TypeTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeTypeKnownValues.Type_PhoneRoom:
                return "PhoneRoom";
            case TypeTypeKnownValues.Type_ConferenceRoom:
                return "ConferenceRoom";
            case TypeTypeKnownValues.Type_MeetingRoom:
                return "MeetingRoom";
            case TypeTypeKnownValues.Type_VideoChatRoom:
                return "VideoChatRoom";
            case TypeTypeKnownValues.Type_NonMeetingRoom:
                return "NonMeetingRoom";
            case TypeTypeKnownValues.Type_Unknown:
                return "Unknown";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasName;
    private string storeName;
    private bool flagHasEmailAddress;
    private string storeEmailAddress;
    private bool flagHasCapacity;
    private BigInteger storeCapacity;
    private bool flagHasID;
    private string storeID;
    private bool flagHasBuilding;
    private string storeBuilding;
    private bool flagHasFloor;
    private string storeFloor;
    private bool flagHasType;
    private TypeType storeType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of CalendarMeetingRoomJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONEmailAddress(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EmailAddress of CalendarMeetingRoomJSON is not a string.");
        setEmailAddress(json_string.getData());
      }


    private void  fromJSONCapacity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Capacity of CalendarMeetingRoomJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Capacity of CalendarMeetingRoomJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCapacity(extracted_integer);
      }


    private void  fromJSONID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ID of CalendarMeetingRoomJSON is not a string.");
        setID(json_string.getData());
      }


    private void  fromJSONBuilding(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Building of CalendarMeetingRoomJSON is not a string.");
        setBuilding(json_string.getData());
      }


    private void  fromJSONFloor(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Floor of CalendarMeetingRoomJSON is not a string.");
        setFloor(json_string.getData());
      }


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Type of CalendarMeetingRoomJSON is not a string.");
        TypeType the_open_enum = new TypeType();
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "onferenceRoom", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_ConferenceRoom;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "eetingRoom", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_MeetingRoom;
                        goto open_enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "onMeetingRoom", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_NonMeetingRoom;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "honeRoom", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_PhoneRoom;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_Unknown;
                        goto open_enum_is_done;
                      }
                break;
            case 'V':
                if ((String.Compare(json_string.getData(), 1, "ideoChatRoom", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_VideoChatRoom;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setType(the_open_enum);
      }


    public CalendarMeetingRoomJSON()
      {
        flagHasName = false;
        flagHasEmailAddress = false;
        flagHasCapacity = false;
        flagHasID = false;
        flagHasBuilding = false;
        flagHasFloor = false;
        flagHasType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public string  getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public bool  hasEmailAddress()
      {
        return flagHasEmailAddress;
      }

    public string  getEmailAddress()
      {
        Debug.Assert(flagHasEmailAddress);
        return storeEmailAddress;
      }

    public bool  hasCapacity()
      {
        return flagHasCapacity;
      }

    public BigInteger  getCapacity()
      {
        Debug.Assert(flagHasCapacity);
        return storeCapacity;
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

    public bool  hasBuilding()
      {
        return flagHasBuilding;
      }

    public string  getBuilding()
      {
        Debug.Assert(flagHasBuilding);
        return storeBuilding;
      }

    public bool  hasFloor()
      {
        return flagHasFloor;
      }

    public string  getFloor()
      {
        Debug.Assert(flagHasFloor);
        return storeFloor;
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public TypeType  getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }

    public string  getTypeAsString()
      {
        TypeType result = getType();
        if (result.in_known_list)
            return stringFromType(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraCalendarMeetingRoomComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCalendarMeetingRoomComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCalendarMeetingRoomComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCalendarMeetingRoomLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setName(string new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void setEmailAddress(string new_value)
      {
        flagHasEmailAddress = true;
        storeEmailAddress = new_value;
      }
    public void unsetEmailAddress()
      {
        flagHasEmailAddress = false;
      }
    public void setCapacity(BigInteger new_value)
      {
        flagHasCapacity = true;
        storeCapacity = new_value;
      }
    public void unsetCapacity()
      {
        flagHasCapacity = false;
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
    public void setBuilding(string new_value)
      {
        flagHasBuilding = true;
        storeBuilding = new_value;
      }
    public void unsetBuilding()
      {
        flagHasBuilding = false;
      }
    public void setFloor(string new_value)
      {
        flagHasFloor = true;
        storeFloor = new_value;
      }
    public void unsetFloor()
      {
        flagHasFloor = false;
      }
    public void setType(TypeType new_value)
      {
        flagHasType = true;
        storeType = new_value;
      }
    public void setType(string chars)
      {
        TypeTypeKnownValues known = stringToType(chars);
        TypeType new_value = new TypeType();
        if (known == TypeTypeKnownValues.Type__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setType(new_value);
      }
    public void setType(TypeTypeKnownValues new_value)
      {
        TypeType new_full_value = new TypeType();
        Debug.Assert(new_value != TypeTypeKnownValues.Type__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setType(new_full_value);
      }
    public void unsetType()
      {
        flagHasType = false;
      }

    public virtual void extraCalendarMeetingRoomAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCalendarMeetingRoomSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCalendarMeetingRoomLookup(key);
        if (old_field == null)
          {
            extraCalendarMeetingRoomAppendPair(key, new_component);
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
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        if (flagHasEmailAddress)
          {
            handler.start_pair("EmailAddress");
            handler.string_value(storeEmailAddress);
          }
        if (flagHasCapacity)
          {
            handler.start_pair("Capacity");
            handler.number_value(storeCapacity);
          }
        if (flagHasID)
          {
            handler.start_pair("ID");
            handler.string_value(storeID);
          }
        if (flagHasBuilding)
          {
            handler.start_pair("Building");
            handler.string_value(storeBuilding);
          }
        if (flagHasFloor)
          {
            handler.start_pair("Floor");
            handler.string_value(storeFloor);
          }
        if (flagHasType)
          {
            handler.start_pair("Type");
            if (storeType.in_known_list)
              {
                switch (storeType.list_value)
                  {
                    case TypeTypeKnownValues.Type_PhoneRoom:
                        handler.string_value("PhoneRoom");
                        break;
                    case TypeTypeKnownValues.Type_ConferenceRoom:
                        handler.string_value("ConferenceRoom");
                        break;
                    case TypeTypeKnownValues.Type_MeetingRoom:
                        handler.string_value("MeetingRoom");
                        break;
                    case TypeTypeKnownValues.Type_VideoChatRoom:
                        handler.string_value("VideoChatRoom");
                        break;
                    case TypeTypeKnownValues.Type_NonMeetingRoom:
                        handler.string_value("NonMeetingRoom");
                        break;
                    case TypeTypeKnownValues.Type_Unknown:
                        handler.string_value("Unknown");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeType.string_value);
              }
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

    public static CalendarMeetingRoomJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarMeetingRoomJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarMeetingRoom", ignore_extras);
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
    public static CalendarMeetingRoomJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CalendarMeetingRoomJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarMeetingRoomJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarMeetingRoom", ignore_extras);
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
    public static CalendarMeetingRoomJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CalendarMeetingRoomJSON from_text(string text, bool ignore_extras)
      {
        CalendarMeetingRoomJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarMeetingRoom", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CalendarMeetingRoomJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CalendarMeetingRoomJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CalendarMeetingRoomJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarMeetingRoom", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorEmailAddress;
    private class FieldHoldingGeneratorCapacity : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorCapacity(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorCapacity : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorCapacity(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorCapacity fieldGeneratorCapacity;
        private JSONHoldingStringGenerator fieldGeneratorID;
        private JSONHoldingStringGenerator fieldGeneratorBuilding;
        private JSONHoldingStringGenerator fieldGeneratorFloor;
    private abstract class FieldGeneratorType : JSONStringGenerator
          {
            protected FieldGeneratorType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeTypeKnownValues known = stringToType(result);
                TypeType new_value = new TypeType();
                if (known == TypeTypeKnownValues.Type__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeType result);
          };
    private class FieldHoldingGeneratorType : FieldGeneratorType
  {
    protected override void handle_result(TypeType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorType(String what)
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
    public TypeType value;
  };
    private class FieldHoldingArrayGeneratorType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorType
      {
        private FieldHoldingArrayGeneratorType top;

        protected override void handle_result(TypeType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorType init_top)
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
    protected virtual void handle_result(List<TypeType> result)
      {
      }

    public FieldHoldingArrayGeneratorType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeType> value;
  };
        private FieldHoldingGeneratorType fieldGeneratorType;
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
            CalendarMeetingRoomJSON result = new CalendarMeetingRoomJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCalendarMeetingRoomAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CalendarMeetingRoomJSON result)
          {
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            if (fieldGeneratorEmailAddress.have_value)
              {
                result.setEmailAddress(fieldGeneratorEmailAddress.value);
                fieldGeneratorEmailAddress.have_value = false;
              }
            if (fieldGeneratorCapacity.have_value)
              {
                result.setCapacity(fieldGeneratorCapacity.value);
                fieldGeneratorCapacity.have_value = false;
              }
            if (fieldGeneratorID.have_value)
              {
                result.setID(fieldGeneratorID.value);
                fieldGeneratorID.have_value = false;
              }
            if (fieldGeneratorBuilding.have_value)
              {
                result.setBuilding(fieldGeneratorBuilding.value);
                fieldGeneratorBuilding.have_value = false;
              }
            if (fieldGeneratorFloor.have_value)
              {
                result.setFloor(fieldGeneratorFloor.value);
                fieldGeneratorFloor.have_value = false;
              }
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
          }
        protected abstract void handle_result(CalendarMeetingRoomJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "uilding", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorBuilding;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "apacity", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorCapacity;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "mailAddress", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorEmailAddress;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "loor", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorFloor;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorID;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorType;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the CalendarMeetingRoom class");
            fieldGeneratorEmailAddress = new JSONHoldingStringGenerator("field \"EmailAddress\" of the CalendarMeetingRoom class");
            fieldGeneratorCapacity = new FieldHoldingGeneratorCapacity("field \"Capacity\" of the CalendarMeetingRoom class");
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the CalendarMeetingRoom class");
            fieldGeneratorBuilding = new JSONHoldingStringGenerator("field \"Building\" of the CalendarMeetingRoom class");
            fieldGeneratorFloor = new JSONHoldingStringGenerator("field \"Floor\" of the CalendarMeetingRoom class");
            fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the CalendarMeetingRoom class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CalendarMeetingRoom class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the CalendarMeetingRoom class");
            fieldGeneratorEmailAddress = new JSONHoldingStringGenerator("field \"EmailAddress\" of the CalendarMeetingRoom class");
            fieldGeneratorCapacity = new FieldHoldingGeneratorCapacity("field \"Capacity\" of the CalendarMeetingRoom class");
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the CalendarMeetingRoom class");
            fieldGeneratorBuilding = new JSONHoldingStringGenerator("field \"Building\" of the CalendarMeetingRoom class");
            fieldGeneratorFloor = new JSONHoldingStringGenerator("field \"Floor\" of the CalendarMeetingRoom class");
            fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the CalendarMeetingRoom class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CalendarMeetingRoom class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorEmailAddress.reset();
            fieldGeneratorCapacity.reset();
            fieldGeneratorID.reset();
            fieldGeneratorBuilding.reset();
            fieldGeneratorFloor.reset();
            fieldGeneratorType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CalendarMeetingRoomJSON  result)
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
        public CalendarMeetingRoomJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CalendarMeetingRoomJSON  result)
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
    protected virtual void handle_result(List<CalendarMeetingRoomJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CalendarMeetingRoomJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CalendarMeetingRoomJSON>();
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
    public List<CalendarMeetingRoomJSON> value;
  };
  };
