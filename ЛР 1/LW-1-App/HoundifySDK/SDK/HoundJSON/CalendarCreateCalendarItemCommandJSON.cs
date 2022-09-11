/* file "CalendarCreateCalendarItemCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class CalendarCreateCalendarItemCommandJSON : CalendarCommandJSON
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

    public enum TypeAvailability
      {
        Availability_Free,
        Availability_Busy
      };

    public static TypeAvailability  stringToAvailability(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "usy", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeAvailability.Availability_Busy;
                break;
            case 'F':
                if ((String.Compare(chars, 1, "ree", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeAvailability.Availability_Free;
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
            case TypeAvailability.Availability_Free:
                return "Free";
            case TypeAvailability.Availability_Busy:
                return "Busy";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeNativeDataJSON : JSONBase
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

        public enum TypeAvailability
          {
            Availability_Free,
            Availability_Busy
          };

        public static TypeAvailability  stringToAvailability(string chars)
          {
            switch (chars[0])
              {
                case 'B':
                    if ((String.Compare(chars, 1, "usy", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeAvailability.Availability_Busy;
                    break;
                case 'F':
                    if ((String.Compare(chars, 1, "ree", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeAvailability.Availability_Free;
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
                case TypeAvailability.Availability_Free:
                    return "Free";
                case TypeAvailability.Availability_Busy:
                    return "Busy";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasItemKind;
        private string storeItemKind;
        private bool flagHasTitle;
        private string storeTitle;
        private bool flagHasLocation;
        private string storeLocation;
        private bool flagHasLocationSpecifier;
        private CalendarLocationJSON  storeLocationSpecifier;
        private bool flagHasAttendees;
        private List< CalendarAttendeeJSON  > storeAttendees;
        private bool flagHasReminders;
        private List< CalendarReminderJSON  > storeReminders;
        private bool flagHasSelfAttendeeStatus;
        private TypeSelfAttendeeStatus storeSelfAttendeeStatus;
        private bool flagHasStart;
        private DateAndOrTimeJSON  storeStart;
        private bool flagHasEnd;
        private DateAndOrTimeJSON  storeEnd;
        private bool flagHasFrequencyType;
        private TypeFrequencyType storeFrequencyType;
        private bool flagHasFrequencyMultiplier;
        private BigInteger storeFrequencyMultiplier;
        private bool flagHasRecurrenceRule;
        private string storeRecurrenceRule;
        private bool flagHasIsRecurring;
        private bool storeIsRecurring;
        private bool flagHasIsAllDay;
        private bool storeIsAllDay;
        private bool flagHasAvailability;
        private TypeAvailability storeAvailability;
        private bool flagHasStartAMPMAmbiguous;
        private bool storeStartAMPMAmbiguous;
        private bool flagHasEndAMPMAmbiguous;
        private bool storeEndAMPMAmbiguous;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONItemKind(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ItemKind of TypeNativeDataJSON is not a string.");
            setItemKind(json_string.getData());
          }


        private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Title of TypeNativeDataJSON is not a string.");
            setTitle(json_string.getData());
          }


        private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Location of TypeNativeDataJSON is not a string.");
            setLocation(json_string.getData());
          }


        private void  fromJSONLocationSpecifier(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            CalendarLocationJSON convert_classy = CalendarLocationJSON.from_json(json_value, ignore_extras, true);
            setLocationSpecifier(convert_classy);
          }


        private void  fromJSONAttendees(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Attendees of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field Attendees of TypeNativeDataJSON has too few elements.");
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
                throw new Exception("The value for field Reminders of TypeNativeDataJSON is not an array.");
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
                throw new Exception("The value for field SelfAttendeeStatus of TypeNativeDataJSON is not a string.");
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
            throw new Exception("The value for field SelfAttendeeStatus of TypeNativeDataJSON is not one of the legal strings.");
          enum_is_done:;
            setSelfAttendeeStatus(the_enum);
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


        private void  fromJSONFrequencyType(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field FrequencyType of TypeNativeDataJSON is not a string.");
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
            throw new Exception("The value for field FrequencyType of TypeNativeDataJSON is not one of the legal strings.");
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
                    throw new Exception("The value for field FrequencyMultiplier of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field FrequencyMultiplier of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setFrequencyMultiplier(extracted_integer);
          }


        private void  fromJSONRecurrenceRule(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field RecurrenceRule of TypeNativeDataJSON is not a string.");
            setRecurrenceRule(json_string.getData());
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
                    throw new Exception("The value for field IsRecurring of TypeNativeDataJSON is not true for false.");
                  }
              }
            setIsRecurring(the_bool);
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
                    throw new Exception("The value for field IsAllDay of TypeNativeDataJSON is not true for false.");
                  }
              }
            setIsAllDay(the_bool);
          }


        private void  fromJSONAvailability(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Availability of TypeNativeDataJSON is not a string.");
            TypeAvailability the_enum;
            switch (json_string.getData()[0])
              {
                case 'B':
                    if ((String.Compare(json_string.getData(), 1, "usy", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_enum = TypeAvailability.Availability_Busy;
                            goto enum_is_done;
                          }
                    break;
                case 'F':
                    if ((String.Compare(json_string.getData(), 1, "ree", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_enum = TypeAvailability.Availability_Free;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field Availability of TypeNativeDataJSON is not one of the legal strings.");
          enum_is_done:;
            setAvailability(the_enum);
          }


        private void  fromJSONStartAMPMAmbiguous(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field StartAMPMAmbiguous of TypeNativeDataJSON is not true for false.");
                  }
              }
            setStartAMPMAmbiguous(the_bool);
          }


        private void  fromJSONEndAMPMAmbiguous(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field EndAMPMAmbiguous of TypeNativeDataJSON is not true for false.");
                  }
              }
            setEndAMPMAmbiguous(the_bool);
          }


        public TypeNativeDataJSON()
          {
            flagHasItemKind = false;
            flagHasTitle = false;
            flagHasLocation = false;
            flagHasLocationSpecifier = false;
            flagHasAttendees = false;
            flagHasReminders = false;
            flagHasSelfAttendeeStatus = false;
            flagHasStart = false;
            flagHasEnd = false;
            flagHasFrequencyType = false;
            flagHasFrequencyMultiplier = false;
            flagHasRecurrenceRule = false;
            flagHasIsRecurring = false;
            flagHasIsAllDay = false;
            flagHasAvailability = false;
            flagHasStartAMPMAmbiguous = false;
            flagHasEndAMPMAmbiguous = false;
            storeAttendees = new List< CalendarAttendeeJSON  >();
            storeReminders = new List< CalendarReminderJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
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

        public bool  hasRecurrenceRule()
          {
            return flagHasRecurrenceRule;
          }

        public string  getRecurrenceRule()
          {
            Debug.Assert(flagHasRecurrenceRule);
            return storeRecurrenceRule;
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

        public bool  hasStartAMPMAmbiguous()
          {
            return flagHasStartAMPMAmbiguous;
          }

        public bool  getStartAMPMAmbiguous()
          {
            Debug.Assert(flagHasStartAMPMAmbiguous);
            return storeStartAMPMAmbiguous;
          }

        public bool  hasEndAMPMAmbiguous()
          {
            return flagHasEndAMPMAmbiguous;
          }

        public bool  getEndAMPMAmbiguous()
          {
            Debug.Assert(flagHasEndAMPMAmbiguous);
            return storeEndAMPMAmbiguous;
          }


        public virtual int extraTypeNativeDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNativeDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNativeDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNativeDataLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
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
                throw new Exception("The value for field FrequencyMultiplier of TypeNativeDataJSON is less than the lower bound (1) for that field.");
            storeFrequencyMultiplier = new_value;
          }
        public void unsetFrequencyMultiplier()
          {
            flagHasFrequencyMultiplier = false;
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
        public void setIsRecurring(bool new_value)
          {
            flagHasIsRecurring = true;
            storeIsRecurring = new_value;
          }
        public void unsetIsRecurring()
          {
            flagHasIsRecurring = false;
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
        public void setStartAMPMAmbiguous(bool new_value)
          {
            flagHasStartAMPMAmbiguous = true;
            storeStartAMPMAmbiguous = new_value;
          }
        public void unsetStartAMPMAmbiguous()
          {
            flagHasStartAMPMAmbiguous = false;
          }
        public void setEndAMPMAmbiguous(bool new_value)
          {
            flagHasEndAMPMAmbiguous = true;
            storeEndAMPMAmbiguous = new_value;
          }
        public void unsetEndAMPMAmbiguous()
          {
            flagHasEndAMPMAmbiguous = false;
          }

        public virtual void extraTypeNativeDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNativeDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNativeDataLookup(key);
            if (old_field == null)
              {
                extraTypeNativeDataAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasLocation);
            if (flagHasLocation)
              {
                handler.start_pair("Location");
                handler.string_value(storeLocation);
              }
            Debug.Assert(partial_allowed || flagHasLocationSpecifier);
            if (flagHasLocationSpecifier)
              {
                handler.start_pair("LocationSpecifier");
                if (partial_allowed)
                    storeLocationSpecifier.write_partial_as_json(handler);
                else
                    storeLocationSpecifier.write_as_json(handler);
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
            if (flagHasRecurrenceRule)
              {
                handler.start_pair("RecurrenceRule");
                handler.string_value(storeRecurrenceRule);
              }
            Debug.Assert(partial_allowed || flagHasIsRecurring);
            if (flagHasIsRecurring)
              {
                handler.start_pair("IsRecurring");
                handler.boolean_value(storeIsRecurring);
              }
            Debug.Assert(partial_allowed || flagHasIsAllDay);
            if (flagHasIsAllDay)
              {
                handler.start_pair("IsAllDay");
                handler.boolean_value(storeIsAllDay);
              }
            Debug.Assert(partial_allowed || flagHasAvailability);
            if (flagHasAvailability)
              {
                handler.start_pair("Availability");
                switch (storeAvailability)
                  {
                    case TypeAvailability.Availability_Free:
                        handler.string_value("Free");
                        break;
                    case TypeAvailability.Availability_Busy:
                        handler.string_value("Busy");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            Debug.Assert(partial_allowed || flagHasStartAMPMAmbiguous);
            if (flagHasStartAMPMAmbiguous)
              {
                handler.start_pair("StartAMPMAmbiguous");
                handler.boolean_value(storeStartAMPMAmbiguous);
              }
            Debug.Assert(partial_allowed || flagHasEndAMPMAmbiguous);
            if (flagHasEndAMPMAmbiguous)
              {
                handler.start_pair("EndAMPMAmbiguous");
                handler.boolean_value(storeEndAMPMAmbiguous);
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
            if (!(hasItemKind()))
              {
                return "When parsing the object for %what%, the \"ItemKind\" field was missing.";
              }
            if (!(hasTitle()))
              {
                return "When parsing the object for %what%, the \"Title\" field was missing.";
              }
            if (!(hasLocation()))
              {
                return "When parsing the object for %what%, the \"Location\" field was missing.";
              }
            if (!(hasLocationSpecifier()))
              {
                return "When parsing the object for %what%, the \"LocationSpecifier\" field was missing.";
              }
            if (!(hasStart()))
              {
                return "When parsing the object for %what%, the \"Start\" field was missing.";
              }
            if (!(hasEnd()))
              {
                return "When parsing the object for %what%, the \"End\" field was missing.";
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
            if (!(hasAvailability()))
              {
                return "When parsing the object for %what%, the \"Availability\" field was missing.";
              }
            if (!(hasStartAMPMAmbiguous()))
              {
                return "When parsing the object for %what%, the \"StartAMPMAmbiguous\" field was missing.";
              }
            if (!(hasEndAMPMAmbiguous()))
              {
                return "When parsing the object for %what%, the \"EndAMPMAmbiguous\" field was missing.";
              }
            return null;
          }

        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_text(string text, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNativeDataJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorItemKind;
            private JSONHoldingStringGenerator fieldGeneratorTitle;
            private JSONHoldingStringGenerator fieldGeneratorLocation;
            private CalendarLocationJSON.HoldingGenerator fieldGeneratorLocationSpecifier;
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
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStart;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEnd;
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
            private JSONHoldingStringGenerator fieldGeneratorRecurrenceRule;
            private JSONHoldingBooleanGenerator fieldGeneratorIsRecurring;
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
            private JSONHoldingBooleanGenerator fieldGeneratorStartAMPMAmbiguous;
            private JSONHoldingBooleanGenerator fieldGeneratorEndAMPMAmbiguous;
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
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
              {
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
                else if ((!(result.hasLocation())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Location\" field was missing.");
                  }
                if (fieldGeneratorLocationSpecifier.have_value)
                  {
                    result.setLocationSpecifier(fieldGeneratorLocationSpecifier.value);
                    fieldGeneratorLocationSpecifier.have_value = false;
                  }
                else if ((!(result.hasLocationSpecifier())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"LocationSpecifier\" field was missing.");
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
                if (fieldGeneratorRecurrenceRule.have_value)
                  {
                    result.setRecurrenceRule(fieldGeneratorRecurrenceRule.value);
                    fieldGeneratorRecurrenceRule.have_value = false;
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
                else if ((!(result.hasAvailability())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Availability\" field was missing.");
                  }
                if (fieldGeneratorStartAMPMAmbiguous.have_value)
                  {
                    result.setStartAMPMAmbiguous(fieldGeneratorStartAMPMAmbiguous.value);
                    fieldGeneratorStartAMPMAmbiguous.have_value = false;
                  }
                else if ((!(result.hasStartAMPMAmbiguous())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"StartAMPMAmbiguous\" field was missing.");
                  }
                if (fieldGeneratorEndAMPMAmbiguous.have_value)
                  {
                    result.setEndAMPMAmbiguous(fieldGeneratorEndAMPMAmbiguous.value);
                    fieldGeneratorEndAMPMAmbiguous.have_value = false;
                  }
                else if ((!(result.hasEndAMPMAmbiguous())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"EndAMPMAmbiguous\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        switch (field_name[1])
                          {
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
                    case 'E':
                        if (String.Compare(field_name, 1, "nd", 0, 2, false) == 0)
                          {
                            if (field_name.Length == 3)
                              {
                                return fieldGeneratorEnd;
                              }
                            switch (field_name[3])
                              {
                                case 'A':
                                    if ((String.Compare(field_name, 4, "MPMAmbiguous", 0, 12, false) == 0) && (field_name.Length == 16))
                                        return fieldGeneratorEndAMPMAmbiguous;
                                    break;
                                default:
                                    break;
                              }
                          }
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
                                if (String.Compare(field_name, 2, "art", 0, 3, false) == 0)
                                  {
                                    if (field_name.Length == 5)
                                      {
                                        return fieldGeneratorStart;
                                      }
                                    switch (field_name[5])
                                      {
                                        case 'A':
                                            if ((String.Compare(field_name, 6, "MPMAmbiguous", 0, 12, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorStartAMPMAmbiguous;
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
                fieldGeneratorItemKind = new JSONHoldingStringGenerator("field \"ItemKind\" of the TypeNativeData class");
                fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the TypeNativeData class");
                fieldGeneratorLocation = new JSONHoldingStringGenerator("field \"Location\" of the TypeNativeData class");
                fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorAttendees = new CalendarAttendeeJSON.HoldingArrayGenerator("field \"Attendees\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorReminders = new CalendarReminderJSON.HoldingArrayGenerator("field \"Reminders\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorSelfAttendeeStatus = new FieldHoldingGeneratorSelfAttendeeStatus("field \"SelfAttendeeStatus\" of the TypeNativeData class");
                fieldGeneratorStart = new DateAndOrTimeJSON.HoldingGenerator("field \"Start\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"End\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorFrequencyType = new FieldHoldingGeneratorFrequencyType("field \"FrequencyType\" of the TypeNativeData class");
                fieldGeneratorFrequencyMultiplier = new FieldHoldingGeneratorFrequencyMultiplier("field \"FrequencyMultiplier\" of the TypeNativeData class");
                fieldGeneratorRecurrenceRule = new JSONHoldingStringGenerator("field \"RecurrenceRule\" of the TypeNativeData class");
                fieldGeneratorIsRecurring = new JSONHoldingBooleanGenerator("field \"IsRecurring\" of the TypeNativeData class");
                fieldGeneratorIsAllDay = new JSONHoldingBooleanGenerator("field \"IsAllDay\" of the TypeNativeData class");
                fieldGeneratorAvailability = new FieldHoldingGeneratorAvailability("field \"Availability\" of the TypeNativeData class");
                fieldGeneratorStartAMPMAmbiguous = new JSONHoldingBooleanGenerator("field \"StartAMPMAmbiguous\" of the TypeNativeData class");
                fieldGeneratorEndAMPMAmbiguous = new JSONHoldingBooleanGenerator("field \"EndAMPMAmbiguous\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorItemKind = new JSONHoldingStringGenerator("field \"ItemKind\" of the TypeNativeData class");
                fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the TypeNativeData class");
                fieldGeneratorLocation = new JSONHoldingStringGenerator("field \"Location\" of the TypeNativeData class");
                fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the TypeNativeData class", false);
                fieldGeneratorAttendees = new CalendarAttendeeJSON.HoldingArrayGenerator("field \"Attendees\" of the TypeNativeData class", false);
                fieldGeneratorReminders = new CalendarReminderJSON.HoldingArrayGenerator("field \"Reminders\" of the TypeNativeData class", false);
                fieldGeneratorSelfAttendeeStatus = new FieldHoldingGeneratorSelfAttendeeStatus("field \"SelfAttendeeStatus\" of the TypeNativeData class");
                fieldGeneratorStart = new DateAndOrTimeJSON.HoldingGenerator("field \"Start\" of the TypeNativeData class", false);
                fieldGeneratorEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"End\" of the TypeNativeData class", false);
                fieldGeneratorFrequencyType = new FieldHoldingGeneratorFrequencyType("field \"FrequencyType\" of the TypeNativeData class");
                fieldGeneratorFrequencyMultiplier = new FieldHoldingGeneratorFrequencyMultiplier("field \"FrequencyMultiplier\" of the TypeNativeData class");
                fieldGeneratorRecurrenceRule = new JSONHoldingStringGenerator("field \"RecurrenceRule\" of the TypeNativeData class");
                fieldGeneratorIsRecurring = new JSONHoldingBooleanGenerator("field \"IsRecurring\" of the TypeNativeData class");
                fieldGeneratorIsAllDay = new JSONHoldingBooleanGenerator("field \"IsAllDay\" of the TypeNativeData class");
                fieldGeneratorAvailability = new FieldHoldingGeneratorAvailability("field \"Availability\" of the TypeNativeData class");
                fieldGeneratorStartAMPMAmbiguous = new JSONHoldingBooleanGenerator("field \"StartAMPMAmbiguous\" of the TypeNativeData class");
                fieldGeneratorEndAMPMAmbiguous = new JSONHoldingBooleanGenerator("field \"EndAMPMAmbiguous\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorItemKind.reset();
                fieldGeneratorTitle.reset();
                fieldGeneratorLocation.reset();
                fieldGeneratorLocationSpecifier.reset();
                fieldGeneratorAttendees.reset();
                fieldGeneratorReminders.reset();
                fieldGeneratorSelfAttendeeStatus.reset();
                fieldGeneratorStart.reset();
                fieldGeneratorEnd.reset();
                fieldGeneratorFrequencyType.reset();
                fieldGeneratorFrequencyMultiplier.reset();
                fieldGeneratorRecurrenceRule.reset();
                fieldGeneratorIsRecurring.reset();
                fieldGeneratorIsAllDay.reset();
                fieldGeneratorAvailability.reset();
                fieldGeneratorStartAMPMAmbiguous.reset();
                fieldGeneratorEndAMPMAmbiguous.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorLocationSpecifier.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorAttendees.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorReminders.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorStart.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorEnd.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorLocationSpecifier.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorAttendees.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorReminders.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorStart.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorEnd.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeNativeDataJSON  result)
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
            public TypeNativeDataJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNativeDataJSON  result)
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
        protected virtual void handle_result(List<TypeNativeDataJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNativeDataJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNativeDataJSON>();
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
        public List<TypeNativeDataJSON> value;
      };
      };
    private bool flagHasItemKind;
    private string storeItemKind;
    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasLocation;
    private string storeLocation;
    private bool flagHasLocationSpecifier;
    private CalendarLocationJSON  storeLocationSpecifier;
    private bool flagHasAttendees;
    private List< CalendarAttendeeJSON  > storeAttendees;
    private bool flagHasReminders;
    private List< CalendarReminderJSON  > storeReminders;
    private bool flagHasSelfAttendeeStatus;
    private TypeSelfAttendeeStatus storeSelfAttendeeStatus;
    private bool flagHasStart;
    private DateAndOrTimeJSON  storeStart;
    private bool flagHasEnd;
    private DateAndOrTimeJSON  storeEnd;
    private bool flagHasFrequencyType;
    private TypeFrequencyType storeFrequencyType;
    private bool flagHasFrequencyMultiplier;
    private BigInteger storeFrequencyMultiplier;
    private bool flagHasRecurrenceRule;
    private string storeRecurrenceRule;
    private bool flagHasIsRecurring;
    private bool storeIsRecurring;
    private bool flagHasIsAllDay;
    private bool storeIsAllDay;
    private bool flagHasAvailability;
    private TypeAvailability storeAvailability;
    private bool flagHasStartAMPMAmbiguous;
    private bool storeStartAMPMAmbiguous;
    private bool flagHasEndAMPMAmbiguous;
    private bool storeEndAMPMAmbiguous;
    private bool flagHasNativeData;
    private TypeNativeDataJSON  storeNativeData;
    private bool flagHasEventsConflictResult;
    private DynamicResponseJSON  storeEventsConflictResult;
    private bool flagHasCalendarPreferenceIsNotSetResult;
    private DynamicResponseJSON  storeCalendarPreferenceIsNotSetResult;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraItemKindToJSON()
      {
        JSONStringValue generated_string_ItemKind = new JSONStringValue(storeItemKind);
        return generated_string_ItemKind;
      }

    private JSONValue  extraTitleToJSON()
      {
        JSONStringValue generated_string_Title = new JSONStringValue(storeTitle);
        return generated_string_Title;
      }

    private JSONValue  extraLocationToJSON()
      {
        JSONStringValue generated_string_Location = new JSONStringValue(storeLocation);
        return generated_string_Location;
      }

    private JSONValue  extraLocationSpecifierToJSON()
      {
        JSONValueHandler handler_LocationSpecifier = new JSONValueHandler();
        storeLocationSpecifier.write_as_json(handler_LocationSpecifier);
        return handler_LocationSpecifier.result;
      }

    private JSONValue  extraAttendeesToJSON()
      {
        JSONArrayValue generated_array_1_Attendees = new JSONArrayValue();
        for (int num1 = 0; num1 < storeAttendees.Count; ++num1)
          {
            JSONValueHandler handler_Attendees = new JSONValueHandler();
            storeAttendees[num1].write_as_json(handler_Attendees);
            generated_array_1_Attendees.appendComponent(handler_Attendees.result);
          }
        return generated_array_1_Attendees;
      }

    private JSONValue  extraRemindersToJSON()
      {
        JSONArrayValue generated_array_2_Reminders = new JSONArrayValue();
        for (int num2 = 0; num2 < storeReminders.Count; ++num2)
          {
            JSONValueHandler handler_Reminders = new JSONValueHandler();
            storeReminders[num2].write_as_json(handler_Reminders);
            generated_array_2_Reminders.appendComponent(handler_Reminders.result);
          }
        return generated_array_2_Reminders;
      }

    private JSONValue  extraSelfAttendeeStatusToJSON()
      {
        JSONStringValue generated_string_SelfAttendeeStatus;
        switch (storeSelfAttendeeStatus)
          {
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_None:
                generated_string_SelfAttendeeStatus = new JSONStringValue("None");
                break;
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted:
                generated_string_SelfAttendeeStatus = new JSONStringValue("Accepted");
                break;
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined:
                generated_string_SelfAttendeeStatus = new JSONStringValue("Declined");
                break;
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited:
                generated_string_SelfAttendeeStatus = new JSONStringValue("Invited");
                break;
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative:
                generated_string_SelfAttendeeStatus = new JSONStringValue("Tentative");
                break;
            default:
                Debug.Assert(false);
                generated_string_SelfAttendeeStatus = null;
                break;
          }
        return generated_string_SelfAttendeeStatus;
      }

    private JSONValue  extraStartToJSON()
      {
        JSONValueHandler handler_Start = new JSONValueHandler();
        storeStart.write_as_json(handler_Start);
        return handler_Start.result;
      }

    private JSONValue  extraEndToJSON()
      {
        JSONValueHandler handler_End = new JSONValueHandler();
        storeEnd.write_as_json(handler_End);
        return handler_End.result;
      }

    private JSONValue  extraFrequencyTypeToJSON()
      {
        JSONStringValue generated_string_FrequencyType;
        switch (storeFrequencyType)
          {
            case TypeFrequencyType.FrequencyType_unknown:
                generated_string_FrequencyType = new JSONStringValue("unknown");
                break;
            case TypeFrequencyType.FrequencyType_one_time:
                generated_string_FrequencyType = new JSONStringValue("one-time");
                break;
            case TypeFrequencyType.FrequencyType_daily:
                generated_string_FrequencyType = new JSONStringValue("daily");
                break;
            case TypeFrequencyType.FrequencyType_weekly:
                generated_string_FrequencyType = new JSONStringValue("weekly");
                break;
            case TypeFrequencyType.FrequencyType_monthly:
                generated_string_FrequencyType = new JSONStringValue("monthly");
                break;
            case TypeFrequencyType.FrequencyType_yearly:
                generated_string_FrequencyType = new JSONStringValue("yearly");
                break;
            default:
                Debug.Assert(false);
                generated_string_FrequencyType = null;
                break;
          }
        return generated_string_FrequencyType;
      }

    private JSONValue  extraFrequencyMultiplierToJSON()
      {
        JSONIntegerValue generated_integer_FrequencyMultiplier = new JSONIntegerValue(storeFrequencyMultiplier);
        return generated_integer_FrequencyMultiplier;
      }

    private JSONValue  extraRecurrenceRuleToJSON()
      {
        JSONStringValue generated_string_RecurrenceRule = new JSONStringValue(storeRecurrenceRule);
        return generated_string_RecurrenceRule;
      }

    private JSONValue  extraIsRecurringToJSON()
      {
        JSONValue generated_boolean_IsRecurring = (storeIsRecurring ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsRecurring;
      }

    private JSONValue  extraIsAllDayToJSON()
      {
        JSONValue generated_boolean_IsAllDay = (storeIsAllDay ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsAllDay;
      }

    private JSONValue  extraAvailabilityToJSON()
      {
        JSONStringValue generated_string_Availability;
        switch (storeAvailability)
          {
            case TypeAvailability.Availability_Free:
                generated_string_Availability = new JSONStringValue("Free");
                break;
            case TypeAvailability.Availability_Busy:
                generated_string_Availability = new JSONStringValue("Busy");
                break;
            default:
                Debug.Assert(false);
                generated_string_Availability = null;
                break;
          }
        return generated_string_Availability;
      }

    private JSONValue  extraStartAMPMAmbiguousToJSON()
      {
        JSONValue generated_boolean_StartAMPMAmbiguous = (storeStartAMPMAmbiguous ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_StartAMPMAmbiguous;
      }

    private JSONValue  extraEndAMPMAmbiguousToJSON()
      {
        JSONValue generated_boolean_EndAMPMAmbiguous = (storeEndAMPMAmbiguous ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_EndAMPMAmbiguous;
      }

    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }

    private JSONValue  extraEventsConflictResultToJSON()
      {
        JSONValueHandler handler_EventsConflictResult = new JSONValueHandler();
        storeEventsConflictResult.write_as_json(handler_EventsConflictResult);
        return handler_EventsConflictResult.result;
      }

    private JSONValue  extraCalendarPreferenceIsNotSetResultToJSON()
      {
        JSONValueHandler handler_CalendarPreferenceIsNotSetResult = new JSONValueHandler();
        storeCalendarPreferenceIsNotSetResult.write_as_json(handler_CalendarPreferenceIsNotSetResult);
        return handler_CalendarPreferenceIsNotSetResult.result;
      }


    private void  fromJSONItemKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ItemKind of CalendarCreateCalendarItemCommandJSON is not a string.");
        setItemKind(json_string.getData());
      }


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of CalendarCreateCalendarItemCommandJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Location of CalendarCreateCalendarItemCommandJSON is not a string.");
        setLocation(json_string.getData());
      }


    private void  fromJSONLocationSpecifier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CalendarLocationJSON convert_classy = CalendarLocationJSON.from_json(json_value, ignore_extras, true);
        setLocationSpecifier(convert_classy);
      }


    private void  fromJSONAttendees(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Attendees of CalendarCreateCalendarItemCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Attendees of CalendarCreateCalendarItemCommandJSON has too few elements.");
        List< CalendarAttendeeJSON  > vector_Attendees1 = new List< CalendarAttendeeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CalendarAttendeeJSON convert_classy = CalendarAttendeeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Attendees1.Add(convert_classy);
          }
        Debug.Assert(vector_Attendees1.Count >= 1);
        initAttendees();
        for (int num3 = 0; num3 < vector_Attendees1.Count; ++num3)
            appendAttendees(vector_Attendees1[num3]);
        for (int num1 = 0; num1 < vector_Attendees1.Count; ++num1)
          {
          }
      }


    private void  fromJSONReminders(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Reminders of CalendarCreateCalendarItemCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< CalendarReminderJSON  > vector_Reminders1 = new List< CalendarReminderJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CalendarReminderJSON convert_classy = CalendarReminderJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Reminders1.Add(convert_classy);
          }
        initReminders();
        for (int num4 = 0; num4 < vector_Reminders1.Count; ++num4)
            appendReminders(vector_Reminders1[num4]);
        for (int num1 = 0; num1 < vector_Reminders1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSelfAttendeeStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SelfAttendeeStatus of CalendarCreateCalendarItemCommandJSON is not a string.");
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
        throw new Exception("The value for field SelfAttendeeStatus of CalendarCreateCalendarItemCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setSelfAttendeeStatus(the_enum);
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


    private void  fromJSONFrequencyType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FrequencyType of CalendarCreateCalendarItemCommandJSON is not a string.");
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
        throw new Exception("The value for field FrequencyType of CalendarCreateCalendarItemCommandJSON is not one of the legal strings.");
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
                throw new Exception("The value for field FrequencyMultiplier of CalendarCreateCalendarItemCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FrequencyMultiplier of CalendarCreateCalendarItemCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFrequencyMultiplier(extracted_integer);
      }


    private void  fromJSONRecurrenceRule(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RecurrenceRule of CalendarCreateCalendarItemCommandJSON is not a string.");
        setRecurrenceRule(json_string.getData());
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
                throw new Exception("The value for field IsRecurring of CalendarCreateCalendarItemCommandJSON is not true for false.");
              }
          }
        setIsRecurring(the_bool);
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
                throw new Exception("The value for field IsAllDay of CalendarCreateCalendarItemCommandJSON is not true for false.");
              }
          }
        setIsAllDay(the_bool);
      }


    private void  fromJSONAvailability(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Availability of CalendarCreateCalendarItemCommandJSON is not a string.");
        TypeAvailability the_enum;
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "usy", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeAvailability.Availability_Busy;
                        goto enum_is_done;
                      }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "ree", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeAvailability.Availability_Free;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Availability of CalendarCreateCalendarItemCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setAvailability(the_enum);
      }


    private void  fromJSONStartAMPMAmbiguous(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StartAMPMAmbiguous of CalendarCreateCalendarItemCommandJSON is not true for false.");
              }
          }
        setStartAMPMAmbiguous(the_bool);
      }


    private void  fromJSONEndAMPMAmbiguous(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field EndAMPMAmbiguous of CalendarCreateCalendarItemCommandJSON is not true for false.");
              }
          }
        setEndAMPMAmbiguous(the_bool);
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    private void  fromJSONEventsConflictResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setEventsConflictResult(convert_classy);
      }


    private void  fromJSONCalendarPreferenceIsNotSetResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setCalendarPreferenceIsNotSetResult(convert_classy);
      }


    public CalendarCreateCalendarItemCommandJSON()
      {
        flagHasItemKind = false;
        flagHasTitle = false;
        flagHasLocation = false;
        flagHasLocationSpecifier = false;
        flagHasAttendees = false;
        flagHasReminders = false;
        flagHasSelfAttendeeStatus = false;
        flagHasStart = false;
        flagHasEnd = false;
        flagHasFrequencyType = false;
        flagHasFrequencyMultiplier = false;
        flagHasRecurrenceRule = false;
        flagHasIsRecurring = false;
        flagHasIsAllDay = false;
        flagHasAvailability = false;
        flagHasStartAMPMAmbiguous = false;
        flagHasEndAMPMAmbiguous = false;
        flagHasNativeData = false;
        flagHasEventsConflictResult = false;
        flagHasCalendarPreferenceIsNotSetResult = false;
        storeAttendees = new List< CalendarAttendeeJSON  >();
        storeReminders = new List< CalendarReminderJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCalendarCommandKind()
      {
        return "CreateItem";
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

    public bool  hasRecurrenceRule()
      {
        return flagHasRecurrenceRule;
      }

    public string  getRecurrenceRule()
      {
        Debug.Assert(flagHasRecurrenceRule);
        return storeRecurrenceRule;
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

    public bool  hasStartAMPMAmbiguous()
      {
        return flagHasStartAMPMAmbiguous;
      }

    public bool  getStartAMPMAmbiguous()
      {
        Debug.Assert(flagHasStartAMPMAmbiguous);
        return storeStartAMPMAmbiguous;
      }

    public bool  hasEndAMPMAmbiguous()
      {
        return flagHasEndAMPMAmbiguous;
      }

    public bool  getEndAMPMAmbiguous()
      {
        Debug.Assert(flagHasEndAMPMAmbiguous);
        return storeEndAMPMAmbiguous;
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public TypeNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }

    public bool  hasEventsConflictResult()
      {
        return flagHasEventsConflictResult;
      }

    public DynamicResponseJSON   getEventsConflictResult()
      {
        Debug.Assert(flagHasEventsConflictResult);
        return storeEventsConflictResult;
      }

    public bool  hasCalendarPreferenceIsNotSetResult()
      {
        return flagHasCalendarPreferenceIsNotSetResult;
      }

    public DynamicResponseJSON   getCalendarPreferenceIsNotSetResult()
      {
        Debug.Assert(flagHasCalendarPreferenceIsNotSetResult);
        return storeCalendarPreferenceIsNotSetResult;
      }


    public virtual int extraCalendarCreateCalendarItemCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCalendarCreateCalendarItemCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCalendarCreateCalendarItemCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCalendarCreateCalendarItemCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCalendarCommandComponentCount()
      {
        int result = 0;
        if (flagHasItemKind)
            ++result;
        if (flagHasTitle)
            ++result;
        if (flagHasLocation)
            ++result;
        if (flagHasLocationSpecifier)
            ++result;
        if (flagHasAttendees)
            ++result;
        if (flagHasReminders)
            ++result;
        if (flagHasSelfAttendeeStatus)
            ++result;
        if (flagHasStart)
            ++result;
        if (flagHasEnd)
            ++result;
        if (flagHasFrequencyType)
            ++result;
        if (flagHasFrequencyMultiplier)
            ++result;
        if (flagHasRecurrenceRule)
            ++result;
        if (flagHasIsRecurring)
            ++result;
        if (flagHasIsAllDay)
            ++result;
        if (flagHasAvailability)
            ++result;
        if (flagHasStartAMPMAmbiguous)
            ++result;
        if (flagHasEndAMPMAmbiguous)
            ++result;
        if (flagHasNativeData)
            ++result;
        if (flagHasEventsConflictResult)
            ++result;
        if (flagHasCalendarPreferenceIsNotSetResult)
            ++result;
        result += extraCalendarCreateCalendarItemCommandComponentCount();
        return result;
      }
    public override string extraCalendarCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasItemKind)
          {
            if (remainder == 0)
                return "ItemKind";
            --remainder;
          }
        if (flagHasTitle)
          {
            if (remainder == 0)
                return "Title";
            --remainder;
          }
        if (flagHasLocation)
          {
            if (remainder == 0)
                return "Location";
            --remainder;
          }
        if (flagHasLocationSpecifier)
          {
            if (remainder == 0)
                return "LocationSpecifier";
            --remainder;
          }
        if (flagHasAttendees)
          {
            if (remainder == 0)
                return "Attendees";
            --remainder;
          }
        if (flagHasReminders)
          {
            if (remainder == 0)
                return "Reminders";
            --remainder;
          }
        if (flagHasSelfAttendeeStatus)
          {
            if (remainder == 0)
                return "SelfAttendeeStatus";
            --remainder;
          }
        if (flagHasStart)
          {
            if (remainder == 0)
                return "Start";
            --remainder;
          }
        if (flagHasEnd)
          {
            if (remainder == 0)
                return "End";
            --remainder;
          }
        if (flagHasFrequencyType)
          {
            if (remainder == 0)
                return "FrequencyType";
            --remainder;
          }
        if (flagHasFrequencyMultiplier)
          {
            if (remainder == 0)
                return "FrequencyMultiplier";
            --remainder;
          }
        if (flagHasRecurrenceRule)
          {
            if (remainder == 0)
                return "RecurrenceRule";
            --remainder;
          }
        if (flagHasIsRecurring)
          {
            if (remainder == 0)
                return "IsRecurring";
            --remainder;
          }
        if (flagHasIsAllDay)
          {
            if (remainder == 0)
                return "IsAllDay";
            --remainder;
          }
        if (flagHasAvailability)
          {
            if (remainder == 0)
                return "Availability";
            --remainder;
          }
        if (flagHasStartAMPMAmbiguous)
          {
            if (remainder == 0)
                return "StartAMPMAmbiguous";
            --remainder;
          }
        if (flagHasEndAMPMAmbiguous)
          {
            if (remainder == 0)
                return "EndAMPMAmbiguous";
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        if (flagHasEventsConflictResult)
          {
            if (remainder == 0)
                return "EventsConflictResult";
            --remainder;
          }
        if (flagHasCalendarPreferenceIsNotSetResult)
          {
            if (remainder == 0)
                return "CalendarPreferenceIsNotSetResult";
            --remainder;
          }
        return extraCalendarCreateCalendarItemCommandComponentKey(remainder);
      }
    public override JSONValue extraCalendarCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasItemKind)
          {
            if (remainder == 0)
                return extraItemKindToJSON();
            --remainder;
          }
        if (flagHasTitle)
          {
            if (remainder == 0)
                return extraTitleToJSON();
            --remainder;
          }
        if (flagHasLocation)
          {
            if (remainder == 0)
                return extraLocationToJSON();
            --remainder;
          }
        if (flagHasLocationSpecifier)
          {
            if (remainder == 0)
                return extraLocationSpecifierToJSON();
            --remainder;
          }
        if (flagHasAttendees)
          {
            if (remainder == 0)
                return extraAttendeesToJSON();
            --remainder;
          }
        if (flagHasReminders)
          {
            if (remainder == 0)
                return extraRemindersToJSON();
            --remainder;
          }
        if (flagHasSelfAttendeeStatus)
          {
            if (remainder == 0)
                return extraSelfAttendeeStatusToJSON();
            --remainder;
          }
        if (flagHasStart)
          {
            if (remainder == 0)
                return extraStartToJSON();
            --remainder;
          }
        if (flagHasEnd)
          {
            if (remainder == 0)
                return extraEndToJSON();
            --remainder;
          }
        if (flagHasFrequencyType)
          {
            if (remainder == 0)
                return extraFrequencyTypeToJSON();
            --remainder;
          }
        if (flagHasFrequencyMultiplier)
          {
            if (remainder == 0)
                return extraFrequencyMultiplierToJSON();
            --remainder;
          }
        if (flagHasRecurrenceRule)
          {
            if (remainder == 0)
                return extraRecurrenceRuleToJSON();
            --remainder;
          }
        if (flagHasIsRecurring)
          {
            if (remainder == 0)
                return extraIsRecurringToJSON();
            --remainder;
          }
        if (flagHasIsAllDay)
          {
            if (remainder == 0)
                return extraIsAllDayToJSON();
            --remainder;
          }
        if (flagHasAvailability)
          {
            if (remainder == 0)
                return extraAvailabilityToJSON();
            --remainder;
          }
        if (flagHasStartAMPMAmbiguous)
          {
            if (remainder == 0)
                return extraStartAMPMAmbiguousToJSON();
            --remainder;
          }
        if (flagHasEndAMPMAmbiguous)
          {
            if (remainder == 0)
                return extraEndAMPMAmbiguousToJSON();
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        if (flagHasEventsConflictResult)
          {
            if (remainder == 0)
                return extraEventsConflictResultToJSON();
            --remainder;
          }
        if (flagHasCalendarPreferenceIsNotSetResult)
          {
            if (remainder == 0)
                return extraCalendarPreferenceIsNotSetResultToJSON();
            --remainder;
          }
        return extraCalendarCreateCalendarItemCommandComponentValue(remainder);
      }
    public override JSONValue extraCalendarCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                switch (field_name[1])
                  {
                    case 't':
                        if ((String.Compare(field_name, 2, "tendees", 0, 7, false) == 0) && (field_name.Length == 9))
                            return (flagHasAttendees ? extraAttendeesToJSON() : null);
                        break;
                    case 'v':
                        if ((String.Compare(field_name, 2, "ailability", 0, 10, false) == 0) && (field_name.Length == 12))
                            return (flagHasAvailability ? extraAvailabilityToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(field_name, 1, "alendarPreferenceIsNotSetResult", 0, 31, false) == 0) && (field_name.Length == 32))
                    return (flagHasCalendarPreferenceIsNotSetResult ? extraCalendarPreferenceIsNotSetResultToJSON() : null);
                break;
            case 'E':
                switch (field_name[1])
                  {
                    case 'n':
                        if (String.Compare(field_name, 2, "d", 0, 1, false) == 0)
                          {
                            if (field_name.Length == 3)
                              {
                                return (flagHasEnd ? extraEndToJSON() : null);
                              }
                            switch (field_name[3])
                              {
                                case 'A':
                                    if ((String.Compare(field_name, 4, "MPMAmbiguous", 0, 12, false) == 0) && (field_name.Length == 16))
                                        return (flagHasEndAMPMAmbiguous ? extraEndAMPMAmbiguousToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'v':
                        if ((String.Compare(field_name, 2, "entsConflictResult", 0, 18, false) == 0) && (field_name.Length == 20))
                            return (flagHasEventsConflictResult ? extraEventsConflictResultToJSON() : null);
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
                        case 'M':
                            if ((String.Compare(field_name, 10, "ultiplier", 0, 9, false) == 0) && (field_name.Length == 19))
                                return (flagHasFrequencyMultiplier ? extraFrequencyMultiplierToJSON() : null);
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 10, "ype", 0, 3, false) == 0) && (field_name.Length == 13))
                                return (flagHasFrequencyType ? extraFrequencyTypeToJSON() : null);
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
                                    return (flagHasIsAllDay ? extraIsAllDayToJSON() : null);
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 3, "ecurring", 0, 8, false) == 0) && (field_name.Length == 11))
                                    return (flagHasIsRecurring ? extraIsRecurringToJSON() : null);
                                break;
                            default:
                                break;
                          }
                        break;
                    case 't':
                        if ((String.Compare(field_name, 2, "emKind", 0, 6, false) == 0) && (field_name.Length == 8))
                            return (flagHasItemKind ? extraItemKindToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if (String.Compare(field_name, 1, "ocation", 0, 7, false) == 0)
                  {
                    if (field_name.Length == 8)
                      {
                        return (flagHasLocation ? extraLocationToJSON() : null);
                      }
                    switch (field_name[8])
                      {
                        case 'S':
                            if ((String.Compare(field_name, 9, "pecifier", 0, 8, false) == 0) && (field_name.Length == 17))
                                return (flagHasLocationSpecifier ? extraLocationSpecifierToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasNativeData ? extraNativeDataToJSON() : null);
                break;
            case 'R':
                if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                  {
                    switch (field_name[2])
                      {
                        case 'c':
                            if ((String.Compare(field_name, 3, "urrenceRule", 0, 11, false) == 0) && (field_name.Length == 14))
                                return (flagHasRecurrenceRule ? extraRecurrenceRuleToJSON() : null);
                            break;
                        case 'm':
                            if ((String.Compare(field_name, 3, "inders", 0, 6, false) == 0) && (field_name.Length == 9))
                                return (flagHasReminders ? extraRemindersToJSON() : null);
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
                            return (flagHasSelfAttendeeStatus ? extraSelfAttendeeStatusToJSON() : null);
                        break;
                    case 't':
                        if (String.Compare(field_name, 2, "art", 0, 3, false) == 0)
                          {
                            if (field_name.Length == 5)
                              {
                                return (flagHasStart ? extraStartToJSON() : null);
                              }
                            switch (field_name[5])
                              {
                                case 'A':
                                    if ((String.Compare(field_name, 6, "MPMAmbiguous", 0, 12, false) == 0) && (field_name.Length == 18))
                                        return (flagHasStartAMPMAmbiguous ? extraStartAMPMAmbiguousToJSON() : null);
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
            case 'T':
                if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasTitle ? extraTitleToJSON() : null);
                break;
            default:
                break;
          }
        return extraCalendarCreateCalendarItemCommandLookup(field_name);
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
    public void initAttendees()
      {
        if (flagHasAttendees)
          {
            for (int num5 = 0; num5 < storeAttendees.Count; ++num5)
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
            for (int num6 = 0; num6 < storeAttendees.Count; ++num6)
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
            for (int num7 = 0; num7 < storeReminders.Count; ++num7)
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
            for (int num8 = 0; num8 < storeReminders.Count; ++num8)
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
            throw new Exception("The value for field FrequencyMultiplier of CalendarCreateCalendarItemCommandJSON is less than the lower bound (1) for that field.");
        storeFrequencyMultiplier = new_value;
      }
    public void unsetFrequencyMultiplier()
      {
        flagHasFrequencyMultiplier = false;
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
    public void setIsRecurring(bool new_value)
      {
        flagHasIsRecurring = true;
        storeIsRecurring = new_value;
      }
    public void unsetIsRecurring()
      {
        flagHasIsRecurring = false;
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
    public void setStartAMPMAmbiguous(bool new_value)
      {
        flagHasStartAMPMAmbiguous = true;
        storeStartAMPMAmbiguous = new_value;
      }
    public void unsetStartAMPMAmbiguous()
      {
        flagHasStartAMPMAmbiguous = false;
      }
    public void setEndAMPMAmbiguous(bool new_value)
      {
        flagHasEndAMPMAmbiguous = true;
        storeEndAMPMAmbiguous = new_value;
      }
    public void unsetEndAMPMAmbiguous()
      {
        flagHasEndAMPMAmbiguous = false;
      }
    public void setNativeData(TypeNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
      }
    public void setEventsConflictResult(DynamicResponseJSON  new_value)
      {
        if (flagHasEventsConflictResult)
          {
          }
        flagHasEventsConflictResult = true;
        storeEventsConflictResult = new_value;
      }
    public void unsetEventsConflictResult()
      {
        if (flagHasEventsConflictResult)
          {
          }
        flagHasEventsConflictResult = false;
      }
    public void setCalendarPreferenceIsNotSetResult(DynamicResponseJSON  new_value)
      {
        if (flagHasCalendarPreferenceIsNotSetResult)
          {
          }
        flagHasCalendarPreferenceIsNotSetResult = true;
        storeCalendarPreferenceIsNotSetResult = new_value;
      }
    public void unsetCalendarPreferenceIsNotSetResult()
      {
        if (flagHasCalendarPreferenceIsNotSetResult)
          {
          }
        flagHasCalendarPreferenceIsNotSetResult = false;
      }

    public virtual void extraCalendarCreateCalendarItemCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCalendarCreateCalendarItemCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCalendarCreateCalendarItemCommandLookup(key);
        if (old_field == null)
          {
            extraCalendarCreateCalendarItemCommandAppendPair(key, new_component);
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
    public override void extraCalendarCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 't':
                        if ((String.Compare(key, 2, "tendees", 0, 7, false) == 0) && (key.Length == 9))
                            {
                            fromJSONAttendees(new_component, false);
                            return;
                            }
                        break;
                    case 'v':
                        if ((String.Compare(key, 2, "ailability", 0, 10, false) == 0) && (key.Length == 12))
                            {
                            fromJSONAvailability(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(key, 1, "alendarPreferenceIsNotSetResult", 0, 31, false) == 0) && (key.Length == 32))
                    {
                    fromJSONCalendarPreferenceIsNotSetResult(new_component, false);
                    return;
                    }
                break;
            case 'E':
                switch (key[1])
                  {
                    case 'n':
                        if (String.Compare(key, 2, "d", 0, 1, false) == 0)
                          {
                            if (key.Length == 3)
                              {
                                {
                                fromJSONEnd(new_component, false);
                                return;
                                }
                              }
                            switch (key[3])
                              {
                                case 'A':
                                    if ((String.Compare(key, 4, "MPMAmbiguous", 0, 12, false) == 0) && (key.Length == 16))
                                        {
                                        fromJSONEndAMPMAmbiguous(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'v':
                        if ((String.Compare(key, 2, "entsConflictResult", 0, 18, false) == 0) && (key.Length == 20))
                            {
                            fromJSONEventsConflictResult(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'F':
                if (String.Compare(key, 1, "requency", 0, 8, false) == 0)
                  {
                    switch (key[9])
                      {
                        case 'M':
                            if ((String.Compare(key, 10, "ultiplier", 0, 9, false) == 0) && (key.Length == 19))
                                {
                                fromJSONFrequencyMultiplier(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 10, "ype", 0, 3, false) == 0) && (key.Length == 13))
                                {
                                fromJSONFrequencyType(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                switch (key[1])
                  {
                    case 's':
                        switch (key[2])
                          {
                            case 'A':
                                if ((String.Compare(key, 3, "llDay", 0, 5, false) == 0) && (key.Length == 8))
                                    {
                                    fromJSONIsAllDay(new_component, false);
                                    return;
                                    }
                                break;
                            case 'R':
                                if ((String.Compare(key, 3, "ecurring", 0, 8, false) == 0) && (key.Length == 11))
                                    {
                                    fromJSONIsRecurring(new_component, false);
                                    return;
                                    }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 't':
                        if ((String.Compare(key, 2, "emKind", 0, 6, false) == 0) && (key.Length == 8))
                            {
                            fromJSONItemKind(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if (String.Compare(key, 1, "ocation", 0, 7, false) == 0)
                  {
                    if (key.Length == 8)
                      {
                        {
                        fromJSONLocation(new_component, false);
                        return;
                        }
                      }
                    switch (key[8])
                      {
                        case 'S':
                            if ((String.Compare(key, 9, "pecifier", 0, 8, false) == 0) && (key.Length == 17))
                                {
                                fromJSONLocationSpecifier(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if (String.Compare(key, 1, "e", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'c':
                            if ((String.Compare(key, 3, "urrenceRule", 0, 11, false) == 0) && (key.Length == 14))
                                {
                                fromJSONRecurrenceRule(new_component, false);
                                return;
                                }
                            break;
                        case 'm':
                            if ((String.Compare(key, 3, "inders", 0, 6, false) == 0) && (key.Length == 9))
                                {
                                fromJSONReminders(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'e':
                        if ((String.Compare(key, 2, "lfAttendeeStatus", 0, 16, false) == 0) && (key.Length == 18))
                            {
                            fromJSONSelfAttendeeStatus(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if (String.Compare(key, 2, "art", 0, 3, false) == 0)
                          {
                            if (key.Length == 5)
                              {
                                {
                                fromJSONStart(new_component, false);
                                return;
                                }
                              }
                            switch (key[5])
                              {
                                case 'A':
                                    if ((String.Compare(key, 6, "MPMAmbiguous", 0, 12, false) == 0) && (key.Length == 18))
                                        {
                                        fromJSONStartAMPMAmbiguous(new_component, false);
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
            case 'T':
                if ((String.Compare(key, 1, "itle", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONTitle(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCalendarCreateCalendarItemCommandAppendPair(key, new_component);
      }
    public override void extraCalendarCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 't':
                        if ((String.Compare(key, 2, "tendees", 0, 7, false) == 0) && (key.Length == 9))
                            {
                            fromJSONAttendees(new_component, false);
                            return;
                            }
                        break;
                    case 'v':
                        if ((String.Compare(key, 2, "ailability", 0, 10, false) == 0) && (key.Length == 12))
                            {
                            fromJSONAvailability(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(key, 1, "alendarPreferenceIsNotSetResult", 0, 31, false) == 0) && (key.Length == 32))
                    {
                    fromJSONCalendarPreferenceIsNotSetResult(new_component, false);
                    return;
                    }
                break;
            case 'E':
                switch (key[1])
                  {
                    case 'n':
                        if (String.Compare(key, 2, "d", 0, 1, false) == 0)
                          {
                            if (key.Length == 3)
                              {
                                {
                                fromJSONEnd(new_component, false);
                                return;
                                }
                              }
                            switch (key[3])
                              {
                                case 'A':
                                    if ((String.Compare(key, 4, "MPMAmbiguous", 0, 12, false) == 0) && (key.Length == 16))
                                        {
                                        fromJSONEndAMPMAmbiguous(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'v':
                        if ((String.Compare(key, 2, "entsConflictResult", 0, 18, false) == 0) && (key.Length == 20))
                            {
                            fromJSONEventsConflictResult(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'F':
                if (String.Compare(key, 1, "requency", 0, 8, false) == 0)
                  {
                    switch (key[9])
                      {
                        case 'M':
                            if ((String.Compare(key, 10, "ultiplier", 0, 9, false) == 0) && (key.Length == 19))
                                {
                                fromJSONFrequencyMultiplier(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 10, "ype", 0, 3, false) == 0) && (key.Length == 13))
                                {
                                fromJSONFrequencyType(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                switch (key[1])
                  {
                    case 's':
                        switch (key[2])
                          {
                            case 'A':
                                if ((String.Compare(key, 3, "llDay", 0, 5, false) == 0) && (key.Length == 8))
                                    {
                                    fromJSONIsAllDay(new_component, false);
                                    return;
                                    }
                                break;
                            case 'R':
                                if ((String.Compare(key, 3, "ecurring", 0, 8, false) == 0) && (key.Length == 11))
                                    {
                                    fromJSONIsRecurring(new_component, false);
                                    return;
                                    }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 't':
                        if ((String.Compare(key, 2, "emKind", 0, 6, false) == 0) && (key.Length == 8))
                            {
                            fromJSONItemKind(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if (String.Compare(key, 1, "ocation", 0, 7, false) == 0)
                  {
                    if (key.Length == 8)
                      {
                        {
                        fromJSONLocation(new_component, false);
                        return;
                        }
                      }
                    switch (key[8])
                      {
                        case 'S':
                            if ((String.Compare(key, 9, "pecifier", 0, 8, false) == 0) && (key.Length == 17))
                                {
                                fromJSONLocationSpecifier(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if (String.Compare(key, 1, "e", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'c':
                            if ((String.Compare(key, 3, "urrenceRule", 0, 11, false) == 0) && (key.Length == 14))
                                {
                                fromJSONRecurrenceRule(new_component, false);
                                return;
                                }
                            break;
                        case 'm':
                            if ((String.Compare(key, 3, "inders", 0, 6, false) == 0) && (key.Length == 9))
                                {
                                fromJSONReminders(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'e':
                        if ((String.Compare(key, 2, "lfAttendeeStatus", 0, 16, false) == 0) && (key.Length == 18))
                            {
                            fromJSONSelfAttendeeStatus(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if (String.Compare(key, 2, "art", 0, 3, false) == 0)
                          {
                            if (key.Length == 5)
                              {
                                {
                                fromJSONStart(new_component, false);
                                return;
                                }
                              }
                            switch (key[5])
                              {
                                case 'A':
                                    if ((String.Compare(key, 6, "MPMAmbiguous", 0, 12, false) == 0) && (key.Length == 18))
                                        {
                                        fromJSONStartAMPMAmbiguous(new_component, false);
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
            case 'T':
                if ((String.Compare(key, 1, "itle", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONTitle(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCalendarCreateCalendarItemCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasLocation);
        if (flagHasLocation)
          {
            handler.start_pair("Location");
            handler.string_value(storeLocation);
          }
        Debug.Assert(partial_allowed || flagHasLocationSpecifier);
        if (flagHasLocationSpecifier)
          {
            handler.start_pair("LocationSpecifier");
            if (partial_allowed)
                storeLocationSpecifier.write_partial_as_json(handler);
            else
                storeLocationSpecifier.write_as_json(handler);
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
        if (flagHasRecurrenceRule)
          {
            handler.start_pair("RecurrenceRule");
            handler.string_value(storeRecurrenceRule);
          }
        Debug.Assert(partial_allowed || flagHasIsRecurring);
        if (flagHasIsRecurring)
          {
            handler.start_pair("IsRecurring");
            handler.boolean_value(storeIsRecurring);
          }
        Debug.Assert(partial_allowed || flagHasIsAllDay);
        if (flagHasIsAllDay)
          {
            handler.start_pair("IsAllDay");
            handler.boolean_value(storeIsAllDay);
          }
        Debug.Assert(partial_allowed || flagHasAvailability);
        if (flagHasAvailability)
          {
            handler.start_pair("Availability");
            switch (storeAvailability)
              {
                case TypeAvailability.Availability_Free:
                    handler.string_value("Free");
                    break;
                case TypeAvailability.Availability_Busy:
                    handler.string_value("Busy");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasStartAMPMAmbiguous);
        if (flagHasStartAMPMAmbiguous)
          {
            handler.start_pair("StartAMPMAmbiguous");
            handler.boolean_value(storeStartAMPMAmbiguous);
          }
        Debug.Assert(partial_allowed || flagHasEndAMPMAmbiguous);
        if (flagHasEndAMPMAmbiguous)
          {
            handler.start_pair("EndAMPMAmbiguous");
            handler.boolean_value(storeEndAMPMAmbiguous);
          }
        Debug.Assert(partial_allowed || flagHasNativeData);
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
          }
        if (flagHasEventsConflictResult)
          {
            handler.start_pair("EventsConflictResult");
            if (partial_allowed)
                storeEventsConflictResult.write_partial_as_json(handler);
            else
                storeEventsConflictResult.write_as_json(handler);
          }
        if (flagHasCalendarPreferenceIsNotSetResult)
          {
            handler.start_pair("CalendarPreferenceIsNotSetResult");
            if (partial_allowed)
                storeCalendarPreferenceIsNotSetResult.write_partial_as_json(handler);
            else
                storeCalendarPreferenceIsNotSetResult.write_as_json(handler);
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
        if (!(hasItemKind()))
          {
            return "When parsing the object for %what%, the \"ItemKind\" field was missing.";
          }
        if (!(hasTitle()))
          {
            return "When parsing the object for %what%, the \"Title\" field was missing.";
          }
        if (!(hasLocation()))
          {
            return "When parsing the object for %what%, the \"Location\" field was missing.";
          }
        if (!(hasLocationSpecifier()))
          {
            return "When parsing the object for %what%, the \"LocationSpecifier\" field was missing.";
          }
        if (!(hasStart()))
          {
            return "When parsing the object for %what%, the \"Start\" field was missing.";
          }
        if (!(hasEnd()))
          {
            return "When parsing the object for %what%, the \"End\" field was missing.";
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
        if (!(hasAvailability()))
          {
            return "When parsing the object for %what%, the \"Availability\" field was missing.";
          }
        if (!(hasStartAMPMAmbiguous()))
          {
            return "When parsing the object for %what%, the \"StartAMPMAmbiguous\" field was missing.";
          }
        if (!(hasEndAMPMAmbiguous()))
          {
            return "When parsing the object for %what%, the \"EndAMPMAmbiguous\" field was missing.";
          }
        if (!(hasNativeData()))
          {
            return "When parsing the object for %what%, the \"NativeData\" field was missing.";
          }
        return null;
      }

    public static new CalendarCreateCalendarItemCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarCreateCalendarItemCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarCreateCalendarItemCommand", ignore_extras);
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
    public static new CalendarCreateCalendarItemCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CalendarCreateCalendarItemCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarCreateCalendarItemCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarCreateCalendarItemCommand", ignore_extras);
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
    public static new CalendarCreateCalendarItemCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CalendarCreateCalendarItemCommandJSON from_text(string text, bool ignore_extras)
      {
        CalendarCreateCalendarItemCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarCreateCalendarItemCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CalendarCreateCalendarItemCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CalendarCreateCalendarItemCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CalendarCreateCalendarItemCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarCreateCalendarItemCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CalendarCommandJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorItemKind;
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingStringGenerator fieldGeneratorLocation;
        private CalendarLocationJSON.HoldingGenerator fieldGeneratorLocationSpecifier;
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
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStart;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEnd;
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
        private JSONHoldingStringGenerator fieldGeneratorRecurrenceRule;
        private JSONHoldingBooleanGenerator fieldGeneratorIsRecurring;
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
        private JSONHoldingBooleanGenerator fieldGeneratorStartAMPMAmbiguous;
        private JSONHoldingBooleanGenerator fieldGeneratorEndAMPMAmbiguous;
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorEventsConflictResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorCalendarPreferenceIsNotSetResult;
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
            if (!(getCalendarCommandJSONKey().Equals("CreateItem")))
                throw new Exception("The key field has a value other than `CreateItem'.");
            CalendarCreateCalendarItemCommandJSON result = new CalendarCreateCalendarItemCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCalendarCreateCalendarItemCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CalendarCommandJSON new_result)
          {
            handle_result((CalendarCreateCalendarItemCommandJSON )new_result);
          }
        protected void finish(CalendarCreateCalendarItemCommandJSON result)
          {
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
            else if ((!(result.hasLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Location\" field was missing.");
              }
            if (fieldGeneratorLocationSpecifier.have_value)
              {
                result.setLocationSpecifier(fieldGeneratorLocationSpecifier.value);
                fieldGeneratorLocationSpecifier.have_value = false;
              }
            else if ((!(result.hasLocationSpecifier())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LocationSpecifier\" field was missing.");
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
            if (fieldGeneratorRecurrenceRule.have_value)
              {
                result.setRecurrenceRule(fieldGeneratorRecurrenceRule.value);
                fieldGeneratorRecurrenceRule.have_value = false;
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
            else if ((!(result.hasAvailability())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Availability\" field was missing.");
              }
            if (fieldGeneratorStartAMPMAmbiguous.have_value)
              {
                result.setStartAMPMAmbiguous(fieldGeneratorStartAMPMAmbiguous.value);
                fieldGeneratorStartAMPMAmbiguous.have_value = false;
              }
            else if ((!(result.hasStartAMPMAmbiguous())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartAMPMAmbiguous\" field was missing.");
              }
            if (fieldGeneratorEndAMPMAmbiguous.have_value)
              {
                result.setEndAMPMAmbiguous(fieldGeneratorEndAMPMAmbiguous.value);
                fieldGeneratorEndAMPMAmbiguous.have_value = false;
              }
            else if ((!(result.hasEndAMPMAmbiguous())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndAMPMAmbiguous\" field was missing.");
              }
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            else if ((!(result.hasNativeData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NativeData\" field was missing.");
              }
            if (fieldGeneratorEventsConflictResult.have_value)
              {
                result.setEventsConflictResult(fieldGeneratorEventsConflictResult.value);
                fieldGeneratorEventsConflictResult.have_value = false;
              }
            if (fieldGeneratorCalendarPreferenceIsNotSetResult.have_value)
              {
                result.setCalendarPreferenceIsNotSetResult(fieldGeneratorCalendarPreferenceIsNotSetResult.value);
                fieldGeneratorCalendarPreferenceIsNotSetResult.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(CalendarCreateCalendarItemCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
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
                    if ((String.Compare(field_name, 1, "alendarPreferenceIsNotSetResult", 0, 31, false) == 0) && (field_name.Length == 32))
                        return fieldGeneratorCalendarPreferenceIsNotSetResult;
                    break;
                case 'E':
                    switch (field_name[1])
                      {
                        case 'n':
                            if (String.Compare(field_name, 2, "d", 0, 1, false) == 0)
                              {
                                if (field_name.Length == 3)
                                  {
                                    return fieldGeneratorEnd;
                                  }
                                switch (field_name[3])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 4, "MPMAmbiguous", 0, 12, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorEndAMPMAmbiguous;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'v':
                            if ((String.Compare(field_name, 2, "entsConflictResult", 0, 18, false) == 0) && (field_name.Length == 20))
                                return fieldGeneratorEventsConflictResult;
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
                case 'N':
                    if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorNativeData;
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
                            if (String.Compare(field_name, 2, "art", 0, 3, false) == 0)
                              {
                                if (field_name.Length == 5)
                                  {
                                    return fieldGeneratorStart;
                                  }
                                switch (field_name[5])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 6, "MPMAmbiguous", 0, 12, false) == 0) && (field_name.Length == 18))
                                            return fieldGeneratorStartAMPMAmbiguous;
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
                case 'T':
                    if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorTitle;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorItemKind = new JSONHoldingStringGenerator("field \"ItemKind\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorLocation = new JSONHoldingStringGenerator("field \"Location\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the CalendarCreateCalendarItemCommand class", ignore_extras);
            fieldGeneratorAttendees = new CalendarAttendeeJSON.HoldingArrayGenerator("field \"Attendees\" of the CalendarCreateCalendarItemCommand class", ignore_extras);
            fieldGeneratorReminders = new CalendarReminderJSON.HoldingArrayGenerator("field \"Reminders\" of the CalendarCreateCalendarItemCommand class", ignore_extras);
            fieldGeneratorSelfAttendeeStatus = new FieldHoldingGeneratorSelfAttendeeStatus("field \"SelfAttendeeStatus\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorStart = new DateAndOrTimeJSON.HoldingGenerator("field \"Start\" of the CalendarCreateCalendarItemCommand class", ignore_extras);
            fieldGeneratorEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"End\" of the CalendarCreateCalendarItemCommand class", ignore_extras);
            fieldGeneratorFrequencyType = new FieldHoldingGeneratorFrequencyType("field \"FrequencyType\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorFrequencyMultiplier = new FieldHoldingGeneratorFrequencyMultiplier("field \"FrequencyMultiplier\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorRecurrenceRule = new JSONHoldingStringGenerator("field \"RecurrenceRule\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorIsRecurring = new JSONHoldingBooleanGenerator("field \"IsRecurring\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorIsAllDay = new JSONHoldingBooleanGenerator("field \"IsAllDay\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorAvailability = new FieldHoldingGeneratorAvailability("field \"Availability\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorStartAMPMAmbiguous = new JSONHoldingBooleanGenerator("field \"StartAMPMAmbiguous\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorEndAMPMAmbiguous = new JSONHoldingBooleanGenerator("field \"EndAMPMAmbiguous\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the CalendarCreateCalendarItemCommand class", ignore_extras);
            fieldGeneratorEventsConflictResult = new DynamicResponseJSON.HoldingGenerator("field \"EventsConflictResult\" of the CalendarCreateCalendarItemCommand class", ignore_extras);
            fieldGeneratorCalendarPreferenceIsNotSetResult = new DynamicResponseJSON.HoldingGenerator("field \"CalendarPreferenceIsNotSetResult\" of the CalendarCreateCalendarItemCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CalendarCreateCalendarItemCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorItemKind = new JSONHoldingStringGenerator("field \"ItemKind\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorLocation = new JSONHoldingStringGenerator("field \"Location\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the CalendarCreateCalendarItemCommand class", false);
            fieldGeneratorAttendees = new CalendarAttendeeJSON.HoldingArrayGenerator("field \"Attendees\" of the CalendarCreateCalendarItemCommand class", false);
            fieldGeneratorReminders = new CalendarReminderJSON.HoldingArrayGenerator("field \"Reminders\" of the CalendarCreateCalendarItemCommand class", false);
            fieldGeneratorSelfAttendeeStatus = new FieldHoldingGeneratorSelfAttendeeStatus("field \"SelfAttendeeStatus\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorStart = new DateAndOrTimeJSON.HoldingGenerator("field \"Start\" of the CalendarCreateCalendarItemCommand class", false);
            fieldGeneratorEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"End\" of the CalendarCreateCalendarItemCommand class", false);
            fieldGeneratorFrequencyType = new FieldHoldingGeneratorFrequencyType("field \"FrequencyType\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorFrequencyMultiplier = new FieldHoldingGeneratorFrequencyMultiplier("field \"FrequencyMultiplier\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorRecurrenceRule = new JSONHoldingStringGenerator("field \"RecurrenceRule\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorIsRecurring = new JSONHoldingBooleanGenerator("field \"IsRecurring\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorIsAllDay = new JSONHoldingBooleanGenerator("field \"IsAllDay\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorAvailability = new FieldHoldingGeneratorAvailability("field \"Availability\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorStartAMPMAmbiguous = new JSONHoldingBooleanGenerator("field \"StartAMPMAmbiguous\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorEndAMPMAmbiguous = new JSONHoldingBooleanGenerator("field \"EndAMPMAmbiguous\" of the CalendarCreateCalendarItemCommand class");
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the CalendarCreateCalendarItemCommand class", false);
            fieldGeneratorEventsConflictResult = new DynamicResponseJSON.HoldingGenerator("field \"EventsConflictResult\" of the CalendarCreateCalendarItemCommand class", false);
            fieldGeneratorCalendarPreferenceIsNotSetResult = new DynamicResponseJSON.HoldingGenerator("field \"CalendarPreferenceIsNotSetResult\" of the CalendarCreateCalendarItemCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CalendarCreateCalendarItemCommand class");
          }

        public override void reset()
          {
            fieldGeneratorItemKind.reset();
            fieldGeneratorTitle.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorLocationSpecifier.reset();
            fieldGeneratorAttendees.reset();
            fieldGeneratorReminders.reset();
            fieldGeneratorSelfAttendeeStatus.reset();
            fieldGeneratorStart.reset();
            fieldGeneratorEnd.reset();
            fieldGeneratorFrequencyType.reset();
            fieldGeneratorFrequencyMultiplier.reset();
            fieldGeneratorRecurrenceRule.reset();
            fieldGeneratorIsRecurring.reset();
            fieldGeneratorIsAllDay.reset();
            fieldGeneratorAvailability.reset();
            fieldGeneratorStartAMPMAmbiguous.reset();
            fieldGeneratorEndAMPMAmbiguous.reset();
            fieldGeneratorNativeData.reset();
            fieldGeneratorEventsConflictResult.reset();
            fieldGeneratorCalendarPreferenceIsNotSetResult.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CalendarCreateCalendarItemCommandJSON  result)
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
        public CalendarCreateCalendarItemCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CalendarCreateCalendarItemCommandJSON  result)
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
    protected virtual void handle_result(List<CalendarCreateCalendarItemCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CalendarCreateCalendarItemCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CalendarCreateCalendarItemCommandJSON>();
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
    public List<CalendarCreateCalendarItemCommandJSON> value;
  };
  };
