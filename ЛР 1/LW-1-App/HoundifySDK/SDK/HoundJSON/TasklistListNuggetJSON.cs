/* file "TasklistListNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TasklistListNuggetJSON : InformationNuggetJSON
  {
    public enum TypeActionKnownValues
      {
        Action_Create,
        Action_Enumerate,
        Action_Clear,
        Action_ClearConfirm,
        Action_ClearCancel,
        Action_Delete,
        Action_DeleteConfirm,
        Action_DeleteCancel,
        Action__none
      };
    public struct TypeAction
      {
        public bool in_known_list;
        public string string_value;
        public TypeActionKnownValues list_value;
      };

    public static TypeActionKnownValues  stringToAction(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                switch (chars[1])
                  {
                    case 'l':
                        if (String.Compare(chars, 2, "ear", 0, 3, false) == 0)
                          {
                            if (chars.Length == 5)
                              {
                                return TypeActionKnownValues.Action_Clear;
                              }
                            switch (chars[5])
                              {
                                case 'C':
                                    switch (chars[6])
                                      {
                                        case 'a':
                                            if ((String.Compare(chars, 7, "ncel", 0, 4, false) == 0) && (chars.Length == 11))
                                                return TypeActionKnownValues.Action_ClearCancel;
                                            break;
                                        case 'o':
                                            if ((String.Compare(chars, 7, "nfirm", 0, 5, false) == 0) && (chars.Length == 12))
                                                return TypeActionKnownValues.Action_ClearConfirm;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "eate", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeActionKnownValues.Action_Create;
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if (String.Compare(chars, 1, "elete", 0, 5, false) == 0)
                  {
                    if (chars.Length == 6)
                      {
                        return TypeActionKnownValues.Action_Delete;
                      }
                    switch (chars[6])
                      {
                        case 'C':
                            switch (chars[7])
                              {
                                case 'a':
                                    if ((String.Compare(chars, 8, "ncel", 0, 4, false) == 0) && (chars.Length == 12))
                                        return TypeActionKnownValues.Action_DeleteCancel;
                                    break;
                                case 'o':
                                    if ((String.Compare(chars, 8, "nfirm", 0, 5, false) == 0) && (chars.Length == 13))
                                        return TypeActionKnownValues.Action_DeleteConfirm;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if ((String.Compare(chars, 1, "numerate", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeActionKnownValues.Action_Enumerate;
                break;
            default:
                break;
          }
        return TypeActionKnownValues.Action__none;
      }

    public static string  stringFromAction(TypeActionKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeActionKnownValues.Action_Create:
                return "Create";
            case TypeActionKnownValues.Action_Enumerate:
                return "Enumerate";
            case TypeActionKnownValues.Action_Clear:
                return "Clear";
            case TypeActionKnownValues.Action_ClearConfirm:
                return "ClearConfirm";
            case TypeActionKnownValues.Action_ClearCancel:
                return "ClearCancel";
            case TypeActionKnownValues.Action_Delete:
                return "Delete";
            case TypeActionKnownValues.Action_DeleteConfirm:
                return "DeleteConfirm";
            case TypeActionKnownValues.Action_DeleteCancel:
                return "DeleteCancel";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasAction;
    private TypeAction storeAction;
    private bool flagHasListName;
    private string storeListName;
    private bool flagHasResult;
    private TasklistListResultJSON  storeResult;
    private bool flagHasEntries;
    private List< string > storeEntries;
    private bool flagHasErrorType;
    private TasklistErrorTypeJSON  storeErrorType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraActionToJSON()
      {
        JSONStringValue generated_string_Action;
        if (!(storeAction.in_known_list))
          {
        generated_string_Action = new JSONStringValue(storeAction.string_value);
          }
        else
          {
        switch (storeAction.list_value)
          {
            case TypeActionKnownValues.Action_Create:
                generated_string_Action = new JSONStringValue("Create");
                break;
            case TypeActionKnownValues.Action_Enumerate:
                generated_string_Action = new JSONStringValue("Enumerate");
                break;
            case TypeActionKnownValues.Action_Clear:
                generated_string_Action = new JSONStringValue("Clear");
                break;
            case TypeActionKnownValues.Action_ClearConfirm:
                generated_string_Action = new JSONStringValue("ClearConfirm");
                break;
            case TypeActionKnownValues.Action_ClearCancel:
                generated_string_Action = new JSONStringValue("ClearCancel");
                break;
            case TypeActionKnownValues.Action_Delete:
                generated_string_Action = new JSONStringValue("Delete");
                break;
            case TypeActionKnownValues.Action_DeleteConfirm:
                generated_string_Action = new JSONStringValue("DeleteConfirm");
                break;
            case TypeActionKnownValues.Action_DeleteCancel:
                generated_string_Action = new JSONStringValue("DeleteCancel");
                break;
            default:
                Debug.Assert(false);
                generated_string_Action = null;
                break;
          }
          }
        return generated_string_Action;
      }

    private JSONValue  extraListNameToJSON()
      {
        JSONStringValue generated_string_ListName = new JSONStringValue(storeListName);
        return generated_string_ListName;
      }

    private JSONValue  extraResultToJSON()
      {
        JSONValueHandler handler_Result = new JSONValueHandler();
        storeResult.write_as_json(handler_Result);
        return handler_Result.result;
      }

    private JSONValue  extraEntriesToJSON()
      {
        JSONArrayValue generated_array_1_Entries = new JSONArrayValue();
        for (int num1 = 0; num1 < storeEntries.Count; ++num1)
          {
            JSONStringValue generated_string_Entries = new JSONStringValue(storeEntries[num1]);
            generated_array_1_Entries.appendComponent(generated_string_Entries);
          }
        return generated_array_1_Entries;
      }

    private JSONValue  extraErrorTypeToJSON()
      {
        JSONValueHandler handler_ErrorType = new JSONValueHandler();
        storeErrorType.write_as_json(handler_ErrorType);
        return handler_ErrorType.result;
      }


    private void  fromJSONAction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Action of TasklistListNuggetJSON is not a string.");
        TypeAction the_open_enum = new TypeAction();
        switch (json_string.getData()[0])
          {
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        if (String.Compare(json_string.getData(), 2, "ear", 0, 3, false) == 0)
                          {
                            if (json_string.getData().Length == 5)
                              {
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeActionKnownValues.Action_Clear;
                                    goto open_enum_is_done;
                                  }
                              }
                            switch (json_string.getData()[5])
                              {
                                case 'C':
                                    switch (json_string.getData()[6])
                                      {
                                        case 'a':
                                            if ((String.Compare(json_string.getData(), 7, "ncel", 0, 4, false) == 0) && (json_string.getData().Length == 11))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeActionKnownValues.Action_ClearCancel;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'o':
                                            if ((String.Compare(json_string.getData(), 7, "nfirm", 0, 5, false) == 0) && (json_string.getData().Length == 12))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeActionKnownValues.Action_ClearConfirm;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "eate", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeActionKnownValues.Action_Create;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if (String.Compare(json_string.getData(), 1, "elete", 0, 5, false) == 0)
                  {
                    if (json_string.getData().Length == 6)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeActionKnownValues.Action_Delete;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[6])
                      {
                        case 'C':
                            switch (json_string.getData()[7])
                              {
                                case 'a':
                                    if ((String.Compare(json_string.getData(), 8, "ncel", 0, 4, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeActionKnownValues.Action_DeleteCancel;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'o':
                                    if ((String.Compare(json_string.getData(), 8, "nfirm", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeActionKnownValues.Action_DeleteConfirm;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "numerate", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeActionKnownValues.Action_Enumerate;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setAction(the_open_enum);
      }


    private void  fromJSONListName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ListName of TasklistListNuggetJSON is not a string.");
        setListName(json_string.getData());
      }


    private void  fromJSONResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TasklistListResultJSON convert_classy = TasklistListResultJSON.from_json(json_value, ignore_extras, true);
        setResult(convert_classy);
      }


    private void  fromJSONEntries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Entries of TasklistListNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Entries1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Entries of TasklistListNuggetJSON is not a string.");
            vector_Entries1.Add(json_string.getData());
          }
        initEntries();
        for (int num1 = 0; num1 < vector_Entries1.Count; ++num1)
            appendEntries(vector_Entries1[num1]);
        for (int num1 = 0; num1 < vector_Entries1.Count; ++num1)
          {
          }
      }


    private void  fromJSONErrorType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TasklistErrorTypeJSON convert_classy = TasklistErrorTypeJSON.from_json(json_value, ignore_extras, true);
        setErrorType(convert_classy);
      }


    public TasklistListNuggetJSON()
      {
        flagHasAction = false;
        flagHasListName = false;
        flagHasResult = false;
        flagHasEntries = false;
        flagHasErrorType = false;
        storeEntries = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "TasklistListNugget";
      }

    public bool  hasAction()
      {
        return flagHasAction;
      }

    public TypeAction  getAction()
      {
        Debug.Assert(flagHasAction);
        return storeAction;
      }

    public string  getActionAsString()
      {
        TypeAction result = getAction();
        if (result.in_known_list)
            return stringFromAction(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasListName()
      {
        return flagHasListName;
      }

    public string  getListName()
      {
        Debug.Assert(flagHasListName);
        return storeListName;
      }

    public bool  hasResult()
      {
        return flagHasResult;
      }

    public TasklistListResultJSON   getResult()
      {
        Debug.Assert(flagHasResult);
        return storeResult;
      }

    public TasklistListResultJSON.TypeValue  getResultValue()
      {
        return getResult().getValue();
      }

    public string  getResultAsString()
      {
        return getResult().getValueAsString();
      }

    public bool  hasEntries()
      {
        return flagHasEntries;
      }

    public int  countOfEntries()
      {
        Debug.Assert(flagHasEntries);
        return storeEntries.Count;
      }

    public string  elementOfEntries(int element_num)
      {
        Debug.Assert(flagHasEntries);
        return storeEntries[element_num];
      }

    public List< string >  getEntries()
      {
        Debug.Assert(flagHasEntries);
        return storeEntries;
      }

    public bool  hasErrorType()
      {
        return flagHasErrorType;
      }

    public TasklistErrorTypeJSON   getErrorType()
      {
        Debug.Assert(flagHasErrorType);
        return storeErrorType;
      }

    public TasklistErrorTypeJSON.TypeValue  getErrorTypeValue()
      {
        return getErrorType().getValue();
      }

    public string  getErrorTypeAsString()
      {
        return getErrorType().getValueAsString();
      }


    public virtual int extraTasklistListNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTasklistListNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTasklistListNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTasklistListNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasAction)
            ++result;
        if (flagHasListName)
            ++result;
        if (flagHasResult)
            ++result;
        if (flagHasEntries)
            ++result;
        if (flagHasErrorType)
            ++result;
        result += extraTasklistListNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAction)
          {
            if (remainder == 0)
                return "Action";
            --remainder;
          }
        if (flagHasListName)
          {
            if (remainder == 0)
                return "ListName";
            --remainder;
          }
        if (flagHasResult)
          {
            if (remainder == 0)
                return "Result";
            --remainder;
          }
        if (flagHasEntries)
          {
            if (remainder == 0)
                return "Entries";
            --remainder;
          }
        if (flagHasErrorType)
          {
            if (remainder == 0)
                return "ErrorType";
            --remainder;
          }
        return extraTasklistListNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAction)
          {
            if (remainder == 0)
                return extraActionToJSON();
            --remainder;
          }
        if (flagHasListName)
          {
            if (remainder == 0)
                return extraListNameToJSON();
            --remainder;
          }
        if (flagHasResult)
          {
            if (remainder == 0)
                return extraResultToJSON();
            --remainder;
          }
        if (flagHasEntries)
          {
            if (remainder == 0)
                return extraEntriesToJSON();
            --remainder;
          }
        if (flagHasErrorType)
          {
            if (remainder == 0)
                return extraErrorTypeToJSON();
            --remainder;
          }
        return extraTasklistListNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "ction", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasAction ? extraActionToJSON() : null);
                break;
            case 'E':
                switch (field_name[1])
                  {
                    case 'n':
                        if ((String.Compare(field_name, 2, "tries", 0, 5, false) == 0) && (field_name.Length == 7))
                            return (flagHasEntries ? extraEntriesToJSON() : null);
                        break;
                    case 'r':
                        if ((String.Compare(field_name, 2, "rorType", 0, 7, false) == 0) && (field_name.Length == 9))
                            return (flagHasErrorType ? extraErrorTypeToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "istName", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasListName ? extraListNameToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "esult", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasResult ? extraResultToJSON() : null);
                break;
            default:
                break;
          }
        return extraTasklistListNuggetLookup(field_name);
      }

    public void setAction(TypeAction new_value)
      {
        flagHasAction = true;
        storeAction = new_value;
      }
    public void setAction(string chars)
      {
        TypeActionKnownValues known = stringToAction(chars);
        TypeAction new_value = new TypeAction();
        if (known == TypeActionKnownValues.Action__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setAction(new_value);
      }
    public void setAction(TypeActionKnownValues new_value)
      {
        TypeAction new_full_value = new TypeAction();
        Debug.Assert(new_value != TypeActionKnownValues.Action__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setAction(new_full_value);
      }
    public void unsetAction()
      {
        flagHasAction = false;
      }
    public void setListName(string new_value)
      {
        flagHasListName = true;
        storeListName = new_value;
      }
    public void unsetListName()
      {
        flagHasListName = false;
      }
    public void setResult(TasklistListResultJSON  new_value)
      {
        if (flagHasResult)
          {
          }
        flagHasResult = true;
        storeResult = new_value;
      }
    public void setResult(TasklistListResultJSON.TypeValue new_value)
      {
        setResult(new TasklistListResultJSON(new_value));
      }
    public void setResult(string chars)
      {
        TasklistListResultJSON.TypeValueKnownValues known = TasklistListResultJSON.stringToValue(chars);
        TasklistListResultJSON.TypeValue new_value = new TasklistListResultJSON.TypeValue();
        if (known == TasklistListResultJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setResult(new_value);
      }
    public void unsetResult()
      {
        if (flagHasResult)
          {
          }
        flagHasResult = false;
      }
    public void initEntries()
      {
        flagHasEntries = true;
        storeEntries.Clear();
      }
    public void appendEntries(string to_append)
      {
        if (!flagHasEntries)
          {
            flagHasEntries = true;
            storeEntries.Clear();
          }
        Debug.Assert(flagHasEntries);
        storeEntries.Add(to_append);
      }
    public void unsetEntries()
      {
        flagHasEntries = false;
        storeEntries.Clear();
      }
    public void setErrorType(TasklistErrorTypeJSON  new_value)
      {
        if (flagHasErrorType)
          {
          }
        flagHasErrorType = true;
        storeErrorType = new_value;
      }
    public void setErrorType(TasklistErrorTypeJSON.TypeValue new_value)
      {
        setErrorType(new TasklistErrorTypeJSON(new_value));
      }
    public void setErrorType(string chars)
      {
        TasklistErrorTypeJSON.TypeValueKnownValues known = TasklistErrorTypeJSON.stringToValue(chars);
        TasklistErrorTypeJSON.TypeValue new_value = new TasklistErrorTypeJSON.TypeValue();
        if (known == TasklistErrorTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setErrorType(new_value);
      }
    public void unsetErrorType()
      {
        if (flagHasErrorType)
          {
          }
        flagHasErrorType = false;
      }

    public virtual void extraTasklistListNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTasklistListNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTasklistListNuggetLookup(key);
        if (old_field == null)
          {
            extraTasklistListNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ction", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONAction(new_component, false);
                    return;
                    }
                break;
            case 'E':
                switch (key[1])
                  {
                    case 'n':
                        if ((String.Compare(key, 2, "tries", 0, 5, false) == 0) && (key.Length == 7))
                            {
                            fromJSONEntries(new_component, false);
                            return;
                            }
                        break;
                    case 'r':
                        if ((String.Compare(key, 2, "rorType", 0, 7, false) == 0) && (key.Length == 9))
                            {
                            fromJSONErrorType(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(key, 1, "istName", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONListName(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "esult", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONResult(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraTasklistListNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ction", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONAction(new_component, false);
                    return;
                    }
                break;
            case 'E':
                switch (key[1])
                  {
                    case 'n':
                        if ((String.Compare(key, 2, "tries", 0, 5, false) == 0) && (key.Length == 7))
                            {
                            fromJSONEntries(new_component, false);
                            return;
                            }
                        break;
                    case 'r':
                        if ((String.Compare(key, 2, "rorType", 0, 7, false) == 0) && (key.Length == 9))
                            {
                            fromJSONErrorType(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(key, 1, "istName", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONListName(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "esult", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONResult(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraTasklistListNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasAction);
        if (flagHasAction)
          {
            handler.start_pair("Action");
            if (storeAction.in_known_list)
              {
                switch (storeAction.list_value)
                  {
                    case TypeActionKnownValues.Action_Create:
                        handler.string_value("Create");
                        break;
                    case TypeActionKnownValues.Action_Enumerate:
                        handler.string_value("Enumerate");
                        break;
                    case TypeActionKnownValues.Action_Clear:
                        handler.string_value("Clear");
                        break;
                    case TypeActionKnownValues.Action_ClearConfirm:
                        handler.string_value("ClearConfirm");
                        break;
                    case TypeActionKnownValues.Action_ClearCancel:
                        handler.string_value("ClearCancel");
                        break;
                    case TypeActionKnownValues.Action_Delete:
                        handler.string_value("Delete");
                        break;
                    case TypeActionKnownValues.Action_DeleteConfirm:
                        handler.string_value("DeleteConfirm");
                        break;
                    case TypeActionKnownValues.Action_DeleteCancel:
                        handler.string_value("DeleteCancel");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeAction.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasListName);
        if (flagHasListName)
          {
            handler.start_pair("ListName");
            handler.string_value(storeListName);
          }
        Debug.Assert(partial_allowed || flagHasResult);
        if (flagHasResult)
          {
            handler.start_pair("Result");
            if (partial_allowed)
                storeResult.write_partial_as_json(handler);
            else
                storeResult.write_as_json(handler);
          }
        if (flagHasEntries)
          {
            handler.start_pair("Entries");
            handler.start_array();
            for (int num1 = 0; num1 < storeEntries.Count; ++num1)
              {
                handler.string_value(storeEntries[num1]);
              }
            handler.finish_array();
          }
        if (flagHasErrorType)
          {
            handler.start_pair("ErrorType");
            if (partial_allowed)
                storeErrorType.write_partial_as_json(handler);
            else
                storeErrorType.write_as_json(handler);
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
        if (!(hasAction()))
          {
            return "When parsing the object for %what%, the \"Action\" field was missing.";
          }
        if (!(hasListName()))
          {
            return "When parsing the object for %what%, the \"ListName\" field was missing.";
          }
        if (!(hasResult()))
          {
            return "When parsing the object for %what%, the \"Result\" field was missing.";
          }
        return null;
      }

    public static new TasklistListNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TasklistListNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistListNugget", ignore_extras);
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
    public static new TasklistListNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TasklistListNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TasklistListNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistListNugget", ignore_extras);
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
    public static new TasklistListNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TasklistListNuggetJSON from_text(string text, bool ignore_extras)
      {
        TasklistListNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistListNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TasklistListNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TasklistListNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TasklistListNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistListNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
    private abstract class FieldGeneratorAction : JSONStringGenerator
          {
            protected FieldGeneratorAction(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorAction()
              {
              }
            protected override void handle_result(string result)
              {
                TypeActionKnownValues known = stringToAction(result);
                TypeAction new_value = new TypeAction();
                if (known == TypeActionKnownValues.Action__none)
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
            protected abstract void handle_result(TypeAction result);
          };
    private class FieldHoldingGeneratorAction : FieldGeneratorAction
  {
    protected override void handle_result(TypeAction result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorAction(String what)
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
    public TypeAction value;
  };
    private class FieldHoldingArrayGeneratorAction : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorAction
      {
        private FieldHoldingArrayGeneratorAction top;

        protected override void handle_result(TypeAction result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorAction init_top)
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
    protected virtual void handle_result(List<TypeAction> result)
      {
      }

    public FieldHoldingArrayGeneratorAction(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAction>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorAction()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAction>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeAction> value;
  };
        private FieldHoldingGeneratorAction fieldGeneratorAction;
        private JSONHoldingStringGenerator fieldGeneratorListName;
        private TasklistListResultJSON.HoldingGenerator fieldGeneratorResult;
        private JSONHoldingStringArrayGenerator fieldGeneratorEntries;
        private TasklistErrorTypeJSON.HoldingGenerator fieldGeneratorErrorType;
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
            if (!(getInformationNuggetJSONKey().Equals("TasklistListNugget")))
                throw new Exception("The key field has a value other than `TasklistListNugget'.");
            TasklistListNuggetJSON result = new TasklistListNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTasklistListNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((TasklistListNuggetJSON )new_result);
          }
        protected void finish(TasklistListNuggetJSON result)
          {
            if (fieldGeneratorAction.have_value)
              {
                result.setAction(fieldGeneratorAction.value);
                fieldGeneratorAction.have_value = false;
              }
            else if ((!(result.hasAction())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Action\" field was missing.");
              }
            if (fieldGeneratorListName.have_value)
              {
                result.setListName(fieldGeneratorListName.value);
                fieldGeneratorListName.have_value = false;
              }
            else if ((!(result.hasListName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ListName\" field was missing.");
              }
            if (fieldGeneratorResult.have_value)
              {
                result.setResult(fieldGeneratorResult.value);
                fieldGeneratorResult.have_value = false;
              }
            else if ((!(result.hasResult())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Result\" field was missing.");
              }
            if (fieldGeneratorEntries.have_value)
              {
                result.initEntries();
                int count = fieldGeneratorEntries.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendEntries(fieldGeneratorEntries.value[num]);
                  }
                fieldGeneratorEntries.value.Clear();
                fieldGeneratorEntries.have_value = false;
              }
            if (fieldGeneratorErrorType.have_value)
              {
                result.setErrorType(fieldGeneratorErrorType.value);
                fieldGeneratorErrorType.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(TasklistListNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ction", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorAction;
                    break;
                case 'E':
                    switch (field_name[1])
                      {
                        case 'n':
                            if ((String.Compare(field_name, 2, "tries", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorEntries;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "rorType", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorErrorType;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "istName", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorListName;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "esult", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorResult;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAction = new FieldHoldingGeneratorAction("field \"Action\" of the TasklistListNugget class");
            fieldGeneratorListName = new JSONHoldingStringGenerator("field \"ListName\" of the TasklistListNugget class");
            fieldGeneratorResult = new TasklistListResultJSON.HoldingGenerator("field \"Result\" of the TasklistListNugget class", ignore_extras);
            fieldGeneratorEntries = new JSONHoldingStringArrayGenerator("field \"Entries\" of the TasklistListNugget class");
            fieldGeneratorErrorType = new TasklistErrorTypeJSON.HoldingGenerator("field \"ErrorType\" of the TasklistListNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TasklistListNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAction = new FieldHoldingGeneratorAction("field \"Action\" of the TasklistListNugget class");
            fieldGeneratorListName = new JSONHoldingStringGenerator("field \"ListName\" of the TasklistListNugget class");
            fieldGeneratorResult = new TasklistListResultJSON.HoldingGenerator("field \"Result\" of the TasklistListNugget class", false);
            fieldGeneratorEntries = new JSONHoldingStringArrayGenerator("field \"Entries\" of the TasklistListNugget class");
            fieldGeneratorErrorType = new TasklistErrorTypeJSON.HoldingGenerator("field \"ErrorType\" of the TasklistListNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TasklistListNugget class");
          }

        public override void reset()
          {
            fieldGeneratorAction.reset();
            fieldGeneratorListName.reset();
            fieldGeneratorResult.reset();
            fieldGeneratorEntries.reset();
            fieldGeneratorErrorType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(TasklistListNuggetJSON  result)
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
        public TasklistListNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TasklistListNuggetJSON  result)
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
    protected virtual void handle_result(List<TasklistListNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TasklistListNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TasklistListNuggetJSON>();
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
    public List<TasklistListNuggetJSON> value;
  };
  };
