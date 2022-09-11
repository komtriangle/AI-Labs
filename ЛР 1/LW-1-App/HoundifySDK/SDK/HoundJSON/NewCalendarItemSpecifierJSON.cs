/* file "NewCalendarItemSpecifierJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class NewCalendarItemSpecifierJSON : JSONBase
  {
    public enum TypeFrequencyTypeKnownValues
      {
        FrequencyType_Unknown,
        FrequencyType_One_Time,
        FrequencyType_Daily,
        FrequencyType_Weekly,
        FrequencyType_Monthly,
        FrequencyType_Yearly,
        FrequencyType__none
      };
    public struct TypeFrequencyType
      {
        public bool in_known_list;
        public string string_value;
        public TypeFrequencyTypeKnownValues list_value;
      };

    public static TypeFrequencyTypeKnownValues  stringToFrequencyType(string chars)
      {
        switch (chars[0])
          {
            case 'D':
                if ((String.Compare(chars, 1, "aily", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeFrequencyTypeKnownValues.FrequencyType_Daily;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "onthly", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeFrequencyTypeKnownValues.FrequencyType_Monthly;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "ne-Time", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeFrequencyTypeKnownValues.FrequencyType_One_Time;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeFrequencyTypeKnownValues.FrequencyType_Unknown;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "eekly", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeFrequencyTypeKnownValues.FrequencyType_Weekly;
                break;
            case 'Y':
                if ((String.Compare(chars, 1, "early", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeFrequencyTypeKnownValues.FrequencyType_Yearly;
                break;
            default:
                break;
          }
        return TypeFrequencyTypeKnownValues.FrequencyType__none;
      }

    public static string  stringFromFrequencyType(TypeFrequencyTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeFrequencyTypeKnownValues.FrequencyType_Unknown:
                return "Unknown";
            case TypeFrequencyTypeKnownValues.FrequencyType_One_Time:
                return "One-Time";
            case TypeFrequencyTypeKnownValues.FrequencyType_Daily:
                return "Daily";
            case TypeFrequencyTypeKnownValues.FrequencyType_Weekly:
                return "Weekly";
            case TypeFrequencyTypeKnownValues.FrequencyType_Monthly:
                return "Monthly";
            case TypeFrequencyTypeKnownValues.FrequencyType_Yearly:
                return "Yearly";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeSelfAttendeeStatusKnownValues
      {
        SelfAttendeeStatus_Accepted,
        SelfAttendeeStatus_Declined,
        SelfAttendeeStatus_Invited,
        SelfAttendeeStatus_Tentative,
        SelfAttendeeStatus__none
      };
    public struct TypeSelfAttendeeStatus
      {
        public bool in_known_list;
        public string string_value;
        public TypeSelfAttendeeStatusKnownValues list_value;
      };

    public static TypeSelfAttendeeStatusKnownValues  stringToSelfAttendeeStatus(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ccepted", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus_Accepted;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "eclined", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus_Declined;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nvited", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus_Invited;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "entative", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus_Tentative;
                break;
            default:
                break;
          }
        return TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus__none;
      }

    public static string  stringFromSelfAttendeeStatus(TypeSelfAttendeeStatusKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus_Accepted:
                return "Accepted";
            case TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus_Declined:
                return "Declined";
            case TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus_Invited:
                return "Invited";
            case TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus_Tentative:
                return "Tentative";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasLocation;
    private string storeLocation;
    private bool flagHasLocationSpecifier;
    private CalendarLocationJSON  storeLocationSpecifier;
    private bool flagHasRange;
    private DateTimeRangeSpecJSON  storeRange;
    private bool flagHasAttendees;
    private List< CalendarAttendeeJSON  > storeAttendees;
    private bool flagHasClientShouldFindAppropriateTime;
    private bool storeClientShouldFindAppropriateTime;
    private bool flagHasFrequencyType;
    private TypeFrequencyType storeFrequencyType;
    private bool flagHasFrequencyArgument;
    private BigInteger storeFrequencyArgument;
    private bool flagHasFrequencyMultiplier;
    private BigInteger storeFrequencyMultiplier;
    private bool flagHasIsAllDay;
    private bool storeIsAllDay;
    private bool flagHasSelfAttendeeStatus;
    private TypeSelfAttendeeStatus storeSelfAttendeeStatus;
    private bool flagHasReminders;
    private List< CalendarReminderJSON  > storeReminders;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of NewCalendarItemSpecifierJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Location of NewCalendarItemSpecifierJSON is not a string.");
        setLocation(json_string.getData());
      }


    private void  fromJSONLocationSpecifier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CalendarLocationJSON convert_classy = CalendarLocationJSON.from_json(json_value, ignore_extras, true);
        setLocationSpecifier(convert_classy);
      }


    private void  fromJSONRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setRange(convert_classy);
      }


    private void  fromJSONAttendees(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Attendees of NewCalendarItemSpecifierJSON is not an array.");
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


    private void  fromJSONClientShouldFindAppropriateTime(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ClientShouldFindAppropriateTime of NewCalendarItemSpecifierJSON is not true for false.");
              }
          }
        setClientShouldFindAppropriateTime(the_bool);
      }


    private void  fromJSONFrequencyType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FrequencyType of NewCalendarItemSpecifierJSON is not a string.");
        TypeFrequencyType the_open_enum = new TypeFrequencyType();
        switch (json_string.getData()[0])
          {
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "aily", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeFrequencyTypeKnownValues.FrequencyType_Daily;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "onthly", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeFrequencyTypeKnownValues.FrequencyType_Monthly;
                        goto open_enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "ne-Time", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeFrequencyTypeKnownValues.FrequencyType_One_Time;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeFrequencyTypeKnownValues.FrequencyType_Unknown;
                        goto open_enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "eekly", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeFrequencyTypeKnownValues.FrequencyType_Weekly;
                        goto open_enum_is_done;
                      }
                break;
            case 'Y':
                if ((String.Compare(json_string.getData(), 1, "early", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeFrequencyTypeKnownValues.FrequencyType_Yearly;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setFrequencyType(the_open_enum);
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
                throw new Exception("The value for field FrequencyArgument of NewCalendarItemSpecifierJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FrequencyArgument of NewCalendarItemSpecifierJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFrequencyArgument(extracted_integer);
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
                throw new Exception("The value for field FrequencyMultiplier of NewCalendarItemSpecifierJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FrequencyMultiplier of NewCalendarItemSpecifierJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFrequencyMultiplier(extracted_integer);
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
                throw new Exception("The value for field IsAllDay of NewCalendarItemSpecifierJSON is not true for false.");
              }
          }
        setIsAllDay(the_bool);
      }


    private void  fromJSONSelfAttendeeStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SelfAttendeeStatus of NewCalendarItemSpecifierJSON is not a string.");
        TypeSelfAttendeeStatus the_open_enum = new TypeSelfAttendeeStatus();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ccepted", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus_Accepted;
                        goto open_enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "eclined", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus_Declined;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nvited", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus_Invited;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "entative", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus_Tentative;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setSelfAttendeeStatus(the_open_enum);
      }


    private void  fromJSONReminders(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Reminders of NewCalendarItemSpecifierJSON is not an array.");
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


    public NewCalendarItemSpecifierJSON()
      {
        flagHasTitle = false;
        flagHasLocation = false;
        flagHasLocationSpecifier = false;
        flagHasRange = false;
        flagHasAttendees = false;
        flagHasClientShouldFindAppropriateTime = false;
        flagHasFrequencyType = false;
        flagHasFrequencyArgument = false;
        flagHasFrequencyMultiplier = false;
        flagHasIsAllDay = false;
        flagHasSelfAttendeeStatus = false;
        flagHasReminders = false;
        storeAttendees = new List< CalendarAttendeeJSON  >();
        storeReminders = new List< CalendarReminderJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasLocationSpecifier()
      {
        return flagHasLocationSpecifier;
      }

    public CalendarLocationJSON   getLocationSpecifier()
      {
        Debug.Assert(flagHasLocationSpecifier);
        return storeLocationSpecifier;
      }

    public bool  hasRange()
      {
        return flagHasRange;
      }

    public DateTimeRangeSpecJSON   getRange()
      {
        Debug.Assert(flagHasRange);
        return storeRange;
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

    public bool  hasClientShouldFindAppropriateTime()
      {
        return flagHasClientShouldFindAppropriateTime;
      }

    public bool  getClientShouldFindAppropriateTime()
      {
        Debug.Assert(flagHasClientShouldFindAppropriateTime);
        return storeClientShouldFindAppropriateTime;
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
        TypeFrequencyType result = getFrequencyType();
        if (result.in_known_list)
            return stringFromFrequencyType(result.list_value);
        else
            return result.string_value;
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

    public bool  hasFrequencyMultiplier()
      {
        return flagHasFrequencyMultiplier;
      }

    public BigInteger  getFrequencyMultiplier()
      {
        Debug.Assert(flagHasFrequencyMultiplier);
        return storeFrequencyMultiplier;
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
        TypeSelfAttendeeStatus result = getSelfAttendeeStatus();
        if (result.in_known_list)
            return stringFromSelfAttendeeStatus(result.list_value);
        else
            return result.string_value;
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


    public virtual int extraNewCalendarItemSpecifierComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraNewCalendarItemSpecifierComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraNewCalendarItemSpecifierComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraNewCalendarItemSpecifierLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setLocationSpecifier(CalendarLocationJSON  new_value)
      {
        if (flagHasLocationSpecifier)
          {
          }
        flagHasLocationSpecifier = true;
        storeLocationSpecifier = new_value;
      }
    public void unsetLocationSpecifier()
      {
        if (flagHasLocationSpecifier)
          {
          }
        flagHasLocationSpecifier = false;
      }
    public void setRange(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasRange)
          {
          }
        flagHasRange = true;
        storeRange = new_value;
      }
    public void unsetRange()
      {
        if (flagHasRange)
          {
          }
        flagHasRange = false;
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
    public void setClientShouldFindAppropriateTime(bool new_value)
      {
        flagHasClientShouldFindAppropriateTime = true;
        storeClientShouldFindAppropriateTime = new_value;
      }
    public void unsetClientShouldFindAppropriateTime()
      {
        flagHasClientShouldFindAppropriateTime = false;
      }
    public void setFrequencyType(TypeFrequencyType new_value)
      {
        flagHasFrequencyType = true;
        storeFrequencyType = new_value;
      }
    public void setFrequencyType(string chars)
      {
        TypeFrequencyTypeKnownValues known = stringToFrequencyType(chars);
        TypeFrequencyType new_value = new TypeFrequencyType();
        if (known == TypeFrequencyTypeKnownValues.FrequencyType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setFrequencyType(new_value);
      }
    public void setFrequencyType(TypeFrequencyTypeKnownValues new_value)
      {
        TypeFrequencyType new_full_value = new TypeFrequencyType();
        Debug.Assert(new_value != TypeFrequencyTypeKnownValues.FrequencyType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setFrequencyType(new_full_value);
      }
    public void unsetFrequencyType()
      {
        flagHasFrequencyType = false;
      }
    public void setFrequencyArgument(BigInteger new_value)
      {
        flagHasFrequencyArgument = true;
        storeFrequencyArgument = new_value;
      }
    public void unsetFrequencyArgument()
      {
        flagHasFrequencyArgument = false;
      }
    public void setFrequencyMultiplier(BigInteger new_value)
      {
        flagHasFrequencyMultiplier = true;
        storeFrequencyMultiplier = new_value;
      }
    public void unsetFrequencyMultiplier()
      {
        flagHasFrequencyMultiplier = false;
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
    public void setSelfAttendeeStatus(TypeSelfAttendeeStatus new_value)
      {
        flagHasSelfAttendeeStatus = true;
        storeSelfAttendeeStatus = new_value;
      }
    public void setSelfAttendeeStatus(string chars)
      {
        TypeSelfAttendeeStatusKnownValues known = stringToSelfAttendeeStatus(chars);
        TypeSelfAttendeeStatus new_value = new TypeSelfAttendeeStatus();
        if (known == TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSelfAttendeeStatus(new_value);
      }
    public void setSelfAttendeeStatus(TypeSelfAttendeeStatusKnownValues new_value)
      {
        TypeSelfAttendeeStatus new_full_value = new TypeSelfAttendeeStatus();
        Debug.Assert(new_value != TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setSelfAttendeeStatus(new_full_value);
      }
    public void unsetSelfAttendeeStatus()
      {
        flagHasSelfAttendeeStatus = false;
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

    public virtual void extraNewCalendarItemSpecifierAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraNewCalendarItemSpecifierSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraNewCalendarItemSpecifierLookup(key);
        if (old_field == null)
          {
            extraNewCalendarItemSpecifierAppendPair(key, new_component);
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
        if (flagHasLocationSpecifier)
          {
            handler.start_pair("LocationSpecifier");
            if (partial_allowed)
                storeLocationSpecifier.write_partial_as_json(handler);
            else
                storeLocationSpecifier.write_as_json(handler);
          }
        if (flagHasRange)
          {
            handler.start_pair("Range");
            if (partial_allowed)
                storeRange.write_partial_as_json(handler);
            else
                storeRange.write_as_json(handler);
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
        if (flagHasClientShouldFindAppropriateTime)
          {
            handler.start_pair("ClientShouldFindAppropriateTime");
            handler.boolean_value(storeClientShouldFindAppropriateTime);
          }
        if (flagHasFrequencyType)
          {
            handler.start_pair("FrequencyType");
            if (storeFrequencyType.in_known_list)
              {
                switch (storeFrequencyType.list_value)
                  {
                    case TypeFrequencyTypeKnownValues.FrequencyType_Unknown:
                        handler.string_value("Unknown");
                        break;
                    case TypeFrequencyTypeKnownValues.FrequencyType_One_Time:
                        handler.string_value("One-Time");
                        break;
                    case TypeFrequencyTypeKnownValues.FrequencyType_Daily:
                        handler.string_value("Daily");
                        break;
                    case TypeFrequencyTypeKnownValues.FrequencyType_Weekly:
                        handler.string_value("Weekly");
                        break;
                    case TypeFrequencyTypeKnownValues.FrequencyType_Monthly:
                        handler.string_value("Monthly");
                        break;
                    case TypeFrequencyTypeKnownValues.FrequencyType_Yearly:
                        handler.string_value("Yearly");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeFrequencyType.string_value);
              }
          }
        if (flagHasFrequencyArgument)
          {
            handler.start_pair("FrequencyArgument");
            handler.number_value(storeFrequencyArgument);
          }
        if (flagHasFrequencyMultiplier)
          {
            handler.start_pair("FrequencyMultiplier");
            handler.number_value(storeFrequencyMultiplier);
          }
        if (flagHasIsAllDay)
          {
            handler.start_pair("IsAllDay");
            handler.boolean_value(storeIsAllDay);
          }
        if (flagHasSelfAttendeeStatus)
          {
            handler.start_pair("SelfAttendeeStatus");
            if (storeSelfAttendeeStatus.in_known_list)
              {
                switch (storeSelfAttendeeStatus.list_value)
                  {
                    case TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus_Accepted:
                        handler.string_value("Accepted");
                        break;
                    case TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus_Declined:
                        handler.string_value("Declined");
                        break;
                    case TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus_Invited:
                        handler.string_value("Invited");
                        break;
                    case TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus_Tentative:
                        handler.string_value("Tentative");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeSelfAttendeeStatus.string_value);
              }
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

    public static NewCalendarItemSpecifierJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NewCalendarItemSpecifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NewCalendarItemSpecifier", ignore_extras);
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
    public static NewCalendarItemSpecifierJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static NewCalendarItemSpecifierJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NewCalendarItemSpecifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NewCalendarItemSpecifier", ignore_extras);
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
    public static NewCalendarItemSpecifierJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static NewCalendarItemSpecifierJSON from_text(string text, bool ignore_extras)
      {
        NewCalendarItemSpecifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NewCalendarItemSpecifier", ignore_extras);
            JSONParse.parse_json_value(text, "Text for NewCalendarItemSpecifierJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static NewCalendarItemSpecifierJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        NewCalendarItemSpecifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NewCalendarItemSpecifier", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingStringGenerator fieldGeneratorLocation;
        private CalendarLocationJSON.HoldingGenerator fieldGeneratorLocationSpecifier;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorRange;
        private CalendarAttendeeJSON.HoldingArrayGenerator fieldGeneratorAttendees;
        private JSONHoldingBooleanGenerator fieldGeneratorClientShouldFindAppropriateTime;
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
                TypeFrequencyTypeKnownValues known = stringToFrequencyType(result);
                TypeFrequencyType new_value = new TypeFrequencyType();
                if (known == TypeFrequencyTypeKnownValues.FrequencyType__none)
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
    private class FieldHoldingGeneratorFrequencyArgument : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorFrequencyArgument(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorFrequencyArgument : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorFrequencyArgument(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorFrequencyArgument fieldGeneratorFrequencyArgument;
    private class FieldHoldingGeneratorFrequencyMultiplier : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorFrequencyMultiplier(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorFrequencyMultiplier : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorFrequencyMultiplier(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorFrequencyMultiplier fieldGeneratorFrequencyMultiplier;
        private JSONHoldingBooleanGenerator fieldGeneratorIsAllDay;
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
                TypeSelfAttendeeStatusKnownValues known = stringToSelfAttendeeStatus(result);
                TypeSelfAttendeeStatus new_value = new TypeSelfAttendeeStatus();
                if (known == TypeSelfAttendeeStatusKnownValues.SelfAttendeeStatus__none)
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
        private CalendarReminderJSON.HoldingArrayGenerator fieldGeneratorReminders;
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
            NewCalendarItemSpecifierJSON result = new NewCalendarItemSpecifierJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraNewCalendarItemSpecifierAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(NewCalendarItemSpecifierJSON result)
          {
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
            if (fieldGeneratorLocationSpecifier.have_value)
              {
                result.setLocationSpecifier(fieldGeneratorLocationSpecifier.value);
                fieldGeneratorLocationSpecifier.have_value = false;
              }
            if (fieldGeneratorRange.have_value)
              {
                result.setRange(fieldGeneratorRange.value);
                fieldGeneratorRange.have_value = false;
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
            if (fieldGeneratorClientShouldFindAppropriateTime.have_value)
              {
                result.setClientShouldFindAppropriateTime(fieldGeneratorClientShouldFindAppropriateTime.value);
                fieldGeneratorClientShouldFindAppropriateTime.have_value = false;
              }
            if (fieldGeneratorFrequencyType.have_value)
              {
                result.setFrequencyType(fieldGeneratorFrequencyType.value);
                fieldGeneratorFrequencyType.have_value = false;
              }
            if (fieldGeneratorFrequencyArgument.have_value)
              {
                result.setFrequencyArgument(fieldGeneratorFrequencyArgument.value);
                fieldGeneratorFrequencyArgument.have_value = false;
              }
            if (fieldGeneratorFrequencyMultiplier.have_value)
              {
                result.setFrequencyMultiplier(fieldGeneratorFrequencyMultiplier.value);
                fieldGeneratorFrequencyMultiplier.have_value = false;
              }
            if (fieldGeneratorIsAllDay.have_value)
              {
                result.setIsAllDay(fieldGeneratorIsAllDay.value);
                fieldGeneratorIsAllDay.have_value = false;
              }
            if (fieldGeneratorSelfAttendeeStatus.have_value)
              {
                result.setSelfAttendeeStatus(fieldGeneratorSelfAttendeeStatus.value);
                fieldGeneratorSelfAttendeeStatus.have_value = false;
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
          }
        protected abstract void handle_result(NewCalendarItemSpecifierJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttendees", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorAttendees;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "lientShouldFindAppropriateTime", 0, 30, false) == 0) && (field_name.Length == 31))
                        return fieldGeneratorClientShouldFindAppropriateTime;
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
                    if (String.Compare(field_name, 1, "ocation", 0, 7, false) == 0)
                      {
                        if (field_name.Length == 8)
                          {
                            return fieldGeneratorLocation;
                          }
                        switch (field_name[8])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 9, "pecifier", 0, 8, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorLocationSpecifier;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "nge", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorRange;
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 2, "minders", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorReminders;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "elfAttendeeStatus", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorSelfAttendeeStatus;
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
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the NewCalendarItemSpecifier class");
            fieldGeneratorLocation = new JSONHoldingStringGenerator("field \"Location\" of the NewCalendarItemSpecifier class");
            fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the NewCalendarItemSpecifier class", ignore_extras);
            fieldGeneratorRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"Range\" of the NewCalendarItemSpecifier class", ignore_extras);
            fieldGeneratorAttendees = new CalendarAttendeeJSON.HoldingArrayGenerator("field \"Attendees\" of the NewCalendarItemSpecifier class", ignore_extras);
            fieldGeneratorClientShouldFindAppropriateTime = new JSONHoldingBooleanGenerator("field \"ClientShouldFindAppropriateTime\" of the NewCalendarItemSpecifier class");
            fieldGeneratorFrequencyType = new FieldHoldingGeneratorFrequencyType("field \"FrequencyType\" of the NewCalendarItemSpecifier class");
            fieldGeneratorFrequencyArgument = new FieldHoldingGeneratorFrequencyArgument("field \"FrequencyArgument\" of the NewCalendarItemSpecifier class");
            fieldGeneratorFrequencyMultiplier = new FieldHoldingGeneratorFrequencyMultiplier("field \"FrequencyMultiplier\" of the NewCalendarItemSpecifier class");
            fieldGeneratorIsAllDay = new JSONHoldingBooleanGenerator("field \"IsAllDay\" of the NewCalendarItemSpecifier class");
            fieldGeneratorSelfAttendeeStatus = new FieldHoldingGeneratorSelfAttendeeStatus("field \"SelfAttendeeStatus\" of the NewCalendarItemSpecifier class");
            fieldGeneratorReminders = new CalendarReminderJSON.HoldingArrayGenerator("field \"Reminders\" of the NewCalendarItemSpecifier class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the NewCalendarItemSpecifier class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the NewCalendarItemSpecifier class");
            fieldGeneratorLocation = new JSONHoldingStringGenerator("field \"Location\" of the NewCalendarItemSpecifier class");
            fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the NewCalendarItemSpecifier class", false);
            fieldGeneratorRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"Range\" of the NewCalendarItemSpecifier class", false);
            fieldGeneratorAttendees = new CalendarAttendeeJSON.HoldingArrayGenerator("field \"Attendees\" of the NewCalendarItemSpecifier class", false);
            fieldGeneratorClientShouldFindAppropriateTime = new JSONHoldingBooleanGenerator("field \"ClientShouldFindAppropriateTime\" of the NewCalendarItemSpecifier class");
            fieldGeneratorFrequencyType = new FieldHoldingGeneratorFrequencyType("field \"FrequencyType\" of the NewCalendarItemSpecifier class");
            fieldGeneratorFrequencyArgument = new FieldHoldingGeneratorFrequencyArgument("field \"FrequencyArgument\" of the NewCalendarItemSpecifier class");
            fieldGeneratorFrequencyMultiplier = new FieldHoldingGeneratorFrequencyMultiplier("field \"FrequencyMultiplier\" of the NewCalendarItemSpecifier class");
            fieldGeneratorIsAllDay = new JSONHoldingBooleanGenerator("field \"IsAllDay\" of the NewCalendarItemSpecifier class");
            fieldGeneratorSelfAttendeeStatus = new FieldHoldingGeneratorSelfAttendeeStatus("field \"SelfAttendeeStatus\" of the NewCalendarItemSpecifier class");
            fieldGeneratorReminders = new CalendarReminderJSON.HoldingArrayGenerator("field \"Reminders\" of the NewCalendarItemSpecifier class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the NewCalendarItemSpecifier class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTitle.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorLocationSpecifier.reset();
            fieldGeneratorRange.reset();
            fieldGeneratorAttendees.reset();
            fieldGeneratorClientShouldFindAppropriateTime.reset();
            fieldGeneratorFrequencyType.reset();
            fieldGeneratorFrequencyArgument.reset();
            fieldGeneratorFrequencyMultiplier.reset();
            fieldGeneratorIsAllDay.reset();
            fieldGeneratorSelfAttendeeStatus.reset();
            fieldGeneratorReminders.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorLocationSpecifier.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRange.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAttendees.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorReminders.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorLocationSpecifier.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRange.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAttendees.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorReminders.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(NewCalendarItemSpecifierJSON  result)
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
        public NewCalendarItemSpecifierJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(NewCalendarItemSpecifierJSON  result)
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
    protected virtual void handle_result(List<NewCalendarItemSpecifierJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<NewCalendarItemSpecifierJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<NewCalendarItemSpecifierJSON>();
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
    public List<NewCalendarItemSpecifierJSON> value;
  };
  };
