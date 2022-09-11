/* file "CiscoSparkRoomAvailabilityItemJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CiscoSparkRoomAvailabilityItemJSON : JSONBase
  {
    public enum TypeRoomKnownValues
      {
        Room_CurrentRoom,
        Room__none
      };
    public struct TypeRoom
      {
        public bool in_known_list;
        public string string_value;
        public TypeRoomKnownValues list_value;
      };

    public static TypeRoomKnownValues  stringToRoom(string chars)
      {
        if ((String.Compare(chars, 0, "CurrentRoom", 0, 11, false) == 0) && (chars.Length == 11))
            return TypeRoomKnownValues.Room_CurrentRoom;
        return TypeRoomKnownValues.Room__none;
      }

    public static string  stringFromRoom(TypeRoomKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeRoomKnownValues.Room_CurrentRoom:
                return "CurrentRoom";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeStatusKnownValues
      {
        Status_Available,
        Status_Booked,
        Status_Meeting,
        Status_Reserved,
        Status__none
      };
    public struct TypeStatus
      {
        public bool in_known_list;
        public string string_value;
        public TypeStatusKnownValues list_value;
      };

    public static TypeStatusKnownValues  stringToStatus(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "vailable", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeStatusKnownValues.Status_Available;
                break;
            case 'B':
                if ((String.Compare(chars, 1, "ooked", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeStatusKnownValues.Status_Booked;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "eeting", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeStatusKnownValues.Status_Meeting;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "eserved", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeStatusKnownValues.Status_Reserved;
                break;
            default:
                break;
          }
        return TypeStatusKnownValues.Status__none;
      }

    public static string  stringFromStatus(TypeStatusKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeStatusKnownValues.Status_Available:
                return "Available";
            case TypeStatusKnownValues.Status_Booked:
                return "Booked";
            case TypeStatusKnownValues.Status_Meeting:
                return "Meeting";
            case TypeStatusKnownValues.Status_Reserved:
                return "Reserved";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasStartDateAndTime;
    private DateAndOrTimeJSON  storeStartDateAndTime;
    private bool flagHasEndDateAndTime;
    private DateAndOrTimeJSON  storeEndDateAndTime;
    private bool flagHasRoom;
    private TypeRoom storeRoom;
    private bool flagHasStatus;
    private TypeStatus storeStatus;
    private bool flagHasIsNext;
    private bool storeIsNext;
    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasParticipants;
    private List< string > storeParticipants;
    private bool flagHasSpokenParticipants;
    private List< string > storeSpokenParticipants;
    private bool flagHasSubQueryId;
    private string storeSubQueryId;
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


    private void  fromJSONRoom(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Room of CiscoSparkRoomAvailabilityItemJSON is not a string.");
        TypeRoom the_open_enum = new TypeRoom();
        if ((String.Compare(json_string.getData(), 0, "CurrentRoom", 0, 11, false) == 0) && (json_string.getData().Length == 11))
              {
                the_open_enum.in_known_list = true;
                the_open_enum.list_value = TypeRoomKnownValues.Room_CurrentRoom;
                goto open_enum_is_done;
              }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setRoom(the_open_enum);
      }


    private void  fromJSONStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Status of CiscoSparkRoomAvailabilityItemJSON is not a string.");
        TypeStatus the_open_enum = new TypeStatus();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "vailable", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_Available;
                        goto open_enum_is_done;
                      }
                break;
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "ooked", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_Booked;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "eeting", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_Meeting;
                        goto open_enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "eserved", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_Reserved;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setStatus(the_open_enum);
      }


    private void  fromJSONIsNext(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsNext of CiscoSparkRoomAvailabilityItemJSON is not true for false.");
              }
          }
        setIsNext(the_bool);
      }


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of CiscoSparkRoomAvailabilityItemJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONParticipants(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Participants of CiscoSparkRoomAvailabilityItemJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Participants1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Participants of CiscoSparkRoomAvailabilityItemJSON is not a string.");
            vector_Participants1.Add(json_string.getData());
          }
        initParticipants();
        for (int num1 = 0; num1 < vector_Participants1.Count; ++num1)
            appendParticipants(vector_Participants1[num1]);
        for (int num1 = 0; num1 < vector_Participants1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSpokenParticipants(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SpokenParticipants of CiscoSparkRoomAvailabilityItemJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_SpokenParticipants1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field SpokenParticipants of CiscoSparkRoomAvailabilityItemJSON is not a string.");
            vector_SpokenParticipants1.Add(json_string.getData());
          }
        initSpokenParticipants();
        for (int num2 = 0; num2 < vector_SpokenParticipants1.Count; ++num2)
            appendSpokenParticipants(vector_SpokenParticipants1[num2]);
        for (int num1 = 0; num1 < vector_SpokenParticipants1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSubQueryId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SubQueryId of CiscoSparkRoomAvailabilityItemJSON is not a string.");
        setSubQueryId(json_string.getData());
      }


    public CiscoSparkRoomAvailabilityItemJSON()
      {
        flagHasStartDateAndTime = false;
        flagHasEndDateAndTime = false;
        flagHasRoom = false;
        flagHasStatus = false;
        flagHasIsNext = false;
        flagHasTitle = false;
        flagHasParticipants = false;
        flagHasSpokenParticipants = false;
        flagHasSubQueryId = false;
        storeIsNext = false;
        storeParticipants = new List< string >();
        storeSpokenParticipants = new List< string >();
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

    public bool  hasRoom()
      {
        return flagHasRoom;
      }

    public TypeRoom  getRoom()
      {
        Debug.Assert(flagHasRoom);
        return storeRoom;
      }

    public string  getRoomAsString()
      {
        TypeRoom result = getRoom();
        if (result.in_known_list)
            return stringFromRoom(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasStatus()
      {
        return flagHasStatus;
      }

    public TypeStatus  getStatus()
      {
        Debug.Assert(flagHasStatus);
        return storeStatus;
      }

    public string  getStatusAsString()
      {
        TypeStatus result = getStatus();
        if (result.in_known_list)
            return stringFromStatus(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasIsNext()
      {
        return flagHasIsNext;
      }

    public bool  getIsNext()
      {
        return storeIsNext;
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

    public bool  hasParticipants()
      {
        return flagHasParticipants;
      }

    public int  countOfParticipants()
      {
        Debug.Assert(flagHasParticipants);
        return storeParticipants.Count;
      }

    public string  elementOfParticipants(int element_num)
      {
        Debug.Assert(flagHasParticipants);
        return storeParticipants[element_num];
      }

    public List< string >  getParticipants()
      {
        Debug.Assert(flagHasParticipants);
        return storeParticipants;
      }

    public bool  hasSpokenParticipants()
      {
        return flagHasSpokenParticipants;
      }

    public int  countOfSpokenParticipants()
      {
        Debug.Assert(flagHasSpokenParticipants);
        return storeSpokenParticipants.Count;
      }

    public string  elementOfSpokenParticipants(int element_num)
      {
        Debug.Assert(flagHasSpokenParticipants);
        return storeSpokenParticipants[element_num];
      }

    public List< string >  getSpokenParticipants()
      {
        Debug.Assert(flagHasSpokenParticipants);
        return storeSpokenParticipants;
      }

    public bool  hasSubQueryId()
      {
        return flagHasSubQueryId;
      }

    public string  getSubQueryId()
      {
        Debug.Assert(flagHasSubQueryId);
        return storeSubQueryId;
      }


    public virtual int extraCiscoSparkRoomAvailabilityItemComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCiscoSparkRoomAvailabilityItemComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCiscoSparkRoomAvailabilityItemComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCiscoSparkRoomAvailabilityItemLookup(string field_name)
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
    public void setRoom(TypeRoom new_value)
      {
        flagHasRoom = true;
        storeRoom = new_value;
      }
    public void setRoom(string chars)
      {
        TypeRoomKnownValues known = stringToRoom(chars);
        TypeRoom new_value = new TypeRoom();
        if (known == TypeRoomKnownValues.Room__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setRoom(new_value);
      }
    public void setRoom(TypeRoomKnownValues new_value)
      {
        TypeRoom new_full_value = new TypeRoom();
        Debug.Assert(new_value != TypeRoomKnownValues.Room__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setRoom(new_full_value);
      }
    public void unsetRoom()
      {
        flagHasRoom = false;
      }
    public void setStatus(TypeStatus new_value)
      {
        flagHasStatus = true;
        storeStatus = new_value;
      }
    public void setStatus(string chars)
      {
        TypeStatusKnownValues known = stringToStatus(chars);
        TypeStatus new_value = new TypeStatus();
        if (known == TypeStatusKnownValues.Status__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setStatus(new_value);
      }
    public void setStatus(TypeStatusKnownValues new_value)
      {
        TypeStatus new_full_value = new TypeStatus();
        Debug.Assert(new_value != TypeStatusKnownValues.Status__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setStatus(new_full_value);
      }
    public void unsetStatus()
      {
        flagHasStatus = false;
      }
    public void setIsNext(bool new_value)
      {
        flagHasIsNext = true;
        storeIsNext = new_value;
      }
    public void unsetIsNext()
      {
        flagHasIsNext = false;
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
    public void initParticipants()
      {
        flagHasParticipants = true;
        storeParticipants.Clear();
      }
    public void appendParticipants(string to_append)
      {
        if (!flagHasParticipants)
          {
            flagHasParticipants = true;
            storeParticipants.Clear();
          }
        Debug.Assert(flagHasParticipants);
        storeParticipants.Add(to_append);
      }
    public void unsetParticipants()
      {
        flagHasParticipants = false;
        storeParticipants.Clear();
      }
    public void initSpokenParticipants()
      {
        flagHasSpokenParticipants = true;
        storeSpokenParticipants.Clear();
      }
    public void appendSpokenParticipants(string to_append)
      {
        if (!flagHasSpokenParticipants)
          {
            flagHasSpokenParticipants = true;
            storeSpokenParticipants.Clear();
          }
        Debug.Assert(flagHasSpokenParticipants);
        storeSpokenParticipants.Add(to_append);
      }
    public void unsetSpokenParticipants()
      {
        flagHasSpokenParticipants = false;
        storeSpokenParticipants.Clear();
      }
    public void setSubQueryId(string new_value)
      {
        flagHasSubQueryId = true;
        storeSubQueryId = new_value;
      }
    public void unsetSubQueryId()
      {
        flagHasSubQueryId = false;
      }

    public virtual void extraCiscoSparkRoomAvailabilityItemAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCiscoSparkRoomAvailabilityItemSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCiscoSparkRoomAvailabilityItemLookup(key);
        if (old_field == null)
          {
            extraCiscoSparkRoomAvailabilityItemAppendPair(key, new_component);
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
        if (flagHasStartDateAndTime)
          {
            handler.start_pair("StartDateAndTime");
            if (partial_allowed)
                storeStartDateAndTime.write_partial_as_json(handler);
            else
                storeStartDateAndTime.write_as_json(handler);
          }
        if (flagHasEndDateAndTime)
          {
            handler.start_pair("EndDateAndTime");
            if (partial_allowed)
                storeEndDateAndTime.write_partial_as_json(handler);
            else
                storeEndDateAndTime.write_as_json(handler);
          }
        if (flagHasRoom)
          {
            handler.start_pair("Room");
            if (storeRoom.in_known_list)
              {
                switch (storeRoom.list_value)
                  {
                    case TypeRoomKnownValues.Room_CurrentRoom:
                        handler.string_value("CurrentRoom");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeRoom.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasStatus);
        if (flagHasStatus)
          {
            handler.start_pair("Status");
            if (storeStatus.in_known_list)
              {
                switch (storeStatus.list_value)
                  {
                    case TypeStatusKnownValues.Status_Available:
                        handler.string_value("Available");
                        break;
                    case TypeStatusKnownValues.Status_Booked:
                        handler.string_value("Booked");
                        break;
                    case TypeStatusKnownValues.Status_Meeting:
                        handler.string_value("Meeting");
                        break;
                    case TypeStatusKnownValues.Status_Reserved:
                        handler.string_value("Reserved");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeStatus.string_value);
              }
          }
        if (flagHasIsNext)
          {
            handler.start_pair("IsNext");
            handler.boolean_value(storeIsNext);
          }
        if (flagHasTitle)
          {
            handler.start_pair("Title");
            handler.string_value(storeTitle);
          }
        if (flagHasParticipants)
          {
            handler.start_pair("Participants");
            handler.start_array();
            for (int num1 = 0; num1 < storeParticipants.Count; ++num1)
              {
                handler.string_value(storeParticipants[num1]);
              }
            handler.finish_array();
          }
        if (flagHasSpokenParticipants)
          {
            handler.start_pair("SpokenParticipants");
            handler.start_array();
            for (int num2 = 0; num2 < storeSpokenParticipants.Count; ++num2)
              {
                handler.string_value(storeSpokenParticipants[num2]);
              }
            handler.finish_array();
          }
        if (flagHasSubQueryId)
          {
            handler.start_pair("SubQueryId");
            handler.string_value(storeSubQueryId);
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
        if (!(hasStatus()))
          {
            return "When parsing the object for %what%, the \"Status\" field was missing.";
          }
        return null;
      }

    public static CiscoSparkRoomAvailabilityItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CiscoSparkRoomAvailabilityItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CiscoSparkRoomAvailabilityItem", ignore_extras);
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
    public static CiscoSparkRoomAvailabilityItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CiscoSparkRoomAvailabilityItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CiscoSparkRoomAvailabilityItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CiscoSparkRoomAvailabilityItem", ignore_extras);
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
    public static CiscoSparkRoomAvailabilityItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CiscoSparkRoomAvailabilityItemJSON from_text(string text, bool ignore_extras)
      {
        CiscoSparkRoomAvailabilityItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CiscoSparkRoomAvailabilityItem", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CiscoSparkRoomAvailabilityItemJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CiscoSparkRoomAvailabilityItemJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CiscoSparkRoomAvailabilityItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CiscoSparkRoomAvailabilityItem", ignore_extras);
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
    private abstract class FieldGeneratorRoom : JSONStringGenerator
          {
            protected FieldGeneratorRoom(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorRoom()
              {
              }
            protected override void handle_result(string result)
              {
                TypeRoomKnownValues known = stringToRoom(result);
                TypeRoom new_value = new TypeRoom();
                if (known == TypeRoomKnownValues.Room__none)
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
            protected abstract void handle_result(TypeRoom result);
          };
    private class FieldHoldingGeneratorRoom : FieldGeneratorRoom
  {
    protected override void handle_result(TypeRoom result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorRoom(String what)
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
    public TypeRoom value;
  };
    private class FieldHoldingArrayGeneratorRoom : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorRoom
      {
        private FieldHoldingArrayGeneratorRoom top;

        protected override void handle_result(TypeRoom result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorRoom init_top)
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
    protected virtual void handle_result(List<TypeRoom> result)
      {
      }

    public FieldHoldingArrayGeneratorRoom(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRoom>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorRoom()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRoom>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeRoom> value;
  };
        private FieldHoldingGeneratorRoom fieldGeneratorRoom;
    private abstract class FieldGeneratorStatus : JSONStringGenerator
          {
            protected FieldGeneratorStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorStatus()
              {
              }
            protected override void handle_result(string result)
              {
                TypeStatusKnownValues known = stringToStatus(result);
                TypeStatus new_value = new TypeStatus();
                if (known == TypeStatusKnownValues.Status__none)
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
            protected abstract void handle_result(TypeStatus result);
          };
    private class FieldHoldingGeneratorStatus : FieldGeneratorStatus
  {
    protected override void handle_result(TypeStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorStatus(String what)
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
    public TypeStatus value;
  };
    private class FieldHoldingArrayGeneratorStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorStatus
      {
        private FieldHoldingArrayGeneratorStatus top;

        protected override void handle_result(TypeStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorStatus init_top)
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
    protected virtual void handle_result(List<TypeStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeStatus> value;
  };
        private FieldHoldingGeneratorStatus fieldGeneratorStatus;
        private JSONHoldingBooleanGenerator fieldGeneratorIsNext;
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingStringArrayGenerator fieldGeneratorParticipants;
        private JSONHoldingStringArrayGenerator fieldGeneratorSpokenParticipants;
        private JSONHoldingStringGenerator fieldGeneratorSubQueryId;
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
            CiscoSparkRoomAvailabilityItemJSON result = new CiscoSparkRoomAvailabilityItemJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCiscoSparkRoomAvailabilityItemAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CiscoSparkRoomAvailabilityItemJSON result)
          {
            if (fieldGeneratorStartDateAndTime.have_value)
              {
                result.setStartDateAndTime(fieldGeneratorStartDateAndTime.value);
                fieldGeneratorStartDateAndTime.have_value = false;
              }
            if (fieldGeneratorEndDateAndTime.have_value)
              {
                result.setEndDateAndTime(fieldGeneratorEndDateAndTime.value);
                fieldGeneratorEndDateAndTime.have_value = false;
              }
            if (fieldGeneratorRoom.have_value)
              {
                result.setRoom(fieldGeneratorRoom.value);
                fieldGeneratorRoom.have_value = false;
              }
            if (fieldGeneratorStatus.have_value)
              {
                result.setStatus(fieldGeneratorStatus.value);
                fieldGeneratorStatus.have_value = false;
              }
            else if ((!(result.hasStatus())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Status\" field was missing.");
              }
            if (fieldGeneratorIsNext.have_value)
              {
                result.setIsNext(fieldGeneratorIsNext.value);
                fieldGeneratorIsNext.have_value = false;
              }
            if (fieldGeneratorTitle.have_value)
              {
                result.setTitle(fieldGeneratorTitle.value);
                fieldGeneratorTitle.have_value = false;
              }
            if (fieldGeneratorParticipants.have_value)
              {
                result.initParticipants();
                int count = fieldGeneratorParticipants.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendParticipants(fieldGeneratorParticipants.value[num]);
                  }
                fieldGeneratorParticipants.value.Clear();
                fieldGeneratorParticipants.have_value = false;
              }
            if (fieldGeneratorSpokenParticipants.have_value)
              {
                result.initSpokenParticipants();
                int count = fieldGeneratorSpokenParticipants.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSpokenParticipants(fieldGeneratorSpokenParticipants.value[num]);
                  }
                fieldGeneratorSpokenParticipants.value.Clear();
                fieldGeneratorSpokenParticipants.have_value = false;
              }
            if (fieldGeneratorSubQueryId.have_value)
              {
                result.setSubQueryId(fieldGeneratorSubQueryId.value);
                fieldGeneratorSubQueryId.have_value = false;
              }
          }
        protected abstract void handle_result(CiscoSparkRoomAvailabilityItemJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "ndDateAndTime", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorEndDateAndTime;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sNext", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorIsNext;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "articipants", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorParticipants;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "oom", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorRoom;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'p':
                            if ((String.Compare(field_name, 2, "okenParticipants", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorSpokenParticipants;
                            break;
                        case 't':
                            if (String.Compare(field_name, 2, "a", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'r':
                                        if ((String.Compare(field_name, 4, "tDateAndTime", 0, 12, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorStartDateAndTime;
                                        break;
                                    case 't':
                                        if ((String.Compare(field_name, 4, "us", 0, 2, false) == 0) && (field_name.Length == 6))
                                            return fieldGeneratorStatus;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "bQueryId", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorSubQueryId;
                            break;
                        default:
                            break;
                      }
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
            fieldGeneratorStartDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndTime\" of the CiscoSparkRoomAvailabilityItem class", ignore_extras);
            fieldGeneratorEndDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndTime\" of the CiscoSparkRoomAvailabilityItem class", ignore_extras);
            fieldGeneratorRoom = new FieldHoldingGeneratorRoom("field \"Room\" of the CiscoSparkRoomAvailabilityItem class");
            fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the CiscoSparkRoomAvailabilityItem class");
            fieldGeneratorIsNext = new JSONHoldingBooleanGenerator("field \"IsNext\" of the CiscoSparkRoomAvailabilityItem class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the CiscoSparkRoomAvailabilityItem class");
            fieldGeneratorParticipants = new JSONHoldingStringArrayGenerator("field \"Participants\" of the CiscoSparkRoomAvailabilityItem class");
            fieldGeneratorSpokenParticipants = new JSONHoldingStringArrayGenerator("field \"SpokenParticipants\" of the CiscoSparkRoomAvailabilityItem class");
            fieldGeneratorSubQueryId = new JSONHoldingStringGenerator("field \"SubQueryId\" of the CiscoSparkRoomAvailabilityItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CiscoSparkRoomAvailabilityItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStartDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndTime\" of the CiscoSparkRoomAvailabilityItem class", false);
            fieldGeneratorEndDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndTime\" of the CiscoSparkRoomAvailabilityItem class", false);
            fieldGeneratorRoom = new FieldHoldingGeneratorRoom("field \"Room\" of the CiscoSparkRoomAvailabilityItem class");
            fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the CiscoSparkRoomAvailabilityItem class");
            fieldGeneratorIsNext = new JSONHoldingBooleanGenerator("field \"IsNext\" of the CiscoSparkRoomAvailabilityItem class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the CiscoSparkRoomAvailabilityItem class");
            fieldGeneratorParticipants = new JSONHoldingStringArrayGenerator("field \"Participants\" of the CiscoSparkRoomAvailabilityItem class");
            fieldGeneratorSpokenParticipants = new JSONHoldingStringArrayGenerator("field \"SpokenParticipants\" of the CiscoSparkRoomAvailabilityItem class");
            fieldGeneratorSubQueryId = new JSONHoldingStringGenerator("field \"SubQueryId\" of the CiscoSparkRoomAvailabilityItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CiscoSparkRoomAvailabilityItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStartDateAndTime.reset();
            fieldGeneratorEndDateAndTime.reset();
            fieldGeneratorRoom.reset();
            fieldGeneratorStatus.reset();
            fieldGeneratorIsNext.reset();
            fieldGeneratorTitle.reset();
            fieldGeneratorParticipants.reset();
            fieldGeneratorSpokenParticipants.reset();
            fieldGeneratorSubQueryId.reset();
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
        protected override void handle_result(CiscoSparkRoomAvailabilityItemJSON  result)
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
        public CiscoSparkRoomAvailabilityItemJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CiscoSparkRoomAvailabilityItemJSON  result)
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
    protected virtual void handle_result(List<CiscoSparkRoomAvailabilityItemJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CiscoSparkRoomAvailabilityItemJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CiscoSparkRoomAvailabilityItemJSON>();
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
    public List<CiscoSparkRoomAvailabilityItemJSON> value;
  };
  };
