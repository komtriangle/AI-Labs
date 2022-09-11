/* file "ModifyCalendarItemsCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class ModifyCalendarItemsCommandJSON : CalendarCommandJSON
  {
    public enum TypeNewFrequencyType
      {
        NewFrequencyType_unknown,
        NewFrequencyType_one_time,
        NewFrequencyType_daily,
        NewFrequencyType_weekly,
        NewFrequencyType_monthly,
        NewFrequencyType_yearly
      };

    public static TypeNewFrequencyType  stringToNewFrequencyType(string chars)
      {
        switch (chars[0])
          {
            case 'd':
                if ((String.Compare(chars, 1, "aily", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeNewFrequencyType.NewFrequencyType_daily;
                break;
            case 'm':
                if ((String.Compare(chars, 1, "onthly", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeNewFrequencyType.NewFrequencyType_monthly;
                break;
            case 'o':
                if ((String.Compare(chars, 1, "ne-time", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeNewFrequencyType.NewFrequencyType_one_time;
                break;
            case 'u':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeNewFrequencyType.NewFrequencyType_unknown;
                break;
            case 'w':
                if ((String.Compare(chars, 1, "eekly", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeNewFrequencyType.NewFrequencyType_weekly;
                break;
            case 'y':
                if ((String.Compare(chars, 1, "early", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeNewFrequencyType.NewFrequencyType_yearly;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `NewFrequencyType' is not one of the legal values.");
      }

    public static string  stringFromNewFrequencyType(TypeNewFrequencyType the_enum)
      {
        switch (the_enum)
          {
            case TypeNewFrequencyType.NewFrequencyType_unknown:
                return "unknown";
            case TypeNewFrequencyType.NewFrequencyType_one_time:
                return "one-time";
            case TypeNewFrequencyType.NewFrequencyType_daily:
                return "daily";
            case TypeNewFrequencyType.NewFrequencyType_weekly:
                return "weekly";
            case TypeNewFrequencyType.NewFrequencyType_monthly:
                return "monthly";
            case TypeNewFrequencyType.NewFrequencyType_yearly:
                return "yearly";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeNewSelfAttendeeStatus
      {
        NewSelfAttendeeStatus_None,
        NewSelfAttendeeStatus_Accepted,
        NewSelfAttendeeStatus_Declined,
        NewSelfAttendeeStatus_Invited,
        NewSelfAttendeeStatus_Tentative
      };

    public static TypeNewSelfAttendeeStatus  stringToNewSelfAttendeeStatus(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ccepted", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Accepted;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "eclined", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Declined;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nvited", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Invited;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_None;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "entative", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Tentative;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `NewSelfAttendeeStatus' is not one of the legal values.");
      }

    public static string  stringFromNewSelfAttendeeStatus(TypeNewSelfAttendeeStatus the_enum)
      {
        switch (the_enum)
          {
            case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_None:
                return "None";
            case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Accepted:
                return "Accepted";
            case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Declined:
                return "Declined";
            case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Invited:
                return "Invited";
            case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Tentative:
                return "Tentative";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeNativeDataJSON : JSONBase
      {
        public enum TypeNewFrequencyType
          {
            NewFrequencyType_unknown,
            NewFrequencyType_one_time,
            NewFrequencyType_daily,
            NewFrequencyType_weekly,
            NewFrequencyType_monthly,
            NewFrequencyType_yearly
          };

        public static TypeNewFrequencyType  stringToNewFrequencyType(string chars)
          {
            switch (chars[0])
              {
                case 'd':
                    if ((String.Compare(chars, 1, "aily", 0, 4, false) == 0) && (chars.Length == 5))
                        return TypeNewFrequencyType.NewFrequencyType_daily;
                    break;
                case 'm':
                    if ((String.Compare(chars, 1, "onthly", 0, 6, false) == 0) && (chars.Length == 7))
                        return TypeNewFrequencyType.NewFrequencyType_monthly;
                    break;
                case 'o':
                    if ((String.Compare(chars, 1, "ne-time", 0, 7, false) == 0) && (chars.Length == 8))
                        return TypeNewFrequencyType.NewFrequencyType_one_time;
                    break;
                case 'u':
                    if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                        return TypeNewFrequencyType.NewFrequencyType_unknown;
                    break;
                case 'w':
                    if ((String.Compare(chars, 1, "eekly", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeNewFrequencyType.NewFrequencyType_weekly;
                    break;
                case 'y':
                    if ((String.Compare(chars, 1, "early", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeNewFrequencyType.NewFrequencyType_yearly;
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `NewFrequencyType' is not one of the legal values.");
          }

        public static string  stringFromNewFrequencyType(TypeNewFrequencyType the_enum)
          {
            switch (the_enum)
              {
                case TypeNewFrequencyType.NewFrequencyType_unknown:
                    return "unknown";
                case TypeNewFrequencyType.NewFrequencyType_one_time:
                    return "one-time";
                case TypeNewFrequencyType.NewFrequencyType_daily:
                    return "daily";
                case TypeNewFrequencyType.NewFrequencyType_weekly:
                    return "weekly";
                case TypeNewFrequencyType.NewFrequencyType_monthly:
                    return "monthly";
                case TypeNewFrequencyType.NewFrequencyType_yearly:
                    return "yearly";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        public enum TypeNewSelfAttendeeStatus
          {
            NewSelfAttendeeStatus_None,
            NewSelfAttendeeStatus_Accepted,
            NewSelfAttendeeStatus_Declined,
            NewSelfAttendeeStatus_Invited,
            NewSelfAttendeeStatus_Tentative
          };

        public static TypeNewSelfAttendeeStatus  stringToNewSelfAttendeeStatus(string chars)
          {
            switch (chars[0])
              {
                case 'A':
                    if ((String.Compare(chars, 1, "ccepted", 0, 7, false) == 0) && (chars.Length == 8))
                        return TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Accepted;
                    break;
                case 'D':
                    if ((String.Compare(chars, 1, "eclined", 0, 7, false) == 0) && (chars.Length == 8))
                        return TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Declined;
                    break;
                case 'I':
                    if ((String.Compare(chars, 1, "nvited", 0, 6, false) == 0) && (chars.Length == 7))
                        return TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Invited;
                    break;
                case 'N':
                    if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_None;
                    break;
                case 'T':
                    if ((String.Compare(chars, 1, "entative", 0, 8, false) == 0) && (chars.Length == 9))
                        return TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Tentative;
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `NewSelfAttendeeStatus' is not one of the legal values.");
          }

        public static string  stringFromNewSelfAttendeeStatus(TypeNewSelfAttendeeStatus the_enum)
          {
            switch (the_enum)
              {
                case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_None:
                    return "None";
                case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Accepted:
                    return "Accepted";
                case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Declined:
                    return "Declined";
                case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Invited:
                    return "Invited";
                case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Tentative:
                    return "Tentative";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasItemType;
        private string storeItemType;
        private bool flagHasExactTitle;
        private string storeExactTitle;
        private bool flagHasPartialTitle;
        private string storePartialTitle;
        private bool flagHasExactLocation;
        private string storeExactLocation;
        private bool flagHasPartialLocation;
        private string storePartialLocation;
        private bool flagHasLocationSpecifier;
        private CalendarLocationJSON  storeLocationSpecifier;
        private bool flagHasStartStart;
        private DateAndOrTimeJSON  storeStartStart;
        private bool flagHasEndStart;
        private DateAndOrTimeJSON  storeEndStart;
        private bool flagHasStartEnd;
        private DateAndOrTimeJSON  storeStartEnd;
        private bool flagHasEndEnd;
        private DateAndOrTimeJSON  storeEndEnd;
        private bool flagHasNewItemType;
        private string storeNewItemType;
        private bool flagHasNewTitle;
        private string storeNewTitle;
        private bool flagHasNewLocation;
        private string storeNewLocation;
        private bool flagHasNewLocationSpecifier;
        private CalendarLocationJSON  storeNewLocationSpecifier;
        private bool flagHasNewStart;
        private DateAndOrTimeJSON  storeNewStart;
        private bool flagHasStartDeltaSeconds;
        private double storeStartDeltaSeconds;
        private string textStoreStartDeltaSeconds;
        private bool flagHasStartDeltaDays;
        private BigInteger storeStartDeltaDays;
        private bool flagHasStartDeltaMonths;
        private BigInteger storeStartDeltaMonths;
        private bool flagHasNewEnd;
        private DateAndOrTimeJSON  storeNewEnd;
        private bool flagHasEndDeltaSeconds;
        private double storeEndDeltaSeconds;
        private string textStoreEndDeltaSeconds;
        private bool flagHasEndDeltaDays;
        private BigInteger storeEndDeltaDays;
        private bool flagHasEndDeltaMonths;
        private BigInteger storeEndDeltaMonths;
        private bool flagHasNewFrequencyType;
        private TypeNewFrequencyType storeNewFrequencyType;
        private bool flagHasNewFrequencyMultiplier;
        private BigInteger storeNewFrequencyMultiplier;
        private bool flagHasAddEventAttendees;
        private List< string > storeAddEventAttendees;
        private bool flagHasRemoveEventAttendees;
        private List< string > storeRemoveEventAttendees;
        private bool flagHasNewSelfAttendeeStatus;
        private TypeNewSelfAttendeeStatus storeNewSelfAttendeeStatus;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONItemType(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ItemType of TypeNativeDataJSON is not a string.");
            setItemType(json_string.getData());
          }


        private void  fromJSONExactTitle(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ExactTitle of TypeNativeDataJSON is not a string.");
            setExactTitle(json_string.getData());
          }


        private void  fromJSONPartialTitle(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PartialTitle of TypeNativeDataJSON is not a string.");
            setPartialTitle(json_string.getData());
          }


        private void  fromJSONExactLocation(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ExactLocation of TypeNativeDataJSON is not a string.");
            setExactLocation(json_string.getData());
          }


        private void  fromJSONPartialLocation(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PartialLocation of TypeNativeDataJSON is not a string.");
            setPartialLocation(json_string.getData());
          }


        private void  fromJSONLocationSpecifier(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            CalendarLocationJSON convert_classy = CalendarLocationJSON.from_json(json_value, ignore_extras, true);
            setLocationSpecifier(convert_classy);
          }


        private void  fromJSONStartStart(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setStartStart(convert_classy);
          }


        private void  fromJSONEndStart(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setEndStart(convert_classy);
          }


        private void  fromJSONStartEnd(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setStartEnd(convert_classy);
          }


        private void  fromJSONEndEnd(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setEndEnd(convert_classy);
          }


        private void  fromJSONNewItemType(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field NewItemType of TypeNativeDataJSON is not a string.");
            setNewItemType(json_string.getData());
          }


        private void  fromJSONNewTitle(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field NewTitle of TypeNativeDataJSON is not a string.");
            setNewTitle(json_string.getData());
          }


        private void  fromJSONNewLocation(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field NewLocation of TypeNativeDataJSON is not a string.");
            setNewLocation(json_string.getData());
          }


        private void  fromJSONNewLocationSpecifier(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            CalendarLocationJSON convert_classy = CalendarLocationJSON.from_json(json_value, ignore_extras, true);
            setNewLocationSpecifier(convert_classy);
          }


        private void  fromJSONNewStart(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setNewStart(convert_classy);
          }


        private void  fromJSONStartDeltaSeconds(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONRationalValue json_rational = json_value.rational_value();
            string the_rational_text;
            if (json_rational != null)
              {
                the_rational_text = json_rational.getText();
              }
            else
              {
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer != null)
                  {
                    the_rational_text = json_integer.getText();
                  }
                else
                  {
                    throw new Exception("The value for field StartDeltaSeconds of TypeNativeDataJSON is not a number.");
                  }
              }
            setStartDeltaSecondsText(the_rational_text);
          }


        private void  fromJSONStartDeltaDays(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field StartDeltaDays of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field StartDeltaDays of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setStartDeltaDays(extracted_integer);
          }


        private void  fromJSONStartDeltaMonths(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field StartDeltaMonths of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field StartDeltaMonths of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setStartDeltaMonths(extracted_integer);
          }


        private void  fromJSONNewEnd(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setNewEnd(convert_classy);
          }


        private void  fromJSONEndDeltaSeconds(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONRationalValue json_rational = json_value.rational_value();
            string the_rational_text;
            if (json_rational != null)
              {
                the_rational_text = json_rational.getText();
              }
            else
              {
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer != null)
                  {
                    the_rational_text = json_integer.getText();
                  }
                else
                  {
                    throw new Exception("The value for field EndDeltaSeconds of TypeNativeDataJSON is not a number.");
                  }
              }
            setEndDeltaSecondsText(the_rational_text);
          }


        private void  fromJSONEndDeltaDays(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field EndDeltaDays of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field EndDeltaDays of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setEndDeltaDays(extracted_integer);
          }


        private void  fromJSONEndDeltaMonths(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field EndDeltaMonths of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field EndDeltaMonths of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setEndDeltaMonths(extracted_integer);
          }


        private void  fromJSONNewFrequencyType(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field NewFrequencyType of TypeNativeDataJSON is not a string.");
            TypeNewFrequencyType the_enum;
            switch (json_string.getData()[0])
              {
                case 'd':
                    if ((String.Compare(json_string.getData(), 1, "aily", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeNewFrequencyType.NewFrequencyType_daily;
                            goto enum_is_done;
                          }
                    break;
                case 'm':
                    if ((String.Compare(json_string.getData(), 1, "onthly", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_enum = TypeNewFrequencyType.NewFrequencyType_monthly;
                            goto enum_is_done;
                          }
                    break;
                case 'o':
                    if ((String.Compare(json_string.getData(), 1, "ne-time", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_enum = TypeNewFrequencyType.NewFrequencyType_one_time;
                            goto enum_is_done;
                          }
                    break;
                case 'u':
                    if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_enum = TypeNewFrequencyType.NewFrequencyType_unknown;
                            goto enum_is_done;
                          }
                    break;
                case 'w':
                    if ((String.Compare(json_string.getData(), 1, "eekly", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_enum = TypeNewFrequencyType.NewFrequencyType_weekly;
                            goto enum_is_done;
                          }
                    break;
                case 'y':
                    if ((String.Compare(json_string.getData(), 1, "early", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_enum = TypeNewFrequencyType.NewFrequencyType_yearly;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field NewFrequencyType of TypeNativeDataJSON is not one of the legal strings.");
          enum_is_done:;
            setNewFrequencyType(the_enum);
          }


        private void  fromJSONNewFrequencyMultiplier(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field NewFrequencyMultiplier of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field NewFrequencyMultiplier of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setNewFrequencyMultiplier(extracted_integer);
          }


        private void  fromJSONAddEventAttendees(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field AddEventAttendees of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< string > vector_AddEventAttendees1 = new List< string >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                JSONStringValue json_string = json_array1.component(num1).string_value();
                if (json_string == null)
                    throw new Exception("The value for an element of field AddEventAttendees of TypeNativeDataJSON is not a string.");
                vector_AddEventAttendees1.Add(json_string.getData());
              }
            initAddEventAttendees();
            for (int num1 = 0; num1 < vector_AddEventAttendees1.Count; ++num1)
                appendAddEventAttendees(vector_AddEventAttendees1[num1]);
            for (int num1 = 0; num1 < vector_AddEventAttendees1.Count; ++num1)
              {
              }
          }


        private void  fromJSONRemoveEventAttendees(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field RemoveEventAttendees of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< string > vector_RemoveEventAttendees1 = new List< string >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                JSONStringValue json_string = json_array1.component(num1).string_value();
                if (json_string == null)
                    throw new Exception("The value for an element of field RemoveEventAttendees of TypeNativeDataJSON is not a string.");
                vector_RemoveEventAttendees1.Add(json_string.getData());
              }
            initRemoveEventAttendees();
            for (int num2 = 0; num2 < vector_RemoveEventAttendees1.Count; ++num2)
                appendRemoveEventAttendees(vector_RemoveEventAttendees1[num2]);
            for (int num1 = 0; num1 < vector_RemoveEventAttendees1.Count; ++num1)
              {
              }
          }


        private void  fromJSONNewSelfAttendeeStatus(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field NewSelfAttendeeStatus of TypeNativeDataJSON is not a string.");
            TypeNewSelfAttendeeStatus the_enum;
            switch (json_string.getData()[0])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 1, "ccepted", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_enum = TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Accepted;
                            goto enum_is_done;
                          }
                    break;
                case 'D':
                    if ((String.Compare(json_string.getData(), 1, "eclined", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_enum = TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Declined;
                            goto enum_is_done;
                          }
                    break;
                case 'I':
                    if ((String.Compare(json_string.getData(), 1, "nvited", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_enum = TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Invited;
                            goto enum_is_done;
                          }
                    break;
                case 'N':
                    if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_enum = TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_None;
                            goto enum_is_done;
                          }
                    break;
                case 'T':
                    if ((String.Compare(json_string.getData(), 1, "entative", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                          {
                            the_enum = TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Tentative;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field NewSelfAttendeeStatus of TypeNativeDataJSON is not one of the legal strings.");
          enum_is_done:;
            setNewSelfAttendeeStatus(the_enum);
          }


        public TypeNativeDataJSON()
          {
            flagHasItemType = false;
            flagHasExactTitle = false;
            flagHasPartialTitle = false;
            flagHasExactLocation = false;
            flagHasPartialLocation = false;
            flagHasLocationSpecifier = false;
            flagHasStartStart = false;
            flagHasEndStart = false;
            flagHasStartEnd = false;
            flagHasEndEnd = false;
            flagHasNewItemType = false;
            flagHasNewTitle = false;
            flagHasNewLocation = false;
            flagHasNewLocationSpecifier = false;
            flagHasNewStart = false;
            flagHasStartDeltaSeconds = false;
            flagHasStartDeltaDays = false;
            flagHasStartDeltaMonths = false;
            flagHasNewEnd = false;
            flagHasEndDeltaSeconds = false;
            flagHasEndDeltaDays = false;
            flagHasEndDeltaMonths = false;
            flagHasNewFrequencyType = false;
            flagHasNewFrequencyMultiplier = false;
            flagHasAddEventAttendees = false;
            flagHasRemoveEventAttendees = false;
            flagHasNewSelfAttendeeStatus = false;
            storeAddEventAttendees = new List< string >();
            storeRemoveEventAttendees = new List< string >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasItemType()
          {
            return flagHasItemType;
          }

        public string  getItemType()
          {
            Debug.Assert(flagHasItemType);
            return storeItemType;
          }

        public bool  hasExactTitle()
          {
            return flagHasExactTitle;
          }

        public string  getExactTitle()
          {
            Debug.Assert(flagHasExactTitle);
            return storeExactTitle;
          }

        public bool  hasPartialTitle()
          {
            return flagHasPartialTitle;
          }

        public string  getPartialTitle()
          {
            Debug.Assert(flagHasPartialTitle);
            return storePartialTitle;
          }

        public bool  hasExactLocation()
          {
            return flagHasExactLocation;
          }

        public string  getExactLocation()
          {
            Debug.Assert(flagHasExactLocation);
            return storeExactLocation;
          }

        public bool  hasPartialLocation()
          {
            return flagHasPartialLocation;
          }

        public string  getPartialLocation()
          {
            Debug.Assert(flagHasPartialLocation);
            return storePartialLocation;
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

        public bool  hasStartStart()
          {
            return flagHasStartStart;
          }

        public DateAndOrTimeJSON   getStartStart()
          {
            Debug.Assert(flagHasStartStart);
            return storeStartStart;
          }

        public bool  hasEndStart()
          {
            return flagHasEndStart;
          }

        public DateAndOrTimeJSON   getEndStart()
          {
            Debug.Assert(flagHasEndStart);
            return storeEndStart;
          }

        public bool  hasStartEnd()
          {
            return flagHasStartEnd;
          }

        public DateAndOrTimeJSON   getStartEnd()
          {
            Debug.Assert(flagHasStartEnd);
            return storeStartEnd;
          }

        public bool  hasEndEnd()
          {
            return flagHasEndEnd;
          }

        public DateAndOrTimeJSON   getEndEnd()
          {
            Debug.Assert(flagHasEndEnd);
            return storeEndEnd;
          }

        public bool  hasNewItemType()
          {
            return flagHasNewItemType;
          }

        public string  getNewItemType()
          {
            Debug.Assert(flagHasNewItemType);
            return storeNewItemType;
          }

        public bool  hasNewTitle()
          {
            return flagHasNewTitle;
          }

        public string  getNewTitle()
          {
            Debug.Assert(flagHasNewTitle);
            return storeNewTitle;
          }

        public bool  hasNewLocation()
          {
            return flagHasNewLocation;
          }

        public string  getNewLocation()
          {
            Debug.Assert(flagHasNewLocation);
            return storeNewLocation;
          }

        public bool  hasNewLocationSpecifier()
          {
            return flagHasNewLocationSpecifier;
          }

        public CalendarLocationJSON   getNewLocationSpecifier()
          {
            Debug.Assert(flagHasNewLocationSpecifier);
            return storeNewLocationSpecifier;
          }

        public bool  hasNewStart()
          {
            return flagHasNewStart;
          }

        public DateAndOrTimeJSON   getNewStart()
          {
            Debug.Assert(flagHasNewStart);
            return storeNewStart;
          }

        public bool  hasStartDeltaSeconds()
          {
            return flagHasStartDeltaSeconds;
          }

        public double  getStartDeltaSeconds()
          {
            Debug.Assert(flagHasStartDeltaSeconds);
            if (textStoreStartDeltaSeconds != "")
              {
                return Double.Parse(textStoreStartDeltaSeconds);
              }
            return storeStartDeltaSeconds;
          }

        public string  getStartDeltaSecondsAsText()
          {
            Debug.Assert(flagHasStartDeltaSeconds);
            if (textStoreStartDeltaSeconds == "")
              {
                return Convert.ToString(storeStartDeltaSeconds);
              }
            else
              {
                return (textStoreStartDeltaSeconds);
              }
          }

        public bool  hasStartDeltaDays()
          {
            return flagHasStartDeltaDays;
          }

        public BigInteger  getStartDeltaDays()
          {
            Debug.Assert(flagHasStartDeltaDays);
            return storeStartDeltaDays;
          }

        public bool  hasStartDeltaMonths()
          {
            return flagHasStartDeltaMonths;
          }

        public BigInteger  getStartDeltaMonths()
          {
            Debug.Assert(flagHasStartDeltaMonths);
            return storeStartDeltaMonths;
          }

        public bool  hasNewEnd()
          {
            return flagHasNewEnd;
          }

        public DateAndOrTimeJSON   getNewEnd()
          {
            Debug.Assert(flagHasNewEnd);
            return storeNewEnd;
          }

        public bool  hasEndDeltaSeconds()
          {
            return flagHasEndDeltaSeconds;
          }

        public double  getEndDeltaSeconds()
          {
            Debug.Assert(flagHasEndDeltaSeconds);
            if (textStoreEndDeltaSeconds != "")
              {
                return Double.Parse(textStoreEndDeltaSeconds);
              }
            return storeEndDeltaSeconds;
          }

        public string  getEndDeltaSecondsAsText()
          {
            Debug.Assert(flagHasEndDeltaSeconds);
            if (textStoreEndDeltaSeconds == "")
              {
                return Convert.ToString(storeEndDeltaSeconds);
              }
            else
              {
                return (textStoreEndDeltaSeconds);
              }
          }

        public bool  hasEndDeltaDays()
          {
            return flagHasEndDeltaDays;
          }

        public BigInteger  getEndDeltaDays()
          {
            Debug.Assert(flagHasEndDeltaDays);
            return storeEndDeltaDays;
          }

        public bool  hasEndDeltaMonths()
          {
            return flagHasEndDeltaMonths;
          }

        public BigInteger  getEndDeltaMonths()
          {
            Debug.Assert(flagHasEndDeltaMonths);
            return storeEndDeltaMonths;
          }

        public bool  hasNewFrequencyType()
          {
            return flagHasNewFrequencyType;
          }

        public TypeNewFrequencyType  getNewFrequencyType()
          {
            Debug.Assert(flagHasNewFrequencyType);
            return storeNewFrequencyType;
          }

        public string  getNewFrequencyTypeAsString()
          {
            return stringFromNewFrequencyType(getNewFrequencyType());
          }

        public bool  hasNewFrequencyMultiplier()
          {
            return flagHasNewFrequencyMultiplier;
          }

        public BigInteger  getNewFrequencyMultiplier()
          {
            Debug.Assert(flagHasNewFrequencyMultiplier);
            return storeNewFrequencyMultiplier;
          }

        public bool  hasAddEventAttendees()
          {
            return flagHasAddEventAttendees;
          }

        public int  countOfAddEventAttendees()
          {
            Debug.Assert(flagHasAddEventAttendees);
            return storeAddEventAttendees.Count;
          }

        public string  elementOfAddEventAttendees(int element_num)
          {
            Debug.Assert(flagHasAddEventAttendees);
            return storeAddEventAttendees[element_num];
          }

        public List< string >  getAddEventAttendees()
          {
            Debug.Assert(flagHasAddEventAttendees);
            return storeAddEventAttendees;
          }

        public bool  hasRemoveEventAttendees()
          {
            return flagHasRemoveEventAttendees;
          }

        public int  countOfRemoveEventAttendees()
          {
            Debug.Assert(flagHasRemoveEventAttendees);
            return storeRemoveEventAttendees.Count;
          }

        public string  elementOfRemoveEventAttendees(int element_num)
          {
            Debug.Assert(flagHasRemoveEventAttendees);
            return storeRemoveEventAttendees[element_num];
          }

        public List< string >  getRemoveEventAttendees()
          {
            Debug.Assert(flagHasRemoveEventAttendees);
            return storeRemoveEventAttendees;
          }

        public bool  hasNewSelfAttendeeStatus()
          {
            return flagHasNewSelfAttendeeStatus;
          }

        public TypeNewSelfAttendeeStatus  getNewSelfAttendeeStatus()
          {
            Debug.Assert(flagHasNewSelfAttendeeStatus);
            return storeNewSelfAttendeeStatus;
          }

        public string  getNewSelfAttendeeStatusAsString()
          {
            return stringFromNewSelfAttendeeStatus(getNewSelfAttendeeStatus());
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

        public void setItemType(string new_value)
          {
            flagHasItemType = true;
            storeItemType = new_value;
          }
        public void unsetItemType()
          {
            flagHasItemType = false;
          }
        public void setExactTitle(string new_value)
          {
            flagHasExactTitle = true;
            storeExactTitle = new_value;
          }
        public void unsetExactTitle()
          {
            flagHasExactTitle = false;
          }
        public void setPartialTitle(string new_value)
          {
            flagHasPartialTitle = true;
            storePartialTitle = new_value;
          }
        public void unsetPartialTitle()
          {
            flagHasPartialTitle = false;
          }
        public void setExactLocation(string new_value)
          {
            flagHasExactLocation = true;
            storeExactLocation = new_value;
          }
        public void unsetExactLocation()
          {
            flagHasExactLocation = false;
          }
        public void setPartialLocation(string new_value)
          {
            flagHasPartialLocation = true;
            storePartialLocation = new_value;
          }
        public void unsetPartialLocation()
          {
            flagHasPartialLocation = false;
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
        public void setStartStart(DateAndOrTimeJSON  new_value)
          {
            if (flagHasStartStart)
              {
              }
            flagHasStartStart = true;
            storeStartStart = new_value;
          }
        public void unsetStartStart()
          {
            if (flagHasStartStart)
              {
              }
            flagHasStartStart = false;
          }
        public void setEndStart(DateAndOrTimeJSON  new_value)
          {
            if (flagHasEndStart)
              {
              }
            flagHasEndStart = true;
            storeEndStart = new_value;
          }
        public void unsetEndStart()
          {
            if (flagHasEndStart)
              {
              }
            flagHasEndStart = false;
          }
        public void setStartEnd(DateAndOrTimeJSON  new_value)
          {
            if (flagHasStartEnd)
              {
              }
            flagHasStartEnd = true;
            storeStartEnd = new_value;
          }
        public void unsetStartEnd()
          {
            if (flagHasStartEnd)
              {
              }
            flagHasStartEnd = false;
          }
        public void setEndEnd(DateAndOrTimeJSON  new_value)
          {
            if (flagHasEndEnd)
              {
              }
            flagHasEndEnd = true;
            storeEndEnd = new_value;
          }
        public void unsetEndEnd()
          {
            if (flagHasEndEnd)
              {
              }
            flagHasEndEnd = false;
          }
        public void setNewItemType(string new_value)
          {
            flagHasNewItemType = true;
            storeNewItemType = new_value;
          }
        public void unsetNewItemType()
          {
            flagHasNewItemType = false;
          }
        public void setNewTitle(string new_value)
          {
            flagHasNewTitle = true;
            storeNewTitle = new_value;
          }
        public void unsetNewTitle()
          {
            flagHasNewTitle = false;
          }
        public void setNewLocation(string new_value)
          {
            flagHasNewLocation = true;
            storeNewLocation = new_value;
          }
        public void unsetNewLocation()
          {
            flagHasNewLocation = false;
          }
        public void setNewLocationSpecifier(CalendarLocationJSON  new_value)
          {
            if (flagHasNewLocationSpecifier)
              {
              }
            flagHasNewLocationSpecifier = true;
            storeNewLocationSpecifier = new_value;
          }
        public void unsetNewLocationSpecifier()
          {
            if (flagHasNewLocationSpecifier)
              {
              }
            flagHasNewLocationSpecifier = false;
          }
        public void setNewStart(DateAndOrTimeJSON  new_value)
          {
            if (flagHasNewStart)
              {
              }
            flagHasNewStart = true;
            storeNewStart = new_value;
          }
        public void unsetNewStart()
          {
            if (flagHasNewStart)
              {
              }
            flagHasNewStart = false;
          }
        public void setStartDeltaSeconds(double new_value)
          {
            flagHasStartDeltaSeconds = true;
            storeStartDeltaSeconds = new_value;
            textStoreStartDeltaSeconds = "";
          }
        public void setStartDeltaSecondsText(string new_value)
          {
            flagHasStartDeltaSeconds = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field StartDeltaSeconds of TypeNativeDataJSON is not a valid number.");
            textStoreStartDeltaSeconds = new_value;
          }
        public void unsetStartDeltaSeconds()
          {
            flagHasStartDeltaSeconds = false;
          }
        public void setStartDeltaDays(BigInteger new_value)
          {
            flagHasStartDeltaDays = true;
            if (new_value < 0)
                throw new Exception("The value for field StartDeltaDays of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeStartDeltaDays = new_value;
          }
        public void unsetStartDeltaDays()
          {
            flagHasStartDeltaDays = false;
          }
        public void setStartDeltaMonths(BigInteger new_value)
          {
            flagHasStartDeltaMonths = true;
            if (new_value < 0)
                throw new Exception("The value for field StartDeltaMonths of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeStartDeltaMonths = new_value;
          }
        public void unsetStartDeltaMonths()
          {
            flagHasStartDeltaMonths = false;
          }
        public void setNewEnd(DateAndOrTimeJSON  new_value)
          {
            if (flagHasNewEnd)
              {
              }
            flagHasNewEnd = true;
            storeNewEnd = new_value;
          }
        public void unsetNewEnd()
          {
            if (flagHasNewEnd)
              {
              }
            flagHasNewEnd = false;
          }
        public void setEndDeltaSeconds(double new_value)
          {
            flagHasEndDeltaSeconds = true;
            storeEndDeltaSeconds = new_value;
            textStoreEndDeltaSeconds = "";
          }
        public void setEndDeltaSecondsText(string new_value)
          {
            flagHasEndDeltaSeconds = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field EndDeltaSeconds of TypeNativeDataJSON is not a valid number.");
            textStoreEndDeltaSeconds = new_value;
          }
        public void unsetEndDeltaSeconds()
          {
            flagHasEndDeltaSeconds = false;
          }
        public void setEndDeltaDays(BigInteger new_value)
          {
            flagHasEndDeltaDays = true;
            if (new_value < 0)
                throw new Exception("The value for field EndDeltaDays of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeEndDeltaDays = new_value;
          }
        public void unsetEndDeltaDays()
          {
            flagHasEndDeltaDays = false;
          }
        public void setEndDeltaMonths(BigInteger new_value)
          {
            flagHasEndDeltaMonths = true;
            if (new_value < 0)
                throw new Exception("The value for field EndDeltaMonths of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeEndDeltaMonths = new_value;
          }
        public void unsetEndDeltaMonths()
          {
            flagHasEndDeltaMonths = false;
          }
        public void setNewFrequencyType(TypeNewFrequencyType new_value)
          {
            flagHasNewFrequencyType = true;
            storeNewFrequencyType = new_value;
          }
        public void setNewFrequencyType(string chars)
          {
            setNewFrequencyType(stringToNewFrequencyType(chars));
          }
        public void unsetNewFrequencyType()
          {
            flagHasNewFrequencyType = false;
          }
        public void setNewFrequencyMultiplier(BigInteger new_value)
          {
            flagHasNewFrequencyMultiplier = true;
            if (new_value < 0)
                throw new Exception("The value for field NewFrequencyMultiplier of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeNewFrequencyMultiplier = new_value;
          }
        public void unsetNewFrequencyMultiplier()
          {
            flagHasNewFrequencyMultiplier = false;
          }
        public void initAddEventAttendees()
          {
            flagHasAddEventAttendees = true;
            storeAddEventAttendees.Clear();
          }
        public void appendAddEventAttendees(string to_append)
          {
            if (!flagHasAddEventAttendees)
              {
                flagHasAddEventAttendees = true;
                storeAddEventAttendees.Clear();
              }
            Debug.Assert(flagHasAddEventAttendees);
            storeAddEventAttendees.Add(to_append);
          }
        public void unsetAddEventAttendees()
          {
            flagHasAddEventAttendees = false;
            storeAddEventAttendees.Clear();
          }
        public void initRemoveEventAttendees()
          {
            flagHasRemoveEventAttendees = true;
            storeRemoveEventAttendees.Clear();
          }
        public void appendRemoveEventAttendees(string to_append)
          {
            if (!flagHasRemoveEventAttendees)
              {
                flagHasRemoveEventAttendees = true;
                storeRemoveEventAttendees.Clear();
              }
            Debug.Assert(flagHasRemoveEventAttendees);
            storeRemoveEventAttendees.Add(to_append);
          }
        public void unsetRemoveEventAttendees()
          {
            flagHasRemoveEventAttendees = false;
            storeRemoveEventAttendees.Clear();
          }
        public void setNewSelfAttendeeStatus(TypeNewSelfAttendeeStatus new_value)
          {
            flagHasNewSelfAttendeeStatus = true;
            storeNewSelfAttendeeStatus = new_value;
          }
        public void setNewSelfAttendeeStatus(string chars)
          {
            setNewSelfAttendeeStatus(stringToNewSelfAttendeeStatus(chars));
          }
        public void unsetNewSelfAttendeeStatus()
          {
            flagHasNewSelfAttendeeStatus = false;
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
            Debug.Assert(partial_allowed || flagHasItemType);
            if (flagHasItemType)
              {
                handler.start_pair("ItemType");
                handler.string_value(storeItemType);
              }
            Debug.Assert(partial_allowed || flagHasExactTitle);
            if (flagHasExactTitle)
              {
                handler.start_pair("ExactTitle");
                handler.string_value(storeExactTitle);
              }
            Debug.Assert(partial_allowed || flagHasPartialTitle);
            if (flagHasPartialTitle)
              {
                handler.start_pair("PartialTitle");
                handler.string_value(storePartialTitle);
              }
            Debug.Assert(partial_allowed || flagHasExactLocation);
            if (flagHasExactLocation)
              {
                handler.start_pair("ExactLocation");
                handler.string_value(storeExactLocation);
              }
            Debug.Assert(partial_allowed || flagHasPartialLocation);
            if (flagHasPartialLocation)
              {
                handler.start_pair("PartialLocation");
                handler.string_value(storePartialLocation);
              }
            if (flagHasLocationSpecifier)
              {
                handler.start_pair("LocationSpecifier");
                if (partial_allowed)
                    storeLocationSpecifier.write_partial_as_json(handler);
                else
                    storeLocationSpecifier.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasStartStart);
            if (flagHasStartStart)
              {
                handler.start_pair("StartStart");
                if (partial_allowed)
                    storeStartStart.write_partial_as_json(handler);
                else
                    storeStartStart.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasEndStart);
            if (flagHasEndStart)
              {
                handler.start_pair("EndStart");
                if (partial_allowed)
                    storeEndStart.write_partial_as_json(handler);
                else
                    storeEndStart.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasStartEnd);
            if (flagHasStartEnd)
              {
                handler.start_pair("StartEnd");
                if (partial_allowed)
                    storeStartEnd.write_partial_as_json(handler);
                else
                    storeStartEnd.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasEndEnd);
            if (flagHasEndEnd)
              {
                handler.start_pair("EndEnd");
                if (partial_allowed)
                    storeEndEnd.write_partial_as_json(handler);
                else
                    storeEndEnd.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasNewItemType);
            if (flagHasNewItemType)
              {
                handler.start_pair("NewItemType");
                handler.string_value(storeNewItemType);
              }
            Debug.Assert(partial_allowed || flagHasNewTitle);
            if (flagHasNewTitle)
              {
                handler.start_pair("NewTitle");
                handler.string_value(storeNewTitle);
              }
            Debug.Assert(partial_allowed || flagHasNewLocation);
            if (flagHasNewLocation)
              {
                handler.start_pair("NewLocation");
                handler.string_value(storeNewLocation);
              }
            if (flagHasNewLocationSpecifier)
              {
                handler.start_pair("NewLocationSpecifier");
                if (partial_allowed)
                    storeNewLocationSpecifier.write_partial_as_json(handler);
                else
                    storeNewLocationSpecifier.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasNewStart);
            if (flagHasNewStart)
              {
                handler.start_pair("NewStart");
                if (partial_allowed)
                    storeNewStart.write_partial_as_json(handler);
                else
                    storeNewStart.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasStartDeltaSeconds);
            if (flagHasStartDeltaSeconds)
              {
                handler.start_pair("StartDeltaSeconds");
                if (textStoreStartDeltaSeconds != "")
                    handler.number_value(textStoreStartDeltaSeconds);
                else if (((double)(long)storeStartDeltaSeconds) == storeStartDeltaSeconds)
                    handler.number_value((long)storeStartDeltaSeconds);
                else
                    handler.number_value(storeStartDeltaSeconds);
              }
            Debug.Assert(partial_allowed || flagHasStartDeltaDays);
            if (flagHasStartDeltaDays)
              {
                handler.start_pair("StartDeltaDays");
                handler.number_value(storeStartDeltaDays);
              }
            Debug.Assert(partial_allowed || flagHasStartDeltaMonths);
            if (flagHasStartDeltaMonths)
              {
                handler.start_pair("StartDeltaMonths");
                handler.number_value(storeStartDeltaMonths);
              }
            Debug.Assert(partial_allowed || flagHasNewEnd);
            if (flagHasNewEnd)
              {
                handler.start_pair("NewEnd");
                if (partial_allowed)
                    storeNewEnd.write_partial_as_json(handler);
                else
                    storeNewEnd.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasEndDeltaSeconds);
            if (flagHasEndDeltaSeconds)
              {
                handler.start_pair("EndDeltaSeconds");
                if (textStoreEndDeltaSeconds != "")
                    handler.number_value(textStoreEndDeltaSeconds);
                else if (((double)(long)storeEndDeltaSeconds) == storeEndDeltaSeconds)
                    handler.number_value((long)storeEndDeltaSeconds);
                else
                    handler.number_value(storeEndDeltaSeconds);
              }
            Debug.Assert(partial_allowed || flagHasEndDeltaDays);
            if (flagHasEndDeltaDays)
              {
                handler.start_pair("EndDeltaDays");
                handler.number_value(storeEndDeltaDays);
              }
            Debug.Assert(partial_allowed || flagHasEndDeltaMonths);
            if (flagHasEndDeltaMonths)
              {
                handler.start_pair("EndDeltaMonths");
                handler.number_value(storeEndDeltaMonths);
              }
            Debug.Assert(partial_allowed || flagHasNewFrequencyType);
            if (flagHasNewFrequencyType)
              {
                handler.start_pair("NewFrequencyType");
                switch (storeNewFrequencyType)
                  {
                    case TypeNewFrequencyType.NewFrequencyType_unknown:
                        handler.string_value("unknown");
                        break;
                    case TypeNewFrequencyType.NewFrequencyType_one_time:
                        handler.string_value("one-time");
                        break;
                    case TypeNewFrequencyType.NewFrequencyType_daily:
                        handler.string_value("daily");
                        break;
                    case TypeNewFrequencyType.NewFrequencyType_weekly:
                        handler.string_value("weekly");
                        break;
                    case TypeNewFrequencyType.NewFrequencyType_monthly:
                        handler.string_value("monthly");
                        break;
                    case TypeNewFrequencyType.NewFrequencyType_yearly:
                        handler.string_value("yearly");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            Debug.Assert(partial_allowed || flagHasNewFrequencyMultiplier);
            if (flagHasNewFrequencyMultiplier)
              {
                handler.start_pair("NewFrequencyMultiplier");
                handler.number_value(storeNewFrequencyMultiplier);
              }
            if (flagHasAddEventAttendees)
              {
                handler.start_pair("AddEventAttendees");
                handler.start_array();
                for (int num1 = 0; num1 < storeAddEventAttendees.Count; ++num1)
                  {
                    handler.string_value(storeAddEventAttendees[num1]);
                  }
                handler.finish_array();
              }
            if (flagHasRemoveEventAttendees)
              {
                handler.start_pair("RemoveEventAttendees");
                handler.start_array();
                for (int num2 = 0; num2 < storeRemoveEventAttendees.Count; ++num2)
                  {
                    handler.string_value(storeRemoveEventAttendees[num2]);
                  }
                handler.finish_array();
              }
            if (flagHasNewSelfAttendeeStatus)
              {
                handler.start_pair("NewSelfAttendeeStatus");
                switch (storeNewSelfAttendeeStatus)
                  {
                    case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_None:
                        handler.string_value("None");
                        break;
                    case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Accepted:
                        handler.string_value("Accepted");
                        break;
                    case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Declined:
                        handler.string_value("Declined");
                        break;
                    case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Invited:
                        handler.string_value("Invited");
                        break;
                    case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Tentative:
                        handler.string_value("Tentative");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
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
            if (!(hasItemType()))
              {
                return "When parsing the object for %what%, the \"ItemType\" field was missing.";
              }
            if (!(hasExactTitle()))
              {
                return "When parsing the object for %what%, the \"ExactTitle\" field was missing.";
              }
            if (!(hasPartialTitle()))
              {
                return "When parsing the object for %what%, the \"PartialTitle\" field was missing.";
              }
            if (!(hasExactLocation()))
              {
                return "When parsing the object for %what%, the \"ExactLocation\" field was missing.";
              }
            if (!(hasPartialLocation()))
              {
                return "When parsing the object for %what%, the \"PartialLocation\" field was missing.";
              }
            if (!(hasStartStart()))
              {
                return "When parsing the object for %what%, the \"StartStart\" field was missing.";
              }
            if (!(hasEndStart()))
              {
                return "When parsing the object for %what%, the \"EndStart\" field was missing.";
              }
            if (!(hasStartEnd()))
              {
                return "When parsing the object for %what%, the \"StartEnd\" field was missing.";
              }
            if (!(hasEndEnd()))
              {
                return "When parsing the object for %what%, the \"EndEnd\" field was missing.";
              }
            if (!(hasNewItemType()))
              {
                return "When parsing the object for %what%, the \"NewItemType\" field was missing.";
              }
            if (!(hasNewTitle()))
              {
                return "When parsing the object for %what%, the \"NewTitle\" field was missing.";
              }
            if (!(hasNewLocation()))
              {
                return "When parsing the object for %what%, the \"NewLocation\" field was missing.";
              }
            if (!(hasNewStart()))
              {
                return "When parsing the object for %what%, the \"NewStart\" field was missing.";
              }
            if (!(hasStartDeltaSeconds()))
              {
                return "When parsing the object for %what%, the \"StartDeltaSeconds\" field was missing.";
              }
            if (!(hasStartDeltaDays()))
              {
                return "When parsing the object for %what%, the \"StartDeltaDays\" field was missing.";
              }
            if (!(hasStartDeltaMonths()))
              {
                return "When parsing the object for %what%, the \"StartDeltaMonths\" field was missing.";
              }
            if (!(hasNewEnd()))
              {
                return "When parsing the object for %what%, the \"NewEnd\" field was missing.";
              }
            if (!(hasEndDeltaSeconds()))
              {
                return "When parsing the object for %what%, the \"EndDeltaSeconds\" field was missing.";
              }
            if (!(hasEndDeltaDays()))
              {
                return "When parsing the object for %what%, the \"EndDeltaDays\" field was missing.";
              }
            if (!(hasEndDeltaMonths()))
              {
                return "When parsing the object for %what%, the \"EndDeltaMonths\" field was missing.";
              }
            if (!(hasNewFrequencyType()))
              {
                return "When parsing the object for %what%, the \"NewFrequencyType\" field was missing.";
              }
            if (!(hasNewFrequencyMultiplier()))
              {
                return "When parsing the object for %what%, the \"NewFrequencyMultiplier\" field was missing.";
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
            private JSONHoldingStringGenerator fieldGeneratorItemType;
            private JSONHoldingStringGenerator fieldGeneratorExactTitle;
            private JSONHoldingStringGenerator fieldGeneratorPartialTitle;
            private JSONHoldingStringGenerator fieldGeneratorExactLocation;
            private JSONHoldingStringGenerator fieldGeneratorPartialLocation;
            private CalendarLocationJSON.HoldingGenerator fieldGeneratorLocationSpecifier;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartStart;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndStart;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartEnd;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndEnd;
            private JSONHoldingStringGenerator fieldGeneratorNewItemType;
            private JSONHoldingStringGenerator fieldGeneratorNewTitle;
            private JSONHoldingStringGenerator fieldGeneratorNewLocation;
            private CalendarLocationJSON.HoldingGenerator fieldGeneratorNewLocationSpecifier;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorNewStart;
            private JSONHoldingNumberTextGenerator fieldGeneratorStartDeltaSeconds;
        private class FieldHoldingGeneratorStartDeltaDays : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorStartDeltaDays(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorStartDeltaDays : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorStartDeltaDays(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorStartDeltaDays fieldGeneratorStartDeltaDays;
        private class FieldHoldingGeneratorStartDeltaMonths : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorStartDeltaMonths(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorStartDeltaMonths : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorStartDeltaMonths(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorStartDeltaMonths fieldGeneratorStartDeltaMonths;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorNewEnd;
            private JSONHoldingNumberTextGenerator fieldGeneratorEndDeltaSeconds;
        private class FieldHoldingGeneratorEndDeltaDays : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorEndDeltaDays(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorEndDeltaDays : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorEndDeltaDays(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorEndDeltaDays fieldGeneratorEndDeltaDays;
        private class FieldHoldingGeneratorEndDeltaMonths : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorEndDeltaMonths(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorEndDeltaMonths : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorEndDeltaMonths(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorEndDeltaMonths fieldGeneratorEndDeltaMonths;
        private abstract class FieldGeneratorNewFrequencyType : JSONStringGenerator
              {
                protected FieldGeneratorNewFrequencyType(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorNewFrequencyType()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToNewFrequencyType(result));
                  }
                protected abstract void handle_result(TypeNewFrequencyType result);
              };
        private class FieldHoldingGeneratorNewFrequencyType : FieldGeneratorNewFrequencyType
      {
        protected override void handle_result(TypeNewFrequencyType result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorNewFrequencyType(String what)
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
        public TypeNewFrequencyType value;
      };
        private class FieldHoldingArrayGeneratorNewFrequencyType : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorNewFrequencyType
          {
            private FieldHoldingArrayGeneratorNewFrequencyType top;

            protected override void handle_result(TypeNewFrequencyType result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorNewFrequencyType init_top)
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
        protected virtual void handle_result(List<TypeNewFrequencyType> result)
          {
          }

        public FieldHoldingArrayGeneratorNewFrequencyType(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeNewFrequencyType>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorNewFrequencyType()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeNewFrequencyType>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeNewFrequencyType> value;
      };
            private FieldHoldingGeneratorNewFrequencyType fieldGeneratorNewFrequencyType;
        private class FieldHoldingGeneratorNewFrequencyMultiplier : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorNewFrequencyMultiplier(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorNewFrequencyMultiplier : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorNewFrequencyMultiplier(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorNewFrequencyMultiplier fieldGeneratorNewFrequencyMultiplier;
            private JSONHoldingStringArrayGenerator fieldGeneratorAddEventAttendees;
            private JSONHoldingStringArrayGenerator fieldGeneratorRemoveEventAttendees;
        private abstract class FieldGeneratorNewSelfAttendeeStatus : JSONStringGenerator
              {
                protected FieldGeneratorNewSelfAttendeeStatus(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorNewSelfAttendeeStatus()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToNewSelfAttendeeStatus(result));
                  }
                protected abstract void handle_result(TypeNewSelfAttendeeStatus result);
              };
        private class FieldHoldingGeneratorNewSelfAttendeeStatus : FieldGeneratorNewSelfAttendeeStatus
      {
        protected override void handle_result(TypeNewSelfAttendeeStatus result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorNewSelfAttendeeStatus(String what)
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
        public TypeNewSelfAttendeeStatus value;
      };
        private class FieldHoldingArrayGeneratorNewSelfAttendeeStatus : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorNewSelfAttendeeStatus
          {
            private FieldHoldingArrayGeneratorNewSelfAttendeeStatus top;

            protected override void handle_result(TypeNewSelfAttendeeStatus result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorNewSelfAttendeeStatus init_top)
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
        protected virtual void handle_result(List<TypeNewSelfAttendeeStatus> result)
          {
          }

        public FieldHoldingArrayGeneratorNewSelfAttendeeStatus(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeNewSelfAttendeeStatus>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorNewSelfAttendeeStatus()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeNewSelfAttendeeStatus>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeNewSelfAttendeeStatus> value;
      };
            private FieldHoldingGeneratorNewSelfAttendeeStatus fieldGeneratorNewSelfAttendeeStatus;
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
                if (fieldGeneratorItemType.have_value)
                  {
                    result.setItemType(fieldGeneratorItemType.value);
                    fieldGeneratorItemType.have_value = false;
                  }
                else if ((!(result.hasItemType())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ItemType\" field was missing.");
                  }
                if (fieldGeneratorExactTitle.have_value)
                  {
                    result.setExactTitle(fieldGeneratorExactTitle.value);
                    fieldGeneratorExactTitle.have_value = false;
                  }
                else if ((!(result.hasExactTitle())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ExactTitle\" field was missing.");
                  }
                if (fieldGeneratorPartialTitle.have_value)
                  {
                    result.setPartialTitle(fieldGeneratorPartialTitle.value);
                    fieldGeneratorPartialTitle.have_value = false;
                  }
                else if ((!(result.hasPartialTitle())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"PartialTitle\" field was missing.");
                  }
                if (fieldGeneratorExactLocation.have_value)
                  {
                    result.setExactLocation(fieldGeneratorExactLocation.value);
                    fieldGeneratorExactLocation.have_value = false;
                  }
                else if ((!(result.hasExactLocation())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ExactLocation\" field was missing.");
                  }
                if (fieldGeneratorPartialLocation.have_value)
                  {
                    result.setPartialLocation(fieldGeneratorPartialLocation.value);
                    fieldGeneratorPartialLocation.have_value = false;
                  }
                else if ((!(result.hasPartialLocation())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"PartialLocation\" field was missing.");
                  }
                if (fieldGeneratorLocationSpecifier.have_value)
                  {
                    result.setLocationSpecifier(fieldGeneratorLocationSpecifier.value);
                    fieldGeneratorLocationSpecifier.have_value = false;
                  }
                if (fieldGeneratorStartStart.have_value)
                  {
                    result.setStartStart(fieldGeneratorStartStart.value);
                    fieldGeneratorStartStart.have_value = false;
                  }
                else if ((!(result.hasStartStart())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"StartStart\" field was missing.");
                  }
                if (fieldGeneratorEndStart.have_value)
                  {
                    result.setEndStart(fieldGeneratorEndStart.value);
                    fieldGeneratorEndStart.have_value = false;
                  }
                else if ((!(result.hasEndStart())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"EndStart\" field was missing.");
                  }
                if (fieldGeneratorStartEnd.have_value)
                  {
                    result.setStartEnd(fieldGeneratorStartEnd.value);
                    fieldGeneratorStartEnd.have_value = false;
                  }
                else if ((!(result.hasStartEnd())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"StartEnd\" field was missing.");
                  }
                if (fieldGeneratorEndEnd.have_value)
                  {
                    result.setEndEnd(fieldGeneratorEndEnd.value);
                    fieldGeneratorEndEnd.have_value = false;
                  }
                else if ((!(result.hasEndEnd())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"EndEnd\" field was missing.");
                  }
                if (fieldGeneratorNewItemType.have_value)
                  {
                    result.setNewItemType(fieldGeneratorNewItemType.value);
                    fieldGeneratorNewItemType.have_value = false;
                  }
                else if ((!(result.hasNewItemType())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewItemType\" field was missing.");
                  }
                if (fieldGeneratorNewTitle.have_value)
                  {
                    result.setNewTitle(fieldGeneratorNewTitle.value);
                    fieldGeneratorNewTitle.have_value = false;
                  }
                else if ((!(result.hasNewTitle())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewTitle\" field was missing.");
                  }
                if (fieldGeneratorNewLocation.have_value)
                  {
                    result.setNewLocation(fieldGeneratorNewLocation.value);
                    fieldGeneratorNewLocation.have_value = false;
                  }
                else if ((!(result.hasNewLocation())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewLocation\" field was missing.");
                  }
                if (fieldGeneratorNewLocationSpecifier.have_value)
                  {
                    result.setNewLocationSpecifier(fieldGeneratorNewLocationSpecifier.value);
                    fieldGeneratorNewLocationSpecifier.have_value = false;
                  }
                if (fieldGeneratorNewStart.have_value)
                  {
                    result.setNewStart(fieldGeneratorNewStart.value);
                    fieldGeneratorNewStart.have_value = false;
                  }
                else if ((!(result.hasNewStart())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewStart\" field was missing.");
                  }
                if (fieldGeneratorStartDeltaSeconds.have_value)
                  {
                    result.setStartDeltaSecondsText(fieldGeneratorStartDeltaSeconds.value);
                    fieldGeneratorStartDeltaSeconds.have_value = false;
                  }
                else if ((!(result.hasStartDeltaSeconds())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"StartDeltaSeconds\" field was missing.");
                  }
                if (fieldGeneratorStartDeltaDays.have_value)
                  {
                    result.setStartDeltaDays(fieldGeneratorStartDeltaDays.value);
                    fieldGeneratorStartDeltaDays.have_value = false;
                  }
                else if ((!(result.hasStartDeltaDays())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"StartDeltaDays\" field was missing.");
                  }
                if (fieldGeneratorStartDeltaMonths.have_value)
                  {
                    result.setStartDeltaMonths(fieldGeneratorStartDeltaMonths.value);
                    fieldGeneratorStartDeltaMonths.have_value = false;
                  }
                else if ((!(result.hasStartDeltaMonths())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"StartDeltaMonths\" field was missing.");
                  }
                if (fieldGeneratorNewEnd.have_value)
                  {
                    result.setNewEnd(fieldGeneratorNewEnd.value);
                    fieldGeneratorNewEnd.have_value = false;
                  }
                else if ((!(result.hasNewEnd())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewEnd\" field was missing.");
                  }
                if (fieldGeneratorEndDeltaSeconds.have_value)
                  {
                    result.setEndDeltaSecondsText(fieldGeneratorEndDeltaSeconds.value);
                    fieldGeneratorEndDeltaSeconds.have_value = false;
                  }
                else if ((!(result.hasEndDeltaSeconds())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"EndDeltaSeconds\" field was missing.");
                  }
                if (fieldGeneratorEndDeltaDays.have_value)
                  {
                    result.setEndDeltaDays(fieldGeneratorEndDeltaDays.value);
                    fieldGeneratorEndDeltaDays.have_value = false;
                  }
                else if ((!(result.hasEndDeltaDays())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"EndDeltaDays\" field was missing.");
                  }
                if (fieldGeneratorEndDeltaMonths.have_value)
                  {
                    result.setEndDeltaMonths(fieldGeneratorEndDeltaMonths.value);
                    fieldGeneratorEndDeltaMonths.have_value = false;
                  }
                else if ((!(result.hasEndDeltaMonths())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"EndDeltaMonths\" field was missing.");
                  }
                if (fieldGeneratorNewFrequencyType.have_value)
                  {
                    result.setNewFrequencyType(fieldGeneratorNewFrequencyType.value);
                    fieldGeneratorNewFrequencyType.have_value = false;
                  }
                else if ((!(result.hasNewFrequencyType())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewFrequencyType\" field was missing.");
                  }
                if (fieldGeneratorNewFrequencyMultiplier.have_value)
                  {
                    result.setNewFrequencyMultiplier(fieldGeneratorNewFrequencyMultiplier.value);
                    fieldGeneratorNewFrequencyMultiplier.have_value = false;
                  }
                else if ((!(result.hasNewFrequencyMultiplier())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewFrequencyMultiplier\" field was missing.");
                  }
                if (fieldGeneratorAddEventAttendees.have_value)
                  {
                    result.initAddEventAttendees();
                    int count = fieldGeneratorAddEventAttendees.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendAddEventAttendees(fieldGeneratorAddEventAttendees.value[num]);
                      }
                    fieldGeneratorAddEventAttendees.value.Clear();
                    fieldGeneratorAddEventAttendees.have_value = false;
                  }
                if (fieldGeneratorRemoveEventAttendees.have_value)
                  {
                    result.initRemoveEventAttendees();
                    int count = fieldGeneratorRemoveEventAttendees.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendRemoveEventAttendees(fieldGeneratorRemoveEventAttendees.value[num]);
                      }
                    fieldGeneratorRemoveEventAttendees.value.Clear();
                    fieldGeneratorRemoveEventAttendees.have_value = false;
                  }
                if (fieldGeneratorNewSelfAttendeeStatus.have_value)
                  {
                    result.setNewSelfAttendeeStatus(fieldGeneratorNewSelfAttendeeStatus.value);
                    fieldGeneratorNewSelfAttendeeStatus.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "ddEventAttendees", 0, 16, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorAddEventAttendees;
                        break;
                    case 'E':
                        switch (field_name[1])
                          {
                            case 'n':
                                if (String.Compare(field_name, 2, "d", 0, 1, false) == 0)
                                  {
                                    switch (field_name[3])
                                      {
                                        case 'D':
                                            if (String.Compare(field_name, 4, "elta", 0, 4, false) == 0)
                                              {
                                                switch (field_name[8])
                                                  {
                                                    case 'D':
                                                        if ((String.Compare(field_name, 9, "ays", 0, 3, false) == 0) && (field_name.Length == 12))
                                                            return fieldGeneratorEndDeltaDays;
                                                        break;
                                                    case 'M':
                                                        if ((String.Compare(field_name, 9, "onths", 0, 5, false) == 0) && (field_name.Length == 14))
                                                            return fieldGeneratorEndDeltaMonths;
                                                        break;
                                                    case 'S':
                                                        if ((String.Compare(field_name, 9, "econds", 0, 6, false) == 0) && (field_name.Length == 15))
                                                            return fieldGeneratorEndDeltaSeconds;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'E':
                                            if ((String.Compare(field_name, 4, "nd", 0, 2, false) == 0) && (field_name.Length == 6))
                                                return fieldGeneratorEndEnd;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 4, "tart", 0, 4, false) == 0) && (field_name.Length == 8))
                                                return fieldGeneratorEndStart;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'x':
                                if (String.Compare(field_name, 2, "act", 0, 3, false) == 0)
                                  {
                                    switch (field_name[5])
                                      {
                                        case 'L':
                                            if ((String.Compare(field_name, 6, "ocation", 0, 7, false) == 0) && (field_name.Length == 13))
                                                return fieldGeneratorExactLocation;
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 6, "itle", 0, 4, false) == 0) && (field_name.Length == 10))
                                                return fieldGeneratorExactTitle;
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
                    case 'I':
                        if ((String.Compare(field_name, 1, "temType", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorItemType;
                        break;
                    case 'L':
                        if ((String.Compare(field_name, 1, "ocationSpecifier", 0, 16, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorLocationSpecifier;
                        break;
                    case 'N':
                        if (String.Compare(field_name, 1, "ew", 0, 2, false) == 0)
                          {
                            switch (field_name[3])
                              {
                                case 'E':
                                    if ((String.Compare(field_name, 4, "nd", 0, 2, false) == 0) && (field_name.Length == 6))
                                        return fieldGeneratorNewEnd;
                                    break;
                                case 'F':
                                    if (String.Compare(field_name, 4, "requency", 0, 8, false) == 0)
                                      {
                                        switch (field_name[12])
                                          {
                                            case 'M':
                                                if ((String.Compare(field_name, 13, "ultiplier", 0, 9, false) == 0) && (field_name.Length == 22))
                                                    return fieldGeneratorNewFrequencyMultiplier;
                                                break;
                                            case 'T':
                                                if ((String.Compare(field_name, 13, "ype", 0, 3, false) == 0) && (field_name.Length == 16))
                                                    return fieldGeneratorNewFrequencyType;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'I':
                                    if ((String.Compare(field_name, 4, "temType", 0, 7, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorNewItemType;
                                    break;
                                case 'L':
                                    if (String.Compare(field_name, 4, "ocation", 0, 7, false) == 0)
                                      {
                                        if (field_name.Length == 11)
                                          {
                                            return fieldGeneratorNewLocation;
                                          }
                                        switch (field_name[11])
                                          {
                                            case 'S':
                                                if ((String.Compare(field_name, 12, "pecifier", 0, 8, false) == 0) && (field_name.Length == 20))
                                                    return fieldGeneratorNewLocationSpecifier;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'S':
                                    switch (field_name[4])
                                      {
                                        case 'e':
                                            if ((String.Compare(field_name, 5, "lfAttendeeStatus", 0, 16, false) == 0) && (field_name.Length == 21))
                                                return fieldGeneratorNewSelfAttendeeStatus;
                                            break;
                                        case 't':
                                            if ((String.Compare(field_name, 5, "art", 0, 3, false) == 0) && (field_name.Length == 8))
                                                return fieldGeneratorNewStart;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 4, "itle", 0, 4, false) == 0) && (field_name.Length == 8))
                                        return fieldGeneratorNewTitle;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'P':
                        if (String.Compare(field_name, 1, "artial", 0, 6, false) == 0)
                          {
                            switch (field_name[7])
                              {
                                case 'L':
                                    if ((String.Compare(field_name, 8, "ocation", 0, 7, false) == 0) && (field_name.Length == 15))
                                        return fieldGeneratorPartialLocation;
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 8, "itle", 0, 4, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorPartialTitle;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "emoveEventAttendees", 0, 19, false) == 0) && (field_name.Length == 20))
                            return fieldGeneratorRemoveEventAttendees;
                        break;
                    case 'S':
                        if (String.Compare(field_name, 1, "tart", 0, 4, false) == 0)
                          {
                            switch (field_name[5])
                              {
                                case 'D':
                                    if (String.Compare(field_name, 6, "elta", 0, 4, false) == 0)
                                      {
                                        switch (field_name[10])
                                          {
                                            case 'D':
                                                if ((String.Compare(field_name, 11, "ays", 0, 3, false) == 0) && (field_name.Length == 14))
                                                    return fieldGeneratorStartDeltaDays;
                                                break;
                                            case 'M':
                                                if ((String.Compare(field_name, 11, "onths", 0, 5, false) == 0) && (field_name.Length == 16))
                                                    return fieldGeneratorStartDeltaMonths;
                                                break;
                                            case 'S':
                                                if ((String.Compare(field_name, 11, "econds", 0, 6, false) == 0) && (field_name.Length == 17))
                                                    return fieldGeneratorStartDeltaSeconds;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'E':
                                    if ((String.Compare(field_name, 6, "nd", 0, 2, false) == 0) && (field_name.Length == 8))
                                        return fieldGeneratorStartEnd;
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 6, "tart", 0, 4, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorStartStart;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorItemType = new JSONHoldingStringGenerator("field \"ItemType\" of the TypeNativeData class");
                fieldGeneratorExactTitle = new JSONHoldingStringGenerator("field \"ExactTitle\" of the TypeNativeData class");
                fieldGeneratorPartialTitle = new JSONHoldingStringGenerator("field \"PartialTitle\" of the TypeNativeData class");
                fieldGeneratorExactLocation = new JSONHoldingStringGenerator("field \"ExactLocation\" of the TypeNativeData class");
                fieldGeneratorPartialLocation = new JSONHoldingStringGenerator("field \"PartialLocation\" of the TypeNativeData class");
                fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorStartStart = new DateAndOrTimeJSON.HoldingGenerator("field \"StartStart\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorEndStart = new DateAndOrTimeJSON.HoldingGenerator("field \"EndStart\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorStartEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"StartEnd\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorEndEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"EndEnd\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorNewItemType = new JSONHoldingStringGenerator("field \"NewItemType\" of the TypeNativeData class");
                fieldGeneratorNewTitle = new JSONHoldingStringGenerator("field \"NewTitle\" of the TypeNativeData class");
                fieldGeneratorNewLocation = new JSONHoldingStringGenerator("field \"NewLocation\" of the TypeNativeData class");
                fieldGeneratorNewLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"NewLocationSpecifier\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorNewStart = new DateAndOrTimeJSON.HoldingGenerator("field \"NewStart\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorStartDeltaSeconds = new JSONHoldingNumberTextGenerator("field \"StartDeltaSeconds\" of the TypeNativeData class");
                fieldGeneratorStartDeltaDays = new FieldHoldingGeneratorStartDeltaDays("field \"StartDeltaDays\" of the TypeNativeData class");
                fieldGeneratorStartDeltaMonths = new FieldHoldingGeneratorStartDeltaMonths("field \"StartDeltaMonths\" of the TypeNativeData class");
                fieldGeneratorNewEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"NewEnd\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorEndDeltaSeconds = new JSONHoldingNumberTextGenerator("field \"EndDeltaSeconds\" of the TypeNativeData class");
                fieldGeneratorEndDeltaDays = new FieldHoldingGeneratorEndDeltaDays("field \"EndDeltaDays\" of the TypeNativeData class");
                fieldGeneratorEndDeltaMonths = new FieldHoldingGeneratorEndDeltaMonths("field \"EndDeltaMonths\" of the TypeNativeData class");
                fieldGeneratorNewFrequencyType = new FieldHoldingGeneratorNewFrequencyType("field \"NewFrequencyType\" of the TypeNativeData class");
                fieldGeneratorNewFrequencyMultiplier = new FieldHoldingGeneratorNewFrequencyMultiplier("field \"NewFrequencyMultiplier\" of the TypeNativeData class");
                fieldGeneratorAddEventAttendees = new JSONHoldingStringArrayGenerator("field \"AddEventAttendees\" of the TypeNativeData class");
                fieldGeneratorRemoveEventAttendees = new JSONHoldingStringArrayGenerator("field \"RemoveEventAttendees\" of the TypeNativeData class");
                fieldGeneratorNewSelfAttendeeStatus = new FieldHoldingGeneratorNewSelfAttendeeStatus("field \"NewSelfAttendeeStatus\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorItemType = new JSONHoldingStringGenerator("field \"ItemType\" of the TypeNativeData class");
                fieldGeneratorExactTitle = new JSONHoldingStringGenerator("field \"ExactTitle\" of the TypeNativeData class");
                fieldGeneratorPartialTitle = new JSONHoldingStringGenerator("field \"PartialTitle\" of the TypeNativeData class");
                fieldGeneratorExactLocation = new JSONHoldingStringGenerator("field \"ExactLocation\" of the TypeNativeData class");
                fieldGeneratorPartialLocation = new JSONHoldingStringGenerator("field \"PartialLocation\" of the TypeNativeData class");
                fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the TypeNativeData class", false);
                fieldGeneratorStartStart = new DateAndOrTimeJSON.HoldingGenerator("field \"StartStart\" of the TypeNativeData class", false);
                fieldGeneratorEndStart = new DateAndOrTimeJSON.HoldingGenerator("field \"EndStart\" of the TypeNativeData class", false);
                fieldGeneratorStartEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"StartEnd\" of the TypeNativeData class", false);
                fieldGeneratorEndEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"EndEnd\" of the TypeNativeData class", false);
                fieldGeneratorNewItemType = new JSONHoldingStringGenerator("field \"NewItemType\" of the TypeNativeData class");
                fieldGeneratorNewTitle = new JSONHoldingStringGenerator("field \"NewTitle\" of the TypeNativeData class");
                fieldGeneratorNewLocation = new JSONHoldingStringGenerator("field \"NewLocation\" of the TypeNativeData class");
                fieldGeneratorNewLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"NewLocationSpecifier\" of the TypeNativeData class", false);
                fieldGeneratorNewStart = new DateAndOrTimeJSON.HoldingGenerator("field \"NewStart\" of the TypeNativeData class", false);
                fieldGeneratorStartDeltaSeconds = new JSONHoldingNumberTextGenerator("field \"StartDeltaSeconds\" of the TypeNativeData class");
                fieldGeneratorStartDeltaDays = new FieldHoldingGeneratorStartDeltaDays("field \"StartDeltaDays\" of the TypeNativeData class");
                fieldGeneratorStartDeltaMonths = new FieldHoldingGeneratorStartDeltaMonths("field \"StartDeltaMonths\" of the TypeNativeData class");
                fieldGeneratorNewEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"NewEnd\" of the TypeNativeData class", false);
                fieldGeneratorEndDeltaSeconds = new JSONHoldingNumberTextGenerator("field \"EndDeltaSeconds\" of the TypeNativeData class");
                fieldGeneratorEndDeltaDays = new FieldHoldingGeneratorEndDeltaDays("field \"EndDeltaDays\" of the TypeNativeData class");
                fieldGeneratorEndDeltaMonths = new FieldHoldingGeneratorEndDeltaMonths("field \"EndDeltaMonths\" of the TypeNativeData class");
                fieldGeneratorNewFrequencyType = new FieldHoldingGeneratorNewFrequencyType("field \"NewFrequencyType\" of the TypeNativeData class");
                fieldGeneratorNewFrequencyMultiplier = new FieldHoldingGeneratorNewFrequencyMultiplier("field \"NewFrequencyMultiplier\" of the TypeNativeData class");
                fieldGeneratorAddEventAttendees = new JSONHoldingStringArrayGenerator("field \"AddEventAttendees\" of the TypeNativeData class");
                fieldGeneratorRemoveEventAttendees = new JSONHoldingStringArrayGenerator("field \"RemoveEventAttendees\" of the TypeNativeData class");
                fieldGeneratorNewSelfAttendeeStatus = new FieldHoldingGeneratorNewSelfAttendeeStatus("field \"NewSelfAttendeeStatus\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorItemType.reset();
                fieldGeneratorExactTitle.reset();
                fieldGeneratorPartialTitle.reset();
                fieldGeneratorExactLocation.reset();
                fieldGeneratorPartialLocation.reset();
                fieldGeneratorLocationSpecifier.reset();
                fieldGeneratorStartStart.reset();
                fieldGeneratorEndStart.reset();
                fieldGeneratorStartEnd.reset();
                fieldGeneratorEndEnd.reset();
                fieldGeneratorNewItemType.reset();
                fieldGeneratorNewTitle.reset();
                fieldGeneratorNewLocation.reset();
                fieldGeneratorNewLocationSpecifier.reset();
                fieldGeneratorNewStart.reset();
                fieldGeneratorStartDeltaSeconds.reset();
                fieldGeneratorStartDeltaDays.reset();
                fieldGeneratorStartDeltaMonths.reset();
                fieldGeneratorNewEnd.reset();
                fieldGeneratorEndDeltaSeconds.reset();
                fieldGeneratorEndDeltaDays.reset();
                fieldGeneratorEndDeltaMonths.reset();
                fieldGeneratorNewFrequencyType.reset();
                fieldGeneratorNewFrequencyMultiplier.reset();
                fieldGeneratorAddEventAttendees.reset();
                fieldGeneratorRemoveEventAttendees.reset();
                fieldGeneratorNewSelfAttendeeStatus.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorLocationSpecifier.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorStartStart.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorEndStart.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorStartEnd.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorEndEnd.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorNewLocationSpecifier.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorNewStart.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorNewEnd.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorLocationSpecifier.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorStartStart.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorEndStart.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorStartEnd.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorEndEnd.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorNewLocationSpecifier.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorNewStart.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorNewEnd.set_allow_unpolished(new_allow_unpolished);
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
    private bool flagHasItemType;
    private string storeItemType;
    private bool flagHasExactTitle;
    private string storeExactTitle;
    private bool flagHasPartialTitle;
    private string storePartialTitle;
    private bool flagHasExactLocation;
    private string storeExactLocation;
    private bool flagHasPartialLocation;
    private string storePartialLocation;
    private bool flagHasLocationSpecifier;
    private CalendarLocationJSON  storeLocationSpecifier;
    private bool flagHasStartStart;
    private DateAndOrTimeJSON  storeStartStart;
    private bool flagHasEndStart;
    private DateAndOrTimeJSON  storeEndStart;
    private bool flagHasStartEnd;
    private DateAndOrTimeJSON  storeStartEnd;
    private bool flagHasEndEnd;
    private DateAndOrTimeJSON  storeEndEnd;
    private bool flagHasNewItemType;
    private string storeNewItemType;
    private bool flagHasNewTitle;
    private string storeNewTitle;
    private bool flagHasNewLocation;
    private string storeNewLocation;
    private bool flagHasNewLocationSpecifier;
    private CalendarLocationJSON  storeNewLocationSpecifier;
    private bool flagHasNewStart;
    private DateAndOrTimeJSON  storeNewStart;
    private bool flagHasStartDeltaSeconds;
    private double storeStartDeltaSeconds;
    private string textStoreStartDeltaSeconds;
    private bool flagHasStartDeltaDays;
    private BigInteger storeStartDeltaDays;
    private bool flagHasStartDeltaMonths;
    private BigInteger storeStartDeltaMonths;
    private bool flagHasNewEnd;
    private DateAndOrTimeJSON  storeNewEnd;
    private bool flagHasEndDeltaSeconds;
    private double storeEndDeltaSeconds;
    private string textStoreEndDeltaSeconds;
    private bool flagHasEndDeltaDays;
    private BigInteger storeEndDeltaDays;
    private bool flagHasEndDeltaMonths;
    private BigInteger storeEndDeltaMonths;
    private bool flagHasNewFrequencyType;
    private TypeNewFrequencyType storeNewFrequencyType;
    private bool flagHasNewFrequencyMultiplier;
    private BigInteger storeNewFrequencyMultiplier;
    private bool flagHasAddEventAttendees;
    private List< string > storeAddEventAttendees;
    private bool flagHasRemoveEventAttendees;
    private List< string > storeRemoveEventAttendees;
    private bool flagHasNewSelfAttendeeStatus;
    private TypeNewSelfAttendeeStatus storeNewSelfAttendeeStatus;
    private bool flagHasNativeData;
    private TypeNativeDataJSON  storeNativeData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraItemTypeToJSON()
      {
        JSONStringValue generated_string_ItemType = new JSONStringValue(storeItemType);
        return generated_string_ItemType;
      }

    private JSONValue  extraExactTitleToJSON()
      {
        JSONStringValue generated_string_ExactTitle = new JSONStringValue(storeExactTitle);
        return generated_string_ExactTitle;
      }

    private JSONValue  extraPartialTitleToJSON()
      {
        JSONStringValue generated_string_PartialTitle = new JSONStringValue(storePartialTitle);
        return generated_string_PartialTitle;
      }

    private JSONValue  extraExactLocationToJSON()
      {
        JSONStringValue generated_string_ExactLocation = new JSONStringValue(storeExactLocation);
        return generated_string_ExactLocation;
      }

    private JSONValue  extraPartialLocationToJSON()
      {
        JSONStringValue generated_string_PartialLocation = new JSONStringValue(storePartialLocation);
        return generated_string_PartialLocation;
      }

    private JSONValue  extraLocationSpecifierToJSON()
      {
        JSONValueHandler handler_LocationSpecifier = new JSONValueHandler();
        storeLocationSpecifier.write_as_json(handler_LocationSpecifier);
        return handler_LocationSpecifier.result;
      }

    private JSONValue  extraStartStartToJSON()
      {
        JSONValueHandler handler_StartStart = new JSONValueHandler();
        storeStartStart.write_as_json(handler_StartStart);
        return handler_StartStart.result;
      }

    private JSONValue  extraEndStartToJSON()
      {
        JSONValueHandler handler_EndStart = new JSONValueHandler();
        storeEndStart.write_as_json(handler_EndStart);
        return handler_EndStart.result;
      }

    private JSONValue  extraStartEndToJSON()
      {
        JSONValueHandler handler_StartEnd = new JSONValueHandler();
        storeStartEnd.write_as_json(handler_StartEnd);
        return handler_StartEnd.result;
      }

    private JSONValue  extraEndEndToJSON()
      {
        JSONValueHandler handler_EndEnd = new JSONValueHandler();
        storeEndEnd.write_as_json(handler_EndEnd);
        return handler_EndEnd.result;
      }

    private JSONValue  extraNewItemTypeToJSON()
      {
        JSONStringValue generated_string_NewItemType = new JSONStringValue(storeNewItemType);
        return generated_string_NewItemType;
      }

    private JSONValue  extraNewTitleToJSON()
      {
        JSONStringValue generated_string_NewTitle = new JSONStringValue(storeNewTitle);
        return generated_string_NewTitle;
      }

    private JSONValue  extraNewLocationToJSON()
      {
        JSONStringValue generated_string_NewLocation = new JSONStringValue(storeNewLocation);
        return generated_string_NewLocation;
      }

    private JSONValue  extraNewLocationSpecifierToJSON()
      {
        JSONValueHandler handler_NewLocationSpecifier = new JSONValueHandler();
        storeNewLocationSpecifier.write_as_json(handler_NewLocationSpecifier);
        return handler_NewLocationSpecifier.result;
      }

    private JSONValue  extraNewStartToJSON()
      {
        JSONValueHandler handler_NewStart = new JSONValueHandler();
        storeNewStart.write_as_json(handler_NewStart);
        return handler_NewStart.result;
      }

    private JSONValue  extraStartDeltaSecondsToJSON()
      {
        JSONValue generated_rational_StartDeltaSeconds;
        if (textStoreStartDeltaSeconds != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreStartDeltaSeconds);
            generated_rational_StartDeltaSeconds = handler.result;
          }
        else if (((double)(long)storeStartDeltaSeconds) == storeStartDeltaSeconds)
            generated_rational_StartDeltaSeconds = new JSONIntegerValue((long)(storeStartDeltaSeconds));
        else
            generated_rational_StartDeltaSeconds = new JSONRationalValue(storeStartDeltaSeconds, 15);
        return generated_rational_StartDeltaSeconds;
      }

    private JSONValue  extraStartDeltaDaysToJSON()
      {
        JSONIntegerValue generated_integer_StartDeltaDays = new JSONIntegerValue(storeStartDeltaDays);
        return generated_integer_StartDeltaDays;
      }

    private JSONValue  extraStartDeltaMonthsToJSON()
      {
        JSONIntegerValue generated_integer_StartDeltaMonths = new JSONIntegerValue(storeStartDeltaMonths);
        return generated_integer_StartDeltaMonths;
      }

    private JSONValue  extraNewEndToJSON()
      {
        JSONValueHandler handler_NewEnd = new JSONValueHandler();
        storeNewEnd.write_as_json(handler_NewEnd);
        return handler_NewEnd.result;
      }

    private JSONValue  extraEndDeltaSecondsToJSON()
      {
        JSONValue generated_rational_EndDeltaSeconds;
        if (textStoreEndDeltaSeconds != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreEndDeltaSeconds);
            generated_rational_EndDeltaSeconds = handler.result;
          }
        else if (((double)(long)storeEndDeltaSeconds) == storeEndDeltaSeconds)
            generated_rational_EndDeltaSeconds = new JSONIntegerValue((long)(storeEndDeltaSeconds));
        else
            generated_rational_EndDeltaSeconds = new JSONRationalValue(storeEndDeltaSeconds, 15);
        return generated_rational_EndDeltaSeconds;
      }

    private JSONValue  extraEndDeltaDaysToJSON()
      {
        JSONIntegerValue generated_integer_EndDeltaDays = new JSONIntegerValue(storeEndDeltaDays);
        return generated_integer_EndDeltaDays;
      }

    private JSONValue  extraEndDeltaMonthsToJSON()
      {
        JSONIntegerValue generated_integer_EndDeltaMonths = new JSONIntegerValue(storeEndDeltaMonths);
        return generated_integer_EndDeltaMonths;
      }

    private JSONValue  extraNewFrequencyTypeToJSON()
      {
        JSONStringValue generated_string_NewFrequencyType;
        switch (storeNewFrequencyType)
          {
            case TypeNewFrequencyType.NewFrequencyType_unknown:
                generated_string_NewFrequencyType = new JSONStringValue("unknown");
                break;
            case TypeNewFrequencyType.NewFrequencyType_one_time:
                generated_string_NewFrequencyType = new JSONStringValue("one-time");
                break;
            case TypeNewFrequencyType.NewFrequencyType_daily:
                generated_string_NewFrequencyType = new JSONStringValue("daily");
                break;
            case TypeNewFrequencyType.NewFrequencyType_weekly:
                generated_string_NewFrequencyType = new JSONStringValue("weekly");
                break;
            case TypeNewFrequencyType.NewFrequencyType_monthly:
                generated_string_NewFrequencyType = new JSONStringValue("monthly");
                break;
            case TypeNewFrequencyType.NewFrequencyType_yearly:
                generated_string_NewFrequencyType = new JSONStringValue("yearly");
                break;
            default:
                Debug.Assert(false);
                generated_string_NewFrequencyType = null;
                break;
          }
        return generated_string_NewFrequencyType;
      }

    private JSONValue  extraNewFrequencyMultiplierToJSON()
      {
        JSONIntegerValue generated_integer_NewFrequencyMultiplier = new JSONIntegerValue(storeNewFrequencyMultiplier);
        return generated_integer_NewFrequencyMultiplier;
      }

    private JSONValue  extraAddEventAttendeesToJSON()
      {
        JSONArrayValue generated_array_1_AddEventAttendees = new JSONArrayValue();
        for (int num1 = 0; num1 < storeAddEventAttendees.Count; ++num1)
          {
            JSONStringValue generated_string_AddEventAttendees = new JSONStringValue(storeAddEventAttendees[num1]);
            generated_array_1_AddEventAttendees.appendComponent(generated_string_AddEventAttendees);
          }
        return generated_array_1_AddEventAttendees;
      }

    private JSONValue  extraRemoveEventAttendeesToJSON()
      {
        JSONArrayValue generated_array_2_RemoveEventAttendees = new JSONArrayValue();
        for (int num2 = 0; num2 < storeRemoveEventAttendees.Count; ++num2)
          {
            JSONStringValue generated_string_RemoveEventAttendees = new JSONStringValue(storeRemoveEventAttendees[num2]);
            generated_array_2_RemoveEventAttendees.appendComponent(generated_string_RemoveEventAttendees);
          }
        return generated_array_2_RemoveEventAttendees;
      }

    private JSONValue  extraNewSelfAttendeeStatusToJSON()
      {
        JSONStringValue generated_string_NewSelfAttendeeStatus;
        switch (storeNewSelfAttendeeStatus)
          {
            case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_None:
                generated_string_NewSelfAttendeeStatus = new JSONStringValue("None");
                break;
            case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Accepted:
                generated_string_NewSelfAttendeeStatus = new JSONStringValue("Accepted");
                break;
            case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Declined:
                generated_string_NewSelfAttendeeStatus = new JSONStringValue("Declined");
                break;
            case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Invited:
                generated_string_NewSelfAttendeeStatus = new JSONStringValue("Invited");
                break;
            case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Tentative:
                generated_string_NewSelfAttendeeStatus = new JSONStringValue("Tentative");
                break;
            default:
                Debug.Assert(false);
                generated_string_NewSelfAttendeeStatus = null;
                break;
          }
        return generated_string_NewSelfAttendeeStatus;
      }

    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }


    private void  fromJSONItemType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ItemType of ModifyCalendarItemsCommandJSON is not a string.");
        setItemType(json_string.getData());
      }


    private void  fromJSONExactTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExactTitle of ModifyCalendarItemsCommandJSON is not a string.");
        setExactTitle(json_string.getData());
      }


    private void  fromJSONPartialTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PartialTitle of ModifyCalendarItemsCommandJSON is not a string.");
        setPartialTitle(json_string.getData());
      }


    private void  fromJSONExactLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExactLocation of ModifyCalendarItemsCommandJSON is not a string.");
        setExactLocation(json_string.getData());
      }


    private void  fromJSONPartialLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PartialLocation of ModifyCalendarItemsCommandJSON is not a string.");
        setPartialLocation(json_string.getData());
      }


    private void  fromJSONLocationSpecifier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CalendarLocationJSON convert_classy = CalendarLocationJSON.from_json(json_value, ignore_extras, true);
        setLocationSpecifier(convert_classy);
      }


    private void  fromJSONStartStart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStartStart(convert_classy);
      }


    private void  fromJSONEndStart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setEndStart(convert_classy);
      }


    private void  fromJSONStartEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStartEnd(convert_classy);
      }


    private void  fromJSONEndEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setEndEnd(convert_classy);
      }


    private void  fromJSONNewItemType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NewItemType of ModifyCalendarItemsCommandJSON is not a string.");
        setNewItemType(json_string.getData());
      }


    private void  fromJSONNewTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NewTitle of ModifyCalendarItemsCommandJSON is not a string.");
        setNewTitle(json_string.getData());
      }


    private void  fromJSONNewLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NewLocation of ModifyCalendarItemsCommandJSON is not a string.");
        setNewLocation(json_string.getData());
      }


    private void  fromJSONNewLocationSpecifier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CalendarLocationJSON convert_classy = CalendarLocationJSON.from_json(json_value, ignore_extras, true);
        setNewLocationSpecifier(convert_classy);
      }


    private void  fromJSONNewStart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setNewStart(convert_classy);
      }


    private void  fromJSONStartDeltaSeconds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field StartDeltaSeconds of ModifyCalendarItemsCommandJSON is not a number.");
              }
          }
        setStartDeltaSecondsText(the_rational_text);
      }


    private void  fromJSONStartDeltaDays(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field StartDeltaDays of ModifyCalendarItemsCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field StartDeltaDays of ModifyCalendarItemsCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setStartDeltaDays(extracted_integer);
      }


    private void  fromJSONStartDeltaMonths(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field StartDeltaMonths of ModifyCalendarItemsCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field StartDeltaMonths of ModifyCalendarItemsCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setStartDeltaMonths(extracted_integer);
      }


    private void  fromJSONNewEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setNewEnd(convert_classy);
      }


    private void  fromJSONEndDeltaSeconds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field EndDeltaSeconds of ModifyCalendarItemsCommandJSON is not a number.");
              }
          }
        setEndDeltaSecondsText(the_rational_text);
      }


    private void  fromJSONEndDeltaDays(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field EndDeltaDays of ModifyCalendarItemsCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field EndDeltaDays of ModifyCalendarItemsCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setEndDeltaDays(extracted_integer);
      }


    private void  fromJSONEndDeltaMonths(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field EndDeltaMonths of ModifyCalendarItemsCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field EndDeltaMonths of ModifyCalendarItemsCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setEndDeltaMonths(extracted_integer);
      }


    private void  fromJSONNewFrequencyType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NewFrequencyType of ModifyCalendarItemsCommandJSON is not a string.");
        TypeNewFrequencyType the_enum;
        switch (json_string.getData()[0])
          {
            case 'd':
                if ((String.Compare(json_string.getData(), 1, "aily", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeNewFrequencyType.NewFrequencyType_daily;
                        goto enum_is_done;
                      }
                break;
            case 'm':
                if ((String.Compare(json_string.getData(), 1, "onthly", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeNewFrequencyType.NewFrequencyType_monthly;
                        goto enum_is_done;
                      }
                break;
            case 'o':
                if ((String.Compare(json_string.getData(), 1, "ne-time", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeNewFrequencyType.NewFrequencyType_one_time;
                        goto enum_is_done;
                      }
                break;
            case 'u':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeNewFrequencyType.NewFrequencyType_unknown;
                        goto enum_is_done;
                      }
                break;
            case 'w':
                if ((String.Compare(json_string.getData(), 1, "eekly", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeNewFrequencyType.NewFrequencyType_weekly;
                        goto enum_is_done;
                      }
                break;
            case 'y':
                if ((String.Compare(json_string.getData(), 1, "early", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeNewFrequencyType.NewFrequencyType_yearly;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field NewFrequencyType of ModifyCalendarItemsCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setNewFrequencyType(the_enum);
      }


    private void  fromJSONNewFrequencyMultiplier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NewFrequencyMultiplier of ModifyCalendarItemsCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NewFrequencyMultiplier of ModifyCalendarItemsCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNewFrequencyMultiplier(extracted_integer);
      }


    private void  fromJSONAddEventAttendees(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AddEventAttendees of ModifyCalendarItemsCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_AddEventAttendees1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field AddEventAttendees of ModifyCalendarItemsCommandJSON is not a string.");
            vector_AddEventAttendees1.Add(json_string.getData());
          }
        initAddEventAttendees();
        for (int num3 = 0; num3 < vector_AddEventAttendees1.Count; ++num3)
            appendAddEventAttendees(vector_AddEventAttendees1[num3]);
        for (int num1 = 0; num1 < vector_AddEventAttendees1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRemoveEventAttendees(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RemoveEventAttendees of ModifyCalendarItemsCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_RemoveEventAttendees1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field RemoveEventAttendees of ModifyCalendarItemsCommandJSON is not a string.");
            vector_RemoveEventAttendees1.Add(json_string.getData());
          }
        initRemoveEventAttendees();
        for (int num4 = 0; num4 < vector_RemoveEventAttendees1.Count; ++num4)
            appendRemoveEventAttendees(vector_RemoveEventAttendees1[num4]);
        for (int num1 = 0; num1 < vector_RemoveEventAttendees1.Count; ++num1)
          {
          }
      }


    private void  fromJSONNewSelfAttendeeStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NewSelfAttendeeStatus of ModifyCalendarItemsCommandJSON is not a string.");
        TypeNewSelfAttendeeStatus the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ccepted", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Accepted;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "eclined", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Declined;
                        goto enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nvited", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Invited;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_None;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "entative", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Tentative;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field NewSelfAttendeeStatus of ModifyCalendarItemsCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setNewSelfAttendeeStatus(the_enum);
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    public ModifyCalendarItemsCommandJSON()
      {
        flagHasItemType = false;
        flagHasExactTitle = false;
        flagHasPartialTitle = false;
        flagHasExactLocation = false;
        flagHasPartialLocation = false;
        flagHasLocationSpecifier = false;
        flagHasStartStart = false;
        flagHasEndStart = false;
        flagHasStartEnd = false;
        flagHasEndEnd = false;
        flagHasNewItemType = false;
        flagHasNewTitle = false;
        flagHasNewLocation = false;
        flagHasNewLocationSpecifier = false;
        flagHasNewStart = false;
        flagHasStartDeltaSeconds = false;
        flagHasStartDeltaDays = false;
        flagHasStartDeltaMonths = false;
        flagHasNewEnd = false;
        flagHasEndDeltaSeconds = false;
        flagHasEndDeltaDays = false;
        flagHasEndDeltaMonths = false;
        flagHasNewFrequencyType = false;
        flagHasNewFrequencyMultiplier = false;
        flagHasAddEventAttendees = false;
        flagHasRemoveEventAttendees = false;
        flagHasNewSelfAttendeeStatus = false;
        flagHasNativeData = false;
        storeAddEventAttendees = new List< string >();
        storeRemoveEventAttendees = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCalendarCommandKind()
      {
        return "ModifyItems";
      }

    public bool  hasItemType()
      {
        return flagHasItemType;
      }

    public string  getItemType()
      {
        Debug.Assert(flagHasItemType);
        return storeItemType;
      }

    public bool  hasExactTitle()
      {
        return flagHasExactTitle;
      }

    public string  getExactTitle()
      {
        Debug.Assert(flagHasExactTitle);
        return storeExactTitle;
      }

    public bool  hasPartialTitle()
      {
        return flagHasPartialTitle;
      }

    public string  getPartialTitle()
      {
        Debug.Assert(flagHasPartialTitle);
        return storePartialTitle;
      }

    public bool  hasExactLocation()
      {
        return flagHasExactLocation;
      }

    public string  getExactLocation()
      {
        Debug.Assert(flagHasExactLocation);
        return storeExactLocation;
      }

    public bool  hasPartialLocation()
      {
        return flagHasPartialLocation;
      }

    public string  getPartialLocation()
      {
        Debug.Assert(flagHasPartialLocation);
        return storePartialLocation;
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

    public bool  hasStartStart()
      {
        return flagHasStartStart;
      }

    public DateAndOrTimeJSON   getStartStart()
      {
        Debug.Assert(flagHasStartStart);
        return storeStartStart;
      }

    public bool  hasEndStart()
      {
        return flagHasEndStart;
      }

    public DateAndOrTimeJSON   getEndStart()
      {
        Debug.Assert(flagHasEndStart);
        return storeEndStart;
      }

    public bool  hasStartEnd()
      {
        return flagHasStartEnd;
      }

    public DateAndOrTimeJSON   getStartEnd()
      {
        Debug.Assert(flagHasStartEnd);
        return storeStartEnd;
      }

    public bool  hasEndEnd()
      {
        return flagHasEndEnd;
      }

    public DateAndOrTimeJSON   getEndEnd()
      {
        Debug.Assert(flagHasEndEnd);
        return storeEndEnd;
      }

    public bool  hasNewItemType()
      {
        return flagHasNewItemType;
      }

    public string  getNewItemType()
      {
        Debug.Assert(flagHasNewItemType);
        return storeNewItemType;
      }

    public bool  hasNewTitle()
      {
        return flagHasNewTitle;
      }

    public string  getNewTitle()
      {
        Debug.Assert(flagHasNewTitle);
        return storeNewTitle;
      }

    public bool  hasNewLocation()
      {
        return flagHasNewLocation;
      }

    public string  getNewLocation()
      {
        Debug.Assert(flagHasNewLocation);
        return storeNewLocation;
      }

    public bool  hasNewLocationSpecifier()
      {
        return flagHasNewLocationSpecifier;
      }

    public CalendarLocationJSON   getNewLocationSpecifier()
      {
        Debug.Assert(flagHasNewLocationSpecifier);
        return storeNewLocationSpecifier;
      }

    public bool  hasNewStart()
      {
        return flagHasNewStart;
      }

    public DateAndOrTimeJSON   getNewStart()
      {
        Debug.Assert(flagHasNewStart);
        return storeNewStart;
      }

    public bool  hasStartDeltaSeconds()
      {
        return flagHasStartDeltaSeconds;
      }

    public double  getStartDeltaSeconds()
      {
        Debug.Assert(flagHasStartDeltaSeconds);
        if (textStoreStartDeltaSeconds != "")
          {
            return Double.Parse(textStoreStartDeltaSeconds);
          }
        return storeStartDeltaSeconds;
      }

    public string  getStartDeltaSecondsAsText()
      {
        Debug.Assert(flagHasStartDeltaSeconds);
        if (textStoreStartDeltaSeconds == "")
          {
            return Convert.ToString(storeStartDeltaSeconds);
          }
        else
          {
            return (textStoreStartDeltaSeconds);
          }
      }

    public bool  hasStartDeltaDays()
      {
        return flagHasStartDeltaDays;
      }

    public BigInteger  getStartDeltaDays()
      {
        Debug.Assert(flagHasStartDeltaDays);
        return storeStartDeltaDays;
      }

    public bool  hasStartDeltaMonths()
      {
        return flagHasStartDeltaMonths;
      }

    public BigInteger  getStartDeltaMonths()
      {
        Debug.Assert(flagHasStartDeltaMonths);
        return storeStartDeltaMonths;
      }

    public bool  hasNewEnd()
      {
        return flagHasNewEnd;
      }

    public DateAndOrTimeJSON   getNewEnd()
      {
        Debug.Assert(flagHasNewEnd);
        return storeNewEnd;
      }

    public bool  hasEndDeltaSeconds()
      {
        return flagHasEndDeltaSeconds;
      }

    public double  getEndDeltaSeconds()
      {
        Debug.Assert(flagHasEndDeltaSeconds);
        if (textStoreEndDeltaSeconds != "")
          {
            return Double.Parse(textStoreEndDeltaSeconds);
          }
        return storeEndDeltaSeconds;
      }

    public string  getEndDeltaSecondsAsText()
      {
        Debug.Assert(flagHasEndDeltaSeconds);
        if (textStoreEndDeltaSeconds == "")
          {
            return Convert.ToString(storeEndDeltaSeconds);
          }
        else
          {
            return (textStoreEndDeltaSeconds);
          }
      }

    public bool  hasEndDeltaDays()
      {
        return flagHasEndDeltaDays;
      }

    public BigInteger  getEndDeltaDays()
      {
        Debug.Assert(flagHasEndDeltaDays);
        return storeEndDeltaDays;
      }

    public bool  hasEndDeltaMonths()
      {
        return flagHasEndDeltaMonths;
      }

    public BigInteger  getEndDeltaMonths()
      {
        Debug.Assert(flagHasEndDeltaMonths);
        return storeEndDeltaMonths;
      }

    public bool  hasNewFrequencyType()
      {
        return flagHasNewFrequencyType;
      }

    public TypeNewFrequencyType  getNewFrequencyType()
      {
        Debug.Assert(flagHasNewFrequencyType);
        return storeNewFrequencyType;
      }

    public string  getNewFrequencyTypeAsString()
      {
        return stringFromNewFrequencyType(getNewFrequencyType());
      }

    public bool  hasNewFrequencyMultiplier()
      {
        return flagHasNewFrequencyMultiplier;
      }

    public BigInteger  getNewFrequencyMultiplier()
      {
        Debug.Assert(flagHasNewFrequencyMultiplier);
        return storeNewFrequencyMultiplier;
      }

    public bool  hasAddEventAttendees()
      {
        return flagHasAddEventAttendees;
      }

    public int  countOfAddEventAttendees()
      {
        Debug.Assert(flagHasAddEventAttendees);
        return storeAddEventAttendees.Count;
      }

    public string  elementOfAddEventAttendees(int element_num)
      {
        Debug.Assert(flagHasAddEventAttendees);
        return storeAddEventAttendees[element_num];
      }

    public List< string >  getAddEventAttendees()
      {
        Debug.Assert(flagHasAddEventAttendees);
        return storeAddEventAttendees;
      }

    public bool  hasRemoveEventAttendees()
      {
        return flagHasRemoveEventAttendees;
      }

    public int  countOfRemoveEventAttendees()
      {
        Debug.Assert(flagHasRemoveEventAttendees);
        return storeRemoveEventAttendees.Count;
      }

    public string  elementOfRemoveEventAttendees(int element_num)
      {
        Debug.Assert(flagHasRemoveEventAttendees);
        return storeRemoveEventAttendees[element_num];
      }

    public List< string >  getRemoveEventAttendees()
      {
        Debug.Assert(flagHasRemoveEventAttendees);
        return storeRemoveEventAttendees;
      }

    public bool  hasNewSelfAttendeeStatus()
      {
        return flagHasNewSelfAttendeeStatus;
      }

    public TypeNewSelfAttendeeStatus  getNewSelfAttendeeStatus()
      {
        Debug.Assert(flagHasNewSelfAttendeeStatus);
        return storeNewSelfAttendeeStatus;
      }

    public string  getNewSelfAttendeeStatusAsString()
      {
        return stringFromNewSelfAttendeeStatus(getNewSelfAttendeeStatus());
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


    public virtual int extraModifyCalendarItemsCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraModifyCalendarItemsCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraModifyCalendarItemsCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraModifyCalendarItemsCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCalendarCommandComponentCount()
      {
        int result = 0;
        if (flagHasItemType)
            ++result;
        if (flagHasExactTitle)
            ++result;
        if (flagHasPartialTitle)
            ++result;
        if (flagHasExactLocation)
            ++result;
        if (flagHasPartialLocation)
            ++result;
        if (flagHasLocationSpecifier)
            ++result;
        if (flagHasStartStart)
            ++result;
        if (flagHasEndStart)
            ++result;
        if (flagHasStartEnd)
            ++result;
        if (flagHasEndEnd)
            ++result;
        if (flagHasNewItemType)
            ++result;
        if (flagHasNewTitle)
            ++result;
        if (flagHasNewLocation)
            ++result;
        if (flagHasNewLocationSpecifier)
            ++result;
        if (flagHasNewStart)
            ++result;
        if (flagHasStartDeltaSeconds)
            ++result;
        if (flagHasStartDeltaDays)
            ++result;
        if (flagHasStartDeltaMonths)
            ++result;
        if (flagHasNewEnd)
            ++result;
        if (flagHasEndDeltaSeconds)
            ++result;
        if (flagHasEndDeltaDays)
            ++result;
        if (flagHasEndDeltaMonths)
            ++result;
        if (flagHasNewFrequencyType)
            ++result;
        if (flagHasNewFrequencyMultiplier)
            ++result;
        if (flagHasAddEventAttendees)
            ++result;
        if (flagHasRemoveEventAttendees)
            ++result;
        if (flagHasNewSelfAttendeeStatus)
            ++result;
        if (flagHasNativeData)
            ++result;
        result += extraModifyCalendarItemsCommandComponentCount();
        return result;
      }
    public override string extraCalendarCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasItemType)
          {
            if (remainder == 0)
                return "ItemType";
            --remainder;
          }
        if (flagHasExactTitle)
          {
            if (remainder == 0)
                return "ExactTitle";
            --remainder;
          }
        if (flagHasPartialTitle)
          {
            if (remainder == 0)
                return "PartialTitle";
            --remainder;
          }
        if (flagHasExactLocation)
          {
            if (remainder == 0)
                return "ExactLocation";
            --remainder;
          }
        if (flagHasPartialLocation)
          {
            if (remainder == 0)
                return "PartialLocation";
            --remainder;
          }
        if (flagHasLocationSpecifier)
          {
            if (remainder == 0)
                return "LocationSpecifier";
            --remainder;
          }
        if (flagHasStartStart)
          {
            if (remainder == 0)
                return "StartStart";
            --remainder;
          }
        if (flagHasEndStart)
          {
            if (remainder == 0)
                return "EndStart";
            --remainder;
          }
        if (flagHasStartEnd)
          {
            if (remainder == 0)
                return "StartEnd";
            --remainder;
          }
        if (flagHasEndEnd)
          {
            if (remainder == 0)
                return "EndEnd";
            --remainder;
          }
        if (flagHasNewItemType)
          {
            if (remainder == 0)
                return "NewItemType";
            --remainder;
          }
        if (flagHasNewTitle)
          {
            if (remainder == 0)
                return "NewTitle";
            --remainder;
          }
        if (flagHasNewLocation)
          {
            if (remainder == 0)
                return "NewLocation";
            --remainder;
          }
        if (flagHasNewLocationSpecifier)
          {
            if (remainder == 0)
                return "NewLocationSpecifier";
            --remainder;
          }
        if (flagHasNewStart)
          {
            if (remainder == 0)
                return "NewStart";
            --remainder;
          }
        if (flagHasStartDeltaSeconds)
          {
            if (remainder == 0)
                return "StartDeltaSeconds";
            --remainder;
          }
        if (flagHasStartDeltaDays)
          {
            if (remainder == 0)
                return "StartDeltaDays";
            --remainder;
          }
        if (flagHasStartDeltaMonths)
          {
            if (remainder == 0)
                return "StartDeltaMonths";
            --remainder;
          }
        if (flagHasNewEnd)
          {
            if (remainder == 0)
                return "NewEnd";
            --remainder;
          }
        if (flagHasEndDeltaSeconds)
          {
            if (remainder == 0)
                return "EndDeltaSeconds";
            --remainder;
          }
        if (flagHasEndDeltaDays)
          {
            if (remainder == 0)
                return "EndDeltaDays";
            --remainder;
          }
        if (flagHasEndDeltaMonths)
          {
            if (remainder == 0)
                return "EndDeltaMonths";
            --remainder;
          }
        if (flagHasNewFrequencyType)
          {
            if (remainder == 0)
                return "NewFrequencyType";
            --remainder;
          }
        if (flagHasNewFrequencyMultiplier)
          {
            if (remainder == 0)
                return "NewFrequencyMultiplier";
            --remainder;
          }
        if (flagHasAddEventAttendees)
          {
            if (remainder == 0)
                return "AddEventAttendees";
            --remainder;
          }
        if (flagHasRemoveEventAttendees)
          {
            if (remainder == 0)
                return "RemoveEventAttendees";
            --remainder;
          }
        if (flagHasNewSelfAttendeeStatus)
          {
            if (remainder == 0)
                return "NewSelfAttendeeStatus";
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraModifyCalendarItemsCommandComponentKey(remainder);
      }
    public override JSONValue extraCalendarCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasItemType)
          {
            if (remainder == 0)
                return extraItemTypeToJSON();
            --remainder;
          }
        if (flagHasExactTitle)
          {
            if (remainder == 0)
                return extraExactTitleToJSON();
            --remainder;
          }
        if (flagHasPartialTitle)
          {
            if (remainder == 0)
                return extraPartialTitleToJSON();
            --remainder;
          }
        if (flagHasExactLocation)
          {
            if (remainder == 0)
                return extraExactLocationToJSON();
            --remainder;
          }
        if (flagHasPartialLocation)
          {
            if (remainder == 0)
                return extraPartialLocationToJSON();
            --remainder;
          }
        if (flagHasLocationSpecifier)
          {
            if (remainder == 0)
                return extraLocationSpecifierToJSON();
            --remainder;
          }
        if (flagHasStartStart)
          {
            if (remainder == 0)
                return extraStartStartToJSON();
            --remainder;
          }
        if (flagHasEndStart)
          {
            if (remainder == 0)
                return extraEndStartToJSON();
            --remainder;
          }
        if (flagHasStartEnd)
          {
            if (remainder == 0)
                return extraStartEndToJSON();
            --remainder;
          }
        if (flagHasEndEnd)
          {
            if (remainder == 0)
                return extraEndEndToJSON();
            --remainder;
          }
        if (flagHasNewItemType)
          {
            if (remainder == 0)
                return extraNewItemTypeToJSON();
            --remainder;
          }
        if (flagHasNewTitle)
          {
            if (remainder == 0)
                return extraNewTitleToJSON();
            --remainder;
          }
        if (flagHasNewLocation)
          {
            if (remainder == 0)
                return extraNewLocationToJSON();
            --remainder;
          }
        if (flagHasNewLocationSpecifier)
          {
            if (remainder == 0)
                return extraNewLocationSpecifierToJSON();
            --remainder;
          }
        if (flagHasNewStart)
          {
            if (remainder == 0)
                return extraNewStartToJSON();
            --remainder;
          }
        if (flagHasStartDeltaSeconds)
          {
            if (remainder == 0)
                return extraStartDeltaSecondsToJSON();
            --remainder;
          }
        if (flagHasStartDeltaDays)
          {
            if (remainder == 0)
                return extraStartDeltaDaysToJSON();
            --remainder;
          }
        if (flagHasStartDeltaMonths)
          {
            if (remainder == 0)
                return extraStartDeltaMonthsToJSON();
            --remainder;
          }
        if (flagHasNewEnd)
          {
            if (remainder == 0)
                return extraNewEndToJSON();
            --remainder;
          }
        if (flagHasEndDeltaSeconds)
          {
            if (remainder == 0)
                return extraEndDeltaSecondsToJSON();
            --remainder;
          }
        if (flagHasEndDeltaDays)
          {
            if (remainder == 0)
                return extraEndDeltaDaysToJSON();
            --remainder;
          }
        if (flagHasEndDeltaMonths)
          {
            if (remainder == 0)
                return extraEndDeltaMonthsToJSON();
            --remainder;
          }
        if (flagHasNewFrequencyType)
          {
            if (remainder == 0)
                return extraNewFrequencyTypeToJSON();
            --remainder;
          }
        if (flagHasNewFrequencyMultiplier)
          {
            if (remainder == 0)
                return extraNewFrequencyMultiplierToJSON();
            --remainder;
          }
        if (flagHasAddEventAttendees)
          {
            if (remainder == 0)
                return extraAddEventAttendeesToJSON();
            --remainder;
          }
        if (flagHasRemoveEventAttendees)
          {
            if (remainder == 0)
                return extraRemoveEventAttendeesToJSON();
            --remainder;
          }
        if (flagHasNewSelfAttendeeStatus)
          {
            if (remainder == 0)
                return extraNewSelfAttendeeStatusToJSON();
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraModifyCalendarItemsCommandComponentValue(remainder);
      }
    public override JSONValue extraCalendarCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "ddEventAttendees", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasAddEventAttendees ? extraAddEventAttendeesToJSON() : null);
                break;
            case 'E':
                switch (field_name[1])
                  {
                    case 'n':
                        if (String.Compare(field_name, 2, "d", 0, 1, false) == 0)
                          {
                            switch (field_name[3])
                              {
                                case 'D':
                                    if (String.Compare(field_name, 4, "elta", 0, 4, false) == 0)
                                      {
                                        switch (field_name[8])
                                          {
                                            case 'D':
                                                if ((String.Compare(field_name, 9, "ays", 0, 3, false) == 0) && (field_name.Length == 12))
                                                    return (flagHasEndDeltaDays ? extraEndDeltaDaysToJSON() : null);
                                                break;
                                            case 'M':
                                                if ((String.Compare(field_name, 9, "onths", 0, 5, false) == 0) && (field_name.Length == 14))
                                                    return (flagHasEndDeltaMonths ? extraEndDeltaMonthsToJSON() : null);
                                                break;
                                            case 'S':
                                                if ((String.Compare(field_name, 9, "econds", 0, 6, false) == 0) && (field_name.Length == 15))
                                                    return (flagHasEndDeltaSeconds ? extraEndDeltaSecondsToJSON() : null);
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'E':
                                    if ((String.Compare(field_name, 4, "nd", 0, 2, false) == 0) && (field_name.Length == 6))
                                        return (flagHasEndEnd ? extraEndEndToJSON() : null);
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 4, "tart", 0, 4, false) == 0) && (field_name.Length == 8))
                                        return (flagHasEndStart ? extraEndStartToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'x':
                        if (String.Compare(field_name, 2, "act", 0, 3, false) == 0)
                          {
                            switch (field_name[5])
                              {
                                case 'L':
                                    if ((String.Compare(field_name, 6, "ocation", 0, 7, false) == 0) && (field_name.Length == 13))
                                        return (flagHasExactLocation ? extraExactLocationToJSON() : null);
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 6, "itle", 0, 4, false) == 0) && (field_name.Length == 10))
                                        return (flagHasExactTitle ? extraExactTitleToJSON() : null);
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
            case 'I':
                if ((String.Compare(field_name, 1, "temType", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasItemType ? extraItemTypeToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "ocationSpecifier", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasLocationSpecifier ? extraLocationSpecifierToJSON() : null);
                break;
            case 'N':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "tiveData", 0, 8, false) == 0) && (field_name.Length == 10))
                            return (flagHasNativeData ? extraNativeDataToJSON() : null);
                        break;
                    case 'e':
                        if (String.Compare(field_name, 2, "w", 0, 1, false) == 0)
                          {
                            switch (field_name[3])
                              {
                                case 'E':
                                    if ((String.Compare(field_name, 4, "nd", 0, 2, false) == 0) && (field_name.Length == 6))
                                        return (flagHasNewEnd ? extraNewEndToJSON() : null);
                                    break;
                                case 'F':
                                    if (String.Compare(field_name, 4, "requency", 0, 8, false) == 0)
                                      {
                                        switch (field_name[12])
                                          {
                                            case 'M':
                                                if ((String.Compare(field_name, 13, "ultiplier", 0, 9, false) == 0) && (field_name.Length == 22))
                                                    return (flagHasNewFrequencyMultiplier ? extraNewFrequencyMultiplierToJSON() : null);
                                                break;
                                            case 'T':
                                                if ((String.Compare(field_name, 13, "ype", 0, 3, false) == 0) && (field_name.Length == 16))
                                                    return (flagHasNewFrequencyType ? extraNewFrequencyTypeToJSON() : null);
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'I':
                                    if ((String.Compare(field_name, 4, "temType", 0, 7, false) == 0) && (field_name.Length == 11))
                                        return (flagHasNewItemType ? extraNewItemTypeToJSON() : null);
                                    break;
                                case 'L':
                                    if (String.Compare(field_name, 4, "ocation", 0, 7, false) == 0)
                                      {
                                        if (field_name.Length == 11)
                                          {
                                            return (flagHasNewLocation ? extraNewLocationToJSON() : null);
                                          }
                                        switch (field_name[11])
                                          {
                                            case 'S':
                                                if ((String.Compare(field_name, 12, "pecifier", 0, 8, false) == 0) && (field_name.Length == 20))
                                                    return (flagHasNewLocationSpecifier ? extraNewLocationSpecifierToJSON() : null);
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'S':
                                    switch (field_name[4])
                                      {
                                        case 'e':
                                            if ((String.Compare(field_name, 5, "lfAttendeeStatus", 0, 16, false) == 0) && (field_name.Length == 21))
                                                return (flagHasNewSelfAttendeeStatus ? extraNewSelfAttendeeStatusToJSON() : null);
                                            break;
                                        case 't':
                                            if ((String.Compare(field_name, 5, "art", 0, 3, false) == 0) && (field_name.Length == 8))
                                                return (flagHasNewStart ? extraNewStartToJSON() : null);
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 4, "itle", 0, 4, false) == 0) && (field_name.Length == 8))
                                        return (flagHasNewTitle ? extraNewTitleToJSON() : null);
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
            case 'P':
                if (String.Compare(field_name, 1, "artial", 0, 6, false) == 0)
                  {
                    switch (field_name[7])
                      {
                        case 'L':
                            if ((String.Compare(field_name, 8, "ocation", 0, 7, false) == 0) && (field_name.Length == 15))
                                return (flagHasPartialLocation ? extraPartialLocationToJSON() : null);
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 8, "itle", 0, 4, false) == 0) && (field_name.Length == 12))
                                return (flagHasPartialTitle ? extraPartialTitleToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "emoveEventAttendees", 0, 19, false) == 0) && (field_name.Length == 20))
                    return (flagHasRemoveEventAttendees ? extraRemoveEventAttendeesToJSON() : null);
                break;
            case 'S':
                if (String.Compare(field_name, 1, "tart", 0, 4, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'D':
                            if (String.Compare(field_name, 6, "elta", 0, 4, false) == 0)
                              {
                                switch (field_name[10])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 11, "ays", 0, 3, false) == 0) && (field_name.Length == 14))
                                            return (flagHasStartDeltaDays ? extraStartDeltaDaysToJSON() : null);
                                        break;
                                    case 'M':
                                        if ((String.Compare(field_name, 11, "onths", 0, 5, false) == 0) && (field_name.Length == 16))
                                            return (flagHasStartDeltaMonths ? extraStartDeltaMonthsToJSON() : null);
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 11, "econds", 0, 6, false) == 0) && (field_name.Length == 17))
                                            return (flagHasStartDeltaSeconds ? extraStartDeltaSecondsToJSON() : null);
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'E':
                            if ((String.Compare(field_name, 6, "nd", 0, 2, false) == 0) && (field_name.Length == 8))
                                return (flagHasStartEnd ? extraStartEndToJSON() : null);
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 6, "tart", 0, 4, false) == 0) && (field_name.Length == 10))
                                return (flagHasStartStart ? extraStartStartToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraModifyCalendarItemsCommandLookup(field_name);
      }

    public void setItemType(string new_value)
      {
        flagHasItemType = true;
        storeItemType = new_value;
      }
    public void unsetItemType()
      {
        flagHasItemType = false;
      }
    public void setExactTitle(string new_value)
      {
        flagHasExactTitle = true;
        storeExactTitle = new_value;
      }
    public void unsetExactTitle()
      {
        flagHasExactTitle = false;
      }
    public void setPartialTitle(string new_value)
      {
        flagHasPartialTitle = true;
        storePartialTitle = new_value;
      }
    public void unsetPartialTitle()
      {
        flagHasPartialTitle = false;
      }
    public void setExactLocation(string new_value)
      {
        flagHasExactLocation = true;
        storeExactLocation = new_value;
      }
    public void unsetExactLocation()
      {
        flagHasExactLocation = false;
      }
    public void setPartialLocation(string new_value)
      {
        flagHasPartialLocation = true;
        storePartialLocation = new_value;
      }
    public void unsetPartialLocation()
      {
        flagHasPartialLocation = false;
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
    public void setStartStart(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStartStart)
          {
          }
        flagHasStartStart = true;
        storeStartStart = new_value;
      }
    public void unsetStartStart()
      {
        if (flagHasStartStart)
          {
          }
        flagHasStartStart = false;
      }
    public void setEndStart(DateAndOrTimeJSON  new_value)
      {
        if (flagHasEndStart)
          {
          }
        flagHasEndStart = true;
        storeEndStart = new_value;
      }
    public void unsetEndStart()
      {
        if (flagHasEndStart)
          {
          }
        flagHasEndStart = false;
      }
    public void setStartEnd(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStartEnd)
          {
          }
        flagHasStartEnd = true;
        storeStartEnd = new_value;
      }
    public void unsetStartEnd()
      {
        if (flagHasStartEnd)
          {
          }
        flagHasStartEnd = false;
      }
    public void setEndEnd(DateAndOrTimeJSON  new_value)
      {
        if (flagHasEndEnd)
          {
          }
        flagHasEndEnd = true;
        storeEndEnd = new_value;
      }
    public void unsetEndEnd()
      {
        if (flagHasEndEnd)
          {
          }
        flagHasEndEnd = false;
      }
    public void setNewItemType(string new_value)
      {
        flagHasNewItemType = true;
        storeNewItemType = new_value;
      }
    public void unsetNewItemType()
      {
        flagHasNewItemType = false;
      }
    public void setNewTitle(string new_value)
      {
        flagHasNewTitle = true;
        storeNewTitle = new_value;
      }
    public void unsetNewTitle()
      {
        flagHasNewTitle = false;
      }
    public void setNewLocation(string new_value)
      {
        flagHasNewLocation = true;
        storeNewLocation = new_value;
      }
    public void unsetNewLocation()
      {
        flagHasNewLocation = false;
      }
    public void setNewLocationSpecifier(CalendarLocationJSON  new_value)
      {
        if (flagHasNewLocationSpecifier)
          {
          }
        flagHasNewLocationSpecifier = true;
        storeNewLocationSpecifier = new_value;
      }
    public void unsetNewLocationSpecifier()
      {
        if (flagHasNewLocationSpecifier)
          {
          }
        flagHasNewLocationSpecifier = false;
      }
    public void setNewStart(DateAndOrTimeJSON  new_value)
      {
        if (flagHasNewStart)
          {
          }
        flagHasNewStart = true;
        storeNewStart = new_value;
      }
    public void unsetNewStart()
      {
        if (flagHasNewStart)
          {
          }
        flagHasNewStart = false;
      }
    public void setStartDeltaSeconds(double new_value)
      {
        flagHasStartDeltaSeconds = true;
        storeStartDeltaSeconds = new_value;
        textStoreStartDeltaSeconds = "";
      }
    public void setStartDeltaSecondsText(string new_value)
      {
        flagHasStartDeltaSeconds = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field StartDeltaSeconds of ModifyCalendarItemsCommandJSON is not a valid number.");
        textStoreStartDeltaSeconds = new_value;
      }
    public void unsetStartDeltaSeconds()
      {
        flagHasStartDeltaSeconds = false;
      }
    public void setStartDeltaDays(BigInteger new_value)
      {
        flagHasStartDeltaDays = true;
        if (new_value < 0)
            throw new Exception("The value for field StartDeltaDays of ModifyCalendarItemsCommandJSON is less than the lower bound (0) for that field.");
        storeStartDeltaDays = new_value;
      }
    public void unsetStartDeltaDays()
      {
        flagHasStartDeltaDays = false;
      }
    public void setStartDeltaMonths(BigInteger new_value)
      {
        flagHasStartDeltaMonths = true;
        if (new_value < 0)
            throw new Exception("The value for field StartDeltaMonths of ModifyCalendarItemsCommandJSON is less than the lower bound (0) for that field.");
        storeStartDeltaMonths = new_value;
      }
    public void unsetStartDeltaMonths()
      {
        flagHasStartDeltaMonths = false;
      }
    public void setNewEnd(DateAndOrTimeJSON  new_value)
      {
        if (flagHasNewEnd)
          {
          }
        flagHasNewEnd = true;
        storeNewEnd = new_value;
      }
    public void unsetNewEnd()
      {
        if (flagHasNewEnd)
          {
          }
        flagHasNewEnd = false;
      }
    public void setEndDeltaSeconds(double new_value)
      {
        flagHasEndDeltaSeconds = true;
        storeEndDeltaSeconds = new_value;
        textStoreEndDeltaSeconds = "";
      }
    public void setEndDeltaSecondsText(string new_value)
      {
        flagHasEndDeltaSeconds = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field EndDeltaSeconds of ModifyCalendarItemsCommandJSON is not a valid number.");
        textStoreEndDeltaSeconds = new_value;
      }
    public void unsetEndDeltaSeconds()
      {
        flagHasEndDeltaSeconds = false;
      }
    public void setEndDeltaDays(BigInteger new_value)
      {
        flagHasEndDeltaDays = true;
        if (new_value < 0)
            throw new Exception("The value for field EndDeltaDays of ModifyCalendarItemsCommandJSON is less than the lower bound (0) for that field.");
        storeEndDeltaDays = new_value;
      }
    public void unsetEndDeltaDays()
      {
        flagHasEndDeltaDays = false;
      }
    public void setEndDeltaMonths(BigInteger new_value)
      {
        flagHasEndDeltaMonths = true;
        if (new_value < 0)
            throw new Exception("The value for field EndDeltaMonths of ModifyCalendarItemsCommandJSON is less than the lower bound (0) for that field.");
        storeEndDeltaMonths = new_value;
      }
    public void unsetEndDeltaMonths()
      {
        flagHasEndDeltaMonths = false;
      }
    public void setNewFrequencyType(TypeNewFrequencyType new_value)
      {
        flagHasNewFrequencyType = true;
        storeNewFrequencyType = new_value;
      }
    public void setNewFrequencyType(string chars)
      {
        setNewFrequencyType(stringToNewFrequencyType(chars));
      }
    public void unsetNewFrequencyType()
      {
        flagHasNewFrequencyType = false;
      }
    public void setNewFrequencyMultiplier(BigInteger new_value)
      {
        flagHasNewFrequencyMultiplier = true;
        if (new_value < 0)
            throw new Exception("The value for field NewFrequencyMultiplier of ModifyCalendarItemsCommandJSON is less than the lower bound (0) for that field.");
        storeNewFrequencyMultiplier = new_value;
      }
    public void unsetNewFrequencyMultiplier()
      {
        flagHasNewFrequencyMultiplier = false;
      }
    public void initAddEventAttendees()
      {
        flagHasAddEventAttendees = true;
        storeAddEventAttendees.Clear();
      }
    public void appendAddEventAttendees(string to_append)
      {
        if (!flagHasAddEventAttendees)
          {
            flagHasAddEventAttendees = true;
            storeAddEventAttendees.Clear();
          }
        Debug.Assert(flagHasAddEventAttendees);
        storeAddEventAttendees.Add(to_append);
      }
    public void unsetAddEventAttendees()
      {
        flagHasAddEventAttendees = false;
        storeAddEventAttendees.Clear();
      }
    public void initRemoveEventAttendees()
      {
        flagHasRemoveEventAttendees = true;
        storeRemoveEventAttendees.Clear();
      }
    public void appendRemoveEventAttendees(string to_append)
      {
        if (!flagHasRemoveEventAttendees)
          {
            flagHasRemoveEventAttendees = true;
            storeRemoveEventAttendees.Clear();
          }
        Debug.Assert(flagHasRemoveEventAttendees);
        storeRemoveEventAttendees.Add(to_append);
      }
    public void unsetRemoveEventAttendees()
      {
        flagHasRemoveEventAttendees = false;
        storeRemoveEventAttendees.Clear();
      }
    public void setNewSelfAttendeeStatus(TypeNewSelfAttendeeStatus new_value)
      {
        flagHasNewSelfAttendeeStatus = true;
        storeNewSelfAttendeeStatus = new_value;
      }
    public void setNewSelfAttendeeStatus(string chars)
      {
        setNewSelfAttendeeStatus(stringToNewSelfAttendeeStatus(chars));
      }
    public void unsetNewSelfAttendeeStatus()
      {
        flagHasNewSelfAttendeeStatus = false;
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

    public virtual void extraModifyCalendarItemsCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraModifyCalendarItemsCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraModifyCalendarItemsCommandLookup(key);
        if (old_field == null)
          {
            extraModifyCalendarItemsCommandAppendPair(key, new_component);
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
                if ((String.Compare(key, 1, "ddEventAttendees", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONAddEventAttendees(new_component, false);
                    return;
                    }
                break;
            case 'E':
                switch (key[1])
                  {
                    case 'n':
                        if (String.Compare(key, 2, "d", 0, 1, false) == 0)
                          {
                            switch (key[3])
                              {
                                case 'D':
                                    if (String.Compare(key, 4, "elta", 0, 4, false) == 0)
                                      {
                                        switch (key[8])
                                          {
                                            case 'D':
                                                if ((String.Compare(key, 9, "ays", 0, 3, false) == 0) && (key.Length == 12))
                                                    {
                                                    fromJSONEndDeltaDays(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            case 'M':
                                                if ((String.Compare(key, 9, "onths", 0, 5, false) == 0) && (key.Length == 14))
                                                    {
                                                    fromJSONEndDeltaMonths(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            case 'S':
                                                if ((String.Compare(key, 9, "econds", 0, 6, false) == 0) && (key.Length == 15))
                                                    {
                                                    fromJSONEndDeltaSeconds(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'E':
                                    if ((String.Compare(key, 4, "nd", 0, 2, false) == 0) && (key.Length == 6))
                                        {
                                        fromJSONEndEnd(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 4, "tart", 0, 4, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONEndStart(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'x':
                        if (String.Compare(key, 2, "act", 0, 3, false) == 0)
                          {
                            switch (key[5])
                              {
                                case 'L':
                                    if ((String.Compare(key, 6, "ocation", 0, 7, false) == 0) && (key.Length == 13))
                                        {
                                        fromJSONExactLocation(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 6, "itle", 0, 4, false) == 0) && (key.Length == 10))
                                        {
                                        fromJSONExactTitle(new_component, false);
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
            case 'I':
                if ((String.Compare(key, 1, "temType", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONItemType(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocationSpecifier", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONLocationSpecifier(new_component, false);
                    return;
                    }
                break;
            case 'N':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "tiveData", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONNativeData(new_component, false);
                            return;
                            }
                        break;
                    case 'e':
                        if (String.Compare(key, 2, "w", 0, 1, false) == 0)
                          {
                            switch (key[3])
                              {
                                case 'E':
                                    if ((String.Compare(key, 4, "nd", 0, 2, false) == 0) && (key.Length == 6))
                                        {
                                        fromJSONNewEnd(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'F':
                                    if (String.Compare(key, 4, "requency", 0, 8, false) == 0)
                                      {
                                        switch (key[12])
                                          {
                                            case 'M':
                                                if ((String.Compare(key, 13, "ultiplier", 0, 9, false) == 0) && (key.Length == 22))
                                                    {
                                                    fromJSONNewFrequencyMultiplier(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            case 'T':
                                                if ((String.Compare(key, 13, "ype", 0, 3, false) == 0) && (key.Length == 16))
                                                    {
                                                    fromJSONNewFrequencyType(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'I':
                                    if ((String.Compare(key, 4, "temType", 0, 7, false) == 0) && (key.Length == 11))
                                        {
                                        fromJSONNewItemType(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'L':
                                    if (String.Compare(key, 4, "ocation", 0, 7, false) == 0)
                                      {
                                        if (key.Length == 11)
                                          {
                                            {
                                            fromJSONNewLocation(new_component, false);
                                            return;
                                            }
                                          }
                                        switch (key[11])
                                          {
                                            case 'S':
                                                if ((String.Compare(key, 12, "pecifier", 0, 8, false) == 0) && (key.Length == 20))
                                                    {
                                                    fromJSONNewLocationSpecifier(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'S':
                                    switch (key[4])
                                      {
                                        case 'e':
                                            if ((String.Compare(key, 5, "lfAttendeeStatus", 0, 16, false) == 0) && (key.Length == 21))
                                                {
                                                fromJSONNewSelfAttendeeStatus(new_component, false);
                                                return;
                                                }
                                            break;
                                        case 't':
                                            if ((String.Compare(key, 5, "art", 0, 3, false) == 0) && (key.Length == 8))
                                                {
                                                fromJSONNewStart(new_component, false);
                                                return;
                                                }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 4, "itle", 0, 4, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONNewTitle(new_component, false);
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
            case 'P':
                if (String.Compare(key, 1, "artial", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'L':
                            if ((String.Compare(key, 8, "ocation", 0, 7, false) == 0) && (key.Length == 15))
                                {
                                fromJSONPartialLocation(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 8, "itle", 0, 4, false) == 0) && (key.Length == 12))
                                {
                                fromJSONPartialTitle(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(key, 1, "emoveEventAttendees", 0, 19, false) == 0) && (key.Length == 20))
                    {
                    fromJSONRemoveEventAttendees(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if (String.Compare(key, 1, "tart", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'D':
                            if (String.Compare(key, 6, "elta", 0, 4, false) == 0)
                              {
                                switch (key[10])
                                  {
                                    case 'D':
                                        if ((String.Compare(key, 11, "ays", 0, 3, false) == 0) && (key.Length == 14))
                                            {
                                            fromJSONStartDeltaDays(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'M':
                                        if ((String.Compare(key, 11, "onths", 0, 5, false) == 0) && (key.Length == 16))
                                            {
                                            fromJSONStartDeltaMonths(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'S':
                                        if ((String.Compare(key, 11, "econds", 0, 6, false) == 0) && (key.Length == 17))
                                            {
                                            fromJSONStartDeltaSeconds(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'E':
                            if ((String.Compare(key, 6, "nd", 0, 2, false) == 0) && (key.Length == 8))
                                {
                                fromJSONStartEnd(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 6, "tart", 0, 4, false) == 0) && (key.Length == 10))
                                {
                                fromJSONStartStart(new_component, false);
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
        extraModifyCalendarItemsCommandAppendPair(key, new_component);
      }
    public override void extraCalendarCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ddEventAttendees", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONAddEventAttendees(new_component, false);
                    return;
                    }
                break;
            case 'E':
                switch (key[1])
                  {
                    case 'n':
                        if (String.Compare(key, 2, "d", 0, 1, false) == 0)
                          {
                            switch (key[3])
                              {
                                case 'D':
                                    if (String.Compare(key, 4, "elta", 0, 4, false) == 0)
                                      {
                                        switch (key[8])
                                          {
                                            case 'D':
                                                if ((String.Compare(key, 9, "ays", 0, 3, false) == 0) && (key.Length == 12))
                                                    {
                                                    fromJSONEndDeltaDays(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            case 'M':
                                                if ((String.Compare(key, 9, "onths", 0, 5, false) == 0) && (key.Length == 14))
                                                    {
                                                    fromJSONEndDeltaMonths(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            case 'S':
                                                if ((String.Compare(key, 9, "econds", 0, 6, false) == 0) && (key.Length == 15))
                                                    {
                                                    fromJSONEndDeltaSeconds(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'E':
                                    if ((String.Compare(key, 4, "nd", 0, 2, false) == 0) && (key.Length == 6))
                                        {
                                        fromJSONEndEnd(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 4, "tart", 0, 4, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONEndStart(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'x':
                        if (String.Compare(key, 2, "act", 0, 3, false) == 0)
                          {
                            switch (key[5])
                              {
                                case 'L':
                                    if ((String.Compare(key, 6, "ocation", 0, 7, false) == 0) && (key.Length == 13))
                                        {
                                        fromJSONExactLocation(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 6, "itle", 0, 4, false) == 0) && (key.Length == 10))
                                        {
                                        fromJSONExactTitle(new_component, false);
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
            case 'I':
                if ((String.Compare(key, 1, "temType", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONItemType(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocationSpecifier", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONLocationSpecifier(new_component, false);
                    return;
                    }
                break;
            case 'N':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "tiveData", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONNativeData(new_component, false);
                            return;
                            }
                        break;
                    case 'e':
                        if (String.Compare(key, 2, "w", 0, 1, false) == 0)
                          {
                            switch (key[3])
                              {
                                case 'E':
                                    if ((String.Compare(key, 4, "nd", 0, 2, false) == 0) && (key.Length == 6))
                                        {
                                        fromJSONNewEnd(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'F':
                                    if (String.Compare(key, 4, "requency", 0, 8, false) == 0)
                                      {
                                        switch (key[12])
                                          {
                                            case 'M':
                                                if ((String.Compare(key, 13, "ultiplier", 0, 9, false) == 0) && (key.Length == 22))
                                                    {
                                                    fromJSONNewFrequencyMultiplier(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            case 'T':
                                                if ((String.Compare(key, 13, "ype", 0, 3, false) == 0) && (key.Length == 16))
                                                    {
                                                    fromJSONNewFrequencyType(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'I':
                                    if ((String.Compare(key, 4, "temType", 0, 7, false) == 0) && (key.Length == 11))
                                        {
                                        fromJSONNewItemType(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'L':
                                    if (String.Compare(key, 4, "ocation", 0, 7, false) == 0)
                                      {
                                        if (key.Length == 11)
                                          {
                                            {
                                            fromJSONNewLocation(new_component, false);
                                            return;
                                            }
                                          }
                                        switch (key[11])
                                          {
                                            case 'S':
                                                if ((String.Compare(key, 12, "pecifier", 0, 8, false) == 0) && (key.Length == 20))
                                                    {
                                                    fromJSONNewLocationSpecifier(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'S':
                                    switch (key[4])
                                      {
                                        case 'e':
                                            if ((String.Compare(key, 5, "lfAttendeeStatus", 0, 16, false) == 0) && (key.Length == 21))
                                                {
                                                fromJSONNewSelfAttendeeStatus(new_component, false);
                                                return;
                                                }
                                            break;
                                        case 't':
                                            if ((String.Compare(key, 5, "art", 0, 3, false) == 0) && (key.Length == 8))
                                                {
                                                fromJSONNewStart(new_component, false);
                                                return;
                                                }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 4, "itle", 0, 4, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONNewTitle(new_component, false);
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
            case 'P':
                if (String.Compare(key, 1, "artial", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'L':
                            if ((String.Compare(key, 8, "ocation", 0, 7, false) == 0) && (key.Length == 15))
                                {
                                fromJSONPartialLocation(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 8, "itle", 0, 4, false) == 0) && (key.Length == 12))
                                {
                                fromJSONPartialTitle(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(key, 1, "emoveEventAttendees", 0, 19, false) == 0) && (key.Length == 20))
                    {
                    fromJSONRemoveEventAttendees(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if (String.Compare(key, 1, "tart", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'D':
                            if (String.Compare(key, 6, "elta", 0, 4, false) == 0)
                              {
                                switch (key[10])
                                  {
                                    case 'D':
                                        if ((String.Compare(key, 11, "ays", 0, 3, false) == 0) && (key.Length == 14))
                                            {
                                            fromJSONStartDeltaDays(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'M':
                                        if ((String.Compare(key, 11, "onths", 0, 5, false) == 0) && (key.Length == 16))
                                            {
                                            fromJSONStartDeltaMonths(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'S':
                                        if ((String.Compare(key, 11, "econds", 0, 6, false) == 0) && (key.Length == 17))
                                            {
                                            fromJSONStartDeltaSeconds(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'E':
                            if ((String.Compare(key, 6, "nd", 0, 2, false) == 0) && (key.Length == 8))
                                {
                                fromJSONStartEnd(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 6, "tart", 0, 4, false) == 0) && (key.Length == 10))
                                {
                                fromJSONStartStart(new_component, false);
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
        extraModifyCalendarItemsCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasItemType);
        if (flagHasItemType)
          {
            handler.start_pair("ItemType");
            handler.string_value(storeItemType);
          }
        Debug.Assert(partial_allowed || flagHasExactTitle);
        if (flagHasExactTitle)
          {
            handler.start_pair("ExactTitle");
            handler.string_value(storeExactTitle);
          }
        Debug.Assert(partial_allowed || flagHasPartialTitle);
        if (flagHasPartialTitle)
          {
            handler.start_pair("PartialTitle");
            handler.string_value(storePartialTitle);
          }
        Debug.Assert(partial_allowed || flagHasExactLocation);
        if (flagHasExactLocation)
          {
            handler.start_pair("ExactLocation");
            handler.string_value(storeExactLocation);
          }
        Debug.Assert(partial_allowed || flagHasPartialLocation);
        if (flagHasPartialLocation)
          {
            handler.start_pair("PartialLocation");
            handler.string_value(storePartialLocation);
          }
        if (flagHasLocationSpecifier)
          {
            handler.start_pair("LocationSpecifier");
            if (partial_allowed)
                storeLocationSpecifier.write_partial_as_json(handler);
            else
                storeLocationSpecifier.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasStartStart);
        if (flagHasStartStart)
          {
            handler.start_pair("StartStart");
            if (partial_allowed)
                storeStartStart.write_partial_as_json(handler);
            else
                storeStartStart.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasEndStart);
        if (flagHasEndStart)
          {
            handler.start_pair("EndStart");
            if (partial_allowed)
                storeEndStart.write_partial_as_json(handler);
            else
                storeEndStart.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasStartEnd);
        if (flagHasStartEnd)
          {
            handler.start_pair("StartEnd");
            if (partial_allowed)
                storeStartEnd.write_partial_as_json(handler);
            else
                storeStartEnd.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasEndEnd);
        if (flagHasEndEnd)
          {
            handler.start_pair("EndEnd");
            if (partial_allowed)
                storeEndEnd.write_partial_as_json(handler);
            else
                storeEndEnd.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasNewItemType);
        if (flagHasNewItemType)
          {
            handler.start_pair("NewItemType");
            handler.string_value(storeNewItemType);
          }
        Debug.Assert(partial_allowed || flagHasNewTitle);
        if (flagHasNewTitle)
          {
            handler.start_pair("NewTitle");
            handler.string_value(storeNewTitle);
          }
        Debug.Assert(partial_allowed || flagHasNewLocation);
        if (flagHasNewLocation)
          {
            handler.start_pair("NewLocation");
            handler.string_value(storeNewLocation);
          }
        if (flagHasNewLocationSpecifier)
          {
            handler.start_pair("NewLocationSpecifier");
            if (partial_allowed)
                storeNewLocationSpecifier.write_partial_as_json(handler);
            else
                storeNewLocationSpecifier.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasNewStart);
        if (flagHasNewStart)
          {
            handler.start_pair("NewStart");
            if (partial_allowed)
                storeNewStart.write_partial_as_json(handler);
            else
                storeNewStart.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasStartDeltaSeconds);
        if (flagHasStartDeltaSeconds)
          {
            handler.start_pair("StartDeltaSeconds");
            if (textStoreStartDeltaSeconds != "")
                handler.number_value(textStoreStartDeltaSeconds);
            else if (((double)(long)storeStartDeltaSeconds) == storeStartDeltaSeconds)
                handler.number_value((long)storeStartDeltaSeconds);
            else
                handler.number_value(storeStartDeltaSeconds);
          }
        Debug.Assert(partial_allowed || flagHasStartDeltaDays);
        if (flagHasStartDeltaDays)
          {
            handler.start_pair("StartDeltaDays");
            handler.number_value(storeStartDeltaDays);
          }
        Debug.Assert(partial_allowed || flagHasStartDeltaMonths);
        if (flagHasStartDeltaMonths)
          {
            handler.start_pair("StartDeltaMonths");
            handler.number_value(storeStartDeltaMonths);
          }
        Debug.Assert(partial_allowed || flagHasNewEnd);
        if (flagHasNewEnd)
          {
            handler.start_pair("NewEnd");
            if (partial_allowed)
                storeNewEnd.write_partial_as_json(handler);
            else
                storeNewEnd.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasEndDeltaSeconds);
        if (flagHasEndDeltaSeconds)
          {
            handler.start_pair("EndDeltaSeconds");
            if (textStoreEndDeltaSeconds != "")
                handler.number_value(textStoreEndDeltaSeconds);
            else if (((double)(long)storeEndDeltaSeconds) == storeEndDeltaSeconds)
                handler.number_value((long)storeEndDeltaSeconds);
            else
                handler.number_value(storeEndDeltaSeconds);
          }
        Debug.Assert(partial_allowed || flagHasEndDeltaDays);
        if (flagHasEndDeltaDays)
          {
            handler.start_pair("EndDeltaDays");
            handler.number_value(storeEndDeltaDays);
          }
        Debug.Assert(partial_allowed || flagHasEndDeltaMonths);
        if (flagHasEndDeltaMonths)
          {
            handler.start_pair("EndDeltaMonths");
            handler.number_value(storeEndDeltaMonths);
          }
        Debug.Assert(partial_allowed || flagHasNewFrequencyType);
        if (flagHasNewFrequencyType)
          {
            handler.start_pair("NewFrequencyType");
            switch (storeNewFrequencyType)
              {
                case TypeNewFrequencyType.NewFrequencyType_unknown:
                    handler.string_value("unknown");
                    break;
                case TypeNewFrequencyType.NewFrequencyType_one_time:
                    handler.string_value("one-time");
                    break;
                case TypeNewFrequencyType.NewFrequencyType_daily:
                    handler.string_value("daily");
                    break;
                case TypeNewFrequencyType.NewFrequencyType_weekly:
                    handler.string_value("weekly");
                    break;
                case TypeNewFrequencyType.NewFrequencyType_monthly:
                    handler.string_value("monthly");
                    break;
                case TypeNewFrequencyType.NewFrequencyType_yearly:
                    handler.string_value("yearly");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasNewFrequencyMultiplier);
        if (flagHasNewFrequencyMultiplier)
          {
            handler.start_pair("NewFrequencyMultiplier");
            handler.number_value(storeNewFrequencyMultiplier);
          }
        if (flagHasAddEventAttendees)
          {
            handler.start_pair("AddEventAttendees");
            handler.start_array();
            for (int num1 = 0; num1 < storeAddEventAttendees.Count; ++num1)
              {
                handler.string_value(storeAddEventAttendees[num1]);
              }
            handler.finish_array();
          }
        if (flagHasRemoveEventAttendees)
          {
            handler.start_pair("RemoveEventAttendees");
            handler.start_array();
            for (int num2 = 0; num2 < storeRemoveEventAttendees.Count; ++num2)
              {
                handler.string_value(storeRemoveEventAttendees[num2]);
              }
            handler.finish_array();
          }
        if (flagHasNewSelfAttendeeStatus)
          {
            handler.start_pair("NewSelfAttendeeStatus");
            switch (storeNewSelfAttendeeStatus)
              {
                case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_None:
                    handler.string_value("None");
                    break;
                case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Accepted:
                    handler.string_value("Accepted");
                    break;
                case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Declined:
                    handler.string_value("Declined");
                    break;
                case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Invited:
                    handler.string_value("Invited");
                    break;
                case TypeNewSelfAttendeeStatus.NewSelfAttendeeStatus_Tentative:
                    handler.string_value("Tentative");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
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
        if (!(hasItemType()))
          {
            return "When parsing the object for %what%, the \"ItemType\" field was missing.";
          }
        if (!(hasExactTitle()))
          {
            return "When parsing the object for %what%, the \"ExactTitle\" field was missing.";
          }
        if (!(hasPartialTitle()))
          {
            return "When parsing the object for %what%, the \"PartialTitle\" field was missing.";
          }
        if (!(hasExactLocation()))
          {
            return "When parsing the object for %what%, the \"ExactLocation\" field was missing.";
          }
        if (!(hasPartialLocation()))
          {
            return "When parsing the object for %what%, the \"PartialLocation\" field was missing.";
          }
        if (!(hasStartStart()))
          {
            return "When parsing the object for %what%, the \"StartStart\" field was missing.";
          }
        if (!(hasEndStart()))
          {
            return "When parsing the object for %what%, the \"EndStart\" field was missing.";
          }
        if (!(hasStartEnd()))
          {
            return "When parsing the object for %what%, the \"StartEnd\" field was missing.";
          }
        if (!(hasEndEnd()))
          {
            return "When parsing the object for %what%, the \"EndEnd\" field was missing.";
          }
        if (!(hasNewItemType()))
          {
            return "When parsing the object for %what%, the \"NewItemType\" field was missing.";
          }
        if (!(hasNewTitle()))
          {
            return "When parsing the object for %what%, the \"NewTitle\" field was missing.";
          }
        if (!(hasNewLocation()))
          {
            return "When parsing the object for %what%, the \"NewLocation\" field was missing.";
          }
        if (!(hasNewStart()))
          {
            return "When parsing the object for %what%, the \"NewStart\" field was missing.";
          }
        if (!(hasStartDeltaSeconds()))
          {
            return "When parsing the object for %what%, the \"StartDeltaSeconds\" field was missing.";
          }
        if (!(hasStartDeltaDays()))
          {
            return "When parsing the object for %what%, the \"StartDeltaDays\" field was missing.";
          }
        if (!(hasStartDeltaMonths()))
          {
            return "When parsing the object for %what%, the \"StartDeltaMonths\" field was missing.";
          }
        if (!(hasNewEnd()))
          {
            return "When parsing the object for %what%, the \"NewEnd\" field was missing.";
          }
        if (!(hasEndDeltaSeconds()))
          {
            return "When parsing the object for %what%, the \"EndDeltaSeconds\" field was missing.";
          }
        if (!(hasEndDeltaDays()))
          {
            return "When parsing the object for %what%, the \"EndDeltaDays\" field was missing.";
          }
        if (!(hasEndDeltaMonths()))
          {
            return "When parsing the object for %what%, the \"EndDeltaMonths\" field was missing.";
          }
        if (!(hasNewFrequencyType()))
          {
            return "When parsing the object for %what%, the \"NewFrequencyType\" field was missing.";
          }
        if (!(hasNewFrequencyMultiplier()))
          {
            return "When parsing the object for %what%, the \"NewFrequencyMultiplier\" field was missing.";
          }
        return null;
      }

    public static new ModifyCalendarItemsCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ModifyCalendarItemsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ModifyCalendarItemsCommand", ignore_extras);
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
    public static new ModifyCalendarItemsCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ModifyCalendarItemsCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ModifyCalendarItemsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ModifyCalendarItemsCommand", ignore_extras);
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
    public static new ModifyCalendarItemsCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ModifyCalendarItemsCommandJSON from_text(string text, bool ignore_extras)
      {
        ModifyCalendarItemsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ModifyCalendarItemsCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ModifyCalendarItemsCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ModifyCalendarItemsCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ModifyCalendarItemsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ModifyCalendarItemsCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CalendarCommandJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorItemType;
        private JSONHoldingStringGenerator fieldGeneratorExactTitle;
        private JSONHoldingStringGenerator fieldGeneratorPartialTitle;
        private JSONHoldingStringGenerator fieldGeneratorExactLocation;
        private JSONHoldingStringGenerator fieldGeneratorPartialLocation;
        private CalendarLocationJSON.HoldingGenerator fieldGeneratorLocationSpecifier;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartStart;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndStart;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartEnd;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndEnd;
        private JSONHoldingStringGenerator fieldGeneratorNewItemType;
        private JSONHoldingStringGenerator fieldGeneratorNewTitle;
        private JSONHoldingStringGenerator fieldGeneratorNewLocation;
        private CalendarLocationJSON.HoldingGenerator fieldGeneratorNewLocationSpecifier;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorNewStart;
        private JSONHoldingNumberTextGenerator fieldGeneratorStartDeltaSeconds;
    private class FieldHoldingGeneratorStartDeltaDays : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorStartDeltaDays(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorStartDeltaDays : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorStartDeltaDays(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorStartDeltaDays fieldGeneratorStartDeltaDays;
    private class FieldHoldingGeneratorStartDeltaMonths : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorStartDeltaMonths(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorStartDeltaMonths : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorStartDeltaMonths(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorStartDeltaMonths fieldGeneratorStartDeltaMonths;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorNewEnd;
        private JSONHoldingNumberTextGenerator fieldGeneratorEndDeltaSeconds;
    private class FieldHoldingGeneratorEndDeltaDays : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorEndDeltaDays(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorEndDeltaDays : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorEndDeltaDays(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorEndDeltaDays fieldGeneratorEndDeltaDays;
    private class FieldHoldingGeneratorEndDeltaMonths : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorEndDeltaMonths(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorEndDeltaMonths : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorEndDeltaMonths(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorEndDeltaMonths fieldGeneratorEndDeltaMonths;
    private abstract class FieldGeneratorNewFrequencyType : JSONStringGenerator
          {
            protected FieldGeneratorNewFrequencyType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorNewFrequencyType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToNewFrequencyType(result));
              }
            protected abstract void handle_result(TypeNewFrequencyType result);
          };
    private class FieldHoldingGeneratorNewFrequencyType : FieldGeneratorNewFrequencyType
  {
    protected override void handle_result(TypeNewFrequencyType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorNewFrequencyType(String what)
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
    public TypeNewFrequencyType value;
  };
    private class FieldHoldingArrayGeneratorNewFrequencyType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorNewFrequencyType
      {
        private FieldHoldingArrayGeneratorNewFrequencyType top;

        protected override void handle_result(TypeNewFrequencyType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorNewFrequencyType init_top)
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
    protected virtual void handle_result(List<TypeNewFrequencyType> result)
      {
      }

    public FieldHoldingArrayGeneratorNewFrequencyType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNewFrequencyType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorNewFrequencyType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNewFrequencyType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeNewFrequencyType> value;
  };
        private FieldHoldingGeneratorNewFrequencyType fieldGeneratorNewFrequencyType;
    private class FieldHoldingGeneratorNewFrequencyMultiplier : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorNewFrequencyMultiplier(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorNewFrequencyMultiplier : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorNewFrequencyMultiplier(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorNewFrequencyMultiplier fieldGeneratorNewFrequencyMultiplier;
        private JSONHoldingStringArrayGenerator fieldGeneratorAddEventAttendees;
        private JSONHoldingStringArrayGenerator fieldGeneratorRemoveEventAttendees;
    private abstract class FieldGeneratorNewSelfAttendeeStatus : JSONStringGenerator
          {
            protected FieldGeneratorNewSelfAttendeeStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorNewSelfAttendeeStatus()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToNewSelfAttendeeStatus(result));
              }
            protected abstract void handle_result(TypeNewSelfAttendeeStatus result);
          };
    private class FieldHoldingGeneratorNewSelfAttendeeStatus : FieldGeneratorNewSelfAttendeeStatus
  {
    protected override void handle_result(TypeNewSelfAttendeeStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorNewSelfAttendeeStatus(String what)
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
    public TypeNewSelfAttendeeStatus value;
  };
    private class FieldHoldingArrayGeneratorNewSelfAttendeeStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorNewSelfAttendeeStatus
      {
        private FieldHoldingArrayGeneratorNewSelfAttendeeStatus top;

        protected override void handle_result(TypeNewSelfAttendeeStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorNewSelfAttendeeStatus init_top)
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
    protected virtual void handle_result(List<TypeNewSelfAttendeeStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorNewSelfAttendeeStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNewSelfAttendeeStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorNewSelfAttendeeStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNewSelfAttendeeStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeNewSelfAttendeeStatus> value;
  };
        private FieldHoldingGeneratorNewSelfAttendeeStatus fieldGeneratorNewSelfAttendeeStatus;
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
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
            if (!(getCalendarCommandJSONKey().Equals("ModifyItems")))
                throw new Exception("The key field has a value other than `ModifyItems'.");
            ModifyCalendarItemsCommandJSON result = new ModifyCalendarItemsCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraModifyCalendarItemsCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CalendarCommandJSON new_result)
          {
            handle_result((ModifyCalendarItemsCommandJSON )new_result);
          }
        protected void finish(ModifyCalendarItemsCommandJSON result)
          {
            if (fieldGeneratorItemType.have_value)
              {
                result.setItemType(fieldGeneratorItemType.value);
                fieldGeneratorItemType.have_value = false;
              }
            else if ((!(result.hasItemType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ItemType\" field was missing.");
              }
            if (fieldGeneratorExactTitle.have_value)
              {
                result.setExactTitle(fieldGeneratorExactTitle.value);
                fieldGeneratorExactTitle.have_value = false;
              }
            else if ((!(result.hasExactTitle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ExactTitle\" field was missing.");
              }
            if (fieldGeneratorPartialTitle.have_value)
              {
                result.setPartialTitle(fieldGeneratorPartialTitle.value);
                fieldGeneratorPartialTitle.have_value = false;
              }
            else if ((!(result.hasPartialTitle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PartialTitle\" field was missing.");
              }
            if (fieldGeneratorExactLocation.have_value)
              {
                result.setExactLocation(fieldGeneratorExactLocation.value);
                fieldGeneratorExactLocation.have_value = false;
              }
            else if ((!(result.hasExactLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ExactLocation\" field was missing.");
              }
            if (fieldGeneratorPartialLocation.have_value)
              {
                result.setPartialLocation(fieldGeneratorPartialLocation.value);
                fieldGeneratorPartialLocation.have_value = false;
              }
            else if ((!(result.hasPartialLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PartialLocation\" field was missing.");
              }
            if (fieldGeneratorLocationSpecifier.have_value)
              {
                result.setLocationSpecifier(fieldGeneratorLocationSpecifier.value);
                fieldGeneratorLocationSpecifier.have_value = false;
              }
            if (fieldGeneratorStartStart.have_value)
              {
                result.setStartStart(fieldGeneratorStartStart.value);
                fieldGeneratorStartStart.have_value = false;
              }
            else if ((!(result.hasStartStart())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartStart\" field was missing.");
              }
            if (fieldGeneratorEndStart.have_value)
              {
                result.setEndStart(fieldGeneratorEndStart.value);
                fieldGeneratorEndStart.have_value = false;
              }
            else if ((!(result.hasEndStart())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndStart\" field was missing.");
              }
            if (fieldGeneratorStartEnd.have_value)
              {
                result.setStartEnd(fieldGeneratorStartEnd.value);
                fieldGeneratorStartEnd.have_value = false;
              }
            else if ((!(result.hasStartEnd())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartEnd\" field was missing.");
              }
            if (fieldGeneratorEndEnd.have_value)
              {
                result.setEndEnd(fieldGeneratorEndEnd.value);
                fieldGeneratorEndEnd.have_value = false;
              }
            else if ((!(result.hasEndEnd())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndEnd\" field was missing.");
              }
            if (fieldGeneratorNewItemType.have_value)
              {
                result.setNewItemType(fieldGeneratorNewItemType.value);
                fieldGeneratorNewItemType.have_value = false;
              }
            else if ((!(result.hasNewItemType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewItemType\" field was missing.");
              }
            if (fieldGeneratorNewTitle.have_value)
              {
                result.setNewTitle(fieldGeneratorNewTitle.value);
                fieldGeneratorNewTitle.have_value = false;
              }
            else if ((!(result.hasNewTitle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewTitle\" field was missing.");
              }
            if (fieldGeneratorNewLocation.have_value)
              {
                result.setNewLocation(fieldGeneratorNewLocation.value);
                fieldGeneratorNewLocation.have_value = false;
              }
            else if ((!(result.hasNewLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewLocation\" field was missing.");
              }
            if (fieldGeneratorNewLocationSpecifier.have_value)
              {
                result.setNewLocationSpecifier(fieldGeneratorNewLocationSpecifier.value);
                fieldGeneratorNewLocationSpecifier.have_value = false;
              }
            if (fieldGeneratorNewStart.have_value)
              {
                result.setNewStart(fieldGeneratorNewStart.value);
                fieldGeneratorNewStart.have_value = false;
              }
            else if ((!(result.hasNewStart())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewStart\" field was missing.");
              }
            if (fieldGeneratorStartDeltaSeconds.have_value)
              {
                result.setStartDeltaSecondsText(fieldGeneratorStartDeltaSeconds.value);
                fieldGeneratorStartDeltaSeconds.have_value = false;
              }
            else if ((!(result.hasStartDeltaSeconds())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartDeltaSeconds\" field was missing.");
              }
            if (fieldGeneratorStartDeltaDays.have_value)
              {
                result.setStartDeltaDays(fieldGeneratorStartDeltaDays.value);
                fieldGeneratorStartDeltaDays.have_value = false;
              }
            else if ((!(result.hasStartDeltaDays())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartDeltaDays\" field was missing.");
              }
            if (fieldGeneratorStartDeltaMonths.have_value)
              {
                result.setStartDeltaMonths(fieldGeneratorStartDeltaMonths.value);
                fieldGeneratorStartDeltaMonths.have_value = false;
              }
            else if ((!(result.hasStartDeltaMonths())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartDeltaMonths\" field was missing.");
              }
            if (fieldGeneratorNewEnd.have_value)
              {
                result.setNewEnd(fieldGeneratorNewEnd.value);
                fieldGeneratorNewEnd.have_value = false;
              }
            else if ((!(result.hasNewEnd())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewEnd\" field was missing.");
              }
            if (fieldGeneratorEndDeltaSeconds.have_value)
              {
                result.setEndDeltaSecondsText(fieldGeneratorEndDeltaSeconds.value);
                fieldGeneratorEndDeltaSeconds.have_value = false;
              }
            else if ((!(result.hasEndDeltaSeconds())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndDeltaSeconds\" field was missing.");
              }
            if (fieldGeneratorEndDeltaDays.have_value)
              {
                result.setEndDeltaDays(fieldGeneratorEndDeltaDays.value);
                fieldGeneratorEndDeltaDays.have_value = false;
              }
            else if ((!(result.hasEndDeltaDays())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndDeltaDays\" field was missing.");
              }
            if (fieldGeneratorEndDeltaMonths.have_value)
              {
                result.setEndDeltaMonths(fieldGeneratorEndDeltaMonths.value);
                fieldGeneratorEndDeltaMonths.have_value = false;
              }
            else if ((!(result.hasEndDeltaMonths())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndDeltaMonths\" field was missing.");
              }
            if (fieldGeneratorNewFrequencyType.have_value)
              {
                result.setNewFrequencyType(fieldGeneratorNewFrequencyType.value);
                fieldGeneratorNewFrequencyType.have_value = false;
              }
            else if ((!(result.hasNewFrequencyType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewFrequencyType\" field was missing.");
              }
            if (fieldGeneratorNewFrequencyMultiplier.have_value)
              {
                result.setNewFrequencyMultiplier(fieldGeneratorNewFrequencyMultiplier.value);
                fieldGeneratorNewFrequencyMultiplier.have_value = false;
              }
            else if ((!(result.hasNewFrequencyMultiplier())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewFrequencyMultiplier\" field was missing.");
              }
            if (fieldGeneratorAddEventAttendees.have_value)
              {
                result.initAddEventAttendees();
                int count = fieldGeneratorAddEventAttendees.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAddEventAttendees(fieldGeneratorAddEventAttendees.value[num]);
                  }
                fieldGeneratorAddEventAttendees.value.Clear();
                fieldGeneratorAddEventAttendees.have_value = false;
              }
            if (fieldGeneratorRemoveEventAttendees.have_value)
              {
                result.initRemoveEventAttendees();
                int count = fieldGeneratorRemoveEventAttendees.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRemoveEventAttendees(fieldGeneratorRemoveEventAttendees.value[num]);
                  }
                fieldGeneratorRemoveEventAttendees.value.Clear();
                fieldGeneratorRemoveEventAttendees.have_value = false;
              }
            if (fieldGeneratorNewSelfAttendeeStatus.have_value)
              {
                result.setNewSelfAttendeeStatus(fieldGeneratorNewSelfAttendeeStatus.value);
                fieldGeneratorNewSelfAttendeeStatus.have_value = false;
              }
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ModifyCalendarItemsCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ddEventAttendees", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorAddEventAttendees;
                    break;
                case 'E':
                    switch (field_name[1])
                      {
                        case 'n':
                            if (String.Compare(field_name, 2, "d", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'D':
                                        if (String.Compare(field_name, 4, "elta", 0, 4, false) == 0)
                                          {
                                            switch (field_name[8])
                                              {
                                                case 'D':
                                                    if ((String.Compare(field_name, 9, "ays", 0, 3, false) == 0) && (field_name.Length == 12))
                                                        return fieldGeneratorEndDeltaDays;
                                                    break;
                                                case 'M':
                                                    if ((String.Compare(field_name, 9, "onths", 0, 5, false) == 0) && (field_name.Length == 14))
                                                        return fieldGeneratorEndDeltaMonths;
                                                    break;
                                                case 'S':
                                                    if ((String.Compare(field_name, 9, "econds", 0, 6, false) == 0) && (field_name.Length == 15))
                                                        return fieldGeneratorEndDeltaSeconds;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'E':
                                        if ((String.Compare(field_name, 4, "nd", 0, 2, false) == 0) && (field_name.Length == 6))
                                            return fieldGeneratorEndEnd;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 4, "tart", 0, 4, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorEndStart;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'x':
                            if (String.Compare(field_name, 2, "act", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'L':
                                        if ((String.Compare(field_name, 6, "ocation", 0, 7, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorExactLocation;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 6, "itle", 0, 4, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorExactTitle;
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
                case 'I':
                    if ((String.Compare(field_name, 1, "temType", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorItemType;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocationSpecifier", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorLocationSpecifier;
                    break;
                case 'N':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "tiveData", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorNativeData;
                            break;
                        case 'e':
                            if (String.Compare(field_name, 2, "w", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'E':
                                        if ((String.Compare(field_name, 4, "nd", 0, 2, false) == 0) && (field_name.Length == 6))
                                            return fieldGeneratorNewEnd;
                                        break;
                                    case 'F':
                                        if (String.Compare(field_name, 4, "requency", 0, 8, false) == 0)
                                          {
                                            switch (field_name[12])
                                              {
                                                case 'M':
                                                    if ((String.Compare(field_name, 13, "ultiplier", 0, 9, false) == 0) && (field_name.Length == 22))
                                                        return fieldGeneratorNewFrequencyMultiplier;
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(field_name, 13, "ype", 0, 3, false) == 0) && (field_name.Length == 16))
                                                        return fieldGeneratorNewFrequencyType;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'I':
                                        if ((String.Compare(field_name, 4, "temType", 0, 7, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorNewItemType;
                                        break;
                                    case 'L':
                                        if (String.Compare(field_name, 4, "ocation", 0, 7, false) == 0)
                                          {
                                            if (field_name.Length == 11)
                                              {
                                                return fieldGeneratorNewLocation;
                                              }
                                            switch (field_name[11])
                                              {
                                                case 'S':
                                                    if ((String.Compare(field_name, 12, "pecifier", 0, 8, false) == 0) && (field_name.Length == 20))
                                                        return fieldGeneratorNewLocationSpecifier;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'S':
                                        switch (field_name[4])
                                          {
                                            case 'e':
                                                if ((String.Compare(field_name, 5, "lfAttendeeStatus", 0, 16, false) == 0) && (field_name.Length == 21))
                                                    return fieldGeneratorNewSelfAttendeeStatus;
                                                break;
                                            case 't':
                                                if ((String.Compare(field_name, 5, "art", 0, 3, false) == 0) && (field_name.Length == 8))
                                                    return fieldGeneratorNewStart;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 4, "itle", 0, 4, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorNewTitle;
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
                case 'P':
                    if (String.Compare(field_name, 1, "artial", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 8, "ocation", 0, 7, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorPartialLocation;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 8, "itle", 0, 4, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorPartialTitle;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "emoveEventAttendees", 0, 19, false) == 0) && (field_name.Length == 20))
                        return fieldGeneratorRemoveEventAttendees;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "tart", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'D':
                                if (String.Compare(field_name, 6, "elta", 0, 4, false) == 0)
                                  {
                                    switch (field_name[10])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 11, "ays", 0, 3, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorStartDeltaDays;
                                            break;
                                        case 'M':
                                            if ((String.Compare(field_name, 11, "onths", 0, 5, false) == 0) && (field_name.Length == 16))
                                                return fieldGeneratorStartDeltaMonths;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 11, "econds", 0, 6, false) == 0) && (field_name.Length == 17))
                                                return fieldGeneratorStartDeltaSeconds;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'E':
                                if ((String.Compare(field_name, 6, "nd", 0, 2, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorStartEnd;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 6, "tart", 0, 4, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorStartStart;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorItemType = new JSONHoldingStringGenerator("field \"ItemType\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorExactTitle = new JSONHoldingStringGenerator("field \"ExactTitle\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorPartialTitle = new JSONHoldingStringGenerator("field \"PartialTitle\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorExactLocation = new JSONHoldingStringGenerator("field \"ExactLocation\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorPartialLocation = new JSONHoldingStringGenerator("field \"PartialLocation\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the ModifyCalendarItemsCommand class", ignore_extras);
            fieldGeneratorStartStart = new DateAndOrTimeJSON.HoldingGenerator("field \"StartStart\" of the ModifyCalendarItemsCommand class", ignore_extras);
            fieldGeneratorEndStart = new DateAndOrTimeJSON.HoldingGenerator("field \"EndStart\" of the ModifyCalendarItemsCommand class", ignore_extras);
            fieldGeneratorStartEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"StartEnd\" of the ModifyCalendarItemsCommand class", ignore_extras);
            fieldGeneratorEndEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"EndEnd\" of the ModifyCalendarItemsCommand class", ignore_extras);
            fieldGeneratorNewItemType = new JSONHoldingStringGenerator("field \"NewItemType\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorNewTitle = new JSONHoldingStringGenerator("field \"NewTitle\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorNewLocation = new JSONHoldingStringGenerator("field \"NewLocation\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorNewLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"NewLocationSpecifier\" of the ModifyCalendarItemsCommand class", ignore_extras);
            fieldGeneratorNewStart = new DateAndOrTimeJSON.HoldingGenerator("field \"NewStart\" of the ModifyCalendarItemsCommand class", ignore_extras);
            fieldGeneratorStartDeltaSeconds = new JSONHoldingNumberTextGenerator("field \"StartDeltaSeconds\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorStartDeltaDays = new FieldHoldingGeneratorStartDeltaDays("field \"StartDeltaDays\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorStartDeltaMonths = new FieldHoldingGeneratorStartDeltaMonths("field \"StartDeltaMonths\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorNewEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"NewEnd\" of the ModifyCalendarItemsCommand class", ignore_extras);
            fieldGeneratorEndDeltaSeconds = new JSONHoldingNumberTextGenerator("field \"EndDeltaSeconds\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorEndDeltaDays = new FieldHoldingGeneratorEndDeltaDays("field \"EndDeltaDays\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorEndDeltaMonths = new FieldHoldingGeneratorEndDeltaMonths("field \"EndDeltaMonths\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorNewFrequencyType = new FieldHoldingGeneratorNewFrequencyType("field \"NewFrequencyType\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorNewFrequencyMultiplier = new FieldHoldingGeneratorNewFrequencyMultiplier("field \"NewFrequencyMultiplier\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorAddEventAttendees = new JSONHoldingStringArrayGenerator("field \"AddEventAttendees\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorRemoveEventAttendees = new JSONHoldingStringArrayGenerator("field \"RemoveEventAttendees\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorNewSelfAttendeeStatus = new FieldHoldingGeneratorNewSelfAttendeeStatus("field \"NewSelfAttendeeStatus\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the ModifyCalendarItemsCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ModifyCalendarItemsCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorItemType = new JSONHoldingStringGenerator("field \"ItemType\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorExactTitle = new JSONHoldingStringGenerator("field \"ExactTitle\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorPartialTitle = new JSONHoldingStringGenerator("field \"PartialTitle\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorExactLocation = new JSONHoldingStringGenerator("field \"ExactLocation\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorPartialLocation = new JSONHoldingStringGenerator("field \"PartialLocation\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the ModifyCalendarItemsCommand class", false);
            fieldGeneratorStartStart = new DateAndOrTimeJSON.HoldingGenerator("field \"StartStart\" of the ModifyCalendarItemsCommand class", false);
            fieldGeneratorEndStart = new DateAndOrTimeJSON.HoldingGenerator("field \"EndStart\" of the ModifyCalendarItemsCommand class", false);
            fieldGeneratorStartEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"StartEnd\" of the ModifyCalendarItemsCommand class", false);
            fieldGeneratorEndEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"EndEnd\" of the ModifyCalendarItemsCommand class", false);
            fieldGeneratorNewItemType = new JSONHoldingStringGenerator("field \"NewItemType\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorNewTitle = new JSONHoldingStringGenerator("field \"NewTitle\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorNewLocation = new JSONHoldingStringGenerator("field \"NewLocation\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorNewLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"NewLocationSpecifier\" of the ModifyCalendarItemsCommand class", false);
            fieldGeneratorNewStart = new DateAndOrTimeJSON.HoldingGenerator("field \"NewStart\" of the ModifyCalendarItemsCommand class", false);
            fieldGeneratorStartDeltaSeconds = new JSONHoldingNumberTextGenerator("field \"StartDeltaSeconds\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorStartDeltaDays = new FieldHoldingGeneratorStartDeltaDays("field \"StartDeltaDays\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorStartDeltaMonths = new FieldHoldingGeneratorStartDeltaMonths("field \"StartDeltaMonths\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorNewEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"NewEnd\" of the ModifyCalendarItemsCommand class", false);
            fieldGeneratorEndDeltaSeconds = new JSONHoldingNumberTextGenerator("field \"EndDeltaSeconds\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorEndDeltaDays = new FieldHoldingGeneratorEndDeltaDays("field \"EndDeltaDays\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorEndDeltaMonths = new FieldHoldingGeneratorEndDeltaMonths("field \"EndDeltaMonths\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorNewFrequencyType = new FieldHoldingGeneratorNewFrequencyType("field \"NewFrequencyType\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorNewFrequencyMultiplier = new FieldHoldingGeneratorNewFrequencyMultiplier("field \"NewFrequencyMultiplier\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorAddEventAttendees = new JSONHoldingStringArrayGenerator("field \"AddEventAttendees\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorRemoveEventAttendees = new JSONHoldingStringArrayGenerator("field \"RemoveEventAttendees\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorNewSelfAttendeeStatus = new FieldHoldingGeneratorNewSelfAttendeeStatus("field \"NewSelfAttendeeStatus\" of the ModifyCalendarItemsCommand class");
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the ModifyCalendarItemsCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ModifyCalendarItemsCommand class");
          }

        public override void reset()
          {
            fieldGeneratorItemType.reset();
            fieldGeneratorExactTitle.reset();
            fieldGeneratorPartialTitle.reset();
            fieldGeneratorExactLocation.reset();
            fieldGeneratorPartialLocation.reset();
            fieldGeneratorLocationSpecifier.reset();
            fieldGeneratorStartStart.reset();
            fieldGeneratorEndStart.reset();
            fieldGeneratorStartEnd.reset();
            fieldGeneratorEndEnd.reset();
            fieldGeneratorNewItemType.reset();
            fieldGeneratorNewTitle.reset();
            fieldGeneratorNewLocation.reset();
            fieldGeneratorNewLocationSpecifier.reset();
            fieldGeneratorNewStart.reset();
            fieldGeneratorStartDeltaSeconds.reset();
            fieldGeneratorStartDeltaDays.reset();
            fieldGeneratorStartDeltaMonths.reset();
            fieldGeneratorNewEnd.reset();
            fieldGeneratorEndDeltaSeconds.reset();
            fieldGeneratorEndDeltaDays.reset();
            fieldGeneratorEndDeltaMonths.reset();
            fieldGeneratorNewFrequencyType.reset();
            fieldGeneratorNewFrequencyMultiplier.reset();
            fieldGeneratorAddEventAttendees.reset();
            fieldGeneratorRemoveEventAttendees.reset();
            fieldGeneratorNewSelfAttendeeStatus.reset();
            fieldGeneratorNativeData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ModifyCalendarItemsCommandJSON  result)
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
        public ModifyCalendarItemsCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ModifyCalendarItemsCommandJSON  result)
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
    protected virtual void handle_result(List<ModifyCalendarItemsCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ModifyCalendarItemsCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ModifyCalendarItemsCommandJSON>();
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
    public List<ModifyCalendarItemsCommandJSON> value;
  };
  };
