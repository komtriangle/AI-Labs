/* file "CalendarCreateDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class CalendarCreateDataJSON : JSONBase
  {
    public enum TypeNextCreateActionKnownValues
      {
        NextCreateAction_Undefined,
        NextCreateAction_CreateItem,
        NextCreateAction_AskTitle,
        NextCreateAction_AskDate,
        NextCreateAction_AskTime,
        NextCreateAction_Location,
        NextCreateAction_Attendee,
        NextCreateAction_SelfAttendeeStatus,
        NextCreateAction_Reminder,
        NextCreateAction__none
      };
    public struct TypeNextCreateAction
      {
        public bool in_known_list;
        public string string_value;
        public TypeNextCreateActionKnownValues list_value;
      };

    public static TypeNextCreateActionKnownValues  stringToNextCreateAction(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 's':
                        if (String.Compare(chars, 2, "k", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'D':
                                    if ((String.Compare(chars, 4, "ate", 0, 3, false) == 0) && (chars.Length == 7))
                                        return TypeNextCreateActionKnownValues.NextCreateAction_AskDate;
                                    break;
                                case 'T':
                                    if (String.Compare(chars, 4, "i", 0, 1, false) == 0)
                                      {
                                        switch (chars[5])
                                          {
                                            case 'm':
                                                if ((String.Compare(chars, 6, "e", 0, 1, false) == 0) && (chars.Length == 7))
                                                    return TypeNextCreateActionKnownValues.NextCreateAction_AskTime;
                                                break;
                                            case 't':
                                                if ((String.Compare(chars, 6, "le", 0, 2, false) == 0) && (chars.Length == 8))
                                                    return TypeNextCreateActionKnownValues.NextCreateAction_AskTitle;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 't':
                        if ((String.Compare(chars, 2, "tendee", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeNextCreateActionKnownValues.NextCreateAction_Attendee;
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(chars, 1, "reateItem", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeNextCreateActionKnownValues.NextCreateAction_CreateItem;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "ocation", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeNextCreateActionKnownValues.NextCreateAction_Location;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "eminder", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeNextCreateActionKnownValues.NextCreateAction_Reminder;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "elfAttendeeStatus", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeNextCreateActionKnownValues.NextCreateAction_SelfAttendeeStatus;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "ndefined", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeNextCreateActionKnownValues.NextCreateAction_Undefined;
                break;
            default:
                break;
          }
        return TypeNextCreateActionKnownValues.NextCreateAction__none;
      }

    public static string  stringFromNextCreateAction(TypeNextCreateActionKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeNextCreateActionKnownValues.NextCreateAction_Undefined:
                return "Undefined";
            case TypeNextCreateActionKnownValues.NextCreateAction_CreateItem:
                return "CreateItem";
            case TypeNextCreateActionKnownValues.NextCreateAction_AskTitle:
                return "AskTitle";
            case TypeNextCreateActionKnownValues.NextCreateAction_AskDate:
                return "AskDate";
            case TypeNextCreateActionKnownValues.NextCreateAction_AskTime:
                return "AskTime";
            case TypeNextCreateActionKnownValues.NextCreateAction_Location:
                return "Location";
            case TypeNextCreateActionKnownValues.NextCreateAction_Attendee:
                return "Attendee";
            case TypeNextCreateActionKnownValues.NextCreateAction_SelfAttendeeStatus:
                return "SelfAttendeeStatus";
            case TypeNextCreateActionKnownValues.NextCreateAction_Reminder:
                return "Reminder";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeLastCreateActionKnownValues
      {
        LastCreateAction_Undefined,
        LastCreateAction_CreateItem,
        LastCreateAction_AskTitle,
        LastCreateAction_AskDate,
        LastCreateAction_AskTime,
        LastCreateAction_Location,
        LastCreateAction_Attendee,
        LastCreateAction_SelfAttendeeStatus,
        LastCreateAction_Reminder,
        LastCreateAction__none
      };
    public struct TypeLastCreateAction
      {
        public bool in_known_list;
        public string string_value;
        public TypeLastCreateActionKnownValues list_value;
      };

    public static TypeLastCreateActionKnownValues  stringToLastCreateAction(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 's':
                        if (String.Compare(chars, 2, "k", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'D':
                                    if ((String.Compare(chars, 4, "ate", 0, 3, false) == 0) && (chars.Length == 7))
                                        return TypeLastCreateActionKnownValues.LastCreateAction_AskDate;
                                    break;
                                case 'T':
                                    if (String.Compare(chars, 4, "i", 0, 1, false) == 0)
                                      {
                                        switch (chars[5])
                                          {
                                            case 'm':
                                                if ((String.Compare(chars, 6, "e", 0, 1, false) == 0) && (chars.Length == 7))
                                                    return TypeLastCreateActionKnownValues.LastCreateAction_AskTime;
                                                break;
                                            case 't':
                                                if ((String.Compare(chars, 6, "le", 0, 2, false) == 0) && (chars.Length == 8))
                                                    return TypeLastCreateActionKnownValues.LastCreateAction_AskTitle;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 't':
                        if ((String.Compare(chars, 2, "tendee", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeLastCreateActionKnownValues.LastCreateAction_Attendee;
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(chars, 1, "reateItem", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeLastCreateActionKnownValues.LastCreateAction_CreateItem;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "ocation", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeLastCreateActionKnownValues.LastCreateAction_Location;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "eminder", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeLastCreateActionKnownValues.LastCreateAction_Reminder;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "elfAttendeeStatus", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeLastCreateActionKnownValues.LastCreateAction_SelfAttendeeStatus;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "ndefined", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeLastCreateActionKnownValues.LastCreateAction_Undefined;
                break;
            default:
                break;
          }
        return TypeLastCreateActionKnownValues.LastCreateAction__none;
      }

    public static string  stringFromLastCreateAction(TypeLastCreateActionKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeLastCreateActionKnownValues.LastCreateAction_Undefined:
                return "Undefined";
            case TypeLastCreateActionKnownValues.LastCreateAction_CreateItem:
                return "CreateItem";
            case TypeLastCreateActionKnownValues.LastCreateAction_AskTitle:
                return "AskTitle";
            case TypeLastCreateActionKnownValues.LastCreateAction_AskDate:
                return "AskDate";
            case TypeLastCreateActionKnownValues.LastCreateAction_AskTime:
                return "AskTime";
            case TypeLastCreateActionKnownValues.LastCreateAction_Location:
                return "Location";
            case TypeLastCreateActionKnownValues.LastCreateAction_Attendee:
                return "Attendee";
            case TypeLastCreateActionKnownValues.LastCreateAction_SelfAttendeeStatus:
                return "SelfAttendeeStatus";
            case TypeLastCreateActionKnownValues.LastCreateAction_Reminder:
                return "Reminder";
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

    public enum TypeAvailability
      {
        Availability_Busy,
        Availability_Available,
        Availability_Tentative
      };

    public static TypeAvailability  stringToAvailability(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "vailable", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeAvailability.Availability_Available;
                break;
            case 'B':
                if ((String.Compare(chars, 1, "usy", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeAvailability.Availability_Busy;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "entative", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeAvailability.Availability_Tentative;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Availability' is not one of the legal values.");
      }

    public static string  stringFromAvailability(TypeAvailability the_enum)
      {
        switch (the_enum)
          {
            case TypeAvailability.Availability_Busy:
                return "Busy";
            case TypeAvailability.Availability_Available:
                return "Available";
            case TypeAvailability.Availability_Tentative:
                return "Tentative";
            default:
                Debug.Assert(false);
                return null;
          }
      }

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

    public enum TypeAccessLevel
      {
        AccessLevel_Default,
        AccessLevel_Private,
        AccessLevel_Public
      };

    public static TypeAccessLevel  stringToAccessLevel(string chars)
      {
        switch (chars[0])
          {
            case 'D':
                if ((String.Compare(chars, 1, "efault", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeAccessLevel.AccessLevel_Default;
                break;
            case 'P':
                switch (chars[1])
                  {
                    case 'r':
                        if ((String.Compare(chars, 2, "ivate", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeAccessLevel.AccessLevel_Private;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "blic", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeAccessLevel.AccessLevel_Public;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field `AccessLevel' is not one of the legal values.");
      }

    public static string  stringFromAccessLevel(TypeAccessLevel the_enum)
      {
        switch (the_enum)
          {
            case TypeAccessLevel.AccessLevel_Default:
                return "Default";
            case TypeAccessLevel.AccessLevel_Private:
                return "Private";
            case TypeAccessLevel.AccessLevel_Public:
                return "Public";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasNextCreateAction;
    private TypeNextCreateAction storeNextCreateAction;
    private bool flagHasLastCreateAction;
    private TypeLastCreateAction storeLastCreateAction;
    private bool flagHasItemKind;
    private string storeItemKind;
    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasLocation;
    private string storeLocation;
    private bool flagHasLocationSpecifier;
    private CalendarLocationJSON  storeLocationSpecifier;
    private bool flagHasMapLocation;
    private string storeMapLocation;
    private bool flagHasRequestedStart;
    private DateAndOrTimeJSON  storeRequestedStart;
    private bool flagHasRequestedEnd;
    private DateAndOrTimeJSON  storeRequestedEnd;
    private bool flagHasStart;
    private DateAndOrTimeJSON  storeStart;
    private bool flagHasEnd;
    private DateAndOrTimeJSON  storeEnd;
    private bool flagHasClientShouldFindAppropriateTime;
    private bool storeClientShouldFindAppropriateTime;
    private bool flagHasFrequencyType;
    private TypeFrequencyType storeFrequencyType;
    private bool flagHasFrequencyMultiplier;
    private BigInteger storeFrequencyMultiplier;
    private bool flagHasIsRecurring;
    private bool storeIsRecurring;
    private bool flagHasRecurrenceRule;
    private string storeRecurrenceRule;
    private bool flagHasDurationData;
    private DurationDataJSON  storeDurationData;
    private bool flagHasIsAllDay;
    private bool storeIsAllDay;
    private bool flagHasAvailability;
    private TypeAvailability storeAvailability;
    private bool flagHasCalendarName;
    private string storeCalendarName;
    private bool flagHasCalendarID;
    private string storeCalendarID;
    private bool flagHasDescription;
    private string storeDescription;
    private bool flagHasOrganizer;
    private string storeOrganizer;
    private bool flagHasSelfAttendeeStatus;
    private TypeSelfAttendeeStatus storeSelfAttendeeStatus;
    private bool flagHasAccessLevel;
    private TypeAccessLevel storeAccessLevel;
    private bool flagHasAttendees;
    private List< CalendarAttendeeJSON  > storeAttendees;
    private bool flagHasReminders;
    private List< CalendarReminderJSON  > storeReminders;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONNextCreateAction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NextCreateAction of CalendarCreateDataJSON is not a string.");
        TypeNextCreateAction the_open_enum = new TypeNextCreateAction();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 's':
                        if (String.Compare(json_string.getData(), 2, "k", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'D':
                                    if ((String.Compare(json_string.getData(), 4, "ate", 0, 3, false) == 0) && (json_string.getData().Length == 7))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNextCreateActionKnownValues.NextCreateAction_AskDate;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'T':
                                    if (String.Compare(json_string.getData(), 4, "i", 0, 1, false) == 0)
                                      {
                                        switch (json_string.getData()[5])
                                          {
                                            case 'm':
                                                if ((String.Compare(json_string.getData(), 6, "e", 0, 1, false) == 0) && (json_string.getData().Length == 7))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNextCreateActionKnownValues.NextCreateAction_AskTime;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 't':
                                                if ((String.Compare(json_string.getData(), 6, "le", 0, 2, false) == 0) && (json_string.getData().Length == 8))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNextCreateActionKnownValues.NextCreateAction_AskTitle;
                                                        goto open_enum_is_done;
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
                          }
                        break;
                    case 't':
                        if ((String.Compare(json_string.getData(), 2, "tendee", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNextCreateActionKnownValues.NextCreateAction_Attendee;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "reateItem", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeNextCreateActionKnownValues.NextCreateAction_CreateItem;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ocation", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeNextCreateActionKnownValues.NextCreateAction_Location;
                        goto open_enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "eminder", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeNextCreateActionKnownValues.NextCreateAction_Reminder;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "elfAttendeeStatus", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeNextCreateActionKnownValues.NextCreateAction_SelfAttendeeStatus;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "ndefined", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeNextCreateActionKnownValues.NextCreateAction_Undefined;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setNextCreateAction(the_open_enum);
      }


    private void  fromJSONLastCreateAction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LastCreateAction of CalendarCreateDataJSON is not a string.");
        TypeLastCreateAction the_open_enum = new TypeLastCreateAction();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 's':
                        if (String.Compare(json_string.getData(), 2, "k", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'D':
                                    if ((String.Compare(json_string.getData(), 4, "ate", 0, 3, false) == 0) && (json_string.getData().Length == 7))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeLastCreateActionKnownValues.LastCreateAction_AskDate;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'T':
                                    if (String.Compare(json_string.getData(), 4, "i", 0, 1, false) == 0)
                                      {
                                        switch (json_string.getData()[5])
                                          {
                                            case 'm':
                                                if ((String.Compare(json_string.getData(), 6, "e", 0, 1, false) == 0) && (json_string.getData().Length == 7))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeLastCreateActionKnownValues.LastCreateAction_AskTime;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 't':
                                                if ((String.Compare(json_string.getData(), 6, "le", 0, 2, false) == 0) && (json_string.getData().Length == 8))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeLastCreateActionKnownValues.LastCreateAction_AskTitle;
                                                        goto open_enum_is_done;
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
                          }
                        break;
                    case 't':
                        if ((String.Compare(json_string.getData(), 2, "tendee", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeLastCreateActionKnownValues.LastCreateAction_Attendee;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "reateItem", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeLastCreateActionKnownValues.LastCreateAction_CreateItem;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ocation", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeLastCreateActionKnownValues.LastCreateAction_Location;
                        goto open_enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "eminder", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeLastCreateActionKnownValues.LastCreateAction_Reminder;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "elfAttendeeStatus", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeLastCreateActionKnownValues.LastCreateAction_SelfAttendeeStatus;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "ndefined", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeLastCreateActionKnownValues.LastCreateAction_Undefined;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setLastCreateAction(the_open_enum);
      }


    private void  fromJSONItemKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ItemKind of CalendarCreateDataJSON is not a string.");
        setItemKind(json_string.getData());
      }


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of CalendarCreateDataJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Location of CalendarCreateDataJSON is not a string.");
        setLocation(json_string.getData());
      }


    private void  fromJSONLocationSpecifier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CalendarLocationJSON convert_classy = CalendarLocationJSON.from_json(json_value, ignore_extras, true);
        setLocationSpecifier(convert_classy);
      }


    private void  fromJSONMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MapLocation of CalendarCreateDataJSON is not a string.");
        setMapLocation(json_string.getData());
      }


    private void  fromJSONRequestedStart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setRequestedStart(convert_classy);
      }


    private void  fromJSONRequestedEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setRequestedEnd(convert_classy);
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
                throw new Exception("The value for field ClientShouldFindAppropriateTime of CalendarCreateDataJSON is not true for false.");
              }
          }
        setClientShouldFindAppropriateTime(the_bool);
      }


    private void  fromJSONFrequencyType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FrequencyType of CalendarCreateDataJSON is not a string.");
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
        throw new Exception("The value for field FrequencyType of CalendarCreateDataJSON is not one of the legal strings.");
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
                throw new Exception("The value for field FrequencyMultiplier of CalendarCreateDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FrequencyMultiplier of CalendarCreateDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFrequencyMultiplier(extracted_integer);
      }


    private void  fromJSONIsRecurring(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsRecurring of CalendarCreateDataJSON is not true for false.");
              }
          }
        setIsRecurring(the_bool);
      }


    private void  fromJSONRecurrenceRule(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RecurrenceRule of CalendarCreateDataJSON is not a string.");
        setRecurrenceRule(json_string.getData());
      }


    private void  fromJSONDurationData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DurationDataJSON convert_classy = DurationDataJSON.from_json(json_value, ignore_extras, true);
        setDurationData(convert_classy);
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
                throw new Exception("The value for field IsAllDay of CalendarCreateDataJSON is not true for false.");
              }
          }
        setIsAllDay(the_bool);
      }


    private void  fromJSONAvailability(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Availability of CalendarCreateDataJSON is not a string.");
        TypeAvailability the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "vailable", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeAvailability.Availability_Available;
                        goto enum_is_done;
                      }
                break;
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "usy", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeAvailability.Availability_Busy;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "entative", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeAvailability.Availability_Tentative;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Availability of CalendarCreateDataJSON is not one of the legal strings.");
      enum_is_done:;
        setAvailability(the_enum);
      }


    private void  fromJSONCalendarName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CalendarName of CalendarCreateDataJSON is not a string.");
        setCalendarName(json_string.getData());
      }


    private void  fromJSONCalendarID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CalendarID of CalendarCreateDataJSON is not a string.");
        setCalendarID(json_string.getData());
      }


    private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Description of CalendarCreateDataJSON is not a string.");
        setDescription(json_string.getData());
      }


    private void  fromJSONOrganizer(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Organizer of CalendarCreateDataJSON is not a string.");
        setOrganizer(json_string.getData());
      }


    private void  fromJSONSelfAttendeeStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SelfAttendeeStatus of CalendarCreateDataJSON is not a string.");
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
        throw new Exception("The value for field SelfAttendeeStatus of CalendarCreateDataJSON is not one of the legal strings.");
      enum_is_done:;
        setSelfAttendeeStatus(the_enum);
      }


    private void  fromJSONAccessLevel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AccessLevel of CalendarCreateDataJSON is not a string.");
        TypeAccessLevel the_enum;
        switch (json_string.getData()[0])
          {
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "efault", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeAccessLevel.AccessLevel_Default;
                        goto enum_is_done;
                      }
                break;
            case 'P':
                switch (json_string.getData()[1])
                  {
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "ivate", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_enum = TypeAccessLevel.AccessLevel_Private;
                                goto enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "blic", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_enum = TypeAccessLevel.AccessLevel_Public;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field AccessLevel of CalendarCreateDataJSON is not one of the legal strings.");
      enum_is_done:;
        setAccessLevel(the_enum);
      }


    private void  fromJSONAttendees(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Attendees of CalendarCreateDataJSON is not an array.");
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


    private void  fromJSONReminders(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Reminders of CalendarCreateDataJSON is not an array.");
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


    public CalendarCreateDataJSON()
      {
        flagHasNextCreateAction = false;
        flagHasLastCreateAction = false;
        flagHasItemKind = false;
        flagHasTitle = false;
        flagHasLocation = false;
        flagHasLocationSpecifier = false;
        flagHasMapLocation = false;
        flagHasRequestedStart = false;
        flagHasRequestedEnd = false;
        flagHasStart = false;
        flagHasEnd = false;
        flagHasClientShouldFindAppropriateTime = false;
        flagHasFrequencyType = false;
        flagHasFrequencyMultiplier = false;
        flagHasIsRecurring = false;
        flagHasRecurrenceRule = false;
        flagHasDurationData = false;
        flagHasIsAllDay = false;
        flagHasAvailability = false;
        flagHasCalendarName = false;
        flagHasCalendarID = false;
        flagHasDescription = false;
        flagHasOrganizer = false;
        flagHasSelfAttendeeStatus = false;
        flagHasAccessLevel = false;
        flagHasAttendees = false;
        flagHasReminders = false;
        storeAttendees = new List< CalendarAttendeeJSON  >();
        storeReminders = new List< CalendarReminderJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasNextCreateAction()
      {
        return flagHasNextCreateAction;
      }

    public TypeNextCreateAction  getNextCreateAction()
      {
        Debug.Assert(flagHasNextCreateAction);
        return storeNextCreateAction;
      }

    public string  getNextCreateActionAsString()
      {
        TypeNextCreateAction result = getNextCreateAction();
        if (result.in_known_list)
            return stringFromNextCreateAction(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasLastCreateAction()
      {
        return flagHasLastCreateAction;
      }

    public TypeLastCreateAction  getLastCreateAction()
      {
        Debug.Assert(flagHasLastCreateAction);
        return storeLastCreateAction;
      }

    public string  getLastCreateActionAsString()
      {
        TypeLastCreateAction result = getLastCreateAction();
        if (result.in_known_list)
            return stringFromLastCreateAction(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasItemKind()
      {
        return flagHasItemKind;
      }

    public string  getItemKind()
      {
        Debug.Assert(flagHasItemKind);
        return storeItemKind;
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

    public bool  hasMapLocation()
      {
        return flagHasMapLocation;
      }

    public string  getMapLocation()
      {
        Debug.Assert(flagHasMapLocation);
        return storeMapLocation;
      }

    public bool  hasRequestedStart()
      {
        return flagHasRequestedStart;
      }

    public DateAndOrTimeJSON   getRequestedStart()
      {
        Debug.Assert(flagHasRequestedStart);
        return storeRequestedStart;
      }

    public bool  hasRequestedEnd()
      {
        return flagHasRequestedEnd;
      }

    public DateAndOrTimeJSON   getRequestedEnd()
      {
        Debug.Assert(flagHasRequestedEnd);
        return storeRequestedEnd;
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

    public bool  hasIsRecurring()
      {
        return flagHasIsRecurring;
      }

    public bool  getIsRecurring()
      {
        Debug.Assert(flagHasIsRecurring);
        return storeIsRecurring;
      }

    public bool  hasRecurrenceRule()
      {
        return flagHasRecurrenceRule;
      }

    public string  getRecurrenceRule()
      {
        Debug.Assert(flagHasRecurrenceRule);
        return storeRecurrenceRule;
      }

    public bool  hasDurationData()
      {
        return flagHasDurationData;
      }

    public DurationDataJSON   getDurationData()
      {
        Debug.Assert(flagHasDurationData);
        return storeDurationData;
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

    public bool  hasAvailability()
      {
        return flagHasAvailability;
      }

    public TypeAvailability  getAvailability()
      {
        Debug.Assert(flagHasAvailability);
        return storeAvailability;
      }

    public string  getAvailabilityAsString()
      {
        return stringFromAvailability(getAvailability());
      }

    public bool  hasCalendarName()
      {
        return flagHasCalendarName;
      }

    public string  getCalendarName()
      {
        Debug.Assert(flagHasCalendarName);
        return storeCalendarName;
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

    public bool  hasDescription()
      {
        return flagHasDescription;
      }

    public string  getDescription()
      {
        Debug.Assert(flagHasDescription);
        return storeDescription;
      }

    public bool  hasOrganizer()
      {
        return flagHasOrganizer;
      }

    public string  getOrganizer()
      {
        Debug.Assert(flagHasOrganizer);
        return storeOrganizer;
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

    public bool  hasAccessLevel()
      {
        return flagHasAccessLevel;
      }

    public TypeAccessLevel  getAccessLevel()
      {
        Debug.Assert(flagHasAccessLevel);
        return storeAccessLevel;
      }

    public string  getAccessLevelAsString()
      {
        return stringFromAccessLevel(getAccessLevel());
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


    public virtual int extraCalendarCreateDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCalendarCreateDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCalendarCreateDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCalendarCreateDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setNextCreateAction(TypeNextCreateAction new_value)
      {
        flagHasNextCreateAction = true;
        storeNextCreateAction = new_value;
      }
    public void setNextCreateAction(string chars)
      {
        TypeNextCreateActionKnownValues known = stringToNextCreateAction(chars);
        TypeNextCreateAction new_value = new TypeNextCreateAction();
        if (known == TypeNextCreateActionKnownValues.NextCreateAction__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setNextCreateAction(new_value);
      }
    public void setNextCreateAction(TypeNextCreateActionKnownValues new_value)
      {
        TypeNextCreateAction new_full_value = new TypeNextCreateAction();
        Debug.Assert(new_value != TypeNextCreateActionKnownValues.NextCreateAction__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setNextCreateAction(new_full_value);
      }
    public void unsetNextCreateAction()
      {
        flagHasNextCreateAction = false;
      }
    public void setLastCreateAction(TypeLastCreateAction new_value)
      {
        flagHasLastCreateAction = true;
        storeLastCreateAction = new_value;
      }
    public void setLastCreateAction(string chars)
      {
        TypeLastCreateActionKnownValues known = stringToLastCreateAction(chars);
        TypeLastCreateAction new_value = new TypeLastCreateAction();
        if (known == TypeLastCreateActionKnownValues.LastCreateAction__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setLastCreateAction(new_value);
      }
    public void setLastCreateAction(TypeLastCreateActionKnownValues new_value)
      {
        TypeLastCreateAction new_full_value = new TypeLastCreateAction();
        Debug.Assert(new_value != TypeLastCreateActionKnownValues.LastCreateAction__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setLastCreateAction(new_full_value);
      }
    public void unsetLastCreateAction()
      {
        flagHasLastCreateAction = false;
      }
    public void setItemKind(string new_value)
      {
        flagHasItemKind = true;
        storeItemKind = new_value;
      }
    public void unsetItemKind()
      {
        flagHasItemKind = false;
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
    public void setMapLocation(string new_value)
      {
        flagHasMapLocation = true;
        storeMapLocation = new_value;
      }
    public void unsetMapLocation()
      {
        flagHasMapLocation = false;
      }
    public void setRequestedStart(DateAndOrTimeJSON  new_value)
      {
        if (flagHasRequestedStart)
          {
          }
        flagHasRequestedStart = true;
        storeRequestedStart = new_value;
      }
    public void unsetRequestedStart()
      {
        if (flagHasRequestedStart)
          {
          }
        flagHasRequestedStart = false;
      }
    public void setRequestedEnd(DateAndOrTimeJSON  new_value)
      {
        if (flagHasRequestedEnd)
          {
          }
        flagHasRequestedEnd = true;
        storeRequestedEnd = new_value;
      }
    public void unsetRequestedEnd()
      {
        if (flagHasRequestedEnd)
          {
          }
        flagHasRequestedEnd = false;
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
            throw new Exception("The value for field FrequencyMultiplier of CalendarCreateDataJSON is less than the lower bound (1) for that field.");
        storeFrequencyMultiplier = new_value;
      }
    public void unsetFrequencyMultiplier()
      {
        flagHasFrequencyMultiplier = false;
      }
    public void setIsRecurring(bool new_value)
      {
        flagHasIsRecurring = true;
        storeIsRecurring = new_value;
      }
    public void unsetIsRecurring()
      {
        flagHasIsRecurring = false;
      }
    public void setRecurrenceRule(string new_value)
      {
        flagHasRecurrenceRule = true;
        storeRecurrenceRule = new_value;
      }
    public void unsetRecurrenceRule()
      {
        flagHasRecurrenceRule = false;
      }
    public void setDurationData(DurationDataJSON  new_value)
      {
        if (flagHasDurationData)
          {
          }
        flagHasDurationData = true;
        storeDurationData = new_value;
      }
    public void unsetDurationData()
      {
        if (flagHasDurationData)
          {
          }
        flagHasDurationData = false;
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
    public void setAvailability(TypeAvailability new_value)
      {
        flagHasAvailability = true;
        storeAvailability = new_value;
      }
    public void setAvailability(string chars)
      {
        setAvailability(stringToAvailability(chars));
      }
    public void unsetAvailability()
      {
        flagHasAvailability = false;
      }
    public void setCalendarName(string new_value)
      {
        flagHasCalendarName = true;
        storeCalendarName = new_value;
      }
    public void unsetCalendarName()
      {
        flagHasCalendarName = false;
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
    public void setDescription(string new_value)
      {
        flagHasDescription = true;
        storeDescription = new_value;
      }
    public void unsetDescription()
      {
        flagHasDescription = false;
      }
    public void setOrganizer(string new_value)
      {
        flagHasOrganizer = true;
        storeOrganizer = new_value;
      }
    public void unsetOrganizer()
      {
        flagHasOrganizer = false;
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
    public void setAccessLevel(TypeAccessLevel new_value)
      {
        flagHasAccessLevel = true;
        storeAccessLevel = new_value;
      }
    public void setAccessLevel(string chars)
      {
        setAccessLevel(stringToAccessLevel(chars));
      }
    public void unsetAccessLevel()
      {
        flagHasAccessLevel = false;
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

    public virtual void extraCalendarCreateDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCalendarCreateDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCalendarCreateDataLookup(key);
        if (old_field == null)
          {
            extraCalendarCreateDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNextCreateAction);
        if (flagHasNextCreateAction)
          {
            handler.start_pair("NextCreateAction");
            if (storeNextCreateAction.in_known_list)
              {
                switch (storeNextCreateAction.list_value)
                  {
                    case TypeNextCreateActionKnownValues.NextCreateAction_Undefined:
                        handler.string_value("Undefined");
                        break;
                    case TypeNextCreateActionKnownValues.NextCreateAction_CreateItem:
                        handler.string_value("CreateItem");
                        break;
                    case TypeNextCreateActionKnownValues.NextCreateAction_AskTitle:
                        handler.string_value("AskTitle");
                        break;
                    case TypeNextCreateActionKnownValues.NextCreateAction_AskDate:
                        handler.string_value("AskDate");
                        break;
                    case TypeNextCreateActionKnownValues.NextCreateAction_AskTime:
                        handler.string_value("AskTime");
                        break;
                    case TypeNextCreateActionKnownValues.NextCreateAction_Location:
                        handler.string_value("Location");
                        break;
                    case TypeNextCreateActionKnownValues.NextCreateAction_Attendee:
                        handler.string_value("Attendee");
                        break;
                    case TypeNextCreateActionKnownValues.NextCreateAction_SelfAttendeeStatus:
                        handler.string_value("SelfAttendeeStatus");
                        break;
                    case TypeNextCreateActionKnownValues.NextCreateAction_Reminder:
                        handler.string_value("Reminder");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeNextCreateAction.string_value);
              }
          }
        if (flagHasLastCreateAction)
          {
            handler.start_pair("LastCreateAction");
            if (storeLastCreateAction.in_known_list)
              {
                switch (storeLastCreateAction.list_value)
                  {
                    case TypeLastCreateActionKnownValues.LastCreateAction_Undefined:
                        handler.string_value("Undefined");
                        break;
                    case TypeLastCreateActionKnownValues.LastCreateAction_CreateItem:
                        handler.string_value("CreateItem");
                        break;
                    case TypeLastCreateActionKnownValues.LastCreateAction_AskTitle:
                        handler.string_value("AskTitle");
                        break;
                    case TypeLastCreateActionKnownValues.LastCreateAction_AskDate:
                        handler.string_value("AskDate");
                        break;
                    case TypeLastCreateActionKnownValues.LastCreateAction_AskTime:
                        handler.string_value("AskTime");
                        break;
                    case TypeLastCreateActionKnownValues.LastCreateAction_Location:
                        handler.string_value("Location");
                        break;
                    case TypeLastCreateActionKnownValues.LastCreateAction_Attendee:
                        handler.string_value("Attendee");
                        break;
                    case TypeLastCreateActionKnownValues.LastCreateAction_SelfAttendeeStatus:
                        handler.string_value("SelfAttendeeStatus");
                        break;
                    case TypeLastCreateActionKnownValues.LastCreateAction_Reminder:
                        handler.string_value("Reminder");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeLastCreateAction.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasItemKind);
        if (flagHasItemKind)
          {
            handler.start_pair("ItemKind");
            handler.string_value(storeItemKind);
          }
        Debug.Assert(partial_allowed || flagHasTitle);
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
        if (flagHasMapLocation)
          {
            handler.start_pair("MapLocation");
            handler.string_value(storeMapLocation);
          }
        if (flagHasRequestedStart)
          {
            handler.start_pair("RequestedStart");
            if (partial_allowed)
                storeRequestedStart.write_partial_as_json(handler);
            else
                storeRequestedStart.write_as_json(handler);
          }
        if (flagHasRequestedEnd)
          {
            handler.start_pair("RequestedEnd");
            if (partial_allowed)
                storeRequestedEnd.write_partial_as_json(handler);
            else
                storeRequestedEnd.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasStart);
        if (flagHasStart)
          {
            handler.start_pair("Start");
            if (partial_allowed)
                storeStart.write_partial_as_json(handler);
            else
                storeStart.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasEnd);
        if (flagHasEnd)
          {
            handler.start_pair("End");
            if (partial_allowed)
                storeEnd.write_partial_as_json(handler);
            else
                storeEnd.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasClientShouldFindAppropriateTime);
        if (flagHasClientShouldFindAppropriateTime)
          {
            handler.start_pair("ClientShouldFindAppropriateTime");
            handler.boolean_value(storeClientShouldFindAppropriateTime);
          }
        Debug.Assert(partial_allowed || flagHasFrequencyType);
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
        Debug.Assert(partial_allowed || flagHasFrequencyMultiplier);
        if (flagHasFrequencyMultiplier)
          {
            handler.start_pair("FrequencyMultiplier");
            handler.number_value(storeFrequencyMultiplier);
          }
        Debug.Assert(partial_allowed || flagHasIsRecurring);
        if (flagHasIsRecurring)
          {
            handler.start_pair("IsRecurring");
            handler.boolean_value(storeIsRecurring);
          }
        if (flagHasRecurrenceRule)
          {
            handler.start_pair("RecurrenceRule");
            handler.string_value(storeRecurrenceRule);
          }
        if (flagHasDurationData)
          {
            handler.start_pair("DurationData");
            if (partial_allowed)
                storeDurationData.write_partial_as_json(handler);
            else
                storeDurationData.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasIsAllDay);
        if (flagHasIsAllDay)
          {
            handler.start_pair("IsAllDay");
            handler.boolean_value(storeIsAllDay);
          }
        if (flagHasAvailability)
          {
            handler.start_pair("Availability");
            switch (storeAvailability)
              {
                case TypeAvailability.Availability_Busy:
                    handler.string_value("Busy");
                    break;
                case TypeAvailability.Availability_Available:
                    handler.string_value("Available");
                    break;
                case TypeAvailability.Availability_Tentative:
                    handler.string_value("Tentative");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasCalendarName)
          {
            handler.start_pair("CalendarName");
            handler.string_value(storeCalendarName);
          }
        if (flagHasCalendarID)
          {
            handler.start_pair("CalendarID");
            handler.string_value(storeCalendarID);
          }
        if (flagHasDescription)
          {
            handler.start_pair("Description");
            handler.string_value(storeDescription);
          }
        if (flagHasOrganizer)
          {
            handler.start_pair("Organizer");
            handler.string_value(storeOrganizer);
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
        if (flagHasAccessLevel)
          {
            handler.start_pair("AccessLevel");
            switch (storeAccessLevel)
              {
                case TypeAccessLevel.AccessLevel_Default:
                    handler.string_value("Default");
                    break;
                case TypeAccessLevel.AccessLevel_Private:
                    handler.string_value("Private");
                    break;
                case TypeAccessLevel.AccessLevel_Public:
                    handler.string_value("Public");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
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
        if (!(hasNextCreateAction()))
          {
            return "When parsing the object for %what%, the \"NextCreateAction\" field was missing.";
          }
        if (!(hasItemKind()))
          {
            return "When parsing the object for %what%, the \"ItemKind\" field was missing.";
          }
        if (!(hasTitle()))
          {
            return "When parsing the object for %what%, the \"Title\" field was missing.";
          }
        if (!(hasStart()))
          {
            return "When parsing the object for %what%, the \"Start\" field was missing.";
          }
        if (!(hasEnd()))
          {
            return "When parsing the object for %what%, the \"End\" field was missing.";
          }
        if (!(hasClientShouldFindAppropriateTime()))
          {
            return "When parsing the object for %what%, the \"ClientShouldFindAppropriateTime\" field was missing.";
          }
        if (!(hasFrequencyType()))
          {
            return "When parsing the object for %what%, the \"FrequencyType\" field was missing.";
          }
        if (!(hasFrequencyMultiplier()))
          {
            return "When parsing the object for %what%, the \"FrequencyMultiplier\" field was missing.";
          }
        if (!(hasIsRecurring()))
          {
            return "When parsing the object for %what%, the \"IsRecurring\" field was missing.";
          }
        if (!(hasIsAllDay()))
          {
            return "When parsing the object for %what%, the \"IsAllDay\" field was missing.";
          }
        return null;
      }

    public static CalendarCreateDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarCreateDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarCreateData", ignore_extras);
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
    public static CalendarCreateDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CalendarCreateDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarCreateDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarCreateData", ignore_extras);
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
    public static CalendarCreateDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CalendarCreateDataJSON from_text(string text, bool ignore_extras)
      {
        CalendarCreateDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarCreateData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CalendarCreateDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CalendarCreateDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CalendarCreateDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarCreateData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorNextCreateAction : JSONStringGenerator
          {
            protected FieldGeneratorNextCreateAction(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorNextCreateAction()
              {
              }
            protected override void handle_result(string result)
              {
                TypeNextCreateActionKnownValues known = stringToNextCreateAction(result);
                TypeNextCreateAction new_value = new TypeNextCreateAction();
                if (known == TypeNextCreateActionKnownValues.NextCreateAction__none)
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
            protected abstract void handle_result(TypeNextCreateAction result);
          };
    private class FieldHoldingGeneratorNextCreateAction : FieldGeneratorNextCreateAction
  {
    protected override void handle_result(TypeNextCreateAction result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorNextCreateAction(String what)
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
    public TypeNextCreateAction value;
  };
    private class FieldHoldingArrayGeneratorNextCreateAction : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorNextCreateAction
      {
        private FieldHoldingArrayGeneratorNextCreateAction top;

        protected override void handle_result(TypeNextCreateAction result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorNextCreateAction init_top)
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
    protected virtual void handle_result(List<TypeNextCreateAction> result)
      {
      }

    public FieldHoldingArrayGeneratorNextCreateAction(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNextCreateAction>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorNextCreateAction()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNextCreateAction>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeNextCreateAction> value;
  };
        private FieldHoldingGeneratorNextCreateAction fieldGeneratorNextCreateAction;
    private abstract class FieldGeneratorLastCreateAction : JSONStringGenerator
          {
            protected FieldGeneratorLastCreateAction(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorLastCreateAction()
              {
              }
            protected override void handle_result(string result)
              {
                TypeLastCreateActionKnownValues known = stringToLastCreateAction(result);
                TypeLastCreateAction new_value = new TypeLastCreateAction();
                if (known == TypeLastCreateActionKnownValues.LastCreateAction__none)
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
            protected abstract void handle_result(TypeLastCreateAction result);
          };
    private class FieldHoldingGeneratorLastCreateAction : FieldGeneratorLastCreateAction
  {
    protected override void handle_result(TypeLastCreateAction result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorLastCreateAction(String what)
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
    public TypeLastCreateAction value;
  };
    private class FieldHoldingArrayGeneratorLastCreateAction : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLastCreateAction
      {
        private FieldHoldingArrayGeneratorLastCreateAction top;

        protected override void handle_result(TypeLastCreateAction result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLastCreateAction init_top)
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
    protected virtual void handle_result(List<TypeLastCreateAction> result)
      {
      }

    public FieldHoldingArrayGeneratorLastCreateAction(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLastCreateAction>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLastCreateAction()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLastCreateAction>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLastCreateAction> value;
  };
        private FieldHoldingGeneratorLastCreateAction fieldGeneratorLastCreateAction;
        private JSONHoldingStringGenerator fieldGeneratorItemKind;
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingStringGenerator fieldGeneratorLocation;
        private CalendarLocationJSON.HoldingGenerator fieldGeneratorLocationSpecifier;
        private JSONHoldingStringGenerator fieldGeneratorMapLocation;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorRequestedStart;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorRequestedEnd;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStart;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEnd;
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
        private JSONHoldingBooleanGenerator fieldGeneratorIsRecurring;
        private JSONHoldingStringGenerator fieldGeneratorRecurrenceRule;
        private DurationDataJSON.HoldingGenerator fieldGeneratorDurationData;
        private JSONHoldingBooleanGenerator fieldGeneratorIsAllDay;
    private abstract class FieldGeneratorAvailability : JSONStringGenerator
          {
            protected FieldGeneratorAvailability(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorAvailability()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToAvailability(result));
              }
            protected abstract void handle_result(TypeAvailability result);
          };
    private class FieldHoldingGeneratorAvailability : FieldGeneratorAvailability
  {
    protected override void handle_result(TypeAvailability result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorAvailability(String what)
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
    public TypeAvailability value;
  };
    private class FieldHoldingArrayGeneratorAvailability : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorAvailability
      {
        private FieldHoldingArrayGeneratorAvailability top;

        protected override void handle_result(TypeAvailability result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorAvailability init_top)
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
    protected virtual void handle_result(List<TypeAvailability> result)
      {
      }

    public FieldHoldingArrayGeneratorAvailability(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAvailability>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorAvailability()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAvailability>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeAvailability> value;
  };
        private FieldHoldingGeneratorAvailability fieldGeneratorAvailability;
        private JSONHoldingStringGenerator fieldGeneratorCalendarName;
        private JSONHoldingStringGenerator fieldGeneratorCalendarID;
        private JSONHoldingStringGenerator fieldGeneratorDescription;
        private JSONHoldingStringGenerator fieldGeneratorOrganizer;
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
    private abstract class FieldGeneratorAccessLevel : JSONStringGenerator
          {
            protected FieldGeneratorAccessLevel(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorAccessLevel()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToAccessLevel(result));
              }
            protected abstract void handle_result(TypeAccessLevel result);
          };
    private class FieldHoldingGeneratorAccessLevel : FieldGeneratorAccessLevel
  {
    protected override void handle_result(TypeAccessLevel result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorAccessLevel(String what)
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
    public TypeAccessLevel value;
  };
    private class FieldHoldingArrayGeneratorAccessLevel : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorAccessLevel
      {
        private FieldHoldingArrayGeneratorAccessLevel top;

        protected override void handle_result(TypeAccessLevel result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorAccessLevel init_top)
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
    protected virtual void handle_result(List<TypeAccessLevel> result)
      {
      }

    public FieldHoldingArrayGeneratorAccessLevel(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAccessLevel>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorAccessLevel()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAccessLevel>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeAccessLevel> value;
  };
        private FieldHoldingGeneratorAccessLevel fieldGeneratorAccessLevel;
        private CalendarAttendeeJSON.HoldingArrayGenerator fieldGeneratorAttendees;
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
            CalendarCreateDataJSON result = new CalendarCreateDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCalendarCreateDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CalendarCreateDataJSON result)
          {
            if (fieldGeneratorNextCreateAction.have_value)
              {
                result.setNextCreateAction(fieldGeneratorNextCreateAction.value);
                fieldGeneratorNextCreateAction.have_value = false;
              }
            else if ((!(result.hasNextCreateAction())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NextCreateAction\" field was missing.");
              }
            if (fieldGeneratorLastCreateAction.have_value)
              {
                result.setLastCreateAction(fieldGeneratorLastCreateAction.value);
                fieldGeneratorLastCreateAction.have_value = false;
              }
            if (fieldGeneratorItemKind.have_value)
              {
                result.setItemKind(fieldGeneratorItemKind.value);
                fieldGeneratorItemKind.have_value = false;
              }
            else if ((!(result.hasItemKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ItemKind\" field was missing.");
              }
            if (fieldGeneratorTitle.have_value)
              {
                result.setTitle(fieldGeneratorTitle.value);
                fieldGeneratorTitle.have_value = false;
              }
            else if ((!(result.hasTitle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Title\" field was missing.");
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
            if (fieldGeneratorMapLocation.have_value)
              {
                result.setMapLocation(fieldGeneratorMapLocation.value);
                fieldGeneratorMapLocation.have_value = false;
              }
            if (fieldGeneratorRequestedStart.have_value)
              {
                result.setRequestedStart(fieldGeneratorRequestedStart.value);
                fieldGeneratorRequestedStart.have_value = false;
              }
            if (fieldGeneratorRequestedEnd.have_value)
              {
                result.setRequestedEnd(fieldGeneratorRequestedEnd.value);
                fieldGeneratorRequestedEnd.have_value = false;
              }
            if (fieldGeneratorStart.have_value)
              {
                result.setStart(fieldGeneratorStart.value);
                fieldGeneratorStart.have_value = false;
              }
            else if ((!(result.hasStart())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Start\" field was missing.");
              }
            if (fieldGeneratorEnd.have_value)
              {
                result.setEnd(fieldGeneratorEnd.value);
                fieldGeneratorEnd.have_value = false;
              }
            else if ((!(result.hasEnd())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"End\" field was missing.");
              }
            if (fieldGeneratorClientShouldFindAppropriateTime.have_value)
              {
                result.setClientShouldFindAppropriateTime(fieldGeneratorClientShouldFindAppropriateTime.value);
                fieldGeneratorClientShouldFindAppropriateTime.have_value = false;
              }
            else if ((!(result.hasClientShouldFindAppropriateTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ClientShouldFindAppropriateTime\" field was missing.");
              }
            if (fieldGeneratorFrequencyType.have_value)
              {
                result.setFrequencyType(fieldGeneratorFrequencyType.value);
                fieldGeneratorFrequencyType.have_value = false;
              }
            else if ((!(result.hasFrequencyType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FrequencyType\" field was missing.");
              }
            if (fieldGeneratorFrequencyMultiplier.have_value)
              {
                result.setFrequencyMultiplier(fieldGeneratorFrequencyMultiplier.value);
                fieldGeneratorFrequencyMultiplier.have_value = false;
              }
            else if ((!(result.hasFrequencyMultiplier())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FrequencyMultiplier\" field was missing.");
              }
            if (fieldGeneratorIsRecurring.have_value)
              {
                result.setIsRecurring(fieldGeneratorIsRecurring.value);
                fieldGeneratorIsRecurring.have_value = false;
              }
            else if ((!(result.hasIsRecurring())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsRecurring\" field was missing.");
              }
            if (fieldGeneratorRecurrenceRule.have_value)
              {
                result.setRecurrenceRule(fieldGeneratorRecurrenceRule.value);
                fieldGeneratorRecurrenceRule.have_value = false;
              }
            if (fieldGeneratorDurationData.have_value)
              {
                result.setDurationData(fieldGeneratorDurationData.value);
                fieldGeneratorDurationData.have_value = false;
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
            if (fieldGeneratorAvailability.have_value)
              {
                result.setAvailability(fieldGeneratorAvailability.value);
                fieldGeneratorAvailability.have_value = false;
              }
            if (fieldGeneratorCalendarName.have_value)
              {
                result.setCalendarName(fieldGeneratorCalendarName.value);
                fieldGeneratorCalendarName.have_value = false;
              }
            if (fieldGeneratorCalendarID.have_value)
              {
                result.setCalendarID(fieldGeneratorCalendarID.value);
                fieldGeneratorCalendarID.have_value = false;
              }
            if (fieldGeneratorDescription.have_value)
              {
                result.setDescription(fieldGeneratorDescription.value);
                fieldGeneratorDescription.have_value = false;
              }
            if (fieldGeneratorOrganizer.have_value)
              {
                result.setOrganizer(fieldGeneratorOrganizer.value);
                fieldGeneratorOrganizer.have_value = false;
              }
            if (fieldGeneratorSelfAttendeeStatus.have_value)
              {
                result.setSelfAttendeeStatus(fieldGeneratorSelfAttendeeStatus.value);
                fieldGeneratorSelfAttendeeStatus.have_value = false;
              }
            if (fieldGeneratorAccessLevel.have_value)
              {
                result.setAccessLevel(fieldGeneratorAccessLevel.value);
                fieldGeneratorAccessLevel.have_value = false;
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
          }
        protected abstract void handle_result(CalendarCreateDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'c':
                            if ((String.Compare(field_name, 2, "cessLevel", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorAccessLevel;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "tendees", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorAttendees;
                            break;
                        case 'v':
                            if ((String.Compare(field_name, 2, "ailability", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorAvailability;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "lendar", 0, 6, false) == 0)
                              {
                                switch (field_name[8])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 9, "D", 0, 1, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorCalendarID;
                                        break;
                                    case 'N':
                                        if ((String.Compare(field_name, 9, "ame", 0, 3, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorCalendarName;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'l':
                            if ((String.Compare(field_name, 2, "ientShouldFindAppropriateTime", 0, 29, false) == 0) && (field_name.Length == 31))
                                return fieldGeneratorClientShouldFindAppropriateTime;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "scription", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorDescription;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "rationData", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorDurationData;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "nd", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorEnd;
                    break;
                case 'F':
                    if (String.Compare(field_name, 1, "requency", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
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
                    switch (field_name[1])
                      {
                        case 's':
                            switch (field_name[2])
                              {
                                case 'A':
                                    if ((String.Compare(field_name, 3, "llDay", 0, 5, false) == 0) && (field_name.Length == 8))
                                        return fieldGeneratorIsAllDay;
                                    break;
                                case 'R':
                                    if ((String.Compare(field_name, 3, "ecurring", 0, 8, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorIsRecurring;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "emKind", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorItemKind;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "stCreateAction", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorLastCreateAction;
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "cation", 0, 6, false) == 0)
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
                        default:
                            break;
                      }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "apLocation", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorMapLocation;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "extCreateAction", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorNextCreateAction;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "rganizer", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorOrganizer;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'c':
                                if ((String.Compare(field_name, 3, "urrenceRule", 0, 11, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorRecurrenceRule;
                                break;
                            case 'm':
                                if ((String.Compare(field_name, 3, "inders", 0, 6, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorReminders;
                                break;
                            case 'q':
                                if (String.Compare(field_name, 3, "uested", 0, 6, false) == 0)
                                  {
                                    switch (field_name[9])
                                      {
                                        case 'E':
                                            if ((String.Compare(field_name, 10, "nd", 0, 2, false) == 0) && (field_name.Length == 12))
                                                return fieldGeneratorRequestedEnd;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 10, "tart", 0, 4, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorRequestedStart;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "lfAttendeeStatus", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorSelfAttendeeStatus;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "art", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorStart;
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
            fieldGeneratorNextCreateAction = new FieldHoldingGeneratorNextCreateAction("field \"NextCreateAction\" of the CalendarCreateData class");
            fieldGeneratorLastCreateAction = new FieldHoldingGeneratorLastCreateAction("field \"LastCreateAction\" of the CalendarCreateData class");
            fieldGeneratorItemKind = new JSONHoldingStringGenerator("field \"ItemKind\" of the CalendarCreateData class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the CalendarCreateData class");
            fieldGeneratorLocation = new JSONHoldingStringGenerator("field \"Location\" of the CalendarCreateData class");
            fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the CalendarCreateData class", ignore_extras);
            fieldGeneratorMapLocation = new JSONHoldingStringGenerator("field \"MapLocation\" of the CalendarCreateData class");
            fieldGeneratorRequestedStart = new DateAndOrTimeJSON.HoldingGenerator("field \"RequestedStart\" of the CalendarCreateData class", ignore_extras);
            fieldGeneratorRequestedEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"RequestedEnd\" of the CalendarCreateData class", ignore_extras);
            fieldGeneratorStart = new DateAndOrTimeJSON.HoldingGenerator("field \"Start\" of the CalendarCreateData class", ignore_extras);
            fieldGeneratorEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"End\" of the CalendarCreateData class", ignore_extras);
            fieldGeneratorClientShouldFindAppropriateTime = new JSONHoldingBooleanGenerator("field \"ClientShouldFindAppropriateTime\" of the CalendarCreateData class");
            fieldGeneratorFrequencyType = new FieldHoldingGeneratorFrequencyType("field \"FrequencyType\" of the CalendarCreateData class");
            fieldGeneratorFrequencyMultiplier = new FieldHoldingGeneratorFrequencyMultiplier("field \"FrequencyMultiplier\" of the CalendarCreateData class");
            fieldGeneratorIsRecurring = new JSONHoldingBooleanGenerator("field \"IsRecurring\" of the CalendarCreateData class");
            fieldGeneratorRecurrenceRule = new JSONHoldingStringGenerator("field \"RecurrenceRule\" of the CalendarCreateData class");
            fieldGeneratorDurationData = new DurationDataJSON.HoldingGenerator("field \"DurationData\" of the CalendarCreateData class", ignore_extras);
            fieldGeneratorIsAllDay = new JSONHoldingBooleanGenerator("field \"IsAllDay\" of the CalendarCreateData class");
            fieldGeneratorAvailability = new FieldHoldingGeneratorAvailability("field \"Availability\" of the CalendarCreateData class");
            fieldGeneratorCalendarName = new JSONHoldingStringGenerator("field \"CalendarName\" of the CalendarCreateData class");
            fieldGeneratorCalendarID = new JSONHoldingStringGenerator("field \"CalendarID\" of the CalendarCreateData class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the CalendarCreateData class");
            fieldGeneratorOrganizer = new JSONHoldingStringGenerator("field \"Organizer\" of the CalendarCreateData class");
            fieldGeneratorSelfAttendeeStatus = new FieldHoldingGeneratorSelfAttendeeStatus("field \"SelfAttendeeStatus\" of the CalendarCreateData class");
            fieldGeneratorAccessLevel = new FieldHoldingGeneratorAccessLevel("field \"AccessLevel\" of the CalendarCreateData class");
            fieldGeneratorAttendees = new CalendarAttendeeJSON.HoldingArrayGenerator("field \"Attendees\" of the CalendarCreateData class", ignore_extras);
            fieldGeneratorReminders = new CalendarReminderJSON.HoldingArrayGenerator("field \"Reminders\" of the CalendarCreateData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CalendarCreateData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorNextCreateAction = new FieldHoldingGeneratorNextCreateAction("field \"NextCreateAction\" of the CalendarCreateData class");
            fieldGeneratorLastCreateAction = new FieldHoldingGeneratorLastCreateAction("field \"LastCreateAction\" of the CalendarCreateData class");
            fieldGeneratorItemKind = new JSONHoldingStringGenerator("field \"ItemKind\" of the CalendarCreateData class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the CalendarCreateData class");
            fieldGeneratorLocation = new JSONHoldingStringGenerator("field \"Location\" of the CalendarCreateData class");
            fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the CalendarCreateData class", false);
            fieldGeneratorMapLocation = new JSONHoldingStringGenerator("field \"MapLocation\" of the CalendarCreateData class");
            fieldGeneratorRequestedStart = new DateAndOrTimeJSON.HoldingGenerator("field \"RequestedStart\" of the CalendarCreateData class", false);
            fieldGeneratorRequestedEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"RequestedEnd\" of the CalendarCreateData class", false);
            fieldGeneratorStart = new DateAndOrTimeJSON.HoldingGenerator("field \"Start\" of the CalendarCreateData class", false);
            fieldGeneratorEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"End\" of the CalendarCreateData class", false);
            fieldGeneratorClientShouldFindAppropriateTime = new JSONHoldingBooleanGenerator("field \"ClientShouldFindAppropriateTime\" of the CalendarCreateData class");
            fieldGeneratorFrequencyType = new FieldHoldingGeneratorFrequencyType("field \"FrequencyType\" of the CalendarCreateData class");
            fieldGeneratorFrequencyMultiplier = new FieldHoldingGeneratorFrequencyMultiplier("field \"FrequencyMultiplier\" of the CalendarCreateData class");
            fieldGeneratorIsRecurring = new JSONHoldingBooleanGenerator("field \"IsRecurring\" of the CalendarCreateData class");
            fieldGeneratorRecurrenceRule = new JSONHoldingStringGenerator("field \"RecurrenceRule\" of the CalendarCreateData class");
            fieldGeneratorDurationData = new DurationDataJSON.HoldingGenerator("field \"DurationData\" of the CalendarCreateData class", false);
            fieldGeneratorIsAllDay = new JSONHoldingBooleanGenerator("field \"IsAllDay\" of the CalendarCreateData class");
            fieldGeneratorAvailability = new FieldHoldingGeneratorAvailability("field \"Availability\" of the CalendarCreateData class");
            fieldGeneratorCalendarName = new JSONHoldingStringGenerator("field \"CalendarName\" of the CalendarCreateData class");
            fieldGeneratorCalendarID = new JSONHoldingStringGenerator("field \"CalendarID\" of the CalendarCreateData class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the CalendarCreateData class");
            fieldGeneratorOrganizer = new JSONHoldingStringGenerator("field \"Organizer\" of the CalendarCreateData class");
            fieldGeneratorSelfAttendeeStatus = new FieldHoldingGeneratorSelfAttendeeStatus("field \"SelfAttendeeStatus\" of the CalendarCreateData class");
            fieldGeneratorAccessLevel = new FieldHoldingGeneratorAccessLevel("field \"AccessLevel\" of the CalendarCreateData class");
            fieldGeneratorAttendees = new CalendarAttendeeJSON.HoldingArrayGenerator("field \"Attendees\" of the CalendarCreateData class", false);
            fieldGeneratorReminders = new CalendarReminderJSON.HoldingArrayGenerator("field \"Reminders\" of the CalendarCreateData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CalendarCreateData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorNextCreateAction.reset();
            fieldGeneratorLastCreateAction.reset();
            fieldGeneratorItemKind.reset();
            fieldGeneratorTitle.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorLocationSpecifier.reset();
            fieldGeneratorMapLocation.reset();
            fieldGeneratorRequestedStart.reset();
            fieldGeneratorRequestedEnd.reset();
            fieldGeneratorStart.reset();
            fieldGeneratorEnd.reset();
            fieldGeneratorClientShouldFindAppropriateTime.reset();
            fieldGeneratorFrequencyType.reset();
            fieldGeneratorFrequencyMultiplier.reset();
            fieldGeneratorIsRecurring.reset();
            fieldGeneratorRecurrenceRule.reset();
            fieldGeneratorDurationData.reset();
            fieldGeneratorIsAllDay.reset();
            fieldGeneratorAvailability.reset();
            fieldGeneratorCalendarName.reset();
            fieldGeneratorCalendarID.reset();
            fieldGeneratorDescription.reset();
            fieldGeneratorOrganizer.reset();
            fieldGeneratorSelfAttendeeStatus.reset();
            fieldGeneratorAccessLevel.reset();
            fieldGeneratorAttendees.reset();
            fieldGeneratorReminders.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorLocationSpecifier.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestedStart.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestedEnd.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStart.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEnd.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDurationData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAttendees.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorReminders.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorLocationSpecifier.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestedStart.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestedEnd.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStart.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEnd.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDurationData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAttendees.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorReminders.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CalendarCreateDataJSON  result)
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
        public CalendarCreateDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CalendarCreateDataJSON  result)
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
    protected virtual void handle_result(List<CalendarCreateDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CalendarCreateDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CalendarCreateDataJSON>();
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
    public List<CalendarCreateDataJSON> value;
  };
  };
