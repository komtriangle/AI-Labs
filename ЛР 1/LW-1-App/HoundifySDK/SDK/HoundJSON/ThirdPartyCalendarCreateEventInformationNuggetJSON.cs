/* file "ThirdPartyCalendarCreateEventInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ThirdPartyCalendarCreateEventInformationNuggetJSON : ThirdPartyCalendarInformationNuggetJSON
  {
    public enum TypeConfirmReasonKnownValues
      {
        ConfirmReason_EventConflicts,
        ConfirmReason__none
      };
    public struct TypeConfirmReason
      {
        public bool in_known_list;
        public string string_value;
        public TypeConfirmReasonKnownValues list_value;
      };

    public static TypeConfirmReasonKnownValues  stringToConfirmReason(string chars)
      {
        if ((String.Compare(chars, 0, "EventConflicts", 0, 14, false) == 0) && (chars.Length == 14))
            return TypeConfirmReasonKnownValues.ConfirmReason_EventConflicts;
        return TypeConfirmReasonKnownValues.ConfirmReason__none;
      }

    public static string  stringFromConfirmReason(TypeConfirmReasonKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeConfirmReasonKnownValues.ConfirmReason_EventConflicts:
                return "EventConflicts";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeCreateTypeKnownValues
      {
        CreateType_Normal,
        CreateType_RoomBook,
        CreateType__none
      };
    public struct TypeCreateType
      {
        public bool in_known_list;
        public string string_value;
        public TypeCreateTypeKnownValues list_value;
      };

    public static TypeCreateTypeKnownValues  stringToCreateType(string chars)
      {
        switch (chars[0])
          {
            case 'N':
                if ((String.Compare(chars, 1, "ormal", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeCreateTypeKnownValues.CreateType_Normal;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "oomBook", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeCreateTypeKnownValues.CreateType_RoomBook;
                break;
            default:
                break;
          }
        return TypeCreateTypeKnownValues.CreateType__none;
      }

    public static string  stringFromCreateType(TypeCreateTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeCreateTypeKnownValues.CreateType_Normal:
                return "Normal";
            case TypeCreateTypeKnownValues.CreateType_RoomBook:
                return "RoomBook";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasConflictingEvents;
    private List< ThirdPartyCalendarEventJSON  > storeConflictingEvents;
    private bool flagHasCreateData;
    private CalendarCreateDataJSON  storeCreateData;
    private bool flagHasUserHasToConfirm;
    private bool storeUserHasToConfirm;
    private bool flagHasConfirmReason;
    private TypeConfirmReason storeConfirmReason;
    private bool flagHasEvent;
    private ThirdPartyCalendarEventJSON  storeEvent;
    private bool flagHasCreateType;
    private TypeCreateType storeCreateType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraConflictingEventsToJSON()
      {
        JSONArrayValue generated_array_1_ConflictingEvents = new JSONArrayValue();
        for (int num1 = 0; num1 < storeConflictingEvents.Count; ++num1)
          {
            JSONValueHandler handler_ConflictingEvents = new JSONValueHandler();
            storeConflictingEvents[num1].write_as_json(handler_ConflictingEvents);
            generated_array_1_ConflictingEvents.appendComponent(handler_ConflictingEvents.result);
          }
        return generated_array_1_ConflictingEvents;
      }

    private JSONValue  extraCreateDataToJSON()
      {
        JSONValueHandler handler_CreateData = new JSONValueHandler();
        storeCreateData.write_as_json(handler_CreateData);
        return handler_CreateData.result;
      }

    private JSONValue  extraUserHasToConfirmToJSON()
      {
        JSONValue generated_boolean_UserHasToConfirm = (storeUserHasToConfirm ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_UserHasToConfirm;
      }

    private JSONValue  extraConfirmReasonToJSON()
      {
        JSONStringValue generated_string_ConfirmReason;
        if (!(storeConfirmReason.in_known_list))
          {
        generated_string_ConfirmReason = new JSONStringValue(storeConfirmReason.string_value);
          }
        else
          {
        switch (storeConfirmReason.list_value)
          {
            case TypeConfirmReasonKnownValues.ConfirmReason_EventConflicts:
                generated_string_ConfirmReason = new JSONStringValue("EventConflicts");
                break;
            default:
                Debug.Assert(false);
                generated_string_ConfirmReason = null;
                break;
          }
          }
        return generated_string_ConfirmReason;
      }

    private JSONValue  extraEventToJSON()
      {
        JSONValueHandler handler_Event = new JSONValueHandler();
        storeEvent.write_as_json(handler_Event);
        return handler_Event.result;
      }

    private JSONValue  extraCreateTypeToJSON()
      {
        JSONStringValue generated_string_CreateType;
        if (!(storeCreateType.in_known_list))
          {
        generated_string_CreateType = new JSONStringValue(storeCreateType.string_value);
          }
        else
          {
        switch (storeCreateType.list_value)
          {
            case TypeCreateTypeKnownValues.CreateType_Normal:
                generated_string_CreateType = new JSONStringValue("Normal");
                break;
            case TypeCreateTypeKnownValues.CreateType_RoomBook:
                generated_string_CreateType = new JSONStringValue("RoomBook");
                break;
            default:
                Debug.Assert(false);
                generated_string_CreateType = null;
                break;
          }
          }
        return generated_string_CreateType;
      }


    private void  fromJSONConflictingEvents(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ConflictingEvents of ThirdPartyCalendarCreateEventInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< ThirdPartyCalendarEventJSON  > vector_ConflictingEvents1 = new List< ThirdPartyCalendarEventJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            ThirdPartyCalendarEventJSON convert_classy = ThirdPartyCalendarEventJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ConflictingEvents1.Add(convert_classy);
          }
        initConflictingEvents();
        for (int num1 = 0; num1 < vector_ConflictingEvents1.Count; ++num1)
            appendConflictingEvents(vector_ConflictingEvents1[num1]);
        for (int num1 = 0; num1 < vector_ConflictingEvents1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCreateData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CalendarCreateDataJSON convert_classy = CalendarCreateDataJSON.from_json(json_value, ignore_extras, true);
        setCreateData(convert_classy);
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
                throw new Exception("The value for field UserHasToConfirm of ThirdPartyCalendarCreateEventInformationNuggetJSON is not true for false.");
              }
          }
        setUserHasToConfirm(the_bool);
      }


    private void  fromJSONConfirmReason(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ConfirmReason of ThirdPartyCalendarCreateEventInformationNuggetJSON is not a string.");
        TypeConfirmReason the_open_enum = new TypeConfirmReason();
        if ((String.Compare(json_string.getData(), 0, "EventConflicts", 0, 14, false) == 0) && (json_string.getData().Length == 14))
              {
                the_open_enum.in_known_list = true;
                the_open_enum.list_value = TypeConfirmReasonKnownValues.ConfirmReason_EventConflicts;
                goto open_enum_is_done;
              }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setConfirmReason(the_open_enum);
      }


    private void  fromJSONEvent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ThirdPartyCalendarEventJSON convert_classy = ThirdPartyCalendarEventJSON.from_json(json_value, ignore_extras, true);
        setEvent(convert_classy);
      }


    private void  fromJSONCreateType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CreateType of ThirdPartyCalendarCreateEventInformationNuggetJSON is not a string.");
        TypeCreateType the_open_enum = new TypeCreateType();
        switch (json_string.getData()[0])
          {
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCreateTypeKnownValues.CreateType_Normal;
                        goto open_enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "oomBook", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCreateTypeKnownValues.CreateType_RoomBook;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setCreateType(the_open_enum);
      }


    public ThirdPartyCalendarCreateEventInformationNuggetJSON()
      {
        flagHasConflictingEvents = false;
        flagHasCreateData = false;
        flagHasUserHasToConfirm = false;
        flagHasConfirmReason = false;
        flagHasEvent = false;
        flagHasCreateType = false;
        storeConflictingEvents = new List< ThirdPartyCalendarEventJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getThirdPartyCalendarInformationNuggetType()
      {
        return "ThirdPartyCalendarCreateEventInformationNugget";
      }

    public bool  hasConflictingEvents()
      {
        return flagHasConflictingEvents;
      }

    public int  countOfConflictingEvents()
      {
        Debug.Assert(flagHasConflictingEvents);
        return storeConflictingEvents.Count;
      }

    public ThirdPartyCalendarEventJSON   elementOfConflictingEvents(int element_num)
      {
        Debug.Assert(flagHasConflictingEvents);
        return storeConflictingEvents[element_num];
      }

    public List< ThirdPartyCalendarEventJSON  >  getConflictingEvents()
      {
        Debug.Assert(flagHasConflictingEvents);
        return storeConflictingEvents;
      }

    public bool  hasCreateData()
      {
        return flagHasCreateData;
      }

    public CalendarCreateDataJSON   getCreateData()
      {
        Debug.Assert(flagHasCreateData);
        return storeCreateData;
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

    public bool  hasConfirmReason()
      {
        return flagHasConfirmReason;
      }

    public TypeConfirmReason  getConfirmReason()
      {
        Debug.Assert(flagHasConfirmReason);
        return storeConfirmReason;
      }

    public string  getConfirmReasonAsString()
      {
        TypeConfirmReason result = getConfirmReason();
        if (result.in_known_list)
            return stringFromConfirmReason(result.list_value);
        else
            return result.string_value;
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

    public bool  hasCreateType()
      {
        return flagHasCreateType;
      }

    public TypeCreateType  getCreateType()
      {
        Debug.Assert(flagHasCreateType);
        return storeCreateType;
      }

    public string  getCreateTypeAsString()
      {
        TypeCreateType result = getCreateType();
        if (result.in_known_list)
            return stringFromCreateType(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraThirdPartyCalendarCreateEventInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraThirdPartyCalendarCreateEventInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarCreateEventInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarCreateEventInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraThirdPartyCalendarInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasConflictingEvents)
            ++result;
        if (flagHasCreateData)
            ++result;
        if (flagHasUserHasToConfirm)
            ++result;
        if (flagHasConfirmReason)
            ++result;
        if (flagHasEvent)
            ++result;
        if (flagHasCreateType)
            ++result;
        result += extraThirdPartyCalendarCreateEventInformationNuggetComponentCount();
        return result;
      }
    public override string extraThirdPartyCalendarInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasConflictingEvents)
          {
            if (remainder == 0)
                return "ConflictingEvents";
            --remainder;
          }
        if (flagHasCreateData)
          {
            if (remainder == 0)
                return "CreateData";
            --remainder;
          }
        if (flagHasUserHasToConfirm)
          {
            if (remainder == 0)
                return "UserHasToConfirm";
            --remainder;
          }
        if (flagHasConfirmReason)
          {
            if (remainder == 0)
                return "ConfirmReason";
            --remainder;
          }
        if (flagHasEvent)
          {
            if (remainder == 0)
                return "Event";
            --remainder;
          }
        if (flagHasCreateType)
          {
            if (remainder == 0)
                return "CreateType";
            --remainder;
          }
        return extraThirdPartyCalendarCreateEventInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraThirdPartyCalendarInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasConflictingEvents)
          {
            if (remainder == 0)
                return extraConflictingEventsToJSON();
            --remainder;
          }
        if (flagHasCreateData)
          {
            if (remainder == 0)
                return extraCreateDataToJSON();
            --remainder;
          }
        if (flagHasUserHasToConfirm)
          {
            if (remainder == 0)
                return extraUserHasToConfirmToJSON();
            --remainder;
          }
        if (flagHasConfirmReason)
          {
            if (remainder == 0)
                return extraConfirmReasonToJSON();
            --remainder;
          }
        if (flagHasEvent)
          {
            if (remainder == 0)
                return extraEventToJSON();
            --remainder;
          }
        if (flagHasCreateType)
          {
            if (remainder == 0)
                return extraCreateTypeToJSON();
            --remainder;
          }
        return extraThirdPartyCalendarCreateEventInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraThirdPartyCalendarInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                switch (field_name[1])
                  {
                    case 'o':
                        if (String.Compare(field_name, 2, "nf", 0, 2, false) == 0)
                          {
                            switch (field_name[4])
                              {
                                case 'i':
                                    if ((String.Compare(field_name, 5, "rmReason", 0, 8, false) == 0) && (field_name.Length == 13))
                                        return (flagHasConfirmReason ? extraConfirmReasonToJSON() : null);
                                    break;
                                case 'l':
                                    if ((String.Compare(field_name, 5, "ictingEvents", 0, 12, false) == 0) && (field_name.Length == 17))
                                        return (flagHasConflictingEvents ? extraConflictingEventsToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(field_name, 2, "eate", 0, 4, false) == 0)
                          {
                            switch (field_name[6])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 7, "ata", 0, 3, false) == 0) && (field_name.Length == 10))
                                        return (flagHasCreateData ? extraCreateDataToJSON() : null);
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 7, "ype", 0, 3, false) == 0) && (field_name.Length == 10))
                                        return (flagHasCreateType ? extraCreateTypeToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'E':
                if ((String.Compare(field_name, 1, "vent", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasEvent ? extraEventToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "serHasToConfirm", 0, 15, false) == 0) && (field_name.Length == 16))
                    return (flagHasUserHasToConfirm ? extraUserHasToConfirmToJSON() : null);
                break;
            default:
                break;
          }
        return extraThirdPartyCalendarCreateEventInformationNuggetLookup(field_name);
      }

    public void initConflictingEvents()
      {
        if (flagHasConflictingEvents)
          {
            for (int num1 = 0; num1 < storeConflictingEvents.Count; ++num1)
              {
              }
          }
        flagHasConflictingEvents = true;
        storeConflictingEvents.Clear();
      }
    public void appendConflictingEvents(ThirdPartyCalendarEventJSON  to_append)
      {
        if (!flagHasConflictingEvents)
          {
            flagHasConflictingEvents = true;
            storeConflictingEvents.Clear();
          }
        Debug.Assert(flagHasConflictingEvents);
        storeConflictingEvents.Add(to_append);
      }
    public void unsetConflictingEvents()
      {
        if (flagHasConflictingEvents)
          {
            for (int num2 = 0; num2 < storeConflictingEvents.Count; ++num2)
              {
              }
          }
        flagHasConflictingEvents = false;
        storeConflictingEvents.Clear();
      }
    public void setCreateData(CalendarCreateDataJSON  new_value)
      {
        if (flagHasCreateData)
          {
          }
        flagHasCreateData = true;
        storeCreateData = new_value;
      }
    public void unsetCreateData()
      {
        if (flagHasCreateData)
          {
          }
        flagHasCreateData = false;
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
    public void setConfirmReason(TypeConfirmReason new_value)
      {
        flagHasConfirmReason = true;
        storeConfirmReason = new_value;
      }
    public void setConfirmReason(string chars)
      {
        TypeConfirmReasonKnownValues known = stringToConfirmReason(chars);
        TypeConfirmReason new_value = new TypeConfirmReason();
        if (known == TypeConfirmReasonKnownValues.ConfirmReason__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setConfirmReason(new_value);
      }
    public void setConfirmReason(TypeConfirmReasonKnownValues new_value)
      {
        TypeConfirmReason new_full_value = new TypeConfirmReason();
        Debug.Assert(new_value != TypeConfirmReasonKnownValues.ConfirmReason__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setConfirmReason(new_full_value);
      }
    public void unsetConfirmReason()
      {
        flagHasConfirmReason = false;
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
    public void setCreateType(TypeCreateType new_value)
      {
        flagHasCreateType = true;
        storeCreateType = new_value;
      }
    public void setCreateType(string chars)
      {
        TypeCreateTypeKnownValues known = stringToCreateType(chars);
        TypeCreateType new_value = new TypeCreateType();
        if (known == TypeCreateTypeKnownValues.CreateType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setCreateType(new_value);
      }
    public void setCreateType(TypeCreateTypeKnownValues new_value)
      {
        TypeCreateType new_full_value = new TypeCreateType();
        Debug.Assert(new_value != TypeCreateTypeKnownValues.CreateType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setCreateType(new_full_value);
      }
    public void unsetCreateType()
      {
        flagHasCreateType = false;
      }

    public virtual void extraThirdPartyCalendarCreateEventInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraThirdPartyCalendarCreateEventInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraThirdPartyCalendarCreateEventInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraThirdPartyCalendarCreateEventInformationNuggetAppendPair(key, new_component);
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
            case 'C':
                switch (key[1])
                  {
                    case 'o':
                        if (String.Compare(key, 2, "nf", 0, 2, false) == 0)
                          {
                            switch (key[4])
                              {
                                case 'i':
                                    if ((String.Compare(key, 5, "rmReason", 0, 8, false) == 0) && (key.Length == 13))
                                        {
                                        fromJSONConfirmReason(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'l':
                                    if ((String.Compare(key, 5, "ictingEvents", 0, 12, false) == 0) && (key.Length == 17))
                                        {
                                        fromJSONConflictingEvents(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(key, 2, "eate", 0, 4, false) == 0)
                          {
                            switch (key[6])
                              {
                                case 'D':
                                    if ((String.Compare(key, 7, "ata", 0, 3, false) == 0) && (key.Length == 10))
                                        {
                                        fromJSONCreateData(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 7, "ype", 0, 3, false) == 0) && (key.Length == 10))
                                        {
                                        fromJSONCreateType(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'E':
                if ((String.Compare(key, 1, "vent", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONEvent(new_component, false);
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
        extraThirdPartyCalendarCreateEventInformationNuggetAppendPair(key, new_component);
      }
    public override void extraThirdPartyCalendarInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                switch (key[1])
                  {
                    case 'o':
                        if (String.Compare(key, 2, "nf", 0, 2, false) == 0)
                          {
                            switch (key[4])
                              {
                                case 'i':
                                    if ((String.Compare(key, 5, "rmReason", 0, 8, false) == 0) && (key.Length == 13))
                                        {
                                        fromJSONConfirmReason(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'l':
                                    if ((String.Compare(key, 5, "ictingEvents", 0, 12, false) == 0) && (key.Length == 17))
                                        {
                                        fromJSONConflictingEvents(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(key, 2, "eate", 0, 4, false) == 0)
                          {
                            switch (key[6])
                              {
                                case 'D':
                                    if ((String.Compare(key, 7, "ata", 0, 3, false) == 0) && (key.Length == 10))
                                        {
                                        fromJSONCreateData(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 7, "ype", 0, 3, false) == 0) && (key.Length == 10))
                                        {
                                        fromJSONCreateType(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'E':
                if ((String.Compare(key, 1, "vent", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONEvent(new_component, false);
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
        extraThirdPartyCalendarCreateEventInformationNuggetSetField(key, new_component);
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
        if (flagHasConflictingEvents)
          {
            handler.start_pair("ConflictingEvents");
            handler.start_array();
            for (int num1 = 0; num1 < storeConflictingEvents.Count; ++num1)
              {
                if (partial_allowed)
                    storeConflictingEvents[num1].write_partial_as_json(handler);
                else
                    storeConflictingEvents[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasCreateData)
          {
            handler.start_pair("CreateData");
            if (partial_allowed)
                storeCreateData.write_partial_as_json(handler);
            else
                storeCreateData.write_as_json(handler);
          }
        if (flagHasUserHasToConfirm)
          {
            handler.start_pair("UserHasToConfirm");
            handler.boolean_value(storeUserHasToConfirm);
          }
        if (flagHasConfirmReason)
          {
            handler.start_pair("ConfirmReason");
            if (storeConfirmReason.in_known_list)
              {
                switch (storeConfirmReason.list_value)
                  {
                    case TypeConfirmReasonKnownValues.ConfirmReason_EventConflicts:
                        handler.string_value("EventConflicts");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeConfirmReason.string_value);
              }
          }
        if (flagHasEvent)
          {
            handler.start_pair("Event");
            if (partial_allowed)
                storeEvent.write_partial_as_json(handler);
            else
                storeEvent.write_as_json(handler);
          }
        if (flagHasCreateType)
          {
            handler.start_pair("CreateType");
            if (storeCreateType.in_known_list)
              {
                switch (storeCreateType.list_value)
                  {
                    case TypeCreateTypeKnownValues.CreateType_Normal:
                        handler.string_value("Normal");
                        break;
                    case TypeCreateTypeKnownValues.CreateType_RoomBook:
                        handler.string_value("RoomBook");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeCreateType.string_value);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new ThirdPartyCalendarCreateEventInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarCreateEventInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarCreateEventInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarCreateEventInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarCreateEventInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarCreateEventInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarCreateEventInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarCreateEventInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarCreateEventInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ThirdPartyCalendarCreateEventInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarCreateEventInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ThirdPartyCalendarCreateEventInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ThirdPartyCalendarCreateEventInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ThirdPartyCalendarCreateEventInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarCreateEventInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ThirdPartyCalendarInformationNuggetJSON.Generator
      {
        private ThirdPartyCalendarEventJSON.HoldingArrayGenerator fieldGeneratorConflictingEvents;
        private CalendarCreateDataJSON.HoldingGenerator fieldGeneratorCreateData;
        private JSONHoldingBooleanGenerator fieldGeneratorUserHasToConfirm;
    private abstract class FieldGeneratorConfirmReason : JSONStringGenerator
          {
            protected FieldGeneratorConfirmReason(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorConfirmReason()
              {
              }
            protected override void handle_result(string result)
              {
                TypeConfirmReasonKnownValues known = stringToConfirmReason(result);
                TypeConfirmReason new_value = new TypeConfirmReason();
                if (known == TypeConfirmReasonKnownValues.ConfirmReason__none)
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
            protected abstract void handle_result(TypeConfirmReason result);
          };
    private class FieldHoldingGeneratorConfirmReason : FieldGeneratorConfirmReason
  {
    protected override void handle_result(TypeConfirmReason result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorConfirmReason(String what)
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
    public TypeConfirmReason value;
  };
    private class FieldHoldingArrayGeneratorConfirmReason : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorConfirmReason
      {
        private FieldHoldingArrayGeneratorConfirmReason top;

        protected override void handle_result(TypeConfirmReason result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorConfirmReason init_top)
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
    protected virtual void handle_result(List<TypeConfirmReason> result)
      {
      }

    public FieldHoldingArrayGeneratorConfirmReason(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeConfirmReason>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorConfirmReason()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeConfirmReason>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeConfirmReason> value;
  };
        private FieldHoldingGeneratorConfirmReason fieldGeneratorConfirmReason;
        private ThirdPartyCalendarEventJSON.HoldingGenerator fieldGeneratorEvent;
    private abstract class FieldGeneratorCreateType : JSONStringGenerator
          {
            protected FieldGeneratorCreateType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCreateType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeCreateTypeKnownValues known = stringToCreateType(result);
                TypeCreateType new_value = new TypeCreateType();
                if (known == TypeCreateTypeKnownValues.CreateType__none)
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
            protected abstract void handle_result(TypeCreateType result);
          };
    private class FieldHoldingGeneratorCreateType : FieldGeneratorCreateType
  {
    protected override void handle_result(TypeCreateType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCreateType(String what)
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
    public TypeCreateType value;
  };
    private class FieldHoldingArrayGeneratorCreateType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCreateType
      {
        private FieldHoldingArrayGeneratorCreateType top;

        protected override void handle_result(TypeCreateType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCreateType init_top)
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
    protected virtual void handle_result(List<TypeCreateType> result)
      {
      }

    public FieldHoldingArrayGeneratorCreateType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCreateType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCreateType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCreateType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCreateType> value;
  };
        private FieldHoldingGeneratorCreateType fieldGeneratorCreateType;
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
            if (!(getThirdPartyCalendarInformationNuggetJSONKey().Equals("ThirdPartyCalendarCreateEventInformationNugget")))
                throw new Exception("The key field has a value other than `ThirdPartyCalendarCreateEventInformationNugget'.");
            ThirdPartyCalendarCreateEventInformationNuggetJSON result = new ThirdPartyCalendarCreateEventInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraThirdPartyCalendarCreateEventInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ThirdPartyCalendarInformationNuggetJSON new_result)
          {
            handle_result((ThirdPartyCalendarCreateEventInformationNuggetJSON )new_result);
          }
        protected void finish(ThirdPartyCalendarCreateEventInformationNuggetJSON result)
          {
            if (fieldGeneratorConflictingEvents.have_value)
              {
                result.initConflictingEvents();
                int count = fieldGeneratorConflictingEvents.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendConflictingEvents(fieldGeneratorConflictingEvents.value[num]);
                  }
                fieldGeneratorConflictingEvents.value.Clear();
                fieldGeneratorConflictingEvents.have_value = false;
              }
            if (fieldGeneratorCreateData.have_value)
              {
                result.setCreateData(fieldGeneratorCreateData.value);
                fieldGeneratorCreateData.have_value = false;
              }
            if (fieldGeneratorUserHasToConfirm.have_value)
              {
                result.setUserHasToConfirm(fieldGeneratorUserHasToConfirm.value);
                fieldGeneratorUserHasToConfirm.have_value = false;
              }
            if (fieldGeneratorConfirmReason.have_value)
              {
                result.setConfirmReason(fieldGeneratorConfirmReason.value);
                fieldGeneratorConfirmReason.have_value = false;
              }
            if (fieldGeneratorEvent.have_value)
              {
                result.setEvent(fieldGeneratorEvent.value);
                fieldGeneratorEvent.have_value = false;
              }
            if (fieldGeneratorCreateType.have_value)
              {
                result.setCreateType(fieldGeneratorCreateType.value);
                fieldGeneratorCreateType.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ThirdPartyCalendarCreateEventInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'o':
                            if (String.Compare(field_name, 2, "nf", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'i':
                                        if ((String.Compare(field_name, 5, "rmReason", 0, 8, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorConfirmReason;
                                        break;
                                    case 'l':
                                        if ((String.Compare(field_name, 5, "ictingEvents", 0, 12, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorConflictingEvents;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if (String.Compare(field_name, 2, "eate", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 7, "ata", 0, 3, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorCreateData;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 7, "ype", 0, 3, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorCreateType;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "vent", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorEvent;
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
            fieldGeneratorConflictingEvents = new ThirdPartyCalendarEventJSON.HoldingArrayGenerator("field \"ConflictingEvents\" of the ThirdPartyCalendarCreateEventInformationNugget class", ignore_extras);
            fieldGeneratorCreateData = new CalendarCreateDataJSON.HoldingGenerator("field \"CreateData\" of the ThirdPartyCalendarCreateEventInformationNugget class", ignore_extras);
            fieldGeneratorUserHasToConfirm = new JSONHoldingBooleanGenerator("field \"UserHasToConfirm\" of the ThirdPartyCalendarCreateEventInformationNugget class");
            fieldGeneratorConfirmReason = new FieldHoldingGeneratorConfirmReason("field \"ConfirmReason\" of the ThirdPartyCalendarCreateEventInformationNugget class");
            fieldGeneratorEvent = new ThirdPartyCalendarEventJSON.HoldingGenerator("field \"Event\" of the ThirdPartyCalendarCreateEventInformationNugget class", ignore_extras);
            fieldGeneratorCreateType = new FieldHoldingGeneratorCreateType("field \"CreateType\" of the ThirdPartyCalendarCreateEventInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ThirdPartyCalendarCreateEventInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorConflictingEvents = new ThirdPartyCalendarEventJSON.HoldingArrayGenerator("field \"ConflictingEvents\" of the ThirdPartyCalendarCreateEventInformationNugget class", false);
            fieldGeneratorCreateData = new CalendarCreateDataJSON.HoldingGenerator("field \"CreateData\" of the ThirdPartyCalendarCreateEventInformationNugget class", false);
            fieldGeneratorUserHasToConfirm = new JSONHoldingBooleanGenerator("field \"UserHasToConfirm\" of the ThirdPartyCalendarCreateEventInformationNugget class");
            fieldGeneratorConfirmReason = new FieldHoldingGeneratorConfirmReason("field \"ConfirmReason\" of the ThirdPartyCalendarCreateEventInformationNugget class");
            fieldGeneratorEvent = new ThirdPartyCalendarEventJSON.HoldingGenerator("field \"Event\" of the ThirdPartyCalendarCreateEventInformationNugget class", false);
            fieldGeneratorCreateType = new FieldHoldingGeneratorCreateType("field \"CreateType\" of the ThirdPartyCalendarCreateEventInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ThirdPartyCalendarCreateEventInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorConflictingEvents.reset();
            fieldGeneratorCreateData.reset();
            fieldGeneratorUserHasToConfirm.reset();
            fieldGeneratorConfirmReason.reset();
            fieldGeneratorEvent.reset();
            fieldGeneratorCreateType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ThirdPartyCalendarCreateEventInformationNuggetJSON  result)
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
        public ThirdPartyCalendarCreateEventInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ThirdPartyCalendarCreateEventInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ThirdPartyCalendarCreateEventInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ThirdPartyCalendarCreateEventInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ThirdPartyCalendarCreateEventInformationNuggetJSON>();
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
    public List<ThirdPartyCalendarCreateEventInformationNuggetJSON> value;
  };
  };
