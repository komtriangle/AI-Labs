/* file "CreateCalendarRequestInformationCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CreateCalendarRequestInformationCommandJSON : CalendarCommandJSON
  {
    public enum TypeVariableRequestedKnownValues
      {
        VariableRequested_Undefined,
        VariableRequested_Title,
        VariableRequested_StartDate,
        VariableRequested_StartTime,
        VariableRequested__none
      };
    public struct TypeVariableRequested
      {
        public bool in_known_list;
        public string string_value;
        public TypeVariableRequestedKnownValues list_value;
      };

    public static TypeVariableRequestedKnownValues  stringToVariableRequested(string chars)
      {
        switch (chars[0])
          {
            case 'S':
                if (String.Compare(chars, 1, "tart", 0, 4, false) == 0)
                  {
                    switch (chars[5])
                      {
                        case 'D':
                            if ((String.Compare(chars, 6, "ate", 0, 3, false) == 0) && (chars.Length == 9))
                                return TypeVariableRequestedKnownValues.VariableRequested_StartDate;
                            break;
                        case 'T':
                            if ((String.Compare(chars, 6, "ime", 0, 3, false) == 0) && (chars.Length == 9))
                                return TypeVariableRequestedKnownValues.VariableRequested_StartTime;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'T':
                if ((String.Compare(chars, 1, "itle", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeVariableRequestedKnownValues.VariableRequested_Title;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "ndefined", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeVariableRequestedKnownValues.VariableRequested_Undefined;
                break;
            default:
                break;
          }
        return TypeVariableRequestedKnownValues.VariableRequested__none;
      }

    public static string  stringFromVariableRequested(TypeVariableRequestedKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeVariableRequestedKnownValues.VariableRequested_Undefined:
                return "Undefined";
            case TypeVariableRequestedKnownValues.VariableRequested_Title:
                return "Title";
            case TypeVariableRequestedKnownValues.VariableRequested_StartDate:
                return "StartDate";
            case TypeVariableRequestedKnownValues.VariableRequested_StartTime:
                return "StartTime";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeLastResponseUnderstandingStatusKnownValues
      {
        LastResponseUnderstandingStatus_Understood,
        LastResponseUnderstandingStatus_DateNotUnderstood,
        LastResponseUnderstandingStatus_TimeNotUnderstood,
        LastResponseUnderstandingStatus_AttendeeNotUnderstood,
        LastResponseUnderstandingStatus_AttendeeEmailNotUnderstood,
        LastResponseUnderstandingStatus_SomethingElseNotUnderstood,
        LastResponseUnderstandingStatus__none
      };
    public struct TypeLastResponseUnderstandingStatus
      {
        public bool in_known_list;
        public string string_value;
        public TypeLastResponseUnderstandingStatusKnownValues list_value;
      };

    public static TypeLastResponseUnderstandingStatusKnownValues  stringToLastResponseUnderstandingStatus(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if (String.Compare(chars, 1, "ttendee", 0, 7, false) == 0)
                  {
                    switch (chars[8])
                      {
                        case 'E':
                            if ((String.Compare(chars, 9, "mailNotUnderstood", 0, 17, false) == 0) && (chars.Length == 26))
                                return TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_AttendeeEmailNotUnderstood;
                            break;
                        case 'N':
                            if ((String.Compare(chars, 9, "otUnderstood", 0, 12, false) == 0) && (chars.Length == 21))
                                return TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_AttendeeNotUnderstood;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'D':
                if ((String.Compare(chars, 1, "ateNotUnderstood", 0, 16, false) == 0) && (chars.Length == 17))
                    return TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_DateNotUnderstood;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "omethingElseNotUnderstood", 0, 25, false) == 0) && (chars.Length == 26))
                    return TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_SomethingElseNotUnderstood;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "imeNotUnderstood", 0, 16, false) == 0) && (chars.Length == 17))
                    return TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_TimeNotUnderstood;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nderstood", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_Understood;
                break;
            default:
                break;
          }
        return TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus__none;
      }

    public static string  stringFromLastResponseUnderstandingStatus(TypeLastResponseUnderstandingStatusKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_Understood:
                return "Understood";
            case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_DateNotUnderstood:
                return "DateNotUnderstood";
            case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_TimeNotUnderstood:
                return "TimeNotUnderstood";
            case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_AttendeeNotUnderstood:
                return "AttendeeNotUnderstood";
            case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_AttendeeEmailNotUnderstood:
                return "AttendeeEmailNotUnderstood";
            case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_SomethingElseNotUnderstood:
                return "SomethingElseNotUnderstood";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCalendarCreateData;
    private List< CalendarCreateDataJSON  > storeCalendarCreateData;
    private bool flagHasVariableRequested;
    private TypeVariableRequested storeVariableRequested;
    private bool flagHasStartCreateCalendarItem;
    private bool storeStartCreateCalendarItem;
    private bool flagHasUserDoesNotKnowLastVariableRequested;
    private bool storeUserDoesNotKnowLastVariableRequested;
    private bool flagHasUserDesiresLastVariableRequested;
    private bool storeUserDesiresLastVariableRequested;
    private bool flagHasUserIsConfused;
    private bool storeUserIsConfused;
    private bool flagHasLastResponseNotUnderstood;
    private bool storeLastResponseNotUnderstood;
    private bool flagHasLastResponseUnderstandingStatus;
    private TypeLastResponseUnderstandingStatus storeLastResponseUnderstandingStatus;
    private bool flagHasConversationStateUsed;
    private bool storeConversationStateUsed;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCalendarCreateDataToJSON()
      {
        JSONArrayValue generated_array_1_CalendarCreateData = new JSONArrayValue();
        for (int num1 = 0; num1 < storeCalendarCreateData.Count; ++num1)
          {
            JSONValueHandler handler_CalendarCreateData = new JSONValueHandler();
            storeCalendarCreateData[num1].write_as_json(handler_CalendarCreateData);
            generated_array_1_CalendarCreateData.appendComponent(handler_CalendarCreateData.result);
          }
        return generated_array_1_CalendarCreateData;
      }

    private JSONValue  extraVariableRequestedToJSON()
      {
        JSONStringValue generated_string_VariableRequested;
        if (!(storeVariableRequested.in_known_list))
          {
        generated_string_VariableRequested = new JSONStringValue(storeVariableRequested.string_value);
          }
        else
          {
        switch (storeVariableRequested.list_value)
          {
            case TypeVariableRequestedKnownValues.VariableRequested_Undefined:
                generated_string_VariableRequested = new JSONStringValue("Undefined");
                break;
            case TypeVariableRequestedKnownValues.VariableRequested_Title:
                generated_string_VariableRequested = new JSONStringValue("Title");
                break;
            case TypeVariableRequestedKnownValues.VariableRequested_StartDate:
                generated_string_VariableRequested = new JSONStringValue("StartDate");
                break;
            case TypeVariableRequestedKnownValues.VariableRequested_StartTime:
                generated_string_VariableRequested = new JSONStringValue("StartTime");
                break;
            default:
                Debug.Assert(false);
                generated_string_VariableRequested = null;
                break;
          }
          }
        return generated_string_VariableRequested;
      }

    private JSONValue  extraStartCreateCalendarItemToJSON()
      {
        JSONValue generated_boolean_StartCreateCalendarItem = (storeStartCreateCalendarItem ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_StartCreateCalendarItem;
      }

    private JSONValue  extraUserDoesNotKnowLastVariableRequestedToJSON()
      {
        JSONValue generated_boolean_UserDoesNotKnowLastVariableRequested = (storeUserDoesNotKnowLastVariableRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_UserDoesNotKnowLastVariableRequested;
      }

    private JSONValue  extraUserDesiresLastVariableRequestedToJSON()
      {
        JSONValue generated_boolean_UserDesiresLastVariableRequested = (storeUserDesiresLastVariableRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_UserDesiresLastVariableRequested;
      }

    private JSONValue  extraUserIsConfusedToJSON()
      {
        JSONValue generated_boolean_UserIsConfused = (storeUserIsConfused ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_UserIsConfused;
      }

    private JSONValue  extraLastResponseNotUnderstoodToJSON()
      {
        JSONValue generated_boolean_LastResponseNotUnderstood = (storeLastResponseNotUnderstood ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_LastResponseNotUnderstood;
      }

    private JSONValue  extraLastResponseUnderstandingStatusToJSON()
      {
        JSONStringValue generated_string_LastResponseUnderstandingStatus;
        if (!(storeLastResponseUnderstandingStatus.in_known_list))
          {
        generated_string_LastResponseUnderstandingStatus = new JSONStringValue(storeLastResponseUnderstandingStatus.string_value);
          }
        else
          {
        switch (storeLastResponseUnderstandingStatus.list_value)
          {
            case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_Understood:
                generated_string_LastResponseUnderstandingStatus = new JSONStringValue("Understood");
                break;
            case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_DateNotUnderstood:
                generated_string_LastResponseUnderstandingStatus = new JSONStringValue("DateNotUnderstood");
                break;
            case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_TimeNotUnderstood:
                generated_string_LastResponseUnderstandingStatus = new JSONStringValue("TimeNotUnderstood");
                break;
            case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_AttendeeNotUnderstood:
                generated_string_LastResponseUnderstandingStatus = new JSONStringValue("AttendeeNotUnderstood");
                break;
            case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_AttendeeEmailNotUnderstood:
                generated_string_LastResponseUnderstandingStatus = new JSONStringValue("AttendeeEmailNotUnderstood");
                break;
            case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_SomethingElseNotUnderstood:
                generated_string_LastResponseUnderstandingStatus = new JSONStringValue("SomethingElseNotUnderstood");
                break;
            default:
                Debug.Assert(false);
                generated_string_LastResponseUnderstandingStatus = null;
                break;
          }
          }
        return generated_string_LastResponseUnderstandingStatus;
      }

    private JSONValue  extraConversationStateUsedToJSON()
      {
        JSONValue generated_boolean_ConversationStateUsed = (storeConversationStateUsed ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_ConversationStateUsed;
      }


    private void  fromJSONCalendarCreateData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CalendarCreateData of CreateCalendarRequestInformationCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< CalendarCreateDataJSON  > vector_CalendarCreateData1 = new List< CalendarCreateDataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CalendarCreateDataJSON convert_classy = CalendarCreateDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_CalendarCreateData1.Add(convert_classy);
          }
        initCalendarCreateData();
        for (int num1 = 0; num1 < vector_CalendarCreateData1.Count; ++num1)
            appendCalendarCreateData(vector_CalendarCreateData1[num1]);
        for (int num1 = 0; num1 < vector_CalendarCreateData1.Count; ++num1)
          {
          }
      }


    private void  fromJSONVariableRequested(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field VariableRequested of CreateCalendarRequestInformationCommandJSON is not a string.");
        TypeVariableRequested the_open_enum = new TypeVariableRequested();
        switch (json_string.getData()[0])
          {
            case 'S':
                if (String.Compare(json_string.getData(), 1, "tart", 0, 4, false) == 0)
                  {
                    switch (json_string.getData()[5])
                      {
                        case 'D':
                            if ((String.Compare(json_string.getData(), 6, "ate", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeVariableRequestedKnownValues.VariableRequested_StartDate;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'T':
                            if ((String.Compare(json_string.getData(), 6, "ime", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeVariableRequestedKnownValues.VariableRequested_StartTime;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "itle", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeVariableRequestedKnownValues.VariableRequested_Title;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "ndefined", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeVariableRequestedKnownValues.VariableRequested_Undefined;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setVariableRequested(the_open_enum);
      }


    private void  fromJSONStartCreateCalendarItem(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StartCreateCalendarItem of CreateCalendarRequestInformationCommandJSON is not true for false.");
              }
          }
        setStartCreateCalendarItem(the_bool);
      }


    private void  fromJSONUserDoesNotKnowLastVariableRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserDoesNotKnowLastVariableRequested of CreateCalendarRequestInformationCommandJSON is not true for false.");
              }
          }
        setUserDoesNotKnowLastVariableRequested(the_bool);
      }


    private void  fromJSONUserDesiresLastVariableRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserDesiresLastVariableRequested of CreateCalendarRequestInformationCommandJSON is not true for false.");
              }
          }
        setUserDesiresLastVariableRequested(the_bool);
      }


    private void  fromJSONUserIsConfused(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserIsConfused of CreateCalendarRequestInformationCommandJSON is not true for false.");
              }
          }
        setUserIsConfused(the_bool);
      }


    private void  fromJSONLastResponseNotUnderstood(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field LastResponseNotUnderstood of CreateCalendarRequestInformationCommandJSON is not true for false.");
              }
          }
        setLastResponseNotUnderstood(the_bool);
      }


    private void  fromJSONLastResponseUnderstandingStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LastResponseUnderstandingStatus of CreateCalendarRequestInformationCommandJSON is not a string.");
        TypeLastResponseUnderstandingStatus the_open_enum = new TypeLastResponseUnderstandingStatus();
        switch (json_string.getData()[0])
          {
            case 'A':
                if (String.Compare(json_string.getData(), 1, "ttendee", 0, 7, false) == 0)
                  {
                    switch (json_string.getData()[8])
                      {
                        case 'E':
                            if ((String.Compare(json_string.getData(), 9, "mailNotUnderstood", 0, 17, false) == 0) && (json_string.getData().Length == 26))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_AttendeeEmailNotUnderstood;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'N':
                            if ((String.Compare(json_string.getData(), 9, "otUnderstood", 0, 12, false) == 0) && (json_string.getData().Length == 21))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_AttendeeNotUnderstood;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ateNotUnderstood", 0, 16, false) == 0) && (json_string.getData().Length == 17))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_DateNotUnderstood;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "omethingElseNotUnderstood", 0, 25, false) == 0) && (json_string.getData().Length == 26))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_SomethingElseNotUnderstood;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "imeNotUnderstood", 0, 16, false) == 0) && (json_string.getData().Length == 17))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_TimeNotUnderstood;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nderstood", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_Understood;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setLastResponseUnderstandingStatus(the_open_enum);
      }


    private void  fromJSONConversationStateUsed(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ConversationStateUsed of CreateCalendarRequestInformationCommandJSON is not true for false.");
              }
          }
        setConversationStateUsed(the_bool);
      }


    public CreateCalendarRequestInformationCommandJSON()
      {
        flagHasCalendarCreateData = false;
        flagHasVariableRequested = false;
        flagHasStartCreateCalendarItem = false;
        flagHasUserDoesNotKnowLastVariableRequested = false;
        flagHasUserDesiresLastVariableRequested = false;
        flagHasUserIsConfused = false;
        flagHasLastResponseNotUnderstood = false;
        flagHasLastResponseUnderstandingStatus = false;
        flagHasConversationStateUsed = false;
        storeCalendarCreateData = new List< CalendarCreateDataJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCalendarCommandKind()
      {
        return "CreateCalendarRequestInformationCommand";
      }

    public bool  hasCalendarCreateData()
      {
        return flagHasCalendarCreateData;
      }

    public int  countOfCalendarCreateData()
      {
        Debug.Assert(flagHasCalendarCreateData);
        return storeCalendarCreateData.Count;
      }

    public CalendarCreateDataJSON   elementOfCalendarCreateData(int element_num)
      {
        Debug.Assert(flagHasCalendarCreateData);
        return storeCalendarCreateData[element_num];
      }

    public List< CalendarCreateDataJSON  >  getCalendarCreateData()
      {
        Debug.Assert(flagHasCalendarCreateData);
        return storeCalendarCreateData;
      }

    public bool  hasVariableRequested()
      {
        return flagHasVariableRequested;
      }

    public TypeVariableRequested  getVariableRequested()
      {
        Debug.Assert(flagHasVariableRequested);
        return storeVariableRequested;
      }

    public string  getVariableRequestedAsString()
      {
        TypeVariableRequested result = getVariableRequested();
        if (result.in_known_list)
            return stringFromVariableRequested(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasStartCreateCalendarItem()
      {
        return flagHasStartCreateCalendarItem;
      }

    public bool  getStartCreateCalendarItem()
      {
        Debug.Assert(flagHasStartCreateCalendarItem);
        return storeStartCreateCalendarItem;
      }

    public bool  hasUserDoesNotKnowLastVariableRequested()
      {
        return flagHasUserDoesNotKnowLastVariableRequested;
      }

    public bool  getUserDoesNotKnowLastVariableRequested()
      {
        Debug.Assert(flagHasUserDoesNotKnowLastVariableRequested);
        return storeUserDoesNotKnowLastVariableRequested;
      }

    public bool  hasUserDesiresLastVariableRequested()
      {
        return flagHasUserDesiresLastVariableRequested;
      }

    public bool  getUserDesiresLastVariableRequested()
      {
        Debug.Assert(flagHasUserDesiresLastVariableRequested);
        return storeUserDesiresLastVariableRequested;
      }

    public bool  hasUserIsConfused()
      {
        return flagHasUserIsConfused;
      }

    public bool  getUserIsConfused()
      {
        Debug.Assert(flagHasUserIsConfused);
        return storeUserIsConfused;
      }

    public bool  hasLastResponseNotUnderstood()
      {
        return flagHasLastResponseNotUnderstood;
      }

    public bool  getLastResponseNotUnderstood()
      {
        Debug.Assert(flagHasLastResponseNotUnderstood);
        return storeLastResponseNotUnderstood;
      }

    public bool  hasLastResponseUnderstandingStatus()
      {
        return flagHasLastResponseUnderstandingStatus;
      }

    public TypeLastResponseUnderstandingStatus  getLastResponseUnderstandingStatus()
      {
        Debug.Assert(flagHasLastResponseUnderstandingStatus);
        return storeLastResponseUnderstandingStatus;
      }

    public string  getLastResponseUnderstandingStatusAsString()
      {
        TypeLastResponseUnderstandingStatus result = getLastResponseUnderstandingStatus();
        if (result.in_known_list)
            return stringFromLastResponseUnderstandingStatus(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasConversationStateUsed()
      {
        return flagHasConversationStateUsed;
      }

    public bool  getConversationStateUsed()
      {
        Debug.Assert(flagHasConversationStateUsed);
        return storeConversationStateUsed;
      }


    public virtual int extraCreateCalendarRequestInformationCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCreateCalendarRequestInformationCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCreateCalendarRequestInformationCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCreateCalendarRequestInformationCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCalendarCommandComponentCount()
      {
        int result = 0;
        if (flagHasCalendarCreateData)
            ++result;
        if (flagHasVariableRequested)
            ++result;
        if (flagHasStartCreateCalendarItem)
            ++result;
        if (flagHasUserDoesNotKnowLastVariableRequested)
            ++result;
        if (flagHasUserDesiresLastVariableRequested)
            ++result;
        if (flagHasUserIsConfused)
            ++result;
        if (flagHasLastResponseNotUnderstood)
            ++result;
        if (flagHasLastResponseUnderstandingStatus)
            ++result;
        if (flagHasConversationStateUsed)
            ++result;
        result += extraCreateCalendarRequestInformationCommandComponentCount();
        return result;
      }
    public override string extraCalendarCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCalendarCreateData)
          {
            if (remainder == 0)
                return "CalendarCreateData";
            --remainder;
          }
        if (flagHasVariableRequested)
          {
            if (remainder == 0)
                return "VariableRequested";
            --remainder;
          }
        if (flagHasStartCreateCalendarItem)
          {
            if (remainder == 0)
                return "StartCreateCalendarItem";
            --remainder;
          }
        if (flagHasUserDoesNotKnowLastVariableRequested)
          {
            if (remainder == 0)
                return "UserDoesNotKnowLastVariableRequested";
            --remainder;
          }
        if (flagHasUserDesiresLastVariableRequested)
          {
            if (remainder == 0)
                return "UserDesiresLastVariableRequested";
            --remainder;
          }
        if (flagHasUserIsConfused)
          {
            if (remainder == 0)
                return "UserIsConfused";
            --remainder;
          }
        if (flagHasLastResponseNotUnderstood)
          {
            if (remainder == 0)
                return "LastResponseNotUnderstood";
            --remainder;
          }
        if (flagHasLastResponseUnderstandingStatus)
          {
            if (remainder == 0)
                return "LastResponseUnderstandingStatus";
            --remainder;
          }
        if (flagHasConversationStateUsed)
          {
            if (remainder == 0)
                return "ConversationStateUsed";
            --remainder;
          }
        return extraCreateCalendarRequestInformationCommandComponentKey(remainder);
      }
    public override JSONValue extraCalendarCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCalendarCreateData)
          {
            if (remainder == 0)
                return extraCalendarCreateDataToJSON();
            --remainder;
          }
        if (flagHasVariableRequested)
          {
            if (remainder == 0)
                return extraVariableRequestedToJSON();
            --remainder;
          }
        if (flagHasStartCreateCalendarItem)
          {
            if (remainder == 0)
                return extraStartCreateCalendarItemToJSON();
            --remainder;
          }
        if (flagHasUserDoesNotKnowLastVariableRequested)
          {
            if (remainder == 0)
                return extraUserDoesNotKnowLastVariableRequestedToJSON();
            --remainder;
          }
        if (flagHasUserDesiresLastVariableRequested)
          {
            if (remainder == 0)
                return extraUserDesiresLastVariableRequestedToJSON();
            --remainder;
          }
        if (flagHasUserIsConfused)
          {
            if (remainder == 0)
                return extraUserIsConfusedToJSON();
            --remainder;
          }
        if (flagHasLastResponseNotUnderstood)
          {
            if (remainder == 0)
                return extraLastResponseNotUnderstoodToJSON();
            --remainder;
          }
        if (flagHasLastResponseUnderstandingStatus)
          {
            if (remainder == 0)
                return extraLastResponseUnderstandingStatusToJSON();
            --remainder;
          }
        if (flagHasConversationStateUsed)
          {
            if (remainder == 0)
                return extraConversationStateUsedToJSON();
            --remainder;
          }
        return extraCreateCalendarRequestInformationCommandComponentValue(remainder);
      }
    public override JSONValue extraCalendarCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "lendarCreateData", 0, 16, false) == 0) && (field_name.Length == 18))
                            return (flagHasCalendarCreateData ? extraCalendarCreateDataToJSON() : null);
                        break;
                    case 'o':
                        if ((String.Compare(field_name, 2, "nversationStateUsed", 0, 19, false) == 0) && (field_name.Length == 21))
                            return (flagHasConversationStateUsed ? extraConversationStateUsedToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if (String.Compare(field_name, 1, "astResponse", 0, 11, false) == 0)
                  {
                    switch (field_name[12])
                      {
                        case 'N':
                            if ((String.Compare(field_name, 13, "otUnderstood", 0, 12, false) == 0) && (field_name.Length == 25))
                                return (flagHasLastResponseNotUnderstood ? extraLastResponseNotUnderstoodToJSON() : null);
                            break;
                        case 'U':
                            if ((String.Compare(field_name, 13, "nderstandingStatus", 0, 18, false) == 0) && (field_name.Length == 31))
                                return (flagHasLastResponseUnderstandingStatus ? extraLastResponseUnderstandingStatusToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "tartCreateCalendarItem", 0, 22, false) == 0) && (field_name.Length == 23))
                    return (flagHasStartCreateCalendarItem ? extraStartCreateCalendarItemToJSON() : null);
                break;
            case 'U':
                if (String.Compare(field_name, 1, "ser", 0, 3, false) == 0)
                  {
                    switch (field_name[4])
                      {
                        case 'D':
                            switch (field_name[5])
                              {
                                case 'e':
                                    if ((String.Compare(field_name, 6, "siresLastVariableRequested", 0, 26, false) == 0) && (field_name.Length == 32))
                                        return (flagHasUserDesiresLastVariableRequested ? extraUserDesiresLastVariableRequestedToJSON() : null);
                                    break;
                                case 'o':
                                    if ((String.Compare(field_name, 6, "esNotKnowLastVariableRequested", 0, 30, false) == 0) && (field_name.Length == 36))
                                        return (flagHasUserDoesNotKnowLastVariableRequested ? extraUserDoesNotKnowLastVariableRequestedToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'I':
                            if ((String.Compare(field_name, 5, "sConfused", 0, 9, false) == 0) && (field_name.Length == 14))
                                return (flagHasUserIsConfused ? extraUserIsConfusedToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'V':
                if ((String.Compare(field_name, 1, "ariableRequested", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasVariableRequested ? extraVariableRequestedToJSON() : null);
                break;
            default:
                break;
          }
        return extraCreateCalendarRequestInformationCommandLookup(field_name);
      }

    public void initCalendarCreateData()
      {
        if (flagHasCalendarCreateData)
          {
            for (int num1 = 0; num1 < storeCalendarCreateData.Count; ++num1)
              {
              }
          }
        flagHasCalendarCreateData = true;
        storeCalendarCreateData.Clear();
      }
    public void appendCalendarCreateData(CalendarCreateDataJSON  to_append)
      {
        if (!flagHasCalendarCreateData)
          {
            flagHasCalendarCreateData = true;
            storeCalendarCreateData.Clear();
          }
        Debug.Assert(flagHasCalendarCreateData);
        storeCalendarCreateData.Add(to_append);
      }
    public void unsetCalendarCreateData()
      {
        if (flagHasCalendarCreateData)
          {
            for (int num2 = 0; num2 < storeCalendarCreateData.Count; ++num2)
              {
              }
          }
        flagHasCalendarCreateData = false;
        storeCalendarCreateData.Clear();
      }
    public void setVariableRequested(TypeVariableRequested new_value)
      {
        flagHasVariableRequested = true;
        storeVariableRequested = new_value;
      }
    public void setVariableRequested(string chars)
      {
        TypeVariableRequestedKnownValues known = stringToVariableRequested(chars);
        TypeVariableRequested new_value = new TypeVariableRequested();
        if (known == TypeVariableRequestedKnownValues.VariableRequested__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setVariableRequested(new_value);
      }
    public void setVariableRequested(TypeVariableRequestedKnownValues new_value)
      {
        TypeVariableRequested new_full_value = new TypeVariableRequested();
        Debug.Assert(new_value != TypeVariableRequestedKnownValues.VariableRequested__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setVariableRequested(new_full_value);
      }
    public void unsetVariableRequested()
      {
        flagHasVariableRequested = false;
      }
    public void setStartCreateCalendarItem(bool new_value)
      {
        flagHasStartCreateCalendarItem = true;
        storeStartCreateCalendarItem = new_value;
      }
    public void unsetStartCreateCalendarItem()
      {
        flagHasStartCreateCalendarItem = false;
      }
    public void setUserDoesNotKnowLastVariableRequested(bool new_value)
      {
        flagHasUserDoesNotKnowLastVariableRequested = true;
        storeUserDoesNotKnowLastVariableRequested = new_value;
      }
    public void unsetUserDoesNotKnowLastVariableRequested()
      {
        flagHasUserDoesNotKnowLastVariableRequested = false;
      }
    public void setUserDesiresLastVariableRequested(bool new_value)
      {
        flagHasUserDesiresLastVariableRequested = true;
        storeUserDesiresLastVariableRequested = new_value;
      }
    public void unsetUserDesiresLastVariableRequested()
      {
        flagHasUserDesiresLastVariableRequested = false;
      }
    public void setUserIsConfused(bool new_value)
      {
        flagHasUserIsConfused = true;
        storeUserIsConfused = new_value;
      }
    public void unsetUserIsConfused()
      {
        flagHasUserIsConfused = false;
      }
    public void setLastResponseNotUnderstood(bool new_value)
      {
        flagHasLastResponseNotUnderstood = true;
        storeLastResponseNotUnderstood = new_value;
      }
    public void unsetLastResponseNotUnderstood()
      {
        flagHasLastResponseNotUnderstood = false;
      }
    public void setLastResponseUnderstandingStatus(TypeLastResponseUnderstandingStatus new_value)
      {
        flagHasLastResponseUnderstandingStatus = true;
        storeLastResponseUnderstandingStatus = new_value;
      }
    public void setLastResponseUnderstandingStatus(string chars)
      {
        TypeLastResponseUnderstandingStatusKnownValues known = stringToLastResponseUnderstandingStatus(chars);
        TypeLastResponseUnderstandingStatus new_value = new TypeLastResponseUnderstandingStatus();
        if (known == TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setLastResponseUnderstandingStatus(new_value);
      }
    public void setLastResponseUnderstandingStatus(TypeLastResponseUnderstandingStatusKnownValues new_value)
      {
        TypeLastResponseUnderstandingStatus new_full_value = new TypeLastResponseUnderstandingStatus();
        Debug.Assert(new_value != TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setLastResponseUnderstandingStatus(new_full_value);
      }
    public void unsetLastResponseUnderstandingStatus()
      {
        flagHasLastResponseUnderstandingStatus = false;
      }
    public void setConversationStateUsed(bool new_value)
      {
        flagHasConversationStateUsed = true;
        storeConversationStateUsed = new_value;
      }
    public void unsetConversationStateUsed()
      {
        flagHasConversationStateUsed = false;
      }

    public virtual void extraCreateCalendarRequestInformationCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCreateCalendarRequestInformationCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCreateCalendarRequestInformationCommandLookup(key);
        if (old_field == null)
          {
            extraCreateCalendarRequestInformationCommandAppendPair(key, new_component);
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
            case 'C':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "lendarCreateData", 0, 16, false) == 0) && (key.Length == 18))
                            {
                            fromJSONCalendarCreateData(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "nversationStateUsed", 0, 19, false) == 0) && (key.Length == 21))
                            {
                            fromJSONConversationStateUsed(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if (String.Compare(key, 1, "astResponse", 0, 11, false) == 0)
                  {
                    switch (key[12])
                      {
                        case 'N':
                            if ((String.Compare(key, 13, "otUnderstood", 0, 12, false) == 0) && (key.Length == 25))
                                {
                                fromJSONLastResponseNotUnderstood(new_component, false);
                                return;
                                }
                            break;
                        case 'U':
                            if ((String.Compare(key, 13, "nderstandingStatus", 0, 18, false) == 0) && (key.Length == 31))
                                {
                                fromJSONLastResponseUnderstandingStatus(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tartCreateCalendarItem", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONStartCreateCalendarItem(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if (String.Compare(key, 1, "ser", 0, 3, false) == 0)
                  {
                    switch (key[4])
                      {
                        case 'D':
                            switch (key[5])
                              {
                                case 'e':
                                    if ((String.Compare(key, 6, "siresLastVariableRequested", 0, 26, false) == 0) && (key.Length == 32))
                                        {
                                        fromJSONUserDesiresLastVariableRequested(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'o':
                                    if ((String.Compare(key, 6, "esNotKnowLastVariableRequested", 0, 30, false) == 0) && (key.Length == 36))
                                        {
                                        fromJSONUserDoesNotKnowLastVariableRequested(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'I':
                            if ((String.Compare(key, 5, "sConfused", 0, 9, false) == 0) && (key.Length == 14))
                                {
                                fromJSONUserIsConfused(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'V':
                if ((String.Compare(key, 1, "ariableRequested", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONVariableRequested(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCreateCalendarRequestInformationCommandAppendPair(key, new_component);
      }
    public override void extraCalendarCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "lendarCreateData", 0, 16, false) == 0) && (key.Length == 18))
                            {
                            fromJSONCalendarCreateData(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "nversationStateUsed", 0, 19, false) == 0) && (key.Length == 21))
                            {
                            fromJSONConversationStateUsed(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if (String.Compare(key, 1, "astResponse", 0, 11, false) == 0)
                  {
                    switch (key[12])
                      {
                        case 'N':
                            if ((String.Compare(key, 13, "otUnderstood", 0, 12, false) == 0) && (key.Length == 25))
                                {
                                fromJSONLastResponseNotUnderstood(new_component, false);
                                return;
                                }
                            break;
                        case 'U':
                            if ((String.Compare(key, 13, "nderstandingStatus", 0, 18, false) == 0) && (key.Length == 31))
                                {
                                fromJSONLastResponseUnderstandingStatus(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tartCreateCalendarItem", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONStartCreateCalendarItem(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if (String.Compare(key, 1, "ser", 0, 3, false) == 0)
                  {
                    switch (key[4])
                      {
                        case 'D':
                            switch (key[5])
                              {
                                case 'e':
                                    if ((String.Compare(key, 6, "siresLastVariableRequested", 0, 26, false) == 0) && (key.Length == 32))
                                        {
                                        fromJSONUserDesiresLastVariableRequested(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'o':
                                    if ((String.Compare(key, 6, "esNotKnowLastVariableRequested", 0, 30, false) == 0) && (key.Length == 36))
                                        {
                                        fromJSONUserDoesNotKnowLastVariableRequested(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'I':
                            if ((String.Compare(key, 5, "sConfused", 0, 9, false) == 0) && (key.Length == 14))
                                {
                                fromJSONUserIsConfused(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'V':
                if ((String.Compare(key, 1, "ariableRequested", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONVariableRequested(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCreateCalendarRequestInformationCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCalendarCreateData);
        if (flagHasCalendarCreateData)
          {
            handler.start_pair("CalendarCreateData");
            handler.start_array();
            for (int num1 = 0; num1 < storeCalendarCreateData.Count; ++num1)
              {
                if (partial_allowed)
                    storeCalendarCreateData[num1].write_partial_as_json(handler);
                else
                    storeCalendarCreateData[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasVariableRequested);
        if (flagHasVariableRequested)
          {
            handler.start_pair("VariableRequested");
            if (storeVariableRequested.in_known_list)
              {
                switch (storeVariableRequested.list_value)
                  {
                    case TypeVariableRequestedKnownValues.VariableRequested_Undefined:
                        handler.string_value("Undefined");
                        break;
                    case TypeVariableRequestedKnownValues.VariableRequested_Title:
                        handler.string_value("Title");
                        break;
                    case TypeVariableRequestedKnownValues.VariableRequested_StartDate:
                        handler.string_value("StartDate");
                        break;
                    case TypeVariableRequestedKnownValues.VariableRequested_StartTime:
                        handler.string_value("StartTime");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeVariableRequested.string_value);
              }
          }
        if (flagHasStartCreateCalendarItem)
          {
            handler.start_pair("StartCreateCalendarItem");
            handler.boolean_value(storeStartCreateCalendarItem);
          }
        if (flagHasUserDoesNotKnowLastVariableRequested)
          {
            handler.start_pair("UserDoesNotKnowLastVariableRequested");
            handler.boolean_value(storeUserDoesNotKnowLastVariableRequested);
          }
        if (flagHasUserDesiresLastVariableRequested)
          {
            handler.start_pair("UserDesiresLastVariableRequested");
            handler.boolean_value(storeUserDesiresLastVariableRequested);
          }
        if (flagHasUserIsConfused)
          {
            handler.start_pair("UserIsConfused");
            handler.boolean_value(storeUserIsConfused);
          }
        if (flagHasLastResponseNotUnderstood)
          {
            handler.start_pair("LastResponseNotUnderstood");
            handler.boolean_value(storeLastResponseNotUnderstood);
          }
        if (flagHasLastResponseUnderstandingStatus)
          {
            handler.start_pair("LastResponseUnderstandingStatus");
            if (storeLastResponseUnderstandingStatus.in_known_list)
              {
                switch (storeLastResponseUnderstandingStatus.list_value)
                  {
                    case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_Understood:
                        handler.string_value("Understood");
                        break;
                    case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_DateNotUnderstood:
                        handler.string_value("DateNotUnderstood");
                        break;
                    case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_TimeNotUnderstood:
                        handler.string_value("TimeNotUnderstood");
                        break;
                    case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_AttendeeNotUnderstood:
                        handler.string_value("AttendeeNotUnderstood");
                        break;
                    case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_AttendeeEmailNotUnderstood:
                        handler.string_value("AttendeeEmailNotUnderstood");
                        break;
                    case TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus_SomethingElseNotUnderstood:
                        handler.string_value("SomethingElseNotUnderstood");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeLastResponseUnderstandingStatus.string_value);
              }
          }
        if (flagHasConversationStateUsed)
          {
            handler.start_pair("ConversationStateUsed");
            handler.boolean_value(storeConversationStateUsed);
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
        if (!(hasCalendarCreateData()))
          {
            return "When parsing the object for %what%, the \"CalendarCreateData\" field was missing.";
          }
        if (!(hasVariableRequested()))
          {
            return "When parsing the object for %what%, the \"VariableRequested\" field was missing.";
          }
        return null;
      }

    public static new CreateCalendarRequestInformationCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CreateCalendarRequestInformationCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CreateCalendarRequestInformationCommand", ignore_extras);
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
    public static new CreateCalendarRequestInformationCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CreateCalendarRequestInformationCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CreateCalendarRequestInformationCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CreateCalendarRequestInformationCommand", ignore_extras);
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
    public static new CreateCalendarRequestInformationCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CreateCalendarRequestInformationCommandJSON from_text(string text, bool ignore_extras)
      {
        CreateCalendarRequestInformationCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CreateCalendarRequestInformationCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CreateCalendarRequestInformationCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CreateCalendarRequestInformationCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CreateCalendarRequestInformationCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CreateCalendarRequestInformationCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CalendarCommandJSON.Generator
      {
        private CalendarCreateDataJSON.HoldingArrayGenerator fieldGeneratorCalendarCreateData;
    private abstract class FieldGeneratorVariableRequested : JSONStringGenerator
          {
            protected FieldGeneratorVariableRequested(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorVariableRequested()
              {
              }
            protected override void handle_result(string result)
              {
                TypeVariableRequestedKnownValues known = stringToVariableRequested(result);
                TypeVariableRequested new_value = new TypeVariableRequested();
                if (known == TypeVariableRequestedKnownValues.VariableRequested__none)
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
            protected abstract void handle_result(TypeVariableRequested result);
          };
    private class FieldHoldingGeneratorVariableRequested : FieldGeneratorVariableRequested
  {
    protected override void handle_result(TypeVariableRequested result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorVariableRequested(String what)
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
    public TypeVariableRequested value;
  };
    private class FieldHoldingArrayGeneratorVariableRequested : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorVariableRequested
      {
        private FieldHoldingArrayGeneratorVariableRequested top;

        protected override void handle_result(TypeVariableRequested result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorVariableRequested init_top)
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
    protected virtual void handle_result(List<TypeVariableRequested> result)
      {
      }

    public FieldHoldingArrayGeneratorVariableRequested(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeVariableRequested>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorVariableRequested()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeVariableRequested>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeVariableRequested> value;
  };
        private FieldHoldingGeneratorVariableRequested fieldGeneratorVariableRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorStartCreateCalendarItem;
        private JSONHoldingBooleanGenerator fieldGeneratorUserDoesNotKnowLastVariableRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorUserDesiresLastVariableRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorUserIsConfused;
        private JSONHoldingBooleanGenerator fieldGeneratorLastResponseNotUnderstood;
    private abstract class FieldGeneratorLastResponseUnderstandingStatus : JSONStringGenerator
          {
            protected FieldGeneratorLastResponseUnderstandingStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorLastResponseUnderstandingStatus()
              {
              }
            protected override void handle_result(string result)
              {
                TypeLastResponseUnderstandingStatusKnownValues known = stringToLastResponseUnderstandingStatus(result);
                TypeLastResponseUnderstandingStatus new_value = new TypeLastResponseUnderstandingStatus();
                if (known == TypeLastResponseUnderstandingStatusKnownValues.LastResponseUnderstandingStatus__none)
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
            protected abstract void handle_result(TypeLastResponseUnderstandingStatus result);
          };
    private class FieldHoldingGeneratorLastResponseUnderstandingStatus : FieldGeneratorLastResponseUnderstandingStatus
  {
    protected override void handle_result(TypeLastResponseUnderstandingStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorLastResponseUnderstandingStatus(String what)
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
    public TypeLastResponseUnderstandingStatus value;
  };
    private class FieldHoldingArrayGeneratorLastResponseUnderstandingStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLastResponseUnderstandingStatus
      {
        private FieldHoldingArrayGeneratorLastResponseUnderstandingStatus top;

        protected override void handle_result(TypeLastResponseUnderstandingStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLastResponseUnderstandingStatus init_top)
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
    protected virtual void handle_result(List<TypeLastResponseUnderstandingStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorLastResponseUnderstandingStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLastResponseUnderstandingStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLastResponseUnderstandingStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLastResponseUnderstandingStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLastResponseUnderstandingStatus> value;
  };
        private FieldHoldingGeneratorLastResponseUnderstandingStatus fieldGeneratorLastResponseUnderstandingStatus;
        private JSONHoldingBooleanGenerator fieldGeneratorConversationStateUsed;
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
            if (!(getCalendarCommandJSONKey().Equals("CreateCalendarRequestInformationCommand")))
                throw new Exception("The key field has a value other than `CreateCalendarRequestInformationCommand'.");
            CreateCalendarRequestInformationCommandJSON result = new CreateCalendarRequestInformationCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCreateCalendarRequestInformationCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CalendarCommandJSON new_result)
          {
            handle_result((CreateCalendarRequestInformationCommandJSON )new_result);
          }
        protected void finish(CreateCalendarRequestInformationCommandJSON result)
          {
            if (fieldGeneratorCalendarCreateData.have_value)
              {
                result.initCalendarCreateData();
                int count = fieldGeneratorCalendarCreateData.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCalendarCreateData(fieldGeneratorCalendarCreateData.value[num]);
                  }
                fieldGeneratorCalendarCreateData.value.Clear();
                fieldGeneratorCalendarCreateData.have_value = false;
              }
            else if ((!(result.hasCalendarCreateData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CalendarCreateData\" field was missing.");
              }
            if (fieldGeneratorVariableRequested.have_value)
              {
                result.setVariableRequested(fieldGeneratorVariableRequested.value);
                fieldGeneratorVariableRequested.have_value = false;
              }
            else if ((!(result.hasVariableRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"VariableRequested\" field was missing.");
              }
            if (fieldGeneratorStartCreateCalendarItem.have_value)
              {
                result.setStartCreateCalendarItem(fieldGeneratorStartCreateCalendarItem.value);
                fieldGeneratorStartCreateCalendarItem.have_value = false;
              }
            if (fieldGeneratorUserDoesNotKnowLastVariableRequested.have_value)
              {
                result.setUserDoesNotKnowLastVariableRequested(fieldGeneratorUserDoesNotKnowLastVariableRequested.value);
                fieldGeneratorUserDoesNotKnowLastVariableRequested.have_value = false;
              }
            if (fieldGeneratorUserDesiresLastVariableRequested.have_value)
              {
                result.setUserDesiresLastVariableRequested(fieldGeneratorUserDesiresLastVariableRequested.value);
                fieldGeneratorUserDesiresLastVariableRequested.have_value = false;
              }
            if (fieldGeneratorUserIsConfused.have_value)
              {
                result.setUserIsConfused(fieldGeneratorUserIsConfused.value);
                fieldGeneratorUserIsConfused.have_value = false;
              }
            if (fieldGeneratorLastResponseNotUnderstood.have_value)
              {
                result.setLastResponseNotUnderstood(fieldGeneratorLastResponseNotUnderstood.value);
                fieldGeneratorLastResponseNotUnderstood.have_value = false;
              }
            if (fieldGeneratorLastResponseUnderstandingStatus.have_value)
              {
                result.setLastResponseUnderstandingStatus(fieldGeneratorLastResponseUnderstandingStatus.value);
                fieldGeneratorLastResponseUnderstandingStatus.have_value = false;
              }
            if (fieldGeneratorConversationStateUsed.have_value)
              {
                result.setConversationStateUsed(fieldGeneratorConversationStateUsed.value);
                fieldGeneratorConversationStateUsed.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(CreateCalendarRequestInformationCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "lendarCreateData", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorCalendarCreateData;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "nversationStateUsed", 0, 19, false) == 0) && (field_name.Length == 21))
                                return fieldGeneratorConversationStateUsed;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "astResponse", 0, 11, false) == 0)
                      {
                        switch (field_name[12])
                          {
                            case 'N':
                                if ((String.Compare(field_name, 13, "otUnderstood", 0, 12, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorLastResponseNotUnderstood;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 13, "nderstandingStatus", 0, 18, false) == 0) && (field_name.Length == 31))
                                    return fieldGeneratorLastResponseUnderstandingStatus;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tartCreateCalendarItem", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorStartCreateCalendarItem;
                    break;
                case 'U':
                    if (String.Compare(field_name, 1, "ser", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'D':
                                switch (field_name[5])
                                  {
                                    case 'e':
                                        if ((String.Compare(field_name, 6, "siresLastVariableRequested", 0, 26, false) == 0) && (field_name.Length == 32))
                                            return fieldGeneratorUserDesiresLastVariableRequested;
                                        break;
                                    case 'o':
                                        if ((String.Compare(field_name, 6, "esNotKnowLastVariableRequested", 0, 30, false) == 0) && (field_name.Length == 36))
                                            return fieldGeneratorUserDoesNotKnowLastVariableRequested;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 5, "sConfused", 0, 9, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorUserIsConfused;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "ariableRequested", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorVariableRequested;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCalendarCreateData = new CalendarCreateDataJSON.HoldingArrayGenerator("field \"CalendarCreateData\" of the CreateCalendarRequestInformationCommand class", ignore_extras);
            fieldGeneratorVariableRequested = new FieldHoldingGeneratorVariableRequested("field \"VariableRequested\" of the CreateCalendarRequestInformationCommand class");
            fieldGeneratorStartCreateCalendarItem = new JSONHoldingBooleanGenerator("field \"StartCreateCalendarItem\" of the CreateCalendarRequestInformationCommand class");
            fieldGeneratorUserDoesNotKnowLastVariableRequested = new JSONHoldingBooleanGenerator("field \"UserDoesNotKnowLastVariableRequested\" of the CreateCalendarRequestInformationCommand class");
            fieldGeneratorUserDesiresLastVariableRequested = new JSONHoldingBooleanGenerator("field \"UserDesiresLastVariableRequested\" of the CreateCalendarRequestInformationCommand class");
            fieldGeneratorUserIsConfused = new JSONHoldingBooleanGenerator("field \"UserIsConfused\" of the CreateCalendarRequestInformationCommand class");
            fieldGeneratorLastResponseNotUnderstood = new JSONHoldingBooleanGenerator("field \"LastResponseNotUnderstood\" of the CreateCalendarRequestInformationCommand class");
            fieldGeneratorLastResponseUnderstandingStatus = new FieldHoldingGeneratorLastResponseUnderstandingStatus("field \"LastResponseUnderstandingStatus\" of the CreateCalendarRequestInformationCommand class");
            fieldGeneratorConversationStateUsed = new JSONHoldingBooleanGenerator("field \"ConversationStateUsed\" of the CreateCalendarRequestInformationCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CreateCalendarRequestInformationCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCalendarCreateData = new CalendarCreateDataJSON.HoldingArrayGenerator("field \"CalendarCreateData\" of the CreateCalendarRequestInformationCommand class", false);
            fieldGeneratorVariableRequested = new FieldHoldingGeneratorVariableRequested("field \"VariableRequested\" of the CreateCalendarRequestInformationCommand class");
            fieldGeneratorStartCreateCalendarItem = new JSONHoldingBooleanGenerator("field \"StartCreateCalendarItem\" of the CreateCalendarRequestInformationCommand class");
            fieldGeneratorUserDoesNotKnowLastVariableRequested = new JSONHoldingBooleanGenerator("field \"UserDoesNotKnowLastVariableRequested\" of the CreateCalendarRequestInformationCommand class");
            fieldGeneratorUserDesiresLastVariableRequested = new JSONHoldingBooleanGenerator("field \"UserDesiresLastVariableRequested\" of the CreateCalendarRequestInformationCommand class");
            fieldGeneratorUserIsConfused = new JSONHoldingBooleanGenerator("field \"UserIsConfused\" of the CreateCalendarRequestInformationCommand class");
            fieldGeneratorLastResponseNotUnderstood = new JSONHoldingBooleanGenerator("field \"LastResponseNotUnderstood\" of the CreateCalendarRequestInformationCommand class");
            fieldGeneratorLastResponseUnderstandingStatus = new FieldHoldingGeneratorLastResponseUnderstandingStatus("field \"LastResponseUnderstandingStatus\" of the CreateCalendarRequestInformationCommand class");
            fieldGeneratorConversationStateUsed = new JSONHoldingBooleanGenerator("field \"ConversationStateUsed\" of the CreateCalendarRequestInformationCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CreateCalendarRequestInformationCommand class");
          }

        public override void reset()
          {
            fieldGeneratorCalendarCreateData.reset();
            fieldGeneratorVariableRequested.reset();
            fieldGeneratorStartCreateCalendarItem.reset();
            fieldGeneratorUserDoesNotKnowLastVariableRequested.reset();
            fieldGeneratorUserDesiresLastVariableRequested.reset();
            fieldGeneratorUserIsConfused.reset();
            fieldGeneratorLastResponseNotUnderstood.reset();
            fieldGeneratorLastResponseUnderstandingStatus.reset();
            fieldGeneratorConversationStateUsed.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CreateCalendarRequestInformationCommandJSON  result)
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
        public CreateCalendarRequestInformationCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CreateCalendarRequestInformationCommandJSON  result)
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
    protected virtual void handle_result(List<CreateCalendarRequestInformationCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CreateCalendarRequestInformationCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CreateCalendarRequestInformationCommandJSON>();
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
    public List<CreateCalendarRequestInformationCommandJSON> value;
  };
  };
