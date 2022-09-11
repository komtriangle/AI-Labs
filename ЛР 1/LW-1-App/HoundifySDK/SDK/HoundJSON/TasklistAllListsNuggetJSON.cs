/* file "TasklistAllListsNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TasklistAllListsNuggetJSON : InformationNuggetJSON
  {
    public enum TypeActionKnownValues
      {
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
                if (String.Compare(chars, 1, "lear", 0, 4, false) == 0)
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
    private bool flagHasResult;
    private TasklistAllListsResultJSON  storeResult;
    private bool flagHasListMetas;
    private List< TasklistListMetaJSON  > storeListMetas;
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

    private JSONValue  extraResultToJSON()
      {
        JSONValueHandler handler_Result = new JSONValueHandler();
        storeResult.write_as_json(handler_Result);
        return handler_Result.result;
      }

    private JSONValue  extraListMetasToJSON()
      {
        JSONArrayValue generated_array_1_ListMetas = new JSONArrayValue();
        for (int num1 = 0; num1 < storeListMetas.Count; ++num1)
          {
            JSONValueHandler handler_ListMetas = new JSONValueHandler();
            storeListMetas[num1].write_as_json(handler_ListMetas);
            generated_array_1_ListMetas.appendComponent(handler_ListMetas.result);
          }
        return generated_array_1_ListMetas;
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
            throw new Exception("The value for field Action of TasklistAllListsNuggetJSON is not a string.");
        TypeAction the_open_enum = new TypeAction();
        switch (json_string.getData()[0])
          {
            case 'C':
                if (String.Compare(json_string.getData(), 1, "lear", 0, 4, false) == 0)
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


    private void  fromJSONResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TasklistAllListsResultJSON convert_classy = TasklistAllListsResultJSON.from_json(json_value, ignore_extras, true);
        setResult(convert_classy);
      }


    private void  fromJSONListMetas(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ListMetas of TasklistAllListsNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TasklistListMetaJSON  > vector_ListMetas1 = new List< TasklistListMetaJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TasklistListMetaJSON convert_classy = TasklistListMetaJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ListMetas1.Add(convert_classy);
          }
        initListMetas();
        for (int num1 = 0; num1 < vector_ListMetas1.Count; ++num1)
            appendListMetas(vector_ListMetas1[num1]);
        for (int num1 = 0; num1 < vector_ListMetas1.Count; ++num1)
          {
          }
      }


    private void  fromJSONErrorType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TasklistErrorTypeJSON convert_classy = TasklistErrorTypeJSON.from_json(json_value, ignore_extras, true);
        setErrorType(convert_classy);
      }


    public TasklistAllListsNuggetJSON()
      {
        flagHasAction = false;
        flagHasResult = false;
        flagHasListMetas = false;
        flagHasErrorType = false;
        storeListMetas = new List< TasklistListMetaJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "TasklistAllListsNugget";
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

    public bool  hasResult()
      {
        return flagHasResult;
      }

    public TasklistAllListsResultJSON   getResult()
      {
        Debug.Assert(flagHasResult);
        return storeResult;
      }

    public TasklistAllListsResultJSON.TypeValue  getResultValue()
      {
        return getResult().getValue();
      }

    public string  getResultAsString()
      {
        return getResult().getValueAsString();
      }

    public bool  hasListMetas()
      {
        return flagHasListMetas;
      }

    public int  countOfListMetas()
      {
        Debug.Assert(flagHasListMetas);
        return storeListMetas.Count;
      }

    public TasklistListMetaJSON   elementOfListMetas(int element_num)
      {
        Debug.Assert(flagHasListMetas);
        return storeListMetas[element_num];
      }

    public List< TasklistListMetaJSON  >  getListMetas()
      {
        Debug.Assert(flagHasListMetas);
        return storeListMetas;
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


    public virtual int extraTasklistAllListsNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTasklistAllListsNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTasklistAllListsNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTasklistAllListsNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasAction)
            ++result;
        if (flagHasResult)
            ++result;
        if (flagHasListMetas)
            ++result;
        if (flagHasErrorType)
            ++result;
        result += extraTasklistAllListsNuggetComponentCount();
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
        if (flagHasResult)
          {
            if (remainder == 0)
                return "Result";
            --remainder;
          }
        if (flagHasListMetas)
          {
            if (remainder == 0)
                return "ListMetas";
            --remainder;
          }
        if (flagHasErrorType)
          {
            if (remainder == 0)
                return "ErrorType";
            --remainder;
          }
        return extraTasklistAllListsNuggetComponentKey(remainder);
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
        if (flagHasResult)
          {
            if (remainder == 0)
                return extraResultToJSON();
            --remainder;
          }
        if (flagHasListMetas)
          {
            if (remainder == 0)
                return extraListMetasToJSON();
            --remainder;
          }
        if (flagHasErrorType)
          {
            if (remainder == 0)
                return extraErrorTypeToJSON();
            --remainder;
          }
        return extraTasklistAllListsNuggetComponentValue(remainder);
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
                if ((String.Compare(field_name, 1, "rrorType", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasErrorType ? extraErrorTypeToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "istMetas", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasListMetas ? extraListMetasToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "esult", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasResult ? extraResultToJSON() : null);
                break;
            default:
                break;
          }
        return extraTasklistAllListsNuggetLookup(field_name);
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
    public void setResult(TasklistAllListsResultJSON  new_value)
      {
        if (flagHasResult)
          {
          }
        flagHasResult = true;
        storeResult = new_value;
      }
    public void setResult(TasklistAllListsResultJSON.TypeValue new_value)
      {
        setResult(new TasklistAllListsResultJSON(new_value));
      }
    public void setResult(string chars)
      {
        TasklistAllListsResultJSON.TypeValueKnownValues known = TasklistAllListsResultJSON.stringToValue(chars);
        TasklistAllListsResultJSON.TypeValue new_value = new TasklistAllListsResultJSON.TypeValue();
        if (known == TasklistAllListsResultJSON.TypeValueKnownValues.Value__none)
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
    public void initListMetas()
      {
        if (flagHasListMetas)
          {
            for (int num1 = 0; num1 < storeListMetas.Count; ++num1)
              {
              }
          }
        flagHasListMetas = true;
        storeListMetas.Clear();
      }
    public void appendListMetas(TasklistListMetaJSON  to_append)
      {
        if (!flagHasListMetas)
          {
            flagHasListMetas = true;
            storeListMetas.Clear();
          }
        Debug.Assert(flagHasListMetas);
        storeListMetas.Add(to_append);
      }
    public void unsetListMetas()
      {
        if (flagHasListMetas)
          {
            for (int num2 = 0; num2 < storeListMetas.Count; ++num2)
              {
              }
          }
        flagHasListMetas = false;
        storeListMetas.Clear();
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

    public virtual void extraTasklistAllListsNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTasklistAllListsNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTasklistAllListsNuggetLookup(key);
        if (old_field == null)
          {
            extraTasklistAllListsNuggetAppendPair(key, new_component);
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
                if ((String.Compare(key, 1, "rrorType", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONErrorType(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "istMetas", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONListMetas(new_component, false);
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
        extraTasklistAllListsNuggetAppendPair(key, new_component);
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
                if ((String.Compare(key, 1, "rrorType", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONErrorType(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "istMetas", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONListMetas(new_component, false);
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
        extraTasklistAllListsNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasResult);
        if (flagHasResult)
          {
            handler.start_pair("Result");
            if (partial_allowed)
                storeResult.write_partial_as_json(handler);
            else
                storeResult.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasListMetas);
        if (flagHasListMetas)
          {
            handler.start_pair("ListMetas");
            handler.start_array();
            for (int num1 = 0; num1 < storeListMetas.Count; ++num1)
              {
                if (partial_allowed)
                    storeListMetas[num1].write_partial_as_json(handler);
                else
                    storeListMetas[num1].write_as_json(handler);
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
        if (!(hasResult()))
          {
            return "When parsing the object for %what%, the \"Result\" field was missing.";
          }
        if (!(hasListMetas()))
          {
            return "When parsing the object for %what%, the \"ListMetas\" field was missing.";
          }
        return null;
      }

    public static new TasklistAllListsNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TasklistAllListsNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistAllListsNugget", ignore_extras);
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
    public static new TasklistAllListsNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TasklistAllListsNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TasklistAllListsNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistAllListsNugget", ignore_extras);
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
    public static new TasklistAllListsNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TasklistAllListsNuggetJSON from_text(string text, bool ignore_extras)
      {
        TasklistAllListsNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistAllListsNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TasklistAllListsNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TasklistAllListsNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TasklistAllListsNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistAllListsNugget", ignore_extras);
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
        private TasklistAllListsResultJSON.HoldingGenerator fieldGeneratorResult;
        private TasklistListMetaJSON.HoldingArrayGenerator fieldGeneratorListMetas;
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
            if (!(getInformationNuggetJSONKey().Equals("TasklistAllListsNugget")))
                throw new Exception("The key field has a value other than `TasklistAllListsNugget'.");
            TasklistAllListsNuggetJSON result = new TasklistAllListsNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTasklistAllListsNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((TasklistAllListsNuggetJSON )new_result);
          }
        protected void finish(TasklistAllListsNuggetJSON result)
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
            if (fieldGeneratorResult.have_value)
              {
                result.setResult(fieldGeneratorResult.value);
                fieldGeneratorResult.have_value = false;
              }
            else if ((!(result.hasResult())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Result\" field was missing.");
              }
            if (fieldGeneratorListMetas.have_value)
              {
                result.initListMetas();
                int count = fieldGeneratorListMetas.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendListMetas(fieldGeneratorListMetas.value[num]);
                  }
                fieldGeneratorListMetas.value.Clear();
                fieldGeneratorListMetas.have_value = false;
              }
            else if ((!(result.hasListMetas())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ListMetas\" field was missing.");
              }
            if (fieldGeneratorErrorType.have_value)
              {
                result.setErrorType(fieldGeneratorErrorType.value);
                fieldGeneratorErrorType.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(TasklistAllListsNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ction", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorAction;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "rrorType", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorErrorType;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "istMetas", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorListMetas;
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
            fieldGeneratorAction = new FieldHoldingGeneratorAction("field \"Action\" of the TasklistAllListsNugget class");
            fieldGeneratorResult = new TasklistAllListsResultJSON.HoldingGenerator("field \"Result\" of the TasklistAllListsNugget class", ignore_extras);
            fieldGeneratorListMetas = new TasklistListMetaJSON.HoldingArrayGenerator("field \"ListMetas\" of the TasklistAllListsNugget class", ignore_extras);
            fieldGeneratorErrorType = new TasklistErrorTypeJSON.HoldingGenerator("field \"ErrorType\" of the TasklistAllListsNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TasklistAllListsNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAction = new FieldHoldingGeneratorAction("field \"Action\" of the TasklistAllListsNugget class");
            fieldGeneratorResult = new TasklistAllListsResultJSON.HoldingGenerator("field \"Result\" of the TasklistAllListsNugget class", false);
            fieldGeneratorListMetas = new TasklistListMetaJSON.HoldingArrayGenerator("field \"ListMetas\" of the TasklistAllListsNugget class", false);
            fieldGeneratorErrorType = new TasklistErrorTypeJSON.HoldingGenerator("field \"ErrorType\" of the TasklistAllListsNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TasklistAllListsNugget class");
          }

        public override void reset()
          {
            fieldGeneratorAction.reset();
            fieldGeneratorResult.reset();
            fieldGeneratorListMetas.reset();
            fieldGeneratorErrorType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(TasklistAllListsNuggetJSON  result)
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
        public TasklistAllListsNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TasklistAllListsNuggetJSON  result)
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
    protected virtual void handle_result(List<TasklistAllListsNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TasklistAllListsNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TasklistAllListsNuggetJSON>();
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
    public List<TasklistAllListsNuggetJSON> value;
  };
  };
