/* file "ThirdPartyCalendarEventJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class ThirdPartyCalendarEventJSON : JSONBase
  {
    public enum TypeSelfAttendeeStatus
      {
        SelfAttendeeStatus_None,
        SelfAttendeeStatus_Accepted,
        SelfAttendeeStatus_Declined,
        SelfAttendeeStatus_Invited,
        SelfAttendeeStatus_Tentative
      };

    public static TypeSelfAttendeeStatus  stringToSelfAttendeeStatus(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ccepted", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "eclined", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nvited", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeSelfAttendeeStatus.SelfAttendeeStatus_None;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "entative", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `SelfAttendeeStatus' is not one of the legal values.");
      }

    public static string  stringFromSelfAttendeeStatus(TypeSelfAttendeeStatus the_enum)
      {
        switch (the_enum)
          {
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_None:
                return "None";
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted:
                return "Accepted";
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined:
                return "Declined";
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited:
                return "Invited";
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative:
                return "Tentative";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeFrequencyType
      {
        FrequencyType_unknown,
        FrequencyType_one_time,
        FrequencyType_daily,
        FrequencyType_weekly,
        FrequencyType_monthly,
        FrequencyType_yearly
      };

    public static TypeFrequencyType  stringToFrequencyType(string chars)
      {
        switch (chars[0])
          {
            case 'd':
                if ((String.Compare(chars, 1, "aily", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeFrequencyType.FrequencyType_daily;
                break;
            case 'm':
                if ((String.Compare(chars, 1, "onthly", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeFrequencyType.FrequencyType_monthly;
                break;
            case 'o':
                if ((String.Compare(chars, 1, "ne-time", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeFrequencyType.FrequencyType_one_time;
                break;
            case 'u':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeFrequencyType.FrequencyType_unknown;
                break;
            case 'w':
                if ((String.Compare(chars, 1, "eekly", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeFrequencyType.FrequencyType_weekly;
                break;
            case 'y':
                if ((String.Compare(chars, 1, "early", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeFrequencyType.FrequencyType_yearly;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `FrequencyType' is not one of the legal values.");
      }

    public static string  stringFromFrequencyType(TypeFrequencyType the_enum)
      {
        switch (the_enum)
          {
            case TypeFrequencyType.FrequencyType_unknown:
                return "unknown";
            case TypeFrequencyType.FrequencyType_one_time:
                return "one-time";
            case TypeFrequencyType.FrequencyType_daily:
                return "daily";
            case TypeFrequencyType.FrequencyType_weekly:
                return "weekly";
            case TypeFrequencyType.FrequencyType_monthly:
                return "monthly";
            case TypeFrequencyType.FrequencyType_yearly:
                return "yearly";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCalendarID;
    private string storeCalendarID;
    private bool flagHasEventID;
    private string storeEventID;
    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasLocation;
    private string storeLocation;
    private bool flagHasDescription;
    private string storeDescription;
    private bool flagHasStartDateTime;
    private DateAndOrTimeJSON  storeStartDateTime;
    private bool flagHasEndDateTime;
    private DateAndOrTimeJSON  storeEndDateTime;
    private bool flagHasIsAllDay;
    private bool storeIsAllDay;
    private bool flagHasOrganiser;
    private CalendarAttendeeJSON  storeOrganiser;
    private bool flagHasAttendees;
    private List< CalendarAttendeeJSON  > storeAttendees;
    private bool flagHasReminders;
    private List< CalendarReminderJSON  > storeReminders;
    private bool flagHasSelfAttendeeStatus;
    private TypeSelfAttendeeStatus storeSelfAttendeeStatus;
    private bool flagHasFrequencyType;
    private TypeFrequencyType storeFrequencyType;
    private bool flagHasFrequencyMultiplier;
    private BigInteger storeFrequencyMultiplier;
    private bool flagHasFrequencyArgument;
    private BigInteger storeFrequencyArgument;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCalendarID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CalendarID of ThirdPartyCalendarEventJSON is not a string.");
        setCalendarID(json_string.getData());
      }


    private void  fromJSONEventID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EventID of ThirdPartyCalendarEventJSON is not a string.");
        setEventID(json_string.getData());
      }


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of ThirdPartyCalendarEventJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Location of ThirdPartyCalendarEventJSON is not a string.");
        setLocation(json_string.getData());
      }


    private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Description of ThirdPartyCalendarEventJSON is not a string.");
        setDescription(json_string.getData());
      }


    private void  fromJSONStartDateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStartDateTime(convert_classy);
      }


    private void  fromJSONEndDateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setEndDateTime(convert_classy);
      }


    private void  fromJSONIsAllDay(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsAllDay of ThirdPartyCalendarEventJSON is not true for false.");
              }
          }
        setIsAllDay(the_bool);
      }


    private void  fromJSONOrganiser(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CalendarAttendeeJSON convert_classy = CalendarAttendeeJSON.from_json(json_value, ignore_extras, true);
        setOrganiser(convert_classy);
      }


    private void  fromJSONAttendees(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Attendees of ThirdPartyCalendarEventJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Attendees of ThirdPartyCalendarEventJSON has too few elements.");
        List< CalendarAttendeeJSON  > vector_Attendees1 = new List< CalendarAttendeeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CalendarAttendeeJSON convert_classy = CalendarAttendeeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Attendees1.Add(convert_classy);
          }
        Debug.Assert(vector_Attendees1.Count >= 1);
        initAttendees();
        for (int num1 = 0; num1 < vector_Attendees1.Count; ++num1)
            appendAttendees(vector_Attendees1[num1]);
        for (int num1 = 0; num1 < vector_Attendees1.Count; ++num1)
          {
          }
      }


    private void  fromJSONReminders(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Reminders of ThirdPartyCalendarEventJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< CalendarReminderJSON  > vector_Reminders1 = new List< CalendarReminderJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CalendarReminderJSON convert_classy = CalendarReminderJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Reminders1.Add(convert_classy);
          }
        initReminders();
        for (int num2 = 0; num2 < vector_Reminders1.Count; ++num2)
            appendReminders(vector_Reminders1[num2]);
        for (int num1 = 0; num1 < vector_Reminders1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSelfAttendeeStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SelfAttendeeStatus of ThirdPartyCalendarEventJSON is not a string.");
        TypeSelfAttendeeStatus the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ccepted", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "eclined", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined;
                        goto enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nvited", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_None;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "entative", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field SelfAttendeeStatus of ThirdPartyCalendarEventJSON is not one of the legal strings.");
      enum_is_done:;
        setSelfAttendeeStatus(the_enum);
      }


    private void  fromJSONFrequencyType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FrequencyType of ThirdPartyCalendarEventJSON is not a string.");
        TypeFrequencyType the_enum;
        switch (json_string.getData()[0])
          {
            case 'd':
                if ((String.Compare(json_string.getData(), 1, "aily", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeFrequencyType.FrequencyType_daily;
                        goto enum_is_done;
                      }
                break;
            case 'm':
                if ((String.Compare(json_string.getData(), 1, "onthly", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeFrequencyType.FrequencyType_monthly;
                        goto enum_is_done;
                      }
                break;
            case 'o':
                if ((String.Compare(json_string.getData(), 1, "ne-time", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeFrequencyType.FrequencyType_one_time;
                        goto enum_is_done;
                      }
                break;
            case 'u':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeFrequencyType.FrequencyType_unknown;
                        goto enum_is_done;
                      }
                break;
            case 'w':
                if ((String.Compare(json_string.getData(), 1, "eekly", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeFrequencyType.FrequencyType_weekly;
                        goto enum_is_done;
                      }
                break;
            case 'y':
                if ((String.Compare(json_string.getData(), 1, "early", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeFrequencyType.FrequencyType_yearly;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field FrequencyType of ThirdPartyCalendarEventJSON is not one of the legal strings.");
      enum_is_done:;
        setFrequencyType(the_enum);
      }


    private void  fromJSONFrequencyMultiplier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FrequencyMultiplier of ThirdPartyCalendarEventJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FrequencyMultiplier of ThirdPartyCalendarEventJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFrequencyMultiplier(extracted_integer);
      }


    private void  fromJSONFrequencyArgument(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FrequencyArgument of ThirdPartyCalendarEventJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FrequencyArgument of ThirdPartyCalendarEventJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFrequencyArgument(extracted_integer);
      }


    public ThirdPartyCalendarEventJSON()
      {
        flagHasCalendarID = false;
        flagHasEventID = false;
        flagHasTitle = false;
        flagHasLocation = false;
        flagHasDescription = false;
        flagHasStartDateTime = false;
        flagHasEndDateTime = false;
        flagHasIsAllDay = false;
        flagHasOrganiser = false;
        flagHasAttendees = false;
        flagHasReminders = false;
        flagHasSelfAttendeeStatus = false;
        flagHasFrequencyType = false;
        flagHasFrequencyMultiplier = false;
        flagHasFrequencyArgument = false;
        storeAttendees = new List< CalendarAttendeeJSON  >();
        storeReminders = new List< CalendarReminderJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCalendarID()
      {
        return flagHasCalendarID;
      }

    public string  getCalendarID()
      {
        Debug.Assert(flagHasCalendarID);
        return storeCalendarID;
      }

    public bool  hasEventID()
      {
        return flagHasEventID;
      }

    public string  getEventID()
      {
        Debug.Assert(flagHasEventID);
        return storeEventID;
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

    public bool  hasDescription()
      {
        return flagHasDescription;
      }

    public string  getDescription()
      {
        Debug.Assert(flagHasDescription);
        return storeDescription;
      }

    public bool  hasStartDateTime()
      {
        return flagHasStartDateTime;
      }

    public DateAndOrTimeJSON   getStartDateTime()
      {
        Debug.Assert(flagHasStartDateTime);
        return storeStartDateTime;
      }

    public bool  hasEndDateTime()
      {
        return flagHasEndDateTime;
      }

    public DateAndOrTimeJSON   getEndDateTime()
      {
        Debug.Assert(flagHasEndDateTime);
        return storeEndDateTime;
      }

    public bool  hasIsAllDay()
      {
        return flagHasIsAllDay;
      }

    public bool  getIsAllDay()
      {
        Debug.Assert(flagHasIsAllDay);
        return storeIsAllDay;
      }

    public bool  hasOrganiser()
      {
        return flagHasOrganiser;
      }

    public CalendarAttendeeJSON   getOrganiser()
      {
        Debug.Assert(flagHasOrganiser);
        return storeOrganiser;
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

    public bool  hasReminders()
      {
        return flagHasReminders;
      }

    public int  countOfReminders()
      {
        Debug.Assert(flagHasReminders);
        return storeReminders.Count;
      }

    public CalendarReminderJSON   elementOfReminders(int element_num)
      {
        Debug.Assert(flagHasReminders);
        return storeReminders[element_num];
      }

    public List< CalendarReminderJSON  >  getReminders()
      {
        Debug.Assert(flagHasReminders);
        return storeReminders;
      }

    public bool  hasSelfAttendeeStatus()
      {
        return flagHasSelfAttendeeStatus;
      }

    public TypeSelfAttendeeStatus  getSelfAttendeeStatus()
      {
        Debug.Assert(flagHasSelfAttendeeStatus);
        return storeSelfAttendeeStatus;
      }

    public string  getSelfAttendeeStatusAsString()
      {
        return stringFromSelfAttendeeStatus(getSelfAttendeeStatus());
      }

    public bool  hasFrequencyType()
      {
        return flagHasFrequencyType;
      }

    public TypeFrequencyType  getFrequencyType()
      {
        Debug.Assert(flagHasFrequencyType);
        return storeFrequencyType;
      }

    public string  getFrequencyTypeAsString()
      {
        return stringFromFrequencyType(getFrequencyType());
      }

    public bool  hasFrequencyMultiplier()
      {
        return flagHasFrequencyMultiplier;
      }

    public BigInteger  getFrequencyMultiplier()
      {
        Debug.Assert(flagHasFrequencyMultiplier);
        return storeFrequencyMultiplier;
      }

    public bool  hasFrequencyArgument()
      {
        return flagHasFrequencyArgument;
      }

    public BigInteger  getFrequencyArgument()
      {
        Debug.Assert(flagHasFrequencyArgument);
        return storeFrequencyArgument;
      }


    public virtual int extraThirdPartyCalendarEventComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraThirdPartyCalendarEventComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarEventComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarEventLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setCalendarID(string new_value)
      {
        flagHasCalendarID = true;
        storeCalendarID = new_value;
      }
    public void unsetCalendarID()
      {
        flagHasCalendarID = false;
      }
    public void setEventID(string new_value)
      {
        flagHasEventID = true;
        storeEventID = new_value;
      }
    public void unsetEventID()
      {
        flagHasEventID = false;
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
    public void setDescription(string new_value)
      {
        flagHasDescription = true;
        storeDescription = new_value;
      }
    public void unsetDescription()
      {
        flagHasDescription = false;
      }
    public void setStartDateTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStartDateTime)
          {
          }
        flagHasStartDateTime = true;
        storeStartDateTime = new_value;
      }
    public void unsetStartDateTime()
      {
        if (flagHasStartDateTime)
          {
          }
        flagHasStartDateTime = false;
      }
    public void setEndDateTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasEndDateTime)
          {
          }
        flagHasEndDateTime = true;
        storeEndDateTime = new_value;
      }
    public void unsetEndDateTime()
      {
        if (flagHasEndDateTime)
          {
          }
        flagHasEndDateTime = false;
      }
    public void setIsAllDay(bool new_value)
      {
        flagHasIsAllDay = true;
        storeIsAllDay = new_value;
      }
    public void unsetIsAllDay()
      {
        flagHasIsAllDay = false;
      }
    public void setOrganiser(CalendarAttendeeJSON  new_value)
      {
        if (flagHasOrganiser)
          {
          }
        flagHasOrganiser = true;
        storeOrganiser = new_value;
      }
    public void unsetOrganiser()
      {
        if (flagHasOrganiser)
          {
          }
        flagHasOrganiser = false;
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
    public void initReminders()
      {
        if (flagHasReminders)
          {
            for (int num3 = 0; num3 < storeReminders.Count; ++num3)
              {
              }
          }
        flagHasReminders = true;
        storeReminders.Clear();
      }
    public void appendReminders(CalendarReminderJSON  to_append)
      {
        if (!flagHasReminders)
          {
            flagHasReminders = true;
            storeReminders.Clear();
          }
        Debug.Assert(flagHasReminders);
        storeReminders.Add(to_append);
      }
    public void unsetReminders()
      {
        if (flagHasReminders)
          {
            for (int num4 = 0; num4 < storeReminders.Count; ++num4)
              {
              }
          }
        flagHasReminders = false;
        storeReminders.Clear();
      }
    public void setSelfAttendeeStatus(TypeSelfAttendeeStatus new_value)
      {
        flagHasSelfAttendeeStatus = true;
        storeSelfAttendeeStatus = new_value;
      }
    public void setSelfAttendeeStatus(string chars)
      {
        setSelfAttendeeStatus(stringToSelfAttendeeStatus(chars));
      }
    public void unsetSelfAttendeeStatus()
      {
        flagHasSelfAttendeeStatus = false;
      }
    public void setFrequencyType(TypeFrequencyType new_value)
      {
        flagHasFrequencyType = true;
        storeFrequencyType = new_value;
      }
    public void setFrequencyType(string chars)
      {
        setFrequencyType(stringToFrequencyType(chars));
      }
    public void unsetFrequencyType()
      {
        flagHasFrequencyType = false;
      }
    public void setFrequencyMultiplier(BigInteger new_value)
      {
        flagHasFrequencyMultiplier = true;
        if (new_value < 1)
            throw new Exception("The value for field FrequencyMultiplier of ThirdPartyCalendarEventJSON is less than the lower bound (1) for that field.");
        storeFrequencyMultiplier = new_value;
      }
    public void unsetFrequencyMultiplier()
      {
        flagHasFrequencyMultiplier = false;
      }
    public void setFrequencyArgument(BigInteger new_value)
      {
        flagHasFrequencyArgument = true;
        if (new_value < 0)
            throw new Exception("The value for field FrequencyArgument of ThirdPartyCalendarEventJSON is less than the lower bound (0) for that field.");
        storeFrequencyArgument = new_value;
      }
    public void unsetFrequencyArgument()
      {
        flagHasFrequencyArgument = false;
      }

    public virtual void extraThirdPartyCalendarEventAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraThirdPartyCalendarEventSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraThirdPartyCalendarEventLookup(key);
        if (old_field == null)
          {
            extraThirdPartyCalendarEventAppendPair(key, new_component);
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
        if (flagHasCalendarID)
          {
            handler.start_pair("CalendarID");
            handler.string_value(storeCalendarID);
          }
        if (flagHasEventID)
          {
            handler.start_pair("EventID");
            handler.string_value(storeEventID);
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
        if (flagHasDescription)
          {
            handler.start_pair("Description");
            handler.string_value(storeDescription);
          }
        if (flagHasStartDateTime)
          {
            handler.start_pair("StartDateTime");
            if (partial_allowed)
                storeStartDateTime.write_partial_as_json(handler);
            else
                storeStartDateTime.write_as_json(handler);
          }
        if (flagHasEndDateTime)
          {
            handler.start_pair("EndDateTime");
            if (partial_allowed)
                storeEndDateTime.write_partial_as_json(handler);
            else
                storeEndDateTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasIsAllDay);
        if (flagHasIsAllDay)
          {
            handler.start_pair("IsAllDay");
            handler.boolean_value(storeIsAllDay);
          }
        if (flagHasOrganiser)
          {
            handler.start_pair("Organiser");
            if (partial_allowed)
                storeOrganiser.write_partial_as_json(handler);
            else
                storeOrganiser.write_as_json(handler);
          }
        if (flagHasAttendees)
          {
            handler.start_pair("Attendees");
            Debug.Assert(storeAttendees.Count >= 1);
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
        if (flagHasReminders)
          {
            handler.start_pair("Reminders");
            handler.start_array();
            for (int num2 = 0; num2 < storeReminders.Count; ++num2)
              {
                if (partial_allowed)
                    storeReminders[num2].write_partial_as_json(handler);
                else
                    storeReminders[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSelfAttendeeStatus)
          {
            handler.start_pair("SelfAttendeeStatus");
            switch (storeSelfAttendeeStatus)
              {
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_None:
                    handler.string_value("None");
                    break;
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted:
                    handler.string_value("Accepted");
                    break;
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined:
                    handler.string_value("Declined");
                    break;
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited:
                    handler.string_value("Invited");
                    break;
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative:
                    handler.string_value("Tentative");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasFrequencyType)
          {
            handler.start_pair("FrequencyType");
            switch (storeFrequencyType)
              {
                case TypeFrequencyType.FrequencyType_unknown:
                    handler.string_value("unknown");
                    break;
                case TypeFrequencyType.FrequencyType_one_time:
                    handler.string_value("one-time");
                    break;
                case TypeFrequencyType.FrequencyType_daily:
                    handler.string_value("daily");
                    break;
                case TypeFrequencyType.FrequencyType_weekly:
                    handler.string_value("weekly");
                    break;
                case TypeFrequencyType.FrequencyType_monthly:
                    handler.string_value("monthly");
                    break;
                case TypeFrequencyType.FrequencyType_yearly:
                    handler.string_value("yearly");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasFrequencyMultiplier)
          {
            handler.start_pair("FrequencyMultiplier");
            handler.number_value(storeFrequencyMultiplier);
          }
        if (flagHasFrequencyArgument)
          {
            handler.start_pair("FrequencyArgument");
            handler.number_value(storeFrequencyArgument);
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
        if (!(hasIsAllDay()))
          {
            return "When parsing the object for %what%, the \"IsAllDay\" field was missing.";
          }
        return null;
      }

    public static ThirdPartyCalendarEventJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarEvent", ignore_extras);
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
    public static ThirdPartyCalendarEventJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ThirdPartyCalendarEventJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarEvent", ignore_extras);
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
    public static ThirdPartyCalendarEventJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ThirdPartyCalendarEventJSON from_text(string text, bool ignore_extras)
      {
        ThirdPartyCalendarEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarEvent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ThirdPartyCalendarEventJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ThirdPartyCalendarEventJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ThirdPartyCalendarEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarEvent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorCalendarID;
        private JSONHoldingStringGenerator fieldGeneratorEventID;
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingStringGenerator fieldGeneratorLocation;
        private JSONHoldingStringGenerator fieldGeneratorDescription;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartDateTime;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndDateTime;
        private JSONHoldingBooleanGenerator fieldGeneratorIsAllDay;
        private CalendarAttendeeJSON.HoldingGenerator fieldGeneratorOrganiser;
        private CalendarAttendeeJSON.HoldingArrayGenerator fieldGeneratorAttendees;
        private CalendarReminderJSON.HoldingArrayGenerator fieldGeneratorReminders;
    private abstract class FieldGeneratorSelfAttendeeStatus : JSONStringGenerator
          {
            protected FieldGeneratorSelfAttendeeStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSelfAttendeeStatus()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToSelfAttendeeStatus(result));
              }
            protected abstract void handle_result(TypeSelfAttendeeStatus result);
          };
    private class FieldHoldingGeneratorSelfAttendeeStatus : FieldGeneratorSelfAttendeeStatus
  {
    protected override void handle_result(TypeSelfAttendeeStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSelfAttendeeStatus(String what)
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
    public TypeSelfAttendeeStatus value;
  };
    private class FieldHoldingArrayGeneratorSelfAttendeeStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSelfAttendeeStatus
      {
        private FieldHoldingArrayGeneratorSelfAttendeeStatus top;

        protected override void handle_result(TypeSelfAttendeeStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSelfAttendeeStatus init_top)
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
    protected virtual void handle_result(List<TypeSelfAttendeeStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorSelfAttendeeStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSelfAttendeeStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSelfAttendeeStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSelfAttendeeStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSelfAttendeeStatus> value;
  };
        private FieldHoldingGeneratorSelfAttendeeStatus fieldGeneratorSelfAttendeeStatus;
    private abstract class FieldGeneratorFrequencyType : JSONStringGenerator
          {
            protected FieldGeneratorFrequencyType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFrequencyType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToFrequencyType(result));
              }
            protected abstract void handle_result(TypeFrequencyType result);
          };
    private class FieldHoldingGeneratorFrequencyType : FieldGeneratorFrequencyType
  {
    protected override void handle_result(TypeFrequencyType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFrequencyType(String what)
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
    public TypeFrequencyType value;
  };
    private class FieldHoldingArrayGeneratorFrequencyType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFrequencyType
      {
        private FieldHoldingArrayGeneratorFrequencyType top;

        protected override void handle_result(TypeFrequencyType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFrequencyType init_top)
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
    protected virtual void handle_result(List<TypeFrequencyType> result)
      {
      }

    public FieldHoldingArrayGeneratorFrequencyType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFrequencyType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFrequencyType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFrequencyType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFrequencyType> value;
  };
        private FieldHoldingGeneratorFrequencyType fieldGeneratorFrequencyType;
    private class FieldHoldingGeneratorFrequencyMultiplier : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorFrequencyMultiplier(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorFrequencyMultiplier : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorFrequencyMultiplier(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorFrequencyMultiplier fieldGeneratorFrequencyMultiplier;
    private class FieldHoldingGeneratorFrequencyArgument : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorFrequencyArgument(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorFrequencyArgument : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorFrequencyArgument(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorFrequencyArgument fieldGeneratorFrequencyArgument;
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
            ThirdPartyCalendarEventJSON result = new ThirdPartyCalendarEventJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraThirdPartyCalendarEventAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ThirdPartyCalendarEventJSON result)
          {
            if (fieldGeneratorCalendarID.have_value)
              {
                result.setCalendarID(fieldGeneratorCalendarID.value);
                fieldGeneratorCalendarID.have_value = false;
              }
            if (fieldGeneratorEventID.have_value)
              {
                result.setEventID(fieldGeneratorEventID.value);
                fieldGeneratorEventID.have_value = false;
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
            if (fieldGeneratorDescription.have_value)
              {
                result.setDescription(fieldGeneratorDescription.value);
                fieldGeneratorDescription.have_value = false;
              }
            if (fieldGeneratorStartDateTime.have_value)
              {
                result.setStartDateTime(fieldGeneratorStartDateTime.value);
                fieldGeneratorStartDateTime.have_value = false;
              }
            if (fieldGeneratorEndDateTime.have_value)
              {
                result.setEndDateTime(fieldGeneratorEndDateTime.value);
                fieldGeneratorEndDateTime.have_value = false;
              }
            if (fieldGeneratorIsAllDay.have_value)
              {
                result.setIsAllDay(fieldGeneratorIsAllDay.value);
                fieldGeneratorIsAllDay.have_value = false;
              }
            else if ((!(result.hasIsAllDay())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsAllDay\" field was missing.");
              }
            if (fieldGeneratorOrganiser.have_value)
              {
                result.setOrganiser(fieldGeneratorOrganiser.value);
                fieldGeneratorOrganiser.have_value = false;
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
            if (fieldGeneratorReminders.have_value)
              {
                result.initReminders();
                int count = fieldGeneratorReminders.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendReminders(fieldGeneratorReminders.value[num]);
                  }
                fieldGeneratorReminders.value.Clear();
                fieldGeneratorReminders.have_value = false;
              }
            if (fieldGeneratorSelfAttendeeStatus.have_value)
              {
                result.setSelfAttendeeStatus(fieldGeneratorSelfAttendeeStatus.value);
                fieldGeneratorSelfAttendeeStatus.have_value = false;
              }
            if (fieldGeneratorFrequencyType.have_value)
              {
                result.setFrequencyType(fieldGeneratorFrequencyType.value);
                fieldGeneratorFrequencyType.have_value = false;
              }
            if (fieldGeneratorFrequencyMultiplier.have_value)
              {
                result.setFrequencyMultiplier(fieldGeneratorFrequencyMultiplier.value);
                fieldGeneratorFrequencyMultiplier.have_value = false;
              }
            if (fieldGeneratorFrequencyArgument.have_value)
              {
                result.setFrequencyArgument(fieldGeneratorFrequencyArgument.value);
                fieldGeneratorFrequencyArgument.have_value = false;
              }
          }
        protected abstract void handle_result(ThirdPartyCalendarEventJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttendees", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorAttendees;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "alendarID", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorCalendarID;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "escription", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDescription;
                    break;
                case 'E':
                    switch (field_name[1])
                      {
                        case 'n':
                            if ((String.Compare(field_name, 2, "dDateTime", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorEndDateTime;
                            break;
                        case 'v':
                            if ((String.Compare(field_name, 2, "entID", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorEventID;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    if (String.Compare(field_name, 1, "requency", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 10, "rgument", 0, 7, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorFrequencyArgument;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 10, "ultiplier", 0, 9, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorFrequencyMultiplier;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 10, "ype", 0, 3, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorFrequencyType;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sAllDay", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorIsAllDay;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLocation;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "rganiser", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorOrganiser;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "eminders", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorReminders;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "lfAttendeeStatus", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorSelfAttendeeStatus;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "artDateTime", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorStartDateTime;
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
            fieldGeneratorCalendarID = new JSONHoldingStringGenerator("field \"CalendarID\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorEventID = new JSONHoldingStringGenerator("field \"EventID\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorLocation = new JSONHoldingStringGenerator("field \"Location\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorStartDateTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateTime\" of the ThirdPartyCalendarEvent class", ignore_extras);
            fieldGeneratorEndDateTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateTime\" of the ThirdPartyCalendarEvent class", ignore_extras);
            fieldGeneratorIsAllDay = new JSONHoldingBooleanGenerator("field \"IsAllDay\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorOrganiser = new CalendarAttendeeJSON.HoldingGenerator("field \"Organiser\" of the ThirdPartyCalendarEvent class", ignore_extras);
            fieldGeneratorAttendees = new CalendarAttendeeJSON.HoldingArrayGenerator("field \"Attendees\" of the ThirdPartyCalendarEvent class", ignore_extras);
            fieldGeneratorReminders = new CalendarReminderJSON.HoldingArrayGenerator("field \"Reminders\" of the ThirdPartyCalendarEvent class", ignore_extras);
            fieldGeneratorSelfAttendeeStatus = new FieldHoldingGeneratorSelfAttendeeStatus("field \"SelfAttendeeStatus\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorFrequencyType = new FieldHoldingGeneratorFrequencyType("field \"FrequencyType\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorFrequencyMultiplier = new FieldHoldingGeneratorFrequencyMultiplier("field \"FrequencyMultiplier\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorFrequencyArgument = new FieldHoldingGeneratorFrequencyArgument("field \"FrequencyArgument\" of the ThirdPartyCalendarEvent class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ThirdPartyCalendarEvent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCalendarID = new JSONHoldingStringGenerator("field \"CalendarID\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorEventID = new JSONHoldingStringGenerator("field \"EventID\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorLocation = new JSONHoldingStringGenerator("field \"Location\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorStartDateTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateTime\" of the ThirdPartyCalendarEvent class", false);
            fieldGeneratorEndDateTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateTime\" of the ThirdPartyCalendarEvent class", false);
            fieldGeneratorIsAllDay = new JSONHoldingBooleanGenerator("field \"IsAllDay\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorOrganiser = new CalendarAttendeeJSON.HoldingGenerator("field \"Organiser\" of the ThirdPartyCalendarEvent class", false);
            fieldGeneratorAttendees = new CalendarAttendeeJSON.HoldingArrayGenerator("field \"Attendees\" of the ThirdPartyCalendarEvent class", false);
            fieldGeneratorReminders = new CalendarReminderJSON.HoldingArrayGenerator("field \"Reminders\" of the ThirdPartyCalendarEvent class", false);
            fieldGeneratorSelfAttendeeStatus = new FieldHoldingGeneratorSelfAttendeeStatus("field \"SelfAttendeeStatus\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorFrequencyType = new FieldHoldingGeneratorFrequencyType("field \"FrequencyType\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorFrequencyMultiplier = new FieldHoldingGeneratorFrequencyMultiplier("field \"FrequencyMultiplier\" of the ThirdPartyCalendarEvent class");
            fieldGeneratorFrequencyArgument = new FieldHoldingGeneratorFrequencyArgument("field \"FrequencyArgument\" of the ThirdPartyCalendarEvent class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ThirdPartyCalendarEvent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCalendarID.reset();
            fieldGeneratorEventID.reset();
            fieldGeneratorTitle.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorDescription.reset();
            fieldGeneratorStartDateTime.reset();
            fieldGeneratorEndDateTime.reset();
            fieldGeneratorIsAllDay.reset();
            fieldGeneratorOrganiser.reset();
            fieldGeneratorAttendees.reset();
            fieldGeneratorReminders.reset();
            fieldGeneratorSelfAttendeeStatus.reset();
            fieldGeneratorFrequencyType.reset();
            fieldGeneratorFrequencyMultiplier.reset();
            fieldGeneratorFrequencyArgument.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorStartDateTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEndDateTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOrganiser.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAttendees.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorReminders.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorStartDateTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEndDateTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOrganiser.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAttendees.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorReminders.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ThirdPartyCalendarEventJSON  result)
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
        public ThirdPartyCalendarEventJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ThirdPartyCalendarEventJSON  result)
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
    protected virtual void handle_result(List<ThirdPartyCalendarEventJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ThirdPartyCalendarEventJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ThirdPartyCalendarEventJSON>();
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
    public List<ThirdPartyCalendarEventJSON> value;
  };
  };
